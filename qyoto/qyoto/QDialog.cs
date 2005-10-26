//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QDialog : QWidget, IDisposable {
 		protected QDialog(Type dummy) : base((Type) null) {}
		interface IQDialogProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected void CreateQDialogProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDialog), this);
			_interceptor = (QDialog) realProxy.GetTransparentProxy();
		}
		private QDialog ProxyQDialog() {
			return (QDialog) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDialogProxy), null);
			_staticInterceptor = (IQDialogProxy) realProxy.GetTransparentProxy();
		}
		private static IQDialogProxy StaticQDialog() {
			return (IQDialogProxy) _staticInterceptor;
		}

		enum DialogCode {
			Rejected = 0,
			Accepted = 1,
		}
		public new virtual QMetaObject MetaObject() {
			return ProxyQDialog().MetaObject();
		}
		// void* qt_metacast(const char* arg1); >>>> NOT CONVERTED
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QDialog(QWidget parent, int f) : this((Type) null) {
			CreateQDialogProxy();
			NewQDialog(parent,f);
		}
		private void NewQDialog(QWidget parent, int f) {
			ProxyQDialog().NewQDialog(parent,f);
		}
		public QDialog(QWidget parent) : this((Type) null) {
			CreateQDialogProxy();
			NewQDialog(parent);
		}
		private void NewQDialog(QWidget parent) {
			ProxyQDialog().NewQDialog(parent);
		}
		public QDialog() : this((Type) null) {
			CreateQDialogProxy();
			NewQDialog();
		}
		private void NewQDialog() {
			ProxyQDialog().NewQDialog();
		}
		public int Result() {
			return ProxyQDialog().Result();
		}
		public new void SetVisible(bool visible) {
			ProxyQDialog().SetVisible(visible);
		}
		public void SetOrientation(int orientation) {
			ProxyQDialog().SetOrientation(orientation);
		}
		public int Orientation() {
			return ProxyQDialog().Orientation();
		}
		public void SetExtension(QWidget extension) {
			ProxyQDialog().SetExtension(extension);
		}
		public QWidget Extension() {
			return ProxyQDialog().Extension();
		}
		public new QSize SizeHint() {
			return ProxyQDialog().SizeHint();
		}
		public new QSize MinimumSizeHint() {
			return ProxyQDialog().MinimumSizeHint();
		}
		public void SetSizeGripEnabled(bool arg1) {
			ProxyQDialog().SetSizeGripEnabled(arg1);
		}
		public bool IsSizeGripEnabled() {
			return ProxyQDialog().IsSizeGripEnabled();
		}
		public void SetModal(bool modal) {
			ProxyQDialog().SetModal(modal);
		}
		public new bool Event(QEvent arg1) {
			return ProxyQDialog().Event(arg1);
		}
		public void SetResult(int r) {
			ProxyQDialog().SetResult(r);
		}
		public int Exec() {
			return ProxyQDialog().Exec();
		}
		public virtual void Done(int arg1) {
			ProxyQDialog().Done(arg1);
		}
		public virtual void Accept() {
			ProxyQDialog().Accept();
		}
		public virtual void Reject() {
			ProxyQDialog().Reject();
		}
		public void ShowExtension(bool arg1) {
			ProxyQDialog().ShowExtension(arg1);
		}
		public static new string Tr(string s, string c) {
			return StaticQDialog().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQDialog().Tr(s);
		}
		protected new void KeyPressEvent(QKeyEvent arg1) {
			ProxyQDialog().KeyPressEvent(arg1);
		}
		protected new void CloseEvent(QCloseEvent arg1) {
			ProxyQDialog().CloseEvent(arg1);
		}
		public new void ShowEvent(QShowEvent arg1) {
			ProxyQDialog().ShowEvent(arg1);
		}
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQDialog().ResizeEvent(arg1);
		}
		protected new void ContextMenuEvent(QContextMenuEvent arg1) {
			ProxyQDialog().ContextMenuEvent(arg1);
		}
		public new bool EventFilter(QObject arg1, QEvent arg2) {
			return ProxyQDialog().EventFilter(arg1,arg2);
		}
		protected void AdjustPosition(QWidget arg1) {
			ProxyQDialog().AdjustPosition(arg1);
		}
		~QDialog() {
			ProxyQDialog().Dispose();
		}
		public new void Dispose() {
			ProxyQDialog().Dispose();
		}
	}
}
