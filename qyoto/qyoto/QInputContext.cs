//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QInputContext : QObject {
 		protected QInputContext(Type dummy) : base((Type) null) {}
		interface IQInputContextProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected void CreateQInputContextProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QInputContext), this);
			_interceptor = (QInputContext) realProxy.GetTransparentProxy();
		}
		private QInputContext ProxyQInputContext() {
			return (QInputContext) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QInputContext() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQInputContextProxy), null);
			_staticInterceptor = (IQInputContextProxy) realProxy.GetTransparentProxy();
		}
		private static IQInputContextProxy StaticQInputContext() {
			return (IQInputContextProxy) _staticInterceptor;
		}

		enum E_StandardFormat {
			PreeditFormat = 0,
			SelectionFormat = 1,
		}
		public new virtual QMetaObject MetaObject() {
			return ProxyQInputContext().MetaObject();
		}
		// void* qt_metacast(const char* arg1); >>>> NOT CONVERTED
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public virtual string IdentifierName() {
			return ProxyQInputContext().IdentifierName();
		}
		public virtual string Language() {
			return ProxyQInputContext().Language();
		}
		public virtual void Reset() {
			ProxyQInputContext().Reset();
		}
		public virtual void Update() {
			ProxyQInputContext().Update();
		}
		public virtual void MouseHandler(int x, QMouseEvent arg2) {
			ProxyQInputContext().MouseHandler(x,arg2);
		}
		public virtual QFont Font() {
			return ProxyQInputContext().Font();
		}
		public virtual bool IsComposing() {
			return ProxyQInputContext().IsComposing();
		}
		public QWidget FocusWidget() {
			return ProxyQInputContext().FocusWidget();
		}
		public virtual void SetFocusWidget(QWidget w) {
			ProxyQInputContext().SetFocusWidget(w);
		}
		public virtual void WidgetDestroyed(QWidget w) {
			ProxyQInputContext().WidgetDestroyed(w);
		}
		// QList<QAction*> actions(); >>>> NOT CONVERTED
		public virtual bool FilterEvent(QEvent arg1) {
			return ProxyQInputContext().FilterEvent(arg1);
		}
		public void SendEvent(QInputMethodEvent arg1) {
			ProxyQInputContext().SendEvent(arg1);
		}
		// QTextFormat standardFormat(QInputContext::StandardFormat arg1); >>>> NOT CONVERTED
		public static new string Tr(string s, string c) {
			return StaticQInputContext().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQInputContext().Tr(s);
		}
	}
}
