//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QMetaObject : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QMetaObject(Type dummy) {}
		interface IQMetaObjectProxy {
			bool CheckConnectArgs(string signal, string method);
			byte[] NormalizedSignature(string method);
			bool Connect(QObject sender, int signal_index, QObject receiver, int method_index, int type, out int types);
			bool Connect(QObject sender, int signal_index, QObject receiver, int method_index, int type);
			bool Connect(QObject sender, int signal_index, QObject receiver, int method_index);
			bool Disconnect(QObject sender, int signal_index, QObject receiver, int method_index);
			void ConnectSlotsByName(QObject o);
			bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9);
			bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8);
			bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7);
			bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6);
			bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5);
			bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4);
			bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3);
			bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2);
			bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1);
			bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0);
			bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0);
			bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret);
			bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9);
			bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8);
			bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7);
			bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6);
			bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5);
			bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4);
			bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3);
			bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2);
			bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1);
			bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0);
			bool InvokeMethod(QObject arg1, string member, int type);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1);
			bool InvokeMethod(QObject arg1, string member, QGenericArgument val0);
			bool InvokeMethod(QObject arg1, string member);
		}

		protected void CreateQMetaObjectProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMetaObject), this);
			_interceptor = (QMetaObject) realProxy.GetTransparentProxy();
		}
		private QMetaObject ProxyQMetaObject() {
			return (QMetaObject) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMetaObject() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMetaObjectProxy), null);
			_staticInterceptor = (IQMetaObjectProxy) realProxy.GetTransparentProxy();
		}
		private static IQMetaObjectProxy StaticQMetaObject() {
			return (IQMetaObjectProxy) _staticInterceptor;
		}

		enum Call {
			InvokeMetaMethod = 0,
			ReadProperty = 1,
			WriteProperty = 2,
			ResetProperty = 3,
			QueryPropertyDesignable = 4,
			QueryPropertyScriptable = 5,
			QueryPropertyStored = 6,
			QueryPropertyEditable = 7,
		}
		public string ClassName() {
			return ProxyQMetaObject().ClassName();
		}
		public QMetaObject SuperClass() {
			return ProxyQMetaObject().SuperClass();
		}
		public QObject Cast(QObject arg1) {
			return ProxyQMetaObject().Cast(arg1);
		}
		public string Tr(string s, string c) {
			return ProxyQMetaObject().Tr(s,c);
		}
		public string TrUtf8(string s, string c) {
			return ProxyQMetaObject().TrUtf8(s,c);
		}
		public int MethodOffset() {
			return ProxyQMetaObject().MethodOffset();
		}
		public int EnumeratorOffset() {
			return ProxyQMetaObject().EnumeratorOffset();
		}
		public int PropertyOffset() {
			return ProxyQMetaObject().PropertyOffset();
		}
		public int ClassInfoOffset() {
			return ProxyQMetaObject().ClassInfoOffset();
		}
		public int MethodCount() {
			return ProxyQMetaObject().MethodCount();
		}
		public int EnumeratorCount() {
			return ProxyQMetaObject().EnumeratorCount();
		}
		public int PropertyCount() {
			return ProxyQMetaObject().PropertyCount();
		}
		public int ClassInfoCount() {
			return ProxyQMetaObject().ClassInfoCount();
		}
		public int IndexOfMethod(string method) {
			return ProxyQMetaObject().IndexOfMethod(method);
		}
		public int IndexOfSignal(string signal) {
			return ProxyQMetaObject().IndexOfSignal(signal);
		}
		public int IndexOfSlot(string slot) {
			return ProxyQMetaObject().IndexOfSlot(slot);
		}
		public int IndexOfEnumerator(string name) {
			return ProxyQMetaObject().IndexOfEnumerator(name);
		}
		public int IndexOfProperty(string name) {
			return ProxyQMetaObject().IndexOfProperty(name);
		}
		public int IndexOfClassInfo(string name) {
			return ProxyQMetaObject().IndexOfClassInfo(name);
		}
		public QMetaMethod Method(int index) {
			return ProxyQMetaObject().Method(index);
		}
		public QMetaEnum Enumerator(int index) {
			return ProxyQMetaObject().Enumerator(index);
		}
		public QMetaProperty Property(int index) {
			return ProxyQMetaObject().Property(index);
		}
		public QMetaClassInfo ClassInfo(int index) {
			return ProxyQMetaObject().ClassInfo(index);
		}
		public static bool CheckConnectArgs(string signal, string method) {
			return StaticQMetaObject().CheckConnectArgs(signal,method);
		}
		public static byte[] NormalizedSignature(string method) {
			return StaticQMetaObject().NormalizedSignature(method);
		}
		public static bool Connect(QObject sender, int signal_index, QObject receiver, int method_index, int type, out int types) {
			return StaticQMetaObject().Connect(sender,signal_index,receiver,method_index,type,out types);
		}
		public static bool Connect(QObject sender, int signal_index, QObject receiver, int method_index, int type) {
			return StaticQMetaObject().Connect(sender,signal_index,receiver,method_index,type);
		}
		public static bool Connect(QObject sender, int signal_index, QObject receiver, int method_index) {
			return StaticQMetaObject().Connect(sender,signal_index,receiver,method_index);
		}
		public static bool Disconnect(QObject sender, int signal_index, QObject receiver, int method_index) {
			return StaticQMetaObject().Disconnect(sender,signal_index,receiver,method_index);
		}
		public static void ConnectSlotsByName(QObject o) {
			StaticQMetaObject().ConnectSlotsByName(o);
		}
		// void activate(QObject* arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		// void activate(QObject* arg1,const QMetaObject* arg2,int arg3,void** arg4); >>>> NOT CONVERTED
		// void addGuard(QObject** arg1); >>>> NOT CONVERTED
		// void removeGuard(QObject** arg1); >>>> NOT CONVERTED
		// void changeGuard(QObject** arg1,QObject* arg2); >>>> NOT CONVERTED
		public static bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1,val2,val3,val4,val5,val6,val7,val8,val9);
		}
		public static bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1,val2,val3,val4,val5,val6,val7,val8);
		}
		public static bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1,val2,val3,val4,val5,val6,val7);
		}
		public static bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1,val2,val3,val4,val5,val6);
		}
		public static bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1,val2,val3,val4,val5);
		}
		public static bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1,val2,val3,val4);
		}
		public static bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1,val2,val3);
		}
		public static bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1,val2);
		}
		public static bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0,val1);
		}
		public static bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret, QGenericArgument val0) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret,val0);
		}
		public static bool InvokeMethod(QObject arg1, string member, int arg3, QGenericReturnArgument ret) {
			return StaticQMetaObject().InvokeMethod(arg1,member,arg3,ret);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1,val2,val3,val4,val5,val6,val7,val8,val9);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1,val2,val3,val4,val5,val6,val7,val8);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1,val2,val3,val4,val5,val6,val7);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1,val2,val3,val4,val5,val6);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1,val2,val3,val4,val5);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1,val2,val3,val4);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1,val2,val3);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1,val2);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0, QGenericArgument val1) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0,val1);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret, QGenericArgument val0) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret,val0);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericReturnArgument ret) {
			return StaticQMetaObject().InvokeMethod(arg1,member,ret);
		}
		public static bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1,val2,val3,val4,val5,val6,val7,val8,val9);
		}
		public static bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1,val2,val3,val4,val5,val6,val7,val8);
		}
		public static bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1,val2,val3,val4,val5,val6,val7);
		}
		public static bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1,val2,val3,val4,val5,val6);
		}
		public static bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1,val2,val3,val4,val5);
		}
		public static bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1,val2,val3,val4);
		}
		public static bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1,val2,val3);
		}
		public static bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1,val2);
		}
		public static bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0, QGenericArgument val1) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0,val1);
		}
		public static bool InvokeMethod(QObject arg1, string member, int type, QGenericArgument val0) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type,val0);
		}
		public static bool InvokeMethod(QObject arg1, string member, int type) {
			return StaticQMetaObject().InvokeMethod(arg1,member,type);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8, QGenericArgument val9) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1,val2,val3,val4,val5,val6,val7,val8,val9);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7, QGenericArgument val8) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1,val2,val3,val4,val5,val6,val7,val8);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6, QGenericArgument val7) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1,val2,val3,val4,val5,val6,val7);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5, QGenericArgument val6) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1,val2,val3,val4,val5,val6);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4, QGenericArgument val5) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1,val2,val3,val4,val5);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3, QGenericArgument val4) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1,val2,val3,val4);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2, QGenericArgument val3) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1,val2,val3);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1, QGenericArgument val2) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1,val2);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0, QGenericArgument val1) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0,val1);
		}
		public static bool InvokeMethod(QObject arg1, string member, QGenericArgument val0) {
			return StaticQMetaObject().InvokeMethod(arg1,member,val0);
		}
		public static bool InvokeMethod(QObject arg1, string member) {
			return StaticQMetaObject().InvokeMethod(arg1,member);
		}
	}
}
