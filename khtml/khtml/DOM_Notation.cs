//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  This interface represents a notation declared in the DTD. A
	///  notation either declares, by name, the format of an unparsed entity
	///  (see section 4.7 of the XML 1.0 specification), or is used for
	///  formal declaration of Processing Instruction targets (see section
	///  2.6 of the XML 1.0 specification). The <code>nodeName</code>
	///  attribute inherited from <code>Node</code> is set to the declared
	///  name of the notation.
	///   The DOM Level 1 does not support editing <code>Notation</code>
	///  nodes; they are therefore readonly.
	///   A <code>Notation</code> node does not have any parent.
	///  </remarks>		<short>    This interface represents a notation declared in the DTD.</short>
	[SmokeClass("DOM::Notation")]
	public class Notation : DOM.Node, IDisposable {
 		protected Notation(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(Notation), this);
		}
		// DOM::Notation* Notation(DOM::NotationImpl* arg1); >>>> NOT CONVERTED
		public Notation() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Notation", "Notation()", typeof(void));
		}
		public Notation(DOM.Notation other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Notation#", "Notation(const DOM::Notation&)", typeof(void), typeof(DOM.Notation), other);
		}
		public Notation(DOM.Node other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Notation#", "Notation(const DOM::Node&)", typeof(void), typeof(DOM.Node), other);
		}
		/// <remarks>
		///  The public identifier of this notation. If the public
		///  identifier was not specified, this is <code>null</code> .
		///      </remarks>		<short>    The public identifier of this notation.</short>
		public DOM.DOMString PublicId() {
			return (DOM.DOMString) interceptor.Invoke("publicId", "publicId() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  The system identifier of this notation. If the system
		///  identifier was not specified, this is <code>null</code> .
		///      </remarks>		<short>    The system identifier of this notation.</short>
		public DOM.DOMString SystemId() {
			return (DOM.DOMString) interceptor.Invoke("systemId", "systemId() const", typeof(DOM.DOMString));
		}
		~Notation() {
			interceptor.Invoke("~Notation", "~Notation()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~Notation", "~Notation()", typeof(void));
		}
	}
}