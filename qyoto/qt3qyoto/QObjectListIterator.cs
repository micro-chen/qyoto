//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;

	public class QObjectListIterator : IDisposable {
		protected Object _interceptor = null;
 		protected QObjectListIterator(Type dummy) : base() {}
		interface IQObjectListIteratorProxy {
		}

		protected void CreateQObjectListIteratorProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QObjectListIterator), this);
			_interceptor = (QObjectListIterator) realProxy.GetTransparentProxy();
		}
		private QObjectListIterator ProxyQObjectListIterator() {
			return (QObjectListIterator) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QObjectListIterator() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQObjectListIteratorProxy), null);
			_staticInterceptor = (IQObjectListIteratorProxy) realProxy.GetTransparentProxy();
		}
		private static IQObjectListIteratorProxy StaticQObjectListIterator() {
			return (IQObjectListIteratorProxy) _staticInterceptor;
		}

		public QObjectListIterator(ArrayList l) : this((Type) null) {
			CreateQObjectListIteratorProxy();
			NewQObjectListIterator(l);
		}
		private void NewQObjectListIterator(ArrayList l) {
			ProxyQObjectListIterator().NewQObjectListIterator(l);
		}
		~QObjectListIterator() {
			ProxyQObjectListIterator().Dispose();
		}
		public void Dispose() {
			ProxyQObjectListIterator().Dispose();
		}
	}
}
