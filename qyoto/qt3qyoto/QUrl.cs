//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public interface IQUrl {
			string Protocol();
			void SetProtocol(string protocol);
			string User();
			void SetUser(string user);
			bool HasUser();
			string Password();
			void SetPassword(string pass);
			bool HasPassword();
			string Host();
			void SetHost(string user);
			bool HasHost();
			int Port();
			void SetPort(int port);
			bool HasPort();
			string Path(bool correct);
			string Path();
			void SetPath(string path);
			bool HasPath();
			void SetEncodedPathAndQuery(string enc);
			string EncodedPathAndQuery();
			void SetQuery(string txt);
			string Query();
			string Ref();
			void SetRef(string txt);
			bool HasRef();
			bool IsValid();
			bool IsLocalFile();
			void AddPath(string path);
			void SetFileName(string txt);
			string FileName();
			string DirPath();
			string ToString(bool encodedPath, bool forcePrependProtocol);
			string ToString(bool encodedPath);
			string ToString();
			bool CdUp();
	}

	[SmokeClass("QUrl")]
	public class QUrl : MarshalByRefObject, IQUrl, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QUrl(Type dummy) {}
		interface IQUrlProxy {
			void Decode(StringBuilder url);
			void Encode(StringBuilder url);
			bool IsRelativeUrl(string url);
		}

		protected void CreateQUrlProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QUrl), this);
			_interceptor = (QUrl) realProxy.GetTransparentProxy();
		}
		private QUrl ProxyQUrl() {
			return (QUrl) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QUrl() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQUrlProxy), null);
			_staticInterceptor = (IQUrlProxy) realProxy.GetTransparentProxy();
		}
		private static IQUrlProxy StaticQUrl() {
			return (IQUrlProxy) _staticInterceptor;
		}

		public QUrl() : this((Type) null) {
			CreateQUrlProxy();
			NewQUrl();
		}
		[SmokeMethod("QUrl()")]
		private void NewQUrl() {
			ProxyQUrl().NewQUrl();
		}
		public QUrl(string url) : this((Type) null) {
			CreateQUrlProxy();
			NewQUrl(url);
		}
		[SmokeMethod("QUrl(const QString&)")]
		private void NewQUrl(string url) {
			ProxyQUrl().NewQUrl(url);
		}
		public QUrl(IQUrl url) : this((Type) null) {
			CreateQUrlProxy();
			NewQUrl(url);
		}
		[SmokeMethod("QUrl(const QUrl&)")]
		private void NewQUrl(IQUrl url) {
			ProxyQUrl().NewQUrl(url);
		}
		public QUrl(IQUrl url, string relUrl, bool checkSlash) : this((Type) null) {
			CreateQUrlProxy();
			NewQUrl(url,relUrl,checkSlash);
		}
		[SmokeMethod("QUrl(const QUrl&, const QString&, bool)")]
		private void NewQUrl(IQUrl url, string relUrl, bool checkSlash) {
			ProxyQUrl().NewQUrl(url,relUrl,checkSlash);
		}
		public QUrl(IQUrl url, string relUrl) : this((Type) null) {
			CreateQUrlProxy();
			NewQUrl(url,relUrl);
		}
		[SmokeMethod("QUrl(const QUrl&, const QString&)")]
		private void NewQUrl(IQUrl url, string relUrl) {
			ProxyQUrl().NewQUrl(url,relUrl);
		}
		[SmokeMethod("protocol() const")]
		public string Protocol() {
			return ProxyQUrl().Protocol();
		}
		[SmokeMethod("setProtocol(const QString&)")]
		public virtual void SetProtocol(string protocol) {
			ProxyQUrl().SetProtocol(protocol);
		}
		[SmokeMethod("user() const")]
		public string User() {
			return ProxyQUrl().User();
		}
		[SmokeMethod("setUser(const QString&)")]
		public virtual void SetUser(string user) {
			ProxyQUrl().SetUser(user);
		}
		[SmokeMethod("hasUser() const")]
		public bool HasUser() {
			return ProxyQUrl().HasUser();
		}
		[SmokeMethod("password() const")]
		public string Password() {
			return ProxyQUrl().Password();
		}
		[SmokeMethod("setPassword(const QString&)")]
		public virtual void SetPassword(string pass) {
			ProxyQUrl().SetPassword(pass);
		}
		[SmokeMethod("hasPassword() const")]
		public bool HasPassword() {
			return ProxyQUrl().HasPassword();
		}
		[SmokeMethod("host() const")]
		public string Host() {
			return ProxyQUrl().Host();
		}
		[SmokeMethod("setHost(const QString&)")]
		public virtual void SetHost(string user) {
			ProxyQUrl().SetHost(user);
		}
		[SmokeMethod("hasHost() const")]
		public bool HasHost() {
			return ProxyQUrl().HasHost();
		}
		[SmokeMethod("port() const")]
		public int Port() {
			return ProxyQUrl().Port();
		}
		[SmokeMethod("setPort(int)")]
		public virtual void SetPort(int port) {
			ProxyQUrl().SetPort(port);
		}
		[SmokeMethod("hasPort() const")]
		public bool HasPort() {
			return ProxyQUrl().HasPort();
		}
		[SmokeMethod("path(bool) const")]
		public string Path(bool correct) {
			return ProxyQUrl().Path(correct);
		}
		[SmokeMethod("path() const")]
		public string Path() {
			return ProxyQUrl().Path();
		}
		[SmokeMethod("setPath(const QString&)")]
		public virtual void SetPath(string path) {
			ProxyQUrl().SetPath(path);
		}
		[SmokeMethod("hasPath() const")]
		public bool HasPath() {
			return ProxyQUrl().HasPath();
		}
		[SmokeMethod("setEncodedPathAndQuery(const QString&)")]
		public virtual void SetEncodedPathAndQuery(string enc) {
			ProxyQUrl().SetEncodedPathAndQuery(enc);
		}
		[SmokeMethod("encodedPathAndQuery()")]
		public string EncodedPathAndQuery() {
			return ProxyQUrl().EncodedPathAndQuery();
		}
		[SmokeMethod("setQuery(const QString&)")]
		public virtual void SetQuery(string txt) {
			ProxyQUrl().SetQuery(txt);
		}
		[SmokeMethod("query() const")]
		public string Query() {
			return ProxyQUrl().Query();
		}
		[SmokeMethod("ref() const")]
		public string Ref() {
			return ProxyQUrl().Ref();
		}
		[SmokeMethod("setRef(const QString&)")]
		public virtual void SetRef(string txt) {
			ProxyQUrl().SetRef(txt);
		}
		[SmokeMethod("hasRef() const")]
		public bool HasRef() {
			return ProxyQUrl().HasRef();
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQUrl().IsValid();
		}
		[SmokeMethod("isLocalFile() const")]
		public bool IsLocalFile() {
			return ProxyQUrl().IsLocalFile();
		}
		[SmokeMethod("addPath(const QString&)")]
		public virtual void AddPath(string path) {
			ProxyQUrl().AddPath(path);
		}
		[SmokeMethod("setFileName(const QString&)")]
		public virtual void SetFileName(string txt) {
			ProxyQUrl().SetFileName(txt);
		}
		[SmokeMethod("fileName() const")]
		public string FileName() {
			return ProxyQUrl().FileName();
		}
		[SmokeMethod("dirPath() const")]
		public string DirPath() {
			return ProxyQUrl().DirPath();
		}
		//  operator QString(); >>>> NOT CONVERTED
		[SmokeMethod("toString(bool, bool) const")]
		public new virtual string ToString(bool encodedPath, bool forcePrependProtocol) {
			return ProxyQUrl().ToString(encodedPath,forcePrependProtocol);
		}
		[SmokeMethod("toString(bool) const")]
		public new virtual string ToString(bool encodedPath) {
			return ProxyQUrl().ToString(encodedPath);
		}
		[SmokeMethod("toString() const")]
		public new virtual string ToString() {
			return ProxyQUrl().ToString();
		}
		[SmokeMethod("cdUp()")]
		public virtual bool CdUp() {
			return ProxyQUrl().CdUp();
		}
		[SmokeMethod("decode(QString&)")]
		public static void Decode(StringBuilder url) {
			StaticQUrl().Decode(url);
		}
		[SmokeMethod("encode(QString&)")]
		public static void Encode(StringBuilder url) {
			StaticQUrl().Encode(url);
		}
		[SmokeMethod("isRelativeUrl(const QString&)")]
		public static bool IsRelativeUrl(string url) {
			return StaticQUrl().IsRelativeUrl(url);
		}
		[SmokeMethod("reset()")]
		protected virtual void Reset() {
			ProxyQUrl().Reset();
		}
		[SmokeMethod("parse(const QString&)")]
		protected virtual bool Parse(string url) {
			return ProxyQUrl().Parse(url);
		}
		~QUrl() {
			DisposeQUrl();
		}
		public void Dispose() {
			DisposeQUrl();
		}
		private void DisposeQUrl() {
			ProxyQUrl().DisposeQUrl();
		}
	}
}
