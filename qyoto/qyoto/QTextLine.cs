//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QTextLine : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QTextLine(Type dummy) {}
		interface IQTextLineProxy {
		}

		protected void CreateQTextLineProxy() {
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

		enum Edge {
			Leading = 0,
			Trailing = 1,
		}
		enum CursorPosition {
			CursorBetweenCharacters = 0,
			CursorOnCharacter = 1,
		}
		public QTextLine() : this((Type) null) {
			CreateQTextLineProxy();
			NewQTextLine();
		}
		private void NewQTextLine() {
			ProxyQTextLine().NewQTextLine();
		}
		public bool IsValid() {
			return ProxyQTextLine().IsValid();
		}
		public QRectF Rect() {
			return ProxyQTextLine().Rect();
		}
		// qreal x(); >>>> NOT CONVERTED
		// qreal y(); >>>> NOT CONVERTED
		// qreal width(); >>>> NOT CONVERTED
		// qreal ascent(); >>>> NOT CONVERTED
		// qreal descent(); >>>> NOT CONVERTED
		// qreal height(); >>>> NOT CONVERTED
		// qreal naturalTextWidth(); >>>> NOT CONVERTED
		public QRectF NaturalTextRect() {
			return ProxyQTextLine().NaturalTextRect();
		}
		// qreal cursorToX(int* arg1,QTextLine::Edge arg2); >>>> NOT CONVERTED
		// qreal cursorToX(int* arg1); >>>> NOT CONVERTED
		// qreal cursorToX(int arg1,QTextLine::Edge arg2); >>>> NOT CONVERTED
		// qreal cursorToX(int arg1); >>>> NOT CONVERTED
		// int xToCursor(qreal arg1,QTextLine::CursorPosition arg2); >>>> NOT CONVERTED
		// int xToCursor(qreal arg1); >>>> NOT CONVERTED
		// void setLineWidth(qreal arg1); >>>> NOT CONVERTED
		public void SetNumColumns(int columns) {
			ProxyQTextLine().SetNumColumns(columns);
		}
		public void SetPosition(QPointF pos) {
			ProxyQTextLine().SetPosition(pos);
		}
		public int TextStart() {
			return ProxyQTextLine().TextStart();
		}
		public int TextLength() {
			return ProxyQTextLine().TextLength();
		}
		public int LineNumber() {
			return ProxyQTextLine().LineNumber();
		}
//		public void Draw(QPainter p, QPointF point, FormatRange selection) {
//			ProxyQTextLine().Draw(p,point,selection);
//		}
		public void Draw(QPainter p, QPointF point) {
			ProxyQTextLine().Draw(p,point);
		}
		~QTextLine() {
			ProxyQTextLine().Dispose();
		}
		public void Dispose() {
			ProxyQTextLine().Dispose();
		}
	}
}
