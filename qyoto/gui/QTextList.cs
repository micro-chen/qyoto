//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTextList")]
	public class QTextList : QTextBlockGroup, IDisposable {
 		protected QTextList(Type dummy) : base((Type) null) {}
		[SmokeClass("QTextList")]
		interface IQTextListProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextList), this);
			_interceptor = (QTextList) realProxy.GetTransparentProxy();
		}
		private QTextList ProxyQTextList() {
			return (QTextList) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextList() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextListProxy), null);
			_staticInterceptor = (IQTextListProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextListProxy StaticQTextList() {
			return (IQTextListProxy) _staticInterceptor;
		}
		public QTextList(QTextDocument doc) : this((Type) null) {
			CreateProxy();
			NewQTextList(doc);
		}
		[SmokeMethod("QTextList", "(QTextDocument*)", "#")]
		private void NewQTextList(QTextDocument doc) {
			ProxyQTextList().NewQTextList(doc);
		}
		[SmokeMethod("count", "() const", "")]
		public int Count() {
			return ProxyQTextList().Count();
		}
		[SmokeMethod("isEmpty", "() const", "")]
		public bool IsEmpty() {
			return ProxyQTextList().IsEmpty();
		}
		[SmokeMethod("item", "(int) const", "$")]
		public QTextBlock Item(int i) {
			return ProxyQTextList().Item(i);
		}
		[SmokeMethod("itemNumber", "(const QTextBlock&) const", "#")]
		public int ItemNumber(QTextBlock arg1) {
			return ProxyQTextList().ItemNumber(arg1);
		}
		[SmokeMethod("itemText", "(const QTextBlock&) const", "#")]
		public string ItemText(QTextBlock arg1) {
			return ProxyQTextList().ItemText(arg1);
		}
		[SmokeMethod("removeItem", "(int)", "$")]
		public void RemoveItem(int i) {
			ProxyQTextList().RemoveItem(i);
		}
		[SmokeMethod("remove", "(const QTextBlock&)", "#")]
		public void Remove(QTextBlock arg1) {
			ProxyQTextList().Remove(arg1);
		}
		[SmokeMethod("add", "(const QTextBlock&)", "#")]
		public void Add(QTextBlock block) {
			ProxyQTextList().Add(block);
		}
		[SmokeMethod("setFormat", "(const QTextListFormat&)", "#")]
		public new void SetFormat(QTextListFormat format) {
			ProxyQTextList().SetFormat(format);
		}
		[SmokeMethod("format", "() const", "")]
		public new QTextListFormat Format() {
			return ProxyQTextList().Format();
		}
		public static new string Tr(string s, string c) {
			return StaticQTextList().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQTextList().Tr(s);
		}
		~QTextList() {
			DisposeQTextList();
		}
		public new void Dispose() {
			DisposeQTextList();
		}
		[SmokeMethod("~QTextList", "()", "")]
		private void DisposeQTextList() {
			ProxyQTextList().DisposeQTextList();
		}
		protected new IQTextListSignals Emit {
			get {
				return (IQTextListSignals) Q_EMIT;
			}
		}
	}

	public interface IQTextListSignals : IQTextBlockGroupSignals {
	}
}
