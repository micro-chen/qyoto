//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	public class QFont : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QFont(Type dummy) {}
		interface IQFontProxy {
			bool op_equals(QFont lhs, QFont arg1);
			string Substitute(string arg1);
			ArrayList Substitutes(string arg1);
			ArrayList Substitutions();
			void InsertSubstitution(string arg1, string arg2);
			void InsertSubstitutions(string arg1, string[] arg2);
			void RemoveSubstitution(string arg1);
			void Initialize();
			void Cleanup();
			void CacheStatistics();
			QFont DefaultFont();
			void SetDefaultFont(QFont arg1);
		}

		protected void CreateQFontProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFont), this);
			_interceptor = (QFont) realProxy.GetTransparentProxy();
		}
		private QFont ProxyQFont() {
			return (QFont) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFont() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFontProxy), null);
			_staticInterceptor = (IQFontProxy) realProxy.GetTransparentProxy();
		}
		private static IQFontProxy StaticQFont() {
			return (IQFontProxy) _staticInterceptor;
		}

		enum E_StyleHint {
			Helvetica = 0,
			SansSerif = Helvetica,
			Times = 1,
			Serif = Times,
			Courier = 2,
			TypeWriter = Courier,
			OldEnglish = 3,
			Decorative = OldEnglish,
			System = 4,
			AnyStyle = 5,
		}
		enum E_StyleStrategy {
			PreferDefault = 0x0001,
			PreferBitmap = 0x0002,
			PreferDevice = 0x0004,
			PreferOutline = 0x0008,
			ForceOutline = 0x0010,
			PreferMatch = 0x0020,
			PreferQuality = 0x0040,
			PreferAntialias = 0x0080,
			NoAntialias = 0x0100,
			OpenGLCompatible = 0x0200,
		}
		enum E_Weight {
			Light = 25,
			Normal = 50,
			DemiBold = 63,
			Bold = 75,
			Black = 87,
		}
		enum E_Stretch {
			UltraCondensed = 50,
			ExtraCondensed = 62,
			Condensed = 75,
			SemiCondensed = 87,
			Unstretched = 100,
			SemiExpanded = 112,
			Expanded = 125,
			ExtraExpanded = 150,
			UltraExpanded = 200,
		}
		enum Script {
			Latin = 0,
			Greek = 1,
			Cyrillic = 2,
			Armenian = 3,
			Georgian = 4,
			Runic = 5,
			Ogham = 6,
			SpacingModifiers = 7,
			CombiningMarks = 8,
			Hebrew = 9,
			Arabic = 10,
			Syriac = 11,
			Thaana = 12,
			Devanagari = 13,
			Bengali = 14,
			Gurmukhi = 15,
			Gujarati = 16,
			Oriya = 17,
			Tamil = 18,
			Telugu = 19,
			Kannada = 20,
			Malayalam = 21,
			Sinhala = 22,
			Thai = 23,
			Lao = 24,
			Tibetan = 25,
			Myanmar = 26,
			Khmer = 27,
			Han = 28,
			Hiragana = 29,
			Katakana = 30,
			Hangul = 31,
			Bopomofo = 32,
			Yi = 33,
			Ethiopic = 34,
			Cherokee = 35,
			CanadianAboriginal = 36,
			Mongolian = 37,
			CurrencySymbols = 38,
			LetterlikeSymbols = 39,
			NumberForms = 40,
			MathematicalOperators = 41,
			TechnicalSymbols = 42,
			GeometricSymbols = 43,
			MiscellaneousSymbols = 44,
			EnclosedAndSquare = 45,
			Braille = 46,
			Unicode = 47,
			Tagalog = 48,
			Hanunoo = 49,
			Buhid = 50,
			Tagbanwa = 51,
			KatakanaHalfWidth = 52,
			Limbu = 53,
			TaiLe = 54,
			NScripts = 55,
			UnknownScript = NScripts,
			NoScript = 56,
			Han_Japanese = 57,
			Han_SimplifiedChinese = 58,
			Han_TraditionalChinese = 59,
			Han_Korean = 60,
			LastPrivateScript = 61,
		}
		public QFont() : this((Type) null) {
			CreateQFontProxy();
			NewQFont();
		}
		private void NewQFont() {
			ProxyQFont().NewQFont();
		}
		public QFont(string family, int pointSize, int weight, bool italic) : this((Type) null) {
			CreateQFontProxy();
			NewQFont(family,pointSize,weight,italic);
		}
		private void NewQFont(string family, int pointSize, int weight, bool italic) {
			ProxyQFont().NewQFont(family,pointSize,weight,italic);
		}
		public QFont(string family, int pointSize, int weight) : this((Type) null) {
			CreateQFontProxy();
			NewQFont(family,pointSize,weight);
		}
		private void NewQFont(string family, int pointSize, int weight) {
			ProxyQFont().NewQFont(family,pointSize,weight);
		}
		public QFont(string family, int pointSize) : this((Type) null) {
			CreateQFontProxy();
			NewQFont(family,pointSize);
		}
		private void NewQFont(string family, int pointSize) {
			ProxyQFont().NewQFont(family,pointSize);
		}
		public QFont(string family) : this((Type) null) {
			CreateQFontProxy();
			NewQFont(family);
		}
		private void NewQFont(string family) {
			ProxyQFont().NewQFont(family);
		}
		public QFont(QFont arg1) : this((Type) null) {
			CreateQFontProxy();
			NewQFont(arg1);
		}
		private void NewQFont(QFont arg1) {
			ProxyQFont().NewQFont(arg1);
		}
		public string Family() {
			return ProxyQFont().Family();
		}
		public void SetFamily(string arg1) {
			ProxyQFont().SetFamily(arg1);
		}
		public int PointSize() {
			return ProxyQFont().PointSize();
		}
		public float PointSizeFloat() {
			return ProxyQFont().PointSizeFloat();
		}
		public void SetPointSize(int arg1) {
			ProxyQFont().SetPointSize(arg1);
		}
		public void SetPointSizeFloat(float arg1) {
			ProxyQFont().SetPointSizeFloat(arg1);
		}
		public int PixelSize() {
			return ProxyQFont().PixelSize();
		}
		public void SetPixelSize(int arg1) {
			ProxyQFont().SetPixelSize(arg1);
		}
		public void SetPixelSizeFloat(float arg1) {
			ProxyQFont().SetPixelSizeFloat(arg1);
		}
		public int Weight() {
			return ProxyQFont().Weight();
		}
		public void SetWeight(int arg1) {
			ProxyQFont().SetWeight(arg1);
		}
		public bool Bold() {
			return ProxyQFont().Bold();
		}
		public void SetBold(bool arg1) {
			ProxyQFont().SetBold(arg1);
		}
		public bool Italic() {
			return ProxyQFont().Italic();
		}
		public void SetItalic(bool arg1) {
			ProxyQFont().SetItalic(arg1);
		}
		public bool Underline() {
			return ProxyQFont().Underline();
		}
		public void SetUnderline(bool arg1) {
			ProxyQFont().SetUnderline(arg1);
		}
		public bool Overline() {
			return ProxyQFont().Overline();
		}
		public void SetOverline(bool arg1) {
			ProxyQFont().SetOverline(arg1);
		}
		public bool StrikeOut() {
			return ProxyQFont().StrikeOut();
		}
		public void SetStrikeOut(bool arg1) {
			ProxyQFont().SetStrikeOut(arg1);
		}
		public bool FixedPitch() {
			return ProxyQFont().FixedPitch();
		}
		public void SetFixedPitch(bool arg1) {
			ProxyQFont().SetFixedPitch(arg1);
		}
		public int StyleHint() {
			return ProxyQFont().StyleHint();
		}
		public int StyleStrategy() {
			return ProxyQFont().StyleStrategy();
		}
		public void SetStyleHint(int arg1, int arg2) {
			ProxyQFont().SetStyleHint(arg1,arg2);
		}
		public void SetStyleHint(int arg1) {
			ProxyQFont().SetStyleHint(arg1);
		}
		public void SetStyleStrategy(int s) {
			ProxyQFont().SetStyleStrategy(s);
		}
		public int Stretch() {
			return ProxyQFont().Stretch();
		}
		public void SetStretch(int arg1) {
			ProxyQFont().SetStretch(arg1);
		}
		public bool RawMode() {
			return ProxyQFont().RawMode();
		}
		public void SetRawMode(bool arg1) {
			ProxyQFont().SetRawMode(arg1);
		}
		public bool ExactMatch() {
			return ProxyQFont().ExactMatch();
		}
		public static bool operator==(QFont lhs, QFont arg1) {
			return StaticQFont().op_equals(lhs,arg1);
		}
		public static bool operator!=(QFont lhs, QFont arg1) {
			return !StaticQFont().op_equals(lhs,arg1);
		}
		public override bool Equals(object o) {
			if (!(o is QFont)) { return false; }
			return this == (QFont) o;
		}
		public override int GetHashCode() {
			return ProxyQFont().GetHashCode();
		}
		public bool IsCopyOf(QFont arg1) {
			return ProxyQFont().IsCopyOf(arg1);
		}
		public uint Handle() {
			return ProxyQFont().Handle();
		}
		public void SetRawName(string arg1) {
			ProxyQFont().SetRawName(arg1);
		}
		public string RawName() {
			return ProxyQFont().RawName();
		}
		public string Key() {
			return ProxyQFont().Key();
		}
		public new string ToString() {
			return ProxyQFont().ToString();
		}
		public bool FromString(string arg1) {
			return ProxyQFont().FromString(arg1);
		}
		public string DefaultFamily() {
			return ProxyQFont().DefaultFamily();
		}
		public string LastResortFamily() {
			return ProxyQFont().LastResortFamily();
		}
		public string LastResortFont() {
			return ProxyQFont().LastResortFont();
		}
		public QFont Resolve(QFont arg1) {
			return ProxyQFont().Resolve(arg1);
		}
		public static string Substitute(string arg1) {
			return StaticQFont().Substitute(arg1);
		}
		public static ArrayList Substitutes(string arg1) {
			return StaticQFont().Substitutes(arg1);
		}
		public static ArrayList Substitutions() {
			return StaticQFont().Substitutions();
		}
		public static void InsertSubstitution(string arg1, string arg2) {
			StaticQFont().InsertSubstitution(arg1,arg2);
		}
		public static void InsertSubstitutions(string arg1, string[] arg2) {
			StaticQFont().InsertSubstitutions(arg1,arg2);
		}
		public static void RemoveSubstitution(string arg1) {
			StaticQFont().RemoveSubstitution(arg1);
		}
		public static void Initialize() {
			StaticQFont().Initialize();
		}
		public static void Cleanup() {
			StaticQFont().Cleanup();
		}
		public static void CacheStatistics() {
			StaticQFont().CacheStatistics();
		}
		public static QFont DefaultFont() {
			return StaticQFont().DefaultFont();
		}
		public static void SetDefaultFont(QFont arg1) {
			StaticQFont().SetDefaultFont(arg1);
		}
		protected bool Dirty() {
			return ProxyQFont().Dirty();
		}
		protected int DeciPointSize() {
			return ProxyQFont().DeciPointSize();
		}
		~QFont() {
			ProxyQFont().Dispose();
		}
		public void Dispose() {
			ProxyQFont().Dispose();
		}
	}
}
