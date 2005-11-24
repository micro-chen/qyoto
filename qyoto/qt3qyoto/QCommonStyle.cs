//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QCommonStyle : QStyle, IDisposable {
 		protected QCommonStyle(Type dummy) : base((Type) null) {}
		interface IQCommonStyleProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQCommonStyleProxy() {
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

		public new virtual QMetaObject MetaObject() {
			return ProxyQCommonStyle().MetaObject();
		}
		public new virtual string ClassName() {
			return ProxyQCommonStyle().ClassName();
		}
		public QCommonStyle() : this((Type) null) {
			CreateQCommonStyleProxy();
			NewQCommonStyle();
		}
		private void NewQCommonStyle() {
			ProxyQCommonStyle().NewQCommonStyle();
		}
		public new void DrawPrimitive(int pe, QPainter p, QRect r, QColorGroup cg, int flags, QStyleOption arg6) {
			ProxyQCommonStyle().DrawPrimitive(pe,p,r,cg,flags,arg6);
		}
		public new void DrawPrimitive(int pe, QPainter p, QRect r, QColorGroup cg, int flags) {
			ProxyQCommonStyle().DrawPrimitive(pe,p,r,cg,flags);
		}
		public new void DrawPrimitive(int pe, QPainter p, QRect r, QColorGroup cg) {
			ProxyQCommonStyle().DrawPrimitive(pe,p,r,cg);
		}
		public new void DrawControl(int element, QPainter p, QWidget widget, QRect r, QColorGroup cg, int how, QStyleOption arg7) {
			ProxyQCommonStyle().DrawControl(element,p,widget,r,cg,how,arg7);
		}
		public new void DrawControl(int element, QPainter p, QWidget widget, QRect r, QColorGroup cg, int how) {
			ProxyQCommonStyle().DrawControl(element,p,widget,r,cg,how);
		}
		public new void DrawControl(int element, QPainter p, QWidget widget, QRect r, QColorGroup cg) {
			ProxyQCommonStyle().DrawControl(element,p,widget,r,cg);
		}
		public new void DrawControlMask(int element, QPainter p, QWidget widget, QRect r, QStyleOption arg5) {
			ProxyQCommonStyle().DrawControlMask(element,p,widget,r,arg5);
		}
		public new void DrawControlMask(int element, QPainter p, QWidget widget, QRect r) {
			ProxyQCommonStyle().DrawControlMask(element,p,widget,r);
		}
		public new QRect SubRect(int r, QWidget widget) {
			return ProxyQCommonStyle().SubRect(r,widget);
		}
		public new void DrawComplexControl(int control, QPainter p, QWidget widget, QRect r, QColorGroup cg, int how, int sub, int subActive, QStyleOption arg9) {
			ProxyQCommonStyle().DrawComplexControl(control,p,widget,r,cg,how,sub,subActive,arg9);
		}
		public new void DrawComplexControl(int control, QPainter p, QWidget widget, QRect r, QColorGroup cg, int how, int sub, int subActive) {
			ProxyQCommonStyle().DrawComplexControl(control,p,widget,r,cg,how,sub,subActive);
		}
		public new void DrawComplexControl(int control, QPainter p, QWidget widget, QRect r, QColorGroup cg, int how, int sub) {
			ProxyQCommonStyle().DrawComplexControl(control,p,widget,r,cg,how,sub);
		}
		public new void DrawComplexControl(int control, QPainter p, QWidget widget, QRect r, QColorGroup cg, int how) {
			ProxyQCommonStyle().DrawComplexControl(control,p,widget,r,cg,how);
		}
		public new void DrawComplexControl(int control, QPainter p, QWidget widget, QRect r, QColorGroup cg) {
			ProxyQCommonStyle().DrawComplexControl(control,p,widget,r,cg);
		}
		public new void DrawComplexControlMask(int control, QPainter p, QWidget widget, QRect r, QStyleOption arg5) {
			ProxyQCommonStyle().DrawComplexControlMask(control,p,widget,r,arg5);
		}
		public new void DrawComplexControlMask(int control, QPainter p, QWidget widget, QRect r) {
			ProxyQCommonStyle().DrawComplexControlMask(control,p,widget,r);
		}
		public new QRect QuerySubControlMetrics(int control, QWidget widget, int sc, QStyleOption arg4) {
			return ProxyQCommonStyle().QuerySubControlMetrics(control,widget,sc,arg4);
		}
		public new QRect QuerySubControlMetrics(int control, QWidget widget, int sc) {
			return ProxyQCommonStyle().QuerySubControlMetrics(control,widget,sc);
		}
		public new int QuerySubControl(int control, QWidget widget, QPoint pos, QStyleOption arg4) {
			return ProxyQCommonStyle().QuerySubControl(control,widget,pos,arg4);
		}
		public new int QuerySubControl(int control, QWidget widget, QPoint pos) {
			return ProxyQCommonStyle().QuerySubControl(control,widget,pos);
		}
		public new int PixelMetric(int m, QWidget widget) {
			return ProxyQCommonStyle().PixelMetric(m,widget);
		}
		public new int PixelMetric(int m) {
			return ProxyQCommonStyle().PixelMetric(m);
		}
		public new QSize SizeFromContents(int s, QWidget widget, QSize contentsSize, QStyleOption arg4) {
			return ProxyQCommonStyle().SizeFromContents(s,widget,contentsSize,arg4);
		}
		public new QSize SizeFromContents(int s, QWidget widget, QSize contentsSize) {
			return ProxyQCommonStyle().SizeFromContents(s,widget,contentsSize);
		}
		// int styleHint(QStyle::StyleHint arg1,const QWidget* arg2,const QStyleOption& arg3,QStyleHintReturn* arg4); >>>> NOT CONVERTED
		public new QPixmap StylePixmap(int sp, QWidget widget, QStyleOption arg3) {
			return ProxyQCommonStyle().StylePixmap(sp,widget,arg3);
		}
		public new QPixmap StylePixmap(int sp, QWidget widget) {
			return ProxyQCommonStyle().StylePixmap(sp,widget);
		}
		public new QPixmap StylePixmap(int sp) {
			return ProxyQCommonStyle().StylePixmap(sp);
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQCommonStyle().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQCommonStyle().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQCommonStyle().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQCommonStyle().TrUtf8(arg1);
		}
		~QCommonStyle() {
			ProxyQCommonStyle().Dispose();
		}
		public new void Dispose() {
			ProxyQCommonStyle().Dispose();
		}
	}
}
