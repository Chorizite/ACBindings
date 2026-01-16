namespace ACBindings.Internal;


/// <summary>Represents an interactive text display within the user interface, capable of scrolling, input handling, and rich formatting support such as cursor positioning, selection, truncation, justification, color, and font customization.</summary>
public unsafe struct UIElement_Text : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Scrollable BaseClass_UIElement_Scrollable; // ACBindings.Internal.UIElement_Scrollable
    public ACBindings.Internal.CInputHandler BaseClass_CInputHandler; // ACBindings.Internal.CInputHandler

    // Child Types
    public unsafe struct UIElement_Text_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*> GetSurfaceBox; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> HasCursor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawStart; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> EraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawDone; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> DynamicCast; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint> GetUIElementType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> SetState; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetParent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.UIElement*> GetAncestorByID; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> KeyUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, float, byte> KeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, int, byte> RegisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> UnregisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.InputEvent*, byte> OnChildAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> Initialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> PostInit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.AvailablePropertySet*, byte> InqAvailableProperties; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, void> OnSetAttribute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, byte> ContainsProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, uint, ACBindings.Internal.BaseProperty*, byte> InqProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.BaseProperty*, byte> SetProperty; // function pointer
        public fixed byte gapD8[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.FunctionSignatureChanged> CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, ACBindings.Internal.UIElement.FunctionSignatureChanged> DragAndDropComplete; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement**, byte> DragItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*> GetDragAndDropCatcher; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> MatchElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, void> UpdateForChildSizeChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> UpdateForParentVisibilityChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Activate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> Deactivate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> TakeFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> RelinquishFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetActivatable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> SetMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, void> UpdateForScreenPositionChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject*, byte> SetUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIObject**, byte> MakeUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement*, byte, void> OnChildActivationChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte> GetShouldBeMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult, ACBindings.Internal.UIElementMessageListenResult> ForwardElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElementMessageInfo*, byte> DefElementMessageHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, byte, void> OnVisibilityChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement.Intialized_Has_Been_Replaced_With_PostInit> Initialized; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_Scrollable*, void> AdjustToScrollableXYChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_Scrollable*, byte, byte, byte, int> InqScrollDelta; // function pointer

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
    public static delegate* unmanaged[Cdecl]<ushort, byte> m_filter; // function pointer
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

    /// <summary>Clears the current text selection and disables selecting mode.
    /// <code>Offset: 0x00466540
    /// bool __thiscall UIElement_Text::ClearSelection(UIElement_Text*)</code>
    /// </summary>
    /// <returns>True after clearing the selection.</returns>
    public byte ClearSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte>)0x00466540)(ref this);

    /// <summary>Scrolls the text widget up or down by one page, updating the vertical scroll position accordingly.
    /// <code>Offset: 0x00466570
    /// void __thiscall UIElement_Text::ScrollPage(UIElement_Text*,bool)</code>
    /// </summary>
    /// <param name="i_bUp">If true, scrolls upward; if false, scrolls downward.</param>
    public void ScrollPage(byte i_bUp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00466570)(ref this, i_bUp);

    /// <summary>Enables or disables the no‑IME state of the text element, controlling whether input method editor handling is suppressed.
    /// <code>Offset: 0x00466730
    /// void __thiscall UIElement_Text::SetNoIme(UIElement_Text*,bool)</code>
    /// </summary>
    /// <param name="b">True to enable no‑IME; false to allow IME processing.</param>
    public void SetNoIme(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00466730)(ref this, b);

    /// <summary>Enables or disables the outline rendering for this text element.
    /// <code>Offset: 0x00466760
    /// void __thiscall UIElement_Text::SetOutline(UIElement_Text*,bool)</code>
    /// </summary>
    /// <param name="b">True to enable outline; false to disable it.</param>
    public void SetOutline(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00466760)(ref this, b);

    /// <summary>Enables the input method editor for this text element, performing required resource loading if it is not already active.
    /// <code>Offset: 0x00466790
    /// bool __thiscall UIElement_Text::IMETurnOn(UIElement_Text*)</code>
    /// </summary>
    /// <returns>True when the IME was activated and initialization succeeded; otherwise false.</returns>
    public byte IMETurnOn() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte>)0x00466790)(ref this);

    /// <summary>Cleans up any pending string download operations for the text element by completing them, clearing the queue, and unregistering from global messages.
    /// <code>Offset: 0x004667D0
    /// void __thiscall UIElement_Text::CleanupStringDownloads(UIElement_Text*)</code>
    /// </summary>
    public void CleanupStringDownloads() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x004667D0)(ref this);

    /// <summary>
    /// Retrieves the current Unicode text stored in the element’s glyph list and returns it via the provided output pointer, handling reference counting to maintain buffer validity.
    /// 
    /// <code>Offset: 0x00466830
    /// _DWORD* __thiscall UIElement_Text::GetText(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a location where the address of the retrieved string will be written.</param>
    /// <returns>Returns the same value as the output parameter (the address of the extracted text).</returns>
    public int* GetText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, int*>)0x00466830)(ref this, a2);

    /// <summary>Retrieves the element’s current pre‑parsed text string, increments its reference count, and returns the string pointer via the supplied output parameter.
    /// <code>Offset: 0x004668A0
    /// _DWORD* __thiscall UIElement_Text::GetPreParsedText(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="this">Pointer to the UIElement_Text instance.</param>
    /// <param name="a2">Output buffer that receives a pointer to the retrieved string (or null if none).</param>
    /// <returns>Returns the same pointer provided in <paramref name="a2"/> pointing to the pre‑parsed text.</returns>
    public int* GetPreParsedText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, int*>)0x004668A0)(ref this, a2);

    /// <summary>Enables or disables text selection for the UI element, updating internal flags and clearing any existing selection when turned off.
    /// <code>Offset: 0x00466910
    /// void __thiscall UIElement_Text::SetSelecting(UIElement_Text*,bool)</code>
    /// </summary>
    /// <param name="b">True activates selecting mode; false deactivates it and resets selection indices.</param>
    public void SetSelecting(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00466910)(ref this, b);

    /// <summary>Marks the UI element as requiring layout and rendering updates or clears that state.
    /// <code>Offset: 0x00466980
    /// void __thiscall UIElement_Text::SetDirty(UIElement_Text*,bool)</code>
    /// </summary>
    /// <param name="b">True to set the dirty flag; false to clear it.</param>
    public void SetDirty(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00466980)(ref this, b);

    /// <summary>Adjusts the element’s margin values (top, bottom, left, right) to fit within the bounds of an input event rectangle, ensuring each margin does not exceed the available space.
    /// <code>Offset: 0x004669D0
    /// void __thiscall UIElement_Text::DetermineMarginValues(UIElement_Text*)</code>
    /// </summary>
    public void DetermineMarginValues() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x004669D0)(ref this);

    /// <summary>Sets the font of a text UI element using a property identifier and a font DID number, handling reference counting and retrieving global or local fonts as required.
    /// <code>Offset: 0x00466A90
    /// void __thiscall UIElement_Text::SetFontDIDHelper(UIElement_Text*,unsigned int,Font**,unsigned int)</code>
    /// </summary>
    /// <param name="property">Identifier for the font property to be applied.</param>
    /// <param name="font">Pointer to a Font* that will receive the selected font; may be released if replaced.</param>
    /// <param name="fontDIDNum">Index used when looking up the desired font within the property's value list.</param>
    public void SetFontDIDHelper(uint property, ACBindings.Internal.Font** font, uint fontDIDNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, ACBindings.Internal.Font**, uint, void>)0x00466A90)(ref this, property, font, fontDIDNum);

    /// <summary>Updates a specified font color entry in the text element’s property system with a new RGBA value.
    /// <code>Offset: 0x00466BF0
    /// void __thiscall UIElement_Text::SetFontColorHelper(UIElement_Text*,unsigned int,RGBAColor*,unsigned int)</code>
    /// </summary>
    /// <param name="property">Identifier of the target property to modify.</param>
    /// <param name="color">RGBAColor containing the new color components.</param>
    /// <param name="fontColorNum">Index within the property that specifies which font color slot to update.</param>
    public void SetFontColorHelper(uint property, ACBindings.Internal.RGBAColor* color, uint fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, ACBindings.Internal.RGBAColor*, uint, void>)0x00466BF0)(ref this, property, color, fontColorNum);

    /// <summary>Assigns a new font identifier to the text element and updates its associated properties.
    /// <code>Offset: 0x00466E80
    /// void __thiscall UIElement_Text::SetFontDID(void*,int)</code>
    /// </summary>
    /// <param name="a2">The new font identifier (DID) to apply.</param>
    public void SetFontDID(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, void>)0x00466E80)(ref this, a2);

    /// <summary>Changes the element’s font identifier while preserving its current displayed text.
    /// <code>Offset: 0x00466FE0
    /// void __thiscall UIElement_Text::SetFontDIDWithoutChangingExistingText(void*,int)</code>
    /// </summary>
    /// <param name="a2">The new font data ID to apply.</param>
    public void SetFontDIDWithoutChangingExistingText(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, void>)0x00466FE0)(ref this, a2);

    /// <summary>Replaces all existing glyphs in the UI text element with those from a new font, marking the element dirty if necessary.
    /// <code>Offset: 0x00467000
    /// void __thiscall UIElement_Text::ChangeExistingTextToNewFont(UIElement_Text*,Font*)</code>
    /// </summary>
    /// <param name="i_pNewFont">The font to apply to all glyphs in the text element.</param>
    public void ChangeExistingTextToNewFont(ACBindings.Internal.Font* i_pNewFont) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.Font*, void>)0x00467000)(ref this, i_pNewFont);

    /// <summary>Computes the glyph index at the beginning or end of the line that contains a given reference position and writes it into o_nPos. The element’s internal cursor is not modified.
    /// <code>Offset: 0x00467040
    /// bool __thiscall UIElement_Text::MoveBeginEndLine(UIElement_Text*,unsigned int,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="i_bBegin">Non‑zero selects the first glyph of the current line; zero selects the last glyph of that line.</param>
    /// <param name="i_nStart">Reference glyph index used to locate the current line within the text.</param>
    /// <param name="o_nPos">Receives the calculated glyph index. For a request for the end of the final line, this is set to the total number of glyphs in the list (one past the last glyph).</param>
    /// <returns>True when a valid position was computed and written to o_nPos; false if no suitable line could be found.</returns>
    public byte MoveBeginEndLine(uint i_bBegin, uint i_nStart, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, uint, uint*, byte>)0x00467040)(ref this, i_bBegin, i_nStart, o_nPos);

    /// <summary>Sets the starting index of the text selection, clamping it within the bounds of the glyph list and resetting any existing selection range.
    /// <code>Offset: 0x004670F0
    /// bool __thiscall UIElement_Text::SetSelectionStart(UIElement_Text*,unsigned int)</code>
    /// </summary>
    /// <param name="i_nPos">The desired position for the cursor or selection start.</param>
    /// <returns>True if the selection start was updated; false when the element is in a non‑editable state.</returns>
    public byte SetSelectionStart(uint i_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, byte>)0x004670F0)(ref this, i_nPos);

    /// <summary>Sets the selection end position within the text, clamping it to the available glyph count and marking the element dirty when changed.
    /// <code>Offset: 0x00467150
    /// bool __thiscall UIElement_Text::SetSelectionEnd(UIElement_Text*,unsigned int)</code>
    /// </summary>
    /// <param name="i_nPos">Desired selection end index.</param>
    /// <returns>True if the selection end was updated; false if the element is in a state that disallows modification.</returns>
    public byte SetSelectionEnd(uint i_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, byte>)0x00467150)(ref this, i_nPos);

    /// <summary>Retrieves the current text selection range from this UI element.
    /// <code>Offset: 0x004671B0
    /// bool __thiscall UIElement_Text::GetSelection(UIElement_Text*,unsigned int*,unsigned int*)</code>
    /// </summary>
    /// <param name="o_nStart">Receives the smallest index of the selected characters; remains 0 when no selection exists.</param>
    /// <param name="o_nEnd">Receives the largest index of the selected characters; remains 0 when no selection exists.</param>
    /// <returns>True if a selection is active (selection flag set); otherwise false.</returns>
    public byte GetSelection(uint* o_nStart, uint* o_nEnd) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint*, uint*, byte>)0x004671B0)(ref this, o_nStart, o_nEnd);

    /// <summary>Recalculates the point at which the displayed text must be truncated when it exceeds the available drawing area, updating internal truncation metrics and optionally setting a tooltip containing the full untruncated text.
    /// <code>Offset: 0x00467210
    /// void __thiscall UIElement_Text::RecalculateTruncation(UIElement_Text*,int*,int*)</code>
    /// </summary>
    /// <param name="io_iPaperWidth">Reference to the width of the text “paper”; may be updated with an adjusted width after truncation logic is applied.</param>
    /// <param name="io_iPaperHeight">Reference to the height of the text “paper”; used for vertical layout calculations and may be updated when necessary.</param>
    public void RecalculateTruncation(int* io_iPaperWidth, int* io_iPaperHeight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, int*, void>)0x00467210)(ref this, io_iPaperWidth, io_iPaperHeight);

    /// <summary>Updates the element's horizontal justification and marks its region as needing a redraw when changed.
    /// <code>Offset: 0x00467490
    /// bool __thiscall UIElement_Text::SetHorizontalJustification(UIElement_Text*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eJustification">The desired horizontal justification setting.</param>
    /// <returns>True after applying the change.</returns>
    public byte SetHorizontalJustification(uint i_eJustification) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, byte>)0x00467490)(ref this, i_eJustification);

    /// <summary>Sets the vertical alignment mode for the text element and marks its layout dirty when changed.
    /// <code>Offset: 0x004674C0
    /// bool __thiscall UIElement_Text::SetVerticalJustification(UIElement_Text*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eJustification">The desired vertical justification value.</param>
    /// <returns>Always true to indicate the operation succeeded.</returns>
    public byte SetVerticalJustification(uint i_eJustification) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, byte>)0x004674C0)(ref this, i_eJustification);

    /// <summary>Calculates the justification offset for a UI element’s text by taking into account the text size, margins, scrollable area dimensions and the element’s current horizontal or vertical alignment setting.
    /// <code>Offset: 0x004674F0
    /// int __thiscall UIElement_Text::CalcJustification(UIElement_Text*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="i_uiTextSize">The width (when computing horizontal alignment) or height (when computing vertical alignment) of the rendered text in pixels.</param>
    /// <param name="i_bHorizontal">True to calculate horizontal justification; false to calculate vertical justification.</param>
    /// <returns>The pixel offset that should be applied to position the text correctly within its container.</returns>
    public int CalcJustification(uint i_uiTextSize, byte i_bHorizontal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, byte, int>)0x004674F0)(ref this, i_uiTextSize, i_bHorizontal);

    /// <summary>Registers the text element's input mappings, including scrollable behavior and any additional input actions specified by internal flags.
    /// <code>Offset: 0x004675E0
    /// bool __thiscall UIElement_Text::RegisterInputMaps(UIElement_Text*,int)</code>
    /// </summary>
    /// <param name="i_nPriority">Base priority for registering input maps; adjusted when adding supplemental maps.</param>
    /// <returns>True if all required input maps were registered successfully; otherwise false.</returns>
    public byte RegisterInputMaps(int i_nPriority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, byte>)0x004675E0)(ref this, i_nPriority);

    /// <summary>Removes input maps associated with this text element from the global input manager and its scrollable base class, conditionally unregistering additional maps based on internal flags.
    /// <code>Offset: 0x00467660
    /// bool __thiscall UIElement_Text::UnregisterInputMaps(UIElement_Text*)</code>
    /// </summary>
    /// <returns>True if at least one unregistration succeeded; otherwise false.</returns>
    public byte UnregisterInputMaps() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte>)0x00467660)(ref this);

    /// <summary>Flags the text element as dirty when its scroll position changes, ensuring it will be redrawn during the next layout pass.
    /// <code>Offset: 0x004676D0
    /// void __thiscall UIElement_Text::AdjustToScrollableXYChange(UIElement_Text*)</code>
    /// </summary>
    public void AdjustToScrollableXYChange() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x004676D0)(ref this);

    /// <summary>Determines whether this text element should appear when the cursor is over it by checking internal flags or inheriting visibility from its base class.
    /// <code>Offset: 0x004676F0
    /// bool __thiscall UIElement_Text::GetShouldBeMouseVisible(UIElement_Text*)</code>
    /// </summary>
    /// <returns>True if either specific bits in m_bitField are set or if the parent UIElement reports that it should be visible; otherwise false.</returns>
    public byte GetShouldBeMouseVisible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte>)0x004676F0)(ref this);

    /// <summary>Enables or disables automatic text truncation for the UI element, updating internal flags and marking the region dirty when a change occurs.
    /// <code>Offset: 0x00467710
    /// void __thiscall UIElement_Text::SetTruncateTextToFit(UIElement_Text*,bool)</code>
    /// </summary>
    /// <param name="b">True to enable truncation; false to disable.</param>
    public void SetTruncateTextToFit(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00467710)(ref this, b);

    /// <summary>Sets whether the text UI element will lose focus when the Escape key is pressed.
    /// <code>Offset: 0x00467780
    /// void __thiscall UIElement_Text::SetLoseFocusOnEscape(UIElement_Text*,bool)</code>
    /// </summary>
    /// <param name="b">True enables the Lose‑Focus‑On‑Escape behavior; false disables it.</param>
    public void SetLoseFocusOnEscape(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00467780)(ref this, b);

    /// <summary>Configures the text element to lose focus automatically when an accept input action is performed.
    /// <code>Offset: 0x004677B0
    /// void __thiscall UIElement_Text::SetLoseFocusOnAcceptInput(UIElement_Text*,bool)</code>
    /// </summary>
    /// <param name="b">True to enable loss of focus on accept; false to keep focus after accepting input.</param>
    public void SetLoseFocusOnAcceptInput(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x004677B0)(ref this, b);

    /// <summary>Resizes the text element so its content fits within the current display width, applying horizontal and vertical margins. Retrieves a custom paper size attribute if present, otherwise defaults to the device’s display width, recalculates the glyph list, and adjusts the element’s bounds accordingly.
    /// <code>Offset: 0x004677E0
    /// void __thiscall UIElement_Text::ResizeToPaper(UIElement_Text*)</code>
    /// </summary>
    public void ResizeToPaper() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x004677E0)(ref this);

    /// <summary>Destroys a UIElement_Text instance, releasing its font object, flushing and destroying glyph lists, cleaning up string downloads, deallocating any pending download queue memory, resetting scrollbar identifiers, and invoking the base class destructors.
    /// <code>Offset: 0x004679F0
    /// void __thiscall UIElement_Text::~UIElement_Text(UIElement_Text*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x004679F0)(ref this);

    /// <summary>Returns a pointer to the requested base class of a UIElement_Text instance based on a type identifier.
    /// <code>Offset: 0x00467A70
    /// UIElement* __thiscall UIElement_Text::DynamicCast(UIElement_Text*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The type identifier specifying which base class pointer to return.</param>
    /// <returns>Pointer to the matching base class, or null if the specified type does not match any supported base class.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, ACBindings.Internal.UIElement*>)0x00467A70)(ref this, i_eType);

    /// <summary>Populates the supplied AvailablePropertySet with properties applicable to this text element, combining those from its scrollable base and the MasterProperty group identified by 0x13.
    /// <code>Offset: 0x00467A90
    /// bool __thiscall UIElement_Text::InqAvailableProperties(UIElement_Text*,AvailablePropertySet*)</code>
    /// </summary>
    /// <param name="set">The set of available properties to populate; must not be null for successful operation.</param>
    /// <returns>True if the set is non‑null and both the base class and master property queries succeeded; otherwise false.</returns>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.AvailablePropertySet*, byte>)0x00467A90)(ref this, set);

    /// <summary>Clears all displayed text from the element by flushing glyphs and pending downloads, resets cursor and selection positions, updates internal flags to reflect an empty string, and marks the region dirty so a redraw is performed if necessary.
    /// <code>Offset: 0x00467AE0
    /// void __thiscall UIElement_Text::ClearAllText(UIElement_Text*)</code>
    /// </summary>
    public void ClearAllText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x00467AE0)(ref this);

    /// <summary>Selects all text within the element by setting the selection start to zero and the selection end to the total number of glyphs, updating internal state flags accordingly.
    /// <code>Offset: 0x00467B60
    /// void __thiscall UIElement_Text::SelectAll(UIElement_Text*)</code>
    /// </summary>
    public void SelectAll() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x00467B60)(ref this);

    /// <summary>Clears any active text selection within the element, resetting the selection range and related state flags. After clearing the selection, it marks the UI element dirty so that the visual representation is refreshed to reflect the change.
    /// <code>Offset: 0x00467BC0
    /// void __thiscall UIElement_Text::Deselect(UIElement_Text*)</code>
    /// </summary>
    public void Deselect() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x00467BC0)(ref this);

    /// <summary>Retrieves the currently highlighted substring from this UIElement_Text instance, returning it via an output parameter and handling reference counting for the resulting string.
    /// <code>Offset: 0x00467C30
    /// _DWORD* __thiscall UIElement_Text::GetSelectedText(UIElement_Text*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Receives a pointer to the Unicode string containing the selected text; may point to a null buffer if no selection exists.</param>
    /// <returns>Returns the same pointer supplied in <paramref name="a2"/> for convenience.</returns>
    public int* GetSelectedText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, int*>)0x00467C30)(ref this, a2);

    /// <summary>Resizes a text UI element to the given width and height, recalculating margin values when the size changes.
    /// <code>Offset: 0x00467CC0
    /// void __thiscall UIElement_Text::ResizeTo(UIElement_Text*,const int,const int)</code>
    /// </summary>
    /// <param name="width">The new width of the element in pixels.</param>
    /// <param name="height">The new height of the element in pixels.</param>
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, int, void>)0x00467CC0)(ref this, width, height);

    /// <summary>Renders the text element onto the supplied surface, drawing only the characters and lines indicated by the index array while applying horizontal and vertical justification, clipping to the specified region, and highlighting any selected portion.
    /// <code>Offset: 0x00467D30
    /// void __thiscall UIElement_Text::DrawSelf(UIRegion*,Box2D*,unsigned int*,_DWORD*,UISurface*)</code>
    /// </summary>
    /// <param name="a2">The rectangle that defines where the text should appear on screen.</param>
    /// <param name="a3">An array of four unsigned integers: <c>a3[0]</c> is the first character index to display; <c>a3[1]</c> is the first visible line number; <c>a3[2]</c> is the last character index to display; <c>a3[3]</c> is the last visible line number. Only characters and lines within these ranges are rendered.</param>
    /// <param name="a4">Additional state or flags forwarded to the base class drawing routine; this function does not use it directly.</param>
    /// <param name="a5">The rendering surface onto which the text, selection highlights, and background shapes are drawn. Rendering is skipped if this pointer is null.</param>
    public void DrawSelf(ACBindings.Internal.Box2D* a2, uint* a3, int* a4, ACBindings.Internal.UISurface* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.Box2D*, uint*, int*, ACBindings.Internal.UISurface*, void>)0x00467D30)(ref this, a2, a3, a4, a5);

    /// <summary>Enables or disables editing of a text UI element, updating internal flags and triggering a visual refresh when necessary.
    /// <code>Offset: 0x00468360
    /// void __thiscall UIElement_Text::SetEditable(UIElement_Text*,bool)</code>
    /// </summary>
    /// <param name="editable">True to allow the user to edit the text; false to make it read‑only.</param>
    public void SetEditable(byte editable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00468360)(ref this, editable);

    /// <summary>Sets or clears the one‑line display flag for the UI text element, updating internal state and marking the region dirty when a change occurs.
    /// <code>Offset: 0x00468400
    /// void __thiscall UIElement_Text::SetOneLine(UIElement_Text*,bool)</code>
    /// </summary>
    /// <param name="b">True to enable single‑line mode; false to allow multi‑line rendering.</param>
    public void SetOneLine(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00468400)(ref this, b);

    /// <summary>Enables or disables selecting of the UI text element, updating internal state and clearing any existing selection when disabled.
    /// <code>Offset: 0x00468450
    /// void __thiscall UIElement_Text::SetSelectable(UIElement_Text*,bool)</code>
    /// </summary>
    /// <param name="b">True to allow the element to be selectable; false to make it non-selectable.</param>
    public void SetSelectable(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x00468450)(ref this, b);

    /// <summary>Updates the text element's current font to the font specified by the given data ID number.
    /// <code>Offset: 0x00468520
    /// void __thiscall UIElement_Text::SetFontDIDNum(UIElement_Text*,unsigned int)</code>
    /// </summary>
    /// <param name="fontDIDNum">The identifier of the desired font.</param>
    public void SetFontDIDNum(uint fontDIDNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, void>)0x00468520)(ref this, fontDIDNum);

    /// <summary>Applies the specified font color index to both the main text color and its tag color for this UI element.
    /// <code>Offset: 0x00468540
    /// void __thiscall UIElement_Text::SetFontColorNum(UIElement_Text*,unsigned int)</code>
    /// </summary>
    /// <param name="fontColorNum">Identifier of the color palette entry to use when setting the font and tag colors.</param>
    public void SetFontColorNum(uint fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, void>)0x00468540)(ref this, fontColorNum);

    /// <summary>Moves the caret one line up or down from the specified cursor position within the text element, updating the output index.
    /// <code>Offset: 0x00468570
    /// bool __thiscall UIElement_Text::MoveUpDown(UIElement_Text*,int,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="i_bUp">Non‑zero to move upward; zero to move downward.</param>
    /// <param name="i_nStart">The current cursor index to start the movement from.</param>
    /// <param name="o_nPos">Receives the new cursor position after attempting the move.</param>
    /// <returns>True if a new position was calculated, or if the caret is already at the top or bottom line (no movement); false when no adjacent line can be found or another internal error occurs.</returns>
    public byte MoveUpDown(int i_bUp, uint i_nStart, uint* o_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, uint, uint*, byte>)0x00468570)(ref this, i_bUp, i_nStart, o_nPos);

    /// <summary>
    /// Recalculates the glyph layout for a text element when its “needs update” flag is set, adjusting dimensions, applying truncation if required, and updating the scrollable area accordingly.
    /// 
    /// <code>Offset: 0x004686B0
    /// bool __thiscall UIElement_Text::RecalculateGlyphList(UIElement_Text*)</code>
    /// </summary>
    /// <returns>True if the glyph list was recalculated; false otherwise.</returns>
    public byte RecalculateGlyphList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte>)0x004686B0)(ref this);

    /// <summary>Enables or disables automatic resizing of the text element so that it fits its content. When activated, resizes the element to match the current text size.
    /// <code>Offset: 0x004687D0
    /// void __thiscall UIElement_Text::SetFitToText(UIElement_Text*,bool)</code>
    /// </summary>
    /// <param name="this">The UIElement_Text instance whose fit-to-text behavior is being set.</param>
    /// <param name="b">True to enable fit‑to‑text; false to disable.</param>
    public void SetFitToText(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte, void>)0x004687D0)(ref this, b);

    /// <summary>Initializes a new text UI element, configuring layout parameters, default font settings, margins, and clearing any existing content.
    /// <code>Offset: 0x00468800
    /// void __thiscall UIElement_Text::UIElement_Text(UIElement_Text*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining display dimensions and element collection for the UI element.</param>
    /// <param name="full_desc">Element description providing visual and behavioral properties for the text element.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x00468800)(ref this, layout, full_desc);

    /// <summary>Handles element messages for a text UI component, toggling input and selection state when receiving message id 47 and delegating other messages to its scrollable base class.
    /// <code>Offset: 0x00468A50
    /// UIElementMessageListenResult __thiscall UIElement_Text::ListenToElementMessage(UIElement_Text*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Provides details about the incoming element message, including the target element, message ID, parameters, and coordinates.</param>
    /// <returns>Returns a UIElementMessageListenResult that indicates whether the message was processed by this component or forwarded to the base implementation.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x00468A50)(ref this, i_rMsg);

    /// <summary>Copies the currently selected portion of the text element into the system clipboard, provided a selection exists.
    /// <code>Offset: 0x00468B30
    /// void __thiscall UIElement_Text::Copy(UIElement_Text*)</code>
    /// </summary>
    public void Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x00468B30)(ref this);

    /// <summary>Translates an (x,y) coordinate inside a text element into the index of the glyph located at that point, taking scrolling and justification into account.
    /// <code>Offset: 0x00468B80
    /// unsigned int __thiscall UIElement_Text::DeterminePositionFromXY(UIElement_Text*,int,int)</code>
    /// </summary>
    /// <param name="i_x">X position relative to the left edge of the element before any scrolling offset is applied.</param>
    /// <param name="i_y">Y position relative to the top edge of the element before any scrolling offset is applied.</param>
    /// <returns>An unsigned integer index into the glyph list that corresponds to the supplied coordinates; if no matching glyph is found, returns 0. The returned value never exceeds the total number of glyphs in the list.</returns>
    public uint DeterminePositionFromXY(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, int, uint>)0x00468B80)(ref this, i_x, i_y);

    /// <summary>Computes the pixel amount required to scroll a text element either by one line or an entire page horizontally or vertically.
    /// <code>Offset: 0x00468C40
    /// int __thiscall UIElement_Text::InqScrollDelta(UIElement_Text*,int,bool,bool)</code>
    /// </summary>
    /// <param name="i_bHorizontal">True for horizontal scrolling, false for vertical scrolling.</param>
    /// <param name="i_bIncrement">If true, returns a negative delta indicating movement in the opposite direction; otherwise returns a positive delta.</param>
    /// <param name="i_bPage">If true, calculates a page‑sized scroll instead of a single line.</param>
    /// <returns>Signed integer representing pixels to shift; magnitude is constrained by the size of the current glyph line and the bounds of the text region.</returns>
    public int InqScrollDelta(int i_bHorizontal, byte i_bIncrement, byte i_bPage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, byte, byte, int>)0x00468C40)(ref this, i_bHorizontal, i_bIncrement, i_bPage);

    /// <summary>Registers the Text element class with the UI framework, associating a factory method for creating instances from layout descriptions.
    /// <code>Offset: 0x00468D20
    /// void __cdecl UIElement_Text::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x00468D20)();

    /// <summary>Determines whether the character at the supplied position index is currently visible within the text element, considering scrolling offsets and margin boundaries.
    /// <code>Offset: 0x00468D30
    /// bool __thiscall UIElement_Text::IsPositionInView(UIElement_Text*,const int*)</code>
    /// </summary>
    /// <param name="nPos">Pointer to an integer that specifies the glyph or character index to test.</param>
    /// <returns>True if the specified position lies inside the viewable area; otherwise, false.</returns>
    public byte IsPositionInView(int* nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, byte>)0x00468D30)(ref this, nPos);

    /// <summary>
    /// Sets the cursor to a specified position within the text, updating selection state, ensuring the new position is visible by scrolling if necessary, and marking the element dirty for repaint.
    /// 
    /// <code>Offset: 0x00468E20
    /// bool __thiscall UIElement_Text::SetCursorPosition(UIElement_Text*,unsigned int,UIElement_Text::CursorMovementFlags)</code>
    /// </summary>
    /// <param name="i_nPos">The target glyph index (0‑based) where the cursor should move.</param>
    /// <param name="i_selMode">Flag indicating how to handle text selection during the move (e.g., select text or default behavior).</param>
    /// <returns>True on success; this function always returns true.</returns>
    public byte SetCursorPosition(uint i_nPos, ACBindings.Internal.UIElement_Text.CursorMovementFlags i_selMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, ACBindings.Internal.UIElement_Text.CursorMovementFlags, byte>)0x00468E20)(ref this, i_nPos, i_selMode);

    /// <summary>Sets the cursor position within a text element based on (x,y) coordinates and a selection mode flag.
    /// <code>Offset: 0x00468F60
    /// bool __thiscall UIElement_Text::SetCursorPositionFromXY(UIElement_Text*,int,int,UIElement_Text::CursorMovementFlags)</code>
    /// </summary>
    /// <param name="i_x">The x-coordinate relative to the text area.</param>
    /// <param name="i_y">The y-coordinate relative to the text area.</param>
    /// <param name="i_selMode">Flags controlling how selection is applied when moving the cursor.</param>
    /// <returns>True if the cursor was successfully positioned; otherwise false.</returns>
    public byte SetCursorPositionFromXY(int i_x, int i_y, ACBindings.Internal.UIElement_Text.CursorMovementFlags i_selMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, int, ACBindings.Internal.UIElement_Text.CursorMovementFlags, byte>)0x00468F60)(ref this, i_x, i_y, i_selMode);

    /// <summary>Moves the cursor within a text element according to the supplied direction, updating its position and handling line or word boundaries, page scrolling, and direct jumps.
    /// <code>Offset: 0x00468F90
    /// bool __thiscall UIElement_Text::MoveCursor(UIElement_Text*,TextDefs::Direction)</code>
    /// </summary>
    /// <param name="dir">The movement direction specified by TextDefs::Direction (e.g., START, END, LENEXT, DIST, etc.).</param>
    /// <returns>True if the cursor was successfully moved; otherwise false.</returns>
    public byte MoveCursor(ACBindings.Internal.TextDefs.Direction dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.TextDefs.Direction, byte>)0x00468F90)(ref this, dir);

    /// <summary>Places the caret after the last glyph in the text, positioning it at the end of the current content.
    /// <code>Offset: 0x00469100
    /// void __thiscall UIElement_Text::MoveCursorToEnd(UIElement_Text*)</code>
    /// </summary>
    public void MoveCursorToEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x00469100)(ref this);

    /// <summary>Moves the text cursor to the specified absolute position within the element.
    /// <code>Offset: 0x00469120
    /// void __thiscall UIElement_Text::MoveCursorToPosition(UIElement_Text*,int)</code>
    /// </summary>
    /// <param name="i_nPos">The new cursor position (index into the glyph list).</param>
    public void MoveCursorToPosition(int i_nPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, void>)0x00469120)(ref this, i_nPos);

    /// <summary>Builds an array of glyph objects that represent each visible character in the UIElement_Text instance, interpreting inline formatting tags and applying them to the glyph data.
    /// <code>Offset: 0x00469130
    /// char __thiscall UIElement_Text::InqGlyphs(char*,int*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the text buffer whose glyphs are to be generated.</param>
    /// <param name="a3">Output structure into which the generated Glyph objects are written.</param>
    /// <returns>Non-zero if glyph generation succeeded; otherwise zero.</returns>
    public sbyte InqGlyphs(int* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, int*, sbyte>)0x00469130)(ref this, a2, a3);

    /// <summary>Scrolls the text element so that the glyph at a given index is visible, adjusting horizontal and vertical scroll offsets accordingly.
    /// <code>Offset: 0x00469440
    /// void __thiscall UIElement_Text::ScrollToPosition(UIElement_Text*,const int)</code>
    /// </summary>
    /// <param name="i_iPos">The zero‑based position of the glyph to bring into view.</param>
    public void ScrollToPosition(int i_iPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, void>)0x00469440)(ref this, i_iPos);

    /// <summary>Determines whether the final glyph of the text block lies within the visible vertical area.
    /// <code>Offset: 0x004695E0
    /// bool __thiscall UIElement_Text::IsAtVerticalEnd(UIElement_Text*)</code>
    /// </summary>
    /// <returns>True when the text reaches its vertical end or is empty; otherwise false.</returns>
    public byte IsAtVerticalEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, byte>)0x004695E0)(ref this);

    /// <summary>Handles mouse-down events for a text UI element, updating cursor position and managing text selection based on focus state and the pressed mouse button.
    /// <code>Offset: 0x00469600
    /// void __thiscall UIElement_Text::MouseDown(UIElement_Text*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="xWindow">X coordinate of the mouse click in window space.</param>
    /// <param name="yWindow">Y coordinate of the mouse click in window space.</param>
    /// <param name="button">Identifier for the mouse button that triggered the event.</param>
    public void MouseDown(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, uint, uint, void>)0x00469600)(ref this, xWindow, yWindow, button);

    /// <summary>Processes a mouse‑up event on the text element. If the release corresponds to a previously pressed button or an internal flag is set, it translates screen coordinates into a glyph position, updates the cursor, and if the click occurs over a tagged glyph, invokes that tag’s callback with the released button.
    /// <code>Offset: 0x00469780
    /// void __thiscall UIElement_Text::MouseUp(UIElement_Text*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="xWindow">The X coordinate of the mouse event in window space.</param>
    /// <param name="yWindow">The Y coordinate of the mouse event in window space.</param>
    /// <param name="button">The identifier of the mouse button that was released.</param>
    public void MouseUp(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, uint, uint, void>)0x00469780)(ref this, xWindow, yWindow, button);

    /// <summary>Updates the text element's cursor position based on mouse movement within its bounds, translating screen coordinates into a character index when active.
    /// <code>Offset: 0x00469880
    /// void __thiscall UIElement_Text::MouseMove(UIElement_Text*,int,int)</code>
    /// </summary>
    /// <param name="i_xWindow">The X coordinate of the mouse in window space.</param>
    /// <param name="i_yWindow">The Y coordinate of the mouse in window space.</param>
    public void MouseMove(int i_xWindow, int i_yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, int, void>)0x00469880)(ref this, i_xWindow, i_yWindow);

    /// <summary>Queries the rendered width and height of a text element, optionally adding its margins, based on a specified source string and size calculation mode.
    /// <code>Offset: 0x004698F0
    /// bool __thiscall UIElement_Text::InqSizewMargins(UIElement_Text*,const StringInfo*,int*,int*,UIElement_Text::UIText_InqSize_Flag)</code>
    /// </summary>
    /// <param name="info">The string information used to compute the size.</param>
    /// <param name="width">Output parameter receiving the computed width including left and right margins.</param>
    /// <param name="height">Output parameter receiving the computed height including top and bottom margins.</param>
    /// <param name="i_eFlag">Determines which width source to use (current, parent, description, or attribute).</param>
    /// <returns>True on success; always returns true in current implementation.</returns>
    public byte InqSizewMargins(ACBindings.Internal.StringInfo* info, int* width, int* height, ACBindings.Internal.UIElement_Text.UIText_InqSize_Flag i_eFlag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.StringInfo*, int*, int*, ACBindings.Internal.UIElement_Text.UIText_InqSize_Flag, byte>)0x004698F0)(ref this, info, width, height, i_eFlag);

    /// <summary>Removes a contiguous block of glyphs from the text element between the specified start and end indices. If requested, adjusts scrolling to keep the remaining visible portion unchanged.
    /// <code>Offset: 0x00469A90
    /// void __thiscall UIElement_Text::DeleteSection(UIElement_Text*,unsigned int,unsigned int,bool)</code>
    /// </summary>
    /// <param name="i_nStart">Zero‑based index of the first glyph to delete (inclusive).</param>
    /// <param name="i_nEnd">Zero‑based index of the glyph after the last one to delete (exclusive).</param>
    /// <param name="i_bKeepCurrentTextInView">When true, scroll offsets are recalculated so that the text currently in view remains visible after deletion.</param>
    public void DeleteSection(uint i_nStart, uint i_nEnd, byte i_bKeepCurrentTextInView) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, uint, byte, void>)0x00469A90)(ref this, i_nStart, i_nEnd, i_bKeepCurrentTextInView);

    /// <summary>Removes the portion of the element's text preceding the specified index, optionally preserving the current visible region.
    /// <code>Offset: 0x00469C00
    /// void __thiscall UIElement_Text::BeheadText(UIElement_Text*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="i_cPosition">The zero‑based character position up to which characters are removed.</param>
    /// <param name="bKeepCurrentTextInView">If true, keeps the remaining text within the viewable area after deletion; otherwise may shift the view.</param>
    public void BeheadText(uint i_cPosition, byte bKeepCurrentTextInView) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, byte, void>)0x00469C00)(ref this, i_cPosition, bKeepCurrentTextInView);

    /// <summary>Deletes the character directly after the current cursor position in the text element.
    /// <code>Offset: 0x00469C20
    /// void __thiscall UIElement_Text::DeleteChar(UIElement_Text*)</code>
    /// </summary>
    public void DeleteChar() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x00469C20)(ref this);

    /// <summary>
    /// Deletes the currently selected range of text from the UIElement_Text instance, removing all characters between the selection start and end positions and clearing the internal selection state.
    /// 
    /// <code>Offset: 0x00469C40
    /// void __thiscall UIElement_Text::DeleteSelection(UIElement_Text*)</code>
    /// </summary>
    public void DeleteSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x00469C40)(ref this);

    /// <summary>Adds text to the element's glyph list, handling selection state, cursor placement, and updating layout based on provided flags.
    /// <code>Offset: 0x00469CC0
    /// LONG __thiscall UIElement_Text::AddText_Internal(UIRegion*,int,char)</code>
    /// </summary>
    /// <param name="a2">Context identifier used for determining insertion behavior and reference counting.</param>
    /// <param name="a3">Flags controlling whether the operation deletes current selection, inserts at cursor, or appends text.</param>
    /// <returns>Non‑zero value indicates successful addition; zero signals that the element has been released and a callback may be invoked.</returns>
    public int AddText_Internal(int a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int, sbyte, int>)0x00469CC0)(ref this, a2, a3);

    /// <summary>Copies the current text selection to the clipboard and removes it from the control when the element is editable.
    /// <code>Offset: 0x00469DF0
    /// void __thiscall UIElement_Text::Cut(UIElement_Text*)</code>
    /// </summary>
    public void Cut() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x00469DF0)(ref this);

    /// <summary>Inserts a typed character into the UI text element, updating its glyph list and scrolling as necessary. Handles printable characters, newlines (under specific conditions), and ignores certain control codes before broadcasting an input event.
    /// <code>Offset: 0x00469E20
    /// void __thiscall UIElement_Text::CharacterHandler(UIElement_Text*,wchar_t)</code>
    /// </summary>
    /// <param name="charToHandle">The Unicode code point of the character to insert.</param>
    public void CharacterHandler(System.Char charToHandle) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, System.Char, void>)0x00469E20)(ref this, charToHandle);

    /// <summary>Appends referenced text into this UIElement_Text instance, incrementing the resource's reference counter and delegating insertion to AddText_Internal with formatting flag 3.
    /// <code>Offset: 0x00469F70
    /// LONG __thiscall UIElement_Text::AppendText(UIRegion*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer identifying the text to append; its associated reference count is increased before the operation.</param>
    /// <returns>Result code returned by AddText_Internal indicating success or failure.</returns>
    public int AppendText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, int>)0x00469F70)(ref this, a2);

    /// <summary>Appends the string referenced by a StringInfo instance to the text element, updating glyph data and managing reference counts for shared resources.
    /// <code>Offset: 0x00469FA0
    /// void __thiscall UIElement_Text::AppendStringInfo(UIElement_Text*,const StringInfo*)</code>
    /// </summary>
    /// <param name="info">The StringInfo containing the string to append.</param>
    public void AppendStringInfo(ACBindings.Internal.StringInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.StringInfo*, void>)0x00469FA0)(ref this, info);

    /// <summary>Adds text to the UI element using a specified font and color, updating internal font settings before invoking AddText_Internal.
    /// <code>Offset: 0x0046A000
    /// LONG __thiscall UIElement_Text::AppendTextWithFont(UIElement_Text*,int*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer identifying the text buffer; the reference counter located 16 bytes before this integer is incremented.</param>
    /// <param name="fontDIDNum">Font identifier applied to the current font object.</param>
    /// <param name="fontColorNum">Color identifier used for both regular and tag fonts.</param>
    /// <returns>Result code from UIElement_Text::AddText_Internal, indicating success or failure of the append operation.</returns>
    public int AppendTextWithFont(int* a2, uint fontDIDNum, uint fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, uint, uint, int>)0x0046A000)(ref this, a2, fontDIDNum, fontColorNum);

    /// <summary>
    /// Appends text from a StringInfo instance to this UI element using the supplied font ID and color indices.
    /// The function updates the current font and colors, increments the string's reference count, inserts the text internally, and releases any temporary resources. 
    /// 
    /// <code>Offset: 0x0046A070
    /// void __thiscall UIElement_Text::AppendStringInfoWithFont(UIElement_Text*,const StringInfo*,int,int)</code>
    /// </summary>
    /// <param name="info">Pointer to the StringInfo containing the text token.</param>
    /// <param name="fontDIDNum">Identifier for the font to use.</param>
    /// <param name="fontColorNum">Identifier for the color to apply to the text.</param>
    public void AppendStringInfoWithFont(ACBindings.Internal.StringInfo* info, int fontDIDNum, int fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.StringInfo*, int, int, void>)0x0046A070)(ref this, info, fontDIDNum, fontColorNum);

    /// <summary>Processes completed string downloads in the object's queue, updating font properties and appending the retrieved text to the element. Broadcasts a message when any download is handled.
    /// <code>Offset: 0x0046A100
    /// void __thiscall UIElement_Text::CheckStringDownloads(UIElement_Text*)</code>
    /// </summary>
    public void CheckStringDownloads() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x0046A100)(ref this);

    /// <summary>Processes queued string downloads, updates the caret blink timer for focused text elements, toggles visibility state, and marks the cursor region dirty to trigger a visual refresh when necessary.
    /// <code>Offset: 0x0046A250
    /// void __thiscall UIElement_Text::Global_Loop(UIElement_Text*)</code>
    /// </summary>
    public void Global_Loop() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x0046A250)(ref this);

    /// <summary>Replaces the text displayed by this UI element with the contents of the supplied StringInfo structure.
    /// <code>Offset: 0x0046A350
    /// void __thiscall UIElement_Text::SetStringInfo(UIElement_Text*,const StringInfo*)</code>
    /// </summary>
    /// <param name="info">String information to display; any existing content is cleared before appending the new data.</param>
    public void SetStringInfo(ACBindings.Internal.StringInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.StringInfo*, void>)0x0046A350)(ref this, info);

    /// <summary>Replaces the current text content of the UI element with a new string defined by <paramref name="info"/> rendered using the font identified by <paramref name="fontDIDNum"/> and colored according to <paramref name="fontColorNum"/>.
    /// <code>Offset: 0x0046A370
    /// void __thiscall UIElement_Text::SetStringInfoWithFont(UIElement_Text*,const StringInfo*,int,int)</code>
    /// </summary>
    /// <param name="info">The StringInfo structure containing the text to display.</param>
    /// <param name="fontDIDNum">Identifier of the font to use when rendering the string.</param>
    /// <param name="fontColorNum">Index or identifier for the font color to apply.</param>
    public void SetStringInfoWithFont(ACBindings.Internal.StringInfo* info, int fontDIDNum, int fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.StringInfo*, int, int, void>)0x0046A370)(ref this, info, fontDIDNum, fontColorNum);

    /// <summary>Pastes clipboard contents into the element at the current cursor position, replacing any selected range and normalizing line endings before insertion. If the resulting text extends beyond the visible area, scrolls to bring the caret into view.
    /// <code>Offset: 0x0046A3A0
    /// void __thiscall UIElement_Text::Paste(UIElement_Text*)</code>
    /// </summary>
    public void Paste() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x0046A3A0)(ref this);

    /// <summary>Processes user input events for a text UI element, handling cursor movement, selection, copy/cut/paste, deletion and other editing commands.
    /// <code>Offset: 0x0046A4F0
    /// bool __thiscall UIElement_Text::OnAction(UIElement_Text*,const InputEvent*)</code>
    /// </summary>
    /// <param name="i_evt">The input event to process.</param>
    /// <returns>True if the event was handled; otherwise, false.</returns>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.InputEvent*, byte>)0x0046A4F0)(ref this, i_evt);

    /// <summary>Responds to a global message with identifier 3 by invoking the element's global loop; other messages are ignored.
    /// <code>Offset: 0x0046A730
    /// void __thiscall UIElement_Text::ListenToGlobalMessage(UIElement_Text*,unsigned int,int)</code>
    /// </summary>
    /// <param name="messageID">Identifier of the global message received.</param>
    /// <param name="data">Additional data associated with the message, currently unused.</param>
    public void ListenToGlobalMessage(uint messageID, int data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint, int, void>)0x0046A730)(ref this, messageID, data);

    /// <summary>Replaces the current text displayed by the UI element with the content supplied as a wide‑character string.
    /// <code>Offset: 0x0046A740
    /// void __thiscall UIElement_Text::SetText(UIElement_Text*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a null‑terminated wide‑character string containing the new text.</param>
    public void SetText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, void>)0x0046A740)(ref this, a2);

    /// <summary>Replaces the current text of this UI element with a new string rendered in a specified font and color, clearing all previous content.
    /// <code>Offset: 0x0046A790
    /// void __thiscall UIElement_Text::SetTextWithFont(UIElement_Text*,int*,int,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a null‑terminated wide‑character string that will become the element’s displayed text.</param>
    /// <param name="fontDIDNum">Identifier of the font object used to render the supplied string.</param>
    /// <param name="fontColorNum">Index specifying the color to apply to the rendered text.</param>
    public void SetTextWithFont(int* a2, int fontDIDNum, int fontColorNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, int*, int, int, void>)0x0046A790)(ref this, a2, fontDIDNum, fontColorNum);

    /// <summary>Restores default font settings for this text element, resetting the font identifier, primary and tag colors to their base values. If the global flag is enabled, re-applies any pre‑parsed text content.
    /// <code>Offset: 0x0046A7F0
    /// void __thiscall UIElement_Text::DoFontReset(UIElement_Text*)</code>
    /// </summary>
    public void DoFontReset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, void>)0x0046A7F0)(ref this);

    /// <summary>Matches this text element with another UIElement, updating its displayed content based on the target's data and adjusting associated listener reference counts.
    /// <code>Offset: 0x0046A870
    /// void __thiscall UIElement_Text::MatchElement(UIElement_Text*,const UIElement*)</code>
    /// </summary>
    /// <param name="elem">The UIElement to match against.</param>
    public void MatchElement(ACBindings.Internal.UIElement* elem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.UIElement*, void>)0x0046A870)(ref this, elem);

    /// <summary>
    /// Handles setting of a UI text element’s attributes based on the supplied property.
    /// Updates justification, editability, string content, character limits, visual styling (outline, margins), and behavior flags such as selectable or focus‑loss actions, resetting font state when required.
    /// 
    /// <code>Offset: 0x0046A8D0
    /// void __thiscall UIElement_Text::OnSetAttribute(UIElement_Text*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="attribute">The BaseProperty containing the attribute to apply.</param>
    public void OnSetAttribute(ACBindings.Internal.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, ACBindings.Internal.BaseProperty*, void>)0x0046A8D0)(ref this, attribute);

    /// <summary>Returns the numeric ID identifying a text UI element.
    /// <code>Offset: 0x006B1960
    /// unsigned int __thiscall UIElement_Text::GetUIElementType(TextureVelocityPartHook*)</code>
    /// </summary>
    /// <returns>The type identifier (12) used by the UI system to denote text elements.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_Text, uint>)0x006B1960)(ref this);
}

