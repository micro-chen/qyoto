//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	public interface IQMimeSource {
			string Format(int n);
			string Format();
			bool Provides(string arg1);
			QByteArray EncodedData(string arg1);
	}

	[SmokeClass("QMimeSource")]
	public class QMimeSource : MarshalByRefObject, IQMimeSource {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QMimeSource(Type dummy) {}
		[SmokeClass("QMimeSource")]
		interface IQMimeSourceProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMimeSource), this);
			_interceptor = (QMimeSource) realProxy.GetTransparentProxy();
		}
		private QMimeSource ProxyQMimeSource() {
			return (QMimeSource) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMimeSource() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMimeSourceProxy), null);
			_staticInterceptor = (IQMimeSourceProxy) realProxy.GetTransparentProxy();
		}
		private static IQMimeSourceProxy StaticQMimeSource() {
			return (IQMimeSourceProxy) _staticInterceptor;
		}
		[SmokeMethod("format", "(int) const", "$")]
		public virtual string Format(int n) {
			return ProxyQMimeSource().Format(n);
		}
		[SmokeMethod("format", "() const", "")]
		public virtual string Format() {
			return ProxyQMimeSource().Format();
		}
		[SmokeMethod("provides", "(const char*) const", "$")]
		public virtual bool Provides(string arg1) {
			return ProxyQMimeSource().Provides(arg1);
		}
		[SmokeMethod("encodedData", "(const char*) const", "$")]
		public virtual QByteArray EncodedData(string arg1) {
			return ProxyQMimeSource().EncodedData(arg1);
		}
		public QMimeSource() : this((Type) null) {
			CreateProxy();
			NewQMimeSource();
		}
		[SmokeMethod("QMimeSource", "()", "")]
		private void NewQMimeSource() {
			ProxyQMimeSource().NewQMimeSource();
		}
		~QMimeSource() {
			DisposeQMimeSource();
		}
		public void Dispose() {
			DisposeQMimeSource();
		}
		[SmokeMethod("~QMimeSource", "()", "")]
		private void DisposeQMimeSource() {
			ProxyQMimeSource().DisposeQMimeSource();
		}
	}
}
