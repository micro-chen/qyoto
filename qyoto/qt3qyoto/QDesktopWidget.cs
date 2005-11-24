//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQDesktopWidgetSignals"></see> for signals emitted by QDesktopWidget
	public class QDesktopWidget : QWidget, IDisposable {
 		protected QDesktopWidget(Type dummy) : base((Type) null) {}
		interface IQDesktopWidgetProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQDesktopWidgetProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDesktopWidget), this);
			_interceptor = (QDesktopWidget) realProxy.GetTransparentProxy();
		}
		private QDesktopWidget ProxyQDesktopWidget() {
			return (QDesktopWidget) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDesktopWidget() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDesktopWidgetProxy), null);
			_staticInterceptor = (IQDesktopWidgetProxy) realProxy.GetTransparentProxy();
		}
		private static IQDesktopWidgetProxy StaticQDesktopWidget() {
			return (IQDesktopWidgetProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQDesktopWidget().MetaObject();
		}
		public new virtual string ClassName() {
			return ProxyQDesktopWidget().ClassName();
		}
		public QDesktopWidget() : this((Type) null) {
			CreateQDesktopWidgetProxy();
			NewQDesktopWidget();
		}
		private void NewQDesktopWidget() {
			ProxyQDesktopWidget().NewQDesktopWidget();
		}
		public bool IsVirtualDesktop() {
			return ProxyQDesktopWidget().IsVirtualDesktop();
		}
		public int NumScreens() {
			return ProxyQDesktopWidget().NumScreens();
		}
		public int PrimaryScreen() {
			return ProxyQDesktopWidget().PrimaryScreen();
		}
		public int ScreenNumber(QWidget widget) {
			return ProxyQDesktopWidget().ScreenNumber(widget);
		}
		public int ScreenNumber() {
			return ProxyQDesktopWidget().ScreenNumber();
		}
		public int ScreenNumber(QPoint arg1) {
			return ProxyQDesktopWidget().ScreenNumber(arg1);
		}
		public QWidget Screen(int screen) {
			return ProxyQDesktopWidget().Screen(screen);
		}
		public QWidget Screen() {
			return ProxyQDesktopWidget().Screen();
		}
		public QRect ScreenGeometry(int screen) {
			return ProxyQDesktopWidget().ScreenGeometry(screen);
		}
		public QRect ScreenGeometry() {
			return ProxyQDesktopWidget().ScreenGeometry();
		}
		public QRect ScreenGeometry(QWidget widget) {
			return ProxyQDesktopWidget().ScreenGeometry(widget);
		}
		public QRect ScreenGeometry(QPoint point) {
			return ProxyQDesktopWidget().ScreenGeometry(point);
		}
		public QRect AvailableGeometry(int screen) {
			return ProxyQDesktopWidget().AvailableGeometry(screen);
		}
		public QRect AvailableGeometry() {
			return ProxyQDesktopWidget().AvailableGeometry();
		}
		public QRect AvailableGeometry(QWidget widget) {
			return ProxyQDesktopWidget().AvailableGeometry(widget);
		}
		public QRect AvailableGeometry(QPoint point) {
			return ProxyQDesktopWidget().AvailableGeometry(point);
		}
		public new void InsertChild(QObject arg1) {
			ProxyQDesktopWidget().InsertChild(arg1);
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQDesktopWidget().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQDesktopWidget().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQDesktopWidget().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQDesktopWidget().TrUtf8(arg1);
		}
		protected new void ResizeEvent(QResizeEvent e) {
			ProxyQDesktopWidget().ResizeEvent(e);
		}
		~QDesktopWidget() {
			ProxyQDesktopWidget().Dispose();
		}
		public new void Dispose() {
			ProxyQDesktopWidget().Dispose();
		}
	}

	public interface IQDesktopWidgetSignals {
		void Resized(int arg1);
		void WorkAreaResized(int arg1);
	}
}
