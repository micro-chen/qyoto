//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	/// See <see cref="IQCoreApplicationSignals"></see> for signals emitted by QCoreApplication
	[SmokeClass("QCoreApplication")]
	public class QCoreApplication : QObject, IDisposable {
 		protected QCoreApplication(Type dummy) : base((Type) null) {}
		interface IQCoreApplicationProxy {
			string Tr(string s, string c);
			string Tr(string s);
			int Argc();
			ArrayList Argv();
			ArrayList Arguments();
			void SetOrganizationDomain(string orgDomain);
			string OrganizationDomain();
			void SetOrganizationName(string orgName);
			string OrganizationName();
			void SetApplicationName(string application);
			string ApplicationName();
			QCoreApplication Instance();
			int Exec();
			void ProcessEvents(uint flags);
			void ProcessEvents();
			void ProcessEvents(uint flags, int maxtime);
			void Exit(int retcode);
			void Exit();
			bool SendEvent(QObject receiver, QEvent arg2);
			void PostEvent(QObject receiver, QEvent arg2);
			void SendPostedEvents(QObject receiver, int event_type);
			void SendPostedEvents();
			void RemovePostedEvents(QObject receiver);
			bool HasPendingEvents();
			bool StartingUp();
			bool ClosingDown();
			string ApplicationDirPath();
			string ApplicationFilePath();
			void SetLibraryPaths(string[] arg1);
			ArrayList LibraryPaths();
			void AddLibraryPath(string arg1);
			void RemoveLibraryPath(string arg1);
			void InstallTranslator(QTranslator messageFile);
			void RemoveTranslator(QTranslator messageFile);
			string Translate(string context, string key, string comment, QCoreApplication.Encoding encoding);
			string Translate(string context, string key, string comment);
			string Translate(string context, string key);
			void Flush();
			void Quit();
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QCoreApplication), this);
			_interceptor = (QCoreApplication) realProxy.GetTransparentProxy();
		}
		private QCoreApplication ProxyQCoreApplication() {
			return (QCoreApplication) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QCoreApplication() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCoreApplicationProxy), null);
			_staticInterceptor = (IQCoreApplicationProxy) realProxy.GetTransparentProxy();
		}
		private static IQCoreApplicationProxy StaticQCoreApplication() {
			return (IQCoreApplicationProxy) _staticInterceptor;
		}

		public enum Encoding {
			DefaultCodec = 0,
			UnicodeUTF8 = 1,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQCoreApplication().MetaObject();
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		[SmokeMethod("notify(QObject*, QEvent*)")]
		public virtual bool Notify(QObject arg1, QEvent arg2) {
			return ProxyQCoreApplication().Notify(arg1,arg2);
		}
		// EventFilter setEventFilter(EventFilter arg1); >>>> NOT CONVERTED
		// bool filterEvent(void* arg1,long* arg2); >>>> NOT CONVERTED
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQCoreApplication().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQCoreApplication().Tr(s);
		}
		[SmokeMethod("argc()")]
		public static int Argc() {
			return StaticQCoreApplication().Argc();
		}
		[SmokeMethod("argv()")]
		public static ArrayList Argv() {
			return StaticQCoreApplication().Argv();
		}
		[SmokeMethod("arguments()")]
		public static ArrayList Arguments() {
			return StaticQCoreApplication().Arguments();
		}
		[SmokeMethod("setOrganizationDomain(const QString&)")]
		public static void SetOrganizationDomain(string orgDomain) {
			StaticQCoreApplication().SetOrganizationDomain(orgDomain);
		}
		[SmokeMethod("organizationDomain()")]
		public static string OrganizationDomain() {
			return StaticQCoreApplication().OrganizationDomain();
		}
		[SmokeMethod("setOrganizationName(const QString&)")]
		public static void SetOrganizationName(string orgName) {
			StaticQCoreApplication().SetOrganizationName(orgName);
		}
		[SmokeMethod("organizationName()")]
		public static string OrganizationName() {
			return StaticQCoreApplication().OrganizationName();
		}
		[SmokeMethod("setApplicationName(const QString&)")]
		public static void SetApplicationName(string application) {
			StaticQCoreApplication().SetApplicationName(application);
		}
		[SmokeMethod("applicationName()")]
		public static string ApplicationName() {
			return StaticQCoreApplication().ApplicationName();
		}
		[SmokeMethod("instance()")]
		public static QCoreApplication Instance() {
			return StaticQCoreApplication().Instance();
		}
		[SmokeMethod("exec()")]
		public static int Exec() {
			return StaticQCoreApplication().Exec();
		}
		[SmokeMethod("processEvents(QEventLoop::ProcessEventsFlags)")]
		public static void ProcessEvents(uint flags) {
			StaticQCoreApplication().ProcessEvents(flags);
		}
		[SmokeMethod("processEvents()")]
		public static void ProcessEvents() {
			StaticQCoreApplication().ProcessEvents();
		}
		[SmokeMethod("processEvents(QEventLoop::ProcessEventsFlags, int)")]
		public static void ProcessEvents(uint flags, int maxtime) {
			StaticQCoreApplication().ProcessEvents(flags,maxtime);
		}
		[SmokeMethod("exit(int)")]
		public static void Exit(int retcode) {
			StaticQCoreApplication().Exit(retcode);
		}
		[SmokeMethod("exit()")]
		public static void Exit() {
			StaticQCoreApplication().Exit();
		}
		[SmokeMethod("sendEvent(QObject*, QEvent*)")]
		public static bool SendEvent(QObject receiver, QEvent arg2) {
			return StaticQCoreApplication().SendEvent(receiver,arg2);
		}
		[SmokeMethod("postEvent(QObject*, QEvent*)")]
		public static void PostEvent(QObject receiver, QEvent arg2) {
			StaticQCoreApplication().PostEvent(receiver,arg2);
		}
		[SmokeMethod("sendPostedEvents(QObject*, int)")]
		public static void SendPostedEvents(QObject receiver, int event_type) {
			StaticQCoreApplication().SendPostedEvents(receiver,event_type);
		}
		[SmokeMethod("sendPostedEvents()")]
		public static void SendPostedEvents() {
			StaticQCoreApplication().SendPostedEvents();
		}
		[SmokeMethod("removePostedEvents(QObject*)")]
		public static void RemovePostedEvents(QObject receiver) {
			StaticQCoreApplication().RemovePostedEvents(receiver);
		}
		[SmokeMethod("hasPendingEvents()")]
		public static bool HasPendingEvents() {
			return StaticQCoreApplication().HasPendingEvents();
		}
		[SmokeMethod("startingUp()")]
		public static bool StartingUp() {
			return StaticQCoreApplication().StartingUp();
		}
		[SmokeMethod("closingDown()")]
		public static bool ClosingDown() {
			return StaticQCoreApplication().ClosingDown();
		}
		[SmokeMethod("applicationDirPath()")]
		public static string ApplicationDirPath() {
			return StaticQCoreApplication().ApplicationDirPath();
		}
		[SmokeMethod("applicationFilePath()")]
		public static string ApplicationFilePath() {
			return StaticQCoreApplication().ApplicationFilePath();
		}
		[SmokeMethod("setLibraryPaths(const QStringList&)")]
		public static void SetLibraryPaths(string[] arg1) {
			StaticQCoreApplication().SetLibraryPaths(arg1);
		}
		[SmokeMethod("libraryPaths()")]
		public static ArrayList LibraryPaths() {
			return StaticQCoreApplication().LibraryPaths();
		}
		[SmokeMethod("addLibraryPath(const QString&)")]
		public static void AddLibraryPath(string arg1) {
			StaticQCoreApplication().AddLibraryPath(arg1);
		}
		[SmokeMethod("removeLibraryPath(const QString&)")]
		public static void RemoveLibraryPath(string arg1) {
			StaticQCoreApplication().RemoveLibraryPath(arg1);
		}
		[SmokeMethod("installTranslator(QTranslator*)")]
		public static void InstallTranslator(QTranslator messageFile) {
			StaticQCoreApplication().InstallTranslator(messageFile);
		}
		[SmokeMethod("removeTranslator(QTranslator*)")]
		public static void RemoveTranslator(QTranslator messageFile) {
			StaticQCoreApplication().RemoveTranslator(messageFile);
		}
		[SmokeMethod("translate(const char*, const char*, const char*, QCoreApplication::Encoding)")]
		public static string Translate(string context, string key, string comment, QCoreApplication.Encoding encoding) {
			return StaticQCoreApplication().Translate(context,key,comment,encoding);
		}
		[SmokeMethod("translate(const char*, const char*, const char*)")]
		public static string Translate(string context, string key, string comment) {
			return StaticQCoreApplication().Translate(context,key,comment);
		}
		[SmokeMethod("translate(const char*, const char*)")]
		public static string Translate(string context, string key) {
			return StaticQCoreApplication().Translate(context,key);
		}
		[SmokeMethod("flush()")]
		public static void Flush() {
			StaticQCoreApplication().Flush();
		}
		[SmokeMethod("quit()")]
		public static void Quit() {
			StaticQCoreApplication().Quit();
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQCoreApplication().Event(arg1);
		}
		// bool compressEvent(QEvent* arg1,QObject* arg2,QPostEventList* arg3); >>>> NOT CONVERTED
		~QCoreApplication() {
			DisposeQCoreApplication();
		}
		public new void Dispose() {
			DisposeQCoreApplication();
		}
		private void DisposeQCoreApplication() {
			ProxyQCoreApplication().DisposeQCoreApplication();
		}
		public QCoreApplication(string[] argv) : this((Type) null) {
			Qyoto.Init_qyoto();
			CreateProxy();
			Qt.qApp = (QApplication) this;
			
			string[] args = new string[argv.Length + 1];
			args[0] = System.Reflection.Assembly.GetExecutingAssembly().Location;
			argv.CopyTo(args, 1);

			NewQCoreApplication(argv.Length, argv);
		}
		[SmokeMethod("QCoreApplication(int&, char**)")]
		private void NewQCoreApplication(int argc, string[] argv) {
			ProxyQCoreApplication().NewQCoreApplication(argc, argv);
		}
		protected new IQCoreApplicationSignals Emit() {
			return (IQCoreApplicationSignals) Q_EMIT;
		}
	}

	public interface IQCoreApplicationSignals : IQObjectSignals {
		[Q_SIGNAL("void aboutToQuit()")]
		void AboutToQuit();
		[Q_SIGNAL("void unixSignal(int)")]
		void UnixSignal(int arg1);
	}
}
