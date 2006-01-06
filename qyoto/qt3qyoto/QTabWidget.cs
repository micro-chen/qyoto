//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQTabWidgetSignals"></see> for signals emitted by QTabWidget
	[SmokeClass("QTabWidget")]
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
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQTabWidget().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQTabWidget().ClassName();
		}
		public QTabWidget(QWidget parent, string name, int f) : this((Type) null) {
			CreateQTabWidgetProxy();
			CreateQTabWidgetSignalProxy();
			NewQTabWidget(parent,name,f);
		}
		[SmokeMethod("QTabWidget(QWidget*, const char*, Qt::WFlags)")]
		private void NewQTabWidget(QWidget parent, string name, int f) {
			ProxyQTabWidget().NewQTabWidget(parent,name,f);
		}
		public QTabWidget(QWidget parent, string name) : this((Type) null) {
			CreateQTabWidgetProxy();
			CreateQTabWidgetSignalProxy();
			NewQTabWidget(parent,name);
		}
		[SmokeMethod("QTabWidget(QWidget*, const char*)")]
		private void NewQTabWidget(QWidget parent, string name) {
			ProxyQTabWidget().NewQTabWidget(parent,name);
		}
		public QTabWidget(QWidget parent) : this((Type) null) {
			CreateQTabWidgetProxy();
			CreateQTabWidgetSignalProxy();
			NewQTabWidget(parent);
		}
		[SmokeMethod("QTabWidget(QWidget*)")]
		private void NewQTabWidget(QWidget parent) {
			ProxyQTabWidget().NewQTabWidget(parent);
		}
		public QTabWidget() : this((Type) null) {
			CreateQTabWidgetProxy();
			CreateQTabWidgetSignalProxy();
			NewQTabWidget();
		}
		[SmokeMethod("QTabWidget()")]
		private void NewQTabWidget() {
			ProxyQTabWidget().NewQTabWidget();
		}
		[SmokeMethod("addTab(QWidget*, const QString&)")]
		public virtual void AddTab(QWidget arg1, string arg2) {
			ProxyQTabWidget().AddTab(arg1,arg2);
		}
		[SmokeMethod("addTab(QWidget*, const QIconSet&, const QString&)")]
		public virtual void AddTab(QWidget child, QIconSet iconset, string label) {
			ProxyQTabWidget().AddTab(child,iconset,label);
		}
		[SmokeMethod("addTab(QWidget*, QTab*)")]
		public virtual void AddTab(QWidget arg1, QTab arg2) {
			ProxyQTabWidget().AddTab(arg1,arg2);
		}
		[SmokeMethod("insertTab(QWidget*, const QString&, int)")]
		public virtual void InsertTab(QWidget arg1, string arg2, int index) {
			ProxyQTabWidget().InsertTab(arg1,arg2,index);
		}
		[SmokeMethod("insertTab(QWidget*, const QString&)")]
		public virtual void InsertTab(QWidget arg1, string arg2) {
			ProxyQTabWidget().InsertTab(arg1,arg2);
		}
		[SmokeMethod("insertTab(QWidget*, const QIconSet&, const QString&, int)")]
		public virtual void InsertTab(QWidget child, QIconSet iconset, string label, int index) {
			ProxyQTabWidget().InsertTab(child,iconset,label,index);
		}
		[SmokeMethod("insertTab(QWidget*, const QIconSet&, const QString&)")]
		public virtual void InsertTab(QWidget child, QIconSet iconset, string label) {
			ProxyQTabWidget().InsertTab(child,iconset,label);
		}
		[SmokeMethod("insertTab(QWidget*, QTab*, int)")]
		public virtual void InsertTab(QWidget arg1, QTab arg2, int index) {
			ProxyQTabWidget().InsertTab(arg1,arg2,index);
		}
		[SmokeMethod("insertTab(QWidget*, QTab*)")]
		public virtual void InsertTab(QWidget arg1, QTab arg2) {
			ProxyQTabWidget().InsertTab(arg1,arg2);
		}
		[SmokeMethod("changeTab(QWidget*, const QString&)")]
		public void ChangeTab(QWidget arg1, string arg2) {
			ProxyQTabWidget().ChangeTab(arg1,arg2);
		}
		[SmokeMethod("changeTab(QWidget*, const QIconSet&, const QString&)")]
		public void ChangeTab(QWidget child, QIconSet iconset, string label) {
			ProxyQTabWidget().ChangeTab(child,iconset,label);
		}
		[SmokeMethod("isTabEnabled(QWidget*) const")]
		public bool IsTabEnabled(QWidget arg1) {
			return ProxyQTabWidget().IsTabEnabled(arg1);
		}
		[SmokeMethod("setTabEnabled(QWidget*, bool)")]
		public void SetTabEnabled(QWidget arg1, bool arg2) {
			ProxyQTabWidget().SetTabEnabled(arg1,arg2);
		}
		[SmokeMethod("setCornerWidget(QWidget*, Qt::Corner)")]
		public void SetCornerWidget(QWidget w, int corner) {
			ProxyQTabWidget().SetCornerWidget(w,corner);
		}
		[SmokeMethod("setCornerWidget(QWidget*)")]
		public void SetCornerWidget(QWidget w) {
			ProxyQTabWidget().SetCornerWidget(w);
		}
		[SmokeMethod("cornerWidget(Qt::Corner) const")]
		public QWidget CornerWidget(int corner) {
			return ProxyQTabWidget().CornerWidget(corner);
		}
		[SmokeMethod("cornerWidget() const")]
		public QWidget CornerWidget() {
			return ProxyQTabWidget().CornerWidget();
		}
		[SmokeMethod("tabLabel(QWidget*) const")]
		public string TabLabel(QWidget arg1) {
			return ProxyQTabWidget().TabLabel(arg1);
		}
		[SmokeMethod("setTabLabel(QWidget*, const QString&)")]
		public void SetTabLabel(QWidget p, string l) {
			ProxyQTabWidget().SetTabLabel(p,l);
		}
		[SmokeMethod("tabIconSet(QWidget*) const")]
		public QIconSet TabIconSet(QWidget w) {
			return ProxyQTabWidget().TabIconSet(w);
		}
		[SmokeMethod("setTabIconSet(QWidget*, const QIconSet&)")]
		public void SetTabIconSet(QWidget w, QIconSet iconset) {
			ProxyQTabWidget().SetTabIconSet(w,iconset);
		}
		[SmokeMethod("removeTabToolTip(QWidget*)")]
		public void RemoveTabToolTip(QWidget w) {
			ProxyQTabWidget().RemoveTabToolTip(w);
		}
		[SmokeMethod("setTabToolTip(QWidget*, const QString&)")]
		public void SetTabToolTip(QWidget w, string tip) {
			ProxyQTabWidget().SetTabToolTip(w,tip);
		}
		[SmokeMethod("tabToolTip(QWidget*) const")]
		public string TabToolTip(QWidget w) {
			return ProxyQTabWidget().TabToolTip(w);
		}
		[SmokeMethod("currentPage() const")]
		public QWidget CurrentPage() {
			return ProxyQTabWidget().CurrentPage();
		}
		[SmokeMethod("page(int) const")]
		public QWidget Page(int arg1) {
			return ProxyQTabWidget().Page(arg1);
		}
		[SmokeMethod("label(int) const")]
		public string Label(int arg1) {
			return ProxyQTabWidget().Label(arg1);
		}
		[SmokeMethod("currentPageIndex() const")]
		public int CurrentPageIndex() {
			return ProxyQTabWidget().CurrentPageIndex();
		}
		[SmokeMethod("indexOf(QWidget*) const")]
		public int IndexOf(QWidget arg1) {
			return ProxyQTabWidget().IndexOf(arg1);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQTabWidget().SizeHint();
		}
		[SmokeMethod("minimumSizeHint() const")]
		public new QSize MinimumSizeHint() {
			return ProxyQTabWidget().MinimumSizeHint();
		}
		[SmokeMethod("tabPosition() const")]
		public int TabPosition() {
			return ProxyQTabWidget().TabPosition();
		}
		[SmokeMethod("setTabPosition(QTabWidget::TabPosition)")]
		public void SetTabPosition(int arg1) {
			ProxyQTabWidget().SetTabPosition(arg1);
		}
		[SmokeMethod("tabShape() const")]
		public int TabShape() {
			return ProxyQTabWidget().TabShape();
		}
		[SmokeMethod("setTabShape(QTabWidget::TabShape)")]
		public void SetTabShape(int s) {
			ProxyQTabWidget().SetTabShape(s);
		}
		[SmokeMethod("margin() const")]
		public int Margin() {
			return ProxyQTabWidget().Margin();
		}
		[SmokeMethod("setMargin(int)")]
		public void SetMargin(int arg1) {
			ProxyQTabWidget().SetMargin(arg1);
		}
		[SmokeMethod("count() const")]
		public int Count() {
			return ProxyQTabWidget().Count();
		}
		[Q_SLOT("void setCurrentPage(int)")]
		[SmokeMethod("setCurrentPage(int)")]
		public void SetCurrentPage(int arg1) {
			ProxyQTabWidget().SetCurrentPage(arg1);
		}
		[Q_SLOT("void showPage(QWidget*)")]
		[SmokeMethod("showPage(QWidget*)")]
		public virtual void ShowPage(QWidget arg1) {
			ProxyQTabWidget().ShowPage(arg1);
		}
		[Q_SLOT("void removePage(QWidget*)")]
		[SmokeMethod("removePage(QWidget*)")]
		public virtual void RemovePage(QWidget arg1) {
			ProxyQTabWidget().RemovePage(arg1);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQTabWidget().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQTabWidget().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQTabWidget().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQTabWidget().TrUtf8(arg1);
		}
		[SmokeMethod("showEvent(QShowEvent*)")]
		public new void ShowEvent(QShowEvent arg1) {
			ProxyQTabWidget().ShowEvent(arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQTabWidget().ResizeEvent(arg1);
		}
		[SmokeMethod("setTabBar(QTabBar*)")]
		protected void SetTabBar(QTabBar arg1) {
			ProxyQTabWidget().SetTabBar(arg1);
		}
		[SmokeMethod("tabBar() const")]
		protected QTabBar TabBar() {
			return ProxyQTabWidget().TabBar();
		}
		[SmokeMethod("styleChange(QStyle&)")]
		public new void StyleChange(QStyle arg1) {
			ProxyQTabWidget().StyleChange(arg1);
		}
		[SmokeMethod("updateMask()")]
		protected new void UpdateMask() {
			ProxyQTabWidget().UpdateMask();
		}
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		public new bool EventFilter(QObject arg1, QEvent arg2) {
			return ProxyQTabWidget().EventFilter(arg1,arg2);
		}
		~QTabWidget() {
			DisposeQTabWidget();
		}
		public new void Dispose() {
			DisposeQTabWidget();
		}
		private void DisposeQTabWidget() {
			ProxyQTabWidget().DisposeQTabWidget();
		}
		protected void CreateQTabWidgetSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQTabWidgetSignals), this);
			Q_EMIT = (IQTabWidgetSignals) realProxy.GetTransparentProxy();
		}
		protected new IQTabWidgetSignals Emit() {
			return (IQTabWidgetSignals) Q_EMIT;
		}
	}

	public interface IQTabWidgetSignals : IQWidgetSignals {
		[Q_SIGNAL("void currentChanged(QWidget*)")]
		void CurrentChanged(QWidget arg1);
		[Q_SIGNAL("void selected(const QString&)")]
		void Selected(string arg1);
	}
}
