//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QValidator : QObject, IDisposable {
 		protected QValidator(Type dummy) : base((Type) null) {}
		interface IQValidatorProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected void CreateQValidatorProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QValidator), this);
			_interceptor = (QValidator) realProxy.GetTransparentProxy();
		}
		private QValidator ProxyQValidator() {
			return (QValidator) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QValidator() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQValidatorProxy), null);
			_staticInterceptor = (IQValidatorProxy) realProxy.GetTransparentProxy();
		}
		private static IQValidatorProxy StaticQValidator() {
			return (IQValidatorProxy) _staticInterceptor;
		}

		enum State {
			Invalid = 0,
			Intermediate = 1,
			Acceptable = 2,
		}
		public new virtual QMetaObject MetaObject() {
			return ProxyQValidator().MetaObject();
		}
		// void* qt_metacast(const char* arg1); >>>> NOT CONVERTED
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QValidator(QObject parent) : this((Type) null) {
			CreateQValidatorProxy();
			NewQValidator(parent);
		}
		private void NewQValidator(QObject parent) {
			ProxyQValidator().NewQValidator(parent);
		}
		public virtual int Validate(StringBuilder arg1, out int arg2) {
			return ProxyQValidator().Validate(arg1,out arg2);
		}
		public virtual void Fixup(StringBuilder arg1) {
			ProxyQValidator().Fixup(arg1);
		}
		public static new string Tr(string s, string c) {
			return StaticQValidator().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQValidator().Tr(s);
		}
		~QValidator() {
			ProxyQValidator().Dispose();
		}
		public new void Dispose() {
			ProxyQValidator().Dispose();
		}
	}
}
