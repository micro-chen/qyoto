//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QInputDialog : QDialog {
 		protected QInputDialog(Type dummy) : base((Type) null) {}
		interface IQInputDialogProxy {
			string Tr(string s, string c);
			string Tr(string s);
			string GetText(QWidget parent, string title, string label, int echo, string text, out bool ok, int f);
			string GetText(QWidget parent, string title, string label, int echo, string text, out bool ok);
			string GetText(QWidget parent, string title, string label, int echo, string text);
			string GetText(QWidget parent, string title, string label, int echo);
			string GetText(QWidget parent, string title, string label);
			int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step, out bool ok, int f);
			int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step, out bool ok);
			int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step);
			int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue);
			int GetInteger(QWidget parent, string title, string label, int value, int minValue);
			int GetInteger(QWidget parent, string title, string label, int value);
			int GetInteger(QWidget parent, string title, string label);
			double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals, out bool ok, int f);
			double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals, out bool ok);
			double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals);
			double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue);
			double GetDouble(QWidget parent, string title, string label, double value, double minValue);
			double GetDouble(QWidget parent, string title, string label, double value);
			double GetDouble(QWidget parent, string title, string label);
			string GetItem(QWidget parent, string title, string label, string[] list, int current, bool editable, out bool ok, int f);
			string GetItem(QWidget parent, string title, string label, string[] list, int current, bool editable, out bool ok);
			string GetItem(QWidget parent, string title, string label, string[] list, int current, bool editable);
			string GetItem(QWidget parent, string title, string label, string[] list, int current);
			string GetItem(QWidget parent, string title, string label, string[] list);
		}

		protected void CreateQInputDialogProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QInputDialog), this);
			_interceptor = (QInputDialog) realProxy.GetTransparentProxy();
		}
		private QInputDialog ProxyQInputDialog() {
			return (QInputDialog) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QInputDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQInputDialogProxy), null);
			_staticInterceptor = (IQInputDialogProxy) realProxy.GetTransparentProxy();
		}
		private static IQInputDialogProxy StaticQInputDialog() {
			return (IQInputDialogProxy) _staticInterceptor;
		}

		public new virtual QMetaObject MetaObject() {
			return ProxyQInputDialog().MetaObject();
		}
		// void* qt_metacast(const char* arg1); >>>> NOT CONVERTED
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public static new string Tr(string s, string c) {
			return StaticQInputDialog().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQInputDialog().Tr(s);
		}
		public static string GetText(QWidget parent, string title, string label, int echo, string text, out bool ok, int f) {
			return StaticQInputDialog().GetText(parent,title,label,echo,text,out ok,f);
		}
		public static string GetText(QWidget parent, string title, string label, int echo, string text, out bool ok) {
			return StaticQInputDialog().GetText(parent,title,label,echo,text,out ok);
		}
		public static string GetText(QWidget parent, string title, string label, int echo, string text) {
			return StaticQInputDialog().GetText(parent,title,label,echo,text);
		}
		public static string GetText(QWidget parent, string title, string label, int echo) {
			return StaticQInputDialog().GetText(parent,title,label,echo);
		}
		public static string GetText(QWidget parent, string title, string label) {
			return StaticQInputDialog().GetText(parent,title,label);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step, out bool ok, int f) {
			return StaticQInputDialog().GetInteger(parent,title,label,value,minValue,maxValue,step,out ok,f);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step, out bool ok) {
			return StaticQInputDialog().GetInteger(parent,title,label,value,minValue,maxValue,step,out ok);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step) {
			return StaticQInputDialog().GetInteger(parent,title,label,value,minValue,maxValue,step);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue) {
			return StaticQInputDialog().GetInteger(parent,title,label,value,minValue,maxValue);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value, int minValue) {
			return StaticQInputDialog().GetInteger(parent,title,label,value,minValue);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value) {
			return StaticQInputDialog().GetInteger(parent,title,label,value);
		}
		public static int GetInteger(QWidget parent, string title, string label) {
			return StaticQInputDialog().GetInteger(parent,title,label);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals, out bool ok, int f) {
			return StaticQInputDialog().GetDouble(parent,title,label,value,minValue,maxValue,decimals,out ok,f);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals, out bool ok) {
			return StaticQInputDialog().GetDouble(parent,title,label,value,minValue,maxValue,decimals,out ok);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals) {
			return StaticQInputDialog().GetDouble(parent,title,label,value,minValue,maxValue,decimals);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue) {
			return StaticQInputDialog().GetDouble(parent,title,label,value,minValue,maxValue);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value, double minValue) {
			return StaticQInputDialog().GetDouble(parent,title,label,value,minValue);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value) {
			return StaticQInputDialog().GetDouble(parent,title,label,value);
		}
		public static double GetDouble(QWidget parent, string title, string label) {
			return StaticQInputDialog().GetDouble(parent,title,label);
		}
		public static string GetItem(QWidget parent, string title, string label, string[] list, int current, bool editable, out bool ok, int f) {
			return StaticQInputDialog().GetItem(parent,title,label,list,current,editable,out ok,f);
		}
		public static string GetItem(QWidget parent, string title, string label, string[] list, int current, bool editable, out bool ok) {
			return StaticQInputDialog().GetItem(parent,title,label,list,current,editable,out ok);
		}
		public static string GetItem(QWidget parent, string title, string label, string[] list, int current, bool editable) {
			return StaticQInputDialog().GetItem(parent,title,label,list,current,editable);
		}
		public static string GetItem(QWidget parent, string title, string label, string[] list, int current) {
			return StaticQInputDialog().GetItem(parent,title,label,list,current);
		}
		public static string GetItem(QWidget parent, string title, string label, string[] list) {
			return StaticQInputDialog().GetItem(parent,title,label,list);
		}
	}
}
