//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QStringData : QShared, IDisposable {
 		protected QStringData(Type dummy) : base((Type) null) {}
		interface IQStringDataProxy {
		}

		protected void CreateQStringDataProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStringData), this);
			_interceptor = (QStringData) realProxy.GetTransparentProxy();
		}
		private QStringData ProxyQStringData() {
			return (QStringData) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStringData() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStringDataProxy), null);
			_staticInterceptor = (IQStringDataProxy) realProxy.GetTransparentProxy();
		}
		private static IQStringDataProxy StaticQStringData() {
			return (IQStringDataProxy) _staticInterceptor;
		}

		public QStringData() : this((Type) null) {
			CreateQStringDataProxy();
			NewQStringData();
		}
		private void NewQStringData() {
			ProxyQStringData().NewQStringData();
		}
		public QStringData(char u, uint l, uint m) : this((Type) null) {
			CreateQStringDataProxy();
			NewQStringData(u,l,m);
		}
		private void NewQStringData(char u, uint l, uint m) {
			ProxyQStringData().NewQStringData(u,l,m);
		}
		public void DeleteSelf() {
			ProxyQStringData().DeleteSelf();
		}
		public void SetDirty() {
			ProxyQStringData().SetDirty();
		}
		~QStringData() {
			ProxyQStringData().Dispose();
		}
		public void Dispose() {
			ProxyQStringData().Dispose();
		}
	}
}
