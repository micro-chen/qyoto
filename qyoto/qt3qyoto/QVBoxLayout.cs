//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QVBoxLayout : QBoxLayout, IDisposable {
 		protected QVBoxLayout(Type dummy) : base((Type) null) {}
		interface IQVBoxLayoutProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQVBoxLayoutProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QVBoxLayout), this);
			_interceptor = (QVBoxLayout) realProxy.GetTransparentProxy();
		}
		private QVBoxLayout ProxyQVBoxLayout() {
			return (QVBoxLayout) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QVBoxLayout() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQVBoxLayoutProxy), null);
			_staticInterceptor = (IQVBoxLayoutProxy) realProxy.GetTransparentProxy();
		}
		private static IQVBoxLayoutProxy StaticQVBoxLayout() {
			return (IQVBoxLayoutProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQVBoxLayout().MetaObject();
		}
		public new virtual string ClassName() {
			return ProxyQVBoxLayout().ClassName();
		}
		public QVBoxLayout(QWidget parent, int border, int spacing, string name) : this((Type) null) {
			CreateQVBoxLayoutProxy();
			NewQVBoxLayout(parent,border,spacing,name);
		}
		private void NewQVBoxLayout(QWidget parent, int border, int spacing, string name) {
			ProxyQVBoxLayout().NewQVBoxLayout(parent,border,spacing,name);
		}
		public QVBoxLayout(QWidget parent, int border, int spacing) : this((Type) null) {
			CreateQVBoxLayoutProxy();
			NewQVBoxLayout(parent,border,spacing);
		}
		private void NewQVBoxLayout(QWidget parent, int border, int spacing) {
			ProxyQVBoxLayout().NewQVBoxLayout(parent,border,spacing);
		}
		public QVBoxLayout(QWidget parent, int border) : this((Type) null) {
			CreateQVBoxLayoutProxy();
			NewQVBoxLayout(parent,border);
		}
		private void NewQVBoxLayout(QWidget parent, int border) {
			ProxyQVBoxLayout().NewQVBoxLayout(parent,border);
		}
		public QVBoxLayout(QWidget parent) : this((Type) null) {
			CreateQVBoxLayoutProxy();
			NewQVBoxLayout(parent);
		}
		private void NewQVBoxLayout(QWidget parent) {
			ProxyQVBoxLayout().NewQVBoxLayout(parent);
		}
		public QVBoxLayout(QLayout parentLayout, int spacing, string name) : this((Type) null) {
			CreateQVBoxLayoutProxy();
			NewQVBoxLayout(parentLayout,spacing,name);
		}
		private void NewQVBoxLayout(QLayout parentLayout, int spacing, string name) {
			ProxyQVBoxLayout().NewQVBoxLayout(parentLayout,spacing,name);
		}
		public QVBoxLayout(QLayout parentLayout, int spacing) : this((Type) null) {
			CreateQVBoxLayoutProxy();
			NewQVBoxLayout(parentLayout,spacing);
		}
		private void NewQVBoxLayout(QLayout parentLayout, int spacing) {
			ProxyQVBoxLayout().NewQVBoxLayout(parentLayout,spacing);
		}
		public QVBoxLayout(QLayout parentLayout) : this((Type) null) {
			CreateQVBoxLayoutProxy();
			NewQVBoxLayout(parentLayout);
		}
		private void NewQVBoxLayout(QLayout parentLayout) {
			ProxyQVBoxLayout().NewQVBoxLayout(parentLayout);
		}
		public QVBoxLayout(int spacing, string name) : this((Type) null) {
			CreateQVBoxLayoutProxy();
			NewQVBoxLayout(spacing,name);
		}
		private void NewQVBoxLayout(int spacing, string name) {
			ProxyQVBoxLayout().NewQVBoxLayout(spacing,name);
		}
		public QVBoxLayout(int spacing) : this((Type) null) {
			CreateQVBoxLayoutProxy();
			NewQVBoxLayout(spacing);
		}
		private void NewQVBoxLayout(int spacing) {
			ProxyQVBoxLayout().NewQVBoxLayout(spacing);
		}
		public QVBoxLayout() : this((Type) null) {
			CreateQVBoxLayoutProxy();
			NewQVBoxLayout();
		}
		private void NewQVBoxLayout() {
			ProxyQVBoxLayout().NewQVBoxLayout();
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQVBoxLayout().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQVBoxLayout().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQVBoxLayout().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQVBoxLayout().TrUtf8(arg1);
		}
		~QVBoxLayout() {
			ProxyQVBoxLayout().Dispose();
		}
		public new void Dispose() {
			ProxyQVBoxLayout().Dispose();
		}
	}
}
