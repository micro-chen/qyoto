//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QSqlResult")]
	public class QSqlResult : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QSqlResult(Type dummy) {}
		interface IQSqlResultProxy {
		}

		protected void CreateQSqlResultProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSqlResult), this);
			_interceptor = (QSqlResult) realProxy.GetTransparentProxy();
		}
		private QSqlResult ProxyQSqlResult() {
			return (QSqlResult) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSqlResult() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlResultProxy), null);
			_staticInterceptor = (IQSqlResultProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlResultProxy StaticQSqlResult() {
			return (IQSqlResultProxy) _staticInterceptor;
		}

		// void setExtension(QSqlExtension* arg1); >>>> NOT CONVERTED
		// QSqlExtension* extension(); >>>> NOT CONVERTED
	}
}
