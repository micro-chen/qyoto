//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QDragLeaveEvent")]
	public class QDragLeaveEvent : QEvent, IDisposable {
 		protected QDragLeaveEvent(Type dummy) : base((Type) null) {}
		interface IQDragLeaveEventProxy {
		}

		protected void CreateQDragLeaveEventProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDragLeaveEvent), this);
			_interceptor = (QDragLeaveEvent) realProxy.GetTransparentProxy();
		}
		private QDragLeaveEvent ProxyQDragLeaveEvent() {
			return (QDragLeaveEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDragLeaveEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDragLeaveEventProxy), null);
			_staticInterceptor = (IQDragLeaveEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQDragLeaveEventProxy StaticQDragLeaveEvent() {
			return (IQDragLeaveEventProxy) _staticInterceptor;
		}

		public QDragLeaveEvent() : this((Type) null) {
			CreateQDragLeaveEventProxy();
			NewQDragLeaveEvent();
		}
		[SmokeMethod("QDragLeaveEvent()")]
		private void NewQDragLeaveEvent() {
			ProxyQDragLeaveEvent().NewQDragLeaveEvent();
		}
		~QDragLeaveEvent() {
			DisposeQDragLeaveEvent();
		}
		public new void Dispose() {
			DisposeQDragLeaveEvent();
		}
		private void DisposeQDragLeaveEvent() {
			ProxyQDragLeaveEvent().DisposeQDragLeaveEvent();
		}
	}
}
