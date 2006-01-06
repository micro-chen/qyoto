//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QSqlPropertyMap")]
	public class QSqlPropertyMap : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QSqlPropertyMap(Type dummy) {}
		interface IQSqlPropertyMapProxy {
			QSqlPropertyMap DefaultMap();
			void InstallDefaultMap(QSqlPropertyMap map);
		}

		protected void CreateQSqlPropertyMapProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSqlPropertyMap), this);
			_interceptor = (QSqlPropertyMap) realProxy.GetTransparentProxy();
		}
		private QSqlPropertyMap ProxyQSqlPropertyMap() {
			return (QSqlPropertyMap) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSqlPropertyMap() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlPropertyMapProxy), null);
			_staticInterceptor = (IQSqlPropertyMapProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlPropertyMapProxy StaticQSqlPropertyMap() {
			return (IQSqlPropertyMapProxy) _staticInterceptor;
		}

		public QSqlPropertyMap() : this((Type) null) {
			CreateQSqlPropertyMapProxy();
			NewQSqlPropertyMap();
		}
		[SmokeMethod("QSqlPropertyMap()")]
		private void NewQSqlPropertyMap() {
			ProxyQSqlPropertyMap().NewQSqlPropertyMap();
		}
		[SmokeMethod("property(QWidget*)")]
		public QVariant Property(QWidget widget) {
			return ProxyQSqlPropertyMap().Property(widget);
		}
		[SmokeMethod("setProperty(QWidget*, const QVariant&)")]
		public virtual void SetProperty(QWidget widget, QVariant value) {
			ProxyQSqlPropertyMap().SetProperty(widget,value);
		}
		[SmokeMethod("insert(const QString&, const QString&)")]
		public void Insert(string classname, string property) {
			ProxyQSqlPropertyMap().Insert(classname,property);
		}
		[SmokeMethod("remove(const QString&)")]
		public void Remove(string classname) {
			ProxyQSqlPropertyMap().Remove(classname);
		}
		[SmokeMethod("defaultMap()")]
		public static QSqlPropertyMap DefaultMap() {
			return StaticQSqlPropertyMap().DefaultMap();
		}
		[SmokeMethod("installDefaultMap(QSqlPropertyMap*)")]
		public static void InstallDefaultMap(QSqlPropertyMap map) {
			StaticQSqlPropertyMap().InstallDefaultMap(map);
		}
		~QSqlPropertyMap() {
			DisposeQSqlPropertyMap();
		}
		public void Dispose() {
			DisposeQSqlPropertyMap();
		}
		private void DisposeQSqlPropertyMap() {
			ProxyQSqlPropertyMap().DisposeQSqlPropertyMap();
		}
	}
}
