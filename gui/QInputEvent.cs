//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QInputEvent")]
    public class QInputEvent : QEvent, IDisposable {
        protected QInputEvent(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QInputEvent), this);
        }
        public QInputEvent(QEvent.TypeOf type, uint modifiers) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QInputEvent$$", "QInputEvent(QEvent::Type, Qt::KeyboardModifiers)", typeof(void), typeof(QEvent.TypeOf), type, typeof(uint), modifiers);
        }
        public QInputEvent(QEvent.TypeOf type) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QInputEvent$", "QInputEvent(QEvent::Type)", typeof(void), typeof(QEvent.TypeOf), type);
        }
        public uint Modifiers() {
            return (uint) interceptor.Invoke("modifiers", "modifiers() const", typeof(uint));
        }
        ~QInputEvent() {
            interceptor.Invoke("~QInputEvent", "~QInputEvent()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QInputEvent", "~QInputEvent()", typeof(void));
        }
    }
}
