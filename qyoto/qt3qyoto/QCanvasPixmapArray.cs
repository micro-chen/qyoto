//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QCanvasPixmapArray : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QCanvasPixmapArray(Type dummy) {}
		interface IQCanvasPixmapArrayProxy {
			bool op_not(QCanvasPixmapArray lhs);
		}

		protected void CreateQCanvasPixmapArrayProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QCanvasPixmapArray), this);
			_interceptor = (QCanvasPixmapArray) realProxy.GetTransparentProxy();
		}
		private QCanvasPixmapArray ProxyQCanvasPixmapArray() {
			return (QCanvasPixmapArray) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QCanvasPixmapArray() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCanvasPixmapArrayProxy), null);
			_staticInterceptor = (IQCanvasPixmapArrayProxy) realProxy.GetTransparentProxy();
		}
		private static IQCanvasPixmapArrayProxy StaticQCanvasPixmapArray() {
			return (IQCanvasPixmapArrayProxy) _staticInterceptor;
		}

		public QCanvasPixmapArray() : this((Type) null) {
			CreateQCanvasPixmapArrayProxy();
			NewQCanvasPixmapArray();
		}
		private void NewQCanvasPixmapArray() {
			ProxyQCanvasPixmapArray().NewQCanvasPixmapArray();
		}
		public QCanvasPixmapArray(string datafilenamepattern, int framecount) : this((Type) null) {
			CreateQCanvasPixmapArrayProxy();
			NewQCanvasPixmapArray(datafilenamepattern,framecount);
		}
		private void NewQCanvasPixmapArray(string datafilenamepattern, int framecount) {
			ProxyQCanvasPixmapArray().NewQCanvasPixmapArray(datafilenamepattern,framecount);
		}
		public QCanvasPixmapArray(string datafilenamepattern) : this((Type) null) {
			CreateQCanvasPixmapArrayProxy();
			NewQCanvasPixmapArray(datafilenamepattern);
		}
		private void NewQCanvasPixmapArray(string datafilenamepattern) {
			ProxyQCanvasPixmapArray().NewQCanvasPixmapArray(datafilenamepattern);
		}
		// QCanvasPixmapArray* QCanvasPixmapArray(QPtrList<QPixmap> arg1,QPtrList<QPoint> arg2); >>>> NOT CONVERTED
		// QCanvasPixmapArray* QCanvasPixmapArray(QValueList<QPixmap> arg1,QPointArray arg2); >>>> NOT CONVERTED
		// QCanvasPixmapArray* QCanvasPixmapArray(QValueList<QPixmap> arg1); >>>> NOT CONVERTED
		public bool ReadPixmaps(string datafilenamepattern, int framecount) {
			return ProxyQCanvasPixmapArray().ReadPixmaps(datafilenamepattern,framecount);
		}
		public bool ReadPixmaps(string datafilenamepattern) {
			return ProxyQCanvasPixmapArray().ReadPixmaps(datafilenamepattern);
		}
		public bool ReadCollisionMasks(string filenamepattern) {
			return ProxyQCanvasPixmapArray().ReadCollisionMasks(filenamepattern);
		}
		public static bool operator!(QCanvasPixmapArray lhs) {
			return StaticQCanvasPixmapArray().op_not(lhs);
		}
		public bool IsValid() {
			return ProxyQCanvasPixmapArray().IsValid();
		}
		public QCanvasPixmap Image(int i) {
			return ProxyQCanvasPixmapArray().Image(i);
		}
		public void SetImage(int i, QCanvasPixmap p) {
			ProxyQCanvasPixmapArray().SetImage(i,p);
		}
		public uint Count() {
			return ProxyQCanvasPixmapArray().Count();
		}
		~QCanvasPixmapArray() {
			ProxyQCanvasPixmapArray().Dispose();
		}
		public void Dispose() {
			ProxyQCanvasPixmapArray().Dispose();
		}
	}
}
