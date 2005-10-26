//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQStatusBarSignals"></see> for signals emitted by QStatusBar
	public class QStatusBar : QWidget, IDisposable {
 		protected QStatusBar(Type dummy) : base((Type) null) {}
		interface IQStatusBarProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected void CreateQStatusBarProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStatusBar), this);
			_interceptor = (QStatusBar) realProxy.GetTransparentProxy();
		}
		private QStatusBar ProxyQStatusBar() {
			return (QStatusBar) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStatusBar() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStatusBarProxy), null);
			_staticInterceptor = (IQStatusBarProxy) realProxy.GetTransparentProxy();
		}
		private static IQStatusBarProxy StaticQStatusBar() {
			return (IQStatusBarProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQStatusBar().MetaObject();
		}
		// void* qt_metacast(const char* arg1); >>>> NOT CONVERTED
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QStatusBar(QWidget parent) : this((Type) null) {
			CreateQStatusBarProxy();
			NewQStatusBar(parent);
		}
		private void NewQStatusBar(QWidget parent) {
			ProxyQStatusBar().NewQStatusBar(parent);
		}
		public QStatusBar() : this((Type) null) {
			CreateQStatusBarProxy();
			NewQStatusBar();
		}
		private void NewQStatusBar() {
			ProxyQStatusBar().NewQStatusBar();
		}
		public void AddWidget(QWidget widget, int stretch) {
			ProxyQStatusBar().AddWidget(widget,stretch);
		}
		public void AddWidget(QWidget widget) {
			ProxyQStatusBar().AddWidget(widget);
		}
		public void AddPermanentWidget(QWidget widget, int stretch) {
			ProxyQStatusBar().AddPermanentWidget(widget,stretch);
		}
		public void AddPermanentWidget(QWidget widget) {
			ProxyQStatusBar().AddPermanentWidget(widget);
		}
		public void RemoveWidget(QWidget widget) {
			ProxyQStatusBar().RemoveWidget(widget);
		}
		public void SetSizeGripEnabled(bool arg1) {
			ProxyQStatusBar().SetSizeGripEnabled(arg1);
		}
		public bool IsSizeGripEnabled() {
			return ProxyQStatusBar().IsSizeGripEnabled();
		}
		public string CurrentMessage() {
			return ProxyQStatusBar().CurrentMessage();
		}
		public void ShowMessage(string text, int timeout) {
			ProxyQStatusBar().ShowMessage(text,timeout);
		}
		public void ShowMessage(string text) {
			ProxyQStatusBar().ShowMessage(text);
		}
		public void ClearMessage() {
			ProxyQStatusBar().ClearMessage();
		}
		public static new string Tr(string s, string c) {
			return StaticQStatusBar().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQStatusBar().Tr(s);
		}
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQStatusBar().PaintEvent(arg1);
		}
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQStatusBar().ResizeEvent(arg1);
		}
		protected void Reformat() {
			ProxyQStatusBar().Reformat();
		}
		protected void HideOrShow() {
			ProxyQStatusBar().HideOrShow();
		}
		public new bool Event(QEvent arg1) {
			return ProxyQStatusBar().Event(arg1);
		}
		~QStatusBar() {
			ProxyQStatusBar().Dispose();
		}
		public new void Dispose() {
			ProxyQStatusBar().Dispose();
		}
	}

	public interface IQStatusBarSignals {
		void MessageChanged(string text);
	}
}
