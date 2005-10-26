//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	public class QDomDocument : QDomNode, IDisposable {
 		protected QDomDocument(Type dummy) : base((Type) null) {}
		interface IQDomDocumentProxy {
		}

		protected void CreateQDomDocumentProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomDocument), this);
			_interceptor = (QDomDocument) realProxy.GetTransparentProxy();
		}
		private QDomDocument ProxyQDomDocument() {
			return (QDomDocument) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomDocument() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomDocumentProxy), null);
			_staticInterceptor = (IQDomDocumentProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomDocumentProxy StaticQDomDocument() {
			return (IQDomDocumentProxy) _staticInterceptor;
		}

		public QDomDocument() : this((Type) null) {
			CreateQDomDocumentProxy();
			NewQDomDocument();
		}
		private void NewQDomDocument() {
			ProxyQDomDocument().NewQDomDocument();
		}
		public QDomDocument(string name) : this((Type) null) {
			CreateQDomDocumentProxy();
			NewQDomDocument(name);
		}
		private void NewQDomDocument(string name) {
			ProxyQDomDocument().NewQDomDocument(name);
		}
		public QDomDocument(QDomDocumentType doctype) : this((Type) null) {
			CreateQDomDocumentProxy();
			NewQDomDocument(doctype);
		}
		private void NewQDomDocument(QDomDocumentType doctype) {
			ProxyQDomDocument().NewQDomDocument(doctype);
		}
		public QDomDocument(QDomDocument x) : this((Type) null) {
			CreateQDomDocumentProxy();
			NewQDomDocument(x);
		}
		private void NewQDomDocument(QDomDocument x) {
			ProxyQDomDocument().NewQDomDocument(x);
		}
		public QDomElement CreateElement(string tagName) {
			return ProxyQDomDocument().CreateElement(tagName);
		}
		public QDomDocumentFragment CreateDocumentFragment() {
			return ProxyQDomDocument().CreateDocumentFragment();
		}
		public QDomText CreateTextNode(string data) {
			return ProxyQDomDocument().CreateTextNode(data);
		}
		public QDomComment CreateComment(string data) {
			return ProxyQDomDocument().CreateComment(data);
		}
		public QDomCDATASection CreateCDATASection(string data) {
			return ProxyQDomDocument().CreateCDATASection(data);
		}
		public QDomProcessingInstruction CreateProcessingInstruction(string target, string data) {
			return ProxyQDomDocument().CreateProcessingInstruction(target,data);
		}
		public QDomAttr CreateAttribute(string name) {
			return ProxyQDomDocument().CreateAttribute(name);
		}
		public QDomEntityReference CreateEntityReference(string name) {
			return ProxyQDomDocument().CreateEntityReference(name);
		}
		public ArrayList ElementsByTagName(string tagname) {
			return ProxyQDomDocument().ElementsByTagName(tagname);
		}
		public QDomNode ImportNode(QDomNode importedNode, bool deep) {
			return ProxyQDomDocument().ImportNode(importedNode,deep);
		}
		public QDomElement CreateElementNS(string nsURI, string qName) {
			return ProxyQDomDocument().CreateElementNS(nsURI,qName);
		}
		public QDomAttr CreateAttributeNS(string nsURI, string qName) {
			return ProxyQDomDocument().CreateAttributeNS(nsURI,qName);
		}
		public ArrayList ElementsByTagNameNS(string nsURI, string localName) {
			return ProxyQDomDocument().ElementsByTagNameNS(nsURI,localName);
		}
		public QDomElement ElementById(string elementId) {
			return ProxyQDomDocument().ElementById(elementId);
		}
		public QDomDocumentType Doctype() {
			return ProxyQDomDocument().Doctype();
		}
		public QDomImplementation Implementation() {
			return ProxyQDomDocument().Implementation();
		}
		public QDomElement DocumentElement() {
			return ProxyQDomDocument().DocumentElement();
		}
		public new int NodeType() {
			return ProxyQDomDocument().NodeType();
		}
		public bool SetContent(byte[] text, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ProxyQDomDocument().SetContent(text,namespaceProcessing,errorMsg,out errorLine,out errorColumn);
		}
		public bool SetContent(byte[] text, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine) {
			return ProxyQDomDocument().SetContent(text,namespaceProcessing,errorMsg,out errorLine);
		}
		public bool SetContent(byte[] text, bool namespaceProcessing, StringBuilder errorMsg) {
			return ProxyQDomDocument().SetContent(text,namespaceProcessing,errorMsg);
		}
		public bool SetContent(byte[] text, bool namespaceProcessing) {
			return ProxyQDomDocument().SetContent(text,namespaceProcessing);
		}
		public bool SetContent(string text, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ProxyQDomDocument().SetContent(text,namespaceProcessing,errorMsg,out errorLine,out errorColumn);
		}
		public bool SetContent(string text, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine) {
			return ProxyQDomDocument().SetContent(text,namespaceProcessing,errorMsg,out errorLine);
		}
		public bool SetContent(string text, bool namespaceProcessing, StringBuilder errorMsg) {
			return ProxyQDomDocument().SetContent(text,namespaceProcessing,errorMsg);
		}
		public bool SetContent(string text, bool namespaceProcessing) {
			return ProxyQDomDocument().SetContent(text,namespaceProcessing);
		}
		public bool SetContent(IQIODevice dev, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ProxyQDomDocument().SetContent(dev,namespaceProcessing,errorMsg,out errorLine,out errorColumn);
		}
		public bool SetContent(IQIODevice dev, bool namespaceProcessing, StringBuilder errorMsg, out int errorLine) {
			return ProxyQDomDocument().SetContent(dev,namespaceProcessing,errorMsg,out errorLine);
		}
		public bool SetContent(IQIODevice dev, bool namespaceProcessing, StringBuilder errorMsg) {
			return ProxyQDomDocument().SetContent(dev,namespaceProcessing,errorMsg);
		}
		public bool SetContent(IQIODevice dev, bool namespaceProcessing) {
			return ProxyQDomDocument().SetContent(dev,namespaceProcessing);
		}
		public bool SetContent(byte[] text, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ProxyQDomDocument().SetContent(text,errorMsg,out errorLine,out errorColumn);
		}
		public bool SetContent(byte[] text, StringBuilder errorMsg, out int errorLine) {
			return ProxyQDomDocument().SetContent(text,errorMsg,out errorLine);
		}
		public bool SetContent(byte[] text, StringBuilder errorMsg) {
			return ProxyQDomDocument().SetContent(text,errorMsg);
		}
		public bool SetContent(byte[] text) {
			return ProxyQDomDocument().SetContent(text);
		}
		public bool SetContent(string text, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ProxyQDomDocument().SetContent(text,errorMsg,out errorLine,out errorColumn);
		}
		public bool SetContent(string text, StringBuilder errorMsg, out int errorLine) {
			return ProxyQDomDocument().SetContent(text,errorMsg,out errorLine);
		}
		public bool SetContent(string text, StringBuilder errorMsg) {
			return ProxyQDomDocument().SetContent(text,errorMsg);
		}
		public bool SetContent(string text) {
			return ProxyQDomDocument().SetContent(text);
		}
		public bool SetContent(IQIODevice dev, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ProxyQDomDocument().SetContent(dev,errorMsg,out errorLine,out errorColumn);
		}
		public bool SetContent(IQIODevice dev, StringBuilder errorMsg, out int errorLine) {
			return ProxyQDomDocument().SetContent(dev,errorMsg,out errorLine);
		}
		public bool SetContent(IQIODevice dev, StringBuilder errorMsg) {
			return ProxyQDomDocument().SetContent(dev,errorMsg);
		}
		public bool SetContent(IQIODevice dev) {
			return ProxyQDomDocument().SetContent(dev);
		}
		public bool SetContent(QXmlInputSource source, QXmlReader reader, StringBuilder errorMsg, out int errorLine, out int errorColumn) {
			return ProxyQDomDocument().SetContent(source,reader,errorMsg,out errorLine,out errorColumn);
		}
		public bool SetContent(QXmlInputSource source, QXmlReader reader, StringBuilder errorMsg, out int errorLine) {
			return ProxyQDomDocument().SetContent(source,reader,errorMsg,out errorLine);
		}
		public bool SetContent(QXmlInputSource source, QXmlReader reader, StringBuilder errorMsg) {
			return ProxyQDomDocument().SetContent(source,reader,errorMsg);
		}
		public bool SetContent(QXmlInputSource source, QXmlReader reader) {
			return ProxyQDomDocument().SetContent(source,reader);
		}
		public new string ToString(int arg1) {
			return ProxyQDomDocument().ToString(arg1);
		}
		public new string ToString() {
			return ProxyQDomDocument().ToString();
		}
		public byte[] ToByteArray(int arg1) {
			return ProxyQDomDocument().ToByteArray(arg1);
		}
		public byte[] ToByteArray() {
			return ProxyQDomDocument().ToByteArray();
		}
		~QDomDocument() {
			ProxyQDomDocument().Dispose();
		}
		public void Dispose() {
			ProxyQDomDocument().Dispose();
		}
	}
}
