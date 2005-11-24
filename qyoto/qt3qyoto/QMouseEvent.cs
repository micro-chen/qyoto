//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QMouseEvent : QEvent, IDisposable {
 		protected QMouseEvent(Type dummy) : base((Type) null) {}
		interface IQMouseEventProxy {
		}

		protected void CreateQMouseEventProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMouseEvent), this);
			_interceptor = (QMouseEvent) realProxy.GetTransparentProxy();
		}
		private QMouseEvent ProxyQMouseEvent() {
			return (QMouseEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMouseEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMouseEventProxy), null);
			_staticInterceptor = (IQMouseEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQMouseEventProxy StaticQMouseEvent() {
			return (IQMouseEventProxy) _staticInterceptor;
		}

		public QMouseEvent(int type, QPoint pos, int button, int state) : this((Type) null) {
			CreateQMouseEventProxy();
			NewQMouseEvent(type,pos,button,state);
		}
		private void NewQMouseEvent(int type, QPoint pos, int button, int state) {
			ProxyQMouseEvent().NewQMouseEvent(type,pos,button,state);
		}
		public QMouseEvent(int type, QPoint pos, QPoint globalPos, int button, int state) : this((Type) null) {
			CreateQMouseEventProxy();
			NewQMouseEvent(type,pos,globalPos,button,state);
		}
		private void NewQMouseEvent(int type, QPoint pos, QPoint globalPos, int button, int state) {
			ProxyQMouseEvent().NewQMouseEvent(type,pos,globalPos,button,state);
		}
		public QPoint Pos() {
			return ProxyQMouseEvent().Pos();
		}
		public QPoint GlobalPos() {
			return ProxyQMouseEvent().GlobalPos();
		}
		public int X() {
			return ProxyQMouseEvent().X();
		}
		public int Y() {
			return ProxyQMouseEvent().Y();
		}
		public int GlobalX() {
			return ProxyQMouseEvent().GlobalX();
		}
		public int GlobalY() {
			return ProxyQMouseEvent().GlobalY();
		}
		public int Button() {
			return ProxyQMouseEvent().Button();
		}
		public int State() {
			return ProxyQMouseEvent().State();
		}
		public int StateAfter() {
			return ProxyQMouseEvent().StateAfter();
		}
		public bool IsAccepted() {
			return ProxyQMouseEvent().IsAccepted();
		}
		public void Accept() {
			ProxyQMouseEvent().Accept();
		}
		public void Ignore() {
			ProxyQMouseEvent().Ignore();
		}
		~QMouseEvent() {
			ProxyQMouseEvent().Dispose();
		}
		public new void Dispose() {
			ProxyQMouseEvent().Dispose();
		}
	}
}
