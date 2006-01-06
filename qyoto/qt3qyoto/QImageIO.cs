//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QImageIO")]
	public class QImageIO : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QImageIO(Type dummy) {}
		interface IQImageIOProxy {
			string ImageFormat(string fileName);
			string ImageFormat(IQIODevice arg1);
			ArrayList InputFormats();
			ArrayList OutputFormats();
		}

		protected void CreateQImageIOProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QImageIO), this);
			_interceptor = (QImageIO) realProxy.GetTransparentProxy();
		}
		private QImageIO ProxyQImageIO() {
			return (QImageIO) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QImageIO() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQImageIOProxy), null);
			_staticInterceptor = (IQImageIOProxy) realProxy.GetTransparentProxy();
		}
		private static IQImageIOProxy StaticQImageIO() {
			return (IQImageIOProxy) _staticInterceptor;
		}

		public QImageIO() : this((Type) null) {
			CreateQImageIOProxy();
			NewQImageIO();
		}
		[SmokeMethod("QImageIO()")]
		private void NewQImageIO() {
			ProxyQImageIO().NewQImageIO();
		}
		public QImageIO(IQIODevice ioDevice, string format) : this((Type) null) {
			CreateQImageIOProxy();
			NewQImageIO(ioDevice,format);
		}
		[SmokeMethod("QImageIO(QIODevice*, const char*)")]
		private void NewQImageIO(IQIODevice ioDevice, string format) {
			ProxyQImageIO().NewQImageIO(ioDevice,format);
		}
		public QImageIO(string fileName, string format) : this((Type) null) {
			CreateQImageIOProxy();
			NewQImageIO(fileName,format);
		}
		[SmokeMethod("QImageIO(const QString&, const char*)")]
		private void NewQImageIO(string fileName, string format) {
			ProxyQImageIO().NewQImageIO(fileName,format);
		}
		[SmokeMethod("image() const")]
		public QImage Image() {
			return ProxyQImageIO().Image();
		}
		[SmokeMethod("status() const")]
		public int Status() {
			return ProxyQImageIO().Status();
		}
		[SmokeMethod("format() const")]
		public string Format() {
			return ProxyQImageIO().Format();
		}
		[SmokeMethod("ioDevice() const")]
		public IQIODevice IoDevice() {
			return ProxyQImageIO().IoDevice();
		}
		[SmokeMethod("fileName() const")]
		public string FileName() {
			return ProxyQImageIO().FileName();
		}
		[SmokeMethod("quality() const")]
		public int Quality() {
			return ProxyQImageIO().Quality();
		}
		[SmokeMethod("description() const")]
		public string Description() {
			return ProxyQImageIO().Description();
		}
		[SmokeMethod("parameters() const")]
		public string Parameters() {
			return ProxyQImageIO().Parameters();
		}
		[SmokeMethod("gamma() const")]
		public float Gamma() {
			return ProxyQImageIO().Gamma();
		}
		[SmokeMethod("setImage(const QImage&)")]
		public void SetImage(QImage arg1) {
			ProxyQImageIO().SetImage(arg1);
		}
		[SmokeMethod("setStatus(int)")]
		public void SetStatus(int arg1) {
			ProxyQImageIO().SetStatus(arg1);
		}
		[SmokeMethod("setFormat(const char*)")]
		public void SetFormat(string arg1) {
			ProxyQImageIO().SetFormat(arg1);
		}
		[SmokeMethod("setIODevice(QIODevice*)")]
		public void SetIODevice(IQIODevice arg1) {
			ProxyQImageIO().SetIODevice(arg1);
		}
		[SmokeMethod("setFileName(const QString&)")]
		public void SetFileName(string arg1) {
			ProxyQImageIO().SetFileName(arg1);
		}
		[SmokeMethod("setQuality(int)")]
		public void SetQuality(int arg1) {
			ProxyQImageIO().SetQuality(arg1);
		}
		[SmokeMethod("setDescription(const QString&)")]
		public void SetDescription(string arg1) {
			ProxyQImageIO().SetDescription(arg1);
		}
		[SmokeMethod("setParameters(const char*)")]
		public void SetParameters(string arg1) {
			ProxyQImageIO().SetParameters(arg1);
		}
		[SmokeMethod("setGamma(float)")]
		public void SetGamma(float arg1) {
			ProxyQImageIO().SetGamma(arg1);
		}
		[SmokeMethod("read()")]
		public bool Read() {
			return ProxyQImageIO().Read();
		}
		[SmokeMethod("write()")]
		public bool Write() {
			return ProxyQImageIO().Write();
		}
		[SmokeMethod("imageFormat(const QString&)")]
		public static string ImageFormat(string fileName) {
			return StaticQImageIO().ImageFormat(fileName);
		}
		[SmokeMethod("imageFormat(QIODevice*)")]
		public static string ImageFormat(IQIODevice arg1) {
			return StaticQImageIO().ImageFormat(arg1);
		}
		[SmokeMethod("inputFormats()")]
		public static ArrayList InputFormats() {
			return StaticQImageIO().InputFormats();
		}
		[SmokeMethod("outputFormats()")]
		public static ArrayList OutputFormats() {
			return StaticQImageIO().OutputFormats();
		}
		~QImageIO() {
			DisposeQImageIO();
		}
		public void Dispose() {
			DisposeQImageIO();
		}
		private void DisposeQImageIO() {
			ProxyQImageIO().DisposeQImageIO();
		}
	}
}
