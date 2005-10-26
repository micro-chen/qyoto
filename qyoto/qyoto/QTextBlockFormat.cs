//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QTextBlockFormat : QTextFormat, IDisposable {
 		protected QTextBlockFormat(Type dummy) : base((Type) null) {}
		interface IQTextBlockFormatProxy {
		}

		protected void CreateQTextBlockFormatProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextBlockFormat), this);
			_interceptor = (QTextBlockFormat) realProxy.GetTransparentProxy();
		}
		private QTextBlockFormat ProxyQTextBlockFormat() {
			return (QTextBlockFormat) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextBlockFormat() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextBlockFormatProxy), null);
			_staticInterceptor = (IQTextBlockFormatProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextBlockFormatProxy StaticQTextBlockFormat() {
			return (IQTextBlockFormatProxy) _staticInterceptor;
		}

		public QTextBlockFormat() : this((Type) null) {
			CreateQTextBlockFormatProxy();
			NewQTextBlockFormat();
		}
		private void NewQTextBlockFormat() {
			ProxyQTextBlockFormat().NewQTextBlockFormat();
		}
		public new bool IsValid() {
			return ProxyQTextBlockFormat().IsValid();
		}
		public void SetAlignment(int alignment) {
			ProxyQTextBlockFormat().SetAlignment(alignment);
		}
		public int Alignment() {
			return ProxyQTextBlockFormat().Alignment();
		}
		// void setTopMargin(qreal arg1); >>>> NOT CONVERTED
		// qreal topMargin(); >>>> NOT CONVERTED
		// void setBottomMargin(qreal arg1); >>>> NOT CONVERTED
		// qreal bottomMargin(); >>>> NOT CONVERTED
		// void setLeftMargin(qreal arg1); >>>> NOT CONVERTED
		// qreal leftMargin(); >>>> NOT CONVERTED
		// void setRightMargin(qreal arg1); >>>> NOT CONVERTED
		// qreal rightMargin(); >>>> NOT CONVERTED
		// void setTextIndent(qreal arg1); >>>> NOT CONVERTED
		// qreal textIndent(); >>>> NOT CONVERTED
		public void SetIndent(int indent) {
			ProxyQTextBlockFormat().SetIndent(indent);
		}
		public int Indent() {
			return ProxyQTextBlockFormat().Indent();
		}
		public void SetNonBreakableLines(bool b) {
			ProxyQTextBlockFormat().SetNonBreakableLines(b);
		}
		public bool NonBreakableLines() {
			return ProxyQTextBlockFormat().NonBreakableLines();
		}
		~QTextBlockFormat() {
			ProxyQTextBlockFormat().Dispose();
		}
		public void Dispose() {
			ProxyQTextBlockFormat().Dispose();
		}
	}
}
