//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QTextFrameLayoutData")]
    public class QTextFrameLayoutData : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QTextFrameLayoutData(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QTextFrameLayoutData), this);
        }
        public QTextFrameLayoutData() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextFrameLayoutData", "QTextFrameLayoutData()", typeof(void));
        }
        ~QTextFrameLayoutData() {
            interceptor.Invoke("~QTextFrameLayoutData", "~QTextFrameLayoutData()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QTextFrameLayoutData", "~QTextFrameLayoutData()", typeof(void));
        }
    }
}