namespace ACBindings.Internal;


/// <summary>
/// Manages the spellbook user interface, presenting a player’s known spells,
/// handling filtering by school and level, selection, deletion, and all related
/// interaction callbacks.
/// </summary>
public unsafe struct gmSpellbookUI
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmSpellbookUI_vtbl
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
    public ACBindings.Internal.UIElement_ItemList* m_spellList;
    public uint m_selectedSpellID;
    public ACBindings.Internal.UIElement* m_btnSchool_Creature;
    public ACBindings.Internal.UIElement* m_btnSchool_Item;
    public ACBindings.Internal.UIElement* m_btnSchool_Life;
    public ACBindings.Internal.UIElement* m_btnSchool_War;
    public ACBindings.Internal.UIElement* m_btnSchool_Void;
    public ACBindings.Internal.UIElement* m_btnLevel_1;
    public ACBindings.Internal.UIElement* m_btnLevel_2;
    public ACBindings.Internal.UIElement* m_btnLevel_3;
    public ACBindings.Internal.UIElement* m_btnLevel_4;
    public ACBindings.Internal.UIElement* m_btnLevel_5;
    public ACBindings.Internal.UIElement* m_btnLevel_6;
    public ACBindings.Internal.UIElement* m_btnLevel_7;
    public ACBindings.Internal.UIElement* m_btnLevel_8;

    // Methods

    /// <summary>Performs a type-safe cast from gmSpellbookUI to a UIElement based on the supplied type identifier, returning a pointer to the requested base or derived element when the identifier matches known values.
    /// <code>Offset: 0x0048B100
    /// UIElement* __thiscall gmSpellbookUI::DynamicCast(gmSpellbookUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Numeric identifier of the desired UIElement type (e.g., 268435502 for the base element, 3 for the derived gmSpellbookUI).</param>
    /// <returns>Pointer to the matching UIElement if the cast succeeds; otherwise nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellbookUI, uint, ACBindings.Internal.UIElement*>)0x0048B100)(ref this, i_eType);

    /// <summary>Returns the unique identifier for this spellbook UI element used by the framework.
    /// <code>Offset: 0x0048B120
    /// unsigned int __thiscall gmSpellbookUI::GetUIElementType(gmSpellbookUI*)</code>
    /// </summary>
    /// <returns>An unsigned integer constant representing the UI element type (268435502).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellbookUI, uint>)0x0048B120)(ref this);

    /// <summary>Creates a new spellbook UI element using the supplied layout and element descriptions.
    /// <code>Offset: 0x0048B130
    /// UIElement* __cdecl gmSpellbookUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout configuration that defines display size and structure for the UI element.</param>
    /// <param name="full_desc">Complete description of the UI element, including visual and state information.</param>
    /// <returns>A pointer to the newly constructed UIElement representing the spellbook UI, or null if memory allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0048B130)(layout, full_desc);

    /// <summary>Determines whether a given spell is hidden from the spellbook UI based on current filter settings.
    /// <code>Offset: 0x0048B190
    /// bool __thiscall gmSpellbookUI::IsFilteredOut(gmSpellbookUI*,CSpellBase*)</code>
    /// </summary>
    /// <param name="this">Reference to the gmSpellbookUI instance.</param>
    /// <param name="spellBase">The spell whose visibility is being evaluated.</param>
    /// <returns>True if the spell does not satisfy any active school or level filters and should be excluded; otherwise, false.</returns>
    public byte IsFilteredOut(ACBindings.Internal.CSpellBase* spellBase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellbookUI, ACBindings.Internal.CSpellBase*, byte>)0x0048B190)(ref this, spellBase);

    /// <summary>Updates the enabled/disabled status of spell school and level filter buttons to reflect the current spellbook filter settings stored in the player system.
    /// <code>Offset: 0x0048B270
    /// void __thiscall gmSpellbookUI::ResetFilterButtons(gmSpellbookUI*)</code>
    /// </summary>
    public void ResetFilterButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellbookUI, void>)0x0048B270)(ref this);

    /// <summary>Initializes spellbook UI elements, links internal pointers to child components such as the spell list and various school/level buttons, clears the selected spell ID, and registers notice handlers for global events.
    /// <code>Offset: 0x0048B590
    /// void __thiscall gmSpellbookUI::PostInit(gmSpellbookUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellbookUI, void>)0x0048B590)(ref this);

    /// <summary>Registers the gmSpellbookUI element type within the UI framework, enabling it to be instantiated from its unique identifier.
    /// <code>Offset: 0x0048B700
    /// void __cdecl gmSpellbookUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0048B700)();

    /// <summary>Finds the position at which a spell should be inserted into the spell list to preserve ascending order by display_order.
    /// <code>Offset: 0x0048B720
    /// unsigned int __thiscall gmSpellbookUI::GetSortedInsertionPlace(gmSpellbookUI*,CSpellBase*)</code>
    /// </summary>
    /// <param name="spellBase">The spell whose insertion point is being determined.</param>
    /// <returns>The index within the current spell list where the new spell should be inserted; if it belongs after all existing spells, returns the list’s length (i.e., the end position).</returns>
    public uint GetSortedInsertionPlace(ACBindings.Internal.CSpellBase* spellBase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellbookUI, ACBindings.Internal.CSpellBase*, uint>)0x0048B720)(ref this, spellBase);

    /// <summary>Sets the currently selected spell, updating list item selection states and scrolling the list to make it visible.
    /// <code>Offset: 0x0048B820
    /// void __thiscall gmSpellbookUI::SetSelected(gmSpellbookUI*,unsigned int)</code>
    /// </summary>
    /// <param name="selectedSpellID">Identifier of the spell to select; a value of zero clears any current selection.</param>
    public void SetSelected(uint selectedSpellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellbookUI, uint, void>)0x0048B820)(ref this, selectedSpellID);

    /// <summary>Updates the spellbook filter mask based on the clicked filter button, toggling the corresponding filter flag and notifying the system when changes occur.
    /// <code>Offset: 0x0048B8C0
    /// void __thiscall gmSpellbookUI::UpdateFilter(gmSpellbookUI*,unsigned int)</code>
    /// </summary>
    /// <param name="buttonID">The identifier of the UI element that represents a filter button whose state is being changed.</param>
    public void UpdateFilter(uint buttonID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellbookUI, uint, void>)0x0048B8C0)(ref this, buttonID);

    /// <summary>Adds a spell shortcut to the spellbook UI list if the spell exists and is not filtered, inserting it at its correct sorted position.
    /// <code>Offset: 0x0048BA80
    /// void __thiscall gmSpellbookUI::AddSpell(gmSpellbookUI*,unsigned int)</code>
    /// </summary>
    /// <param name="spellID">Identifier of the spell to add.</param>
    public void AddSpell(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellbookUI, uint, void>)0x0048BA80)(ref this, spellID);

    /// <summary>Processes a spell‑added notice by adding the spell to the UI list, selecting it if it passes filtering, and triggering any associated input callbacks.
    /// <code>Offset: 0x0048BBB0
    /// void __thiscall gmSpellbookUI::RecvNotice_SpellAdded(gmSpellbookUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eSpellID">Identifier of the newly added spell.</param>
    public void RecvNotice_SpellAdded(uint i_eSpellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellbookUI, uint, void>)0x0048BBB0)(ref this, i_eSpellID);

    /// <summary>Refreshes the spell list displayed in the UI to match the active player's spell book, repopulating items and resetting filter buttons.
    /// <code>Offset: 0x0048BDD0
    /// void __thiscall gmSpellbookUI::UpdateFromPlayerDesc(gmSpellbookUI*)</code>
    /// </summary>
    public void UpdateFromPlayerDesc() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellbookUI, void>)0x0048BDD0)(ref this);

    /// <summary>Handles a notification that a spell has been removed from the player's collection, updating the spellbook UI to reflect the current state.
    /// <code>Offset: 0x0048BEE0
    /// void __thiscall gmSpellbookUI::RecvNotice_SpellRemoved(gmSpellbookUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eSpellID">The identifier of the spell that was removed.</param>
    public void RecvNotice_SpellRemoved(uint i_eSpellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellbookUI, uint, void>)0x0048BEE0)(ref this, i_eSpellID);

    /// <summary>Removes a spell from the character’s spellbook using information supplied by the delete‑dialog callback.
    /// <code>Offset: 0x0048BEF0
    /// void __cdecl gmSpellbookUI::DeleteSpellDialogCallback(const PropertyCollection*)</code>
    /// </summary>
    /// <param name="i_rcResults">Collection of properties returned from the dialog, containing identifiers for the spell to remove.</param>
    public static void DeleteSpellDialogCallback(ACBindings.Internal.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void>)0x0048BEF0)(i_rcResults);

    /// <summary>Updates the spellbook UI in response to a player description notification by delegating to another gmSpellbookUI instance.
    /// <code>Offset: 0x0048C020
    /// void __thiscall gmSpellbookUI::RecvNotice_PlayerDescReceived(gmSpellbookUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellbookUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x0048C020)(ref this, i_playerDesc, i_playerModule);

    /// <summary>Removes the currently selected spell from the player's spellbook after user confirmation. If no spell is selected or the magic system cannot be accessed, the operation fails.
    /// <code>Offset: 0x0048C030
    /// bool __thiscall gmSpellbookUI::DeleteSpell(gmSpellbookUI*)</code>
    /// </summary>
    /// <returns>True if a deletion dialog was presented and the removal process started; otherwise false.</returns>
    public byte DeleteSpell() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellbookUI, byte>)0x0048C030)(ref this);

    /// <summary>
    /// Handles UI element messages in the spellbook interface, processing filter changes, spell selections, and shortcut assignments before delegating unhandled events to the base implementation.
    /// 
    /// <code>Offset: 0x0048C2B0
    /// UIElementMessageListenResult __thiscall gmSpellbookUI::ListenToElementMessage(gmSpellbookUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmSpellbookUI instance receiving the message.</param>
    /// <param name="i_rMsg">Information about the incoming UI element event.</param>
    /// <returns>Result indicating whether the spellbook UI handled the message or passed it on to its base class.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellbookUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0048C2B0)(ref this, i_rMsg);
}

