//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QFontDialog")]
	public class QFontDialog : QDialog {
 		protected QFontDialog(Type dummy) : base((Type) null) {}
		[SmokeClass("QFontDialog")]
		interface IQFontDialogProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
			[SmokeMethod("getFont", "(bool*, const QFont&, QWidget*, const QString&)", "$##$")]
			QFont GetFont(out bool ok, QFont def, QWidget parent, string caption);
			[SmokeMethod("getFont", "(bool*, const QFont&, QWidget*)", "$##")]
			QFont GetFont(out bool ok, QFont def, QWidget parent);
			[SmokeMethod("getFont", "(bool*, const QFont&)", "$#")]
			QFont GetFont(out bool ok, QFont def);
			[SmokeMethod("getFont", "(bool*, QWidget*)", "$#")]
			QFont GetFont(out bool ok, QWidget parent);
			[SmokeMethod("getFont", "(bool*)", "$")]
			QFont GetFont(out bool ok);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFontDialog), this);
			_interceptor = (QFontDialog) realProxy.GetTransparentProxy();
		}
		private QFontDialog ProxyQFontDialog() {
			return (QFontDialog) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFontDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFontDialogProxy), null);
			_staticInterceptor = (IQFontDialogProxy) realProxy.GetTransparentProxy();
		}
		private static IQFontDialogProxy StaticQFontDialog() {
			return (IQFontDialogProxy) _staticInterceptor;
		}
		public static new string Tr(string s, string c) {
			return StaticQFontDialog().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQFontDialog().Tr(s);
		}
		public static QFont GetFont(out bool ok, QFont def, QWidget parent, string caption) {
			return StaticQFontDialog().GetFont(out ok,def,parent,caption);
		}
		public static QFont GetFont(out bool ok, QFont def, QWidget parent) {
			return StaticQFontDialog().GetFont(out ok,def,parent);
		}
		public static QFont GetFont(out bool ok, QFont def) {
			return StaticQFontDialog().GetFont(out ok,def);
		}
		public static QFont GetFont(out bool ok, QWidget parent) {
			return StaticQFontDialog().GetFont(out ok,parent);
		}
		public static QFont GetFont(out bool ok) {
			return StaticQFontDialog().GetFont(out ok);
		}
		protected new IQFontDialogSignals Emit {
			get {
				return (IQFontDialogSignals) Q_EMIT;
			}
		}
	}

	public interface IQFontDialogSignals : IQDialogSignals {
	}
}
