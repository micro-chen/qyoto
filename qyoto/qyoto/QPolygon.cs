//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QPolygon")]
	public class QPolygon : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QPolygon(Type dummy) {}
		interface IQPolygonProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPolygon), this);
			_interceptor = (QPolygon) realProxy.GetTransparentProxy();
		}
		private QPolygon ProxyQPolygon() {
			return (QPolygon) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPolygon() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPolygonProxy), null);
			_staticInterceptor = (IQPolygonProxy) realProxy.GetTransparentProxy();
		}
		private static IQPolygonProxy StaticQPolygon() {
			return (IQPolygonProxy) _staticInterceptor;
		}

		public QPolygon() : this((Type) null) {
			CreateProxy();
			NewQPolygon();
		}
		[SmokeMethod("QPolygon()")]
		private void NewQPolygon() {
			ProxyQPolygon().NewQPolygon();
		}
		public QPolygon(int size) : this((Type) null) {
			CreateProxy();
			NewQPolygon(size);
		}
		[SmokeMethod("QPolygon(int)")]
		private void NewQPolygon(int size) {
			ProxyQPolygon().NewQPolygon(size);
		}
		public QPolygon(QPolygon a) : this((Type) null) {
			CreateProxy();
			NewQPolygon(a);
		}
		[SmokeMethod("QPolygon(const QPolygon&)")]
		private void NewQPolygon(QPolygon a) {
			ProxyQPolygon().NewQPolygon(a);
		}
		// QPolygon* QPolygon(const QVector<QPoint>& arg1); >>>> NOT CONVERTED
		public QPolygon(QRect r, bool closed) : this((Type) null) {
			CreateProxy();
			NewQPolygon(r,closed);
		}
		[SmokeMethod("QPolygon(const QRect&, bool)")]
		private void NewQPolygon(QRect r, bool closed) {
			ProxyQPolygon().NewQPolygon(r,closed);
		}
		public QPolygon(QRect r) : this((Type) null) {
			CreateProxy();
			NewQPolygon(r);
		}
		[SmokeMethod("QPolygon(const QRect&)")]
		private void NewQPolygon(QRect r) {
			ProxyQPolygon().NewQPolygon(r);
		}
		public QPolygon(int nPoints, out int points) : this((Type) null) {
			CreateProxy();
			NewQPolygon(nPoints,out points);
		}
		[SmokeMethod("QPolygon(int, const int*)")]
		private void NewQPolygon(int nPoints, out int points) {
			ProxyQPolygon().NewQPolygon(nPoints,out points);
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		[SmokeMethod("translate(int, int)")]
		public void Translate(int dx, int dy) {
			ProxyQPolygon().Translate(dx,dy);
		}
		[SmokeMethod("translate(const QPoint&)")]
		public void Translate(QPoint offset) {
			ProxyQPolygon().Translate(offset);
		}
		[SmokeMethod("boundingRect() const")]
		public QRect BoundingRect() {
			return ProxyQPolygon().BoundingRect();
		}
		[SmokeMethod("point(int, int*, int*) const")]
		public void Point(int i, out int x, out int y) {
			ProxyQPolygon().Point(i,out x,out y);
		}
		[SmokeMethod("point(int) const")]
		public QPoint Point(int i) {
			return ProxyQPolygon().Point(i);
		}
		[SmokeMethod("setPoint(int, int, int)")]
		public void SetPoint(int index, int x, int y) {
			ProxyQPolygon().SetPoint(index,x,y);
		}
		[SmokeMethod("setPoint(int, const QPoint&)")]
		public void SetPoint(int index, QPoint p) {
			ProxyQPolygon().SetPoint(index,p);
		}
		[SmokeMethod("setPoints(int, const int*)")]
		public void SetPoints(int nPoints, out int points) {
			ProxyQPolygon().SetPoints(nPoints,out points);
		}
		[SmokeMethod("putPoints(int, int, const int*)")]
		public void PutPoints(int index, int nPoints, out int points) {
			ProxyQPolygon().PutPoints(index,nPoints,out points);
		}
		[SmokeMethod("putPoints(int, int, const QPolygon&, int)")]
		public void PutPoints(int index, int nPoints, QPolygon from, int fromIndex) {
			ProxyQPolygon().PutPoints(index,nPoints,from,fromIndex);
		}
		[SmokeMethod("putPoints(int, int, const QPolygon&)")]
		public void PutPoints(int index, int nPoints, QPolygon from) {
			ProxyQPolygon().PutPoints(index,nPoints,from);
		}
		~QPolygon() {
			DisposeQPolygon();
		}
		public void Dispose() {
			DisposeQPolygon();
		}
		private void DisposeQPolygon() {
			ProxyQPolygon().DisposeQPolygon();
		}
	}
}
