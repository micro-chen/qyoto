//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;

    public interface IQXmlDTDHandler {
        bool NotationDecl(string name, string publicId, string systemId);
        bool UnparsedEntityDecl(string name, string publicId, string systemId, string notationName);
        string ErrorString();
    }
    [SmokeClass("QXmlDTDHandler")]
    public abstract class QXmlDTDHandler : Object, IQXmlDTDHandler {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QXmlDTDHandler(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QXmlDTDHandler), this);
        }
        [SmokeMethod("notationDecl(const QString&, const QString&, const QString&)")]
        public abstract bool NotationDecl(string name, string publicId, string systemId);
        [SmokeMethod("unparsedEntityDecl(const QString&, const QString&, const QString&, const QString&)")]
        public abstract bool UnparsedEntityDecl(string name, string publicId, string systemId, string notationName);
        [SmokeMethod("errorString() const")]
        public abstract string ErrorString();
        public QXmlDTDHandler() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QXmlDTDHandler", "QXmlDTDHandler()", typeof(void));
        }
    }
}