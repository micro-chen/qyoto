//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QBrush")]
	public class QBrush : Qt, IDisposable {
 		protected QBrush(Type dummy) : base((Type) null) {}
		interface IQBrushProxy {
			bool op_equals(QBrush lhs, QBrush p);
		}

		protected void CreateQBrushProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QBrush), this);
			_interceptor = (QBrush) realProxy.GetTransparentProxy();
		}
		private QBrush ProxyQBrush() {
			return (QBrush) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QBrush() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQBrushProxy), null);
			_staticInterceptor = (IQBrushProxy) realProxy.GetTransparentProxy();
		}
		private static IQBrushProxy StaticQBrush() {
			return (IQBrushProxy) _staticInterceptor;
		}

		public QBrush() : this((Type) null) {
			CreateQBrushProxy();
			NewQBrush();
		}
		[SmokeMethod("QBrush()")]
		private void NewQBrush() {
			ProxyQBrush().NewQBrush();
		}
		public QBrush(int arg1) : this((Type) null) {
			CreateQBrushProxy();
			NewQBrush(arg1);
		}
		[SmokeMethod("QBrush(Qt::BrushStyle)")]
		private void NewQBrush(int arg1) {
			ProxyQBrush().NewQBrush(arg1);
		}
		public QBrush(QColor arg1, int arg2) : this((Type) null) {
			CreateQBrushProxy();
			NewQBrush(arg1,arg2);
		}
		[SmokeMethod("QBrush(const QColor&, Qt::BrushStyle)")]
		private void NewQBrush(QColor arg1, int arg2) {
			ProxyQBrush().NewQBrush(arg1,arg2);
		}
		public QBrush(QColor arg1) : this((Type) null) {
			CreateQBrushProxy();
			NewQBrush(arg1);
		}
		[SmokeMethod("QBrush(const QColor&)")]
		private void NewQBrush(QColor arg1) {
			ProxyQBrush().NewQBrush(arg1);
		}
		public QBrush(QColor arg1, QPixmap arg2) : this((Type) null) {
			CreateQBrushProxy();
			NewQBrush(arg1,arg2);
		}
		[SmokeMethod("QBrush(const QColor&, const QPixmap&)")]
		private void NewQBrush(QColor arg1, QPixmap arg2) {
			ProxyQBrush().NewQBrush(arg1,arg2);
		}
		public QBrush(QBrush arg1) : this((Type) null) {
			CreateQBrushProxy();
			NewQBrush(arg1);
		}
		[SmokeMethod("QBrush(const QBrush&)")]
		private void NewQBrush(QBrush arg1) {
			ProxyQBrush().NewQBrush(arg1);
		}
		[SmokeMethod("style() const")]
		public int Style() {
			return ProxyQBrush().Style();
		}
		[SmokeMethod("setStyle(Qt::BrushStyle)")]
		public void SetStyle(int arg1) {
			ProxyQBrush().SetStyle(arg1);
		}
		[SmokeMethod("color() const")]
		public QColor Color() {
			return ProxyQBrush().Color();
		}
		[SmokeMethod("setColor(const QColor&)")]
		public void SetColor(QColor arg1) {
			ProxyQBrush().SetColor(arg1);
		}
		[SmokeMethod("pixmap() const")]
		public QPixmap Pixmap() {
			return ProxyQBrush().Pixmap();
		}
		[SmokeMethod("setPixmap(const QPixmap&)")]
		public void SetPixmap(QPixmap arg1) {
			ProxyQBrush().SetPixmap(arg1);
		}
		[SmokeMethod("operator==(const QBrush&) const")]
		public static bool operator==(QBrush lhs, QBrush p) {
			return StaticQBrush().op_equals(lhs,p);
		}
		public static bool operator!=(QBrush lhs, QBrush p) {
			return !StaticQBrush().op_equals(lhs,p);
		}
		public override bool Equals(object o) {
			if (!(o is QBrush)) { return false; }
			return this == (QBrush) o;
		}
		public override int GetHashCode() {
			return ProxyQBrush().GetHashCode();
		}
		~QBrush() {
			DisposeQBrush();
		}
		public void Dispose() {
			DisposeQBrush();
		}
		private void DisposeQBrush() {
			ProxyQBrush().DisposeQBrush();
		}
	}
}
