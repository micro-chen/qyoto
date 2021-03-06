//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QNetworkCookie")]
    public class QNetworkCookie : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QNetworkCookie(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QNetworkCookie), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QNetworkCookie() {
            staticInterceptor = new SmokeInvocation(typeof(QNetworkCookie), null);
        }
        public enum RawForm {
            NameAndValueOnly = 0,
            Full = 1,
        }
        public QNetworkCookie(QByteArray name, QByteArray value) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QNetworkCookie##", "QNetworkCookie(const QByteArray&, const QByteArray&)", typeof(void), typeof(QByteArray), name, typeof(QByteArray), value);
        }
        public QNetworkCookie(QByteArray name) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QNetworkCookie#", "QNetworkCookie(const QByteArray&)", typeof(void), typeof(QByteArray), name);
        }
        public QNetworkCookie() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QNetworkCookie", "QNetworkCookie()", typeof(void));
        }
        public QNetworkCookie(QNetworkCookie other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QNetworkCookie#", "QNetworkCookie(const QNetworkCookie&)", typeof(void), typeof(QNetworkCookie), other);
        }
        public override bool Equals(object o) {
            if (!(o is QNetworkCookie)) { return false; }
            return this == (QNetworkCookie) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        public bool IsSecure() {
            return (bool) interceptor.Invoke("isSecure", "isSecure() const", typeof(bool));
        }
        public void SetSecure(bool enable) {
            interceptor.Invoke("setSecure$", "setSecure(bool)", typeof(void), typeof(bool), enable);
        }
        public bool IsHttpOnly() {
            return (bool) interceptor.Invoke("isHttpOnly", "isHttpOnly() const", typeof(bool));
        }
        public void SetHttpOnly(bool enable) {
            interceptor.Invoke("setHttpOnly$", "setHttpOnly(bool)", typeof(void), typeof(bool), enable);
        }
        public bool IsSessionCookie() {
            return (bool) interceptor.Invoke("isSessionCookie", "isSessionCookie() const", typeof(bool));
        }
        public QDateTime ExpirationDate() {
            return (QDateTime) interceptor.Invoke("expirationDate", "expirationDate() const", typeof(QDateTime));
        }
        public void SetExpirationDate(QDateTime date) {
            interceptor.Invoke("setExpirationDate#", "setExpirationDate(const QDateTime&)", typeof(void), typeof(QDateTime), date);
        }
        public string Domain() {
            return (string) interceptor.Invoke("domain", "domain() const", typeof(string));
        }
        public void SetDomain(string domain) {
            interceptor.Invoke("setDomain$", "setDomain(const QString&)", typeof(void), typeof(string), domain);
        }
        public string Path() {
            return (string) interceptor.Invoke("path", "path() const", typeof(string));
        }
        public void SetPath(string path) {
            interceptor.Invoke("setPath$", "setPath(const QString&)", typeof(void), typeof(string), path);
        }
        public QByteArray Name() {
            return (QByteArray) interceptor.Invoke("name", "name() const", typeof(QByteArray));
        }
        public void SetName(QByteArray cookieName) {
            interceptor.Invoke("setName#", "setName(const QByteArray&)", typeof(void), typeof(QByteArray), cookieName);
        }
        public QByteArray Value() {
            return (QByteArray) interceptor.Invoke("value", "value() const", typeof(QByteArray));
        }
        public void SetValue(QByteArray value) {
            interceptor.Invoke("setValue#", "setValue(const QByteArray&)", typeof(void), typeof(QByteArray), value);
        }
        public QByteArray ToRawForm(QNetworkCookie.RawForm form) {
            return (QByteArray) interceptor.Invoke("toRawForm$", "toRawForm(QNetworkCookie::RawForm) const", typeof(QByteArray), typeof(QNetworkCookie.RawForm), form);
        }
        public QByteArray ToRawForm() {
            return (QByteArray) interceptor.Invoke("toRawForm", "toRawForm() const", typeof(QByteArray));
        }
        ~QNetworkCookie() {
            interceptor.Invoke("~QNetworkCookie", "~QNetworkCookie()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QNetworkCookie", "~QNetworkCookie()", typeof(void));
        }
        public static bool operator==(QNetworkCookie lhs, QNetworkCookie other) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QNetworkCookie&) const", typeof(bool), typeof(QNetworkCookie), lhs, typeof(QNetworkCookie), other);
        }
        public static bool operator!=(QNetworkCookie lhs, QNetworkCookie other) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QNetworkCookie&) const", typeof(bool), typeof(QNetworkCookie), lhs, typeof(QNetworkCookie), other);
        }
        public static List<QNetworkCookie> ParseCookies(QByteArray cookieString) {
            return (List<QNetworkCookie>) staticInterceptor.Invoke("parseCookies#", "parseCookies(const QByteArray&)", typeof(List<QNetworkCookie>), typeof(QByteArray), cookieString);
        }
    }
}
