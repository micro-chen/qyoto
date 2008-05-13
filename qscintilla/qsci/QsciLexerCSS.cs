//Auto-generated by kalyptus. DO NOT EDIT.
namespace QScintilla {

	using System;
	using Qyoto;
	using System.Runtime.InteropServices;

	[SmokeClass("QsciLexerCSS")]
	public class QsciLexerCSS : QsciLexer, IDisposable {
 		protected QsciLexerCSS(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationQsci(typeof(QsciLexerCSS), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QsciLexerCSS() {
			staticInterceptor = new SmokeInvocationQsci(typeof(QsciLexerCSS), null);
		}
		public const int Default = 0;
		public const int Tag = 1;
		public const int ClassSelector = 2;
		public const int PseudoClass = 3;
		public const int UnknownPseudoClass = 4;
		public const int Operator = 5;
		public const int CSS1Property = 6;
		public const int UnknownProperty = 7;
		public const int Value = 8;
		public const int Comment = 9;
		public const int IDSelector = 10;
		public const int Important = 11;
		public const int AtRule = 12;
		public const int DoubleQuotedString = 13;
		public const int SingleQuotedString = 14;
		public const int CSS2Property = 15;
		public const int Attribute = 16;

		public QsciLexerCSS(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QsciLexerCSS#", "QsciLexerCSS(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QsciLexerCSS() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QsciLexerCSS", "QsciLexerCSS()", typeof(void));
		}
		[SmokeMethod("language() const")]
		public override string Language() {
			return (string) interceptor.Invoke("language", "language() const", typeof(string));
		}
		[SmokeMethod("lexer() const")]
		public override string Lexer() {
			return (string) interceptor.Invoke("lexer", "lexer() const", typeof(string));
		}
		[SmokeMethod("blockEnd(int*) const")]
		public override string BlockEnd(ref int style) {
			StackItem[] stack = new StackItem[2];
			stack[1].s_int = style;
			interceptor.Invoke("blockEnd$", "blockEnd(int*) const", stack);
			style = stack[1].s_int;
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (string) returnValue;
		}
		[SmokeMethod("blockEnd() const")]
		public override string BlockEnd() {
			return (string) interceptor.Invoke("blockEnd", "blockEnd() const", typeof(string));
		}
		[SmokeMethod("blockStart(int*) const")]
		public override string BlockStart(ref int style) {
			StackItem[] stack = new StackItem[2];
			stack[1].s_int = style;
			interceptor.Invoke("blockStart$", "blockStart(int*) const", stack);
			style = stack[1].s_int;
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (string) returnValue;
		}
		[SmokeMethod("blockStart() const")]
		public override string BlockStart() {
			return (string) interceptor.Invoke("blockStart", "blockStart() const", typeof(string));
		}
		[SmokeMethod("wordCharacters() const")]
		public override string WordCharacters() {
			return (string) interceptor.Invoke("wordCharacters", "wordCharacters() const", typeof(string));
		}
		[SmokeMethod("defaultColor(int) const")]
		public override QColor DefaultColor(int style) {
			return (QColor) interceptor.Invoke("defaultColor$", "defaultColor(int) const", typeof(QColor), typeof(int), style);
		}
		[SmokeMethod("defaultFont(int) const")]
		public override QFont DefaultFont(int style) {
			return (QFont) interceptor.Invoke("defaultFont$", "defaultFont(int) const", typeof(QFont), typeof(int), style);
		}
		[SmokeMethod("keywords(int) const")]
		public override string Keywords(int set) {
			return (string) interceptor.Invoke("keywords$", "keywords(int) const", typeof(string), typeof(int), set);
		}
		[SmokeMethod("description(int) const")]
		public override string Description(int style) {
			return (string) interceptor.Invoke("description$", "description(int) const", typeof(string), typeof(int), style);
		}
		[SmokeMethod("refreshProperties()")]
		public override void RefreshProperties() {
			interceptor.Invoke("refreshProperties", "refreshProperties()", typeof(void));
		}
		public bool FoldComments() {
			return (bool) interceptor.Invoke("foldComments", "foldComments() const", typeof(bool));
		}
		public bool FoldCompact() {
			return (bool) interceptor.Invoke("foldCompact", "foldCompact() const", typeof(bool));
		}
		[Q_SLOT("void setFoldComments(bool)")]
		[SmokeMethod("setFoldComments(bool)")]
		public virtual void SetFoldComments(bool fold) {
			interceptor.Invoke("setFoldComments$", "setFoldComments(bool)", typeof(void), typeof(bool), fold);
		}
		[Q_SLOT("void setFoldCompact(bool)")]
		[SmokeMethod("setFoldCompact(bool)")]
		public virtual void SetFoldCompact(bool fold) {
			interceptor.Invoke("setFoldCompact$", "setFoldCompact(bool)", typeof(void), typeof(bool), fold);
		}
		[SmokeMethod("readProperties(QSettings&, const QString&)")]
		protected override bool ReadProperties(QSettings qs, string prefix) {
			return (bool) interceptor.Invoke("readProperties#$", "readProperties(QSettings&, const QString&)", typeof(bool), typeof(QSettings), qs, typeof(string), prefix);
		}
		[SmokeMethod("writeProperties(QSettings&, const QString&) const")]
		protected override bool WriteProperties(QSettings qs, string prefix) {
			return (bool) interceptor.Invoke("writeProperties#$", "writeProperties(QSettings&, const QString&) const", typeof(bool), typeof(QSettings), qs, typeof(string), prefix);
		}
		~QsciLexerCSS() {
			interceptor.Invoke("~QsciLexerCSS", "~QsciLexerCSS()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QsciLexerCSS", "~QsciLexerCSS()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQsciLexerCSSSignals Emit {
			get { return (IQsciLexerCSSSignals) Q_EMIT; }
		}
	}

	public interface IQsciLexerCSSSignals : IQsciLexerSignals {
	}
}