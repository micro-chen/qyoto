//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQToolTipGroupSignals"></see> for signals emitted by QToolTipGroup
	public class QToolTipGroup : QObject, IDisposable {
 		protected QToolTipGroup(Type dummy) : base((Type) null) {}
		interface IQToolTipGroupProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQToolTipGroupProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QToolTipGroup), this);
			_interceptor = (QToolTipGroup) realProxy.GetTransparentProxy();
		}
		private QToolTipGroup ProxyQToolTipGroup() {
			return (QToolTipGroup) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QToolTipGroup() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQToolTipGroupProxy), null);
			_staticInterceptor = (IQToolTipGroupProxy) realProxy.GetTransparentProxy();
		}
		private static IQToolTipGroupProxy StaticQToolTipGroup() {
			return (IQToolTipGroupProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQToolTipGroup().MetaObject();
		}
		public new virtual string ClassName() {
			return ProxyQToolTipGroup().ClassName();
		}
		public QToolTipGroup(QObject parent, string name) : this((Type) null) {
			CreateQToolTipGroupProxy();
			NewQToolTipGroup(parent,name);
		}
		private void NewQToolTipGroup(QObject parent, string name) {
			ProxyQToolTipGroup().NewQToolTipGroup(parent,name);
		}
		public QToolTipGroup(QObject parent) : this((Type) null) {
			CreateQToolTipGroupProxy();
			NewQToolTipGroup(parent);
		}
		private void NewQToolTipGroup(QObject parent) {
			ProxyQToolTipGroup().NewQToolTipGroup(parent);
		}
		public bool Delay() {
			return ProxyQToolTipGroup().Delay();
		}
		public bool Enabled() {
			return ProxyQToolTipGroup().Enabled();
		}
		public void SetDelay(bool arg1) {
			ProxyQToolTipGroup().SetDelay(arg1);
		}
		public void SetEnabled(bool arg1) {
			ProxyQToolTipGroup().SetEnabled(arg1);
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQToolTipGroup().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQToolTipGroup().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQToolTipGroup().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQToolTipGroup().TrUtf8(arg1);
		}
		~QToolTipGroup() {
			ProxyQToolTipGroup().Dispose();
		}
		public new void Dispose() {
			ProxyQToolTipGroup().Dispose();
		}
	}

	public interface IQToolTipGroupSignals {
		void ShowTip(string arg1);
		void RemoveTip();
	}
}
