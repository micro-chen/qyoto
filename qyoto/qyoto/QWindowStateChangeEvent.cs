//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QWindowStateChangeEvent : QEvent, IDisposable {
 		protected QWindowStateChangeEvent(Type dummy) : base((Type) null) {}
		interface IQWindowStateChangeEventProxy {
		}

		protected void CreateQWindowStateChangeEventProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QWindowStateChangeEvent), this);
			_interceptor = (QWindowStateChangeEvent) realProxy.GetTransparentProxy();
		}
		private QWindowStateChangeEvent ProxyQWindowStateChangeEvent() {
			return (QWindowStateChangeEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QWindowStateChangeEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQWindowStateChangeEventProxy), null);
			_staticInterceptor = (IQWindowStateChangeEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQWindowStateChangeEventProxy StaticQWindowStateChangeEvent() {
			return (IQWindowStateChangeEventProxy) _staticInterceptor;
		}

		public QWindowStateChangeEvent(int aOldState) : this((Type) null) {
			CreateQWindowStateChangeEventProxy();
			NewQWindowStateChangeEvent(aOldState);
		}
		private void NewQWindowStateChangeEvent(int aOldState) {
			ProxyQWindowStateChangeEvent().NewQWindowStateChangeEvent(aOldState);
		}
		public int OldState() {
			return ProxyQWindowStateChangeEvent().OldState();
		}
		~QWindowStateChangeEvent() {
			ProxyQWindowStateChangeEvent().Dispose();
		}
		public new void Dispose() {
			ProxyQWindowStateChangeEvent().Dispose();
		}
	}
}
