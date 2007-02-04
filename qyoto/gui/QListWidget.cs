//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQListWidgetSignals"></see> for signals emitted by QListWidget
	[SmokeClass("QListWidget")]
	public class QListWidget : QListView, IDisposable {
 		protected QListWidget(Type dummy) : base((Type) null) {}
		[SmokeClass("QListWidget")]
		interface IQListWidgetProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QListWidget), this);
			_interceptor = (QListWidget) realProxy.GetTransparentProxy();
		}
		private QListWidget ProxyQListWidget() {
			return (QListWidget) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QListWidget() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQListWidgetProxy), null);
			_staticInterceptor = (IQListWidgetProxy) realProxy.GetTransparentProxy();
		}
		private static IQListWidgetProxy StaticQListWidget() {
			return (IQListWidgetProxy) _staticInterceptor;
		}
		[Q_PROPERTY("int", "count")]
		public int Count {
			get {
				return Property("count").Value<int>();
			}
		}
		[Q_PROPERTY("int", "currentRow")]
		public int CurrentRow {
			get {
				return Property("currentRow").Value<int>();
			}
			set {
				SetProperty("currentRow", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("bool", "sortingEnabled")]
		public bool SortingEnabled {
			get {
				return Property("sortingEnabled").Value<bool>();
			}
			set {
				SetProperty("sortingEnabled", QVariant.FromValue<bool>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QListWidget(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQListWidget(parent);
		}
		[SmokeMethod("QListWidget", "(QWidget*)", "#")]
		private void NewQListWidget(QWidget parent) {
			ProxyQListWidget().NewQListWidget(parent);
		}
		public QListWidget() : this((Type) null) {
			CreateProxy();
			NewQListWidget();
		}
		[SmokeMethod("QListWidget", "()", "")]
		private void NewQListWidget() {
			ProxyQListWidget().NewQListWidget();
		}
		[SmokeMethod("item", "(int) const", "$")]
		public QListWidgetItem Item(int row) {
			return ProxyQListWidget().Item(row);
		}
		[SmokeMethod("row", "(const QListWidgetItem*) const", "#")]
		public int Row(QListWidgetItem item) {
			return ProxyQListWidget().Row(item);
		}
		[SmokeMethod("insertItem", "(int, QListWidgetItem*)", "$#")]
		public void InsertItem(int row, QListWidgetItem item) {
			ProxyQListWidget().InsertItem(row,item);
		}
		[SmokeMethod("insertItem", "(int, const QString&)", "$$")]
		public void InsertItem(int row, string label) {
			ProxyQListWidget().InsertItem(row,label);
		}
		[SmokeMethod("insertItems", "(int, const QStringList&)", "$?")]
		public void InsertItems(int row, List<string> labels) {
			ProxyQListWidget().InsertItems(row,labels);
		}
		[SmokeMethod("addItem", "(const QString&)", "$")]
		public void AddItem(string label) {
			ProxyQListWidget().AddItem(label);
		}
		[SmokeMethod("addItem", "(QListWidgetItem*)", "#")]
		public void AddItem(QListWidgetItem item) {
			ProxyQListWidget().AddItem(item);
		}
		[SmokeMethod("addItems", "(const QStringList&)", "?")]
		public void AddItems(List<string> labels) {
			ProxyQListWidget().AddItems(labels);
		}
		[SmokeMethod("takeItem", "(int)", "$")]
		public QListWidgetItem TakeItem(int row) {
			return ProxyQListWidget().TakeItem(row);
		}
		[SmokeMethod("currentItem", "() const", "")]
		public QListWidgetItem CurrentItem() {
			return ProxyQListWidget().CurrentItem();
		}
		[SmokeMethod("setCurrentItem", "(QListWidgetItem*)", "#")]
		public void SetCurrentItem(QListWidgetItem item) {
			ProxyQListWidget().SetCurrentItem(item);
		}
		[SmokeMethod("itemAt", "(const QPoint&) const", "#")]
		public QListWidgetItem ItemAt(QPoint p) {
			return ProxyQListWidget().ItemAt(p);
		}
		[SmokeMethod("itemAt", "(int, int) const", "$$")]
		public QListWidgetItem ItemAt(int x, int y) {
			return ProxyQListWidget().ItemAt(x,y);
		}
		[SmokeMethod("visualItemRect", "(const QListWidgetItem*) const", "#")]
		public QRect VisualItemRect(QListWidgetItem item) {
			return ProxyQListWidget().VisualItemRect(item);
		}
		[SmokeMethod("sortItems", "(Qt::SortOrder)", "$")]
		public void SortItems(Qt.SortOrder order) {
			ProxyQListWidget().SortItems(order);
		}
		[SmokeMethod("sortItems", "()", "")]
		public void SortItems() {
			ProxyQListWidget().SortItems();
		}
		[SmokeMethod("isSortingEnabled", "() const", "")]
		public bool IsSortingEnabled() {
			return ProxyQListWidget().IsSortingEnabled();
		}
		[SmokeMethod("editItem", "(QListWidgetItem*)", "#")]
		public void EditItem(QListWidgetItem item) {
			ProxyQListWidget().EditItem(item);
		}
		[SmokeMethod("openPersistentEditor", "(QListWidgetItem*)", "#")]
		public new void OpenPersistentEditor(QListWidgetItem item) {
			ProxyQListWidget().OpenPersistentEditor(item);
		}
		[SmokeMethod("closePersistentEditor", "(QListWidgetItem*)", "#")]
		public new void ClosePersistentEditor(QListWidgetItem item) {
			ProxyQListWidget().ClosePersistentEditor(item);
		}
		[SmokeMethod("itemWidget", "(QListWidgetItem*) const", "#")]
		public QWidget ItemWidget(QListWidgetItem item) {
			return ProxyQListWidget().ItemWidget(item);
		}
		[SmokeMethod("setItemWidget", "(QListWidgetItem*, QWidget*)", "##")]
		public void SetItemWidget(QListWidgetItem item, QWidget widget) {
			ProxyQListWidget().SetItemWidget(item,widget);
		}
		[SmokeMethod("isItemSelected", "(const QListWidgetItem*) const", "#")]
		public bool IsItemSelected(QListWidgetItem item) {
			return ProxyQListWidget().IsItemSelected(item);
		}
		[SmokeMethod("setItemSelected", "(const QListWidgetItem*, bool)", "#$")]
		public void SetItemSelected(QListWidgetItem item, bool select) {
			ProxyQListWidget().SetItemSelected(item,select);
		}
		[SmokeMethod("selectedItems", "() const", "")]
		public List<QListWidgetItem> SelectedItems() {
			return ProxyQListWidget().SelectedItems();
		}
		[SmokeMethod("findItems", "(const QString&, Qt::MatchFlags) const", "$$")]
		public List<QListWidgetItem> FindItems(string text, int flags) {
			return ProxyQListWidget().FindItems(text,flags);
		}
		[SmokeMethod("isItemHidden", "(const QListWidgetItem*) const", "#")]
		public bool IsItemHidden(QListWidgetItem item) {
			return ProxyQListWidget().IsItemHidden(item);
		}
		[SmokeMethod("setItemHidden", "(const QListWidgetItem*, bool)", "#$")]
		public void SetItemHidden(QListWidgetItem item, bool hide) {
			ProxyQListWidget().SetItemHidden(item,hide);
		}
		[SmokeMethod("dropEvent", "(QDropEvent*)", "#")]
		public new void DropEvent(QDropEvent arg1) {
			ProxyQListWidget().DropEvent(arg1);
		}
		[Q_SLOT("void scrollToItem(const QListWidgetItem*, QAbstractItemView::ScrollHint)")]
		[SmokeMethod("scrollToItem", "(const QListWidgetItem*, QAbstractItemView::ScrollHint)", "#$")]
		public void ScrollToItem(QListWidgetItem item, QAbstractItemView.ScrollHint hint) {
			ProxyQListWidget().ScrollToItem(item,hint);
		}
		[Q_SLOT("void scrollToItem(const QListWidgetItem*)")]
		[SmokeMethod("scrollToItem", "(const QListWidgetItem*)", "#")]
		public void ScrollToItem(QListWidgetItem item) {
			ProxyQListWidget().ScrollToItem(item);
		}
		[Q_SLOT("void clear()")]
		[SmokeMethod("clear", "()", "")]
		public void Clear() {
			ProxyQListWidget().Clear();
		}
		public static new string Tr(string s, string c) {
			return StaticQListWidget().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQListWidget().Tr(s);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public new bool Event(QEvent e) {
			return ProxyQListWidget().Event(e);
		}
		[SmokeMethod("mimeTypes", "() const", "")]
		protected virtual List<string> MimeTypes() {
			return ProxyQListWidget().MimeTypes();
		}
		[SmokeMethod("mimeData", "(const QList<QListWidgetItem*>) const", "?")]
		protected virtual QMimeData MimeData(List<QListWidgetItem> items) {
			return ProxyQListWidget().MimeData(items);
		}
		[SmokeMethod("dropMimeData", "(int, const QMimeData*, Qt::DropAction)", "$#$")]
		protected virtual bool DropMimeData(int index, QMimeData data, Qt.DropAction action) {
			return ProxyQListWidget().DropMimeData(index,data,action);
		}
		[SmokeMethod("supportedDropActions", "() const", "")]
		protected virtual int SupportedDropActions() {
			return ProxyQListWidget().SupportedDropActions();
		}
		[SmokeMethod("items", "(const QMimeData*) const", "#")]
		protected List<QListWidgetItem> Items(QMimeData data) {
			return ProxyQListWidget().Items(data);
		}
		[SmokeMethod("indexFromItem", "(QListWidgetItem*) const", "#")]
		protected QModelIndex IndexFromItem(QListWidgetItem item) {
			return ProxyQListWidget().IndexFromItem(item);
		}
		[SmokeMethod("itemFromIndex", "(const QModelIndex&) const", "#")]
		protected QListWidgetItem ItemFromIndex(QModelIndex index) {
			return ProxyQListWidget().ItemFromIndex(index);
		}
		~QListWidget() {
			DisposeQListWidget();
		}
		public new void Dispose() {
			DisposeQListWidget();
		}
		[SmokeMethod("~QListWidget", "()", "")]
		private void DisposeQListWidget() {
			ProxyQListWidget().DisposeQListWidget();
		}
		protected new IQListWidgetSignals Emit {
			get {
				return (IQListWidgetSignals) Q_EMIT;
			}
		}
	}

	public interface IQListWidgetSignals : IQListViewSignals {
		[Q_SIGNAL("void itemPressed(QListWidgetItem*)")]
		void ItemPressed(QListWidgetItem item);
		[Q_SIGNAL("void itemClicked(QListWidgetItem*)")]
		void ItemClicked(QListWidgetItem item);
		[Q_SIGNAL("void itemDoubleClicked(QListWidgetItem*)")]
		void ItemDoubleClicked(QListWidgetItem item);
		[Q_SIGNAL("void itemActivated(QListWidgetItem*)")]
		void ItemActivated(QListWidgetItem item);
		[Q_SIGNAL("void itemEntered(QListWidgetItem*)")]
		void ItemEntered(QListWidgetItem item);
		[Q_SIGNAL("void itemChanged(QListWidgetItem*)")]
		void ItemChanged(QListWidgetItem item);
		[Q_SIGNAL("void currentItemChanged(QListWidgetItem*, QListWidgetItem*)")]
		void CurrentItemChanged(QListWidgetItem current, QListWidgetItem previous);
		[Q_SIGNAL("void currentTextChanged(const QString&)")]
		void CurrentTextChanged(string currentText);
		[Q_SIGNAL("void currentRowChanged(int)")]
		void CurrentRowChanged(int currentRow);
		[Q_SIGNAL("void itemSelectionChanged()")]
		void ItemSelectionChanged();
	}
}
