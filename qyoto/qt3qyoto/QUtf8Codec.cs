//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QUtf8Codec : QTextCodec, IDisposable {
 		protected QUtf8Codec(Type dummy) : base((Type) null) {}
		interface IQUtf8CodecProxy {
		}

		protected void CreateQUtf8CodecProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QUtf8Codec), this);
			_interceptor = (QUtf8Codec) realProxy.GetTransparentProxy();
		}
		private QUtf8Codec ProxyQUtf8Codec() {
			return (QUtf8Codec) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QUtf8Codec() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQUtf8CodecProxy), null);
			_staticInterceptor = (IQUtf8CodecProxy) realProxy.GetTransparentProxy();
		}
		private static IQUtf8CodecProxy StaticQUtf8Codec() {
			return (IQUtf8CodecProxy) _staticInterceptor;
		}

		public new virtual int MibEnum() {
			return ProxyQUtf8Codec().MibEnum();
		}
		public new string Name() {
			return ProxyQUtf8Codec().Name();
		}
		public new QTextDecoder MakeDecoder() {
			return ProxyQUtf8Codec().MakeDecoder();
		}
		public new string FromUnicode(string uc, out int lenInOut) {
			return ProxyQUtf8Codec().FromUnicode(uc,out lenInOut);
		}
		public new string ToUnicode(string chars, int len) {
			return ProxyQUtf8Codec().ToUnicode(chars,len);
		}
		public new int HeuristicContentMatch(string chars, int len) {
			return ProxyQUtf8Codec().HeuristicContentMatch(chars,len);
		}
		public QUtf8Codec() : this((Type) null) {
			CreateQUtf8CodecProxy();
			NewQUtf8Codec();
		}
		private void NewQUtf8Codec() {
			ProxyQUtf8Codec().NewQUtf8Codec();
		}
		~QUtf8Codec() {
			ProxyQUtf8Codec().Dispose();
		}
		public new void Dispose() {
			ProxyQUtf8Codec().Dispose();
		}
	}
}
