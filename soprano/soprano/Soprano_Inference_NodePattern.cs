//Auto-generated by kalyptus. DO NOT EDIT.
namespace Soprano.Inference {
	using Soprano;
	using System;
	using Qyoto;
	/// <remarks>
	///  \class NodePattern nodepattern.h Soprano/Inference/NodePattern
	///  \brief Smallest building block of an inference Rule.
	///  There are two types of NodePattern:
	///  <li>Simple</li> nodes that wrap around an instance or Node
	///      and only match against that particular node.
	///  <li>Variable</li> nodes that match against every Node and
	///      have a name.
	///  \author Sebastian Trueg <trueg@kde.org>
	///          </remarks>		<short>    \class NodePattern nodepattern.</short>
	[SmokeClass("Soprano::Inference::NodePattern")]
	public class NodePattern : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected NodePattern(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(NodePattern), this);
		}
		public NodePattern() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("NodePattern", "NodePattern()", typeof(void));
		}
		public NodePattern(Soprano.Node arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("NodePattern#", "NodePattern(const Soprano::Node&)", typeof(void), typeof(Soprano.Node), arg1);
		}
		public NodePattern(string varname) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("NodePattern$", "NodePattern(const QString&)", typeof(void), typeof(string), varname);
		}
		public NodePattern(Soprano.Inference.NodePattern arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("NodePattern#", "NodePattern(const Soprano::Inference::NodePattern&)", typeof(void), typeof(Soprano.Inference.NodePattern), arg1);
		}
		public bool IsVariable() {
			return (bool) interceptor.Invoke("isVariable", "isVariable() const", typeof(bool));
		}
		/// <remarks>
		///  \returns the associated resource of an invalid Node
		///  if this is a variable.
		///              </remarks>		<short>    \returns the associated resource of an invalid Node  if this is a variable.</short>
		public Soprano.Node Resource() {
			return (Soprano.Node) interceptor.Invoke("resource", "resource() const", typeof(Soprano.Node));
		}
		/// <remarks>
		///  \returns The name of the variable or an empty string
		///  if this is not a variable.
		///              </remarks>		<short>    \returns The name of the variable or an empty string  if this is not a variable.</short>
		public string VariableName() {
			return (string) interceptor.Invoke("variableName", "variableName() const", typeof(string));
		}
		/// <remarks>
		///  Match a Node against this pattern.
		///  Variables will match any Node while
		///  specific %node patterns will only match
		///  that one particular Node.
		///  \return true if node mathes this pattern.
		///              </remarks>		<short>    Match a Node against this pattern.</short>
		public bool Match(Soprano.Node node) {
			return (bool) interceptor.Invoke("match#", "match(const Soprano::Node&) const", typeof(bool), typeof(Soprano.Node), node);
		}
		public string CreateSparqlNodePattern(Soprano.BindingSet bindings) {
			return (string) interceptor.Invoke("createSparqlNodePattern#", "createSparqlNodePattern(const Soprano::BindingSet&) const", typeof(string), typeof(Soprano.BindingSet), bindings);
		}
		~NodePattern() {
			interceptor.Invoke("~NodePattern", "~NodePattern()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~NodePattern", "~NodePattern()", typeof(void));
		}
	}
}