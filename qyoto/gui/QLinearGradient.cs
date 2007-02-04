//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QLinearGradient")]
	public class QLinearGradient : QGradient, IDisposable {
 		protected QLinearGradient(Type dummy) : base((Type) null) {}
		[SmokeClass("QLinearGradient")]
		interface IQLinearGradientProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QLinearGradient), this);
			_interceptor = (QLinearGradient) realProxy.GetTransparentProxy();
		}
		private QLinearGradient ProxyQLinearGradient() {
			return (QLinearGradient) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QLinearGradient() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQLinearGradientProxy), null);
			_staticInterceptor = (IQLinearGradientProxy) realProxy.GetTransparentProxy();
		}
		private static IQLinearGradientProxy StaticQLinearGradient() {
			return (IQLinearGradientProxy) _staticInterceptor;
		}
		public QLinearGradient() : this((Type) null) {
			CreateProxy();
			NewQLinearGradient();
		}
		[SmokeMethod("QLinearGradient", "()", "")]
		private void NewQLinearGradient() {
			ProxyQLinearGradient().NewQLinearGradient();
		}
		public QLinearGradient(QPointF start, QPointF finalStop) : this((Type) null) {
			CreateProxy();
			NewQLinearGradient(start,finalStop);
		}
		[SmokeMethod("QLinearGradient", "(const QPointF&, const QPointF&)", "##")]
		private void NewQLinearGradient(QPointF start, QPointF finalStop) {
			ProxyQLinearGradient().NewQLinearGradient(start,finalStop);
		}
		public QLinearGradient(double xStart, double yStart, double xFinalStop, double yFinalStop) : this((Type) null) {
			CreateProxy();
			NewQLinearGradient(xStart,yStart,xFinalStop,yFinalStop);
		}
		[SmokeMethod("QLinearGradient", "(qreal, qreal, qreal, qreal)", "$$$$")]
		private void NewQLinearGradient(double xStart, double yStart, double xFinalStop, double yFinalStop) {
			ProxyQLinearGradient().NewQLinearGradient(xStart,yStart,xFinalStop,yFinalStop);
		}
		[SmokeMethod("start", "() const", "")]
		public QPointF Start() {
			return ProxyQLinearGradient().Start();
		}
		[SmokeMethod("setStart", "(const QPointF&)", "#")]
		public void SetStart(QPointF start) {
			ProxyQLinearGradient().SetStart(start);
		}
		[SmokeMethod("setStart", "(qreal, qreal)", "$$")]
		public void SetStart(double x, double y) {
			ProxyQLinearGradient().SetStart(x,y);
		}
		[SmokeMethod("finalStop", "() const", "")]
		public QPointF FinalStop() {
			return ProxyQLinearGradient().FinalStop();
		}
		[SmokeMethod("setFinalStop", "(const QPointF&)", "#")]
		public void SetFinalStop(QPointF stop) {
			ProxyQLinearGradient().SetFinalStop(stop);
		}
		[SmokeMethod("setFinalStop", "(qreal, qreal)", "$$")]
		public void SetFinalStop(double x, double y) {
			ProxyQLinearGradient().SetFinalStop(x,y);
		}
		~QLinearGradient() {
			DisposeQLinearGradient();
		}
		public void Dispose() {
			DisposeQLinearGradient();
		}
		[SmokeMethod("~QLinearGradient", "()", "")]
		private void DisposeQLinearGradient() {
			ProxyQLinearGradient().DisposeQLinearGradient();
		}
	}
}
