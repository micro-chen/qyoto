//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QDirSortItem : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QDirSortItem(Type dummy) {}
		interface IQDirSortItemProxy {
		}

		protected void CreateQDirSortItemProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDirSortItem), this);
			_interceptor = (QDirSortItem) realProxy.GetTransparentProxy();
		}
		private QDirSortItem ProxyQDirSortItem() {
			return (QDirSortItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDirSortItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDirSortItemProxy), null);
			_staticInterceptor = (IQDirSortItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQDirSortItemProxy StaticQDirSortItem() {
			return (IQDirSortItemProxy) _staticInterceptor;
		}

		public QDirSortItem() : this((Type) null) {
			CreateQDirSortItemProxy();
			NewQDirSortItem();
		}
		private void NewQDirSortItem() {
			ProxyQDirSortItem().NewQDirSortItem();
		}
		~QDirSortItem() {
			ProxyQDirSortItem().Dispose();
		}
		public void Dispose() {
			ProxyQDirSortItem().Dispose();
		}
	}
}
