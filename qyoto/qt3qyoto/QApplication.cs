//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	/// See <see cref="IQApplicationSignals"></see> for signals emitted by QApplication
	public class QApplication : QObject, IDisposable {
 		protected QApplication(Type dummy) : base((Type) null) {}
		interface IQApplicationProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
			QStyle Style();
			void SetStyle(QStyle arg1);
			QStyle SetStyle(string arg1);
			int ColorMode();
			void SetColorMode(int arg1);
			int ColorSpec();
			void SetColorSpec(int arg1);
			QCursor OverrideCursor();
			void SetOverrideCursor(QCursor arg1, bool replace);
			void SetOverrideCursor(QCursor arg1);
			void RestoreOverrideCursor();
			bool HasGlobalMouseTracking();
			void SetGlobalMouseTracking(bool enable);
			QPalette Palette(QWidget arg1);
			QPalette Palette();
			void SetPalette(QPalette arg1, bool informWidgets, string className);
			void SetPalette(QPalette arg1, bool informWidgets);
			void SetPalette(QPalette arg1);
			QFont Font(QWidget arg1);
			QFont Font();
			void SetFont(QFont arg1, bool informWidgets, string className);
			void SetFont(QFont arg1, bool informWidgets);
			void SetFont(QFont arg1);
			QFontMetrics FontMetrics();
			ArrayList AllWidgets();
			ArrayList TopLevelWidgets();
			QDesktopWidget Desktop();
			QWidget ActivePopupWidget();
			QWidget ActiveModalWidget();
			QClipboard Clipboard();
			QWidget WidgetAt(int x, int y, bool child);
			QWidget WidgetAt(int x, int y);
			QWidget WidgetAt(QPoint arg1, bool child);
			QWidget WidgetAt(QPoint arg1);
			QEventLoop EventLoop();
			void Exit(int retcode);
			void Exit();
			bool SendEvent(QObject receiver, QEvent arg2);
			void PostEvent(QObject receiver, QEvent arg2);
			void SendPostedEvents(QObject receiver, int event_type);
			void SendPostedEvents();
			void RemovePostedEvents(QObject receiver);
			bool StartingUp();
			bool ClosingDown();
			void FlushX();
			void Flush();
			void SyncX();
			void Beep();
			void SetWinStyleHighlightColor(QColor c);
			QColor WinStyleHighlightColor();
			void SetDesktopSettingsAware(bool arg1);
			bool DesktopSettingsAware();
			void SetCursorFlashTime(int arg1);
			int CursorFlashTime();
			void SetDoubleClickInterval(int arg1);
			int DoubleClickInterval();
			void SetWheelScrollLines(int arg1);
			int WheelScrollLines();
			void SetGlobalStrut(QSize arg1);
			QSize GlobalStrut();
			void SetLibraryPaths(string[] arg1);
			ArrayList LibraryPaths();
			void AddLibraryPath(string arg1);
			void RemoveLibraryPath(string arg1);
			void SetStartDragTime(int ms);
			int StartDragTime();
			void SetStartDragDistance(int l);
			int StartDragDistance();
			void SetReverseLayout(bool b);
			bool ReverseLayout();
			int HorizontalAlignment(int align);
			bool IsEffectEnabled(int arg1);
			void SetEffectEnabled(int arg1, bool enable);
			void SetEffectEnabled(int arg1);
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
		enum E_ColorMode {
			NormalColors = 0,
			CustomColors = 1,
		}
		enum E_ColorSpec {
			NormalColor = 0,
			CustomColor = 1,
			ManyColor = 2,
		}
		enum Encoding {
			DefaultCodec = 0,
			UnicodeUTF8 = 1,
		}
		public new virtual QMetaObject MetaObject() {
			return ProxyQApplication().MetaObject();
		}
		public new virtual string ClassName() {
			return ProxyQApplication().ClassName();
		}
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
		public int Type() {
			return ProxyQApplication().Type();
		}
		public QWidget MainWidget() {
			return ProxyQApplication().MainWidget();
		}
		public virtual void SetMainWidget(QWidget arg1) {
			ProxyQApplication().SetMainWidget(arg1);
		}
		public virtual void Polish(QWidget arg1) {
			ProxyQApplication().Polish(arg1);
		}
		public QWidget FocusWidget() {
			return ProxyQApplication().FocusWidget();
		}
		public QWidget ActiveWindow() {
			return ProxyQApplication().ActiveWindow();
		}
		public int Exec() {
			return ProxyQApplication().Exec();
		}
		public void ProcessEvents() {
			ProxyQApplication().ProcessEvents();
		}
		public void ProcessEvents(int maxtime) {
			ProxyQApplication().ProcessEvents(maxtime);
		}
		public void ProcessOneEvent() {
			ProxyQApplication().ProcessOneEvent();
		}
		public bool HasPendingEvents() {
			return ProxyQApplication().HasPendingEvents();
		}
		public int Enter_loop() {
			return ProxyQApplication().Enter_loop();
		}
		public void Exit_loop() {
			ProxyQApplication().Exit_loop();
		}
		public int LoopLevel() {
			return ProxyQApplication().LoopLevel();
		}
		public virtual bool Notify(QObject arg1, QEvent arg2) {
			return ProxyQApplication().Notify(arg1,arg2);
		}
		public void SetDefaultCodec(QTextCodec arg1) {
			ProxyQApplication().SetDefaultCodec(arg1);
		}
		public QTextCodec DefaultCodec() {
			return ProxyQApplication().DefaultCodec();
		}
		public void InstallTranslator(QTranslator arg1) {
			ProxyQApplication().InstallTranslator(arg1);
		}
		public void RemoveTranslator(QTranslator arg1) {
			ProxyQApplication().RemoveTranslator(arg1);
		}
		public string Translate(string context, string key, string comment, int encoding) {
			return ProxyQApplication().Translate(context,key,comment,encoding);
		}
		public string Translate(string context, string key, string comment) {
			return ProxyQApplication().Translate(context,key,comment);
		}
		public string Translate(string context, string key) {
			return ProxyQApplication().Translate(context,key);
		}
		public string ApplicationDirPath() {
			return ProxyQApplication().ApplicationDirPath();
		}
		public string ApplicationFilePath() {
			return ProxyQApplication().ApplicationFilePath();
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
		public void WakeUpGuiThread() {
			ProxyQApplication().WakeUpGuiThread();
		}
		public void Quit() {
			ProxyQApplication().Quit();
		}
		public void CloseAllWindows() {
			ProxyQApplication().CloseAllWindows();
		}
		public void AboutQt() {
			ProxyQApplication().AboutQt();
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQApplication().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQApplication().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQApplication().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQApplication().TrUtf8(arg1);
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
		public static int ColorMode() {
			return StaticQApplication().ColorMode();
		}
		public static void SetColorMode(int arg1) {
			StaticQApplication().SetColorMode(arg1);
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
		public static void SetOverrideCursor(QCursor arg1, bool replace) {
			StaticQApplication().SetOverrideCursor(arg1,replace);
		}
		public static void SetOverrideCursor(QCursor arg1) {
			StaticQApplication().SetOverrideCursor(arg1);
		}
		public static void RestoreOverrideCursor() {
			StaticQApplication().RestoreOverrideCursor();
		}
		public static bool HasGlobalMouseTracking() {
			return StaticQApplication().HasGlobalMouseTracking();
		}
		public static void SetGlobalMouseTracking(bool enable) {
			StaticQApplication().SetGlobalMouseTracking(enable);
		}
		public static QPalette Palette(QWidget arg1) {
			return StaticQApplication().Palette(arg1);
		}
		public static QPalette Palette() {
			return StaticQApplication().Palette();
		}
		public static void SetPalette(QPalette arg1, bool informWidgets, string className) {
			StaticQApplication().SetPalette(arg1,informWidgets,className);
		}
		public static void SetPalette(QPalette arg1, bool informWidgets) {
			StaticQApplication().SetPalette(arg1,informWidgets);
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
		public static void SetFont(QFont arg1, bool informWidgets, string className) {
			StaticQApplication().SetFont(arg1,informWidgets,className);
		}
		public static void SetFont(QFont arg1, bool informWidgets) {
			StaticQApplication().SetFont(arg1,informWidgets);
		}
		public static void SetFont(QFont arg1) {
			StaticQApplication().SetFont(arg1);
		}
		public static QFontMetrics FontMetrics() {
			return StaticQApplication().FontMetrics();
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
		public static QWidget WidgetAt(int x, int y, bool child) {
			return StaticQApplication().WidgetAt(x,y,child);
		}
		public static QWidget WidgetAt(int x, int y) {
			return StaticQApplication().WidgetAt(x,y);
		}
		public static QWidget WidgetAt(QPoint arg1, bool child) {
			return StaticQApplication().WidgetAt(arg1,child);
		}
		public static QWidget WidgetAt(QPoint arg1) {
			return StaticQApplication().WidgetAt(arg1);
		}
		public static QEventLoop EventLoop() {
			return StaticQApplication().EventLoop();
		}
		public static void Exit(int retcode) {
			StaticQApplication().Exit(retcode);
		}
		public static void Exit() {
			StaticQApplication().Exit();
		}
		public static bool SendEvent(QObject receiver, QEvent arg2) {
			return StaticQApplication().SendEvent(receiver,arg2);
		}
		public static void PostEvent(QObject receiver, QEvent arg2) {
			StaticQApplication().PostEvent(receiver,arg2);
		}
		public static void SendPostedEvents(QObject receiver, int event_type) {
			StaticQApplication().SendPostedEvents(receiver,event_type);
		}
		public static void SendPostedEvents() {
			StaticQApplication().SendPostedEvents();
		}
		public static void RemovePostedEvents(QObject receiver) {
			StaticQApplication().RemovePostedEvents(receiver);
		}
		public static bool StartingUp() {
			return StaticQApplication().StartingUp();
		}
		public static bool ClosingDown() {
			return StaticQApplication().ClosingDown();
		}
		public static void FlushX() {
			StaticQApplication().FlushX();
		}
		public static void Flush() {
			StaticQApplication().Flush();
		}
		public static void SyncX() {
			StaticQApplication().SyncX();
		}
		public static void Beep() {
			StaticQApplication().Beep();
		}
		public static void SetWinStyleHighlightColor(QColor c) {
			StaticQApplication().SetWinStyleHighlightColor(c);
		}
		public static QColor WinStyleHighlightColor() {
			return StaticQApplication().WinStyleHighlightColor();
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
		public static void SetLibraryPaths(string[] arg1) {
			StaticQApplication().SetLibraryPaths(arg1);
		}
		public static ArrayList LibraryPaths() {
			return StaticQApplication().LibraryPaths();
		}
		public static void AddLibraryPath(string arg1) {
			StaticQApplication().AddLibraryPath(arg1);
		}
		public static void RemoveLibraryPath(string arg1) {
			StaticQApplication().RemoveLibraryPath(arg1);
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
		public static void SetReverseLayout(bool b) {
			StaticQApplication().SetReverseLayout(b);
		}
		public static bool ReverseLayout() {
			return StaticQApplication().ReverseLayout();
		}
		public static int HorizontalAlignment(int align) {
			return StaticQApplication().HorizontalAlignment(align);
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
		public new bool Event(QEvent arg1) {
			return ProxyQApplication().Event(arg1);
		}
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
		void AboutToQuit();
		void GuiThreadAwake();
	}
}
