//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QLNode : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QLNode(Type dummy) {}
		interface IQLNodeProxy {
		}

		protected void CreateQLNodeProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QLNode), this);
			_interceptor = (QLNode) realProxy.GetTransparentProxy();
		}
		private QLNode ProxyQLNode() {
			return (QLNode) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QLNode() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQLNodeProxy), null);
			_staticInterceptor = (IQLNodeProxy) realProxy.GetTransparentProxy();
		}
		private static IQLNodeProxy StaticQLNode() {
			return (IQLNodeProxy) _staticInterceptor;
		}

		// QPtrCollection::Item getData(); >>>> NOT CONVERTED
	}
}
