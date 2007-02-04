//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QTime")]
	public class QTime : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QTime(Type dummy) {}
		[SmokeClass("QTime")]
		interface IQTimeProxy {
			[SmokeMethod("operator==", "(const QTime&) const", "#")]
			bool op_equals(QTime lhs, QTime other);
			[SmokeMethod("operator<", "(const QTime&) const", "#")]
			bool op_lt(QTime lhs, QTime other);
			[SmokeMethod("operator<=", "(const QTime&) const", "#")]
			bool op_lte(QTime lhs, QTime other);
			[SmokeMethod("operator>", "(const QTime&) const", "#")]
			bool op_gt(QTime lhs, QTime other);
			[SmokeMethod("operator>=", "(const QTime&) const", "#")]
			bool op_gte(QTime lhs, QTime other);
			[SmokeMethod("currentTime", "()", "")]
			QTime CurrentTime();
			[SmokeMethod("fromString", "(const QString&, Qt::DateFormat)", "$$")]
			QTime FromString(string s, Qt.DateFormat f);
			[SmokeMethod("fromString", "(const QString&)", "$")]
			QTime FromString(string s);
			[SmokeMethod("fromString", "(const QString&, const QString&)", "$$")]
			QTime FromString(string s, string format);
			[SmokeMethod("isValid", "(int, int, int, int)", "$$$$")]
			bool IsValid(int h, int m, int s, int ms);
			[SmokeMethod("isValid", "(int, int, int)", "$$$")]
			bool IsValid(int h, int m, int s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTime), this);
			_interceptor = (QTime) realProxy.GetTransparentProxy();
		}
		private QTime ProxyQTime() {
			return (QTime) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTime() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTimeProxy), null);
			_staticInterceptor = (IQTimeProxy) realProxy.GetTransparentProxy();
		}
		private static IQTimeProxy StaticQTime() {
			return (IQTimeProxy) _staticInterceptor;
		}
		public QTime() : this((Type) null) {
			CreateProxy();
			NewQTime();
		}
		[SmokeMethod("QTime", "()", "")]
		private void NewQTime() {
			ProxyQTime().NewQTime();
		}
		public QTime(int h, int m, int s, int ms) : this((Type) null) {
			CreateProxy();
			NewQTime(h,m,s,ms);
		}
		[SmokeMethod("QTime", "(int, int, int, int)", "$$$$")]
		private void NewQTime(int h, int m, int s, int ms) {
			ProxyQTime().NewQTime(h,m,s,ms);
		}
		public QTime(int h, int m, int s) : this((Type) null) {
			CreateProxy();
			NewQTime(h,m,s);
		}
		[SmokeMethod("QTime", "(int, int, int)", "$$$")]
		private void NewQTime(int h, int m, int s) {
			ProxyQTime().NewQTime(h,m,s);
		}
		public QTime(int h, int m) : this((Type) null) {
			CreateProxy();
			NewQTime(h,m);
		}
		[SmokeMethod("QTime", "(int, int)", "$$")]
		private void NewQTime(int h, int m) {
			ProxyQTime().NewQTime(h,m);
		}
		[SmokeMethod("isNull", "() const", "")]
		public bool IsNull() {
			return ProxyQTime().IsNull();
		}
		[SmokeMethod("isValid", "() const", "")]
		public bool IsValid() {
			return ProxyQTime().IsValid();
		}
		[SmokeMethod("hour", "() const", "")]
		public int Hour() {
			return ProxyQTime().Hour();
		}
		[SmokeMethod("minute", "() const", "")]
		public int Minute() {
			return ProxyQTime().Minute();
		}
		[SmokeMethod("second", "() const", "")]
		public int Second() {
			return ProxyQTime().Second();
		}
		[SmokeMethod("msec", "() const", "")]
		public int Msec() {
			return ProxyQTime().Msec();
		}
		[SmokeMethod("toString", "(Qt::DateFormat) const", "$")]
		public new string ToString(Qt.DateFormat f) {
			return ProxyQTime().ToString(f);
		}
		[SmokeMethod("toString", "() const", "")]
		public new string ToString() {
			return ProxyQTime().ToString();
		}
		[SmokeMethod("toString", "(const QString&) const", "$")]
		public new string ToString(string format) {
			return ProxyQTime().ToString(format);
		}
		[SmokeMethod("setHMS", "(int, int, int, int)", "$$$$")]
		public bool SetHMS(int h, int m, int s, int ms) {
			return ProxyQTime().SetHMS(h,m,s,ms);
		}
		[SmokeMethod("setHMS", "(int, int, int)", "$$$")]
		public bool SetHMS(int h, int m, int s) {
			return ProxyQTime().SetHMS(h,m,s);
		}
		[SmokeMethod("addSecs", "(int) const", "$")]
		public QTime AddSecs(int secs) {
			return ProxyQTime().AddSecs(secs);
		}
		[SmokeMethod("secsTo", "(const QTime&) const", "#")]
		public int SecsTo(QTime arg1) {
			return ProxyQTime().SecsTo(arg1);
		}
		[SmokeMethod("addMSecs", "(int) const", "$")]
		public QTime AddMSecs(int ms) {
			return ProxyQTime().AddMSecs(ms);
		}
		[SmokeMethod("msecsTo", "(const QTime&) const", "#")]
		public int MsecsTo(QTime arg1) {
			return ProxyQTime().MsecsTo(arg1);
		}
		public static bool operator==(QTime lhs, QTime other) {
			return StaticQTime().op_equals(lhs,other);
		}
		public static bool operator!=(QTime lhs, QTime other) {
			return !StaticQTime().op_equals(lhs,other);
		}
		public override bool Equals(object o) {
			if (!(o is QTime)) { return false; }
			return this == (QTime) o;
		}
		public override int GetHashCode() {
			return ProxyQTime().GetHashCode();
		}
		public static bool operator<(QTime lhs, QTime other) {
			return StaticQTime().op_lt(lhs,other);
		}
		public static bool operator<=(QTime lhs, QTime other) {
			return StaticQTime().op_lte(lhs,other);
		}
		public static bool operator>(QTime lhs, QTime other) {
			return StaticQTime().op_gt(lhs,other);
		}
		public static bool operator>=(QTime lhs, QTime other) {
			return StaticQTime().op_gte(lhs,other);
		}
		[SmokeMethod("start", "()", "")]
		public void Start() {
			ProxyQTime().Start();
		}
		[SmokeMethod("restart", "()", "")]
		public int Restart() {
			return ProxyQTime().Restart();
		}
		[SmokeMethod("elapsed", "() const", "")]
		public int Elapsed() {
			return ProxyQTime().Elapsed();
		}
		public static QTime CurrentTime() {
			return StaticQTime().CurrentTime();
		}
		public static QTime FromString(string s, Qt.DateFormat f) {
			return StaticQTime().FromString(s,f);
		}
		public static QTime FromString(string s) {
			return StaticQTime().FromString(s);
		}
		public static QTime FromString(string s, string format) {
			return StaticQTime().FromString(s,format);
		}
		public static bool IsValid(int h, int m, int s, int ms) {
			return StaticQTime().IsValid(h,m,s,ms);
		}
		public static bool IsValid(int h, int m, int s) {
			return StaticQTime().IsValid(h,m,s);
		}
		~QTime() {
			DisposeQTime();
		}
		public void Dispose() {
			DisposeQTime();
		}
		[SmokeMethod("~QTime", "()", "")]
		private void DisposeQTime() {
			ProxyQTime().DisposeQTime();
		}
	}
}
