//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QDateTimeEditBase")]
	public class QDateTimeEditBase : QWidget {
 		protected QDateTimeEditBase(Type dummy) : base((Type) null) {}
		interface IQDateTimeEditBaseProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQDateTimeEditBaseProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDateTimeEditBase), this);
			_interceptor = (QDateTimeEditBase) realProxy.GetTransparentProxy();
		}
		private QDateTimeEditBase ProxyQDateTimeEditBase() {
			return (QDateTimeEditBase) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDateTimeEditBase() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDateTimeEditBaseProxy), null);
			_staticInterceptor = (IQDateTimeEditBaseProxy) realProxy.GetTransparentProxy();
		}
		private static IQDateTimeEditBaseProxy StaticQDateTimeEditBase() {
			return (IQDateTimeEditBaseProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQDateTimeEditBase().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQDateTimeEditBase().ClassName();
		}
		[SmokeMethod("setFocusSection(int)")]
		public virtual bool SetFocusSection(int sec) {
			return ProxyQDateTimeEditBase().SetFocusSection(sec);
		}
		[SmokeMethod("sectionFormattedText(int)")]
		public virtual string SectionFormattedText(int sec) {
			return ProxyQDateTimeEditBase().SectionFormattedText(sec);
		}
		[SmokeMethod("addNumber(int, int)")]
		public virtual void AddNumber(int sec, int num) {
			ProxyQDateTimeEditBase().AddNumber(sec,num);
		}
		[SmokeMethod("removeLastNumber(int)")]
		public virtual void RemoveLastNumber(int sec) {
			ProxyQDateTimeEditBase().RemoveLastNumber(sec);
		}
		[Q_SLOT("void stepUp()")]
		[SmokeMethod("stepUp()")]
		public virtual void StepUp() {
			ProxyQDateTimeEditBase().StepUp();
		}
		[Q_SLOT("void stepDown()")]
		[SmokeMethod("stepDown()")]
		public virtual void StepDown() {
			ProxyQDateTimeEditBase().StepDown();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQDateTimeEditBase().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQDateTimeEditBase().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQDateTimeEditBase().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQDateTimeEditBase().TrUtf8(arg1);
		}
		protected void CreateQDateTimeEditBaseSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQDateTimeEditBaseSignals), this);
			Q_EMIT = (IQDateTimeEditBaseSignals) realProxy.GetTransparentProxy();
		}
		protected new IQDateTimeEditBaseSignals Emit() {
			return (IQDateTimeEditBaseSignals) Q_EMIT;
		}
	}

	public interface IQDateTimeEditBaseSignals : IQWidgetSignals {
	}
}
