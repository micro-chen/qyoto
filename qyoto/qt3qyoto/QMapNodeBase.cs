//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QMapNodeBase : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QMapNodeBase(Type dummy) {}
		interface IQMapNodeBaseProxy {
		}

		protected void CreateQMapNodeBaseProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMapNodeBase), this);
			_interceptor = (QMapNodeBase) realProxy.GetTransparentProxy();
		}
		private QMapNodeBase ProxyQMapNodeBase() {
			return (QMapNodeBase) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMapNodeBase() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMapNodeBaseProxy), null);
			_staticInterceptor = (IQMapNodeBaseProxy) realProxy.GetTransparentProxy();
		}
		private static IQMapNodeBaseProxy StaticQMapNodeBase() {
			return (IQMapNodeBaseProxy) _staticInterceptor;
		}

		enum Color {
			Red = 0,
			Black = 1,
		}
		// QMapNodeBase* minimum(); >>>> NOT CONVERTED
		// QMapNodeBase* maximum(); >>>> NOT CONVERTED
		// QMapNodeBase* QMapNodeBase(); >>>> NOT CONVERTED
		~QMapNodeBase() {
			ProxyQMapNodeBase().Dispose();
		}
		public void Dispose() {
			ProxyQMapNodeBase().Dispose();
		}
	}
}
