//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QLayout")]
	public class QLayout : QObject, IQLayoutItem {
 		protected QLayout(Type dummy) : base((Type) null) {}
		interface IQLayoutProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQLayoutProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QLayout), this);
			_interceptor = (QLayout) realProxy.GetTransparentProxy();
		}
		private QLayout ProxyQLayout() {
			return (QLayout) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QLayout() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQLayoutProxy), null);
			_staticInterceptor = (IQLayoutProxy) realProxy.GetTransparentProxy();
		}
		private static IQLayoutProxy StaticQLayout() {
			return (IQLayoutProxy) _staticInterceptor;
		}

		enum E_ResizeMode {
			FreeResize = 0,
			Minimum = 1,
			Fixed = 2,
			Auto = 3,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQLayout().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQLayout().ClassName();
		}
		public QLayout(QWidget parent, int margin, int spacing, string name) : this((Type) null) {
			CreateQLayoutProxy();
			CreateQLayoutSignalProxy();
			NewQLayout(parent,margin,spacing,name);
		}
		[SmokeMethod("QLayout(QWidget*, int, int, const char*)")]
		private void NewQLayout(QWidget parent, int margin, int spacing, string name) {
			ProxyQLayout().NewQLayout(parent,margin,spacing,name);
		}
		public QLayout(QWidget parent, int margin, int spacing) : this((Type) null) {
			CreateQLayoutProxy();
			CreateQLayoutSignalProxy();
			NewQLayout(parent,margin,spacing);
		}
		[SmokeMethod("QLayout(QWidget*, int, int)")]
		private void NewQLayout(QWidget parent, int margin, int spacing) {
			ProxyQLayout().NewQLayout(parent,margin,spacing);
		}
		public QLayout(QWidget parent, int margin) : this((Type) null) {
			CreateQLayoutProxy();
			CreateQLayoutSignalProxy();
			NewQLayout(parent,margin);
		}
		[SmokeMethod("QLayout(QWidget*, int)")]
		private void NewQLayout(QWidget parent, int margin) {
			ProxyQLayout().NewQLayout(parent,margin);
		}
		public QLayout(QWidget parent) : this((Type) null) {
			CreateQLayoutProxy();
			CreateQLayoutSignalProxy();
			NewQLayout(parent);
		}
		[SmokeMethod("QLayout(QWidget*)")]
		private void NewQLayout(QWidget parent) {
			ProxyQLayout().NewQLayout(parent);
		}
		public QLayout(QLayout parentLayout, int spacing, string name) : this((Type) null) {
			CreateQLayoutProxy();
			CreateQLayoutSignalProxy();
			NewQLayout(parentLayout,spacing,name);
		}
		[SmokeMethod("QLayout(QLayout*, int, const char*)")]
		private void NewQLayout(QLayout parentLayout, int spacing, string name) {
			ProxyQLayout().NewQLayout(parentLayout,spacing,name);
		}
		public QLayout(QLayout parentLayout, int spacing) : this((Type) null) {
			CreateQLayoutProxy();
			CreateQLayoutSignalProxy();
			NewQLayout(parentLayout,spacing);
		}
		[SmokeMethod("QLayout(QLayout*, int)")]
		private void NewQLayout(QLayout parentLayout, int spacing) {
			ProxyQLayout().NewQLayout(parentLayout,spacing);
		}
		public QLayout(QLayout parentLayout) : this((Type) null) {
			CreateQLayoutProxy();
			CreateQLayoutSignalProxy();
			NewQLayout(parentLayout);
		}
		[SmokeMethod("QLayout(QLayout*)")]
		private void NewQLayout(QLayout parentLayout) {
			ProxyQLayout().NewQLayout(parentLayout);
		}
		public QLayout(int spacing, string name) : this((Type) null) {
			CreateQLayoutProxy();
			CreateQLayoutSignalProxy();
			NewQLayout(spacing,name);
		}
		[SmokeMethod("QLayout(int, const char*)")]
		private void NewQLayout(int spacing, string name) {
			ProxyQLayout().NewQLayout(spacing,name);
		}
		public QLayout(int spacing) : this((Type) null) {
			CreateQLayoutProxy();
			CreateQLayoutSignalProxy();
			NewQLayout(spacing);
		}
		[SmokeMethod("QLayout(int)")]
		private void NewQLayout(int spacing) {
			ProxyQLayout().NewQLayout(spacing);
		}
		public QLayout() : this((Type) null) {
			CreateQLayoutProxy();
			CreateQLayoutSignalProxy();
			NewQLayout();
		}
		[SmokeMethod("QLayout()")]
		private void NewQLayout() {
			ProxyQLayout().NewQLayout();
		}
		[SmokeMethod("margin() const")]
		public int Margin() {
			return ProxyQLayout().Margin();
		}
		[SmokeMethod("spacing() const")]
		public int Spacing() {
			return ProxyQLayout().Spacing();
		}
		[SmokeMethod("setMargin(int)")]
		public virtual void SetMargin(int arg1) {
			ProxyQLayout().SetMargin(arg1);
		}
		[SmokeMethod("setSpacing(int)")]
		public virtual void SetSpacing(int arg1) {
			ProxyQLayout().SetSpacing(arg1);
		}
		[SmokeMethod("defaultBorder() const")]
		public int DefaultBorder() {
			return ProxyQLayout().DefaultBorder();
		}
		[SmokeMethod("freeze(int, int)")]
		public void Freeze(int w, int h) {
			ProxyQLayout().Freeze(w,h);
		}
		[SmokeMethod("freeze()")]
		public void Freeze() {
			ProxyQLayout().Freeze();
		}
		[SmokeMethod("setResizeMode(QLayout::ResizeMode)")]
		public void SetResizeMode(int arg1) {
			ProxyQLayout().SetResizeMode(arg1);
		}
		[SmokeMethod("resizeMode() const")]
		public int ResizeMode() {
			return ProxyQLayout().ResizeMode();
		}
		[SmokeMethod("setMenuBar(QMenuBar*)")]
		public virtual void SetMenuBar(QMenuBar w) {
			ProxyQLayout().SetMenuBar(w);
		}
		[SmokeMethod("menuBar() const")]
		public QMenuBar MenuBar() {
			return ProxyQLayout().MenuBar();
		}
		[SmokeMethod("mainWidget()")]
		public QWidget MainWidget() {
			return ProxyQLayout().MainWidget();
		}
		[SmokeMethod("isTopLevel() const")]
		public bool IsTopLevel() {
			return ProxyQLayout().IsTopLevel();
		}
		[SmokeMethod("setAutoAdd(bool)")]
		public virtual void SetAutoAdd(bool arg1) {
			ProxyQLayout().SetAutoAdd(arg1);
		}
		[SmokeMethod("autoAdd() const")]
		public bool AutoAdd() {
			return ProxyQLayout().AutoAdd();
		}
		[SmokeMethod("invalidate()")]
		public void Invalidate() {
			ProxyQLayout().Invalidate();
		}
		[SmokeMethod("geometry() const")]
		public QRect Geometry() {
			return ProxyQLayout().Geometry();
		}
		[SmokeMethod("activate()")]
		public bool Activate() {
			return ProxyQLayout().Activate();
		}
		[SmokeMethod("add(QWidget*)")]
		public void Add(QWidget w) {
			ProxyQLayout().Add(w);
		}
		[SmokeMethod("addItem(QLayoutItem*)")]
		public virtual void AddItem(IQLayoutItem arg1) {
			ProxyQLayout().AddItem(arg1);
		}
		[SmokeMethod("remove(QWidget*)")]
		public void Remove(QWidget w) {
			ProxyQLayout().Remove(w);
		}
		[SmokeMethod("removeItem(QLayoutItem*)")]
		public void RemoveItem(IQLayoutItem arg1) {
			ProxyQLayout().RemoveItem(arg1);
		}
		[SmokeMethod("expanding() const")]
		public int Expanding() {
			return ProxyQLayout().Expanding();
		}
		[SmokeMethod("minimumSize() const")]
		public QSize MinimumSize() {
			return ProxyQLayout().MinimumSize();
		}
		[SmokeMethod("maximumSize() const")]
		public QSize MaximumSize() {
			return ProxyQLayout().MaximumSize();
		}
		[SmokeMethod("setGeometry(const QRect&)")]
		public void SetGeometry(QRect arg1) {
			ProxyQLayout().SetGeometry(arg1);
		}
		// QLayoutIterator iterator(); >>>> NOT CONVERTED
		[SmokeMethod("isEmpty() const")]
		public bool IsEmpty() {
			return ProxyQLayout().IsEmpty();
		}
		[SmokeMethod("totalHeightForWidth(int) const")]
		public int TotalHeightForWidth(int w) {
			return ProxyQLayout().TotalHeightForWidth(w);
		}
		[SmokeMethod("totalMinimumSize() const")]
		public QSize TotalMinimumSize() {
			return ProxyQLayout().TotalMinimumSize();
		}
		[SmokeMethod("totalMaximumSize() const")]
		public QSize TotalMaximumSize() {
			return ProxyQLayout().TotalMaximumSize();
		}
		[SmokeMethod("totalSizeHint() const")]
		public QSize TotalSizeHint() {
			return ProxyQLayout().TotalSizeHint();
		}
		[SmokeMethod("layout()")]
		public QLayout Layout() {
			return ProxyQLayout().Layout();
		}
		[SmokeMethod("supportsMargin() const")]
		public bool SupportsMargin() {
			return ProxyQLayout().SupportsMargin();
		}
		[SmokeMethod("setEnabled(bool)")]
		public void SetEnabled(bool arg1) {
			ProxyQLayout().SetEnabled(arg1);
		}
		[SmokeMethod("isEnabled() const")]
		public bool IsEnabled() {
			return ProxyQLayout().IsEnabled();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQLayout().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQLayout().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQLayout().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQLayout().TrUtf8(arg1);
		}
		~QLayout() {
			DisposeQLayout();
		}
		public new void Dispose() {
			DisposeQLayout();
		}
		private void DisposeQLayout() {
			ProxyQLayout().DisposeQLayout();
		}
		[SmokeMethod("sizeHint() const")]
		public virtual QSize SizeHint() {
			return ProxyQLayout().SizeHint();
		}
		[SmokeMethod("hasHeightForWidth() const")]
		public virtual bool HasHeightForWidth() {
			return ProxyQLayout().HasHeightForWidth();
		}
		[SmokeMethod("heightForWidth(int) const")]
		public virtual int HeightForWidth(int arg1) {
			return ProxyQLayout().HeightForWidth(arg1);
		}
		[SmokeMethod("widget()")]
		public virtual QWidget Widget() {
			return ProxyQLayout().Widget();
		}
		// QLayoutIterator iterator(); >>>> NOT CONVERTED
		[SmokeMethod("spacerItem()")]
		public virtual QSpacerItem SpacerItem() {
			return ProxyQLayout().SpacerItem();
		}
		[SmokeMethod("alignment() const")]
		public int Alignment() {
			return ProxyQLayout().Alignment();
		}
		[SmokeMethod("setAlignment(int)")]
		public virtual void SetAlignment(int a) {
			ProxyQLayout().SetAlignment(a);
		}
		protected void CreateQLayoutSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQLayoutSignals), this);
			Q_EMIT = (IQLayoutSignals) realProxy.GetTransparentProxy();
		}
		protected new IQLayoutSignals Emit() {
			return (IQLayoutSignals) Q_EMIT;
		}
	}

	public interface IQLayoutSignals : IQObjectSignals {
	}
}
