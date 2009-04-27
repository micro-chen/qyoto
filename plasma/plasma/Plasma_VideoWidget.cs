//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    /// <remarks>
    ///  @class VideoWidget plasma/widgets/videowidget.h <Plasma/Widgets/VideoWidget>
    ///  a Video playing widget via Phonon, it encloses the
    ///  Phonon.MediaObject and Phonon.AudioOutput too
    ///  See <see cref="IVideoWidgetSignals"></see> for signals emitted by VideoWidget
    /// </remarks>        <short> Provides a video player widget.</short>
    [SmokeClass("Plasma::VideoWidget")]
    public class VideoWidget : QGraphicsProxyWidget, IDisposable {
        protected VideoWidget(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(VideoWidget), this);
        }
        public enum Control {
            NoControls = 0,
            Play = 1,
            Pause = 2,
            Stop = 4,
            PlayPause = 8,
            Previous = 16,
            Next = 32,
            Progress = 64,
            Volume = 128,
            OpenFile = 128,
            DefaultControls = PlayPause|Progress|Volume|OpenFile,
        }
        [Q_PROPERTY("QString", "url")]
        public string Url {
            get { return (string) interceptor.Invoke("url", "url()", typeof(string)); }
            set { interceptor.Invoke("setUrl$", "setUrl(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QString", "currentTime")]
        public string CurrentTime {
            get { return (string) interceptor.Invoke("currentTime", "currentTime()", typeof(string)); }
        }
        [Q_PROPERTY("QString", "totalTime")]
        public string TotalTime {
            get { return (string) interceptor.Invoke("totalTime", "totalTime()", typeof(string)); }
        }
        [Q_PROPERTY("QString", "remainingTime")]
        public string RemainingTime {
            get { return (string) interceptor.Invoke("remainingTime", "remainingTime()", typeof(string)); }
        }
        [Q_PROPERTY("Plasma::VideoWidget::Controls", "usedControls")]
        public uint UsedControls {
            get { return (uint) interceptor.Invoke("usedControls", "usedControls()", typeof(uint)); }
            set { interceptor.Invoke("setUsedControls$", "setUsedControls(Plasma::VideoWidget::Controls)", typeof(void), typeof(uint), value); }
        }
        [Q_PROPERTY("bool", "controlsVisible")]
        public bool ControlsVisible {
            get { return (bool) interceptor.Invoke("controlsVisible", "controlsVisible()", typeof(bool)); }
            set { interceptor.Invoke("setControlsVisible$", "setControlsVisible(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("QString", "styleSheet")]
        public string StyleSheet {
            get { return (string) interceptor.Invoke("styleSheet", "styleSheet()", typeof(string)); }
            set { interceptor.Invoke("setStyleSheet$", "setStyleSheet(QString)", typeof(void), typeof(string), value); }
        }
        // Phonon::MediaObject* mediaObject(); >>>> NOT CONVERTED
        // Phonon::AudioOutput* audioOutput(); >>>> NOT CONVERTED
        // Phonon::VideoWidget* nativeWidget(); >>>> NOT CONVERTED
        public VideoWidget(QGraphicsWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("VideoWidget#", "VideoWidget(QGraphicsWidget*)", typeof(void), typeof(QGraphicsWidget), parent);
        }
        public VideoWidget() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("VideoWidget", "VideoWidget()", typeof(void));
        }
        /// <remarks>
        /// </remarks>        <return> the Phonon.MediaObject being used
        /// </return>
        ///         <short>   </short>
        ///         <see> Phonon.MediaObject</see>
        /// <remarks>
        /// </remarks>        <return> the Phonon.AudioOutput being used
        /// </return>
        ///         <short>   </short>
        ///         <see> Phonon.AudioOutput</see>
        /// <remarks>
        /// </remarks>        <return> the native widget wrapped by this VideoWidget
        ///      </return>
        ///         <short>   </short>
        /// <remarks>
        ///  Play the current file
        ///      </remarks>        <short>    Play the current file      </short>
        [Q_SLOT("void play()")]
        public void Play() {
            interceptor.Invoke("play", "play()", typeof(void));
        }
        /// <remarks>
        ///  Pause the current file
        ///      </remarks>        <short>    Pause the current file      </short>
        [Q_SLOT("void pause()")]
        public void Pause() {
            interceptor.Invoke("pause", "pause()", typeof(void));
        }
        /// <remarks>
        ///  Stop the current file
        ///      </remarks>        <short>    Stop the current file      </short>
        [Q_SLOT("void stop()")]
        public void Stop() {
            interceptor.Invoke("stop", "stop()", typeof(void));
        }
        /// <remarks>
        ///  Jump at a given millisecond in the current file
        ///  @arg time where we want to jump
        ///      </remarks>        <short>    Jump at a given millisecond in the current file  @arg time where we want to jump      </short>
        [Q_SLOT("void seek(qint64)")]
        public void Seek(long time) {
            interceptor.Invoke("seek$", "seek(qint64)", typeof(void), typeof(long), time);
        }
        [SmokeMethod("resizeEvent(QGraphicsSceneResizeEvent*)")]
        protected override void ResizeEvent(QGraphicsSceneResizeEvent arg1) {
            interceptor.Invoke("resizeEvent#", "resizeEvent(QGraphicsSceneResizeEvent*)", typeof(void), typeof(QGraphicsSceneResizeEvent), arg1);
        }
        [SmokeMethod("hoverEnterEvent(QGraphicsSceneHoverEvent*)")]
        protected override void HoverEnterEvent(QGraphicsSceneHoverEvent arg1) {
            interceptor.Invoke("hoverEnterEvent#", "hoverEnterEvent(QGraphicsSceneHoverEvent*)", typeof(void), typeof(QGraphicsSceneHoverEvent), arg1);
        }
        [SmokeMethod("hoverLeaveEvent(QGraphicsSceneHoverEvent*)")]
        protected override void HoverLeaveEvent(QGraphicsSceneHoverEvent arg1) {
            interceptor.Invoke("hoverLeaveEvent#", "hoverLeaveEvent(QGraphicsSceneHoverEvent*)", typeof(void), typeof(QGraphicsSceneHoverEvent), arg1);
        }
        [SmokeMethod("hoverMoveEvent(QGraphicsSceneHoverEvent*)")]
        protected override void HoverMoveEvent(QGraphicsSceneHoverEvent arg1) {
            interceptor.Invoke("hoverMoveEvent#", "hoverMoveEvent(QGraphicsSceneHoverEvent*)", typeof(void), typeof(QGraphicsSceneHoverEvent), arg1);
        }
        ~VideoWidget() {
            interceptor.Invoke("~VideoWidget", "~VideoWidget()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~VideoWidget", "~VideoWidget()", typeof(void));
        }
        protected new IVideoWidgetSignals Emit {
            get { return (IVideoWidgetSignals) Q_EMIT; }
        }
    }

    public interface IVideoWidgetSignals : IQGraphicsProxyWidgetSignals {
        /// <remarks>
        ///  Emitted regularly when the playing is progressing
        ///  @arg time where we are
        ///      </remarks>        <short>    Emitted regularly when the playing is progressing  @arg time where we are      </short>
        [Q_SIGNAL("void tick(qint64)")]
        void Tick(long time);
        /// <remarks>
        ///  Emitted an instant before the playback is finished
        ///      </remarks>        <short>    Emitted an instant before the playback is finished      </short>
        [Q_SIGNAL("void aboutToFinish()")]
        void AboutToFinish();
        /// <remarks>
        ///  The user pressed the "next" button
        /// </remarks>        <short>    The user pressed the "next" button </short>
        [Q_SIGNAL("void nextRequested()")]
        void NextRequested();
        /// <remarks>
        ///  The user pressed the "previous" button
        /// </remarks>        <short>    The user pressed the "previous" button </short>
        [Q_SIGNAL("void previousRequested()")]
        void PreviousRequested();
    }
}
