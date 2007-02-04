//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTextInlineObject")]
	public class QTextInlineObject : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QTextInlineObject(Type dummy) {}
		[SmokeClass("QTextInlineObject")]
		interface IQTextInlineObjectProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextInlineObject), this);
			_interceptor = (QTextInlineObject) realProxy.GetTransparentProxy();
		}
		private QTextInlineObject ProxyQTextInlineObject() {
			return (QTextInlineObject) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextInlineObject() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextInlineObjectProxy), null);
			_staticInterceptor = (IQTextInlineObjectProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextInlineObjectProxy StaticQTextInlineObject() {
			return (IQTextInlineObjectProxy) _staticInterceptor;
		}
		// QTextInlineObject* QTextInlineObject(int arg1,QTextEngine* arg2); >>>> NOT CONVERTED
		public QTextInlineObject() : this((Type) null) {
			CreateProxy();
			NewQTextInlineObject();
		}
		[SmokeMethod("QTextInlineObject", "()", "")]
		private void NewQTextInlineObject() {
			ProxyQTextInlineObject().NewQTextInlineObject();
		}
		[SmokeMethod("isValid", "() const", "")]
		public bool IsValid() {
			return ProxyQTextInlineObject().IsValid();
		}
		[SmokeMethod("rect", "() const", "")]
		public QRectF Rect() {
			return ProxyQTextInlineObject().Rect();
		}
		[SmokeMethod("width", "() const", "")]
		public double Width() {
			return ProxyQTextInlineObject().Width();
		}
		[SmokeMethod("ascent", "() const", "")]
		public double Ascent() {
			return ProxyQTextInlineObject().Ascent();
		}
		[SmokeMethod("descent", "() const", "")]
		public double Descent() {
			return ProxyQTextInlineObject().Descent();
		}
		[SmokeMethod("height", "() const", "")]
		public double Height() {
			return ProxyQTextInlineObject().Height();
		}
		[SmokeMethod("textDirection", "() const", "")]
		public Qt.LayoutDirection TextDirection() {
			return ProxyQTextInlineObject().TextDirection();
		}
		[SmokeMethod("setWidth", "(qreal)", "$")]
		public void SetWidth(double w) {
			ProxyQTextInlineObject().SetWidth(w);
		}
		[SmokeMethod("setAscent", "(qreal)", "$")]
		public void SetAscent(double a) {
			ProxyQTextInlineObject().SetAscent(a);
		}
		[SmokeMethod("setDescent", "(qreal)", "$")]
		public void SetDescent(double d) {
			ProxyQTextInlineObject().SetDescent(d);
		}
		[SmokeMethod("textPosition", "() const", "")]
		public int TextPosition() {
			return ProxyQTextInlineObject().TextPosition();
		}
		[SmokeMethod("formatIndex", "() const", "")]
		public int FormatIndex() {
			return ProxyQTextInlineObject().FormatIndex();
		}
		// QTextFormat format(); >>>> NOT CONVERTED
		~QTextInlineObject() {
			DisposeQTextInlineObject();
		}
		public void Dispose() {
			DisposeQTextInlineObject();
		}
		[SmokeMethod("~QTextInlineObject", "()", "")]
		private void DisposeQTextInlineObject() {
			ProxyQTextInlineObject().DisposeQTextInlineObject();
		}
	}
}
