//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QDomCharacterData : QDomNode, IDisposable {
 		protected QDomCharacterData(Type dummy) : base((Type) null) {}
		interface IQDomCharacterDataProxy {
		}

		protected void CreateQDomCharacterDataProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomCharacterData), this);
			_interceptor = (QDomCharacterData) realProxy.GetTransparentProxy();
		}
		private QDomCharacterData ProxyQDomCharacterData() {
			return (QDomCharacterData) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomCharacterData() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomCharacterDataProxy), null);
			_staticInterceptor = (IQDomCharacterDataProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomCharacterDataProxy StaticQDomCharacterData() {
			return (IQDomCharacterDataProxy) _staticInterceptor;
		}

		public QDomCharacterData() : this((Type) null) {
			CreateQDomCharacterDataProxy();
			NewQDomCharacterData();
		}
		private void NewQDomCharacterData() {
			ProxyQDomCharacterData().NewQDomCharacterData();
		}
		public QDomCharacterData(QDomCharacterData x) : this((Type) null) {
			CreateQDomCharacterDataProxy();
			NewQDomCharacterData(x);
		}
		private void NewQDomCharacterData(QDomCharacterData x) {
			ProxyQDomCharacterData().NewQDomCharacterData(x);
		}
		public virtual string SubstringData(ulong offset, ulong count) {
			return ProxyQDomCharacterData().SubstringData(offset,count);
		}
		public virtual void AppendData(string arg) {
			ProxyQDomCharacterData().AppendData(arg);
		}
		public virtual void InsertData(ulong offset, string arg) {
			ProxyQDomCharacterData().InsertData(offset,arg);
		}
		public virtual void DeleteData(ulong offset, ulong count) {
			ProxyQDomCharacterData().DeleteData(offset,count);
		}
		public virtual void ReplaceData(ulong offset, ulong count, string arg) {
			ProxyQDomCharacterData().ReplaceData(offset,count,arg);
		}
		public virtual uint Length() {
			return ProxyQDomCharacterData().Length();
		}
		public virtual string Data() {
			return ProxyQDomCharacterData().Data();
		}
		public virtual void SetData(string arg1) {
			ProxyQDomCharacterData().SetData(arg1);
		}
		public new int NodeType() {
			return ProxyQDomCharacterData().NodeType();
		}
		public new bool IsCharacterData() {
			return ProxyQDomCharacterData().IsCharacterData();
		}
		~QDomCharacterData() {
			ProxyQDomCharacterData().Dispose();
		}
		public new void Dispose() {
			ProxyQDomCharacterData().Dispose();
		}
	}
}
