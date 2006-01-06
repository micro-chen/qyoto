//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QTime")]
	public class QTime : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QTime(Type dummy) {}
		interface IQTimeProxy {
			bool op_equals(QTime lhs, DateTime d);
			bool op_lt(QTime lhs, DateTime d);
			bool op_lte(QTime lhs, DateTime d);
			bool op_gt(QTime lhs, DateTime d);
			bool op_gte(QTime lhs, DateTime d);
			DateTime CurrentTime();
			DateTime CurrentTime(int arg1);
			DateTime FromString(string s, int f);
			DateTime FromString(string s);
			bool IsValid(int h, int m, int s, int ms);
			bool IsValid(int h, int m, int s);
		}

		protected void CreateQTimeProxy() {
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
			CreateQTimeProxy();
			NewQTime();
		}
		[SmokeMethod("QTime()")]
		private void NewQTime() {
			ProxyQTime().NewQTime();
		}
		public QTime(int h, int m, int s, int ms) : this((Type) null) {
			CreateQTimeProxy();
			NewQTime(h,m,s,ms);
		}
		[SmokeMethod("QTime(int, int, int, int)")]
		private void NewQTime(int h, int m, int s, int ms) {
			ProxyQTime().NewQTime(h,m,s,ms);
		}
		public QTime(int h, int m, int s) : this((Type) null) {
			CreateQTimeProxy();
			NewQTime(h,m,s);
		}
		[SmokeMethod("QTime(int, int, int)")]
		private void NewQTime(int h, int m, int s) {
			ProxyQTime().NewQTime(h,m,s);
		}
		public QTime(int h, int m) : this((Type) null) {
			CreateQTimeProxy();
			NewQTime(h,m);
		}
		[SmokeMethod("QTime(int, int)")]
		private void NewQTime(int h, int m) {
			ProxyQTime().NewQTime(h,m);
		}
		[SmokeMethod("isNull() const")]
		public bool IsNull() {
			return ProxyQTime().IsNull();
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQTime().IsValid();
		}
		[SmokeMethod("hour() const")]
		public int Hour() {
			return ProxyQTime().Hour();
		}
		[SmokeMethod("minute() const")]
		public int Minute() {
			return ProxyQTime().Minute();
		}
		[SmokeMethod("second() const")]
		public int Second() {
			return ProxyQTime().Second();
		}
		[SmokeMethod("msec() const")]
		public int Msec() {
			return ProxyQTime().Msec();
		}
		[SmokeMethod("toString(Qt::DateFormat) const")]
		public new string ToString(int f) {
			return ProxyQTime().ToString(f);
		}
		[SmokeMethod("toString() const")]
		public new string ToString() {
			return ProxyQTime().ToString();
		}
		[SmokeMethod("toString(const QString&) const")]
		public new string ToString(string format) {
			return ProxyQTime().ToString(format);
		}
		[SmokeMethod("setHMS(int, int, int, int)")]
		public bool SetHMS(int h, int m, int s, int ms) {
			return ProxyQTime().SetHMS(h,m,s,ms);
		}
		[SmokeMethod("setHMS(int, int, int)")]
		public bool SetHMS(int h, int m, int s) {
			return ProxyQTime().SetHMS(h,m,s);
		}
		[SmokeMethod("addSecs(int) const")]
		public DateTime AddSecs(int secs) {
			return ProxyQTime().AddSecs(secs);
		}
		[SmokeMethod("secsTo(const QTime&) const")]
		public int SecsTo(DateTime arg1) {
			return ProxyQTime().SecsTo(arg1);
		}
		[SmokeMethod("addMSecs(int) const")]
		public DateTime AddMSecs(int ms) {
			return ProxyQTime().AddMSecs(ms);
		}
		[SmokeMethod("msecsTo(const QTime&) const")]
		public int MsecsTo(DateTime arg1) {
			return ProxyQTime().MsecsTo(arg1);
		}
		[SmokeMethod("operator==(const QTime&) const")]
		public static bool operator==(QTime lhs, DateTime d) {
			return StaticQTime().op_equals(lhs,d);
		}
		public static bool operator!=(QTime lhs, DateTime d) {
			return !StaticQTime().op_equals(lhs,d);
		}
		public override bool Equals(object o) {
			if (!(o is QTime)) { return false; }
			return this == (QTime) o;
		}
		public override int GetHashCode() {
			return ProxyQTime().GetHashCode();
		}
		[SmokeMethod("operator<(const QTime&) const")]
		public static bool operator<(QTime lhs, DateTime d) {
			return StaticQTime().op_lt(lhs,d);
		}
		[SmokeMethod("operator<=(const QTime&) const")]
		public static bool operator<=(QTime lhs, DateTime d) {
			return StaticQTime().op_lte(lhs,d);
		}
		[SmokeMethod("operator>(const QTime&) const")]
		public static bool operator>(QTime lhs, DateTime d) {
			return StaticQTime().op_gt(lhs,d);
		}
		[SmokeMethod("operator>=(const QTime&) const")]
		public static bool operator>=(QTime lhs, DateTime d) {
			return StaticQTime().op_gte(lhs,d);
		}
		[SmokeMethod("start()")]
		public void Start() {
			ProxyQTime().Start();
		}
		[SmokeMethod("restart()")]
		public int Restart() {
			return ProxyQTime().Restart();
		}
		[SmokeMethod("elapsed() const")]
		public int Elapsed() {
			return ProxyQTime().Elapsed();
		}
		[SmokeMethod("currentTime()")]
		public static DateTime CurrentTime() {
			return StaticQTime().CurrentTime();
		}
		[SmokeMethod("currentTime(Qt::TimeSpec)")]
		public static DateTime CurrentTime(int arg1) {
			return StaticQTime().CurrentTime(arg1);
		}
		[SmokeMethod("fromString(const QString&, Qt::DateFormat)")]
		public static DateTime FromString(string s, int f) {
			return StaticQTime().FromString(s,f);
		}
		[SmokeMethod("fromString(const QString&)")]
		public static DateTime FromString(string s) {
			return StaticQTime().FromString(s);
		}
		[SmokeMethod("isValid(int, int, int, int)")]
		public static bool IsValid(int h, int m, int s, int ms) {
			return StaticQTime().IsValid(h,m,s,ms);
		}
		[SmokeMethod("isValid(int, int, int)")]
		public static bool IsValid(int h, int m, int s) {
			return StaticQTime().IsValid(h,m,s);
		}
		~QTime() {
			DisposeQTime();
		}
		public void Dispose() {
			DisposeQTime();
		}
		private void DisposeQTime() {
			ProxyQTime().DisposeQTime();
		}
	}
}
