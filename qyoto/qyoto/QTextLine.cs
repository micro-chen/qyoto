//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QTextLine")]
	public class QTextLine : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QTextLine(Type dummy) {}
		interface IQTextLineProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextLine), this);
			_interceptor = (QTextLine) realProxy.GetTransparentProxy();
		}
		private QTextLine ProxyQTextLine() {
			return (QTextLine) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextLine() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextLineProxy), null);
			_staticInterceptor = (IQTextLineProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextLineProxy StaticQTextLine() {
			return (IQTextLineProxy) _staticInterceptor;
		}

		public enum Edge {
			Leading = 0,
			Trailing = 1,
		}
		public enum CursorPosition {
			CursorBetweenCharacters = 0,
			CursorOnCharacter = 1,
		}
		public QTextLine() : this((Type) null) {
			CreateProxy();
			NewQTextLine();
		}
		[SmokeMethod("QTextLine()")]
		private void NewQTextLine() {
			ProxyQTextLine().NewQTextLine();
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQTextLine().IsValid();
		}
		[SmokeMethod("rect() const")]
		public QRectF Rect() {
			return ProxyQTextLine().Rect();
		}
		[SmokeMethod("x() const")]
		public double X() {
			return ProxyQTextLine().X();
		}
		[SmokeMethod("y() const")]
		public double Y() {
			return ProxyQTextLine().Y();
		}
		[SmokeMethod("width() const")]
		public double Width() {
			return ProxyQTextLine().Width();
		}
		[SmokeMethod("ascent() const")]
		public double Ascent() {
			return ProxyQTextLine().Ascent();
		}
		[SmokeMethod("descent() const")]
		public double Descent() {
			return ProxyQTextLine().Descent();
		}
		[SmokeMethod("height() const")]
		public double Height() {
			return ProxyQTextLine().Height();
		}
		[SmokeMethod("naturalTextWidth() const")]
		public double NaturalTextWidth() {
			return ProxyQTextLine().NaturalTextWidth();
		}
		[SmokeMethod("naturalTextRect() const")]
		public QRectF NaturalTextRect() {
			return ProxyQTextLine().NaturalTextRect();
		}
		[SmokeMethod("cursorToX(int*, QTextLine::Edge) const")]
		public double CursorToX(out int cursorPos, QTextLine.Edge edge) {
			return ProxyQTextLine().CursorToX(out cursorPos,edge);
		}
		[SmokeMethod("cursorToX(int*) const")]
		public double CursorToX(out int cursorPos) {
			return ProxyQTextLine().CursorToX(out cursorPos);
		}
		[SmokeMethod("cursorToX(int, QTextLine::Edge) const")]
		public double CursorToX(int cursorPos, QTextLine.Edge edge) {
			return ProxyQTextLine().CursorToX(cursorPos,edge);
		}
		[SmokeMethod("cursorToX(int) const")]
		public double CursorToX(int cursorPos) {
			return ProxyQTextLine().CursorToX(cursorPos);
		}
		[SmokeMethod("xToCursor(qreal, QTextLine::CursorPosition) const")]
		public int XToCursor(double x, QTextLine.CursorPosition arg2) {
			return ProxyQTextLine().XToCursor(x,arg2);
		}
		[SmokeMethod("xToCursor(qreal) const")]
		public int XToCursor(double x) {
			return ProxyQTextLine().XToCursor(x);
		}
		[SmokeMethod("setLineWidth(qreal)")]
		public void SetLineWidth(double width) {
			ProxyQTextLine().SetLineWidth(width);
		}
		[SmokeMethod("setNumColumns(int)")]
		public void SetNumColumns(int columns) {
			ProxyQTextLine().SetNumColumns(columns);
		}
		[SmokeMethod("setPosition(const QPointF&)")]
		public void SetPosition(QPointF pos) {
			ProxyQTextLine().SetPosition(pos);
		}
		[SmokeMethod("textStart() const")]
		public int TextStart() {
			return ProxyQTextLine().TextStart();
		}
		[SmokeMethod("textLength() const")]
		public int TextLength() {
			return ProxyQTextLine().TextLength();
		}
		[SmokeMethod("lineNumber() const")]
		public int LineNumber() {
			return ProxyQTextLine().LineNumber();
		}
		// void draw(QPainter* arg1,const QPointF& arg2,const QTextLayout::FormatRange* arg3); >>>> NOT CONVERTED
		[SmokeMethod("draw(QPainter*, const QPointF&) const")]
		public void Draw(QPainter p, QPointF point) {
			ProxyQTextLine().Draw(p,point);
		}
		~QTextLine() {
			DisposeQTextLine();
		}
		public void Dispose() {
			DisposeQTextLine();
		}
		private void DisposeQTextLine() {
			ProxyQTextLine().DisposeQTextLine();
		}
	}
}
