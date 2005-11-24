//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QFileIconProvider : QObject, IDisposable {
 		protected QFileIconProvider(Type dummy) : base((Type) null) {}
		interface IQFileIconProviderProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQFileIconProviderProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFileIconProvider), this);
			_interceptor = (QFileIconProvider) realProxy.GetTransparentProxy();
		}
		private QFileIconProvider ProxyQFileIconProvider() {
			return (QFileIconProvider) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFileIconProvider() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFileIconProviderProxy), null);
			_staticInterceptor = (IQFileIconProviderProxy) realProxy.GetTransparentProxy();
		}
		private static IQFileIconProviderProxy StaticQFileIconProvider() {
			return (IQFileIconProviderProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQFileIconProvider().MetaObject();
		}
		public new virtual string ClassName() {
			return ProxyQFileIconProvider().ClassName();
		}
		public QFileIconProvider(QObject parent, string name) : this((Type) null) {
			CreateQFileIconProviderProxy();
			NewQFileIconProvider(parent,name);
		}
		private void NewQFileIconProvider(QObject parent, string name) {
			ProxyQFileIconProvider().NewQFileIconProvider(parent,name);
		}
		public QFileIconProvider(QObject parent) : this((Type) null) {
			CreateQFileIconProviderProxy();
			NewQFileIconProvider(parent);
		}
		private void NewQFileIconProvider(QObject parent) {
			ProxyQFileIconProvider().NewQFileIconProvider(parent);
		}
		public QFileIconProvider() : this((Type) null) {
			CreateQFileIconProviderProxy();
			NewQFileIconProvider();
		}
		private void NewQFileIconProvider() {
			ProxyQFileIconProvider().NewQFileIconProvider();
		}
		public virtual QPixmap Pixmap(QFileInfo arg1) {
			return ProxyQFileIconProvider().Pixmap(arg1);
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQFileIconProvider().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQFileIconProvider().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQFileIconProvider().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQFileIconProvider().TrUtf8(arg1);
		}
		~QFileIconProvider() {
			ProxyQFileIconProvider().Dispose();
		}
		public new void Dispose() {
			ProxyQFileIconProvider().Dispose();
		}
	}
}
