//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQUndoStackSignals"></see> for signals emitted by QUndoStack
	[SmokeClass("QUndoStack")]
	public class QUndoStack : QObject, IDisposable {
 		protected QUndoStack(Type dummy) : base((Type) null) {}
		[SmokeClass("QUndoStack")]
		interface IQUndoStackProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QUndoStack), this);
			_interceptor = (QUndoStack) realProxy.GetTransparentProxy();
		}
		private QUndoStack ProxyQUndoStack() {
			return (QUndoStack) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QUndoStack() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQUndoStackProxy), null);
			_staticInterceptor = (IQUndoStackProxy) realProxy.GetTransparentProxy();
		}
		private static IQUndoStackProxy StaticQUndoStack() {
			return (IQUndoStackProxy) _staticInterceptor;
		}
		[Q_PROPERTY("bool", "active")]
		public bool Active {
			get {
				return Property("active").Value<bool>();
			}
			set {
				SetProperty("active", QVariant.FromValue<bool>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QUndoStack(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQUndoStack(parent);
		}
		[SmokeMethod("QUndoStack", "(QObject*)", "#")]
		private void NewQUndoStack(QObject parent) {
			ProxyQUndoStack().NewQUndoStack(parent);
		}
		public QUndoStack() : this((Type) null) {
			CreateProxy();
			NewQUndoStack();
		}
		[SmokeMethod("QUndoStack", "()", "")]
		private void NewQUndoStack() {
			ProxyQUndoStack().NewQUndoStack();
		}
		[SmokeMethod("clear", "()", "")]
		public void Clear() {
			ProxyQUndoStack().Clear();
		}
		[SmokeMethod("push", "(QUndoCommand*)", "#")]
		public void Push(QUndoCommand cmd) {
			ProxyQUndoStack().Push(cmd);
		}
		[SmokeMethod("canUndo", "() const", "")]
		public bool CanUndo() {
			return ProxyQUndoStack().CanUndo();
		}
		[SmokeMethod("canRedo", "() const", "")]
		public bool CanRedo() {
			return ProxyQUndoStack().CanRedo();
		}
		[SmokeMethod("undoText", "() const", "")]
		public string UndoText() {
			return ProxyQUndoStack().UndoText();
		}
		[SmokeMethod("redoText", "() const", "")]
		public string RedoText() {
			return ProxyQUndoStack().RedoText();
		}
		[SmokeMethod("count", "() const", "")]
		public int Count() {
			return ProxyQUndoStack().Count();
		}
		[SmokeMethod("index", "() const", "")]
		public int Index() {
			return ProxyQUndoStack().Index();
		}
		[SmokeMethod("text", "(int) const", "$")]
		public string Text(int idx) {
			return ProxyQUndoStack().Text(idx);
		}
		[SmokeMethod("createUndoAction", "(QObject*, const QString&) const", "#$")]
		public QAction CreateUndoAction(QObject parent, string prefix) {
			return ProxyQUndoStack().CreateUndoAction(parent,prefix);
		}
		[SmokeMethod("createUndoAction", "(QObject*) const", "#")]
		public QAction CreateUndoAction(QObject parent) {
			return ProxyQUndoStack().CreateUndoAction(parent);
		}
		[SmokeMethod("createRedoAction", "(QObject*, const QString&) const", "#$")]
		public QAction CreateRedoAction(QObject parent, string prefix) {
			return ProxyQUndoStack().CreateRedoAction(parent,prefix);
		}
		[SmokeMethod("createRedoAction", "(QObject*) const", "#")]
		public QAction CreateRedoAction(QObject parent) {
			return ProxyQUndoStack().CreateRedoAction(parent);
		}
		[SmokeMethod("isActive", "() const", "")]
		public bool IsActive() {
			return ProxyQUndoStack().IsActive();
		}
		[SmokeMethod("isClean", "() const", "")]
		public bool IsClean() {
			return ProxyQUndoStack().IsClean();
		}
		[SmokeMethod("cleanIndex", "() const", "")]
		public int CleanIndex() {
			return ProxyQUndoStack().CleanIndex();
		}
		[SmokeMethod("beginMacro", "(const QString&)", "$")]
		public void BeginMacro(string text) {
			ProxyQUndoStack().BeginMacro(text);
		}
		[SmokeMethod("endMacro", "()", "")]
		public void EndMacro() {
			ProxyQUndoStack().EndMacro();
		}
		[Q_SLOT("void setClean()")]
		[SmokeMethod("setClean", "()", "")]
		public void SetClean() {
			ProxyQUndoStack().SetClean();
		}
		[Q_SLOT("void setIndex(int)")]
		[SmokeMethod("setIndex", "(int)", "$")]
		public void SetIndex(int idx) {
			ProxyQUndoStack().SetIndex(idx);
		}
		[Q_SLOT("void undo()")]
		[SmokeMethod("undo", "()", "")]
		public void Undo() {
			ProxyQUndoStack().Undo();
		}
		[Q_SLOT("void redo()")]
		[SmokeMethod("redo", "()", "")]
		public void Redo() {
			ProxyQUndoStack().Redo();
		}
		public static new string Tr(string s, string c) {
			return StaticQUndoStack().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQUndoStack().Tr(s);
		}
		~QUndoStack() {
			DisposeQUndoStack();
		}
		public new void Dispose() {
			DisposeQUndoStack();
		}
		[SmokeMethod("~QUndoStack", "()", "")]
		private void DisposeQUndoStack() {
			ProxyQUndoStack().DisposeQUndoStack();
		}
		protected new IQUndoStackSignals Emit {
			get {
				return (IQUndoStackSignals) Q_EMIT;
			}
		}
	}

	public interface IQUndoStackSignals : IQObjectSignals {
		[Q_SIGNAL("void indexChanged(int)")]
		void IndexChanged(int idx);
		[Q_SIGNAL("void cleanChanged(bool)")]
		void CleanChanged(bool clean);
		[Q_SIGNAL("void canUndoChanged(bool)")]
		void CanUndoChanged(bool canUndo);
		[Q_SIGNAL("void canRedoChanged(bool)")]
		void CanRedoChanged(bool canRedo);
		[Q_SIGNAL("void undoTextChanged(const QString&)")]
		void UndoTextChanged(string undoText);
		[Q_SIGNAL("void redoTextChanged(const QString&)")]
		void RedoTextChanged(string redoText);
	}
}
