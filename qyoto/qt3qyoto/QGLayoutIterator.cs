//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QGLayoutIterator")]
	public class QGLayoutIterator : QShared {
 		protected QGLayoutIterator(Type dummy) : base((Type) null) {}
		interface IQGLayoutIteratorProxy {
		}

		protected void CreateQGLayoutIteratorProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGLayoutIterator), this);
			_interceptor = (QGLayoutIterator) realProxy.GetTransparentProxy();
		}
		private QGLayoutIterator ProxyQGLayoutIterator() {
			return (QGLayoutIterator) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGLayoutIterator() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGLayoutIteratorProxy), null);
			_staticInterceptor = (IQGLayoutIteratorProxy) realProxy.GetTransparentProxy();
		}
		private static IQGLayoutIteratorProxy StaticQGLayoutIterator() {
			return (IQGLayoutIteratorProxy) _staticInterceptor;
		}

		[SmokeMethod("next()")]
		public virtual IQLayoutItem Next() {
			return ProxyQGLayoutIterator().Next();
		}
		[SmokeMethod("current()")]
		public virtual IQLayoutItem Current() {
			return ProxyQGLayoutIterator().Current();
		}
		[SmokeMethod("takeCurrent()")]
		public virtual IQLayoutItem TakeCurrent() {
			return ProxyQGLayoutIterator().TakeCurrent();
		}
	}
}
