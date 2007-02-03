//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDomNodeList")]
	public class QDomNodeList : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QDomNodeList(Type dummy) {}
		interface IQDomNodeListProxy {
			[SmokeMethod("operator==", "(const QDomNodeList&) const", "#")]
			bool op_equals(QDomNodeList lhs, QDomNodeList arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomNodeList), this);
			_interceptor = (QDomNodeList) realProxy.GetTransparentProxy();
		}
		private QDomNodeList ProxyQDomNodeList() {
			return (QDomNodeList) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomNodeList() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomNodeListProxy), null);
			_staticInterceptor = (IQDomNodeListProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomNodeListProxy StaticQDomNodeList() {
			return (IQDomNodeListProxy) _staticInterceptor;
		}

		public QDomNodeList() : this((Type) null) {
			CreateProxy();
			NewQDomNodeList();
		}
		[SmokeMethod("QDomNodeList", "()", "")]
		private void NewQDomNodeList() {
			ProxyQDomNodeList().NewQDomNodeList();
		}
		public QDomNodeList(QDomNodeList arg1) : this((Type) null) {
			CreateProxy();
			NewQDomNodeList(arg1);
		}
		[SmokeMethod("QDomNodeList", "(const QDomNodeList&)", "#")]
		private void NewQDomNodeList(QDomNodeList arg1) {
			ProxyQDomNodeList().NewQDomNodeList(arg1);
		}
		public static bool operator==(QDomNodeList lhs, QDomNodeList arg1) {
			return StaticQDomNodeList().op_equals(lhs,arg1);
		}
		public static bool operator!=(QDomNodeList lhs, QDomNodeList arg1) {
			return !StaticQDomNodeList().op_equals(lhs,arg1);
		}
		public override bool Equals(object o) {
			if (!(o is QDomNodeList)) { return false; }
			return this == (QDomNodeList) o;
		}
		public override int GetHashCode() {
			return ProxyQDomNodeList().GetHashCode();
		}
		[SmokeMethod("item", "(int) const", "$")]
		public QDomNode Item(int index) {
			return ProxyQDomNodeList().Item(index);
		}
		[SmokeMethod("at", "(int) const", "$")]
		public QDomNode At(int index) {
			return ProxyQDomNodeList().At(index);
		}
		[SmokeMethod("length", "() const", "")]
		public uint Length() {
			return ProxyQDomNodeList().Length();
		}
		[SmokeMethod("count", "() const", "")]
		public int Count() {
			return ProxyQDomNodeList().Count();
		}
		[SmokeMethod("size", "() const", "")]
		public int Size() {
			return ProxyQDomNodeList().Size();
		}
		[SmokeMethod("isEmpty", "() const", "")]
		public bool IsEmpty() {
			return ProxyQDomNodeList().IsEmpty();
		}
		~QDomNodeList() {
			DisposeQDomNodeList();
		}
		public void Dispose() {
			DisposeQDomNodeList();
		}
		[SmokeMethod("~QDomNodeList", "()", "")]
		private void DisposeQDomNodeList() {
			ProxyQDomNodeList().DisposeQDomNodeList();
		}
	}
}
