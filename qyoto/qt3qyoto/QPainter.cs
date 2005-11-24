//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QPainter : Qt, IDisposable {
 		protected QPainter(Type dummy) : base((Type) null) {}
		interface IQPainterProxy {
			void Redirect(IQPaintDevice pdev, IQPaintDevice replacement);
			IQPaintDevice Redirect(IQPaintDevice pdev);
			void Initialize();
			void Cleanup();
		}

		protected void CreateQPainterProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPainter), this);
			_interceptor = (QPainter) realProxy.GetTransparentProxy();
		}
		private QPainter ProxyQPainter() {
			return (QPainter) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPainter() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPainterProxy), null);
			_staticInterceptor = (IQPainterProxy) realProxy.GetTransparentProxy();
		}
		private static IQPainterProxy StaticQPainter() {
			return (IQPainterProxy) _staticInterceptor;
		}

		public const int _IsActive = 0x01;
		public const int ExtDev = 0x02;
		public const int IsStartingUp = 0x04;
		public const int NoCache = 0x08;
		public const int VxF = 0x10;
		public const int WxF = 0x20;
		public const int ClipOn = 0x40;
		public const int SafePolygon = 0x80;
		public const int MonoDev = 0x100;
		public const int DirtyFont = 0x200;
		public const int DirtyPen = 0x400;
		public const int DirtyBrush = 0x800;
		public const int RGBColor = 0x1000;
		public const int FontMet = 0x2000;
		public const int FontInf = 0x4000;
		public const int CtorBegin = 0x8000;
		public const int UsePrivateCx = 0x10000;
		public const int VolatileDC = 0x20000;
		public const int Qt2Compat = 0x40000;

		enum CoordinateMode {
			CoordDevice = 0,
			CoordPainter = 1,
		}
		enum TextDirection {
			Auto = 0,
			RTL = 1,
			LTR = 2,
		}
		public QPainter() : this((Type) null) {
			CreateQPainterProxy();
			NewQPainter();
		}
		private void NewQPainter() {
			ProxyQPainter().NewQPainter();
		}
		public QPainter(IQPaintDevice arg1, bool unclipped) : this((Type) null) {
			CreateQPainterProxy();
			NewQPainter(arg1,unclipped);
		}
		private void NewQPainter(IQPaintDevice arg1, bool unclipped) {
			ProxyQPainter().NewQPainter(arg1,unclipped);
		}
		public QPainter(IQPaintDevice arg1) : this((Type) null) {
			CreateQPainterProxy();
			NewQPainter(arg1);
		}
		private void NewQPainter(IQPaintDevice arg1) {
			ProxyQPainter().NewQPainter(arg1);
		}
		public QPainter(IQPaintDevice arg1, QWidget arg2, bool unclipped) : this((Type) null) {
			CreateQPainterProxy();
			NewQPainter(arg1,arg2,unclipped);
		}
		private void NewQPainter(IQPaintDevice arg1, QWidget arg2, bool unclipped) {
			ProxyQPainter().NewQPainter(arg1,arg2,unclipped);
		}
		public QPainter(IQPaintDevice arg1, QWidget arg2) : this((Type) null) {
			CreateQPainterProxy();
			NewQPainter(arg1,arg2);
		}
		private void NewQPainter(IQPaintDevice arg1, QWidget arg2) {
			ProxyQPainter().NewQPainter(arg1,arg2);
		}
		public bool Begin(IQPaintDevice arg1, bool unclipped) {
			return ProxyQPainter().Begin(arg1,unclipped);
		}
		public bool Begin(IQPaintDevice arg1) {
			return ProxyQPainter().Begin(arg1);
		}
		public bool Begin(IQPaintDevice arg1, QWidget arg2, bool unclipped) {
			return ProxyQPainter().Begin(arg1,arg2,unclipped);
		}
		public bool Begin(IQPaintDevice arg1, QWidget arg2) {
			return ProxyQPainter().Begin(arg1,arg2);
		}
		public bool End() {
			return ProxyQPainter().End();
		}
		public IQPaintDevice Device() {
			return ProxyQPainter().Device();
		}
		public bool IsActive() {
			return ProxyQPainter().IsActive();
		}
		public void Flush(QRegion region, int cm) {
			ProxyQPainter().Flush(region,cm);
		}
		public void Flush(QRegion region) {
			ProxyQPainter().Flush(region);
		}
		public void Flush() {
			ProxyQPainter().Flush();
		}
		public void Save() {
			ProxyQPainter().Save();
		}
		public void Restore() {
			ProxyQPainter().Restore();
		}
		public QFontMetrics FontMetrics() {
			return ProxyQPainter().FontMetrics();
		}
		public QFontInfo FontInfo() {
			return ProxyQPainter().FontInfo();
		}
		public QFont Font() {
			return ProxyQPainter().Font();
		}
		public void SetFont(QFont arg1) {
			ProxyQPainter().SetFont(arg1);
		}
		public QPen Pen() {
			return ProxyQPainter().Pen();
		}
		public void SetPen(QPen arg1) {
			ProxyQPainter().SetPen(arg1);
		}
		public void SetPen(int arg1) {
			ProxyQPainter().SetPen(arg1);
		}
		public void SetPen(QColor arg1) {
			ProxyQPainter().SetPen(arg1);
		}
		public QBrush Brush() {
			return ProxyQPainter().Brush();
		}
		public void SetBrush(QBrush arg1) {
			ProxyQPainter().SetBrush(arg1);
		}
		public void SetBrush(int arg1) {
			ProxyQPainter().SetBrush(arg1);
		}
		public void SetBrush(QColor arg1) {
			ProxyQPainter().SetBrush(arg1);
		}
		public QPoint Pos() {
			return ProxyQPainter().Pos();
		}
		public QColor BackgroundColor() {
			return ProxyQPainter().BackgroundColor();
		}
		public void SetBackgroundColor(QColor arg1) {
			ProxyQPainter().SetBackgroundColor(arg1);
		}
		public int BackgroundMode() {
			return ProxyQPainter().BackgroundMode();
		}
		public void SetBackgroundMode(int arg1) {
			ProxyQPainter().SetBackgroundMode(arg1);
		}
		public int RasterOp() {
			return ProxyQPainter().RasterOp();
		}
		public void SetRasterOp(int arg1) {
			ProxyQPainter().SetRasterOp(arg1);
		}
		public QPoint BrushOrigin() {
			return ProxyQPainter().BrushOrigin();
		}
		public void SetBrushOrigin(int x, int y) {
			ProxyQPainter().SetBrushOrigin(x,y);
		}
		public void SetBrushOrigin(QPoint arg1) {
			ProxyQPainter().SetBrushOrigin(arg1);
		}
		public bool HasViewXForm() {
			return ProxyQPainter().HasViewXForm();
		}
		public bool HasWorldXForm() {
			return ProxyQPainter().HasWorldXForm();
		}
		public void SetViewXForm(bool arg1) {
			ProxyQPainter().SetViewXForm(arg1);
		}
		public QRect Window() {
			return ProxyQPainter().Window();
		}
		public void SetWindow(QRect arg1) {
			ProxyQPainter().SetWindow(arg1);
		}
		public void SetWindow(int x, int y, int w, int h) {
			ProxyQPainter().SetWindow(x,y,w,h);
		}
		public QRect Viewport() {
			return ProxyQPainter().Viewport();
		}
		public void SetViewport(QRect arg1) {
			ProxyQPainter().SetViewport(arg1);
		}
		public void SetViewport(int x, int y, int w, int h) {
			ProxyQPainter().SetViewport(x,y,w,h);
		}
		public void SetWorldXForm(bool arg1) {
			ProxyQPainter().SetWorldXForm(arg1);
		}
		public QWMatrix WorldMatrix() {
			return ProxyQPainter().WorldMatrix();
		}
		public void SetWorldMatrix(QWMatrix arg1, bool combine) {
			ProxyQPainter().SetWorldMatrix(arg1,combine);
		}
		public void SetWorldMatrix(QWMatrix arg1) {
			ProxyQPainter().SetWorldMatrix(arg1);
		}
		public void SaveWorldMatrix() {
			ProxyQPainter().SaveWorldMatrix();
		}
		public void RestoreWorldMatrix() {
			ProxyQPainter().RestoreWorldMatrix();
		}
		public void Scale(double sx, double sy) {
			ProxyQPainter().Scale(sx,sy);
		}
		public void Shear(double sh, double sv) {
			ProxyQPainter().Shear(sh,sv);
		}
		public void Rotate(double a) {
			ProxyQPainter().Rotate(a);
		}
		public void Translate(double dx, double dy) {
			ProxyQPainter().Translate(dx,dy);
		}
		public void ResetXForm() {
			ProxyQPainter().ResetXForm();
		}
		public double TranslationX() {
			return ProxyQPainter().TranslationX();
		}
		public double TranslationY() {
			return ProxyQPainter().TranslationY();
		}
		public Object XForm(QPoint arg1) {
			return ProxyQPainter().XForm(arg1);
		}
		public Object XForm(QRect arg1) {
			return ProxyQPainter().XForm(arg1);
		}
		public Object XForm(QPointArray arg1) {
			return ProxyQPainter().XForm(arg1);
		}
		public Object XForm(QPointArray arg1, int index, int npoints) {
			return ProxyQPainter().XForm(arg1,index,npoints);
		}
		public QPoint XFormDev(QPoint arg1) {
			return ProxyQPainter().XFormDev(arg1);
		}
		public QRect XFormDev(QRect arg1) {
			return ProxyQPainter().XFormDev(arg1);
		}
		public QPointArray XFormDev(QPointArray arg1) {
			return ProxyQPainter().XFormDev(arg1);
		}
		public QPointArray XFormDev(QPointArray arg1, int index, int npoints) {
			return ProxyQPainter().XFormDev(arg1,index,npoints);
		}
		public void SetClipping(bool arg1) {
			ProxyQPainter().SetClipping(arg1);
		}
		public bool HasClipping() {
			return ProxyQPainter().HasClipping();
		}
		public QRegion ClipRegion(int arg1) {
			return ProxyQPainter().ClipRegion(arg1);
		}
		public QRegion ClipRegion() {
			return ProxyQPainter().ClipRegion();
		}
		public void SetClipRect(QRect arg1, int arg2) {
			ProxyQPainter().SetClipRect(arg1,arg2);
		}
		public void SetClipRect(QRect arg1) {
			ProxyQPainter().SetClipRect(arg1);
		}
		public void SetClipRect(int x, int y, int w, int h, int arg5) {
			ProxyQPainter().SetClipRect(x,y,w,h,arg5);
		}
		public void SetClipRect(int x, int y, int w, int h) {
			ProxyQPainter().SetClipRect(x,y,w,h);
		}
		public void SetClipRegion(QRegion arg1, int arg2) {
			ProxyQPainter().SetClipRegion(arg1,arg2);
		}
		public void SetClipRegion(QRegion arg1) {
			ProxyQPainter().SetClipRegion(arg1);
		}
		public void DrawPoint(int x, int y) {
			ProxyQPainter().DrawPoint(x,y);
		}
		public void DrawPoint(QPoint arg1) {
			ProxyQPainter().DrawPoint(arg1);
		}
		public void DrawPoints(QPointArray a, int index, int npoints) {
			ProxyQPainter().DrawPoints(a,index,npoints);
		}
		public void DrawPoints(QPointArray a, int index) {
			ProxyQPainter().DrawPoints(a,index);
		}
		public void DrawPoints(QPointArray a) {
			ProxyQPainter().DrawPoints(a);
		}
		public void MoveTo(int x, int y) {
			ProxyQPainter().MoveTo(x,y);
		}
		public void MoveTo(QPoint arg1) {
			ProxyQPainter().MoveTo(arg1);
		}
		public void LineTo(int x, int y) {
			ProxyQPainter().LineTo(x,y);
		}
		public void LineTo(QPoint arg1) {
			ProxyQPainter().LineTo(arg1);
		}
		public void DrawLine(int x1, int y1, int x2, int y2) {
			ProxyQPainter().DrawLine(x1,y1,x2,y2);
		}
		public void DrawLine(QPoint arg1, QPoint arg2) {
			ProxyQPainter().DrawLine(arg1,arg2);
		}
		public void DrawRect(int x, int y, int w, int h) {
			ProxyQPainter().DrawRect(x,y,w,h);
		}
		public void DrawRect(QRect arg1) {
			ProxyQPainter().DrawRect(arg1);
		}
		public void DrawWinFocusRect(int x, int y, int w, int h) {
			ProxyQPainter().DrawWinFocusRect(x,y,w,h);
		}
		public void DrawWinFocusRect(int x, int y, int w, int h, QColor bgColor) {
			ProxyQPainter().DrawWinFocusRect(x,y,w,h,bgColor);
		}
		public void DrawWinFocusRect(QRect arg1) {
			ProxyQPainter().DrawWinFocusRect(arg1);
		}
		public void DrawWinFocusRect(QRect arg1, QColor bgColor) {
			ProxyQPainter().DrawWinFocusRect(arg1,bgColor);
		}
		public void DrawRoundRect(int x, int y, int w, int h, int arg5, int arg6) {
			ProxyQPainter().DrawRoundRect(x,y,w,h,arg5,arg6);
		}
		public void DrawRoundRect(int x, int y, int w, int h, int arg5) {
			ProxyQPainter().DrawRoundRect(x,y,w,h,arg5);
		}
		public void DrawRoundRect(int x, int y, int w, int h) {
			ProxyQPainter().DrawRoundRect(x,y,w,h);
		}
		public void DrawRoundRect(QRect arg1, int arg2, int arg3) {
			ProxyQPainter().DrawRoundRect(arg1,arg2,arg3);
		}
		public void DrawRoundRect(QRect arg1, int arg2) {
			ProxyQPainter().DrawRoundRect(arg1,arg2);
		}
		public void DrawRoundRect(QRect arg1) {
			ProxyQPainter().DrawRoundRect(arg1);
		}
		public void DrawEllipse(int x, int y, int w, int h) {
			ProxyQPainter().DrawEllipse(x,y,w,h);
		}
		public void DrawEllipse(QRect arg1) {
			ProxyQPainter().DrawEllipse(arg1);
		}
		public void DrawArc(int x, int y, int w, int h, int a, int alen) {
			ProxyQPainter().DrawArc(x,y,w,h,a,alen);
		}
		public void DrawArc(QRect arg1, int a, int alen) {
			ProxyQPainter().DrawArc(arg1,a,alen);
		}
		public void DrawPie(int x, int y, int w, int h, int a, int alen) {
			ProxyQPainter().DrawPie(x,y,w,h,a,alen);
		}
		public void DrawPie(QRect arg1, int a, int alen) {
			ProxyQPainter().DrawPie(arg1,a,alen);
		}
		public void DrawChord(int x, int y, int w, int h, int a, int alen) {
			ProxyQPainter().DrawChord(x,y,w,h,a,alen);
		}
		public void DrawChord(QRect arg1, int a, int alen) {
			ProxyQPainter().DrawChord(arg1,a,alen);
		}
		public void DrawLineSegments(QPointArray arg1, int index, int nlines) {
			ProxyQPainter().DrawLineSegments(arg1,index,nlines);
		}
		public void DrawLineSegments(QPointArray arg1, int index) {
			ProxyQPainter().DrawLineSegments(arg1,index);
		}
		public void DrawLineSegments(QPointArray arg1) {
			ProxyQPainter().DrawLineSegments(arg1);
		}
		public void DrawPolyline(QPointArray arg1, int index, int npoints) {
			ProxyQPainter().DrawPolyline(arg1,index,npoints);
		}
		public void DrawPolyline(QPointArray arg1, int index) {
			ProxyQPainter().DrawPolyline(arg1,index);
		}
		public void DrawPolyline(QPointArray arg1) {
			ProxyQPainter().DrawPolyline(arg1);
		}
		public void DrawPolygon(QPointArray arg1, bool winding, int index, int npoints) {
			ProxyQPainter().DrawPolygon(arg1,winding,index,npoints);
		}
		public void DrawPolygon(QPointArray arg1, bool winding, int index) {
			ProxyQPainter().DrawPolygon(arg1,winding,index);
		}
		public void DrawPolygon(QPointArray arg1, bool winding) {
			ProxyQPainter().DrawPolygon(arg1,winding);
		}
		public void DrawPolygon(QPointArray arg1) {
			ProxyQPainter().DrawPolygon(arg1);
		}
		public void DrawConvexPolygon(QPointArray arg1, int index, int npoints) {
			ProxyQPainter().DrawConvexPolygon(arg1,index,npoints);
		}
		public void DrawConvexPolygon(QPointArray arg1, int index) {
			ProxyQPainter().DrawConvexPolygon(arg1,index);
		}
		public void DrawConvexPolygon(QPointArray arg1) {
			ProxyQPainter().DrawConvexPolygon(arg1);
		}
		public void DrawCubicBezier(QPointArray arg1, int index) {
			ProxyQPainter().DrawCubicBezier(arg1,index);
		}
		public void DrawCubicBezier(QPointArray arg1) {
			ProxyQPainter().DrawCubicBezier(arg1);
		}
		public void DrawPixmap(int x, int y, QPixmap arg3, int sx, int sy, int sw, int sh) {
			ProxyQPainter().DrawPixmap(x,y,arg3,sx,sy,sw,sh);
		}
		public void DrawPixmap(int x, int y, QPixmap arg3, int sx, int sy, int sw) {
			ProxyQPainter().DrawPixmap(x,y,arg3,sx,sy,sw);
		}
		public void DrawPixmap(int x, int y, QPixmap arg3, int sx, int sy) {
			ProxyQPainter().DrawPixmap(x,y,arg3,sx,sy);
		}
		public void DrawPixmap(int x, int y, QPixmap arg3, int sx) {
			ProxyQPainter().DrawPixmap(x,y,arg3,sx);
		}
		public void DrawPixmap(int x, int y, QPixmap arg3) {
			ProxyQPainter().DrawPixmap(x,y,arg3);
		}
		public void DrawPixmap(QPoint arg1, QPixmap arg2, QRect sr) {
			ProxyQPainter().DrawPixmap(arg1,arg2,sr);
		}
		public void DrawPixmap(QPoint arg1, QPixmap arg2) {
			ProxyQPainter().DrawPixmap(arg1,arg2);
		}
		public void DrawPixmap(QRect arg1, QPixmap arg2) {
			ProxyQPainter().DrawPixmap(arg1,arg2);
		}
		public void DrawImage(int x, int y, QImage arg3, int sx, int sy, int sw, int sh, int conversionFlags) {
			ProxyQPainter().DrawImage(x,y,arg3,sx,sy,sw,sh,conversionFlags);
		}
		public void DrawImage(int x, int y, QImage arg3, int sx, int sy, int sw, int sh) {
			ProxyQPainter().DrawImage(x,y,arg3,sx,sy,sw,sh);
		}
		public void DrawImage(int x, int y, QImage arg3, int sx, int sy, int sw) {
			ProxyQPainter().DrawImage(x,y,arg3,sx,sy,sw);
		}
		public void DrawImage(int x, int y, QImage arg3, int sx, int sy) {
			ProxyQPainter().DrawImage(x,y,arg3,sx,sy);
		}
		public void DrawImage(int x, int y, QImage arg3, int sx) {
			ProxyQPainter().DrawImage(x,y,arg3,sx);
		}
		public void DrawImage(int x, int y, QImage arg3) {
			ProxyQPainter().DrawImage(x,y,arg3);
		}
		public void DrawImage(QPoint arg1, QImage arg2, QRect sr, int conversionFlags) {
			ProxyQPainter().DrawImage(arg1,arg2,sr,conversionFlags);
		}
		public void DrawImage(QPoint arg1, QImage arg2, QRect sr) {
			ProxyQPainter().DrawImage(arg1,arg2,sr);
		}
		public void DrawImage(QPoint arg1, QImage arg2, int conversion_flags) {
			ProxyQPainter().DrawImage(arg1,arg2,conversion_flags);
		}
		public void DrawImage(QPoint arg1, QImage arg2) {
			ProxyQPainter().DrawImage(arg1,arg2);
		}
		public void DrawImage(QRect arg1, QImage arg2) {
			ProxyQPainter().DrawImage(arg1,arg2);
		}
		public void DrawTiledPixmap(int x, int y, int w, int h, QPixmap arg5, int sx, int sy) {
			ProxyQPainter().DrawTiledPixmap(x,y,w,h,arg5,sx,sy);
		}
		public void DrawTiledPixmap(int x, int y, int w, int h, QPixmap arg5, int sx) {
			ProxyQPainter().DrawTiledPixmap(x,y,w,h,arg5,sx);
		}
		public void DrawTiledPixmap(int x, int y, int w, int h, QPixmap arg5) {
			ProxyQPainter().DrawTiledPixmap(x,y,w,h,arg5);
		}
		public void DrawTiledPixmap(QRect arg1, QPixmap arg2, QPoint arg3) {
			ProxyQPainter().DrawTiledPixmap(arg1,arg2,arg3);
		}
		public void DrawTiledPixmap(QRect arg1, QPixmap arg2) {
			ProxyQPainter().DrawTiledPixmap(arg1,arg2);
		}
		public void DrawPicture(QPicture arg1) {
			ProxyQPainter().DrawPicture(arg1);
		}
		public void DrawPicture(int x, int y, QPicture arg3) {
			ProxyQPainter().DrawPicture(x,y,arg3);
		}
		public void DrawPicture(QPoint arg1, QPicture arg2) {
			ProxyQPainter().DrawPicture(arg1,arg2);
		}
		public void FillRect(int x, int y, int w, int h, QBrush arg5) {
			ProxyQPainter().FillRect(x,y,w,h,arg5);
		}
		public void FillRect(QRect arg1, QBrush arg2) {
			ProxyQPainter().FillRect(arg1,arg2);
		}
		public void EraseRect(int x, int y, int w, int h) {
			ProxyQPainter().EraseRect(x,y,w,h);
		}
		public void EraseRect(QRect arg1) {
			ProxyQPainter().EraseRect(arg1);
		}
		public void DrawText(int x, int y, string arg3, int len, int dir) {
			ProxyQPainter().DrawText(x,y,arg3,len,dir);
		}
		public void DrawText(int x, int y, string arg3, int len) {
			ProxyQPainter().DrawText(x,y,arg3,len);
		}
		public void DrawText(int x, int y, string arg3) {
			ProxyQPainter().DrawText(x,y,arg3);
		}
		public void DrawText(QPoint arg1, string arg2, int len, int dir) {
			ProxyQPainter().DrawText(arg1,arg2,len,dir);
		}
		public void DrawText(QPoint arg1, string arg2, int len) {
			ProxyQPainter().DrawText(arg1,arg2,len);
		}
		public void DrawText(QPoint arg1, string arg2) {
			ProxyQPainter().DrawText(arg1,arg2);
		}
		public void DrawText(int x, int y, string arg3, int pos, int len, int dir) {
			ProxyQPainter().DrawText(x,y,arg3,pos,len,dir);
		}
		public void DrawText(QPoint p, string arg2, int pos, int len, int dir) {
			ProxyQPainter().DrawText(p,arg2,pos,len,dir);
		}
		// void drawText(int arg1,int arg2,int arg3,int arg4,int arg5,const QString& arg6,int arg7,QRect* arg8,QTextParag** arg9); >>>> NOT CONVERTED
		public void DrawText(int x, int y, int w, int h, int flags, string arg6, int len, QRect br) {
			ProxyQPainter().DrawText(x,y,w,h,flags,arg6,len,br);
		}
		public void DrawText(int x, int y, int w, int h, int flags, string arg6, int len) {
			ProxyQPainter().DrawText(x,y,w,h,flags,arg6,len);
		}
		public void DrawText(int x, int y, int w, int h, int flags, string arg6) {
			ProxyQPainter().DrawText(x,y,w,h,flags,arg6);
		}
		// void drawText(const QRect& arg1,int arg2,const QString& arg3,int arg4,QRect* arg5,QTextParag** arg6); >>>> NOT CONVERTED
		public void DrawText(QRect arg1, int flags, string arg3, int len, QRect br) {
			ProxyQPainter().DrawText(arg1,flags,arg3,len,br);
		}
		public void DrawText(QRect arg1, int flags, string arg3, int len) {
			ProxyQPainter().DrawText(arg1,flags,arg3,len);
		}
		public void DrawText(QRect arg1, int flags, string arg3) {
			ProxyQPainter().DrawText(arg1,flags,arg3);
		}
		// QRect boundingRect(int arg1,int arg2,int arg3,int arg4,int arg5,const QString& arg6,int arg7,QTextParag** arg8); >>>> NOT CONVERTED
		public QRect BoundingRect(int x, int y, int w, int h, int flags, string arg6, int len) {
			return ProxyQPainter().BoundingRect(x,y,w,h,flags,arg6,len);
		}
		public QRect BoundingRect(int x, int y, int w, int h, int flags, string arg6) {
			return ProxyQPainter().BoundingRect(x,y,w,h,flags,arg6);
		}
		// QRect boundingRect(const QRect& arg1,int arg2,const QString& arg3,int arg4,QTextParag** arg5); >>>> NOT CONVERTED
		public QRect BoundingRect(QRect arg1, int flags, string arg3, int len) {
			return ProxyQPainter().BoundingRect(arg1,flags,arg3,len);
		}
		public QRect BoundingRect(QRect arg1, int flags, string arg3) {
			return ProxyQPainter().BoundingRect(arg1,flags,arg3);
		}
		public int TabStops() {
			return ProxyQPainter().TabStops();
		}
		public void SetTabStops(int arg1) {
			ProxyQPainter().SetTabStops(arg1);
		}
		public  int TabArray() {
			return ProxyQPainter().TabArray();
		}
		public void SetTabArray(out int arg1) {
			ProxyQPainter().SetTabArray(out arg1);
		}
		public static void Redirect(IQPaintDevice pdev, IQPaintDevice replacement) {
			StaticQPainter().Redirect(pdev,replacement);
		}
		public static IQPaintDevice Redirect(IQPaintDevice pdev) {
			return StaticQPainter().Redirect(pdev);
		}
		public static void Initialize() {
			StaticQPainter().Initialize();
		}
		public static void Cleanup() {
			StaticQPainter().Cleanup();
		}
		~QPainter() {
			ProxyQPainter().Dispose();
		}
		public void Dispose() {
			ProxyQPainter().Dispose();
		}
	}
}
