//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QByteRef")]
	public class QByteRef : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QByteRef(Type dummy) {}
		interface IQByteRefProxy {
			[SmokeMethod("operator==", "(char) const", "$")]
			bool op_equals(QByteRef lhs, char c);
			[SmokeMethod("operator>", "(char) const", "$")]
			bool op_gt(QByteRef lhs, char c);
			[SmokeMethod("operator>=", "(char) const", "$")]
			bool op_gte(QByteRef lhs, char c);
			[SmokeMethod("operator<", "(char) const", "$")]
			bool op_lt(QByteRef lhs, char c);
			[SmokeMethod("operator<=", "(char) const", "$")]
			bool op_lte(QByteRef lhs, char c);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QByteRef), this);
			_interceptor = (QByteRef) realProxy.GetTransparentProxy();
		}
		private QByteRef ProxyQByteRef() {
			return (QByteRef) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QByteRef() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQByteRefProxy), null);
			_staticInterceptor = (IQByteRefProxy) realProxy.GetTransparentProxy();
		}
		private static IQByteRefProxy StaticQByteRef() {
			return (IQByteRefProxy) _staticInterceptor;
		}

		//  operator const char(); >>>> NOT CONVERTED
		public static bool operator==(QByteRef lhs, char c) {
			return StaticQByteRef().op_equals(lhs,c);
		}
		public static bool operator!=(QByteRef lhs, char c) {
			return !StaticQByteRef().op_equals(lhs,c);
		}
		public static bool operator>(QByteRef lhs, char c) {
			return StaticQByteRef().op_gt(lhs,c);
		}
		public static bool operator>=(QByteRef lhs, char c) {
			return StaticQByteRef().op_gte(lhs,c);
		}
		public static bool operator<(QByteRef lhs, char c) {
			return StaticQByteRef().op_lt(lhs,c);
		}
		public static bool operator<=(QByteRef lhs, char c) {
			return StaticQByteRef().op_lte(lhs,c);
		}
		~QByteRef() {
			DisposeQByteRef();
		}
		public void Dispose() {
			DisposeQByteRef();
		}
		[SmokeMethod("~QByteRef", "()", "")]
		private void DisposeQByteRef() {
			ProxyQByteRef().DisposeQByteRef();
		}
	}
}
