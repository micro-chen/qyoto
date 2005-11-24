//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QFontMetrics : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QFontMetrics(Type dummy) {}
		interface IQFontMetricsProxy {
		}

		protected void CreateQFontMetricsProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFontMetrics), this);
			_interceptor = (QFontMetrics) realProxy.GetTransparentProxy();
		}
		private QFontMetrics ProxyQFontMetrics() {
			return (QFontMetrics) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFontMetrics() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFontMetricsProxy), null);
			_staticInterceptor = (IQFontMetricsProxy) realProxy.GetTransparentProxy();
		}
		private static IQFontMetricsProxy StaticQFontMetrics() {
			return (IQFontMetricsProxy) _staticInterceptor;
		}

		public QFontMetrics(QFont arg1) : this((Type) null) {
			CreateQFontMetricsProxy();
			NewQFontMetrics(arg1);
		}
		private void NewQFontMetrics(QFont arg1) {
			ProxyQFontMetrics().NewQFontMetrics(arg1);
		}
		public QFontMetrics(QFont arg1, int arg2) : this((Type) null) {
			CreateQFontMetricsProxy();
			NewQFontMetrics(arg1,arg2);
		}
		private void NewQFontMetrics(QFont arg1, int arg2) {
			ProxyQFontMetrics().NewQFontMetrics(arg1,arg2);
		}
		public QFontMetrics(QFontMetrics arg1) : this((Type) null) {
			CreateQFontMetricsProxy();
			NewQFontMetrics(arg1);
		}
		private void NewQFontMetrics(QFontMetrics arg1) {
			ProxyQFontMetrics().NewQFontMetrics(arg1);
		}
		public int Ascent() {
			return ProxyQFontMetrics().Ascent();
		}
		public int Descent() {
			return ProxyQFontMetrics().Descent();
		}
		public int Height() {
			return ProxyQFontMetrics().Height();
		}
		public int Leading() {
			return ProxyQFontMetrics().Leading();
		}
		public int LineSpacing() {
			return ProxyQFontMetrics().LineSpacing();
		}
		public int MinLeftBearing() {
			return ProxyQFontMetrics().MinLeftBearing();
		}
		public int MinRightBearing() {
			return ProxyQFontMetrics().MinRightBearing();
		}
		public int MaxWidth() {
			return ProxyQFontMetrics().MaxWidth();
		}
		public bool InFont(char arg1) {
			return ProxyQFontMetrics().InFont(arg1);
		}
		public int LeftBearing(char arg1) {
			return ProxyQFontMetrics().LeftBearing(arg1);
		}
		public int RightBearing(char arg1) {
			return ProxyQFontMetrics().RightBearing(arg1);
		}
		public int Width(string arg1, int len) {
			return ProxyQFontMetrics().Width(arg1,len);
		}
		public int Width(string arg1) {
			return ProxyQFontMetrics().Width(arg1);
		}
		public int Width(char arg1) {
			return ProxyQFontMetrics().Width(arg1);
		}
		public int CharWidth(string str, int pos) {
			return ProxyQFontMetrics().CharWidth(str,pos);
		}
		public QRect BoundingRect(string arg1, int len) {
			return ProxyQFontMetrics().BoundingRect(arg1,len);
		}
		public QRect BoundingRect(string arg1) {
			return ProxyQFontMetrics().BoundingRect(arg1);
		}
		public QRect BoundingRect(char arg1) {
			return ProxyQFontMetrics().BoundingRect(arg1);
		}
		// QRect boundingRect(int arg1,int arg2,int arg3,int arg4,int arg5,const QString& arg6,int arg7,int arg8,int* arg9,QTextParag** arg10); >>>> NOT CONVERTED
		public QRect BoundingRect(int x, int y, int w, int h, int flags, string str, int len, int tabstops, out int tabarray) {
			return ProxyQFontMetrics().BoundingRect(x,y,w,h,flags,str,len,tabstops,out tabarray);
		}
		public QRect BoundingRect(int x, int y, int w, int h, int flags, string str, int len, int tabstops) {
			return ProxyQFontMetrics().BoundingRect(x,y,w,h,flags,str,len,tabstops);
		}
		public QRect BoundingRect(int x, int y, int w, int h, int flags, string str, int len) {
			return ProxyQFontMetrics().BoundingRect(x,y,w,h,flags,str,len);
		}
		public QRect BoundingRect(int x, int y, int w, int h, int flags, string str) {
			return ProxyQFontMetrics().BoundingRect(x,y,w,h,flags,str);
		}
		// QSize size(int arg1,const QString& arg2,int arg3,int arg4,int* arg5,QTextParag** arg6); >>>> NOT CONVERTED
		public QSize Size(int flags, string str, int len, int tabstops, out int tabarray) {
			return ProxyQFontMetrics().Size(flags,str,len,tabstops,out tabarray);
		}
		public QSize Size(int flags, string str, int len, int tabstops) {
			return ProxyQFontMetrics().Size(flags,str,len,tabstops);
		}
		public QSize Size(int flags, string str, int len) {
			return ProxyQFontMetrics().Size(flags,str,len);
		}
		public QSize Size(int flags, string str) {
			return ProxyQFontMetrics().Size(flags,str);
		}
		public int UnderlinePos() {
			return ProxyQFontMetrics().UnderlinePos();
		}
		public int OverlinePos() {
			return ProxyQFontMetrics().OverlinePos();
		}
		public int StrikeOutPos() {
			return ProxyQFontMetrics().StrikeOutPos();
		}
		public int LineWidth() {
			return ProxyQFontMetrics().LineWidth();
		}
		~QFontMetrics() {
			ProxyQFontMetrics().Dispose();
		}
		public void Dispose() {
			ProxyQFontMetrics().Dispose();
		}
	}
}
