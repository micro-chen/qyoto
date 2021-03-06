//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QSizePolicy")]
    public class QSizePolicy : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QSizePolicy(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QSizePolicy), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QSizePolicy() {
            staticInterceptor = new SmokeInvocation(typeof(QSizePolicy), null);
        }
        public enum PolicyFlag {
            GrowFlag = 1,
            ExpandFlag = 2,
            ShrinkFlag = 4,
            IgnoreFlag = 8,
        }
        public enum Policy {
            Fixed = 0,
            Minimum = PolicyFlag.GrowFlag,
            Maximum = PolicyFlag.ShrinkFlag,
            Preferred = PolicyFlag.GrowFlag|PolicyFlag.ShrinkFlag,
            MinimumExpanding = PolicyFlag.GrowFlag|PolicyFlag.ExpandFlag,
            Expanding = PolicyFlag.GrowFlag|PolicyFlag.ShrinkFlag|PolicyFlag.ExpandFlag,
            Ignored = PolicyFlag.ShrinkFlag|PolicyFlag.GrowFlag|PolicyFlag.IgnoreFlag,
        }
        public enum ControlType {
            DefaultType = 0x00000001,
            ButtonBox = 0x00000002,
            CheckBox = 0x00000004,
            ComboBox = 0x00000008,
            Frame = 0x00000010,
            GroupBox = 0x00000020,
            Label = 0x00000040,
            Line = 0x00000080,
            LineEdit = 0x00000100,
            PushButton = 0x00000200,
            RadioButton = 0x00000400,
            Slider = 0x00000800,
            SpinBox = 0x00001000,
            TabWidget = 0x00002000,
            ToolButton = 0x00004000,
        }
        //  operator QVariant(); >>>> NOT CONVERTED
        public QSizePolicy() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSizePolicy", "QSizePolicy()", typeof(void));
        }
        public QSizePolicy(QSizePolicy.Policy horizontal, QSizePolicy.Policy vertical) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSizePolicy$$", "QSizePolicy(QSizePolicy::Policy, QSizePolicy::Policy)", typeof(void), typeof(QSizePolicy.Policy), horizontal, typeof(QSizePolicy.Policy), vertical);
        }
        public QSizePolicy(QSizePolicy.Policy horizontal, QSizePolicy.Policy vertical, QSizePolicy.ControlType type) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSizePolicy$$$", "QSizePolicy(QSizePolicy::Policy, QSizePolicy::Policy, QSizePolicy::ControlType)", typeof(void), typeof(QSizePolicy.Policy), horizontal, typeof(QSizePolicy.Policy), vertical, typeof(QSizePolicy.ControlType), type);
        }
        public QSizePolicy.Policy HorizontalPolicy() {
            return (QSizePolicy.Policy) interceptor.Invoke("horizontalPolicy", "horizontalPolicy() const", typeof(QSizePolicy.Policy));
        }
        public QSizePolicy.Policy VerticalPolicy() {
            return (QSizePolicy.Policy) interceptor.Invoke("verticalPolicy", "verticalPolicy() const", typeof(QSizePolicy.Policy));
        }
        public QSizePolicy.ControlType controlType() {
            return (QSizePolicy.ControlType) interceptor.Invoke("controlType", "controlType() const", typeof(QSizePolicy.ControlType));
        }
        public void SetHorizontalPolicy(QSizePolicy.Policy d) {
            interceptor.Invoke("setHorizontalPolicy$", "setHorizontalPolicy(QSizePolicy::Policy)", typeof(void), typeof(QSizePolicy.Policy), d);
        }
        public void SetVerticalPolicy(QSizePolicy.Policy d) {
            interceptor.Invoke("setVerticalPolicy$", "setVerticalPolicy(QSizePolicy::Policy)", typeof(void), typeof(QSizePolicy.Policy), d);
        }
        public void SetControlType(QSizePolicy.ControlType type) {
            interceptor.Invoke("setControlType$", "setControlType(QSizePolicy::ControlType)", typeof(void), typeof(QSizePolicy.ControlType), type);
        }
        public uint ExpandingDirections() {
            return (uint) interceptor.Invoke("expandingDirections", "expandingDirections() const", typeof(uint));
        }
        public void SetHeightForWidth(bool b) {
            interceptor.Invoke("setHeightForWidth$", "setHeightForWidth(bool)", typeof(void), typeof(bool), b);
        }
        public bool HasHeightForWidth() {
            return (bool) interceptor.Invoke("hasHeightForWidth", "hasHeightForWidth() const", typeof(bool));
        }
        public override bool Equals(object o) {
            if (!(o is QSizePolicy)) { return false; }
            return this == (QSizePolicy) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        public int HorizontalStretch() {
            return (int) interceptor.Invoke("horizontalStretch", "horizontalStretch() const", typeof(int));
        }
        public int VerticalStretch() {
            return (int) interceptor.Invoke("verticalStretch", "verticalStretch() const", typeof(int));
        }
        public void SetHorizontalStretch(ushort stretchFactor) {
            interceptor.Invoke("setHorizontalStretch$", "setHorizontalStretch(uchar)", typeof(void), typeof(ushort), stretchFactor);
        }
        public void SetVerticalStretch(ushort stretchFactor) {
            interceptor.Invoke("setVerticalStretch$", "setVerticalStretch(uchar)", typeof(void), typeof(ushort), stretchFactor);
        }
        public void Transpose() {
            interceptor.Invoke("transpose", "transpose()", typeof(void));
        }
        ~QSizePolicy() {
            interceptor.Invoke("~QSizePolicy", "~QSizePolicy()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QSizePolicy", "~QSizePolicy()", typeof(void));
        }
        public static bool operator==(QSizePolicy lhs, QSizePolicy s) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QSizePolicy&) const", typeof(bool), typeof(QSizePolicy), lhs, typeof(QSizePolicy), s);
        }
        public static bool operator!=(QSizePolicy lhs, QSizePolicy s) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QSizePolicy&) const", typeof(bool), typeof(QSizePolicy), lhs, typeof(QSizePolicy), s);
        }
    }
}
