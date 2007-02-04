//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QIconEngine")]
	public class QIconEngine : MarshalByRefObject {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QIconEngine(Type dummy) {}
		[SmokeClass("QIconEngine")]
		interface IQIconEngineProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QIconEngine), this);
			_interceptor = (QIconEngine) realProxy.GetTransparentProxy();
		}
		private QIconEngine ProxyQIconEngine() {
			return (QIconEngine) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QIconEngine() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQIconEngineProxy), null);
			_staticInterceptor = (IQIconEngineProxy) realProxy.GetTransparentProxy();
		}
		private static IQIconEngineProxy StaticQIconEngine() {
			return (IQIconEngineProxy) _staticInterceptor;
		}
		[SmokeMethod("paint", "(QPainter*, const QRect&, QIcon::Mode, QIcon::State)", "##$$")]
		public virtual void Paint(QPainter painter, QRect rect, QIcon.Mode mode, QIcon.State state) {
			ProxyQIconEngine().Paint(painter,rect,mode,state);
		}
		[SmokeMethod("actualSize", "(const QSize&, QIcon::Mode, QIcon::State)", "#$$")]
		public virtual QSize ActualSize(QSize size, QIcon.Mode mode, QIcon.State state) {
			return ProxyQIconEngine().ActualSize(size,mode,state);
		}
		[SmokeMethod("pixmap", "(const QSize&, QIcon::Mode, QIcon::State)", "#$$")]
		public virtual QPixmap Pixmap(QSize size, QIcon.Mode mode, QIcon.State state) {
			return ProxyQIconEngine().Pixmap(size,mode,state);
		}
		[SmokeMethod("addPixmap", "(const QPixmap&, QIcon::Mode, QIcon::State)", "#$$")]
		public virtual void AddPixmap(QPixmap pixmap, QIcon.Mode mode, QIcon.State state) {
			ProxyQIconEngine().AddPixmap(pixmap,mode,state);
		}
		[SmokeMethod("addFile", "(const QString&, const QSize&, QIcon::Mode, QIcon::State)", "$#$$")]
		public virtual void AddFile(string fileName, QSize size, QIcon.Mode mode, QIcon.State state) {
			ProxyQIconEngine().AddFile(fileName,size,mode,state);
		}
		public QIconEngine() : this((Type) null) {
			CreateProxy();
			NewQIconEngine();
		}
		[SmokeMethod("QIconEngine", "()", "")]
		private void NewQIconEngine() {
			ProxyQIconEngine().NewQIconEngine();
		}
		~QIconEngine() {
			DisposeQIconEngine();
		}
		public void Dispose() {
			DisposeQIconEngine();
		}
		[SmokeMethod("~QIconEngine", "()", "")]
		private void DisposeQIconEngine() {
			ProxyQIconEngine().DisposeQIconEngine();
		}
	}
}
