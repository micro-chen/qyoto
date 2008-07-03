//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  The document title. See the <a
	///  href="http://www.w3.org/TR/REC-html40/struct/global.html#edef-TITLE">
	///  TITLE element definition </a> in HTML 4.0.
	///  </remarks>		<short>    The document title.</short>
	[SmokeClass("DOM::HTMLTitleElement")]
	public class HTMLTitleElement : DOM.HTMLElement, IDisposable {
 		protected HTMLTitleElement(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(HTMLTitleElement), this);
		}
		// DOM::HTMLTitleElement* HTMLTitleElement(DOM::HTMLTitleElementImpl* arg1); >>>> NOT CONVERTED
		public HTMLTitleElement() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLTitleElement", "HTMLTitleElement()", typeof(void));
		}
		public HTMLTitleElement(DOM.HTMLTitleElement other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLTitleElement#", "HTMLTitleElement(const DOM::HTMLTitleElement&)", typeof(void), typeof(DOM.HTMLTitleElement), other);
		}
		public HTMLTitleElement(DOM.Node other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLTitleElement#", "HTMLTitleElement(const DOM::Node&)", typeof(void), typeof(DOM.Node), other);
		}
		/// <remarks>
		///  The specified title as a string.
		///      </remarks>		<short>    The specified title as a string.</short>
		public DOM.DOMString Text() {
			return (DOM.DOMString) interceptor.Invoke("text", "text() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see text
		///      </remarks>		<short>    see text      </short>
		public void SetText(DOM.DOMString arg1) {
			interceptor.Invoke("setText#", "setText(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		~HTMLTitleElement() {
			interceptor.Invoke("~HTMLTitleElement", "~HTMLTitleElement()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~HTMLTitleElement", "~HTMLTitleElement()", typeof(void));
		}
	}
}