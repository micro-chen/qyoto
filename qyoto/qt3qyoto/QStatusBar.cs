//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQStatusBarSignals"></see> for signals emitted by QStatusBar
	public class QStatusBar : QWidget, IDisposable {
 		protected QStatusBar(Type dummy) : base((Type) null) {}
		interface IQStatusBarProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
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
		public new virtual string ClassName() {
			return ProxyQStatusBar().ClassName();
		}
		public QStatusBar(QWidget parent, string name) : this((Type) null) {
			CreateQStatusBarProxy();
			NewQStatusBar(parent,name);
		}
		private void NewQStatusBar(QWidget parent, string name) {
			ProxyQStatusBar().NewQStatusBar(parent,name);
		}
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
		public virtual void AddWidget(QWidget arg1, int stretch, bool arg3) {
			ProxyQStatusBar().AddWidget(arg1,stretch,arg3);
		}
		public virtual void AddWidget(QWidget arg1, int stretch) {
			ProxyQStatusBar().AddWidget(arg1,stretch);
		}
		public virtual void AddWidget(QWidget arg1) {
			ProxyQStatusBar().AddWidget(arg1);
		}
		public virtual void RemoveWidget(QWidget arg1) {
			ProxyQStatusBar().RemoveWidget(arg1);
		}
		public void SetSizeGripEnabled(bool arg1) {
			ProxyQStatusBar().SetSizeGripEnabled(arg1);
		}
		public bool IsSizeGripEnabled() {
			return ProxyQStatusBar().IsSizeGripEnabled();
		}
		public void Message(string arg1) {
			ProxyQStatusBar().Message(arg1);
		}
		public void Message(string arg1, int arg2) {
			ProxyQStatusBar().Message(arg1,arg2);
		}
		public void Clear() {
			ProxyQStatusBar().Clear();
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQStatusBar().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQStatusBar().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQStatusBar().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQStatusBar().TrUtf8(arg1);
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
