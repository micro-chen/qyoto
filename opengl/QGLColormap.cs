//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QGLColormap")]
    public class QGLColormap : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QGLColormap(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QGLColormap), this);
        }
        public QGLColormap() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGLColormap", "QGLColormap()", typeof(void));
        }
        public QGLColormap(QGLColormap arg1) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGLColormap#", "QGLColormap(const QGLColormap&)", typeof(void), typeof(QGLColormap), arg1);
        }
        public bool IsEmpty() {
            return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
        }
        public int Size() {
            return (int) interceptor.Invoke("size", "size() const", typeof(int));
        }
        public void Detach() {
            interceptor.Invoke("detach", "detach()", typeof(void));
        }
        public void SetEntries(int count, ref int colors, int arg3) {
            StackItem[] stack = new StackItem[4];
            stack[1].s_int = count;
            stack[2].s_int = colors;
            stack[3].s_int = arg3;
            interceptor.Invoke("setEntries$$$", "setEntries(int, const unsigned int*, int)", stack);
            colors = stack[2].s_int;
            return;
        }
        public void SetEntries(int count, ref int colors) {
            StackItem[] stack = new StackItem[3];
            stack[1].s_int = count;
            stack[2].s_int = colors;
            interceptor.Invoke("setEntries$$", "setEntries(int, const unsigned int*)", stack);
            colors = stack[2].s_int;
            return;
        }
        public void SetEntry(int idx, uint color) {
            interceptor.Invoke("setEntry$$", "setEntry(int, unsigned int)", typeof(void), typeof(int), idx, typeof(uint), color);
        }
        public void SetEntry(int idx, QColor color) {
            interceptor.Invoke("setEntry$#", "setEntry(int, const QColor&)", typeof(void), typeof(int), idx, typeof(QColor), color);
        }
        public uint EntryRgb(int idx) {
            return (uint) interceptor.Invoke("entryRgb$", "entryRgb(int) const", typeof(uint), typeof(int), idx);
        }
        public QColor EntryColor(int idx) {
            return (QColor) interceptor.Invoke("entryColor$", "entryColor(int) const", typeof(QColor), typeof(int), idx);
        }
        public int Find(uint color) {
            return (int) interceptor.Invoke("find$", "find(unsigned int) const", typeof(int), typeof(uint), color);
        }
        public int FindNearest(uint color) {
            return (int) interceptor.Invoke("findNearest$", "findNearest(unsigned int) const", typeof(int), typeof(uint), color);
        }
        protected void SetHandle(uint ahandle) {
            interceptor.Invoke("setHandle$", "setHandle(Qt::HANDLE)", typeof(void), typeof(uint), ahandle);
        }
        ~QGLColormap() {
            interceptor.Invoke("~QGLColormap", "~QGLColormap()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QGLColormap", "~QGLColormap()", typeof(void));
        }
    }
}
