//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QDataSink")]
	public class QDataSink : QAsyncIO {
 		protected QDataSink(Type dummy) : base((Type) null) {}
		interface IQDataSinkProxy {
		}

		protected void CreateQDataSinkProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDataSink), this);
			_interceptor = (QDataSink) realProxy.GetTransparentProxy();
		}
		private QDataSink ProxyQDataSink() {
			return (QDataSink) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDataSink() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDataSinkProxy), null);
			_staticInterceptor = (IQDataSinkProxy) realProxy.GetTransparentProxy();
		}
		private static IQDataSinkProxy StaticQDataSink() {
			return (IQDataSinkProxy) _staticInterceptor;
		}

		[SmokeMethod("readyToReceive()")]
		public virtual int ReadyToReceive() {
			return ProxyQDataSink().ReadyToReceive();
		}
		[SmokeMethod("receive(const uchar*, int)")]
		public virtual void Receive(char[] arg1, int count) {
			ProxyQDataSink().Receive(arg1,count);
		}
		[SmokeMethod("eof()")]
		public virtual void Eof() {
			ProxyQDataSink().Eof();
		}
		[SmokeMethod("maybeReady()")]
		public void MaybeReady() {
			ProxyQDataSink().MaybeReady();
		}
	}
}
