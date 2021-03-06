//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    /// <remarks> See <see cref="IQFileSystemWatcherSignals"></see> for signals emitted by QFileSystemWatcher
    /// </remarks>
    [SmokeClass("QFileSystemWatcher")]
    public class QFileSystemWatcher : QObject, IDisposable {
        protected QFileSystemWatcher(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QFileSystemWatcher), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QFileSystemWatcher() {
            staticInterceptor = new SmokeInvocation(typeof(QFileSystemWatcher), null);
        }
        public QFileSystemWatcher(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QFileSystemWatcher#", "QFileSystemWatcher(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QFileSystemWatcher() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QFileSystemWatcher", "QFileSystemWatcher()", typeof(void));
        }
        public QFileSystemWatcher(List<string> paths, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QFileSystemWatcher?#", "QFileSystemWatcher(const QStringList&, QObject*)", typeof(void), typeof(List<string>), paths, typeof(QObject), parent);
        }
        public QFileSystemWatcher(List<string> paths) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QFileSystemWatcher?", "QFileSystemWatcher(const QStringList&)", typeof(void), typeof(List<string>), paths);
        }
        public void AddPath(string file) {
            interceptor.Invoke("addPath$", "addPath(const QString&)", typeof(void), typeof(string), file);
        }
        public void AddPaths(List<string> files) {
            interceptor.Invoke("addPaths?", "addPaths(const QStringList&)", typeof(void), typeof(List<string>), files);
        }
        public void RemovePath(string file) {
            interceptor.Invoke("removePath$", "removePath(const QString&)", typeof(void), typeof(string), file);
        }
        public void RemovePaths(List<string> files) {
            interceptor.Invoke("removePaths?", "removePaths(const QStringList&)", typeof(void), typeof(List<string>), files);
        }
        public List<string> Files() {
            return (List<string>) interceptor.Invoke("files", "files() const", typeof(List<string>));
        }
        public List<string> Directories() {
            return (List<string>) interceptor.Invoke("directories", "directories() const", typeof(List<string>));
        }
        ~QFileSystemWatcher() {
            interceptor.Invoke("~QFileSystemWatcher", "~QFileSystemWatcher()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QFileSystemWatcher", "~QFileSystemWatcher()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQFileSystemWatcherSignals Emit {
            get { return (IQFileSystemWatcherSignals) Q_EMIT; }
        }
    }

    public interface IQFileSystemWatcherSignals : IQObjectSignals {
        [Q_SIGNAL("void fileChanged(QString)")]
        void FileChanged(string path);
        [Q_SIGNAL("void directoryChanged(QString)")]
        void DirectoryChanged(string path);
    }
}
