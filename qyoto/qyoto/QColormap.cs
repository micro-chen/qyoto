//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QColormap")]
	public class QColormap : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QColormap(Type dummy) {}
		interface IQColormapProxy {
			void Initialize();
			void Cleanup();
			QColormap Instance(int screen);
			QColormap Instance();
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QColormap), this);
			_interceptor = (QColormap) realProxy.GetTransparentProxy();
		}
		private QColormap ProxyQColormap() {
			return (QColormap) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QColormap() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQColormapProxy), null);
			_staticInterceptor = (IQColormapProxy) realProxy.GetTransparentProxy();
		}
		private static IQColormapProxy StaticQColormap() {
			return (IQColormapProxy) _staticInterceptor;
		}

		public enum Mode {
			Direct = 0,
			Indexed = 1,
			Gray = 2,
		}
		public QColormap(QColormap colormap) : this((Type) null) {
			CreateProxy();
			NewQColormap(colormap);
		}
		[SmokeMethod("QColormap(const QColormap&)")]
		private void NewQColormap(QColormap colormap) {
			ProxyQColormap().NewQColormap(colormap);
		}
		[SmokeMethod("mode() const")]
		public QColormap.Mode mode() {
			return ProxyQColormap().mode();
		}
		[SmokeMethod("depth() const")]
		public int Depth() {
			return ProxyQColormap().Depth();
		}
		[SmokeMethod("size() const")]
		public int Size() {
			return ProxyQColormap().Size();
		}
		[SmokeMethod("pixel(const QColor&) const")]
		public uint Pixel(QColor color) {
			return ProxyQColormap().Pixel(color);
		}
		[SmokeMethod("colorAt(uint) const")]
		public QColor ColorAt(uint pixel) {
			return ProxyQColormap().ColorAt(pixel);
		}
		// const QVector<QColor> colormap(); >>>> NOT CONVERTED
		[SmokeMethod("initialize()")]
		public static void Initialize() {
			StaticQColormap().Initialize();
		}
		[SmokeMethod("cleanup()")]
		public static void Cleanup() {
			StaticQColormap().Cleanup();
		}
		[SmokeMethod("instance(int)")]
		public static QColormap Instance(int screen) {
			return StaticQColormap().Instance(screen);
		}
		[SmokeMethod("instance()")]
		public static QColormap Instance() {
			return StaticQColormap().Instance();
		}
		~QColormap() {
			DisposeQColormap();
		}
		public void Dispose() {
			DisposeQColormap();
		}
		private void DisposeQColormap() {
			ProxyQColormap().DisposeQColormap();
		}
	}
}
