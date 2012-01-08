//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QCryptographicHash")]
    public class QCryptographicHash : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QCryptographicHash(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QCryptographicHash), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QCryptographicHash() {
            staticInterceptor = new SmokeInvocation(typeof(QCryptographicHash), null);
        }
        public enum Algorithm {
            Md4 = 0,
            Md5 = 1,
            Sha1 = 2,
        }
        public QCryptographicHash(QCryptographicHash.Algorithm method) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QCryptographicHash$", "QCryptographicHash(QCryptographicHash::Algorithm)", typeof(void), typeof(QCryptographicHash.Algorithm), method);
        }
        public void Reset() {
            interceptor.Invoke("reset", "reset()", typeof(void));
        }
        public void AddData(string data, int length) {
            interceptor.Invoke("addData$$", "addData(const char*, int)", typeof(void), typeof(string), data, typeof(int), length);
        }
        public void AddData(QByteArray data) {
            interceptor.Invoke("addData#", "addData(const QByteArray&)", typeof(void), typeof(QByteArray), data);
        }
        public QByteArray Result() {
            return (QByteArray) interceptor.Invoke("result", "result() const", typeof(QByteArray));
        }
        ~QCryptographicHash() {
            interceptor.Invoke("~QCryptographicHash", "~QCryptographicHash()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QCryptographicHash", "~QCryptographicHash()", typeof(void));
        }
        public static QByteArray Hash(QByteArray data, QCryptographicHash.Algorithm method) {
            return (QByteArray) staticInterceptor.Invoke("hash#$", "hash(const QByteArray&, QCryptographicHash::Algorithm)", typeof(QByteArray), typeof(QByteArray), data, typeof(QCryptographicHash.Algorithm), method);
        }
    }
}