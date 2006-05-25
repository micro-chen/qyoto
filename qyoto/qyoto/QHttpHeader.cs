//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QHttpHeader")]
	public class QHttpHeader : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QHttpHeader(Type dummy) {}
		interface IQHttpHeaderProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QHttpHeader), this);
			_interceptor = (QHttpHeader) realProxy.GetTransparentProxy();
		}
		private QHttpHeader ProxyQHttpHeader() {
			return (QHttpHeader) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QHttpHeader() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQHttpHeaderProxy), null);
			_staticInterceptor = (IQHttpHeaderProxy) realProxy.GetTransparentProxy();
		}
		private static IQHttpHeaderProxy StaticQHttpHeader() {
			return (IQHttpHeaderProxy) _staticInterceptor;
		}

		public QHttpHeader() : this((Type) null) {
			CreateProxy();
			NewQHttpHeader();
		}
		[SmokeMethod("QHttpHeader()")]
		private void NewQHttpHeader() {
			ProxyQHttpHeader().NewQHttpHeader();
		}
		public QHttpHeader(QHttpHeader header) : this((Type) null) {
			CreateProxy();
			NewQHttpHeader(header);
		}
		[SmokeMethod("QHttpHeader(const QHttpHeader&)")]
		private void NewQHttpHeader(QHttpHeader header) {
			ProxyQHttpHeader().NewQHttpHeader(header);
		}
		public QHttpHeader(string str) : this((Type) null) {
			CreateProxy();
			NewQHttpHeader(str);
		}
		[SmokeMethod("QHttpHeader(const QString&)")]
		private void NewQHttpHeader(string str) {
			ProxyQHttpHeader().NewQHttpHeader(str);
		}
		[SmokeMethod("setValue(const QString&, const QString&)")]
		public void SetValue(string key, string value) {
			ProxyQHttpHeader().SetValue(key,value);
		}
		[SmokeMethod("setValues(const QList<QPair<QString, QString> >&)")]
		public void SetValues(string values) {
			ProxyQHttpHeader().SetValues(values);
		}
		[SmokeMethod("addValue(const QString&, const QString&)")]
		public void AddValue(string key, string value) {
			ProxyQHttpHeader().AddValue(key,value);
		}
		[SmokeMethod("values() const")]
		public string Values() {
			return ProxyQHttpHeader().Values();
		}
		[SmokeMethod("hasKey(const QString&) const")]
		public bool HasKey(string key) {
			return ProxyQHttpHeader().HasKey(key);
		}
		[SmokeMethod("keys() const")]
		public ArrayList Keys() {
			return ProxyQHttpHeader().Keys();
		}
		[SmokeMethod("value(const QString&) const")]
		public string Value(string key) {
			return ProxyQHttpHeader().Value(key);
		}
		[SmokeMethod("allValues(const QString&) const")]
		public ArrayList AllValues(string key) {
			return ProxyQHttpHeader().AllValues(key);
		}
		[SmokeMethod("removeValue(const QString&)")]
		public void RemoveValue(string key) {
			ProxyQHttpHeader().RemoveValue(key);
		}
		[SmokeMethod("removeAllValues(const QString&)")]
		public void RemoveAllValues(string key) {
			ProxyQHttpHeader().RemoveAllValues(key);
		}
		[SmokeMethod("hasContentLength() const")]
		public bool HasContentLength() {
			return ProxyQHttpHeader().HasContentLength();
		}
		[SmokeMethod("contentLength() const")]
		public uint ContentLength() {
			return ProxyQHttpHeader().ContentLength();
		}
		[SmokeMethod("setContentLength(int)")]
		public void SetContentLength(int len) {
			ProxyQHttpHeader().SetContentLength(len);
		}
		[SmokeMethod("hasContentType() const")]
		public bool HasContentType() {
			return ProxyQHttpHeader().HasContentType();
		}
		[SmokeMethod("contentType() const")]
		public string ContentType() {
			return ProxyQHttpHeader().ContentType();
		}
		[SmokeMethod("setContentType(const QString&)")]
		public void SetContentType(string type) {
			ProxyQHttpHeader().SetContentType(type);
		}
		[SmokeMethod("toString() const")]
		public new virtual string ToString() {
			return ProxyQHttpHeader().ToString();
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQHttpHeader().IsValid();
		}
		[SmokeMethod("majorVersion() const")]
		public virtual int MajorVersion() {
			return ProxyQHttpHeader().MajorVersion();
		}
		[SmokeMethod("minorVersion() const")]
		public virtual int MinorVersion() {
			return ProxyQHttpHeader().MinorVersion();
		}
		~QHttpHeader() {
			DisposeQHttpHeader();
		}
		public void Dispose() {
			DisposeQHttpHeader();
		}
		private void DisposeQHttpHeader() {
			ProxyQHttpHeader().DisposeQHttpHeader();
		}
	}
}
