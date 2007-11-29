//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  \short A container for a set of QAction objects.
	///  KActionCollection acts as the owning QObject for a set of QAction objects.  It
	///  allows them to be grouped for organized presentation of configuration to the user,
	///  saving + loading of configuration, and optionally for automatic plugging into
	///  specified widget(s).
	///  Additionally, KActionCollection provides several convenience functions for locating
	///  named actions, and actions grouped by QActionGroup.
	///   See <see cref="IKActionCollectionSignals"></see> for signals emitted by KActionCollection
	/// </remarks>		<short>    \short A container for a set of QAction objects.</short>

	[SmokeClass("KActionCollection")]
	public class KActionCollection : QObject, IDisposable {
 		protected KActionCollection(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KActionCollection), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KActionCollection() {
			staticInterceptor = new SmokeInvocation(typeof(KActionCollection), null);
		}
		[Q_PROPERTY("QString", "configGroup")]
		public string ConfigGroup {
			get { return (string) interceptor.Invoke("configGroup", "configGroup()", typeof(string)); }
			set { interceptor.Invoke("setConfigGroup$", "setConfigGroup(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("bool", "configIsGlobal")]
		public bool ConfigIsGlobal {
			get { return (bool) interceptor.Invoke("configIsGlobal", "configIsGlobal()", typeof(bool)); }
			set { interceptor.Invoke("setConfigGlobal$", "setConfigGlobal(bool)", typeof(void), typeof(bool), value); }
		}
		// template<ActionType> ActionType* add(const QString& arg1,const QObject* arg2,const char* arg3); >>>> NOT CONVERTED
		// template<ActionType> ActionType* add(const QString& arg1,const QObject* arg2); >>>> NOT CONVERTED
		// template<ActionType> ActionType* add(const QString& arg1); >>>> NOT CONVERTED
		/// <remarks>
		///  Constructor.  Allows specification of a KComponentData other than the default
		///  global KComponentData, where needed.
		///    </remarks>		<short>    Constructor.</short>
		public KActionCollection(QObject parent, KComponentData cData) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KActionCollection##", "KActionCollection(QObject*, const KComponentData&)", typeof(void), typeof(QObject), parent, typeof(KComponentData), cData);
		}
		public KActionCollection(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KActionCollection#", "KActionCollection(QObject*)", typeof(void), typeof(QObject), parent);
		}
		/// <remarks>
		///  Clears the entire action collection, deleting all actions.
		///    </remarks>		<short>    Clears the entire action collection, deleting all actions.</short>
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		/// <remarks>
		///  Set an associated widget (clears any others).  Associated widgets automatically have all actions
		///  in the action collection added to themselves.
		///  \sa addAssociatedWidget(), removeAssociatedWidget(), clearAssociatedWidgets() and associatedWidgets().
		///    </remarks>		<short>    Set an associated widget (clears any others).</short>
		public void SetAssociatedWidget(QWidget widget) {
			interceptor.Invoke("setAssociatedWidget#", "setAssociatedWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		/// <remarks>
		///  Add an associated widget.  Associated widgets automatically have all actions
		///  in the action collection added to themselves.
		///  \sa setAssociatedWidget(), removeAssociatedWidget(), clearAssociatedWidgets() and associatedWidgets().
		///    </remarks>		<short>    Add an associated widget.</short>
		public void AddAssociatedWidget(QWidget widget) {
			interceptor.Invoke("addAssociatedWidget#", "addAssociatedWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		/// <remarks>
		///  Remove an associated widget.  Removes all actions in this collection from
		///  the removed associated widget.
		///  \sa addAssociatedWidget(), setAssociatedWidget(), clearAssociatedWidgets(), and associatedWidgets().
		///    </remarks>		<short>    Remove an associated widget.</short>
		public void RemoveAssociatedWidget(QWidget widget) {
			interceptor.Invoke("removeAssociatedWidget#", "removeAssociatedWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		/// <remarks>
		///  Clears all associated widgets.  All actions in this collection will be removed
		///  from associated widgets.
		///  \sa addAssociatedWidget(), setAssociatedWidget(), removeAssociatedWidget(), and associatedWidgets().
		///    </remarks>		<short>    Clears all associated widgets.</short>
		public void ClearAssociatedWidgets() {
			interceptor.Invoke("clearAssociatedWidgets", "clearAssociatedWidgets()", typeof(void));
		}
		/// <remarks>
		///  Returns a list of widgets currently associated with this action collection.
		///  Associations are created to enable custom widgets to provide keyboard interactivity
		///  via KActions without having to use QWidget.GrabShortcut().  An example of its use
		///  is katepart, which creates actions for each editor command and then sets its view
		///  as an associated widget.
		///  \sa addAssociatedWidget(), setAssociatedWidget(), removeAssociatedWidget(), and clearAssociatedWidgets().
		///    </remarks>		<short>    Returns a list of widgets currently associated with this action collection.</short>
		public List<QWidget> AssociatedWidgets() {
			return (List<QWidget>) interceptor.Invoke("associatedWidgets", "associatedWidgets() const", typeof(List<QWidget>));
		}
		/// <remarks>
		///  Read all key associations from <code>config.</code>
		///  If <code>config</code> is zero, read all key associations from the
		///  application's configuration file KGlobal.Config(),
		///  in the group set by setConfigGroup().
		///     </remarks>		<short>    Read all key associations from <code>config.</code></short>
		public void ReadSettings(KConfigGroup config) {
			interceptor.Invoke("readSettings#", "readSettings(KConfigGroup*)", typeof(void), typeof(KConfigGroup), config);
		}
		public void ReadSettings() {
			interceptor.Invoke("readSettings", "readSettings()", typeof(void));
		}
		/// <remarks>
		///  Write the current configurable key associations to <code>config</code>,
		///  or (if <code>config</code> is zero) to the application's
		///  configuration file.
		///  \param config Config object to save to, or null to use the application's config object.
		///  \param writeDefaults set to true to write settings which are already at defaults.
		///  \param oneAction pass an action here if you just want to save the values for one action, eg.
		///                   if you know that action is the only one which has changed.
		///     </remarks>		<short>    Write the current configurable key associations to <code>config</code>,  or (if <code>config</code> is zero) to the application's  configuration file.</short>
		public void WriteSettings(KConfigGroup config, bool writeDefaults, QAction oneAction) {
			interceptor.Invoke("writeSettings#$#", "writeSettings(KConfigGroup*, bool, QAction*) const", typeof(void), typeof(KConfigGroup), config, typeof(bool), writeDefaults, typeof(QAction), oneAction);
		}
		public void WriteSettings(KConfigGroup config, bool writeDefaults) {
			interceptor.Invoke("writeSettings#$", "writeSettings(KConfigGroup*, bool) const", typeof(void), typeof(KConfigGroup), config, typeof(bool), writeDefaults);
		}
		public void WriteSettings(KConfigGroup config) {
			interceptor.Invoke("writeSettings#", "writeSettings(KConfigGroup*) const", typeof(void), typeof(KConfigGroup), config);
		}
		public void WriteSettings() {
			interceptor.Invoke("writeSettings", "writeSettings() const", typeof(void));
		}
		/// <remarks>
		///  Returns the number of actions in the collection.
		///  This is equivalent to actions().count().
		///    </remarks>		<short>    Returns the number of actions in the collection.</short>
		public int Count() {
			return (int) interceptor.Invoke("count", "count() const", typeof(int));
		}
		/// <remarks>
		///  Returns whether the action collection is empty or not.
		///    </remarks>		<short>    Returns whether the action collection is empty or not.</short>
		public bool IsEmpty() {
			return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
		}
		/// <remarks>
		///  Return the QAction at position "index" in the action collection.
		///  This is equivalent to actions().value(index);
		///    </remarks>		<short>    Return the QAction  at position "index" in the action collection.</short>
		public QAction Action(int index) {
			return (QAction) interceptor.Invoke("action$", "action(int) const", typeof(QAction), typeof(int), index);
		}
		/// <remarks>
		///  Find the first action with a given \a name in the action collection.
		/// <param> name="name" Name of the KAction, or null to match all actions
		/// </param></remarks>		<return> A pointer to the first KAction in the collection which matches the parameters or
		///  null if nothing matches.
		///    </return>
		/// 		<short>    Find the first action with a given \a name in the action collection.</short>
		public QAction Action(string name) {
			return (QAction) interceptor.Invoke("action$", "action(const QString&) const", typeof(QAction), typeof(string), name);
		}
		/// <remarks>
		///  Returns the list of KActions which belong to this action collection.
		///    </remarks>		<short>    Returns the list of KActions which belong to this action collection.</short>
		public List<QAction> Actions() {
			return (List<QAction>) interceptor.Invoke("actions", "actions() const", typeof(List<QAction>));
		}
		/// <remarks>
		///  Returns the list of KActions without an QAction.ActionGroup() which belong to this action collection.
		///    </remarks>		<short>    Returns the list of KActions without an QAction.ActionGroup() which belong to this action collection.</short>
		public List<QAction> ActionsWithoutGroup() {
			return (List<QAction>) interceptor.Invoke("actionsWithoutGroup", "actionsWithoutGroup() const", typeof(List<QAction>));
		}
		/// <remarks>
		///  Returns the list of all QActionGroups associated with actions in this action collection.
		///    </remarks>		<short>    Returns the list of all QActionGroups associated with actions in this action collection.</short>
		public List<QAction> ActionGroups() {
			return (List<QAction>) interceptor.Invoke("actionGroups", "actionGroups() const", typeof(List<QAction>));
		}
		/// <remarks>
		///  Set the \a componentData associated with this action collection.
		///  \param componentData the KComponentData which is to be associated with this action collection,
		///  or an invalid KComponentData instance to indicate the default KComponentData.
		///    </remarks>		<short>    Set the \a componentData associated with this action collection.</short>
		public void SetComponentData(KComponentData componentData) {
			interceptor.Invoke("setComponentData#", "setComponentData(const KComponentData&)", typeof(void), typeof(KComponentData), componentData);
		}
		/// <remarks> The KComponentData with which this class is associated. </remarks>		<short>   The KComponentData with which this class is associated.</short>
		public KComponentData ComponentData() {
			return (KComponentData) interceptor.Invoke("componentData", "componentData() const", typeof(KComponentData));
		}
		/// <remarks>
		///  The parent KXMLGUIClient, or null if not available.
		///    </remarks>		<short>    The parent KXMLGUIClient, or null if not available.</short>
		public KXMLGUIClient ParentGUIClient() {
			return (KXMLGUIClient) interceptor.Invoke("parentGUIClient", "parentGUIClient() const", typeof(KXMLGUIClient));
		}
		/// <remarks>
		///  Add an action under the given name to the collection.
		///  Inserting an action that was previously inserted under a different name will replace the
		///  old entry, i.e. the action will not be available under the old name anymore but only under
		///  the new one.
		///  Inserting an action under a name that is already used for another action will replace
		///  the other action in the collection.
		/// <param> name="name" The name by which the action be retrieved again from the collection.
		/// </param><param> name="action" The action to add.
		///    </param></remarks>		<short>    Add an action under the given name to the collection.</short>
		public QAction AddAction(string name, QAction action) {
			return (QAction) interceptor.Invoke("addAction$#", "addAction(const QString&, QAction*)", typeof(QAction), typeof(string), name, typeof(QAction), action);
		}
		/// <remarks>
		///  Removes an action from the collection and deletes it.
		/// <param> name="action" The action to remove.
		///    </param></remarks>		<short>    Removes an action from the collection and deletes it.</short>
		public void RemoveAction(QAction action) {
			interceptor.Invoke("removeAction#", "removeAction(QAction*)", typeof(void), typeof(QAction), action);
		}
		/// <remarks>
		///  Removes an action from the collection.
		/// <param> name="action" the action to remove.
		///    </param></remarks>		<short>    Removes an action from the collection.</short>
		public QAction TakeAction(QAction action) {
			return (QAction) interceptor.Invoke("takeAction#", "takeAction(QAction*)", typeof(QAction), typeof(QAction), action);
		}
		/// <remarks>
		///  Creates a new standard action, adds it to the collection and connects the action's triggered() signal to the
		///  specified receiver/member. The newly created action is also returned.
		///  The action can be retrieved later from the collection by its standard name as per
		///  KStandardAction.StdName.
		///    </remarks>		<short>    Creates a new standard action, adds it to the collection and connects the action's triggered() signal to the  specified receiver/member.</short>
		public QAction AddAction(KStandardAction.StandardAction actionType, QObject receiver, string member) {
			return (QAction) interceptor.Invoke("addAction$#$", "addAction(KStandardAction::StandardAction, const QObject*, const char*)", typeof(QAction), typeof(KStandardAction.StandardAction), actionType, typeof(QObject), receiver, typeof(string), member);
		}
		public QAction AddAction(KStandardAction.StandardAction actionType, QObject receiver) {
			return (QAction) interceptor.Invoke("addAction$#", "addAction(KStandardAction::StandardAction, const QObject*)", typeof(QAction), typeof(KStandardAction.StandardAction), actionType, typeof(QObject), receiver);
		}
		public QAction AddAction(KStandardAction.StandardAction actionType) {
			return (QAction) interceptor.Invoke("addAction$", "addAction(KStandardAction::StandardAction)", typeof(QAction), typeof(KStandardAction.StandardAction), actionType);
		}
		/// <remarks>
		///  Creates a new standard action, adds to the collection under the given name and connects the action's triggered() signal to the
		///  specified receiver/member. The newly created action is also returned.
		///  The action can be retrieved later from the collection by the specified name.
		///    </remarks>		<short>    Creates a new standard action, adds to the collection under the given name and connects the action's triggered() signal to the  specified receiver/member.</short>
		public QAction AddAction(KStandardAction.StandardAction actionType, string name, QObject receiver, string member) {
			return (QAction) interceptor.Invoke("addAction$$#$", "addAction(KStandardAction::StandardAction, const QString&, const QObject*, const char*)", typeof(QAction), typeof(KStandardAction.StandardAction), actionType, typeof(string), name, typeof(QObject), receiver, typeof(string), member);
		}
		public QAction AddAction(KStandardAction.StandardAction actionType, string name, QObject receiver) {
			return (QAction) interceptor.Invoke("addAction$$#", "addAction(KStandardAction::StandardAction, const QString&, const QObject*)", typeof(QAction), typeof(KStandardAction.StandardAction), actionType, typeof(string), name, typeof(QObject), receiver);
		}
		public QAction AddAction(KStandardAction.StandardAction actionType, string name) {
			return (QAction) interceptor.Invoke("addAction$$", "addAction(KStandardAction::StandardAction, const QString&)", typeof(QAction), typeof(KStandardAction.StandardAction), actionType, typeof(string), name);
		}
		/// <remarks>
		///  Creates a new action under the given name to the collection and connects the action's triggered()
		///  signal to the specified receiver/member. The newly created action is returned.
		///  Inserting an action that was previously inserted under a different name will replace the
		///  old entry, i.e. the action will not be available under the old name anymore but only under
		///  the new one.
		///  Inserting an action under a name that is already used for another action will replace
		///  the other action in the collection.
		/// <param> name="name" The name by which the action be retrieved again from the collection.
		/// </param><param> name="action" The action to add.
		///    </param></remarks>		<short>    Creates a new action under the given name to the collection and connects the action's triggered()  signal to the specified receiver/member.</short>
		public QAction AddAction(string name, QObject receiver, string member) {
			return (QAction) interceptor.Invoke("addAction$#$", "addAction(const QString&, const QObject*, const char*)", typeof(QAction), typeof(string), name, typeof(QObject), receiver, typeof(string), member);
		}
		public QAction AddAction(string name, QObject receiver) {
			return (QAction) interceptor.Invoke("addAction$#", "addAction(const QString&, const QObject*)", typeof(QAction), typeof(string), name, typeof(QObject), receiver);
		}
		public QAction AddAction(string name) {
			return (QAction) interceptor.Invoke("addAction$", "addAction(const QString&)", typeof(QAction), typeof(string), name);
		}
		/// <remarks>
		///  Creates a new action under the given name, adds it to the collection and connects the action's triggered()
		///  signal to the specified receiver/member. The type of the action is specified by the template
		///  parameter ActionType.
		///    </remarks>		<short>    Creates a new action under the given name, adds it to the collection and connects the action's triggered()  signal to the specified receiver/member.</short>
		[SmokeMethod("connectNotify(const char*)")]
		protected override void ConnectNotify(string signal) {
			interceptor.Invoke("connectNotify$", "connectNotify(const char*)", typeof(void), typeof(string), signal);
		}
		[SmokeMethod("slotActionTriggered()")]
		protected virtual void SlotActionTriggered() {
			interceptor.Invoke("slotActionTriggered", "slotActionTriggered()", typeof(void));
		}
		[SmokeMethod("slotActionHighlighted()")]
		protected virtual void SlotActionHighlighted() {
			interceptor.Invoke("slotActionHighlighted", "slotActionHighlighted()", typeof(void));
		}
		~KActionCollection() {
			interceptor.Invoke("~KActionCollection", "~KActionCollection()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KActionCollection", "~KActionCollection()", typeof(void));
		}
		/// <remarks>
		///  Access the list of all action collections in existence for this app
		///    </remarks>		<short>    Access the list of all action collections in existence for this app    </short>
		public static List<KActionCollection> AllCollections() {
			return (List<KActionCollection>) staticInterceptor.Invoke("allCollections", "allCollections()", typeof(List<KActionCollection>));
		}
		protected new IKActionCollectionSignals Emit {
			get { return (IKActionCollectionSignals) Q_EMIT; }
		}
	}

	public interface IKActionCollectionSignals : IQObjectSignals {
		/// <remarks>
		///  Indicates that \a action was inserted into this action collection.
		///    </remarks>		<short>    Indicates that \a action was inserted into this action collection.</short>
		[Q_SIGNAL("void inserted(QAction*)")]
		void Inserted(QAction action);
		/// <remarks>
		///  Indicates that \a action was removed from this action collection.
		///    </remarks>		<short>    Indicates that \a action was removed from this action collection.</short>
		[Q_SIGNAL("void removed(QAction*)")]
		void Removed(QAction action);
		/// <remarks>
		///  Indicates that \a action was highlighted
		///    </remarks>		<short>    Indicates that \a action was highlighted    </short>
		[Q_SIGNAL("void actionHighlighted(QAction*)")]
		void ActionHighlighted(QAction action);
		/// <remarks>
		///  Indicates that \a action was triggered
		///    </remarks>		<short>    Indicates that \a action was triggered    </short>
		[Q_SIGNAL("void actionTriggered(QAction*)")]
		void ActionTriggered(QAction action);
	}
}