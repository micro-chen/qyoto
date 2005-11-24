//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QGCache : QPtrCollection {
 		protected QGCache(Type dummy) : base((Type) null) {}
		interface IQGCacheProxy {
		}

		protected void CreateQGCacheProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGCache), this);
			_interceptor = (QGCache) realProxy.GetTransparentProxy();
		}
		private QGCache ProxyQGCache() {
			return (QGCache) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGCache() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGCacheProxy), null);
			_staticInterceptor = (IQGCacheProxy) realProxy.GetTransparentProxy();
		}
		private static IQGCacheProxy StaticQGCache() {
			return (IQGCacheProxy) _staticInterceptor;
		}

		enum KeyType {
			StringKey = 0,
			AsciiKey = 1,
			IntKey = 2,
			PtrKey = 3,
		}
		public QGCache(int maxCost, uint size, int kt, bool caseSensitive, bool copyKeys) : this((Type) null) {
			CreateQGCacheProxy();
			NewQGCache(maxCost,size,kt,caseSensitive,copyKeys);
		}
		private void NewQGCache(int maxCost, uint size, int kt, bool caseSensitive, bool copyKeys) {
			ProxyQGCache().NewQGCache(maxCost,size,kt,caseSensitive,copyKeys);
		}
		public QGCache(QGCache arg1) : this((Type) null) {
			CreateQGCacheProxy();
			NewQGCache(arg1);
		}
		private void NewQGCache(QGCache arg1) {
			ProxyQGCache().NewQGCache(arg1);
		}
		protected new uint Count() {
			return ProxyQGCache().Count();
		}
		protected uint Size() {
			return ProxyQGCache().Size();
		}
		protected int MaxCost() {
			return ProxyQGCache().MaxCost();
		}
		protected int TotalCost() {
			return ProxyQGCache().TotalCost();
		}
		protected void SetMaxCost(int maxCost) {
			ProxyQGCache().SetMaxCost(maxCost);
		}
		protected new void Clear() {
			ProxyQGCache().Clear();
		}
		// bool insert_string(const QString& arg1,QPtrCollection::Item arg2,int arg3,int arg4); >>>> NOT CONVERTED
		// bool insert_other(const char* arg1,QPtrCollection::Item arg2,int arg3,int arg4); >>>> NOT CONVERTED
		protected bool Remove_string(string key) {
			return ProxyQGCache().Remove_string(key);
		}
		protected bool Remove_other(string key) {
			return ProxyQGCache().Remove_other(key);
		}
		// QPtrCollection::Item take_string(const QString& arg1); >>>> NOT CONVERTED
		// QPtrCollection::Item take_other(const char* arg1); >>>> NOT CONVERTED
		// QPtrCollection::Item find_string(const QString& arg1,bool arg2); >>>> NOT CONVERTED
		// QPtrCollection::Item find_string(const QString& arg1); >>>> NOT CONVERTED
		// QPtrCollection::Item find_other(const char* arg1,bool arg2); >>>> NOT CONVERTED
		// QPtrCollection::Item find_other(const char* arg1); >>>> NOT CONVERTED
		protected void Statistics() {
			ProxyQGCache().Statistics();
		}
	}
}
