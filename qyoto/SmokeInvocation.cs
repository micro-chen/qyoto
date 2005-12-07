/***************************************************************************
                          SmokeInvocation.cs  -  description
                             -------------------
    begin                : Wed Jun 16 2004
    copyright            : (C) 2004 by Richard Dale
    email                : Richard_Dale@tipitina.demon.co.uk
 ***************************************************************************/

/***************************************************************************
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU General Public License as published by  *
 *   the Free Software Foundation; either version 2 of the License, or     *
 *   (at your option) any later version.                                   *
 *                                                                         *
 ***************************************************************************/

namespace Qt {

	using Qt;
	
	using System;
	using System.Collections;
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Reflection;
	using System.Runtime.Remoting.Proxies;
	using System.Runtime.Remoting.Messaging;
	using System.Runtime.Remoting;
	using System.Runtime.InteropServices;

	[StructLayout(LayoutKind.Explicit)]
	unsafe public struct StackItem {
		[FieldOffset(0)] public void * s_voidp;
		[FieldOffset(0)] public bool s_bool;
		[FieldOffset(0)] public sbyte s_char;
		[FieldOffset(0)] public byte s_uchar;
		[FieldOffset(0)] public short s_short;
		[FieldOffset(0)] public ushort s_ushort;
		[FieldOffset(0)] public int s_int;
		[FieldOffset(0)] public uint s_uint;
		[FieldOffset(0)] public long s_long;
		[FieldOffset(0)] public ulong s_ulong;
		[FieldOffset(0)] public float s_float;
		[FieldOffset(0)] public double s_double;
        [FieldOffset(0)] public long s_enum;
		[FieldOffset(0)] public void * s_class;
		[FieldOffset(0)] public IntPtr s_intptr;
	}
	
	public class SmokeInvocation : RealProxy {
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern int FindMethodId(string className, string methodName);
			
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern int MethodFromMap(int methodId);
			
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern int FindAmbiguousMethodId(int ambigousId);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern void CallMethod(int methodId, IntPtr target, IntPtr sp, int items);
		
