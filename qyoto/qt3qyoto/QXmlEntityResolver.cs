//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public interface IQXmlEntityResolver {
			bool ResolveEntity(string publicId, string systemId, QXmlInputSource ret);
			string ErrorString();
	}

	[SmokeClass("QXmlEntityResolver")]
	public class QXmlEntityResolver : MarshalByRefObject, IQXmlEntityResolver {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QXmlEntityResolver(Type dummy) {}
		interface IQXmlEntityResolverProxy {
		}

		protected void CreateQXmlEntityResolverProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QXmlEntityResolver), this);
			_interceptor = (QXmlEntityResolver) realProxy.GetTransparentProxy();
		}
		private QXmlEntityResolver ProxyQXmlEntityResolver() {
			return (QXmlEntityResolver) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QXmlEntityResolver() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQXmlEntityResolverProxy), null);
			_staticInterceptor = (IQXmlEntityResolverProxy) realProxy.GetTransparentProxy();
		}
		private static IQXmlEntityResolverProxy StaticQXmlEntityResolver() {
			return (IQXmlEntityResolverProxy) _staticInterceptor;
		}

		[SmokeMethod("resolveEntity(const QString&, const QString&, QXmlInputSource*&)")]
		public virtual bool ResolveEntity(string publicId, string systemId, QXmlInputSource ret) {
			return ProxyQXmlEntityResolver().ResolveEntity(publicId,systemId,ret);
		}
		[SmokeMethod("errorString()")]
		public virtual string ErrorString() {
			return ProxyQXmlEntityResolver().ErrorString();
		}
		public QXmlEntityResolver() : this((Type) null) {
			CreateQXmlEntityResolverProxy();
			NewQXmlEntityResolver();
		}
		[SmokeMethod("QXmlEntityResolver()")]
		private void NewQXmlEntityResolver() {
			ProxyQXmlEntityResolver().NewQXmlEntityResolver();
		}
		~QXmlEntityResolver() {
			DisposeQXmlEntityResolver();
		}
		public void Dispose() {
			DisposeQXmlEntityResolver();
		}
		private void DisposeQXmlEntityResolver() {
			ProxyQXmlEntityResolver().DisposeQXmlEntityResolver();
		}
	}
}
