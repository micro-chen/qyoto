//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	public class QMimeData : QObject, IDisposable {
 		protected QMimeData(Type dummy) : base((Type) null) {}
		interface IQMimeDataProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected void CreateQMimeDataProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMimeData), this);
			_interceptor = (QMimeData) realProxy.GetTransparentProxy();
		}
		private QMimeData ProxyQMimeData() {
			return (QMimeData) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMimeData() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMimeDataProxy), null);
			_staticInterceptor = (IQMimeDataProxy) realProxy.GetTransparentProxy();
		}
		private static IQMimeDataProxy StaticQMimeData() {
			return (IQMimeDataProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQMimeData().MetaObject();
		}
		// void* qt_metacast(const char* arg1); >>>> NOT CONVERTED
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QMimeData() : this((Type) null) {
			CreateQMimeDataProxy();
			NewQMimeData();
		}
		private void NewQMimeData() {
			ProxyQMimeData().NewQMimeData();
		}
		// QList<QUrl> urls(); >>>> NOT CONVERTED
		// void setUrls(const QList<QUrl>& arg1); >>>> NOT CONVERTED
		public bool HasUrls() {
			return ProxyQMimeData().HasUrls();
		}
		public string Text() {
			return ProxyQMimeData().Text();
		}
		public void SetText(string text) {
			ProxyQMimeData().SetText(text);
		}
		public bool HasText() {
			return ProxyQMimeData().HasText();
		}
		public string Html() {
			return ProxyQMimeData().Html();
		}
		public void SetHtml(string html) {
			ProxyQMimeData().SetHtml(html);
		}
		public bool HasHtml() {
			return ProxyQMimeData().HasHtml();
		}
		public QVariant ImageData() {
			return ProxyQMimeData().ImageData();
		}
		public void SetImageData(QVariant image) {
			ProxyQMimeData().SetImageData(image);
		}
		public bool HasImage() {
			return ProxyQMimeData().HasImage();
		}
		public QVariant ColorData() {
			return ProxyQMimeData().ColorData();
		}
		public void SetColorData(QVariant color) {
			ProxyQMimeData().SetColorData(color);
		}
		public bool HasColor() {
			return ProxyQMimeData().HasColor();
		}
		public byte[] Data(string mimetype) {
			return ProxyQMimeData().Data(mimetype);
		}
		public void SetData(string mimetype, byte[] data) {
			ProxyQMimeData().SetData(mimetype,data);
		}
		public virtual bool HasFormat(string mimetype) {
			return ProxyQMimeData().HasFormat(mimetype);
		}
		public virtual ArrayList Formats() {
			return ProxyQMimeData().Formats();
		}
		public void Clear() {
			ProxyQMimeData().Clear();
		}
		public static new string Tr(string s, string c) {
			return StaticQMimeData().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQMimeData().Tr(s);
		}
		protected virtual QVariant RetrieveData(string mimetype, int preferredType) {
			return ProxyQMimeData().RetrieveData(mimetype,preferredType);
		}
		~QMimeData() {
			ProxyQMimeData().Dispose();
		}
		public new void Dispose() {
			ProxyQMimeData().Dispose();
		}
	}
}
