//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public interface IQXmlLexicalHandler {
			bool StartDTD(string name, string publicId, string systemId);
			bool EndDTD();
			bool StartEntity(string name);
			bool EndEntity(string name);
			bool StartCDATA();
			bool EndCDATA();
			bool Comment(string ch);
			string ErrorString();
	}

	[SmokeClass("QXmlLexicalHandler")]
	public class QXmlLexicalHandler : MarshalByRefObject, IQXmlLexicalHandler {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QXmlLexicalHandler(Type dummy) {}
		interface IQXmlLexicalHandlerProxy {
		}

		protected void CreateQXmlLexicalHandlerProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QXmlLexicalHandler), this);
			_interceptor = (QXmlLexicalHandler) realProxy.GetTransparentProxy();
		}
		private QXmlLexicalHandler ProxyQXmlLexicalHandler() {
			return (QXmlLexicalHandler) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QXmlLexicalHandler() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQXmlLexicalHandlerProxy), null);
			_staticInterceptor = (IQXmlLexicalHandlerProxy) realProxy.GetTransparentProxy();
		}
		private static IQXmlLexicalHandlerProxy StaticQXmlLexicalHandler() {
			return (IQXmlLexicalHandlerProxy) _staticInterceptor;
		}

		[SmokeMethod("startDTD(const QString&, const QString&, const QString&)")]
		public virtual bool StartDTD(string name, string publicId, string systemId) {
			return ProxyQXmlLexicalHandler().StartDTD(name,publicId,systemId);
		}
		[SmokeMethod("endDTD()")]
		public virtual bool EndDTD() {
			return ProxyQXmlLexicalHandler().EndDTD();
		}
		[SmokeMethod("startEntity(const QString&)")]
		public virtual bool StartEntity(string name) {
			return ProxyQXmlLexicalHandler().StartEntity(name);
		}
		[SmokeMethod("endEntity(const QString&)")]
		public virtual bool EndEntity(string name) {
			return ProxyQXmlLexicalHandler().EndEntity(name);
		}
		[SmokeMethod("startCDATA()")]
		public virtual bool StartCDATA() {
			return ProxyQXmlLexicalHandler().StartCDATA();
		}
		[SmokeMethod("endCDATA()")]
		public virtual bool EndCDATA() {
			return ProxyQXmlLexicalHandler().EndCDATA();
		}
		[SmokeMethod("comment(const QString&)")]
		public virtual bool Comment(string ch) {
			return ProxyQXmlLexicalHandler().Comment(ch);
		}
		[SmokeMethod("errorString()")]
		public virtual string ErrorString() {
			return ProxyQXmlLexicalHandler().ErrorString();
		}
	}
}
