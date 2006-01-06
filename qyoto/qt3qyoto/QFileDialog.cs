//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	/// See <see cref="IQFileDialogSignals"></see> for signals emitted by QFileDialog
	[SmokeClass("QFileDialog")]
	public class QFileDialog : QDialog, IDisposable {
 		protected QFileDialog(Type dummy) : base((Type) null) {}
		interface IQFileDialogProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
			string GetOpenFileName(string initially, string filter, QWidget parent, string name, string caption, StringBuilder selectedFilter, bool resolveSymlinks);
			string GetOpenFileName(string initially, string filter, QWidget parent, string name, string caption, StringBuilder selectedFilter);
			string GetOpenFileName(string initially, string filter, QWidget parent, string name, string caption);
			string GetOpenFileName(string initially, string filter, QWidget parent, string name);
			string GetOpenFileName(string initially, string filter, QWidget parent);
			string GetOpenFileName(string initially, string filter);
			string GetOpenFileName(string initially);
			string GetOpenFileName();
			string GetSaveFileName(string initially, string filter, QWidget parent, string name, string caption, StringBuilder selectedFilter, bool resolveSymlinks);
			string GetSaveFileName(string initially, string filter, QWidget parent, string name, string caption, StringBuilder selectedFilter);
			string GetSaveFileName(string initially, string filter, QWidget parent, string name, string caption);
			string GetSaveFileName(string initially, string filter, QWidget parent, string name);
			string GetSaveFileName(string initially, string filter, QWidget parent);
			string GetSaveFileName(string initially, string filter);
			string GetSaveFileName(string initially);
			string GetSaveFileName();
			string GetExistingDirectory(string dir, QWidget parent, string name, string caption, bool dirOnly, bool resolveSymlinks);
			string GetExistingDirectory(string dir, QWidget parent, string name, string caption, bool dirOnly);
			string GetExistingDirectory(string dir, QWidget parent, string name, string caption);
			string GetExistingDirectory(string dir, QWidget parent, string name);
			string GetExistingDirectory(string dir, QWidget parent);
			string GetExistingDirectory(string dir);
			string GetExistingDirectory();
			ArrayList GetOpenFileNames(string filter, string dir, QWidget parent, string name, string caption, StringBuilder selectedFilter, bool resolveSymlinks);
			ArrayList GetOpenFileNames(string filter, string dir, QWidget parent, string name, string caption, StringBuilder selectedFilter);
			ArrayList GetOpenFileNames(string filter, string dir, QWidget parent, string name, string caption);
			ArrayList GetOpenFileNames(string filter, string dir, QWidget parent, string name);
			ArrayList GetOpenFileNames(string filter, string dir, QWidget parent);
			ArrayList GetOpenFileNames(string filter, string dir);
			ArrayList GetOpenFileNames(string filter);
			ArrayList GetOpenFileNames();
			void SetIconProvider(QFileIconProvider arg1);
			QFileIconProvider IconProvider();
		}

		protected void CreateQFileDialogProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFileDialog), this);
			_interceptor = (QFileDialog) realProxy.GetTransparentProxy();
		}
		private QFileDialog ProxyQFileDialog() {
			return (QFileDialog) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFileDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFileDialogProxy), null);
			_staticInterceptor = (IQFileDialogProxy) realProxy.GetTransparentProxy();
		}
		private static IQFileDialogProxy StaticQFileDialog() {
			return (IQFileDialogProxy) _staticInterceptor;
		}

		enum E_Mode {
			AnyFile = 0,
			ExistingFile = 1,
			Directory = 2,
			ExistingFiles = 3,
			DirectoryOnly = 4,
		}
		enum E_ViewMode {
			Detail = 0,
			List = 1,
		}
		enum E_PreviewMode {
			NoPreview = 0,
			Contents = 1,
			Info = 2,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQFileDialog().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQFileDialog().ClassName();
		}
		public QFileDialog(string dirName, string filter, QWidget parent, string name, bool modal) : this((Type) null) {
			CreateQFileDialogProxy();
			CreateQFileDialogSignalProxy();
			NewQFileDialog(dirName,filter,parent,name,modal);
		}
		[SmokeMethod("QFileDialog(const QString&, const QString&, QWidget*, const char*, bool)")]
		private void NewQFileDialog(string dirName, string filter, QWidget parent, string name, bool modal) {
			ProxyQFileDialog().NewQFileDialog(dirName,filter,parent,name,modal);
		}
		public QFileDialog(string dirName, string filter, QWidget parent, string name) : this((Type) null) {
			CreateQFileDialogProxy();
			CreateQFileDialogSignalProxy();
			NewQFileDialog(dirName,filter,parent,name);
		}
		[SmokeMethod("QFileDialog(const QString&, const QString&, QWidget*, const char*)")]
		private void NewQFileDialog(string dirName, string filter, QWidget parent, string name) {
			ProxyQFileDialog().NewQFileDialog(dirName,filter,parent,name);
		}
		public QFileDialog(string dirName, string filter, QWidget parent) : this((Type) null) {
			CreateQFileDialogProxy();
			CreateQFileDialogSignalProxy();
			NewQFileDialog(dirName,filter,parent);
		}
		[SmokeMethod("QFileDialog(const QString&, const QString&, QWidget*)")]
		private void NewQFileDialog(string dirName, string filter, QWidget parent) {
			ProxyQFileDialog().NewQFileDialog(dirName,filter,parent);
		}
		public QFileDialog(string dirName, string filter) : this((Type) null) {
			CreateQFileDialogProxy();
			CreateQFileDialogSignalProxy();
			NewQFileDialog(dirName,filter);
		}
		[SmokeMethod("QFileDialog(const QString&, const QString&)")]
		private void NewQFileDialog(string dirName, string filter) {
			ProxyQFileDialog().NewQFileDialog(dirName,filter);
		}
		public QFileDialog(string dirName) : this((Type) null) {
			CreateQFileDialogProxy();
			CreateQFileDialogSignalProxy();
			NewQFileDialog(dirName);
		}
		[SmokeMethod("QFileDialog(const QString&)")]
		private void NewQFileDialog(string dirName) {
			ProxyQFileDialog().NewQFileDialog(dirName);
		}
		public QFileDialog(QWidget parent, string name, bool modal) : this((Type) null) {
			CreateQFileDialogProxy();
			CreateQFileDialogSignalProxy();
			NewQFileDialog(parent,name,modal);
		}
		[SmokeMethod("QFileDialog(QWidget*, const char*, bool)")]
		private void NewQFileDialog(QWidget parent, string name, bool modal) {
			ProxyQFileDialog().NewQFileDialog(parent,name,modal);
		}
		public QFileDialog(QWidget parent, string name) : this((Type) null) {
			CreateQFileDialogProxy();
			CreateQFileDialogSignalProxy();
			NewQFileDialog(parent,name);
		}
		[SmokeMethod("QFileDialog(QWidget*, const char*)")]
		private void NewQFileDialog(QWidget parent, string name) {
			ProxyQFileDialog().NewQFileDialog(parent,name);
		}
		public QFileDialog(QWidget parent) : this((Type) null) {
			CreateQFileDialogProxy();
			CreateQFileDialogSignalProxy();
			NewQFileDialog(parent);
		}
		[SmokeMethod("QFileDialog(QWidget*)")]
		private void NewQFileDialog(QWidget parent) {
			ProxyQFileDialog().NewQFileDialog(parent);
		}
		public QFileDialog() : this((Type) null) {
			CreateQFileDialogProxy();
			CreateQFileDialogSignalProxy();
			NewQFileDialog();
		}
		[SmokeMethod("QFileDialog()")]
		private void NewQFileDialog() {
			ProxyQFileDialog().NewQFileDialog();
		}
		[SmokeMethod("selectedFile() const")]
		public string SelectedFile() {
			return ProxyQFileDialog().SelectedFile();
		}
		[SmokeMethod("selectedFilter() const")]
		public string SelectedFilter() {
			return ProxyQFileDialog().SelectedFilter();
		}
		[SmokeMethod("setSelectedFilter(const QString&)")]
		public virtual void SetSelectedFilter(string arg1) {
			ProxyQFileDialog().SetSelectedFilter(arg1);
		}
		[SmokeMethod("setSelectedFilter(int)")]
		public virtual void SetSelectedFilter(int arg1) {
			ProxyQFileDialog().SetSelectedFilter(arg1);
		}
		[SmokeMethod("setSelection(const QString&)")]
		public void SetSelection(string arg1) {
			ProxyQFileDialog().SetSelection(arg1);
		}
		[SmokeMethod("selectAll(bool)")]
		public void SelectAll(bool b) {
			ProxyQFileDialog().SelectAll(b);
		}
		[SmokeMethod("selectedFiles() const")]
		public ArrayList SelectedFiles() {
			return ProxyQFileDialog().SelectedFiles();
		}
		[SmokeMethod("dirPath() const")]
		public string DirPath() {
			return ProxyQFileDialog().DirPath();
		}
		[SmokeMethod("setDir(const QDir&)")]
		public void SetDir(QDir arg1) {
			ProxyQFileDialog().SetDir(arg1);
		}
		[SmokeMethod("dir() const")]
		public QDir Dir() {
			return ProxyQFileDialog().Dir();
		}
		[SmokeMethod("setShowHiddenFiles(bool)")]
		public void SetShowHiddenFiles(bool s) {
			ProxyQFileDialog().SetShowHiddenFiles(s);
		}
		[SmokeMethod("showHiddenFiles() const")]
		public bool ShowHiddenFiles() {
			return ProxyQFileDialog().ShowHiddenFiles();
		}
		[SmokeMethod("rereadDir()")]
		public void RereadDir() {
			ProxyQFileDialog().RereadDir();
		}
		[SmokeMethod("resortDir()")]
		public void ResortDir() {
			ProxyQFileDialog().ResortDir();
		}
		[SmokeMethod("setMode(QFileDialog::Mode)")]
		public void SetMode(int arg1) {
			ProxyQFileDialog().SetMode(arg1);
		}
		[SmokeMethod("mode() const")]
		public int Mode() {
			return ProxyQFileDialog().Mode();
		}
		[SmokeMethod("setViewMode(QFileDialog::ViewMode)")]
		public void SetViewMode(int m) {
			ProxyQFileDialog().SetViewMode(m);
		}
		[SmokeMethod("viewMode() const")]
		public int ViewMode() {
			return ProxyQFileDialog().ViewMode();
		}
		[SmokeMethod("setPreviewMode(QFileDialog::PreviewMode)")]
		public void SetPreviewMode(int m) {
			ProxyQFileDialog().SetPreviewMode(m);
		}
		[SmokeMethod("previewMode() const")]
		public int PreviewMode() {
			return ProxyQFileDialog().PreviewMode();
		}
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		public new bool EventFilter(QObject arg1, QEvent arg2) {
			return ProxyQFileDialog().EventFilter(arg1,arg2);
		}
		[SmokeMethod("isInfoPreviewEnabled() const")]
		public bool IsInfoPreviewEnabled() {
			return ProxyQFileDialog().IsInfoPreviewEnabled();
		}
		[SmokeMethod("isContentsPreviewEnabled() const")]
		public bool IsContentsPreviewEnabled() {
			return ProxyQFileDialog().IsContentsPreviewEnabled();
		}
		[SmokeMethod("setInfoPreviewEnabled(bool)")]
		public void SetInfoPreviewEnabled(bool arg1) {
			ProxyQFileDialog().SetInfoPreviewEnabled(arg1);
		}
		[SmokeMethod("setContentsPreviewEnabled(bool)")]
		public void SetContentsPreviewEnabled(bool arg1) {
			ProxyQFileDialog().SetContentsPreviewEnabled(arg1);
		}
		[SmokeMethod("setInfoPreview(QWidget*, QFilePreview*)")]
		public void SetInfoPreview(QWidget w, QFilePreview preview) {
			ProxyQFileDialog().SetInfoPreview(w,preview);
		}
		[SmokeMethod("setContentsPreview(QWidget*, QFilePreview*)")]
		public void SetContentsPreview(QWidget w, QFilePreview preview) {
			ProxyQFileDialog().SetContentsPreview(w,preview);
		}
		[SmokeMethod("url() const")]
		public IQUrl Url() {
			return ProxyQFileDialog().Url();
		}
		[SmokeMethod("addFilter(const QString&)")]
		public void AddFilter(string filter) {
			ProxyQFileDialog().AddFilter(filter);
		}
		[Q_SLOT("void done(int)")]
		[SmokeMethod("done(int)")]
		public new void Done(int arg1) {
			ProxyQFileDialog().Done(arg1);
		}
		[Q_SLOT("void setDir(const QString&)")]
		[SmokeMethod("setDir(const QString&)")]
		public void SetDir(string arg1) {
			ProxyQFileDialog().SetDir(arg1);
		}
		[Q_SLOT("void setUrl(const QUrlOperator&)")]
		[SmokeMethod("setUrl(const QUrlOperator&)")]
		public void SetUrl(QUrlOperator url) {
			ProxyQFileDialog().SetUrl(url);
		}
		[Q_SLOT("void setFilter(const QString&)")]
		[SmokeMethod("setFilter(const QString&)")]
		public void SetFilter(string arg1) {
			ProxyQFileDialog().SetFilter(arg1);
		}
		[Q_SLOT("void setFilters(const QString&)")]
		[SmokeMethod("setFilters(const QString&)")]
		public void SetFilters(string arg1) {
			ProxyQFileDialog().SetFilters(arg1);
		}
		[Q_SLOT("void setFilters(const char**)")]
		[SmokeMethod("setFilters(const char**)")]
		public void SetFilters(string[] arg1) {
			ProxyQFileDialog().SetFilters(arg1);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQFileDialog().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQFileDialog().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQFileDialog().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQFileDialog().TrUtf8(arg1);
		}
		[SmokeMethod("getOpenFileName(const QString&, const QString&, QWidget*, const char*, const QString&, QString*, bool)")]
		public static string GetOpenFileName(string initially, string filter, QWidget parent, string name, string caption, StringBuilder selectedFilter, bool resolveSymlinks) {
			return StaticQFileDialog().GetOpenFileName(initially,filter,parent,name,caption,selectedFilter,resolveSymlinks);
		}
		[SmokeMethod("getOpenFileName(const QString&, const QString&, QWidget*, const char*, const QString&, QString*)")]
		public static string GetOpenFileName(string initially, string filter, QWidget parent, string name, string caption, StringBuilder selectedFilter) {
			return StaticQFileDialog().GetOpenFileName(initially,filter,parent,name,caption,selectedFilter);
		}
		[SmokeMethod("getOpenFileName(const QString&, const QString&, QWidget*, const char*, const QString&)")]
		public static string GetOpenFileName(string initially, string filter, QWidget parent, string name, string caption) {
			return StaticQFileDialog().GetOpenFileName(initially,filter,parent,name,caption);
		}
		[SmokeMethod("getOpenFileName(const QString&, const QString&, QWidget*, const char*)")]
		public static string GetOpenFileName(string initially, string filter, QWidget parent, string name) {
			return StaticQFileDialog().GetOpenFileName(initially,filter,parent,name);
		}
		[SmokeMethod("getOpenFileName(const QString&, const QString&, QWidget*)")]
		public static string GetOpenFileName(string initially, string filter, QWidget parent) {
			return StaticQFileDialog().GetOpenFileName(initially,filter,parent);
		}
		[SmokeMethod("getOpenFileName(const QString&, const QString&)")]
		public static string GetOpenFileName(string initially, string filter) {
			return StaticQFileDialog().GetOpenFileName(initially,filter);
		}
		[SmokeMethod("getOpenFileName(const QString&)")]
		public static string GetOpenFileName(string initially) {
			return StaticQFileDialog().GetOpenFileName(initially);
		}
		[SmokeMethod("getOpenFileName()")]
		public static string GetOpenFileName() {
			return StaticQFileDialog().GetOpenFileName();
		}
		[SmokeMethod("getSaveFileName(const QString&, const QString&, QWidget*, const char*, const QString&, QString*, bool)")]
		public static string GetSaveFileName(string initially, string filter, QWidget parent, string name, string caption, StringBuilder selectedFilter, bool resolveSymlinks) {
			return StaticQFileDialog().GetSaveFileName(initially,filter,parent,name,caption,selectedFilter,resolveSymlinks);
		}
		[SmokeMethod("getSaveFileName(const QString&, const QString&, QWidget*, const char*, const QString&, QString*)")]
		public static string GetSaveFileName(string initially, string filter, QWidget parent, string name, string caption, StringBuilder selectedFilter) {
			return StaticQFileDialog().GetSaveFileName(initially,filter,parent,name,caption,selectedFilter);
		}
		[SmokeMethod("getSaveFileName(const QString&, const QString&, QWidget*, const char*, const QString&)")]
		public static string GetSaveFileName(string initially, string filter, QWidget parent, string name, string caption) {
			return StaticQFileDialog().GetSaveFileName(initially,filter,parent,name,caption);
		}
		[SmokeMethod("getSaveFileName(const QString&, const QString&, QWidget*, const char*)")]
		public static string GetSaveFileName(string initially, string filter, QWidget parent, string name) {
			return StaticQFileDialog().GetSaveFileName(initially,filter,parent,name);
		}
		[SmokeMethod("getSaveFileName(const QString&, const QString&, QWidget*)")]
		public static string GetSaveFileName(string initially, string filter, QWidget parent) {
			return StaticQFileDialog().GetSaveFileName(initially,filter,parent);
		}
		[SmokeMethod("getSaveFileName(const QString&, const QString&)")]
		public static string GetSaveFileName(string initially, string filter) {
			return StaticQFileDialog().GetSaveFileName(initially,filter);
		}
		[SmokeMethod("getSaveFileName(const QString&)")]
		public static string GetSaveFileName(string initially) {
			return StaticQFileDialog().GetSaveFileName(initially);
		}
		[SmokeMethod("getSaveFileName()")]
		public static string GetSaveFileName() {
			return StaticQFileDialog().GetSaveFileName();
		}
		[SmokeMethod("getExistingDirectory(const QString&, QWidget*, const char*, const QString&, bool, bool)")]
		public static string GetExistingDirectory(string dir, QWidget parent, string name, string caption, bool dirOnly, bool resolveSymlinks) {
			return StaticQFileDialog().GetExistingDirectory(dir,parent,name,caption,dirOnly,resolveSymlinks);
		}
		[SmokeMethod("getExistingDirectory(const QString&, QWidget*, const char*, const QString&, bool)")]
		public static string GetExistingDirectory(string dir, QWidget parent, string name, string caption, bool dirOnly) {
			return StaticQFileDialog().GetExistingDirectory(dir,parent,name,caption,dirOnly);
		}
		[SmokeMethod("getExistingDirectory(const QString&, QWidget*, const char*, const QString&)")]
		public static string GetExistingDirectory(string dir, QWidget parent, string name, string caption) {
			return StaticQFileDialog().GetExistingDirectory(dir,parent,name,caption);
		}
		[SmokeMethod("getExistingDirectory(const QString&, QWidget*, const char*)")]
		public static string GetExistingDirectory(string dir, QWidget parent, string name) {
			return StaticQFileDialog().GetExistingDirectory(dir,parent,name);
		}
		[SmokeMethod("getExistingDirectory(const QString&, QWidget*)")]
		public static string GetExistingDirectory(string dir, QWidget parent) {
			return StaticQFileDialog().GetExistingDirectory(dir,parent);
		}
		[SmokeMethod("getExistingDirectory(const QString&)")]
		public static string GetExistingDirectory(string dir) {
			return StaticQFileDialog().GetExistingDirectory(dir);
		}
		[SmokeMethod("getExistingDirectory()")]
		public static string GetExistingDirectory() {
			return StaticQFileDialog().GetExistingDirectory();
		}
		[SmokeMethod("getOpenFileNames(const QString&, const QString&, QWidget*, const char*, const QString&, QString*, bool)")]
		public static ArrayList GetOpenFileNames(string filter, string dir, QWidget parent, string name, string caption, StringBuilder selectedFilter, bool resolveSymlinks) {
			return StaticQFileDialog().GetOpenFileNames(filter,dir,parent,name,caption,selectedFilter,resolveSymlinks);
		}
		[SmokeMethod("getOpenFileNames(const QString&, const QString&, QWidget*, const char*, const QString&, QString*)")]
		public static ArrayList GetOpenFileNames(string filter, string dir, QWidget parent, string name, string caption, StringBuilder selectedFilter) {
			return StaticQFileDialog().GetOpenFileNames(filter,dir,parent,name,caption,selectedFilter);
		}
		[SmokeMethod("getOpenFileNames(const QString&, const QString&, QWidget*, const char*, const QString&)")]
		public static ArrayList GetOpenFileNames(string filter, string dir, QWidget parent, string name, string caption) {
			return StaticQFileDialog().GetOpenFileNames(filter,dir,parent,name,caption);
		}
		[SmokeMethod("getOpenFileNames(const QString&, const QString&, QWidget*, const char*)")]
		public static ArrayList GetOpenFileNames(string filter, string dir, QWidget parent, string name) {
			return StaticQFileDialog().GetOpenFileNames(filter,dir,parent,name);
		}
		[SmokeMethod("getOpenFileNames(const QString&, const QString&, QWidget*)")]
		public static ArrayList GetOpenFileNames(string filter, string dir, QWidget parent) {
			return StaticQFileDialog().GetOpenFileNames(filter,dir,parent);
		}
		[SmokeMethod("getOpenFileNames(const QString&, const QString&)")]
		public static ArrayList GetOpenFileNames(string filter, string dir) {
			return StaticQFileDialog().GetOpenFileNames(filter,dir);
		}
		[SmokeMethod("getOpenFileNames(const QString&)")]
		public static ArrayList GetOpenFileNames(string filter) {
			return StaticQFileDialog().GetOpenFileNames(filter);
		}
		[SmokeMethod("getOpenFileNames()")]
		public static ArrayList GetOpenFileNames() {
			return StaticQFileDialog().GetOpenFileNames();
		}
		[SmokeMethod("setIconProvider(QFileIconProvider*)")]
		public static void SetIconProvider(QFileIconProvider arg1) {
			StaticQFileDialog().SetIconProvider(arg1);
		}
		[SmokeMethod("iconProvider()")]
		public static QFileIconProvider IconProvider() {
			return StaticQFileDialog().IconProvider();
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQFileDialog().ResizeEvent(arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new void KeyPressEvent(QKeyEvent arg1) {
			ProxyQFileDialog().KeyPressEvent(arg1);
		}
		[SmokeMethod("addWidgets(QLabel*, QWidget*, QPushButton*)")]
		protected void AddWidgets(QLabel arg1, QWidget arg2, QPushButton arg3) {
			ProxyQFileDialog().AddWidgets(arg1,arg2,arg3);
		}
		[SmokeMethod("addToolButton(QButton*, bool)")]
		protected void AddToolButton(QButton b, bool separator) {
			ProxyQFileDialog().AddToolButton(b,separator);
		}
		[SmokeMethod("addToolButton(QButton*)")]
		protected void AddToolButton(QButton b) {
			ProxyQFileDialog().AddToolButton(b);
		}
		[SmokeMethod("addLeftWidget(QWidget*)")]
		protected void AddLeftWidget(QWidget w) {
			ProxyQFileDialog().AddLeftWidget(w);
		}
		[SmokeMethod("addRightWidget(QWidget*)")]
		protected void AddRightWidget(QWidget w) {
			ProxyQFileDialog().AddRightWidget(w);
		}
		~QFileDialog() {
			DisposeQFileDialog();
		}
		public new void Dispose() {
			DisposeQFileDialog();
		}
		private void DisposeQFileDialog() {
			ProxyQFileDialog().DisposeQFileDialog();
		}
		protected void CreateQFileDialogSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQFileDialogSignals), this);
			Q_EMIT = (IQFileDialogSignals) realProxy.GetTransparentProxy();
		}
		protected new IQFileDialogSignals Emit() {
			return (IQFileDialogSignals) Q_EMIT;
		}
	}

	public interface IQFileDialogSignals : IQDialogSignals {
		[Q_SIGNAL("void fileHighlighted(const QString&)")]
		void FileHighlighted(string arg1);
		[Q_SIGNAL("void fileSelected(const QString&)")]
		void FileSelected(string arg1);
		[Q_SIGNAL("void filesSelected(const QStringList&)")]
		void FilesSelected(string[] arg1);
		[Q_SIGNAL("void dirEntered(const QString&)")]
		void DirEntered(string arg1);
		[Q_SIGNAL("void filterSelected(const QString&)")]
		void FilterSelected(string arg1);
	}
}
