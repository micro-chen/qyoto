//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QPointF : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QPointF(Type dummy) {}
		interface IQPointFProxy {
		}

		protected void CreateQPointFProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPointF), this);
			_interceptor = (QPointF) realProxy.GetTransparentProxy();
		}
		private QPointF ProxyQPointF() {
			return (QPointF) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPointF() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPointFProxy), null);
			_staticInterceptor = (IQPointFProxy) realProxy.GetTransparentProxy();
		}
		private static IQPointFProxy StaticQPointF() {
			return (IQPointFProxy) _staticInterceptor;
		}

		public QPointF() : this((Type) null) {
			CreateQPointFProxy();
			NewQPointF();
		}
		private void NewQPointF() {
			ProxyQPointF().NewQPointF();
		}
		public QPointF(QPoint p) : this((Type) null) {
			CreateQPointFProxy();
			NewQPointF(p);
		}
		private void NewQPointF(QPoint p) {
			ProxyQPointF().NewQPointF(p);
		}
		// QPointF* QPointF(qreal arg1,qreal arg2); >>>> NOT CONVERTED
		public bool IsNull() {
			return ProxyQPointF().IsNull();
		}
		// qreal x(); >>>> NOT CONVERTED
		// qreal y(); >>>> NOT CONVERTED
		// void setX(qreal arg1); >>>> NOT CONVERTED
		// void setY(qreal arg1); >>>> NOT CONVERTED
		// qreal& rx(); >>>> NOT CONVERTED
		// qreal& ry(); >>>> NOT CONVERTED
		// QPointF& operator*=(qreal arg1); >>>> NOT CONVERTED
		// QPointF& operator/=(qreal arg1); >>>> NOT CONVERTED
		public QPoint ToPoint() {
			return ProxyQPointF().ToPoint();
		}
		~QPointF() {
			ProxyQPointF().Dispose();
		}
		public void Dispose() {
			ProxyQPointF().Dispose();
		}
	}
}
