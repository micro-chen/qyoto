//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QPaintEngine : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QPaintEngine(Type dummy) {}
		interface IQPaintEngineProxy {
		}

		protected void CreateQPaintEngineProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPaintEngine), this);
			_interceptor = (QPaintEngine) realProxy.GetTransparentProxy();
		}
		private QPaintEngine ProxyQPaintEngine() {
			return (QPaintEngine) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPaintEngine() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPaintEngineProxy), null);
			_staticInterceptor = (IQPaintEngineProxy) realProxy.GetTransparentProxy();
		}
		private static IQPaintEngineProxy StaticQPaintEngine() {
			return (IQPaintEngineProxy) _staticInterceptor;
		}

		enum PaintEngineFeature : uint {
			PrimitiveTransform = 0x00000001,
			PatternTransform = 0x00000002,
			PixmapTransform = 0x00000004,
			PatternBrush = 0x00000008,
			LinearGradientFill = 0x00000010,
			RadialGradientFill = 0x00000020,
			ConicalGradientFill = 0x00000040,
			AlphaBlend = 0x00000080,
			PorterDuff = 0x00000100,
			PainterPaths = 0x00000200,
			Antialiasing = 0x00000400,
			BrushStroke = 0x00000800,
			PaintOutsidePaintEvent = 0x20000000,
			AllFeatures = 0xffffffff,
		}
		enum DirtyFlag {
			DirtyPen = 0x0001,
			DirtyBrush = 0x0002,
			DirtyBrushOrigin = 0x0004,
			DirtyFont = 0x0008,
			DirtyBackground = 0x0010,
			DirtyBackgroundMode = 0x0020,
			DirtyTransform = 0x0040,
			DirtyClipRegion = 0x0080,
			DirtyClipPath = 0x0100,
			DirtyHints = 0x0200,
			DirtyCompositionMode = 0x0400,
			AllDirty = 0xffff,
		}
		enum PolygonDrawMode {
			OddEvenMode = 0,
			WindingMode = 1,
			ConvexMode = 2,
			PolylineMode = 3,
		}
		enum E_Type {
			X11 = 0,
			Windows = 1,
			QuickDraw = 2,
			CoreGraphics = 3,
			MacPrinter = 4,
			QWindowSystem = 5,
			PostScript = 6,
			OpenGL = 7,
			Picture = 8,
			SVG = 9,
			Raster = 10,
			User = 50,
			MaxUser = 100,
		}
		public bool IsActive() {
			return ProxyQPaintEngine().IsActive();
		}
		public void SetActive(bool newState) {
			ProxyQPaintEngine().SetActive(newState);
		}
		public virtual bool Begin(IQPaintDevice pdev) {
			return ProxyQPaintEngine().Begin(pdev);
		}
		public virtual bool End() {
			return ProxyQPaintEngine().End();
		}
		public virtual void UpdateState(QPaintEngineState state) {
			ProxyQPaintEngine().UpdateState(state);
		}
		public virtual void DrawRects(QRect rects, int rectCount) {
			ProxyQPaintEngine().DrawRects(rects,rectCount);
		}
		public virtual void DrawRects(QRectF rects, int rectCount) {
			ProxyQPaintEngine().DrawRects(rects,rectCount);
		}
		public virtual void DrawLines(QLine lines, int lineCount) {
			ProxyQPaintEngine().DrawLines(lines,lineCount);
		}
		public virtual void DrawLines(QLineF lines, int lineCount) {
			ProxyQPaintEngine().DrawLines(lines,lineCount);
		}
		public virtual void DrawEllipse(QRectF r) {
			ProxyQPaintEngine().DrawEllipse(r);
		}
		public virtual void DrawEllipse(QRect r) {
			ProxyQPaintEngine().DrawEllipse(r);
		}
		public virtual void DrawPath(QPainterPath path) {
			ProxyQPaintEngine().DrawPath(path);
		}
		public virtual void DrawPoints(QPointF points, int pointCount) {
			ProxyQPaintEngine().DrawPoints(points,pointCount);
		}
		public virtual void DrawPoints(QPoint points, int pointCount) {
			ProxyQPaintEngine().DrawPoints(points,pointCount);
		}
		public virtual void DrawPolygon(QPointF points, int pointCount, int mode) {
			ProxyQPaintEngine().DrawPolygon(points,pointCount,mode);
		}
		public virtual void DrawPolygon(QPoint points, int pointCount, int mode) {
			ProxyQPaintEngine().DrawPolygon(points,pointCount,mode);
		}
		public virtual void DrawPixmap(QRectF r, QPixmap pm, QRectF sr) {
			ProxyQPaintEngine().DrawPixmap(r,pm,sr);
		}
		public virtual void DrawTiledPixmap(QRectF r, QPixmap pixmap, QPointF s) {
			ProxyQPaintEngine().DrawTiledPixmap(r,pixmap,s);
		}
		public virtual void DrawImage(QRectF r, QImage pm, QRectF sr, int flags) {
			ProxyQPaintEngine().DrawImage(r,pm,sr,flags);
		}
		public virtual void DrawImage(QRectF r, QImage pm, QRectF sr) {
			ProxyQPaintEngine().DrawImage(r,pm,sr);
		}
		public void SetPaintDevice(IQPaintDevice device) {
			ProxyQPaintEngine().SetPaintDevice(device);
		}
		public IQPaintDevice PaintDevice() {
			return ProxyQPaintEngine().PaintDevice();
		}
		public void SetSystemClip(QRegion baseClip) {
			ProxyQPaintEngine().SetSystemClip(baseClip);
		}
		public QRegion SystemClip() {
			return ProxyQPaintEngine().SystemClip();
		}
		public virtual QPoint CoordinateOffset() {
			return ProxyQPaintEngine().CoordinateOffset();
		}
		public void Fix_neg_rect(out int x, out int y, out int w, out int h) {
			ProxyQPaintEngine().Fix_neg_rect(out x,out y,out w,out h);
		}
		public bool TestDirty(int df) {
			return ProxyQPaintEngine().TestDirty(df);
		}
		public void SetDirty(int df) {
			ProxyQPaintEngine().SetDirty(df);
		}
		public void ClearDirty(int df) {
			ProxyQPaintEngine().ClearDirty(df);
		}
		public bool HasFeature(int feature) {
			return ProxyQPaintEngine().HasFeature(feature);
		}
		public QPainter Painter() {
			return ProxyQPaintEngine().Painter();
		}
		public void SyncState() {
			ProxyQPaintEngine().SyncState();
		}
	}
}
