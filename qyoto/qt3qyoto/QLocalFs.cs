//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QLocalFs")]
	public class QLocalFs : QNetworkProtocol, IDisposable {
 		protected QLocalFs(Type dummy) : base((Type) null) {}
		interface IQLocalFsProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQLocalFsProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QLocalFs), this);
			_interceptor = (QLocalFs) realProxy.GetTransparentProxy();
		}
		private QLocalFs ProxyQLocalFs() {
			return (QLocalFs) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QLocalFs() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQLocalFsProxy), null);
			_staticInterceptor = (IQLocalFsProxy) realProxy.GetTransparentProxy();
		}
		private static IQLocalFsProxy StaticQLocalFs() {
			return (IQLocalFsProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQLocalFs().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQLocalFs().ClassName();
		}
		public QLocalFs() : this((Type) null) {
			CreateQLocalFsProxy();
			CreateQLocalFsSignalProxy();
			NewQLocalFs();
		}
		[SmokeMethod("QLocalFs()")]
		private void NewQLocalFs() {
			ProxyQLocalFs().NewQLocalFs();
		}
		[SmokeMethod("supportedOperations() const")]
		public new virtual int SupportedOperations() {
			return ProxyQLocalFs().SupportedOperations();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQLocalFs().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQLocalFs().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQLocalFs().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQLocalFs().TrUtf8(arg1);
		}
		[SmokeMethod("operationListChildren(QNetworkOperation*)")]
		protected new virtual void OperationListChildren(QNetworkOperation op) {
			ProxyQLocalFs().OperationListChildren(op);
		}
		[SmokeMethod("operationMkDir(QNetworkOperation*)")]
		protected new virtual void OperationMkDir(QNetworkOperation op) {
			ProxyQLocalFs().OperationMkDir(op);
		}
		[SmokeMethod("operationRemove(QNetworkOperation*)")]
		protected new virtual void OperationRemove(QNetworkOperation op) {
			ProxyQLocalFs().OperationRemove(op);
		}
		[SmokeMethod("operationRename(QNetworkOperation*)")]
		protected new virtual void OperationRename(QNetworkOperation op) {
			ProxyQLocalFs().OperationRename(op);
		}
		[SmokeMethod("operationGet(QNetworkOperation*)")]
		protected new virtual void OperationGet(QNetworkOperation op) {
			ProxyQLocalFs().OperationGet(op);
		}
		[SmokeMethod("operationPut(QNetworkOperation*)")]
		protected new virtual void OperationPut(QNetworkOperation op) {
			ProxyQLocalFs().OperationPut(op);
		}
		~QLocalFs() {
			DisposeQLocalFs();
		}
		public new void Dispose() {
			DisposeQLocalFs();
		}
		private void DisposeQLocalFs() {
			ProxyQLocalFs().DisposeQLocalFs();
		}
		protected void CreateQLocalFsSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQLocalFsSignals), this);
			Q_EMIT = (IQLocalFsSignals) realProxy.GetTransparentProxy();
		}
		protected new IQLocalFsSignals Emit() {
			return (IQLocalFsSignals) Q_EMIT;
		}
	}

	public interface IQLocalFsSignals : IQNetworkProtocolSignals {
	}
}
