//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QSqlRecordInfo : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QSqlRecordInfo(Type dummy) {}
		interface IQSqlRecordInfoProxy {
		}

		protected void CreateQSqlRecordInfoProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSqlRecordInfo), this);
			_interceptor = (QSqlRecordInfo) realProxy.GetTransparentProxy();
		}
		private QSqlRecordInfo ProxyQSqlRecordInfo() {
			return (QSqlRecordInfo) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSqlRecordInfo() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlRecordInfoProxy), null);
			_staticInterceptor = (IQSqlRecordInfoProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlRecordInfoProxy StaticQSqlRecordInfo() {
			return (IQSqlRecordInfoProxy) _staticInterceptor;
		}

		public QSqlRecordInfo() : this((Type) null) {
			CreateQSqlRecordInfoProxy();
			NewQSqlRecordInfo();
		}
		private void NewQSqlRecordInfo() {
			ProxyQSqlRecordInfo().NewQSqlRecordInfo();
		}
		// QSqlRecordInfo* QSqlRecordInfo(const QSqlFieldInfoList& arg1); >>>> NOT CONVERTED
		public QSqlRecordInfo(QSqlRecord other) : this((Type) null) {
			CreateQSqlRecordInfoProxy();
			NewQSqlRecordInfo(other);
		}
		private void NewQSqlRecordInfo(QSqlRecord other) {
			ProxyQSqlRecordInfo().NewQSqlRecordInfo(other);
		}
		public int Contains(string fieldName) {
			return ProxyQSqlRecordInfo().Contains(fieldName);
		}
		public QSqlFieldInfo Find(string fieldName) {
			return ProxyQSqlRecordInfo().Find(fieldName);
		}
		public QSqlRecord ToRecord() {
			return ProxyQSqlRecordInfo().ToRecord();
		}
		~QSqlRecordInfo() {
			ProxyQSqlRecordInfo().Dispose();
		}
		public void Dispose() {
			ProxyQSqlRecordInfo().Dispose();
		}
	}
}
