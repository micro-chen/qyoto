//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QTextInlineObject : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QTextInlineObject(Type dummy) {}
		interface IQTextInlineObjectProxy {
		}

		protected void CreateQTextInlineObjectProxy() {
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
			CreateQTextInlineObjectProxy();
			NewQTextInlineObject();
		}
		private void NewQTextInlineObject() {
			ProxyQTextInlineObject().NewQTextInlineObject();
		}
		public bool IsValid() {
			return ProxyQTextInlineObject().IsValid();
		}
		public QRectF Rect() {
			return ProxyQTextInlineObject().Rect();
		}
		// qreal width(); >>>> NOT CONVERTED
		// qreal ascent(); >>>> NOT CONVERTED
		// qreal descent(); >>>> NOT CONVERTED
		// qreal height(); >>>> NOT CONVERTED
		public int TextDirection() {
			return ProxyQTextInlineObject().TextDirection();
		}
		// void setWidth(qreal arg1); >>>> NOT CONVERTED
		// void setAscent(qreal arg1); >>>> NOT CONVERTED
		// void setDescent(qreal arg1); >>>> NOT CONVERTED
		public int TextPosition() {
			return ProxyQTextInlineObject().TextPosition();
		}
		public int FormatIndex() {
			return ProxyQTextInlineObject().FormatIndex();
		}
		// QTextFormat format(); >>>> NOT CONVERTED
		~QTextInlineObject() {
			ProxyQTextInlineObject().Dispose();
		}
		public void Dispose() {
			ProxyQTextInlineObject().Dispose();
		}
	}
}
