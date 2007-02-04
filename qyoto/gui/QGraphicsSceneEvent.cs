//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGraphicsSceneEvent")]
	public class QGraphicsSceneEvent : QEvent, IDisposable {
 		protected QGraphicsSceneEvent(Type dummy) : base((Type) null) {}
		[SmokeClass("QGraphicsSceneEvent")]
		interface IQGraphicsSceneEventProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsSceneEvent), this);
			_interceptor = (QGraphicsSceneEvent) realProxy.GetTransparentProxy();
		}
		private QGraphicsSceneEvent ProxyQGraphicsSceneEvent() {
			return (QGraphicsSceneEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGraphicsSceneEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGraphicsSceneEventProxy), null);
			_staticInterceptor = (IQGraphicsSceneEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQGraphicsSceneEventProxy StaticQGraphicsSceneEvent() {
			return (IQGraphicsSceneEventProxy) _staticInterceptor;
		}
		public QGraphicsSceneEvent(QEvent.TypeOf type) : this((Type) null) {
			CreateProxy();
			NewQGraphicsSceneEvent(type);
		}
		[SmokeMethod("QGraphicsSceneEvent", "(QEvent::Type)", "$")]
		private void NewQGraphicsSceneEvent(QEvent.TypeOf type) {
			ProxyQGraphicsSceneEvent().NewQGraphicsSceneEvent(type);
		}
		[SmokeMethod("widget", "() const", "")]
		public QWidget Widget() {
			return ProxyQGraphicsSceneEvent().Widget();
		}
		[SmokeMethod("setWidget", "(QWidget*)", "#")]
		public void SetWidget(QWidget widget) {
			ProxyQGraphicsSceneEvent().SetWidget(widget);
		}
		~QGraphicsSceneEvent() {
			DisposeQGraphicsSceneEvent();
		}
		public new void Dispose() {
			DisposeQGraphicsSceneEvent();
		}
		[SmokeMethod("~QGraphicsSceneEvent", "()", "")]
		private void DisposeQGraphicsSceneEvent() {
			ProxyQGraphicsSceneEvent().DisposeQGraphicsSceneEvent();
		}
	}
}
