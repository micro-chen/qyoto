//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QKeySequence")]
	public class QKeySequence : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QKeySequence(Type dummy) {}
		[SmokeClass("QKeySequence")]
		interface IQKeySequenceProxy {
			[SmokeMethod("operator==", "(const QKeySequence&) const", "#")]
			bool op_equals(QKeySequence lhs, QKeySequence other);
			[SmokeMethod("operator<", "(const QKeySequence&) const", "#")]
			bool op_lt(QKeySequence lhs, QKeySequence ks);
			[SmokeMethod("operator>", "(const QKeySequence&) const", "#")]
			bool op_gt(QKeySequence lhs, QKeySequence other);
			[SmokeMethod("operator<=", "(const QKeySequence&) const", "#")]
			bool op_lte(QKeySequence lhs, QKeySequence other);
			[SmokeMethod("operator>=", "(const QKeySequence&) const", "#")]
			bool op_gte(QKeySequence lhs, QKeySequence other);
			[SmokeMethod("fromString", "(const QString&, QKeySequence::SequenceFormat)", "$$")]
			QKeySequence FromString(string str, QKeySequence.SequenceFormat format);
			[SmokeMethod("fromString", "(const QString&)", "$")]
			QKeySequence FromString(string str);
			[SmokeMethod("mnemonic", "(const QString&)", "$")]
			QKeySequence Mnemonic(string text);
			[SmokeMethod("keyBindings", "(QKeySequence::StandardKey)", "$")]
			List<QKeySequence> KeyBindings(QKeySequence.StandardKey key);
		}
		protected new void CreateProxy() {
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
		public enum StandardKey {
			UnknownKey = 0,
			HelpContents = 1,
			WhatsThis = 2,
			Open = 3,
			Close = 4,
			Save = 5,
			New = 6,
			Delete = 7,
			Cut = 8,
			Copy = 9,
			Paste = 10,
			Undo = 11,
			Redo = 12,
			Back = 13,
			Forward = 14,
			Refresh = 15,
			ZoomIn = 16,
			ZoomOut = 17,
			Print = 18,
			AddTab = 19,
			NextChild = 20,
			PreviousChild = 21,
			Find = 22,
			FindNext = 23,
			FindPrevious = 24,
			Replace = 25,
			SelectAll = 26,
			Bold = 27,
			Italic = 28,
			Underline = 29,
			MoveToNextChar = 30,
			MoveToPreviousChar = 31,
			MoveToNextWord = 32,
			MoveToPreviousWord = 33,
			MoveToNextLine = 34,
			MoveToPreviousLine = 35,
			MoveToNextPage = 36,
			MoveToPreviousPage = 37,
			MoveToStartOfLine = 38,
			MoveToEndOfLine = 39,
			MoveToStartOfBlock = 40,
			MoveToEndOfBlock = 41,
			MoveToStartOfDocument = 42,
			MoveToEndOfDocument = 43,
			SelectNextChar = 44,
			SelectPreviousChar = 45,
			SelectNextWord = 46,
			SelectPreviousWord = 47,
			SelectNextLine = 48,
			SelectPreviousLine = 49,
			SelectNextPage = 50,
			SelectPreviousPage = 51,
			SelectStartOfLine = 52,
			SelectEndOfLine = 53,
			SelectStartOfBlock = 54,
			SelectEndOfBlock = 55,
			SelectStartOfDocument = 56,
			SelectEndOfDocument = 57,
			DeleteStartOfWord = 58,
			DeleteEndOfWord = 59,
			DeleteEndOfLine = 60,
		}
		public enum SequenceMatch {
			NoMatch = 0,
			PartialMatch = 1,
			ExactMatch = 2,
		}
		public enum SequenceFormat {
			NativeText = 0,
			PortableText = 1,
		}
		public QKeySequence() : this((Type) null) {
			CreateProxy();
			NewQKeySequence();
		}
		[SmokeMethod("QKeySequence", "()", "")]
		private void NewQKeySequence() {
			ProxyQKeySequence().NewQKeySequence();
		}
		public QKeySequence(string key) : this((Type) null) {
			CreateProxy();
			NewQKeySequence(key);
		}
		[SmokeMethod("QKeySequence", "(const QString&)", "$")]
		private void NewQKeySequence(string key) {
			ProxyQKeySequence().NewQKeySequence(key);
		}
		public QKeySequence(int k1, int k2, int k3, int k4) : this((Type) null) {
			CreateProxy();
			NewQKeySequence(k1,k2,k3,k4);
		}
		[SmokeMethod("QKeySequence", "(int, int, int, int)", "$$$$")]
		private void NewQKeySequence(int k1, int k2, int k3, int k4) {
			ProxyQKeySequence().NewQKeySequence(k1,k2,k3,k4);
		}
		public QKeySequence(int k1, int k2, int k3) : this((Type) null) {
			CreateProxy();
			NewQKeySequence(k1,k2,k3);
		}
		[SmokeMethod("QKeySequence", "(int, int, int)", "$$$")]
		private void NewQKeySequence(int k1, int k2, int k3) {
			ProxyQKeySequence().NewQKeySequence(k1,k2,k3);
		}
		public QKeySequence(int k1, int k2) : this((Type) null) {
			CreateProxy();
			NewQKeySequence(k1,k2);
		}
		[SmokeMethod("QKeySequence", "(int, int)", "$$")]
		private void NewQKeySequence(int k1, int k2) {
			ProxyQKeySequence().NewQKeySequence(k1,k2);
		}
		public QKeySequence(int k1) : this((Type) null) {
			CreateProxy();
			NewQKeySequence(k1);
		}
		[SmokeMethod("QKeySequence", "(int)", "$")]
		private void NewQKeySequence(int k1) {
			ProxyQKeySequence().NewQKeySequence(k1);
		}
		public QKeySequence(QKeySequence ks) : this((Type) null) {
			CreateProxy();
			NewQKeySequence(ks);
		}
		[SmokeMethod("QKeySequence", "(const QKeySequence&)", "#")]
		private void NewQKeySequence(QKeySequence ks) {
			ProxyQKeySequence().NewQKeySequence(ks);
		}
		public QKeySequence(QKeySequence.StandardKey key) : this((Type) null) {
			CreateProxy();
			NewQKeySequence(key);
		}
		[SmokeMethod("QKeySequence", "(QKeySequence::StandardKey)", "$")]
		private void NewQKeySequence(QKeySequence.StandardKey key) {
			ProxyQKeySequence().NewQKeySequence(key);
		}
		[SmokeMethod("count", "() const", "")]
		public uint Count() {
			return ProxyQKeySequence().Count();
		}
		[SmokeMethod("isEmpty", "() const", "")]
		public bool IsEmpty() {
			return ProxyQKeySequence().IsEmpty();
		}
		[SmokeMethod("toString", "(QKeySequence::SequenceFormat) const", "$")]
		public new string ToString(QKeySequence.SequenceFormat format) {
			return ProxyQKeySequence().ToString(format);
		}
		[SmokeMethod("toString", "() const", "")]
		public new string ToString() {
			return ProxyQKeySequence().ToString();
		}
		[SmokeMethod("matches", "(const QKeySequence&) const", "#")]
		public QKeySequence.SequenceMatch Matches(QKeySequence seq) {
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
		[SmokeMethod("isDetached", "() const", "")]
		public bool IsDetached() {
			return ProxyQKeySequence().IsDetached();
		}
		public static QKeySequence FromString(string str, QKeySequence.SequenceFormat format) {
			return StaticQKeySequence().FromString(str,format);
		}
		public static QKeySequence FromString(string str) {
			return StaticQKeySequence().FromString(str);
		}
		public static QKeySequence Mnemonic(string text) {
			return StaticQKeySequence().Mnemonic(text);
		}
		public static List<QKeySequence> KeyBindings(QKeySequence.StandardKey key) {
			return StaticQKeySequence().KeyBindings(key);
		}
		~QKeySequence() {
			DisposeQKeySequence();
		}
		public void Dispose() {
			DisposeQKeySequence();
		}
		[SmokeMethod("~QKeySequence", "()", "")]
		private void DisposeQKeySequence() {
			ProxyQKeySequence().DisposeQKeySequence();
		}
	}
}
