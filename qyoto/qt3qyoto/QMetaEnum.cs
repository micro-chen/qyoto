//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QMetaEnum : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QMetaEnum(Type dummy) {}
		interface IQMetaEnumProxy {
		}

		protected void CreateQMetaEnumProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMetaEnum), this);
			_interceptor = (QMetaEnum) realProxy.GetTransparentProxy();
		}
		private QMetaEnum ProxyQMetaEnum() {
			return (QMetaEnum) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMetaEnum() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMetaEnumProxy), null);
			_staticInterceptor = (IQMetaEnumProxy) realProxy.GetTransparentProxy();
		}
		private static IQMetaEnumProxy StaticQMetaEnum() {
			return (IQMetaEnumProxy) _staticInterceptor;
		}

		public QMetaEnum() : this((Type) null) {
			CreateQMetaEnumProxy();
			NewQMetaEnum();
		}
		private void NewQMetaEnum() {
			ProxyQMetaEnum().NewQMetaEnum();
		}
		~QMetaEnum() {
			ProxyQMetaEnum().Dispose();
		}
		public void Dispose() {
			ProxyQMetaEnum().Dispose();
		}
	}
}
