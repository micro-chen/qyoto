//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QDropEvent : QEvent, IQMimeSource, IDisposable {
 		protected QDropEvent(Type dummy) : base((Type) null) {}
		interface IQDropEventProxy {
		}

		protected void CreateQDropEventProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDropEvent), this);
			_interceptor = (QDropEvent) realProxy.GetTransparentProxy();
		}
		private QDropEvent ProxyQDropEvent() {
			return (QDropEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDropEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDropEventProxy), null);
			_staticInterceptor = (IQDropEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQDropEventProxy StaticQDropEvent() {
			return (IQDropEventProxy) _staticInterceptor;
		}

		public QDropEvent(QPoint pos, int actions, QMimeData data, int buttons, int modifiers, int type) : this((Type) null) {
			CreateQDropEventProxy();
			NewQDropEvent(pos,actions,data,buttons,modifiers,type);
		}
		private void NewQDropEvent(QPoint pos, int actions, QMimeData data, int buttons, int modifiers, int type) {
			ProxyQDropEvent().NewQDropEvent(pos,actions,data,buttons,modifiers,type);
		}
		public QDropEvent(QPoint pos, int actions, QMimeData data, int buttons, int modifiers) : this((Type) null) {
			CreateQDropEventProxy();
			NewQDropEvent(pos,actions,data,buttons,modifiers);
		}
		private void NewQDropEvent(QPoint pos, int actions, QMimeData data, int buttons, int modifiers) {
			ProxyQDropEvent().NewQDropEvent(pos,actions,data,buttons,modifiers);
		}
		public QPoint Pos() {
			return ProxyQDropEvent().Pos();
		}
		public int MouseButtons() {
			return ProxyQDropEvent().MouseButtons();
		}
		public int KeyboardModifiers() {
			return ProxyQDropEvent().KeyboardModifiers();
		}
		public int PossibleActions() {
			return ProxyQDropEvent().PossibleActions();
		}
		public int ProposedAction() {
			return ProxyQDropEvent().ProposedAction();
		}
		public void AcceptProposedAction() {
			ProxyQDropEvent().AcceptProposedAction();
		}
		public int DropAction() {
			return ProxyQDropEvent().DropAction();
		}
		public void SetDropAction(int action) {
			ProxyQDropEvent().SetDropAction(action);
		}
		public QWidget Source() {
			return ProxyQDropEvent().Source();
		}
		public QMimeData MimeData() {
			return ProxyQDropEvent().MimeData();
		}
		public string Format(int n) {
			return ProxyQDropEvent().Format(n);
		}
		public string Format() {
			return ProxyQDropEvent().Format();
		}
		public byte[] EncodedData(string arg1) {
			return ProxyQDropEvent().EncodedData(arg1);
		}
		public bool Provides(string arg1) {
			return ProxyQDropEvent().Provides(arg1);
		}
		~QDropEvent() {
			ProxyQDropEvent().Dispose();
		}
		public new void Dispose() {
			ProxyQDropEvent().Dispose();
		}
	}
}
