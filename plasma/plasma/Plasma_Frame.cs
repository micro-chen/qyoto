//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    /// <remarks>
    /// </remarks>        <short> A widget that provides a simple frame  A simple frame to group widgets, it can have a plain, sunken or raise aspect  the default aspect is plain.</short>
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
        ///  Sets the Frame's shadow style
        ///  @arg shadow plain, raised or sunken
        ///     </remarks>        <short>    Sets the Frame's shadow style </short>
        public void SetFrameShadow(Plasma.Frame.Shadow shadow) {
            interceptor.Invoke("setFrameShadow$", "setFrameShadow(Plasma::Frame::Shadow)", typeof(void), typeof(Plasma.Frame.Shadow), shadow);
        }
        /// <remarks>
        /// </remarks>        <return> the Frame's shadow style
        ///     </return>
        ///         <short>   </short>
        public Plasma.Frame.Shadow FrameShadow() {
            return (Plasma.Frame.Shadow) interceptor.Invoke("frameShadow", "frameShadow() const", typeof(Plasma.Frame.Shadow));
        }
        /// <remarks>
        ///  Set the text to display by this Frame
        ///  @arg text the text
        ///     </remarks>        <short>    Set the text to display by this Frame </short>
        public void SetText(string text) {
            interceptor.Invoke("setText$", "setText(QString)", typeof(void), typeof(string), text);
        }
        /// <remarks>
        /// </remarks>        <return> text displayed from this Frame
        ///     </return>
        ///         <short>   </short>
        public string Text() {
            return (string) interceptor.Invoke("text", "text() const", typeof(string));
        }
        /// <remarks>
        ///  Sets the path to an image to display.
        ///  @arg path the path to the image; if a relative path, then a themed image will be loaded.
        ///      </remarks>        <short>    Sets the path to an image to display.</short>
        public void SetImage(string path) {
            interceptor.Invoke("setImage$", "setImage(const QString&)", typeof(void), typeof(string), path);
        }
        /// <remarks>
        /// </remarks>        <return> the image path being displayed currently, or an empty string if none.
        ///      </return>
        ///         <short>   </short>
        public string Image() {
            return (string) interceptor.Invoke("image", "image() const", typeof(string));
        }
        /// <remarks>
        ///  Sets the stylesheet used to control the visual display of this Frame
        ///  @arg stylesheet a CSS string
        ///      </remarks>        <short>    Sets the stylesheet used to control the visual display of this Frame </short>
        public void SetStyleSheet(string stylesheet) {
            interceptor.Invoke("setStyleSheet$", "setStyleSheet(const QString&)", typeof(void), typeof(string), stylesheet);
        }
        /// <remarks>
        /// </remarks>        <return> the stylesheet currently used with this widget
        ///      </return>
        ///         <short>   </short>
        public string StyleSheet() {
            return (string) interceptor.Invoke("styleSheet", "styleSheet() const", typeof(string));
        }
        /// <remarks>
        /// </remarks>        <return> the native widget wrapped by this Label
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
