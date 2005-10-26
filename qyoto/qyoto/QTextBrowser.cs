//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	/// See <see cref="IQTextBrowserSignals"></see> for signals emitted by QTextBrowser
	public class QTextBrowser : QTextEdit, IDisposable {
 		protected QTextBrowser(Type dummy) : base((Type) null) {}
		interface IQTextBrowserProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected void CreateQTextBrowserProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextBrowser), this);
			_interceptor = (QTextBrowser) realProxy.GetTransparentProxy();
		}
		private QTextBrowser ProxyQTextBrowser() {
			return (QTextBrowser) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextBrowser() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextBrowserProxy), null);
			_staticInterceptor = (IQTextBrowserProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextBrowserProxy StaticQTextBrowser() {
			return (IQTextBrowserProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQTextBrowser().MetaObject();
		}
		// void* qt_metacast(const char* arg1); >>>> NOT CONVERTED
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QTextBrowser(QWidget parent) : this((Type) null) {
			CreateQTextBrowserProxy();
			NewQTextBrowser(parent);
		}
		private void NewQTextBrowser(QWidget parent) {
			ProxyQTextBrowser().NewQTextBrowser(parent);
		}
		public QTextBrowser() : this((Type) null) {
			CreateQTextBrowserProxy();
			NewQTextBrowser();
		}
		private void NewQTextBrowser() {
			ProxyQTextBrowser().NewQTextBrowser();
		}
		public IQUrl Source() {
			return ProxyQTextBrowser().Source();
		}
		public ArrayList SearchPaths() {
			return ProxyQTextBrowser().SearchPaths();
		}
		public void SetSearchPaths(string[] paths) {
			ProxyQTextBrowser().SetSearchPaths(paths);
		}
		public new virtual QVariant LoadResource(int type, IQUrl name) {
			return ProxyQTextBrowser().LoadResource(type,name);
		}
		public virtual void SetSource(IQUrl name) {
			ProxyQTextBrowser().SetSource(name);
		}
		public virtual void Backward() {
			ProxyQTextBrowser().Backward();
		}
		public virtual void Forward() {
			ProxyQTextBrowser().Forward();
		}
		public virtual void Home() {
			ProxyQTextBrowser().Home();
		}
		public virtual void Reload() {
			ProxyQTextBrowser().Reload();
		}
		public static new string Tr(string s, string c) {
			return StaticQTextBrowser().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQTextBrowser().Tr(s);
		}
		protected new virtual void KeyPressEvent(QKeyEvent ev) {
			ProxyQTextBrowser().KeyPressEvent(ev);
		}
		protected new virtual void MouseMoveEvent(QMouseEvent ev) {
			ProxyQTextBrowser().MouseMoveEvent(ev);
		}
		protected new virtual void MousePressEvent(QMouseEvent ev) {
			ProxyQTextBrowser().MousePressEvent(ev);
		}
		protected new virtual void MouseReleaseEvent(QMouseEvent ev) {
			ProxyQTextBrowser().MouseReleaseEvent(ev);
		}
		protected new virtual void FocusOutEvent(QFocusEvent ev) {
			ProxyQTextBrowser().FocusOutEvent(ev);
		}
		protected new virtual bool FocusNextPrevChild(bool next) {
			return ProxyQTextBrowser().FocusNextPrevChild(next);
		}
		protected new virtual void PaintEvent(QPaintEvent e) {
			ProxyQTextBrowser().PaintEvent(e);
		}
		~QTextBrowser() {
			ProxyQTextBrowser().Dispose();
		}
		public new void Dispose() {
			ProxyQTextBrowser().Dispose();
		}
	}

	public interface IQTextBrowserSignals {
		void BackwardAvailable(bool arg1);
		void ForwardAvailable(bool arg1);
		void SourceChanged(IQUrl arg1);
		void Highlighted(IQUrl arg1);
		void Highlighted(string arg1);
		void AnchorClicked(IQUrl arg1);
	}
}
