//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QDate")]
	public class QDate : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QDate(Type dummy) {}
		[SmokeClass("QDate")]
		interface IQDateProxy {
			[SmokeMethod("operator==", "(const QDate&) const", "#")]
			bool op_equals(QDate lhs, QDate other);
			[SmokeMethod("operator<", "(const QDate&) const", "#")]
			bool op_lt(QDate lhs, QDate other);
			[SmokeMethod("operator<=", "(const QDate&) const", "#")]
			bool op_lte(QDate lhs, QDate other);
			[SmokeMethod("operator>", "(const QDate&) const", "#")]
			bool op_gt(QDate lhs, QDate other);
			[SmokeMethod("operator>=", "(const QDate&) const", "#")]
			bool op_gte(QDate lhs, QDate other);
			[SmokeMethod("shortMonthName", "(int)", "$")]
			string ShortMonthName(int month);
			[SmokeMethod("shortDayName", "(int)", "$")]
			string ShortDayName(int weekday);
			[SmokeMethod("longMonthName", "(int)", "$")]
			string LongMonthName(int month);
			[SmokeMethod("longDayName", "(int)", "$")]
			string LongDayName(int weekday);
			[SmokeMethod("currentDate", "()", "")]
			QDate CurrentDate();
			[SmokeMethod("fromString", "(const QString&, Qt::DateFormat)", "$$")]
			QDate FromString(string s, Qt.DateFormat f);
			[SmokeMethod("fromString", "(const QString&)", "$")]
			QDate FromString(string s);
			[SmokeMethod("fromString", "(const QString&, const QString&)", "$$")]
			QDate FromString(string s, string format);
			[SmokeMethod("isValid", "(int, int, int)", "$$$")]
			bool IsValid(int y, int m, int d);
			[SmokeMethod("isLeapYear", "(int)", "$")]
			bool IsLeapYear(int year);
			[SmokeMethod("gregorianToJulian", "(int, int, int)", "$$$")]
			uint GregorianToJulian(int y, int m, int d);
			[SmokeMethod("julianToGregorian", "(uint, int&, int&, int&)", "$$$$")]
			void JulianToGregorian(uint jd, out int y, out int m, out int d);
			[SmokeMethod("fromJulianDay", "(int)", "$")]
			QDate FromJulianDay(int jd);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDate), this);
			_interceptor = (QDate) realProxy.GetTransparentProxy();
		}
		private QDate ProxyQDate() {
			return (QDate) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDate() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDateProxy), null);
			_staticInterceptor = (IQDateProxy) realProxy.GetTransparentProxy();
		}
		private static IQDateProxy StaticQDate() {
			return (IQDateProxy) _staticInterceptor;
		}
		public QDate() : this((Type) null) {
			CreateProxy();
			NewQDate();
		}
		[SmokeMethod("QDate", "()", "")]
		private void NewQDate() {
			ProxyQDate().NewQDate();
		}
		public QDate(int y, int m, int d) : this((Type) null) {
			CreateProxy();
			NewQDate(y,m,d);
		}
		[SmokeMethod("QDate", "(int, int, int)", "$$$")]
		private void NewQDate(int y, int m, int d) {
			ProxyQDate().NewQDate(y,m,d);
		}
		[SmokeMethod("isNull", "() const", "")]
		public bool IsNull() {
			return ProxyQDate().IsNull();
		}
		[SmokeMethod("isValid", "() const", "")]
		public bool IsValid() {
			return ProxyQDate().IsValid();
		}
		[SmokeMethod("year", "() const", "")]
		public int Year() {
			return ProxyQDate().Year();
		}
		[SmokeMethod("month", "() const", "")]
		public int Month() {
			return ProxyQDate().Month();
		}
		[SmokeMethod("day", "() const", "")]
		public int Day() {
			return ProxyQDate().Day();
		}
		[SmokeMethod("dayOfWeek", "() const", "")]
		public int DayOfWeek() {
			return ProxyQDate().DayOfWeek();
		}
		[SmokeMethod("dayOfYear", "() const", "")]
		public int DayOfYear() {
			return ProxyQDate().DayOfYear();
		}
		[SmokeMethod("daysInMonth", "() const", "")]
		public int DaysInMonth() {
			return ProxyQDate().DaysInMonth();
		}
		[SmokeMethod("daysInYear", "() const", "")]
		public int DaysInYear() {
			return ProxyQDate().DaysInYear();
		}
		[SmokeMethod("weekNumber", "(int*) const", "$")]
		public int WeekNumber(out int yearNum) {
			return ProxyQDate().WeekNumber(out yearNum);
		}
		[SmokeMethod("weekNumber", "() const", "")]
		public int WeekNumber() {
			return ProxyQDate().WeekNumber();
		}
		[SmokeMethod("toString", "(Qt::DateFormat) const", "$")]
		public new string ToString(Qt.DateFormat f) {
			return ProxyQDate().ToString(f);
		}
		[SmokeMethod("toString", "() const", "")]
		public new string ToString() {
			return ProxyQDate().ToString();
		}
		[SmokeMethod("toString", "(const QString&) const", "$")]
		public new string ToString(string format) {
			return ProxyQDate().ToString(format);
		}
		[SmokeMethod("setYMD", "(int, int, int)", "$$$")]
		public bool SetYMD(int y, int m, int d) {
			return ProxyQDate().SetYMD(y,m,d);
		}
		[SmokeMethod("setDate", "(int, int, int)", "$$$")]
		public bool SetDate(int year, int month, int date) {
			return ProxyQDate().SetDate(year,month,date);
		}
		[SmokeMethod("addDays", "(int) const", "$")]
		public QDate AddDays(int days) {
			return ProxyQDate().AddDays(days);
		}
		[SmokeMethod("addMonths", "(int) const", "$")]
		public QDate AddMonths(int months) {
			return ProxyQDate().AddMonths(months);
		}
		[SmokeMethod("addYears", "(int) const", "$")]
		public QDate AddYears(int years) {
			return ProxyQDate().AddYears(years);
		}
		[SmokeMethod("daysTo", "(const QDate&) const", "#")]
		public int DaysTo(QDate arg1) {
			return ProxyQDate().DaysTo(arg1);
		}
		public static bool operator==(QDate lhs, QDate other) {
			return StaticQDate().op_equals(lhs,other);
		}
		public static bool operator!=(QDate lhs, QDate other) {
			return !StaticQDate().op_equals(lhs,other);
		}
		public override bool Equals(object o) {
			if (!(o is QDate)) { return false; }
			return this == (QDate) o;
		}
		public override int GetHashCode() {
			return ProxyQDate().GetHashCode();
		}
		public static bool operator<(QDate lhs, QDate other) {
			return StaticQDate().op_lt(lhs,other);
		}
		public static bool operator<=(QDate lhs, QDate other) {
			return StaticQDate().op_lte(lhs,other);
		}
		public static bool operator>(QDate lhs, QDate other) {
			return StaticQDate().op_gt(lhs,other);
		}
		public static bool operator>=(QDate lhs, QDate other) {
			return StaticQDate().op_gte(lhs,other);
		}
		[SmokeMethod("toJulianDay", "() const", "")]
		public int ToJulianDay() {
			return ProxyQDate().ToJulianDay();
		}
		public static string ShortMonthName(int month) {
			return StaticQDate().ShortMonthName(month);
		}
		public static string ShortDayName(int weekday) {
			return StaticQDate().ShortDayName(weekday);
		}
		public static string LongMonthName(int month) {
			return StaticQDate().LongMonthName(month);
		}
		public static string LongDayName(int weekday) {
			return StaticQDate().LongDayName(weekday);
		}
		public static QDate CurrentDate() {
			return StaticQDate().CurrentDate();
		}
		public static QDate FromString(string s, Qt.DateFormat f) {
			return StaticQDate().FromString(s,f);
		}
		public static QDate FromString(string s) {
			return StaticQDate().FromString(s);
		}
		public static QDate FromString(string s, string format) {
			return StaticQDate().FromString(s,format);
		}
		public static bool IsValid(int y, int m, int d) {
			return StaticQDate().IsValid(y,m,d);
		}
		public static bool IsLeapYear(int year) {
			return StaticQDate().IsLeapYear(year);
		}
		public static uint GregorianToJulian(int y, int m, int d) {
			return StaticQDate().GregorianToJulian(y,m,d);
		}
		public static void JulianToGregorian(uint jd, out int y, out int m, out int d) {
			StaticQDate().JulianToGregorian(jd,out y,out m,out d);
		}
		public static QDate FromJulianDay(int jd) {
			return StaticQDate().FromJulianDay(jd);
		}
		~QDate() {
			DisposeQDate();
		}
		public void Dispose() {
			DisposeQDate();
		}
		[SmokeMethod("~QDate", "()", "")]
		private void DisposeQDate() {
			ProxyQDate().DisposeQDate();
		}
	}
}
