//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTranslator")]
	public class QTranslator : QObject, IDisposable {
 		protected QTranslator(Type dummy) : base((Type) null) {}
		[SmokeClass("QTranslator")]
		interface IQTranslatorProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTranslator), this);
			_interceptor = (QTranslator) realProxy.GetTransparentProxy();
		}
		private QTranslator ProxyQTranslator() {
			return (QTranslator) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTranslator() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTranslatorProxy), null);
			_staticInterceptor = (IQTranslatorProxy) realProxy.GetTransparentProxy();
		}
		private static IQTranslatorProxy StaticQTranslator() {
			return (IQTranslatorProxy) _staticInterceptor;
		}
		public QTranslator(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQTranslator(parent);
		}
		[SmokeMethod("QTranslator", "(QObject*)", "#")]
		private void NewQTranslator(QObject parent) {
			ProxyQTranslator().NewQTranslator(parent);
		}
		public QTranslator() : this((Type) null) {
			CreateProxy();
			NewQTranslator();
		}
		[SmokeMethod("QTranslator", "()", "")]
		private void NewQTranslator() {
			ProxyQTranslator().NewQTranslator();
		}
		[SmokeMethod("translate", "(const char*, const char*, const char*) const", "$$$")]
		public virtual string Translate(string context, string sourceText, string comment) {
			return ProxyQTranslator().Translate(context,sourceText,comment);
		}
		[SmokeMethod("translate", "(const char*, const char*) const", "$$")]
		public virtual string Translate(string context, string sourceText) {
			return ProxyQTranslator().Translate(context,sourceText);
		}
		[SmokeMethod("translate", "(const char*, const char*, const char*, int) const", "$$$$")]
		public string Translate(string context, string sourceText, string comment, int n) {
			return ProxyQTranslator().Translate(context,sourceText,comment,n);
		}
		[SmokeMethod("isEmpty", "() const", "")]
		public virtual bool IsEmpty() {
			return ProxyQTranslator().IsEmpty();
		}
		[SmokeMethod("load", "(const QString&, const QString&, const QString&, const QString&)", "$$$$")]
		public bool Load(string filename, string directory, string search_delimiters, string suffix) {
			return ProxyQTranslator().Load(filename,directory,search_delimiters,suffix);
		}
		[SmokeMethod("load", "(const QString&, const QString&, const QString&)", "$$$")]
		public bool Load(string filename, string directory, string search_delimiters) {
			return ProxyQTranslator().Load(filename,directory,search_delimiters);
		}
		[SmokeMethod("load", "(const QString&, const QString&)", "$$")]
		public bool Load(string filename, string directory) {
			return ProxyQTranslator().Load(filename,directory);
		}
		[SmokeMethod("load", "(const QString&)", "$")]
		public bool Load(string filename) {
			return ProxyQTranslator().Load(filename);
		}
		[SmokeMethod("load", "(const uchar*, int)", "$$")]
		public bool Load(char[] data, int len) {
			return ProxyQTranslator().Load(data,len);
		}
		public static new string Tr(string s, string c) {
			return StaticQTranslator().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQTranslator().Tr(s);
		}
		~QTranslator() {
			DisposeQTranslator();
		}
		public new void Dispose() {
			DisposeQTranslator();
		}
		[SmokeMethod("~QTranslator", "()", "")]
		private void DisposeQTranslator() {
			ProxyQTranslator().DisposeQTranslator();
		}
		protected new IQTranslatorSignals Emit {
			get {
				return (IQTranslatorSignals) Q_EMIT;
			}
		}
	}

	public interface IQTranslatorSignals : IQObjectSignals {
	}
}
