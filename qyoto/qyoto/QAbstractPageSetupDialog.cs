//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QAbstractPageSetupDialog : QDialog {
 		protected QAbstractPageSetupDialog(Type dummy) : base((Type) null) {}
		interface IQAbstractPageSetupDialogProxy {
		}

		protected void CreateQAbstractPageSetupDialogProxy() {
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

		public new virtual int Exec() {
			return ProxyQAbstractPageSetupDialog().Exec();
		}
		public QPrinter Printer() {
			return ProxyQAbstractPageSetupDialog().Printer();
		}
	}
}
