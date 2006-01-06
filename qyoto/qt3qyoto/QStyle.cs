//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QStyle")]
	public class QStyle : QObject {
 		protected QStyle(Type dummy) : base((Type) null) {}
		interface IQStyleProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
			QRect VisualRect(QRect logical, QWidget w);
			QRect VisualRect(QRect logical, QRect bounding);
		}

		protected void CreateQStyleProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyle), this);
			_interceptor = (QStyle) realProxy.GetTransparentProxy();
		}
		private QStyle ProxyQStyle() {
			return (QStyle) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyle() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleProxy), null);
			_staticInterceptor = (IQStyleProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleProxy StaticQStyle() {
			return (IQStyleProxy) _staticInterceptor;
		}

		enum PrimitiveElement {
			PE_ButtonCommand = 0,
			PE_ButtonDefault = 1,
			PE_ButtonBevel = 2,
			PE_ButtonTool = 3,
			PE_ButtonDropDown = 4,
			PE_FocusRect = 5,
			PE_ArrowUp = 6,
			PE_ArrowDown = 7,
			PE_ArrowRight = 8,
			PE_ArrowLeft = 9,
			PE_SpinWidgetUp = 10,
			PE_SpinWidgetDown = 11,
			PE_SpinWidgetPlus = 12,
			PE_SpinWidgetMinus = 13,
			PE_Indicator = 14,
			PE_IndicatorMask = 15,
			PE_ExclusiveIndicator = 16,
			PE_ExclusiveIndicatorMask = 17,
			PE_DockWindowHandle = 18,
			PE_DockWindowSeparator = 19,
			PE_DockWindowResizeHandle = 20,
			PE_Splitter = 21,
			PE_Panel = 22,
			PE_PanelPopup = 23,
			PE_PanelMenuBar = 24,
			PE_PanelDockWindow = 25,
			PE_TabBarBase = 26,
			PE_HeaderSection = 27,
			PE_HeaderArrow = 28,
			PE_StatusBarSection = 29,
			PE_GroupBoxFrame = 30,
			PE_Separator = 31,
			PE_SizeGrip = 32,
			PE_CheckMark = 33,
			PE_ScrollBarAddLine = 34,
			PE_ScrollBarSubLine = 35,
			PE_ScrollBarAddPage = 36,
			PE_ScrollBarSubPage = 37,
			PE_ScrollBarSlider = 38,
			PE_ScrollBarFirst = 39,
			PE_ScrollBarLast = 40,
			PE_ProgressBarChunk = 41,
			PE_PanelLineEdit = 42,
			PE_PanelTabWidget = 43,
			PE_WindowFrame = 44,
			PE_CheckListController = 45,
			PE_CheckListIndicator = 46,
			PE_CheckListExclusiveIndicator = 47,
			PE_PanelGroupBox = 48,
			PE_RubberBand = 49,
			PE_CustomBase = 0xf000000,
		}
		enum StyleFlags {
			Style_Default = 0x00000000,
			Style_Enabled = 0x00000001,
			Style_Raised = 0x00000002,
			Style_Sunken = 0x00000004,
			Style_Off = 0x00000008,
			Style_NoChange = 0x00000010,
			Style_On = 0x00000020,
			Style_Down = 0x00000040,
			Style_Horizontal = 0x00000080,
			Style_HasFocus = 0x00000100,
			Style_Top = 0x00000200,
			Style_Bottom = 0x00000400,
			Style_FocusAtBorder = 0x00000800,
			Style_AutoRaise = 0x00001000,
			Style_MouseOver = 0x00002000,
			Style_Up = 0x00004000,
			Style_Selected = 0x00008000,
			Style_Active = 0x00010000,
			Style_ButtonDefault = 0x00020000,
		}
		enum ControlElement : uint {
			CE_PushButton = 0,
			CE_PushButtonLabel = 1,
			CE_CheckBox = 2,
			CE_CheckBoxLabel = 3,
			CE_RadioButton = 4,
			CE_RadioButtonLabel = 5,
			CE_TabBarTab = 6,
			CE_TabBarLabel = 7,
			CE_ProgressBarGroove = 8,
			CE_ProgressBarContents = 9,
			CE_ProgressBarLabel = 10,
			CE_PopupMenuItem = 11,
			CE_MenuBarItem = 12,
			CE_ToolButtonLabel = 13,
			CE_MenuBarEmptyArea = 14,
			CE_PopupMenuScroller = 15,
			CE_DockWindowEmptyArea = 16,
			CE_PopupMenuVerticalExtra = 17,
			CE_PopupMenuHorizontalExtra = 18,
			CE_ToolBoxTab = 19,
			CE_HeaderLabel = 20,
			CE_CustomBase = 0xf0000000,
		}
		enum E_SubRect : uint {
			SR_PushButtonContents = 0,
			SR_PushButtonFocusRect = 1,
			SR_CheckBoxIndicator = 2,
			SR_CheckBoxContents = 3,
			SR_CheckBoxFocusRect = 4,
			SR_RadioButtonIndicator = 5,
			SR_RadioButtonContents = 6,
			SR_RadioButtonFocusRect = 7,
			SR_ComboBoxFocusRect = 8,
			SR_SliderFocusRect = 9,
			SR_DockWindowHandleRect = 10,
			SR_ProgressBarGroove = 11,
			SR_ProgressBarContents = 12,
			SR_ProgressBarLabel = 13,
			SR_ToolButtonContents = 14,
			SR_DialogButtonAccept = 15,
			SR_DialogButtonReject = 16,
			SR_DialogButtonApply = 17,
			SR_DialogButtonHelp = 18,
			SR_DialogButtonAll = 19,
			SR_DialogButtonAbort = 20,
			SR_DialogButtonIgnore = 21,
			SR_DialogButtonRetry = 22,
			SR_DialogButtonCustom = 23,
			SR_ToolBoxTabContents = 24,
			SR_CustomBase = 0xf0000000,
		}
		enum ComplexControl : uint {
			CC_SpinWidget = 0,
			CC_ComboBox = 1,
			CC_ScrollBar = 2,
			CC_Slider = 3,
			CC_ToolButton = 4,
			CC_TitleBar = 5,
			CC_ListView = 6,
			CC_CustomBase = 0xf0000000,
		}
		enum SubControl : uint {
			SC_None = 0x00000000,
			SC_ScrollBarAddLine = 0x00000001,
			SC_ScrollBarSubLine = 0x00000002,
			SC_ScrollBarAddPage = 0x00000004,
			SC_ScrollBarSubPage = 0x00000008,
			SC_ScrollBarFirst = 0x00000010,
			SC_ScrollBarLast = 0x00000020,
			SC_ScrollBarSlider = 0x00000040,
			SC_ScrollBarGroove = 0x00000080,
			SC_SpinWidgetUp = 0x00000001,
			SC_SpinWidgetDown = 0x00000002,
			SC_SpinWidgetFrame = 0x00000004,
			SC_SpinWidgetEditField = 0x00000008,
			SC_SpinWidgetButtonField = 0x00000010,
			SC_ComboBoxFrame = 0x00000001,
			SC_ComboBoxEditField = 0x00000002,
			SC_ComboBoxArrow = 0x00000004,
			SC_ComboBoxListBoxPopup = 0x00000008,
			SC_SliderGroove = 0x00000001,
			SC_SliderHandle = 0x00000002,
			SC_SliderTickmarks = 0x00000004,
			SC_ToolButton = 0x00000001,
			SC_ToolButtonMenu = 0x00000002,
			SC_TitleBarLabel = 0x00000001,
			SC_TitleBarSysMenu = 0x00000002,
			SC_TitleBarMinButton = 0x00000004,
			SC_TitleBarMaxButton = 0x00000008,
			SC_TitleBarCloseButton = 0x00000010,
			SC_TitleBarNormalButton = 0x00000020,
			SC_TitleBarShadeButton = 0x00000040,
			SC_TitleBarUnshadeButton = 0x00000080,
			SC_ListView = 0x00000001,
			SC_ListViewBranch = 0x00000002,
			SC_ListViewExpand = 0x00000004,
			SC_All = 0xffffffff,
		}
		enum E_PixelMetric : uint {
			PM_ButtonMargin = 0,
			PM_ButtonDefaultIndicator = 1,
			PM_MenuButtonIndicator = 2,
			PM_ButtonShiftHorizontal = 3,
			PM_ButtonShiftVertical = 4,
			PM_DefaultFrameWidth = 5,
			PM_SpinBoxFrameWidth = 6,
			PM_MaximumDragDistance = 7,
			PM_ScrollBarExtent = 8,
			PM_ScrollBarSliderMin = 9,
			PM_SliderThickness = 10,
			PM_SliderControlThickness = 11,
			PM_SliderLength = 12,
			PM_SliderTickmarkOffset = 13,
			PM_SliderSpaceAvailable = 14,
			PM_DockWindowSeparatorExtent = 15,
			PM_DockWindowHandleExtent = 16,
			PM_DockWindowFrameWidth = 17,
			PM_MenuBarFrameWidth = 18,
			PM_TabBarTabOverlap = 19,
			PM_TabBarTabHSpace = 20,
			PM_TabBarTabVSpace = 21,
			PM_TabBarBaseHeight = 22,
			PM_TabBarBaseOverlap = 23,
			PM_ProgressBarChunkWidth = 24,
			PM_SplitterWidth = 25,
			PM_TitleBarHeight = 26,
			PM_IndicatorWidth = 27,
			PM_IndicatorHeight = 28,
			PM_ExclusiveIndicatorWidth = 29,
			PM_ExclusiveIndicatorHeight = 30,
			PM_PopupMenuScrollerHeight = 31,
			PM_CheckListButtonSize = 32,
			PM_CheckListControllerSize = 33,
			PM_PopupMenuFrameHorizontalExtra = 34,
			PM_PopupMenuFrameVerticalExtra = 35,
			PM_DialogButtonsSeparator = 36,
			PM_DialogButtonsButtonWidth = 37,
			PM_DialogButtonsButtonHeight = 38,
			PM_MDIFrameWidth = 39,
			PM_MDIMinimizedWidth = 40,
			PM_HeaderMargin = 41,
			PM_HeaderMarkSize = 42,
			PM_HeaderGripMargin = 43,
			PM_TabBarTabShiftHorizontal = 44,
			PM_TabBarTabShiftVertical = 45,
			PM_TabBarScrollButtonWidth = 46,
			PM_MenuBarItemSpacing = 47,
			PM_ToolBarItemSpacing = 48,
			PM_CustomBase = 0xf0000000,
		}
		enum ContentsType : uint {
			CT_PushButton = 0,
			CT_CheckBox = 1,
			CT_RadioButton = 2,
			CT_ToolButton = 3,
			CT_ComboBox = 4,
			CT_Splitter = 5,
			CT_DockWindow = 6,
			CT_ProgressBar = 7,
			CT_PopupMenuItem = 8,
			CT_TabBarTab = 9,
			CT_Slider = 10,
			CT_Header = 11,
			CT_LineEdit = 12,
			CT_MenuBar = 13,
			CT_SpinBox = 14,
			CT_SizeGrip = 15,
			CT_TabWidget = 16,
			CT_DialogButtons = 17,
			CT_CustomBase = 0xf0000000,
		}
		enum E_StyleHint : uint {
			SH_EtchDisabledText = 0,
			SH_GUIStyle = 1,
			SH_ScrollBar_BackgroundMode = 2,
			SH_ScrollBar_MiddleClickAbsolutePosition = 3,
			SH_ScrollBar_ScrollWhenPointerLeavesControl = 4,
			SH_TabBar_SelectMouseType = 5,
			SH_TabBar_Alignment = 6,
			SH_Header_ArrowAlignment = 7,
			SH_Slider_SnapToValue = 8,
			SH_Slider_SloppyKeyEvents = 9,
			SH_ProgressDialog_CenterCancelButton = 10,
			SH_ProgressDialog_TextLabelAlignment = 11,
			SH_PrintDialog_RightAlignButtons = 12,
			SH_MainWindow_SpaceBelowMenuBar = 13,
			SH_FontDialog_SelectAssociatedText = 14,
			SH_PopupMenu_AllowActiveAndDisabled = 15,
			SH_PopupMenu_SpaceActivatesItem = 16,
			SH_PopupMenu_SubMenuPopupDelay = 17,
			SH_ScrollView_FrameOnlyAroundContents = 18,
			SH_MenuBar_AltKeyNavigation = 19,
			SH_ComboBox_ListMouseTracking = 20,
			SH_PopupMenu_MouseTracking = 21,
			SH_MenuBar_MouseTracking = 22,
			SH_ItemView_ChangeHighlightOnFocus = 23,
			SH_Widget_ShareActivation = 24,
			SH_Workspace_FillSpaceOnMaximize = 25,
			SH_ComboBox_Popup = 26,
			SH_TitleBar_NoBorder = 27,
			SH_ScrollBar_StopMouseOverSlider = 28,
			SH_BlinkCursorWhenTextSelected = 29,
			SH_RichText_FullWidthSelection = 30,
			SH_PopupMenu_Scrollable = 31,
			SH_GroupBox_TextLabelVerticalAlignment = 32,
			SH_GroupBox_TextLabelColor = 33,
			SH_PopupMenu_SloppySubMenus = 34,
			SH_Table_GridLineColor = 35,
			SH_LineEdit_PasswordCharacter = 36,
			SH_DialogButtons_DefaultButton = 37,
			SH_ToolBox_SelectedPageTitleBold = 38,
			SH_TabBar_PreferNoArrows = 39,
			SH_ScrollBar_LeftClickAbsolutePosition = 40,
			SH_ListViewExpand_SelectMouseType = 41,
			SH_UnderlineAccelerator = 42,
			SH_ToolButton_Uses3D = 43,
			SH_CustomBase = 0xf0000000,
		}
		enum E_StylePixmap : uint {
			SP_TitleBarMinButton = 0,
			SP_TitleBarMaxButton = 1,
			SP_TitleBarCloseButton = 2,
			SP_TitleBarNormalButton = 3,
			SP_TitleBarShadeButton = 4,
			SP_TitleBarUnshadeButton = 5,
			SP_DockWindowCloseButton = 6,
			SP_MessageBoxInformation = 7,
			SP_MessageBoxWarning = 8,
			SP_MessageBoxCritical = 9,
			SP_MessageBoxQuestion = 10,
			SP_CustomBase = 0xf0000000,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQStyle().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQStyle().ClassName();
		}
		[SmokeMethod("polish(QWidget*)")]
		public virtual void Polish(QWidget arg1) {
			ProxyQStyle().Polish(arg1);
		}
		[SmokeMethod("unPolish(QWidget*)")]
		public virtual void UnPolish(QWidget arg1) {
			ProxyQStyle().UnPolish(arg1);
		}
		[SmokeMethod("polish(QApplication*)")]
		public virtual void Polish(QApplication arg1) {
			ProxyQStyle().Polish(arg1);
		}
		[SmokeMethod("unPolish(QApplication*)")]
		public virtual void UnPolish(QApplication arg1) {
			ProxyQStyle().UnPolish(arg1);
		}
		[SmokeMethod("polish(QPalette&)")]
		public virtual void Polish(QPalette arg1) {
			ProxyQStyle().Polish(arg1);
		}
		[SmokeMethod("polishPopupMenu(QPopupMenu*)")]
		public virtual void PolishPopupMenu(QPopupMenu arg1) {
			ProxyQStyle().PolishPopupMenu(arg1);
		}
		[SmokeMethod("itemRect(QPainter*, const QRect&, int, bool, const QPixmap*, const QString&, int) const")]
		public virtual QRect ItemRect(QPainter p, QRect r, int flags, bool enabled, QPixmap pixmap, string text, int len) {
			return ProxyQStyle().ItemRect(p,r,flags,enabled,pixmap,text,len);
		}
		[SmokeMethod("itemRect(QPainter*, const QRect&, int, bool, const QPixmap*, const QString&) const")]
		public virtual QRect ItemRect(QPainter p, QRect r, int flags, bool enabled, QPixmap pixmap, string text) {
			return ProxyQStyle().ItemRect(p,r,flags,enabled,pixmap,text);
		}
		[SmokeMethod("drawItem(QPainter*, const QRect&, int, const QColorGroup&, bool, const QPixmap*, const QString&, int, const QColor*) const")]
		public virtual void DrawItem(QPainter p, QRect r, int flags, QColorGroup g, bool enabled, QPixmap pixmap, string text, int len, QColor penColor) {
			ProxyQStyle().DrawItem(p,r,flags,g,enabled,pixmap,text,len,penColor);
		}
		[SmokeMethod("drawItem(QPainter*, const QRect&, int, const QColorGroup&, bool, const QPixmap*, const QString&, int) const")]
		public virtual void DrawItem(QPainter p, QRect r, int flags, QColorGroup g, bool enabled, QPixmap pixmap, string text, int len) {
			ProxyQStyle().DrawItem(p,r,flags,g,enabled,pixmap,text,len);
		}
		[SmokeMethod("drawItem(QPainter*, const QRect&, int, const QColorGroup&, bool, const QPixmap*, const QString&) const")]
		public virtual void DrawItem(QPainter p, QRect r, int flags, QColorGroup g, bool enabled, QPixmap pixmap, string text) {
			ProxyQStyle().DrawItem(p,r,flags,g,enabled,pixmap,text);
		}
		[SmokeMethod("drawPrimitive(QStyle::PrimitiveElement, QPainter*, const QRect&, const QColorGroup&, QStyle::SFlags, const QStyleOption&) const")]
		public virtual void DrawPrimitive(int pe, QPainter p, QRect r, QColorGroup cg, int flags, QStyleOption arg6) {
			ProxyQStyle().DrawPrimitive(pe,p,r,cg,flags,arg6);
		}
		[SmokeMethod("drawPrimitive(QStyle::PrimitiveElement, QPainter*, const QRect&, const QColorGroup&, QStyle::SFlags) const")]
		public virtual void DrawPrimitive(int pe, QPainter p, QRect r, QColorGroup cg, int flags) {
			ProxyQStyle().DrawPrimitive(pe,p,r,cg,flags);
		}
		[SmokeMethod("drawPrimitive(QStyle::PrimitiveElement, QPainter*, const QRect&, const QColorGroup&) const")]
		public virtual void DrawPrimitive(int pe, QPainter p, QRect r, QColorGroup cg) {
			ProxyQStyle().DrawPrimitive(pe,p,r,cg);
		}
		[SmokeMethod("drawControl(QStyle::ControlElement, QPainter*, const QWidget*, const QRect&, const QColorGroup&, QStyle::SFlags, const QStyleOption&) const")]
		public virtual void DrawControl(int element, QPainter p, QWidget widget, QRect r, QColorGroup cg, int how, QStyleOption arg7) {
			ProxyQStyle().DrawControl(element,p,widget,r,cg,how,arg7);
		}
		[SmokeMethod("drawControl(QStyle::ControlElement, QPainter*, const QWidget*, const QRect&, const QColorGroup&, QStyle::SFlags) const")]
		public virtual void DrawControl(int element, QPainter p, QWidget widget, QRect r, QColorGroup cg, int how) {
			ProxyQStyle().DrawControl(element,p,widget,r,cg,how);
		}
		[SmokeMethod("drawControl(QStyle::ControlElement, QPainter*, const QWidget*, const QRect&, const QColorGroup&) const")]
		public virtual void DrawControl(int element, QPainter p, QWidget widget, QRect r, QColorGroup cg) {
			ProxyQStyle().DrawControl(element,p,widget,r,cg);
		}
		[SmokeMethod("drawControlMask(QStyle::ControlElement, QPainter*, const QWidget*, const QRect&, const QStyleOption&) const")]
		public virtual void DrawControlMask(int element, QPainter p, QWidget widget, QRect r, QStyleOption arg5) {
			ProxyQStyle().DrawControlMask(element,p,widget,r,arg5);
		}
		[SmokeMethod("drawControlMask(QStyle::ControlElement, QPainter*, const QWidget*, const QRect&) const")]
		public virtual void DrawControlMask(int element, QPainter p, QWidget widget, QRect r) {
			ProxyQStyle().DrawControlMask(element,p,widget,r);
		}
		[SmokeMethod("subRect(QStyle::SubRect, const QWidget*) const")]
		public virtual QRect SubRect(int r, QWidget widget) {
			return ProxyQStyle().SubRect(r,widget);
		}
		[SmokeMethod("drawComplexControl(QStyle::ComplexControl, QPainter*, const QWidget*, const QRect&, const QColorGroup&, QStyle::SFlags, QStyle::SCFlags, QStyle::SCFlags, const QStyleOption&) const")]
		public virtual void DrawComplexControl(int control, QPainter p, QWidget widget, QRect r, QColorGroup cg, int how, int sub, int subActive, QStyleOption arg9) {
			ProxyQStyle().DrawComplexControl(control,p,widget,r,cg,how,sub,subActive,arg9);
		}
		[SmokeMethod("drawComplexControl(QStyle::ComplexControl, QPainter*, const QWidget*, const QRect&, const QColorGroup&, QStyle::SFlags, QStyle::SCFlags, QStyle::SCFlags) const")]
		public virtual void DrawComplexControl(int control, QPainter p, QWidget widget, QRect r, QColorGroup cg, int how, int sub, int subActive) {
			ProxyQStyle().DrawComplexControl(control,p,widget,r,cg,how,sub,subActive);
		}
		[SmokeMethod("drawComplexControl(QStyle::ComplexControl, QPainter*, const QWidget*, const QRect&, const QColorGroup&, QStyle::SFlags, QStyle::SCFlags) const")]
		public virtual void DrawComplexControl(int control, QPainter p, QWidget widget, QRect r, QColorGroup cg, int how, int sub) {
			ProxyQStyle().DrawComplexControl(control,p,widget,r,cg,how,sub);
		}
		[SmokeMethod("drawComplexControl(QStyle::ComplexControl, QPainter*, const QWidget*, const QRect&, const QColorGroup&, QStyle::SFlags) const")]
		public virtual void DrawComplexControl(int control, QPainter p, QWidget widget, QRect r, QColorGroup cg, int how) {
			ProxyQStyle().DrawComplexControl(control,p,widget,r,cg,how);
		}
		[SmokeMethod("drawComplexControl(QStyle::ComplexControl, QPainter*, const QWidget*, const QRect&, const QColorGroup&) const")]
		public virtual void DrawComplexControl(int control, QPainter p, QWidget widget, QRect r, QColorGroup cg) {
			ProxyQStyle().DrawComplexControl(control,p,widget,r,cg);
		}
		[SmokeMethod("drawComplexControlMask(QStyle::ComplexControl, QPainter*, const QWidget*, const QRect&, const QStyleOption&) const")]
		public virtual void DrawComplexControlMask(int control, QPainter p, QWidget widget, QRect r, QStyleOption arg5) {
			ProxyQStyle().DrawComplexControlMask(control,p,widget,r,arg5);
		}
		[SmokeMethod("drawComplexControlMask(QStyle::ComplexControl, QPainter*, const QWidget*, const QRect&) const")]
		public virtual void DrawComplexControlMask(int control, QPainter p, QWidget widget, QRect r) {
			ProxyQStyle().DrawComplexControlMask(control,p,widget,r);
		}
		[SmokeMethod("querySubControlMetrics(QStyle::ComplexControl, const QWidget*, QStyle::SubControl, const QStyleOption&) const")]
		public virtual QRect QuerySubControlMetrics(int control, QWidget widget, int sc, QStyleOption arg4) {
			return ProxyQStyle().QuerySubControlMetrics(control,widget,sc,arg4);
		}
		[SmokeMethod("querySubControlMetrics(QStyle::ComplexControl, const QWidget*, QStyle::SubControl) const")]
		public virtual QRect QuerySubControlMetrics(int control, QWidget widget, int sc) {
			return ProxyQStyle().QuerySubControlMetrics(control,widget,sc);
		}
		[SmokeMethod("querySubControl(QStyle::ComplexControl, const QWidget*, const QPoint&, const QStyleOption&) const")]
		public virtual int QuerySubControl(int control, QWidget widget, QPoint pos, QStyleOption arg4) {
			return ProxyQStyle().QuerySubControl(control,widget,pos,arg4);
		}
		[SmokeMethod("querySubControl(QStyle::ComplexControl, const QWidget*, const QPoint&) const")]
		public virtual int QuerySubControl(int control, QWidget widget, QPoint pos) {
			return ProxyQStyle().QuerySubControl(control,widget,pos);
		}
		[SmokeMethod("pixelMetric(QStyle::PixelMetric, const QWidget*) const")]
		public virtual int PixelMetric(int metric, QWidget widget) {
			return ProxyQStyle().PixelMetric(metric,widget);
		}
		[SmokeMethod("pixelMetric(QStyle::PixelMetric) const")]
		public virtual int PixelMetric(int metric) {
			return ProxyQStyle().PixelMetric(metric);
		}
		[SmokeMethod("sizeFromContents(QStyle::ContentsType, const QWidget*, const QSize&, const QStyleOption&) const")]
		public virtual QSize SizeFromContents(int contents, QWidget widget, QSize contentsSize, QStyleOption arg4) {
			return ProxyQStyle().SizeFromContents(contents,widget,contentsSize,arg4);
		}
		[SmokeMethod("sizeFromContents(QStyle::ContentsType, const QWidget*, const QSize&) const")]
		public virtual QSize SizeFromContents(int contents, QWidget widget, QSize contentsSize) {
			return ProxyQStyle().SizeFromContents(contents,widget,contentsSize);
		}
		// int styleHint(QStyle::StyleHint arg1,const QWidget* arg2,const QStyleOption& arg3,QStyleHintReturn* arg4); >>>> NOT CONVERTED
		[SmokeMethod("styleHint(QStyle::StyleHint, const QWidget*, const QStyleOption&) const")]
		public virtual int StyleHint(int stylehint, QWidget widget, QStyleOption arg3) {
			return ProxyQStyle().StyleHint(stylehint,widget,arg3);
		}
		[SmokeMethod("styleHint(QStyle::StyleHint, const QWidget*) const")]
		public virtual int StyleHint(int stylehint, QWidget widget) {
			return ProxyQStyle().StyleHint(stylehint,widget);
		}
		[SmokeMethod("styleHint(QStyle::StyleHint) const")]
		public virtual int StyleHint(int stylehint) {
			return ProxyQStyle().StyleHint(stylehint);
		}
		[SmokeMethod("stylePixmap(QStyle::StylePixmap, const QWidget*, const QStyleOption&) const")]
		public virtual QPixmap StylePixmap(int stylepixmap, QWidget widget, QStyleOption arg3) {
			return ProxyQStyle().StylePixmap(stylepixmap,widget,arg3);
		}
		[SmokeMethod("stylePixmap(QStyle::StylePixmap, const QWidget*) const")]
		public virtual QPixmap StylePixmap(int stylepixmap, QWidget widget) {
			return ProxyQStyle().StylePixmap(stylepixmap,widget);
		}
		[SmokeMethod("stylePixmap(QStyle::StylePixmap) const")]
		public virtual QPixmap StylePixmap(int stylepixmap) {
			return ProxyQStyle().StylePixmap(stylepixmap);
		}
		[SmokeMethod("defaultFrameWidth() const")]
		public int DefaultFrameWidth() {
			return ProxyQStyle().DefaultFrameWidth();
		}
		[SmokeMethod("tabbarMetrics(const QWidget*, int&, int&, int&) const")]
		public void TabbarMetrics(QWidget t, out int hf, out int vf, out int ov) {
			ProxyQStyle().TabbarMetrics(t,out hf,out vf,out ov);
		}
		[SmokeMethod("scrollBarExtent() const")]
		public QSize ScrollBarExtent() {
			return ProxyQStyle().ScrollBarExtent();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQStyle().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQStyle().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQStyle().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQStyle().TrUtf8(arg1);
		}
		[SmokeMethod("visualRect(const QRect&, const QWidget*)")]
		public static QRect VisualRect(QRect logical, QWidget w) {
			return StaticQStyle().VisualRect(logical,w);
		}
		[SmokeMethod("visualRect(const QRect&, const QRect&)")]
		public static QRect VisualRect(QRect logical, QRect bounding) {
			return StaticQStyle().VisualRect(logical,bounding);
		}
		protected void CreateQStyleSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQStyleSignals), this);
			Q_EMIT = (IQStyleSignals) realProxy.GetTransparentProxy();
		}
		protected new IQStyleSignals Emit() {
			return (IQStyleSignals) Q_EMIT;
		}
	}

	public interface IQStyleSignals : IQObjectSignals {
	}
}
