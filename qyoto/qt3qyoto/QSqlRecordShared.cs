//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QSqlRecordShared : QShared, IDisposable {
 		protected QSqlRecordShared(Type dummy) : base((Type) null) {}
		interface IQSqlRecordSharedProxy {
		}

		protected void CreateQSqlRecordSharedProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSqlRecordShared), this);
			_interceptor = (QSqlRecordShared) realProxy.GetTransparentProxy();
		}
		private QSqlRecordShared ProxyQSqlRecordShared() {
			return (QSqlRecordShared) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSqlRecordShared() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlRecordSharedProxy), null);
			_staticInterceptor = (IQSqlRecordSharedProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlRecordSharedProxy StaticQSqlRecordShared() {
			return (IQSqlRecordSharedProxy) _staticInterceptor;
		}

		/*public QSqlRecordShared(QSqlRecordPrivate sqlRecordPrivate) : this((Type) null) {
			CreateQSqlRecordSharedProxy();
			NewQSqlRecordShared(sqlRecordPrivate);
		}
		private void NewQSqlRecordShared(QSqlRecordPrivate sqlRecordPrivate) {
			ProxyQSqlRecordShared().NewQSqlRecordShared(sqlRecordPrivate);
		}*/
		~QSqlRecordShared() {
			ProxyQSqlRecordShared().Dispose();
		}
		public void Dispose() {
			ProxyQSqlRecordShared().Dispose();
		}
	}
}
