//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QHBoxLayout")]
	public class QHBoxLayout : QBoxLayout, IDisposable {
 		protected QHBoxLayout(Type dummy) : base((Type) null) {}
		interface IQHBoxLayoutProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQHBoxLayoutProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QHBoxLayout), this);
			_interceptor = (QHBoxLayout) realProxy.GetTransparentProxy();
		}
		private QHBoxLayout ProxyQHBoxLayout() {
			return (QHBoxLayout) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QHBoxLayout() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQHBoxLayoutProxy), null);
			_staticInterceptor = (IQHBoxLayoutProxy) realProxy.GetTransparentProxy();
		}
		private static IQHBoxLayoutProxy StaticQHBoxLayout() {
			return (IQHBoxLayoutProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQHBoxLayout().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQHBoxLayout().ClassName();
		}
		public QHBoxLayout(QWidget parent, int border, int spacing, string name) : this((Type) null) {
			CreateQHBoxLayoutProxy();
			CreateQHBoxLayoutSignalProxy();
			NewQHBoxLayout(parent,border,spacing,name);
		}
		[SmokeMethod("QHBoxLayout(QWidget*, int, int, const char*)")]
		private void NewQHBoxLayout(QWidget parent, int border, int spacing, string name) {
			ProxyQHBoxLayout().NewQHBoxLayout(parent,border,spacing,name);
		}
		public QHBoxLayout(QWidget parent, int border, int spacing) : this((Type) null) {
			CreateQHBoxLayoutProxy();
			CreateQHBoxLayoutSignalProxy();
			NewQHBoxLayout(parent,border,spacing);
		}
		[SmokeMethod("QHBoxLayout(QWidget*, int, int)")]
		private void NewQHBoxLayout(QWidget parent, int border, int spacing) {
			ProxyQHBoxLayout().NewQHBoxLayout(parent,border,spacing);
		}
		public QHBoxLayout(QWidget parent, int border) : this((Type) null) {
			CreateQHBoxLayoutProxy();
			CreateQHBoxLayoutSignalProxy();
			NewQHBoxLayout(parent,border);
		}
		[SmokeMethod("QHBoxLayout(QWidget*, int)")]
		private void NewQHBoxLayout(QWidget parent, int border) {
			ProxyQHBoxLayout().NewQHBoxLayout(parent,border);
		}
		public QHBoxLayout(QWidget parent) : this((Type) null) {
			CreateQHBoxLayoutProxy();
			CreateQHBoxLayoutSignalProxy();
			NewQHBoxLayout(parent);
		}
		[SmokeMethod("QHBoxLayout(QWidget*)")]
		private void NewQHBoxLayout(QWidget parent) {
			ProxyQHBoxLayout().NewQHBoxLayout(parent);
		}
		public QHBoxLayout(QLayout parentLayout, int spacing, string name) : this((Type) null) {
			CreateQHBoxLayoutProxy();
			CreateQHBoxLayoutSignalProxy();
			NewQHBoxLayout(parentLayout,spacing,name);
		}
		[SmokeMethod("QHBoxLayout(QLayout*, int, const char*)")]
		private void NewQHBoxLayout(QLayout parentLayout, int spacing, string name) {
			ProxyQHBoxLayout().NewQHBoxLayout(parentLayout,spacing,name);
		}
		public QHBoxLayout(QLayout parentLayout, int spacing) : this((Type) null) {
			CreateQHBoxLayoutProxy();
			CreateQHBoxLayoutSignalProxy();
			NewQHBoxLayout(parentLayout,spacing);
		}
		[SmokeMethod("QHBoxLayout(QLayout*, int)")]
		private void NewQHBoxLayout(QLayout parentLayout, int spacing) {
			ProxyQHBoxLayout().NewQHBoxLayout(parentLayout,spacing);
		}
		public QHBoxLayout(QLayout parentLayout) : this((Type) null) {
			CreateQHBoxLayoutProxy();
			CreateQHBoxLayoutSignalProxy();
			NewQHBoxLayout(parentLayout);
		}
		[SmokeMethod("QHBoxLayout(QLayout*)")]
		private void NewQHBoxLayout(QLayout parentLayout) {
			ProxyQHBoxLayout().NewQHBoxLayout(parentLayout);
		}
		public QHBoxLayout(int spacing, string name) : this((Type) null) {
			CreateQHBoxLayoutProxy();
			CreateQHBoxLayoutSignalProxy();
			NewQHBoxLayout(spacing,name);
		}
		[SmokeMethod("QHBoxLayout(int, const char*)")]
		private void NewQHBoxLayout(int spacing, string name) {
			ProxyQHBoxLayout().NewQHBoxLayout(spacing,name);
		}
		public QHBoxLayout(int spacing) : this((Type) null) {
			CreateQHBoxLayoutProxy();
			CreateQHBoxLayoutSignalProxy();
			NewQHBoxLayout(spacing);
		}
		[SmokeMethod("QHBoxLayout(int)")]
		private void NewQHBoxLayout(int spacing) {
			ProxyQHBoxLayout().NewQHBoxLayout(spacing);
		}
		public QHBoxLayout() : this((Type) null) {
			CreateQHBoxLayoutProxy();
			CreateQHBoxLayoutSignalProxy();
			NewQHBoxLayout();
		}
		[SmokeMethod("QHBoxLayout()")]
		private void NewQHBoxLayout() {
			ProxyQHBoxLayout().NewQHBoxLayout();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQHBoxLayout().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQHBoxLayout().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQHBoxLayout().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQHBoxLayout().TrUtf8(arg1);
		}
		~QHBoxLayout() {
			DisposeQHBoxLayout();
		}
		public new void Dispose() {
			DisposeQHBoxLayout();
		}
		private void DisposeQHBoxLayout() {
			ProxyQHBoxLayout().DisposeQHBoxLayout();
		}
		protected void CreateQHBoxLayoutSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQHBoxLayoutSignals), this);
			Q_EMIT = (IQHBoxLayoutSignals) realProxy.GetTransparentProxy();
		}
		protected new IQHBoxLayoutSignals Emit() {
			return (IQHBoxLayoutSignals) Q_EMIT;
		}
	}

	public interface IQHBoxLayoutSignals : IQBoxLayoutSignals {
	}
}
