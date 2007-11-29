//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	namespace DOM {

	using System;
	using Qyoto;

	/// <remarks>
	///  Inline subwindows. See the <a
	///  href="http://www.w3.org/TR/REC-html40/present/frames.html#edef-IFRAME">
	///  IFRAME element definition </a> in HTML 4.0.
	///  </remarks>		<short>    Inline subwindows.</short>

	[SmokeClass("DOM::HTMLIFrameElement")]
	public class HTMLIFrameElement : DOM.HTMLElement, IDisposable {
 		protected HTMLIFrameElement(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(HTMLIFrameElement), this);
		}
		// DOM::HTMLIFrameElement* HTMLIFrameElement(DOM::HTMLIFrameElementImpl* arg1); >>>> NOT CONVERTED
		public HTMLIFrameElement() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLIFrameElement", "HTMLIFrameElement()", typeof(void));
		}
		public HTMLIFrameElement(DOM.HTMLIFrameElement other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLIFrameElement#", "HTMLIFrameElement(const DOM::HTMLIFrameElement&)", typeof(void), typeof(DOM.HTMLIFrameElement), other);
		}
		public HTMLIFrameElement(DOM.Node other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLIFrameElement#", "HTMLIFrameElement(const DOM::Node&)", typeof(void), typeof(DOM.Node), other);
		}
		/// <remarks>
		///  Aligns this object (vertically or horizontally) with respect to
		///  its surrounding text. See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/objects.html#adef-align-IMG">
		///  align attribute definition </a> in HTML 4.0. This attribute is
		///  deprecated in HTML 4.0.
		///      </remarks>		<short>    Aligns this object (vertically or horizontally) with respect to  its surrounding text.</short>
		public string Align() {
			return (string) interceptor.Invoke("align", "align() const", typeof(string));
		}
		/// <remarks>
		///  see align
		///      </remarks>		<short>    see align      </short>
		public void SetAlign(string arg1) {
			interceptor.Invoke("setAlign#", "setAlign(const DOM::DOMString&)", typeof(void), typeof(string), arg1);
		}
		/// <remarks>
		///  Request frame borders. See the <a
		///  href="http://www.w3.org/TR/REC-html40/present/frames.html#adef-frameborder">
		///  frameborder attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Request frame borders.</short>
		public string FrameBorder() {
			return (string) interceptor.Invoke("frameBorder", "frameBorder() const", typeof(string));
		}
		/// <remarks>
		///  see frameBorder
		///      </remarks>		<short>    see frameBorder      </short>
		public void SetFrameBorder(string arg1) {
			interceptor.Invoke("setFrameBorder#", "setFrameBorder(const DOM::DOMString&)", typeof(void), typeof(string), arg1);
		}
		/// <remarks>
		///  Frame height. See the <a
		///  href="http://www.w3.org/TR/REC-html40/present/frames.html#adef-height-IFRAME">
		///  height attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Frame height.</short>
		public string Height() {
			return (string) interceptor.Invoke("height", "height() const", typeof(string));
		}
		/// <remarks>
		///  see height
		///      </remarks>		<short>    see height      </short>
		public void SetHeight(string arg1) {
			interceptor.Invoke("setHeight#", "setHeight(const DOM::DOMString&)", typeof(void), typeof(string), arg1);
		}
		/// <remarks>
		///  URI designating a long description of this image or frame. See
		///  the <a
		///  href="http://www.w3.org/TR/REC-html40/present/frames.html#adef-longdesc-IFRAME">
		///  longdesc attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    URI designating a long description of this image or frame.</short>
		public string LongDesc() {
			return (string) interceptor.Invoke("longDesc", "longDesc() const", typeof(string));
		}
		/// <remarks>
		///  see longDesc
		///      </remarks>		<short>    see longDesc      </short>
		public void SetLongDesc(string arg1) {
			interceptor.Invoke("setLongDesc#", "setLongDesc(const DOM::DOMString&)", typeof(void), typeof(string), arg1);
		}
		/// <remarks>
		///  Frame margin height, in pixels. See the <a
		///  href="http://www.w3.org/TR/REC-html40/present/frames.html#adef-marginheight">
		///  marginheight attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Frame margin height, in pixels.</short>
		public string MarginHeight() {
			return (string) interceptor.Invoke("marginHeight", "marginHeight() const", typeof(string));
		}
		/// <remarks>
		///  see marginHeight
		///      </remarks>		<short>    see marginHeight      </short>
		public void SetMarginHeight(string arg1) {
			interceptor.Invoke("setMarginHeight#", "setMarginHeight(const DOM::DOMString&)", typeof(void), typeof(string), arg1);
		}
		/// <remarks>
		///  Frame margin width, in pixels. See the <a
		///  href="http://www.w3.org/TR/REC-html40/present/frames.html#adef-marginwidth">
		///  marginwidth attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Frame margin width, in pixels.</short>
		public string MarginWidth() {
			return (string) interceptor.Invoke("marginWidth", "marginWidth() const", typeof(string));
		}
		/// <remarks>
		///  see marginWidth
		///      </remarks>		<short>    see marginWidth      </short>
		public void SetMarginWidth(string arg1) {
			interceptor.Invoke("setMarginWidth#", "setMarginWidth(const DOM::DOMString&)", typeof(void), typeof(string), arg1);
		}
		/// <remarks>
		///  The frame name (object of the <code>target</code> attribute).
		///  See the <a
		///  href="http://www.w3.org/TR/REC-html40/present/frames.html#adef-name-IFRAME">
		///  name attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    The frame name (object of the <code>target</code> attribute).</short>
		public string Name() {
			return (string) interceptor.Invoke("name", "name() const", typeof(string));
		}
		/// <remarks>
		///  see name
		///      </remarks>		<short>    see name      </short>
		public void SetName(string arg1) {
			interceptor.Invoke("setName#", "setName(const DOM::DOMString&)", typeof(void), typeof(string), arg1);
		}
		/// <remarks>
		///  Specify whether or not the frame should have scrollbars. See
		///  the <a
		///  href="http://www.w3.org/TR/REC-html40/present/frames.html#adef-scrolling">
		///  scrolling attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Specify whether or not the frame should have scrollbars.</short>
		public string Scrolling() {
			return (string) interceptor.Invoke("scrolling", "scrolling() const", typeof(string));
		}
		/// <remarks>
		///  see scrolling
		///      </remarks>		<short>    see scrolling      </short>
		public void SetScrolling(string arg1) {
			interceptor.Invoke("setScrolling#", "setScrolling(const DOM::DOMString&)", typeof(void), typeof(string), arg1);
		}
		/// <remarks>
		///  A URI designating the initial frame contents. See the <a
		///  href="http://www.w3.org/TR/REC-html40/present/frames.html#adef-src-FRAME">
		///  src attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    A URI designating the initial frame contents.</short>
		public string Src() {
			return (string) interceptor.Invoke("src", "src() const", typeof(string));
		}
		/// <remarks>
		///  see src
		///      </remarks>		<short>    see src      </short>
		public void SetSrc(string arg1) {
			interceptor.Invoke("setSrc#", "setSrc(const DOM::DOMString&)", typeof(void), typeof(string), arg1);
		}
		/// <remarks>
		///  Frame width. See the <a
		///  href="http://www.w3.org/TR/REC-html40/present/frames.html#adef-width-IFRAME">
		///  width attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Frame width.</short>
		public string Width() {
			return (string) interceptor.Invoke("width", "width() const", typeof(string));
		}
		/// <remarks>
		///  see width
		///      </remarks>		<short>    see width      </short>
		public void SetWidth(string arg1) {
			interceptor.Invoke("setWidth#", "setWidth(const DOM::DOMString&)", typeof(void), typeof(string), arg1);
		}
		/// <remarks>
		///  Introduced in DOM Level 2
		///  Returns the document this iframe contains, if there is any and
		///  it is available, a Null document otherwise. The attribute is
		///  read-only.
		/// </remarks>		<return> The content Document if available.
		///      </return>
		/// 		<short>    Introduced in DOM Level 2 </short>
		public DOM.Document ContentDocument() {
			return (DOM.Document) interceptor.Invoke("contentDocument", "contentDocument() const", typeof(DOM.Document));
		}
		~HTMLIFrameElement() {
			interceptor.Invoke("~HTMLIFrameElement", "~HTMLIFrameElement()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~HTMLIFrameElement", "~HTMLIFrameElement()", typeof(void));
		}
	}
	}
}