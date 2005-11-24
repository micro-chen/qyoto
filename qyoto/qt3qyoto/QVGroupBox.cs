//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QVGroupBox : QGroupBox, IDisposable {
 		protected QVGroupBox(Type dummy) : base((Type) null) {}
		interface IQVGroupBoxProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQVGroupBoxProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QVGroupBox), this);
			_interceptor = (QVGroupBox) realProxy.GetTransparentProxy();
		}
		private QVGroupBox ProxyQVGroupBox() {
			return (QVGroupBox) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QVGroupBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQVGroupBoxProxy), null);
			_staticInterceptor = (IQVGroupBoxProxy) realProxy.GetTransparentProxy();
		}
		private static IQVGroupBoxProxy StaticQVGroupBox() {
			return (IQVGroupBoxProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQVGroupBox().MetaObject();
		}
		public new virtual string ClassName() {
			return ProxyQVGroupBox().ClassName();
		}
		public QVGroupBox(QWidget parent, string name) : this((Type) null) {
			CreateQVGroupBoxProxy();
			NewQVGroupBox(parent,name);
		}
		private void NewQVGroupBox(QWidget parent, string name) {
			ProxyQVGroupBox().NewQVGroupBox(parent,name);
		}
		public QVGroupBox(QWidget parent) : this((Type) null) {
			CreateQVGroupBoxProxy();
			NewQVGroupBox(parent);
		}
		private void NewQVGroupBox(QWidget parent) {
			ProxyQVGroupBox().NewQVGroupBox(parent);
		}
		public QVGroupBox() : this((Type) null) {
			CreateQVGroupBoxProxy();
			NewQVGroupBox();
		}
		private void NewQVGroupBox() {
			ProxyQVGroupBox().NewQVGroupBox();
		}
		public QVGroupBox(string title, QWidget parent, string name) : this((Type) null) {
			CreateQVGroupBoxProxy();
			NewQVGroupBox(title,parent,name);
		}
		private void NewQVGroupBox(string title, QWidget parent, string name) {
			ProxyQVGroupBox().NewQVGroupBox(title,parent,name);
		}
		public QVGroupBox(string title, QWidget parent) : this((Type) null) {
			CreateQVGroupBoxProxy();
			NewQVGroupBox(title,parent);
		}
		private void NewQVGroupBox(string title, QWidget parent) {
			ProxyQVGroupBox().NewQVGroupBox(title,parent);
		}
		public QVGroupBox(string title) : this((Type) null) {
			CreateQVGroupBoxProxy();
			NewQVGroupBox(title);
		}
		private void NewQVGroupBox(string title) {
			ProxyQVGroupBox().NewQVGroupBox(title);
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQVGroupBox().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQVGroupBox().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQVGroupBox().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQVGroupBox().TrUtf8(arg1);
		}
		~QVGroupBox() {
			ProxyQVGroupBox().Dispose();
		}
		public new void Dispose() {
			ProxyQVGroupBox().Dispose();
		}
	}
}
