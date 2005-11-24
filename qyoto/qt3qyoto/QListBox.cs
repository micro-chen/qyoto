//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQListBoxSignals"></see> for signals emitted by QListBox
	public class QListBox : QScrollView, IDisposable {
 		protected QListBox(Type dummy) : base((Type) null) {}
		interface IQListBoxProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQListBoxProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QListBox), this);
			_interceptor = (QListBox) realProxy.GetTransparentProxy();
		}
		private QListBox ProxyQListBox() {
			return (QListBox) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QListBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQListBoxProxy), null);
			_staticInterceptor = (IQListBoxProxy) realProxy.GetTransparentProxy();
		}
		private static IQListBoxProxy StaticQListBox() {
			return (IQListBoxProxy) _staticInterceptor;
		}

		enum E_SelectionMode {
			Single = 0,
			Multi = 1,
			Extended = 2,
			NoSelection = 3,
		}
		enum LayoutMode {
			FixedNumber = 0,
			FitToWidth = 1,
			FitToHeight = FitToWidth,
			Variable = 2,
		}
		public new virtual QMetaObject MetaObject() {
			return ProxyQListBox().MetaObject();
		}
		public new virtual string ClassName() {
			return ProxyQListBox().ClassName();
		}
		public QListBox(QWidget parent, string name, int f) : this((Type) null) {
			CreateQListBoxProxy();
			NewQListBox(parent,name,f);
		}
		private void NewQListBox(QWidget parent, string name, int f) {
			ProxyQListBox().NewQListBox(parent,name,f);
		}
		public QListBox(QWidget parent, string name) : this((Type) null) {
			CreateQListBoxProxy();
			NewQListBox(parent,name);
		}
		private void NewQListBox(QWidget parent, string name) {
			ProxyQListBox().NewQListBox(parent,name);
		}
		public QListBox(QWidget parent) : this((Type) null) {
			CreateQListBoxProxy();
			NewQListBox(parent);
		}
		private void NewQListBox(QWidget parent) {
			ProxyQListBox().NewQListBox(parent);
		}
		public QListBox() : this((Type) null) {
			CreateQListBoxProxy();
			NewQListBox();
		}
		private void NewQListBox() {
			ProxyQListBox().NewQListBox();
		}
		public new virtual void SetFont(QFont arg1) {
			ProxyQListBox().SetFont(arg1);
		}
		public uint Count() {
			return ProxyQListBox().Count();
		}
		public void InsertStringList(string[] arg1, int index) {
			ProxyQListBox().InsertStringList(arg1,index);
		}
		public void InsertStringList(string[] arg1) {
			ProxyQListBox().InsertStringList(arg1);
		}
		public void InsertStrList(string[] arg1, int index) {
			ProxyQListBox().InsertStrList(arg1,index);
		}
		public void InsertStrList(string[] arg1) {
			ProxyQListBox().InsertStrList(arg1);
		}
		public void InsertStrList(string[] arg1, int numStrings, int index) {
			ProxyQListBox().InsertStrList(arg1,numStrings,index);
		}
		public void InsertItem(QListBoxItem arg1, int index) {
			ProxyQListBox().InsertItem(arg1,index);
		}
		public void InsertItem(QListBoxItem arg1) {
			ProxyQListBox().InsertItem(arg1);
		}
		public void InsertItem(QListBoxItem arg1, QListBoxItem after) {
			ProxyQListBox().InsertItem(arg1,after);
		}
		public void InsertItem(string text, int index) {
			ProxyQListBox().InsertItem(text,index);
		}
		public void InsertItem(string text) {
			ProxyQListBox().InsertItem(text);
		}
		public void InsertItem(QPixmap pixmap, int index) {
			ProxyQListBox().InsertItem(pixmap,index);
		}
		public void InsertItem(QPixmap pixmap) {
			ProxyQListBox().InsertItem(pixmap);
		}
		public void InsertItem(QPixmap pixmap, string text, int index) {
			ProxyQListBox().InsertItem(pixmap,text,index);
		}
		public void InsertItem(QPixmap pixmap, string text) {
			ProxyQListBox().InsertItem(pixmap,text);
		}
		public void RemoveItem(int index) {
			ProxyQListBox().RemoveItem(index);
		}
		public string Text(int index) {
			return ProxyQListBox().Text(index);
		}
		public QPixmap Pixmap(int index) {
			return ProxyQListBox().Pixmap(index);
		}
		public void ChangeItem(QListBoxItem arg1, int index) {
			ProxyQListBox().ChangeItem(arg1,index);
		}
		public void ChangeItem(string text, int index) {
			ProxyQListBox().ChangeItem(text,index);
		}
		public void ChangeItem(QPixmap pixmap, int index) {
			ProxyQListBox().ChangeItem(pixmap,index);
		}
		public void ChangeItem(QPixmap pixmap, string text, int index) {
			ProxyQListBox().ChangeItem(pixmap,text,index);
		}
		public void TakeItem(QListBoxItem arg1) {
			ProxyQListBox().TakeItem(arg1);
		}
		public int NumItemsVisible() {
			return ProxyQListBox().NumItemsVisible();
		}
		public int CurrentItem() {
			return ProxyQListBox().CurrentItem();
		}
		public string CurrentText() {
			return ProxyQListBox().CurrentText();
		}
		public virtual void SetCurrentItem(int index) {
			ProxyQListBox().SetCurrentItem(index);
		}
		public virtual void SetCurrentItem(QListBoxItem arg1) {
			ProxyQListBox().SetCurrentItem(arg1);
		}
		public void CenterCurrentItem() {
			ProxyQListBox().CenterCurrentItem();
		}
		public int TopItem() {
			return ProxyQListBox().TopItem();
		}
		public virtual void SetTopItem(int index) {
			ProxyQListBox().SetTopItem(index);
		}
		public virtual void SetBottomItem(int index) {
			ProxyQListBox().SetBottomItem(index);
		}
		public long MaxItemWidth() {
			return ProxyQListBox().MaxItemWidth();
		}
		public virtual void SetSelectionMode(int arg1) {
			ProxyQListBox().SetSelectionMode(arg1);
		}
		public int SelectionMode() {
			return ProxyQListBox().SelectionMode();
		}
		public void SetMultiSelection(bool multi) {
			ProxyQListBox().SetMultiSelection(multi);
		}
		public bool IsMultiSelection() {
			return ProxyQListBox().IsMultiSelection();
		}
		public virtual void SetSelected(QListBoxItem arg1, bool arg2) {
			ProxyQListBox().SetSelected(arg1,arg2);
		}
		public void SetSelected(int arg1, bool arg2) {
			ProxyQListBox().SetSelected(arg1,arg2);
		}
		public bool IsSelected(int arg1) {
			return ProxyQListBox().IsSelected(arg1);
		}
		public bool IsSelected(QListBoxItem arg1) {
			return ProxyQListBox().IsSelected(arg1);
		}
		public QListBoxItem SelectedItem() {
			return ProxyQListBox().SelectedItem();
		}
		public new QSize SizeHint() {
			return ProxyQListBox().SizeHint();
		}
		public new QSize MinimumSizeHint() {
			return ProxyQListBox().MinimumSizeHint();
		}
		public QListBoxItem Item(int index) {
			return ProxyQListBox().Item(index);
		}
		public int Index(QListBoxItem arg1) {
			return ProxyQListBox().Index(arg1);
		}
		public QListBoxItem FindItem(string text, uint compare) {
			return ProxyQListBox().FindItem(text,compare);
		}
		public QListBoxItem FindItem(string text) {
			return ProxyQListBox().FindItem(text);
		}
		public void TriggerUpdate(bool doLayout) {
			ProxyQListBox().TriggerUpdate(doLayout);
		}
		public bool ItemVisible(int index) {
			return ProxyQListBox().ItemVisible(index);
		}
		public bool ItemVisible(QListBoxItem arg1) {
			return ProxyQListBox().ItemVisible(arg1);
		}
		public virtual void SetColumnMode(int arg1) {
			ProxyQListBox().SetColumnMode(arg1);
		}
		public virtual void SetRowMode(int arg1) {
			ProxyQListBox().SetRowMode(arg1);
		}
		public int ColumnMode() {
			return ProxyQListBox().ColumnMode();
		}
		public int RowMode() {
			return ProxyQListBox().RowMode();
		}
		public int NumColumns() {
			return ProxyQListBox().NumColumns();
		}
		public int NumRows() {
			return ProxyQListBox().NumRows();
		}
		public bool VariableWidth() {
			return ProxyQListBox().VariableWidth();
		}
		public virtual void SetVariableWidth(bool arg1) {
			ProxyQListBox().SetVariableWidth(arg1);
		}
		public bool VariableHeight() {
			return ProxyQListBox().VariableHeight();
		}
		public virtual void SetVariableHeight(bool arg1) {
			ProxyQListBox().SetVariableHeight(arg1);
		}
		public new void ViewportPaintEvent(QPaintEvent arg1) {
			ProxyQListBox().ViewportPaintEvent(arg1);
		}
		public bool DragSelect() {
			return ProxyQListBox().DragSelect();
		}
		public void SetDragSelect(bool arg1) {
			ProxyQListBox().SetDragSelect(arg1);
		}
		public bool AutoScroll() {
			return ProxyQListBox().AutoScroll();
		}
		public void SetAutoScroll(bool arg1) {
			ProxyQListBox().SetAutoScroll(arg1);
		}
		public bool AutoScrollBar() {
			return ProxyQListBox().AutoScrollBar();
		}
		public void SetAutoScrollBar(bool enable) {
			ProxyQListBox().SetAutoScrollBar(enable);
		}
		public bool ScrollBar() {
			return ProxyQListBox().ScrollBar();
		}
		public void SetScrollBar(bool enable) {
			ProxyQListBox().SetScrollBar(enable);
		}
		public bool AutoBottomScrollBar() {
			return ProxyQListBox().AutoBottomScrollBar();
		}
		public void SetAutoBottomScrollBar(bool enable) {
			ProxyQListBox().SetAutoBottomScrollBar(enable);
		}
		public bool BottomScrollBar() {
			return ProxyQListBox().BottomScrollBar();
		}
		public void SetBottomScrollBar(bool enable) {
			ProxyQListBox().SetBottomScrollBar(enable);
		}
		public bool SmoothScrolling() {
			return ProxyQListBox().SmoothScrolling();
		}
		public void SetSmoothScrolling(bool arg1) {
			ProxyQListBox().SetSmoothScrolling(arg1);
		}
		public bool AutoUpdate() {
			return ProxyQListBox().AutoUpdate();
		}
		public void SetAutoUpdate(bool arg1) {
			ProxyQListBox().SetAutoUpdate(arg1);
		}
		public void SetFixedVisibleLines(int lines) {
			ProxyQListBox().SetFixedVisibleLines(lines);
		}
		public int InSort(QListBoxItem arg1) {
			return ProxyQListBox().InSort(arg1);
		}
		public int InSort(string text) {
			return ProxyQListBox().InSort(text);
		}
		public int CellHeight(int i) {
			return ProxyQListBox().CellHeight(i);
		}
		public int CellHeight() {
			return ProxyQListBox().CellHeight();
		}
		public int CellWidth() {
			return ProxyQListBox().CellWidth();
		}
		public int CellWidth(int i) {
			return ProxyQListBox().CellWidth(i);
		}
		public int NumCols() {
			return ProxyQListBox().NumCols();
		}
		public int ItemHeight(int index) {
			return ProxyQListBox().ItemHeight(index);
		}
		public int ItemHeight() {
			return ProxyQListBox().ItemHeight();
		}
		public QListBoxItem ItemAt(QPoint arg1) {
			return ProxyQListBox().ItemAt(arg1);
		}
		public QRect ItemRect(QListBoxItem item) {
			return ProxyQListBox().ItemRect(item);
		}
		public QListBoxItem FirstItem() {
			return ProxyQListBox().FirstItem();
		}
		public void Sort(bool ascending) {
			ProxyQListBox().Sort(ascending);
		}
		public void Sort() {
			ProxyQListBox().Sort();
		}
		public void Clear() {
			ProxyQListBox().Clear();
		}
		public virtual void EnsureCurrentVisible() {
			ProxyQListBox().EnsureCurrentVisible();
		}
		public virtual void ClearSelection() {
			ProxyQListBox().ClearSelection();
		}
		public virtual void SelectAll(bool select) {
			ProxyQListBox().SelectAll(select);
		}
		public virtual void InvertSelection() {
			ProxyQListBox().InvertSelection();
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQListBox().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQListBox().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQListBox().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQListBox().TrUtf8(arg1);
		}
		protected new void MousePressEvent(QMouseEvent arg1) {
			ProxyQListBox().MousePressEvent(arg1);
		}
		protected new void MouseReleaseEvent(QMouseEvent arg1) {
			ProxyQListBox().MouseReleaseEvent(arg1);
		}
		protected new void MouseDoubleClickEvent(QMouseEvent arg1) {
			ProxyQListBox().MouseDoubleClickEvent(arg1);
		}
		protected new void MouseMoveEvent(QMouseEvent arg1) {
			ProxyQListBox().MouseMoveEvent(arg1);
		}
		protected new void ContentsContextMenuEvent(QContextMenuEvent arg1) {
			ProxyQListBox().ContentsContextMenuEvent(arg1);
		}
		protected new void KeyPressEvent(QKeyEvent e) {
			ProxyQListBox().KeyPressEvent(e);
		}
		protected new void FocusInEvent(QFocusEvent e) {
			ProxyQListBox().FocusInEvent(e);
		}
		protected new void FocusOutEvent(QFocusEvent e) {
			ProxyQListBox().FocusOutEvent(e);
		}
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQListBox().ResizeEvent(arg1);
		}
		public new void ShowEvent(QShowEvent arg1) {
			ProxyQListBox().ShowEvent(arg1);
		}
		public new bool EventFilter(QObject o, QEvent e) {
			return ProxyQListBox().EventFilter(o,e);
		}
		protected void UpdateItem(int index) {
			ProxyQListBox().UpdateItem(index);
		}
		protected void UpdateItem(QListBoxItem arg1) {
			ProxyQListBox().UpdateItem(arg1);
		}
		protected void UpdateCellWidth() {
			ProxyQListBox().UpdateCellWidth();
		}
		protected int TotalWidth() {
			return ProxyQListBox().TotalWidth();
		}
		protected int TotalHeight() {
			return ProxyQListBox().TotalHeight();
		}
		public virtual void PaintCell(QPainter arg1, int row, int col) {
			ProxyQListBox().PaintCell(arg1,row,col);
		}
		protected void ToggleCurrentItem() {
			ProxyQListBox().ToggleCurrentItem();
		}
		protected bool IsRubberSelecting() {
			return ProxyQListBox().IsRubberSelecting();
		}
		protected void DoLayout() {
			ProxyQListBox().DoLayout();
		}
		protected new void WindowActivationChange(bool arg1) {
			ProxyQListBox().WindowActivationChange(arg1);
		}
		protected bool ItemYPos(int index, out int yPos) {
			return ProxyQListBox().ItemYPos(index,out yPos);
		}
		protected int FindItem(int yPos) {
			return ProxyQListBox().FindItem(yPos);
		}
		protected void ClearInputString() {
			ProxyQListBox().ClearInputString();
		}
		~QListBox() {
			ProxyQListBox().Dispose();
		}
		public new void Dispose() {
			ProxyQListBox().Dispose();
		}
	}

	public interface IQListBoxSignals {
		void Highlighted(int index);
		void Selected(int index);
		void Highlighted(string arg1);
		void Selected(string arg1);
		void Highlighted(QListBoxItem arg1);
		void Selected(QListBoxItem arg1);
		void SelectionChanged();
		void SelectionChanged(QListBoxItem arg1);
		void CurrentChanged(QListBoxItem arg1);
		void Clicked(QListBoxItem arg1);
		void Clicked(QListBoxItem arg1, QPoint arg2);
		void Pressed(QListBoxItem arg1);
		void Pressed(QListBoxItem arg1, QPoint arg2);
		void DoubleClicked(QListBoxItem arg1);
		void ReturnPressed(QListBoxItem arg1);
		void RightButtonClicked(QListBoxItem arg1, QPoint arg2);
		void RightButtonPressed(QListBoxItem arg1, QPoint arg2);
		void MouseButtonPressed(int arg1, QListBoxItem arg2, QPoint arg3);
		void MouseButtonClicked(int arg1, QListBoxItem arg2, QPoint arg3);
		void ContextMenuRequested(QListBoxItem arg1, QPoint arg2);
		void OnItem(QListBoxItem item);
		void OnViewport();
	}
}
