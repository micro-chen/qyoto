//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QDataSource")]
	public class QDataSource : QAsyncIO {
 		protected QDataSource(Type dummy) : base((Type) null) {}
		interface IQDataSourceProxy {
		}

		protected void CreateQDataSourceProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDataSource), this);
			_interceptor = (QDataSource) realProxy.GetTransparentProxy();
		}
		private QDataSource ProxyQDataSource() {
			return (QDataSource) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDataSource() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDataSourceProxy), null);
			_staticInterceptor = (IQDataSourceProxy) realProxy.GetTransparentProxy();
		}
		private static IQDataSourceProxy StaticQDataSource() {
			return (IQDataSourceProxy) _staticInterceptor;
		}

		[SmokeMethod("readyToSend()")]
		public virtual int ReadyToSend() {
			return ProxyQDataSource().ReadyToSend();
		}
		[SmokeMethod("sendTo(QDataSink*, int)")]
		public virtual void SendTo(QDataSink arg1, int count) {
			ProxyQDataSource().SendTo(arg1,count);
		}
		[SmokeMethod("maybeReady()")]
		public void MaybeReady() {
			ProxyQDataSource().MaybeReady();
		}
		[SmokeMethod("rewindable() const")]
		public virtual bool Rewindable() {
			return ProxyQDataSource().Rewindable();
		}
		[SmokeMethod("enableRewind(bool)")]
		public virtual void EnableRewind(bool arg1) {
			ProxyQDataSource().EnableRewind(arg1);
		}
		[SmokeMethod("rewind()")]
		public virtual void Rewind() {
			ProxyQDataSource().Rewind();
		}
	}
}
