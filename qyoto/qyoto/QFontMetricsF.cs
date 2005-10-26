//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QFontMetricsF : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QFontMetricsF(Type dummy) {}
		interface IQFontMetricsFProxy {
			bool op_equals(QFontMetricsF lhs, QFontMetricsF other);
		}

		protected void CreateQFontMetricsFProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFontMetricsF), this);
			_interceptor = (QFontMetricsF) realProxy.GetTransparentProxy();
		}
		private QFontMetricsF ProxyQFontMetricsF() {
			return (QFontMetricsF) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFontMetricsF() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFontMetricsFProxy), null);
			_staticInterceptor = (IQFontMetricsFProxy) realProxy.GetTransparentProxy();
		}
		private static IQFontMetricsFProxy StaticQFontMetricsF() {
			return (IQFontMetricsFProxy) _staticInterceptor;
		}

		public QFontMetricsF(QFont arg1) : this((Type) null) {
			CreateQFontMetricsFProxy();
			NewQFontMetricsF(arg1);
		}
		private void NewQFontMetricsF(QFont arg1) {
			ProxyQFontMetricsF().NewQFontMetricsF(arg1);
		}
		public QFontMetricsF(QFont arg1, IQPaintDevice pd) : this((Type) null) {
			CreateQFontMetricsFProxy();
			NewQFontMetricsF(arg1,pd);
		}
		private void NewQFontMetricsF(QFont arg1, IQPaintDevice pd) {
			ProxyQFontMetricsF().NewQFontMetricsF(arg1,pd);
		}
		public QFontMetricsF(QFontMetricsF arg1) : this((Type) null) {
			CreateQFontMetricsFProxy();
			NewQFontMetricsF(arg1);
		}
		private void NewQFontMetricsF(QFontMetricsF arg1) {
			ProxyQFontMetricsF().NewQFontMetricsF(arg1);
		}
		// qreal ascent(); >>>> NOT CONVERTED
		// qreal descent(); >>>> NOT CONVERTED
		// qreal height(); >>>> NOT CONVERTED
		// qreal leading(); >>>> NOT CONVERTED
		// qreal lineSpacing(); >>>> NOT CONVERTED
		// qreal minLeftBearing(); >>>> NOT CONVERTED
		// qreal minRightBearing(); >>>> NOT CONVERTED
		// qreal maxWidth(); >>>> NOT CONVERTED
		public bool InFont(char arg1) {
			return ProxyQFontMetricsF().InFont(arg1);
		}
		// qreal leftBearing(QChar arg1); >>>> NOT CONVERTED
		// qreal rightBearing(QChar arg1); >>>> NOT CONVERTED
		// qreal width(const QString& arg1); >>>> NOT CONVERTED
		// qreal width(QChar arg1); >>>> NOT CONVERTED
		public QRectF BoundingRect(string arg1) {
			return ProxyQFontMetricsF().BoundingRect(arg1);
		}
		public QRectF BoundingRect(char arg1) {
			return ProxyQFontMetricsF().BoundingRect(arg1);
		}
		public QRectF BoundingRect(QRectF r, int flags, string arg3, int tabstops, out int tabarray) {
			return ProxyQFontMetricsF().BoundingRect(r,flags,arg3,tabstops,out tabarray);
		}
		public QRectF BoundingRect(QRectF r, int flags, string arg3, int tabstops) {
			return ProxyQFontMetricsF().BoundingRect(r,flags,arg3,tabstops);
		}
		public QRectF BoundingRect(QRectF r, int flags, string arg3) {
			return ProxyQFontMetricsF().BoundingRect(r,flags,arg3);
		}
		public QSizeF Size(int flags, string str, int tabstops, out int tabarray) {
			return ProxyQFontMetricsF().Size(flags,str,tabstops,out tabarray);
		}
		public QSizeF Size(int flags, string str, int tabstops) {
			return ProxyQFontMetricsF().Size(flags,str,tabstops);
		}
		public QSizeF Size(int flags, string str) {
			return ProxyQFontMetricsF().Size(flags,str);
		}
		// qreal underlinePos(); >>>> NOT CONVERTED
		// qreal overlinePos(); >>>> NOT CONVERTED
		// qreal strikeOutPos(); >>>> NOT CONVERTED
		// qreal lineWidth(); >>>> NOT CONVERTED
		public static bool operator==(QFontMetricsF lhs, QFontMetricsF other) {
			return StaticQFontMetricsF().op_equals(lhs,other);
		}
		public static bool operator!=(QFontMetricsF lhs, QFontMetricsF other) {
			return !StaticQFontMetricsF().op_equals(lhs,other);
		}
		public override bool Equals(object o) {
			if (!(o is QFontMetricsF)) { return false; }
			return this == (QFontMetricsF) o;
		}
		public override int GetHashCode() {
			return ProxyQFontMetricsF().GetHashCode();
		}
		~QFontMetricsF() {
			ProxyQFontMetricsF().Dispose();
		}
		public void Dispose() {
			ProxyQFontMetricsF().Dispose();
		}
	}
}
