//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QMatrix")]
	public class QMatrix : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QMatrix(Type dummy) {}
		interface IQMatrixProxy {
			[SmokeMethod("operator==", "(const QMatrix&) const", "#")]
			bool op_equals(QMatrix lhs, QMatrix arg1);
			[SmokeMethod("operator*", "(const QMatrix&) const", "#")]
			QMatrix op_mult(QMatrix lhs, QMatrix o);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMatrix), this);
			_interceptor = (QMatrix) realProxy.GetTransparentProxy();
		}
		private QMatrix ProxyQMatrix() {
			return (QMatrix) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMatrix() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMatrixProxy), null);
			_staticInterceptor = (IQMatrixProxy) realProxy.GetTransparentProxy();
		}
		private static IQMatrixProxy StaticQMatrix() {
			return (IQMatrixProxy) _staticInterceptor;
		}

		public QMatrix() : this((Type) null) {
			CreateProxy();
			NewQMatrix();
		}
		[SmokeMethod("QMatrix", "()", "")]
		private void NewQMatrix() {
			ProxyQMatrix().NewQMatrix();
		}
		public QMatrix(double m11, double m12, double m21, double m22, double dx, double dy) : this((Type) null) {
			CreateProxy();
			NewQMatrix(m11,m12,m21,m22,dx,dy);
		}
		[SmokeMethod("QMatrix", "(qreal, qreal, qreal, qreal, qreal, qreal)", "$$$$$$")]
		private void NewQMatrix(double m11, double m12, double m21, double m22, double dx, double dy) {
			ProxyQMatrix().NewQMatrix(m11,m12,m21,m22,dx,dy);
		}
		public QMatrix(QMatrix matrix) : this((Type) null) {
			CreateProxy();
			NewQMatrix(matrix);
		}
		[SmokeMethod("QMatrix", "(const QMatrix&)", "#")]
		private void NewQMatrix(QMatrix matrix) {
			ProxyQMatrix().NewQMatrix(matrix);
		}
		[SmokeMethod("setMatrix", "(qreal, qreal, qreal, qreal, qreal, qreal)", "$$$$$$")]
		public void SetMatrix(double m11, double m12, double m21, double m22, double dx, double dy) {
			ProxyQMatrix().SetMatrix(m11,m12,m21,m22,dx,dy);
		}
		[SmokeMethod("m11", "() const", "")]
		public double M11() {
			return ProxyQMatrix().M11();
		}
		[SmokeMethod("m12", "() const", "")]
		public double M12() {
			return ProxyQMatrix().M12();
		}
		[SmokeMethod("m21", "() const", "")]
		public double M21() {
			return ProxyQMatrix().M21();
		}
		[SmokeMethod("m22", "() const", "")]
		public double M22() {
			return ProxyQMatrix().M22();
		}
		[SmokeMethod("dx", "() const", "")]
		public double Dx() {
			return ProxyQMatrix().Dx();
		}
		[SmokeMethod("dy", "() const", "")]
		public double Dy() {
			return ProxyQMatrix().Dy();
		}
		[SmokeMethod("map", "(int, int, int*, int*) const", "$$$$")]
		public void Map(int x, int y, out int tx, out int ty) {
			ProxyQMatrix().Map(x,y,out tx,out ty);
		}
		// void map(qreal arg1,qreal arg2,qreal* arg3,qreal* arg4); >>>> NOT CONVERTED
		[SmokeMethod("mapRect", "(const QRect&) const", "#")]
		public QRect MapRect(QRect arg1) {
			return ProxyQMatrix().MapRect(arg1);
		}
		[SmokeMethod("mapRect", "(const QRectF&) const", "#")]
		public QRectF MapRect(QRectF arg1) {
			return ProxyQMatrix().MapRect(arg1);
		}
		[SmokeMethod("map", "(const QPoint&) const", "#")]
		public QPoint Map(QPoint p) {
			return ProxyQMatrix().Map(p);
		}
		[SmokeMethod("map", "(const QPointF&) const", "#")]
		public QPointF Map(QPointF p) {
			return ProxyQMatrix().Map(p);
		}
		[SmokeMethod("map", "(const QLine&) const", "#")]
		public QLine Map(QLine l) {
			return ProxyQMatrix().Map(l);
		}
		[SmokeMethod("map", "(const QLineF&) const", "#")]
		public QLineF Map(QLineF l) {
			return ProxyQMatrix().Map(l);
		}
		[SmokeMethod("map", "(const QPolygonF&) const", "#")]
		public QPolygonF Map(QPolygonF a) {
			return ProxyQMatrix().Map(a);
		}
		[SmokeMethod("map", "(const QPolygon&) const", "#")]
		public QPolygon Map(QPolygon a) {
			return ProxyQMatrix().Map(a);
		}
		[SmokeMethod("map", "(const QRegion&) const", "#")]
		public QRegion Map(QRegion r) {
			return ProxyQMatrix().Map(r);
		}
		[SmokeMethod("map", "(const QPainterPath&) const", "#")]
		public QPainterPath Map(QPainterPath p) {
			return ProxyQMatrix().Map(p);
		}
		[SmokeMethod("mapToPolygon", "(const QRect&) const", "#")]
		public QPolygon MapToPolygon(QRect r) {
			return ProxyQMatrix().MapToPolygon(r);
		}
		[SmokeMethod("reset", "()", "")]
		public void Reset() {
			ProxyQMatrix().Reset();
		}
		[SmokeMethod("isIdentity", "() const", "")]
		public bool IsIdentity() {
			return ProxyQMatrix().IsIdentity();
		}
		[SmokeMethod("translate", "(qreal, qreal)", "$$")]
		public QMatrix Translate(double dx, double dy) {
			return ProxyQMatrix().Translate(dx,dy);
		}
		[SmokeMethod("scale", "(qreal, qreal)", "$$")]
		public QMatrix Scale(double sx, double sy) {
			return ProxyQMatrix().Scale(sx,sy);
		}
		[SmokeMethod("shear", "(qreal, qreal)", "$$")]
		public QMatrix Shear(double sh, double sv) {
			return ProxyQMatrix().Shear(sh,sv);
		}
		[SmokeMethod("rotate", "(qreal)", "$")]
		public QMatrix Rotate(double a) {
			return ProxyQMatrix().Rotate(a);
		}
		[SmokeMethod("isInvertible", "() const", "")]
		public bool IsInvertible() {
			return ProxyQMatrix().IsInvertible();
		}
		[SmokeMethod("det", "() const", "")]
		public double Det() {
			return ProxyQMatrix().Det();
		}
		[SmokeMethod("inverted", "(bool*) const", "$")]
		public QMatrix Inverted(out bool invertible) {
			return ProxyQMatrix().Inverted(out invertible);
		}
		[SmokeMethod("inverted", "() const", "")]
		public QMatrix Inverted() {
			return ProxyQMatrix().Inverted();
		}
		public static bool operator==(QMatrix lhs, QMatrix arg1) {
			return StaticQMatrix().op_equals(lhs,arg1);
		}
		public static bool operator!=(QMatrix lhs, QMatrix arg1) {
			return !StaticQMatrix().op_equals(lhs,arg1);
		}
		public override bool Equals(object o) {
			if (!(o is QMatrix)) { return false; }
			return this == (QMatrix) o;
		}
		public override int GetHashCode() {
			return ProxyQMatrix().GetHashCode();
		}
		public static QMatrix operator*(QMatrix lhs, QMatrix o) {
			return StaticQMatrix().op_mult(lhs,o);
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		~QMatrix() {
			DisposeQMatrix();
		}
		public void Dispose() {
			DisposeQMatrix();
		}
		[SmokeMethod("~QMatrix", "()", "")]
		private void DisposeQMatrix() {
			ProxyQMatrix().DisposeQMatrix();
		}
	}
}
