//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QValidator")]
	public class QValidator : QObject, IDisposable {
 		protected QValidator(Type dummy) : base((Type) null) {}
		interface IQValidatorProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
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
			Valid = Intermediate,
			Acceptable = 2,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQValidator().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQValidator().ClassName();
		}
		public QValidator(QObject parent, string name) : this((Type) null) {
			CreateQValidatorProxy();
			CreateQValidatorSignalProxy();
			NewQValidator(parent,name);
		}
		[SmokeMethod("QValidator(QObject*, const char*)")]
		private void NewQValidator(QObject parent, string name) {
			ProxyQValidator().NewQValidator(parent,name);
		}
		public QValidator(QObject parent) : this((Type) null) {
			CreateQValidatorProxy();
			CreateQValidatorSignalProxy();
			NewQValidator(parent);
		}
		[SmokeMethod("QValidator(QObject*)")]
		private void NewQValidator(QObject parent) {
			ProxyQValidator().NewQValidator(parent);
		}
		[SmokeMethod("validate(QString&, int&) const")]
		public virtual int Validate(StringBuilder arg1, out int arg2) {
			return ProxyQValidator().Validate(arg1,out arg2);
		}
		[SmokeMethod("fixup(QString&) const")]
		public virtual void Fixup(StringBuilder arg1) {
			ProxyQValidator().Fixup(arg1);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQValidator().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQValidator().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQValidator().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQValidator().TrUtf8(arg1);
		}
		~QValidator() {
			DisposeQValidator();
		}
		public new void Dispose() {
			DisposeQValidator();
		}
		private void DisposeQValidator() {
			ProxyQValidator().DisposeQValidator();
		}
		protected void CreateQValidatorSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQValidatorSignals), this);
			Q_EMIT = (IQValidatorSignals) realProxy.GetTransparentProxy();
		}
		protected new IQValidatorSignals Emit() {
			return (IQValidatorSignals) Q_EMIT;
		}
	}

	public interface IQValidatorSignals : IQObjectSignals {
	}
}
