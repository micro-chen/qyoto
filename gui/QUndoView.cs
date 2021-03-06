//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QUndoView")]
    public class QUndoView : QListView, IDisposable {
        protected QUndoView(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QUndoView), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QUndoView() {
            staticInterceptor = new SmokeInvocation(typeof(QUndoView), null);
        }
        [Q_PROPERTY("QString", "emptyLabel")]
        public string EmptyLabel {
            get { return (string) interceptor.Invoke("emptyLabel", "emptyLabel()", typeof(string)); }
            set { interceptor.Invoke("setEmptyLabel$", "setEmptyLabel(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QIcon", "cleanIcon")]
        public QIcon CleanIcon {
            get { return (QIcon) interceptor.Invoke("cleanIcon", "cleanIcon()", typeof(QIcon)); }
            set { interceptor.Invoke("setCleanIcon#", "setCleanIcon(QIcon)", typeof(void), typeof(QIcon), value); }
        }
        public QUndoView(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QUndoView#", "QUndoView(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public QUndoView() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QUndoView", "QUndoView()", typeof(void));
        }
        public QUndoView(QUndoStack stack, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QUndoView##", "QUndoView(QUndoStack*, QWidget*)", typeof(void), typeof(QUndoStack), stack, typeof(QWidget), parent);
        }
        public QUndoView(QUndoStack stack) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QUndoView#", "QUndoView(QUndoStack*)", typeof(void), typeof(QUndoStack), stack);
        }
        public QUndoView(QUndoGroup group, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QUndoView##", "QUndoView(QUndoGroup*, QWidget*)", typeof(void), typeof(QUndoGroup), group, typeof(QWidget), parent);
        }
        public QUndoView(QUndoGroup group) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QUndoView#", "QUndoView(QUndoGroup*)", typeof(void), typeof(QUndoGroup), group);
        }
        public QUndoStack Stack() {
            return (QUndoStack) interceptor.Invoke("stack", "stack() const", typeof(QUndoStack));
        }
        public QUndoGroup Group() {
            return (QUndoGroup) interceptor.Invoke("group", "group() const", typeof(QUndoGroup));
        }
        [Q_SLOT("void setStack(QUndoStack*)")]
        public void SetStack(QUndoStack stack) {
            interceptor.Invoke("setStack#", "setStack(QUndoStack*)", typeof(void), typeof(QUndoStack), stack);
        }
        [Q_SLOT("void setGroup(QUndoGroup*)")]
        public void SetGroup(QUndoGroup group) {
            interceptor.Invoke("setGroup#", "setGroup(QUndoGroup*)", typeof(void), typeof(QUndoGroup), group);
        }
        ~QUndoView() {
            interceptor.Invoke("~QUndoView", "~QUndoView()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QUndoView", "~QUndoView()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQUndoViewSignals Emit {
            get { return (IQUndoViewSignals) Q_EMIT; }
        }
    }

    public interface IQUndoViewSignals : IQListViewSignals {
    }
}
