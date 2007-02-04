//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QAccessibleWidget")]
	public class QAccessibleWidget : QAccessibleObject {
 		protected QAccessibleWidget(Type dummy) : base((Type) null) {}
		[SmokeClass("QAccessibleWidget")]
		interface IQAccessibleWidgetProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAccessibleWidget), this);
			_interceptor = (QAccessibleWidget) realProxy.GetTransparentProxy();
		}
		private QAccessibleWidget ProxyQAccessibleWidget() {
			return (QAccessibleWidget) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAccessibleWidget() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAccessibleWidgetProxy), null);
			_staticInterceptor = (IQAccessibleWidgetProxy) realProxy.GetTransparentProxy();
		}
		private static IQAccessibleWidgetProxy StaticQAccessibleWidget() {
			return (IQAccessibleWidgetProxy) _staticInterceptor;
		}
		public QAccessibleWidget(QWidget o, QAccessible.Role r, string name) : this((Type) null) {
			CreateProxy();
			NewQAccessibleWidget(o,r,name);
		}
		[SmokeMethod("QAccessibleWidget", "(QWidget*, QAccessible::Role, const QString&)", "#$$")]
		private void NewQAccessibleWidget(QWidget o, QAccessible.Role r, string name) {
			ProxyQAccessibleWidget().NewQAccessibleWidget(o,r,name);
		}
		public QAccessibleWidget(QWidget o, QAccessible.Role r) : this((Type) null) {
			CreateProxy();
			NewQAccessibleWidget(o,r);
		}
		[SmokeMethod("QAccessibleWidget", "(QWidget*, QAccessible::Role)", "#$")]
		private void NewQAccessibleWidget(QWidget o, QAccessible.Role r) {
			ProxyQAccessibleWidget().NewQAccessibleWidget(o,r);
		}
		public QAccessibleWidget(QWidget o) : this((Type) null) {
			CreateProxy();
			NewQAccessibleWidget(o);
		}
		[SmokeMethod("QAccessibleWidget", "(QWidget*)", "#")]
		private void NewQAccessibleWidget(QWidget o) {
			ProxyQAccessibleWidget().NewQAccessibleWidget(o);
		}
		[SmokeMethod("childCount", "() const", "")]
		public new int ChildCount() {
			return ProxyQAccessibleWidget().ChildCount();
		}
		[SmokeMethod("indexOfChild", "(const QAccessibleInterface*) const", "#")]
		public new int IndexOfChild(QAccessibleInterface child) {
			return ProxyQAccessibleWidget().IndexOfChild(child);
		}
		[SmokeMethod("relationTo", "(int, const QAccessibleInterface*, int) const", "$#$")]
		public new int RelationTo(int child, QAccessibleInterface other, int otherChild) {
			return ProxyQAccessibleWidget().RelationTo(child,other,otherChild);
		}
		[SmokeMethod("childAt", "(int, int) const", "$$")]
		public new int ChildAt(int x, int y) {
			return ProxyQAccessibleWidget().ChildAt(x,y);
		}
		[SmokeMethod("rect", "(int) const", "$")]
		public new QRect Rect(int child) {
			return ProxyQAccessibleWidget().Rect(child);
		}
		[SmokeMethod("navigate", "(QAccessible::RelationFlag, int, QAccessibleInterface**) const", "$$?")]
		public new int Navigate(QAccessible.RelationFlag rel, int entry, QAccessibleInterface target) {
			return ProxyQAccessibleWidget().Navigate(rel,entry,target);
		}
		[SmokeMethod("text", "(QAccessible::Text, int) const", "$$")]
		public new string Text(QAccessible.Text t, int child) {
			return ProxyQAccessibleWidget().Text(t,child);
		}
		[SmokeMethod("role", "(int) const", "$")]
		public new QAccessible.Role Role(int child) {
			return ProxyQAccessibleWidget().Role(child);
		}
		[SmokeMethod("state", "(int) const", "$")]
		public new int State(int child) {
			return ProxyQAccessibleWidget().State(child);
		}
		[SmokeMethod("actionText", "(int, QAccessible::Text, int) const", "$$$")]
		public new string ActionText(int action, QAccessible.Text t, int child) {
			return ProxyQAccessibleWidget().ActionText(action,t,child);
		}
		[SmokeMethod("doAction", "(int, int, const QVariantList&)", "$$?")]
		public new bool DoAction(int action, int child, List<QVariant> arg3) {
			return ProxyQAccessibleWidget().DoAction(action,child,arg3);
		}
		[SmokeMethod("widget", "() const", "")]
		protected QWidget Widget() {
			return ProxyQAccessibleWidget().Widget();
		}
		[SmokeMethod("parentObject", "() const", "")]
		protected QObject ParentObject() {
			return ProxyQAccessibleWidget().ParentObject();
		}
		[SmokeMethod("addControllingSignal", "(const QString&)", "$")]
		protected void AddControllingSignal(string signal) {
			ProxyQAccessibleWidget().AddControllingSignal(signal);
		}
		[SmokeMethod("setValue", "(const QString&)", "$")]
		protected void SetValue(string value) {
			ProxyQAccessibleWidget().SetValue(value);
		}
		[SmokeMethod("setDescription", "(const QString&)", "$")]
		protected void SetDescription(string desc) {
			ProxyQAccessibleWidget().SetDescription(desc);
		}
		[SmokeMethod("setHelp", "(const QString&)", "$")]
		protected void SetHelp(string help) {
			ProxyQAccessibleWidget().SetHelp(help);
		}
		[SmokeMethod("setAccelerator", "(const QString&)", "$")]
		protected void SetAccelerator(string accel) {
			ProxyQAccessibleWidget().SetAccelerator(accel);
		}
	}
}
