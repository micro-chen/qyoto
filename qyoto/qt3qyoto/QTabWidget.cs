//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQTabWidgetSignals"></see> for signals emitted by QTabWidget
	public class QTabWidget : QWidget, IDisposable {
 		protected QTabWidget(Type dummy) : base((Type) null) {}
		interface IQTabWidgetProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQTabWidgetProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTabWidget), this);
			_interceptor = (QTabWidget) realProxy.GetTransparentProxy();
		}
		private QTabWidget ProxyQTabWidget() {
			return (QTabWidget) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTabWidget() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTabWidgetProxy), null);
			_staticInterceptor = (IQTabWidgetProxy) realProxy.GetTransparentProxy();
		}
		private static IQTabWidgetProxy StaticQTabWidget() {
			return (IQTabWidgetProxy) _staticInterceptor;
		}

		enum E_TabPosition {
			Top = 0,
			Bottom = 1,
		}
		enum E_TabShape {
			Rounded = 0,
			Triangular = 1,
		}
		public new virtual QMetaObject MetaObject() {
			return ProxyQTabWidget().MetaObject();
		}
		public new virtual string ClassName() {
			return ProxyQTabWidget().ClassName();
		}
		public QTabWidget(QWidget parent, string name, int f) : this((Type) null) {
			CreateQTabWidgetProxy();
			NewQTabWidget(parent,name,f);
		}
		private void NewQTabWidget(QWidget parent, string name, int f) {
			ProxyQTabWidget().NewQTabWidget(parent,name,f);
		}
		public QTabWidget(QWidget parent, string name) : this((Type) null) {
			CreateQTabWidgetProxy();
			NewQTabWidget(parent,name);
		}
		private void NewQTabWidget(QWidget parent, string name) {
			ProxyQTabWidget().NewQTabWidget(parent,name);
		}
		public QTabWidget(QWidget parent) : this((Type) null) {
			CreateQTabWidgetProxy();
			NewQTabWidget(parent);
		}
		private void NewQTabWidget(QWidget parent) {
			ProxyQTabWidget().NewQTabWidget(parent);
		}
		public QTabWidget() : this((Type) null) {
			CreateQTabWidgetProxy();
			NewQTabWidget();
		}
		private void NewQTabWidget() {
			ProxyQTabWidget().NewQTabWidget();
		}
		public virtual void AddTab(QWidget arg1, string arg2) {
			ProxyQTabWidget().AddTab(arg1,arg2);
		}
		public virtual void AddTab(QWidget child, QIconSet iconset, string label) {
			ProxyQTabWidget().AddTab(child,iconset,label);
		}
		public virtual void AddTab(QWidget arg1, QTab arg2) {
			ProxyQTabWidget().AddTab(arg1,arg2);
		}
		public virtual void InsertTab(QWidget arg1, string arg2, int index) {
			ProxyQTabWidget().InsertTab(arg1,arg2,index);
		}
		public virtual void InsertTab(QWidget arg1, string arg2) {
			ProxyQTabWidget().InsertTab(arg1,arg2);
		}
		public virtual void InsertTab(QWidget child, QIconSet iconset, string label, int index) {
			ProxyQTabWidget().InsertTab(child,iconset,label,index);
		}
		public virtual void InsertTab(QWidget child, QIconSet iconset, string label) {
			ProxyQTabWidget().InsertTab(child,iconset,label);
		}
		public virtual void InsertTab(QWidget arg1, QTab arg2, int index) {
			ProxyQTabWidget().InsertTab(arg1,arg2,index);
		}
		public virtual void InsertTab(QWidget arg1, QTab arg2) {
			ProxyQTabWidget().InsertTab(arg1,arg2);
		}
		public void ChangeTab(QWidget arg1, string arg2) {
			ProxyQTabWidget().ChangeTab(arg1,arg2);
		}
		public void ChangeTab(QWidget child, QIconSet iconset, string label) {
			ProxyQTabWidget().ChangeTab(child,iconset,label);
		}
		public bool IsTabEnabled(QWidget arg1) {
			return ProxyQTabWidget().IsTabEnabled(arg1);
		}
		public void SetTabEnabled(QWidget arg1, bool arg2) {
			ProxyQTabWidget().SetTabEnabled(arg1,arg2);
		}
		public void SetCornerWidget(QWidget w, int corner) {
			ProxyQTabWidget().SetCornerWidget(w,corner);
		}
		public void SetCornerWidget(QWidget w) {
			ProxyQTabWidget().SetCornerWidget(w);
		}
		public QWidget CornerWidget(int corner) {
			return ProxyQTabWidget().CornerWidget(corner);
		}
		public QWidget CornerWidget() {
			return ProxyQTabWidget().CornerWidget();
		}
		public string TabLabel(QWidget arg1) {
			return ProxyQTabWidget().TabLabel(arg1);
		}
		public void SetTabLabel(QWidget p, string l) {
			ProxyQTabWidget().SetTabLabel(p,l);
		}
		public QIconSet TabIconSet(QWidget w) {
			return ProxyQTabWidget().TabIconSet(w);
		}
		public void SetTabIconSet(QWidget w, QIconSet iconset) {
			ProxyQTabWidget().SetTabIconSet(w,iconset);
		}
		public void RemoveTabToolTip(QWidget w) {
			ProxyQTabWidget().RemoveTabToolTip(w);
		}
		public void SetTabToolTip(QWidget w, string tip) {
			ProxyQTabWidget().SetTabToolTip(w,tip);
		}
		public string TabToolTip(QWidget w) {
			return ProxyQTabWidget().TabToolTip(w);
		}
		public QWidget CurrentPage() {
			return ProxyQTabWidget().CurrentPage();
		}
		public QWidget Page(int arg1) {
			return ProxyQTabWidget().Page(arg1);
		}
		public string Label(int arg1) {
			return ProxyQTabWidget().Label(arg1);
		}
		public int CurrentPageIndex() {
			return ProxyQTabWidget().CurrentPageIndex();
		}
		public int IndexOf(QWidget arg1) {
			return ProxyQTabWidget().IndexOf(arg1);
		}
		public new QSize SizeHint() {
			return ProxyQTabWidget().SizeHint();
		}
		public new QSize MinimumSizeHint() {
			return ProxyQTabWidget().MinimumSizeHint();
		}
		public int TabPosition() {
			return ProxyQTabWidget().TabPosition();
		}
		public void SetTabPosition(int arg1) {
			ProxyQTabWidget().SetTabPosition(arg1);
		}
		public int TabShape() {
			return ProxyQTabWidget().TabShape();
		}
		public void SetTabShape(int s) {
			ProxyQTabWidget().SetTabShape(s);
		}
		public int Margin() {
			return ProxyQTabWidget().Margin();
		}
		public void SetMargin(int arg1) {
			ProxyQTabWidget().SetMargin(arg1);
		}
		public int Count() {
			return ProxyQTabWidget().Count();
		}
		public void SetCurrentPage(int arg1) {
			ProxyQTabWidget().SetCurrentPage(arg1);
		}
		public virtual void ShowPage(QWidget arg1) {
			ProxyQTabWidget().ShowPage(arg1);
		}
		public virtual void RemovePage(QWidget arg1) {
			ProxyQTabWidget().RemovePage(arg1);
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQTabWidget().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQTabWidget().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQTabWidget().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQTabWidget().TrUtf8(arg1);
		}
		public new void ShowEvent(QShowEvent arg1) {
			ProxyQTabWidget().ShowEvent(arg1);
		}
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQTabWidget().ResizeEvent(arg1);
		}
		protected void SetTabBar(QTabBar arg1) {
			ProxyQTabWidget().SetTabBar(arg1);
		}
		protected QTabBar TabBar() {
			return ProxyQTabWidget().TabBar();
		}
		public new void StyleChange(QStyle arg1) {
			ProxyQTabWidget().StyleChange(arg1);
		}
		protected new void UpdateMask() {
			ProxyQTabWidget().UpdateMask();
		}
		public new bool EventFilter(QObject arg1, QEvent arg2) {
			return ProxyQTabWidget().EventFilter(arg1,arg2);
		}
		~QTabWidget() {
			ProxyQTabWidget().Dispose();
		}
		public new void Dispose() {
			ProxyQTabWidget().Dispose();
		}
	}

	public interface IQTabWidgetSignals {
		void CurrentChanged(QWidget arg1);
		void Selected(string arg1);
	}
}
