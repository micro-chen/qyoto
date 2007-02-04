//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QCommonStyle")]
	public class QCommonStyle : QStyle, IDisposable {
 		protected QCommonStyle(Type dummy) : base((Type) null) {}
		[SmokeClass("QCommonStyle")]
		interface IQCommonStyleProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QCommonStyle), this);
			_interceptor = (QCommonStyle) realProxy.GetTransparentProxy();
		}
		private QCommonStyle ProxyQCommonStyle() {
			return (QCommonStyle) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QCommonStyle() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCommonStyleProxy), null);
			_staticInterceptor = (IQCommonStyleProxy) realProxy.GetTransparentProxy();
		}
		private static IQCommonStyleProxy StaticQCommonStyle() {
			return (IQCommonStyleProxy) _staticInterceptor;
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QCommonStyle() : this((Type) null) {
			CreateProxy();
			NewQCommonStyle();
		}
		[SmokeMethod("QCommonStyle", "()", "")]
		private void NewQCommonStyle() {
			ProxyQCommonStyle().NewQCommonStyle();
		}
		[SmokeMethod("drawPrimitive", "(QStyle::PrimitiveElement, const QStyleOption*, QPainter*, const QWidget*) const", "$###")]
		public new void DrawPrimitive(QStyle.PrimitiveElement pe, out int opt, QPainter p, QWidget w) {
			ProxyQCommonStyle().DrawPrimitive(pe,out opt,p,w);
		}
		[SmokeMethod("drawPrimitive", "(QStyle::PrimitiveElement, const QStyleOption*, QPainter*) const", "$##")]
		public new void DrawPrimitive(QStyle.PrimitiveElement pe, out int opt, QPainter p) {
			ProxyQCommonStyle().DrawPrimitive(pe,out opt,p);
		}
		[SmokeMethod("drawControl", "(QStyle::ControlElement, const QStyleOption*, QPainter*, const QWidget*) const", "$###")]
		public new void DrawControl(QStyle.ControlElement element, out int opt, QPainter p, QWidget w) {
			ProxyQCommonStyle().DrawControl(element,out opt,p,w);
		}
		[SmokeMethod("drawControl", "(QStyle::ControlElement, const QStyleOption*, QPainter*) const", "$##")]
		public new void DrawControl(QStyle.ControlElement element, out int opt, QPainter p) {
			ProxyQCommonStyle().DrawControl(element,out opt,p);
		}
		[SmokeMethod("subElementRect", "(QStyle::SubElement, const QStyleOption*, const QWidget*) const", "$##")]
		public new QRect SubElementRect(QStyle.SubElement r, out int opt, QWidget widget) {
			return ProxyQCommonStyle().SubElementRect(r,out opt,widget);
		}
		[SmokeMethod("subElementRect", "(QStyle::SubElement, const QStyleOption*) const", "$#")]
		public new QRect SubElementRect(QStyle.SubElement r, out int opt) {
			return ProxyQCommonStyle().SubElementRect(r,out opt);
		}
		[SmokeMethod("drawComplexControl", "(QStyle::ComplexControl, const QStyleOptionComplex*, QPainter*, const QWidget*) const", "$###")]
		public new void DrawComplexControl(QStyle.ComplexControl cc, QStyleOptionComplex opt, QPainter p, QWidget w) {
			ProxyQCommonStyle().DrawComplexControl(cc,opt,p,w);
		}
		[SmokeMethod("drawComplexControl", "(QStyle::ComplexControl, const QStyleOptionComplex*, QPainter*) const", "$##")]
		public new void DrawComplexControl(QStyle.ComplexControl cc, QStyleOptionComplex opt, QPainter p) {
			ProxyQCommonStyle().DrawComplexControl(cc,opt,p);
		}
		[SmokeMethod("hitTestComplexControl", "(QStyle::ComplexControl, const QStyleOptionComplex*, const QPoint&, const QWidget*) const", "$###")]
		public new QStyle.SubControl HitTestComplexControl(QStyle.ComplexControl cc, QStyleOptionComplex opt, QPoint pt, QWidget w) {
			return ProxyQCommonStyle().HitTestComplexControl(cc,opt,pt,w);
		}
		[SmokeMethod("hitTestComplexControl", "(QStyle::ComplexControl, const QStyleOptionComplex*, const QPoint&) const", "$##")]
		public new QStyle.SubControl HitTestComplexControl(QStyle.ComplexControl cc, QStyleOptionComplex opt, QPoint pt) {
			return ProxyQCommonStyle().HitTestComplexControl(cc,opt,pt);
		}
		[SmokeMethod("subControlRect", "(QStyle::ComplexControl, const QStyleOptionComplex*, QStyle::SubControl, const QWidget*) const", "$#$#")]
		public new QRect SubControlRect(QStyle.ComplexControl cc, QStyleOptionComplex opt, QStyle.SubControl sc, QWidget w) {
			return ProxyQCommonStyle().SubControlRect(cc,opt,sc,w);
		}
		[SmokeMethod("subControlRect", "(QStyle::ComplexControl, const QStyleOptionComplex*, QStyle::SubControl) const", "$#$")]
		public new QRect SubControlRect(QStyle.ComplexControl cc, QStyleOptionComplex opt, QStyle.SubControl sc) {
			return ProxyQCommonStyle().SubControlRect(cc,opt,sc);
		}
		[SmokeMethod("sizeFromContents", "(QStyle::ContentsType, const QStyleOption*, const QSize&, const QWidget*) const", "$###")]
		public new QSize SizeFromContents(QStyle.ContentsType ct, out int opt, QSize contentsSize, QWidget widget) {
			return ProxyQCommonStyle().SizeFromContents(ct,out opt,contentsSize,widget);
		}
		[SmokeMethod("sizeFromContents", "(QStyle::ContentsType, const QStyleOption*, const QSize&) const", "$##")]
		public new QSize SizeFromContents(QStyle.ContentsType ct, out int opt, QSize contentsSize) {
			return ProxyQCommonStyle().SizeFromContents(ct,out opt,contentsSize);
		}
		[SmokeMethod("pixelMetric", "(QStyle::PixelMetric, const QStyleOption*, const QWidget*) const", "$##")]
		public new int PixelMetric(QStyle.PixelMetric m, out int opt, QWidget widget) {
			return ProxyQCommonStyle().PixelMetric(m,out opt,widget);
		}
		[SmokeMethod("pixelMetric", "(QStyle::PixelMetric, const QStyleOption*) const", "$#")]
		public new int PixelMetric(QStyle.PixelMetric m, out int opt) {
			return ProxyQCommonStyle().PixelMetric(m,out opt);
		}
		[SmokeMethod("pixelMetric", "(QStyle::PixelMetric) const", "$")]
		public new int PixelMetric(QStyle.PixelMetric m) {
			return ProxyQCommonStyle().PixelMetric(m);
		}
		[SmokeMethod("styleHint", "(QStyle::StyleHint, const QStyleOption*, const QWidget*, QStyleHintReturn*) const", "$###")]
		public new int StyleHint(QStyle.StyleHint sh, out int opt, QWidget w, QStyleHintReturn shret) {
			return ProxyQCommonStyle().StyleHint(sh,out opt,w,shret);
		}
		[SmokeMethod("styleHint", "(QStyle::StyleHint, const QStyleOption*, const QWidget*) const", "$##")]
		public new int StyleHint(QStyle.StyleHint sh, out int opt, QWidget w) {
			return ProxyQCommonStyle().StyleHint(sh,out opt,w);
		}
		[SmokeMethod("styleHint", "(QStyle::StyleHint, const QStyleOption*) const", "$#")]
		public new int StyleHint(QStyle.StyleHint sh, out int opt) {
			return ProxyQCommonStyle().StyleHint(sh,out opt);
		}
		[SmokeMethod("styleHint", "(QStyle::StyleHint) const", "$")]
		public new int StyleHint(QStyle.StyleHint sh) {
			return ProxyQCommonStyle().StyleHint(sh);
		}
		[SmokeMethod("standardPixmap", "(QStyle::StandardPixmap, const QStyleOption*, const QWidget*) const", "$##")]
		public new QPixmap StandardPixmap(QStyle.StandardPixmap sp, out int opt, QWidget widget) {
			return ProxyQCommonStyle().StandardPixmap(sp,out opt,widget);
		}
		[SmokeMethod("standardPixmap", "(QStyle::StandardPixmap, const QStyleOption*) const", "$#")]
		public new QPixmap StandardPixmap(QStyle.StandardPixmap sp, out int opt) {
			return ProxyQCommonStyle().StandardPixmap(sp,out opt);
		}
		[SmokeMethod("standardPixmap", "(QStyle::StandardPixmap) const", "$")]
		public new QPixmap StandardPixmap(QStyle.StandardPixmap sp) {
			return ProxyQCommonStyle().StandardPixmap(sp);
		}
		[SmokeMethod("generatedIconPixmap", "(QIcon::Mode, const QPixmap&, const QStyleOption*) const", "$##")]
		public new QPixmap GeneratedIconPixmap(QIcon.Mode iconMode, QPixmap pixmap, out int opt) {
			return ProxyQCommonStyle().GeneratedIconPixmap(iconMode,pixmap,out opt);
		}
		public static new string Tr(string s, string c) {
			return StaticQCommonStyle().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQCommonStyle().Tr(s);
		}
		// QCommonStyle* QCommonStyle(QCommonStylePrivate& arg1); >>>> NOT CONVERTED
		[Q_SLOT("QIcon standardIconImplementation(QStyle::StandardPixmap, const QStyleOption*, const QWidget*) const")]
		[SmokeMethod("standardIconImplementation", "(QStyle::StandardPixmap, const QStyleOption*, const QWidget*) const", "$##")]
		protected new QIcon StandardIconImplementation(QStyle.StandardPixmap standardIcon, out int opt, QWidget widget) {
			return ProxyQCommonStyle().StandardIconImplementation(standardIcon,out opt,widget);
		}
		[Q_SLOT("QIcon standardIconImplementation(QStyle::StandardPixmap, const QStyleOption*) const")]
		[SmokeMethod("standardIconImplementation", "(QStyle::StandardPixmap, const QStyleOption*) const", "$#")]
		protected new QIcon StandardIconImplementation(QStyle.StandardPixmap standardIcon, out int opt) {
			return ProxyQCommonStyle().StandardIconImplementation(standardIcon,out opt);
		}
		[Q_SLOT("QIcon standardIconImplementation(QStyle::StandardPixmap) const")]
		[SmokeMethod("standardIconImplementation", "(QStyle::StandardPixmap) const", "$")]
		protected new QIcon StandardIconImplementation(QStyle.StandardPixmap standardIcon) {
			return ProxyQCommonStyle().StandardIconImplementation(standardIcon);
		}
		~QCommonStyle() {
			DisposeQCommonStyle();
		}
		public new void Dispose() {
			DisposeQCommonStyle();
		}
		[SmokeMethod("~QCommonStyle", "()", "")]
		private void DisposeQCommonStyle() {
			ProxyQCommonStyle().DisposeQCommonStyle();
		}
		protected new IQCommonStyleSignals Emit {
			get {
				return (IQCommonStyleSignals) Q_EMIT;
			}
		}
	}

	public interface IQCommonStyleSignals : IQStyleSignals {
	}
}
