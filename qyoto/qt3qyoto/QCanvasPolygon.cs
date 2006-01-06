//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QCanvasPolygon")]
	public class QCanvasPolygon : QCanvasPolygonalItem, IDisposable {
 		protected QCanvasPolygon(Type dummy) : base((Type) null) {}
		interface IQCanvasPolygonProxy {
		}

		protected void CreateQCanvasPolygonProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QCanvasPolygon), this);
			_interceptor = (QCanvasPolygon) realProxy.GetTransparentProxy();
		}
		private QCanvasPolygon ProxyQCanvasPolygon() {
			return (QCanvasPolygon) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QCanvasPolygon() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCanvasPolygonProxy), null);
			_staticInterceptor = (IQCanvasPolygonProxy) realProxy.GetTransparentProxy();
		}
		private static IQCanvasPolygonProxy StaticQCanvasPolygon() {
			return (IQCanvasPolygonProxy) _staticInterceptor;
		}

		public QCanvasPolygon(QCanvas canvas) : this((Type) null) {
			CreateQCanvasPolygonProxy();
			NewQCanvasPolygon(canvas);
		}
		[SmokeMethod("QCanvasPolygon(QCanvas*)")]
		private void NewQCanvasPolygon(QCanvas canvas) {
			ProxyQCanvasPolygon().NewQCanvasPolygon(canvas);
		}
		[SmokeMethod("setPoints(QPointArray)")]
		public void SetPoints(QPointArray arg1) {
			ProxyQCanvasPolygon().SetPoints(arg1);
		}
		[SmokeMethod("points() const")]
		public QPointArray Points() {
			return ProxyQCanvasPolygon().Points();
		}
		[SmokeMethod("moveBy(double, double)")]
		public new void MoveBy(double dx, double dy) {
			ProxyQCanvasPolygon().MoveBy(dx,dy);
		}
		[SmokeMethod("areaPoints() const")]
		public new QPointArray AreaPoints() {
			return ProxyQCanvasPolygon().AreaPoints();
		}
		[SmokeMethod("rtti() const")]
		public new int Rtti() {
			return ProxyQCanvasPolygon().Rtti();
		}
		[SmokeMethod("drawShape(QPainter&)")]
		protected new void DrawShape(QPainter arg1) {
			ProxyQCanvasPolygon().DrawShape(arg1);
		}
		~QCanvasPolygon() {
			DisposeQCanvasPolygon();
		}
		public new void Dispose() {
			DisposeQCanvasPolygon();
		}
		private void DisposeQCanvasPolygon() {
			ProxyQCanvasPolygon().DisposeQCanvasPolygon();
		}
	}
}
