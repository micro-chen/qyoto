//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QStyleOptionFrame : QStyleOption, IDisposable {
 		protected QStyleOptionFrame(Type dummy) : base((Type) null) {}
		interface IQStyleOptionFrameProxy {
		}

		protected void CreateQStyleOptionFrameProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionFrame), this);
			_interceptor = (QStyleOptionFrame) realProxy.GetTransparentProxy();
		}
		private QStyleOptionFrame ProxyQStyleOptionFrame() {
			return (QStyleOptionFrame) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionFrame() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionFrameProxy), null);
			_staticInterceptor = (IQStyleOptionFrameProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionFrameProxy StaticQStyleOptionFrame() {
			return (IQStyleOptionFrameProxy) _staticInterceptor;
		}

		public const int Type = (int) OptionType.SO_Frame;

		public const int Version = 1;

		public QStyleOptionFrame() : this((Type) null) {
			CreateQStyleOptionFrameProxy();
			NewQStyleOptionFrame();
		}
		private void NewQStyleOptionFrame() {
			ProxyQStyleOptionFrame().NewQStyleOptionFrame();
		}
		public QStyleOptionFrame(QStyleOptionFrame other) : this((Type) null) {
			CreateQStyleOptionFrameProxy();
			NewQStyleOptionFrame(other);
		}
		private void NewQStyleOptionFrame(QStyleOptionFrame other) {
			ProxyQStyleOptionFrame().NewQStyleOptionFrame(other);
		}
		public QStyleOptionFrame(int version) : this((Type) null) {
			CreateQStyleOptionFrameProxy();
			NewQStyleOptionFrame(version);
		}
		private void NewQStyleOptionFrame(int version) {
			ProxyQStyleOptionFrame().NewQStyleOptionFrame(version);
		}
		~QStyleOptionFrame() {
			ProxyQStyleOptionFrame().Dispose();
		}
		public void Dispose() {
			ProxyQStyleOptionFrame().Dispose();
		}
	}
}
