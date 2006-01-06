//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QHostAddress")]
	public class QHostAddress : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QHostAddress(Type dummy) {}
		interface IQHostAddressProxy {
			bool op_equals(QHostAddress lhs, QHostAddress arg1);
		}

		protected void CreateQHostAddressProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QHostAddress), this);
			_interceptor = (QHostAddress) realProxy.GetTransparentProxy();
		}
		private QHostAddress ProxyQHostAddress() {
			return (QHostAddress) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QHostAddress() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQHostAddressProxy), null);
			_staticInterceptor = (IQHostAddressProxy) realProxy.GetTransparentProxy();
		}
		private static IQHostAddressProxy StaticQHostAddress() {
			return (IQHostAddressProxy) _staticInterceptor;
		}

		public QHostAddress() : this((Type) null) {
			CreateQHostAddressProxy();
			NewQHostAddress();
		}
		[SmokeMethod("QHostAddress()")]
		private void NewQHostAddress() {
			ProxyQHostAddress().NewQHostAddress();
		}
		public QHostAddress(uint ip4Addr) : this((Type) null) {
			CreateQHostAddressProxy();
			NewQHostAddress(ip4Addr);
		}
		[SmokeMethod("QHostAddress(Q_UINT32)")]
		private void NewQHostAddress(uint ip4Addr) {
			ProxyQHostAddress().NewQHostAddress(ip4Addr);
		}
		public QHostAddress(ushort ip6Addr) : this((Type) null) {
			CreateQHostAddressProxy();
			NewQHostAddress(ip6Addr);
		}
		[SmokeMethod("QHostAddress(Q_UINT8*)")]
		private void NewQHostAddress(ushort ip6Addr) {
			ProxyQHostAddress().NewQHostAddress(ip6Addr);
		}
		// QHostAddress* QHostAddress(const Q_IPV6ADDR& arg1); >>>> NOT CONVERTED
		public QHostAddress(string address) : this((Type) null) {
			CreateQHostAddressProxy();
			NewQHostAddress(address);
		}
		[SmokeMethod("QHostAddress(const QString&)")]
		private void NewQHostAddress(string address) {
			ProxyQHostAddress().NewQHostAddress(address);
		}
		public QHostAddress(QHostAddress arg1) : this((Type) null) {
			CreateQHostAddressProxy();
			NewQHostAddress(arg1);
		}
		[SmokeMethod("QHostAddress(const QHostAddress&)")]
		private void NewQHostAddress(QHostAddress arg1) {
			ProxyQHostAddress().NewQHostAddress(arg1);
		}
		[SmokeMethod("setAddress(Q_UINT32)")]
		public void SetAddress(uint ip4Addr) {
			ProxyQHostAddress().SetAddress(ip4Addr);
		}
		[SmokeMethod("setAddress(Q_UINT8*)")]
		public void SetAddress(ushort ip6Addr) {
			ProxyQHostAddress().SetAddress(ip6Addr);
		}
		[SmokeMethod("setAddress(const QString&)")]
		public bool SetAddress(string address) {
			return ProxyQHostAddress().SetAddress(address);
		}
		[SmokeMethod("isIp4Addr() const")]
		public bool IsIp4Addr() {
			return ProxyQHostAddress().IsIp4Addr();
		}
		[SmokeMethod("ip4Addr() const")]
		public uint Ip4Addr() {
			return ProxyQHostAddress().Ip4Addr();
		}
		[SmokeMethod("isIPv4Address() const")]
		public bool IsIPv4Address() {
			return ProxyQHostAddress().IsIPv4Address();
		}
		[SmokeMethod("toIPv4Address() const")]
		public uint ToIPv4Address() {
			return ProxyQHostAddress().ToIPv4Address();
		}
		[SmokeMethod("isIPv6Address() const")]
		public bool IsIPv6Address() {
			return ProxyQHostAddress().IsIPv6Address();
		}
		// Q_IPV6ADDR toIPv6Address(); >>>> NOT CONVERTED
		[SmokeMethod("toString() const")]
		public new string ToString() {
			return ProxyQHostAddress().ToString();
		}
		[SmokeMethod("operator==(const QHostAddress&) const")]
		public static bool operator==(QHostAddress lhs, QHostAddress arg1) {
			return StaticQHostAddress().op_equals(lhs,arg1);
		}
		public static bool operator!=(QHostAddress lhs, QHostAddress arg1) {
			return !StaticQHostAddress().op_equals(lhs,arg1);
		}
		public override bool Equals(object o) {
			if (!(o is QHostAddress)) { return false; }
			return this == (QHostAddress) o;
		}
		public override int GetHashCode() {
			return ProxyQHostAddress().GetHashCode();
		}
		[SmokeMethod("isNull() const")]
		public bool IsNull() {
			return ProxyQHostAddress().IsNull();
		}
		~QHostAddress() {
			DisposeQHostAddress();
		}
		public void Dispose() {
			DisposeQHostAddress();
		}
		private void DisposeQHostAddress() {
			ProxyQHostAddress().DisposeQHostAddress();
		}
	}
}
