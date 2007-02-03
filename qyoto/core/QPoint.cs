//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QPoint")]
	public class QPoint : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QPoint(Type dummy) {}
		interface IQPointProxy {
			[SmokeMethod("operator*=", "(qreal)", "$")]
			QPoint op_mult(QPoint lhs, double c);
			[SmokeMethod("operator/=", "(qreal)", "$")]
			QPoint op_div(QPoint lhs, double c);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPoint), this);
			_interceptor = (QPoint) realProxy.GetTransparentProxy();
		}
		private QPoint ProxyQPoint() {
			return (QPoint) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPoint() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPointProxy), null);
			_staticInterceptor = (IQPointProxy) realProxy.GetTransparentProxy();
		}
		private static IQPointProxy StaticQPoint() {
			return (IQPointProxy) _staticInterceptor;
		}

		public QPoint() : this((Type) null) {
			CreateProxy();
			NewQPoint();
		}
		[SmokeMethod("QPoint", "()", "")]
		private void NewQPoint() {
			ProxyQPoint().NewQPoint();
		}
		public QPoint(int xpos, int ypos) : this((Type) null) {
			CreateProxy();
			NewQPoint(xpos,ypos);
		}
		[SmokeMethod("QPoint", "(int, int)", "$$")]
		private void NewQPoint(int xpos, int ypos) {
			ProxyQPoint().NewQPoint(xpos,ypos);
		}
		[SmokeMethod("isNull", "() const", "")]
		public bool IsNull() {
			return ProxyQPoint().IsNull();
		}
		[SmokeMethod("x", "() const", "")]
		public int X() {
			return ProxyQPoint().X();
		}
		[SmokeMethod("y", "() const", "")]
		public int Y() {
			return ProxyQPoint().Y();
		}
		[SmokeMethod("setX", "(int)", "$")]
		public void SetX(int x) {
			ProxyQPoint().SetX(x);
		}
		[SmokeMethod("setY", "(int)", "$")]
		public void SetY(int y) {
			ProxyQPoint().SetY(y);
		}
		[SmokeMethod("manhattanLength", "() const", "")]
		public int ManhattanLength() {
			return ProxyQPoint().ManhattanLength();
		}
		[SmokeMethod("rx", "()", "")]
		public int Rx() {
			return ProxyQPoint().Rx();
		}
		[SmokeMethod("ry", "()", "")]
		public int Ry() {
			return ProxyQPoint().Ry();
		}
		public static QPoint operator*(QPoint lhs, double c) {
			return StaticQPoint().op_mult(lhs,c);
		}
		public static QPoint operator/(QPoint lhs, double c) {
			return StaticQPoint().op_div(lhs,c);
		}
		~QPoint() {
			DisposeQPoint();
		}
		public void Dispose() {
			DisposeQPoint();
		}
		[SmokeMethod("~QPoint", "()", "")]
		private void DisposeQPoint() {
			ProxyQPoint().DisposeQPoint();
		}
	}
}
