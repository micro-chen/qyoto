//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QDBusAbstractAdaptor")]
	public class QDBusAbstractAdaptor : QObject, IDisposable {
 		protected QDBusAbstractAdaptor(Type dummy) : base((Type) null) {}
		[SmokeClass("QDBusAbstractAdaptor")]
		interface IQDBusAbstractAdaptorProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDBusAbstractAdaptor), this);
			_interceptor = (QDBusAbstractAdaptor) realProxy.GetTransparentProxy();
		}
		private QDBusAbstractAdaptor ProxyQDBusAbstractAdaptor() {
			return (QDBusAbstractAdaptor) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDBusAbstractAdaptor() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDBusAbstractAdaptorProxy), null);
			_staticInterceptor = (IQDBusAbstractAdaptorProxy) realProxy.GetTransparentProxy();
		}
		private static IQDBusAbstractAdaptorProxy StaticQDBusAbstractAdaptor() {
			return (IQDBusAbstractAdaptorProxy) _staticInterceptor;
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public static new string Tr(string s, string c) {
			return StaticQDBusAbstractAdaptor().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQDBusAbstractAdaptor().Tr(s);
		}
		public QDBusAbstractAdaptor(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQDBusAbstractAdaptor(parent);
		}
		[SmokeMethod("QDBusAbstractAdaptor", "(QObject*)", "#")]
		private void NewQDBusAbstractAdaptor(QObject parent) {
			ProxyQDBusAbstractAdaptor().NewQDBusAbstractAdaptor(parent);
		}
		[SmokeMethod("setAutoRelaySignals", "(bool)", "$")]
		protected void SetAutoRelaySignals(bool enable) {
			ProxyQDBusAbstractAdaptor().SetAutoRelaySignals(enable);
		}
		[SmokeMethod("autoRelaySignals", "() const", "")]
		protected bool AutoRelaySignals() {
			return ProxyQDBusAbstractAdaptor().AutoRelaySignals();
		}
		~QDBusAbstractAdaptor() {
			DisposeQDBusAbstractAdaptor();
		}
		public new void Dispose() {
			DisposeQDBusAbstractAdaptor();
		}
		[SmokeMethod("~QDBusAbstractAdaptor", "()", "")]
		private void DisposeQDBusAbstractAdaptor() {
			ProxyQDBusAbstractAdaptor().DisposeQDBusAbstractAdaptor();
		}
		protected new IQDBusAbstractAdaptorSignals Emit {
			get {
				return (IQDBusAbstractAdaptorSignals) Q_EMIT;
			}
		}
	}

	public interface IQDBusAbstractAdaptorSignals : IQObjectSignals {
	}
}
