//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQGroupBoxSignals"></see> for signals emitted by QGroupBox
	public class QGroupBox : QFrame, IDisposable {
 		protected QGroupBox(Type dummy) : base((Type) null) {}
		interface IQGroupBoxProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQGroupBoxProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGroupBox), this);
			_interceptor = (QGroupBox) realProxy.GetTransparentProxy();
		}
		private QGroupBox ProxyQGroupBox() {
			return (QGroupBox) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGroupBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGroupBoxProxy), null);
			_staticInterceptor = (IQGroupBoxProxy) realProxy.GetTransparentProxy();
		}
		private static IQGroupBoxProxy StaticQGroupBox() {
			return (IQGroupBoxProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQGroupBox().MetaObject();
		}
		public new virtual string ClassName() {
			return ProxyQGroupBox().ClassName();
		}
		public QGroupBox(QWidget parent, string name) : this((Type) null) {
			CreateQGroupBoxProxy();
			NewQGroupBox(parent,name);
		}
		private void NewQGroupBox(QWidget parent, string name) {
			ProxyQGroupBox().NewQGroupBox(parent,name);
		}
		public QGroupBox(QWidget parent) : this((Type) null) {
			CreateQGroupBoxProxy();
			NewQGroupBox(parent);
		}
		private void NewQGroupBox(QWidget parent) {
			ProxyQGroupBox().NewQGroupBox(parent);
		}
		public QGroupBox() : this((Type) null) {
			CreateQGroupBoxProxy();
			NewQGroupBox();
		}
		private void NewQGroupBox() {
			ProxyQGroupBox().NewQGroupBox();
		}
		public QGroupBox(string title, QWidget parent, string name) : this((Type) null) {
			CreateQGroupBoxProxy();
			NewQGroupBox(title,parent,name);
		}
		private void NewQGroupBox(string title, QWidget parent, string name) {
			ProxyQGroupBox().NewQGroupBox(title,parent,name);
		}
		public QGroupBox(string title, QWidget parent) : this((Type) null) {
			CreateQGroupBoxProxy();
			NewQGroupBox(title,parent);
		}
		private void NewQGroupBox(string title, QWidget parent) {
			ProxyQGroupBox().NewQGroupBox(title,parent);
		}
		public QGroupBox(string title) : this((Type) null) {
			CreateQGroupBoxProxy();
			NewQGroupBox(title);
		}
		private void NewQGroupBox(string title) {
			ProxyQGroupBox().NewQGroupBox(title);
		}
		public QGroupBox(int strips, int o, QWidget parent, string name) : this((Type) null) {
			CreateQGroupBoxProxy();
			NewQGroupBox(strips,o,parent,name);
		}
		private void NewQGroupBox(int strips, int o, QWidget parent, string name) {
			ProxyQGroupBox().NewQGroupBox(strips,o,parent,name);
		}
		public QGroupBox(int strips, int o, QWidget parent) : this((Type) null) {
			CreateQGroupBoxProxy();
			NewQGroupBox(strips,o,parent);
		}
		private void NewQGroupBox(int strips, int o, QWidget parent) {
			ProxyQGroupBox().NewQGroupBox(strips,o,parent);
		}
		public QGroupBox(int strips, int o) : this((Type) null) {
			CreateQGroupBoxProxy();
			NewQGroupBox(strips,o);
		}
		private void NewQGroupBox(int strips, int o) {
			ProxyQGroupBox().NewQGroupBox(strips,o);
		}
		public QGroupBox(int strips, int o, string title, QWidget parent, string name) : this((Type) null) {
			CreateQGroupBoxProxy();
			NewQGroupBox(strips,o,title,parent,name);
		}
		private void NewQGroupBox(int strips, int o, string title, QWidget parent, string name) {
			ProxyQGroupBox().NewQGroupBox(strips,o,title,parent,name);
		}
		public QGroupBox(int strips, int o, string title, QWidget parent) : this((Type) null) {
			CreateQGroupBoxProxy();
			NewQGroupBox(strips,o,title,parent);
		}
		private void NewQGroupBox(int strips, int o, string title, QWidget parent) {
			ProxyQGroupBox().NewQGroupBox(strips,o,title,parent);
		}
		public QGroupBox(int strips, int o, string title) : this((Type) null) {
			CreateQGroupBoxProxy();
			NewQGroupBox(strips,o,title);
		}
		private void NewQGroupBox(int strips, int o, string title) {
			ProxyQGroupBox().NewQGroupBox(strips,o,title);
		}
		public virtual void SetColumnLayout(int strips, int o) {
			ProxyQGroupBox().SetColumnLayout(strips,o);
		}
		public string Title() {
			return ProxyQGroupBox().Title();
		}
		public virtual void SetTitle(string arg1) {
			ProxyQGroupBox().SetTitle(arg1);
		}
		public int Alignment() {
			return ProxyQGroupBox().Alignment();
		}
		public virtual void SetAlignment(int arg1) {
			ProxyQGroupBox().SetAlignment(arg1);
		}
		public int Columns() {
			return ProxyQGroupBox().Columns();
		}
		public void SetColumns(int arg1) {
			ProxyQGroupBox().SetColumns(arg1);
		}
		public int Orientation() {
			return ProxyQGroupBox().Orientation();
		}
		public void SetOrientation(int arg1) {
			ProxyQGroupBox().SetOrientation(arg1);
		}
		public int InsideMargin() {
			return ProxyQGroupBox().InsideMargin();
		}
		public int InsideSpacing() {
			return ProxyQGroupBox().InsideSpacing();
		}
		public void SetInsideMargin(int m) {
			ProxyQGroupBox().SetInsideMargin(m);
		}
		public void SetInsideSpacing(int s) {
			ProxyQGroupBox().SetInsideSpacing(s);
		}
		public void AddSpace(int arg1) {
			ProxyQGroupBox().AddSpace(arg1);
		}
		public new QSize SizeHint() {
			return ProxyQGroupBox().SizeHint();
		}
		public bool IsFlat() {
			return ProxyQGroupBox().IsFlat();
		}
		public void SetFlat(bool b) {
			ProxyQGroupBox().SetFlat(b);
		}
		public bool IsCheckable() {
			return ProxyQGroupBox().IsCheckable();
		}
		public void SetCheckable(bool b) {
			ProxyQGroupBox().SetCheckable(b);
		}
		public bool IsChecked() {
			return ProxyQGroupBox().IsChecked();
		}
		public new void SetEnabled(bool on) {
			ProxyQGroupBox().SetEnabled(on);
		}
		public void SetChecked(bool b) {
			ProxyQGroupBox().SetChecked(b);
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQGroupBox().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQGroupBox().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQGroupBox().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQGroupBox().TrUtf8(arg1);
		}
		public new bool Event(QEvent arg1) {
			return ProxyQGroupBox().Event(arg1);
		}
		protected new void ChildEvent(QChildEvent arg1) {
			ProxyQGroupBox().ChildEvent(arg1);
		}
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQGroupBox().ResizeEvent(arg1);
		}
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQGroupBox().PaintEvent(arg1);
		}
		protected new void FocusInEvent(QFocusEvent arg1) {
			ProxyQGroupBox().FocusInEvent(arg1);
		}
		protected new void FontChange(QFont arg1) {
			ProxyQGroupBox().FontChange(arg1);
		}
		~QGroupBox() {
			ProxyQGroupBox().Dispose();
		}
		public new void Dispose() {
			ProxyQGroupBox().Dispose();
		}
	}

	public interface IQGroupBoxSignals {
		void Toggled(bool arg1);
	}
}
