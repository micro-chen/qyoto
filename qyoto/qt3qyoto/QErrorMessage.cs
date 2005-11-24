//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QErrorMessage : QDialog, IDisposable {
 		protected QErrorMessage(Type dummy) : base((Type) null) {}
		interface IQErrorMessageProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
			QErrorMessage QtHandler();
		}

		protected void CreateQErrorMessageProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QErrorMessage), this);
			_interceptor = (QErrorMessage) realProxy.GetTransparentProxy();
		}
		private QErrorMessage ProxyQErrorMessage() {
			return (QErrorMessage) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QErrorMessage() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQErrorMessageProxy), null);
			_staticInterceptor = (IQErrorMessageProxy) realProxy.GetTransparentProxy();
		}
		private static IQErrorMessageProxy StaticQErrorMessage() {
			return (IQErrorMessageProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQErrorMessage().MetaObject();
		}
		public new virtual string ClassName() {
			return ProxyQErrorMessage().ClassName();
		}
		public QErrorMessage(QWidget parent, string name) : this((Type) null) {
			CreateQErrorMessageProxy();
			NewQErrorMessage(parent,name);
		}
		private void NewQErrorMessage(QWidget parent, string name) {
			ProxyQErrorMessage().NewQErrorMessage(parent,name);
		}
		public QErrorMessage(QWidget parent) : this((Type) null) {
			CreateQErrorMessageProxy();
			NewQErrorMessage(parent);
		}
		private void NewQErrorMessage(QWidget parent) {
			ProxyQErrorMessage().NewQErrorMessage(parent);
		}
		public void Message(string arg1) {
			ProxyQErrorMessage().Message(arg1);
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQErrorMessage().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQErrorMessage().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQErrorMessage().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQErrorMessage().TrUtf8(arg1);
		}
		public static QErrorMessage QtHandler() {
			return StaticQErrorMessage().QtHandler();
		}
		protected new void Done(int arg1) {
			ProxyQErrorMessage().Done(arg1);
		}
		~QErrorMessage() {
			ProxyQErrorMessage().Dispose();
		}
		public new void Dispose() {
			ProxyQErrorMessage().Dispose();
		}
	}
}
