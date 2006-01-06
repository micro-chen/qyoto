//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQTextEditSignals"></see> for signals emitted by QTextEdit
	[SmokeClass("QTextEdit")]
	public class QTextEdit : QScrollView, IDisposable {
 		protected QTextEdit(Type dummy) : base((Type) null) {}
		interface IQTextEditProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQTextEditProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextEdit), this);
			_interceptor = (QTextEdit) realProxy.GetTransparentProxy();
		}
		private QTextEdit ProxyQTextEdit() {
			return (QTextEdit) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextEdit() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextEditProxy), null);
			_staticInterceptor = (IQTextEditProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextEditProxy StaticQTextEdit() {
			return (IQTextEditProxy) _staticInterceptor;
		}

		enum E_WordWrap {
			NoWrap = 0,
			WidgetWidth = 1,
			FixedPixelWidth = 2,
			FixedColumnWidth = 3,
		}
		enum E_WrapPolicy {
			AtWordBoundary = 0,
			AtWhiteSpace = AtWordBoundary,
			Anywhere = 1,
			AtWordOrDocumentBoundary = 2,
		}
		enum E_AutoFormatting : uint {
			AutoNone = 0,
			AutoBulletList = 0x00000001,
			AutoAll = 0xffffffff,
		}
		enum KeyboardAction {
			ActionBackspace = 0,
			ActionDelete = 1,
			ActionReturn = 2,
			ActionKill = 3,
			ActionWordBackspace = 4,
			ActionWordDelete = 5,
		}
		enum CursorAction {
			MoveBackward = 0,
			MoveForward = 1,
			MoveWordBackward = 2,
			MoveWordForward = 3,
			MoveUp = 4,
			MoveDown = 5,
			MoveLineStart = 6,
			MoveLineEnd = 7,
			MoveHome = 8,
			MoveEnd = 9,
			MovePgUp = 10,
			MovePgDown = 11,
		}
		enum VerticalAlignment {
			AlignNormal = 0,
			AlignSuperScript = 1,
			AlignSubScript = 2,
		}
		enum TextInsertionFlags {
			RedoIndentation = 0x0001,
			CheckNewLines = 0x0002,
			RemoveSelected = 0x0004,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQTextEdit().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQTextEdit().ClassName();
		}
		public QTextEdit(string text, string context, QWidget parent, string name) : this((Type) null) {
			CreateQTextEditProxy();
			CreateQTextEditSignalProxy();
			NewQTextEdit(text,context,parent,name);
		}
		[SmokeMethod("QTextEdit(const QString&, const QString&, QWidget*, const char*)")]
		private void NewQTextEdit(string text, string context, QWidget parent, string name) {
			ProxyQTextEdit().NewQTextEdit(text,context,parent,name);
		}
		public QTextEdit(string text, string context, QWidget parent) : this((Type) null) {
			CreateQTextEditProxy();
			CreateQTextEditSignalProxy();
			NewQTextEdit(text,context,parent);
		}
		[SmokeMethod("QTextEdit(const QString&, const QString&, QWidget*)")]
		private void NewQTextEdit(string text, string context, QWidget parent) {
			ProxyQTextEdit().NewQTextEdit(text,context,parent);
		}
		public QTextEdit(string text, string context) : this((Type) null) {
			CreateQTextEditProxy();
			CreateQTextEditSignalProxy();
			NewQTextEdit(text,context);
		}
		[SmokeMethod("QTextEdit(const QString&, const QString&)")]
		private void NewQTextEdit(string text, string context) {
			ProxyQTextEdit().NewQTextEdit(text,context);
		}
		public QTextEdit(string text) : this((Type) null) {
			CreateQTextEditProxy();
			CreateQTextEditSignalProxy();
			NewQTextEdit(text);
		}
		[SmokeMethod("QTextEdit(const QString&)")]
		private void NewQTextEdit(string text) {
			ProxyQTextEdit().NewQTextEdit(text);
		}
		public QTextEdit(QWidget parent, string name) : this((Type) null) {
			CreateQTextEditProxy();
			CreateQTextEditSignalProxy();
			NewQTextEdit(parent,name);
		}
		[SmokeMethod("QTextEdit(QWidget*, const char*)")]
		private void NewQTextEdit(QWidget parent, string name) {
			ProxyQTextEdit().NewQTextEdit(parent,name);
		}
		public QTextEdit(QWidget parent) : this((Type) null) {
			CreateQTextEditProxy();
			CreateQTextEditSignalProxy();
			NewQTextEdit(parent);
		}
		[SmokeMethod("QTextEdit(QWidget*)")]
		private void NewQTextEdit(QWidget parent) {
			ProxyQTextEdit().NewQTextEdit(parent);
		}
		public QTextEdit() : this((Type) null) {
			CreateQTextEditProxy();
			CreateQTextEditSignalProxy();
			NewQTextEdit();
		}
		[SmokeMethod("QTextEdit()")]
		private void NewQTextEdit() {
			ProxyQTextEdit().NewQTextEdit();
		}
		[SmokeMethod("setPalette(const QPalette&)")]
		public new void SetPalette(QPalette arg1) {
			ProxyQTextEdit().SetPalette(arg1);
		}
		[SmokeMethod("text() const")]
		public string Text() {
			return ProxyQTextEdit().Text();
		}
		[SmokeMethod("text(int) const")]
		public string Text(int para) {
			return ProxyQTextEdit().Text(para);
		}
		[SmokeMethod("textFormat() const")]
		public int TextFormat() {
			return ProxyQTextEdit().TextFormat();
		}
		[SmokeMethod("context() const")]
		public string Context() {
			return ProxyQTextEdit().Context();
		}
		[SmokeMethod("documentTitle() const")]
		public string DocumentTitle() {
			return ProxyQTextEdit().DocumentTitle();
		}
		[SmokeMethod("getSelection(int*, int*, int*, int*, int) const")]
		public void GetSelection(out int paraFrom, out int indexFrom, out int paraTo, out int indexTo, int selNum) {
			ProxyQTextEdit().GetSelection(out paraFrom,out indexFrom,out paraTo,out indexTo,selNum);
		}
		[SmokeMethod("getSelection(int*, int*, int*, int*) const")]
		public void GetSelection(out int paraFrom, out int indexFrom, out int paraTo, out int indexTo) {
			ProxyQTextEdit().GetSelection(out paraFrom,out indexFrom,out paraTo,out indexTo);
		}
		[SmokeMethod("find(const QString&, bool, bool, bool, int*, int*)")]
		public new virtual bool Find(string expr, bool cs, bool wo, bool forward, out int para, out int index) {
			return ProxyQTextEdit().Find(expr,cs,wo,forward,out para,out index);
		}
		[SmokeMethod("find(const QString&, bool, bool, bool, int*)")]
		public new virtual bool Find(string expr, bool cs, bool wo, bool forward, out int para) {
			return ProxyQTextEdit().Find(expr,cs,wo,forward,out para);
		}
		[SmokeMethod("find(const QString&, bool, bool, bool)")]
		public new virtual bool Find(string expr, bool cs, bool wo, bool forward) {
			return ProxyQTextEdit().Find(expr,cs,wo,forward);
		}
		[SmokeMethod("find(const QString&, bool, bool)")]
		public new virtual bool Find(string expr, bool cs, bool wo) {
			return ProxyQTextEdit().Find(expr,cs,wo);
		}
		[SmokeMethod("paragraphs() const")]
		public int Paragraphs() {
			return ProxyQTextEdit().Paragraphs();
		}
		[SmokeMethod("lines() const")]
		public int Lines() {
			return ProxyQTextEdit().Lines();
		}
		[SmokeMethod("linesOfParagraph(int) const")]
		public int LinesOfParagraph(int para) {
			return ProxyQTextEdit().LinesOfParagraph(para);
		}
		[SmokeMethod("lineOfChar(int, int)")]
		public int LineOfChar(int para, int chr) {
			return ProxyQTextEdit().LineOfChar(para,chr);
		}
		[SmokeMethod("length() const")]
		public int Length() {
			return ProxyQTextEdit().Length();
		}
		[SmokeMethod("paragraphRect(int) const")]
		public QRect ParagraphRect(int para) {
			return ProxyQTextEdit().ParagraphRect(para);
		}
		[SmokeMethod("paragraphAt(const QPoint&) const")]
		public int ParagraphAt(QPoint pos) {
			return ProxyQTextEdit().ParagraphAt(pos);
		}
		[SmokeMethod("charAt(const QPoint&, int*) const")]
		public int CharAt(QPoint pos, out int para) {
			return ProxyQTextEdit().CharAt(pos,out para);
		}
		[SmokeMethod("paragraphLength(int) const")]
		public int ParagraphLength(int para) {
			return ProxyQTextEdit().ParagraphLength(para);
		}
		[SmokeMethod("styleSheet() const")]
		public QStyleSheet StyleSheet() {
			return ProxyQTextEdit().StyleSheet();
		}
		[SmokeMethod("mimeSourceFactory() const")]
		public QMimeSourceFactory MimeSourceFactory() {
			return ProxyQTextEdit().MimeSourceFactory();
		}
		[SmokeMethod("paper() const")]
		public QBrush Paper() {
			return ProxyQTextEdit().Paper();
		}
		[SmokeMethod("linkUnderline() const")]
		public bool LinkUnderline() {
			return ProxyQTextEdit().LinkUnderline();
		}
		[SmokeMethod("heightForWidth(int) const")]
		public new int HeightForWidth(int w) {
			return ProxyQTextEdit().HeightForWidth(w);
		}
		[SmokeMethod("hasSelectedText() const")]
		public bool HasSelectedText() {
			return ProxyQTextEdit().HasSelectedText();
		}
		[SmokeMethod("selectedText() const")]
		public string SelectedText() {
			return ProxyQTextEdit().SelectedText();
		}
		[SmokeMethod("isUndoAvailable() const")]
		public bool IsUndoAvailable() {
			return ProxyQTextEdit().IsUndoAvailable();
		}
		[SmokeMethod("isRedoAvailable() const")]
		public bool IsRedoAvailable() {
			return ProxyQTextEdit().IsRedoAvailable();
		}
		[SmokeMethod("wordWrap() const")]
		public int WordWrap() {
			return ProxyQTextEdit().WordWrap();
		}
		[SmokeMethod("wrapColumnOrWidth() const")]
		public int WrapColumnOrWidth() {
			return ProxyQTextEdit().WrapColumnOrWidth();
		}
		[SmokeMethod("wrapPolicy() const")]
		public int WrapPolicy() {
			return ProxyQTextEdit().WrapPolicy();
		}
		[SmokeMethod("tabStopWidth() const")]
		public int TabStopWidth() {
			return ProxyQTextEdit().TabStopWidth();
		}
		[SmokeMethod("anchorAt(const QPoint&)")]
		public string AnchorAt(QPoint pos) {
			return ProxyQTextEdit().AnchorAt(pos);
		}
		[SmokeMethod("anchorAt(const QPoint&, Qt::AnchorAttribute)")]
		public string AnchorAt(QPoint pos, int a) {
			return ProxyQTextEdit().AnchorAt(pos,a);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQTextEdit().SizeHint();
		}
		[SmokeMethod("isReadOnly() const")]
		public bool IsReadOnly() {
			return ProxyQTextEdit().IsReadOnly();
		}
		[SmokeMethod("getCursorPosition(int*, int*) const")]
		public void GetCursorPosition(out int parag, out int index) {
			ProxyQTextEdit().GetCursorPosition(out parag,out index);
		}
		[SmokeMethod("isModified() const")]
		public bool IsModified() {
			return ProxyQTextEdit().IsModified();
		}
		[SmokeMethod("italic() const")]
		public bool Italic() {
			return ProxyQTextEdit().Italic();
		}
		[SmokeMethod("bold() const")]
		public bool Bold() {
			return ProxyQTextEdit().Bold();
		}
		[SmokeMethod("underline() const")]
		public bool Underline() {
			return ProxyQTextEdit().Underline();
		}
		[SmokeMethod("family() const")]
		public string Family() {
			return ProxyQTextEdit().Family();
		}
		[SmokeMethod("pointSize() const")]
		public int PointSize() {
			return ProxyQTextEdit().PointSize();
		}
		[SmokeMethod("color() const")]
		public QColor Color() {
			return ProxyQTextEdit().Color();
		}
		[SmokeMethod("font() const")]
		public new QFont Font() {
			return ProxyQTextEdit().Font();
		}
		[SmokeMethod("currentFont() const")]
		public QFont CurrentFont() {
			return ProxyQTextEdit().CurrentFont();
		}
		[SmokeMethod("alignment() const")]
		public int Alignment() {
			return ProxyQTextEdit().Alignment();
		}
		[SmokeMethod("undoDepth() const")]
		public int UndoDepth() {
			return ProxyQTextEdit().UndoDepth();
		}
		[SmokeMethod("getFormat(int, int, QFont*, QColor*, QTextEdit::VerticalAlignment*)")]
		public virtual bool GetFormat(int para, int index, QFont font, QColor color, int verticalAlignment) {
			return ProxyQTextEdit().GetFormat(para,index,font,color,verticalAlignment);
		}
		[SmokeMethod("getParagraphFormat(int, QFont*, QColor*, QTextEdit::VerticalAlignment*, int*, QStyleSheetItem::DisplayMode*, QStyleSheetItem::ListStyle*, int*)")]
		public virtual bool GetParagraphFormat(int para, QFont font, QColor color, int verticalAlignment, out int alignment, int displayMode, int listStyle, out int listDepth) {
			return ProxyQTextEdit().GetParagraphFormat(para,font,color,verticalAlignment,out alignment,displayMode,listStyle,out listDepth);
		}
		[SmokeMethod("isOverwriteMode() const")]
		public bool IsOverwriteMode() {
			return ProxyQTextEdit().IsOverwriteMode();
		}
		[SmokeMethod("paragraphBackgroundColor(int) const")]
		public QColor ParagraphBackgroundColor(int para) {
			return ProxyQTextEdit().ParagraphBackgroundColor(para);
		}
		[SmokeMethod("isUndoRedoEnabled() const")]
		public bool IsUndoRedoEnabled() {
			return ProxyQTextEdit().IsUndoRedoEnabled();
		}
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		public new bool EventFilter(QObject o, QEvent e) {
			return ProxyQTextEdit().EventFilter(o,e);
		}
		[SmokeMethod("tabChangesFocus() const")]
		public bool TabChangesFocus() {
			return ProxyQTextEdit().TabChangesFocus();
		}
		[SmokeMethod("setAutoFormatting(uint)")]
		public void SetAutoFormatting(uint features) {
			ProxyQTextEdit().SetAutoFormatting(features);
		}
		[SmokeMethod("autoFormatting() const")]
		public uint AutoFormatting() {
			return ProxyQTextEdit().AutoFormatting();
		}
		[SmokeMethod("syntaxHighlighter() const")]
		public QSyntaxHighlighter SyntaxHighlighter() {
			return ProxyQTextEdit().SyntaxHighlighter();
		}
		[Q_SLOT("void setEnabled(bool)")]
		[SmokeMethod("setEnabled(bool)")]
		public new void SetEnabled(bool arg1) {
			ProxyQTextEdit().SetEnabled(arg1);
		}
		[Q_SLOT("void setMimeSourceFactory(QMimeSourceFactory*)")]
		[SmokeMethod("setMimeSourceFactory(QMimeSourceFactory*)")]
		public virtual void SetMimeSourceFactory(QMimeSourceFactory factory) {
			ProxyQTextEdit().SetMimeSourceFactory(factory);
		}
		[Q_SLOT("void setStyleSheet(QStyleSheet*)")]
		[SmokeMethod("setStyleSheet(QStyleSheet*)")]
		public virtual void SetStyleSheet(QStyleSheet styleSheet) {
			ProxyQTextEdit().SetStyleSheet(styleSheet);
		}
		[Q_SLOT("void scrollToAnchor(const QString&)")]
		[SmokeMethod("scrollToAnchor(const QString&)")]
		public virtual void ScrollToAnchor(string name) {
			ProxyQTextEdit().ScrollToAnchor(name);
		}
		[Q_SLOT("void setPaper(const QBrush&)")]
		[SmokeMethod("setPaper(const QBrush&)")]
		public virtual void SetPaper(QBrush pap) {
			ProxyQTextEdit().SetPaper(pap);
		}
		[Q_SLOT("void setLinkUnderline(bool)")]
		[SmokeMethod("setLinkUnderline(bool)")]
		public virtual void SetLinkUnderline(bool arg1) {
			ProxyQTextEdit().SetLinkUnderline(arg1);
		}
		[Q_SLOT("void setWordWrap(QTextEdit::WordWrap)")]
		[SmokeMethod("setWordWrap(QTextEdit::WordWrap)")]
		public virtual void SetWordWrap(int mode) {
			ProxyQTextEdit().SetWordWrap(mode);
		}
		[Q_SLOT("void setWrapColumnOrWidth(int)")]
		[SmokeMethod("setWrapColumnOrWidth(int)")]
		public virtual void SetWrapColumnOrWidth(int arg1) {
			ProxyQTextEdit().SetWrapColumnOrWidth(arg1);
		}
		[Q_SLOT("void setWrapPolicy(QTextEdit::WrapPolicy)")]
		[SmokeMethod("setWrapPolicy(QTextEdit::WrapPolicy)")]
		public virtual void SetWrapPolicy(int policy) {
			ProxyQTextEdit().SetWrapPolicy(policy);
		}
		[Q_SLOT("void copy()")]
		[SmokeMethod("copy()")]
		public virtual void Copy() {
			ProxyQTextEdit().Copy();
		}
		[Q_SLOT("void append(const QString&)")]
		[SmokeMethod("append(const QString&)")]
		public virtual void Append(string text) {
			ProxyQTextEdit().Append(text);
		}
		[Q_SLOT("void setText(const QString&)")]
		[SmokeMethod("setText(const QString&)")]
		public void SetText(string txt) {
			ProxyQTextEdit().SetText(txt);
		}
		[Q_SLOT("void setText(const QString&, const QString&)")]
		[SmokeMethod("setText(const QString&, const QString&)")]
		public virtual void SetText(string txt, string context) {
			ProxyQTextEdit().SetText(txt,context);
		}
		[Q_SLOT("void setTextFormat(Qt::TextFormat)")]
		[SmokeMethod("setTextFormat(Qt::TextFormat)")]
		public virtual void SetTextFormat(int f) {
			ProxyQTextEdit().SetTextFormat(f);
		}
		[Q_SLOT("void selectAll(bool)")]
		[SmokeMethod("selectAll(bool)")]
		public virtual void SelectAll(bool select) {
			ProxyQTextEdit().SelectAll(select);
		}
		[Q_SLOT("void selectAll()")]
		[SmokeMethod("selectAll()")]
		public virtual void SelectAll() {
			ProxyQTextEdit().SelectAll();
		}
		[Q_SLOT("void setTabStopWidth(int)")]
		[SmokeMethod("setTabStopWidth(int)")]
		public virtual void SetTabStopWidth(int ts) {
			ProxyQTextEdit().SetTabStopWidth(ts);
		}
		[Q_SLOT("void zoomIn(int)")]
		[SmokeMethod("zoomIn(int)")]
		public virtual void ZoomIn(int range) {
			ProxyQTextEdit().ZoomIn(range);
		}
		[Q_SLOT("void zoomIn()")]
		[SmokeMethod("zoomIn()")]
		public virtual void ZoomIn() {
			ProxyQTextEdit().ZoomIn();
		}
		[Q_SLOT("void zoomOut(int)")]
		[SmokeMethod("zoomOut(int)")]
		public virtual void ZoomOut(int range) {
			ProxyQTextEdit().ZoomOut(range);
		}
		[Q_SLOT("void zoomOut()")]
		[SmokeMethod("zoomOut()")]
		public virtual void ZoomOut() {
			ProxyQTextEdit().ZoomOut();
		}
		[Q_SLOT("void zoomTo(int)")]
		[SmokeMethod("zoomTo(int)")]
		public virtual void ZoomTo(int size) {
			ProxyQTextEdit().ZoomTo(size);
		}
		[Q_SLOT("void sync()")]
		[SmokeMethod("sync()")]
		public virtual void Sync() {
			ProxyQTextEdit().Sync();
		}
		[Q_SLOT("void setReadOnly(bool)")]
		[SmokeMethod("setReadOnly(bool)")]
		public virtual void SetReadOnly(bool b) {
			ProxyQTextEdit().SetReadOnly(b);
		}
		[Q_SLOT("void undo()")]
		[SmokeMethod("undo()")]
		public virtual void Undo() {
			ProxyQTextEdit().Undo();
		}
		[Q_SLOT("void redo()")]
		[SmokeMethod("redo()")]
		public virtual void Redo() {
			ProxyQTextEdit().Redo();
		}
		[Q_SLOT("void cut()")]
		[SmokeMethod("cut()")]
		public virtual void Cut() {
			ProxyQTextEdit().Cut();
		}
		[Q_SLOT("void paste()")]
		[SmokeMethod("paste()")]
		public virtual void Paste() {
			ProxyQTextEdit().Paste();
		}
		[Q_SLOT("void pasteSubType(const QCString&)")]
		[SmokeMethod("pasteSubType(const QCString&)")]
		public virtual void PasteSubType(string subtype) {
			ProxyQTextEdit().PasteSubType(subtype);
		}
		[Q_SLOT("void clear()")]
		[SmokeMethod("clear()")]
		public virtual void Clear() {
			ProxyQTextEdit().Clear();
		}
		[Q_SLOT("void del()")]
		[SmokeMethod("del()")]
		public virtual void Del() {
			ProxyQTextEdit().Del();
		}
		[Q_SLOT("void indent()")]
		[SmokeMethod("indent()")]
		public virtual void Indent() {
			ProxyQTextEdit().Indent();
		}
		[Q_SLOT("void setItalic(bool)")]
		[SmokeMethod("setItalic(bool)")]
		public virtual void SetItalic(bool b) {
			ProxyQTextEdit().SetItalic(b);
		}
		[Q_SLOT("void setBold(bool)")]
		[SmokeMethod("setBold(bool)")]
		public virtual void SetBold(bool b) {
			ProxyQTextEdit().SetBold(b);
		}
		[Q_SLOT("void setUnderline(bool)")]
		[SmokeMethod("setUnderline(bool)")]
		public virtual void SetUnderline(bool b) {
			ProxyQTextEdit().SetUnderline(b);
		}
		[Q_SLOT("void setFamily(const QString&)")]
		[SmokeMethod("setFamily(const QString&)")]
		public virtual void SetFamily(string f) {
			ProxyQTextEdit().SetFamily(f);
		}
		[Q_SLOT("void setPointSize(int)")]
		[SmokeMethod("setPointSize(int)")]
		public virtual void SetPointSize(int s) {
			ProxyQTextEdit().SetPointSize(s);
		}
		[Q_SLOT("void setColor(const QColor&)")]
		[SmokeMethod("setColor(const QColor&)")]
		public virtual void SetColor(QColor c) {
			ProxyQTextEdit().SetColor(c);
		}
		[Q_SLOT("void setFont(const QFont&)")]
		[SmokeMethod("setFont(const QFont&)")]
		public new virtual void SetFont(QFont f) {
			ProxyQTextEdit().SetFont(f);
		}
		[Q_SLOT("void setVerticalAlignment(QTextEdit::VerticalAlignment)")]
		[SmokeMethod("setVerticalAlignment(QTextEdit::VerticalAlignment)")]
		public virtual void SetVerticalAlignment(int a) {
			ProxyQTextEdit().SetVerticalAlignment(a);
		}
		[Q_SLOT("void setAlignment(int)")]
		[SmokeMethod("setAlignment(int)")]
		public virtual void SetAlignment(int a) {
			ProxyQTextEdit().SetAlignment(a);
		}
		[Q_SLOT("void setParagType(QStyleSheetItem::DisplayMode, QStyleSheetItem::ListStyle)")]
		[SmokeMethod("setParagType(QStyleSheetItem::DisplayMode, QStyleSheetItem::ListStyle)")]
		public virtual void SetParagType(int dm, int listStyle) {
			ProxyQTextEdit().SetParagType(dm,listStyle);
		}
		[Q_SLOT("void setCursorPosition(int, int)")]
		[SmokeMethod("setCursorPosition(int, int)")]
		public virtual void SetCursorPosition(int parag, int index) {
			ProxyQTextEdit().SetCursorPosition(parag,index);
		}
		[Q_SLOT("void setSelection(int, int, int, int, int)")]
		[SmokeMethod("setSelection(int, int, int, int, int)")]
		public virtual void SetSelection(int parag_from, int index_from, int parag_to, int index_to, int selNum) {
			ProxyQTextEdit().SetSelection(parag_from,index_from,parag_to,index_to,selNum);
		}
		[Q_SLOT("void setSelection(int, int, int, int)")]
		[SmokeMethod("setSelection(int, int, int, int)")]
		public virtual void SetSelection(int parag_from, int index_from, int parag_to, int index_to) {
			ProxyQTextEdit().SetSelection(parag_from,index_from,parag_to,index_to);
		}
		[Q_SLOT("void setSelectionAttributes(int, const QColor&, bool)")]
		[SmokeMethod("setSelectionAttributes(int, const QColor&, bool)")]
		public virtual void SetSelectionAttributes(int selNum, QColor back, bool invertText) {
			ProxyQTextEdit().SetSelectionAttributes(selNum,back,invertText);
		}
		[Q_SLOT("void setModified(bool)")]
		[SmokeMethod("setModified(bool)")]
		public virtual void SetModified(bool m) {
			ProxyQTextEdit().SetModified(m);
		}
		[Q_SLOT("void resetFormat()")]
		[SmokeMethod("resetFormat()")]
		public virtual void ResetFormat() {
			ProxyQTextEdit().ResetFormat();
		}
		[Q_SLOT("void setUndoDepth(int)")]
		[SmokeMethod("setUndoDepth(int)")]
		public virtual void SetUndoDepth(int d) {
			ProxyQTextEdit().SetUndoDepth(d);
		}
		// void setFormat(QTextFormat* arg1,int arg2); >>>> NOT CONVERTED
		[Q_SLOT("void ensureCursorVisible()")]
		[SmokeMethod("ensureCursorVisible()")]
		public virtual void EnsureCursorVisible() {
			ProxyQTextEdit().EnsureCursorVisible();
		}
		// void placeCursor(const QPoint& arg1,QTextCursor* arg2); >>>> NOT CONVERTED
		[Q_SLOT("void placeCursor(const QPoint&)")]
		[SmokeMethod("placeCursor(const QPoint&)")]
		public virtual void PlaceCursor(QPoint pos) {
			ProxyQTextEdit().PlaceCursor(pos);
		}
		[Q_SLOT("void moveCursor(QTextEdit::CursorAction, bool)")]
		[SmokeMethod("moveCursor(QTextEdit::CursorAction, bool)")]
		public virtual void MoveCursor(int action, bool select) {
			ProxyQTextEdit().MoveCursor(action,select);
		}
		[Q_SLOT("void doKeyboardAction(QTextEdit::KeyboardAction)")]
		[SmokeMethod("doKeyboardAction(QTextEdit::KeyboardAction)")]
		public virtual void DoKeyboardAction(int action) {
			ProxyQTextEdit().DoKeyboardAction(action);
		}
		[Q_SLOT("void removeSelectedText(int)")]
		[SmokeMethod("removeSelectedText(int)")]
		public virtual void RemoveSelectedText(int selNum) {
			ProxyQTextEdit().RemoveSelectedText(selNum);
		}
		[Q_SLOT("void removeSelectedText()")]
		[SmokeMethod("removeSelectedText()")]
		public virtual void RemoveSelectedText() {
			ProxyQTextEdit().RemoveSelectedText();
		}
		[Q_SLOT("void removeSelection(int)")]
		[SmokeMethod("removeSelection(int)")]
		public virtual void RemoveSelection(int selNum) {
			ProxyQTextEdit().RemoveSelection(selNum);
		}
		[Q_SLOT("void removeSelection()")]
		[SmokeMethod("removeSelection()")]
		public virtual void RemoveSelection() {
			ProxyQTextEdit().RemoveSelection();
		}
		[Q_SLOT("void setCurrentFont(const QFont&)")]
		[SmokeMethod("setCurrentFont(const QFont&)")]
		public virtual void SetCurrentFont(QFont f) {
			ProxyQTextEdit().SetCurrentFont(f);
		}
		[Q_SLOT("void setOverwriteMode(bool)")]
		[SmokeMethod("setOverwriteMode(bool)")]
		public virtual void SetOverwriteMode(bool b) {
			ProxyQTextEdit().SetOverwriteMode(b);
		}
		[Q_SLOT("void scrollToBottom()")]
		[SmokeMethod("scrollToBottom()")]
		public virtual void ScrollToBottom() {
			ProxyQTextEdit().ScrollToBottom();
		}
		[Q_SLOT("void insert(const QString&, uint)")]
		[SmokeMethod("insert(const QString&, uint)")]
		public void Insert(string text, uint insertionFlags) {
			ProxyQTextEdit().Insert(text,insertionFlags);
		}
		[Q_SLOT("void insert(const QString&)")]
		[SmokeMethod("insert(const QString&)")]
		public void Insert(string text) {
			ProxyQTextEdit().Insert(text);
		}
		[Q_SLOT("void insert(const QString&, bool, bool, bool)")]
		[SmokeMethod("insert(const QString&, bool, bool, bool)")]
		public virtual void Insert(string text, bool arg2, bool arg3, bool arg4) {
			ProxyQTextEdit().Insert(text,arg2,arg3,arg4);
		}
		[Q_SLOT("void insert(const QString&, bool, bool)")]
		[SmokeMethod("insert(const QString&, bool, bool)")]
		public virtual void Insert(string text, bool arg2, bool arg3) {
			ProxyQTextEdit().Insert(text,arg2,arg3);
		}
		[Q_SLOT("void insert(const QString&, bool)")]
		[SmokeMethod("insert(const QString&, bool)")]
		public virtual void Insert(string text, bool arg2) {
			ProxyQTextEdit().Insert(text,arg2);
		}
		[Q_SLOT("void insertAt(const QString&, int, int)")]
		[SmokeMethod("insertAt(const QString&, int, int)")]
		public virtual void InsertAt(string text, int para, int index) {
			ProxyQTextEdit().InsertAt(text,para,index);
		}
		[Q_SLOT("void removeParagraph(int)")]
		[SmokeMethod("removeParagraph(int)")]
		public virtual void RemoveParagraph(int para) {
			ProxyQTextEdit().RemoveParagraph(para);
		}
		[Q_SLOT("void insertParagraph(const QString&, int)")]
		[SmokeMethod("insertParagraph(const QString&, int)")]
		public virtual void InsertParagraph(string text, int para) {
			ProxyQTextEdit().InsertParagraph(text,para);
		}
		[Q_SLOT("void setParagraphBackgroundColor(int, const QColor&)")]
		[SmokeMethod("setParagraphBackgroundColor(int, const QColor&)")]
		public virtual void SetParagraphBackgroundColor(int para, QColor bg) {
			ProxyQTextEdit().SetParagraphBackgroundColor(para,bg);
		}
		[Q_SLOT("void clearParagraphBackground(int)")]
		[SmokeMethod("clearParagraphBackground(int)")]
		public virtual void ClearParagraphBackground(int para) {
			ProxyQTextEdit().ClearParagraphBackground(para);
		}
		[Q_SLOT("void setUndoRedoEnabled(bool)")]
		[SmokeMethod("setUndoRedoEnabled(bool)")]
		public virtual void SetUndoRedoEnabled(bool b) {
			ProxyQTextEdit().SetUndoRedoEnabled(b);
		}
		[Q_SLOT("void setTabChangesFocus(bool)")]
		[SmokeMethod("setTabChangesFocus(bool)")]
		public void SetTabChangesFocus(bool b) {
			ProxyQTextEdit().SetTabChangesFocus(b);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQTextEdit().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQTextEdit().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQTextEdit().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQTextEdit().TrUtf8(arg1);
		}
		[SmokeMethod("repaintChanged()")]
		protected void RepaintChanged() {
			ProxyQTextEdit().RepaintChanged();
		}
		[SmokeMethod("updateStyles()")]
		protected void UpdateStyles() {
			ProxyQTextEdit().UpdateStyles();
		}
		[SmokeMethod("drawContents(QPainter*, int, int, int, int)")]
		protected new void DrawContents(QPainter p, int cx, int cy, int cw, int ch) {
			ProxyQTextEdit().DrawContents(p,cx,cy,cw,ch);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent e) {
			return ProxyQTextEdit().Event(e);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new void KeyPressEvent(QKeyEvent e) {
			ProxyQTextEdit().KeyPressEvent(e);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent e) {
			ProxyQTextEdit().ResizeEvent(e);
		}
		[SmokeMethod("viewportResizeEvent(QResizeEvent*)")]
		protected new void ViewportResizeEvent(QResizeEvent arg1) {
			ProxyQTextEdit().ViewportResizeEvent(arg1);
		}
		[SmokeMethod("contentsMousePressEvent(QMouseEvent*)")]
		protected new void ContentsMousePressEvent(QMouseEvent e) {
			ProxyQTextEdit().ContentsMousePressEvent(e);
		}
		[SmokeMethod("contentsMouseMoveEvent(QMouseEvent*)")]
		protected new void ContentsMouseMoveEvent(QMouseEvent e) {
			ProxyQTextEdit().ContentsMouseMoveEvent(e);
		}
		[SmokeMethod("contentsMouseReleaseEvent(QMouseEvent*)")]
		protected new void ContentsMouseReleaseEvent(QMouseEvent e) {
			ProxyQTextEdit().ContentsMouseReleaseEvent(e);
		}
		[SmokeMethod("contentsMouseDoubleClickEvent(QMouseEvent*)")]
		protected new void ContentsMouseDoubleClickEvent(QMouseEvent e) {
			ProxyQTextEdit().ContentsMouseDoubleClickEvent(e);
		}
		[SmokeMethod("contentsWheelEvent(QWheelEvent*)")]
		protected new void ContentsWheelEvent(QWheelEvent e) {
			ProxyQTextEdit().ContentsWheelEvent(e);
		}
		[SmokeMethod("imStartEvent(QIMEvent*)")]
		protected new void ImStartEvent(QIMEvent arg1) {
			ProxyQTextEdit().ImStartEvent(arg1);
		}
		[SmokeMethod("imComposeEvent(QIMEvent*)")]
		protected new void ImComposeEvent(QIMEvent arg1) {
			ProxyQTextEdit().ImComposeEvent(arg1);
		}
		[SmokeMethod("imEndEvent(QIMEvent*)")]
		protected new void ImEndEvent(QIMEvent arg1) {
			ProxyQTextEdit().ImEndEvent(arg1);
		}
		[SmokeMethod("contentsDragEnterEvent(QDragEnterEvent*)")]
		protected new void ContentsDragEnterEvent(QDragEnterEvent e) {
			ProxyQTextEdit().ContentsDragEnterEvent(e);
		}
		[SmokeMethod("contentsDragMoveEvent(QDragMoveEvent*)")]
		protected new void ContentsDragMoveEvent(QDragMoveEvent e) {
			ProxyQTextEdit().ContentsDragMoveEvent(e);
		}
		[SmokeMethod("contentsDragLeaveEvent(QDragLeaveEvent*)")]
		protected new void ContentsDragLeaveEvent(QDragLeaveEvent e) {
			ProxyQTextEdit().ContentsDragLeaveEvent(e);
		}
		[SmokeMethod("contentsDropEvent(QDropEvent*)")]
		protected new void ContentsDropEvent(QDropEvent e) {
			ProxyQTextEdit().ContentsDropEvent(e);
		}
		[SmokeMethod("contentsContextMenuEvent(QContextMenuEvent*)")]
		protected new void ContentsContextMenuEvent(QContextMenuEvent e) {
			ProxyQTextEdit().ContentsContextMenuEvent(e);
		}
		[SmokeMethod("focusNextPrevChild(bool)")]
		protected new bool FocusNextPrevChild(bool next) {
			return ProxyQTextEdit().FocusNextPrevChild(next);
		}
		// QTextDocument* document(); >>>> NOT CONVERTED
		// QTextCursor* textCursor(); >>>> NOT CONVERTED
		// void setDocument(QTextDocument* arg1); >>>> NOT CONVERTED
		[SmokeMethod("createPopupMenu(const QPoint&)")]
		protected virtual QPopupMenu CreatePopupMenu(QPoint pos) {
			return ProxyQTextEdit().CreatePopupMenu(pos);
		}
		[SmokeMethod("createPopupMenu()")]
		protected virtual QPopupMenu CreatePopupMenu() {
			return ProxyQTextEdit().CreatePopupMenu();
		}
		[SmokeMethod("drawCursor(bool)")]
		protected void DrawCursor(bool visible) {
			ProxyQTextEdit().DrawCursor(visible);
		}
		[SmokeMethod("windowActivationChange(bool)")]
		protected new void WindowActivationChange(bool arg1) {
			ProxyQTextEdit().WindowActivationChange(arg1);
		}
		[Q_SLOT("void doChangeInterval()")]
		[SmokeMethod("doChangeInterval()")]
		protected virtual void DoChangeInterval() {
			ProxyQTextEdit().DoChangeInterval();
		}
		[Q_SLOT("void sliderReleased()")]
		[SmokeMethod("sliderReleased()")]
		protected void SliderReleased() {
			ProxyQTextEdit().SliderReleased();
		}
		~QTextEdit() {
			DisposeQTextEdit();
		}
		public new void Dispose() {
			DisposeQTextEdit();
		}
		private void DisposeQTextEdit() {
			ProxyQTextEdit().DisposeQTextEdit();
		}
		protected void CreateQTextEditSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQTextEditSignals), this);
			Q_EMIT = (IQTextEditSignals) realProxy.GetTransparentProxy();
		}
		protected new IQTextEditSignals Emit() {
			return (IQTextEditSignals) Q_EMIT;
		}
	}

	public interface IQTextEditSignals : IQScrollViewSignals {
		[Q_SIGNAL("void textChanged()")]
		void TextChanged();
		[Q_SIGNAL("void selectionChanged()")]
		void SelectionChanged();
		[Q_SIGNAL("void copyAvailable(bool)")]
		void CopyAvailable(bool arg1);
		[Q_SIGNAL("void undoAvailable(bool)")]
		void UndoAvailable(bool yes);
		[Q_SIGNAL("void redoAvailable(bool)")]
		void RedoAvailable(bool yes);
		[Q_SIGNAL("void currentFontChanged(const QFont&)")]
		void CurrentFontChanged(QFont f);
		[Q_SIGNAL("void currentColorChanged(const QColor&)")]
		void CurrentColorChanged(QColor c);
		[Q_SIGNAL("void currentAlignmentChanged(int)")]
		void CurrentAlignmentChanged(int a);
		[Q_SIGNAL("void currentVerticalAlignmentChanged(QTextEdit::VerticalAlignment)")]
		void CurrentVerticalAlignmentChanged(int a);
		// void cursorPositionChanged(QTextCursor* arg1); >>>> NOT CONVERTED
		[Q_SIGNAL("void cursorPositionChanged(int, int)")]
		void CursorPositionChanged(int para, int pos);
		[Q_SIGNAL("void returnPressed()")]
		void ReturnPressed();
		[Q_SIGNAL("void modificationChanged(bool)")]
		void ModificationChanged(bool m);
		[Q_SIGNAL("void clicked(int, int)")]
		void Clicked(int parag, int index);
		[Q_SIGNAL("void doubleClicked(int, int)")]
		void DoubleClicked(int parag, int index);
	}
}
