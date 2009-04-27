//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  @class TextBrowser plasma/widgets/TextBrowser.h <Plasma/Widgets/TextBrowser>
    ///  See <see cref="ITextBrowserSignals"></see> for signals emitted by TextBrowser
    /// </remarks>        <short> Provides a plasma-themed KTextBrowser. </short>
    [SmokeClass("Plasma::TextBrowser")]
    public class TextBrowser : QGraphicsProxyWidget, IDisposable {
        protected TextBrowser(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(TextBrowser), this);
        }
        [Q_PROPERTY("QGraphicsWidget*", "parentWidget")]
        public QGraphicsWidget ParentWidget {
            get { return (QGraphicsWidget) interceptor.Invoke("parentWidget", "parentWidget()", typeof(QGraphicsWidget)); }
        }
        [Q_PROPERTY("QString", "text")]
        public string Text {
            get { return (string) interceptor.Invoke("text", "text()", typeof(string)); }
            set { interceptor.Invoke("setText$", "setText(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QString", "stylesheet")]
        public string Stylesheet {
            get { return (string) interceptor.Invoke("styleSheet", "styleSheet()", typeof(string)); }
            set { interceptor.Invoke("setStyleSheet$", "setStyleSheet(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("KTextBrowser*", "nativeWidget")]
        public KTextBrowser NativeWidget {
            get { return (KTextBrowser) interceptor.Invoke("nativeWidget", "nativeWidget()", typeof(KTextBrowser)); }
        }
        public TextBrowser(QGraphicsWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("TextBrowser#", "TextBrowser(QGraphicsWidget*)", typeof(void), typeof(QGraphicsWidget), parent);
        }
        public TextBrowser() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("TextBrowser", "TextBrowser()", typeof(void));
        }
        [Q_SLOT("void dataUpdated(QString, Plasma::DataEngine::Data)")]
        public void DataUpdated(string sourceName, Dictionary<string, QVariant> data) {
            interceptor.Invoke("dataUpdated$?", "dataUpdated(const QString&, const QHash<QString,QVariant>&)", typeof(void), typeof(string), sourceName, typeof(Dictionary<string, QVariant>), data);
        }
        [SmokeMethod("resizeEvent(QGraphicsSceneResizeEvent*)")]
        protected override void ResizeEvent(QGraphicsSceneResizeEvent arg1) {
            interceptor.Invoke("resizeEvent#", "resizeEvent(QGraphicsSceneResizeEvent*)", typeof(void), typeof(QGraphicsSceneResizeEvent), arg1);
        }
        ~TextBrowser() {
            interceptor.Invoke("~TextBrowser", "~TextBrowser()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~TextBrowser", "~TextBrowser()", typeof(void));
        }
        protected new ITextBrowserSignals Emit {
            get { return (ITextBrowserSignals) Q_EMIT; }
        }
    }

    public interface ITextBrowserSignals : IQGraphicsProxyWidgetSignals {
        [Q_SIGNAL("void textChanged()")]
        void TextChanged();
    }
}
