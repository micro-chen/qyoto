//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QPolygonF : IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QPolygonF(Type dummy) {}
		interface IQPolygonFProxy {
		}

		protected void CreateQPolygonFProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPolygonF), this);
			_interceptor = (QPolygonF) realProxy.GetTransparentProxy();
		}
		private QPolygonF ProxyQPolygonF() {
			return (QPolygonF) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPolygonF() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPolygonFProxy), null);
			_staticInterceptor = (IQPolygonFProxy) realProxy.GetTransparentProxy();
		}
		private static IQPolygonFProxy StaticQPolygonF() {
			return (IQPolygonFProxy) _staticInterceptor;
		}

		public QPolygonF() : this((Type) null) {
			CreateQPolygonFProxy();
			NewQPolygonF();
		}
		private void NewQPolygonF() {
			ProxyQPolygonF().NewQPolygonF();
		}
		public QPolygonF(int size) : this((Type) null) {
			CreateQPolygonFProxy();
			NewQPolygonF(size);
		}
		private void NewQPolygonF(int size) {
			ProxyQPolygonF().NewQPolygonF(size);
		}
		public QPolygonF(QPolygonF a) : this((Type) null) {
			CreateQPolygonFProxy();
			NewQPolygonF(a);
		}
		private void NewQPolygonF(QPolygonF a) {
			ProxyQPolygonF().NewQPolygonF(a);
		}
		// QPolygonF* QPolygonF(const QVector<QPointF>& arg1); >>>> NOT CONVERTED
		public QPolygonF(QRectF r) : this((Type) null) {
			CreateQPolygonFProxy();
			NewQPolygonF(r);
		}
		private void NewQPolygonF(QRectF r) {
			ProxyQPolygonF().NewQPolygonF(r);
		}
		public QPolygonF(QPolygon a) : this((Type) null) {
			CreateQPolygonFProxy();
			NewQPolygonF(a);
		}
		private void NewQPolygonF(QPolygon a) {
			ProxyQPolygonF().NewQPolygonF(a);
		}
		// void translate(qreal arg1,qreal arg2); >>>> NOT CONVERTED
		public void Translate(QPointF offset) {
			ProxyQPolygonF().Translate(offset);
		}
		public QPolygon ToPolygon() {
			return ProxyQPolygonF().ToPolygon();
		}
		public bool IsClosed() {
			return ProxyQPolygonF().IsClosed();
		}
		public QRectF BoundingRect() {
			return ProxyQPolygonF().BoundingRect();
		}
		~QPolygonF() {
			ProxyQPolygonF().Dispose();
		}
		public void Dispose() {
			ProxyQPolygonF().Dispose();
		}
	}
}
