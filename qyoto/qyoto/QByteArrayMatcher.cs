//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QByteArrayMatcher : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QByteArrayMatcher(Type dummy) {}
		interface IQByteArrayMatcherProxy {
		}

		protected void CreateQByteArrayMatcherProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QByteArrayMatcher), this);
			_interceptor = (QByteArrayMatcher) realProxy.GetTransparentProxy();
		}
		private QByteArrayMatcher ProxyQByteArrayMatcher() {
			return (QByteArrayMatcher) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QByteArrayMatcher() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQByteArrayMatcherProxy), null);
			_staticInterceptor = (IQByteArrayMatcherProxy) realProxy.GetTransparentProxy();
		}
		private static IQByteArrayMatcherProxy StaticQByteArrayMatcher() {
			return (IQByteArrayMatcherProxy) _staticInterceptor;
		}

		public QByteArrayMatcher() : this((Type) null) {
			CreateQByteArrayMatcherProxy();
			NewQByteArrayMatcher();
		}
		private void NewQByteArrayMatcher() {
			ProxyQByteArrayMatcher().NewQByteArrayMatcher();
		}
		public QByteArrayMatcher(byte[] pattern) : this((Type) null) {
			CreateQByteArrayMatcherProxy();
			NewQByteArrayMatcher(pattern);
		}
		private void NewQByteArrayMatcher(byte[] pattern) {
			ProxyQByteArrayMatcher().NewQByteArrayMatcher(pattern);
		}
		public void SetPattern(byte[] pattern) {
			ProxyQByteArrayMatcher().SetPattern(pattern);
		}
		public int IndexIn(byte[] ba, int from) {
			return ProxyQByteArrayMatcher().IndexIn(ba,from);
		}
		public int IndexIn(byte[] ba) {
			return ProxyQByteArrayMatcher().IndexIn(ba);
		}
		public byte[] Pattern() {
			return ProxyQByteArrayMatcher().Pattern();
		}
		~QByteArrayMatcher() {
			ProxyQByteArrayMatcher().Dispose();
		}
		public void Dispose() {
			ProxyQByteArrayMatcher().Dispose();
		}
	}
}
