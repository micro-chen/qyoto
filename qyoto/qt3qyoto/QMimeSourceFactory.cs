//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	public class QMimeSourceFactory : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QMimeSourceFactory(Type dummy) {}
		interface IQMimeSourceFactoryProxy {
			QMimeSourceFactory DefaultFactory();
			void SetDefaultFactory(QMimeSourceFactory arg1);
			QMimeSourceFactory TakeDefaultFactory();
			void AddFactory(QMimeSourceFactory f);
			void RemoveFactory(QMimeSourceFactory f);
		}

		protected void CreateQMimeSourceFactoryProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMimeSourceFactory), this);
			_interceptor = (QMimeSourceFactory) realProxy.GetTransparentProxy();
		}
		private QMimeSourceFactory ProxyQMimeSourceFactory() {
			return (QMimeSourceFactory) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMimeSourceFactory() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMimeSourceFactoryProxy), null);
			_staticInterceptor = (IQMimeSourceFactoryProxy) realProxy.GetTransparentProxy();
		}
		private static IQMimeSourceFactoryProxy StaticQMimeSourceFactory() {
			return (IQMimeSourceFactoryProxy) _staticInterceptor;
		}

		public QMimeSourceFactory() : this((Type) null) {
			CreateQMimeSourceFactoryProxy();
			NewQMimeSourceFactory();
		}
		private void NewQMimeSourceFactory() {
			ProxyQMimeSourceFactory().NewQMimeSourceFactory();
		}
		public virtual IQMimeSource Data(string abs_name) {
			return ProxyQMimeSourceFactory().Data(abs_name);
		}
		public virtual string MakeAbsolute(string abs_or_rel_name, string context) {
			return ProxyQMimeSourceFactory().MakeAbsolute(abs_or_rel_name,context);
		}
		public IQMimeSource Data(string abs_or_rel_name, string context) {
			return ProxyQMimeSourceFactory().Data(abs_or_rel_name,context);
		}
		public virtual void SetText(string abs_name, string text) {
			ProxyQMimeSourceFactory().SetText(abs_name,text);
		}
		public virtual void SetImage(string abs_name, QImage im) {
			ProxyQMimeSourceFactory().SetImage(abs_name,im);
		}
		public virtual void SetPixmap(string abs_name, QPixmap pm) {
			ProxyQMimeSourceFactory().SetPixmap(abs_name,pm);
		}
		public virtual void SetData(string abs_name, IQMimeSource data) {
			ProxyQMimeSourceFactory().SetData(abs_name,data);
		}
		public virtual void SetFilePath(string[] arg1) {
			ProxyQMimeSourceFactory().SetFilePath(arg1);
		}
		public virtual ArrayList FilePath() {
			return ProxyQMimeSourceFactory().FilePath();
		}
		public void AddFilePath(string arg1) {
			ProxyQMimeSourceFactory().AddFilePath(arg1);
		}
		public virtual void SetExtensionType(string ext, string mimetype) {
			ProxyQMimeSourceFactory().SetExtensionType(ext,mimetype);
		}
		public static QMimeSourceFactory DefaultFactory() {
			return StaticQMimeSourceFactory().DefaultFactory();
		}
		public static void SetDefaultFactory(QMimeSourceFactory arg1) {
			StaticQMimeSourceFactory().SetDefaultFactory(arg1);
		}
		public static QMimeSourceFactory TakeDefaultFactory() {
			return StaticQMimeSourceFactory().TakeDefaultFactory();
		}
		public static void AddFactory(QMimeSourceFactory f) {
			StaticQMimeSourceFactory().AddFactory(f);
		}
		public static void RemoveFactory(QMimeSourceFactory f) {
			StaticQMimeSourceFactory().RemoveFactory(f);
		}
		~QMimeSourceFactory() {
			ProxyQMimeSourceFactory().Dispose();
		}
		public void Dispose() {
			ProxyQMimeSourceFactory().Dispose();
		}
	}
}
