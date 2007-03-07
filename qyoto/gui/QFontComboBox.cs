//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQFontComboBoxSignals"></see> for signals emitted by QFontComboBox
	[SmokeClass("QFontComboBox")]
	public class QFontComboBox : QComboBox, IDisposable {
 		protected QFontComboBox(Type dummy) : base((Type) null) {}
		[SmokeClass("QFontComboBox")]
		interface IQFontComboBoxProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFontComboBox), this);
			_interceptor = (QFontComboBox) realProxy.GetTransparentProxy();
		}
		private QFontComboBox ProxyQFontComboBox() {
			return (QFontComboBox) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFontComboBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFontComboBoxProxy), null);
			_staticInterceptor = (IQFontComboBoxProxy) realProxy.GetTransparentProxy();
		}
		private static IQFontComboBoxProxy StaticQFontComboBox() {
			return (IQFontComboBoxProxy) _staticInterceptor;
		}
		public enum FontFilter {
			AllFonts = 0,
			ScalableFonts = 0x1,
			NonScalableFonts = 0x2,
			MonospacedFonts = 0x4,
			ProportionalFonts = 0x8,
		}
		[Q_PROPERTY("QFontDatabase::WritingSystem", "writingSystem")]
		public QFontDatabase.WritingSystem WritingSystem {
			get {
				return Property("writingSystem").Value<QFontDatabase.WritingSystem>();
			}
			set {
				SetProperty("writingSystem", QVariant.FromValue<QFontDatabase.WritingSystem>(value));
			}
		}
		[Q_PROPERTY("FontFilters", "fontFilters")]
		public int FontFilters {
			get {
				return Property("fontFilters").Value<int>();
			}
			set {
				SetProperty("fontFilters", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("QFont", "currentFont")]
		public QFont CurrentFont {
			get {
				return Property("currentFont").Value<QFont>();
			}
			set {
				SetProperty("currentFont", QVariant.FromValue<QFont>(value));
			}
		}
		public QFontComboBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQFontComboBox(parent);
		}
		[SmokeMethod("QFontComboBox", "(QWidget*)", "#")]
		private void NewQFontComboBox(QWidget parent) {
			ProxyQFontComboBox().NewQFontComboBox(parent);
		}
		public QFontComboBox() : this((Type) null) {
			CreateProxy();
			NewQFontComboBox();
		}
		[SmokeMethod("QFontComboBox", "()", "")]
		private void NewQFontComboBox() {
			ProxyQFontComboBox().NewQFontComboBox();
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public new QSize SizeHint() {
			return ProxyQFontComboBox().SizeHint();
		}
		public static new string Tr(string s, string c) {
			return StaticQFontComboBox().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQFontComboBox().Tr(s);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public new bool Event(QEvent e) {
			return ProxyQFontComboBox().Event(e);
		}
		~QFontComboBox() {
			DisposeQFontComboBox();
		}
		public new void Dispose() {
			DisposeQFontComboBox();
		}
		[SmokeMethod("~QFontComboBox", "()", "")]
		private void DisposeQFontComboBox() {
			ProxyQFontComboBox().DisposeQFontComboBox();
		}
		protected new IQFontComboBoxSignals Emit {
			get {
				return (IQFontComboBoxSignals) Q_EMIT;
			}
		}
	}

	public interface IQFontComboBoxSignals : IQComboBoxSignals {
		[Q_SIGNAL("void currentFontChanged(const QFont&)")]
		void CurrentFontChanged(QFont f);
	}
}
