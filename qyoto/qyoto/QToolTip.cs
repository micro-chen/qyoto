//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QToolTip")]
	public class QToolTip : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QToolTip(Type dummy) {}
		interface IQToolTipProxy {
			void ShowText(QPoint pos, string text, QWidget w);
			void ShowText(QPoint pos, string text);
			QPalette Palette();
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QToolTip), this);
			_interceptor = (QToolTip) realProxy.GetTransparentProxy();
		}
		private QToolTip ProxyQToolTip() {
			return (QToolTip) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QToolTip() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQToolTipProxy), null);
			_staticInterceptor = (IQToolTipProxy) realProxy.GetTransparentProxy();
		}
		private static IQToolTipProxy StaticQToolTip() {
			return (IQToolTipProxy) _staticInterceptor;
		}

		[SmokeMethod("showText(const QPoint&, const QString&, QWidget*)")]
		public static void ShowText(QPoint pos, string text, QWidget w) {
			StaticQToolTip().ShowText(pos,text,w);
		}
		[SmokeMethod("showText(const QPoint&, const QString&)")]
		public static void ShowText(QPoint pos, string text) {
			StaticQToolTip().ShowText(pos,text);
		}
		[SmokeMethod("palette()")]
		public static QPalette Palette() {
			return StaticQToolTip().Palette();
		}
		~QToolTip() {
			DisposeQToolTip();
		}
		public void Dispose() {
			DisposeQToolTip();
		}
		private void DisposeQToolTip() {
			ProxyQToolTip().DisposeQToolTip();
		}
	}
}
