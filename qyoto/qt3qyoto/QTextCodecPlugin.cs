//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	public class QTextCodecPlugin : QGPlugin {
 		protected QTextCodecPlugin(Type dummy) : base((Type) null) {}
		interface IQTextCodecPluginProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQTextCodecPluginProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextCodecPlugin), this);
			_interceptor = (QTextCodecPlugin) realProxy.GetTransparentProxy();
		}
		private QTextCodecPlugin ProxyQTextCodecPlugin() {
			return (QTextCodecPlugin) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextCodecPlugin() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextCodecPluginProxy), null);
			_staticInterceptor = (IQTextCodecPluginProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextCodecPluginProxy StaticQTextCodecPlugin() {
			return (IQTextCodecPluginProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQTextCodecPlugin().MetaObject();
		}
		public new virtual string ClassName() {
			return ProxyQTextCodecPlugin().ClassName();
		}
		public virtual ArrayList Names() {
			return ProxyQTextCodecPlugin().Names();
		}
		public virtual QTextCodec CreateForName(string name) {
			return ProxyQTextCodecPlugin().CreateForName(name);
		}
		public virtual int[] MibEnums() {
			return ProxyQTextCodecPlugin().MibEnums();
		}
		public virtual QTextCodec CreateForMib(int mib) {
			return ProxyQTextCodecPlugin().CreateForMib(mib);
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQTextCodecPlugin().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQTextCodecPlugin().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQTextCodecPlugin().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQTextCodecPlugin().TrUtf8(arg1);
		}
	}
}
