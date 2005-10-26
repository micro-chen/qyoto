//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QStandardItemModel : QAbstractItemModel, IDisposable {
 		protected QStandardItemModel(Type dummy) : base((Type) null) {}
		interface IQStandardItemModelProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected void CreateQStandardItemModelProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStandardItemModel), this);
			_interceptor = (QStandardItemModel) realProxy.GetTransparentProxy();
		}
		private QStandardItemModel ProxyQStandardItemModel() {
			return (QStandardItemModel) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStandardItemModel() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStandardItemModelProxy), null);
			_staticInterceptor = (IQStandardItemModelProxy) realProxy.GetTransparentProxy();
		}
		private static IQStandardItemModelProxy StaticQStandardItemModel() {
			return (IQStandardItemModelProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQStandardItemModel().MetaObject();
		}
		// void* qt_metacast(const char* arg1); >>>> NOT CONVERTED
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QStandardItemModel(QObject parent) : this((Type) null) {
			CreateQStandardItemModelProxy();
			NewQStandardItemModel(parent);
		}
		private void NewQStandardItemModel(QObject parent) {
			ProxyQStandardItemModel().NewQStandardItemModel(parent);
		}
		public QStandardItemModel() : this((Type) null) {
			CreateQStandardItemModelProxy();
			NewQStandardItemModel();
		}
		private void NewQStandardItemModel() {
			ProxyQStandardItemModel().NewQStandardItemModel();
		}
		public QStandardItemModel(int rows, int columns, QObject parent) : this((Type) null) {
			CreateQStandardItemModelProxy();
			NewQStandardItemModel(rows,columns,parent);
		}
		private void NewQStandardItemModel(int rows, int columns, QObject parent) {
			ProxyQStandardItemModel().NewQStandardItemModel(rows,columns,parent);
		}
		public QStandardItemModel(int rows, int columns) : this((Type) null) {
			CreateQStandardItemModelProxy();
			NewQStandardItemModel(rows,columns);
		}
		private void NewQStandardItemModel(int rows, int columns) {
			ProxyQStandardItemModel().NewQStandardItemModel(rows,columns);
		}
		public new QModelIndex Index(int row, int column, QModelIndex parent) {
			return ProxyQStandardItemModel().Index(row,column,parent);
		}
		public new QModelIndex Index(int row, int column) {
			return ProxyQStandardItemModel().Index(row,column);
		}
		public new QModelIndex Parent(QModelIndex child) {
			return ProxyQStandardItemModel().Parent(child);
		}
		public new int RowCount(QModelIndex parent) {
			return ProxyQStandardItemModel().RowCount(parent);
		}
		public new int RowCount() {
			return ProxyQStandardItemModel().RowCount();
		}
		public new int ColumnCount(QModelIndex parent) {
			return ProxyQStandardItemModel().ColumnCount(parent);
		}
		public new int ColumnCount() {
			return ProxyQStandardItemModel().ColumnCount();
		}
		public new bool HasChildren(QModelIndex parent) {
			return ProxyQStandardItemModel().HasChildren(parent);
		}
		public new bool HasChildren() {
			return ProxyQStandardItemModel().HasChildren();
		}
		public new QVariant Data(QModelIndex index, int role) {
			return ProxyQStandardItemModel().Data(index,role);
		}
		public new QVariant Data(QModelIndex index) {
			return ProxyQStandardItemModel().Data(index);
		}
		public new bool SetData(QModelIndex index, QVariant value, int role) {
			return ProxyQStandardItemModel().SetData(index,value,role);
		}
		public new bool SetData(QModelIndex index, QVariant value) {
			return ProxyQStandardItemModel().SetData(index,value);
		}
		public new QVariant HeaderData(int section, int orientation, int role) {
			return ProxyQStandardItemModel().HeaderData(section,orientation,role);
		}
		public new QVariant HeaderData(int section, int orientation) {
			return ProxyQStandardItemModel().HeaderData(section,orientation);
		}
		public new bool SetHeaderData(int section, int orientation, QVariant value, int role) {
			return ProxyQStandardItemModel().SetHeaderData(section,orientation,value,role);
		}
		public new bool SetHeaderData(int section, int orientation, QVariant value) {
			return ProxyQStandardItemModel().SetHeaderData(section,orientation,value);
		}
		public new bool InsertRows(int row, int count, QModelIndex parent) {
			return ProxyQStandardItemModel().InsertRows(row,count,parent);
		}
		public new bool InsertRows(int row, int count) {
			return ProxyQStandardItemModel().InsertRows(row,count);
		}
		public new bool InsertColumns(int column, int count, QModelIndex parent) {
			return ProxyQStandardItemModel().InsertColumns(column,count,parent);
		}
		public new bool InsertColumns(int column, int count) {
			return ProxyQStandardItemModel().InsertColumns(column,count);
		}
		public new bool RemoveRows(int row, int count, QModelIndex parent) {
			return ProxyQStandardItemModel().RemoveRows(row,count,parent);
		}
		public new bool RemoveRows(int row, int count) {
			return ProxyQStandardItemModel().RemoveRows(row,count);
		}
		public new bool RemoveColumns(int column, int count, QModelIndex parent) {
			return ProxyQStandardItemModel().RemoveColumns(column,count,parent);
		}
		public new bool RemoveColumns(int column, int count) {
			return ProxyQStandardItemModel().RemoveColumns(column,count);
		}
		public new int Flags(QModelIndex index) {
			return ProxyQStandardItemModel().Flags(index);
		}
		public void Clear() {
			ProxyQStandardItemModel().Clear();
		}
		public static new string Tr(string s, string c) {
			return StaticQStandardItemModel().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQStandardItemModel().Tr(s);
		}
		~QStandardItemModel() {
			ProxyQStandardItemModel().Dispose();
		}
		public new void Dispose() {
			ProxyQStandardItemModel().Dispose();
		}
	}
}
