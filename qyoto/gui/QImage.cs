//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QImage")]
	public class QImage : QPaintDevice, IDisposable {
 		protected QImage(Type dummy) : base((Type) null) {}
		[SmokeClass("QImage")]
		interface IQImageProxy {
			[SmokeMethod("operator==", "(const QImage&) const", "#")]
			bool op_equals(QImage lhs, QImage arg1);
			[SmokeMethod("trueMatrix", "(const QMatrix&, int, int)", "#$$")]
			QMatrix TrueMatrix(QMatrix arg1, int w, int h);
			[SmokeMethod("fromData", "(const uchar*, int, const char*)", "$$$")]
			QImage FromData(char[] data, int size, string format);
			[SmokeMethod("fromData", "(const uchar*, int)", "$$")]
			QImage FromData(char[] data, int size);
			[SmokeMethod("fromData", "(const QByteArray&, const char*)", "#$")]
			QImage FromData(QByteArray data, string format);
			[SmokeMethod("fromData", "(const QByteArray&)", "#")]
			QImage FromData(QByteArray data);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QImage), this);
			_interceptor = (QImage) realProxy.GetTransparentProxy();
		}
		private QImage ProxyQImage() {
			return (QImage) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QImage() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQImageProxy), null);
			_staticInterceptor = (IQImageProxy) realProxy.GetTransparentProxy();
		}
		private static IQImageProxy StaticQImage() {
			return (IQImageProxy) _staticInterceptor;
		}
		public enum InvertMode {
			InvertRgb = 0,
			InvertRgba = 1,
		}
		public enum Format {
			Format_Invalid = 0,
			Format_Mono = 1,
			Format_MonoLSB = 2,
			Format_Indexed8 = 3,
			Format_RGB32 = 4,
			Format_ARGB32 = 5,
			Format_ARGB32_Premultiplied = 6,
			Format_RGB16 = 7,
			NImageFormats = 8,
		}
		public QImage() : this((Type) null) {
			CreateProxy();
			NewQImage();
		}
		[SmokeMethod("QImage", "()", "")]
		private void NewQImage() {
			ProxyQImage().NewQImage();
		}
		public QImage(QSize size, QImage.Format format) : this((Type) null) {
			CreateProxy();
			NewQImage(size,format);
		}
		[SmokeMethod("QImage", "(const QSize&, QImage::Format)", "#$")]
		private void NewQImage(QSize size, QImage.Format format) {
			ProxyQImage().NewQImage(size,format);
		}
		public QImage(int width, int height, QImage.Format format) : this((Type) null) {
			CreateProxy();
			NewQImage(width,height,format);
		}
		[SmokeMethod("QImage", "(int, int, QImage::Format)", "$$$")]
		private void NewQImage(int width, int height, QImage.Format format) {
			ProxyQImage().NewQImage(width,height,format);
		}
		public QImage(char[] data, int width, int height, QImage.Format format) : this((Type) null) {
			CreateProxy();
			NewQImage(data,width,height,format);
		}
		[SmokeMethod("QImage", "(uchar*, int, int, QImage::Format)", "$$$$")]
		private void NewQImage(char[] data, int width, int height, QImage.Format format) {
			ProxyQImage().NewQImage(data,width,height,format);
		}
		// QImage* QImage(const char** arg1); >>>> NOT CONVERTED
		public QImage(string fileName, string format) : this((Type) null) {
			CreateProxy();
			NewQImage(fileName,format);
		}
		[SmokeMethod("QImage", "(const QString&, const char*)", "$$")]
		private void NewQImage(string fileName, string format) {
			ProxyQImage().NewQImage(fileName,format);
		}
		public QImage(string fileName) : this((Type) null) {
			CreateProxy();
			NewQImage(fileName);
		}
		[SmokeMethod("QImage", "(const QString&)", "$")]
		private void NewQImage(string fileName) {
			ProxyQImage().NewQImage(fileName);
		}
		public QImage(QImage arg1) : this((Type) null) {
			CreateProxy();
			NewQImage(arg1);
		}
		[SmokeMethod("QImage", "(const QImage&)", "#")]
		private void NewQImage(QImage arg1) {
			ProxyQImage().NewQImage(arg1);
		}
		[SmokeMethod("isNull", "() const", "")]
		public bool IsNull() {
			return ProxyQImage().IsNull();
		}
		[SmokeMethod("devType", "() const", "")]
		public new int DevType() {
			return ProxyQImage().DevType();
		}
		public static bool operator==(QImage lhs, QImage arg1) {
			return StaticQImage().op_equals(lhs,arg1);
		}
		public static bool operator!=(QImage lhs, QImage arg1) {
			return !StaticQImage().op_equals(lhs,arg1);
		}
		public override bool Equals(object o) {
			if (!(o is QImage)) { return false; }
			return this == (QImage) o;
		}
		public override int GetHashCode() {
			return ProxyQImage().GetHashCode();
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		[SmokeMethod("detach", "()", "")]
		public void Detach() {
			ProxyQImage().Detach();
		}
		[SmokeMethod("isDetached", "() const", "")]
		public bool IsDetached() {
			return ProxyQImage().IsDetached();
		}
		[SmokeMethod("copy", "(const QRect&) const", "#")]
		public QImage Copy(QRect rect) {
			return ProxyQImage().Copy(rect);
		}
		[SmokeMethod("copy", "() const", "")]
		public QImage Copy() {
			return ProxyQImage().Copy();
		}
		[SmokeMethod("copy", "(int, int, int, int) const", "$$$$")]
		public QImage Copy(int x, int y, int w, int h) {
			return ProxyQImage().Copy(x,y,w,h);
		}
		[SmokeMethod("format", "() const", "")]
		public QImage.Format format() {
			return ProxyQImage().format();
		}
		[SmokeMethod("convertToFormat", "(QImage::Format, Qt::ImageConversionFlags) const", "$$")]
		public QImage ConvertToFormat(QImage.Format f, int flags) {
			return ProxyQImage().ConvertToFormat(f,flags);
		}
		[SmokeMethod("convertToFormat", "(QImage::Format) const", "$")]
		public QImage ConvertToFormat(QImage.Format f) {
			return ProxyQImage().ConvertToFormat(f);
		}
		[SmokeMethod("convertToFormat", "(QImage::Format, const QVector<QRgb>&, Qt::ImageConversionFlags) const", "$?$")]
		public QImage ConvertToFormat(QImage.Format f, List<uint> colorTable, int flags) {
			return ProxyQImage().ConvertToFormat(f,colorTable,flags);
		}
		[SmokeMethod("convertToFormat", "(QImage::Format, const QVector<QRgb>&) const", "$?")]
		public QImage ConvertToFormat(QImage.Format f, List<uint> colorTable) {
			return ProxyQImage().ConvertToFormat(f,colorTable);
		}
		[SmokeMethod("width", "() const", "")]
		public new int Width() {
			return ProxyQImage().Width();
		}
		[SmokeMethod("height", "() const", "")]
		public new int Height() {
			return ProxyQImage().Height();
		}
		[SmokeMethod("size", "() const", "")]
		public QSize Size() {
			return ProxyQImage().Size();
		}
		[SmokeMethod("rect", "() const", "")]
		public QRect Rect() {
			return ProxyQImage().Rect();
		}
		[SmokeMethod("depth", "() const", "")]
		public new int Depth() {
			return ProxyQImage().Depth();
		}
		[SmokeMethod("numColors", "() const", "")]
		public new int NumColors() {
			return ProxyQImage().NumColors();
		}
		[SmokeMethod("color", "(int) const", "$")]
		public uint Color(int i) {
			return ProxyQImage().Color(i);
		}
		[SmokeMethod("setColor", "(int, QRgb)", "$$")]
		public void SetColor(int i, uint c) {
			ProxyQImage().SetColor(i,c);
		}
		[SmokeMethod("setNumColors", "(int)", "$")]
		public void SetNumColors(int arg1) {
			ProxyQImage().SetNumColors(arg1);
		}
		[SmokeMethod("allGray", "() const", "")]
		public bool AllGray() {
			return ProxyQImage().AllGray();
		}
		[SmokeMethod("isGrayscale", "() const", "")]
		public bool IsGrayscale() {
			return ProxyQImage().IsGrayscale();
		}
		[SmokeMethod("bits", "()", "")]
		public byte[] Bits() {
			return ProxyQImage().Bits();
		}
		[SmokeMethod("numBytes", "() const", "")]
		public int NumBytes() {
			return ProxyQImage().NumBytes();
		}
		[SmokeMethod("scanLine", "(int)", "$")]
		public byte[] ScanLine(int arg1) {
			return ProxyQImage().ScanLine(arg1);
		}
		[SmokeMethod("bytesPerLine", "() const", "")]
		public int BytesPerLine() {
			return ProxyQImage().BytesPerLine();
		}
		[SmokeMethod("valid", "(int, int) const", "$$")]
		public bool Valid(int x, int y) {
			return ProxyQImage().Valid(x,y);
		}
		[SmokeMethod("valid", "(const QPoint&) const", "#")]
		public bool Valid(QPoint pt) {
			return ProxyQImage().Valid(pt);
		}
		[SmokeMethod("pixelIndex", "(int, int) const", "$$")]
		public int PixelIndex(int x, int y) {
			return ProxyQImage().PixelIndex(x,y);
		}
		[SmokeMethod("pixelIndex", "(const QPoint&) const", "#")]
		public int PixelIndex(QPoint pt) {
			return ProxyQImage().PixelIndex(pt);
		}
		[SmokeMethod("pixel", "(int, int) const", "$$")]
		public uint Pixel(int x, int y) {
			return ProxyQImage().Pixel(x,y);
		}
		[SmokeMethod("pixel", "(const QPoint&) const", "#")]
		public uint Pixel(QPoint pt) {
			return ProxyQImage().Pixel(pt);
		}
		[SmokeMethod("setPixel", "(int, int, uint)", "$$$")]
		public void SetPixel(int x, int y, uint index_or_rgb) {
			ProxyQImage().SetPixel(x,y,index_or_rgb);
		}
		[SmokeMethod("setPixel", "(const QPoint&, uint)", "#$")]
		public void SetPixel(QPoint pt, uint index_or_rgb) {
			ProxyQImage().SetPixel(pt,index_or_rgb);
		}
		[SmokeMethod("colorTable", "() const", "")]
		public List<uint> ColorTable() {
			return ProxyQImage().ColorTable();
		}
		[SmokeMethod("setColorTable", "(const QVector<QRgb>)", "?")]
		public void SetColorTable(List<uint> colors) {
			ProxyQImage().SetColorTable(colors);
		}
		[SmokeMethod("fill", "(uint)", "$")]
		public void Fill(uint pixel) {
			ProxyQImage().Fill(pixel);
		}
		[SmokeMethod("hasAlphaChannel", "() const", "")]
		public bool HasAlphaChannel() {
			return ProxyQImage().HasAlphaChannel();
		}
		[SmokeMethod("setAlphaChannel", "(const QImage&)", "#")]
		public void SetAlphaChannel(QImage alphaChannel) {
			ProxyQImage().SetAlphaChannel(alphaChannel);
		}
		[SmokeMethod("alphaChannel", "() const", "")]
		public QImage AlphaChannel() {
			return ProxyQImage().AlphaChannel();
		}
		[SmokeMethod("createAlphaMask", "(Qt::ImageConversionFlags) const", "$")]
		public QImage CreateAlphaMask(int flags) {
			return ProxyQImage().CreateAlphaMask(flags);
		}
		[SmokeMethod("createAlphaMask", "() const", "")]
		public QImage CreateAlphaMask() {
			return ProxyQImage().CreateAlphaMask();
		}
		[SmokeMethod("createHeuristicMask", "(bool) const", "$")]
		public QImage CreateHeuristicMask(bool clipTight) {
			return ProxyQImage().CreateHeuristicMask(clipTight);
		}
		[SmokeMethod("createHeuristicMask", "() const", "")]
		public QImage CreateHeuristicMask() {
			return ProxyQImage().CreateHeuristicMask();
		}
		[SmokeMethod("scaled", "(int, int, Qt::AspectRatioMode, Qt::TransformationMode) const", "$$$$")]
		public QImage Scaled(int w, int h, Qt.AspectRatioMode aspectMode, Qt.TransformationMode mode) {
			return ProxyQImage().Scaled(w,h,aspectMode,mode);
		}
		[SmokeMethod("scaled", "(int, int, Qt::AspectRatioMode) const", "$$$")]
		public QImage Scaled(int w, int h, Qt.AspectRatioMode aspectMode) {
			return ProxyQImage().Scaled(w,h,aspectMode);
		}
		[SmokeMethod("scaled", "(int, int) const", "$$")]
		public QImage Scaled(int w, int h) {
			return ProxyQImage().Scaled(w,h);
		}
		[SmokeMethod("scaled", "(const QSize&, Qt::AspectRatioMode, Qt::TransformationMode) const", "#$$")]
		public QImage Scaled(QSize s, Qt.AspectRatioMode aspectMode, Qt.TransformationMode mode) {
			return ProxyQImage().Scaled(s,aspectMode,mode);
		}
		[SmokeMethod("scaled", "(const QSize&, Qt::AspectRatioMode) const", "#$")]
		public QImage Scaled(QSize s, Qt.AspectRatioMode aspectMode) {
			return ProxyQImage().Scaled(s,aspectMode);
		}
		[SmokeMethod("scaled", "(const QSize&) const", "#")]
		public QImage Scaled(QSize s) {
			return ProxyQImage().Scaled(s);
		}
		[SmokeMethod("scaledToWidth", "(int, Qt::TransformationMode) const", "$$")]
		public QImage ScaledToWidth(int w, Qt.TransformationMode mode) {
			return ProxyQImage().ScaledToWidth(w,mode);
		}
		[SmokeMethod("scaledToWidth", "(int) const", "$")]
		public QImage ScaledToWidth(int w) {
			return ProxyQImage().ScaledToWidth(w);
		}
		[SmokeMethod("scaledToHeight", "(int, Qt::TransformationMode) const", "$$")]
		public QImage ScaledToHeight(int h, Qt.TransformationMode mode) {
			return ProxyQImage().ScaledToHeight(h,mode);
		}
		[SmokeMethod("scaledToHeight", "(int) const", "$")]
		public QImage ScaledToHeight(int h) {
			return ProxyQImage().ScaledToHeight(h);
		}
		[SmokeMethod("transformed", "(const QMatrix&, Qt::TransformationMode) const", "#$")]
		public QImage Transformed(QMatrix matrix, Qt.TransformationMode mode) {
			return ProxyQImage().Transformed(matrix,mode);
		}
		[SmokeMethod("transformed", "(const QMatrix&) const", "#")]
		public QImage Transformed(QMatrix matrix) {
			return ProxyQImage().Transformed(matrix);
		}
		[SmokeMethod("mirrored", "(bool, bool) const", "$$")]
		public QImage Mirrored(bool horizontally, bool vertically) {
			return ProxyQImage().Mirrored(horizontally,vertically);
		}
		[SmokeMethod("mirrored", "(bool) const", "$")]
		public QImage Mirrored(bool horizontally) {
			return ProxyQImage().Mirrored(horizontally);
		}
		[SmokeMethod("mirrored", "() const", "")]
		public QImage Mirrored() {
			return ProxyQImage().Mirrored();
		}
		[SmokeMethod("rgbSwapped", "() const", "")]
		public QImage RgbSwapped() {
			return ProxyQImage().RgbSwapped();
		}
		[SmokeMethod("invertPixels", "(QImage::InvertMode)", "$")]
		public void InvertPixels(QImage.InvertMode arg1) {
			ProxyQImage().InvertPixels(arg1);
		}
		[SmokeMethod("invertPixels", "()", "")]
		public void InvertPixels() {
			ProxyQImage().InvertPixels();
		}
		[SmokeMethod("load", "(QIODevice*, const char*)", "#$")]
		public bool Load(IQIODevice device, string format) {
			return ProxyQImage().Load(device,format);
		}
		[SmokeMethod("load", "(const QString&, const char*)", "$$")]
		public bool Load(string fileName, string format) {
			return ProxyQImage().Load(fileName,format);
		}
		[SmokeMethod("load", "(const QString&)", "$")]
		public bool Load(string fileName) {
			return ProxyQImage().Load(fileName);
		}
		[SmokeMethod("loadFromData", "(const uchar*, int, const char*)", "$$$")]
		public bool LoadFromData(char[] buf, int len, string format) {
			return ProxyQImage().LoadFromData(buf,len,format);
		}
		[SmokeMethod("loadFromData", "(const uchar*, int)", "$$")]
		public bool LoadFromData(char[] buf, int len) {
			return ProxyQImage().LoadFromData(buf,len);
		}
		[SmokeMethod("loadFromData", "(const QByteArray&, const char*)", "#$")]
		public bool LoadFromData(QByteArray data, string aformat) {
			return ProxyQImage().LoadFromData(data,aformat);
		}
		[SmokeMethod("loadFromData", "(const QByteArray&)", "#")]
		public bool LoadFromData(QByteArray data) {
			return ProxyQImage().LoadFromData(data);
		}
		[SmokeMethod("save", "(const QString&, const char*, int) const", "$$$")]
		public bool Save(string fileName, string format, int quality) {
			return ProxyQImage().Save(fileName,format,quality);
		}
		[SmokeMethod("save", "(const QString&, const char*) const", "$$")]
		public bool Save(string fileName, string format) {
			return ProxyQImage().Save(fileName,format);
		}
		[SmokeMethod("save", "(const QString&) const", "$")]
		public bool Save(string fileName) {
			return ProxyQImage().Save(fileName);
		}
		[SmokeMethod("save", "(QIODevice*, const char*, int) const", "#$$")]
		public bool Save(IQIODevice device, string format, int quality) {
			return ProxyQImage().Save(device,format,quality);
		}
		[SmokeMethod("save", "(QIODevice*, const char*) const", "#$")]
		public bool Save(IQIODevice device, string format) {
			return ProxyQImage().Save(device,format);
		}
		[SmokeMethod("save", "(QIODevice*) const", "#")]
		public bool Save(IQIODevice device) {
			return ProxyQImage().Save(device);
		}
		[SmokeMethod("serialNumber", "() const", "")]
		public int SerialNumber() {
			return ProxyQImage().SerialNumber();
		}
		[SmokeMethod("paintEngine", "() const", "")]
		public new QPaintEngine PaintEngine() {
			return ProxyQImage().PaintEngine();
		}
		[SmokeMethod("dotsPerMeterX", "() const", "")]
		public int DotsPerMeterX() {
			return ProxyQImage().DotsPerMeterX();
		}
		[SmokeMethod("dotsPerMeterY", "() const", "")]
		public int DotsPerMeterY() {
			return ProxyQImage().DotsPerMeterY();
		}
		[SmokeMethod("setDotsPerMeterX", "(int)", "$")]
		public void SetDotsPerMeterX(int arg1) {
			ProxyQImage().SetDotsPerMeterX(arg1);
		}
		[SmokeMethod("setDotsPerMeterY", "(int)", "$")]
		public void SetDotsPerMeterY(int arg1) {
			ProxyQImage().SetDotsPerMeterY(arg1);
		}
		[SmokeMethod("offset", "() const", "")]
		public QPoint Offset() {
			return ProxyQImage().Offset();
		}
		[SmokeMethod("setOffset", "(const QPoint&)", "#")]
		public void SetOffset(QPoint arg1) {
			ProxyQImage().SetOffset(arg1);
		}
		[SmokeMethod("textKeys", "() const", "")]
		public List<string> TextKeys() {
			return ProxyQImage().TextKeys();
		}
		[SmokeMethod("text", "(const QString&) const", "$")]
		public string Text(string key) {
			return ProxyQImage().Text(key);
		}
		[SmokeMethod("text", "() const", "")]
		public string Text() {
			return ProxyQImage().Text();
		}
		[SmokeMethod("setText", "(const QString&, const QString&)", "$$")]
		public void SetText(string key, string value) {
			ProxyQImage().SetText(key,value);
		}
		[SmokeMethod("text", "(const char*, const char*) const", "$$")]
		public string Text(string key, string lang) {
			return ProxyQImage().Text(key,lang);
		}
		// QList<QImageTextKeyLang> textList(); >>>> NOT CONVERTED
		[SmokeMethod("textLanguages", "() const", "")]
		public List<string> TextLanguages() {
			return ProxyQImage().TextLanguages();
		}
		// QString text(const QImageTextKeyLang& arg1); >>>> NOT CONVERTED
		[SmokeMethod("setText", "(const char*, const char*, const QString&)", "$$$")]
		public void SetText(string key, string lang, string arg3) {
			ProxyQImage().SetText(key,lang,arg3);
		}
		public static QMatrix TrueMatrix(QMatrix arg1, int w, int h) {
			return StaticQImage().TrueMatrix(arg1,w,h);
		}
		public static QImage FromData(char[] data, int size, string format) {
			return StaticQImage().FromData(data,size,format);
		}
		public static QImage FromData(char[] data, int size) {
			return StaticQImage().FromData(data,size);
		}
		public static QImage FromData(QByteArray data, string format) {
			return StaticQImage().FromData(data,format);
		}
		public static QImage FromData(QByteArray data) {
			return StaticQImage().FromData(data);
		}
		[SmokeMethod("metric", "(QPaintDevice::PaintDeviceMetric) const", "$")]
		protected new virtual int Metric(IQPaintDevice metric) {
			return ProxyQImage().Metric(metric);
		}
		~QImage() {
			DisposeQImage();
		}
		public void Dispose() {
			DisposeQImage();
		}
		[SmokeMethod("~QImage", "()", "")]
		private void DisposeQImage() {
			ProxyQImage().DisposeQImage();
		}
	}
}
