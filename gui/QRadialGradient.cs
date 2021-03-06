//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QRadialGradient")]
    public class QRadialGradient : QGradient, IDisposable {
        protected QRadialGradient(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QRadialGradient), this);
        }
        public QRadialGradient() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QRadialGradient", "QRadialGradient()", typeof(void));
        }
        public QRadialGradient(QPointF center, double radius, QPointF focalPoint) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QRadialGradient#$#", "QRadialGradient(const QPointF&, qreal, const QPointF&)", typeof(void), typeof(QPointF), center, typeof(double), radius, typeof(QPointF), focalPoint);
        }
        public QRadialGradient(double cx, double cy, double radius, double fx, double fy) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QRadialGradient$$$$$", "QRadialGradient(qreal, qreal, qreal, qreal, qreal)", typeof(void), typeof(double), cx, typeof(double), cy, typeof(double), radius, typeof(double), fx, typeof(double), fy);
        }
        public QRadialGradient(QPointF center, double radius) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QRadialGradient#$", "QRadialGradient(const QPointF&, qreal)", typeof(void), typeof(QPointF), center, typeof(double), radius);
        }
        public QRadialGradient(double cx, double cy, double radius) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QRadialGradient$$$", "QRadialGradient(qreal, qreal, qreal)", typeof(void), typeof(double), cx, typeof(double), cy, typeof(double), radius);
        }
        public QPointF Center() {
            return (QPointF) interceptor.Invoke("center", "center() const", typeof(QPointF));
        }
        public void SetCenter(QPointF center) {
            interceptor.Invoke("setCenter#", "setCenter(const QPointF&)", typeof(void), typeof(QPointF), center);
        }
        public void SetCenter(double x, double y) {
            interceptor.Invoke("setCenter$$", "setCenter(qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y);
        }
        public QPointF FocalPoint() {
            return (QPointF) interceptor.Invoke("focalPoint", "focalPoint() const", typeof(QPointF));
        }
        public void SetFocalPoint(QPointF focalPoint) {
            interceptor.Invoke("setFocalPoint#", "setFocalPoint(const QPointF&)", typeof(void), typeof(QPointF), focalPoint);
        }
        public void SetFocalPoint(double x, double y) {
            interceptor.Invoke("setFocalPoint$$", "setFocalPoint(qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y);
        }
        public double Radius() {
            return (double) interceptor.Invoke("radius", "radius() const", typeof(double));
        }
        public void SetRadius(double radius) {
            interceptor.Invoke("setRadius$", "setRadius(qreal)", typeof(void), typeof(double), radius);
        }
        ~QRadialGradient() {
            interceptor.Invoke("~QRadialGradient", "~QRadialGradient()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QRadialGradient", "~QRadialGradient()", typeof(void));
        }
    }
}
