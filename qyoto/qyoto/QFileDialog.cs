//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	/// See <see cref="IQFileDialogSignals"></see> for signals emitted by QFileDialog
	public class QFileDialog : QDialog, IDisposable {
 		protected QFileDialog(Type dummy) : base((Type) null) {}
		interface IQFileDialogProxy {
			string Tr(string s, string c);
			string Tr(string s);
			string GetOpenFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter, int options);
			string GetOpenFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter);
			string GetOpenFileName(QWidget parent, string caption, string dir, string filter);
			string GetOpenFileName(QWidget parent, string caption, string dir);
			string GetOpenFileName(QWidget parent, string caption);
			string GetOpenFileName(QWidget parent);
			string GetOpenFileName();
			string GetSaveFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter, int options);
			string GetSaveFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter);
			string GetSaveFileName(QWidget parent, string caption, string dir, string filter);
			string GetSaveFileName(QWidget parent, string caption, string dir);
			string GetSaveFileName(QWidget parent, string caption);
			string GetSaveFileName(QWidget parent);
			string GetSaveFileName();
			string GetExistingDirectory(QWidget parent, string caption, string dir, int options);
			string GetExistingDirectory(QWidget parent, string caption, string dir);
			string GetExistingDirectory(QWidget parent, string caption);
			string GetExistingDirectory(QWidget parent);
			string GetExistingDirectory();
			ArrayList GetOpenFileNames(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter, int options);
			ArrayList GetOpenFileNames(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter);
			ArrayList GetOpenFileNames(QWidget parent, string caption, string dir, string filter);
			ArrayList GetOpenFileNames(QWidget parent, string caption, string dir);
			ArrayList GetOpenFileNames(QWidget parent, string caption);
			ArrayList GetOpenFileNames(QWidget parent);
			ArrayList GetOpenFileNames();
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

		enum E_ViewMode {
			Detail = 0,
			List = 1,
		}
		enum E_FileMode {
			AnyFile = 0,
			ExistingFile = 1,
			Directory = 2,
			ExistingFiles = 3,
			DirectoryOnly = 4,
		}
		enum E_AcceptMode {
			AcceptOpen = 0,
			AcceptSave = 1,
		}
		enum DialogLabel {
			LookIn = 0,
			FileName = 1,
			FileType = 2,
			Accept = 3,
			Reject = 4,
		}
		enum Option {
			ShowDirsOnly = 0x01,
			DontResolveSymlinks = 0x02,
			DontConfirmOverwrite = 0x04,
			DontUseSheet = 0x08,
			DontUseNativeDialog = 0x10,
		}
		public new virtual QMetaObject MetaObject() {
			return ProxyQFileDialog().MetaObject();
		}
		// void* qt_metacast(const char* arg1); >>>> NOT CONVERTED
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QFileDialog(QWidget parent, int f) : this((Type) null) {
			CreateQFileDialogProxy();
			NewQFileDialog(parent,f);
		}
		private void NewQFileDialog(QWidget parent, int f) {
			ProxyQFileDialog().NewQFileDialog(parent,f);
		}
		public QFileDialog(QWidget parent, string caption, string directory, string filter) : this((Type) null) {
			CreateQFileDialogProxy();
			NewQFileDialog(parent,caption,directory,filter);
		}
		private void NewQFileDialog(QWidget parent, string caption, string directory, string filter) {
			ProxyQFileDialog().NewQFileDialog(parent,caption,directory,filter);
		}
		public QFileDialog(QWidget parent, string caption, string directory) : this((Type) null) {
			CreateQFileDialogProxy();
			NewQFileDialog(parent,caption,directory);
		}
		private void NewQFileDialog(QWidget parent, string caption, string directory) {
			ProxyQFileDialog().NewQFileDialog(parent,caption,directory);
		}
		public QFileDialog(QWidget parent, string caption) : this((Type) null) {
			CreateQFileDialogProxy();
			NewQFileDialog(parent,caption);
		}
		private void NewQFileDialog(QWidget parent, string caption) {
			ProxyQFileDialog().NewQFileDialog(parent,caption);
		}
		public QFileDialog(QWidget parent) : this((Type) null) {
			CreateQFileDialogProxy();
			NewQFileDialog(parent);
		}
		private void NewQFileDialog(QWidget parent) {
			ProxyQFileDialog().NewQFileDialog(parent);
		}
		public QFileDialog() : this((Type) null) {
			CreateQFileDialogProxy();
			NewQFileDialog();
		}
		private void NewQFileDialog() {
			ProxyQFileDialog().NewQFileDialog();
		}
		public void SetDirectory(string directory) {
			ProxyQFileDialog().SetDirectory(directory);
		}
		public void SetDirectory(QDir directory) {
			ProxyQFileDialog().SetDirectory(directory);
		}
		public QDir Directory() {
			return ProxyQFileDialog().Directory();
		}
		public void SelectFile(string filename) {
			ProxyQFileDialog().SelectFile(filename);
		}
		public ArrayList SelectedFiles() {
			return ProxyQFileDialog().SelectedFiles();
		}
		public void SetFilter(string filter) {
			ProxyQFileDialog().SetFilter(filter);
		}
		public void SetFilters(string[] filters) {
			ProxyQFileDialog().SetFilters(filters);
		}
		public ArrayList Filters() {
			return ProxyQFileDialog().Filters();
		}
		public void SelectFilter(string filter) {
			ProxyQFileDialog().SelectFilter(filter);
		}
		public string SelectedFilter() {
			return ProxyQFileDialog().SelectedFilter();
		}
		public void SetViewMode(int mode) {
			ProxyQFileDialog().SetViewMode(mode);
		}
		public int ViewMode() {
			return ProxyQFileDialog().ViewMode();
		}
		public void SetFileMode(int mode) {
			ProxyQFileDialog().SetFileMode(mode);
		}
		public int FileMode() {
			return ProxyQFileDialog().FileMode();
		}
		public void SetAcceptMode(int mode) {
			ProxyQFileDialog().SetAcceptMode(mode);
		}
		public int AcceptMode() {
			return ProxyQFileDialog().AcceptMode();
		}
		public void SetReadOnly(bool enabled) {
			ProxyQFileDialog().SetReadOnly(enabled);
		}
		public bool IsReadOnly() {
			return ProxyQFileDialog().IsReadOnly();
		}
		public void SetResolveSymlinks(bool enabled) {
			ProxyQFileDialog().SetResolveSymlinks(enabled);
		}
		public bool ResolveSymlinks() {
			return ProxyQFileDialog().ResolveSymlinks();
		}
		public void SetConfirmOverwrite(bool enabled) {
			ProxyQFileDialog().SetConfirmOverwrite(enabled);
		}
		public bool ConfirmOverwrite() {
			return ProxyQFileDialog().ConfirmOverwrite();
		}
		public void SetDefaultSuffix(string suffix) {
			ProxyQFileDialog().SetDefaultSuffix(suffix);
		}
		public string DefaultSuffix() {
			return ProxyQFileDialog().DefaultSuffix();
		}
		public void SetHistory(string[] paths) {
			ProxyQFileDialog().SetHistory(paths);
		}
		public ArrayList History() {
			return ProxyQFileDialog().History();
		}
		public void SetItemDelegate(QAbstractItemDelegate arg1) {
			ProxyQFileDialog().SetItemDelegate(arg1);
		}
		public QAbstractItemDelegate ItemDelegate() {
			return ProxyQFileDialog().ItemDelegate();
		}
		public void SetIconProvider(QFileIconProvider provider) {
			ProxyQFileDialog().SetIconProvider(provider);
		}
		public QFileIconProvider IconProvider() {
			return ProxyQFileDialog().IconProvider();
		}
		public void SetLabelText(int label, string text) {
			ProxyQFileDialog().SetLabelText(label,text);
		}
		public string LabelText(int label) {
			return ProxyQFileDialog().LabelText(label);
		}
		public static new string Tr(string s, string c) {
			return StaticQFileDialog().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQFileDialog().Tr(s);
		}
		public static string GetOpenFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter, int options) {
			return StaticQFileDialog().GetOpenFileName(parent,caption,dir,filter,selectedFilter,options);
		}
		public static string GetOpenFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter) {
			return StaticQFileDialog().GetOpenFileName(parent,caption,dir,filter,selectedFilter);
		}
		public static string GetOpenFileName(QWidget parent, string caption, string dir, string filter) {
			return StaticQFileDialog().GetOpenFileName(parent,caption,dir,filter);
		}
		public static string GetOpenFileName(QWidget parent, string caption, string dir) {
			return StaticQFileDialog().GetOpenFileName(parent,caption,dir);
		}
		public static string GetOpenFileName(QWidget parent, string caption) {
			return StaticQFileDialog().GetOpenFileName(parent,caption);
		}
		public static string GetOpenFileName(QWidget parent) {
			return StaticQFileDialog().GetOpenFileName(parent);
		}
		public static string GetOpenFileName() {
			return StaticQFileDialog().GetOpenFileName();
		}
		public static string GetSaveFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter, int options) {
			return StaticQFileDialog().GetSaveFileName(parent,caption,dir,filter,selectedFilter,options);
		}
		public static string GetSaveFileName(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter) {
			return StaticQFileDialog().GetSaveFileName(parent,caption,dir,filter,selectedFilter);
		}
		public static string GetSaveFileName(QWidget parent, string caption, string dir, string filter) {
			return StaticQFileDialog().GetSaveFileName(parent,caption,dir,filter);
		}
		public static string GetSaveFileName(QWidget parent, string caption, string dir) {
			return StaticQFileDialog().GetSaveFileName(parent,caption,dir);
		}
		public static string GetSaveFileName(QWidget parent, string caption) {
			return StaticQFileDialog().GetSaveFileName(parent,caption);
		}
		public static string GetSaveFileName(QWidget parent) {
			return StaticQFileDialog().GetSaveFileName(parent);
		}
		public static string GetSaveFileName() {
			return StaticQFileDialog().GetSaveFileName();
		}
		public static string GetExistingDirectory(QWidget parent, string caption, string dir, int options) {
			return StaticQFileDialog().GetExistingDirectory(parent,caption,dir,options);
		}
		public static string GetExistingDirectory(QWidget parent, string caption, string dir) {
			return StaticQFileDialog().GetExistingDirectory(parent,caption,dir);
		}
		public static string GetExistingDirectory(QWidget parent, string caption) {
			return StaticQFileDialog().GetExistingDirectory(parent,caption);
		}
		public static string GetExistingDirectory(QWidget parent) {
			return StaticQFileDialog().GetExistingDirectory(parent);
		}
		public static string GetExistingDirectory() {
			return StaticQFileDialog().GetExistingDirectory();
		}
		public static ArrayList GetOpenFileNames(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter, int options) {
			return StaticQFileDialog().GetOpenFileNames(parent,caption,dir,filter,selectedFilter,options);
		}
		public static ArrayList GetOpenFileNames(QWidget parent, string caption, string dir, string filter, StringBuilder selectedFilter) {
			return StaticQFileDialog().GetOpenFileNames(parent,caption,dir,filter,selectedFilter);
		}
		public static ArrayList GetOpenFileNames(QWidget parent, string caption, string dir, string filter) {
			return StaticQFileDialog().GetOpenFileNames(parent,caption,dir,filter);
		}
		public static ArrayList GetOpenFileNames(QWidget parent, string caption, string dir) {
			return StaticQFileDialog().GetOpenFileNames(parent,caption,dir);
		}
		public static ArrayList GetOpenFileNames(QWidget parent, string caption) {
			return StaticQFileDialog().GetOpenFileNames(parent,caption);
		}
		public static ArrayList GetOpenFileNames(QWidget parent) {
			return StaticQFileDialog().GetOpenFileNames(parent);
		}
		public static ArrayList GetOpenFileNames() {
			return StaticQFileDialog().GetOpenFileNames();
		}
		// QFileDialog* QFileDialog(const QFileDialogArgs& arg1); >>>> NOT CONVERTED
		protected new void Done(int result) {
			ProxyQFileDialog().Done(result);
		}
		protected new void Accept() {
			ProxyQFileDialog().Accept();
		}
		~QFileDialog() {
			ProxyQFileDialog().Dispose();
		}
		public new void Dispose() {
			ProxyQFileDialog().Dispose();
		}
	}

	public interface IQFileDialogSignals {
		void FilesSelected(string[] files);
		void CurrentChanged(string path);
	}
}
