//Auto-generated by kalyptus. DO NOT EDIT.
namespace QScintilla {

	using System;
	using Qyoto;

	[SmokeClass("QsciCommand")]
	public class QsciCommand : Object {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QsciCommand(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocationQsci(typeof(QsciCommand), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QsciCommand() {
			staticInterceptor = new SmokeInvocationQsci(typeof(QsciCommand), null);
		}
		public void SetKey(int key) {
			interceptor.Invoke("setKey$", "setKey(int)", typeof(void), typeof(int), key);
		}
		public void SetAlternateKey(int altkey) {
			interceptor.Invoke("setAlternateKey$", "setAlternateKey(int)", typeof(void), typeof(int), altkey);
		}
		public int Key() {
			return (int) interceptor.Invoke("key", "key() const", typeof(int));
		}
		public int AlternateKey() {
			return (int) interceptor.Invoke("alternateKey", "alternateKey() const", typeof(int));
		}
		public string Description() {
			return (string) interceptor.Invoke("description", "description() const", typeof(string));
		}
		public static bool ValidKey(int key) {
			return (bool) staticInterceptor.Invoke("validKey$", "validKey(int)", typeof(bool), typeof(int), key);
		}
	}
}