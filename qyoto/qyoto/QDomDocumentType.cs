//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QDomDocumentType : QDomNode, IDisposable {
 		protected QDomDocumentType(Type dummy) : base((Type) null) {}
		interface IQDomDocumentTypeProxy {
		}

		protected void CreateQDomDocumentTypeProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomDocumentType), this);
			_interceptor = (QDomDocumentType) realProxy.GetTransparentProxy();
		}
		private QDomDocumentType ProxyQDomDocumentType() {
			return (QDomDocumentType) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomDocumentType() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomDocumentTypeProxy), null);
			_staticInterceptor = (IQDomDocumentTypeProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomDocumentTypeProxy StaticQDomDocumentType() {
			return (IQDomDocumentTypeProxy) _staticInterceptor;
		}

		public QDomDocumentType() : this((Type) null) {
			CreateQDomDocumentTypeProxy();
			NewQDomDocumentType();
		}
		private void NewQDomDocumentType() {
			ProxyQDomDocumentType().NewQDomDocumentType();
		}
		public QDomDocumentType(QDomDocumentType x) : this((Type) null) {
			CreateQDomDocumentTypeProxy();
			NewQDomDocumentType(x);
		}
		private void NewQDomDocumentType(QDomDocumentType x) {
			ProxyQDomDocumentType().NewQDomDocumentType(x);
		}
		public string Name() {
			return ProxyQDomDocumentType().Name();
		}
		public QDomNamedNodeMap Entities() {
			return ProxyQDomDocumentType().Entities();
		}
		public QDomNamedNodeMap Notations() {
			return ProxyQDomDocumentType().Notations();
		}
		public string PublicId() {
			return ProxyQDomDocumentType().PublicId();
		}
		public string SystemId() {
			return ProxyQDomDocumentType().SystemId();
		}
		public string InternalSubset() {
			return ProxyQDomDocumentType().InternalSubset();
		}
		public new int NodeType() {
			return ProxyQDomDocumentType().NodeType();
		}
		~QDomDocumentType() {
			ProxyQDomDocumentType().Dispose();
		}
		public void Dispose() {
			ProxyQDomDocumentType().Dispose();
		}
	}
}
