//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QDateEdit : QDateTimeEdit, IDisposable {
 		protected QDateEdit(Type dummy) : base((Type) null) {}
		interface IQDateEditProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected void CreateQDateEditProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDateEdit), this);
			_interceptor = (QDateEdit) realProxy.GetTransparentProxy();
		}
		private QDateEdit ProxyQDateEdit() {
			return (QDateEdit) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDateEdit() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDateEditProxy), null);
			_staticInterceptor = (IQDateEditProxy) realProxy.GetTransparentProxy();
		}
		private static IQDateEditProxy StaticQDateEdit() {
			return (IQDateEditProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQDateEdit().MetaObject();
		}
		// void* qt_metacast(const char* arg1); >>>> NOT CONVERTED
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QDateEdit(QWidget parent) : this((Type) null) {
			CreateQDateEditProxy();
			NewQDateEdit(parent);
		}
		private void NewQDateEdit(QWidget parent) {
			ProxyQDateEdit().NewQDateEdit(parent);
		}
		public QDateEdit() : this((Type) null) {
			CreateQDateEditProxy();
			NewQDateEdit();
		}
		private void NewQDateEdit() {
			ProxyQDateEdit().NewQDateEdit();
		}
		public QDateEdit(DateTime t, QWidget parent) : this((Type) null) {
			CreateQDateEditProxy();
			NewQDateEdit(t,parent);
		}
		private void NewQDateEdit(DateTime t, QWidget parent) {
			ProxyQDateEdit().NewQDateEdit(t,parent);
		}
		public QDateEdit(DateTime t) : this((Type) null) {
			CreateQDateEditProxy();
			NewQDateEdit(t);
		}
		private void NewQDateEdit(DateTime t) {
			ProxyQDateEdit().NewQDateEdit(t);
		}
		public static new string Tr(string s, string c) {
			return StaticQDateEdit().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQDateEdit().Tr(s);
		}
		~QDateEdit() {
			ProxyQDateEdit().Dispose();
		}
		public new void Dispose() {
			ProxyQDateEdit().Dispose();
		}
	}
}
