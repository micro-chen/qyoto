//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionSpinBox")]
	public class QStyleOptionSpinBox : QStyleOptionComplex, IDisposable {
 		protected QStyleOptionSpinBox(Type dummy) : base((Type) null) {}
		[SmokeClass("QStyleOptionSpinBox")]
		interface IQStyleOptionSpinBoxProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionSpinBox), this);
			_interceptor = (QStyleOptionSpinBox) realProxy.GetTransparentProxy();
		}
		private QStyleOptionSpinBox ProxyQStyleOptionSpinBox() {
			return (QStyleOptionSpinBox) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionSpinBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionSpinBoxProxy), null);
			_staticInterceptor = (IQStyleOptionSpinBoxProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionSpinBoxProxy StaticQStyleOptionSpinBox() {
			return (IQStyleOptionSpinBoxProxy) _staticInterceptor;
		}
		public enum StyleOptionType {
			Type = QStyleOption.OptionType.SO_SpinBox,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public QStyleOptionSpinBox() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionSpinBox();
		}
		[SmokeMethod("QStyleOptionSpinBox", "()", "")]
		private void NewQStyleOptionSpinBox() {
			ProxyQStyleOptionSpinBox().NewQStyleOptionSpinBox();
		}
		public QStyleOptionSpinBox(QStyleOptionSpinBox other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionSpinBox(other);
		}
		[SmokeMethod("QStyleOptionSpinBox", "(const QStyleOptionSpinBox&)", "#")]
		private void NewQStyleOptionSpinBox(QStyleOptionSpinBox other) {
			ProxyQStyleOptionSpinBox().NewQStyleOptionSpinBox(other);
		}
		public QStyleOptionSpinBox(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionSpinBox(version);
		}
		[SmokeMethod("QStyleOptionSpinBox", "(int)", "$")]
		private void NewQStyleOptionSpinBox(int version) {
			ProxyQStyleOptionSpinBox().NewQStyleOptionSpinBox(version);
		}
		~QStyleOptionSpinBox() {
			DisposeQStyleOptionSpinBox();
		}
		public void Dispose() {
			DisposeQStyleOptionSpinBox();
		}
		[SmokeMethod("~QStyleOptionSpinBox", "()", "")]
		private void DisposeQStyleOptionSpinBox() {
			ProxyQStyleOptionSpinBox().DisposeQStyleOptionSpinBox();
		}
	}
}
