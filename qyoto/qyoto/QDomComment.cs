//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QDomComment : QDomCharacterData, IDisposable {
 		protected QDomComment(Type dummy) : base((Type) null) {}
		interface IQDomCommentProxy {
		}

		protected void CreateQDomCommentProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomComment), this);
			_interceptor = (QDomComment) realProxy.GetTransparentProxy();
		}
		private QDomComment ProxyQDomComment() {
			return (QDomComment) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomComment() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomCommentProxy), null);
			_staticInterceptor = (IQDomCommentProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomCommentProxy StaticQDomComment() {
			return (IQDomCommentProxy) _staticInterceptor;
		}

		public QDomComment() : this((Type) null) {
			CreateQDomCommentProxy();
			NewQDomComment();
		}
		private void NewQDomComment() {
			ProxyQDomComment().NewQDomComment();
		}
		public QDomComment(QDomComment x) : this((Type) null) {
			CreateQDomCommentProxy();
			NewQDomComment(x);
		}
		private void NewQDomComment(QDomComment x) {
			ProxyQDomComment().NewQDomComment(x);
		}
		public new int NodeType() {
			return ProxyQDomComment().NodeType();
		}
		~QDomComment() {
			ProxyQDomComment().Dispose();
		}
		public void Dispose() {
			ProxyQDomComment().Dispose();
		}
	}
}
