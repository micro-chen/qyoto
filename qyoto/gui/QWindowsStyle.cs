//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QWindowsStyle")]
	public class QWindowsStyle : QCommonStyle, IDisposable {
 		protected QWindowsStyle(Type dummy) : base((Type) null) {}
		[SmokeClass("QWindowsStyle")]
		interface IQWindowsStyleProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QWindowsStyle), this);
			_interceptor = (QWindowsStyle) realProxy.GetTransparentProxy();
		}
		private QWindowsStyle ProxyQWindowsStyle() {
			return (QWindowsStyle) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QWindowsStyle() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQWindowsStyleProxy), null);
			_staticInterceptor = (IQWindowsStyleProxy) realProxy.GetTransparentProxy();
		}
		private static IQWindowsStyleProxy StaticQWindowsStyle() {
			return (IQWindowsStyleProxy) _staticInterceptor;
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QWindowsStyle() : this((Type) null) {
			CreateProxy();
			NewQWindowsStyle();
		}
		[SmokeMethod("QWindowsStyle", "()", "")]
		private void NewQWindowsStyle() {
			ProxyQWindowsStyle().NewQWindowsStyle();
		}
		[SmokeMethod("polish", "(QApplication*)", "#")]
		public new void Polish(QApplication arg1) {
			ProxyQWindowsStyle().Polish(arg1);
		}
		[SmokeMethod("unpolish", "(QApplication*)", "#")]
		public new void Unpolish(QApplication arg1) {
			ProxyQWindowsStyle().Unpolish(arg1);
		}
		[SmokeMethod("polish", "(QWidget*)", "#")]
		public new void Polish(QWidget arg1) {
			ProxyQWindowsStyle().Polish(arg1);
		}
		[SmokeMethod("unpolish", "(QWidget*)", "#")]
		public new void Unpolish(QWidget arg1) {
			ProxyQWindowsStyle().Unpolish(arg1);
		}
		[SmokeMethod("polish", "(QPalette&)", "#")]
		public new void Polish(QPalette arg1) {
			ProxyQWindowsStyle().Polish(arg1);
		}
		[SmokeMethod("drawPrimitive", "(QStyle::PrimitiveElement, const QStyleOption*, QPainter*, const QWidget*) const", "$###")]
		public new void DrawPrimitive(QStyle.PrimitiveElement pe, out int opt, QPainter p, QWidget w) {
			ProxyQWindowsStyle().DrawPrimitive(pe,out opt,p,w);
		}
		[SmokeMethod("drawPrimitive", "(QStyle::PrimitiveElement, const QStyleOption*, QPainter*) const", "$##")]
		public new void DrawPrimitive(QStyle.PrimitiveElement pe, out int opt, QPainter p) {
			ProxyQWindowsStyle().DrawPrimitive(pe,out opt,p);
		}
		[SmokeMethod("drawControl", "(QStyle::ControlElement, const QStyleOption*, QPainter*, const QWidget*) const", "$###")]
		public new void DrawControl(QStyle.ControlElement element, out int opt, QPainter p, QWidget w) {
			ProxyQWindowsStyle().DrawControl(element,out opt,p,w);
		}
		[SmokeMethod("drawControl", "(QStyle::ControlElement, const QStyleOption*, QPainter*) const", "$##")]
		public new void DrawControl(QStyle.ControlElement element, out int opt, QPainter p) {
			ProxyQWindowsStyle().DrawControl(element,out opt,p);
		}
		[SmokeMethod("subElementRect", "(QStyle::SubElement, const QStyleOption*, const QWidget*) const", "$##")]
		public new QRect SubElementRect(QStyle.SubElement r, out int opt, QWidget widget) {
			return ProxyQWindowsStyle().SubElementRect(r,out opt,widget);
		}
		[SmokeMethod("subElementRect", "(QStyle::SubElement, const QStyleOption*) const", "$#")]
		public new QRect SubElementRect(QStyle.SubElement r, out int opt) {
			return ProxyQWindowsStyle().SubElementRect(r,out opt);
		}
		[SmokeMethod("drawComplexControl", "(QStyle::ComplexControl, const QStyleOptionComplex*, QPainter*, const QWidget*) const", "$###")]
		public new void DrawComplexControl(QStyle.ComplexControl cc, QStyleOptionComplex opt, QPainter p, QWidget w) {
			ProxyQWindowsStyle().DrawComplexControl(cc,opt,p,w);
		}
		[SmokeMethod("drawComplexControl", "(QStyle::ComplexControl, const QStyleOptionComplex*, QPainter*) const", "$##")]
		public new void DrawComplexControl(QStyle.ComplexControl cc, QStyleOptionComplex opt, QPainter p) {
			ProxyQWindowsStyle().DrawComplexControl(cc,opt,p);
		}
		[SmokeMethod("sizeFromContents", "(QStyle::ContentsType, const QStyleOption*, const QSize&, const QWidget*) const", "$###")]
		public new QSize SizeFromContents(QStyle.ContentsType ct, out int opt, QSize contentsSize, QWidget widget) {
			return ProxyQWindowsStyle().SizeFromContents(ct,out opt,contentsSize,widget);
		}
		[SmokeMethod("sizeFromContents", "(QStyle::ContentsType, const QStyleOption*, const QSize&) const", "$##")]
		public new QSize SizeFromContents(QStyle.ContentsType ct, out int opt, QSize contentsSize) {
			return ProxyQWindowsStyle().SizeFromContents(ct,out opt,contentsSize);
		}
		[SmokeMethod("pixelMetric", "(QStyle::PixelMetric, const QStyleOption*, const QWidget*) const", "$##")]
		public new int PixelMetric(QStyle.PixelMetric pm, out int option, QWidget widget) {
			return ProxyQWindowsStyle().PixelMetric(pm,out option,widget);
		}
		[SmokeMethod("pixelMetric", "(QStyle::PixelMetric, const QStyleOption*) const", "$#")]
		public new int PixelMetric(QStyle.PixelMetric pm, out int option) {
			return ProxyQWindowsStyle().PixelMetric(pm,out option);
		}
		[SmokeMethod("pixelMetric", "(QStyle::PixelMetric) const", "$")]
		public new int PixelMetric(QStyle.PixelMetric pm) {
			return ProxyQWindowsStyle().PixelMetric(pm);
		}
		[SmokeMethod("styleHint", "(QStyle::StyleHint, const QStyleOption*, const QWidget*, QStyleHintReturn*) const", "$###")]
		public new int StyleHint(QStyle.StyleHint hint, out int opt, QWidget widget, QStyleHintReturn returnData) {
			return ProxyQWindowsStyle().StyleHint(hint,out opt,widget,returnData);
		}
		[SmokeMethod("styleHint", "(QStyle::StyleHint, const QStyleOption*, const QWidget*) const", "$##")]
		public new int StyleHint(QStyle.StyleHint hint, out int opt, QWidget widget) {
			return ProxyQWindowsStyle().StyleHint(hint,out opt,widget);
		}
		[SmokeMethod("styleHint", "(QStyle::StyleHint, const QStyleOption*) const", "$#")]
		public new int StyleHint(QStyle.StyleHint hint, out int opt) {
			return ProxyQWindowsStyle().StyleHint(hint,out opt);
		}
		[SmokeMethod("styleHint", "(QStyle::StyleHint) const", "$")]
		public new int StyleHint(QStyle.StyleHint hint) {
			return ProxyQWindowsStyle().StyleHint(hint);
		}
		[SmokeMethod("standardPixmap", "(QStyle::StandardPixmap, const QStyleOption*, const QWidget*) const", "$##")]
		public new QPixmap StandardPixmap(QStyle.StandardPixmap standardPixmap, out int opt, QWidget widget) {
			return ProxyQWindowsStyle().StandardPixmap(standardPixmap,out opt,widget);
		}
		[SmokeMethod("standardPixmap", "(QStyle::StandardPixmap, const QStyleOption*) const", "$#")]
		public new QPixmap StandardPixmap(QStyle.StandardPixmap standardPixmap, out int opt) {
			return ProxyQWindowsStyle().StandardPixmap(standardPixmap,out opt);
		}
		public static new string Tr(string s, string c) {
			return StaticQWindowsStyle().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQWindowsStyle().Tr(s);
		}
		[SmokeMethod("eventFilter", "(QObject*, QEvent*)", "##")]
		public new bool EventFilter(QObject o, QEvent e) {
			return ProxyQWindowsStyle().EventFilter(o,e);
		}
		[SmokeMethod("timerEvent", "(QTimerEvent*)", "#")]
		protected new void TimerEvent(QTimerEvent arg1) {
			ProxyQWindowsStyle().TimerEvent(arg1);
		}
		// QWindowsStyle* QWindowsStyle(QWindowsStylePrivate& arg1); >>>> NOT CONVERTED
		[Q_SLOT("QIcon standardIconImplementation(QStyle::StandardPixmap, const QStyleOption*, const QWidget*) const")]
		[SmokeMethod("standardIconImplementation", "(QStyle::StandardPixmap, const QStyleOption*, const QWidget*) const", "$##")]
		protected new QIcon StandardIconImplementation(QStyle.StandardPixmap standardIcon, out int option, QWidget widget) {
			return ProxyQWindowsStyle().StandardIconImplementation(standardIcon,out option,widget);
		}
		[Q_SLOT("QIcon standardIconImplementation(QStyle::StandardPixmap, const QStyleOption*) const")]
		[SmokeMethod("standardIconImplementation", "(QStyle::StandardPixmap, const QStyleOption*) const", "$#")]
		protected new QIcon StandardIconImplementation(QStyle.StandardPixmap standardIcon, out int option) {
			return ProxyQWindowsStyle().StandardIconImplementation(standardIcon,out option);
		}
		~QWindowsStyle() {
			DisposeQWindowsStyle();
		}
		public new void Dispose() {
			DisposeQWindowsStyle();
		}
		[SmokeMethod("~QWindowsStyle", "()", "")]
		private void DisposeQWindowsStyle() {
			ProxyQWindowsStyle().DisposeQWindowsStyle();
		}
		protected new IQWindowsStyleSignals Emit {
			get {
				return (IQWindowsStyleSignals) Q_EMIT;
			}
		}
	}

	public interface IQWindowsStyleSignals : IQCommonStyleSignals {
	}
}
