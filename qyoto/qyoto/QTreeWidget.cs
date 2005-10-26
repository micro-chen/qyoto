//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	/// See <see cref="IQTreeWidgetSignals"></see> for signals emitted by QTreeWidget
	public class QTreeWidget : QTreeView, IDisposable {
 		protected QTreeWidget(Type dummy) : base((Type) null) {}
		interface IQTreeWidgetProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected void CreateQTreeWidgetProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTreeWidget), this);
			_interceptor = (QTreeWidget) realProxy.GetTransparentProxy();
		}
		private QTreeWidget ProxyQTreeWidget() {
			return (QTreeWidget) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTreeWidget() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTreeWidgetProxy), null);
			_staticInterceptor = (IQTreeWidgetProxy) realProxy.GetTransparentProxy();
		}
		private static IQTreeWidgetProxy StaticQTreeWidget() {
			return (IQTreeWidgetProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQTreeWidget().MetaObject();
		}
		// void* qt_metacast(const char* arg1); >>>> NOT CONVERTED
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QTreeWidget(QWidget parent) : this((Type) null) {
			CreateQTreeWidgetProxy();
			NewQTreeWidget(parent);
		}
		private void NewQTreeWidget(QWidget parent) {
			ProxyQTreeWidget().NewQTreeWidget(parent);
		}
		public QTreeWidget() : this((Type) null) {
			CreateQTreeWidgetProxy();
			NewQTreeWidget();
		}
		private void NewQTreeWidget() {
			ProxyQTreeWidget().NewQTreeWidget();
		}
		public int ColumnCount() {
			return ProxyQTreeWidget().ColumnCount();
		}
		public void SetColumnCount(int columns) {
			ProxyQTreeWidget().SetColumnCount(columns);
		}
		public QTreeWidgetItem TopLevelItem(int index) {
			return ProxyQTreeWidget().TopLevelItem(index);
		}
		public int TopLevelItemCount() {
			return ProxyQTreeWidget().TopLevelItemCount();
		}
		public void InsertTopLevelItem(int index, QTreeWidgetItem item) {
			ProxyQTreeWidget().InsertTopLevelItem(index,item);
		}
		public void AddTopLevelItem(QTreeWidgetItem item) {
			ProxyQTreeWidget().AddTopLevelItem(item);
		}
		public QTreeWidgetItem TakeTopLevelItem(int index) {
			return ProxyQTreeWidget().TakeTopLevelItem(index);
		}
		public int IndexOfTopLevelItem(QTreeWidgetItem item) {
			return ProxyQTreeWidget().IndexOfTopLevelItem(item);
		}
		public QTreeWidgetItem HeaderItem() {
			return ProxyQTreeWidget().HeaderItem();
		}
		public void SetHeaderItem(QTreeWidgetItem item) {
			ProxyQTreeWidget().SetHeaderItem(item);
		}
		public void SetHeaderLabels(string[] labels) {
			ProxyQTreeWidget().SetHeaderLabels(labels);
		}
		public QTreeWidgetItem CurrentItem() {
			return ProxyQTreeWidget().CurrentItem();
		}
		public void SetCurrentItem(QTreeWidgetItem item) {
			ProxyQTreeWidget().SetCurrentItem(item);
		}
		public QTreeWidgetItem ItemAt(QPoint p) {
			return ProxyQTreeWidget().ItemAt(p);
		}
		public QTreeWidgetItem ItemAt(int x, int y) {
			return ProxyQTreeWidget().ItemAt(x,y);
		}
		public QRect VisualItemRect(QTreeWidgetItem item) {
			return ProxyQTreeWidget().VisualItemRect(item);
		}
		public void SortItems(int column, int order) {
			ProxyQTreeWidget().SortItems(column,order);
		}
		public void SetSortingEnabled(bool enable) {
			ProxyQTreeWidget().SetSortingEnabled(enable);
		}
		public bool IsSortingEnabled() {
			return ProxyQTreeWidget().IsSortingEnabled();
		}
		public void EditItem(QTreeWidgetItem item, int column) {
			ProxyQTreeWidget().EditItem(item,column);
		}
		public void EditItem(QTreeWidgetItem item) {
			ProxyQTreeWidget().EditItem(item);
		}
		public new void OpenPersistentEditor(QTreeWidgetItem item, int column) {
			ProxyQTreeWidget().OpenPersistentEditor(item,column);
		}
		public new void OpenPersistentEditor(QTreeWidgetItem item) {
			ProxyQTreeWidget().OpenPersistentEditor(item);
		}
		public new void ClosePersistentEditor(QTreeWidgetItem item, int column) {
			ProxyQTreeWidget().ClosePersistentEditor(item,column);
		}
		public new void ClosePersistentEditor(QTreeWidgetItem item) {
			ProxyQTreeWidget().ClosePersistentEditor(item);
		}
		public bool IsItemSelected(QTreeWidgetItem item) {
			return ProxyQTreeWidget().IsItemSelected(item);
		}
		public void SetItemSelected(QTreeWidgetItem item, bool select) {
			ProxyQTreeWidget().SetItemSelected(item,select);
		}
		// QList<QTreeWidgetItem*> selectedItems(); >>>> NOT CONVERTED
		// QList<QTreeWidgetItem*> findItems(const QString& arg1,Qt::MatchFlags arg2,int arg3); >>>> NOT CONVERTED
		// QList<QTreeWidgetItem*> findItems(const QString& arg1,Qt::MatchFlags arg2); >>>> NOT CONVERTED
		public bool IsItemHidden(QTreeWidgetItem item) {
			return ProxyQTreeWidget().IsItemHidden(item);
		}
		public void SetItemHidden(QTreeWidgetItem item, bool hide) {
			ProxyQTreeWidget().SetItemHidden(item,hide);
		}
		public bool IsItemExpanded(QTreeWidgetItem item) {
			return ProxyQTreeWidget().IsItemExpanded(item);
		}
		public void SetItemExpanded(QTreeWidgetItem item, bool expand) {
			ProxyQTreeWidget().SetItemExpanded(item,expand);
		}
		public void ScrollToItem(QTreeWidgetItem item, int hint) {
			ProxyQTreeWidget().ScrollToItem(item,hint);
		}
		public void ScrollToItem(QTreeWidgetItem item) {
			ProxyQTreeWidget().ScrollToItem(item);
		}
		public void ExpandItem(QTreeWidgetItem item) {
			ProxyQTreeWidget().ExpandItem(item);
		}
		public void CollapseItem(QTreeWidgetItem item) {
			ProxyQTreeWidget().CollapseItem(item);
		}
		public void Clear() {
			ProxyQTreeWidget().Clear();
		}
		public static new string Tr(string s, string c) {
			return StaticQTreeWidget().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQTreeWidget().Tr(s);
		}
		protected virtual ArrayList MimeTypes() {
			return ProxyQTreeWidget().MimeTypes();
		}
		// QMimeData* mimeData(const QList<QTreeWidgetItem*> arg1); >>>> NOT CONVERTED
		protected virtual bool DropMimeData(QTreeWidgetItem parent, int index, QMimeData data, int action) {
			return ProxyQTreeWidget().DropMimeData(parent,index,data,action);
		}
		protected virtual int SupportedDropActions() {
			return ProxyQTreeWidget().SupportedDropActions();
		}
		// QList<QTreeWidgetItem*> items(const QMimeData* arg1); >>>> NOT CONVERTED
		protected QModelIndex IndexFromItem(QTreeWidgetItem item, int column) {
			return ProxyQTreeWidget().IndexFromItem(item,column);
		}
		protected QModelIndex IndexFromItem(QTreeWidgetItem item) {
			return ProxyQTreeWidget().IndexFromItem(item);
		}
		protected QTreeWidgetItem ItemFromIndex(QModelIndex index) {
			return ProxyQTreeWidget().ItemFromIndex(index);
		}
		~QTreeWidget() {
			ProxyQTreeWidget().Dispose();
		}
		public new void Dispose() {
			ProxyQTreeWidget().Dispose();
		}
	}

	public interface IQTreeWidgetSignals {
		void ItemPressed(QTreeWidgetItem item, int column);
		void ItemClicked(QTreeWidgetItem item, int column);
		void ItemDoubleClicked(QTreeWidgetItem item, int column);
		void ItemActivated(QTreeWidgetItem item, int column);
		void ItemEntered(QTreeWidgetItem item, int column);
		void ItemChanged(QTreeWidgetItem item, int column);
		void ItemExpanded(QTreeWidgetItem item);
		void ItemCollapsed(QTreeWidgetItem item);
		void CurrentItemChanged(QTreeWidgetItem current, QTreeWidgetItem previous);
		void ItemSelectionChanged();
	}
}
