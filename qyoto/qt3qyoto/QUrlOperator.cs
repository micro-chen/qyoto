//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQUrlOperatorSignals"></see> for signals emitted by QUrlOperator
	[SmokeClass("QUrlOperator")]
	public class QUrlOperator : QObject, IQUrl, IDisposable {
 		protected QUrlOperator(Type dummy) : base((Type) null) {}
		interface IQUrlOperatorProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
			void Decode(StringBuilder url);
			void Encode(StringBuilder url);
			bool IsRelativeUrl(string url);
		}

		protected void CreateQUrlOperatorProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QUrlOperator), this);
			_interceptor = (QUrlOperator) realProxy.GetTransparentProxy();
		}
		private QUrlOperator ProxyQUrlOperator() {
			return (QUrlOperator) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QUrlOperator() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQUrlOperatorProxy), null);
			_staticInterceptor = (IQUrlOperatorProxy) realProxy.GetTransparentProxy();
		}
		private static IQUrlOperatorProxy StaticQUrlOperator() {
			return (IQUrlOperatorProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQUrlOperator().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQUrlOperator().ClassName();
		}
		public QUrlOperator() : this((Type) null) {
			CreateQUrlOperatorProxy();
			CreateQUrlOperatorSignalProxy();
			NewQUrlOperator();
		}
		[SmokeMethod("QUrlOperator()")]
		private void NewQUrlOperator() {
			ProxyQUrlOperator().NewQUrlOperator();
		}
		public QUrlOperator(string urL) : this((Type) null) {
			CreateQUrlOperatorProxy();
			CreateQUrlOperatorSignalProxy();
			NewQUrlOperator(urL);
		}
		[SmokeMethod("QUrlOperator(const QString&)")]
		private void NewQUrlOperator(string urL) {
			ProxyQUrlOperator().NewQUrlOperator(urL);
		}
		public QUrlOperator(QUrlOperator url) : this((Type) null) {
			CreateQUrlOperatorProxy();
			CreateQUrlOperatorSignalProxy();
			NewQUrlOperator(url);
		}
		[SmokeMethod("QUrlOperator(const QUrlOperator&)")]
		private void NewQUrlOperator(QUrlOperator url) {
			ProxyQUrlOperator().NewQUrlOperator(url);
		}
		public QUrlOperator(QUrlOperator url, string relUrl, bool checkSlash) : this((Type) null) {
			CreateQUrlOperatorProxy();
			CreateQUrlOperatorSignalProxy();
			NewQUrlOperator(url,relUrl,checkSlash);
		}
		[SmokeMethod("QUrlOperator(const QUrlOperator&, const QString&, bool)")]
		private void NewQUrlOperator(QUrlOperator url, string relUrl, bool checkSlash) {
			ProxyQUrlOperator().NewQUrlOperator(url,relUrl,checkSlash);
		}
		public QUrlOperator(QUrlOperator url, string relUrl) : this((Type) null) {
			CreateQUrlOperatorProxy();
			CreateQUrlOperatorSignalProxy();
			NewQUrlOperator(url,relUrl);
		}
		[SmokeMethod("QUrlOperator(const QUrlOperator&, const QString&)")]
		private void NewQUrlOperator(QUrlOperator url, string relUrl) {
			ProxyQUrlOperator().NewQUrlOperator(url,relUrl);
		}
		[SmokeMethod("setPath(const QString&)")]
		public virtual void SetPath(string path) {
			ProxyQUrlOperator().SetPath(path);
		}
		[SmokeMethod("cdUp()")]
		public virtual bool CdUp() {
			return ProxyQUrlOperator().CdUp();
		}
		[SmokeMethod("listChildren()")]
		public virtual QNetworkOperation ListChildren() {
			return ProxyQUrlOperator().ListChildren();
		}
		[SmokeMethod("mkdir(const QString&)")]
		public virtual QNetworkOperation Mkdir(string dirname) {
			return ProxyQUrlOperator().Mkdir(dirname);
		}
		[SmokeMethod("remove(const QString&)")]
		public virtual QNetworkOperation Remove(string filename) {
			return ProxyQUrlOperator().Remove(filename);
		}
		[SmokeMethod("rename(const QString&, const QString&)")]
		public virtual QNetworkOperation Rename(string oldname, string newname) {
			return ProxyQUrlOperator().Rename(oldname,newname);
		}
		[SmokeMethod("get(const QString&)")]
		public virtual QNetworkOperation Get(string location) {
			return ProxyQUrlOperator().Get(location);
		}
		[SmokeMethod("get()")]
		public virtual QNetworkOperation Get() {
			return ProxyQUrlOperator().Get();
		}
		[SmokeMethod("put(const QByteArray&, const QString&)")]
		public virtual QNetworkOperation Put(QByteArray data, string location) {
			return ProxyQUrlOperator().Put(data,location);
		}
		[SmokeMethod("put(const QByteArray&)")]
		public virtual QNetworkOperation Put(QByteArray data) {
			return ProxyQUrlOperator().Put(data);
		}
		// QPtrList<QNetworkOperation> copy(const QString& arg1,const QString& arg2,bool arg3,bool arg4); >>>> NOT CONVERTED
		// QPtrList<QNetworkOperation> copy(const QString& arg1,const QString& arg2,bool arg3); >>>> NOT CONVERTED
		// QPtrList<QNetworkOperation> copy(const QString& arg1,const QString& arg2); >>>> NOT CONVERTED
		[SmokeMethod("copy(const QStringList&, const QString&, bool)")]
		public virtual void Copy(string[] files, string dest, bool move) {
			ProxyQUrlOperator().Copy(files,dest,move);
		}
		[SmokeMethod("copy(const QStringList&, const QString&)")]
		public virtual void Copy(string[] files, string dest) {
			ProxyQUrlOperator().Copy(files,dest);
		}
		[SmokeMethod("isDir(bool*)")]
		public virtual bool IsDir(out bool ok) {
			return ProxyQUrlOperator().IsDir(out ok);
		}
		[SmokeMethod("isDir()")]
		public virtual bool IsDir() {
			return ProxyQUrlOperator().IsDir();
		}
		[SmokeMethod("setNameFilter(const QString&)")]
		public virtual void SetNameFilter(string nameFilter) {
			ProxyQUrlOperator().SetNameFilter(nameFilter);
		}
		[SmokeMethod("nameFilter() const")]
		public string NameFilter() {
			return ProxyQUrlOperator().NameFilter();
		}
		[SmokeMethod("info(const QString&) const")]
		public virtual QUrlInfo Info(string entry) {
			return ProxyQUrlOperator().Info(entry);
		}
		[SmokeMethod("stop()")]
		public virtual void Stop() {
			ProxyQUrlOperator().Stop();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQUrlOperator().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQUrlOperator().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQUrlOperator().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQUrlOperator().TrUtf8(arg1);
		}
		[SmokeMethod("reset()")]
		protected void Reset() {
			ProxyQUrlOperator().Reset();
		}
		[SmokeMethod("parse(const QString&)")]
		protected bool Parse(string url) {
			return ProxyQUrlOperator().Parse(url);
		}
		[SmokeMethod("checkValid()")]
		protected virtual bool CheckValid() {
			return ProxyQUrlOperator().CheckValid();
		}
		[SmokeMethod("clearEntries()")]
		protected virtual void ClearEntries() {
			ProxyQUrlOperator().ClearEntries();
		}
		[SmokeMethod("getNetworkProtocol()")]
		protected void GetNetworkProtocol() {
			ProxyQUrlOperator().GetNetworkProtocol();
		}
		[SmokeMethod("deleteNetworkProtocol()")]
		protected void DeleteNetworkProtocol() {
			ProxyQUrlOperator().DeleteNetworkProtocol();
		}
		~QUrlOperator() {
			DisposeQUrlOperator();
		}
		public new void Dispose() {
			DisposeQUrlOperator();
		}
		private void DisposeQUrlOperator() {
			ProxyQUrlOperator().DisposeQUrlOperator();
		}
		[SmokeMethod("protocol() const")]
		public string Protocol() {
			return ProxyQUrlOperator().Protocol();
		}
		[SmokeMethod("setProtocol(const QString&)")]
		public virtual void SetProtocol(string protocol) {
			ProxyQUrlOperator().SetProtocol(protocol);
		}
		[SmokeMethod("user() const")]
		public string User() {
			return ProxyQUrlOperator().User();
		}
		[SmokeMethod("setUser(const QString&)")]
		public virtual void SetUser(string user) {
			ProxyQUrlOperator().SetUser(user);
		}
		[SmokeMethod("hasUser() const")]
		public bool HasUser() {
			return ProxyQUrlOperator().HasUser();
		}
		[SmokeMethod("password() const")]
		public string Password() {
			return ProxyQUrlOperator().Password();
		}
		[SmokeMethod("setPassword(const QString&)")]
		public virtual void SetPassword(string pass) {
			ProxyQUrlOperator().SetPassword(pass);
		}
		[SmokeMethod("hasPassword() const")]
		public bool HasPassword() {
			return ProxyQUrlOperator().HasPassword();
		}
		[SmokeMethod("host() const")]
		public string Host() {
			return ProxyQUrlOperator().Host();
		}
		[SmokeMethod("setHost(const QString&)")]
		public virtual void SetHost(string user) {
			ProxyQUrlOperator().SetHost(user);
		}
		[SmokeMethod("hasHost() const")]
		public bool HasHost() {
			return ProxyQUrlOperator().HasHost();
		}
		[SmokeMethod("port() const")]
		public int Port() {
			return ProxyQUrlOperator().Port();
		}
		[SmokeMethod("setPort(int)")]
		public virtual void SetPort(int port) {
			ProxyQUrlOperator().SetPort(port);
		}
		[SmokeMethod("hasPort() const")]
		public bool HasPort() {
			return ProxyQUrlOperator().HasPort();
		}
		[SmokeMethod("path(bool) const")]
		public string Path(bool correct) {
			return ProxyQUrlOperator().Path(correct);
		}
		[SmokeMethod("path() const")]
		public string Path() {
			return ProxyQUrlOperator().Path();
		}
		[SmokeMethod("hasPath() const")]
		public bool HasPath() {
			return ProxyQUrlOperator().HasPath();
		}
		[SmokeMethod("setEncodedPathAndQuery(const QString&)")]
		public virtual void SetEncodedPathAndQuery(string enc) {
			ProxyQUrlOperator().SetEncodedPathAndQuery(enc);
		}
		[SmokeMethod("encodedPathAndQuery()")]
		public string EncodedPathAndQuery() {
			return ProxyQUrlOperator().EncodedPathAndQuery();
		}
		[SmokeMethod("setQuery(const QString&)")]
		public virtual void SetQuery(string txt) {
			ProxyQUrlOperator().SetQuery(txt);
		}
		[SmokeMethod("query() const")]
		public string Query() {
			return ProxyQUrlOperator().Query();
		}
		[SmokeMethod("ref() const")]
		public string Ref() {
			return ProxyQUrlOperator().Ref();
		}
		[SmokeMethod("setRef(const QString&)")]
		public virtual void SetRef(string txt) {
			ProxyQUrlOperator().SetRef(txt);
		}
		[SmokeMethod("hasRef() const")]
		public bool HasRef() {
			return ProxyQUrlOperator().HasRef();
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQUrlOperator().IsValid();
		}
		[SmokeMethod("isLocalFile() const")]
		public bool IsLocalFile() {
			return ProxyQUrlOperator().IsLocalFile();
		}
		[SmokeMethod("addPath(const QString&)")]
		public virtual void AddPath(string path) {
			ProxyQUrlOperator().AddPath(path);
		}
		[SmokeMethod("setFileName(const QString&)")]
		public virtual void SetFileName(string txt) {
			ProxyQUrlOperator().SetFileName(txt);
		}
		[SmokeMethod("fileName() const")]
		public string FileName() {
			return ProxyQUrlOperator().FileName();
		}
		[SmokeMethod("dirPath() const")]
		public string DirPath() {
			return ProxyQUrlOperator().DirPath();
		}
		//  operator QString(); >>>> NOT CONVERTED
		[SmokeMethod("toString(bool, bool) const")]
		public new virtual string ToString(bool encodedPath, bool forcePrependProtocol) {
			return ProxyQUrlOperator().ToString(encodedPath,forcePrependProtocol);
		}
		[SmokeMethod("toString(bool) const")]
		public new virtual string ToString(bool encodedPath) {
			return ProxyQUrlOperator().ToString(encodedPath);
		}
		[SmokeMethod("toString() const")]
		public new virtual string ToString() {
			return ProxyQUrlOperator().ToString();
		}
		[SmokeMethod("decode(QString&)")]
		public static void Decode(StringBuilder url) {
			StaticQUrlOperator().Decode(url);
		}
		[SmokeMethod("encode(QString&)")]
		public static void Encode(StringBuilder url) {
			StaticQUrlOperator().Encode(url);
		}
		[SmokeMethod("isRelativeUrl(const QString&)")]
		public static bool IsRelativeUrl(string url) {
			return StaticQUrlOperator().IsRelativeUrl(url);
		}
		protected void CreateQUrlOperatorSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQUrlOperatorSignals), this);
			Q_EMIT = (IQUrlOperatorSignals) realProxy.GetTransparentProxy();
		}
		protected new IQUrlOperatorSignals Emit() {
			return (IQUrlOperatorSignals) Q_EMIT;
		}
	}

	public interface IQUrlOperatorSignals : IQObjectSignals {
		// void newChildren(const QValueList<QUrlInfo>& arg1,QNetworkOperation* arg2); >>>> NOT CONVERTED
		[Q_SIGNAL("void finished(QNetworkOperation*)")]
		void Finished(QNetworkOperation res);
		[Q_SIGNAL("void start(QNetworkOperation*)")]
		void Start(QNetworkOperation res);
		[Q_SIGNAL("void createdDirectory(const QUrlInfo&, QNetworkOperation*)")]
		void CreatedDirectory(QUrlInfo arg1, QNetworkOperation res);
		[Q_SIGNAL("void removed(QNetworkOperation*)")]
		void Removed(QNetworkOperation res);
		[Q_SIGNAL("void itemChanged(QNetworkOperation*)")]
		void ItemChanged(QNetworkOperation res);
		[Q_SIGNAL("void data(const QByteArray&, QNetworkOperation*)")]
		void Data(QByteArray arg1, QNetworkOperation res);
		[Q_SIGNAL("void dataTransferProgress(int, int, QNetworkOperation*)")]
		void DataTransferProgress(int bytesDone, int bytesTotal, QNetworkOperation res);
		// void startedNextCopy(const QPtrList<QNetworkOperation>& arg1); >>>> NOT CONVERTED
		[Q_SIGNAL("void connectionStateChanged(int, const QString&)")]
		void ConnectionStateChanged(int state, string data);
	}
}
