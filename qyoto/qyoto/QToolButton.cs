//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQToolButtonSignals"></see> for signals emitted by QToolButton
	public class QToolButton : QAbstractButton, IDisposable {
 		protected QToolButton(Type dummy) : base((Type) null) {}
		interface IQToolButtonProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected void CreateQToolButtonProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QToolButton), this);
			_interceptor = (QToolButton) realProxy.GetTransparentProxy();
		}
		private QToolButton ProxyQToolButton() {
			return (QToolButton) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QToolButton() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQToolButtonProxy), null);
			_staticInterceptor = (IQToolButtonProxy) realProxy.GetTransparentProxy();
		}
		private static IQToolButtonProxy StaticQToolButton() {
			return (IQToolButtonProxy) _staticInterceptor;
		}

		enum ToolButtonPopupMode {
			DelayedPopup = 0,
			MenuButtonPopup = 1,
			InstantPopup = 2,
		}
		public new virtual QMetaObject MetaObject() {
			return ProxyQToolButton().MetaObject();
		}
		// void* qt_metacast(const char* arg1); >>>> NOT CONVERTED
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QToolButton(QWidget parent) : this((Type) null) {
			CreateQToolButtonProxy();
			NewQToolButton(parent);
		}
		private void NewQToolButton(QWidget parent) {
			ProxyQToolButton().NewQToolButton(parent);
		}
		public QToolButton() : this((Type) null) {
			CreateQToolButtonProxy();
			NewQToolButton();
		}
		private void NewQToolButton() {
			ProxyQToolButton().NewQToolButton();
		}
		public new QSize SizeHint() {
			return ProxyQToolButton().SizeHint();
		}
		public new QSize MinimumSizeHint() {
			return ProxyQToolButton().MinimumSizeHint();
		}
		public int ToolButtonStyle() {
			return ProxyQToolButton().ToolButtonStyle();
		}
		public int ArrowType() {
			return ProxyQToolButton().ArrowType();
		}
		public void SetArrowType(int type) {
			ProxyQToolButton().SetArrowType(type);
		}
		public void SetMenu(QMenu menu) {
			ProxyQToolButton().SetMenu(menu);
		}
		public QMenu Menu() {
			return ProxyQToolButton().Menu();
		}
		public void SetPopupMode(int mode) {
			ProxyQToolButton().SetPopupMode(mode);
		}
		public int PopupMode() {
			return ProxyQToolButton().PopupMode();
		}
		public QAction DefaultAction() {
			return ProxyQToolButton().DefaultAction();
		}
		public void SetAutoRaise(bool enable) {
			ProxyQToolButton().SetAutoRaise(enable);
		}
		public bool AutoRaise() {
			return ProxyQToolButton().AutoRaise();
		}
		public void ShowMenu() {
			ProxyQToolButton().ShowMenu();
		}
		public void SetToolButtonStyle(int style) {
			ProxyQToolButton().SetToolButtonStyle(style);
		}
		public void SetDefaultAction(QAction arg1) {
			ProxyQToolButton().SetDefaultAction(arg1);
		}
		public static new string Tr(string s, string c) {
			return StaticQToolButton().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQToolButton().Tr(s);
		}
		protected new void MousePressEvent(QMouseEvent arg1) {
			ProxyQToolButton().MousePressEvent(arg1);
		}
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQToolButton().PaintEvent(arg1);
		}
		protected new void ActionEvent(QActionEvent arg1) {
			ProxyQToolButton().ActionEvent(arg1);
		}
		protected new void EnterEvent(QEvent arg1) {
			ProxyQToolButton().EnterEvent(arg1);
		}
		protected new void LeaveEvent(QEvent arg1) {
			ProxyQToolButton().LeaveEvent(arg1);
		}
		protected new void TimerEvent(QTimerEvent arg1) {
			ProxyQToolButton().TimerEvent(arg1);
		}
		protected new void ChangeEvent(QEvent arg1) {
			ProxyQToolButton().ChangeEvent(arg1);
		}
		protected new void NextCheckState() {
			ProxyQToolButton().NextCheckState();
		}
		~QToolButton() {
			ProxyQToolButton().Dispose();
		}
		public new void Dispose() {
			ProxyQToolButton().Dispose();
		}
	}

	public interface IQToolButtonSignals {
		void Triggered(QAction arg1);
	}
}
