//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQStackedWidgetSignals"></see> for signals emitted by QStackedWidget
	[SmokeClass("QStackedWidget")]
	public class QStackedWidget : QFrame, IDisposable {
 		protected QStackedWidget(Type dummy) : base((Type) null) {}
		[SmokeClass("QStackedWidget")]
		interface IQStackedWidgetProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStackedWidget), this);
			_interceptor = (QStackedWidget) realProxy.GetTransparentProxy();
		}
		private QStackedWidget ProxyQStackedWidget() {
			return (QStackedWidget) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStackedWidget() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStackedWidgetProxy), null);
			_staticInterceptor = (IQStackedWidgetProxy) realProxy.GetTransparentProxy();
		}
		private static IQStackedWidgetProxy StaticQStackedWidget() {
			return (IQStackedWidgetProxy) _staticInterceptor;
		}
		[Q_PROPERTY("int", "currentIndex")]
		public int CurrentIndex {
			get {
				return Property("currentIndex").Value<int>();
			}
			set {
				SetProperty("currentIndex", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("int", "count")]
		public int Count {
			get {
				return Property("count").Value<int>();
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QStackedWidget(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQStackedWidget(parent);
		}
		[SmokeMethod("QStackedWidget", "(QWidget*)", "#")]
		private void NewQStackedWidget(QWidget parent) {
			ProxyQStackedWidget().NewQStackedWidget(parent);
		}
		public QStackedWidget() : this((Type) null) {
			CreateProxy();
			NewQStackedWidget();
		}
		[SmokeMethod("QStackedWidget", "()", "")]
		private void NewQStackedWidget() {
			ProxyQStackedWidget().NewQStackedWidget();
		}
		[SmokeMethod("addWidget", "(QWidget*)", "#")]
		public int AddWidget(QWidget w) {
			return ProxyQStackedWidget().AddWidget(w);
		}
		[SmokeMethod("insertWidget", "(int, QWidget*)", "$#")]
		public int InsertWidget(int index, QWidget w) {
			return ProxyQStackedWidget().InsertWidget(index,w);
		}
		[SmokeMethod("removeWidget", "(QWidget*)", "#")]
		public void RemoveWidget(QWidget w) {
			ProxyQStackedWidget().RemoveWidget(w);
		}
		[SmokeMethod("currentWidget", "() const", "")]
		public QWidget CurrentWidget() {
			return ProxyQStackedWidget().CurrentWidget();
		}
		[SmokeMethod("indexOf", "(QWidget*) const", "#")]
		public int IndexOf(QWidget arg1) {
			return ProxyQStackedWidget().IndexOf(arg1);
		}
		[SmokeMethod("widget", "(int) const", "$")]
		public QWidget Widget(int arg1) {
			return ProxyQStackedWidget().Widget(arg1);
		}
		[Q_SLOT("void setCurrentWidget(QWidget*)")]
		[SmokeMethod("setCurrentWidget", "(QWidget*)", "#")]
		public void SetCurrentWidget(QWidget w) {
			ProxyQStackedWidget().SetCurrentWidget(w);
		}
		public static new string Tr(string s, string c) {
			return StaticQStackedWidget().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQStackedWidget().Tr(s);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public new bool Event(QEvent e) {
			return ProxyQStackedWidget().Event(e);
		}
		~QStackedWidget() {
			DisposeQStackedWidget();
		}
		public new void Dispose() {
			DisposeQStackedWidget();
		}
		[SmokeMethod("~QStackedWidget", "()", "")]
		private void DisposeQStackedWidget() {
			ProxyQStackedWidget().DisposeQStackedWidget();
		}
		protected new IQStackedWidgetSignals Emit {
			get {
				return (IQStackedWidgetSignals) Q_EMIT;
			}
		}
	}

	public interface IQStackedWidgetSignals : IQFrameSignals {
		[Q_SIGNAL("void currentChanged(int)")]
		void CurrentChanged(int arg1);
		[Q_SIGNAL("void widgetRemoved(int)")]
		void WidgetRemoved(int index);
	}
}