		delegate IntPtr GetIntPtr(IntPtr instance);
		delegate void SetIntPtr(IntPtr instance, IntPtr ptr);
		delegate void RemoveIntPtr(IntPtr ptr);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern IntPtr StringArrayToCharStarStar(int length, string[] strArray);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern IntPtr StringToQString(string str);

		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern void AddGetSmokeObject(GetIntPtr callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern void AddSetSmokeObject(SetIntPtr callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern void AddMapPointer(SetIntPtr callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern void AddUnmapPointer(RemoveIntPtr callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern void AddGetPointerObject(GetIntPtr callback);

		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern void AddIntPtrToCharStarStar(GetIntPtr callback);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern void AddIntPtrToQString(GetIntPtr callback);
		
		static IntPtr GetSmokeObject(IntPtr instancePtr) {
			Object instance = ((GCHandle) instancePtr).Target;
			if (instance == null) {
				return (IntPtr) 0;
			}
			FieldInfo fieldInfo = instance.GetType().GetField(	"_smokeObject", 
															BindingFlags.NonPublic 
															| BindingFlags.GetField
															| BindingFlags.Instance );
			return (IntPtr) fieldInfo.GetValue(instance);
		}
		
		static void SetSmokeObject(IntPtr instancePtr, IntPtr smokeObjectPtr) {
			Object instance = ((GCHandle) instancePtr).Target;
			if (instance == null) {
				return;
			}
			FieldInfo fieldInfo = instance.GetType().GetField(	"_smokeObject", 
															BindingFlags.NonPublic 
															| BindingFlags.GetField
															| BindingFlags.Instance );
			fieldInfo.SetValue(instance, smokeObjectPtr);
			return;
		}

		static void MapPointer(IntPtr ptr, IntPtr instancePtr) {
			Object instance = ((GCHandle) instancePtr).Target;
			WeakReference weakRef = new WeakReference(instance);
			pointerMap[ptr] = weakRef;
		}
		
		static void UnmapPointer(IntPtr ptr) {
			pointerMap.Remove(ptr);
		}
		
		static IntPtr GetPointerObject(IntPtr ptr) {
			Console.WriteLine("ENTER GetPointerObject() ptr: {0}", ptr);
			if (pointerMap[ptr] == null) {
				Console.WriteLine("GetPointerObject() pointerMap[ptr] == null");
				return (IntPtr) 0;
			}

			WeakReference weakRef = (WeakReference) pointerMap[ptr];
			if (weakRef == null) {
				Console.WriteLine("GetPointerObject() weakRef zero");
				return (IntPtr) 0;
			} else if (weakRef.IsAlive) {
				Console.WriteLine("GetPointerObject() weakRef.IsAlive");
				GCHandle instanceHandle = GCHandle.Alloc(weakRef.Target);
				return (IntPtr) instanceHandle;
			} else {
				Console.WriteLine("GetPointerObject() weakRef dead");
				return (IntPtr) 0;
			}
		}
		
		static IntPtr IntPtrToCharStarStar(IntPtr ptr) {
			string[] temp = (string[]) ((GCHandle) ptr).Target;
			Console.WriteLine("IntPtrToCharStarStar() string[0]: {0}", temp[0]);
			return StringArrayToCharStarStar(temp.Length, temp);
		}

		static IntPtr IntPtrToQString(IntPtr ptr) {
			string temp = (string) ((GCHandle) ptr).Target;
			Console.WriteLine("IntPtrToQString() string: {0}", temp);
			return StringToQString(temp);
		}

		static private Hashtable pointerMap = new Hashtable();
		static private GetIntPtr getSmokeObject = new GetIntPtr(GetSmokeObject);
		static private SetIntPtr setSmokeObject = new SetIntPtr(SetSmokeObject);
		
		static private SetIntPtr mapPointer = new SetIntPtr(MapPointer);
		static private RemoveIntPtr unmapPointer = new RemoveIntPtr(UnmapPointer);
		static private GetIntPtr getPointerObject = new GetIntPtr(GetPointerObject);
		
		static private GetIntPtr intPtrToCharStarStar = new GetIntPtr(IntPtrToCharStarStar);
		static private GetIntPtr intPtrToQString = new GetIntPtr(IntPtrToQString);
		
		static SmokeInvocation() {
			AddGetSmokeObject(getSmokeObject);
			AddSetSmokeObject(setSmokeObject);
			
			AddMapPointer(mapPointer);
			AddUnmapPointer(unmapPointer);
			AddGetPointerObject(getPointerObject);

			AddIntPtrToCharStarStar(intPtrToCharStarStar);
			AddIntPtrToQString(intPtrToQString);
		}
		
		private Type	_classToProxy;
		private Object	_instance;
		private string	_className;
		
		public SmokeInvocation(Type classToProxy, Object instance) : base(classToProxy) 
		{
			_classToProxy = classToProxy;
			_instance = instance;
			_className = Regex.Replace(_classToProxy.ToString(), @"^[^\.]*.([^+]*).*", "$1");
		}

		public ArrayList FindMethod(string name) {
			ArrayList result = new ArrayList();
			
			Console.WriteLine("FindMethod() className: {0} MethodName: {1}", _className, name);
			int meth = FindMethodId(_className, name);
			if (meth == 0) {
				meth = FindMethodId("QGlobalSpace", name);
			}
			
			if (meth == 0) {
				return result;
			} else if (meth > 0) {
				int i = MethodFromMap(meth);
				Console.WriteLine("FindMethod() MethodName: {0} result: {1}", name, i);
				if (i == 0) {		// shouldn't happen
					;
				} else if (i > 0) {	// single match
					result.Add(i);
					Console.WriteLine("FindMethod() single match {0}", i);
				} else {		// multiple match
					i = -i;		// turn into ambiguousMethodList index
					int	methodId;
					while ((methodId = FindAmbiguousMethodId(i)) != 0) {
						if (methodId > 0) {
							result.Add(methodId);
						}
						i++;
					}
					Console.WriteLine("FindMethod() multiple match {0}", result[0]);
				}
			}
			return result;
		}
		
		public override IMessage Invoke(IMessage message) {
			ArrayList	methods = null;
			
			IMethodCallMessage callMessage = (IMethodCallMessage) message;
			Console.WriteLine(	"Invoke() MethodName: {0} Type: {1} ArgCount: {2}", 
								callMessage.MethodName, 
								callMessage.TypeName, 
								callMessage.ArgCount.ToString() );
			
			StackItem[] stack = new StackItem[callMessage.ArgCount+1];
			
			string mungedName = callMessage.MethodName;
			mungedName = char.ToLower(mungedName[0]) + mungedName.Substring(1, mungedName.Length-1);
			mungedName = Regex.Replace(mungedName, @"^new", "");

			if (callMessage.MethodSignature != null) {
				Type[] types = (Type[]) callMessage.MethodSignature;
				for (int i = 0; i < callMessage.ArgCount; i++) {
					if (	types[i].IsArray
							|| types[i] == typeof(System.Collections.ArrayList) ) 
					{
						mungedName += "?";
					} else if (	types[i].IsPrimitive 
								|| types[i] == typeof(System.String) 
								|| types[i] == typeof(System.Text.StringBuilder) ) 
					{
						mungedName += "$";
					} else {
						mungedName += "#";
					}
				}

				methods = FindMethod(mungedName);

				for (int i = 0; i < callMessage.ArgCount; i++) {
					if (callMessage.Args[i] == null) {
						unsafe {
							stack[i+1].s_intptr = (IntPtr) 0;
						}
					} else if (types[i] == typeof(bool)) {
						stack[i+1].s_bool = (bool) callMessage.Args[i];
					} else if (types[i] == typeof(sbyte)) {
						stack[i+1].s_char = (sbyte) callMessage.Args[i];
					} else if (types[i] == typeof(byte)) {
						stack[i+1].s_uchar = (byte) callMessage.Args[i];
					} else if (types[i] == typeof(short)) {
						stack[i+1].s_short = (short) callMessage.Args[i];
					} else if (types[i] == typeof(ushort)) {
						stack[i+1].s_ushort = (ushort) callMessage.Args[i];
					} else if (types[i] == typeof(int)) {
						stack[i+1].s_int = (int) callMessage.Args[i];
					} else if (types[i] == typeof(uint)) {
						stack[i+1].s_uint = (uint) callMessage.Args[i];
					} else if (types[i] == typeof(long)) {
						stack[i+1].s_long = (long) callMessage.Args[i];
					} else if (types[i] == typeof(ulong)) {
						stack[i+1].s_ulong = (ulong) callMessage.Args[i];
					} else if (types[i] == typeof(float)) {
						stack[i+1].s_float = (float) callMessage.Args[i];
					} else if (types[i] == typeof(double)) {
						stack[i+1].s_double = (double) callMessage.Args[i];
					} else {
						stack[i+1].s_intptr = (IntPtr) GCHandle.Alloc(callMessage.Args[i]);
//					} else if (types[i] == typeof(string[])) {
//						unsafe {
//							stack[i+1].s_voidp = (void *) StringArrayToCharStarStar((string[]) callMessage.Args[i]);
//						}
					}
					if (callMessage.Args[i] == null) {
						Console.WriteLine(	"\tArgName: {0} Arg: null", 
											callMessage.GetArgName(i) );
					} else {
						Console.WriteLine(	"\tArgName: {0} Arg: {1} Type: {2}", 
											callMessage.GetArgName(i),
											callMessage.GetArg(i),
											callMessage.Args[i].GetType() );
					}
				}
			}
			
			GCHandle instanceHandle = GCHandle.Alloc(_instance);
			
			unsafe {
				fixed(StackItem * stackPtr = stack) {
					CallMethod((int) methods[0], (IntPtr) instanceHandle, (IntPtr) stackPtr, callMessage.ArgCount);
					Console.WriteLine("returned from CallMethod");
//					Console.WriteLine("result {0}", stack[0].s_int);
				}
			}
			
			instanceHandle.Free();
			
			if (_instance != null) {
//				Console.WriteLine(	"instance: {0} returned: {1}", 
//									_instance.GetType().ToString(), 
//									returnedInstance.GetType().ToString(),
//									stackItem[1].s_int );
			}
			
			IMethodReturnMessage returnMessage = (IMethodReturnMessage) message;
			
			/*
			if (returnMessage.MethodName.Equals("PointSize")) {
				MethodReturnMessageWrapper returnValue = new MethodReturnMessageWrapper((IMethodReturnMessage) returnMessage); 
				returnValue.ReturnValue = 17;
				returnMessage = returnValue;
			}
			*/

			MethodReturnMessageWrapper returnValue = new MethodReturnMessageWrapper((IMethodReturnMessage) returnMessage); 
			returnValue.ReturnValue = null;
			returnMessage = returnValue;

			return returnMessage;
		}
		
		public override int GetHashCode() {
			return _instance.GetHashCode();
		}
	}
}

