//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QPaintEvent : QEvent, IDisposable {
 		protected QPaintEvent(Type dummy) : base((Type) null) {}
		interface IQPaintEventProxy {
		}

		protected void CreateQPaintEventProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPaintEvent), this);
			_interceptor = (QPaintEvent) realProxy.GetTransparentProxy();
		}
		private QPaintEvent ProxyQPaintEvent() {
			return (QPaintEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPaintEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPaintEventProxy), null);
			_staticInterceptor = (IQPaintEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQPaintEventProxy StaticQPaintEvent() {
			return (IQPaintEventProxy) _staticInterceptor;
		}

		public QPaintEvent(QRegion paintRegion) : this((Type) null) {
			CreateQPaintEventProxy();
			NewQPaintEvent(paintRegion);
		}
		private void NewQPaintEvent(QRegion paintRegion) {
			ProxyQPaintEvent().NewQPaintEvent(paintRegion);
		}
		public QPaintEvent(QRect paintRect) : this((Type) null) {
			CreateQPaintEventProxy();
			NewQPaintEvent(paintRect);
		}
		private void NewQPaintEvent(QRect paintRect) {
			ProxyQPaintEvent().NewQPaintEvent(paintRect);
		}
		public QRect Rect() {
			return ProxyQPaintEvent().Rect();
		}
		public QRegion Region() {
			return ProxyQPaintEvent().Region();
		}
		~QPaintEvent() {
			ProxyQPaintEvent().Dispose();
		}
		public new void Dispose() {
			ProxyQPaintEvent().Dispose();
		}
	}
}
