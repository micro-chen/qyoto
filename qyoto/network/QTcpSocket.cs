//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTcpSocket")]
	public class QTcpSocket : QAbstractSocket, IDisposable {
 		protected QTcpSocket(Type dummy) : base((Type) null) {}
		[SmokeClass("QTcpSocket")]
		interface IQTcpSocketProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTcpSocket), this);
			_interceptor = (QTcpSocket) realProxy.GetTransparentProxy();
		}
		private QTcpSocket ProxyQTcpSocket() {
			return (QTcpSocket) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTcpSocket() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTcpSocketProxy), null);
			_staticInterceptor = (IQTcpSocketProxy) realProxy.GetTransparentProxy();
		}
		private static IQTcpSocketProxy StaticQTcpSocket() {
			return (IQTcpSocketProxy) _staticInterceptor;
		}
		public QTcpSocket(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQTcpSocket(parent);
		}
		[SmokeMethod("QTcpSocket", "(QObject*)", "#")]
		private void NewQTcpSocket(QObject parent) {
			ProxyQTcpSocket().NewQTcpSocket(parent);
		}
		public QTcpSocket() : this((Type) null) {
			CreateProxy();
			NewQTcpSocket();
		}
		[SmokeMethod("QTcpSocket", "()", "")]
		private void NewQTcpSocket() {
			ProxyQTcpSocket().NewQTcpSocket();
		}
		public static new string Tr(string s, string c) {
			return StaticQTcpSocket().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQTcpSocket().Tr(s);
		}
		~QTcpSocket() {
			DisposeQTcpSocket();
		}
		public new void Dispose() {
			DisposeQTcpSocket();
		}
		[SmokeMethod("~QTcpSocket", "()", "")]
		private void DisposeQTcpSocket() {
			ProxyQTcpSocket().DisposeQTcpSocket();
		}
		protected new IQTcpSocketSignals Emit {
			get {
				return (IQTcpSocketSignals) Q_EMIT;
			}
		}
	}

	public interface IQTcpSocketSignals : IQAbstractSocketSignals {
	}
}
