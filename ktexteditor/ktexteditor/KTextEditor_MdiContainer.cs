//Auto-generated by kalyptus. DO NOT EDIT.
namespace KTextEditor {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  A container for MDI-capable kpart hosts.
    ///  The kpart container for the KTextEditor interface may have different
    ///  capabilities. For example, inside KDevelop or Kate, the container can
    ///  manage multiple views and multiple documents. However, if the kpart text
    ///  is used inside konqueror as a replacement of the text entry in html
    ///  forms, the container will only support one view with one document.
    ///  This class allows the kpart component to create and delete views, create
    ///  and delete documents, fetch and set the current view. Note that the
    ///  ktexteditor framework already supports multiple document and views and
    ///  that the kpart host can create them and delete them as it wishes. What
    ///  this class provides is the ability for the <i>kpart component</i> being
    ///  hosted to do the same.
    ///  An instance of this extension should be set with
    ///  ContainerInterface.SetContainerExtension().Check ContainerInterface() to
    ///  see how to obtain an instance of ContainerInterface. The instance should
    ///  inherit QObject, inherit MdiContainer, declare the Q_OBJECT macro and
    ///  declare a Q_INTERFACES(KTextEditor.MdiContainer) .
    ///  Code example to support MdiContainer (in the kpart host):
    ///  <pre>
    ///  class MyMdiContainer : public QObject,
    ///                         public MdiContainer
    ///  {
    ///       Q_INTERFACES( KTextEditor.MdiContainer )
    ///    public      // ...
    ///  }
    ///  </pre>
    ///  To check if the kpart hosts supports the MDI container:
    ///  <pre>
    ///  Editor  editor = KTextEditor.EditorChooser.Editor();
    ///  ContainerInterface  iface = qobject_cast<ContainerInterface >( editor );
    ///  if (iface) {
    ///    MdiContainer  mdiContainer = qobject_cast<MdiContainer >( iface.Container() );
    ///    if (MdiContainer != NULL ) {
    ///     // great, I can create additional views
    ///     // ...
    ///    }
    ///  }
    ///  </pre>
    ///  </remarks>        <short>    A container for MDI-capable kpart hosts.</short>
    [SmokeClass("KTextEditor::MdiContainer")]
    public class MdiContainer : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected MdiContainer(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(MdiContainer), this);
        }
        /// <remarks> Constructor </remarks>        <short>   Constructor </short>
        public MdiContainer() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("MdiContainer", "MdiContainer()", typeof(void));
        }
        /// <remarks>
        ///  Set the <pre>view</pre> requested by the part as the active view.
        ///  \sa activeView
        ///      </remarks>        <short>    Set the \p view requested by the part as the active view.</short>
        [SmokeMethod("setActiveView(KTextEditor::View*)")]
        public virtual void SetActiveView(KTextEditor.View view) {
            interceptor.Invoke("setActiveView#", "setActiveView(KTextEditor::View*)", typeof(void), typeof(KTextEditor.View), view);
        }
        /// <remarks>
        ///  Get the current activew view.
        ///  \return the active view.
        ///  \sa setActiveView
        ///      </remarks>        <short>    Get the current activew view.</short>
        [SmokeMethod("activeView()")]
        public virtual KTextEditor.View ActiveView() {
            return (KTextEditor.View) interceptor.Invoke("activeView", "activeView()", typeof(KTextEditor.View));
        }
        /// <remarks>
        ///  Create a new Document and return it to the kpart.
        ///  Canonical implementation is:
        ///  <pre>
        ///  Document  createDocument()
        ///  {
        ///      Document  doc;
        ///      // set parentQObject to relevant value
        ///      doc = editor.CreateDocument( parentQObject );
        ///      // integrate the new document in the document list of the
        ///      // container, ...
        ///      return doc;
        ///  }
        ///  </pre>
        ///  The signal documentCreated() will be emitted during the creation.
        ///  \return a pointer to the new Document object.
        ///      </remarks>        <short>    Create a new Document and return it to the kpart.</short>
        [SmokeMethod("createDocument()")]
        public virtual KTextEditor.Document CreateDocument() {
            return (KTextEditor.Document) interceptor.Invoke("createDocument", "createDocument()", typeof(KTextEditor.Document));
        }
        /// <remarks>
        ///  Closes of document <pre>doc</pre> .
        ///  The document is about to be closed but is still valid when this
        ///  call is made. The Document does not contain any view when this
        ///  call is made (closeView() has been called on all the views of the
        ///  document previously).
        ///  The signal aboutToClose() is emitted before this method is
        ///  called.
        ///  \return true if the removal is authorized and acted, or
        ///      false if removing documents by the kpart is not supported
        ///      by the container.
        ///      </remarks>        <short>    Closes of document \p doc .</short>
        [SmokeMethod("closeDocument(KTextEditor::Document*)")]
        public virtual bool CloseDocument(KTextEditor.Document doc) {
            return (bool) interceptor.Invoke("closeDocument#", "closeDocument(KTextEditor::Document*)", typeof(bool), typeof(KTextEditor.Document), doc);
        }
        /// <remarks>
        ///  Creates a new View and return it to the kpart.
        ///  Canonical implementation is:
        ///  <pre>
        ///  View  createView( Document  doc )
        ///  {
        ///      // set parentWidget to relevant value
        ///      return doc.CreateView( parentWidget );
        ///  }
        ///  </pre>
        ///  The signal viewCreated() will be emitted during the createView()
        ///  call.
        ///  \return a pointer to the new View created.
        ///      </remarks>        <short>    Creates a new View and return it to the kpart.</short>
        [SmokeMethod("createView(KTextEditor::Document*)")]
        public virtual KTextEditor.View CreateView(KTextEditor.Document doc) {
            return (KTextEditor.View) interceptor.Invoke("createView#", "createView(KTextEditor::Document*)", typeof(KTextEditor.View), typeof(KTextEditor.Document), doc);
        }
        /// <remarks>
        ///  Closes the View <pre>view</pre> .
        ///  The view is still valid when this call is made but will be deleted
        ///  shortly after.
        ///  \return true if the removal is authorized and acted, or
        ///      false if the container does not support view removing from
        ///      the kpart, or
        ///      </remarks>        <short>    Closes the View \p view .</short>
        [SmokeMethod("closeView(KTextEditor::View*)")]
        public virtual bool CloseView(KTextEditor.View view) {
            return (bool) interceptor.Invoke("closeView#", "closeView(KTextEditor::View*)", typeof(bool), typeof(KTextEditor.View), view);
        }
        ~MdiContainer() {
            interceptor.Invoke("~MdiContainer", "~MdiContainer()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~MdiContainer", "~MdiContainer()", typeof(void));
        }
    }
}