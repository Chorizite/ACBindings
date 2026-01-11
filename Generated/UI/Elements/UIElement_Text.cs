namespace ACBindings.Internal;

public unsafe struct UIElement_Text : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Scrollable BaseClass_UIElement_Scrollable; // ACBindings.Internal.UIElement_Scrollable
    public ACBindings.Internal.CInputHandler BaseClass_CInputHandler; // ACBindings.Internal.CInputHandler

    // Child Types
    public unsafe struct UIElement_Text_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*> GetSurfaceBox; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> HasCursor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> AddChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> RemoveChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawStart; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> EraseBackground; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawDone; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint> GetUIElementType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> SetState; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetParent; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> GetAncestorByID; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> KeyUp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, float, byte> KeyDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, int, byte> RegisterInputMaps; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> UnregisterInputMaps; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte> OnChildAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> Initialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> PostInit; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.AvailablePropertySet*, byte> InqAvailableProperties; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, void> OnSetAttribute; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> ContainsProperty; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.BaseProperty*, byte> InqProperty; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, byte> SetProperty; // function pointer
        public fixed byte gapD8[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.FunctionSignatureChanged> CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, ACBindings.Internal.UIElement.FunctionSignatureChanged> DragAndDropComplete; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement**, byte> DragItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetDragAndDropCatcher; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> MatchElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> UpdateForChildSizeChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> UpdateForParentVisibilityChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Activate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Deactivate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> TakeFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> RelinquishFocus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetActivatable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> SetMouseVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> UpdateForScreenPositionChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject*, byte> SetUIObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, byte> MakeUIObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, void> OnChildActivationChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetShouldBeMouseVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult, ACBindings.Internal.UIElementMessageListenResult> ForwardElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, byte> DefElementMessageHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> OnVisibilityChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.Intialized_Has_Been_Replaced_With_PostInit> Initialized; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_Scrollable*, void> AdjustToScrollableXYChange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_Scrollable*, byte, byte, byte, int> InqScrollDelta; // function pointer

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
    // UIElement_Text::DrawSelf::__l16::GlyphPass
    public enum GlyphPass : byte
    {
        gpBackground = 0x0,
        gpForeground = 0x1,
        gpNPasses = 0x2
    }

    // Members
    public ACBindings.Internal.GlyphList m_glyphList;
    public uint m_nCursorPos;
    public uint m_nSelectionStart;
    public uint m_nSelectionEnd;
    public ACBindings.Internal.GlyphList m_glTruncate;
    public uint m_nTruncationPos;
    public int m_cxTrailer;
    public int m_cyTrailer;
    public uint m_cxAdjustedLineNumber;
    public int m_cxAdjustedLineSize;
    public uint m_bitField;
    public uint m_eHorizontalJustification;
    public uint m_eVerticalJustification;
    public delegate* unmanaged[Cdecl]<ushort, byte> m_filter; // function pointer
    public ACBindings.Internal.RGBAColor m_curFontColor;
    public ACBindings.Internal.Font* m_curFontObj;
    public ACBindings.Internal.RGBAColor m_curTagFontColor;
    public uint m_curOutlineColor;
    public int m_margU;
    public int m_margD;
    public int m_margL;
    public int m_margR;
    public double m_lastCursorMoveTime;
    public double m_lastFlashFlipTime;
    public ACBindings.Internal.Box2D m_lastCursor;
    public ACBindings.Internal.SmartArray___StringDownload_ptr m_downloadQueue;

    // Generated Constructor
    public UIElement_Text(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00466540
    /// bool __thiscall UIElement_Text::ClearSelection(UIElement_Text*)</code>
    /// </summary>
    public byte ClearSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte>)0x00466540)(ref this);

    /// <summary>
    /// <code>Offset: 0x00466570
    /// void __thiscall UIElement_Text::ScrollPage(UIElement_Text*,bool)</code>
    /// </summary>
    public void ScrollPage(byte i_bUp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00466570)(ref this, i_bUp);

    /// <summary>
    /// <code>Offset: 0x00466730
    /// void __thiscall UIElement_Text::SetNoIme(UIElement_Text*,bool)</code>
    /// </summary>
    public void SetNoIme(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00466730)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x00466760
    /// void __thiscall UIElement_Text::SetOutline(UIElement_Text*,bool)</code>
    /// </summary>
    public void SetOutline(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00466760)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x00466790
    /// bool __thiscall UIElement_Text::IMETurnOn(UIElement_Text*)</code>
    /// </summary>
    public byte IMETurnOn() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte>)0x00466790)(ref this);

    /// <summary>
    /// <code>Offset: 0x004667D0
    /// void __thiscall UIElement_Text::CleanupStringDownloads(UIElement_Text*)</code>
    /// </summary>
    public void CleanupStringDownloads() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x004667D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00466830
    /// _DWORD* __thiscall UIElement_Text::GetText(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int* GetText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, int*>)0x00466830)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004668A0
    /// _DWORD* __thiscall UIElement_Text::GetPreParsedText(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int* GetPreParsedText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, int*>)0x004668A0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00466910
    /// void __thiscall UIElement_Text::SetSelecting(UIElement_Text*,bool)</code>
    /// </summary>
    public void SetSelecting(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00466910)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x00466980
    /// void __thiscall UIElement_Text::SetDirty(UIElement_Text*,bool)</code>
    /// </summary>
    public void SetDirty(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00466980)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x004669D0
    /// void __thiscall UIElement_Text::DetermineMarginValues(UIElement_Text*)</code>
    /// </summary>
    public void DetermineMarginValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x004669D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00466A90
    /// void __thiscall UIElement_Text::SetFontDIDHelper(UIElement_Text*,unsigned int,Font**,unsigned int)</code>
    /// </summary>
    public void SetFontDIDHelper(uint property, ACBindings.Internal.Font** font, uint fontDIDNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, ACBindings.Internal.Font**, uint, void>)0x00466A90)(ref this, property, font, fontDIDNum);

    /// <summary>
    /// <code>Offset: 0x00466BF0
    /// void __thiscall UIElement_Text::SetFontColorHelper(UIElement_Text*,unsigned int,RGBAColor*,unsigned int)</code>
    /// </summary>
    public void SetFontColorHelper(uint property, ACBindings.Internal.RGBAColor* color, uint fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, ACBindings.Internal.RGBAColor*, uint, void>)0x00466BF0)(ref this, property, color, fontColorNum);

    /// <summary>
    /// <code>Offset: 0x00466E80
    /// void __thiscall UIElement_Text::SetFontDID(void*,int)</code>
    /// </summary>
    public void SetFontDID(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, void>)0x00466E80)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00466FE0
    /// void __thiscall UIElement_Text::SetFontDIDWithoutChangingExistingText(void*,int)</code>
    /// </summary>
    public void SetFontDIDWithoutChangingExistingText(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, void>)0x00466FE0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00467000
    /// void __thiscall UIElement_Text::ChangeExistingTextToNewFont(UIElement_Text*,Font*)</code>
    /// </summary>
    public void ChangeExistingTextToNewFont(ACBindings.Internal.Font* i_pNewFont) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.Font*, void>)0x00467000)(ref this, i_pNewFont);

    /// <summary>
    /// <code>Offset: 0x00467040
    /// bool __thiscall UIElement_Text::MoveBeginEndLine(UIElement_Text*,unsigned int,unsigned int,unsigned int*)</code>
    /// </summary>
    public byte MoveBeginEndLine(uint i_bBegin, uint i_nStart, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, uint, uint*, byte>)0x00467040)(ref this, i_bBegin, i_nStart, o_nPos);

    /// <summary>
    /// <code>Offset: 0x004670F0
    /// bool __thiscall UIElement_Text::SetSelectionStart(UIElement_Text*,unsigned int)</code>
    /// </summary>
    public byte SetSelectionStart(uint i_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, byte>)0x004670F0)(ref this, i_nPos);

    /// <summary>
    /// <code>Offset: 0x00467150
    /// bool __thiscall UIElement_Text::SetSelectionEnd(UIElement_Text*,unsigned int)</code>
    /// </summary>
    public byte SetSelectionEnd(uint i_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, byte>)0x00467150)(ref this, i_nPos);

    /// <summary>
    /// <code>Offset: 0x004671B0
    /// bool __thiscall UIElement_Text::GetSelection(UIElement_Text*,unsigned int*,unsigned int*)</code>
    /// </summary>
    public byte GetSelection(uint* o_nStart, uint* o_nEnd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint*, uint*, byte>)0x004671B0)(ref this, o_nStart, o_nEnd);

    /// <summary>
    /// <code>Offset: 0x00467210
    /// void __thiscall UIElement_Text::RecalculateTruncation(UIElement_Text*,int*,int*)</code>
    /// </summary>
    public void RecalculateTruncation(int* io_iPaperWidth, int* io_iPaperHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, int*, void>)0x00467210)(ref this, io_iPaperWidth, io_iPaperHeight);

    /// <summary>
    /// <code>Offset: 0x00467490
    /// bool __thiscall UIElement_Text::SetHorizontalJustification(UIElement_Text*,unsigned int)</code>
    /// </summary>
    public byte SetHorizontalJustification(uint i_eJustification) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, byte>)0x00467490)(ref this, i_eJustification);

    /// <summary>
    /// <code>Offset: 0x004674C0
    /// bool __thiscall UIElement_Text::SetVerticalJustification(UIElement_Text*,unsigned int)</code>
    /// </summary>
    public byte SetVerticalJustification(uint i_eJustification) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, byte>)0x004674C0)(ref this, i_eJustification);

    /// <summary>
    /// <code>Offset: 0x004674F0
    /// int __thiscall UIElement_Text::CalcJustification(UIElement_Text*,unsigned int,bool)</code>
    /// </summary>
    public int CalcJustification(uint i_uiTextSize, byte i_bHorizontal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, byte, int>)0x004674F0)(ref this, i_uiTextSize, i_bHorizontal);

    /// <summary>
    /// <code>Offset: 0x004675E0
    /// bool __thiscall UIElement_Text::RegisterInputMaps(UIElement_Text*,int)</code>
    /// </summary>
    public byte RegisterInputMaps(int i_nPriority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, byte>)0x004675E0)(ref this, i_nPriority);

    /// <summary>
    /// <code>Offset: 0x00467660
    /// bool __thiscall UIElement_Text::UnregisterInputMaps(UIElement_Text*)</code>
    /// </summary>
    public byte UnregisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte>)0x00467660)(ref this);

    /// <summary>
    /// <code>Offset: 0x004676D0
    /// void __thiscall UIElement_Text::AdjustToScrollableXYChange(UIElement_Text*)</code>
    /// </summary>
    public void AdjustToScrollableXYChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x004676D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004676F0
    /// bool __thiscall UIElement_Text::GetShouldBeMouseVisible(UIElement_Text*)</code>
    /// </summary>
    public byte GetShouldBeMouseVisible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte>)0x004676F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00467710
    /// void __thiscall UIElement_Text::SetTruncateTextToFit(UIElement_Text*,bool)</code>
    /// </summary>
    public void SetTruncateTextToFit(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00467710)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x00467780
    /// void __thiscall UIElement_Text::SetLoseFocusOnEscape(UIElement_Text*,bool)</code>
    /// </summary>
    public void SetLoseFocusOnEscape(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00467780)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x004677B0
    /// void __thiscall UIElement_Text::SetLoseFocusOnAcceptInput(UIElement_Text*,bool)</code>
    /// </summary>
    public void SetLoseFocusOnAcceptInput(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x004677B0)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x004677E0
    /// void __thiscall UIElement_Text::ResizeToPaper(UIElement_Text*)</code>
    /// </summary>
    public void ResizeToPaper() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x004677E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004679F0
    /// void __thiscall UIElement_Text::~UIElement_Text(UIElement_Text*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x004679F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00467A70
    /// UIElement* __thiscall UIElement_Text::DynamicCast(UIElement_Text*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, ACBindings.Internal.UIElement*>)0x00467A70)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x00467A90
    /// bool __thiscall UIElement_Text::InqAvailableProperties(UIElement_Text*,AvailablePropertySet*)</code>
    /// </summary>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.AvailablePropertySet*, byte>)0x00467A90)(ref this, set);

    /// <summary>
    /// <code>Offset: 0x00467AE0
    /// void __thiscall UIElement_Text::ClearAllText(UIElement_Text*)</code>
    /// </summary>
    public void ClearAllText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x00467AE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00467B60
    /// void __thiscall UIElement_Text::SelectAll(UIElement_Text*)</code>
    /// </summary>
    public void SelectAll() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x00467B60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00467BC0
    /// void __thiscall UIElement_Text::Deselect(UIElement_Text*)</code>
    /// </summary>
    public void Deselect() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x00467BC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00467C30
    /// _DWORD* __thiscall UIElement_Text::GetSelectedText(UIElement_Text*,_DWORD*)</code>
    /// </summary>
    public int* GetSelectedText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, int*>)0x00467C30)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00467CC0
    /// void __thiscall UIElement_Text::ResizeTo(UIElement_Text*,const int,const int)</code>
    /// </summary>
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, int, void>)0x00467CC0)(ref this, width, height);

    /// <summary>
    /// <code>Offset: 0x00467D30
    /// void __thiscall UIElement_Text::DrawSelf(UIRegion*,Box2D*,unsigned int*,_DWORD*,UISurface*)</code>
    /// </summary>
    public void DrawSelf(ACBindings.Internal.Box2D* a2, uint* a3, int* a4, ACBindings.Internal.UISurface* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.Box2D*, uint*, int*, ACBindings.Internal.UISurface*, void>)0x00467D30)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x00468360
    /// void __thiscall UIElement_Text::SetEditable(UIElement_Text*,bool)</code>
    /// </summary>
    public void SetEditable(byte editable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00468360)(ref this, editable);

    /// <summary>
    /// <code>Offset: 0x00468400
    /// void __thiscall UIElement_Text::SetOneLine(UIElement_Text*,bool)</code>
    /// </summary>
    public void SetOneLine(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00468400)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x00468450
    /// void __thiscall UIElement_Text::SetSelectable(UIElement_Text*,bool)</code>
    /// </summary>
    public void SetSelectable(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00468450)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x00468520
    /// void __thiscall UIElement_Text::SetFontDIDNum(UIElement_Text*,unsigned int)</code>
    /// </summary>
    public void SetFontDIDNum(uint fontDIDNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, void>)0x00468520)(ref this, fontDIDNum);

    /// <summary>
    /// <code>Offset: 0x00468540
    /// void __thiscall UIElement_Text::SetFontColorNum(UIElement_Text*,unsigned int)</code>
    /// </summary>
    public void SetFontColorNum(uint fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, void>)0x00468540)(ref this, fontColorNum);

    /// <summary>
    /// <code>Offset: 0x00468570
    /// bool __thiscall UIElement_Text::MoveUpDown(UIElement_Text*,int,unsigned int,unsigned int*)</code>
    /// </summary>
    public byte MoveUpDown(int i_bUp, uint i_nStart, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, uint, uint*, byte>)0x00468570)(ref this, i_bUp, i_nStart, o_nPos);

    /// <summary>
    /// <code>Offset: 0x004686B0
    /// bool __thiscall UIElement_Text::RecalculateGlyphList(UIElement_Text*)</code>
    /// </summary>
    public byte RecalculateGlyphList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte>)0x004686B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004687D0
    /// void __thiscall UIElement_Text::SetFitToText(UIElement_Text*,bool)</code>
    /// </summary>
    public void SetFitToText(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x004687D0)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x00468800
    /// void __thiscall UIElement_Text::UIElement_Text(UIElement_Text*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00468800)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x00468A50
    /// UIElementMessageListenResult __thiscall UIElement_Text::ListenToElementMessage(UIElement_Text*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00468A50)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x00468B30
    /// void __thiscall UIElement_Text::Copy(UIElement_Text*)</code>
    /// </summary>
    public void Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x00468B30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00468B80
    /// unsigned int __thiscall UIElement_Text::DeterminePositionFromXY(UIElement_Text*,int,int)</code>
    /// </summary>
    public uint DeterminePositionFromXY(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, int, uint>)0x00468B80)(ref this, i_x, i_y);

    /// <summary>
    /// <code>Offset: 0x00468C40
    /// int __thiscall UIElement_Text::InqScrollDelta(UIElement_Text*,int,bool,bool)</code>
    /// </summary>
    public int InqScrollDelta(int i_bHorizontal, byte i_bIncrement, byte i_bPage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, byte, byte, int>)0x00468C40)(ref this, i_bHorizontal, i_bIncrement, i_bPage);

    /// <summary>
    /// <code>Offset: 0x00468D20
    /// void __cdecl UIElement_Text::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00468D20)();

    /// <summary>
    /// <code>Offset: 0x00468D30
    /// bool __thiscall UIElement_Text::IsPositionInView(UIElement_Text*,const int*)</code>
    /// </summary>
    public byte IsPositionInView(int* nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, byte>)0x00468D30)(ref this, nPos);

    /// <summary>
    /// <code>Offset: 0x00468E20
    /// bool __thiscall UIElement_Text::SetCursorPosition(UIElement_Text*,unsigned int,UIElement_Text::CursorMovementFlags)</code>
    /// </summary>
    public byte SetCursorPosition(uint i_nPos, ACBindings.Internal.UIElement_Text.CursorMovementFlags i_selMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, ACBindings.Internal.UIElement_Text.CursorMovementFlags, byte>)0x00468E20)(ref this, i_nPos, i_selMode);

    /// <summary>
    /// <code>Offset: 0x00468F60
    /// bool __thiscall UIElement_Text::SetCursorPositionFromXY(UIElement_Text*,int,int,UIElement_Text::CursorMovementFlags)</code>
    /// </summary>
    public byte SetCursorPositionFromXY(int i_x, int i_y, ACBindings.Internal.UIElement_Text.CursorMovementFlags i_selMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, int, ACBindings.Internal.UIElement_Text.CursorMovementFlags, byte>)0x00468F60)(ref this, i_x, i_y, i_selMode);

    /// <summary>
    /// <code>Offset: 0x00468F90
    /// bool __thiscall UIElement_Text::MoveCursor(UIElement_Text*,TextDefs::Direction)</code>
    /// </summary>
    public byte MoveCursor(ACBindings.Internal.TextDefs.Direction dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.TextDefs.Direction, byte>)0x00468F90)(ref this, dir);

    /// <summary>
    /// <code>Offset: 0x00469100
    /// void __thiscall UIElement_Text::MoveCursorToEnd(UIElement_Text*)</code>
    /// </summary>
    public void MoveCursorToEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x00469100)(ref this);

    /// <summary>
    /// <code>Offset: 0x00469120
    /// void __thiscall UIElement_Text::MoveCursorToPosition(UIElement_Text*,int)</code>
    /// </summary>
    public void MoveCursorToPosition(int i_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, void>)0x00469120)(ref this, i_nPos);

    /// <summary>
    /// <code>Offset: 0x00469130
    /// char __thiscall UIElement_Text::InqGlyphs(char*,int*,int*)</code>
    /// </summary>
    public sbyte InqGlyphs(int* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, int*, sbyte>)0x00469130)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00469440
    /// void __thiscall UIElement_Text::ScrollToPosition(UIElement_Text*,const int)</code>
    /// </summary>
    public void ScrollToPosition(int i_iPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, void>)0x00469440)(ref this, i_iPos);

    /// <summary>
    /// <code>Offset: 0x004695E0
    /// bool __thiscall UIElement_Text::IsAtVerticalEnd(UIElement_Text*)</code>
    /// </summary>
    public byte IsAtVerticalEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte>)0x004695E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00469600
    /// void __thiscall UIElement_Text::MouseDown(UIElement_Text*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void MouseDown(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, uint, uint, void>)0x00469600)(ref this, xWindow, yWindow, button);

    /// <summary>
    /// <code>Offset: 0x00469780
    /// void __thiscall UIElement_Text::MouseUp(UIElement_Text*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void MouseUp(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, uint, uint, void>)0x00469780)(ref this, xWindow, yWindow, button);

    /// <summary>
    /// <code>Offset: 0x00469880
    /// void __thiscall UIElement_Text::MouseMove(UIElement_Text*,int,int)</code>
    /// </summary>
    public void MouseMove(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, int, void>)0x00469880)(ref this, i_xWindow, i_yWindow);

    /// <summary>
    /// <code>Offset: 0x004698F0
    /// bool __thiscall UIElement_Text::InqSizewMargins(UIElement_Text*,const StringInfo*,int*,int*,UIElement_Text::UIText_InqSize_Flag)</code>
    /// </summary>
    public byte InqSizewMargins(ACBindings.Internal.StringInfo* info, int* width, int* height, ACBindings.Internal.UIElement_Text.UIText_InqSize_Flag i_eFlag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.StringInfo*, int*, int*, ACBindings.Internal.UIElement_Text.UIText_InqSize_Flag, byte>)0x004698F0)(ref this, info, width, height, i_eFlag);

    /// <summary>
    /// <code>Offset: 0x00469A90
    /// void __thiscall UIElement_Text::DeleteSection(UIElement_Text*,unsigned int,unsigned int,bool)</code>
    /// </summary>
    public void DeleteSection(uint i_nStart, uint i_nEnd, byte i_bKeepCurrentTextInView) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, uint, byte, void>)0x00469A90)(ref this, i_nStart, i_nEnd, i_bKeepCurrentTextInView);

    /// <summary>
    /// <code>Offset: 0x00469C00
    /// void __thiscall UIElement_Text::BeheadText(UIElement_Text*,unsigned int,bool)</code>
    /// </summary>
    public void BeheadText(uint i_cPosition, byte bKeepCurrentTextInView) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, byte, void>)0x00469C00)(ref this, i_cPosition, bKeepCurrentTextInView);

    /// <summary>
    /// <code>Offset: 0x00469C20
    /// void __thiscall UIElement_Text::DeleteChar(UIElement_Text*)</code>
    /// </summary>
    public void DeleteChar() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x00469C20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00469C40
    /// void __thiscall UIElement_Text::DeleteSelection(UIElement_Text*)</code>
    /// </summary>
    public void DeleteSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x00469C40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00469CC0
    /// LONG __thiscall UIElement_Text::AddText_Internal(UIRegion*,int,char)</code>
    /// </summary>
    public int AddText_Internal(int a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, sbyte, int>)0x00469CC0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00469DF0
    /// void __thiscall UIElement_Text::Cut(UIElement_Text*)</code>
    /// </summary>
    public void Cut() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x00469DF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00469E20
    /// void __thiscall UIElement_Text::CharacterHandler(UIElement_Text*,wchar_t)</code>
    /// </summary>
    public void CharacterHandler(System.Char charToHandle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, System.Char, void>)0x00469E20)(ref this, charToHandle);

    /// <summary>
    /// <code>Offset: 0x00469F70
    /// LONG __thiscall UIElement_Text::AppendText(UIRegion*,int*)</code>
    /// </summary>
    public int AppendText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, int>)0x00469F70)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00469FA0
    /// void __thiscall UIElement_Text::AppendStringInfo(UIElement_Text*,const StringInfo*)</code>
    /// </summary>
    public void AppendStringInfo(ACBindings.Internal.StringInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.StringInfo*, void>)0x00469FA0)(ref this, info);

    /// <summary>
    /// <code>Offset: 0x0046A000
    /// LONG __thiscall UIElement_Text::AppendTextWithFont(UIElement_Text*,int*,unsigned int,unsigned int)</code>
    /// </summary>
    public int AppendTextWithFont(int* a2, uint fontDIDNum, uint fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, uint, uint, int>)0x0046A000)(ref this, a2, fontDIDNum, fontColorNum);

    /// <summary>
    /// <code>Offset: 0x0046A070
    /// void __thiscall UIElement_Text::AppendStringInfoWithFont(UIElement_Text*,const StringInfo*,int,int)</code>
    /// </summary>
    public void AppendStringInfoWithFont(ACBindings.Internal.StringInfo* info, int fontDIDNum, int fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.StringInfo*, int, int, void>)0x0046A070)(ref this, info, fontDIDNum, fontColorNum);

    /// <summary>
    /// <code>Offset: 0x0046A100
    /// void __thiscall UIElement_Text::CheckStringDownloads(UIElement_Text*)</code>
    /// </summary>
    public void CheckStringDownloads() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x0046A100)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046A250
    /// void __thiscall UIElement_Text::Global_Loop(UIElement_Text*)</code>
    /// </summary>
    public void Global_Loop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x0046A250)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046A350
    /// void __thiscall UIElement_Text::SetStringInfo(UIElement_Text*,const StringInfo*)</code>
    /// </summary>
    public void SetStringInfo(ACBindings.Internal.StringInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.StringInfo*, void>)0x0046A350)(ref this, info);

    /// <summary>
    /// <code>Offset: 0x0046A370
    /// void __thiscall UIElement_Text::SetStringInfoWithFont(UIElement_Text*,const StringInfo*,int,int)</code>
    /// </summary>
    public void SetStringInfoWithFont(ACBindings.Internal.StringInfo* info, int fontDIDNum, int fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.StringInfo*, int, int, void>)0x0046A370)(ref this, info, fontDIDNum, fontColorNum);

    /// <summary>
    /// <code>Offset: 0x0046A3A0
    /// void __thiscall UIElement_Text::Paste(UIElement_Text*)</code>
    /// </summary>
    public void Paste() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x0046A3A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046A4F0
    /// bool __thiscall UIElement_Text::OnAction(UIElement_Text*,const InputEvent*)</code>
    /// </summary>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.InputEvent*, byte>)0x0046A4F0)(ref this, i_evt);

    /// <summary>
    /// <code>Offset: 0x0046A730
    /// void __thiscall UIElement_Text::ListenToGlobalMessage(UIElement_Text*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint messageID, int data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, int, void>)0x0046A730)(ref this, messageID, data);

    /// <summary>
    /// <code>Offset: 0x0046A740
    /// void __thiscall UIElement_Text::SetText(UIElement_Text*,int*)</code>
    /// </summary>
    public void SetText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, void>)0x0046A740)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0046A790
    /// void __thiscall UIElement_Text::SetTextWithFont(UIElement_Text*,int*,int,int)</code>
    /// </summary>
    public void SetTextWithFont(int* a2, int fontDIDNum, int fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, int, int, void>)0x0046A790)(ref this, a2, fontDIDNum, fontColorNum);

    /// <summary>
    /// <code>Offset: 0x0046A7F0
    /// void __thiscall UIElement_Text::DoFontReset(UIElement_Text*)</code>
    /// </summary>
    public void DoFontReset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x0046A7F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0046A870
    /// void __thiscall UIElement_Text::MatchElement(UIElement_Text*,const UIElement*)</code>
    /// </summary>
    public void MatchElement(ACBindings.Internal.UIElement* elem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.UIElement*, void>)0x0046A870)(ref this, elem);

    /// <summary>
    /// <code>Offset: 0x0046A8D0
    /// void __thiscall UIElement_Text::OnSetAttribute(UIElement_Text*,const BaseProperty*)</code>
    /// </summary>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.BaseProperty*, void>)0x0046A8D0)(ref this, attribute);

    /// <summary>
    /// <code>Offset: 0x006B1960
    /// unsigned int __thiscall UIElement_Text::GetUIElementType(TextureVelocityPartHook*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint>)0x006B1960)(ref this);
}

