//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
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
    [SmokeClass("QPaintDevice")]
    public abstract class QPaintDevice : Object, IQPaintDevice {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QPaintDevice(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QPaintDevice), this);
        }
        public enum PaintDeviceMetric {
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
        [SmokeMethod("devType() const")]
        public virtual int DevType() {
            return (int) interceptor.Invoke("devType", "devType() const", typeof(int));
        }
        public bool PaintingActive() {
            return (bool) interceptor.Invoke("paintingActive", "paintingActive() const", typeof(bool));
        }
        [SmokeMethod("paintEngine() const")]
        public abstract QPaintEngine PaintEngine();
        public int Width() {
            return (int) interceptor.Invoke("width", "width() const", typeof(int));
        }
        public int Height() {
            return (int) interceptor.Invoke("height", "height() const", typeof(int));
        }
        public int WidthMM() {
            return (int) interceptor.Invoke("widthMM", "widthMM() const", typeof(int));
        }
        public int HeightMM() {
            return (int) interceptor.Invoke("heightMM", "heightMM() const", typeof(int));
        }
        public int LogicalDpiX() {
            return (int) interceptor.Invoke("logicalDpiX", "logicalDpiX() const", typeof(int));
        }
        public int LogicalDpiY() {
            return (int) interceptor.Invoke("logicalDpiY", "logicalDpiY() const", typeof(int));
        }
        public int PhysicalDpiX() {
            return (int) interceptor.Invoke("physicalDpiX", "physicalDpiX() const", typeof(int));
        }
        public int PhysicalDpiY() {
            return (int) interceptor.Invoke("physicalDpiY", "physicalDpiY() const", typeof(int));
        }
        public int NumColors() {
            return (int) interceptor.Invoke("numColors", "numColors() const", typeof(int));
        }
        public int Depth() {
            return (int) interceptor.Invoke("depth", "depth() const", typeof(int));
        }
        public QPaintDevice() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPaintDevice", "QPaintDevice()", typeof(void));
        }
        [SmokeMethod("metric(QPaintDevice::PaintDeviceMetric) const")]
        protected virtual int Metric(QPaintDevice.PaintDeviceMetric metric) {
            return (int) interceptor.Invoke("metric$", "metric(QPaintDevice::PaintDeviceMetric) const", typeof(int), typeof(QPaintDevice.PaintDeviceMetric), metric);
        }
    }
}