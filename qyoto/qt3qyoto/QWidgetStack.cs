//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQWidgetStackSignals"></see> for signals emitted by QWidgetStack
	[SmokeClass("QWidgetStack")]
	public class QWidgetStack : QFrame, IDisposable {
 		protected QWidgetStack(Type dummy) : base((Type) null) {}
		interface IQWidgetStackProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQWidgetStackProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QWidgetStack), this);
			_interceptor = (QWidgetStack) realProxy.GetTransparentProxy();
		}
		private QWidgetStack ProxyQWidgetStack() {
			return (QWidgetStack) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QWidgetStack() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQWidgetStackProxy), null);
			_staticInterceptor = (IQWidgetStackProxy) realProxy.GetTransparentProxy();
		}
		private static IQWidgetStackProxy StaticQWidgetStack() {
			return (IQWidgetStackProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQWidgetStack().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQWidgetStack().ClassName();
		}
		public QWidgetStack(QWidget parent, string name) : this((Type) null) {
			CreateQWidgetStackProxy();
			CreateQWidgetStackSignalProxy();
			NewQWidgetStack(parent,name);
		}
		[SmokeMethod("QWidgetStack(QWidget*, const char*)")]
		private void NewQWidgetStack(QWidget parent, string name) {
			ProxyQWidgetStack().NewQWidgetStack(parent,name);
		}
		public QWidgetStack(QWidget parent) : this((Type) null) {
			CreateQWidgetStackProxy();
			CreateQWidgetStackSignalProxy();
			NewQWidgetStack(parent);
		}
		[SmokeMethod("QWidgetStack(QWidget*)")]
		private void NewQWidgetStack(QWidget parent) {
			ProxyQWidgetStack().NewQWidgetStack(parent);
		}
		public QWidgetStack() : this((Type) null) {
			CreateQWidgetStackProxy();
			CreateQWidgetStackSignalProxy();
			NewQWidgetStack();
		}
		[SmokeMethod("QWidgetStack()")]
		private void NewQWidgetStack() {
			ProxyQWidgetStack().NewQWidgetStack();
		}
		public QWidgetStack(QWidget parent, string name, int f) : this((Type) null) {
			CreateQWidgetStackProxy();
			CreateQWidgetStackSignalProxy();
			NewQWidgetStack(parent,name,f);
		}
		[SmokeMethod("QWidgetStack(QWidget*, const char*, Qt::WFlags)")]
		private void NewQWidgetStack(QWidget parent, string name, int f) {
			ProxyQWidgetStack().NewQWidgetStack(parent,name,f);
		}
		[SmokeMethod("addWidget(QWidget*, int)")]
		public int AddWidget(QWidget arg1, int arg2) {
			return ProxyQWidgetStack().AddWidget(arg1,arg2);
		}
		[SmokeMethod("addWidget(QWidget*)")]
		public int AddWidget(QWidget arg1) {
			return ProxyQWidgetStack().AddWidget(arg1);
		}
		[SmokeMethod("removeWidget(QWidget*)")]
		public void RemoveWidget(QWidget arg1) {
			ProxyQWidgetStack().RemoveWidget(arg1);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQWidgetStack().SizeHint();
		}
		[SmokeMethod("minimumSizeHint() const")]
		public new QSize MinimumSizeHint() {
			return ProxyQWidgetStack().MinimumSizeHint();
		}
		[SmokeMethod("show()")]
		public new void Show() {
			ProxyQWidgetStack().Show();
		}
		[SmokeMethod("widget(int) const")]
		public QWidget Widget(int arg1) {
			return ProxyQWidgetStack().Widget(arg1);
		}
		[SmokeMethod("id(QWidget*) const")]
		public int Id(QWidget arg1) {
			return ProxyQWidgetStack().Id(arg1);
		}
		[SmokeMethod("visibleWidget() const")]
		public QWidget VisibleWidget() {
			return ProxyQWidgetStack().VisibleWidget();
		}
		[SmokeMethod("setFrameRect(const QRect&)")]
		public new void SetFrameRect(QRect arg1) {
			ProxyQWidgetStack().SetFrameRect(arg1);
		}
		[Q_SLOT("void raiseWidget(int)")]
		[SmokeMethod("raiseWidget(int)")]
		public void RaiseWidget(int arg1) {
			ProxyQWidgetStack().RaiseWidget(arg1);
		}
		[Q_SLOT("void raiseWidget(QWidget*)")]
		[SmokeMethod("raiseWidget(QWidget*)")]
		public void RaiseWidget(QWidget arg1) {
			ProxyQWidgetStack().RaiseWidget(arg1);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQWidgetStack().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQWidgetStack().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQWidgetStack().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQWidgetStack().TrUtf8(arg1);
		}
		[SmokeMethod("frameChanged()")]
		protected new void FrameChanged() {
			ProxyQWidgetStack().FrameChanged();
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQWidgetStack().ResizeEvent(arg1);
		}
		[SmokeMethod("setChildGeometries()")]
		protected virtual void SetChildGeometries() {
			ProxyQWidgetStack().SetChildGeometries();
		}
		[SmokeMethod("childEvent(QChildEvent*)")]
		protected new void ChildEvent(QChildEvent arg1) {
			ProxyQWidgetStack().ChildEvent(arg1);
		}
		~QWidgetStack() {
			DisposeQWidgetStack();
		}
		public new void Dispose() {
			DisposeQWidgetStack();
		}
		private void DisposeQWidgetStack() {
			ProxyQWidgetStack().DisposeQWidgetStack();
		}
		protected void CreateQWidgetStackSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQWidgetStackSignals), this);
			Q_EMIT = (IQWidgetStackSignals) realProxy.GetTransparentProxy();
		}
		protected new IQWidgetStackSignals Emit() {
			return (IQWidgetStackSignals) Q_EMIT;
		}
	}

	public interface IQWidgetStackSignals : IQFrameSignals {
		[Q_SIGNAL("void aboutToShow(int)")]
		void AboutToShow(int arg1);
		[Q_SIGNAL("void aboutToShow(QWidget*)")]
		void AboutToShow(QWidget arg1);
	}
}
