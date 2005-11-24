//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QPointArray : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QPointArray(Type dummy) {}
		interface IQPointArrayProxy {
			void CleanBuffers();
		}

		protected void CreateQPointArrayProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPointArray), this);
			_interceptor = (QPointArray) realProxy.GetTransparentProxy();
		}
		private QPointArray ProxyQPointArray() {
			return (QPointArray) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPointArray() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPointArrayProxy), null);
			_staticInterceptor = (IQPointArrayProxy) realProxy.GetTransparentProxy();
		}
		private static IQPointArrayProxy StaticQPointArray() {
			return (IQPointArrayProxy) _staticInterceptor;
		}

		public QPointArray() : this((Type) null) {
			CreateQPointArrayProxy();
			NewQPointArray();
		}
		private void NewQPointArray() {
			ProxyQPointArray().NewQPointArray();
		}
		public QPointArray(int size) : this((Type) null) {
			CreateQPointArrayProxy();
			NewQPointArray(size);
		}
		private void NewQPointArray(int size) {
			ProxyQPointArray().NewQPointArray(size);
		}
		public QPointArray(QPointArray a) : this((Type) null) {
			CreateQPointArrayProxy();
			NewQPointArray(a);
		}
		private void NewQPointArray(QPointArray a) {
			ProxyQPointArray().NewQPointArray(a);
		}
		public QPointArray(QRect r, bool closed) : this((Type) null) {
			CreateQPointArrayProxy();
			NewQPointArray(r,closed);
		}
		private void NewQPointArray(QRect r, bool closed) {
			ProxyQPointArray().NewQPointArray(r,closed);
		}
		public QPointArray(QRect r) : this((Type) null) {
			CreateQPointArrayProxy();
			NewQPointArray(r);
		}
		private void NewQPointArray(QRect r) {
			ProxyQPointArray().NewQPointArray(r);
		}
		public QPointArray(int nPoints, out short points) : this((Type) null) {
			CreateQPointArrayProxy();
			NewQPointArray(nPoints,out points);
		}
		private void NewQPointArray(int nPoints, out short points) {
			ProxyQPointArray().NewQPointArray(nPoints,out points);
		}
		public new QPointArray Copy() {
			return ProxyQPointArray().Copy();
		}
		public void Translate(int dx, int dy) {
			ProxyQPointArray().Translate(dx,dy);
		}
		public QRect BoundingRect() {
			return ProxyQPointArray().BoundingRect();
		}
		public void Point(uint i, out int x, out int y) {
			ProxyQPointArray().Point(i,out x,out y);
		}
		public QPoint Point(uint i) {
			return ProxyQPointArray().Point(i);
		}
		public void SetPoint(uint i, int x, int y) {
			ProxyQPointArray().SetPoint(i,x,y);
		}
		public void SetPoint(uint i, QPoint p) {
			ProxyQPointArray().SetPoint(i,p);
		}
		public bool SetPoints(int nPoints, out short points) {
			return ProxyQPointArray().SetPoints(nPoints,out points);
		}
		public bool PutPoints(int index, int nPoints, out short points) {
			return ProxyQPointArray().PutPoints(index,nPoints,out points);
		}
		public bool PutPoints(int index, int nPoints, QPointArray from, int fromIndex) {
			return ProxyQPointArray().PutPoints(index,nPoints,from,fromIndex);
		}
		public bool PutPoints(int index, int nPoints, QPointArray from) {
			return ProxyQPointArray().PutPoints(index,nPoints,from);
		}
		public void MakeArc(int x, int y, int w, int h, int a1, int a2) {
			ProxyQPointArray().MakeArc(x,y,w,h,a1,a2);
		}
		public void MakeEllipse(int x, int y, int w, int h) {
			ProxyQPointArray().MakeEllipse(x,y,w,h);
		}
		public void MakeArc(int x, int y, int w, int h, int a1, int a2, QWMatrix arg7) {
			ProxyQPointArray().MakeArc(x,y,w,h,a1,a2,arg7);
		}
		public QPointArray CubicBezier() {
			return ProxyQPointArray().CubicBezier();
		}
		// void* shortPoints(int arg1,int arg2); >>>> NOT CONVERTED
		// void* shortPoints(int arg1); >>>> NOT CONVERTED
		// void* shortPoints(); >>>> NOT CONVERTED
		public static void CleanBuffers() {
			StaticQPointArray().CleanBuffers();
		}
		~QPointArray() {
			ProxyQPointArray().Dispose();
		}
		public void Dispose() {
			ProxyQPointArray().Dispose();
		}
//	public native int size();
//	public native int count();
//	public native bool isEmpty();
//	public native bool isNull();
//	public native bool resize( int size);
//	public native bool truncate( int pos);
//	public native int begin();
//	public native int end();
//	public native QPoint at(int index);
	
	}
}
