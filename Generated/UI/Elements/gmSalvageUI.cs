namespace ACBindings.Internal;


/// <summary>Handles the in‑game salvage UI, managing item lists, tool selection, and drag‑and‑drop operations for converting items into crafting components.</summary>
public unsafe struct gmSalvageUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.Internal.ItemListDragHandler

    // Child Types
    public unsafe struct gmSalvageUI_vtbl
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
    public ACBindings.Internal.UIElement_ItemList* m_salvageList;
    public ACBindings.Internal.UIElement* m_salvageButton;
    public uint m_toolID;
    public uint m_material;

    // Generated Constructor
    public gmSalvageUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Finalizes the gmSalvageUI instance by unregistering its item list drag handler, removing any registered notice handlers from the global event system, resetting virtual tables, and invoking base class destructors to clean up resources.
    /// <code>Offset: 0x004CBB30
    /// void __thiscall gmSalvageUI::~gmSalvageUI(gmSalvageUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, void>)0x004CBB30)(ref this);

    /// <summary>Returns a UIElement pointer for the current gmSalvageUI instance when the supplied type identifier matches either the object's own type or its UIElement base class; otherwise returns null.
    /// <code>Offset: 0x004CBB90
    /// UIElement* __thiscall gmSalvageUI::DynamicCast(gmSalvageUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The requested element type identifier (e.g., 268435473 for UIElement base, 3 for gmSalvageUI).</param>
    /// <returns>Pointer to a UIElement matching the requested type, or nullptr if no match is found.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint, ACBindings.Internal.UIElement*>)0x004CBB90)(ref this, i_eType);

    /// <summary>Returns the unique identifier for this salvage user interface element.
    /// <code>Offset: 0x004CBBB0
    /// unsigned int __thiscall gmSalvageUI::GetUIElementType(gmSalvageUI*)</code>
    /// </summary>
    /// <returns>An unsigned integer constant (268435473) that represents the UI element type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint>)0x004CBBB0)(ref this);

    /// <summary>Removes an item identified by its ID from the salvage list, resets its trade state, and cleans up UI components when the list becomes empty.
    /// <code>Offset: 0x004CBBC0
    /// void __thiscall gmSalvageUI::RemoveItem(gmSalvageUI*,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">The unique identifier of the item to remove from the salvage UI.</param>
    public void RemoveItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint, void>)0x004CBBC0)(ref this, itemID);

    /// <summary>Determines whether a given item qualifies for salvaging based on its material type, structure level, module restrictions, and special flags.
    /// <code>Offset: 0x004CBC30
    /// bool __thiscall gmSalvageUI::IsItemSuitable(gmSalvageUI*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="item">The object to evaluate for salvage suitability.</param>
    /// <returns>True if the item meets all salvage criteria; otherwise false.</returns>
    public byte IsItemSuitable(ACBindings.Internal.ACCWeenieObject* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, ACBindings.Internal.ACCWeenieObject*, byte>)0x004CBC30)(ref this, item);

    /// <summary>Creates a salvage UI element within the client housing system, initializing base UI fields, notice handling, and item list dragging support.
    /// <code>Offset: 0x004CBCA0
    /// void __thiscall gmSalvageUI::gmSalvageUI(gmSalvageUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Description of the overall UI layout to apply to this element.</param>
    /// <param name="full_desc">Full description of the specific UI element being constructed.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004CBCA0)(ref this, layout, full_desc);

    /// <summary>Initializes the salvage UI by locating child elements, configuring the item list drag handler, and registering notice handlers for relevant events.
    /// <code>Offset: 0x004CBD30
    /// void __thiscall gmSalvageUI::PostInit(gmSalvageUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, void>)0x004CBD30)(ref this);

    /// <summary>Handles a notice indicating that a salvage item with the specified ID should be removed from the UI list.
    /// <code>Offset: 0x004CBE00
    /// void __thiscall gmSalvageUI::RecvNotice_RemoveSalvageItem(gmSalvageUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_itemID">The unique identifier of the salvage item to remove.</param>
    public void RecvNotice_RemoveSalvageItem(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint, void>)0x004CBE00)(ref this, i_itemID);

    /// <summary>Initiates a drag operation for an item in the salvage list, triggers its action event, and removes it from the UI if the action indicates removal.
    /// <code>Offset: 0x004CBE10
    /// void __thiscall gmSalvageUI::RecvNotice_ItemListBeginDrag(gmSalvageUI*,const UIElement*,int)</code>
    /// </summary>
    /// <param name="i_itemList">UI element representing the item list control.</param>
    /// <param name="i_slotNum">Index of the slot within the list to begin dragging.</param>
    public void RecvNotice_ItemListBeginDrag(ACBindings.Internal.UIElement* i_itemList, int i_slotNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, ACBindings.Internal.UIElement*, int, void>)0x004CBE10)(ref this, i_itemList, i_slotNum);

    /// <summary>Clears the trade state for every item displayed in the supplied list by resetting their associated game objects.
    /// <code>Offset: 0x004CBE60
    /// void __thiscall gmSalvageUI::ClearAllTradeStates(gmSlumlordUI*,UIElement_ItemList*)</code>
    /// </summary>
    /// <param name="list">The UI element list containing items whose trade states are to be cleared.</param>
    public void ClearAllTradeStates(ACBindings.Internal.UIElement_ItemList* list) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, ACBindings.Internal.UIElement_ItemList*, void>)0x004CBE60)(ref this, list);

    /// <summary>Adds the specified item to the salvage list when it is suitable and not already present. On successful addition, updates the item's trade state, sets the material type for the first entry, and activates the salvage button.
    /// <code>Offset: 0x004CBEC0
    /// bool __thiscall gmSalvageUI::_AddItem(gmSalvageUI*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="item">The item to be added to the salvage list.</param>
    /// <returns>True if the item was successfully added; otherwise false.</returns>
    public byte _AddItem(ACBindings.Internal.ACCWeenieObject* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, ACBindings.Internal.ACCWeenieObject*, byte>)0x004CBEC0)(ref this, item);

    /// <summary>Registers the GM Salvage UI element type (ID 0x10000011) with the UI framework, making it available for creation and use within the game.
    /// <code>Offset: 0x004CBF50
    /// void __cdecl gmSalvageUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004CBF50)();

    /// <summary>Closes the salvage panel, clearing all trade states, resetting tool ID and material, emptying the salvage item list, and destroying the salvage button if present.
    /// <code>Offset: 0x004CBFD0
    /// void __thiscall gmSalvageUI::CloseSalvagePanel(gmSalvageUI*)</code>
    /// </summary>
    public void CloseSalvagePanel() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, void>)0x004CBFD0)(ref this);

    /// <summary>Adds an item to the salvage UI by its identifier, delegating to helper functions based on whether the object contains nested items.
    /// <code>Offset: 0x004CC020
    /// bool __thiscall gmSalvageUI::AddNewItem(gmSalvageUI*,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">Identifier of the game object to be added.</param>
    /// <returns>True if the item (or its contained items) was successfully added; otherwise false when the object cannot be found or handling fails.</returns>
    public byte AddNewItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint, byte>)0x004CC020)(ref this, itemID);

    /// <summary>Responds to visibility changes on the salvage UI element. If the element becomes invisible while a specific internal flag is set, it closes the salvage panel.
    /// <code>Offset: 0x004CC060
    /// void __thiscall gmSalvageUI::OnVisibilityChanged(gmSalvageUI*,bool)</code>
    /// </summary>
    /// <param name="i_bVisible">True if the element is being shown; false if hidden.</param>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, byte, void>)0x004CC060)(ref this, i_bVisible);

    /// <summary>Opens the salvage panel with the specified tool ID, clearing any prior trade states and resetting the internal item list before display.
    /// <code>Offset: 0x004CC090
    /// void __thiscall gmSalvageUI::RecvNotice_OpenSalvagePanel(gmSalvageUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_toolID">Identifier for the tool that initiates opening of the salvage panel.</param>
    public void RecvNotice_OpenSalvagePanel(uint i_toolID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint, void>)0x004CC090)(ref this, i_toolID);

    /// <summary>Adds a salvage item identified by its ID to the UI, handling both standalone items and containers with contained items.
    /// <code>Offset: 0x004CC0A0
    /// void __thiscall gmSalvageUI::RecvNotice_AddSalvageItem(gmSalvageUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_itemID">Identifier of the item to add.</param>
    public void RecvNotice_AddSalvageItem(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint, void>)0x004CC0A0)(ref this, i_itemID);

    /// <summary>Recursively adds all non‑container items from the supplied container to the salvage list and displays a notice about the operation.
    /// <code>Offset: 0x004CC0E0
    /// bool __thiscall gmSalvageUI::_AddContainedItems(gmSalvageUI*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="container">The container object whose contents are processed.</param>
    /// <returns>True if the container had a contained items list (even if empty), indicating that processing occurred; otherwise false when no such list exists.</returns>
    public byte _AddContainedItems(ACBindings.Internal.ACCWeenieObject* container) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, ACBindings.Internal.ACCWeenieObject*, byte>)0x004CC0E0)(ref this, container);

    /// <summary>Checks if an item can be dragged into the salvage list by verifying existence, ownership, duplication, and salvage suitability.
    /// <code>Offset: 0x004CC240
    /// bool __thiscall gmSalvageUI::DragItemAcceptable(gmSalvageUI*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="itemID">Identifier of the item being dragged.</param>
    /// <param name="silent">When true suppresses a notice if the item is not owned by the player; otherwise displays a warning message.</param>
    /// <returns>True if the item exists, belongs to the player, is not already in the salvage list, and has contained items or meets salvage criteria; false otherwise.</returns>
    public byte DragItemAcceptable(uint itemID, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint, byte, byte>)0x004CC240)(ref this, itemID, silent);

    /// <summary>Accepts a dragged item into the salvage UI if it meets validation rules. When a salvage list is present, the item is appended to it.
    /// <code>Offset: 0x004CC380
    /// bool __thiscall gmSalvageUI::AcceptDragObject(gmSalvageUI*,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">Identifier of the item being dragged.</param>
    /// <returns>True if the item was accepted for salvage (added when a list exists); otherwise false.</returns>
    public byte AcceptDragObject(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, uint, byte>)0x004CC380)(ref this, itemID);

    /// <summary>Processes a drag‑drop release on the salvage UI by validating that the source element is a valid droppable item and that the drop target is the salvage list before accepting the object.
    /// <code>Offset: 0x004CC3C0
    /// void __thiscall gmSalvageUI::HandleDropRelease(gmSalvageUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information for the drop event, containing identifiers of the dragged element, the target element, and parameters used to determine acceptance conditions.</param>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, ACBindings.Internal.UIElementMessageInfo*, void>)0x004CC3C0)(ref this, i_rMsg);

    /// <summary>Salvages selected items from the UI list, creating a tinkering tool when a valid tool ID is present and items are selected. Returns true on successful salvage; otherwise false.
    /// <code>Offset: 0x004CC430
    /// bool __thiscall gmSalvageUI::Salvage(gmSalvageUI*)</code>
    /// </summary>
    /// <returns>True if the salvage operation completed successfully; false if no items were selected or no tool ID was set.</returns>
    public byte Salvage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, byte>)0x004CC430)(ref this);

    /// <summary>Handles UI element messages for the salvage screen, routing list‑item actions, button clicks and drag‑drop releases to internal handlers before delegating to the base class.
    /// <code>Offset: 0x004CC540
    /// UIElementMessageListenResult __thiscall gmSalvageUI::ListenToElementMessage(gmSalvageUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">The gmSalvageUI instance receiving the message.</param>
    /// <param name="i_rMsg">Information about the UI event being processed.</param>
    /// <returns>Result returned by the base UIElement implementation after processing the message.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSalvageUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004CC540)(ref this, i_rMsg);
}

