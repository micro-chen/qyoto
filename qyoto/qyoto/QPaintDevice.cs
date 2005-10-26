//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public interface IQPaintDevice {
			int DevType();
			bool PaintingActive();
			QPaintEngine PaintEngine();
			int Width();
			int Height();
			int WidthMM();
			int HeightMM();
			int LogicalDpiX();
			int LogicalDpiY();
			int PhysicalDpiX();
			int PhysicalDpiY();
			int NumColors();
			int Depth();
	}

	public class QPaintDevice : MarshalByRefObject, IQPaintDevice {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QPaintDevice(Type dummy) {}
		interface IQPaintDeviceProxy {
		}

		protected void CreateQPaintDeviceProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPaintDevice), this);
			_interceptor = (QPaintDevice) realProxy.GetTransparentProxy();
		}
		private QPaintDevice ProxyQPaintDevice() {
			return (QPaintDevice) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPaintDevice() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPaintDeviceProxy), null);
			_staticInterceptor = (IQPaintDeviceProxy) realProxy.GetTransparentProxy();
		}
		private static IQPaintDeviceProxy StaticQPaintDevice() {
			return (IQPaintDeviceProxy) _staticInterceptor;
		}

		enum PaintDeviceMetric {
			PdmWidth = 1,
			PdmHeight = 2,
			PdmWidthMM = 3,
			PdmHeightMM = 4,
			PdmNumColors = 5,
			PdmDepth = 6,
			PdmDpiX = 7,
			PdmDpiY = 8,
			PdmPhysicalDpiX = 9,
			PdmPhysicalDpiY = 10,
		}
		public virtual int DevType() {
			return ProxyQPaintDevice().DevType();
		}
		public bool PaintingActive() {
			return ProxyQPaintDevice().PaintingActive();
		}
		public virtual QPaintEngine PaintEngine() {
			return ProxyQPaintDevice().PaintEngine();
		}
		public int Width() {
			return ProxyQPaintDevice().Width();
		}
		public int Height() {
			return ProxyQPaintDevice().Height();
		}
		public int WidthMM() {
			return ProxyQPaintDevice().WidthMM();
		}
		public int HeightMM() {
			return ProxyQPaintDevice().HeightMM();
		}
		public int LogicalDpiX() {
			return ProxyQPaintDevice().LogicalDpiX();
		}
		public int LogicalDpiY() {
			return ProxyQPaintDevice().LogicalDpiY();
		}
		public int PhysicalDpiX() {
			return ProxyQPaintDevice().PhysicalDpiX();
		}
		public int PhysicalDpiY() {
			return ProxyQPaintDevice().PhysicalDpiY();
		}
		public int NumColors() {
			return ProxyQPaintDevice().NumColors();
		}
		public int Depth() {
			return ProxyQPaintDevice().Depth();
		}

	}
}
