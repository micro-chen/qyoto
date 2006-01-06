//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QSjisCodec")]
	public class QSjisCodec : QTextCodec, IDisposable {
 		protected QSjisCodec(Type dummy) : base((Type) null) {}
		interface IQSjisCodecProxy {
		}

		protected void CreateQSjisCodecProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSjisCodec), this);
			_interceptor = (QSjisCodec) realProxy.GetTransparentProxy();
		}
		private QSjisCodec ProxyQSjisCodec() {
			return (QSjisCodec) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSjisCodec() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSjisCodecProxy), null);
			_staticInterceptor = (IQSjisCodecProxy) realProxy.GetTransparentProxy();
		}
		private static IQSjisCodecProxy StaticQSjisCodec() {
			return (IQSjisCodecProxy) _staticInterceptor;
		}

		[SmokeMethod("mibEnum() const")]
		public new virtual int MibEnum() {
			return ProxyQSjisCodec().MibEnum();
		}
		[SmokeMethod("name() const")]
		public new string Name() {
			return ProxyQSjisCodec().Name();
		}
		[SmokeMethod("mimeName() const")]
		public new string MimeName() {
			return ProxyQSjisCodec().MimeName();
		}
		[SmokeMethod("makeDecoder() const")]
		public new QTextDecoder MakeDecoder() {
			return ProxyQSjisCodec().MakeDecoder();
		}
		[SmokeMethod("fromUnicode(const QString&, int&) const")]
		public new string FromUnicode(string uc, out int lenInOut) {
			return ProxyQSjisCodec().FromUnicode(uc,out lenInOut);
		}
		[SmokeMethod("toUnicode(const char*, int) const")]
		public new string ToUnicode(string chars, int len) {
			return ProxyQSjisCodec().ToUnicode(chars,len);
		}
		[SmokeMethod("heuristicContentMatch(const char*, int) const")]
		public new int HeuristicContentMatch(string chars, int len) {
			return ProxyQSjisCodec().HeuristicContentMatch(chars,len);
		}
		[SmokeMethod("heuristicNameMatch(const char*) const")]
		public new int HeuristicNameMatch(string hint) {
			return ProxyQSjisCodec().HeuristicNameMatch(hint);
		}
		public QSjisCodec() : this((Type) null) {
			CreateQSjisCodecProxy();
			NewQSjisCodec();
		}
		[SmokeMethod("QSjisCodec()")]
		private void NewQSjisCodec() {
			ProxyQSjisCodec().NewQSjisCodec();
		}
		~QSjisCodec() {
			DisposeQSjisCodec();
		}
		public new void Dispose() {
			DisposeQSjisCodec();
		}
		private void DisposeQSjisCodec() {
			ProxyQSjisCodec().DisposeQSjisCodec();
		}
	}
}
