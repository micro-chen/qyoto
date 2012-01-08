//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QKeyEvent")]
    public class QKeyEvent : QInputEvent, IDisposable {
        protected QKeyEvent(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QKeyEvent), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QKeyEvent() {
            staticInterceptor = new SmokeInvocation(typeof(QKeyEvent), null);
        }
        public QKeyEvent(QEvent.TypeOf type, int key, uint modifiers, string text, bool autorep, ushort count) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QKeyEvent$$$$$$", "QKeyEvent(QEvent::Type, int, Qt::KeyboardModifiers, const QString&, bool, unsigned short)", typeof(void), typeof(QEvent.TypeOf), type, typeof(int), key, typeof(uint), modifiers, typeof(string), text, typeof(bool), autorep, typeof(ushort), count);
        }
        public QKeyEvent(QEvent.TypeOf type, int key, uint modifiers, string text, bool autorep) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QKeyEvent$$$$$", "QKeyEvent(QEvent::Type, int, Qt::KeyboardModifiers, const QString&, bool)", typeof(void), typeof(QEvent.TypeOf), type, typeof(int), key, typeof(uint), modifiers, typeof(string), text, typeof(bool), autorep);
        }
        public QKeyEvent(QEvent.TypeOf type, int key, uint modifiers, string text) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QKeyEvent$$$$", "QKeyEvent(QEvent::Type, int, Qt::KeyboardModifiers, const QString&)", typeof(void), typeof(QEvent.TypeOf), type, typeof(int), key, typeof(uint), modifiers, typeof(string), text);
        }
        public QKeyEvent(QEvent.TypeOf type, int key, uint modifiers) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QKeyEvent$$$", "QKeyEvent(QEvent::Type, int, Qt::KeyboardModifiers)", typeof(void), typeof(QEvent.TypeOf), type, typeof(int), key, typeof(uint), modifiers);
        }
        public int Key() {
            return (int) interceptor.Invoke("key", "key() const", typeof(int));
        }
        public bool Matches(QKeySequence.StandardKey key) {
            return (bool) interceptor.Invoke("matches$", "matches(QKeySequence::StandardKey) const", typeof(bool), typeof(QKeySequence.StandardKey), key);
        }
        public new uint Modifiers() {
            return (uint) interceptor.Invoke("modifiers", "modifiers() const", typeof(uint));
        }
        public string Text() {
            return (string) interceptor.Invoke("text", "text() const", typeof(string));
        }
        public bool IsAutoRepeat() {
            return (bool) interceptor.Invoke("isAutoRepeat", "isAutoRepeat() const", typeof(bool));
        }
        public int Count() {
            return (int) interceptor.Invoke("count", "count() const", typeof(int));
        }
        public bool HasExtendedInfo() {
            return (bool) interceptor.Invoke("hasExtendedInfo", "hasExtendedInfo() const", typeof(bool));
        }
        public uint NativeScanCode() {
            return (uint) interceptor.Invoke("nativeScanCode", "nativeScanCode() const", typeof(uint));
        }
        public uint NativeVirtualKey() {
            return (uint) interceptor.Invoke("nativeVirtualKey", "nativeVirtualKey() const", typeof(uint));
        }
        public uint NativeModifiers() {
            return (uint) interceptor.Invoke("nativeModifiers", "nativeModifiers() const", typeof(uint));
        }
        ~QKeyEvent() {
            interceptor.Invoke("~QKeyEvent", "~QKeyEvent()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QKeyEvent", "~QKeyEvent()", typeof(void));
        }
        public override bool Equals(object o) {
            if (!(o is QKeyEvent)) { return false; }
            return this == (QKeyEvent) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        public static QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, uint modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers, string text, bool autorep, ushort count) {
            return (QKeyEvent) staticInterceptor.Invoke("createExtendedKeyEvent$$$$$$$$$", "createExtendedKeyEvent(QEvent::Type, int, Qt::KeyboardModifiers, unsigned int, unsigned int, unsigned int, const QString&, bool, unsigned short)", typeof(QKeyEvent), typeof(QEvent.TypeOf), type, typeof(int), key, typeof(uint), modifiers, typeof(uint), nativeScanCode, typeof(uint), nativeVirtualKey, typeof(uint), nativeModifiers, typeof(string), text, typeof(bool), autorep, typeof(ushort), count);
        }
        public static QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, uint modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers, string text, bool autorep) {
            return (QKeyEvent) staticInterceptor.Invoke("createExtendedKeyEvent$$$$$$$$", "createExtendedKeyEvent(QEvent::Type, int, Qt::KeyboardModifiers, unsigned int, unsigned int, unsigned int, const QString&, bool)", typeof(QKeyEvent), typeof(QEvent.TypeOf), type, typeof(int), key, typeof(uint), modifiers, typeof(uint), nativeScanCode, typeof(uint), nativeVirtualKey, typeof(uint), nativeModifiers, typeof(string), text, typeof(bool), autorep);
        }
        public static QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, uint modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers, string text) {
            return (QKeyEvent) staticInterceptor.Invoke("createExtendedKeyEvent$$$$$$$", "createExtendedKeyEvent(QEvent::Type, int, Qt::KeyboardModifiers, unsigned int, unsigned int, unsigned int, const QString&)", typeof(QKeyEvent), typeof(QEvent.TypeOf), type, typeof(int), key, typeof(uint), modifiers, typeof(uint), nativeScanCode, typeof(uint), nativeVirtualKey, typeof(uint), nativeModifiers, typeof(string), text);
        }
        public static QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, uint modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers) {
            return (QKeyEvent) staticInterceptor.Invoke("createExtendedKeyEvent$$$$$$", "createExtendedKeyEvent(QEvent::Type, int, Qt::KeyboardModifiers, unsigned int, unsigned int, unsigned int)", typeof(QKeyEvent), typeof(QEvent.TypeOf), type, typeof(int), key, typeof(uint), modifiers, typeof(uint), nativeScanCode, typeof(uint), nativeVirtualKey, typeof(uint), nativeModifiers);
        }
        public static bool operator==(QKeyEvent e, QKeySequence.StandardKey key) {
            return (bool) staticInterceptor.Invoke("operator==#$", "operator==(QKeyEvent*, QKeySequence::StandardKey)", typeof(bool), typeof(QKeyEvent), e, typeof(QKeySequence.StandardKey), key);
        }
        public static bool operator!=(QKeyEvent e, QKeySequence.StandardKey key) {
            return !(bool) staticInterceptor.Invoke("operator==#$", "operator==(QKeyEvent*, QKeySequence::StandardKey)", typeof(bool), typeof(QKeyEvent), e, typeof(QKeySequence.StandardKey), key);
        }
        public static bool operator==(QKeySequence.StandardKey key, QKeyEvent e) {
            return (bool) staticInterceptor.Invoke("operator==$#", "operator==(QKeySequence::StandardKey, QKeyEvent*)", typeof(bool), typeof(QKeySequence.StandardKey), key, typeof(QKeyEvent), e);
        }
        public static bool operator!=(QKeySequence.StandardKey key, QKeyEvent e) {
            return !(bool) staticInterceptor.Invoke("operator==$#", "operator==(QKeySequence::StandardKey, QKeyEvent*)", typeof(bool), typeof(QKeySequence.StandardKey), key, typeof(QKeyEvent), e);
        }
    }
}