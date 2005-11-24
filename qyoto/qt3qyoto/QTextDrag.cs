//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QTextDrag : QDragObject, IDisposable {
 		protected QTextDrag(Type dummy) : base((Type) null) {}
		interface IQTextDragProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
			bool CanDecode(IQMimeSource e);
			bool Decode(IQMimeSource e, StringBuilder s);
			bool Decode(IQMimeSource e, StringBuilder s, StringBuilder subtype);
		}

		protected void CreateQTextDragProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextDrag), this);
			_interceptor = (QTextDrag) realProxy.GetTransparentProxy();
		}
		private QTextDrag ProxyQTextDrag() {
			return (QTextDrag) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextDrag() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextDragProxy), null);
			_staticInterceptor = (IQTextDragProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextDragProxy StaticQTextDrag() {
			return (IQTextDragProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQTextDrag().MetaObject();
		}
		public new virtual string ClassName() {
			return ProxyQTextDrag().ClassName();
		}
		public QTextDrag(string arg1, QWidget dragSource, string name) : this((Type) null) {
			CreateQTextDragProxy();
			NewQTextDrag(arg1,dragSource,name);
		}
		private void NewQTextDrag(string arg1, QWidget dragSource, string name) {
			ProxyQTextDrag().NewQTextDrag(arg1,dragSource,name);
		}
		public QTextDrag(string arg1, QWidget dragSource) : this((Type) null) {
			CreateQTextDragProxy();
			NewQTextDrag(arg1,dragSource);
		}
		private void NewQTextDrag(string arg1, QWidget dragSource) {
			ProxyQTextDrag().NewQTextDrag(arg1,dragSource);
		}
		public QTextDrag(string arg1) : this((Type) null) {
			CreateQTextDragProxy();
			NewQTextDrag(arg1);
		}
		private void NewQTextDrag(string arg1) {
			ProxyQTextDrag().NewQTextDrag(arg1);
		}
		public QTextDrag(QWidget dragSource, string name) : this((Type) null) {
			CreateQTextDragProxy();
			NewQTextDrag(dragSource,name);
		}
		private void NewQTextDrag(QWidget dragSource, string name) {
			ProxyQTextDrag().NewQTextDrag(dragSource,name);
		}
		public QTextDrag(QWidget dragSource) : this((Type) null) {
			CreateQTextDragProxy();
			NewQTextDrag(dragSource);
		}
		private void NewQTextDrag(QWidget dragSource) {
			ProxyQTextDrag().NewQTextDrag(dragSource);
		}
		public QTextDrag() : this((Type) null) {
			CreateQTextDragProxy();
			NewQTextDrag();
		}
		private void NewQTextDrag() {
			ProxyQTextDrag().NewQTextDrag();
		}
		public virtual void SetText(string arg1) {
			ProxyQTextDrag().SetText(arg1);
		}
		public virtual void SetSubtype(string arg1) {
			ProxyQTextDrag().SetSubtype(arg1);
		}
		public new string Format(int i) {
			return ProxyQTextDrag().Format(i);
		}
		public new virtual byte[] EncodedData(string arg1) {
			return ProxyQTextDrag().EncodedData(arg1);
		}
		public static new string Tr(string arg1, string arg2) {
			return StaticQTextDrag().Tr(arg1,arg2);
		}
		public static new string Tr(string arg1) {
			return StaticQTextDrag().Tr(arg1);
		}
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQTextDrag().TrUtf8(arg1,arg2);
		}
		public static new string TrUtf8(string arg1) {
			return StaticQTextDrag().TrUtf8(arg1);
		}
		public static bool CanDecode(IQMimeSource e) {
			return StaticQTextDrag().CanDecode(e);
		}
		public static bool Decode(IQMimeSource e, StringBuilder s) {
			return StaticQTextDrag().Decode(e,s);
		}
		public static bool Decode(IQMimeSource e, StringBuilder s, StringBuilder subtype) {
			return StaticQTextDrag().Decode(e,s,subtype);
		}
		~QTextDrag() {
			ProxyQTextDrag().Dispose();
		}
		public new void Dispose() {
			ProxyQTextDrag().Dispose();
		}
	}
}
