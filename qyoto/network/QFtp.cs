//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQFtpSignals"></see> for signals emitted by QFtp
	[SmokeClass("QFtp")]
	public class QFtp : QObject, IDisposable {
 		protected QFtp(Type dummy) : base((Type) null) {}
		[SmokeClass("QFtp")]
		interface IQFtpProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFtp), this);
			_interceptor = (QFtp) realProxy.GetTransparentProxy();
		}
		private QFtp ProxyQFtp() {
			return (QFtp) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFtp() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFtpProxy), null);
			_staticInterceptor = (IQFtpProxy) realProxy.GetTransparentProxy();
		}
		private static IQFtpProxy StaticQFtp() {
			return (IQFtpProxy) _staticInterceptor;
		}
		public enum State {
			Unconnected = 0,
			HostLookup = 1,
			Connecting = 2,
			Connected = 3,
			LoggedIn = 4,
			Closing = 5,
		}
		public enum Error {
			NoError = 0,
			UnknownError = 1,
			HostNotFound = 2,
			ConnectionRefused = 3,
			NotConnected = 4,
		}
		public enum Command {
			None = 0,
			SetTransferMode = 1,
			SetProxy = 2,
			ConnectToHost = 3,
			Login = 4,
			Close = 5,
			List = 6,
			Cd = 7,
			Get = 8,
			Put = 9,
			Remove = 10,
			Mkdir = 11,
			Rmdir = 12,
			Rename = 13,
			RawCommand = 14,
		}
		public enum TransferMode {
			Active = 0,
			Passive = 1,
		}
		public enum TransferType {
			Binary = 0,
			Ascii = 1,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QFtp(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQFtp(parent);
		}
		[SmokeMethod("QFtp", "(QObject*)", "#")]
		private void NewQFtp(QObject parent) {
			ProxyQFtp().NewQFtp(parent);
		}
		public QFtp() : this((Type) null) {
			CreateProxy();
			NewQFtp();
		}
		[SmokeMethod("QFtp", "()", "")]
		private void NewQFtp() {
			ProxyQFtp().NewQFtp();
		}
		[SmokeMethod("setProxy", "(const QString&, quint16)", "$$")]
		public int SetProxy(string host, ushort port) {
			return ProxyQFtp().SetProxy(host,port);
		}
		[SmokeMethod("connectToHost", "(const QString&, quint16)", "$$")]
		public int ConnectToHost(string host, ushort port) {
			return ProxyQFtp().ConnectToHost(host,port);
		}
		[SmokeMethod("connectToHost", "(const QString&)", "$")]
		public int ConnectToHost(string host) {
			return ProxyQFtp().ConnectToHost(host);
		}
		[SmokeMethod("login", "(const QString&, const QString&)", "$$")]
		public int Login(string user, string password) {
			return ProxyQFtp().Login(user,password);
		}
		[SmokeMethod("login", "(const QString&)", "$")]
		public int Login(string user) {
			return ProxyQFtp().Login(user);
		}
		[SmokeMethod("login", "()", "")]
		public int Login() {
			return ProxyQFtp().Login();
		}
		[SmokeMethod("close", "()", "")]
		public int Close() {
			return ProxyQFtp().Close();
		}
		[SmokeMethod("setTransferMode", "(QFtp::TransferMode)", "$")]
		public int SetTransferMode(QFtp.TransferMode mode) {
			return ProxyQFtp().SetTransferMode(mode);
		}
		[SmokeMethod("list", "(const QString&)", "$")]
		public int List(string dir) {
			return ProxyQFtp().List(dir);
		}
		[SmokeMethod("list", "()", "")]
		public int List() {
			return ProxyQFtp().List();
		}
		[SmokeMethod("cd", "(const QString&)", "$")]
		public int Cd(string dir) {
			return ProxyQFtp().Cd(dir);
		}
		[SmokeMethod("get", "(const QString&, QIODevice*, QFtp::TransferType)", "$#$")]
		public int Get(string file, IQIODevice dev, QFtp.TransferType type) {
			return ProxyQFtp().Get(file,dev,type);
		}
		[SmokeMethod("get", "(const QString&, QIODevice*)", "$#")]
		public int Get(string file, IQIODevice dev) {
			return ProxyQFtp().Get(file,dev);
		}
		[SmokeMethod("get", "(const QString&)", "$")]
		public int Get(string file) {
			return ProxyQFtp().Get(file);
		}
		[SmokeMethod("put", "(const QByteArray&, const QString&, QFtp::TransferType)", "#$$")]
		public int Put(QByteArray data, string file, QFtp.TransferType type) {
			return ProxyQFtp().Put(data,file,type);
		}
		[SmokeMethod("put", "(const QByteArray&, const QString&)", "#$")]
		public int Put(QByteArray data, string file) {
			return ProxyQFtp().Put(data,file);
		}
		[SmokeMethod("put", "(QIODevice*, const QString&, QFtp::TransferType)", "#$$")]
		public int Put(IQIODevice dev, string file, QFtp.TransferType type) {
			return ProxyQFtp().Put(dev,file,type);
		}
		[SmokeMethod("put", "(QIODevice*, const QString&)", "#$")]
		public int Put(IQIODevice dev, string file) {
			return ProxyQFtp().Put(dev,file);
		}
		[SmokeMethod("remove", "(const QString&)", "$")]
		public int Remove(string file) {
			return ProxyQFtp().Remove(file);
		}
		[SmokeMethod("mkdir", "(const QString&)", "$")]
		public int Mkdir(string dir) {
			return ProxyQFtp().Mkdir(dir);
		}
		[SmokeMethod("rmdir", "(const QString&)", "$")]
		public int Rmdir(string dir) {
			return ProxyQFtp().Rmdir(dir);
		}
		[SmokeMethod("rename", "(const QString&, const QString&)", "$$")]
		public int Rename(string oldname, string newname) {
			return ProxyQFtp().Rename(oldname,newname);
		}
		[SmokeMethod("rawCommand", "(const QString&)", "$")]
		public int RawCommand(string command) {
			return ProxyQFtp().RawCommand(command);
		}
		[SmokeMethod("bytesAvailable", "() const", "")]
		public long BytesAvailable() {
			return ProxyQFtp().BytesAvailable();
		}
		[SmokeMethod("read", "(char*, qint64)", "$$")]
		public long Read(string data, long maxlen) {
			return ProxyQFtp().Read(data,maxlen);
		}
		[SmokeMethod("readAll", "()", "")]
		public QByteArray ReadAll() {
			return ProxyQFtp().ReadAll();
		}
		[SmokeMethod("currentId", "() const", "")]
		public int CurrentId() {
			return ProxyQFtp().CurrentId();
		}
		[SmokeMethod("currentDevice", "() const", "")]
		public IQIODevice CurrentDevice() {
			return ProxyQFtp().CurrentDevice();
		}
		[SmokeMethod("currentCommand", "() const", "")]
		public QFtp.Command CurrentCommand() {
			return ProxyQFtp().CurrentCommand();
		}
		[SmokeMethod("hasPendingCommands", "() const", "")]
		public bool HasPendingCommands() {
			return ProxyQFtp().HasPendingCommands();
		}
		[SmokeMethod("clearPendingCommands", "()", "")]
		public void ClearPendingCommands() {
			ProxyQFtp().ClearPendingCommands();
		}
		[SmokeMethod("state", "() const", "")]
		public QFtp.State state() {
			return ProxyQFtp().state();
		}
		[SmokeMethod("error", "() const", "")]
		public QFtp.Error error() {
			return ProxyQFtp().error();
		}
		[SmokeMethod("errorString", "() const", "")]
		public string ErrorString() {
			return ProxyQFtp().ErrorString();
		}
		[Q_SLOT("void abort()")]
		[SmokeMethod("abort", "()", "")]
		public void Abort() {
			ProxyQFtp().Abort();
		}
		public static new string Tr(string s, string c) {
			return StaticQFtp().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQFtp().Tr(s);
		}
		~QFtp() {
			DisposeQFtp();
		}
		public new void Dispose() {
			DisposeQFtp();
		}
		[SmokeMethod("~QFtp", "()", "")]
		private void DisposeQFtp() {
			ProxyQFtp().DisposeQFtp();
		}
		protected new IQFtpSignals Emit {
			get {
				return (IQFtpSignals) Q_EMIT;
			}
		}
	}

	public interface IQFtpSignals : IQObjectSignals {
		[Q_SIGNAL("void stateChanged(int)")]
		void StateChanged(int arg1);
		[Q_SIGNAL("void listInfo(const QUrlInfo&)")]
		void ListInfo(QUrlInfo arg1);
		[Q_SIGNAL("void readyRead()")]
		void ReadyRead();
		[Q_SIGNAL("void dataTransferProgress(qint64, qint64)")]
		void DataTransferProgress(long arg1, long arg2);
		[Q_SIGNAL("void rawCommandReply(int, const QString&)")]
		void RawCommandReply(int arg1, string arg2);
		[Q_SIGNAL("void commandStarted(int)")]
		void CommandStarted(int arg1);
		[Q_SIGNAL("void commandFinished(int, bool)")]
		void CommandFinished(int arg1, bool arg2);
		[Q_SIGNAL("void done(bool)")]
		void Done(bool arg1);
	}
}
