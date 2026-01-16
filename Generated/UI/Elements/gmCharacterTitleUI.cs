namespace ACBindings.Internal;


/// <summary>
/// Represents the character title selection UI component that displays the current title and allows changing it via a listbox, maintaining an internal CharacterTitleTable.
/// </summary>
/// <remarks>
/// Extends <c>UIElement_Field</c>, manages display text, action button, and title list box, and reacts to global notice events for adding or setting titles.
/// </remarks>
public unsafe struct gmCharacterTitleUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmCharacterTitleUI_vtbl
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

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_Text* m_pDisplayTitleText;
    public ACBindings.Internal.UIElement_Button* m_pDisplayButton;
    public ACBindings.Internal.UIElement_ListBox* m_pTitleListBox;
    public ACBindings.Internal.CharacterTitleTable m_characterTitleTable;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Updates the display button’s enabled state according to whether the currently selected title in the list box matches the character’s displayed title.
    /// <code>Offset: 0x0049A7E0
    /// void __thiscall gmCharacterTitleUI::UpdateButtons(gmCharacterTitleUI*)</code>
    /// </summary>
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, void>)0x0049A7E0)(ref this);

    /// <summary>Initializes the character title UI by locating its child elements and registering notice handlers for relevant events.
    /// <code>Offset: 0x0049A8F0
    /// void __thiscall gmCharacterTitleUI::PostInit(gmCharacterTitleUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, void>)0x0049A8F0)(ref this);

    /// <summary>Processes UI element messages for character title selection and button state updates, setting the chosen title or refreshing buttons before delegating to the parent handler.
    /// <code>Offset: 0x0049A9B0
    /// UIElementMessageListenResult __thiscall gmCharacterTitleUI::ListenToElementMessage(gmCharacterTitleUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information containing element ID, message type, and additional data.</param>
    /// <returns>Result from the base class message listener indicating how the message was handled.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0049A9B0)(ref this, i_rMsg);

    /// <summary>Finds the correct position in the titles list for inserting a new title, preserving alphabetical order.
    /// <code>Offset: 0x0049AA40
    /// UIElement* __thiscall gmCharacterTitleUI::FindSortedInsertPosition(_DWORD*,const wchar_t**)</code>
    /// </summary>
    /// <param name="a2">Pointer to the wide‑character string of the title to insert; passed by reference and may be ref‑counted.</param>
    /// <returns>Pointer to the first list item whose text is alphabetically after the specified title; returns null if the new title should be appended at the end of the list.</returns>
    public ACBindings.Internal.UIElement* FindSortedInsertPosition(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, System.IntPtr, ACBindings.Internal.UIElement*>)0x0049AA40)(ref this, a2);

    /// <summary>Adds a character title to the UI's list box when the provided title ID exists, inserting it in sorted order and updating its display text.
    /// <code>Offset: 0x0049AB20
    /// bool __thiscall gmCharacterTitleUI::AddTitleToList(gmCharacterTitleUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_title">Identifier of the title to add.</param>
    /// <returns>True if the title was successfully added; otherwise, false.</returns>
    public byte AddTitleToList(uint i_title) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, uint, byte>)0x0049AB20)(ref this, i_title);

    /// <summary>Adds a character title identified by <c>i_title</c> to the UI’s list if it has not already been registered.
    /// <code>Offset: 0x0049AC00
    /// void __thiscall gmCharacterTitleUI::RecvNotice_AddCharacterTitle(gmCharacterTitleUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_title">The identifier of the character title to add.</param>
    public void RecvNotice_AddCharacterTitle(uint i_title) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, uint, void>)0x0049AC00)(ref this, i_title);

    /// <summary>Performs a dynamic cast on the gmCharacterTitleUI instance, returning a pointer to the requested component type if supported.
    /// <code>Offset: 0x0049AD20
    /// UIElement* __thiscall gmCharacterTitleUI::DynamicCast(gmCharacterTitleUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Specifies the desired type code; supports casting to the UIElement base class or to the gmCharacterTitleUI itself.</param>
    /// <returns>A pointer to the matching component as UIElement*, or nullptr if the requested type is not available.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, uint, ACBindings.Internal.UIElement*>)0x0049AD20)(ref this, i_eType);

    /// <summary>Returns the unique identifier that distinguishes this UI element type from others in the system.
    /// <code>Offset: 0x0049AD40
    /// unsigned int __thiscall gmCharacterTitleUI::GetUIElementType(gmCharacterTitleUI*)</code>
    /// </summary>
    /// <returns>An unsigned integer representing the UI element type (value 268435526).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, uint>)0x0049AD40)(ref this);

    /// <summary>Destroys a gmCharacterTitleUI instance, releasing title resources and unregistering associated notice handlers.
    /// <code>Offset: 0x0049AD50
    /// void __thiscall gmCharacterTitleUI::~gmCharacterTitleUI(gmCharacterTitleUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, void>)0x0049AD50)(ref this);

    /// <summary>Registers the character title UI element class, enabling it to be instantiated by the UI framework.
    /// <code>Offset: 0x0049AE10
    /// void __cdecl gmCharacterTitleUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0049AE10)();

    /// <summary>Refreshes the character title UI by updating the displayed title text, repopulating the list of available titles from the character title table, and adjusting button states accordingly.
    /// <code>Offset: 0x0049AE30
    /// bool __thiscall gmCharacterTitleUI::Refresh(gmCharacterTitleUI*)</code>
    /// </summary>
    /// <returns>True after successful refresh; the method currently always returns true.</returns>
    public byte Refresh() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, byte>)0x0049AE30)(ref this);

    /// <summary>Updates the internal character title table with new data and refreshes the title UI display accordingly.
    /// <code>Offset: 0x0049AFA0
    /// void __thiscall gmCharacterTitleUI::RecvNotice_UpdateCharacterTitleTable(gmCharacterTitleUI*,const CharacterTitleTable*)</code>
    /// </summary>
    /// <param name="i_titleTable">Pointer to the CharacterTitleTable containing updated titles.</param>
    public void RecvNotice_UpdateCharacterTitleTable(ACBindings.Internal.CharacterTitleTable* i_titleTable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, ACBindings.Internal.CharacterTitleTable*, void>)0x0049AFA0)(ref this, i_titleTable);

    /// <summary>Updates the displayed character title using the specified title identifier, ensuring it is registered and refreshing the UI accordingly.
    /// <code>Offset: 0x0049AFC0
    /// void __thiscall gmCharacterTitleUI::RecvNotice_SetDisplayCharacterTitle(gmCharacterTitleUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_title">Identifier of the title to be shown in the interface.</param>
    public void RecvNotice_SetDisplayCharacterTitle(uint i_title) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterTitleUI, uint, void>)0x0049AFC0)(ref this, i_title);
}

