//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQFtpSignals"></see> for signals emitted by QFtp
	[SmokeClass("QFtp")]
	public class QFtp : QNetworkProtocol, IDisposable {
 		protected QFtp(Type dummy) : base((Type) null) {}
		interface IQFtpProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQFtpProxy() {
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

		enum E_State {
			Unconnected = 0,
			HostLookup = 1,
			Connecting = 2,
			Connected = 3,
			LoggedIn = 4,
			Closing = 5,
		}
		enum E_Error {
			NoError = 0,
			UnknownError = 1,
			HostNotFound = 2,
			ConnectionRefused = 3,
			NotConnected = 4,
		}
		enum Command {
			None = 0,
			ConnectToHost = 1,
			Login = 2,
			Close = 3,
			List = 4,
			Cd = 5,
			Get = 6,
			Put = 7,
			Remove = 8,
			Mkdir = 9,
			Rmdir = 10,
			Rename = 11,
			RawCommand = 12,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQFtp().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQFtp().ClassName();
		}
		public QFtp() : this((Type) null) {
			CreateQFtpProxy();
			CreateQFtpSignalProxy();
			NewQFtp();
		}
		[SmokeMethod("QFtp()")]
		private void NewQFtp() {
			ProxyQFtp().NewQFtp();
		}
		public QFtp(QObject parent, string name) : this((Type) null) {
			CreateQFtpProxy();
			CreateQFtpSignalProxy();
			NewQFtp(parent,name);
		}
		[SmokeMethod("QFtp(QObject*, const char*)")]
		private void NewQFtp(QObject parent, string name) {
			ProxyQFtp().NewQFtp(parent,name);
		}
		public QFtp(QObject parent) : this((Type) null) {
			CreateQFtpProxy();
			CreateQFtpSignalProxy();
			NewQFtp(parent);
		}
		[SmokeMethod("QFtp(QObject*)")]
		private void NewQFtp(QObject parent) {
			ProxyQFtp().NewQFtp(parent);
		}
		[SmokeMethod("supportedOperations() const")]
		public new int SupportedOperations() {
			return ProxyQFtp().SupportedOperations();
		}
		[SmokeMethod("connectToHost(const QString&, Q_UINT16)")]
		public int ConnectToHost(string host, ushort port) {
			return ProxyQFtp().ConnectToHost(host,port);
		}
		[SmokeMethod("connectToHost(const QString&)")]
		public int ConnectToHost(string host) {
			return ProxyQFtp().ConnectToHost(host);
		}
		[SmokeMethod("login(const QString&, const QString&)")]
		public int Login(string user, string password) {
			return ProxyQFtp().Login(user,password);
		}
		[SmokeMethod("login(const QString&)")]
		public int Login(string user) {
			return ProxyQFtp().Login(user);
		}
		[SmokeMethod("login()")]
		public int Login() {
			return ProxyQFtp().Login();
		}
		[SmokeMethod("close()")]
		public int Close() {
			return ProxyQFtp().Close();
		}
		[SmokeMethod("list(const QString&)")]
		public int List(string dir) {
			return ProxyQFtp().List(dir);
		}
		[SmokeMethod("list()")]
		public int List() {
			return ProxyQFtp().List();
		}
		[SmokeMethod("cd(const QString&)")]
		public int Cd(string dir) {
			return ProxyQFtp().Cd(dir);
		}
		[SmokeMethod("get(const QString&, QIODevice*)")]
		public int Get(string file, IQIODevice dev) {
			return ProxyQFtp().Get(file,dev);
		}
		[SmokeMethod("get(const QString&)")]
		public int Get(string file) {
			return ProxyQFtp().Get(file);
		}
		[SmokeMethod("put(const QByteArray&, const QString&)")]
		public int Put(QByteArray data, string file) {
			return ProxyQFtp().Put(data,file);
		}
		[SmokeMethod("put(QIODevice*, const QString&)")]
		public int Put(IQIODevice dev, string file) {
			return ProxyQFtp().Put(dev,file);
		}
		[SmokeMethod("remove(const QString&)")]
		public int Remove(string file) {
			return ProxyQFtp().Remove(file);
		}
		[SmokeMethod("mkdir(const QString&)")]
		public int Mkdir(string dir) {
			return ProxyQFtp().Mkdir(dir);
		}
		[SmokeMethod("rmdir(const QString&)")]
		public int Rmdir(string dir) {
			return ProxyQFtp().Rmdir(dir);
		}
		[SmokeMethod("rename(const QString&, const QString&)")]
		public int Rename(string oldname, string newname) {
			return ProxyQFtp().Rename(oldname,newname);
		}
		[SmokeMethod("rawCommand(const QString&)")]
		public int RawCommand(string command) {
			return ProxyQFtp().RawCommand(command);
		}
		[SmokeMethod("bytesAvailable() const")]
		public long BytesAvailable() {
			return ProxyQFtp().BytesAvailable();
		}
		[SmokeMethod("readBlock(char*, Q_ULONG)")]
		public long ReadBlock(string data, long maxlen) {
			return ProxyQFtp().ReadBlock(data,maxlen);
		}
		[SmokeMethod("readAll()")]
		public QByteArray ReadAll() {
			return ProxyQFtp().ReadAll();
		}
		[SmokeMethod("currentId() const")]
		public int CurrentId() {
			return ProxyQFtp().CurrentId();
		}
		[SmokeMethod("currentDevice() const")]
		public IQIODevice CurrentDevice() {
			return ProxyQFtp().CurrentDevice();
		}
		[SmokeMethod("currentCommand() const")]
		public int CurrentCommand() {
			return ProxyQFtp().CurrentCommand();
		}
		[SmokeMethod("hasPendingCommands() const")]
		public bool HasPendingCommands() {
			return ProxyQFtp().HasPendingCommands();
		}
		[SmokeMethod("clearPendingCommands()")]
		public void ClearPendingCommands() {
			ProxyQFtp().ClearPendingCommands();
		}
		[SmokeMethod("state() const")]
		public int State() {
			return ProxyQFtp().State();
		}
		[SmokeMethod("error() const")]
		public int Error() {
			return ProxyQFtp().Error();
		}
		[SmokeMethod("errorString() const")]
		public string ErrorString() {
			return ProxyQFtp().ErrorString();
		}
		[Q_SLOT("void abort()")]
		[SmokeMethod("abort()")]
		public void Abort() {
			ProxyQFtp().Abort();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQFtp().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQFtp().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQFtp().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQFtp().TrUtf8(arg1);
		}
		[SmokeMethod("parseDir(const QString&, QUrlInfo&)")]
		protected void ParseDir(string buffer, QUrlInfo info) {
			ProxyQFtp().ParseDir(buffer,info);
		}
		[SmokeMethod("operationListChildren(QNetworkOperation*)")]
		protected new void OperationListChildren(QNetworkOperation op) {
			ProxyQFtp().OperationListChildren(op);
		}
		[SmokeMethod("operationMkDir(QNetworkOperation*)")]
		protected new void OperationMkDir(QNetworkOperation op) {
			ProxyQFtp().OperationMkDir(op);
		}
		[SmokeMethod("operationRemove(QNetworkOperation*)")]
		protected new void OperationRemove(QNetworkOperation op) {
			ProxyQFtp().OperationRemove(op);
		}
		[SmokeMethod("operationRename(QNetworkOperation*)")]
		protected new void OperationRename(QNetworkOperation op) {
			ProxyQFtp().OperationRename(op);
		}
		[SmokeMethod("operationGet(QNetworkOperation*)")]
		protected new void OperationGet(QNetworkOperation op) {
			ProxyQFtp().OperationGet(op);
		}
		[SmokeMethod("operationPut(QNetworkOperation*)")]
		protected new void OperationPut(QNetworkOperation op) {
			ProxyQFtp().OperationPut(op);
		}
		[Q_SLOT("void hostFound()")]
		[SmokeMethod("hostFound()")]
		protected void HostFound() {
			ProxyQFtp().HostFound();
		}
		[Q_SLOT("void connected()")]
		[SmokeMethod("connected()")]
		protected void Connected() {
			ProxyQFtp().Connected();
		}
		[Q_SLOT("void closed()")]
		[SmokeMethod("closed()")]
		protected void Closed() {
			ProxyQFtp().Closed();
		}
		[Q_SLOT("void dataHostFound()")]
		[SmokeMethod("dataHostFound()")]
		protected void DataHostFound() {
			ProxyQFtp().DataHostFound();
		}
		[Q_SLOT("void dataConnected()")]
		[SmokeMethod("dataConnected()")]
		protected void DataConnected() {
			ProxyQFtp().DataConnected();
		}
		[Q_SLOT("void dataClosed()")]
		[SmokeMethod("dataClosed()")]
		protected void DataClosed() {
			ProxyQFtp().DataClosed();
		}
		[Q_SLOT("void dataReadyRead()")]
		[SmokeMethod("dataReadyRead()")]
		protected void DataReadyRead() {
			ProxyQFtp().DataReadyRead();
		}
		[Q_SLOT("void dataBytesWritten(int)")]
		[SmokeMethod("dataBytesWritten(int)")]
		protected void DataBytesWritten(int nbytes) {
			ProxyQFtp().DataBytesWritten(nbytes);
		}
		[Q_SLOT("void error(int)")]
		[SmokeMethod("error(int)")]
		protected void Error(int arg1) {
			ProxyQFtp().Error(arg1);
		}
		~QFtp() {
			DisposeQFtp();
		}
		public new void Dispose() {
			DisposeQFtp();
		}
		private void DisposeQFtp() {
			ProxyQFtp().DisposeQFtp();
		}
		protected void CreateQFtpSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQFtpSignals), this);
			Q_EMIT = (IQFtpSignals) realProxy.GetTransparentProxy();
		}
		protected new IQFtpSignals Emit() {
			return (IQFtpSignals) Q_EMIT;
		}
	}

	public interface IQFtpSignals : IQNetworkProtocolSignals {
		[Q_SIGNAL("void stateChanged(int)")]
		void StateChanged(int arg1);
		[Q_SIGNAL("void listInfo(const QUrlInfo&)")]
		void ListInfo(QUrlInfo arg1);
		[Q_SIGNAL("void readyRead()")]
		void ReadyRead();
		[Q_SIGNAL("void dataTransferProgress(int, int)")]
		void DataTransferProgress(int arg1, int arg2);
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
