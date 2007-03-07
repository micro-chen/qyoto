//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQLCDNumberSignals"></see> for signals emitted by QLCDNumber
	[SmokeClass("QLCDNumber")]
	public class QLCDNumber : QFrame, IDisposable {
 		protected QLCDNumber(Type dummy) : base((Type) null) {}
		[SmokeClass("QLCDNumber")]
		interface IQLCDNumberProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
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
		public enum Mode {
			Hex = 0,
			Dec = 1,
			Oct = 2,
			Bin = 3,
		}
		public enum SegmentStyle {
			Outline = 0,
			Filled = 1,
			Flat = 2,
		}
		[Q_PROPERTY("bool", "smallDecimalPoint")]
		public bool SmallDecimalPoint {
			get {
				return Property("smallDecimalPoint").Value<bool>();
			}
			set {
				SetProperty("smallDecimalPoint", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("int", "numDigits")]
		public int NumDigits {
			get {
				return Property("numDigits").Value<int>();
			}
			set {
				SetProperty("numDigits", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("QLCDNumber::Mode", "mode")]
		public QLCDNumber.Mode mode {
			get {
				return Property("mode").Value<QLCDNumber.Mode>();
			}
			set {
				SetProperty("mode", QVariant.FromValue<QLCDNumber.Mode>(value));
			}
		}
		[Q_PROPERTY("QLCDNumber::SegmentStyle", "segmentStyle")]
		public QLCDNumber.SegmentStyle segmentStyle {
			get {
				return Property("segmentStyle").Value<QLCDNumber.SegmentStyle>();
			}
			set {
				SetProperty("segmentStyle", QVariant.FromValue<QLCDNumber.SegmentStyle>(value));
			}
		}
		[Q_PROPERTY("double", "value")]
		public double Value {
			get {
				return Property("value").Value<double>();
			}
			set {
				SetProperty("value", QVariant.FromValue<double>(value));
			}
		}
		[Q_PROPERTY("int", "intValue")]
		public int IntValue {
			get {
				return Property("intValue").Value<int>();
			}
			set {
				SetProperty("intValue", QVariant.FromValue<int>(value));
			}
		}
		public QLCDNumber(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQLCDNumber(parent);
		}
		[SmokeMethod("QLCDNumber", "(QWidget*)", "#")]
		private void NewQLCDNumber(QWidget parent) {
			ProxyQLCDNumber().NewQLCDNumber(parent);
		}
		public QLCDNumber() : this((Type) null) {
			CreateProxy();
			NewQLCDNumber();
		}
		[SmokeMethod("QLCDNumber", "()", "")]
		private void NewQLCDNumber() {
			ProxyQLCDNumber().NewQLCDNumber();
		}
		public QLCDNumber(uint numDigits, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQLCDNumber(numDigits,parent);
		}
		[SmokeMethod("QLCDNumber", "(uint, QWidget*)", "$#")]
		private void NewQLCDNumber(uint numDigits, QWidget parent) {
			ProxyQLCDNumber().NewQLCDNumber(numDigits,parent);
		}
		public QLCDNumber(uint numDigits) : this((Type) null) {
			CreateProxy();
			NewQLCDNumber(numDigits);
		}
		[SmokeMethod("QLCDNumber", "(uint)", "$")]
		private void NewQLCDNumber(uint numDigits) {
			ProxyQLCDNumber().NewQLCDNumber(numDigits);
		}
		[SmokeMethod("checkOverflow", "(double) const", "$")]
		public bool CheckOverflow(double num) {
			return ProxyQLCDNumber().CheckOverflow(num);
		}
		[SmokeMethod("checkOverflow", "(int) const", "$")]
		public bool CheckOverflow(int num) {
			return ProxyQLCDNumber().CheckOverflow(num);
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public new QSize SizeHint() {
			return ProxyQLCDNumber().SizeHint();
		}
		[Q_SLOT("void display(const QString&)")]
		[SmokeMethod("display", "(const QString&)", "$")]
		public void Display(string str) {
			ProxyQLCDNumber().Display(str);
		}
		[Q_SLOT("void display(int)")]
		[SmokeMethod("display", "(int)", "$")]
		public void Display(int num) {
			ProxyQLCDNumber().Display(num);
		}
		[Q_SLOT("void display(double)")]
		[SmokeMethod("display", "(double)", "$")]
		public void Display(double num) {
			ProxyQLCDNumber().Display(num);
		}
		[Q_SLOT("void setHexMode()")]
		[SmokeMethod("setHexMode", "()", "")]
		public void SetHexMode() {
			ProxyQLCDNumber().SetHexMode();
		}
		[Q_SLOT("void setDecMode()")]
		[SmokeMethod("setDecMode", "()", "")]
		public void SetDecMode() {
			ProxyQLCDNumber().SetDecMode();
		}
		[Q_SLOT("void setOctMode()")]
		[SmokeMethod("setOctMode", "()", "")]
		public void SetOctMode() {
			ProxyQLCDNumber().SetOctMode();
		}
		[Q_SLOT("void setBinMode()")]
		[SmokeMethod("setBinMode", "()", "")]
		public void SetBinMode() {
			ProxyQLCDNumber().SetBinMode();
		}
		public static new string Tr(string s, string c) {
			return StaticQLCDNumber().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQLCDNumber().Tr(s);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public new bool Event(QEvent e) {
			return ProxyQLCDNumber().Event(e);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQLCDNumber().PaintEvent(arg1);
		}
		~QLCDNumber() {
			DisposeQLCDNumber();
		}
		public new void Dispose() {
			DisposeQLCDNumber();
		}
		[SmokeMethod("~QLCDNumber", "()", "")]
		private void DisposeQLCDNumber() {
			ProxyQLCDNumber().DisposeQLCDNumber();
		}
		protected new IQLCDNumberSignals Emit {
			get {
				return (IQLCDNumberSignals) Q_EMIT;
			}
		}
	}

	public interface IQLCDNumberSignals : IQFrameSignals {
		[Q_SIGNAL("void overflow()")]
		void Overflow();
	}
}
