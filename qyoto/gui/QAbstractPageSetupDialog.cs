//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QAbstractPageSetupDialog")]
	public class QAbstractPageSetupDialog : QDialog {
 		protected QAbstractPageSetupDialog(Type dummy) : base((Type) null) {}
		[SmokeClass("QAbstractPageSetupDialog")]
		interface IQAbstractPageSetupDialogProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAbstractPageSetupDialog), this);
			_interceptor = (QAbstractPageSetupDialog) realProxy.GetTransparentProxy();
		}
		private QAbstractPageSetupDialog ProxyQAbstractPageSetupDialog() {
			return (QAbstractPageSetupDialog) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAbstractPageSetupDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAbstractPageSetupDialogProxy), null);
			_staticInterceptor = (IQAbstractPageSetupDialogProxy) realProxy.GetTransparentProxy();
		}
		private static IQAbstractPageSetupDialogProxy StaticQAbstractPageSetupDialog() {
			return (IQAbstractPageSetupDialogProxy) _staticInterceptor;
		}
		public QAbstractPageSetupDialog(QPrinter printer, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQAbstractPageSetupDialog(printer,parent);
		}
		[SmokeMethod("QAbstractPageSetupDialog", "(QPrinter*, QWidget*)", "##")]
		private void NewQAbstractPageSetupDialog(QPrinter printer, QWidget parent) {
			ProxyQAbstractPageSetupDialog().NewQAbstractPageSetupDialog(printer,parent);
		}
		public QAbstractPageSetupDialog(QPrinter printer) : this((Type) null) {
			CreateProxy();
			NewQAbstractPageSetupDialog(printer);
		}
		[SmokeMethod("QAbstractPageSetupDialog", "(QPrinter*)", "#")]
		private void NewQAbstractPageSetupDialog(QPrinter printer) {
			ProxyQAbstractPageSetupDialog().NewQAbstractPageSetupDialog(printer);
		}
		[SmokeMethod("exec", "()", "")]
		public new virtual int Exec() {
			return ProxyQAbstractPageSetupDialog().Exec();
		}
		[SmokeMethod("printer", "()", "")]
		public QPrinter Printer() {
			return ProxyQAbstractPageSetupDialog().Printer();
		}
		public static new string Tr(string s, string c) {
			return StaticQAbstractPageSetupDialog().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQAbstractPageSetupDialog().Tr(s);
		}
		~QAbstractPageSetupDialog() {
			DisposeQAbstractPageSetupDialog();
		}
		public new void Dispose() {
			DisposeQAbstractPageSetupDialog();
		}
		[SmokeMethod("~QAbstractPageSetupDialog", "()", "")]
		private void DisposeQAbstractPageSetupDialog() {
			ProxyQAbstractPageSetupDialog().DisposeQAbstractPageSetupDialog();
		}
		protected new IQAbstractPageSetupDialogSignals Emit {
			get {
				return (IQAbstractPageSetupDialogSignals) Q_EMIT;
			}
		}
	}

	public interface IQAbstractPageSetupDialogSignals : IQDialogSignals {
	}
}
