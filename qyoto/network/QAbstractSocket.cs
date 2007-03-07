//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQAbstractSocketSignals"></see> for signals emitted by QAbstractSocket
	[SmokeClass("QAbstractSocket")]
	public class QAbstractSocket : QIODevice, IDisposable {
 		protected QAbstractSocket(Type dummy) : base((Type) null) {}
		[SmokeClass("QAbstractSocket")]
		interface IQAbstractSocketProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAbstractSocket), this);
			_interceptor = (QAbstractSocket) realProxy.GetTransparentProxy();
		}
		private QAbstractSocket ProxyQAbstractSocket() {
			return (QAbstractSocket) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAbstractSocket() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAbstractSocketProxy), null);
			_staticInterceptor = (IQAbstractSocketProxy) realProxy.GetTransparentProxy();
		}
		private static IQAbstractSocketProxy StaticQAbstractSocket() {
			return (IQAbstractSocketProxy) _staticInterceptor;
		}
		public enum SocketType {
			TcpSocket = 0,
			UdpSocket = 1,
			UnknownSocketType = -1,
		}
		public enum NetworkLayerProtocol {
			IPv4Protocol = 0,
			IPv6Protocol = 1,
			UnknownNetworkLayerProtocol = -1,
		}
		public enum SocketError {
			ConnectionRefusedError = 0,
			RemoteHostClosedError = 1,
			HostNotFoundError = 2,
			SocketAccessError = 3,
			SocketResourceError = 4,
			SocketTimeoutError = 5,
			DatagramTooLargeError = 6,
			NetworkError = 7,
			AddressInUseError = 8,
			SocketAddressNotAvailableError = 9,
			UnsupportedSocketOperationError = 10,
			UnknownSocketError = -1,
		}
		public enum SocketState {
			UnconnectedState = 0,
			HostLookupState = 1,
			ConnectingState = 2,
			ConnectedState = 3,
			BoundState = 4,
			ListeningState = 5,
			ClosingState = 6,
		}
		public QAbstractSocket(QAbstractSocket.SocketType socketType, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQAbstractSocket(socketType,parent);
		}
		[SmokeMethod("QAbstractSocket", "(QAbstractSocket::SocketType, QObject*)", "$#")]
		private void NewQAbstractSocket(QAbstractSocket.SocketType socketType, QObject parent) {
			ProxyQAbstractSocket().NewQAbstractSocket(socketType,parent);
		}
		[SmokeMethod("connectToHost", "(const QString&, quint16, OpenMode)", "$$$")]
		public void ConnectToHost(string hostName, ushort port, int mode) {
			ProxyQAbstractSocket().ConnectToHost(hostName,port,mode);
		}
		[SmokeMethod("connectToHost", "(const QString&, quint16)", "$$")]
		public void ConnectToHost(string hostName, ushort port) {
			ProxyQAbstractSocket().ConnectToHost(hostName,port);
		}
		[SmokeMethod("connectToHost", "(const QHostAddress&, quint16, OpenMode)", "#$$")]
		public void ConnectToHost(QHostAddress address, ushort port, int mode) {
			ProxyQAbstractSocket().ConnectToHost(address,port,mode);
		}
		[SmokeMethod("connectToHost", "(const QHostAddress&, quint16)", "#$")]
		public void ConnectToHost(QHostAddress address, ushort port) {
			ProxyQAbstractSocket().ConnectToHost(address,port);
		}
		[SmokeMethod("disconnectFromHost", "()", "")]
		public void DisconnectFromHost() {
			ProxyQAbstractSocket().DisconnectFromHost();
		}
		[SmokeMethod("isValid", "() const", "")]
		public bool IsValid() {
			return ProxyQAbstractSocket().IsValid();
		}
		[SmokeMethod("bytesAvailable", "() const", "")]
		public new long BytesAvailable() {
			return ProxyQAbstractSocket().BytesAvailable();
		}
		[SmokeMethod("bytesToWrite", "() const", "")]
		public new long BytesToWrite() {
			return ProxyQAbstractSocket().BytesToWrite();
		}
		[SmokeMethod("canReadLine", "() const", "")]
		public new bool CanReadLine() {
			return ProxyQAbstractSocket().CanReadLine();
		}
		[SmokeMethod("localPort", "() const", "")]
		public ushort LocalPort() {
			return ProxyQAbstractSocket().LocalPort();
		}
		[SmokeMethod("localAddress", "() const", "")]
		public QHostAddress LocalAddress() {
			return ProxyQAbstractSocket().LocalAddress();
		}
		[SmokeMethod("peerPort", "() const", "")]
		public ushort PeerPort() {
			return ProxyQAbstractSocket().PeerPort();
		}
		[SmokeMethod("peerAddress", "() const", "")]
		public QHostAddress PeerAddress() {
			return ProxyQAbstractSocket().PeerAddress();
		}
		[SmokeMethod("peerName", "() const", "")]
		public string PeerName() {
			return ProxyQAbstractSocket().PeerName();
		}
		[SmokeMethod("readBufferSize", "() const", "")]
		public long ReadBufferSize() {
			return ProxyQAbstractSocket().ReadBufferSize();
		}
		[SmokeMethod("setReadBufferSize", "(qint64)", "$")]
		public void SetReadBufferSize(long size) {
			ProxyQAbstractSocket().SetReadBufferSize(size);
		}
		[SmokeMethod("abort", "()", "")]
		public void Abort() {
			ProxyQAbstractSocket().Abort();
		}
		[SmokeMethod("socketDescriptor", "() const", "")]
		public int SocketDescriptor() {
			return ProxyQAbstractSocket().SocketDescriptor();
		}
		[SmokeMethod("setSocketDescriptor", "(int, QAbstractSocket::SocketState, OpenMode)", "$$$")]
		public bool SetSocketDescriptor(int socketDescriptor, QAbstractSocket.SocketState state, int openMode) {
			return ProxyQAbstractSocket().SetSocketDescriptor(socketDescriptor,state,openMode);
		}
		[SmokeMethod("setSocketDescriptor", "(int, QAbstractSocket::SocketState)", "$$")]
		public bool SetSocketDescriptor(int socketDescriptor, QAbstractSocket.SocketState state) {
			return ProxyQAbstractSocket().SetSocketDescriptor(socketDescriptor,state);
		}
		[SmokeMethod("setSocketDescriptor", "(int)", "$")]
		public bool SetSocketDescriptor(int socketDescriptor) {
			return ProxyQAbstractSocket().SetSocketDescriptor(socketDescriptor);
		}
		[SmokeMethod("socketType", "() const", "")]
		public QAbstractSocket.SocketType socketType() {
			return ProxyQAbstractSocket().socketType();
		}
		[SmokeMethod("state", "() const", "")]
		public QAbstractSocket.SocketState State() {
			return ProxyQAbstractSocket().State();
		}
		[SmokeMethod("error", "() const", "")]
		public QAbstractSocket.SocketError Error() {
			return ProxyQAbstractSocket().Error();
		}
		[SmokeMethod("close", "()", "")]
		public new void Close() {
			ProxyQAbstractSocket().Close();
		}
		[SmokeMethod("isSequential", "() const", "")]
		public new bool IsSequential() {
			return ProxyQAbstractSocket().IsSequential();
		}
		[SmokeMethod("atEnd", "() const", "")]
		public new bool AtEnd() {
			return ProxyQAbstractSocket().AtEnd();
		}
		[SmokeMethod("flush", "()", "")]
		public bool Flush() {
			return ProxyQAbstractSocket().Flush();
		}
		[SmokeMethod("waitForConnected", "(int)", "$")]
		public bool WaitForConnected(int msecs) {
			return ProxyQAbstractSocket().WaitForConnected(msecs);
		}
		[SmokeMethod("waitForConnected", "()", "")]
		public bool WaitForConnected() {
			return ProxyQAbstractSocket().WaitForConnected();
		}
		[SmokeMethod("waitForReadyRead", "(int)", "$")]
		public new bool WaitForReadyRead(int msecs) {
			return ProxyQAbstractSocket().WaitForReadyRead(msecs);
		}
		[SmokeMethod("waitForReadyRead", "()", "")]
		public new bool WaitForReadyRead() {
			return ProxyQAbstractSocket().WaitForReadyRead();
		}
		[SmokeMethod("waitForBytesWritten", "(int)", "$")]
		public new bool WaitForBytesWritten(int msecs) {
			return ProxyQAbstractSocket().WaitForBytesWritten(msecs);
		}
		[SmokeMethod("waitForBytesWritten", "()", "")]
		public new bool WaitForBytesWritten() {
			return ProxyQAbstractSocket().WaitForBytesWritten();
		}
		[SmokeMethod("waitForDisconnected", "(int)", "$")]
		public bool WaitForDisconnected(int msecs) {
			return ProxyQAbstractSocket().WaitForDisconnected(msecs);
		}
		[SmokeMethod("waitForDisconnected", "()", "")]
		public bool WaitForDisconnected() {
			return ProxyQAbstractSocket().WaitForDisconnected();
		}
		[SmokeMethod("setProxy", "(const QNetworkProxy&)", "#")]
		public void SetProxy(QNetworkProxy networkProxy) {
			ProxyQAbstractSocket().SetProxy(networkProxy);
		}
		[SmokeMethod("proxy", "() const", "")]
		public QNetworkProxy Proxy() {
			return ProxyQAbstractSocket().Proxy();
		}
		public static new string Tr(string s, string c) {
			return StaticQAbstractSocket().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQAbstractSocket().Tr(s);
		}
		[SmokeMethod("readData", "(char*, qint64)", "$$")]
		protected new long ReadData(string data, long maxlen) {
			return ProxyQAbstractSocket().ReadData(data,maxlen);
		}
		[SmokeMethod("readLineData", "(char*, qint64)", "$$")]
		protected new long ReadLineData(string data, long maxlen) {
			return ProxyQAbstractSocket().ReadLineData(data,maxlen);
		}
		[SmokeMethod("writeData", "(const char*, qint64)", "$$")]
		protected new long WriteData(string data, long len) {
			return ProxyQAbstractSocket().WriteData(data,len);
		}
		[SmokeMethod("setSocketState", "(QAbstractSocket::SocketState)", "$")]
		protected void SetSocketState(QAbstractSocket.SocketState state) {
			ProxyQAbstractSocket().SetSocketState(state);
		}
		[SmokeMethod("setSocketError", "(QAbstractSocket::SocketError)", "$")]
		protected void SetSocketError(QAbstractSocket.SocketError socketError) {
			ProxyQAbstractSocket().SetSocketError(socketError);
		}
		[SmokeMethod("setLocalPort", "(quint16)", "$")]
		protected void SetLocalPort(ushort port) {
			ProxyQAbstractSocket().SetLocalPort(port);
		}
		[SmokeMethod("setLocalAddress", "(const QHostAddress&)", "#")]
		protected void SetLocalAddress(QHostAddress address) {
			ProxyQAbstractSocket().SetLocalAddress(address);
		}
		[SmokeMethod("setPeerPort", "(quint16)", "$")]
		protected void SetPeerPort(ushort port) {
			ProxyQAbstractSocket().SetPeerPort(port);
		}
		[SmokeMethod("setPeerAddress", "(const QHostAddress&)", "#")]
		protected void SetPeerAddress(QHostAddress address) {
			ProxyQAbstractSocket().SetPeerAddress(address);
		}
		[SmokeMethod("setPeerName", "(const QString&)", "$")]
		protected void SetPeerName(string name) {
			ProxyQAbstractSocket().SetPeerName(name);
		}
		// QAbstractSocket* QAbstractSocket(QAbstractSocket::SocketType arg1,QAbstractSocketPrivate& arg2,QObject* arg3); >>>> NOT CONVERTED
		// QAbstractSocket* QAbstractSocket(QAbstractSocket::SocketType arg1,QAbstractSocketPrivate& arg2); >>>> NOT CONVERTED
		[Q_SLOT("void connectToHostImplementation(const QString&, quint16, OpenMode)")]
		[SmokeMethod("connectToHostImplementation", "(const QString&, quint16, OpenMode)", "$$$")]
		protected void ConnectToHostImplementation(string hostName, ushort port, int mode) {
			ProxyQAbstractSocket().ConnectToHostImplementation(hostName,port,mode);
		}
		[Q_SLOT("void connectToHostImplementation(const QString&, quint16)")]
		[SmokeMethod("connectToHostImplementation", "(const QString&, quint16)", "$$")]
		protected void ConnectToHostImplementation(string hostName, ushort port) {
			ProxyQAbstractSocket().ConnectToHostImplementation(hostName,port);
		}
		[Q_SLOT("void disconnectFromHostImplementation()")]
		[SmokeMethod("disconnectFromHostImplementation", "()", "")]
		protected void DisconnectFromHostImplementation() {
			ProxyQAbstractSocket().DisconnectFromHostImplementation();
		}
		~QAbstractSocket() {
			DisposeQAbstractSocket();
		}
		public void Dispose() {
			DisposeQAbstractSocket();
		}
		[SmokeMethod("~QAbstractSocket", "()", "")]
		private void DisposeQAbstractSocket() {
			ProxyQAbstractSocket().DisposeQAbstractSocket();
		}
		protected new IQAbstractSocketSignals Emit {
			get {
				return (IQAbstractSocketSignals) Q_EMIT;
			}
		}
	}

	public interface IQAbstractSocketSignals : IQIODeviceSignals {
		[Q_SIGNAL("void hostFound()")]
		void HostFound();
		[Q_SIGNAL("void connected()")]
		void Connected();
		[Q_SIGNAL("void disconnected()")]
		void Disconnected();
		[Q_SIGNAL("void stateChanged(QAbstractSocket::SocketState)")]
		void StateChanged(QAbstractSocket.SocketState arg1);
		[Q_SIGNAL("void error(QAbstractSocket::SocketError)")]
		void Error(QAbstractSocket.SocketError arg1);
	}
}
