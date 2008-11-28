//Auto-generated by kalyptus. DO NOT EDIT.
namespace Nepomuk.Search {
    using Kimono;
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  \class Term term.h nepomuk/term.h
    ///  \brief A Query constist of Terms.
    ///  Queries are build from Term instances. A Term can have one of multiple
    ///  types and subterms. See Term.Type for details on the different Term types.
    ///  \author Sebastian Trueg <trueg@kde.org>
    ///          </remarks>        <short>    \class Term term.</short>
    [SmokeClass("Nepomuk::Search::Term")]
    public class Term : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected Term(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(Term), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static Term() {
            staticInterceptor = new SmokeInvocation(typeof(Term), null);
        }
        /// <remarks>
        ///  Each search term has a type.
        ///              </remarks>        <short>    Each search term has a type.</short>
        public enum TypeOf {
            InvalidTerm = 0,
            LiteralTerm = 1,
            ResourceTerm = 2,
            AndTerm = 3,
            OrTerm = 4,
            ComparisonTerm = 5,
        }
        public enum Comparator {
            Contains = 0,
            Equal = 1,
            Greater = 2,
            Smaller = 3,
            GreaterOrEqual = 4,
            SmallerOrEqual = 5,
        }
        /// <remarks>
        ///  Constructs an invalid term.
        ///              </remarks>        <short>    Constructs an invalid term.</short>
        public Term() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Term", "Term()", typeof(void));
        }
        /// <remarks>
        ///  Copy constructor.
        ///              </remarks>        <short>    Copy constructor.</short>
        public Term(Nepomuk.Search.Term other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Term#", "Term(const Nepomuk::Search::Term&)", typeof(void), typeof(Nepomuk.Search.Term), other);
        }
        /// <remarks>
        ///  Construct a literal term.
        ///              </remarks>        <short>    Construct a literal term.</short>
        public Term(Soprano.LiteralValue value) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Term#", "Term(const Soprano::LiteralValue&)", typeof(void), typeof(Soprano.LiteralValue), value);
        }
        /// <remarks>
        ///  Construct a resource term.
        ///              </remarks>        <short>    Construct a resource term.</short>
        public Term(QUrl resource) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Term#", "Term(const QUrl&)", typeof(void), typeof(QUrl), resource);
        }
        /// <remarks>
        ///  Construct a Contains ComparisonTerm term.
        ///  \param field A string that will be matched against a field label
        ///  \param value A value that will be matched against the field value. Unsupported
        ///         types are converted to string.
        ///  \param comparator The Comparator to use
        ///              </remarks>        <short>    Construct a Contains ComparisonTerm term.</short>
        public Term(string field, Soprano.LiteralValue value, Nepomuk.Search.Term.Comparator c) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Term$#$", "Term(const QString&, const Soprano::LiteralValue&, Nepomuk::Search::Term::Comparator)", typeof(void), typeof(string), field, typeof(Soprano.LiteralValue), value, typeof(Nepomuk.Search.Term.Comparator), c);
        }
        public Term(string field, Soprano.LiteralValue value) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Term$#", "Term(const QString&, const Soprano::LiteralValue&)", typeof(void), typeof(string), field, typeof(Soprano.LiteralValue), value);
        }
        /// <remarks>
        ///  Construct a Contains ComparisonTerm term.
        ///  \param field The exact field to match
        ///  \param value A value that will be matched against the field value. Unsupported
        ///         types are converted to string.
        ///  \param comparator The Comparator to use
        ///              </remarks>        <short>    Construct a Contains ComparisonTerm term.</short>
        public Term(QUrl field, Soprano.LiteralValue value, Nepomuk.Search.Term.Comparator c) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Term##$", "Term(const QUrl&, const Soprano::LiteralValue&, Nepomuk::Search::Term::Comparator)", typeof(void), typeof(QUrl), field, typeof(Soprano.LiteralValue), value, typeof(Nepomuk.Search.Term.Comparator), c);
        }
        public Term(QUrl field, Soprano.LiteralValue value) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Term##", "Term(const QUrl&, const Soprano::LiteralValue&)", typeof(void), typeof(QUrl), field, typeof(Soprano.LiteralValue), value);
        }
        /// <remarks>
        ///  Construct an EqualityTerm term.
        ///  \param field The exact field to match
        ///  \param value The resource that should be matched.
        ///              </remarks>        <short>    Construct an EqualityTerm term.</short>
        public Term(QUrl field, QUrl resource) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Term##", "Term(const QUrl&, const QUrl&)", typeof(void), typeof(QUrl), field, typeof(QUrl), resource);
        }
        /// <remarks>
        ///  \return <pre>true</pre> if the Term is valid.
        ///              </remarks>        <short>    \return \p true if the Term is valid.</short>
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        /// <remarks>
        ///  \return the Term type.
        ///  \sa setType
        ///              </remarks>        <short>    \return the Term type.</short>
        public Nepomuk.Search.Term.TypeOf type() {
            return (Nepomuk.Search.Term.TypeOf) interceptor.Invoke("type", "type() const", typeof(Nepomuk.Search.Term.TypeOf));
        }
        /// <remarks>
        ///  The literal value of a LiteralTerm.
        ///  \sa setValue
        ///              </remarks>        <short>    The literal value of a LiteralTerm.</short>
        public Soprano.LiteralValue Value() {
            return (Soprano.LiteralValue) interceptor.Invoke("value", "value() const", typeof(Soprano.LiteralValue));
        }
        /// <remarks>
        ///  The resource of a ResourceTerm
        ///  \sa setResource
        ///              </remarks>        <short>    The resource of a ResourceTerm </short>
        public QUrl Resource() {
            return (QUrl) interceptor.Invoke("resource", "resource() const", typeof(QUrl));
        }
        /// <remarks>
        ///  The Comparator used by ComparisonTerm Terms.
        ///  \sa setComparator
        ///              </remarks>        <short>    The Comparator used by ComparisonTerm Terms.</short>
        public Nepomuk.Search.Term.Comparator comparator() {
            return (Nepomuk.Search.Term.Comparator) interceptor.Invoke("comparator", "comparator() const", typeof(Nepomuk.Search.Term.Comparator));
        }
        /// <remarks>
        ///  A property name used for ComparisonTerm Terms. Will be matched against
        ///  the rdfs:label to find the corresponding property.
        ///  \sa setField, property, setProperty
        ///              </remarks>        <short>    A property name used for ComparisonTerm Terms.</short>
        public string Field() {
            return (string) interceptor.Invoke("field", "field() const", typeof(string));
        }
        /// <remarks>
        ///  A property used for ComparisonTerm Terms.
        ///  \sa setProperty, field, setField
        ///              </remarks>        <short>    A property used for ComparisonTerm Terms.</short>
        public QUrl Property() {
            return (QUrl) interceptor.Invoke("property", "property() const", typeof(QUrl));
        }
        /// <remarks>
        ///  The sub terms  used by AndTerm, OrTerm, and ComparisonTerm.
        ///  \sa setSubTerms, addSubTerm
        ///              </remarks>        <short>    The sub terms  used by AndTerm, OrTerm, and ComparisonTerm.</short>
        public List<Nepomuk.Search.Term> SubTerms() {
            return (List<Nepomuk.Search.Term>) interceptor.Invoke("subTerms", "subTerms() const", typeof(List<Nepomuk.Search.Term>));
        }
        /// <remarks>
        ///  Set the type of the Term
        ///              </remarks>        <short>    Set the type of the Term              </short>
        public void SetType(Nepomuk.Search.Term.TypeOf arg1) {
            interceptor.Invoke("setType$", "setType(Nepomuk::Search::Term::Type)", typeof(void), typeof(Nepomuk.Search.Term.TypeOf), arg1);
        }
        /// <remarks>
        ///  Set the value of a LiteralTerm
        ///              </remarks>        <short>    Set the value of a LiteralTerm              </short>
        public void SetValue(Soprano.LiteralValue arg1) {
            interceptor.Invoke("setValue#", "setValue(const Soprano::LiteralValue&)", typeof(void), typeof(Soprano.LiteralValue), arg1);
        }
        /// <remarks>
        ///  Set the resource of a ResourceTerm
        ///              </remarks>        <short>    Set the resource of a ResourceTerm              </short>
        public void SetResource(QUrl arg1) {
            interceptor.Invoke("setResource#", "setResource(const QUrl&)", typeof(void), typeof(QUrl), arg1);
        }
        /// <remarks>
        ///  Defaults to Equal
        ///              </remarks>        <short>    Defaults to Equal              </short>
        public void SetComparator(Nepomuk.Search.Term.Comparator arg1) {
            interceptor.Invoke("setComparator$", "setComparator(Nepomuk::Search::Term::Comparator)", typeof(void), typeof(Nepomuk.Search.Term.Comparator), arg1);
        }
        /// <remarks>
        ///  Set the property label in case the exact
        ///  property is not known. Will be mached against
        ///  the property's rdfs:label.
        ///  \sa field, setProperty, property
        ///              </remarks>        <short>    Set the property label in case the exact  property is not known.</short>
        public void SetField(string arg1) {
            interceptor.Invoke("setField$", "setField(const QString&)", typeof(void), typeof(string), arg1);
        }
        /// <remarks>
        ///  Set the property for ComparisonTerm
        ///  Terms.
        ///  If the exact property is not known use setField.
        ///  \sa property
        ///              </remarks>        <short>    Set the property for ComparisonTerm  Terms.</short>
        public void SetProperty(QUrl arg1) {
            interceptor.Invoke("setProperty#", "setProperty(const QUrl&)", typeof(void), typeof(QUrl), arg1);
        }
        /// <remarks>
        ///  Set the subterms used by AndTerm, OrTerm, and ComparisonTerm.
        ///  \sa addSubTerm
        ///              </remarks>        <short>    Set the subterms used by AndTerm, OrTerm, and ComparisonTerm.</short>
        public void SetSubTerms(List<Nepomuk.Search.Term> arg1) {
            interceptor.Invoke("setSubTerms?", "setSubTerms(const QList<Nepomuk::Search::Term>&)", typeof(void), typeof(List<Nepomuk.Search.Term>), arg1);
        }
        /// <remarks>
        ///  Add a subterm used by AndTerm, OrTerm, and ComparisonTerm.
        ///  \sa setSubTerm
        ///              </remarks>        <short>    Add a subterm used by AndTerm, OrTerm, and ComparisonTerm.</short>
        public void AddSubTerm(Nepomuk.Search.Term arg1) {
            interceptor.Invoke("addSubTerm#", "addSubTerm(const Nepomuk::Search::Term&)", typeof(void), typeof(Nepomuk.Search.Term), arg1);
        }
        /// <remarks>
        ///  Comparison operator.
        ///              </remarks>        <short>    Comparison operator.</short>
        public override bool Equals(object o) {
            if (!(o is Term)) { return false; }
            return this == (Term) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        ~Term() {
            interceptor.Invoke("~Term", "~Term()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~Term", "~Term()", typeof(void));
        }
        public static bool operator==(Term lhs, Nepomuk.Search.Term arg1) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const Nepomuk::Search::Term&) const", typeof(bool), typeof(Term), lhs, typeof(Nepomuk.Search.Term), arg1);
        }
        public static bool operator!=(Term lhs, Nepomuk.Search.Term arg1) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const Nepomuk::Search::Term&) const", typeof(bool), typeof(Term), lhs, typeof(Nepomuk.Search.Term), arg1);
        }
    }
}