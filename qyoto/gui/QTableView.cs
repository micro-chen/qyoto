//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QTableView")]
	public class QTableView : QAbstractItemView, IDisposable {
 		protected QTableView(Type dummy) : base((Type) null) {}
		[SmokeClass("QTableView")]
		interface IQTableViewProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTableView), this);
			_interceptor = (QTableView) realProxy.GetTransparentProxy();
		}
		private QTableView ProxyQTableView() {
			return (QTableView) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTableView() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTableViewProxy), null);
			_staticInterceptor = (IQTableViewProxy) realProxy.GetTransparentProxy();
		}
		private static IQTableViewProxy StaticQTableView() {
			return (IQTableViewProxy) _staticInterceptor;
		}
		[Q_PROPERTY("bool", "showGrid")]
		public bool ShowGrid {
			get {
				return Property("showGrid").Value<bool>();
			}
			set {
				SetProperty("showGrid", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("Qt::PenStyle", "gridStyle")]
		public Qt.PenStyle GridStyle {
			get {
				return Property("gridStyle").Value<Qt.PenStyle>();
			}
			set {
				SetProperty("gridStyle", QVariant.FromValue<Qt.PenStyle>(value));
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
		public QTableView(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQTableView(parent);
		}
		[SmokeMethod("QTableView", "(QWidget*)", "#")]
		private void NewQTableView(QWidget parent) {
			ProxyQTableView().NewQTableView(parent);
		}
		public QTableView() : this((Type) null) {
			CreateProxy();
			NewQTableView();
		}
		[SmokeMethod("QTableView", "()", "")]
		private void NewQTableView() {
			ProxyQTableView().NewQTableView();
		}
		[SmokeMethod("setModel", "(QAbstractItemModel*)", "#")]
		public new void SetModel(QAbstractItemModel model) {
			ProxyQTableView().SetModel(model);
		}
		[SmokeMethod("setRootIndex", "(const QModelIndex&)", "#")]
		public new void SetRootIndex(QModelIndex index) {
			ProxyQTableView().SetRootIndex(index);
		}
		[SmokeMethod("setSelectionModel", "(QItemSelectionModel*)", "#")]
		public new void SetSelectionModel(QItemSelectionModel selectionModel) {
			ProxyQTableView().SetSelectionModel(selectionModel);
		}
		[SmokeMethod("horizontalHeader", "() const", "")]
		public QHeaderView HorizontalHeader() {
			return ProxyQTableView().HorizontalHeader();
		}
		[SmokeMethod("verticalHeader", "() const", "")]
		public QHeaderView VerticalHeader() {
			return ProxyQTableView().VerticalHeader();
		}
		[SmokeMethod("setHorizontalHeader", "(QHeaderView*)", "#")]
		public void SetHorizontalHeader(QHeaderView header) {
			ProxyQTableView().SetHorizontalHeader(header);
		}
		[SmokeMethod("setVerticalHeader", "(QHeaderView*)", "#")]
		public void SetVerticalHeader(QHeaderView header) {
			ProxyQTableView().SetVerticalHeader(header);
		}
		[SmokeMethod("rowViewportPosition", "(int) const", "$")]
		public int RowViewportPosition(int row) {
			return ProxyQTableView().RowViewportPosition(row);
		}
		[SmokeMethod("rowAt", "(int) const", "$")]
		public int RowAt(int y) {
			return ProxyQTableView().RowAt(y);
		}
		[SmokeMethod("setRowHeight", "(int, int)", "$$")]
		public void SetRowHeight(int row, int height) {
			ProxyQTableView().SetRowHeight(row,height);
		}
		[SmokeMethod("rowHeight", "(int) const", "$")]
		public int RowHeight(int row) {
			return ProxyQTableView().RowHeight(row);
		}
		[SmokeMethod("columnViewportPosition", "(int) const", "$")]
		public int ColumnViewportPosition(int column) {
			return ProxyQTableView().ColumnViewportPosition(column);
		}
		[SmokeMethod("columnAt", "(int) const", "$")]
		public int ColumnAt(int x) {
			return ProxyQTableView().ColumnAt(x);
		}
		[SmokeMethod("setColumnWidth", "(int, int)", "$$")]
		public void SetColumnWidth(int column, int width) {
			ProxyQTableView().SetColumnWidth(column,width);
		}
		[SmokeMethod("columnWidth", "(int) const", "$")]
		public int ColumnWidth(int column) {
			return ProxyQTableView().ColumnWidth(column);
		}
		[SmokeMethod("isRowHidden", "(int) const", "$")]
		public bool IsRowHidden(int row) {
			return ProxyQTableView().IsRowHidden(row);
		}
		[SmokeMethod("setRowHidden", "(int, bool)", "$$")]
		public void SetRowHidden(int row, bool hide) {
			ProxyQTableView().SetRowHidden(row,hide);
		}
		[SmokeMethod("isColumnHidden", "(int) const", "$")]
		public bool IsColumnHidden(int column) {
			return ProxyQTableView().IsColumnHidden(column);
		}
		[SmokeMethod("setColumnHidden", "(int, bool)", "$$")]
		public void SetColumnHidden(int column, bool hide) {
			ProxyQTableView().SetColumnHidden(column,hide);
		}
		[SmokeMethod("isSortingEnabled", "() const", "")]
		public bool IsSortingEnabled() {
			return ProxyQTableView().IsSortingEnabled();
		}
		[SmokeMethod("visualRect", "(const QModelIndex&) const", "#")]
		public new QRect VisualRect(QModelIndex index) {
			return ProxyQTableView().VisualRect(index);
		}
		[SmokeMethod("scrollTo", "(const QModelIndex&, QAbstractItemView::ScrollHint)", "#$")]
		public new void ScrollTo(QModelIndex index, QAbstractItemView.ScrollHint hint) {
			ProxyQTableView().ScrollTo(index,hint);
		}
		[SmokeMethod("scrollTo", "(const QModelIndex&)", "#")]
		public new void ScrollTo(QModelIndex index) {
			ProxyQTableView().ScrollTo(index);
		}
		[SmokeMethod("indexAt", "(const QPoint&) const", "#")]
		public new QModelIndex IndexAt(QPoint p) {
			return ProxyQTableView().IndexAt(p);
		}
		[SmokeMethod("setSpan", "(int, int, int, int)", "$$$$")]
		public void SetSpan(int row, int column, int rowSpan, int columnSpan) {
			ProxyQTableView().SetSpan(row,column,rowSpan,columnSpan);
		}
		[SmokeMethod("rowSpan", "(int, int) const", "$$")]
		public int RowSpan(int row, int column) {
			return ProxyQTableView().RowSpan(row,column);
		}
		[SmokeMethod("columnSpan", "(int, int) const", "$$")]
		public int ColumnSpan(int row, int column) {
			return ProxyQTableView().ColumnSpan(row,column);
		}
		[SmokeMethod("sortByColumn", "(int, Qt::SortOrder)", "$$")]
		public void SortByColumn(int column, Qt.SortOrder order) {
			ProxyQTableView().SortByColumn(column,order);
		}
		[Q_SLOT("void selectRow(int)")]
		[SmokeMethod("selectRow", "(int)", "$")]
		public void SelectRow(int row) {
			ProxyQTableView().SelectRow(row);
		}
		[Q_SLOT("void selectColumn(int)")]
		[SmokeMethod("selectColumn", "(int)", "$")]
		public void SelectColumn(int column) {
			ProxyQTableView().SelectColumn(column);
		}
		[Q_SLOT("void hideRow(int)")]
		[SmokeMethod("hideRow", "(int)", "$")]
		public void HideRow(int row) {
			ProxyQTableView().HideRow(row);
		}
		[Q_SLOT("void hideColumn(int)")]
		[SmokeMethod("hideColumn", "(int)", "$")]
		public void HideColumn(int column) {
			ProxyQTableView().HideColumn(column);
		}
		[Q_SLOT("void showRow(int)")]
		[SmokeMethod("showRow", "(int)", "$")]
		public void ShowRow(int row) {
			ProxyQTableView().ShowRow(row);
		}
		[Q_SLOT("void showColumn(int)")]
		[SmokeMethod("showColumn", "(int)", "$")]
		public void ShowColumn(int column) {
			ProxyQTableView().ShowColumn(column);
		}
		[Q_SLOT("void resizeRowToContents(int)")]
		[SmokeMethod("resizeRowToContents", "(int)", "$")]
		public void ResizeRowToContents(int row) {
			ProxyQTableView().ResizeRowToContents(row);
		}
		[Q_SLOT("void resizeRowsToContents()")]
		[SmokeMethod("resizeRowsToContents", "()", "")]
		public void ResizeRowsToContents() {
			ProxyQTableView().ResizeRowsToContents();
		}
		[Q_SLOT("void resizeColumnToContents(int)")]
		[SmokeMethod("resizeColumnToContents", "(int)", "$")]
		public void ResizeColumnToContents(int column) {
			ProxyQTableView().ResizeColumnToContents(column);
		}
		[Q_SLOT("void resizeColumnsToContents()")]
		[SmokeMethod("resizeColumnsToContents", "()", "")]
		public void ResizeColumnsToContents() {
			ProxyQTableView().ResizeColumnsToContents();
		}
		[Q_SLOT("void sortByColumn(int)")]
		[SmokeMethod("sortByColumn", "(int)", "$")]
		public void SortByColumn(int column) {
			ProxyQTableView().SortByColumn(column);
		}
		public static new string Tr(string s, string c) {
			return StaticQTableView().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQTableView().Tr(s);
		}
		[SmokeMethod("scrollContentsBy", "(int, int)", "$$")]
		protected new void ScrollContentsBy(int dx, int dy) {
			ProxyQTableView().ScrollContentsBy(dx,dy);
		}
		[SmokeMethod("viewOptions", "() const", "")]
		protected new QStyleOptionViewItem ViewOptions() {
			return ProxyQTableView().ViewOptions();
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected new void PaintEvent(QPaintEvent e) {
			ProxyQTableView().PaintEvent(e);
		}
		[SmokeMethod("timerEvent", "(QTimerEvent*)", "#")]
		protected new void TimerEvent(QTimerEvent arg1) {
			ProxyQTableView().TimerEvent(arg1);
		}
		[SmokeMethod("horizontalOffset", "() const", "")]
		protected new int HorizontalOffset() {
			return ProxyQTableView().HorizontalOffset();
		}
		[SmokeMethod("verticalOffset", "() const", "")]
		protected new int VerticalOffset() {
			return ProxyQTableView().VerticalOffset();
		}
		[SmokeMethod("moveCursor", "(QAbstractItemView::CursorAction, Qt::KeyboardModifiers)", "$$")]
		protected new QModelIndex MoveCursor(QAbstractItemView.CursorAction cursorAction, int modifiers) {
			return ProxyQTableView().MoveCursor(cursorAction,modifiers);
		}
		[SmokeMethod("setSelection", "(const QRect&, QItemSelectionModel::SelectionFlags)", "#$")]
		protected new void SetSelection(QRect rect, int command) {
			ProxyQTableView().SetSelection(rect,command);
		}
		[SmokeMethod("visualRegionForSelection", "(const QItemSelection&) const", "#")]
		protected new QRegion VisualRegionForSelection(QItemSelection selection) {
			return ProxyQTableView().VisualRegionForSelection(selection);
		}
		[SmokeMethod("selectedIndexes", "() const", "")]
		protected new List<QModelIndex> SelectedIndexes() {
			return ProxyQTableView().SelectedIndexes();
		}
		[SmokeMethod("updateGeometries", "()", "")]
		protected new void UpdateGeometries() {
			ProxyQTableView().UpdateGeometries();
		}
		[SmokeMethod("sizeHintForRow", "(int) const", "$")]
		protected new int SizeHintForRow(int row) {
			return ProxyQTableView().SizeHintForRow(row);
		}
		[SmokeMethod("sizeHintForColumn", "(int) const", "$")]
		protected new int SizeHintForColumn(int column) {
			return ProxyQTableView().SizeHintForColumn(column);
		}
		[SmokeMethod("verticalScrollbarAction", "(int)", "$")]
		protected new void VerticalScrollbarAction(int action) {
			ProxyQTableView().VerticalScrollbarAction(action);
		}
		[SmokeMethod("horizontalScrollbarAction", "(int)", "$")]
		protected new void HorizontalScrollbarAction(int action) {
			ProxyQTableView().HorizontalScrollbarAction(action);
		}
		[SmokeMethod("isIndexHidden", "(const QModelIndex&) const", "#")]
		protected new bool IsIndexHidden(QModelIndex index) {
			return ProxyQTableView().IsIndexHidden(index);
		}
		[Q_SLOT("void rowMoved(int, int, int)")]
		[SmokeMethod("rowMoved", "(int, int, int)", "$$$")]
		protected void RowMoved(int row, int oldIndex, int newIndex) {
			ProxyQTableView().RowMoved(row,oldIndex,newIndex);
		}
		[Q_SLOT("void columnMoved(int, int, int)")]
		[SmokeMethod("columnMoved", "(int, int, int)", "$$$")]
		protected void ColumnMoved(int column, int oldIndex, int newIndex) {
			ProxyQTableView().ColumnMoved(column,oldIndex,newIndex);
		}
		[Q_SLOT("void rowResized(int, int, int)")]
		[SmokeMethod("rowResized", "(int, int, int)", "$$$")]
		protected void RowResized(int row, int oldHeight, int newHeight) {
			ProxyQTableView().RowResized(row,oldHeight,newHeight);
		}
		[Q_SLOT("void columnResized(int, int, int)")]
		[SmokeMethod("columnResized", "(int, int, int)", "$$$")]
		protected void ColumnResized(int column, int oldWidth, int newWidth) {
			ProxyQTableView().ColumnResized(column,oldWidth,newWidth);
		}
		[Q_SLOT("void rowCountChanged(int, int)")]
		[SmokeMethod("rowCountChanged", "(int, int)", "$$")]
		protected void RowCountChanged(int oldCount, int newCount) {
			ProxyQTableView().RowCountChanged(oldCount,newCount);
		}
		[Q_SLOT("void columnCountChanged(int, int)")]
		[SmokeMethod("columnCountChanged", "(int, int)", "$$")]
		protected void ColumnCountChanged(int oldCount, int newCount) {
			ProxyQTableView().ColumnCountChanged(oldCount,newCount);
		}
		~QTableView() {
			DisposeQTableView();
		}
		public new void Dispose() {
			DisposeQTableView();
		}
		[SmokeMethod("~QTableView", "()", "")]
		private void DisposeQTableView() {
			ProxyQTableView().DisposeQTableView();
		}
		protected new IQTableViewSignals Emit {
			get {
				return (IQTableViewSignals) Q_EMIT;
			}
		}
	}

	public interface IQTableViewSignals : IQAbstractItemViewSignals {
	}
}
