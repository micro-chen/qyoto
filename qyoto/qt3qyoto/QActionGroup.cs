//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQActionGroupSignals"></see> for signals emitted by QActionGroup
	[SmokeClass("QActionGroup")]
	public class QActionGroup : QAction, IDisposable {
 		protected QActionGroup(Type dummy) : base((Type) null) {}
		interface IQActionGroupProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQActionGroupProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QActionGroup), this);
			_interceptor = (QActionGroup) realProxy.GetTransparentProxy();
		}
		private QActionGroup ProxyQActionGroup() {
			return (QActionGroup) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QActionGroup() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQActionGroupProxy), null);
			_staticInterceptor = (IQActionGroupProxy) realProxy.GetTransparentProxy();
		}
		private static IQActionGroupProxy StaticQActionGroup() {
			return (IQActionGroupProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQActionGroup().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQActionGroup().ClassName();
		}
		public QActionGroup(QObject parent, string name) : this((Type) null) {
			CreateQActionGroupProxy();
			CreateQActionGroupSignalProxy();
			NewQActionGroup(parent,name);
		}
		[SmokeMethod("QActionGroup(QObject*, const char*)")]
		private void NewQActionGroup(QObject parent, string name) {
			ProxyQActionGroup().NewQActionGroup(parent,name);
		}
		public QActionGroup(QObject parent) : this((Type) null) {
			CreateQActionGroupProxy();
			CreateQActionGroupSignalProxy();
			NewQActionGroup(parent);
		}
		[SmokeMethod("QActionGroup(QObject*)")]
		private void NewQActionGroup(QObject parent) {
			ProxyQActionGroup().NewQActionGroup(parent);
		}
		public QActionGroup(QObject parent, string name, bool exclusive) : this((Type) null) {
			CreateQActionGroupProxy();
			CreateQActionGroupSignalProxy();
			NewQActionGroup(parent,name,exclusive);
		}
		[SmokeMethod("QActionGroup(QObject*, const char*, bool)")]
		private void NewQActionGroup(QObject parent, string name, bool exclusive) {
			ProxyQActionGroup().NewQActionGroup(parent,name,exclusive);
		}
		[SmokeMethod("setExclusive(bool)")]
		public void SetExclusive(bool arg1) {
			ProxyQActionGroup().SetExclusive(arg1);
		}
		[SmokeMethod("isExclusive() const")]
		public bool IsExclusive() {
			return ProxyQActionGroup().IsExclusive();
		}
		[SmokeMethod("add(QAction*)")]
		public void Add(QAction a) {
			ProxyQActionGroup().Add(a);
		}
		[SmokeMethod("addSeparator()")]
		public void AddSeparator() {
			ProxyQActionGroup().AddSeparator();
		}
		[SmokeMethod("addTo(QWidget*)")]
		public new bool AddTo(QWidget arg1) {
			return ProxyQActionGroup().AddTo(arg1);
		}
		[SmokeMethod("removeFrom(QWidget*)")]
		public new bool RemoveFrom(QWidget arg1) {
			return ProxyQActionGroup().RemoveFrom(arg1);
		}
		[SmokeMethod("setEnabled(bool)")]
		public new void SetEnabled(bool arg1) {
			ProxyQActionGroup().SetEnabled(arg1);
		}
		[SmokeMethod("setToggleAction(bool)")]
		public new void SetToggleAction(bool toggle) {
			ProxyQActionGroup().SetToggleAction(toggle);
		}
		[SmokeMethod("setOn(bool)")]
		public new void SetOn(bool on) {
			ProxyQActionGroup().SetOn(on);
		}
		[SmokeMethod("setUsesDropDown(bool)")]
		public void SetUsesDropDown(bool enable) {
			ProxyQActionGroup().SetUsesDropDown(enable);
		}
		[SmokeMethod("usesDropDown() const")]
		public bool UsesDropDown() {
			return ProxyQActionGroup().UsesDropDown();
		}
		[SmokeMethod("setIconSet(const QIconSet&)")]
		public new void SetIconSet(QIconSet arg1) {
			ProxyQActionGroup().SetIconSet(arg1);
		}
		[SmokeMethod("setText(const QString&)")]
		public new void SetText(string arg1) {
			ProxyQActionGroup().SetText(arg1);
		}
		[SmokeMethod("setMenuText(const QString&)")]
		public new void SetMenuText(string arg1) {
			ProxyQActionGroup().SetMenuText(arg1);
		}
		[SmokeMethod("setToolTip(const QString&)")]
		public new void SetToolTip(string arg1) {
			ProxyQActionGroup().SetToolTip(arg1);
		}
		[SmokeMethod("setWhatsThis(const QString&)")]
		public new void SetWhatsThis(string arg1) {
			ProxyQActionGroup().SetWhatsThis(arg1);
		}
		[SmokeMethod("insert(QAction*)")]
		public void Insert(QAction a) {
			ProxyQActionGroup().Insert(a);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQActionGroup().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQActionGroup().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQActionGroup().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQActionGroup().TrUtf8(arg1);
		}
		[SmokeMethod("childEvent(QChildEvent*)")]
		protected new void ChildEvent(QChildEvent arg1) {
			ProxyQActionGroup().ChildEvent(arg1);
		}
		[SmokeMethod("addedTo(QWidget*, QWidget*, QAction*)")]
		protected new virtual void AddedTo(QWidget actionWidget, QWidget container, QAction a) {
			ProxyQActionGroup().AddedTo(actionWidget,container,a);
		}
		[SmokeMethod("addedTo(int, QPopupMenu*, QAction*)")]
		protected new virtual void AddedTo(int index, QPopupMenu menu, QAction a) {
			ProxyQActionGroup().AddedTo(index,menu,a);
		}
		[SmokeMethod("addedTo(QWidget*, QWidget*)")]
		protected new virtual void AddedTo(QWidget actionWidget, QWidget container) {
			ProxyQActionGroup().AddedTo(actionWidget,container);
		}
		[SmokeMethod("addedTo(int, QPopupMenu*)")]
		protected new virtual void AddedTo(int index, QPopupMenu menu) {
			ProxyQActionGroup().AddedTo(index,menu);
		}
		~QActionGroup() {
			DisposeQActionGroup();
		}
		public new void Dispose() {
			DisposeQActionGroup();
		}
		private void DisposeQActionGroup() {
			ProxyQActionGroup().DisposeQActionGroup();
		}
		protected void CreateQActionGroupSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQActionGroupSignals), this);
			Q_EMIT = (IQActionGroupSignals) realProxy.GetTransparentProxy();
		}
		protected new IQActionGroupSignals Emit() {
			return (IQActionGroupSignals) Q_EMIT;
		}
	}

	public interface IQActionGroupSignals : IQActionSignals {
		[Q_SIGNAL("void selected(QAction*)")]
		void Selected(QAction arg1);
	}
}
