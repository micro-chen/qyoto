//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQDragSignals"></see> for signals emitted by QDrag
	public class QDrag : QObject, IDisposable {
 		protected QDrag(Type dummy) : base((Type) null) {}
		interface IQDragProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected void CreateQDragProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDrag), this);
			_interceptor = (QDrag) realProxy.GetTransparentProxy();
		}
		private QDrag ProxyQDrag() {
			return (QDrag) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDrag() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDragProxy), null);
			_staticInterceptor = (IQDragProxy) realProxy.GetTransparentProxy();
		}
		private static IQDragProxy StaticQDrag() {
			return (IQDragProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQDrag().MetaObject();
		}
		// void* qt_metacast(const char* arg1); >>>> NOT CONVERTED
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QDrag(QWidget dragSource) : this((Type) null) {
			CreateQDragProxy();
			NewQDrag(dragSource);
		}
		private void NewQDrag(QWidget dragSource) {
			ProxyQDrag().NewQDrag(dragSource);
		}
		public void SetMimeData(QMimeData data) {
			ProxyQDrag().SetMimeData(data);
		}
		public QMimeData MimeData() {
			return ProxyQDrag().MimeData();
		}
		public void SetPixmap(QPixmap arg1) {
			ProxyQDrag().SetPixmap(arg1);
		}
		public QPixmap Pixmap() {
			return ProxyQDrag().Pixmap();
		}
		public void SetHotSpot(QPoint hotspot) {
			ProxyQDrag().SetHotSpot(hotspot);
		}
		public QPoint HotSpot() {
			return ProxyQDrag().HotSpot();
		}
		public QWidget Source() {
			return ProxyQDrag().Source();
		}
		public QWidget Target() {
			return ProxyQDrag().Target();
		}
		public int Start(int supportedActions) {
			return ProxyQDrag().Start(supportedActions);
		}
		public int Start() {
			return ProxyQDrag().Start();
		}
		public void SetDragCursor(QPixmap cursor, int action) {
			ProxyQDrag().SetDragCursor(cursor,action);
		}
		public static new string Tr(string s, string c) {
			return StaticQDrag().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQDrag().Tr(s);
		}
		~QDrag() {
			ProxyQDrag().Dispose();
		}
		public new void Dispose() {
			ProxyQDrag().Dispose();
		}
	}

	public interface IQDragSignals {
		void ActionChanged(int action);
		void TargetChanged(QWidget newTarget);
	}
}
