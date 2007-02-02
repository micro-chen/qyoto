//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGraphicsSceneHoverEvent")]
	public class QGraphicsSceneHoverEvent : QGraphicsSceneEvent, IDisposable {
 		protected QGraphicsSceneHoverEvent(Type dummy) : base((Type) null) {}
		interface IQGraphicsSceneHoverEventProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsSceneHoverEvent), this);
			_interceptor = (QGraphicsSceneHoverEvent) realProxy.GetTransparentProxy();
		}
		private QGraphicsSceneHoverEvent ProxyQGraphicsSceneHoverEvent() {
			return (QGraphicsSceneHoverEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGraphicsSceneHoverEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGraphicsSceneHoverEventProxy), null);
			_staticInterceptor = (IQGraphicsSceneHoverEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQGraphicsSceneHoverEventProxy StaticQGraphicsSceneHoverEvent() {
			return (IQGraphicsSceneHoverEventProxy) _staticInterceptor;
		}

		public QGraphicsSceneHoverEvent(QEvent.TypeOf type) : this((Type) null) {
			CreateProxy();
			NewQGraphicsSceneHoverEvent(type);
		}
		[SmokeMethod("QGraphicsSceneHoverEvent(QEvent::Type)")]
		private void NewQGraphicsSceneHoverEvent(QEvent.TypeOf type) {
			ProxyQGraphicsSceneHoverEvent().NewQGraphicsSceneHoverEvent(type);
		}
		public QGraphicsSceneHoverEvent() : this((Type) null) {
			CreateProxy();
			NewQGraphicsSceneHoverEvent();
		}
		[SmokeMethod("QGraphicsSceneHoverEvent()")]
		private void NewQGraphicsSceneHoverEvent() {
			ProxyQGraphicsSceneHoverEvent().NewQGraphicsSceneHoverEvent();
		}
		[SmokeMethod("pos() const")]
		public QPointF Pos() {
			return ProxyQGraphicsSceneHoverEvent().Pos();
		}
		[SmokeMethod("setPos(const QPointF&)")]
		public void SetPos(QPointF pos) {
			ProxyQGraphicsSceneHoverEvent().SetPos(pos);
		}
		[SmokeMethod("scenePos() const")]
		public QPointF ScenePos() {
			return ProxyQGraphicsSceneHoverEvent().ScenePos();
		}
		[SmokeMethod("setScenePos(const QPointF&)")]
		public void SetScenePos(QPointF pos) {
			ProxyQGraphicsSceneHoverEvent().SetScenePos(pos);
		}
		[SmokeMethod("screenPos() const")]
		public QPoint ScreenPos() {
			return ProxyQGraphicsSceneHoverEvent().ScreenPos();
		}
		[SmokeMethod("setScreenPos(const QPoint&)")]
		public void SetScreenPos(QPoint pos) {
			ProxyQGraphicsSceneHoverEvent().SetScreenPos(pos);
		}
		~QGraphicsSceneHoverEvent() {
			DisposeQGraphicsSceneHoverEvent();
		}
		public new void Dispose() {
			DisposeQGraphicsSceneHoverEvent();
		}
		[SmokeMethod("~QGraphicsSceneHoverEvent()")]
		private void DisposeQGraphicsSceneHoverEvent() {
			ProxyQGraphicsSceneHoverEvent().DisposeQGraphicsSceneHoverEvent();
		}
	}
}
