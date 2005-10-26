//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QKeySequence : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QKeySequence(Type dummy) {}
		interface IQKeySequenceProxy {
			bool op_equals(QKeySequence lhs, QKeySequence other);
			bool op_lt(QKeySequence lhs, QKeySequence ks);
			bool op_gt(QKeySequence lhs, QKeySequence other);
			bool op_lte(QKeySequence lhs, QKeySequence other);
			bool op_gte(QKeySequence lhs, QKeySequence other);
			QKeySequence Mnemonic(string text);
		}

		protected void CreateQKeySequenceProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QKeySequence), this);
			_interceptor = (QKeySequence) realProxy.GetTransparentProxy();
		}
		private QKeySequence ProxyQKeySequence() {
			return (QKeySequence) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QKeySequence() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQKeySequenceProxy), null);
			_staticInterceptor = (IQKeySequenceProxy) realProxy.GetTransparentProxy();
		}
		private static IQKeySequenceProxy StaticQKeySequence() {
			return (IQKeySequenceProxy) _staticInterceptor;
		}

		enum SequenceMatch {
			NoMatch = 0,
			PartialMatch = 1,
			ExactMatch = 2,
		}
		public QKeySequence() : this((Type) null) {
			CreateQKeySequenceProxy();
			NewQKeySequence();
		}
		private void NewQKeySequence() {
			ProxyQKeySequence().NewQKeySequence();
		}
		public QKeySequence(string key) : this((Type) null) {
			CreateQKeySequenceProxy();
			NewQKeySequence(key);
		}
		private void NewQKeySequence(string key) {
			ProxyQKeySequence().NewQKeySequence(key);
		}
		public QKeySequence(int k1, int k2, int k3, int k4) : this((Type) null) {
			CreateQKeySequenceProxy();
			NewQKeySequence(k1,k2,k3,k4);
		}
		private void NewQKeySequence(int k1, int k2, int k3, int k4) {
			ProxyQKeySequence().NewQKeySequence(k1,k2,k3,k4);
		}
		public QKeySequence(int k1, int k2, int k3) : this((Type) null) {
			CreateQKeySequenceProxy();
			NewQKeySequence(k1,k2,k3);
		}
		private void NewQKeySequence(int k1, int k2, int k3) {
			ProxyQKeySequence().NewQKeySequence(k1,k2,k3);
		}
		public QKeySequence(int k1, int k2) : this((Type) null) {
			CreateQKeySequenceProxy();
			NewQKeySequence(k1,k2);
		}
		private void NewQKeySequence(int k1, int k2) {
			ProxyQKeySequence().NewQKeySequence(k1,k2);
		}
		public QKeySequence(int k1) : this((Type) null) {
			CreateQKeySequenceProxy();
			NewQKeySequence(k1);
		}
		private void NewQKeySequence(int k1) {
			ProxyQKeySequence().NewQKeySequence(k1);
		}
		public QKeySequence(QKeySequence ks) : this((Type) null) {
			CreateQKeySequenceProxy();
			NewQKeySequence(ks);
		}
		private void NewQKeySequence(QKeySequence ks) {
			ProxyQKeySequence().NewQKeySequence(ks);
		}
		public uint Count() {
			return ProxyQKeySequence().Count();
		}
		public bool IsEmpty() {
			return ProxyQKeySequence().IsEmpty();
		}
		public int Matches(QKeySequence seq) {
			return ProxyQKeySequence().Matches(seq);
		}
		//  operator QString(); >>>> NOT CONVERTED
		//  operator QVariant(); >>>> NOT CONVERTED
		//  operator int(); >>>> NOT CONVERTED
		public static bool operator==(QKeySequence lhs, QKeySequence other) {
			return StaticQKeySequence().op_equals(lhs,other);
		}
		public static bool operator!=(QKeySequence lhs, QKeySequence other) {
			return !StaticQKeySequence().op_equals(lhs,other);
		}
		public override bool Equals(object o) {
			if (!(o is QKeySequence)) { return false; }
			return this == (QKeySequence) o;
		}
		public override int GetHashCode() {
			return ProxyQKeySequence().GetHashCode();
		}
		public static bool operator<(QKeySequence lhs, QKeySequence ks) {
			return StaticQKeySequence().op_lt(lhs,ks);
		}
		public static bool operator>(QKeySequence lhs, QKeySequence other) {
			return StaticQKeySequence().op_gt(lhs,other);
		}
		public static bool operator<=(QKeySequence lhs, QKeySequence other) {
			return StaticQKeySequence().op_lte(lhs,other);
		}
		public static bool operator>=(QKeySequence lhs, QKeySequence other) {
			return StaticQKeySequence().op_gte(lhs,other);
		}
		public bool IsDetached() {
			return ProxyQKeySequence().IsDetached();
		}
		public static QKeySequence Mnemonic(string text) {
			return StaticQKeySequence().Mnemonic(text);
		}
		~QKeySequence() {
			ProxyQKeySequence().Dispose();
		}
		public void Dispose() {
			ProxyQKeySequence().Dispose();
		}
	}
}
