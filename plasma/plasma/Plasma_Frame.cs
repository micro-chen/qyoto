//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    /// <remarks>
    ///  @class Frame plasma/widgets/frame.h <Plasma/Widgets/Frame>
    ///  A simple frame to group widgets, it can have a plain, sunken or raise aspect
    ///  the default aspect is plain
    ///  </remarks>        <short> A widget that provides a simple frame.</short>
    [SmokeClass("Plasma::Frame")]
    public class Frame : QGraphicsWidget, IDisposable {
        protected Frame(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(Frame), this);
        }
        public enum Shadow {
            Plain = 1,
            Raised = 2,
            Sunken = 3,
        }
        [Q_PROPERTY("Plasma::Frame::Shadow", "frameShadow")]
        public Plasma.Frame.Shadow FrameShadow {
            get { return (Plasma.Frame.Shadow) interceptor.Invoke("frameShadow", "frameShadow()", typeof(Plasma.Frame.Shadow)); }
            set { interceptor.Invoke("setFrameShadow$", "setFrameShadow(Plasma::Frame::Shadow)", typeof(void), typeof(Plasma.Frame.Shadow), value); }
        }
        [Q_PROPERTY("QString", "text")]
        public string Text {
            get { return (string) interceptor.Invoke("text", "text()", typeof(string)); }
            set { interceptor.Invoke("setText$", "setText(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QString", "image")]
        public string Image {
            get { return (string) interceptor.Invoke("image", "image()", typeof(string)); }
            set { interceptor.Invoke("setImage$", "setImage(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QString", "styleSheet")]
        public string StyleSheet {
            get { return (string) interceptor.Invoke("styleSheet", "styleSheet()", typeof(string)); }
            set { interceptor.Invoke("setStyleSheet$", "setStyleSheet(QString)", typeof(void), typeof(string), value); }
        }
        /// <remarks>
        ///  Constructs a new Frame
        ///  @arg parent the parent of this widget
        ///      </remarks>        <short>    Constructs a new Frame </short>
        public Frame(QGraphicsWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Frame#", "Frame(QGraphicsWidget*)", typeof(void), typeof(QGraphicsWidget), parent);
        }
        public Frame() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Frame", "Frame()", typeof(void));
        }
        /// <remarks>
        /// </remarks>        <return> the native widget wrapped by this Frame
        ///      </return>
        ///         <short>   </short>
        public QWidget NativeWidget() {
            return (QWidget) interceptor.Invoke("nativeWidget", "nativeWidget() const", typeof(QWidget));
        }
        [SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
        protected new virtual void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
            interceptor.Invoke("paint###", "paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionGraphicsItem), option, typeof(QWidget), widget);
        }
        [SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*)")]
        protected new virtual void Paint(QPainter painter, QStyleOptionGraphicsItem option) {
            interceptor.Invoke("paint##", "paint(QPainter*, const QStyleOptionGraphicsItem*)", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionGraphicsItem), option);
        }
        [SmokeMethod("resizeEvent(QGraphicsSceneResizeEvent*)")]
        protected override void ResizeEvent(QGraphicsSceneResizeEvent arg1) {
            interceptor.Invoke("resizeEvent#", "resizeEvent(QGraphicsSceneResizeEvent*)", typeof(void), typeof(QGraphicsSceneResizeEvent), arg1);
        }
        [SmokeMethod("sizeHint(Qt::SizeHint, const QSizeF&) const")]
        public override QSizeF SizeHint(Qt.SizeHint which, QSizeF constraint) {
            return (QSizeF) interceptor.Invoke("sizeHint$#", "sizeHint(Qt::SizeHint, const QSizeF&) const", typeof(QSizeF), typeof(Qt.SizeHint), which, typeof(QSizeF), constraint);
        }
        ~Frame() {
            interceptor.Invoke("~Frame", "~Frame()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~Frame", "~Frame()", typeof(void));
        }
        protected new IFrameSignals Emit {
            get { return (IFrameSignals) Q_EMIT; }
        }
    }

    public interface IFrameSignals : IQGraphicsWidgetSignals {
    }
}
