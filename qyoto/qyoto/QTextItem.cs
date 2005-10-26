//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QTextItem : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QTextItem(Type dummy) {}
		interface IQTextItemProxy {
		}

		protected void CreateQTextItemProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextItem), this);
			_interceptor = (QTextItem) realProxy.GetTransparentProxy();
		}
		private QTextItem ProxyQTextItem() {
			return (QTextItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextItemProxy), null);
			_staticInterceptor = (IQTextItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextItemProxy StaticQTextItem() {
			return (IQTextItemProxy) _staticInterceptor;
		}

		enum RenderFlag : uint {
			RightToLeft = 0x1,
			Overline = 0x10,
			Underline = 0x20,
			StrikeOut = 0x40,
			Dummy = 0xffffffff,
		}
		// qreal descent(); >>>> NOT CONVERTED
		// qreal ascent(); >>>> NOT CONVERTED
		// qreal width(); >>>> NOT CONVERTED
		public int RenderFlags() {
			return ProxyQTextItem().RenderFlags();
		}
		public string Text() {
			return ProxyQTextItem().Text();
		}
		public QFont Font() {
			return ProxyQTextItem().Font();
		}
		public QTextItem() : this((Type) null) {
			CreateQTextItemProxy();
			NewQTextItem();
		}
		private void NewQTextItem() {
			ProxyQTextItem().NewQTextItem();
		}
		~QTextItem() {
			ProxyQTextItem().Dispose();
		}
		public void Dispose() {
			ProxyQTextItem().Dispose();
		}
	}
}
