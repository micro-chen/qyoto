//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	public class QSqlDriverPlugin : QGPlugin {
 		protected QSqlDriverPlugin(Type dummy) : base((Type) null) {}
		interface IQSqlDriverPluginProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQSqlDriverPluginProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSqlDriverPlugin), this);
			_interceptor = (QSqlDriverPlugin) realProxy.GetTransparentProxy();
		}
		private QSqlDriverPlugin ProxyQSqlDriverPlugin() {
			return (QSqlDriverPlugin) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSqlDriverPlugin() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlDriverPluginProxy), null);
			_staticInterceptor = (IQSqlDriverPluginProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlDriverPluginProxy StaticQSqlDriverPlugin() {
			return (IQSqlDriverPluginProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQSqlDriverPlugin().MetaObject();
		}
		public new virtual string ClassName() {
			return ProxyQSqlDriverPlugin().ClassName();
		}
		public virtual ArrayList Keys() {
			return ProxyQSqlDriverPlugin().Keys();
		}
		public virtual QSqlDriver Create(string key) {
			return ProxyQSqlDriverPlugin().Create(key);
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQSqlDriverPlugin().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQSqlDriverPlugin().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQSqlDriverPlugin().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQSqlDriverPlugin().TrUtf8(arg1);
		}
	}
}
