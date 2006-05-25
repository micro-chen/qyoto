//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QMetaType")]
	public class QMetaType : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QMetaType(Type dummy) {}
		interface IQMetaTypeProxy {
			int type(string typeName);
			string TypeName(int type);
			bool IsRegistered(int type);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMetaType), this);
			_interceptor = (QMetaType) realProxy.GetTransparentProxy();
		}
		private QMetaType ProxyQMetaType() {
			return (QMetaType) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMetaType() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMetaTypeProxy), null);
			_staticInterceptor = (IQMetaTypeProxy) realProxy.GetTransparentProxy();
		}
		private static IQMetaTypeProxy StaticQMetaType() {
			return (IQMetaTypeProxy) _staticInterceptor;
		}

		public enum E_Type {
			Void = 0,
			Bool = 1,
			Int = 2,
			UInt = 3,
			Double = 6,
			QChar = 7,
			QString = 10,
			QByteArray = 12,
			VoidStar = 128,
			Long = 129,
			Short = 130,
			Char = 131,
			ULong = 132,
			UShort = 133,
			UChar = 134,
			Float = 135,
			QObjectStar = 136,
			QWidgetStar = 137,
			User = 256,
		}
		public QMetaType() : this((Type) null) {
			CreateProxy();
			NewQMetaType();
		}
		[SmokeMethod("QMetaType()")]
		private void NewQMetaType() {
			ProxyQMetaType().NewQMetaType();
		}
		// void registerStreamOperators(const char* arg1,SaveOperator arg2,LoadOperator arg3); >>>> NOT CONVERTED
		// int registerType(const char* arg1,Destructor arg2,Constructor arg3); >>>> NOT CONVERTED
		[SmokeMethod("type(const char*)")]
		public static int type(string typeName) {
			return StaticQMetaType().type(typeName);
		}
		[SmokeMethod("typeName(int)")]
		public static string TypeName(int type) {
			return StaticQMetaType().TypeName(type);
		}
		[SmokeMethod("isRegistered(int)")]
		public static bool IsRegistered(int type) {
			return StaticQMetaType().IsRegistered(type);
		}
		// void* construct(int arg1,const void* arg2); >>>> NOT CONVERTED
		// void destroy(int arg1,void* arg2); >>>> NOT CONVERTED
		// bool save(QDataStream& arg1,int arg2,const void* arg3); >>>> NOT CONVERTED
		// bool load(QDataStream& arg1,int arg2,void* arg3); >>>> NOT CONVERTED
		~QMetaType() {
			DisposeQMetaType();
		}
		public void Dispose() {
			DisposeQMetaType();
		}
		private void DisposeQMetaType() {
			ProxyQMetaType().DisposeQMetaType();
		}
	}
}
