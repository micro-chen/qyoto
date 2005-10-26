//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQLCDNumberSignals"></see> for signals emitted by QLCDNumber
	public class QLCDNumber : QFrame, IDisposable {
 		protected QLCDNumber(Type dummy) : base((Type) null) {}
		interface IQLCDNumberProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected void CreateQLCDNumberProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QLCDNumber), this);
			_interceptor = (QLCDNumber) realProxy.GetTransparentProxy();
		}
		private QLCDNumber ProxyQLCDNumber() {
			return (QLCDNumber) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QLCDNumber() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQLCDNumberProxy), null);
			_staticInterceptor = (IQLCDNumberProxy) realProxy.GetTransparentProxy();
		}
		private static IQLCDNumberProxy StaticQLCDNumber() {
			return (IQLCDNumberProxy) _staticInterceptor;
		}

		enum E_Mode {
			Hex = 0,
			Dec = 1,
			Oct = 2,
			Bin = 3,
		}
		enum E_SegmentStyle {
			Outline = 0,
			Filled = 1,
			Flat = 2,
		}
		public new virtual QMetaObject MetaObject() {
			return ProxyQLCDNumber().MetaObject();
		}
		// void* qt_metacast(const char* arg1); >>>> NOT CONVERTED
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QLCDNumber(QWidget parent) : this((Type) null) {
			CreateQLCDNumberProxy();
			NewQLCDNumber(parent);
		}
		private void NewQLCDNumber(QWidget parent) {
			ProxyQLCDNumber().NewQLCDNumber(parent);
		}
		public QLCDNumber() : this((Type) null) {
			CreateQLCDNumberProxy();
			NewQLCDNumber();
		}
		private void NewQLCDNumber() {
			ProxyQLCDNumber().NewQLCDNumber();
		}
		public QLCDNumber(uint numDigits, QWidget parent) : this((Type) null) {
			CreateQLCDNumberProxy();
			NewQLCDNumber(numDigits,parent);
		}
		private void NewQLCDNumber(uint numDigits, QWidget parent) {
			ProxyQLCDNumber().NewQLCDNumber(numDigits,parent);
		}
		public QLCDNumber(uint numDigits) : this((Type) null) {
			CreateQLCDNumberProxy();
			NewQLCDNumber(numDigits);
		}
		private void NewQLCDNumber(uint numDigits) {
			ProxyQLCDNumber().NewQLCDNumber(numDigits);
		}
		public bool SmallDecimalPoint() {
			return ProxyQLCDNumber().SmallDecimalPoint();
		}
		public int NumDigits() {
			return ProxyQLCDNumber().NumDigits();
		}
		public void SetNumDigits(int nDigits) {
			ProxyQLCDNumber().SetNumDigits(nDigits);
		}
		public bool CheckOverflow(double num) {
			return ProxyQLCDNumber().CheckOverflow(num);
		}
		public bool CheckOverflow(int num) {
			return ProxyQLCDNumber().CheckOverflow(num);
		}
		public int Mode() {
			return ProxyQLCDNumber().Mode();
		}
		public void SetMode(int arg1) {
			ProxyQLCDNumber().SetMode(arg1);
		}
		public int SegmentStyle() {
			return ProxyQLCDNumber().SegmentStyle();
		}
		public void SetSegmentStyle(int arg1) {
			ProxyQLCDNumber().SetSegmentStyle(arg1);
		}
		public double Value() {
			return ProxyQLCDNumber().Value();
		}
		public int IntValue() {
			return ProxyQLCDNumber().IntValue();
		}
		public new QSize SizeHint() {
			return ProxyQLCDNumber().SizeHint();
		}
		public void Display(string str) {
			ProxyQLCDNumber().Display(str);
		}
		public void Display(int num) {
			ProxyQLCDNumber().Display(num);
		}
		public void Display(double num) {
			ProxyQLCDNumber().Display(num);
		}
		public void SetHexMode() {
			ProxyQLCDNumber().SetHexMode();
		}
		public void SetDecMode() {
			ProxyQLCDNumber().SetDecMode();
		}
		public void SetOctMode() {
			ProxyQLCDNumber().SetOctMode();
		}
		public void SetBinMode() {
			ProxyQLCDNumber().SetBinMode();
		}
		public void SetSmallDecimalPoint(bool arg1) {
			ProxyQLCDNumber().SetSmallDecimalPoint(arg1);
		}
		public static new string Tr(string s, string c) {
			return StaticQLCDNumber().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQLCDNumber().Tr(s);
		}
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQLCDNumber().PaintEvent(arg1);
		}
		~QLCDNumber() {
			ProxyQLCDNumber().Dispose();
		}
		public new void Dispose() {
			ProxyQLCDNumber().Dispose();
		}
	}

	public interface IQLCDNumberSignals {
		void Overflow();
	}
}
