//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QMetaProperty")]
	public class QMetaProperty : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QMetaProperty(Type dummy) {}
		interface IQMetaPropertyProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMetaProperty), this);
			_interceptor = (QMetaProperty) realProxy.GetTransparentProxy();
		}
		private QMetaProperty ProxyQMetaProperty() {
			return (QMetaProperty) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMetaProperty() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMetaPropertyProxy), null);
			_staticInterceptor = (IQMetaPropertyProxy) realProxy.GetTransparentProxy();
		}
		private static IQMetaPropertyProxy StaticQMetaProperty() {
			return (IQMetaPropertyProxy) _staticInterceptor;
		}

		public QMetaProperty() : this((Type) null) {
			CreateProxy();
			NewQMetaProperty();
		}
		[SmokeMethod("QMetaProperty()")]
		private void NewQMetaProperty() {
			ProxyQMetaProperty().NewQMetaProperty();
		}
		[SmokeMethod("name() const")]
		public string Name() {
			return ProxyQMetaProperty().Name();
		}
		[SmokeMethod("typeName() const")]
		public string TypeName() {
			return ProxyQMetaProperty().TypeName();
		}
		[SmokeMethod("type() const")]
		public QVariant.E_Type type() {
			return ProxyQMetaProperty().type();
		}
		[SmokeMethod("isReadable() const")]
		public bool IsReadable() {
			return ProxyQMetaProperty().IsReadable();
		}
		[SmokeMethod("isWritable() const")]
		public bool IsWritable() {
			return ProxyQMetaProperty().IsWritable();
		}
		[SmokeMethod("isResettable() const")]
		public bool IsResettable() {
			return ProxyQMetaProperty().IsResettable();
		}
		[SmokeMethod("isDesignable(const QObject*) const")]
		public bool IsDesignable(QObject arg1) {
			return ProxyQMetaProperty().IsDesignable(arg1);
		}
		[SmokeMethod("isDesignable() const")]
		public bool IsDesignable() {
			return ProxyQMetaProperty().IsDesignable();
		}
		[SmokeMethod("isScriptable(const QObject*) const")]
		public bool IsScriptable(QObject arg1) {
			return ProxyQMetaProperty().IsScriptable(arg1);
		}
		[SmokeMethod("isScriptable() const")]
		public bool IsScriptable() {
			return ProxyQMetaProperty().IsScriptable();
		}
		[SmokeMethod("isStored(const QObject*) const")]
		public bool IsStored(QObject arg1) {
			return ProxyQMetaProperty().IsStored(arg1);
		}
		[SmokeMethod("isStored() const")]
		public bool IsStored() {
			return ProxyQMetaProperty().IsStored();
		}
		[SmokeMethod("isEditable(const QObject*) const")]
		public bool IsEditable(QObject arg1) {
			return ProxyQMetaProperty().IsEditable(arg1);
		}
		[SmokeMethod("isEditable() const")]
		public bool IsEditable() {
			return ProxyQMetaProperty().IsEditable();
		}
		[SmokeMethod("isUser(const QObject*) const")]
		public bool IsUser(QObject arg1) {
			return ProxyQMetaProperty().IsUser(arg1);
		}
		[SmokeMethod("isUser() const")]
		public bool IsUser() {
			return ProxyQMetaProperty().IsUser();
		}
		[SmokeMethod("isFlagType() const")]
		public bool IsFlagType() {
			return ProxyQMetaProperty().IsFlagType();
		}
		[SmokeMethod("isEnumType() const")]
		public bool IsEnumType() {
			return ProxyQMetaProperty().IsEnumType();
		}
		[SmokeMethod("enumerator() const")]
		public QMetaEnum Enumerator() {
			return ProxyQMetaProperty().Enumerator();
		}
		[SmokeMethod("read(const QObject*) const")]
		public QVariant Read(QObject arg1) {
			return ProxyQMetaProperty().Read(arg1);
		}
		[SmokeMethod("write(QObject*, const QVariant&) const")]
		public bool Write(QObject arg1, QVariant value) {
			return ProxyQMetaProperty().Write(arg1,value);
		}
		[SmokeMethod("reset(QObject*) const")]
		public bool Reset(QObject arg1) {
			return ProxyQMetaProperty().Reset(arg1);
		}
		[SmokeMethod("hasStdCppSet() const")]
		public bool HasStdCppSet() {
			return ProxyQMetaProperty().HasStdCppSet();
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQMetaProperty().IsValid();
		}
		~QMetaProperty() {
			DisposeQMetaProperty();
		}
		public void Dispose() {
			DisposeQMetaProperty();
		}
		private void DisposeQMetaProperty() {
			ProxyQMetaProperty().DisposeQMetaProperty();
		}
	}
}
