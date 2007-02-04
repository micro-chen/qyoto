//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QNetworkProxy")]
	public class QNetworkProxy : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QNetworkProxy(Type dummy) {}
		[SmokeClass("QNetworkProxy")]
		interface IQNetworkProxyProxy {
			[SmokeMethod("setApplicationProxy", "(const QNetworkProxy&)", "#")]
			void SetApplicationProxy(QNetworkProxy proxy);
			[SmokeMethod("applicationProxy", "()", "")]
			QNetworkProxy ApplicationProxy();
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QNetworkProxy), this);
			_interceptor = (QNetworkProxy) realProxy.GetTransparentProxy();
		}
		private QNetworkProxy ProxyQNetworkProxy() {
			return (QNetworkProxy) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QNetworkProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQNetworkProxyProxy), null);
			_staticInterceptor = (IQNetworkProxyProxy) realProxy.GetTransparentProxy();
		}
		private static IQNetworkProxyProxy StaticQNetworkProxy() {
			return (IQNetworkProxyProxy) _staticInterceptor;
		}
		public enum ProxyType {
			DefaultProxy = 0,
			Socks5Proxy = 1,
			NoProxy = 2,
		}
		public QNetworkProxy() : this((Type) null) {
			CreateProxy();
			NewQNetworkProxy();
		}
		[SmokeMethod("QNetworkProxy", "()", "")]
		private void NewQNetworkProxy() {
			ProxyQNetworkProxy().NewQNetworkProxy();
		}
		public QNetworkProxy(QNetworkProxy.ProxyType type, string hostName, ushort port, string user, string password) : this((Type) null) {
			CreateProxy();
			NewQNetworkProxy(type,hostName,port,user,password);
		}
		[SmokeMethod("QNetworkProxy", "(QNetworkProxy::ProxyType, const QString&, quint16, const QString&, const QString&)", "$$$$$")]
		private void NewQNetworkProxy(QNetworkProxy.ProxyType type, string hostName, ushort port, string user, string password) {
			ProxyQNetworkProxy().NewQNetworkProxy(type,hostName,port,user,password);
		}
		public QNetworkProxy(QNetworkProxy.ProxyType type, string hostName, ushort port, string user) : this((Type) null) {
			CreateProxy();
			NewQNetworkProxy(type,hostName,port,user);
		}
		[SmokeMethod("QNetworkProxy", "(QNetworkProxy::ProxyType, const QString&, quint16, const QString&)", "$$$$")]
		private void NewQNetworkProxy(QNetworkProxy.ProxyType type, string hostName, ushort port, string user) {
			ProxyQNetworkProxy().NewQNetworkProxy(type,hostName,port,user);
		}
		public QNetworkProxy(QNetworkProxy.ProxyType type, string hostName, ushort port) : this((Type) null) {
			CreateProxy();
			NewQNetworkProxy(type,hostName,port);
		}
		[SmokeMethod("QNetworkProxy", "(QNetworkProxy::ProxyType, const QString&, quint16)", "$$$")]
		private void NewQNetworkProxy(QNetworkProxy.ProxyType type, string hostName, ushort port) {
			ProxyQNetworkProxy().NewQNetworkProxy(type,hostName,port);
		}
		public QNetworkProxy(QNetworkProxy.ProxyType type, string hostName) : this((Type) null) {
			CreateProxy();
			NewQNetworkProxy(type,hostName);
		}
		[SmokeMethod("QNetworkProxy", "(QNetworkProxy::ProxyType, const QString&)", "$$")]
		private void NewQNetworkProxy(QNetworkProxy.ProxyType type, string hostName) {
			ProxyQNetworkProxy().NewQNetworkProxy(type,hostName);
		}
		public QNetworkProxy(QNetworkProxy.ProxyType type) : this((Type) null) {
			CreateProxy();
			NewQNetworkProxy(type);
		}
		[SmokeMethod("QNetworkProxy", "(QNetworkProxy::ProxyType)", "$")]
		private void NewQNetworkProxy(QNetworkProxy.ProxyType type) {
			ProxyQNetworkProxy().NewQNetworkProxy(type);
		}
		public QNetworkProxy(QNetworkProxy other) : this((Type) null) {
			CreateProxy();
			NewQNetworkProxy(other);
		}
		[SmokeMethod("QNetworkProxy", "(const QNetworkProxy&)", "#")]
		private void NewQNetworkProxy(QNetworkProxy other) {
			ProxyQNetworkProxy().NewQNetworkProxy(other);
		}
		[SmokeMethod("setType", "(QNetworkProxy::ProxyType)", "$")]
		public void SetType(QNetworkProxy.ProxyType type) {
			ProxyQNetworkProxy().SetType(type);
		}
		[SmokeMethod("type", "() const", "")]
		public QNetworkProxy.ProxyType type() {
			return ProxyQNetworkProxy().type();
		}
		[SmokeMethod("setUser", "(const QString&)", "$")]
		public void SetUser(string userName) {
			ProxyQNetworkProxy().SetUser(userName);
		}
		[SmokeMethod("user", "() const", "")]
		public string User() {
			return ProxyQNetworkProxy().User();
		}
		[SmokeMethod("setPassword", "(const QString&)", "$")]
		public void SetPassword(string password) {
			ProxyQNetworkProxy().SetPassword(password);
		}
		[SmokeMethod("password", "() const", "")]
		public string Password() {
			return ProxyQNetworkProxy().Password();
		}
		[SmokeMethod("setHostName", "(const QString&)", "$")]
		public void SetHostName(string hostName) {
			ProxyQNetworkProxy().SetHostName(hostName);
		}
		[SmokeMethod("hostName", "() const", "")]
		public string HostName() {
			return ProxyQNetworkProxy().HostName();
		}
		[SmokeMethod("setPort", "(quint16)", "$")]
		public void SetPort(ushort port) {
			ProxyQNetworkProxy().SetPort(port);
		}
		[SmokeMethod("port", "() const", "")]
		public ushort Port() {
			return ProxyQNetworkProxy().Port();
		}
		public static void SetApplicationProxy(QNetworkProxy proxy) {
			StaticQNetworkProxy().SetApplicationProxy(proxy);
		}
		public static QNetworkProxy ApplicationProxy() {
			return StaticQNetworkProxy().ApplicationProxy();
		}
		~QNetworkProxy() {
			DisposeQNetworkProxy();
		}
		public void Dispose() {
			DisposeQNetworkProxy();
		}
		[SmokeMethod("~QNetworkProxy", "()", "")]
		private void DisposeQNetworkProxy() {
			ProxyQNetworkProxy().DisposeQNetworkProxy();
		}
	}
}
