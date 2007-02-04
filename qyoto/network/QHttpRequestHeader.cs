//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QHttpRequestHeader")]
	public class QHttpRequestHeader : QHttpHeader, IDisposable {
 		protected QHttpRequestHeader(Type dummy) : base((Type) null) {}
		[SmokeClass("QHttpRequestHeader")]
		interface IQHttpRequestHeaderProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QHttpRequestHeader), this);
			_interceptor = (QHttpRequestHeader) realProxy.GetTransparentProxy();
		}
		private QHttpRequestHeader ProxyQHttpRequestHeader() {
			return (QHttpRequestHeader) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QHttpRequestHeader() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQHttpRequestHeaderProxy), null);
			_staticInterceptor = (IQHttpRequestHeaderProxy) realProxy.GetTransparentProxy();
		}
		private static IQHttpRequestHeaderProxy StaticQHttpRequestHeader() {
			return (IQHttpRequestHeaderProxy) _staticInterceptor;
		}
		public QHttpRequestHeader() : this((Type) null) {
			CreateProxy();
			NewQHttpRequestHeader();
		}
		[SmokeMethod("QHttpRequestHeader", "()", "")]
		private void NewQHttpRequestHeader() {
			ProxyQHttpRequestHeader().NewQHttpRequestHeader();
		}
		public QHttpRequestHeader(string method, string path, int majorVer, int minorVer) : this((Type) null) {
			CreateProxy();
			NewQHttpRequestHeader(method,path,majorVer,minorVer);
		}
		[SmokeMethod("QHttpRequestHeader", "(const QString&, const QString&, int, int)", "$$$$")]
		private void NewQHttpRequestHeader(string method, string path, int majorVer, int minorVer) {
			ProxyQHttpRequestHeader().NewQHttpRequestHeader(method,path,majorVer,minorVer);
		}
		public QHttpRequestHeader(string method, string path, int majorVer) : this((Type) null) {
			CreateProxy();
			NewQHttpRequestHeader(method,path,majorVer);
		}
		[SmokeMethod("QHttpRequestHeader", "(const QString&, const QString&, int)", "$$$")]
		private void NewQHttpRequestHeader(string method, string path, int majorVer) {
			ProxyQHttpRequestHeader().NewQHttpRequestHeader(method,path,majorVer);
		}
		public QHttpRequestHeader(string method, string path) : this((Type) null) {
			CreateProxy();
			NewQHttpRequestHeader(method,path);
		}
		[SmokeMethod("QHttpRequestHeader", "(const QString&, const QString&)", "$$")]
		private void NewQHttpRequestHeader(string method, string path) {
			ProxyQHttpRequestHeader().NewQHttpRequestHeader(method,path);
		}
		public QHttpRequestHeader(QHttpRequestHeader header) : this((Type) null) {
			CreateProxy();
			NewQHttpRequestHeader(header);
		}
		[SmokeMethod("QHttpRequestHeader", "(const QHttpRequestHeader&)", "#")]
		private void NewQHttpRequestHeader(QHttpRequestHeader header) {
			ProxyQHttpRequestHeader().NewQHttpRequestHeader(header);
		}
		public QHttpRequestHeader(string str) : this((Type) null) {
			CreateProxy();
			NewQHttpRequestHeader(str);
		}
		[SmokeMethod("QHttpRequestHeader", "(const QString&)", "$")]
		private void NewQHttpRequestHeader(string str) {
			ProxyQHttpRequestHeader().NewQHttpRequestHeader(str);
		}
		[SmokeMethod("setRequest", "(const QString&, const QString&, int, int)", "$$$$")]
		public void SetRequest(string method, string path, int majorVer, int minorVer) {
			ProxyQHttpRequestHeader().SetRequest(method,path,majorVer,minorVer);
		}
		[SmokeMethod("setRequest", "(const QString&, const QString&, int)", "$$$")]
		public void SetRequest(string method, string path, int majorVer) {
			ProxyQHttpRequestHeader().SetRequest(method,path,majorVer);
		}
		[SmokeMethod("setRequest", "(const QString&, const QString&)", "$$")]
		public void SetRequest(string method, string path) {
			ProxyQHttpRequestHeader().SetRequest(method,path);
		}
		[SmokeMethod("method", "() const", "")]
		public string Method() {
			return ProxyQHttpRequestHeader().Method();
		}
		[SmokeMethod("path", "() const", "")]
		public string Path() {
			return ProxyQHttpRequestHeader().Path();
		}
		[SmokeMethod("majorVersion", "() const", "")]
		public new int MajorVersion() {
			return ProxyQHttpRequestHeader().MajorVersion();
		}
		[SmokeMethod("minorVersion", "() const", "")]
		public new int MinorVersion() {
			return ProxyQHttpRequestHeader().MinorVersion();
		}
		[SmokeMethod("toString", "() const", "")]
		public new string ToString() {
			return ProxyQHttpRequestHeader().ToString();
		}
		[SmokeMethod("parseLine", "(const QString&, int)", "$$")]
		protected new bool ParseLine(string line, int number) {
			return ProxyQHttpRequestHeader().ParseLine(line,number);
		}
		~QHttpRequestHeader() {
			DisposeQHttpRequestHeader();
		}
		public new void Dispose() {
			DisposeQHttpRequestHeader();
		}
		[SmokeMethod("~QHttpRequestHeader", "()", "")]
		private void DisposeQHttpRequestHeader() {
			ProxyQHttpRequestHeader().DisposeQHttpRequestHeader();
		}
	}
}
