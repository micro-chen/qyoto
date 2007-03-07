//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QObjectCleanupHandler")]
	public class QObjectCleanupHandler : QObject, IDisposable {
 		protected QObjectCleanupHandler(Type dummy) : base((Type) null) {}
		[SmokeClass("QObjectCleanupHandler")]
		interface IQObjectCleanupHandlerProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QObjectCleanupHandler), this);
			_interceptor = (QObjectCleanupHandler) realProxy.GetTransparentProxy();
		}
		private QObjectCleanupHandler ProxyQObjectCleanupHandler() {
			return (QObjectCleanupHandler) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QObjectCleanupHandler() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQObjectCleanupHandlerProxy), null);
			_staticInterceptor = (IQObjectCleanupHandlerProxy) realProxy.GetTransparentProxy();
		}
		private static IQObjectCleanupHandlerProxy StaticQObjectCleanupHandler() {
			return (IQObjectCleanupHandlerProxy) _staticInterceptor;
		}
		public QObjectCleanupHandler() : this((Type) null) {
			CreateProxy();
			NewQObjectCleanupHandler();
		}
		[SmokeMethod("QObjectCleanupHandler", "()", "")]
		private void NewQObjectCleanupHandler() {
			ProxyQObjectCleanupHandler().NewQObjectCleanupHandler();
		}
		[SmokeMethod("add", "(QObject*)", "#")]
		public QObject Add(QObject arg1) {
			return ProxyQObjectCleanupHandler().Add(arg1);
		}
		[SmokeMethod("remove", "(QObject*)", "#")]
		public void Remove(QObject arg1) {
			ProxyQObjectCleanupHandler().Remove(arg1);
		}
		[SmokeMethod("isEmpty", "() const", "")]
		public bool IsEmpty() {
			return ProxyQObjectCleanupHandler().IsEmpty();
		}
		[SmokeMethod("clear", "()", "")]
		public void Clear() {
			ProxyQObjectCleanupHandler().Clear();
		}
		public static new string Tr(string s, string c) {
			return StaticQObjectCleanupHandler().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQObjectCleanupHandler().Tr(s);
		}
		~QObjectCleanupHandler() {
			DisposeQObjectCleanupHandler();
		}
		public new void Dispose() {
			DisposeQObjectCleanupHandler();
		}
		[SmokeMethod("~QObjectCleanupHandler", "()", "")]
		private void DisposeQObjectCleanupHandler() {
			ProxyQObjectCleanupHandler().DisposeQObjectCleanupHandler();
		}
		protected new IQObjectCleanupHandlerSignals Emit {
			get {
				return (IQObjectCleanupHandlerSignals) Q_EMIT;
			}
		}
	}

	public interface IQObjectCleanupHandlerSignals : IQObjectSignals {
	}
}
