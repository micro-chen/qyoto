//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QDomCDATASection : QDomText, IDisposable {
 		protected QDomCDATASection(Type dummy) : base((Type) null) {}
		interface IQDomCDATASectionProxy {
		}

		protected void CreateQDomCDATASectionProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomCDATASection), this);
			_interceptor = (QDomCDATASection) realProxy.GetTransparentProxy();
		}
		private QDomCDATASection ProxyQDomCDATASection() {
			return (QDomCDATASection) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomCDATASection() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomCDATASectionProxy), null);
			_staticInterceptor = (IQDomCDATASectionProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomCDATASectionProxy StaticQDomCDATASection() {
			return (IQDomCDATASectionProxy) _staticInterceptor;
		}

		public QDomCDATASection() : this((Type) null) {
			CreateQDomCDATASectionProxy();
			NewQDomCDATASection();
		}
		private void NewQDomCDATASection() {
			ProxyQDomCDATASection().NewQDomCDATASection();
		}
		public QDomCDATASection(QDomCDATASection x) : this((Type) null) {
			CreateQDomCDATASectionProxy();
			NewQDomCDATASection(x);
		}
		private void NewQDomCDATASection(QDomCDATASection x) {
			ProxyQDomCDATASection().NewQDomCDATASection(x);
		}
		public new int NodeType() {
			return ProxyQDomCDATASection().NodeType();
		}
		~QDomCDATASection() {
			ProxyQDomCDATASection().Dispose();
		}
		public void Dispose() {
			ProxyQDomCDATASection().Dispose();
		}
	}
}
