//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QStandardItem")]
    public class QStandardItem : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QStandardItem(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QStandardItem), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QStandardItem() {
            staticInterceptor = new SmokeInvocation(typeof(QStandardItem), null);
        }
        public enum ItemType {
            Type = 0,
            UserType = 1000,
        }
        // QStandardItem* QStandardItem(QStandardItemPrivate& arg1); >>>> NOT CONVERTED
        public QStandardItem() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStandardItem", "QStandardItem()", typeof(void));
        }
        public QStandardItem(string text) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStandardItem$", "QStandardItem(const QString&)", typeof(void), typeof(string), text);
        }
        public QStandardItem(QIcon icon, string text) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStandardItem#$", "QStandardItem(const QIcon&, const QString&)", typeof(void), typeof(QIcon), icon, typeof(string), text);
        }
        public QStandardItem(int rows, int columns) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStandardItem$$", "QStandardItem(int, int)", typeof(void), typeof(int), rows, typeof(int), columns);
        }
        public QStandardItem(int rows) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStandardItem$", "QStandardItem(int)", typeof(void), typeof(int), rows);
        }
        [SmokeMethod("data(int) const")]
        public virtual QVariant Data(int role) {
            return (QVariant) interceptor.Invoke("data$", "data(int) const", typeof(QVariant), typeof(int), role);
        }
        [SmokeMethod("data() const")]
        public virtual QVariant Data() {
            return (QVariant) interceptor.Invoke("data", "data() const", typeof(QVariant));
        }
        [SmokeMethod("setData(const QVariant&, int)")]
        public virtual void SetData(QVariant value, int role) {
            interceptor.Invoke("setData#$", "setData(const QVariant&, int)", typeof(void), typeof(QVariant), value, typeof(int), role);
        }
        [SmokeMethod("setData(const QVariant&)")]
        public virtual void SetData(QVariant value) {
            interceptor.Invoke("setData#", "setData(const QVariant&)", typeof(void), typeof(QVariant), value);
        }
        public string Text() {
            return (string) interceptor.Invoke("text", "text() const", typeof(string));
        }
        public void SetText(string text) {
            interceptor.Invoke("setText$", "setText(const QString&)", typeof(void), typeof(string), text);
        }
        public QIcon Icon() {
            return (QIcon) interceptor.Invoke("icon", "icon() const", typeof(QIcon));
        }
        public void SetIcon(QIcon icon) {
            interceptor.Invoke("setIcon#", "setIcon(const QIcon&)", typeof(void), typeof(QIcon), icon);
        }
        public string ToolTip() {
            return (string) interceptor.Invoke("toolTip", "toolTip() const", typeof(string));
        }
        public void SetToolTip(string toolTip) {
            interceptor.Invoke("setToolTip$", "setToolTip(const QString&)", typeof(void), typeof(string), toolTip);
        }
        public string StatusTip() {
            return (string) interceptor.Invoke("statusTip", "statusTip() const", typeof(string));
        }
        public void SetStatusTip(string statusTip) {
            interceptor.Invoke("setStatusTip$", "setStatusTip(const QString&)", typeof(void), typeof(string), statusTip);
        }
        public string WhatsThis() {
            return (string) interceptor.Invoke("whatsThis", "whatsThis() const", typeof(string));
        }
        public void SetWhatsThis(string whatsThis) {
            interceptor.Invoke("setWhatsThis$", "setWhatsThis(const QString&)", typeof(void), typeof(string), whatsThis);
        }
        public QSize SizeHint() {
            return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
        }
        public void SetSizeHint(QSize sizeHint) {
            interceptor.Invoke("setSizeHint#", "setSizeHint(const QSize&)", typeof(void), typeof(QSize), sizeHint);
        }
        public QFont Font() {
            return (QFont) interceptor.Invoke("font", "font() const", typeof(QFont));
        }
        public void SetFont(QFont font) {
            interceptor.Invoke("setFont#", "setFont(const QFont&)", typeof(void), typeof(QFont), font);
        }
        public uint TextAlignment() {
            return (uint) interceptor.Invoke("textAlignment", "textAlignment() const", typeof(uint));
        }
        public void SetTextAlignment(uint textAlignment) {
            interceptor.Invoke("setTextAlignment$", "setTextAlignment(Qt::Alignment)", typeof(void), typeof(uint), textAlignment);
        }
        public QBrush Background() {
            return (QBrush) interceptor.Invoke("background", "background() const", typeof(QBrush));
        }
        public void SetBackground(QBrush brush) {
            interceptor.Invoke("setBackground#", "setBackground(const QBrush&)", typeof(void), typeof(QBrush), brush);
        }
        public QBrush Foreground() {
            return (QBrush) interceptor.Invoke("foreground", "foreground() const", typeof(QBrush));
        }
        public void SetForeground(QBrush brush) {
            interceptor.Invoke("setForeground#", "setForeground(const QBrush&)", typeof(void), typeof(QBrush), brush);
        }
        public Qt.CheckState CheckState() {
            return (Qt.CheckState) interceptor.Invoke("checkState", "checkState() const", typeof(Qt.CheckState));
        }
        public void SetCheckState(Qt.CheckState checkState) {
            interceptor.Invoke("setCheckState$", "setCheckState(Qt::CheckState)", typeof(void), typeof(Qt.CheckState), checkState);
        }
        public string AccessibleText() {
            return (string) interceptor.Invoke("accessibleText", "accessibleText() const", typeof(string));
        }
        public void SetAccessibleText(string accessibleText) {
            interceptor.Invoke("setAccessibleText$", "setAccessibleText(const QString&)", typeof(void), typeof(string), accessibleText);
        }
        public string AccessibleDescription() {
            return (string) interceptor.Invoke("accessibleDescription", "accessibleDescription() const", typeof(string));
        }
        public void SetAccessibleDescription(string accessibleDescription) {
            interceptor.Invoke("setAccessibleDescription$", "setAccessibleDescription(const QString&)", typeof(void), typeof(string), accessibleDescription);
        }
        public uint Flags() {
            return (uint) interceptor.Invoke("flags", "flags() const", typeof(uint));
        }
        public void SetFlags(uint flags) {
            interceptor.Invoke("setFlags$", "setFlags(Qt::ItemFlags)", typeof(void), typeof(uint), flags);
        }
        public bool IsEnabled() {
            return (bool) interceptor.Invoke("isEnabled", "isEnabled() const", typeof(bool));
        }
        public void SetEnabled(bool enabled) {
            interceptor.Invoke("setEnabled$", "setEnabled(bool)", typeof(void), typeof(bool), enabled);
        }
        public bool IsEditable() {
            return (bool) interceptor.Invoke("isEditable", "isEditable() const", typeof(bool));
        }
        public void SetEditable(bool editable) {
            interceptor.Invoke("setEditable$", "setEditable(bool)", typeof(void), typeof(bool), editable);
        }
        public bool IsSelectable() {
            return (bool) interceptor.Invoke("isSelectable", "isSelectable() const", typeof(bool));
        }
        public void SetSelectable(bool selectable) {
            interceptor.Invoke("setSelectable$", "setSelectable(bool)", typeof(void), typeof(bool), selectable);
        }
        public bool IsCheckable() {
            return (bool) interceptor.Invoke("isCheckable", "isCheckable() const", typeof(bool));
        }
        public void SetCheckable(bool checkable) {
            interceptor.Invoke("setCheckable$", "setCheckable(bool)", typeof(void), typeof(bool), checkable);
        }
        public bool IsTristate() {
            return (bool) interceptor.Invoke("isTristate", "isTristate() const", typeof(bool));
        }
        public void SetTristate(bool tristate) {
            interceptor.Invoke("setTristate$", "setTristate(bool)", typeof(void), typeof(bool), tristate);
        }
        public bool IsDragEnabled() {
            return (bool) interceptor.Invoke("isDragEnabled", "isDragEnabled() const", typeof(bool));
        }
        public void SetDragEnabled(bool dragEnabled) {
            interceptor.Invoke("setDragEnabled$", "setDragEnabled(bool)", typeof(void), typeof(bool), dragEnabled);
        }
        public bool IsDropEnabled() {
            return (bool) interceptor.Invoke("isDropEnabled", "isDropEnabled() const", typeof(bool));
        }
        public void SetDropEnabled(bool dropEnabled) {
            interceptor.Invoke("setDropEnabled$", "setDropEnabled(bool)", typeof(void), typeof(bool), dropEnabled);
        }
        public QStandardItem Parent() {
            return (QStandardItem) interceptor.Invoke("parent", "parent() const", typeof(QStandardItem));
        }
        public int Row() {
            return (int) interceptor.Invoke("row", "row() const", typeof(int));
        }
        public int Column() {
            return (int) interceptor.Invoke("column", "column() const", typeof(int));
        }
        public QModelIndex Index() {
            return (QModelIndex) interceptor.Invoke("index", "index() const", typeof(QModelIndex));
        }
        public QStandardItemModel Model() {
            return (QStandardItemModel) interceptor.Invoke("model", "model() const", typeof(QStandardItemModel));
        }
        public int RowCount() {
            return (int) interceptor.Invoke("rowCount", "rowCount() const", typeof(int));
        }
        public void SetRowCount(int rows) {
            interceptor.Invoke("setRowCount$", "setRowCount(int)", typeof(void), typeof(int), rows);
        }
        public int ColumnCount() {
            return (int) interceptor.Invoke("columnCount", "columnCount() const", typeof(int));
        }
        public void SetColumnCount(int columns) {
            interceptor.Invoke("setColumnCount$", "setColumnCount(int)", typeof(void), typeof(int), columns);
        }
        public bool HasChildren() {
            return (bool) interceptor.Invoke("hasChildren", "hasChildren() const", typeof(bool));
        }
        public QStandardItem Child(int row, int column) {
            return (QStandardItem) interceptor.Invoke("child$$", "child(int, int) const", typeof(QStandardItem), typeof(int), row, typeof(int), column);
        }
        public QStandardItem Child(int row) {
            return (QStandardItem) interceptor.Invoke("child$", "child(int) const", typeof(QStandardItem), typeof(int), row);
        }
        public void SetChild(int row, int column, QStandardItem item) {
            interceptor.Invoke("setChild$$#", "setChild(int, int, QStandardItem*)", typeof(void), typeof(int), row, typeof(int), column, typeof(QStandardItem), item);
        }
        public void SetChild(int row, QStandardItem item) {
            interceptor.Invoke("setChild$#", "setChild(int, QStandardItem*)", typeof(void), typeof(int), row, typeof(QStandardItem), item);
        }
        public void InsertRow(int row, List<QStandardItem> items) {
            interceptor.Invoke("insertRow$?", "insertRow(int, const QList<QStandardItem*>&)", typeof(void), typeof(int), row, typeof(List<QStandardItem>), items);
        }
        public void InsertColumn(int column, List<QStandardItem> items) {
            interceptor.Invoke("insertColumn$?", "insertColumn(int, const QList<QStandardItem*>&)", typeof(void), typeof(int), column, typeof(List<QStandardItem>), items);
        }
        public void InsertRows(int row, List<QStandardItem> items) {
            interceptor.Invoke("insertRows$?", "insertRows(int, const QList<QStandardItem*>&)", typeof(void), typeof(int), row, typeof(List<QStandardItem>), items);
        }
        public void InsertRows(int row, int count) {
            interceptor.Invoke("insertRows$$", "insertRows(int, int)", typeof(void), typeof(int), row, typeof(int), count);
        }
        public void InsertColumns(int column, int count) {
            interceptor.Invoke("insertColumns$$", "insertColumns(int, int)", typeof(void), typeof(int), column, typeof(int), count);
        }
        public void RemoveRow(int row) {
            interceptor.Invoke("removeRow$", "removeRow(int)", typeof(void), typeof(int), row);
        }
        public void RemoveColumn(int column) {
            interceptor.Invoke("removeColumn$", "removeColumn(int)", typeof(void), typeof(int), column);
        }
        public void RemoveRows(int row, int count) {
            interceptor.Invoke("removeRows$$", "removeRows(int, int)", typeof(void), typeof(int), row, typeof(int), count);
        }
        public void RemoveColumns(int column, int count) {
            interceptor.Invoke("removeColumns$$", "removeColumns(int, int)", typeof(void), typeof(int), column, typeof(int), count);
        }
        public void AppendRow(List<QStandardItem> items) {
            interceptor.Invoke("appendRow?", "appendRow(const QList<QStandardItem*>&)", typeof(void), typeof(List<QStandardItem>), items);
        }
        public void AppendRows(List<QStandardItem> items) {
            interceptor.Invoke("appendRows?", "appendRows(const QList<QStandardItem*>&)", typeof(void), typeof(List<QStandardItem>), items);
        }
        public void AppendColumn(List<QStandardItem> items) {
            interceptor.Invoke("appendColumn?", "appendColumn(const QList<QStandardItem*>&)", typeof(void), typeof(List<QStandardItem>), items);
        }
        public void InsertRow(int row, QStandardItem item) {
            interceptor.Invoke("insertRow$#", "insertRow(int, QStandardItem*)", typeof(void), typeof(int), row, typeof(QStandardItem), item);
        }
        public void AppendRow(QStandardItem item) {
            interceptor.Invoke("appendRow#", "appendRow(QStandardItem*)", typeof(void), typeof(QStandardItem), item);
        }
        public QStandardItem TakeChild(int row, int column) {
            return (QStandardItem) interceptor.Invoke("takeChild$$", "takeChild(int, int)", typeof(QStandardItem), typeof(int), row, typeof(int), column);
        }
        public QStandardItem TakeChild(int row) {
            return (QStandardItem) interceptor.Invoke("takeChild$", "takeChild(int)", typeof(QStandardItem), typeof(int), row);
        }
        public List<QStandardItem> TakeRow(int row) {
            return (List<QStandardItem>) interceptor.Invoke("takeRow$", "takeRow(int)", typeof(List<QStandardItem>), typeof(int), row);
        }
        public List<QStandardItem> TakeColumn(int column) {
            return (List<QStandardItem>) interceptor.Invoke("takeColumn$", "takeColumn(int)", typeof(List<QStandardItem>), typeof(int), column);
        }
        public void SortChildren(int column, Qt.SortOrder order) {
            interceptor.Invoke("sortChildren$$", "sortChildren(int, Qt::SortOrder)", typeof(void), typeof(int), column, typeof(Qt.SortOrder), order);
        }
        public void SortChildren(int column) {
            interceptor.Invoke("sortChildren$", "sortChildren(int)", typeof(void), typeof(int), column);
        }
        [SmokeMethod("clone() const")]
        public virtual QStandardItem Clone() {
            return (QStandardItem) interceptor.Invoke("clone", "clone() const", typeof(QStandardItem));
        }
        [SmokeMethod("type() const")]
        public virtual int type() {
            return (int) interceptor.Invoke("type", "type() const", typeof(int));
        }
        [SmokeMethod("read(QDataStream&)")]
        public virtual void Read(QDataStream arg1) {
            interceptor.Invoke("read#", "read(QDataStream&)", typeof(void), typeof(QDataStream), arg1);
        }
        [SmokeMethod("write(QDataStream&) const")]
        public virtual void Write(QDataStream arg1) {
            interceptor.Invoke("write#", "write(QDataStream&) const", typeof(void), typeof(QDataStream), arg1);
        }
        public QStandardItem(QStandardItem other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStandardItem#", "QStandardItem(const QStandardItem&)", typeof(void), typeof(QStandardItem), other);
        }
        protected void EmitDataChanged() {
            interceptor.Invoke("emitDataChanged", "emitDataChanged()", typeof(void));
        }
        ~QStandardItem() {
            interceptor.Invoke("~QStandardItem", "~QStandardItem()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QStandardItem", "~QStandardItem()", typeof(void));
        }
        public static bool operator<(QStandardItem lhs, QStandardItem other) {
            return (bool) staticInterceptor.Invoke("operator<#", "operator<(const QStandardItem&) const", typeof(bool), typeof(QStandardItem), lhs, typeof(QStandardItem), other);
        }
        public static bool operator>(QStandardItem lhs, QStandardItem other) {
            return !(bool) staticInterceptor.Invoke("operator<#", "operator<(const QStandardItem&) const", typeof(bool), typeof(QStandardItem), lhs, typeof(QStandardItem), other)
                        && !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QStandardItem&) const", typeof(bool), typeof(QStandardItem), lhs, typeof(QStandardItem), other);
        }
    }
}