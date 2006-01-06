//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QIconViewItem")]
	public class QIconViewItem : Qt, IDisposable {
 		protected QIconViewItem(Type dummy) : base((Type) null) {}
		interface IQIconViewItemProxy {
		}

		protected void CreateQIconViewItemProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QIconViewItem), this);
			_interceptor = (QIconViewItem) realProxy.GetTransparentProxy();
		}
		private QIconViewItem ProxyQIconViewItem() {
			return (QIconViewItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QIconViewItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQIconViewItemProxy), null);
			_staticInterceptor = (IQIconViewItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQIconViewItemProxy StaticQIconViewItem() {
			return (IQIconViewItemProxy) _staticInterceptor;
		}

		public QIconViewItem(QIconView parent) : this((Type) null) {
			CreateQIconViewItemProxy();
			NewQIconViewItem(parent);
		}
		[SmokeMethod("QIconViewItem(QIconView*)")]
		private void NewQIconViewItem(QIconView parent) {
			ProxyQIconViewItem().NewQIconViewItem(parent);
		}
		public QIconViewItem(QIconView parent, QIconViewItem after) : this((Type) null) {
			CreateQIconViewItemProxy();
			NewQIconViewItem(parent,after);
		}
		[SmokeMethod("QIconViewItem(QIconView*, QIconViewItem*)")]
		private void NewQIconViewItem(QIconView parent, QIconViewItem after) {
			ProxyQIconViewItem().NewQIconViewItem(parent,after);
		}
		public QIconViewItem(QIconView parent, string text) : this((Type) null) {
			CreateQIconViewItemProxy();
			NewQIconViewItem(parent,text);
		}
		[SmokeMethod("QIconViewItem(QIconView*, const QString&)")]
		private void NewQIconViewItem(QIconView parent, string text) {
			ProxyQIconViewItem().NewQIconViewItem(parent,text);
		}
		public QIconViewItem(QIconView parent, QIconViewItem after, string text) : this((Type) null) {
			CreateQIconViewItemProxy();
			NewQIconViewItem(parent,after,text);
		}
		[SmokeMethod("QIconViewItem(QIconView*, QIconViewItem*, const QString&)")]
		private void NewQIconViewItem(QIconView parent, QIconViewItem after, string text) {
			ProxyQIconViewItem().NewQIconViewItem(parent,after,text);
		}
		public QIconViewItem(QIconView parent, string text, QPixmap icon) : this((Type) null) {
			CreateQIconViewItemProxy();
			NewQIconViewItem(parent,text,icon);
		}
		[SmokeMethod("QIconViewItem(QIconView*, const QString&, const QPixmap&)")]
		private void NewQIconViewItem(QIconView parent, string text, QPixmap icon) {
			ProxyQIconViewItem().NewQIconViewItem(parent,text,icon);
		}
		public QIconViewItem(QIconView parent, QIconViewItem after, string text, QPixmap icon) : this((Type) null) {
			CreateQIconViewItemProxy();
			NewQIconViewItem(parent,after,text,icon);
		}
		[SmokeMethod("QIconViewItem(QIconView*, QIconViewItem*, const QString&, const QPixmap&)")]
		private void NewQIconViewItem(QIconView parent, QIconViewItem after, string text, QPixmap icon) {
			ProxyQIconViewItem().NewQIconViewItem(parent,after,text,icon);
		}
		public QIconViewItem(QIconView parent, string text, QPicture picture) : this((Type) null) {
			CreateQIconViewItemProxy();
			NewQIconViewItem(parent,text,picture);
		}
		[SmokeMethod("QIconViewItem(QIconView*, const QString&, const QPicture&)")]
		private void NewQIconViewItem(QIconView parent, string text, QPicture picture) {
			ProxyQIconViewItem().NewQIconViewItem(parent,text,picture);
		}
		public QIconViewItem(QIconView parent, QIconViewItem after, string text, QPicture picture) : this((Type) null) {
			CreateQIconViewItemProxy();
			NewQIconViewItem(parent,after,text,picture);
		}
		[SmokeMethod("QIconViewItem(QIconView*, QIconViewItem*, const QString&, const QPicture&)")]
		private void NewQIconViewItem(QIconView parent, QIconViewItem after, string text, QPicture picture) {
			ProxyQIconViewItem().NewQIconViewItem(parent,after,text,picture);
		}
		[SmokeMethod("setRenameEnabled(bool)")]
		public virtual void SetRenameEnabled(bool allow) {
			ProxyQIconViewItem().SetRenameEnabled(allow);
		}
		[SmokeMethod("setDragEnabled(bool)")]
		public virtual void SetDragEnabled(bool allow) {
			ProxyQIconViewItem().SetDragEnabled(allow);
		}
		[SmokeMethod("setDropEnabled(bool)")]
		public virtual void SetDropEnabled(bool allow) {
			ProxyQIconViewItem().SetDropEnabled(allow);
		}
		[SmokeMethod("text() const")]
		public virtual string Text() {
			return ProxyQIconViewItem().Text();
		}
		[SmokeMethod("pixmap() const")]
		public virtual QPixmap Pixmap() {
			return ProxyQIconViewItem().Pixmap();
		}
		[SmokeMethod("picture() const")]
		public virtual QPicture Picture() {
			return ProxyQIconViewItem().Picture();
		}
		[SmokeMethod("key() const")]
		public virtual string Key() {
			return ProxyQIconViewItem().Key();
		}
		[SmokeMethod("renameEnabled() const")]
		public bool RenameEnabled() {
			return ProxyQIconViewItem().RenameEnabled();
		}
		[SmokeMethod("dragEnabled() const")]
		public bool DragEnabled() {
			return ProxyQIconViewItem().DragEnabled();
		}
		[SmokeMethod("dropEnabled() const")]
		public bool DropEnabled() {
			return ProxyQIconViewItem().DropEnabled();
		}
		[SmokeMethod("iconView() const")]
		public QIconView IconView() {
			return ProxyQIconViewItem().IconView();
		}
		[SmokeMethod("prevItem() const")]
		public QIconViewItem PrevItem() {
			return ProxyQIconViewItem().PrevItem();
		}
		[SmokeMethod("nextItem() const")]
		public QIconViewItem NextItem() {
			return ProxyQIconViewItem().NextItem();
		}
		[SmokeMethod("index() const")]
		public int Index() {
			return ProxyQIconViewItem().Index();
		}
		[SmokeMethod("setSelected(bool, bool)")]
		public virtual void SetSelected(bool s, bool cb) {
			ProxyQIconViewItem().SetSelected(s,cb);
		}
		[SmokeMethod("setSelected(bool)")]
		public virtual void SetSelected(bool s) {
			ProxyQIconViewItem().SetSelected(s);
		}
		[SmokeMethod("setSelectable(bool)")]
		public virtual void SetSelectable(bool s) {
			ProxyQIconViewItem().SetSelectable(s);
		}
		[SmokeMethod("isSelected() const")]
		public bool IsSelected() {
			return ProxyQIconViewItem().IsSelected();
		}
		[SmokeMethod("isSelectable() const")]
		public bool IsSelectable() {
			return ProxyQIconViewItem().IsSelectable();
		}
		[SmokeMethod("repaint()")]
		public virtual void Repaint() {
			ProxyQIconViewItem().Repaint();
		}
		[SmokeMethod("move(int, int)")]
		public virtual bool Move(int x, int y) {
			return ProxyQIconViewItem().Move(x,y);
		}
		[SmokeMethod("moveBy(int, int)")]
		public virtual void MoveBy(int dx, int dy) {
			ProxyQIconViewItem().MoveBy(dx,dy);
		}
		[SmokeMethod("move(const QPoint&)")]
		public virtual bool Move(QPoint pnt) {
			return ProxyQIconViewItem().Move(pnt);
		}
		[SmokeMethod("moveBy(const QPoint&)")]
		public virtual void MoveBy(QPoint pnt) {
			ProxyQIconViewItem().MoveBy(pnt);
		}
		[SmokeMethod("rect() const")]
		public QRect Rect() {
			return ProxyQIconViewItem().Rect();
		}
		[SmokeMethod("x() const")]
		public int X() {
			return ProxyQIconViewItem().X();
		}
		[SmokeMethod("y() const")]
		public int Y() {
			return ProxyQIconViewItem().Y();
		}
		[SmokeMethod("width() const")]
		public int Width() {
			return ProxyQIconViewItem().Width();
		}
		[SmokeMethod("height() const")]
		public int Height() {
			return ProxyQIconViewItem().Height();
		}
		[SmokeMethod("size() const")]
		public QSize Size() {
			return ProxyQIconViewItem().Size();
		}
		[SmokeMethod("pos() const")]
		public QPoint Pos() {
			return ProxyQIconViewItem().Pos();
		}
		[SmokeMethod("textRect(bool) const")]
		public QRect TextRect(bool relative) {
			return ProxyQIconViewItem().TextRect(relative);
		}
		[SmokeMethod("textRect() const")]
		public QRect TextRect() {
			return ProxyQIconViewItem().TextRect();
		}
		[SmokeMethod("pixmapRect(bool) const")]
		public QRect PixmapRect(bool relative) {
			return ProxyQIconViewItem().PixmapRect(relative);
		}
		[SmokeMethod("pixmapRect() const")]
		public QRect PixmapRect() {
			return ProxyQIconViewItem().PixmapRect();
		}
		[SmokeMethod("contains(const QPoint&) const")]
		public bool Contains(QPoint pnt) {
			return ProxyQIconViewItem().Contains(pnt);
		}
		[SmokeMethod("intersects(const QRect&) const")]
		public bool Intersects(QRect r) {
			return ProxyQIconViewItem().Intersects(r);
		}
		[SmokeMethod("acceptDrop(const QMimeSource*) const")]
		public virtual bool AcceptDrop(IQMimeSource mime) {
			return ProxyQIconViewItem().AcceptDrop(mime);
		}
		[SmokeMethod("rename()")]
		public void Rename() {
			ProxyQIconViewItem().Rename();
		}
		[SmokeMethod("compare(QIconViewItem*) const")]
		public virtual int Compare(QIconViewItem i) {
			return ProxyQIconViewItem().Compare(i);
		}
		[SmokeMethod("setText(const QString&)")]
		public virtual void SetText(string text) {
			ProxyQIconViewItem().SetText(text);
		}
		[SmokeMethod("setPixmap(const QPixmap&)")]
		public virtual void SetPixmap(QPixmap icon) {
			ProxyQIconViewItem().SetPixmap(icon);
		}
		[SmokeMethod("setPicture(const QPicture&)")]
		public virtual void SetPicture(QPicture icon) {
			ProxyQIconViewItem().SetPicture(icon);
		}
		[SmokeMethod("setText(const QString&, bool, bool)")]
		public virtual void SetText(string text, bool recalc, bool redraw) {
			ProxyQIconViewItem().SetText(text,recalc,redraw);
		}
		[SmokeMethod("setText(const QString&, bool)")]
		public virtual void SetText(string text, bool recalc) {
			ProxyQIconViewItem().SetText(text,recalc);
		}
		[SmokeMethod("setPixmap(const QPixmap&, bool, bool)")]
		public virtual void SetPixmap(QPixmap icon, bool recalc, bool redraw) {
			ProxyQIconViewItem().SetPixmap(icon,recalc,redraw);
		}
		[SmokeMethod("setPixmap(const QPixmap&, bool)")]
		public virtual void SetPixmap(QPixmap icon, bool recalc) {
			ProxyQIconViewItem().SetPixmap(icon,recalc);
		}
		[SmokeMethod("setKey(const QString&)")]
		public virtual void SetKey(string k) {
			ProxyQIconViewItem().SetKey(k);
		}
		[SmokeMethod("rtti() const")]
		public virtual int Rtti() {
			return ProxyQIconViewItem().Rtti();
		}
		[SmokeMethod("removeRenameBox()")]
		protected virtual void RemoveRenameBox() {
			ProxyQIconViewItem().RemoveRenameBox();
		}
		[SmokeMethod("calcRect(const QString&)")]
		protected virtual void CalcRect(string text_) {
			ProxyQIconViewItem().CalcRect(text_);
		}
		[SmokeMethod("calcRect()")]
		protected virtual void CalcRect() {
			ProxyQIconViewItem().CalcRect();
		}
		[SmokeMethod("paintItem(QPainter*, const QColorGroup&)")]
		protected virtual void PaintItem(QPainter p, QColorGroup cg) {
			ProxyQIconViewItem().PaintItem(p,cg);
		}
		[SmokeMethod("paintFocus(QPainter*, const QColorGroup&)")]
		protected virtual void PaintFocus(QPainter p, QColorGroup cg) {
			ProxyQIconViewItem().PaintFocus(p,cg);
		}
		// void dropped(QDropEvent* arg1,const QValueList<QIconDragItem>& arg2); >>>> NOT CONVERTED
		[SmokeMethod("dragEntered()")]
		protected virtual void DragEntered() {
			ProxyQIconViewItem().DragEntered();
		}
		[SmokeMethod("dragLeft()")]
		protected virtual void DragLeft() {
			ProxyQIconViewItem().DragLeft();
		}
		[SmokeMethod("setItemRect(const QRect&)")]
		protected void SetItemRect(QRect r) {
			ProxyQIconViewItem().SetItemRect(r);
		}
		[SmokeMethod("setTextRect(const QRect&)")]
		protected void SetTextRect(QRect r) {
			ProxyQIconViewItem().SetTextRect(r);
		}
		[SmokeMethod("setPixmapRect(const QRect&)")]
		protected void SetPixmapRect(QRect r) {
			ProxyQIconViewItem().SetPixmapRect(r);
		}
		[SmokeMethod("calcTmpText()")]
		protected void CalcTmpText() {
			ProxyQIconViewItem().CalcTmpText();
		}
		[SmokeMethod("tempText() const")]
		protected string TempText() {
			return ProxyQIconViewItem().TempText();
		}
		~QIconViewItem() {
			DisposeQIconViewItem();
		}
		public void Dispose() {
			DisposeQIconViewItem();
		}
		private void DisposeQIconViewItem() {
			ProxyQIconViewItem().DisposeQIconViewItem();
		}
	}
}
