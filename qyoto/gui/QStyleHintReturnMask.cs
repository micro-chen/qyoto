//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleHintReturnMask")]
	public class QStyleHintReturnMask : QStyleHintReturn, IDisposable {
 		protected QStyleHintReturnMask(Type dummy) : base((Type) null) {}
		[SmokeClass("QStyleHintReturnMask")]
		interface IQStyleHintReturnMaskProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleHintReturnMask), this);
			_interceptor = (QStyleHintReturnMask) realProxy.GetTransparentProxy();
		}
		private QStyleHintReturnMask ProxyQStyleHintReturnMask() {
			return (QStyleHintReturnMask) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleHintReturnMask() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleHintReturnMaskProxy), null);
			_staticInterceptor = (IQStyleHintReturnMaskProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleHintReturnMaskProxy StaticQStyleHintReturnMask() {
			return (IQStyleHintReturnMaskProxy) _staticInterceptor;
		}
		public enum StyleOptionType {
			Type = QStyleHintReturn.HintReturnType.SH_Mask,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public QStyleHintReturnMask() : this((Type) null) {
			CreateProxy();
			NewQStyleHintReturnMask();
		}
		[SmokeMethod("QStyleHintReturnMask", "()", "")]
		private void NewQStyleHintReturnMask() {
			ProxyQStyleHintReturnMask().NewQStyleHintReturnMask();
		}
		~QStyleHintReturnMask() {
			DisposeQStyleHintReturnMask();
		}
		public void Dispose() {
			DisposeQStyleHintReturnMask();
		}
		[SmokeMethod("~QStyleHintReturnMask", "()", "")]
		private void DisposeQStyleHintReturnMask() {
			ProxyQStyleHintReturnMask().DisposeQStyleHintReturnMask();
		}
	}
}
