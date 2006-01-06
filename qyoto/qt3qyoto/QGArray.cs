//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QGArray")]
	public class QGArray : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QGArray(Type dummy) {}
		interface IQGArrayProxy {
		}

		protected void CreateQGArrayProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGArray), this);
			_interceptor = (QGArray) realProxy.GetTransparentProxy();
		}
		private QGArray ProxyQGArray() {
			return (QGArray) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGArray() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGArrayProxy), null);
			_staticInterceptor = (IQGArrayProxy) realProxy.GetTransparentProxy();
		}
		private static IQGArrayProxy StaticQGArray() {
			return (IQGArrayProxy) _staticInterceptor;
		}

		enum Optimization {
			MemOptim = 0,
			SpeedOptim = 1,
		}
		public QGArray() : this((Type) null) {
			CreateQGArrayProxy();
			NewQGArray();
		}
		[SmokeMethod("QGArray()")]
		private void NewQGArray() {
			ProxyQGArray().NewQGArray();
		}
		public QGArray(int arg1, int arg2) : this((Type) null) {
			CreateQGArrayProxy();
			NewQGArray(arg1,arg2);
		}
		[SmokeMethod("QGArray(int, int)")]
		private void NewQGArray(int arg1, int arg2) {
			ProxyQGArray().NewQGArray(arg1,arg2);
		}
		public QGArray(int size) : this((Type) null) {
			CreateQGArrayProxy();
			NewQGArray(size);
		}
		[SmokeMethod("QGArray(int)")]
		private void NewQGArray(int size) {
			ProxyQGArray().NewQGArray(size);
		}
		public QGArray(QGArray a) : this((Type) null) {
			CreateQGArrayProxy();
			NewQGArray(a);
		}
		[SmokeMethod("QGArray(const QGArray&)")]
		private void NewQGArray(QGArray a) {
			ProxyQGArray().NewQGArray(a);
		}
		[SmokeMethod("detach()")]
		public virtual void Detach() {
			ProxyQGArray().Detach();
		}
		[SmokeMethod("data() const")]
		protected string Data() {
			return ProxyQGArray().Data();
		}
		[SmokeMethod("nrefs() const")]
		protected uint Nrefs() {
			return ProxyQGArray().Nrefs();
		}
		[SmokeMethod("size() const")]
		protected uint Size() {
			return ProxyQGArray().Size();
		}
		[SmokeMethod("isEqual(const QGArray&) const")]
		protected bool IsEqual(QGArray a) {
			return ProxyQGArray().IsEqual(a);
		}
		[SmokeMethod("resize(uint, QGArray::Optimization)")]
		protected bool Resize(uint newsize, int optim) {
			return ProxyQGArray().Resize(newsize,optim);
		}
		[SmokeMethod("resize(uint)")]
		protected bool Resize(uint newsize) {
			return ProxyQGArray().Resize(newsize);
		}
		[SmokeMethod("fill(const char*, int, uint)")]
		protected bool Fill(string d, int len, uint sz) {
			return ProxyQGArray().Fill(d,len,sz);
		}
		[SmokeMethod("assign(const QGArray&)")]
		protected QGArray Assign(QGArray a) {
			return ProxyQGArray().Assign(a);
		}
		[SmokeMethod("assign(const char*, uint)")]
		protected QGArray Assign(string d, uint len) {
			return ProxyQGArray().Assign(d,len);
		}
		[SmokeMethod("duplicate(const QGArray&)")]
		protected QGArray Duplicate(QGArray a) {
			return ProxyQGArray().Duplicate(a);
		}
		[SmokeMethod("duplicate(const char*, uint)")]
		protected QGArray Duplicate(string d, uint len) {
			return ProxyQGArray().Duplicate(d,len);
		}
		[SmokeMethod("store(const char*, uint)")]
		protected void Store(string d, uint len) {
			ProxyQGArray().Store(d,len);
		}
		// QGArray::array_data* sharedBlock(); >>>> NOT CONVERTED
		// void setSharedBlock(QGArray::array_data* arg1); >>>> NOT CONVERTED
		[SmokeMethod("setRawData(const char*, uint)")]
		protected QGArray SetRawData(string d, uint len) {
			return ProxyQGArray().SetRawData(d,len);
		}
		[SmokeMethod("resetRawData(const char*, uint)")]
		protected void ResetRawData(string d, uint len) {
			ProxyQGArray().ResetRawData(d,len);
		}
		[SmokeMethod("find(const char*, uint, uint) const")]
		protected int Find(string d, uint index, uint sz) {
			return ProxyQGArray().Find(d,index,sz);
		}
		[SmokeMethod("contains(const char*, uint) const")]
		protected int Contains(string d, uint sz) {
			return ProxyQGArray().Contains(d,sz);
		}
		[SmokeMethod("sort(uint)")]
		protected void Sort(uint sz) {
			ProxyQGArray().Sort(sz);
		}
		[SmokeMethod("bsearch(const char*, uint) const")]
		protected int Bsearch(string d, uint sz) {
			return ProxyQGArray().Bsearch(d,sz);
		}
		[SmokeMethod("at(uint) const")]
		protected string At(uint index) {
			return ProxyQGArray().At(index);
		}
		[SmokeMethod("setExpand(uint, const char*, uint)")]
		protected bool SetExpand(uint index, string d, uint sz) {
			return ProxyQGArray().SetExpand(index,d,sz);
		}
		// QGArray::array_data* newData(); >>>> NOT CONVERTED
		// void deleteData(QGArray::array_data* arg1); >>>> NOT CONVERTED
	}
}
