//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QGradient : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QGradient(Type dummy) {}
		interface IQGradientProxy {
			bool op_equals(QGradient lhs, QGradient gradient);
		}

		protected void CreateQGradientProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGradient), this);
			_interceptor = (QGradient) realProxy.GetTransparentProxy();
		}
		private QGradient ProxyQGradient() {
			return (QGradient) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGradient() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGradientProxy), null);
			_staticInterceptor = (IQGradientProxy) realProxy.GetTransparentProxy();
		}
		private static IQGradientProxy StaticQGradient() {
			return (IQGradientProxy) _staticInterceptor;
		}

		enum E_Type {
			LinearGradient = 0,
			RadialGradient = 1,
			ConicalGradient = 2,
		}
		enum E_Spread {
			PadSpread = 0,
			ReflectSpread = 1,
			RepeatSpread = 2,
		}
		public QGradient() : this((Type) null) {
			CreateQGradientProxy();
			NewQGradient();
		}
		private void NewQGradient() {
			ProxyQGradient().NewQGradient();
		}
		public void SetSpread(int spread) {
			ProxyQGradient().SetSpread(spread);
		}
		public int Spread() {
			return ProxyQGradient().Spread();
		}
		// void setColorAt(qreal arg1,const QColor& arg2); >>>> NOT CONVERTED
		// void setStops(const QGradientStops& arg1); >>>> NOT CONVERTED
		// QGradientStops stops(); >>>> NOT CONVERTED
		public static bool operator==(QGradient lhs, QGradient gradient) {
			return StaticQGradient().op_equals(lhs,gradient);
		}
		public static bool operator!=(QGradient lhs, QGradient gradient) {
			return !StaticQGradient().op_equals(lhs,gradient);
		}
		public override bool Equals(object o) {
			if (!(o is QGradient)) { return false; }
			return this == (QGradient) o;
		}
		public override int GetHashCode() {
			return ProxyQGradient().GetHashCode();
		}
		~QGradient() {
			ProxyQGradient().Dispose();
		}
		public void Dispose() {
			ProxyQGradient().Dispose();
		}
	}
}
