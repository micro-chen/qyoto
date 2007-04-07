namespace Qyoto {

	using System;
	using System.Runtime.InteropServices;

	public class QAbstractProxyModelHelper : QAbstractProxyModel {
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern int QAbstractItemModelColumnCount(IntPtr obj, IntPtr modelIndex);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern int QAbstractItemModelRowCount(IntPtr obj, IntPtr modelIndex);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern IntPtr QAbstractItemModelParent(IntPtr obj, IntPtr modelIndex);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern IntPtr QAbstractItemModelIndex(IntPtr obj, int row, int column, IntPtr modelIndex);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern IntPtr QAbstractProxyModelMapToSource(IntPtr obj, IntPtr proxyIndex);
		
		[DllImport("libqyoto", CharSet=CharSet.Ansi)]
		static extern IntPtr QAbstractProxyModelMapFromSource(IntPtr obj, IntPtr sourceIndex);
		
		protected QAbstractProxyModelHelper(Type dummy) : base((Type) null) {}
		
		public override int ColumnCount(QModelIndex parent) {
			return QAbstractItemModelColumnCount((IntPtr) GCHandle.Alloc(this), (IntPtr) GCHandle.Alloc(parent));
		}
		
		public override int RowCount(QModelIndex parent) {
			return QAbstractItemModelRowCount((IntPtr) GCHandle.Alloc(this), (IntPtr) GCHandle.Alloc(parent));
		}
		
		public override QModelIndex Parent(QModelIndex child) {
			GCHandle ret = (GCHandle) QAbstractItemModelParent((IntPtr) GCHandle.Alloc(this), 
										(IntPtr) GCHandle.Alloc(child));
			QModelIndex ix = (QModelIndex) ret.Target;
			ret.Free();
			return ix;
		}
		
		public override QModelIndex Index(int row, int column, QModelIndex parent) {
			GCHandle ret = (GCHandle) QAbstractItemModelIndex((IntPtr) GCHandle.Alloc(this), row, column, 
								(IntPtr) GCHandle.Alloc(parent));
			QModelIndex ix = (QModelIndex) ret.Target;
			ret.Free();
			return ix;
		}
		
		public override QModelIndex MapFromSource(QModelIndex sourceIndex) {
			GCHandle ret = (GCHandle) QAbstractProxyModelMapFromSource((IntPtr) GCHandle.Alloc(this), 
											(IntPtr) GCHandle.Alloc(sourceIndex));
			QModelIndex ix = (QModelIndex) ret.Target;
			ret.Free();
			return ix;
		}
		
		public override QModelIndex MapToSource(QModelIndex proxyIndex) {
			GCHandle ret = (GCHandle) QAbstractProxyModelMapToSource((IntPtr) GCHandle.Alloc(this), 
										(IntPtr) GCHandle.Alloc(proxyIndex));
			QModelIndex ix = (QModelIndex) ret.Target;
			ret.Free();
			return ix;
		}
	}
}