//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QEvent")]
	public class QEvent : Qt, IDisposable {
 		protected QEvent(Type dummy) : base((Type) null) {}
		interface IQEventProxy {
		}

		protected void CreateQEventProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QEvent), this);
			_interceptor = (QEvent) realProxy.GetTransparentProxy();
		}
		private QEvent ProxyQEvent() {
			return (QEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQEventProxy), null);
			_staticInterceptor = (IQEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQEventProxy StaticQEvent() {
			return (IQEventProxy) _staticInterceptor;
		}

		enum E_Type {
			None = 0,
			Timer = 1,
			MouseButtonPress = 2,
			MouseButtonRelease = 3,
			MouseButtonDblClick = 4,
			MouseMove = 5,
			KeyPress = 6,
			KeyRelease = 7,
			FocusIn = 8,
			FocusOut = 9,
			Enter = 10,
			Leave = 11,
			Paint = 12,
			Move = 13,
			Resize = 14,
			Create = 15,
			Destroy = 16,
			Show = 17,
			Hide = 18,
			Close = 19,
			Quit = 20,
			Reparent = 21,
			ShowMinimized = 22,
			ShowNormal = 23,
			WindowActivate = 24,
			WindowDeactivate = 25,
			ShowToParent = 26,
			HideToParent = 27,
			ShowMaximized = 28,
			ShowFullScreen = 29,
			Accel = 30,
			Wheel = 31,
			AccelAvailable = 32,
			CaptionChange = 33,
			IconChange = 34,
			ParentFontChange = 35,
			ApplicationFontChange = 36,
			ParentPaletteChange = 37,
			ApplicationPaletteChange = 38,
			PaletteChange = 39,
			Clipboard = 40,
			Speech = 42,
			SockAct = 50,
			AccelOverride = 51,
			DeferredDelete = 52,
			DragEnter = 60,
			DragMove = 61,
			DragLeave = 62,
			Drop = 63,
			DragResponse = 64,
			ChildInserted = 70,
			ChildRemoved = 71,
			LayoutHint = 72,
			ShowWindowRequest = 73,
			WindowBlocked = 74,
			WindowUnblocked = 75,
			ActivateControl = 80,
			DeactivateControl = 81,
			ContextMenu = 82,
			IMStart = 83,
			IMCompose = 84,
			IMEnd = 85,
			Accessibility = 86,
			TabletMove = 87,
			LocaleChange = 88,
			LanguageChange = 89,
			LayoutDirectionChange = 90,
			Style = 91,
			TabletPress = 92,
			TabletRelease = 93,
			OkRequest = 94,
			HelpRequest = 95,
			WindowStateChange = 96,
			IconDrag = 97,
			User = 1000,
			MaxUser = 65535,
		}
		public QEvent(int type) : this((Type) null) {
			CreateQEventProxy();
			NewQEvent(type);
		}
		[SmokeMethod("QEvent(QEvent::Type)")]
		private void NewQEvent(int type) {
			ProxyQEvent().NewQEvent(type);
		}
		[SmokeMethod("spontaneous() const")]
		public bool Spontaneous() {
			return ProxyQEvent().Spontaneous();
		}
		~QEvent() {
			DisposeQEvent();
		}
		public void Dispose() {
			DisposeQEvent();
		}
		private void DisposeQEvent() {
			ProxyQEvent().DisposeQEvent();
		}
	}
}
