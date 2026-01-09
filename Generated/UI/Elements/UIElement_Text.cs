namespace ACBindings;

// UIElement_Text
public unsafe struct UIElement_Text : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Scrollable BaseClass_UIElement_Scrollable; // ACBindings.UIElement_Scrollable
    public ACBindings.CInputHandler BaseClass_CInputHandler; // ACBindings.CInputHandler

    // Child Types
    // UIElement_Text_vtbl
    public unsafe struct UIElement_Text_vtbl
    {
        // Members
        public System.IntPtr UIListener_dtor_0; // function pointer
        public System.IntPtr OnAction; // function pointer
        public System.IntPtr OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public System.IntPtr ListenToElementMessage; // function pointer
        public System.IntPtr ListenToGlobalMessage; // function pointer
        public System.IntPtr SetVisible; // function pointer
        public System.IntPtr SetShouldBlockClicks; // function pointer
        public System.IntPtr SetShouldEraseBackground; // function pointer
        public System.IntPtr SetClampGameViewEdge; // function pointer
        public System.IntPtr CheckOverOverride; // function pointer
        public System.IntPtr MoveTo; // function pointer
        public System.IntPtr ResizeTo; // function pointer
        public System.IntPtr GetSurfaceBox; // function pointer
        public System.IntPtr CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public System.IntPtr SetParent; // function pointer
        public fixed byte gap48[4];
        public System.IntPtr MouseMove; // function pointer
        public System.IntPtr MouseOver; // function pointer
        public System.IntPtr MouseOverTop; // function pointer
        public System.IntPtr MouseHover; // function pointer
        public System.IntPtr MouseUnhover; // function pointer
        public System.IntPtr MouseDown; // function pointer
        public System.IntPtr MouseUp; // function pointer
        public System.IntPtr HasCursor; // function pointer
        public System.IntPtr AddChild; // function pointer
        public System.IntPtr RemoveChild; // function pointer
        public System.IntPtr DrawStart; // function pointer
        public System.IntPtr EraseBackground; // function pointer
        public System.IntPtr PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public System.IntPtr PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public System.IntPtr DrawDone; // function pointer
        public System.IntPtr MouseTap; // function pointer
        public System.IntPtr DynamicCast; // function pointer
        public System.IntPtr GetUIElementType; // function pointer
        public System.IntPtr SetState; // function pointer
        public System.IntPtr GetParent; // function pointer
        public System.IntPtr GetAncestorByID; // function pointer
        public System.IntPtr KeyUp; // function pointer
        public System.IntPtr KeyDown; // function pointer
        public System.IntPtr RegisterInputMaps; // function pointer
        public System.IntPtr UnregisterInputMaps; // function pointer
        public System.IntPtr OnChildAction; // function pointer
        public System.IntPtr Initialize; // function pointer
        public System.IntPtr PostInit; // function pointer
        public System.IntPtr InqAvailableProperties; // function pointer
        public System.IntPtr OnSetAttribute; // function pointer
        public System.IntPtr ContainsProperty; // function pointer
        public System.IntPtr InqProperty; // function pointer
        public System.IntPtr SetProperty; // function pointer
        public fixed byte gapD8[4];
        public System.IntPtr CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public System.IntPtr DragAndDropComplete; // function pointer
        public System.IntPtr DragItem; // function pointer
        public System.IntPtr GetDragAndDropCatcher; // function pointer
        public System.IntPtr MatchElement; // function pointer
        public System.IntPtr UpdateForChildSizeChange; // function pointer
        public System.IntPtr UpdateForParentVisibilityChange; // function pointer
        public System.IntPtr Activate; // function pointer
        public System.IntPtr Deactivate; // function pointer
        public System.IntPtr TakeFocus; // function pointer
        public System.IntPtr RelinquishFocus; // function pointer
        public System.IntPtr GetActivatable; // function pointer
        public System.IntPtr SetMouseVisible; // function pointer
        public System.IntPtr UpdateForScreenPositionChange; // function pointer
        public System.IntPtr SetUIObject; // function pointer
        public System.IntPtr MakeUIObject; // function pointer
        public System.IntPtr OnChildActivationChanged; // function pointer
        public System.IntPtr GetShouldBeMouseVisible; // function pointer
        public System.IntPtr ForwardElementMessage; // function pointer
        public System.IntPtr DefElementMessageHandler; // function pointer
        public System.IntPtr OnVisibilityChanged; // function pointer
        public System.IntPtr Initialized; // function pointer
        public System.IntPtr AdjustToScrollableXYChange; // function pointer
        public System.IntPtr InqScrollDelta; // function pointer

        // Methods
    }
    // UIElement_Text::AddTextFlags
    public enum AddTextFlags : byte
    {
        atf_Default = 0x0,
        atf_PerserveSelection = 0x1,
        atf_AppendText = 0x2
    }
    // UIElement_Text::CursorMovementFlags
    public enum CursorMovementFlags : byte
    {
        ctm_Default = 0x0,
        ctm_SelectText = 0x1,
        ctm_DontSelectText = 0x2
    }
    // UIElement_Text::DrawSelf::__l16::GlyphPass
    public enum GlyphPass : byte
    {
        gpBackground = 0x0,
        gpForeground = 0x1,
        gpNPasses = 0x2
    }
    // UIElement_Text::UIText_Flag
    public enum UIText_Flag : ushort
    {
        UITF_NONE = 0x0,
        UITF_EDITABLE = 0x1,
        UITF_ONE_LINE = 0x2,
        UITF_SELECTABLE = 0x4,
        UITF_NO_IME = 0x8,
        UITF_OUTLINE = 0x10,
        UITF_DROPSHADOW = 0x20,
        UITF_MOUSE_SELECTING = 0x40,
        UITF_SELECTING = 0x80,
        UITF_DIRTY = 0x100,
        UITF_CURSOR_VISIBLE = 0x200,
        UITF_FIT_TO_TEXT = 0x400,
        UITF_TRUNCATE_TEXT_TO_FIT = 0x800,
        UITF_LOSE_FOCUS_ON_ESCAPE = 0x1000,
        UITF_LOSE_FOCUS_ON_ACCEPT_INPUT = 0x2000
    }
    // UIElement_Text::UIText_InqSize_Flag
    public enum UIText_InqSize_Flag : byte
    {
        UITS_MAX_WIDTH = 0x0,
        UITS_CUR_WIDTH = 0x1,
        UITS_CUR_PARENT_WIDTH = 0x2,
        UITS_DESC_WIDTH = 0x3
    }

    // Members
    public ACBindings.GlyphList m_glyphList;
    public uint m_nCursorPos;
    public uint m_nSelectionStart;
    public uint m_nSelectionEnd;
    public ACBindings.GlyphList m_glTruncate;
    public uint m_nTruncationPos;
    public int m_cxTrailer;
    public int m_cyTrailer;
    public uint m_cxAdjustedLineNumber;
    public int m_cxAdjustedLineSize;
    public uint m_bitField;
    public uint m_eHorizontalJustification;
    public uint m_eVerticalJustification;
    public System.IntPtr m_filter; // function pointer
    public ACBindings.RGBAColor m_curFontColor;
    public ACBindings.Font* m_curFontObj;
    public ACBindings.RGBAColor m_curTagFontColor;
    public uint m_curOutlineColor;
    public int m_margU;
    public int m_margD;
    public int m_margL;
    public int m_margR;
    public double m_lastCursorMoveTime;
    public double m_lastFlashFlipTime;
    public ACBindings.Box2D m_lastCursor;
    public ACBindings.SmartArray__StringDownload_ptr m_downloadQueue;

    // Generated Constructor
    public UIElement_Text(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall UIElement_Text::ClearSelection(UIElement_Text*)
    public byte ClearSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte>)0x00466540)(ref this);
    // void __thiscall UIElement_Text::ScrollPage(UIElement_Text*,bool)
    public void ScrollPage(byte i_bUp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte, void>)0x00466570)(ref this, i_bUp);
    // void __thiscall UIElement_Text::SetNoIme(UIElement_Text*,bool)
    public void SetNoIme(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte, void>)0x00466730)(ref this, b);
    // void __thiscall UIElement_Text::SetOutline(UIElement_Text*,bool)
    public void SetOutline(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte, void>)0x00466760)(ref this, b);
    // bool __thiscall UIElement_Text::IMETurnOn(UIElement_Text*)
    public byte IMETurnOn() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte>)0x00466790)(ref this);
    // void __thiscall UIElement_Text::CleanupStringDownloads(UIElement_Text*)
    public void CleanupStringDownloads() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x004667D0)(ref this);
    // _DWORD* __thiscall UIElement_Text::GetText(_DWORD*,_DWORD*)
    public int* GetText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int*, int*>)0x00466830)(ref this, a2);
    // _DWORD* __thiscall UIElement_Text::GetPreParsedText(_DWORD*,_DWORD*)
    public int* GetPreParsedText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int*, int*>)0x004668A0)(ref this, a2);
    // void __thiscall UIElement_Text::SetSelecting(UIElement_Text*,bool)
    public void SetSelecting(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte, void>)0x00466910)(ref this, b);
    // void __thiscall UIElement_Text::SetDirty(UIElement_Text*,bool)
    public void SetDirty(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte, void>)0x00466980)(ref this, b);
    // void __thiscall UIElement_Text::DetermineMarginValues(UIElement_Text*)
    public void DetermineMarginValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x004669D0)(ref this);
    // void __thiscall UIElement_Text::SetFontDIDHelper(UIElement_Text*,unsigned int,Font**,unsigned int)
    public void SetFontDIDHelper(uint property, ACBindings.Font** font, uint fontDIDNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, ACBindings.Font**, uint, void>)0x00466A90)(ref this, property, font, fontDIDNum);
    // void __thiscall UIElement_Text::SetFontColorHelper(UIElement_Text*,unsigned int,RGBAColor*,unsigned int)
    public void SetFontColorHelper(uint property, ACBindings.RGBAColor* color, uint fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, ACBindings.RGBAColor*, uint, void>)0x00466BF0)(ref this, property, color, fontColorNum);
    // void __thiscall UIElement_Text::SetFontDID(void*,int)
    public void SetFontDID(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int, void>)0x00466E80)(ref this, a2);
    // void __thiscall UIElement_Text::SetFontDIDWithoutChangingExistingText(void*,int)
    public void SetFontDIDWithoutChangingExistingText(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int, void>)0x00466FE0)(ref this, a2);
    // void __thiscall UIElement_Text::ChangeExistingTextToNewFont(UIElement_Text*,Font*)
    public void ChangeExistingTextToNewFont(ACBindings.Font* i_pNewFont) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, ACBindings.Font*, void>)0x00467000)(ref this, i_pNewFont);
    // bool __thiscall UIElement_Text::MoveBeginEndLine(UIElement_Text*,unsigned int,unsigned int,unsigned int*)
    public byte MoveBeginEndLine(uint i_bBegin, uint i_nStart, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, uint, uint*, byte>)0x00467040)(ref this, i_bBegin, i_nStart, o_nPos);
    // bool __thiscall UIElement_Text::SetSelectionStart(UIElement_Text*,unsigned int)
    public byte SetSelectionStart(uint i_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, byte>)0x004670F0)(ref this, i_nPos);
    // bool __thiscall UIElement_Text::SetSelectionEnd(UIElement_Text*,unsigned int)
    public byte SetSelectionEnd(uint i_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, byte>)0x00467150)(ref this, i_nPos);
    // bool __thiscall UIElement_Text::GetSelection(UIElement_Text*,unsigned int*,unsigned int*)
    public byte GetSelection(uint* o_nStart, uint* o_nEnd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint*, uint*, byte>)0x004671B0)(ref this, o_nStart, o_nEnd);
    // void __thiscall UIElement_Text::RecalculateTruncation(UIElement_Text*,int*,int*)
    public void RecalculateTruncation(int* io_iPaperWidth, int* io_iPaperHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int*, int*, void>)0x00467210)(ref this, io_iPaperWidth, io_iPaperHeight);
    // bool __thiscall UIElement_Text::SetHorizontalJustification(UIElement_Text*,unsigned int)
    public byte SetHorizontalJustification(uint i_eJustification) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, byte>)0x00467490)(ref this, i_eJustification);
    // bool __thiscall UIElement_Text::SetVerticalJustification(UIElement_Text*,unsigned int)
    public byte SetVerticalJustification(uint i_eJustification) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, byte>)0x004674C0)(ref this, i_eJustification);
    // int __thiscall UIElement_Text::CalcJustification(UIElement_Text*,unsigned int,bool)
    public int CalcJustification(uint i_uiTextSize, byte i_bHorizontal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, byte, int>)0x004674F0)(ref this, i_uiTextSize, i_bHorizontal);
    // bool __thiscall UIElement_Text::RegisterInputMaps(UIElement_Text*,int)
    public byte RegisterInputMaps(int i_nPriority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int, byte>)0x004675E0)(ref this, i_nPriority);
    // bool __thiscall UIElement_Text::UnregisterInputMaps(UIElement_Text*)
    public byte UnregisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte>)0x00467660)(ref this);
    // void __thiscall UIElement_Text::AdjustToScrollableXYChange(UIElement_Text*)
    public void AdjustToScrollableXYChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x004676D0)(ref this);
    // bool __thiscall UIElement_Text::GetShouldBeMouseVisible(UIElement_Text*)
    public byte GetShouldBeMouseVisible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte>)0x004676F0)(ref this);
    // void __thiscall UIElement_Text::SetTruncateTextToFit(UIElement_Text*,bool)
    public void SetTruncateTextToFit(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte, void>)0x00467710)(ref this, b);
    // void __thiscall UIElement_Text::SetLoseFocusOnEscape(UIElement_Text*,bool)
    public void SetLoseFocusOnEscape(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte, void>)0x00467780)(ref this, b);
    // void __thiscall UIElement_Text::SetLoseFocusOnAcceptInput(UIElement_Text*,bool)
    public void SetLoseFocusOnAcceptInput(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte, void>)0x004677B0)(ref this, b);
    // void __thiscall UIElement_Text::ResizeToPaper(UIElement_Text*)
    public void ResizeToPaper() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x004677E0)(ref this);
    // void __thiscall UIElement_Text::~UIElement_Text(UIElement_Text*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x004679F0)(ref this);
    // UIElement* __thiscall UIElement_Text::DynamicCast(UIElement_Text*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, ACBindings.UIElement*>)0x00467A70)(ref this, i_eType);
    // bool __thiscall UIElement_Text::InqAvailableProperties(UIElement_Text*,AvailablePropertySet*)
    public byte InqAvailableProperties(ACBindings.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, ACBindings.AvailablePropertySet*, byte>)0x00467A90)(ref this, set);
    // void __thiscall UIElement_Text::ClearAllText(UIElement_Text*)
    public void ClearAllText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x00467AE0)(ref this);
    // void __thiscall UIElement_Text::SelectAll(UIElement_Text*)
    public void SelectAll() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x00467B60)(ref this);
    // void __thiscall UIElement_Text::Deselect(UIElement_Text*)
    public void Deselect() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x00467BC0)(ref this);
    // _DWORD* __thiscall UIElement_Text::GetSelectedText(UIElement_Text*,_DWORD*)
    public int* GetSelectedText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int*, int*>)0x00467C30)(ref this, a2);
    // void __thiscall UIElement_Text::ResizeTo(UIElement_Text*,const int,const int)
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int, int, void>)0x00467CC0)(ref this, width, height);
    // void __thiscall UIElement_Text::DrawSelf(UIRegion*,Box2D*,unsigned int*,_DWORD*,UISurface*)
    public void DrawSelf(ACBindings.Box2D* a2, uint* a3, int* a4, ACBindings.UISurface* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, ACBindings.Box2D*, uint*, int*, ACBindings.UISurface*, void>)0x00467D30)(ref this, a2, a3, a4, a5);
    // void __thiscall UIElement_Text::SetEditable(UIElement_Text*,bool)
    public void SetEditable(byte editable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte, void>)0x00468360)(ref this, editable);
    // void __thiscall UIElement_Text::SetOneLine(UIElement_Text*,bool)
    public void SetOneLine(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte, void>)0x00468400)(ref this, b);
    // void __thiscall UIElement_Text::SetSelectable(UIElement_Text*,bool)
    public void SetSelectable(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte, void>)0x00468450)(ref this, b);
    // void __thiscall UIElement_Text::SetFontDIDNum(UIElement_Text*,unsigned int)
    public void SetFontDIDNum(uint fontDIDNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, void>)0x00468520)(ref this, fontDIDNum);
    // void __thiscall UIElement_Text::SetFontColorNum(UIElement_Text*,unsigned int)
    public void SetFontColorNum(uint fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, void>)0x00468540)(ref this, fontColorNum);
    // bool __thiscall UIElement_Text::MoveUpDown(UIElement_Text*,int,unsigned int,unsigned int*)
    public byte MoveUpDown(int i_bUp, uint i_nStart, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int, uint, uint*, byte>)0x00468570)(ref this, i_bUp, i_nStart, o_nPos);
    // bool __thiscall UIElement_Text::RecalculateGlyphList(UIElement_Text*)
    public byte RecalculateGlyphList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte>)0x004686B0)(ref this);
    // void __thiscall UIElement_Text::SetFitToText(UIElement_Text*,bool)
    public void SetFitToText(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte, void>)0x004687D0)(ref this, b);
    // void __thiscall UIElement_Text::UIElement_Text(UIElement_Text*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x00468800)(ref this, layout, full_desc);
    // UIElementMessageListenResult __thiscall UIElement_Text::ListenToElementMessage(UIElement_Text*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x00468A50)(ref this, i_rMsg);
    // void __thiscall UIElement_Text::Copy(UIElement_Text*)
    public void Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x00468B30)(ref this);
    // unsigned int __thiscall UIElement_Text::DeterminePositionFromXY(UIElement_Text*,int,int)
    public uint DeterminePositionFromXY(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int, int, uint>)0x00468B80)(ref this, i_x, i_y);
    // int __thiscall UIElement_Text::InqScrollDelta(UIElement_Text*,int,bool,bool)
    public int InqScrollDelta(int i_bHorizontal, byte i_bIncrement, byte i_bPage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int, byte, byte, int>)0x00468C40)(ref this, i_bHorizontal, i_bIncrement, i_bPage);
    // void __cdecl UIElement_Text::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00468D20)();
    // bool __thiscall UIElement_Text::IsPositionInView(UIElement_Text*,const int*)
    public byte IsPositionInView(int* nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int*, byte>)0x00468D30)(ref this, nPos);
    // bool __thiscall UIElement_Text::SetCursorPosition(UIElement_Text*,unsigned int,UIElement_Text::CursorMovementFlags)
    public byte SetCursorPosition(uint i_nPos, ACBindings.UIElement_Text.CursorMovementFlags i_selMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, ACBindings.UIElement_Text.CursorMovementFlags, byte>)0x00468E20)(ref this, i_nPos, i_selMode);
    // bool __thiscall UIElement_Text::SetCursorPositionFromXY(UIElement_Text*,int,int,UIElement_Text::CursorMovementFlags)
    public byte SetCursorPositionFromXY(int i_x, int i_y, ACBindings.UIElement_Text.CursorMovementFlags i_selMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int, int, ACBindings.UIElement_Text.CursorMovementFlags, byte>)0x00468F60)(ref this, i_x, i_y, i_selMode);
    // bool __thiscall UIElement_Text::MoveCursor(UIElement_Text*,TextDefs::Direction)
    public byte MoveCursor(ACBindings.TextDefs.Direction dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, ACBindings.TextDefs.Direction, byte>)0x00468F90)(ref this, dir);
    // void __thiscall UIElement_Text::MoveCursorToEnd(UIElement_Text*)
    public void MoveCursorToEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x00469100)(ref this);
    // void __thiscall UIElement_Text::MoveCursorToPosition(UIElement_Text*,int)
    public void MoveCursorToPosition(int i_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int, void>)0x00469120)(ref this, i_nPos);
    // char __thiscall UIElement_Text::InqGlyphs(char*,int*,int*)
    public sbyte InqGlyphs(int* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int*, int*, sbyte>)0x00469130)(ref this, a2, a3);
    // void __thiscall UIElement_Text::ScrollToPosition(UIElement_Text*,const int)
    public void ScrollToPosition(int i_iPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int, void>)0x00469440)(ref this, i_iPos);
    // bool __thiscall UIElement_Text::IsAtVerticalEnd(UIElement_Text*)
    public byte IsAtVerticalEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, byte>)0x004695E0)(ref this);
    // void __thiscall UIElement_Text::MouseDown(UIElement_Text*,unsigned int,unsigned int,unsigned int)
    public void MouseDown(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, uint, uint, void>)0x00469600)(ref this, xWindow, yWindow, button);
    // void __thiscall UIElement_Text::MouseUp(UIElement_Text*,unsigned int,unsigned int,unsigned int)
    public void MouseUp(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, uint, uint, void>)0x00469780)(ref this, xWindow, yWindow, button);
    // void __thiscall UIElement_Text::MouseMove(UIElement_Text*,int,int)
    public void MouseMove(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int, int, void>)0x00469880)(ref this, i_xWindow, i_yWindow);
    // bool __thiscall UIElement_Text::InqSizewMargins(UIElement_Text*,const StringInfo*,int*,int*,UIElement_Text::UIText_InqSize_Flag)
    public byte InqSizewMargins(ACBindings.StringInfo* info, int* width, int* height, ACBindings.UIElement_Text.UIText_InqSize_Flag i_eFlag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, ACBindings.StringInfo*, int*, int*, ACBindings.UIElement_Text.UIText_InqSize_Flag, byte>)0x004698F0)(ref this, info, width, height, i_eFlag);
    // void __thiscall UIElement_Text::DeleteSection(UIElement_Text*,unsigned int,unsigned int,bool)
    public void DeleteSection(uint i_nStart, uint i_nEnd, byte i_bKeepCurrentTextInView) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, uint, byte, void>)0x00469A90)(ref this, i_nStart, i_nEnd, i_bKeepCurrentTextInView);
    // void __thiscall UIElement_Text::BeheadText(UIElement_Text*,unsigned int,bool)
    public void BeheadText(uint i_cPosition, byte bKeepCurrentTextInView) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, byte, void>)0x00469C00)(ref this, i_cPosition, bKeepCurrentTextInView);
    // void __thiscall UIElement_Text::DeleteChar(UIElement_Text*)
    public void DeleteChar() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x00469C20)(ref this);
    // void __thiscall UIElement_Text::DeleteSelection(UIElement_Text*)
    public void DeleteSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x00469C40)(ref this);
    // LONG __thiscall UIElement_Text::AddText_Internal(UIRegion*,int,char)
    public int AddText_Internal(int a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int, sbyte, int>)0x00469CC0)(ref this, a2, a3);
    // void __thiscall UIElement_Text::Cut(UIElement_Text*)
    public void Cut() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x00469DF0)(ref this);
    // void __thiscall UIElement_Text::CharacterHandler(UIElement_Text*,wchar_t)
    public void CharacterHandler(System.Char charToHandle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, System.Char, void>)0x00469E20)(ref this, charToHandle);
    // LONG __thiscall UIElement_Text::AppendText(UIRegion*,int*)
    public int AppendText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int*, int>)0x00469F70)(ref this, a2);
    // void __thiscall UIElement_Text::AppendStringInfo(UIElement_Text*,const StringInfo*)
    public void AppendStringInfo(ACBindings.StringInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, ACBindings.StringInfo*, void>)0x00469FA0)(ref this, info);
    // LONG __thiscall UIElement_Text::AppendTextWithFont(UIElement_Text*,int*,unsigned int,unsigned int)
    public int AppendTextWithFont(int* a2, uint fontDIDNum, uint fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int*, uint, uint, int>)0x0046A000)(ref this, a2, fontDIDNum, fontColorNum);
    // void __thiscall UIElement_Text::AppendStringInfoWithFont(UIElement_Text*,const StringInfo*,int,int)
    public void AppendStringInfoWithFont(ACBindings.StringInfo* info, int fontDIDNum, int fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, ACBindings.StringInfo*, int, int, void>)0x0046A070)(ref this, info, fontDIDNum, fontColorNum);
    // void __thiscall UIElement_Text::CheckStringDownloads(UIElement_Text*)
    public void CheckStringDownloads() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x0046A100)(ref this);
    // void __thiscall UIElement_Text::Global_Loop(UIElement_Text*)
    public void Global_Loop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x0046A250)(ref this);
    // void __thiscall UIElement_Text::SetStringInfo(UIElement_Text*,const StringInfo*)
    public void SetStringInfo(ACBindings.StringInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, ACBindings.StringInfo*, void>)0x0046A350)(ref this, info);
    // void __thiscall UIElement_Text::SetStringInfoWithFont(UIElement_Text*,const StringInfo*,int,int)
    public void SetStringInfoWithFont(ACBindings.StringInfo* info, int fontDIDNum, int fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, ACBindings.StringInfo*, int, int, void>)0x0046A370)(ref this, info, fontDIDNum, fontColorNum);
    // void __thiscall UIElement_Text::Paste(UIElement_Text*)
    public void Paste() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x0046A3A0)(ref this);
    // bool __thiscall UIElement_Text::OnAction(UIElement_Text*,const InputEvent*)
    public byte OnAction(ACBindings.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, ACBindings.InputEvent*, byte>)0x0046A4F0)(ref this, i_evt);
    // void __thiscall UIElement_Text::ListenToGlobalMessage(UIElement_Text*,unsigned int,int)
    public void ListenToGlobalMessage(uint messageID, int data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint, int, void>)0x0046A730)(ref this, messageID, data);
    // void __thiscall UIElement_Text::SetText(UIElement_Text*,int*)
    public void SetText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int*, void>)0x0046A740)(ref this, a2);
    // void __thiscall UIElement_Text::SetTextWithFont(UIElement_Text*,int*,int,int)
    public void SetTextWithFont(int* a2, int fontDIDNum, int fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, int*, int, int, void>)0x0046A790)(ref this, a2, fontDIDNum, fontColorNum);
    // void __thiscall UIElement_Text::DoFontReset(UIElement_Text*)
    public void DoFontReset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, void>)0x0046A7F0)(ref this);
    // void __thiscall UIElement_Text::MatchElement(UIElement_Text*,const UIElement*)
    public void MatchElement(ACBindings.UIElement* elem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, ACBindings.UIElement*, void>)0x0046A870)(ref this, elem);
    // void __thiscall UIElement_Text::OnSetAttribute(UIElement_Text*,const BaseProperty*)
    public void OnSetAttribute(ACBindings.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, ACBindings.BaseProperty*, void>)0x0046A8D0)(ref this, attribute);
    // unsigned int __thiscall UIElement_Text::GetUIElementType(TextureVelocityPartHook*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_Text, uint>)0x006B1960)(ref this);
}

