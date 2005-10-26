//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	/// See <see cref="IQApplicationSignals"></see> for signals emitted by QApplication
	public class QApplication : QCoreApplication, IDisposable {
 		protected QApplication(Type dummy) : base((Type) null) {}
		interface IQApplicationProxy {
			string Tr(string s, string c);
			string Tr(string s);
			QStyle Style();
			void SetStyle(QStyle arg1);
			QStyle SetStyle(string arg1);
			int ColorSpec();
			void SetColorSpec(int arg1);
			QCursor OverrideCursor();
			void SetOverrideCursor(QCursor arg1);
			void ChangeOverrideCursor(QCursor arg1);
			void RestoreOverrideCursor();
			QPalette Palette();
			QPalette Palette(QWidget arg1);
			QPalette Palette(string className);
			void SetPalette(QPalette arg1, string className);
			void SetPalette(QPalette arg1);
			QFont Font(QWidget arg1);
			QFont Font();
			void SetFont(QFont arg1, string className);
			void SetFont(QFont arg1);
			QFontMetrics FontMetrics();
			void SetWindowIcon(QIcon icon);
			QIcon WindowIcon();
			ArrayList AllWidgets();
			ArrayList TopLevelWidgets();
			QDesktopWidget Desktop();
			QWidget ActivePopupWidget();
			QWidget ActiveModalWidget();
			QClipboard Clipboard();
			QWidget FocusWidget();
			QWidget ActiveWindow();
			void SetActiveWindow(QWidget act);
			QWidget WidgetAt(QPoint p);
			QWidget WidgetAt(int x, int y);
			QWidget TopLevelAt(QPoint p);
			QWidget TopLevelAt(int x, int y);
			void SyncX();
			void Beep();
			int KeyboardModifiers();
			int MouseButtons();
			void SetDesktopSettingsAware(bool arg1);
			bool DesktopSettingsAware();
			void SetCursorFlashTime(int arg1);
			int CursorFlashTime();
			void SetDoubleClickInterval(int arg1);
			int DoubleClickInterval();
			void SetKeyboardInputInterval(int arg1);
			int KeyboardInputInterval();
			void SetWheelScrollLines(int arg1);
			int WheelScrollLines();
			void SetGlobalStrut(QSize arg1);
			QSize GlobalStrut();
			void SetStartDragTime(int ms);
			int StartDragTime();
			void SetStartDragDistance(int l);
			int StartDragDistance();
			void SetLayoutDirection(int direction);
			int LayoutDirection();
			bool IsRightToLeft();
			bool IsLeftToRight();
			bool IsEffectEnabled(int arg1);
			void SetEffectEnabled(int arg1, bool enable);
			void SetEffectEnabled(int arg1);
			int Exec();
			void SetQuitOnLastWindowClosed(bool quit);
			bool QuitOnLastWindowClosed();
			void CloseAllWindows();
			void AboutQt();
		}

		protected void CreateQApplicationProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QApplication), this);
			_interceptor = (QApplication) realProxy.GetTransparentProxy();
		}
		private QApplication ProxyQApplication() {
			return (QApplication) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QApplication() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQApplicationProxy), null);
			_staticInterceptor = (IQApplicationProxy) realProxy.GetTransparentProxy();
		}
		private static IQApplicationProxy StaticQApplication() {
			return (IQApplicationProxy) _staticInterceptor;
		}

		enum E_Type {
			Tty = 0,
			GuiClient = 1,
			GuiServer = 2,
		}
		enum E_ColorSpec {
			NormalColor = 0,
			CustomColor = 1,
			ManyColor = 2,
		}
		public new virtual QMetaObject MetaObject() {
			return ProxyQApplication().MetaObject();
		}
		// void* qt_metacast(const char* arg1); >>>> NOT CONVERTED
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QApplication(string[] argv) : this((Type) null) {
			CreateQApplicationProxy();
			NewQApplication(argv);
		}
		private void NewQApplication(string[] argv) {
			ProxyQApplication().NewQApplication(argv);
		}
		public QApplication(string[] argv, bool GUIenabled) : this((Type) null) {
			CreateQApplicationProxy();
			NewQApplication(argv,GUIenabled);
		}
		private void NewQApplication(string[] argv, bool GUIenabled) {
			ProxyQApplication().NewQApplication(argv,GUIenabled);
		}
		public QApplication(string[] argv, int arg3) : this((Type) null) {
			CreateQApplicationProxy();
			NewQApplication(argv,arg3);
		}
		private void NewQApplication(string[] argv, int arg3) {
			ProxyQApplication().NewQApplication(argv,arg3);
		}
		public bool IsSessionRestored() {
			return ProxyQApplication().IsSessionRestored();
		}
		public string SessionId() {
			return ProxyQApplication().SessionId();
		}
		public string SessionKey() {
			return ProxyQApplication().SessionKey();
		}
		public virtual void CommitData(QSessionManager sm) {
			ProxyQApplication().CommitData(sm);
		}
		public virtual void SaveState(QSessionManager sm) {
			ProxyQApplication().SaveState(sm);
		}
		public void SetInputContext(QInputContext arg1) {
			ProxyQApplication().SetInputContext(arg1);
		}
		public QInputContext InputContext() {
			return ProxyQApplication().InputContext();
		}
		public new bool Notify(QObject arg1, QEvent arg2) {
			return ProxyQApplication().Notify(arg1,arg2);
		}
		public static new string Tr(string s, string c) {
			return StaticQApplication().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQApplication().Tr(s);
		}
		public static QStyle Style() {
			return StaticQApplication().Style();
		}
		public static void SetStyle(QStyle arg1) {
			StaticQApplication().SetStyle(arg1);
		}
		public static QStyle SetStyle(string arg1) {
			return StaticQApplication().SetStyle(arg1);
		}
		public static int ColorSpec() {
			return StaticQApplication().ColorSpec();
		}
		public static void SetColorSpec(int arg1) {
			StaticQApplication().SetColorSpec(arg1);
		}
		public static QCursor OverrideCursor() {
			return StaticQApplication().OverrideCursor();
		}
		public static void SetOverrideCursor(QCursor arg1) {
			StaticQApplication().SetOverrideCursor(arg1);
		}
		public static void ChangeOverrideCursor(QCursor arg1) {
			StaticQApplication().ChangeOverrideCursor(arg1);
		}
		public static void RestoreOverrideCursor() {
			StaticQApplication().RestoreOverrideCursor();
		}
		public static QPalette Palette() {
			return StaticQApplication().Palette();
		}
		public static QPalette Palette(QWidget arg1) {
			return StaticQApplication().Palette(arg1);
		}
		public static QPalette Palette(string className) {
			return StaticQApplication().Palette(className);
		}
		public static void SetPalette(QPalette arg1, string className) {
			StaticQApplication().SetPalette(arg1,className);
		}
		public static void SetPalette(QPalette arg1) {
			StaticQApplication().SetPalette(arg1);
		}
		public static QFont Font(QWidget arg1) {
			return StaticQApplication().Font(arg1);
		}
		public static QFont Font() {
			return StaticQApplication().Font();
		}
		public static void SetFont(QFont arg1, string className) {
			StaticQApplication().SetFont(arg1,className);
		}
		public static void SetFont(QFont arg1) {
			StaticQApplication().SetFont(arg1);
		}
		public static QFontMetrics FontMetrics() {
			return StaticQApplication().FontMetrics();
		}
		public static void SetWindowIcon(QIcon icon) {
			StaticQApplication().SetWindowIcon(icon);
		}
		public static QIcon WindowIcon() {
			return StaticQApplication().WindowIcon();
		}
		public static ArrayList AllWidgets() {
			return StaticQApplication().AllWidgets();
		}
		public static ArrayList TopLevelWidgets() {
			return StaticQApplication().TopLevelWidgets();
		}
		public static QDesktopWidget Desktop() {
			return StaticQApplication().Desktop();
		}
		public static QWidget ActivePopupWidget() {
			return StaticQApplication().ActivePopupWidget();
		}
		public static QWidget ActiveModalWidget() {
			return StaticQApplication().ActiveModalWidget();
		}
		public static QClipboard Clipboard() {
			return StaticQApplication().Clipboard();
		}
		public static QWidget FocusWidget() {
			return StaticQApplication().FocusWidget();
		}
		public static QWidget ActiveWindow() {
			return StaticQApplication().ActiveWindow();
		}
		public static void SetActiveWindow(QWidget act) {
			StaticQApplication().SetActiveWindow(act);
		}
		public static QWidget WidgetAt(QPoint p) {
			return StaticQApplication().WidgetAt(p);
		}
		public static QWidget WidgetAt(int x, int y) {
			return StaticQApplication().WidgetAt(x,y);
		}
		public static QWidget TopLevelAt(QPoint p) {
			return StaticQApplication().TopLevelAt(p);
		}
		public static QWidget TopLevelAt(int x, int y) {
			return StaticQApplication().TopLevelAt(x,y);
		}
		public static void SyncX() {
			StaticQApplication().SyncX();
		}
		public static void Beep() {
			StaticQApplication().Beep();
		}
		public static int KeyboardModifiers() {
			return StaticQApplication().KeyboardModifiers();
		}
		public static int MouseButtons() {
			return StaticQApplication().MouseButtons();
		}
		public static void SetDesktopSettingsAware(bool arg1) {
			StaticQApplication().SetDesktopSettingsAware(arg1);
		}
		public static bool DesktopSettingsAware() {
			return StaticQApplication().DesktopSettingsAware();
		}
		public static void SetCursorFlashTime(int arg1) {
			StaticQApplication().SetCursorFlashTime(arg1);
		}
		public static int CursorFlashTime() {
			return StaticQApplication().CursorFlashTime();
		}
		public static void SetDoubleClickInterval(int arg1) {
			StaticQApplication().SetDoubleClickInterval(arg1);
		}
		public static int DoubleClickInterval() {
			return StaticQApplication().DoubleClickInterval();
		}
		public static void SetKeyboardInputInterval(int arg1) {
			StaticQApplication().SetKeyboardInputInterval(arg1);
		}
		public static int KeyboardInputInterval() {
			return StaticQApplication().KeyboardInputInterval();
		}
		public static void SetWheelScrollLines(int arg1) {
			StaticQApplication().SetWheelScrollLines(arg1);
		}
		public static int WheelScrollLines() {
			return StaticQApplication().WheelScrollLines();
		}
		public static void SetGlobalStrut(QSize arg1) {
			StaticQApplication().SetGlobalStrut(arg1);
		}
		public static QSize GlobalStrut() {
			return StaticQApplication().GlobalStrut();
		}
		public static void SetStartDragTime(int ms) {
			StaticQApplication().SetStartDragTime(ms);
		}
		public static int StartDragTime() {
			return StaticQApplication().StartDragTime();
		}
		public static void SetStartDragDistance(int l) {
			StaticQApplication().SetStartDragDistance(l);
		}
		public static int StartDragDistance() {
			return StaticQApplication().StartDragDistance();
		}
		public static void SetLayoutDirection(int direction) {
			StaticQApplication().SetLayoutDirection(direction);
		}
		public static int LayoutDirection() {
			return StaticQApplication().LayoutDirection();
		}
		public static bool IsRightToLeft() {
			return StaticQApplication().IsRightToLeft();
		}
		public static bool IsLeftToRight() {
			return StaticQApplication().IsLeftToRight();
		}
		public static bool IsEffectEnabled(int arg1) {
			return StaticQApplication().IsEffectEnabled(arg1);
		}
		public static void SetEffectEnabled(int arg1, bool enable) {
			StaticQApplication().SetEffectEnabled(arg1,enable);
		}
		public static void SetEffectEnabled(int arg1) {
			StaticQApplication().SetEffectEnabled(arg1);
		}
		public static new int Exec() {
			return StaticQApplication().Exec();
		}
		public static void SetQuitOnLastWindowClosed(bool quit) {
			StaticQApplication().SetQuitOnLastWindowClosed(quit);
		}
		public static bool QuitOnLastWindowClosed() {
			return StaticQApplication().QuitOnLastWindowClosed();
		}
		public static void CloseAllWindows() {
			StaticQApplication().CloseAllWindows();
		}
		public static void AboutQt() {
			StaticQApplication().AboutQt();
		}
		public new bool Event(QEvent arg1) {
			return ProxyQApplication().Event(arg1);
		}
		// bool compressEvent(QEvent* arg1,QObject* arg2,QPostEventList* arg3); >>>> NOT CONVERTED
		~QApplication() {
			ProxyQApplication().Dispose();
		}
		public new void Dispose() {
			ProxyQApplication().Dispose();
		}
//	public native string[] args();

	}

	public interface IQApplicationSignals {
		void LastWindowClosed();
	}
}
