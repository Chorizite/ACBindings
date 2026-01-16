namespace ACBindings.Internal;


/// <summary>Manages the in‑game toolbar UI, handling shortcut slots, selected object displays, and combat mode toggles.</summary>
public unsafe struct gmToolbarUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.Internal.ItemListDragHandler

    // Child Types
    public unsafe struct gmToolbarUI_vtbl
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
    public ACBindings.Internal.SmartArray___PanelButtonInfo m_buttonInfoArray;
    public ACBindings.Internal.UIElement* m_pUseObjectButton;
    public ACBindings.Internal.UIElement* m_pExamineObjectButton;
    public ACBindings.Internal.UIElement* m_pSelObjectField;
    public ACBindings.Internal.UIElement_Text* m_pSelObjectName;
    public ACBindings.Internal.UIElement_Meter* m_pSelObjectHealthMeter;
    public ACBindings.Internal.UIElement_Meter* m_pSelObjectManaMeter;
    public ACBindings.Internal.UIElement_Text* m_pStackSizeEntryBox;
    public ACBindings.Internal.UIElement_Scrollbar* m_pStackSizeSlider;
    public ACBindings.Internal.UIElement* m_pInventoryButtonDragOverlay;
    public uint m_iidSelectedObject;
    public ACBindings.Internal.SmartArray___UIElement_ItemList_ptr m_shortcutSlots;
    public uint m_lastShortcutNumDragged;
    public byte m_bToolbarActive;
    public uint m_idAmmoObject;

    // Generated Constructor
    public gmToolbarUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// Updates the toolbar's mana display for the selected item when a notice is received.
    /// 
    /// <code>Offset: 0x004BDD50
    /// void __thiscall gmToolbarUI::RecvNotice_UpdateItemMana(gmToolbarUI*,unsigned int,float,bool)</code>
    /// </summary>
    /// <param name="i_iidTarget">Identifier of the object whose mana should be updated.</param>
    /// <param name="i_fMana">The new mana value to set on the UI element.</param>
    /// <param name="i_bSuccess">Indicates whether the update was successful; if false, a query for item mana is requested.</param>
    public void RecvNotice_UpdateItemMana(uint i_iidTarget, float i_fMana, byte i_bSuccess) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, float, byte, void>)0x004BDD50)(ref this, i_iidTarget, i_fMana, i_bSuccess);

    /// <summary>Updates the toolbar UI's health meter when an object's health changes, provided the object matches the currently registered target element.
    /// <code>Offset: 0x004BDDA0
    /// void __thiscall gmToolbarUI::RecvNotice_UpdateObjectHealth(gmToolbarUI*,unsigned int,float)</code>
    /// </summary>
    /// <param name="i_iidTarget">Identifier of the object whose health has changed.</param>
    /// <param name="i_fHealth">The new health value to display on the UI.</param>
    public void RecvNotice_UpdateObjectHealth(uint i_iidTarget, float i_fHealth) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, float, void>)0x004BDDA0)(ref this, i_iidTarget, i_fHealth);

    /// <summary>Updates the inventory button drag‑overlay while a UI element drags over the toolbar, applying visual feedback when drop flags indicate a valid target.
    /// <code>Offset: 0x004BDE10
    /// void __thiscall gmToolbarUI::HandleInventoryButtonDragOver(gmToolbarUI*,UIElement*)</code>
    /// </summary>
    /// <param name="dragElement">The UI element currently being dragged over the toolbar.</param>
    public void HandleInventoryButtonDragOver(ACBindings.Internal.UIElement* dragElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, ACBindings.Internal.UIElement*, void>)0x004BDE10)(ref this, dragElement);

    /// <summary>Determines whether the specified object is eligible to be added to the toolbar’s shortcut slots. The decision considers the object's type, state flags, inventory status, and whether it belongs to a vendor container.
    /// <code>Offset: 0x004BDE60
    /// bool __thiscall gmToolbarUI::IsShortcutEligible(gmToolbarUI*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="this">The toolbar UI instance performing the check.</param>
    /// <param name="weenObj">Object under consideration for shortcut placement.</param>
    /// <returns>True if the object can be used as a shortcut; otherwise false.</returns>
    public byte IsShortcutEligible(ACBindings.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, ACBindings.Internal.ACCWeenieObject*, byte>)0x004BDE60)(ref this, weenObj);

    /// <summary>
    /// Handles a request to split a stacked item, automatically selecting the entire quantity field so the user can specify a new amount.
    /// 
    /// <code>Offset: 0x004BDF30
    /// void __thiscall gmToolbarUI::RecvNotice_SplitStack(gmToolbarUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidItem">The identifier of the item whose stack may be split.</param>
    public void RecvNotice_SplitStack(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, void>)0x004BDF30)(ref this, i_iidItem);

    /// <summary>Sets the visibility of a toolbar panel identified by its ID, showing it when true and hiding it when false.
    /// <code>Offset: 0x004BDF90
    /// void __thiscall gmToolbarUI::RecvNotice_SetPanelVisibility(gmToolbarUI*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="i_ePanelID">The unique identifier of the panel to be shown or hidden.</param>
    /// <param name="i_bVisible">True to display the panel; false to conceal it.</param>
    public void RecvNotice_SetPanelVisibility(uint i_ePanelID, byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, byte, void>)0x004BDF90)(ref this, i_ePanelID, i_bVisible);

    /// <summary>Activates the toolbar item in the specified shortcut slot, executing its action callback and either using, selecting, or targeting the associated object depending on the current UI target mode and the i_bUse flag.
    /// <code>Offset: 0x004BDFE0
    /// void __thiscall gmToolbarUI::UseShortcut(gmToolbarUI*,int,bool)</code>
    /// </summary>
    /// <param name="slot">Zero‑based index of the shortcut slot to activate.</param>
    /// <param name="i_bUse">If true, attempts to use the item; otherwise selects it.</param>
    public void UseShortcut(int slot, byte i_bUse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, int, byte, void>)0x004BDFE0)(ref this, slot, i_bUse);

    /// <summary>Clears all shortcut item lists associated with the toolbar, resetting their contents.
    /// <code>Offset: 0x004BE0B0
    /// void __thiscall gmToolbarUI::FlushShortcuts(gmToolbarUI*)</code>
    /// </summary>
    public void FlushShortcuts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004BE0B0)(ref this);

    /// <summary>Removes the shortcut for a given item ID from the toolbar's shortcut slots and, optionally, broadcasts the removal to relevant systems.
    /// <code>Offset: 0x004BE0E0
    /// int __thiscall gmToolbarUI::RemoveShortcut(gmToolbarUI*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="itemID">The identifier of the item whose shortcut should be removed.</param>
    /// <param name="broadcast">If true, triggers event notifications and updates the player module.</param>
    /// <returns>The index of the slot from which the shortcut was removed, or -1 if no matching shortcut was found.</returns>
    public int RemoveShortcut(uint itemID, byte broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, byte, int>)0x004BE0E0)(ref this, itemID, broadcast);

    /// <summary>Removes the shortcut assigned to a specified toolbar slot and optionally broadcasts the change.
    /// <code>Offset: 0x004BE180
    /// unsigned int __thiscall gmToolbarUI::RemoveShortcutInSlotNum(gmToolbarUI*,int,bool)</code>
    /// </summary>
    /// <param name="slot">Index of the slot from which to remove the shortcut; must be within bounds.</param>
    /// <param name="broadcast">If true, notifies other components that the shortcut was removed.</param>
    /// <returns>The identifier of the removed shortcut, or 0 if no shortcut existed in the specified slot or removal failed.</returns>
    public uint RemoveShortcutInSlotNum(int slot, byte broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, int, byte, uint>)0x004BE180)(ref this, slot, broadcast);

    /// <summary>Finds the first empty shortcut slot to the right of a specified position, searching forward and wrapping around if necessary.
    /// <code>Offset: 0x004BE1F0
    /// int __thiscall gmToolbarUI::GetFirstEmptyShortcutToTheRightOf(gmToolbarUI*,unsigned int)</code>
    /// </summary>
    /// <param name="index">Zero‑based index of the starting shortcut slot.</param>
    /// <returns>-1 if no empty slot exists; otherwise the zero‑based index of the nearest empty slot to the right.</returns>
    public int GetFirstEmptyShortcutToTheRightOf(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, int>)0x004BE1F0)(ref this, index);

    /// <summary>Checks whether a specified shortcut slot in the toolbar is empty and ready for use.
    /// <code>Offset: 0x004BE270
    /// bool __thiscall gmToolbarUI::IsShortcutSlotAvailable(gmToolbarUI*,int)</code>
    /// </summary>
    /// <param name="slot">Zero‑based index of the shortcut slot to test.</param>
    /// <returns>True if the slot exists and contains no items; otherwise, false.</returns>
    public byte IsShortcutSlotAvailable(int slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, int, byte>)0x004BE270)(ref this, slot);

    /// <summary>Adjusts toolbar controls to match the specified combat mode, enabling or disabling shortcuts and visibility of related buttons.
    /// <code>Offset: 0x004BE2A0
    /// void __thiscall gmToolbarUI::RecvNotice_SetCombatMode(gmToolbarUI*,COMBAT_MODE)</code>
    /// </summary>
    /// <param name="i_eCombatMode">The combat mode to apply (e.g., MELEE_COMBAT_MODE, MISSILE_COMBAT_MODE).</param>
    public void RecvNotice_SetCombatMode(ACBindings.Internal.COMBAT_MODE i_eCombatMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, ACBindings.Internal.COMBAT_MODE, void>)0x004BE2A0)(ref this, i_eCombatMode);

    /// <summary>Initializes a toolbar UI element, setting up base UI fields and internal state such as button info array, selected object tracking, and activation flag.
    /// <code>Offset: 0x004BE3A0
    /// void __thiscall gmToolbarUI::gmToolbarUI(gmToolbarUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Description of the layout containing dimensions and element mapping for the toolbar.</param>
    /// <param name="full_desc">Full element descriptor defining properties and children for the toolbar.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004BE3A0)(ref this, layout, full_desc);

    /// <summary>Attempts to cast a gmToolbarUI instance to a specified type based on a numeric type identifier, returning a UIElement pointer when the requested type matches either the toolbar’s own type or its base UIElement.
    /// <code>Offset: 0x004BE460
    /// UIElement* __thiscall gmToolbarUI::DynamicCast(gmToolbarUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Numeric type identifier for the desired cast target.</param>
    /// <returns>Pointer to the UIElement representation of the object if the type matches; otherwise null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, ACBindings.Internal.UIElement*>)0x004BE460)(ref this, i_eType);

    /// <summary>Retrieves the unique type identifier for this toolbar UI element.
    /// <code>Offset: 0x004BE480
    /// unsigned int __thiscall gmToolbarUI::GetUIElementType(gmToolbarUI*)</code>
    /// </summary>
    /// <returns>The unsigned integer representing the UI element's type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint>)0x004BE480)(ref this);

    /// <summary>Releases resources owned by a toolbar UI instance. Unregisters shortcut slot drag handlers and global listeners, deallocates dynamic button and shortcut data arrays, then calls destructors for inherited notice handler and element field base classes.
    /// <code>Offset: 0x004BE490
    /// void __thiscall gmToolbarUI::~gmToolbarUI(gmToolbarUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004BE490)(ref this);

    /// <summary>Creates a new toolbar UI element using the supplied layout and descriptor information.
    /// <code>Offset: 0x004BE550
    /// UIElement* __cdecl gmToolbarUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout definition for the toolbar’s visual structure.</param>
    /// <param name="full_desc">Full element description defining properties, states, and children for the toolbar.</param>
    /// <returns>A pointer to the newly created UIElement representing the toolbar; null if allocation fails.</returns>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004BE550)(layout, full_desc);

    /// <summary>Removes an item's shortcut from the toolbar UI when a removal notice is received, delegating to the internal RemoveShortcut routine with the removal flag enabled.
    /// <code>Offset: 0x004BE580
    /// void __thiscall gmToolbarUI::RecvNotice_RemoveShortcut(gmToolbarUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_itemID">The identifier of the item whose toolbar shortcut should be removed.</param>
    public void RecvNotice_RemoveShortcut(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, void>)0x004BE580)(ref this, i_itemID);

    /// <summary>Triggers execution of the tool or item bound to the specified toolbar shortcut slot.
    /// <code>Offset: 0x004BE5A0
    /// void __thiscall gmToolbarUI::RecvNotice_UseShortcut(gmToolbarUI*,int)</code>
    /// </summary>
    /// <param name="i_slot">Zero-based index of the shortcut slot to activate.</param>
    public void RecvNotice_UseShortcut(int i_slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, int, void>)0x004BE5A0)(ref this, i_slot);

    /// <summary>Handles an item‑list drag start event, removing any shortcut that references the dragged item and updating internal bookkeeping.
    /// <code>Offset: 0x004BE5C0
    /// void __thiscall gmToolbarUI::RecvNotice_ItemListBeginDrag(gmToolbarUI*,const UIElement*,int)</code>
    /// </summary>
    /// <param name="i_itemList">The UI element representing the item list where dragging began.</param>
    /// <param name="i_slotNum">Index of the toolbar slot from which the drag was initiated; not currently used in this implementation but kept for API compatibility.</param>
    public void RecvNotice_ItemListBeginDrag(ACBindings.Internal.UIElement* i_itemList, int i_slotNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, ACBindings.Internal.UIElement*, int, void>)0x004BE5C0)(ref this, i_itemList, i_slotNum);

    /// <summary>Adds an object to the toolbar as a shortcut, placing it in the requested zero‑based slot or the first empty slot if the index is out of range. Existing items in that slot are cleared before the new item is added. If <paramref name="broadcast"/> is true, the method triggers shortcut‑addition events for the character and player systems.
    /// <code>Offset: 0x004BE630
    /// void __thiscall gmToolbarUI::AddShortcut(gmToolbarUI*,unsigned int,int,bool)</code>
    /// </summary>
    /// <param name="itemID">Identifier of the object to be assigned as a toolbar shortcut.</param>
    /// <param name="slot">Zero‑based index of the desired toolbar slot; if invalid or out of range, the first available empty slot is used instead.</param>
    /// <param name="broadcast">When true, emits events to notify character and player modules that a new shortcut has been added.</param>
    public void AddShortcut(uint itemID, int slot, byte broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, int, byte, void>)0x004BE630)(ref this, itemID, slot, broadcast);

    /// <summary>Registers the toolbar UI element class with the UI system, enabling its creation via the framework.
    /// <code>Offset: 0x004BE730
    /// void __cdecl gmToolbarUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004BE730)();

    /// <summary>Creates a toolbar shortcut for the specified item. Optionally picks up the item and places it into the player's backpack before linking it to an existing or new slot. Suppresses status messages when silent is true.
    /// <code>Offset: 0x004BE750
    /// void __thiscall gmToolbarUI::CreateShortcutToItem(gmToolbarUI*,unsigned int,int,bool,bool)</code>
    /// </summary>
    /// <param name="itemID">The unique identifier of the item to be linked as a shortcut.</param>
    /// <param name="shortcutIndex">Target toolbar slot; -1 causes the function to select the first free slot.</param>
    /// <param name="pickUp">If true, attempts to pick up the item and add it to the backpack before creating the shortcut.</param>
    /// <param name="silent">When true, disables user‑facing notices for ineligible items or errors.</param>
    public void CreateShortcutToItem(uint itemID, int shortcutIndex, byte pickUp, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, int, byte, byte, void>)0x004BE750)(ref this, itemID, shortcutIndex, pickUp, silent);

    /// <summary>Initializes the toolbar's shortcut slots by locating UI elements, registering drag handlers for each slot, storing them in m_shortcutSlots, and then flushing existing shortcuts.
    /// <code>Offset: 0x004BE9E0
    /// void __thiscall gmToolbarUI::InitShortcutArray(gmToolbarUI*)</code>
    /// </summary>
    public void InitShortcutArray() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004BE9E0)(ref this);

    /// <summary>Responds to global input messages for the toolbar UI, performing actions such as executing or creating shortcuts, updating the stack‑size entry field, or handling specific key codes.
    /// <code>Offset: 0x004BF170
    /// void __thiscall gmToolbarUI::ListenToGlobalMessage(gmToolbarUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the incoming global message; only message ID 1 is handled by this method.</param>
    /// <param name="i_data_int">Data associated with the message. When the toolbar’s stack size entry field has focus and this value equals 39, the field is updated; otherwise the value is interpreted as a key code to use or create shortcuts.</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, int, void>)0x004BF170)(ref this, i_messageID, i_data_int);

    /// <summary>Processes a drop release event on the toolbar UI, moving items to the player’s backpack or updating shortcut slots based on where the item was dropped.
    /// <code>Offset: 0x004BF450
    /// void __thiscall gmToolbarUI::HandleDropRelease(gmToolbarUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message containing information about the dragged element, the target element, and contextual data such as cursor position and identifiers.</param>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, ACBindings.Internal.UIElementMessageInfo*, void>)0x004BF450)(ref this, i_rMsg);

    /// <summary>Adds a shortcut button linking to the specified item ID in the designated toolbar slot.
    /// <code>Offset: 0x004BF620
    /// void __thiscall gmToolbarUI::RecvNotice_AddShortcut(gmToolbarUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_itemID">Unique identifier of the item to link.</param>
    /// <param name="i_slot">Toolbar slot index where the shortcut should appear.</param>
    public void RecvNotice_AddShortcut(uint i_itemID, int i_slot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, int, void>)0x004BF620)(ref this, i_itemID, i_slot);

    /// <summary>Updates toolbar shortcuts when an item is fully merged into another by removing the old item's shortcut and creating a new shortcut to the merged target.
    /// <code>Offset: 0x004BF640
    /// void __thiscall gmToolbarUI::RecvNotice_FullMergingItem(gmToolbarUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_oldObject">Identifier of the item whose shortcut should be removed from the toolbar.</param>
    /// <param name="i_mergeTo">Identifier of the item that will receive the merged stack, for which a new toolbar shortcut is created.</param>
    public void RecvNotice_FullMergingItem(uint i_oldObject, uint i_mergeTo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, uint, void>)0x004BF640)(ref this, i_oldObject, i_mergeTo);

    /// <summary>Retrieves the current stack size of the ammo object referenced by m_idAmmoObject and updates the toolbar's ammo counter text element. If the ammo object's stack size is zero, it displays 1 instead.
    /// <code>Offset: 0x004BF670
    /// void __thiscall gmToolbarUI::UpdateAmmoNumber(gmToolbarUI*)</code>
    /// </summary>
    public void UpdateAmmoNumber() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004BF670)(ref this);

    /// <summary>Initializes toolbar UI components by locating child elements, storing references to buttons, selection field, health/mana meters, stack size entry box and slider, drag overlay, and shortcut slots; builds the button information array with corresponding panel IDs and resets input action callbacks for the selected object controls.
    /// <code>Offset: 0x004BF710
    /// void __thiscall gmToolbarUI::PostInit(gmToolbarUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004BF710)(ref this);

    /// <summary>Handles toolbar button interactions by interpreting UI element messages and performing actions such as toggling combat mode, using or examining selected objects, managing stack size input, drag‑and‑drop inventory operations, and updating UI elements accordingly.
    /// <code>Offset: 0x004BFB20
    /// UIElementMessageListenResult __thiscall gmToolbarUI::ListenToElementMessage(gmToolbarUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element event to process.</param>
    /// <returns>The result of listening to the message, indicating whether default handling should occur or a specific action was taken.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004BFB20)(ref this, i_rMsg);

    /// <summary>Updates the toolbar’s current ammo identifier by examining the active weapon or object and any linked ammunition items, then refreshes the displayed ammo count if a new ID is found.
    /// <code>Offset: 0x004BFEA0
    /// void __thiscall gmToolbarUI::UpdateAmmoID(gmToolbarUI*)</code>
    /// </summary>
    public void UpdateAmmoID() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004BFEA0)(ref this);

    /// <summary>Handles a server notice that an item has moved, updating the toolbar UI accordingly. If the move involves the player’s wielded container and changes location flags, refreshes the ammo display. Searches all list boxes for the moved item and removes any shortcut button pointing to it when it is no longer owned by the player.
    /// <code>Offset: 0x004BFF40
    /// void __thiscall gmToolbarUI::RecvNotice_ServerSaysMoveItem(gmToolbarUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">Unique identifier of the moved item.</param>
    /// <param name="oldContainer">Identifier of the container from which the item was removed.</param>
    /// <param name="oldWielder">Identifier of the previous wielder owning the item.</param>
    /// <param name="oldLocation">Bit flags describing the item's previous location.</param>
    /// <param name="newContainer">Identifier of the destination container.</param>
    /// <param name="place">Target slot position within the destination (unused in logic).</param>
    /// <param name="newWielder">Identifier of the new wielder after the move.</param>
    /// <param name="newLocation">Bit flags describing the item's new location.</param>
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004BFF40)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>Updates toolbar UI elements when the selected object changes, refreshing its name, health and mana meters, stack size controls, and action button states based on the object's properties.
    /// <code>Offset: 0x004C0010
    /// void __thiscall gmToolbarUI::HandleSelectionChanged(gmToolbarUI*)</code>
    /// </summary>
    public void HandleSelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004C0010)(ref this);

    /// <summary>Synchronizes the toolbar UI with the active player module by refreshing shortcut buttons and ammo data.
    /// <code>Offset: 0x004C04A0
    /// void __thiscall gmToolbarUI::UpdateFromPlayerDesc(gmToolbarUI*)</code>
    /// </summary>
    public void UpdateFromPlayerDesc() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004C04A0)(ref this);

    /// <summary>Handles notification that an item's attributes have changed, updating the toolbar UI for selection changes or ammo updates.
    /// <code>Offset: 0x004C0580
    /// void __thiscall gmToolbarUI::RecvNotice_ItemAttributesChanged(gmToolbarUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_target">Identifier of the object whose attributes were updated.</param>
    /// <param name="i_attrib">Attribute flag indicating which attribute changed (unused in this implementation).</param>
    public void RecvNotice_ItemAttributesChanged(uint i_target, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, uint, uint, void>)0x004C0580)(ref this, i_target, i_attrib);

    /// <summary>Responds to selection change notices by delegating to the toolbar's internal handler to update UI elements accordingly.
    /// <code>Offset: 0x004C0600
    /// void __thiscall gmToolbarUI::RecvNotice_SelectionChanged(gmToolbarUI*)</code>
    /// </summary>
    public void RecvNotice_SelectionChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, void>)0x004C0600)(ref this);

    /// <summary>Synchronizes the toolbar UI with updated player information when a player description notice is received.
    /// <code>Offset: 0x004C0610
    /// void __thiscall gmToolbarUI::RecvNotice_PlayerDescReceived(gmToolbarUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="i_playerDesc">The new player qualities structure containing attributes and stats to display.</param>
    /// <param name="i_playerModule">The player module providing additional state such as dirty flags or timestamps.</param>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmToolbarUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004C0610)(ref this, i_playerDesc, i_playerModule);
}

