//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    /// <remarks> See <see cref="IQTextDocumentSignals"></see> for signals emitted by QTextDocument
    /// </remarks>
    [SmokeClass("QTextDocument")]
    public class QTextDocument : QObject, IDisposable {
        protected QTextDocument(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QTextDocument), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QTextDocument() {
            staticInterceptor = new SmokeInvocation(typeof(QTextDocument), null);
        }
        public enum MetaInformation {
            DocumentTitle = 0,
            DocumentUrl = 1,
        }
        public enum FindFlag {
            FindBackward = 0x00001,
            FindCaseSensitively = 0x00002,
            FindWholeWords = 0x00004,
        }
        public enum ResourceType {
            HtmlResource = 1,
            ImageResource = 2,
            StyleSheetResource = 3,
            UserResource = 100,
        }
        [Q_PROPERTY("bool", "undoRedoEnabled")]
        public bool UndoRedoEnabled {
            get { return (bool) interceptor.Invoke("isUndoRedoEnabled", "isUndoRedoEnabled()", typeof(bool)); }
            set { interceptor.Invoke("setUndoRedoEnabled$", "setUndoRedoEnabled(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("bool", "modified")]
        public bool Modified {
            get { return (bool) interceptor.Invoke("isModified", "isModified()", typeof(bool)); }
            set { interceptor.Invoke("setModified$", "setModified(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("QSizeF", "pageSize")]
        public QSizeF PageSize {
            get { return (QSizeF) interceptor.Invoke("pageSize", "pageSize()", typeof(QSizeF)); }
            set { interceptor.Invoke("setPageSize#", "setPageSize(QSizeF)", typeof(void), typeof(QSizeF), value); }
        }
        [Q_PROPERTY("QFont", "defaultFont")]
        public QFont DefaultFont {
            get { return (QFont) interceptor.Invoke("defaultFont", "defaultFont()", typeof(QFont)); }
            set { interceptor.Invoke("setDefaultFont#", "setDefaultFont(QFont)", typeof(void), typeof(QFont), value); }
        }
        [Q_PROPERTY("bool", "useDesignMetrics")]
        public bool UseDesignMetrics {
            get { return (bool) interceptor.Invoke("useDesignMetrics", "useDesignMetrics()", typeof(bool)); }
            set { interceptor.Invoke("setUseDesignMetrics$", "setUseDesignMetrics(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("QSizeF", "size")]
        public QSizeF Size {
            get { return (QSizeF) interceptor.Invoke("size", "size()", typeof(QSizeF)); }
        }
        [Q_PROPERTY("qreal", "textWidth")]
        public double TextWidth {
            get { return (double) interceptor.Invoke("textWidth", "textWidth()", typeof(double)); }
            set { interceptor.Invoke("setTextWidth$", "setTextWidth(qreal)", typeof(void), typeof(double), value); }
        }
        [Q_PROPERTY("int", "blockCount")]
        public int BlockCount {
            get { return (int) interceptor.Invoke("blockCount", "blockCount()", typeof(int)); }
        }
        [Q_PROPERTY("qreal", "indentWidth")]
        public double IndentWidth {
            get { return (double) interceptor.Invoke("indentWidth", "indentWidth()", typeof(double)); }
            set { interceptor.Invoke("setIndentWidth$", "setIndentWidth(qreal)", typeof(void), typeof(double), value); }
        }
        [Q_PROPERTY("QString", "defaultStyleSheet")]
        public string DefaultStyleSheet {
            get { return (string) interceptor.Invoke("defaultStyleSheet", "defaultStyleSheet()", typeof(string)); }
            set { interceptor.Invoke("setDefaultStyleSheet$", "setDefaultStyleSheet(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("int", "maximumBlockCount")]
        public int MaximumBlockCount {
            get { return (int) interceptor.Invoke("maximumBlockCount", "maximumBlockCount()", typeof(int)); }
            set { interceptor.Invoke("setMaximumBlockCount$", "setMaximumBlockCount(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("qreal", "documentMargin")]
        public double DocumentMargin {
            get { return (double) interceptor.Invoke("documentMargin", "documentMargin()", typeof(double)); }
            set { interceptor.Invoke("setDocumentMargin$", "setDocumentMargin(qreal)", typeof(void), typeof(double), value); }
        }
        [Q_PROPERTY("QTextOption", "defaultTextOption")]
        public QTextOption DefaultTextOption {
            get { return (QTextOption) interceptor.Invoke("defaultTextOption", "defaultTextOption()", typeof(QTextOption)); }
            set { interceptor.Invoke("setDefaultTextOption#", "setDefaultTextOption(QTextOption)", typeof(void), typeof(QTextOption), value); }
        }
        // QTextDocumentPrivate* docHandle(); >>>> NOT CONVERTED
        // void appendUndoItem(QAbstractUndoItem* arg1); >>>> NOT CONVERTED
        // QTextDocument* QTextDocument(QTextDocumentPrivate& arg1,QObject* arg2); >>>> NOT CONVERTED
        public QTextDocument(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextDocument#", "QTextDocument(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QTextDocument() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextDocument", "QTextDocument()", typeof(void));
        }
        public QTextDocument(string text, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextDocument$#", "QTextDocument(const QString&, QObject*)", typeof(void), typeof(string), text, typeof(QObject), parent);
        }
        public QTextDocument(string text) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextDocument$", "QTextDocument(const QString&)", typeof(void), typeof(string), text);
        }
        public QTextDocument Clone(QObject parent) {
            return (QTextDocument) interceptor.Invoke("clone#", "clone(QObject*) const", typeof(QTextDocument), typeof(QObject), parent);
        }
        public QTextDocument Clone() {
            return (QTextDocument) interceptor.Invoke("clone", "clone() const", typeof(QTextDocument));
        }
        public bool IsEmpty() {
            return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
        }
        [SmokeMethod("clear()")]
        public virtual void Clear() {
            interceptor.Invoke("clear", "clear()", typeof(void));
        }
        public bool IsUndoAvailable() {
            return (bool) interceptor.Invoke("isUndoAvailable", "isUndoAvailable() const", typeof(bool));
        }
        public bool IsRedoAvailable() {
            return (bool) interceptor.Invoke("isRedoAvailable", "isRedoAvailable() const", typeof(bool));
        }
        public int Revision() {
            return (int) interceptor.Invoke("revision", "revision() const", typeof(int));
        }
        public void SetDocumentLayout(QAbstractTextDocumentLayout layout) {
            interceptor.Invoke("setDocumentLayout#", "setDocumentLayout(QAbstractTextDocumentLayout*)", typeof(void), typeof(QAbstractTextDocumentLayout), layout);
        }
        public QAbstractTextDocumentLayout DocumentLayout() {
            return (QAbstractTextDocumentLayout) interceptor.Invoke("documentLayout", "documentLayout() const", typeof(QAbstractTextDocumentLayout));
        }
        public void SetMetaInformation(QTextDocument.MetaInformation info, string arg2) {
            interceptor.Invoke("setMetaInformation$$", "setMetaInformation(QTextDocument::MetaInformation, const QString&)", typeof(void), typeof(QTextDocument.MetaInformation), info, typeof(string), arg2);
        }
        public string metaInformation(QTextDocument.MetaInformation info) {
            return (string) interceptor.Invoke("metaInformation$", "metaInformation(QTextDocument::MetaInformation) const", typeof(string), typeof(QTextDocument.MetaInformation), info);
        }
        public string ToHtml(QByteArray encoding) {
            return (string) interceptor.Invoke("toHtml#", "toHtml(const QByteArray&) const", typeof(string), typeof(QByteArray), encoding);
        }
        public string ToHtml() {
            return (string) interceptor.Invoke("toHtml", "toHtml() const", typeof(string));
        }
        public void SetHtml(string html) {
            interceptor.Invoke("setHtml$", "setHtml(const QString&)", typeof(void), typeof(string), html);
        }
        public string ToPlainText() {
            return (string) interceptor.Invoke("toPlainText", "toPlainText() const", typeof(string));
        }
        public void SetPlainText(string text) {
            interceptor.Invoke("setPlainText$", "setPlainText(const QString&)", typeof(void), typeof(string), text);
        }
        public QChar CharacterAt(int pos) {
            return (QChar) interceptor.Invoke("characterAt$", "characterAt(int) const", typeof(QChar), typeof(int), pos);
        }
        public QTextCursor Find(string subString, int from, uint options) {
            return (QTextCursor) interceptor.Invoke("find$$$", "find(const QString&, int, QTextDocument::FindFlags) const", typeof(QTextCursor), typeof(string), subString, typeof(int), from, typeof(uint), options);
        }
        public QTextCursor Find(string subString, int from) {
            return (QTextCursor) interceptor.Invoke("find$$", "find(const QString&, int) const", typeof(QTextCursor), typeof(string), subString, typeof(int), from);
        }
        public QTextCursor Find(string subString) {
            return (QTextCursor) interceptor.Invoke("find$", "find(const QString&) const", typeof(QTextCursor), typeof(string), subString);
        }
        public QTextCursor Find(string subString, QTextCursor from, uint options) {
            return (QTextCursor) interceptor.Invoke("find$#$", "find(const QString&, const QTextCursor&, QTextDocument::FindFlags) const", typeof(QTextCursor), typeof(string), subString, typeof(QTextCursor), from, typeof(uint), options);
        }
        public QTextCursor Find(string subString, QTextCursor from) {
            return (QTextCursor) interceptor.Invoke("find$#", "find(const QString&, const QTextCursor&) const", typeof(QTextCursor), typeof(string), subString, typeof(QTextCursor), from);
        }
        public QTextCursor Find(QRegExp expr, int from, uint options) {
            return (QTextCursor) interceptor.Invoke("find#$$", "find(const QRegExp&, int, QTextDocument::FindFlags) const", typeof(QTextCursor), typeof(QRegExp), expr, typeof(int), from, typeof(uint), options);
        }
        public QTextCursor Find(QRegExp expr, int from) {
            return (QTextCursor) interceptor.Invoke("find#$", "find(const QRegExp&, int) const", typeof(QTextCursor), typeof(QRegExp), expr, typeof(int), from);
        }
        public QTextCursor Find(QRegExp expr) {
            return (QTextCursor) interceptor.Invoke("find#", "find(const QRegExp&) const", typeof(QTextCursor), typeof(QRegExp), expr);
        }
        public QTextCursor Find(QRegExp expr, QTextCursor from, uint options) {
            return (QTextCursor) interceptor.Invoke("find##$", "find(const QRegExp&, const QTextCursor&, QTextDocument::FindFlags) const", typeof(QTextCursor), typeof(QRegExp), expr, typeof(QTextCursor), from, typeof(uint), options);
        }
        public QTextCursor Find(QRegExp expr, QTextCursor from) {
            return (QTextCursor) interceptor.Invoke("find##", "find(const QRegExp&, const QTextCursor&) const", typeof(QTextCursor), typeof(QRegExp), expr, typeof(QTextCursor), from);
        }
        public QTextFrame FrameAt(int pos) {
            return (QTextFrame) interceptor.Invoke("frameAt$", "frameAt(int) const", typeof(QTextFrame), typeof(int), pos);
        }
        public QTextFrame RootFrame() {
            return (QTextFrame) interceptor.Invoke("rootFrame", "rootFrame() const", typeof(QTextFrame));
        }
        public QTextObject Object(int objectIndex) {
            return (QTextObject) interceptor.Invoke("object$", "object(int) const", typeof(QTextObject), typeof(int), objectIndex);
        }
        public QTextObject ObjectForFormat(QTextFormat arg1) {
            return (QTextObject) interceptor.Invoke("objectForFormat#", "objectForFormat(const QTextFormat&) const", typeof(QTextObject), typeof(QTextFormat), arg1);
        }
        public QTextBlock FindBlock(int pos) {
            return (QTextBlock) interceptor.Invoke("findBlock$", "findBlock(int) const", typeof(QTextBlock), typeof(int), pos);
        }
        public QTextBlock FindBlockByNumber(int blockNumber) {
            return (QTextBlock) interceptor.Invoke("findBlockByNumber$", "findBlockByNumber(int) const", typeof(QTextBlock), typeof(int), blockNumber);
        }
        public QTextBlock FindBlockByLineNumber(int blockNumber) {
            return (QTextBlock) interceptor.Invoke("findBlockByLineNumber$", "findBlockByLineNumber(int) const", typeof(QTextBlock), typeof(int), blockNumber);
        }
        public QTextBlock Begin() {
            return (QTextBlock) interceptor.Invoke("begin", "begin() const", typeof(QTextBlock));
        }
        public QTextBlock End() {
            return (QTextBlock) interceptor.Invoke("end", "end() const", typeof(QTextBlock));
        }
        public QTextBlock FirstBlock() {
            return (QTextBlock) interceptor.Invoke("firstBlock", "firstBlock() const", typeof(QTextBlock));
        }
        public QTextBlock LastBlock() {
            return (QTextBlock) interceptor.Invoke("lastBlock", "lastBlock() const", typeof(QTextBlock));
        }
        public int PageCount() {
            return (int) interceptor.Invoke("pageCount", "pageCount() const", typeof(int));
        }
        public void Print(QPrinter printer) {
            interceptor.Invoke("print#", "print(QPrinter*) const", typeof(void), typeof(QPrinter), printer);
        }
        public QVariant Resource(int type, QUrl name) {
            return (QVariant) interceptor.Invoke("resource$#", "resource(int, const QUrl&) const", typeof(QVariant), typeof(int), type, typeof(QUrl), name);
        }
        public void AddResource(int type, QUrl name, QVariant resource) {
            interceptor.Invoke("addResource$##", "addResource(int, const QUrl&, const QVariant&)", typeof(void), typeof(int), type, typeof(QUrl), name, typeof(QVariant), resource);
        }
        public List<QTextFormat> AllFormats() {
            return (List<QTextFormat>) interceptor.Invoke("allFormats", "allFormats() const", typeof(List<QTextFormat>));
        }
        public void MarkContentsDirty(int from, int length) {
            interceptor.Invoke("markContentsDirty$$", "markContentsDirty(int, int)", typeof(void), typeof(int), from, typeof(int), length);
        }
        public void DrawContents(QPainter painter, QRectF rect) {
            interceptor.Invoke("drawContents##", "drawContents(QPainter*, const QRectF&)", typeof(void), typeof(QPainter), painter, typeof(QRectF), rect);
        }
        public void DrawContents(QPainter painter) {
            interceptor.Invoke("drawContents#", "drawContents(QPainter*)", typeof(void), typeof(QPainter), painter);
        }
        public double IdealWidth() {
            return (double) interceptor.Invoke("idealWidth", "idealWidth() const", typeof(double));
        }
        public void AdjustSize() {
            interceptor.Invoke("adjustSize", "adjustSize()", typeof(void));
        }
        public int LineCount() {
            return (int) interceptor.Invoke("lineCount", "lineCount() const", typeof(int));
        }
        public int CharacterCount() {
            return (int) interceptor.Invoke("characterCount", "characterCount() const", typeof(int));
        }
        public void Undo(QTextCursor cursor) {
            interceptor.Invoke("undo#", "undo(QTextCursor*)", typeof(void), typeof(QTextCursor), cursor);
        }
        public void Redo(QTextCursor cursor) {
            interceptor.Invoke("redo#", "redo(QTextCursor*)", typeof(void), typeof(QTextCursor), cursor);
        }
        [Q_SLOT("void undo()")]
        public void Undo() {
            interceptor.Invoke("undo", "undo()", typeof(void));
        }
        [Q_SLOT("void redo()")]
        public void Redo() {
            interceptor.Invoke("redo", "redo()", typeof(void));
        }
        [Q_SLOT("void setModified(bool)")]
        public void SetModified(bool m) {
            interceptor.Invoke("setModified$", "setModified(bool)", typeof(void), typeof(bool), m);
        }
        [Q_SLOT("void setModified()")]
        public void SetModified() {
            interceptor.Invoke("setModified", "setModified()", typeof(void));
        }
        [SmokeMethod("createObject(const QTextFormat&)")]
        protected virtual QTextObject CreateObject(QTextFormat f) {
            return (QTextObject) interceptor.Invoke("createObject#", "createObject(const QTextFormat&)", typeof(QTextObject), typeof(QTextFormat), f);
        }
        [SmokeMethod("loadResource(int, const QUrl&)")]
        protected virtual QVariant LoadResource(int type, QUrl name) {
            return (QVariant) interceptor.Invoke("loadResource$#", "loadResource(int, const QUrl&)", typeof(QVariant), typeof(int), type, typeof(QUrl), name);
        }
        ~QTextDocument() {
            interceptor.Invoke("~QTextDocument", "~QTextDocument()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QTextDocument", "~QTextDocument()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQTextDocumentSignals Emit {
            get { return (IQTextDocumentSignals) Q_EMIT; }
        }
    }

    public interface IQTextDocumentSignals : IQObjectSignals {
        [Q_SIGNAL("void contentsChange(int, int, int)")]
        void ContentsChange(int from, int charsRemoves, int charsAdded);
        [Q_SIGNAL("void contentsChanged()")]
        void ContentsChanged();
        [Q_SIGNAL("void undoAvailable(bool)")]
        void UndoAvailable(bool arg1);
        [Q_SIGNAL("void redoAvailable(bool)")]
        void RedoAvailable(bool arg1);
        [Q_SIGNAL("void undoCommandAdded()")]
        void UndoCommandAdded();
        [Q_SIGNAL("void modificationChanged(bool)")]
        void ModificationChanged(bool m);
        [Q_SIGNAL("void cursorPositionChanged(QTextCursor)")]
        void CursorPositionChanged(QTextCursor cursor);
        [Q_SIGNAL("void blockCountChanged(int)")]
        void BlockCountChanged(int newBlockCount);
        [Q_SIGNAL("void documentLayoutChanged()")]
        void DocumentLayoutChanged();
    }
}