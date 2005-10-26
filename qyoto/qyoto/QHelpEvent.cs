//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QHelpEvent : QEvent, IDisposable {
 		protected QHelpEvent(Type dummy) : base((Type) null) {}
		interface IQHelpEventProxy {
		}

		protected void CreateQHelpEventProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QHelpEvent), this);
			_interceptor = (QHelpEvent) realProxy.GetTransparentProxy();
		}
		private QHelpEvent ProxyQHelpEvent() {
			return (QHelpEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QHelpEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQHelpEventProxy), null);
			_staticInterceptor = (IQHelpEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQHelpEventProxy StaticQHelpEvent() {
			return (IQHelpEventProxy) _staticInterceptor;
		}

		public QHelpEvent(int type, QPoint pos, QPoint globalPos) : this((Type) null) {
			CreateQHelpEventProxy();
			NewQHelpEvent(type,pos,globalPos);
		}
		private void NewQHelpEvent(int type, QPoint pos, QPoint globalPos) {
			ProxyQHelpEvent().NewQHelpEvent(type,pos,globalPos);
		}
		public int X() {
			return ProxyQHelpEvent().X();
		}
		public int Y() {
			return ProxyQHelpEvent().Y();
		}
		public int GlobalX() {
			return ProxyQHelpEvent().GlobalX();
		}
		public int GlobalY() {
			return ProxyQHelpEvent().GlobalY();
		}
		public QPoint Pos() {
			return ProxyQHelpEvent().Pos();
		}
		public QPoint GlobalPos() {
			return ProxyQHelpEvent().GlobalPos();
		}
		~QHelpEvent() {
			ProxyQHelpEvent().Dispose();
		}
		public new void Dispose() {
			ProxyQHelpEvent().Dispose();
		}
	}
}
