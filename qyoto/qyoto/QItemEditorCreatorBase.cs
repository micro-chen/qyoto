//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QItemEditorCreatorBase")]
	public class QItemEditorCreatorBase : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QItemEditorCreatorBase(Type dummy) {}
		interface IQItemEditorCreatorBaseProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QItemEditorCreatorBase), this);
			_interceptor = (QItemEditorCreatorBase) realProxy.GetTransparentProxy();
		}
		private QItemEditorCreatorBase ProxyQItemEditorCreatorBase() {
			return (QItemEditorCreatorBase) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QItemEditorCreatorBase() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQItemEditorCreatorBaseProxy), null);
			_staticInterceptor = (IQItemEditorCreatorBaseProxy) realProxy.GetTransparentProxy();
		}
		private static IQItemEditorCreatorBaseProxy StaticQItemEditorCreatorBase() {
			return (IQItemEditorCreatorBaseProxy) _staticInterceptor;
		}

		[SmokeMethod("createWidget(QWidget*) const")]
		public virtual QWidget CreateWidget(QWidget parent) {
			return ProxyQItemEditorCreatorBase().CreateWidget(parent);
		}
		[SmokeMethod("valuePropertyName() const")]
		public virtual QByteArray ValuePropertyName() {
			return ProxyQItemEditorCreatorBase().ValuePropertyName();
		}
		public QItemEditorCreatorBase() : this((Type) null) {
			CreateProxy();
			NewQItemEditorCreatorBase();
		}
		[SmokeMethod("QItemEditorCreatorBase()")]
		private void NewQItemEditorCreatorBase() {
			ProxyQItemEditorCreatorBase().NewQItemEditorCreatorBase();
		}
		~QItemEditorCreatorBase() {
			DisposeQItemEditorCreatorBase();
		}
		public void Dispose() {
			DisposeQItemEditorCreatorBase();
		}
		private void DisposeQItemEditorCreatorBase() {
			ProxyQItemEditorCreatorBase().DisposeQItemEditorCreatorBase();
		}
	}
}
