//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQCheckBoxSignals"></see> for signals emitted by QCheckBox
    /// </remarks>
    [SmokeClass("QCheckBox")]
    public class QCheckBox : QAbstractButton, IDisposable {
        protected QCheckBox(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QCheckBox), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QCheckBox() {
            staticInterceptor = new SmokeInvocation(typeof(QCheckBox), null);
        }
        [Q_PROPERTY("bool", "tristate")]
        public bool Tristate {
            get { return (bool) interceptor.Invoke("isTristate", "isTristate()", typeof(bool)); }
            set { interceptor.Invoke("setTristate$", "setTristate(bool)", typeof(void), typeof(bool), value); }
        }
        public QCheckBox(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QCheckBox#", "QCheckBox(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public QCheckBox() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QCheckBox", "QCheckBox()", typeof(void));
        }
        public QCheckBox(string text, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QCheckBox$#", "QCheckBox(const QString&, QWidget*)", typeof(void), typeof(string), text, typeof(QWidget), parent);
        }
        public QCheckBox(string text) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QCheckBox$", "QCheckBox(const QString&)", typeof(void), typeof(string), text);
        }
        [SmokeMethod("sizeHint() const")]
        public override QSize SizeHint() {
            return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
        }
        public new Qt.CheckState CheckState() {
            return (Qt.CheckState) interceptor.Invoke("checkState", "checkState() const", typeof(Qt.CheckState));
        }
        public void SetCheckState(Qt.CheckState state) {
            interceptor.Invoke("setCheckState$", "setCheckState(Qt::CheckState)", typeof(void), typeof(Qt.CheckState), state);
        }
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent e) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
        }
        [SmokeMethod("hitButton(const QPoint&) const")]
        protected override bool HitButton(QPoint pos) {
            return (bool) interceptor.Invoke("hitButton#", "hitButton(const QPoint&) const", typeof(bool), typeof(QPoint), pos);
        }
        [SmokeMethod("checkStateSet()")]
        protected override void CheckStateSet() {
            interceptor.Invoke("checkStateSet", "checkStateSet()", typeof(void));
        }
        [SmokeMethod("nextCheckState()")]
        protected override void NextCheckState() {
            interceptor.Invoke("nextCheckState", "nextCheckState()", typeof(void));
        }
        [SmokeMethod("paintEvent(QPaintEvent*)")]
        protected override void PaintEvent(QPaintEvent arg1) {
            interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
        }
        [SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
        protected override void MouseMoveEvent(QMouseEvent arg1) {
            interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
        }
        protected void InitStyleOption(QStyleOptionButton option) {
            interceptor.Invoke("initStyleOption#", "initStyleOption(QStyleOptionButton*) const", typeof(void), typeof(QStyleOptionButton), option);
        }
        ~QCheckBox() {
            interceptor.Invoke("~QCheckBox", "~QCheckBox()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QCheckBox", "~QCheckBox()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQCheckBoxSignals Emit {
            get { return (IQCheckBoxSignals) Q_EMIT; }
        }
    }

    public interface IQCheckBoxSignals : IQAbstractButtonSignals {
        [Q_SIGNAL("void stateChanged(int)")]
        void StateChanged(int arg1);
    }
}