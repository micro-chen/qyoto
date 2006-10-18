//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QDBusAbstractInterface")]
	public class QDBusAbstractInterface : QObject, IDisposable {
 		protected QDBusAbstractInterface(Type dummy) : base((Type) null) {}
		interface IQDBusAbstractInterfaceProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDBusAbstractInterface), this);
			_interceptor = (QDBusAbstractInterface) realProxy.GetTransparentProxy();
		}
		private QDBusAbstractInterface ProxyQDBusAbstractInterface() {
			return (QDBusAbstractInterface) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDBusAbstractInterface() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDBusAbstractInterfaceProxy), null);
			_staticInterceptor = (IQDBusAbstractInterfaceProxy) realProxy.GetTransparentProxy();
		}
		private static IQDBusAbstractInterfaceProxy StaticQDBusAbstractInterface() {
			return (IQDBusAbstractInterfaceProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQDBusAbstractInterface().IsValid();
		}
		[SmokeMethod("connection() const")]
		public QDBusConnection Connection() {
			return ProxyQDBusAbstractInterface().Connection();
		}
		[SmokeMethod("service() const")]
		public string Service() {
			return ProxyQDBusAbstractInterface().Service();
		}
		[SmokeMethod("path() const")]
		public string Path() {
			return ProxyQDBusAbstractInterface().Path();
		}
		[SmokeMethod("interface() const")]
		public string Interface() {
			return ProxyQDBusAbstractInterface().Interface();
		}
		[SmokeMethod("lastError() const")]
		public QDBusError LastError() {
			return ProxyQDBusAbstractInterface().LastError();
		}
		[SmokeMethod("call(const QString&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&)")]
		public QDBusMessage Call(string method, QVariant arg1, QVariant arg2, QVariant arg3, QVariant arg4, QVariant arg5, QVariant arg6, QVariant arg7, QVariant arg8) {
			return ProxyQDBusAbstractInterface().Call(method,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8);
		}
		[SmokeMethod("call(const QString&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&)")]
		public QDBusMessage Call(string method, QVariant arg1, QVariant arg2, QVariant arg3, QVariant arg4, QVariant arg5, QVariant arg6, QVariant arg7) {
			return ProxyQDBusAbstractInterface().Call(method,arg1,arg2,arg3,arg4,arg5,arg6,arg7);
		}
		[SmokeMethod("call(const QString&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&)")]
		public QDBusMessage Call(string method, QVariant arg1, QVariant arg2, QVariant arg3, QVariant arg4, QVariant arg5, QVariant arg6) {
			return ProxyQDBusAbstractInterface().Call(method,arg1,arg2,arg3,arg4,arg5,arg6);
		}
		[SmokeMethod("call(const QString&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&)")]
		public QDBusMessage Call(string method, QVariant arg1, QVariant arg2, QVariant arg3, QVariant arg4, QVariant arg5) {
			return ProxyQDBusAbstractInterface().Call(method,arg1,arg2,arg3,arg4,arg5);
		}
		[SmokeMethod("call(const QString&, const QVariant&, const QVariant&, const QVariant&, const QVariant&)")]
		public QDBusMessage Call(string method, QVariant arg1, QVariant arg2, QVariant arg3, QVariant arg4) {
			return ProxyQDBusAbstractInterface().Call(method,arg1,arg2,arg3,arg4);
		}
		[SmokeMethod("call(const QString&, const QVariant&, const QVariant&, const QVariant&)")]
		public QDBusMessage Call(string method, QVariant arg1, QVariant arg2, QVariant arg3) {
			return ProxyQDBusAbstractInterface().Call(method,arg1,arg2,arg3);
		}
		[SmokeMethod("call(const QString&, const QVariant&, const QVariant&)")]
		public QDBusMessage Call(string method, QVariant arg1, QVariant arg2) {
			return ProxyQDBusAbstractInterface().Call(method,arg1,arg2);
		}
		[SmokeMethod("call(const QString&, const QVariant&)")]
		public QDBusMessage Call(string method, QVariant arg1) {
			return ProxyQDBusAbstractInterface().Call(method,arg1);
		}
		[SmokeMethod("call(const QString&)")]
		public QDBusMessage Call(string method) {
			return ProxyQDBusAbstractInterface().Call(method);
		}
		[SmokeMethod("call(QDBus::CallMode, const QString&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&)")]
		public QDBusMessage Call(QDBus.CallMode mode, string method, QVariant arg1, QVariant arg2, QVariant arg3, QVariant arg4, QVariant arg5, QVariant arg6, QVariant arg7, QVariant arg8) {
			return ProxyQDBusAbstractInterface().Call(mode,method,arg1,arg2,arg3,arg4,arg5,arg6,arg7,arg8);
		}
		[SmokeMethod("call(QDBus::CallMode, const QString&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&)")]
		public QDBusMessage Call(QDBus.CallMode mode, string method, QVariant arg1, QVariant arg2, QVariant arg3, QVariant arg4, QVariant arg5, QVariant arg6, QVariant arg7) {
			return ProxyQDBusAbstractInterface().Call(mode,method,arg1,arg2,arg3,arg4,arg5,arg6,arg7);
		}
		[SmokeMethod("call(QDBus::CallMode, const QString&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&)")]
		public QDBusMessage Call(QDBus.CallMode mode, string method, QVariant arg1, QVariant arg2, QVariant arg3, QVariant arg4, QVariant arg5, QVariant arg6) {
			return ProxyQDBusAbstractInterface().Call(mode,method,arg1,arg2,arg3,arg4,arg5,arg6);
		}
		[SmokeMethod("call(QDBus::CallMode, const QString&, const QVariant&, const QVariant&, const QVariant&, const QVariant&, const QVariant&)")]
		public QDBusMessage Call(QDBus.CallMode mode, string method, QVariant arg1, QVariant arg2, QVariant arg3, QVariant arg4, QVariant arg5) {
			return ProxyQDBusAbstractInterface().Call(mode,method,arg1,arg2,arg3,arg4,arg5);
		}
		[SmokeMethod("call(QDBus::CallMode, const QString&, const QVariant&, const QVariant&, const QVariant&, const QVariant&)")]
		public QDBusMessage Call(QDBus.CallMode mode, string method, QVariant arg1, QVariant arg2, QVariant arg3, QVariant arg4) {
			return ProxyQDBusAbstractInterface().Call(mode,method,arg1,arg2,arg3,arg4);
		}
		[SmokeMethod("call(QDBus::CallMode, const QString&, const QVariant&, const QVariant&, const QVariant&)")]
		public QDBusMessage Call(QDBus.CallMode mode, string method, QVariant arg1, QVariant arg2, QVariant arg3) {
			return ProxyQDBusAbstractInterface().Call(mode,method,arg1,arg2,arg3);
		}
		[SmokeMethod("call(QDBus::CallMode, const QString&, const QVariant&, const QVariant&)")]
		public QDBusMessage Call(QDBus.CallMode mode, string method, QVariant arg1, QVariant arg2) {
			return ProxyQDBusAbstractInterface().Call(mode,method,arg1,arg2);
		}
		[SmokeMethod("call(QDBus::CallMode, const QString&, const QVariant&)")]
		public QDBusMessage Call(QDBus.CallMode mode, string method, QVariant arg1) {
			return ProxyQDBusAbstractInterface().Call(mode,method,arg1);
		}
		[SmokeMethod("call(QDBus::CallMode, const QString&)")]
		public QDBusMessage Call(QDBus.CallMode mode, string method) {
			return ProxyQDBusAbstractInterface().Call(mode,method);
		}
		[SmokeMethod("callWithArgumentList(QDBus::CallMode, const QString&, const QList<QVariant>&)")]
		public QDBusMessage CallWithArgumentList(QDBus.CallMode mode, string method, ArrayList args) {
			return ProxyQDBusAbstractInterface().CallWithArgumentList(mode,method,args);
		}
		[SmokeMethod("callWithCallback(const QString&, const QList<QVariant>&, QObject*, const char*)")]
		public bool CallWithCallback(string method, ArrayList args, QObject receiver, string member) {
			return ProxyQDBusAbstractInterface().CallWithCallback(method,args,receiver,member);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQDBusAbstractInterface().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQDBusAbstractInterface().Tr(s);
		}
		public QDBusAbstractInterface(string service, string path, string arg3, QDBusConnection connection, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQDBusAbstractInterface(service,path,arg3,connection,parent);
		}
		[SmokeMethod("QDBusAbstractInterface(const QString&, const QString&, const char*, const QDBusConnection&, QObject*)")]
		private void NewQDBusAbstractInterface(string service, string path, string arg3, QDBusConnection connection, QObject parent) {
			ProxyQDBusAbstractInterface().NewQDBusAbstractInterface(service,path,arg3,connection,parent);
		}
		[SmokeMethod("connectNotify(const char*)")]
		protected new void ConnectNotify(string signal) {
			ProxyQDBusAbstractInterface().ConnectNotify(signal);
		}
		[SmokeMethod("disconnectNotify(const char*)")]
		protected new void DisconnectNotify(string signal) {
			ProxyQDBusAbstractInterface().DisconnectNotify(signal);
		}
		[SmokeMethod("internalPropGet(const char*) const")]
		protected QVariant InternalPropGet(string propname) {
			return ProxyQDBusAbstractInterface().InternalPropGet(propname);
		}
		[SmokeMethod("internalPropSet(const char*, const QVariant&)")]
		protected void InternalPropSet(string propname, QVariant value) {
			ProxyQDBusAbstractInterface().InternalPropSet(propname,value);
		}
		[SmokeMethod("internalConstCall(QDBus::CallMode, const QString&, const QList<QVariant>&) const")]
		protected QDBusMessage InternalConstCall(QDBus.CallMode mode, string method, ArrayList args) {
			return ProxyQDBusAbstractInterface().InternalConstCall(mode,method,args);
		}
		[SmokeMethod("internalConstCall(QDBus::CallMode, const QString&) const")]
		protected QDBusMessage InternalConstCall(QDBus.CallMode mode, string method) {
			return ProxyQDBusAbstractInterface().InternalConstCall(mode,method);
		}
		~QDBusAbstractInterface() {
			DisposeQDBusAbstractInterface();
		}
		public new void Dispose() {
			DisposeQDBusAbstractInterface();
		}
		[SmokeMethod("~QDBusAbstractInterface()")]
		private void DisposeQDBusAbstractInterface() {
			ProxyQDBusAbstractInterface().DisposeQDBusAbstractInterface();
		}
		protected new IQDBusAbstractInterfaceSignals Emit() {
			return (IQDBusAbstractInterfaceSignals) Q_EMIT;
		}
	}

	public interface IQDBusAbstractInterfaceSignals : IQObjectSignals {
	}
}
