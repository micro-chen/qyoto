//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  The simplest uses of KPassivePopup are by using the various message() static
	///  methods. The position the popup appears at depends on the type of the parent window:
	/// 
	/// <li>
	/// Normal Windows: The popup is placed adjacent to the icon of the window.
	/// </li>
	/// 
	/// <li>
	/// System Tray Windows: The popup is placed adjact to the system tray window itself.
	/// </li>
	/// 
	/// <li>
	/// Skip Taskbar Windows: The popup is placed adjact to the window
	///      itself if it is visible, and at the edge of the desktop otherwise.
	/// </li>
	///  You also have the option of calling show with a QPoint as a parameter that
	///  removes the automatic placing of KPassivePopup and shows it in the point you want.
	///  The most basic use of KPassivePopup displays a popup containing a piece of text:
	///  <pre>
	///     KPassivePopup.Message( "This is the message", this );
	///  </pre>
	///  We can create popups with titles and icons too, as this example shows:
	///  <pre>
	///     QPixmap px;
	///     px.load( "hi32-app-logtracker.png" );
	///     KPassivePopup.Message( "Some title", "This is the main text", px, this );
	///  </pre>
	///  This screenshot shows a popup with both a caption and a main text which is
	///  being displayed next to the toolbar icon of the window that triggered it:
	///  \image html kpassivepopup.png "A passive popup"
	///  For more control over the popup, you can use the setView(QWidget ) method
	///  to create a custom popup.
	///  <pre>
	///     KPassivePopup pop = new KPassivePopup( parent );
	///     KVBox vb = new KVBox( pop );
	///      new QLabel( vb, "<b>Isn't this great?</b>" );
	///     KHBox box = new KHBox( vb );
	///      new QPushButton( "Yes", box );
	///      new QPushButton( "No", box );
	///     pop.SetView( vb );
	///     pop.Show();
	///  </pre>
	///  See <see cref="IKPassivePopupSignals"></see> for signals emitted by KPassivePopup
	/// </remarks>		<author> Sascha Cunz, sascha.cunz@tiscali.de
	///  </author>
	/// 		<short> A dialog-like popup that displays messages without interrupting the user. </short>

	[SmokeClass("KPassivePopup")]
	public class KPassivePopup : QFrame, IDisposable {
 		protected KPassivePopup(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KPassivePopup), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KPassivePopup() {
			staticInterceptor = new SmokeInvocation(typeof(KPassivePopup), null);
		}
		/// <remarks>
		///  Styles that a KPassivePopup can have.
		///      </remarks>		<short>    Styles that a KPassivePopup can have.</short>
		public enum PopupStyle {
			Boxed = 0,
			Balloon = 1,
			CustomStyle = 128,
		}
		[Q_PROPERTY("bool", "autoDelete")]
		public bool AutoDelete {
			get { return (bool) interceptor.Invoke("autoDelete", "autoDelete()", typeof(bool)); }
			set { interceptor.Invoke("setAutoDelete$", "setAutoDelete(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("int", "timeout")]
		public int Timeout {
			get { return (int) interceptor.Invoke("timeout", "timeout()", typeof(int)); }
			set { interceptor.Invoke("setTimeout$", "setTimeout(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("QRect", "defaultArea")]
		public QRect DefaultArea {
			get { return (QRect) interceptor.Invoke("defaultArea", "defaultArea()", typeof(QRect)); }
		}
		/// <remarks>
		///  Creates a popup for the specified widget.
		///      </remarks>		<short>    Creates a popup for the specified widget.</short>
		public KPassivePopup(QWidget parent, uint f) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPassivePopup#$", "KPassivePopup(QWidget*, Qt::WFlags)", typeof(void), typeof(QWidget), parent, typeof(uint), f);
		}
		public KPassivePopup(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPassivePopup#", "KPassivePopup(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KPassivePopup() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPassivePopup", "KPassivePopup()", typeof(void));
		}
		/// <remarks>
		///  Creates a popup for the specified window.
		///      </remarks>		<short>    Creates a popup for the specified window.</short>
		public KPassivePopup(uint parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPassivePopup$", "KPassivePopup(WId)", typeof(void), typeof(uint), parent);
		}
		/// <remarks>
		///  Sets the main view to be the specified widget (which must be a child of the popup).
		///      </remarks>		<short>    Sets the main view to be the specified widget (which must be a child of the popup).</short>
		public void SetView(QWidget child) {
			interceptor.Invoke("setView#", "setView(QWidget*)", typeof(void), typeof(QWidget), child);
		}
		/// <remarks>
		///  Creates a standard view then calls setView(QWidget) .
		///      </remarks>		<short>    Creates a standard view then calls setView(QWidget ) .</short>
		public void SetView(string caption, string text) {
			interceptor.Invoke("setView$$", "setView(const QString&, const QString&)", typeof(void), typeof(string), caption, typeof(string), text);
		}
		public void SetView(string caption) {
			interceptor.Invoke("setView$", "setView(const QString&)", typeof(void), typeof(string), caption);
		}
		/// <remarks>
		///  Creates a standard view then calls setView(QWidget) .
		///      </remarks>		<short>    Creates a standard view then calls setView(QWidget ) .</short>
		[SmokeMethod("setView(const QString&, const QString&, const QPixmap&)")]
		public virtual void SetView(string caption, string text, QPixmap icon) {
			interceptor.Invoke("setView$$#", "setView(const QString&, const QString&, const QPixmap&)", typeof(void), typeof(string), caption, typeof(string), text, typeof(QPixmap), icon);
		}
		/// <remarks>
		///  Returns a widget that is used as standard view if one of the
		///  setView() methods taking the string arguments is used.
		///  You can use the returned widget to customize the passivepopup while
		///  keeping the look similar to the "standard" passivepopups.
		///  After customizing the widget, pass it to setView( QWidget )
		/// <param> name="caption" The window caption (title) on the popup
		/// </param><param> name="text" The text for the popup
		/// </param><param> name="icon" The icon to use for the popup
		/// </param><param> name="parent" The parent widget used for the returned KVBox. If left null,
		///  then "this", i.e. the passive popup object will be used.
		/// </param></remarks>		<return> a KVBox containing the given arguments, looking like the
		///  standard passivepopups.
		/// </return>
		/// 		<short>    Returns a widget that is used as standard view if one of the  setView() methods taking the string arguments is used.</short>
		/// 		<see> setView(</see>
		/// 		<see> QWidget</see>
		/// 		<see> setView(</see>
		/// 		<see> const</see>
		/// 		<see> const</see>
		/// 		<see> setView(</see>
		/// 		<see> const</see>
		/// 		<see> const</see>
		/// 		<see> const</see>
		/// 		<see> QPixmap&</see>
		public KVBox StandardView(string caption, string text, QPixmap icon, QWidget parent) {
			return (KVBox) interceptor.Invoke("standardView$$##", "standardView(const QString&, const QString&, const QPixmap&, QWidget*)", typeof(KVBox), typeof(string), caption, typeof(string), text, typeof(QPixmap), icon, typeof(QWidget), parent);
		}
		public KVBox StandardView(string caption, string text, QPixmap icon) {
			return (KVBox) interceptor.Invoke("standardView$$#", "standardView(const QString&, const QString&, const QPixmap&)", typeof(KVBox), typeof(string), caption, typeof(string), text, typeof(QPixmap), icon);
		}
		/// <remarks>
		///  Returns the main view.
		///      </remarks>		<short>    Returns the main view.</short>
		public QWidget View() {
			return (QWidget) interceptor.Invoke("view", "view() const", typeof(QWidget));
		}
		/// <remarks>
		///  Enables / disables auto-deletion of this widget when the timeout
		///  occurs.
		///  The default is false. If you use the class-methods message(),
		///  auto-delection is turned on by default.
		///      </remarks>		<short>    Enables / disables auto-deletion of this widget when the timeout  occurs.</short>
		[SmokeMethod("setAutoDelete(bool)")]
		public virtual void SetAutoDelete(bool autoDelete) {
			interceptor.Invoke("setAutoDelete$", "setAutoDelete(bool)", typeof(void), typeof(bool), autoDelete);
		}
		/// <remarks>
		///  Returns the position to which this popup is anchored.
		///      </remarks>		<short>    Returns the position to which this popup is anchored.</short>
		public QPoint Anchor() {
			return (QPoint) interceptor.Invoke("anchor", "anchor() const", typeof(QPoint));
		}
		/// <remarks>
		///  Sets the anchor of this popup. The popup tries automatically to adjust
		///  itself somehow around the point.
		///      </remarks>		<short>    Sets the anchor of this popup.</short>
		public void SetAnchor(QPoint anchor) {
			interceptor.Invoke("setAnchor#", "setAnchor(const QPoint&)", typeof(void), typeof(QPoint), anchor);
		}
		/// <remarks>
		///  Sets the delay for the popup is removed automatically. Setting the delay to 0
		///  disables the timeout, if you're doing this, you may want to connect the
		///  clicked() signal to the hide() slot.
		///  Setting the delay to -1 makes it use the default value.
		/// </remarks>		<short>    Sets the delay for the popup is removed automatically.</short>
		/// 		<see> timeout</see>
		[Q_SLOT("void setTimeout(int)")]
		public void SetTimeout(int delay) {
			interceptor.Invoke("setTimeout$", "setTimeout(int)", typeof(void), typeof(int), delay);
		}
		/// <remarks>
		///  Sets the visual appearance of the popup.
		/// </remarks>		<short>    Sets the visual appearance of the popup.</short>
		/// 		<see> PopupStyle</see>
		[Q_SLOT("void setPopupStyle(int)")]
		public void SetPopupStyle(int popupstyle) {
			interceptor.Invoke("setPopupStyle$", "setPopupStyle(int)", typeof(void), typeof(int), popupstyle);
		}
		/// <remarks>
		///  Reimplemented to reposition the popup.
		///      </remarks>		<short>    Reimplemented to reposition the popup.</short>
		[Q_SLOT("void show()")]
		public new void Show() {
			interceptor.Invoke("show", "show()", typeof(void));
		}
		/// <remarks>
		///  Shows the popup in the given point
		///      </remarks>		<short>    Shows the popup in the given point      </short>
		[Q_SLOT("void show(const QPoint&)")]
		public void Show(QPoint p) {
			interceptor.Invoke("show#", "show(const QPoint&)", typeof(void), typeof(QPoint), p);
		}
		[Q_SLOT("void setVisible(bool)")]
		[SmokeMethod("setVisible(bool)")]
		public override void SetVisible(bool visible) {
			interceptor.Invoke("setVisible$", "setVisible(bool)", typeof(void), typeof(bool), visible);
		}
		/// <remarks>
		///  This method positions the popup.
		///      </remarks>		<short>    This method positions the popup.</short>
		[SmokeMethod("positionSelf()")]
		protected virtual void PositionSelf() {
			interceptor.Invoke("positionSelf", "positionSelf()", typeof(void));
		}
		/// <remarks>
		///  Reimplemented to destroy the object when autoDelete() is
		///  enabled.
		///      </remarks>		<short>    Reimplemented to destroy the object when autoDelete() is  enabled.</short>
		[SmokeMethod("hideEvent(QHideEvent*)")]
		protected override void HideEvent(QHideEvent arg1) {
			interceptor.Invoke("hideEvent#", "hideEvent(QHideEvent*)", typeof(void), typeof(QHideEvent), arg1);
		}
		/// <remarks>
		///  Moves the popup to be adjacent to the icon of the specified rectangle.
		///      </remarks>		<short>    Moves the popup to be adjacent to the icon of the specified rectangle.</short>
		protected void MoveNear(QRect target) {
			interceptor.Invoke("moveNear#", "moveNear(const QRect&)", typeof(void), typeof(QRect), target);
		}
		/// <remarks>
		///  Calculates the position to place the popup near the specified rectangle.
		///      </remarks>		<short>    Calculates the position to place the popup near the specified rectangle.</short>
		protected QPoint CalculateNearbyPoint(QRect target) {
			return (QPoint) interceptor.Invoke("calculateNearbyPoint#", "calculateNearbyPoint(const QRect&)", typeof(QPoint), typeof(QRect), target);
		}
		/// <remarks>
		///  Reimplemented to detect mouse clicks.
		///      </remarks>		<short>    Reimplemented to detect mouse clicks.</short>
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected override void MouseReleaseEvent(QMouseEvent e) {
			interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), e);
		}
		/// <remarks>
		///  Updates the transparency mask. Unused if PopupStyle == Boxed
		///      </remarks>		<short>    Updates the transparency mask.</short>
		protected void UpdateMask() {
			interceptor.Invoke("updateMask", "updateMask()", typeof(void));
		}
		/// <remarks>
		///  Overwrite to paint the border when PopupStyle == Balloon.
		///  Unused if PopupStyle == Boxed
		///      </remarks>		<short>    Overwrite to paint the border when PopupStyle == Balloon.</short>
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent pe) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), pe);
		}
		~KPassivePopup() {
			interceptor.Invoke("~KPassivePopup", "~KPassivePopup()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KPassivePopup", "~KPassivePopup()", typeof(void));
		}
		/// <remarks>
		///  Convenience method that displays popup with the specified  message  beside the
		///  icon of the specified widget.
		///  Note that the returned object is destroyed when it is hidden.
		/// </remarks>		<short>    Convenience method that displays popup with the specified  message  beside the  icon of the specified widget.</short>
		/// 		<see> setAutoDelete</see>
		public static KPassivePopup Message(string text, QWidget parent) {
			return (KPassivePopup) staticInterceptor.Invoke("message$#", "message(const QString&, QWidget*)", typeof(KPassivePopup), typeof(string), text, typeof(QWidget), parent);
		}
		/// <remarks>
		///  Convenience method that displays popup with the specified  message  beside the
		///  icon of the specified QSystemTrayIcon.
		///  Note that the returned object is destroyed when it is hidden.
		/// </remarks>		<short>    Convenience method that displays popup with the specified  message  beside the  icon of the specified QSystemTrayIcon.</short>
		/// 		<see> setAutoDelete</see>
		public static KPassivePopup Message(string text, QSystemTrayIcon parent) {
			return (KPassivePopup) staticInterceptor.Invoke("message$#", "message(const QString&, QSystemTrayIcon*)", typeof(KPassivePopup), typeof(string), text, typeof(QSystemTrayIcon), parent);
		}
		/// <remarks>
		///  Convenience method that displays popup with the specified caption and message
		///  beside the icon of the specified widget.
		///  Note that the returned object is destroyed when it is hidden.
		/// </remarks>		<short>    Convenience method that displays popup with the specified caption and message  beside the icon of the specified widget.</short>
		/// 		<see> setAutoDelete</see>
		public static KPassivePopup Message(string caption, string text, QWidget parent) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$#", "message(const QString&, const QString&, QWidget*)", typeof(KPassivePopup), typeof(string), caption, typeof(string), text, typeof(QWidget), parent);
		}
		/// <remarks>
		///  Convenience method that displays popup with the specified caption and message
		///  beside the icon of the specified QSystemTrayIcon.
		///  Note that the returned object is destroyed when it is hidden.
		/// </remarks>		<short>    Convenience method that displays popup with the specified caption and message  beside the icon of the specified QSystemTrayIcon.</short>
		/// 		<see> setAutoDelete</see>
		public static KPassivePopup Message(string caption, string text, QSystemTrayIcon parent) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$#", "message(const QString&, const QString&, QSystemTrayIcon*)", typeof(KPassivePopup), typeof(string), caption, typeof(string), text, typeof(QSystemTrayIcon), parent);
		}
		/// <remarks>
		///  Convenience method that displays popup with the specified icon, caption and
		///  message beside the icon of the specified widget.
		///  Note that the returned object is destroyed when it is hidden.
		/// </remarks>		<short>    Convenience method that displays popup with the specified icon, caption and  message beside the icon of the specified widget.</short>
		/// 		<see> setAutoDelete</see>
		public static KPassivePopup Message(string caption, string text, QPixmap icon, QWidget parent, int timeout) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$##$", "message(const QString&, const QString&, const QPixmap&, QWidget*, int)", typeof(KPassivePopup), typeof(string), caption, typeof(string), text, typeof(QPixmap), icon, typeof(QWidget), parent, typeof(int), timeout);
		}
		public static KPassivePopup Message(string caption, string text, QPixmap icon, QWidget parent) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$##", "message(const QString&, const QString&, const QPixmap&, QWidget*)", typeof(KPassivePopup), typeof(string), caption, typeof(string), text, typeof(QPixmap), icon, typeof(QWidget), parent);
		}
		/// <remarks>
		///  Convenience method that displays popup with the specified icon, caption and
		///  message beside the icon of the specified QSystemTrayIcon.
		///  Note that the returned object is destroyed when it is hidden.
		/// </remarks>		<short>    Convenience method that displays popup with the specified icon, caption and  message beside the icon of the specified QSystemTrayIcon.</short>
		/// 		<see> setAutoDelete</see>
		public static KPassivePopup Message(string caption, string text, QPixmap icon, QSystemTrayIcon parent, int timeout) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$##$", "message(const QString&, const QString&, const QPixmap&, QSystemTrayIcon*, int)", typeof(KPassivePopup), typeof(string), caption, typeof(string), text, typeof(QPixmap), icon, typeof(QSystemTrayIcon), parent, typeof(int), timeout);
		}
		public static KPassivePopup Message(string caption, string text, QPixmap icon, QSystemTrayIcon parent) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$##", "message(const QString&, const QString&, const QPixmap&, QSystemTrayIcon*)", typeof(KPassivePopup), typeof(string), caption, typeof(string), text, typeof(QPixmap), icon, typeof(QSystemTrayIcon), parent);
		}
		/// <remarks>
		///  Convenience method that displays popup with the specified icon, caption and
		///  message beside the icon of the specified window.
		///  Note that the returned object is destroyed when it is hidden.
		/// </remarks>		<short>    Convenience method that displays popup with the specified icon, caption and  message beside the icon of the specified window.</short>
		/// 		<see> setAutoDelete</see>
		public static KPassivePopup Message(string caption, string text, QPixmap icon, uint parent, int timeout) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$#$$", "message(const QString&, const QString&, const QPixmap&, WId, int)", typeof(KPassivePopup), typeof(string), caption, typeof(string), text, typeof(QPixmap), icon, typeof(uint), parent, typeof(int), timeout);
		}
		public static KPassivePopup Message(string caption, string text, QPixmap icon, uint parent) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$#$", "message(const QString&, const QString&, const QPixmap&, WId)", typeof(KPassivePopup), typeof(string), caption, typeof(string), text, typeof(QPixmap), icon, typeof(uint), parent);
		}
		/// <remarks>
		///  Convenience method that displays popup with the specified popup-style and message beside the
		///  icon of the specified widget.
		///  Note that the returned object is destroyed when it is hidden.
		/// </remarks>		<short>    Convenience method that displays popup with the specified popup-style and message beside the  icon of the specified widget.</short>
		/// 		<see> setAutoDelete</see>
		public static KPassivePopup Message(int popupStyle, string text, QWidget parent) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$#", "message(int, const QString&, QWidget*)", typeof(KPassivePopup), typeof(int), popupStyle, typeof(string), text, typeof(QWidget), parent);
		}
		/// <remarks>
		///  Convenience method that displays popup with the specified popup-style and message beside the
		///  icon of the specified QSystemTrayIcon.
		///  Note that the returned object is destroyed when it is hidden.
		/// </remarks>		<short>    Convenience method that displays popup with the specified popup-style and message beside the  icon of the specified QSystemTrayIcon.</short>
		/// 		<see> setAutoDelete</see>
		public static KPassivePopup Message(int popupStyle, string text, QSystemTrayIcon parent) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$#", "message(int, const QString&, QSystemTrayIcon*)", typeof(KPassivePopup), typeof(int), popupStyle, typeof(string), text, typeof(QSystemTrayIcon), parent);
		}
		/// <remarks>
		///  Convenience method that displays popup with the specified popup-style, caption and message
		///  beside the icon of the specified QSystemTrayIcon.
		///  Note that the returned object is destroyed when it is hidden.
		/// </remarks>		<short>    Convenience method that displays popup with the specified popup-style, caption and message  beside the icon of the specified QSystemTrayIcon.</short>
		/// 		<see> setAutoDelete</see>
		public static KPassivePopup Message(int popupStyle, string caption, string text, QSystemTrayIcon parent) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$$#", "message(int, const QString&, const QString&, QSystemTrayIcon*)", typeof(KPassivePopup), typeof(int), popupStyle, typeof(string), caption, typeof(string), text, typeof(QSystemTrayIcon), parent);
		}
		/// <remarks>
		///  Convenience method that displays popup with the specified popup-style, caption and message
		///  beside the icon of the specified widget.
		///  Note that the returned object is destroyed when it is hidden.
		/// </remarks>		<short>    Convenience method that displays popup with the specified popup-style, caption and message  beside the icon of the specified widget.</short>
		/// 		<see> setAutoDelete</see>
		public static KPassivePopup Message(int popupStyle, string caption, string text, QWidget parent) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$$#", "message(int, const QString&, const QString&, QWidget*)", typeof(KPassivePopup), typeof(int), popupStyle, typeof(string), caption, typeof(string), text, typeof(QWidget), parent);
		}
		/// <remarks>
		///  Convenience method that displays popup with the specified popup-style, icon, caption and
		///  message beside the icon of the specified widget.
		///  Note that the returned object is destroyed when it is hidden.
		/// </remarks>		<short>    Convenience method that displays popup with the specified popup-style, icon, caption and  message beside the icon of the specified widget.</short>
		/// 		<see> setAutoDelete</see>
		public static KPassivePopup Message(int popupStyle, string caption, string text, QPixmap icon, QWidget parent, int timeout) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$$##$", "message(int, const QString&, const QString&, const QPixmap&, QWidget*, int)", typeof(KPassivePopup), typeof(int), popupStyle, typeof(string), caption, typeof(string), text, typeof(QPixmap), icon, typeof(QWidget), parent, typeof(int), timeout);
		}
		public static KPassivePopup Message(int popupStyle, string caption, string text, QPixmap icon, QWidget parent) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$$##", "message(int, const QString&, const QString&, const QPixmap&, QWidget*)", typeof(KPassivePopup), typeof(int), popupStyle, typeof(string), caption, typeof(string), text, typeof(QPixmap), icon, typeof(QWidget), parent);
		}
		/// <remarks>
		///  Convenience method that displays popup with the specified popup-style, icon, caption and
		///  message beside the icon of the specified QSystemTrayIcon.
		///  Note that the returned object is destroyed when it is hidden.
		/// </remarks>		<short>    Convenience method that displays popup with the specified popup-style, icon, caption and  message beside the icon of the specified QSystemTrayIcon.</short>
		/// 		<see> setAutoDelete</see>
		public static KPassivePopup Message(int popupStyle, string caption, string text, QPixmap icon, QSystemTrayIcon parent, int timeout) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$$##$", "message(int, const QString&, const QString&, const QPixmap&, QSystemTrayIcon*, int)", typeof(KPassivePopup), typeof(int), popupStyle, typeof(string), caption, typeof(string), text, typeof(QPixmap), icon, typeof(QSystemTrayIcon), parent, typeof(int), timeout);
		}
		public static KPassivePopup Message(int popupStyle, string caption, string text, QPixmap icon, QSystemTrayIcon parent) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$$##", "message(int, const QString&, const QString&, const QPixmap&, QSystemTrayIcon*)", typeof(KPassivePopup), typeof(int), popupStyle, typeof(string), caption, typeof(string), text, typeof(QPixmap), icon, typeof(QSystemTrayIcon), parent);
		}
		/// <remarks>
		///  Convenience method that displays popup with the specified popup-style, icon, caption and
		///  message beside the icon of the specified window.
		///  Note that the returned object is destroyed when it is hidden.
		/// </remarks>		<short>    Convenience method that displays popup with the specified popup-style, icon, caption and  message beside the icon of the specified window.</short>
		/// 		<see> setAutoDelete</see>
		public static KPassivePopup Message(int popupStyle, string caption, string text, QPixmap icon, uint parent, int timeout) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$$#$$", "message(int, const QString&, const QString&, const QPixmap&, WId, int)", typeof(KPassivePopup), typeof(int), popupStyle, typeof(string), caption, typeof(string), text, typeof(QPixmap), icon, typeof(uint), parent, typeof(int), timeout);
		}
		public static KPassivePopup Message(int popupStyle, string caption, string text, QPixmap icon, uint parent) {
			return (KPassivePopup) staticInterceptor.Invoke("message$$$#$", "message(int, const QString&, const QString&, const QPixmap&, WId)", typeof(KPassivePopup), typeof(int), popupStyle, typeof(string), caption, typeof(string), text, typeof(QPixmap), icon, typeof(uint), parent);
		}
		protected new IKPassivePopupSignals Emit {
			get { return (IKPassivePopupSignals) Q_EMIT; }
		}
	}

	public interface IKPassivePopupSignals : IQFrameSignals {
		/// <remarks>
		///  Emitted when the popup is clicked.
		///      </remarks>		<short>    Emitted when the popup is clicked.</short>
		[Q_SIGNAL("void clicked()")]
		void Clicked();
		/// <remarks>
		///  Emitted when the popup is clicked.
		///      </remarks>		<short>    Emitted when the popup is clicked.</short>
		[Q_SIGNAL("void clicked(const QPoint&)")]
		void Clicked(QPoint pos);
	}
}