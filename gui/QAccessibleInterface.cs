//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QAccessibleInterface")]
    public abstract class QAccessibleInterface : QAccessible {
        protected QAccessibleInterface(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QAccessibleInterface), this);
        }
        // int navigate(QAccessible::RelationFlag arg1,int arg2,QAccessibleInterface** arg3); >>>> NOT CONVERTED
        // QSet<QAccessible::Method> supportedMethods(); >>>> NOT CONVERTED
        [SmokeMethod("isValid() const")]
        public abstract bool IsValid();
        [SmokeMethod("object() const")]
        public abstract QObject Object();
        [SmokeMethod("childCount() const")]
        public abstract int ChildCount();
        [SmokeMethod("indexOfChild(const QAccessibleInterface*) const")]
        public abstract int IndexOfChild(QAccessibleInterface arg1);
        [SmokeMethod("relationTo(int, const QAccessibleInterface*, int) const")]
        public abstract uint RelationTo(int child, QAccessibleInterface other, int otherChild);
        [SmokeMethod("childAt(int, int) const")]
        public abstract int ChildAt(int x, int y);
        [SmokeMethod("text(QAccessible::Text, int) const")]
        public new abstract string Text(QAccessible.Text t, int child);
        [SmokeMethod("setText(QAccessible::Text, int, const QString&)")]
        public abstract void SetText(QAccessible.Text t, int child, string text);
        [SmokeMethod("rect(int) const")]
        public abstract QRect Rect(int child);
        [SmokeMethod("role(int) const")]
        public new abstract QAccessible.Role Role(int child);
        [SmokeMethod("state(int) const")]
        public abstract uint State(int child);
        [SmokeMethod("userActionCount(int) const")]
        public abstract int UserActionCount(int child);
        [SmokeMethod("actionText(int, QAccessible::Text, int) const")]
        public abstract string ActionText(int action, QAccessible.Text t, int child);
        [SmokeMethod("doAction(int, int, const QList<QVariant>&)")]
        public abstract bool DoAction(int action, int child, List<QVariant> arg3);
        public QVariant InvokeMethod(QAccessible.Method method, int child, List<QVariant> arg3) {
            return (QVariant) interceptor.Invoke("invokeMethod$$?", "invokeMethod(QAccessible::Method, int, const QList<QVariant>&)", typeof(QVariant), typeof(QAccessible.Method), method, typeof(int), child, typeof(List<QVariant>), arg3);
        }
        public QVariant InvokeMethod(QAccessible.Method method, int child) {
            return (QVariant) interceptor.Invoke("invokeMethod$$", "invokeMethod(QAccessible::Method, int)", typeof(QVariant), typeof(QAccessible.Method), method, typeof(int), child);
        }
        public QVariant InvokeMethod(QAccessible.Method method) {
            return (QVariant) interceptor.Invoke("invokeMethod$", "invokeMethod(QAccessible::Method)", typeof(QVariant), typeof(QAccessible.Method), method);
        }
        public QColor ForegroundColor() {
            return (QColor) interceptor.Invoke("foregroundColor", "foregroundColor()", typeof(QColor));
        }
        public QColor BackgroundColor() {
            return (QColor) interceptor.Invoke("backgroundColor", "backgroundColor()", typeof(QColor));
        }
        public QAccessibleTextInterface TextInterface() {
            return (QAccessibleTextInterface) interceptor.Invoke("textInterface", "textInterface()", typeof(QAccessibleTextInterface));
        }
        public QAccessibleEditableTextInterface EditableTextInterface() {
            return (QAccessibleEditableTextInterface) interceptor.Invoke("editableTextInterface", "editableTextInterface()", typeof(QAccessibleEditableTextInterface));
        }
        public QAccessibleValueInterface ValueInterface() {
            return (QAccessibleValueInterface) interceptor.Invoke("valueInterface", "valueInterface()", typeof(QAccessibleValueInterface));
        }
        public QAccessibleTableInterface TableInterface() {
            return (QAccessibleTableInterface) interceptor.Invoke("tableInterface", "tableInterface()", typeof(QAccessibleTableInterface));
        }
        public QAccessibleInterface() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QAccessibleInterface", "QAccessibleInterface()", typeof(void));
        }
    }
}
