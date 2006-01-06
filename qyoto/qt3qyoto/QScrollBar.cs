//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQScrollBarSignals"></see> for signals emitted by QScrollBar
	[SmokeClass("QScrollBar")]
	public class QScrollBar : QWidget, IQRangeControl, IDisposable {
 		protected QScrollBar(Type dummy) : base((Type) null) {}
		interface IQScrollBarProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQScrollBarProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QScrollBar), this);
			_interceptor = (QScrollBar) realProxy.GetTransparentProxy();
		}
		private QScrollBar ProxyQScrollBar() {
			return (QScrollBar) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QScrollBar() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQScrollBarProxy), null);
			_staticInterceptor = (IQScrollBarProxy) realProxy.GetTransparentProxy();
		}
		private static IQScrollBarProxy StaticQScrollBar() {
			return (IQScrollBarProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQScrollBar().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQScrollBar().ClassName();
		}
		public QScrollBar(QWidget parent, string name) : this((Type) null) {
			CreateQScrollBarProxy();
			CreateQScrollBarSignalProxy();
			NewQScrollBar(parent,name);
		}
		[SmokeMethod("QScrollBar(QWidget*, const char*)")]
		private void NewQScrollBar(QWidget parent, string name) {
			ProxyQScrollBar().NewQScrollBar(parent,name);
		}
		public QScrollBar(QWidget parent) : this((Type) null) {
			CreateQScrollBarProxy();
			CreateQScrollBarSignalProxy();
			NewQScrollBar(parent);
		}
		[SmokeMethod("QScrollBar(QWidget*)")]
		private void NewQScrollBar(QWidget parent) {
			ProxyQScrollBar().NewQScrollBar(parent);
		}
		public QScrollBar(int arg1, QWidget parent, string name) : this((Type) null) {
			CreateQScrollBarProxy();
			CreateQScrollBarSignalProxy();
			NewQScrollBar(arg1,parent,name);
		}
		[SmokeMethod("QScrollBar(Qt::Orientation, QWidget*, const char*)")]
		private void NewQScrollBar(int arg1, QWidget parent, string name) {
			ProxyQScrollBar().NewQScrollBar(arg1,parent,name);
		}
		public QScrollBar(int arg1, QWidget parent) : this((Type) null) {
			CreateQScrollBarProxy();
			CreateQScrollBarSignalProxy();
			NewQScrollBar(arg1,parent);
		}
		[SmokeMethod("QScrollBar(Qt::Orientation, QWidget*)")]
		private void NewQScrollBar(int arg1, QWidget parent) {
			ProxyQScrollBar().NewQScrollBar(arg1,parent);
		}
		public QScrollBar(int minValue, int maxValue, int lineStep, int pageStep, int value, int arg6, QWidget parent, string name) : this((Type) null) {
			CreateQScrollBarProxy();
			CreateQScrollBarSignalProxy();
			NewQScrollBar(minValue,maxValue,lineStep,pageStep,value,arg6,parent,name);
		}
		[SmokeMethod("QScrollBar(int, int, int, int, int, Qt::Orientation, QWidget*, const char*)")]
		private void NewQScrollBar(int minValue, int maxValue, int lineStep, int pageStep, int value, int arg6, QWidget parent, string name) {
			ProxyQScrollBar().NewQScrollBar(minValue,maxValue,lineStep,pageStep,value,arg6,parent,name);
		}
		public QScrollBar(int minValue, int maxValue, int lineStep, int pageStep, int value, int arg6, QWidget parent) : this((Type) null) {
			CreateQScrollBarProxy();
			CreateQScrollBarSignalProxy();
			NewQScrollBar(minValue,maxValue,lineStep,pageStep,value,arg6,parent);
		}
		[SmokeMethod("QScrollBar(int, int, int, int, int, Qt::Orientation, QWidget*)")]
		private void NewQScrollBar(int minValue, int maxValue, int lineStep, int pageStep, int value, int arg6, QWidget parent) {
			ProxyQScrollBar().NewQScrollBar(minValue,maxValue,lineStep,pageStep,value,arg6,parent);
		}
		[SmokeMethod("setOrientation(Qt::Orientation)")]
		public virtual void SetOrientation(int arg1) {
			ProxyQScrollBar().SetOrientation(arg1);
		}
		[SmokeMethod("orientation() const")]
		public int Orientation() {
			return ProxyQScrollBar().Orientation();
		}
		[SmokeMethod("setTracking(bool)")]
		public virtual void SetTracking(bool enable) {
			ProxyQScrollBar().SetTracking(enable);
		}
		[SmokeMethod("tracking() const")]
		public bool Tracking() {
			return ProxyQScrollBar().Tracking();
		}
		[SmokeMethod("draggingSlider() const")]
		public bool DraggingSlider() {
			return ProxyQScrollBar().DraggingSlider();
		}
		[SmokeMethod("setPalette(const QPalette&)")]
		public new virtual void SetPalette(QPalette arg1) {
			ProxyQScrollBar().SetPalette(arg1);
		}
		[SmokeMethod("sizeHint() const")]
		public new virtual QSize SizeHint() {
			return ProxyQScrollBar().SizeHint();
		}
		[SmokeMethod("setSizePolicy(QSizePolicy)")]
		public new virtual void SetSizePolicy(QSizePolicy sp) {
			ProxyQScrollBar().SetSizePolicy(sp);
		}
		[SmokeMethod("setSizePolicy(QSizePolicy::SizeType, QSizePolicy::SizeType, bool)")]
		public new void SetSizePolicy(int hor, int ver, bool hfw) {
			ProxyQScrollBar().SetSizePolicy(hor,ver,hfw);
		}
		[SmokeMethod("setSizePolicy(QSizePolicy::SizeType, QSizePolicy::SizeType)")]
		public new void SetSizePolicy(int hor, int ver) {
			ProxyQScrollBar().SetSizePolicy(hor,ver);
		}
		[SmokeMethod("minValue() const")]
		public int MinValue() {
			return ProxyQScrollBar().MinValue();
		}
		[SmokeMethod("maxValue() const")]
		public int MaxValue() {
			return ProxyQScrollBar().MaxValue();
		}
		[SmokeMethod("setMinValue(int)")]
		public void SetMinValue(int arg1) {
			ProxyQScrollBar().SetMinValue(arg1);
		}
		[SmokeMethod("setMaxValue(int)")]
		public void SetMaxValue(int arg1) {
			ProxyQScrollBar().SetMaxValue(arg1);
		}
		[SmokeMethod("lineStep() const")]
		public int LineStep() {
			return ProxyQScrollBar().LineStep();
		}
		[SmokeMethod("pageStep() const")]
		public int PageStep() {
			return ProxyQScrollBar().PageStep();
		}
		[SmokeMethod("setLineStep(int)")]
		public void SetLineStep(int arg1) {
			ProxyQScrollBar().SetLineStep(arg1);
		}
		[SmokeMethod("setPageStep(int)")]
		public void SetPageStep(int arg1) {
			ProxyQScrollBar().SetPageStep(arg1);
		}
		[SmokeMethod("value() const")]
		public int Value() {
			return ProxyQScrollBar().Value();
		}
		[SmokeMethod("sliderStart() const")]
		public int SliderStart() {
			return ProxyQScrollBar().SliderStart();
		}
		[SmokeMethod("sliderRect() const")]
		public QRect SliderRect() {
			return ProxyQScrollBar().SliderRect();
		}
		[Q_SLOT("void setValue(int)")]
		[SmokeMethod("setValue(int)")]
		public void SetValue(int arg1) {
			ProxyQScrollBar().SetValue(arg1);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQScrollBar().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQScrollBar().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQScrollBar().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQScrollBar().TrUtf8(arg1);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected new void WheelEvent(QWheelEvent arg1) {
			ProxyQScrollBar().WheelEvent(arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new void KeyPressEvent(QKeyEvent arg1) {
			ProxyQScrollBar().KeyPressEvent(arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQScrollBar().ResizeEvent(arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQScrollBar().PaintEvent(arg1);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new void MousePressEvent(QMouseEvent arg1) {
			ProxyQScrollBar().MousePressEvent(arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected new void MouseReleaseEvent(QMouseEvent arg1) {
			ProxyQScrollBar().MouseReleaseEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent arg1) {
			ProxyQScrollBar().MouseMoveEvent(arg1);
		}
		[SmokeMethod("contextMenuEvent(QContextMenuEvent*)")]
		protected new void ContextMenuEvent(QContextMenuEvent arg1) {
			ProxyQScrollBar().ContextMenuEvent(arg1);
		}
		[SmokeMethod("hideEvent(QHideEvent*)")]
		protected new void HideEvent(QHideEvent arg1) {
			ProxyQScrollBar().HideEvent(arg1);
		}
		[SmokeMethod("valueChange()")]
		protected void ValueChange() {
			ProxyQScrollBar().ValueChange();
		}
		[SmokeMethod("stepChange()")]
		protected void StepChange() {
			ProxyQScrollBar().StepChange();
		}
		[SmokeMethod("rangeChange()")]
		protected void RangeChange() {
			ProxyQScrollBar().RangeChange();
		}
		[SmokeMethod("styleChange(QStyle&)")]
		public new void StyleChange(QStyle arg1) {
			ProxyQScrollBar().StyleChange(arg1);
		}
		~QScrollBar() {
			DisposeQScrollBar();
		}
		public new void Dispose() {
			DisposeQScrollBar();
		}
		private void DisposeQScrollBar() {
			ProxyQScrollBar().DisposeQScrollBar();
		}
		[SmokeMethod("addPage()")]
		public void AddPage() {
			ProxyQScrollBar().AddPage();
		}
		[SmokeMethod("subtractPage()")]
		public void SubtractPage() {
			ProxyQScrollBar().SubtractPage();
		}
		[SmokeMethod("addLine()")]
		public void AddLine() {
			ProxyQScrollBar().AddLine();
		}
		[SmokeMethod("subtractLine()")]
		public void SubtractLine() {
			ProxyQScrollBar().SubtractLine();
		}
		[SmokeMethod("setRange(int, int)")]
		public void SetRange(int minValue, int maxValue) {
			ProxyQScrollBar().SetRange(minValue,maxValue);
		}
		[SmokeMethod("setSteps(int, int)")]
		public void SetSteps(int line, int page) {
			ProxyQScrollBar().SetSteps(line,page);
		}
		[SmokeMethod("bound(int) const")]
		public int Bound(int arg1) {
			return ProxyQScrollBar().Bound(arg1);
		}
		[SmokeMethod("positionFromValue(int, int) const")]
		protected int PositionFromValue(int val, int space) {
			return ProxyQScrollBar().PositionFromValue(val,space);
		}
		[SmokeMethod("valueFromPosition(int, int) const")]
		protected int ValueFromPosition(int pos, int space) {
			return ProxyQScrollBar().ValueFromPosition(pos,space);
		}
		[SmokeMethod("directSetValue(int)")]
		protected void DirectSetValue(int val) {
			ProxyQScrollBar().DirectSetValue(val);
		}
		[SmokeMethod("prevValue() const")]
		protected int PrevValue() {
			return ProxyQScrollBar().PrevValue();
		}
		protected void CreateQScrollBarSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQScrollBarSignals), this);
			Q_EMIT = (IQScrollBarSignals) realProxy.GetTransparentProxy();
		}
		protected new IQScrollBarSignals Emit() {
			return (IQScrollBarSignals) Q_EMIT;
		}
	}

	public interface IQScrollBarSignals : IQWidgetSignals {
		[Q_SIGNAL("void valueChanged(int)")]
		void ValueChanged(int value);
		[Q_SIGNAL("void sliderPressed()")]
		void SliderPressed();
		[Q_SIGNAL("void sliderMoved(int)")]
		void SliderMoved(int value);
		[Q_SIGNAL("void sliderReleased()")]
		void SliderReleased();
		[Q_SIGNAL("void nextLine()")]
		void NextLine();
		[Q_SIGNAL("void prevLine()")]
		void PrevLine();
		[Q_SIGNAL("void nextPage()")]
		void NextPage();
		[Q_SIGNAL("void prevPage()")]
		void PrevPage();
	}
}
