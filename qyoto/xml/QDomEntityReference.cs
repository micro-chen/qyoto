//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDomEntityReference")]
	public class QDomEntityReference : QDomNode, IDisposable {
 		protected QDomEntityReference(Type dummy) : base((Type) null) {}
		interface IQDomEntityReferenceProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomEntityReference), this);
			_interceptor = (QDomEntityReference) realProxy.GetTransparentProxy();
		}
		private QDomEntityReference ProxyQDomEntityReference() {
			return (QDomEntityReference) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomEntityReference() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomEntityReferenceProxy), null);
			_staticInterceptor = (IQDomEntityReferenceProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomEntityReferenceProxy StaticQDomEntityReference() {
			return (IQDomEntityReferenceProxy) _staticInterceptor;
		}

		public QDomEntityReference() : this((Type) null) {
			CreateProxy();
			NewQDomEntityReference();
		}
		[SmokeMethod("QDomEntityReference()")]
		private void NewQDomEntityReference() {
			ProxyQDomEntityReference().NewQDomEntityReference();
		}
		public QDomEntityReference(QDomEntityReference x) : this((Type) null) {
			CreateProxy();
			NewQDomEntityReference(x);
		}
		[SmokeMethod("QDomEntityReference(const QDomEntityReference&)")]
		private void NewQDomEntityReference(QDomEntityReference x) {
			ProxyQDomEntityReference().NewQDomEntityReference(x);
		}
		[SmokeMethod("nodeType() const")]
		public new QDomNode.NodeType NodeType() {
			return ProxyQDomEntityReference().NodeType();
		}
		~QDomEntityReference() {
			DisposeQDomEntityReference();
		}
		public void Dispose() {
			DisposeQDomEntityReference();
		}
		[SmokeMethod("~QDomEntityReference()")]
		private void DisposeQDomEntityReference() {
			ProxyQDomEntityReference().DisposeQDomEntityReference();
		}
	}
}