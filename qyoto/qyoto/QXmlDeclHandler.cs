//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public interface IQXmlDeclHandler {
			bool AttributeDecl(string eName, string aName, string type, string valueDefault, string value);
			bool InternalEntityDecl(string name, string value);
			bool ExternalEntityDecl(string name, string publicId, string systemId);
			string ErrorString();
	}

	public class QXmlDeclHandler : MarshalByRefObject, IQXmlDeclHandler {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QXmlDeclHandler(Type dummy) {}
		interface IQXmlDeclHandlerProxy {
		}

		protected void CreateQXmlDeclHandlerProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QXmlDeclHandler), this);
			_interceptor = (QXmlDeclHandler) realProxy.GetTransparentProxy();
		}
		private QXmlDeclHandler ProxyQXmlDeclHandler() {
			return (QXmlDeclHandler) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QXmlDeclHandler() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQXmlDeclHandlerProxy), null);
			_staticInterceptor = (IQXmlDeclHandlerProxy) realProxy.GetTransparentProxy();
		}
		private static IQXmlDeclHandlerProxy StaticQXmlDeclHandler() {
			return (IQXmlDeclHandlerProxy) _staticInterceptor;
		}

		public virtual bool AttributeDecl(string eName, string aName, string type, string valueDefault, string value) {
			return ProxyQXmlDeclHandler().AttributeDecl(eName,aName,type,valueDefault,value);
		}
		public virtual bool InternalEntityDecl(string name, string value) {
			return ProxyQXmlDeclHandler().InternalEntityDecl(name,value);
		}
		public virtual bool ExternalEntityDecl(string name, string publicId, string systemId) {
			return ProxyQXmlDeclHandler().ExternalEntityDecl(name,publicId,systemId);
		}
		public virtual string ErrorString() {
			return ProxyQXmlDeclHandler().ErrorString();
		}
	}
}
