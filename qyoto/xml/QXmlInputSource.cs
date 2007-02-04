//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QXmlInputSource")]
	public class QXmlInputSource : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QXmlInputSource(Type dummy) {}
		[SmokeClass("QXmlInputSource")]
		interface IQXmlInputSourceProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QXmlInputSource), this);
			_interceptor = (QXmlInputSource) realProxy.GetTransparentProxy();
		}
		private QXmlInputSource ProxyQXmlInputSource() {
			return (QXmlInputSource) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QXmlInputSource() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQXmlInputSourceProxy), null);
			_staticInterceptor = (IQXmlInputSourceProxy) realProxy.GetTransparentProxy();
		}
		private static IQXmlInputSourceProxy StaticQXmlInputSource() {
			return (IQXmlInputSourceProxy) _staticInterceptor;
		}
		public QXmlInputSource() : this((Type) null) {
			CreateProxy();
			NewQXmlInputSource();
		}
		[SmokeMethod("QXmlInputSource", "()", "")]
		private void NewQXmlInputSource() {
			ProxyQXmlInputSource().NewQXmlInputSource();
		}
		public QXmlInputSource(IQIODevice dev) : this((Type) null) {
			CreateProxy();
			NewQXmlInputSource(dev);
		}
		[SmokeMethod("QXmlInputSource", "(QIODevice*)", "#")]
		private void NewQXmlInputSource(IQIODevice dev) {
			ProxyQXmlInputSource().NewQXmlInputSource(dev);
		}
		[SmokeMethod("setData", "(const QString&)", "$")]
		public virtual void SetData(string dat) {
			ProxyQXmlInputSource().SetData(dat);
		}
		[SmokeMethod("setData", "(const QByteArray&)", "#")]
		public virtual void SetData(QByteArray dat) {
			ProxyQXmlInputSource().SetData(dat);
		}
		[SmokeMethod("fetchData", "()", "")]
		public virtual void FetchData() {
			ProxyQXmlInputSource().FetchData();
		}
		[SmokeMethod("data", "() const", "")]
		public virtual string Data() {
			return ProxyQXmlInputSource().Data();
		}
		[SmokeMethod("next", "()", "")]
		public virtual char Next() {
			return ProxyQXmlInputSource().Next();
		}
		[SmokeMethod("reset", "()", "")]
		public virtual void Reset() {
			ProxyQXmlInputSource().Reset();
		}
		[SmokeMethod("fromRawData", "(const QByteArray&, bool)", "#$")]
		protected virtual string FromRawData(QByteArray data, bool beginning) {
			return ProxyQXmlInputSource().FromRawData(data,beginning);
		}
		[SmokeMethod("fromRawData", "(const QByteArray&)", "#")]
		protected virtual string FromRawData(QByteArray data) {
			return ProxyQXmlInputSource().FromRawData(data);
		}
		~QXmlInputSource() {
			DisposeQXmlInputSource();
		}
		public void Dispose() {
			DisposeQXmlInputSource();
		}
		[SmokeMethod("~QXmlInputSource", "()", "")]
		private void DisposeQXmlInputSource() {
			ProxyQXmlInputSource().DisposeQXmlInputSource();
		}
	}
}
