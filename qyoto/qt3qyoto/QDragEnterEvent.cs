//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QDragEnterEvent : QDragMoveEvent, IDisposable {
 		protected QDragEnterEvent(Type dummy) : base((Type) null) {}
		interface IQDragEnterEventProxy {
		}

		protected void CreateQDragEnterEventProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDragEnterEvent), this);
			_interceptor = (QDragEnterEvent) realProxy.GetTransparentProxy();
		}
		private QDragEnterEvent ProxyQDragEnterEvent() {
			return (QDragEnterEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDragEnterEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDragEnterEventProxy), null);
			_staticInterceptor = (IQDragEnterEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQDragEnterEventProxy StaticQDragEnterEvent() {
			return (IQDragEnterEventProxy) _staticInterceptor;
		}

		public QDragEnterEvent(QPoint pos) : this((Type) null) {
			CreateQDragEnterEventProxy();
			NewQDragEnterEvent(pos);
		}
		private void NewQDragEnterEvent(QPoint pos) {
			ProxyQDragEnterEvent().NewQDragEnterEvent(pos);
		}
		~QDragEnterEvent() {
			ProxyQDragEnterEvent().Dispose();
		}
		public new void Dispose() {
			ProxyQDragEnterEvent().Dispose();
		}
	}
}
