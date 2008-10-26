//Auto-generated by kalyptus. DO NOT EDIT.
namespace Nepomuk.Types {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  \brief Defines a literal type based on XML Schema.
    ///  Each valid Literal represents the literal type
    ///  as XML Schema URI and as QVariant type.
    ///          </remarks>        <short>    \brief Defines a literal type based on XML Schema.</short>
    [SmokeClass("Nepomuk::Types::Literal")]
    public class Literal : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected Literal(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(Literal), this);
        }
        /// <remarks>
        ///  Default constructor.
        ///  Creates an empty Literal
        /// 	     </remarks>        <short>    Default constructor.</short>
        public Literal() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Literal", "Literal()", typeof(void));
        }
        public Literal(Nepomuk.Types.Literal arg1) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Literal#", "Literal(const Nepomuk::Types::Literal&)", typeof(void), typeof(Nepomuk.Types.Literal), arg1);
        }
        public Literal(QUrl dataTypeUri) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Literal#", "Literal(const QUrl&)", typeof(void), typeof(QUrl), dataTypeUri);
        }
        /// <remarks>
        ///  The XML Schema type URI.
        /// 	     </remarks>        <short>    The XML Schema type URI.</short>
        public QUrl DataTypeUri() {
            return (QUrl) interceptor.Invoke("dataTypeUri", "dataTypeUri() const", typeof(QUrl));
        }
        /// <remarks>
        ///  The type converted to a QVariant.Type.
        ///  \return The QVariant.Type that corresponds to the XML Schema type or
        ///  QVariant.Invalid if it could not be matched.
        /// 	     </remarks>        <short>    The type converted to a QVariant.Type.</short>
        public QVariant.TypeOf DataType() {
            return (QVariant.TypeOf) interceptor.Invoke("dataType", "dataType() const", typeof(QVariant.TypeOf));
        }
        /// <remarks>
        ///  Is this a valid Literal, i.e. has it a valid URI.
        ///              </remarks>        <short>    Is this a valid Literal, i.</short>
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        ~Literal() {
            interceptor.Invoke("~Literal", "~Literal()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~Literal", "~Literal()", typeof(void));
        }
    }
}