//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQToolBoxSignals"></see> for signals emitted by QToolBox
	public class QToolBox : QFrame, IDisposable {
 		protected QToolBox(Type dummy) : base((Type) null) {}
		interface IQToolBoxProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQToolBoxProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QToolBox), this);
			_interceptor = (QToolBox) realProxy.GetTransparentProxy();
		}
		private QToolBox ProxyQToolBox() {
			return (QToolBox) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QToolBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQToolBoxProxy), null);
			_staticInterceptor = (IQToolBoxProxy) realProxy.GetTransparentProxy();
		}
		private static IQToolBoxProxy StaticQToolBox() {
			return (IQToolBoxProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQToolBox().MetaObject();
		}
		public new virtual string ClassName() {
			return ProxyQToolBox().ClassName();
		}
		public QToolBox(QWidget parent, string name, int f) : this((Type) null) {
			CreateQToolBoxProxy();
			NewQToolBox(parent,name,f);
		}
		private void NewQToolBox(QWidget parent, string name, int f) {
			ProxyQToolBox().NewQToolBox(parent,name,f);
		}
		public QToolBox(QWidget parent, string name) : this((Type) null) {
			CreateQToolBoxProxy();
			NewQToolBox(parent,name);
		}
		private void NewQToolBox(QWidget parent, string name) {
			ProxyQToolBox().NewQToolBox(parent,name);
		}
		public QToolBox(QWidget parent) : this((Type) null) {
			CreateQToolBoxProxy();
			NewQToolBox(parent);
		}
		private void NewQToolBox(QWidget parent) {
			ProxyQToolBox().NewQToolBox(parent);
		}
		public QToolBox() : this((Type) null) {
			CreateQToolBoxProxy();
			NewQToolBox();
		}
		private void NewQToolBox() {
			ProxyQToolBox().NewQToolBox();
		}
		public int AddItem(QWidget item, string label) {
			return ProxyQToolBox().AddItem(item,label);
		}
		public int AddItem(QWidget item, QIconSet iconSet, string label) {
			return ProxyQToolBox().AddItem(item,iconSet,label);
		}
		public int InsertItem(int index, QWidget item, string label) {
			return ProxyQToolBox().InsertItem(index,item,label);
		}
		public int InsertItem(int index, QWidget item, QIconSet iconSet, string label) {
			return ProxyQToolBox().InsertItem(index,item,iconSet,label);
		}
		public int RemoveItem(QWidget item) {
			return ProxyQToolBox().RemoveItem(item);
		}
		public void SetItemEnabled(int index, bool enabled) {
			ProxyQToolBox().SetItemEnabled(index,enabled);
		}
		public bool IsItemEnabled(int index) {
			return ProxyQToolBox().IsItemEnabled(index);
		}
		public void SetItemLabel(int index, string label) {
			ProxyQToolBox().SetItemLabel(index,label);
		}
		public string ItemLabel(int index) {
			return ProxyQToolBox().ItemLabel(index);
		}
		public void SetItemIconSet(int index, QIconSet iconSet) {
			ProxyQToolBox().SetItemIconSet(index,iconSet);
		}
		public QIconSet ItemIconSet(int index) {
			return ProxyQToolBox().ItemIconSet(index);
		}
		public void SetItemToolTip(int index, string toolTip) {
			ProxyQToolBox().SetItemToolTip(index,toolTip);
		}
		public string ItemToolTip(int index) {
			return ProxyQToolBox().ItemToolTip(index);
		}
		public QWidget CurrentItem() {
			return ProxyQToolBox().CurrentItem();
		}
		public void SetCurrentItem(QWidget item) {
			ProxyQToolBox().SetCurrentItem(item);
		}
		public int CurrentIndex() {
			return ProxyQToolBox().CurrentIndex();
		}
		public QWidget Item(int index) {
			return ProxyQToolBox().Item(index);
		}
		public int IndexOf(QWidget item) {
			return ProxyQToolBox().IndexOf(item);
		}
		public int Count() {
			return ProxyQToolBox().Count();
		}
		public void SetCurrentIndex(int index) {
			ProxyQToolBox().SetCurrentIndex(index);
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQToolBox().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQToolBox().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQToolBox().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQToolBox().TrUtf8(arg1);
		}
		protected virtual void ItemInserted(int index) {
			ProxyQToolBox().ItemInserted(index);
		}
		protected virtual void ItemRemoved(int index) {
			ProxyQToolBox().ItemRemoved(index);
		}
		public new void ShowEvent(QShowEvent e) {
			ProxyQToolBox().ShowEvent(e);
		}
		protected new void FrameChanged() {
			ProxyQToolBox().FrameChanged();
		}
		public new void StyleChange(QStyle arg1) {
			ProxyQToolBox().StyleChange(arg1);
		}
		~QToolBox() {
			ProxyQToolBox().Dispose();
		}
		public new void Dispose() {
			ProxyQToolBox().Dispose();
		}
	}

	public interface IQToolBoxSignals {
		void CurrentChanged(int index);
	}
}
