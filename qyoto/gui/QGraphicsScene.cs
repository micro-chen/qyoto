//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQGraphicsSceneSignals"></see> for signals emitted by QGraphicsScene
	[SmokeClass("QGraphicsScene")]
	public class QGraphicsScene : QObject, IDisposable {
 		protected QGraphicsScene(Type dummy) : base((Type) null) {}
		[SmokeClass("QGraphicsScene")]
		interface IQGraphicsSceneProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsScene), this);
			_interceptor = (QGraphicsScene) realProxy.GetTransparentProxy();
		}
		private QGraphicsScene ProxyQGraphicsScene() {
			return (QGraphicsScene) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGraphicsScene() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGraphicsSceneProxy), null);
			_staticInterceptor = (IQGraphicsSceneProxy) realProxy.GetTransparentProxy();
		}
		private static IQGraphicsSceneProxy StaticQGraphicsScene() {
			return (IQGraphicsSceneProxy) _staticInterceptor;
		}
		public enum ItemIndexMethod {
			BspTreeIndex = 0,
			NoIndex = -1,
		}
		[Q_PROPERTY("QBrush", "backgroundBrush")]
		public QBrush BackgroundBrush {
			get {
				return Property("backgroundBrush").Value<QBrush>();
			}
			set {
				SetProperty("backgroundBrush", QVariant.FromValue<QBrush>(value));
			}
		}
		[Q_PROPERTY("QBrush", "foregroundBrush")]
		public QBrush ForegroundBrush {
			get {
				return Property("foregroundBrush").Value<QBrush>();
			}
			set {
				SetProperty("foregroundBrush", QVariant.FromValue<QBrush>(value));
			}
		}
		[Q_PROPERTY("QGraphicsScene::ItemIndexMethod", "itemIndexMethod")]
		public QGraphicsScene.ItemIndexMethod itemIndexMethod {
			get {
				return Property("itemIndexMethod").Value<QGraphicsScene.ItemIndexMethod>();
			}
			set {
				SetProperty("itemIndexMethod", QVariant.FromValue<QGraphicsScene.ItemIndexMethod>(value));
			}
		}
		[Q_PROPERTY("QRectF", "sceneRect")]
		public QRectF SceneRect {
			get {
				return Property("sceneRect").Value<QRectF>();
			}
			set {
				SetProperty("sceneRect", QVariant.FromValue<QRectF>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QGraphicsScene(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsScene(parent);
		}
		[SmokeMethod("QGraphicsScene", "(QObject*)", "#")]
		private void NewQGraphicsScene(QObject parent) {
			ProxyQGraphicsScene().NewQGraphicsScene(parent);
		}
		public QGraphicsScene() : this((Type) null) {
			CreateProxy();
			NewQGraphicsScene();
		}
		[SmokeMethod("QGraphicsScene", "()", "")]
		private void NewQGraphicsScene() {
			ProxyQGraphicsScene().NewQGraphicsScene();
		}
		public QGraphicsScene(QRectF sceneRect, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsScene(sceneRect,parent);
		}
		[SmokeMethod("QGraphicsScene", "(const QRectF&, QObject*)", "##")]
		private void NewQGraphicsScene(QRectF sceneRect, QObject parent) {
			ProxyQGraphicsScene().NewQGraphicsScene(sceneRect,parent);
		}
		public QGraphicsScene(QRectF sceneRect) : this((Type) null) {
			CreateProxy();
			NewQGraphicsScene(sceneRect);
		}
		[SmokeMethod("QGraphicsScene", "(const QRectF&)", "#")]
		private void NewQGraphicsScene(QRectF sceneRect) {
			ProxyQGraphicsScene().NewQGraphicsScene(sceneRect);
		}
		public QGraphicsScene(double x, double y, double width, double height, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsScene(x,y,width,height,parent);
		}
		[SmokeMethod("QGraphicsScene", "(qreal, qreal, qreal, qreal, QObject*)", "$$$$#")]
		private void NewQGraphicsScene(double x, double y, double width, double height, QObject parent) {
			ProxyQGraphicsScene().NewQGraphicsScene(x,y,width,height,parent);
		}
		public QGraphicsScene(double x, double y, double width, double height) : this((Type) null) {
			CreateProxy();
			NewQGraphicsScene(x,y,width,height);
		}
		[SmokeMethod("QGraphicsScene", "(qreal, qreal, qreal, qreal)", "$$$$")]
		private void NewQGraphicsScene(double x, double y, double width, double height) {
			ProxyQGraphicsScene().NewQGraphicsScene(x,y,width,height);
		}
		[SmokeMethod("width", "() const", "")]
		public double Width() {
			return ProxyQGraphicsScene().Width();
		}
		[SmokeMethod("height", "() const", "")]
		public double Height() {
			return ProxyQGraphicsScene().Height();
		}
		[SmokeMethod("setSceneRect", "(qreal, qreal, qreal, qreal)", "$$$$")]
		public void SetSceneRect(double x, double y, double w, double h) {
			ProxyQGraphicsScene().SetSceneRect(x,y,w,h);
		}
		[SmokeMethod("render", "(QPainter*, const QRectF&, const QRectF&, Qt::AspectRatioMode)", "###$")]
		public void Render(QPainter painter, QRectF target, QRectF source, Qt.AspectRatioMode aspectRatioMode) {
			ProxyQGraphicsScene().Render(painter,target,source,aspectRatioMode);
		}
		[SmokeMethod("render", "(QPainter*, const QRectF&, const QRectF&)", "###")]
		public void Render(QPainter painter, QRectF target, QRectF source) {
			ProxyQGraphicsScene().Render(painter,target,source);
		}
		[SmokeMethod("render", "(QPainter*, const QRectF&)", "##")]
		public void Render(QPainter painter, QRectF target) {
			ProxyQGraphicsScene().Render(painter,target);
		}
		[SmokeMethod("render", "(QPainter*)", "#")]
		public void Render(QPainter painter) {
			ProxyQGraphicsScene().Render(painter);
		}
		[SmokeMethod("itemsBoundingRect", "() const", "")]
		public QRectF ItemsBoundingRect() {
			return ProxyQGraphicsScene().ItemsBoundingRect();
		}
		[SmokeMethod("items", "() const", "")]
		public List<QGraphicsItem> Items() {
			return ProxyQGraphicsScene().Items();
		}
		[SmokeMethod("items", "(const QPointF&) const", "#")]
		public List<QGraphicsItem> Items(QPointF pos) {
			return ProxyQGraphicsScene().Items(pos);
		}
		[SmokeMethod("items", "(const QRectF&, Qt::ItemSelectionMode) const", "#$")]
		public List<QGraphicsItem> Items(QRectF rect, Qt.ItemSelectionMode mode) {
			return ProxyQGraphicsScene().Items(rect,mode);
		}
		[SmokeMethod("items", "(const QRectF&) const", "#")]
		public List<QGraphicsItem> Items(QRectF rect) {
			return ProxyQGraphicsScene().Items(rect);
		}
		[SmokeMethod("items", "(const QPolygonF&, Qt::ItemSelectionMode) const", "#$")]
		public List<QGraphicsItem> Items(QPolygonF polygon, Qt.ItemSelectionMode mode) {
			return ProxyQGraphicsScene().Items(polygon,mode);
		}
		[SmokeMethod("items", "(const QPolygonF&) const", "#")]
		public List<QGraphicsItem> Items(QPolygonF polygon) {
			return ProxyQGraphicsScene().Items(polygon);
		}
		[SmokeMethod("items", "(const QPainterPath&, Qt::ItemSelectionMode) const", "#$")]
		public List<QGraphicsItem> Items(QPainterPath path, Qt.ItemSelectionMode mode) {
			return ProxyQGraphicsScene().Items(path,mode);
		}
		[SmokeMethod("items", "(const QPainterPath&) const", "#")]
		public List<QGraphicsItem> Items(QPainterPath path) {
			return ProxyQGraphicsScene().Items(path);
		}
		[SmokeMethod("collidingItems", "(const QGraphicsItem*, Qt::ItemSelectionMode) const", "#$")]
		public List<QGraphicsItem> CollidingItems(QGraphicsItem item, Qt.ItemSelectionMode mode) {
			return ProxyQGraphicsScene().CollidingItems(item,mode);
		}
		[SmokeMethod("collidingItems", "(const QGraphicsItem*) const", "#")]
		public List<QGraphicsItem> CollidingItems(QGraphicsItem item) {
			return ProxyQGraphicsScene().CollidingItems(item);
		}
		[SmokeMethod("itemAt", "(const QPointF&) const", "#")]
		public QGraphicsItem ItemAt(QPointF pos) {
			return ProxyQGraphicsScene().ItemAt(pos);
		}
		[SmokeMethod("itemAt", "(qreal, qreal) const", "$$")]
		public QGraphicsItem ItemAt(double x, double y) {
			return ProxyQGraphicsScene().ItemAt(x,y);
		}
		[SmokeMethod("selectedItems", "() const", "")]
		public List<QGraphicsItem> SelectedItems() {
			return ProxyQGraphicsScene().SelectedItems();
		}
		[SmokeMethod("setSelectionArea", "(const QPainterPath&)", "#")]
		public void SetSelectionArea(QPainterPath path) {
			ProxyQGraphicsScene().SetSelectionArea(path);
		}
		[SmokeMethod("clearSelection", "()", "")]
		public void ClearSelection() {
			ProxyQGraphicsScene().ClearSelection();
		}
		[SmokeMethod("createItemGroup", "(const QList<QGraphicsItem*>&)", "?")]
		public QGraphicsItemGroup CreateItemGroup(List<QGraphicsItem> items) {
			return ProxyQGraphicsScene().CreateItemGroup(items);
		}
		[SmokeMethod("destroyItemGroup", "(QGraphicsItemGroup*)", "#")]
		public void DestroyItemGroup(QGraphicsItemGroup group) {
			ProxyQGraphicsScene().DestroyItemGroup(group);
		}
		[SmokeMethod("addItem", "(QGraphicsItem*)", "#")]
		public void AddItem(QGraphicsItem item) {
			ProxyQGraphicsScene().AddItem(item);
		}
		[SmokeMethod("addEllipse", "(const QRectF&, const QPen&, const QBrush&)", "###")]
		public QGraphicsEllipseItem AddEllipse(QRectF rect, QPen pen, QBrush brush) {
			return ProxyQGraphicsScene().AddEllipse(rect,pen,brush);
		}
		[SmokeMethod("addEllipse", "(const QRectF&, const QPen&)", "##")]
		public QGraphicsEllipseItem AddEllipse(QRectF rect, QPen pen) {
			return ProxyQGraphicsScene().AddEllipse(rect,pen);
		}
		[SmokeMethod("addEllipse", "(const QRectF&)", "#")]
		public QGraphicsEllipseItem AddEllipse(QRectF rect) {
			return ProxyQGraphicsScene().AddEllipse(rect);
		}
		[SmokeMethod("addLine", "(const QLineF&, const QPen&)", "##")]
		public QGraphicsLineItem AddLine(QLineF line, QPen pen) {
			return ProxyQGraphicsScene().AddLine(line,pen);
		}
		[SmokeMethod("addLine", "(const QLineF&)", "#")]
		public QGraphicsLineItem AddLine(QLineF line) {
			return ProxyQGraphicsScene().AddLine(line);
		}
		[SmokeMethod("addPath", "(const QPainterPath&, const QPen&, const QBrush&)", "###")]
		public QGraphicsPathItem AddPath(QPainterPath path, QPen pen, QBrush brush) {
			return ProxyQGraphicsScene().AddPath(path,pen,brush);
		}
		[SmokeMethod("addPath", "(const QPainterPath&, const QPen&)", "##")]
		public QGraphicsPathItem AddPath(QPainterPath path, QPen pen) {
			return ProxyQGraphicsScene().AddPath(path,pen);
		}
		[SmokeMethod("addPath", "(const QPainterPath&)", "#")]
		public QGraphicsPathItem AddPath(QPainterPath path) {
			return ProxyQGraphicsScene().AddPath(path);
		}
		[SmokeMethod("addPixmap", "(const QPixmap&)", "#")]
		public QGraphicsPixmapItem AddPixmap(QPixmap pixmap) {
			return ProxyQGraphicsScene().AddPixmap(pixmap);
		}
		[SmokeMethod("addPolygon", "(const QPolygonF&, const QPen&, const QBrush&)", "###")]
		public QGraphicsPolygonItem AddPolygon(QPolygonF polygon, QPen pen, QBrush brush) {
			return ProxyQGraphicsScene().AddPolygon(polygon,pen,brush);
		}
		[SmokeMethod("addPolygon", "(const QPolygonF&, const QPen&)", "##")]
		public QGraphicsPolygonItem AddPolygon(QPolygonF polygon, QPen pen) {
			return ProxyQGraphicsScene().AddPolygon(polygon,pen);
		}
		[SmokeMethod("addPolygon", "(const QPolygonF&)", "#")]
		public QGraphicsPolygonItem AddPolygon(QPolygonF polygon) {
			return ProxyQGraphicsScene().AddPolygon(polygon);
		}
		[SmokeMethod("addRect", "(const QRectF&, const QPen&, const QBrush&)", "###")]
		public QGraphicsRectItem AddRect(QRectF rect, QPen pen, QBrush brush) {
			return ProxyQGraphicsScene().AddRect(rect,pen,brush);
		}
		[SmokeMethod("addRect", "(const QRectF&, const QPen&)", "##")]
		public QGraphicsRectItem AddRect(QRectF rect, QPen pen) {
			return ProxyQGraphicsScene().AddRect(rect,pen);
		}
		[SmokeMethod("addRect", "(const QRectF&)", "#")]
		public QGraphicsRectItem AddRect(QRectF rect) {
			return ProxyQGraphicsScene().AddRect(rect);
		}
		[SmokeMethod("addText", "(const QString&, const QFont&)", "$#")]
		public QGraphicsTextItem AddText(string text, QFont font) {
			return ProxyQGraphicsScene().AddText(text,font);
		}
		[SmokeMethod("addText", "(const QString&)", "$")]
		public QGraphicsTextItem AddText(string text) {
			return ProxyQGraphicsScene().AddText(text);
		}
		[SmokeMethod("removeItem", "(QGraphicsItem*)", "#")]
		public void RemoveItem(QGraphicsItem item) {
			ProxyQGraphicsScene().RemoveItem(item);
		}
		[SmokeMethod("focusItem", "() const", "")]
		public QGraphicsItem FocusItem() {
			return ProxyQGraphicsScene().FocusItem();
		}
		[SmokeMethod("setFocusItem", "(QGraphicsItem*, Qt::FocusReason)", "#$")]
		public void SetFocusItem(QGraphicsItem item, Qt.FocusReason focusReason) {
			ProxyQGraphicsScene().SetFocusItem(item,focusReason);
		}
		[SmokeMethod("setFocusItem", "(QGraphicsItem*)", "#")]
		public void SetFocusItem(QGraphicsItem item) {
			ProxyQGraphicsScene().SetFocusItem(item);
		}
		[SmokeMethod("hasFocus", "() const", "")]
		public bool HasFocus() {
			return ProxyQGraphicsScene().HasFocus();
		}
		[SmokeMethod("setFocus", "(Qt::FocusReason)", "$")]
		public void SetFocus(Qt.FocusReason focusReason) {
			ProxyQGraphicsScene().SetFocus(focusReason);
		}
		[SmokeMethod("setFocus", "()", "")]
		public void SetFocus() {
			ProxyQGraphicsScene().SetFocus();
		}
		[SmokeMethod("clearFocus", "()", "")]
		public void ClearFocus() {
			ProxyQGraphicsScene().ClearFocus();
		}
		[SmokeMethod("mouseGrabberItem", "() const", "")]
		public QGraphicsItem MouseGrabberItem() {
			return ProxyQGraphicsScene().MouseGrabberItem();
		}
		[SmokeMethod("inputMethodQuery", "(Qt::InputMethodQuery) const", "$")]
		public virtual QVariant InputMethodQuery(Qt.InputMethodQuery query) {
			return ProxyQGraphicsScene().InputMethodQuery(query);
		}
		[SmokeMethod("views", "() const", "")]
		public List<QGraphicsView> Views() {
			return ProxyQGraphicsScene().Views();
		}
		[Q_SLOT("void update(const QRectF&)")]
		[SmokeMethod("update", "(const QRectF&)", "#")]
		public void Update(QRectF rect) {
			ProxyQGraphicsScene().Update(rect);
		}
		[Q_SLOT("void update()")]
		[SmokeMethod("update", "()", "")]
		public void Update() {
			ProxyQGraphicsScene().Update();
		}
		[Q_SLOT("void advance()")]
		[SmokeMethod("advance", "()", "")]
		public void Advance() {
			ProxyQGraphicsScene().Advance();
		}
		public static new string Tr(string s, string c) {
			return StaticQGraphicsScene().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQGraphicsScene().Tr(s);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public new bool Event(QEvent arg1) {
			return ProxyQGraphicsScene().Event(arg1);
		}
		[SmokeMethod("contextMenuEvent", "(QGraphicsSceneContextMenuEvent*)", "#")]
		protected virtual void ContextMenuEvent(QGraphicsSceneContextMenuEvent arg1) {
			ProxyQGraphicsScene().ContextMenuEvent(arg1);
		}
		[SmokeMethod("dragEnterEvent", "(QGraphicsSceneDragDropEvent*)", "#")]
		protected virtual void DragEnterEvent(QGraphicsSceneDragDropEvent arg1) {
			ProxyQGraphicsScene().DragEnterEvent(arg1);
		}
		[SmokeMethod("dragMoveEvent", "(QGraphicsSceneDragDropEvent*)", "#")]
		protected virtual void DragMoveEvent(QGraphicsSceneDragDropEvent arg1) {
			ProxyQGraphicsScene().DragMoveEvent(arg1);
		}
		[SmokeMethod("dragLeaveEvent", "(QGraphicsSceneDragDropEvent*)", "#")]
		protected virtual void DragLeaveEvent(QGraphicsSceneDragDropEvent arg1) {
			ProxyQGraphicsScene().DragLeaveEvent(arg1);
		}
		[SmokeMethod("dropEvent", "(QGraphicsSceneDragDropEvent*)", "#")]
		protected virtual void DropEvent(QGraphicsSceneDragDropEvent arg1) {
			ProxyQGraphicsScene().DropEvent(arg1);
		}
		[SmokeMethod("focusInEvent", "(QFocusEvent*)", "#")]
		protected virtual void FocusInEvent(QFocusEvent arg1) {
			ProxyQGraphicsScene().FocusInEvent(arg1);
		}
		[SmokeMethod("focusOutEvent", "(QFocusEvent*)", "#")]
		protected virtual void FocusOutEvent(QFocusEvent arg1) {
			ProxyQGraphicsScene().FocusOutEvent(arg1);
		}
		[SmokeMethod("helpEvent", "(QGraphicsSceneHelpEvent*)", "#")]
		protected virtual void HelpEvent(QGraphicsSceneHelpEvent arg1) {
			ProxyQGraphicsScene().HelpEvent(arg1);
		}
		[SmokeMethod("keyPressEvent", "(QKeyEvent*)", "#")]
		protected virtual void KeyPressEvent(QKeyEvent arg1) {
			ProxyQGraphicsScene().KeyPressEvent(arg1);
		}
		[SmokeMethod("keyReleaseEvent", "(QKeyEvent*)", "#")]
		protected virtual void KeyReleaseEvent(QKeyEvent arg1) {
			ProxyQGraphicsScene().KeyReleaseEvent(arg1);
		}
		[SmokeMethod("mousePressEvent", "(QGraphicsSceneMouseEvent*)", "#")]
		protected virtual void MousePressEvent(QGraphicsSceneMouseEvent arg1) {
			ProxyQGraphicsScene().MousePressEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent", "(QGraphicsSceneMouseEvent*)", "#")]
		protected virtual void MouseMoveEvent(QGraphicsSceneMouseEvent arg1) {
			ProxyQGraphicsScene().MouseMoveEvent(arg1);
		}
		[SmokeMethod("mouseReleaseEvent", "(QGraphicsSceneMouseEvent*)", "#")]
		protected virtual void MouseReleaseEvent(QGraphicsSceneMouseEvent arg1) {
			ProxyQGraphicsScene().MouseReleaseEvent(arg1);
		}
		[SmokeMethod("mouseDoubleClickEvent", "(QGraphicsSceneMouseEvent*)", "#")]
		protected virtual void MouseDoubleClickEvent(QGraphicsSceneMouseEvent arg1) {
			ProxyQGraphicsScene().MouseDoubleClickEvent(arg1);
		}
		[SmokeMethod("wheelEvent", "(QGraphicsSceneWheelEvent*)", "#")]
		protected virtual void WheelEvent(QGraphicsSceneWheelEvent arg1) {
			ProxyQGraphicsScene().WheelEvent(arg1);
		}
		[SmokeMethod("inputMethodEvent", "(QInputMethodEvent*)", "#")]
		protected virtual void InputMethodEvent(QInputMethodEvent arg1) {
			ProxyQGraphicsScene().InputMethodEvent(arg1);
		}
		[SmokeMethod("drawBackground", "(QPainter*, const QRectF&)", "##")]
		protected virtual void DrawBackground(QPainter painter, QRectF rect) {
			ProxyQGraphicsScene().DrawBackground(painter,rect);
		}
		[SmokeMethod("drawForeground", "(QPainter*, const QRectF&)", "##")]
		protected virtual void DrawForeground(QPainter painter, QRectF rect) {
			ProxyQGraphicsScene().DrawForeground(painter,rect);
		}
		// void drawItems(QPainter* arg1,int arg2,QGraphicsItem** arg3,const QStyleOptionGraphicsItem* arg4,QWidget* arg5); >>>> NOT CONVERTED
		// void drawItems(QPainter* arg1,int arg2,QGraphicsItem** arg3,const QStyleOptionGraphicsItem* arg4); >>>> NOT CONVERTED
		~QGraphicsScene() {
			DisposeQGraphicsScene();
		}
		public new void Dispose() {
			DisposeQGraphicsScene();
		}
		[SmokeMethod("~QGraphicsScene", "()", "")]
		private void DisposeQGraphicsScene() {
			ProxyQGraphicsScene().DisposeQGraphicsScene();
		}
		protected new IQGraphicsSceneSignals Emit {
			get {
				return (IQGraphicsSceneSignals) Q_EMIT;
			}
		}
	}

	public interface IQGraphicsSceneSignals : IQObjectSignals {
		[Q_SIGNAL("void changed(const QList<QRectF>&)")]
		void Changed(List<QRectF> region);
		[Q_SIGNAL("void sceneRectChanged(const QRectF&)")]
		void SceneRectChanged(QRectF rect);
	}
}
