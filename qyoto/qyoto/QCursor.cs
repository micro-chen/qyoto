//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QCursor : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QCursor(Type dummy) {}
		interface IQCursorProxy {
			QPoint Pos();
			void SetPos(int x, int y);
			void SetPos(QPoint p);
		}

		protected void CreateQCursorProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QCursor), this);
			_interceptor = (QCursor) realProxy.GetTransparentProxy();
		}
		private QCursor ProxyQCursor() {
			return (QCursor) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QCursor() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCursorProxy), null);
			_staticInterceptor = (IQCursorProxy) realProxy.GetTransparentProxy();
		}
		private static IQCursorProxy StaticQCursor() {
			return (IQCursorProxy) _staticInterceptor;
		}

		public QCursor() : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor();
		}
		private void NewQCursor() {
			ProxyQCursor().NewQCursor();
		}
		public QCursor(int shape) : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor(shape);
		}
		private void NewQCursor(int shape) {
			ProxyQCursor().NewQCursor(shape);
		}
		public QCursor(QBitmap bitmap, QBitmap mask, int hotX, int hotY) : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor(bitmap,mask,hotX,hotY);
		}
		private void NewQCursor(QBitmap bitmap, QBitmap mask, int hotX, int hotY) {
			ProxyQCursor().NewQCursor(bitmap,mask,hotX,hotY);
		}
		public QCursor(QBitmap bitmap, QBitmap mask, int hotX) : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor(bitmap,mask,hotX);
		}
		private void NewQCursor(QBitmap bitmap, QBitmap mask, int hotX) {
			ProxyQCursor().NewQCursor(bitmap,mask,hotX);
		}
		public QCursor(QBitmap bitmap, QBitmap mask) : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor(bitmap,mask);
		}
		private void NewQCursor(QBitmap bitmap, QBitmap mask) {
			ProxyQCursor().NewQCursor(bitmap,mask);
		}
		public QCursor(QPixmap pixmap, int hotX, int hotY) : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor(pixmap,hotX,hotY);
		}
		private void NewQCursor(QPixmap pixmap, int hotX, int hotY) {
			ProxyQCursor().NewQCursor(pixmap,hotX,hotY);
		}
		public QCursor(QPixmap pixmap, int hotX) : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor(pixmap,hotX);
		}
		private void NewQCursor(QPixmap pixmap, int hotX) {
			ProxyQCursor().NewQCursor(pixmap,hotX);
		}
		public QCursor(QPixmap pixmap) : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor(pixmap);
		}
		private void NewQCursor(QPixmap pixmap) {
			ProxyQCursor().NewQCursor(pixmap);
		}
		public QCursor(QCursor cursor) : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor(cursor);
		}
		private void NewQCursor(QCursor cursor) {
			ProxyQCursor().NewQCursor(cursor);
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		public int Shape() {
			return ProxyQCursor().Shape();
		}
		public void SetShape(int newShape) {
			ProxyQCursor().SetShape(newShape);
		}
		public QBitmap Bitmap() {
			return ProxyQCursor().Bitmap();
		}
		public QBitmap Mask() {
			return ProxyQCursor().Mask();
		}
		public QPixmap Pixmap() {
			return ProxyQCursor().Pixmap();
		}
		public QPoint HotSpot() {
			return ProxyQCursor().HotSpot();
		}
		public static QPoint Pos() {
			return StaticQCursor().Pos();
		}
		public static void SetPos(int x, int y) {
			StaticQCursor().SetPos(x,y);
		}
		public static void SetPos(QPoint p) {
			StaticQCursor().SetPos(p);
		}
		~QCursor() {
			ProxyQCursor().Dispose();
		}
		public void Dispose() {
			ProxyQCursor().Dispose();
		}
	}
}
