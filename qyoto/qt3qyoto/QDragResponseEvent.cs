//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QDragResponseEvent")]
	public class QDragResponseEvent : QEvent, IDisposable {
 		protected QDragResponseEvent(Type dummy) : base((Type) null) {}
		interface IQDragResponseEventProxy {
		}

		protected void CreateQDragResponseEventProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDragResponseEvent), this);
			_interceptor = (QDragResponseEvent) realProxy.GetTransparentProxy();
		}
		private QDragResponseEvent ProxyQDragResponseEvent() {
			return (QDragResponseEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDragResponseEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDragResponseEventProxy), null);
			_staticInterceptor = (IQDragResponseEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQDragResponseEventProxy StaticQDragResponseEvent() {
			return (IQDragResponseEventProxy) _staticInterceptor;
		}

		public QDragResponseEvent(bool accepted) : this((Type) null) {
			CreateQDragResponseEventProxy();
			NewQDragResponseEvent(accepted);
		}
		[SmokeMethod("QDragResponseEvent(bool)")]
		private void NewQDragResponseEvent(bool accepted) {
			ProxyQDragResponseEvent().NewQDragResponseEvent(accepted);
		}
		[SmokeMethod("dragAccepted() const")]
		public bool DragAccepted() {
			return ProxyQDragResponseEvent().DragAccepted();
		}
		~QDragResponseEvent() {
			DisposeQDragResponseEvent();
		}
		public new void Dispose() {
			DisposeQDragResponseEvent();
		}
		private void DisposeQDragResponseEvent() {
			ProxyQDragResponseEvent().DisposeQDragResponseEvent();
		}
	}
}
