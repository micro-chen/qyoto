//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QMetaClassInfo")]
	public class QMetaClassInfo : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QMetaClassInfo(Type dummy) {}
		[SmokeClass("QMetaClassInfo")]
		interface IQMetaClassInfoProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMetaClassInfo), this);
			_interceptor = (QMetaClassInfo) realProxy.GetTransparentProxy();
		}
		private QMetaClassInfo ProxyQMetaClassInfo() {
			return (QMetaClassInfo) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMetaClassInfo() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMetaClassInfoProxy), null);
			_staticInterceptor = (IQMetaClassInfoProxy) realProxy.GetTransparentProxy();
		}
		private static IQMetaClassInfoProxy StaticQMetaClassInfo() {
			return (IQMetaClassInfoProxy) _staticInterceptor;
		}
		public QMetaClassInfo() : this((Type) null) {
			CreateProxy();
			NewQMetaClassInfo();
		}
		[SmokeMethod("QMetaClassInfo", "()", "")]
		private void NewQMetaClassInfo() {
			ProxyQMetaClassInfo().NewQMetaClassInfo();
		}
		[SmokeMethod("name", "() const", "")]
		public string Name() {
			return ProxyQMetaClassInfo().Name();
		}
		[SmokeMethod("value", "() const", "")]
		public string Value() {
			return ProxyQMetaClassInfo().Value();
		}
		~QMetaClassInfo() {
			DisposeQMetaClassInfo();
		}
		public void Dispose() {
			DisposeQMetaClassInfo();
		}
		[SmokeMethod("~QMetaClassInfo", "()", "")]
		private void DisposeQMetaClassInfo() {
			ProxyQMetaClassInfo().DisposeQMetaClassInfo();
		}
	}
}
