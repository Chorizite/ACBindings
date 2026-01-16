namespace ACBindings.Internal;


/// <summary>
/// Manages the spellcasting user interface, handling spell selection, casting actions, and endowment item display.
/// </summary>
public unsafe struct gmSpellcastingUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmSpellcastingUI_vtbl
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
    public ACBindings.Internal.UIElement_Panel* m_spellcastPanel;
    public ACBindings.Internal.UIElement_Text* m_spellName;
    public ACBindings.Internal.UIElement_Button* m_spellcastButton;
    public ACBindings.Internal.UIElement* m_endowmentIcon;
    public ACBindings.Internal.UIElement* m_endowmentIcon_Overlay;
    public ACBindings.Internal.UIElement* m_endowmentIcon_Underlay;
    public ACBindings.Internal.UIElement* m_endowmentIcon_Selected;
    public ACBindings.Internal.UIElement* m_spellcastBackground;
    public byte m_endowmentPresent;
    public uint m_endowmentItemID;
    public uint m_endowmentSpellID;
    public fixed byte m_subMenus_Raw[224];
    public ACBindings.Internal.SpellCastSubMenu* m_subMenus => (ACBindings.Internal.SpellCastSubMenu*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_subMenus_Raw[0]);

    // Generated Constructor
    public gmSpellcastingUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Maps the current spellcasting UI tab ID to its successor in the tab sequence.
    /// <code>Offset: 0x004C6400
    /// unsigned int __thiscall gmSpellcastingUI::GetNextTabID(gmSpellcastingUI*,unsigned int)</code>
    /// </summary>
    /// <param name="id">The identifier of the currently selected tab.</param>
    /// <returns>The identifier of the next tab. If the supplied id is not one of the recognized values or exceeds 0x100005C1, returns 268435619 (no subsequent tab).</returns>
    public uint GetNextTabID(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint, uint>)0x004C6400)(ref this, id);

    /// <summary>Retrieves the preceding spellcasting tab identifier for a given current tab ID according to a predefined ordering.
    /// <code>Offset: 0x004C6480
    /// unsigned int __thiscall gmSpellcastingUI::GetPrevTabID(gmSpellcastingUI*,unsigned int)</code>
    /// </summary>
    /// <param name="id">The identifier of the current spellcasting tab.</param>
    /// <returns>The identifier of the previous tab. For known IDs it maps to the next lower tab in the sequence; if the input is greater than 0x100005C2, it returns 268435619. If the input equals 268436930 (0x100005C2), it returns 268435625.</returns>
    public uint GetPrevTabID(uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint, uint>)0x004C6480)(ref this, id);

    /// <summary>Retrieves the index of the currently active spellcasting submenu based on the panel’s open page token.
    /// <code>Offset: 0x004C6500
    /// int __thiscall gmSpellcastingUI::GetOpenSubMenuIndex(gmSpellcastingUI*)</code>
    /// </summary>
    /// <returns>The submenu index (1‑7) when a submenu is open; otherwise 0.</returns>
    public int GetOpenSubMenuIndex() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, int>)0x004C6500)(ref this);

    /// <summary>Cleans up the spellcasting UI by unregistering global event handlers, removing submenu item list drag callbacks, and destroying base‑class resources.
    /// <code>Offset: 0x004C65E0
    /// void __thiscall gmSpellcastingUI::~gmSpellcastingUI(gmSpellcastingUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C65E0)(ref this);

    /// <summary>Attempts a run‑time cast of a gmSpellcastingUI instance to a specified UI element type, returning the appropriate UIElement pointer or null if unsupported.
    /// <code>Offset: 0x004C6650
    /// UIElement* __thiscall gmSpellcastingUI::DynamicCast(gmSpellcastingUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier for the target UI element type; 268435477 requests the base UIElement class, 3 requests a cast to the gmSpellcastingUI itself, and other values yield no match.</param>
    /// <returns>Pointer to the requested UIElement when the cast succeeds; otherwise nullptr.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint, ACBindings.Internal.UIElement*>)0x004C6650)(ref this, i_eType);

    /// <summary>Returns the UI element type identifier for this spellcasting interface.
    /// <code>Offset: 0x004C6670
    /// unsigned int __thiscall gmSpellcastingUI::GetUIElementType(gmSpellcastingUI*)</code>
    /// </summary>
    /// <returns>The unique integer identifying the UI element's type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint>)0x004C6670)(ref this);

    /// <summary>Creates a spellcasting UI component using the provided layout and element descriptions, initializing panels, text fields, buttons, icons, background, and submenu structures.
    /// <code>Offset: 0x004C6830
    /// void __thiscall gmSpellcastingUI::gmSpellcastingUI(gmSpellcastingUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Specifies the visual dimensions and overall layout configuration for the UI.</param>
    /// <param name="full_desc">Provides detailed information about individual UI elements, including states, positions, and child components.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004C6830)(ref this, layout, full_desc);

    /// <summary>Initializes the spellcasting UI by locating and configuring its child elements such as panel, name text, background, button, endowment icon layers, sub‑menus, and registers necessary global notice handlers.
    /// <code>Offset: 0x004C68F0
    /// void __thiscall gmSpellcastingUI::PostInit(gmSpellcastingUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C68F0)(ref this);

    /// <summary>Registers the spellcasting UI element class with the UI framework, enabling its creation from layout descriptors.
    /// <code>Offset: 0x004C6C20
    /// void __cdecl gmSpellcastingUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004C6C20)();

    /// <summary>Attempts to cast the currently selected spell or use the associated item from the active submenu. If no spell is selected, displays a notice prompting the player to choose one.
    /// <code>Offset: 0x004C6C40
    /// void __thiscall gmSpellcastingUI::Cast(gmSpellcastingUI*)</code>
    /// </summary>
    public void Cast() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C6C40)(ref this);

    /// <summary>Updates the endowment icon in the spellcasting UI to reflect the currently equipped endowment item or clears it when no endowment is present. Sets the icon image, overlay, tooltip, and selection state according to the underlying object’s properties.
    /// <code>Offset: 0x004C6D10
    /// void __thiscall gmSpellcastingUI::UpdateEndowmentIcon(gmSpellcastingUI*)</code>
    /// </summary>
    public void UpdateEndowmentIcon() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C6D10)(ref this);

    /// <summary>Responds to a cast‑notice by initiating the casting of the currently selected spell.
    /// <code>Offset: 0x004C6FF0
    /// void __thiscall gmSpellcastingUI::RecvNotice_CastCurrentSpell(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_CastCurrentSpell() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C6FF0)(ref this);

    /// <summary>Refreshes all spellcast submenu panels using data from the player's module upon receiving a player description notice.
    /// <code>Offset: 0x004C7590
    /// void __thiscall gmSpellcastingUI::RecvNotice_PlayerDescReceived(gmSpellcastingUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player quality information received in the notice (not used directly by this method).</param>
    /// <param name="i_playerModule">Current state of the player module, providing data for updating each submenu.</param>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004C7590)(ref this, i_playerDesc, i_playerModule);

    /// <summary>Removes a spell shortcut identified by its ID from the currently active spellcasting submenu.
    /// <code>Offset: 0x004C75C0
    /// void __thiscall gmSpellcastingUI::RecvNotice_RemoveSpellShortcut(gmSpellcastingUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_spellID">Identifier of the spell to be removed.</param>
    public void RecvNotice_RemoveSpellShortcut(uint i_spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint, void>)0x004C75C0)(ref this, i_spellID);

    /// <summary>Synchronizes all spell‑casting submenus after a spell is removed, ensuring that each submenu reflects the current state of available spells.
    /// <code>Offset: 0x004C75F0
    /// void __thiscall gmSpellcastingUI::RecvNotice_SpellRemoved(gmSpellcastingUI*,unsigned int)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmSpellcastingUI instance handling the UI update.</param>
    /// <param name="i_eSpellID">Identifier of the spell that was removed from the player's repertoire.</param>
    public void RecvNotice_SpellRemoved(uint i_eSpellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint, void>)0x004C75F0)(ref this, i_eSpellID);

    /// <summary>Updates the tooltip and state of the spell cast button based on the currently selected spell, endowment item, and target selection. Clears existing tooltip data, determines appropriate action text (“CAST”, “USE”) or prompts for target selection, and sets the UI element accordingly.
    /// <code>Offset: 0x004C7620
    /// void __thiscall gmSpellcastingUI::UpdateCastButtonTooltip(gmSpellcastingUI*)</code>
    /// </summary>
    public void UpdateCastButtonTooltip() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C7620)(ref this);

    /// <summary>Updates the spellcast button tooltip to match the currently selected spell whenever a selection change notice is received.
    /// <code>Offset: 0x004C7E60
    /// void __thiscall gmSpellcastingUI::RecvNotice_SelectionChanged(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C7E60)(ref this);

    /// <summary>Adjusts the spellcasting UI based on the current combat mode, enabling magic‑specific features when in magic combat and disabling them otherwise.
    /// <code>Offset: 0x004C7E70
    /// void __thiscall gmSpellcastingUI::RecvNotice_SetCombatMode(gmSpellcastingUI*,COMBAT_MODE)</code>
    /// </summary>
    /// <param name="i_eCombatMode">The combat mode to apply.</param>
    public void RecvNotice_SetCombatMode(ACBindings.Internal.COMBAT_MODE i_eCombatMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, ACBindings.Internal.COMBAT_MODE, void>)0x004C7E70)(ref this, i_eCombatMode);

    /// <summary>Responds to a server notice that an item has moved, updating the spellcasting UI when the move involves the player’s current holder.
    /// <code>Offset: 0x004C7EC0
    /// void __thiscall gmSpellcastingUI::RecvNotice_ServerSaysMoveItem(gmSpellcastingUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_itemID">Identifier of the item being moved.</param>
    /// <param name="i_oldContainer">Original container ID before the move.</param>
    /// <param name="i_oldWielder">Entity that originally held the item.</param>
    /// <param name="i_oldLocation">Previous location index within the old container.</param>
    /// <param name="i_newContainer">Destination container ID after the move.</param>
    /// <param name="i_place">Target position within the new container.</param>
    /// <param name="i_newWielder">Entity that now holds the item.</param>
    /// <param name="i_newLocation">New location index within the destination container.</param>
    public void RecvNotice_ServerSaysMoveItem(uint i_itemID, uint i_oldContainer, uint i_oldWielder, uint i_oldLocation, uint i_newContainer, int i_place, uint i_newWielder, uint i_newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004C7EC0)(ref this, i_itemID, i_oldContainer, i_oldWielder, i_oldLocation, i_newContainer, i_place, i_newWielder, i_newLocation);

    /// <summary>Adds a spell to the favorite shortcuts list at the specified position, optionally replacing an existing entry, then refreshes the UI elements such as the endowment icon and cast‑button tooltip.
    /// <code>Offset: 0x004C7F10
    /// void __thiscall gmSpellcastingUI::AddSpellShortcut(gmSpellcastingUI*,unsigned int,int,bool)</code>
    /// </summary>
    /// <param name="i_spellID">Identifier of the spell to add.</param>
    /// <param name="pos">Target index within the favorites submenu where the spell should appear.</param>
    /// <param name="allowReplace">If true, replaces an existing spell at that position; otherwise insertion fails when occupied.</param>
    public void AddSpellShortcut(uint i_spellID, int pos, byte allowReplace) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint, int, byte, void>)0x004C7F10)(ref this, i_spellID, pos, allowReplace);

    /// <summary>Handles the initiation of a drag on an item in a spell list, locating the related submenu, executing the item's action, removing the spell from that submenu, and updating the endowment icon and tooltip.
    /// <code>Offset: 0x004C7F50
    /// void __thiscall gmSpellcastingUI::RecvNotice_ItemListBeginDrag(gmSpellcastingUI*,const UIElement*,int)</code>
    /// </summary>
    /// <param name="i_itemList">The UI element representing the spell list from which the item is dragged.</param>
    /// <param name="i_slotNum">Index of the item within the list to be dragged.</param>
    public void RecvNotice_ItemListBeginDrag(ACBindings.Internal.UIElement* i_itemList, int i_slotNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, ACBindings.Internal.UIElement*, int, void>)0x004C7F50)(ref this, i_itemList, i_slotNum);

    /// <summary>Responds to a notice indicating the user wants to switch to the next spell tab, computing the new tab index, activating it in the panel, and refreshing endowment icons and cast button tooltips accordingly.
    /// <code>Offset: 0x004C7FD0
    /// void __thiscall gmSpellcastingUI::RecvNotice_NextSpellTab(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_NextSpellTab() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C7FD0)(ref this);

    /// <summary>Handles a notification to switch the spellcasting UI to the previous tab, updating the panel, endowment icon, and cast button tooltip.
    /// <code>Offset: 0x004C8010
    /// void __thiscall gmSpellcastingUI::RecvNotice_PrevSpellTab(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_PrevSpellTab() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C8010)(ref this);

    /// <summary>Advances to the next available spell in the currently open submenu when a notice is received, handling edge cases such as empty lists or endowment selection. Updates the UI by setting the selected spell and refreshing the endowment icon and cast button tooltip.
    /// <code>Offset: 0x004C8050
    /// void __thiscall gmSpellcastingUI::RecvNotice_NextSpellSelection(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_NextSpellSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C8050)(ref this);

    /// <summary>Updates the currently selected spell when the user navigates to the previous entry in the list, handling endowment mode and ensuring UI elements such as the endowment icon and cast button tooltip reflect the new selection.
    /// <code>Offset: 0x004C81C0
    /// void __thiscall gmSpellcastingUI::RecvNotice_PrevSpellSelection(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_PrevSpellSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C81C0)(ref this);

    /// <summary>Responds to the first spell tab being selected by opening the corresponding tab in the UI panel and updating the endowment icon and cast‑button tooltip.
    /// <code>Offset: 0x004C8330
    /// void __thiscall gmSpellcastingUI::RecvNotice_FirstSpellTab(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_FirstSpellTab() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C8330)(ref this);

    /// <summary>
    /// Responds to a notice indicating the last spell tab should be displayed by opening that tab in the spellcasting UI panel, then refreshing the endowment icon and cast button tooltip.
    /// 
    /// <code>Offset: 0x004C8360
    /// void __thiscall gmSpellcastingUI::RecvNotice_LastSpellTab(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_LastSpellTab() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C8360)(ref this);

    /// <summary>Processes the first spell selection notice by setting the endowment flag if a registered element exists, or selecting the first spell in the currently open submenu; updates the endowment icon and cast button tooltip accordingly.
    /// <code>Offset: 0x004C8390
    /// void __thiscall gmSpellcastingUI::RecvNotice_FirstSpellSelection(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_FirstSpellSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C8390)(ref this);

    /// <summary>Responds to a last‑spell‑selection notice by updating the UI. If the current submenu contains spells, selects the most recent one; otherwise marks the endowment as selected and refreshes related icons and tooltips.
    /// <code>Offset: 0x004C8410
    /// void __thiscall gmSpellcastingUI::RecvNotice_LastSpellSelection(gmSpellcastingUI*)</code>
    /// </summary>
    public void RecvNotice_LastSpellSelection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, void>)0x004C8410)(ref this);

    /// <summary>Selects the spell at the given quick‑slot index in the currently open submenu and initiates its cast, updating endowment icon and button tooltip accordingly.
    /// <code>Offset: 0x004C84A0
    /// void __thiscall gmSpellcastingUI::RecvNotice_CastQuickslotSpell(gmSpellcastingUI*,int)</code>
    /// </summary>
    /// <param name="i_slot">Index of the quick‑slot to be cast within the active submenu.</param>
    public void RecvNotice_CastQuickslotSpell(int i_slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, int, void>)0x004C84A0)(ref this, i_slot);

    /// <summary>Processes a drag‑drop release in the spellcasting UI, adding the dragged spell to shortcuts or favorites depending on where it was dropped.
    /// <code>Offset: 0x004C8520
    /// void __thiscall gmSpellcastingUI::HandleDropRelease(gmSpellcastingUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information describing the dragged element, drop target, and any relevant identifiers for the spell being moved.</param>
    /// <returns>No value is returned; the function performs UI updates as a side effect.</returns>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, ACBindings.Internal.UIElementMessageInfo*, void>)0x004C8520)(ref this, i_rMsg);

    /// <summary>Adds the specified spell ID to the currently open submenu as a favorite shortcut and refreshes related UI elements such as the endowment icon and cast button tooltip.
    /// <code>Offset: 0x004C8660
    /// void __thiscall gmSpellcastingUI::RecvNotice_AddSpellShortcut(gmSpellcastingUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_spellID">Identifier of the spell to add as a shortcut.</param>
    public void RecvNotice_AddSpellShortcut(uint i_spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, uint, void>)0x004C8660)(ref this, i_spellID);

    /// <summary>Handles UI element messages for the spellcasting interface, updating item selections, endowment status, and initiating spell casts based on user interaction.
    /// <code>Offset: 0x004C86A0
    /// UIElementMessageListenResult __thiscall gmSpellcastingUI::ListenToElementMessage(gmSpellcastingUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information containing the originating element ID, message type, parameters, and coordinates.</param>
    /// <returns>Result of processing the message, typically delegating to the base class after applying custom logic.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSpellcastingUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004C86A0)(ref this, i_rMsg);
}

