//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQAbstractItemDelegateSignals"></see> for signals emitted by QAbstractItemDelegate
	public class QAbstractItemDelegate : QObject {
 		protected QAbstractItemDelegate(Type dummy) : base((Type) null) {}
		interface IQAbstractItemDelegateProxy {
			string Tr(string s, string c);
			string Tr(string s);
			string ElidedText(QFontMetrics fontMetrics, int width, int mode, string text);
		}

		protected void CreateQAbstractItemDelegateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAbstractItemDelegate), this);
			_interceptor = (QAbstractItemDelegate) realProxy.GetTransparentProxy();
		}
		private QAbstractItemDelegate ProxyQAbstractItemDelegate() {
			return (QAbstractItemDelegate) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAbstractItemDelegate() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAbstractItemDelegateProxy), null);
			_staticInterceptor = (IQAbstractItemDelegateProxy) realProxy.GetTransparentProxy();
		}
		private static IQAbstractItemDelegateProxy StaticQAbstractItemDelegate() {
			return (IQAbstractItemDelegateProxy) _staticInterceptor;
		}

		enum EndEditHint {
			NoHint = 0,
			EditNextItem = 1,
			EditPreviousItem = 2,
			SubmitModelCache = 3,
			RevertModelCache = 4,
		}
		public new virtual QMetaObject MetaObject() {
			return ProxyQAbstractItemDelegate().MetaObject();
		}
		// void* qt_metacast(const char* arg1); >>>> NOT CONVERTED
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public virtual void Paint(QPainter painter, QStyleOptionViewItem option, QModelIndex index) {
			ProxyQAbstractItemDelegate().Paint(painter,option,index);
		}
		public virtual QSize SizeHint(QStyleOptionViewItem option, QModelIndex index) {
			return ProxyQAbstractItemDelegate().SizeHint(option,index);
		}
		public virtual QWidget CreateEditor(QWidget parent, QStyleOptionViewItem option, QModelIndex index) {
			return ProxyQAbstractItemDelegate().CreateEditor(parent,option,index);
		}
		public virtual void SetEditorData(QWidget editor, QModelIndex index) {
			ProxyQAbstractItemDelegate().SetEditorData(editor,index);
		}
		public virtual void SetModelData(QWidget editor, QAbstractItemModel model, QModelIndex index) {
			ProxyQAbstractItemDelegate().SetModelData(editor,model,index);
		}
		public virtual void UpdateEditorGeometry(QWidget editor, QStyleOptionViewItem option, QModelIndex index) {
			ProxyQAbstractItemDelegate().UpdateEditorGeometry(editor,option,index);
		}
		public virtual bool EditorEvent(QEvent arg1, QAbstractItemModel model, QStyleOptionViewItem option, QModelIndex index) {
			return ProxyQAbstractItemDelegate().EditorEvent(arg1,model,option,index);
		}
		public static new string Tr(string s, string c) {
			return StaticQAbstractItemDelegate().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQAbstractItemDelegate().Tr(s);
		}
		public static string ElidedText(QFontMetrics fontMetrics, int width, int mode, string text) {
			return StaticQAbstractItemDelegate().ElidedText(fontMetrics,width,mode,text);
		}
	}

	public interface IQAbstractItemDelegateSignals {
		void CommitData(QWidget editor);
		void CloseEditor(QWidget editor, int hint);
		void CloseEditor(QWidget editor);
	}
}
