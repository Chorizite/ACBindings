namespace ACBindings.Internal;


/// <summary>Vendor user interface component that manages vendor interactions, including item listings, purchase and sale operations, and transaction tracking within the game client.</summary>
public unsafe struct gmVendorUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler
    public ACBindings.Internal.ObjectRangeHandler BaseClass_ObjectRangeHandler; // ACBindings.Internal.ObjectRangeHandler

    // Statics
    public static uint* m_curDialogContext = (uint*)0x00840534;

    // Child Types
    public unsafe struct gmVendorUI_vtbl
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
    public ACBindings.Internal.UIElement_Panel* m_vendorPanel;
    public uint shopVendorID;
    public ACBindings.Internal.VendorProfile* shopVendorProfile;
    public System.IntPtr shopItemProfileList;
    public ACBindings.Internal.PackableList___ItemProfile m_buyList;
    public ACBindings.Internal.PackableList___ItemProfile m_sellList;
    public ACBindings.Internal.VendorItemsUI* m_itemsUI;
    public ACBindings.Internal.VendorBuyUI* m_buyUI;
    public ACBindings.Internal.VendorSellUI* m_sellUI;
    public int m_totalValue;
    public int m_last_sale;

    // Generated Constructor
    public gmVendorUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Triggers a vendor transaction, calling CM_Vendor::Event_Buy when a4 is zero or CM_Vendor::Event_Sell when a4 equals one, then records the request and marks the UI busy.
    /// <code>Offset: 0x004C0EA0
    /// void __stdcall gmVendorUI::SendShopEvent(int,int*,int,int)</code>
    /// </summary>
    /// <param name="requestObjID">Identifier of the vendor object involved in the event.</param>
    /// <param name="a2">Pointer to data supplied for the transaction (typically item identifier or quantity).</param>
    /// <param name="a3">Additional value used only when performing a buy operation, such as desired quantity.</param>
    /// <param name="a4">Transaction type flag: zero initiates a purchase, one initiates a sale; any other non‑zero value results in no action.</param>
    public static void SendShopEvent(int requestObjID, int* a2, int a3, int a4) => ((delegate* unmanaged[Stdcall]<int, int*, int, int, void>)0x004C0EA0)(requestObjID, a2, a3, a4);

    /// <summary>Updates all registered UI components about a change in the selected vendor item, passing the previous and new item identifiers.
    /// <code>Offset: 0x004C0F00
    /// void __thiscall gmVendorUI::RecvNotice_SetSelectedItem(gmVendorUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="oldSelectedID">Identifier of the item that was previously selected.</param>
    /// <param name="selectedID">Identifier of the newly selected item.</param>
    public void RecvNotice_SetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, uint, void>)0x004C0F00)(ref this, oldSelectedID, selectedID);

    /// <summary>Handles the closing of a vendor window, deregistering its UI elements when not in an update cycle.
    /// <code>Offset: 0x004C0F40
    /// void __thiscall gmVendorUI::RecvNotice_CloseVendor(gmVendorUI*,bool)</code>
    /// </summary>
    /// <param name="i_bUpdating">True if the notice is part of an ongoing update; false triggers cleanup.</param>
    public void RecvNotice_CloseVendor(byte i_bUpdating) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, byte, void>)0x004C0F40)(ref this, i_bUpdating);

    /// <summary>Handles removal of an object from the vendor UI’s monitored range, updating internal registration when the specified object exits.
    /// <code>Offset: 0x004C0F70
    /// void __thiscall gmVendorUI::OnObjectRangeExit(gmVendorUI*,unsigned int)</code>
    /// </summary>
    /// <param name="objectID">Identifier of the object that has left the monitored area.</param>
    public void OnObjectRangeExit(uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, void>)0x004C0F70)(ref this, objectID);

    /// <summary>Updates the sell state of a vendor item identified by its unique ID.
    /// <code>Offset: 0x004C0FA0
    /// void __thiscall gmVendorUI::VendorItemSetSellState(gmVendorUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="itemID">The identifier of the item whose sell state is to be changed.</param>
    /// <param name="state">The new sell state value to apply to the item (e.g., active or inactive).</param>
    public void VendorItemSetSellState(uint itemID, int state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, int, void>)0x004C0FA0)(ref this, itemID, state);

    /// <summary>Removes an item from the supplied UI list and, if that list represents the vendor's sell inventory, clears the item's selling state.
    /// <code>Offset: 0x004C0FC0
    /// void __thiscall gmVendorUI::DeleteItem(gmVendorUI*,UIElement_ItemList*,unsigned int,int)</code>
    /// </summary>
    /// <param name="uiItemList">The UI element that holds the items to be modified.</param>
    /// <param name="itemID">Identifier of the item to delete from the list.</param>
    /// <param name="broadcast">Flag indicating whether changes should be broadcast to other systems (currently unused).</param>
    public void DeleteItem(ACBindings.Internal.UIElement_ItemList* uiItemList, uint itemID, int broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.UIElement_ItemList*, uint, int, void>)0x004C0FC0)(ref this, uiItemList, itemID, broadcast);

    /// <summary>Opens a specified tab within the vendor UI, clearing any previous sale state.
    /// <code>Offset: 0x004C1010
    /// void __thiscall gmVendorUI::OpenTab(gmVendorUI*,unsigned int)</code>
    /// </summary>
    /// <param name="tabID">The identifier of the tab to activate.</param>
    public void OpenTab(uint tabID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, void>)0x004C1010)(ref this, tabID);

    /// <summary>Updates drag‑over handling for the vendor UI, opening a designated tab when a dragged element hovers over the vendor panel’s screen bounds.
    /// <code>Offset: 0x004C1030
    /// void __thiscall gmVendorUI::UpdateDragOver(gmVendorUI*)</code>
    /// </summary>
    public void UpdateDragOver() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, void>)0x004C1030)(ref this);

    /// <summary>Handles global messages for the vendor UI, updating drag‑over state when message ID 3 is received.
    /// <code>Offset: 0x004C1100
    /// void __thiscall gmVendorUI::ListenToGlobalMessage(gmVendorUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the global message to process.</param>
    /// <param name="i_data_int">Auxiliary data associated with the message (unused in this implementation).</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, int, void>)0x004C1100)(ref this, i_messageID, i_data_int);

    /// <summary>Initializes the vendor user interface by creating item, buy, and sell panels; registers global event handlers for various vendor-related notices; and sets up quality change listeners.
    /// <code>Offset: 0x004C1590
    /// void __thiscall gmVendorUI::PostInit(gmVendorUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, void>)0x004C1590)(ref this);

    /// <summary>Checks whether the vendor shop contains an item with the specified ID and, if found, returns a reference to it while optionally updating a count value.
    /// <code>Offset: 0x004C1760
    /// char __thiscall gmVendorUI::ShopHasItem(_DWORD*,int,_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">The ID of the item to search for in the vendor's inventory.</param>
    /// <param name="a3">A pointer to an integer that may be updated with the lesser of its current value and the available quantity of the found item.</param>
    /// <param name="a4">A pointer to an integer that receives the object identifier of the matching item profile when it is found.</param>
    /// <returns>Non‑zero if the item exists in the shop; zero otherwise.</returns>
    public sbyte ShopHasItem(int a2, int* a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, int, int*, int*, sbyte>)0x004C1760)(ref this, a2, a3, a4);

    /// <summary>Clears the sell state flag for every item referenced by the supplied list of vendor items.
    /// <code>Offset: 0x004C17C0
    /// void __stdcall gmVendorUI::FlushSellListSellState(int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the container that holds the list of items whose sell state is being cleared.</param>
    public static void FlushSellListSellState(int a1) => ((delegate* unmanaged[Stdcall]<int, void>)0x004C17C0)(a1);

    /// <summary>
    /// Iterates over an object's inventory, incrementing slot counts based on item stackability and activation/capacity flags. The first output parameter receives the number of normal slots; the second receives the number of special slots.
    /// 
    /// <code>Offset: 0x004C1800
    /// ACCWeenieObject* __stdcall gmVendorUI::InqListSlotCount(ACCWeenieObject*,_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a1">The object whose inventory is queried.</param>
    /// <param name="a2">Pointer to a DWORD that will receive the count of normal slots.</param>
    /// <param name="a3">Pointer to a DWORD that will receive the count of special slots requiring activation or capacity handling.</param>
    /// <returns>Pointer to the last processed weenie object, or the original argument if no items were processed.</returns>
    public static ACBindings.Internal.ACCWeenieObject* InqListSlotCount(ACBindings.Internal.ACCWeenieObject* a1, int* a2, int* a3) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.ACCWeenieObject*, int*, int*, ACBindings.Internal.ACCWeenieObject*>)0x004C1800)(a1, a2, a3);

    /// <summary>Removes an item profile from the provided list based on its ID and optionally reduces the stored amount.
    /// <code>Offset: 0x004C1E50
    /// char __stdcall gmVendorUI::RemoveProfileFromList(_DWORD*,int,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the list of item profiles.</param>
    /// <param name="a2">ID of the item profile to remove or modify.</param>
    /// <param name="a3">Quantity to subtract; if -1 or greater than or equal to the current amount, the entire entry is removed.</param>
    /// <returns>Non‑zero when an entry was found and modified or deleted; zero when no matching profile exists.</returns>
    public static sbyte RemoveProfileFromList(int* a1, int a2, int a3) => ((delegate* unmanaged[Stdcall]<int*, int, int, sbyte>)0x004C1E50)(a1, a2, a3);

    /// <summary>Records item data from a list box into a vendor inventory, merging amounts when requested and using stack sizes for quantity calculations.
    /// <code>Offset: 0x004C1F00
    /// char __stdcall gmVendorUI::RecordContents(UIElement_ListBox*,_DWORD*,int,int)</code>
    /// </summary>
    /// <param name="a1">UI element list box containing items to record.</param>
    /// <param name="a2">Pointer to the PackableList of ItemProfile that will receive the recorded profiles.</param>
    /// <param name="a3">If non‑zero, existing profiles with matching item IDs are merged by adding amounts; otherwise new profiles are always created.</param>
    /// <param name="a4">If non‑zero, the stack size of each item is used as the quantity instead of a default value of one.</param>
    /// <returns>Non‑zero if at least one profile was updated (merged), zero if all added items were inserted as new profiles.</returns>
    public static sbyte RecordContents(ACBindings.Internal.UIElement_ListBox* a1, int* a2, int a3, int a4) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.UIElement_ListBox*, int*, int, int, sbyte>)0x004C1F00)(a1, a2, a3, a4);

    /// <summary>Adds a specified item to a vendor UI list at a given position. When removeDuplicates is true, any existing instance of that item is removed first; if addContents is set, contained items are also added recursively. The method only adds the item when the vendor profile accepts it unless excludeIfUnacceptable is false, and returns the final insertion index or -1 on failure.
    /// <code>Offset: 0x004C20A0
    /// int __thiscall gmVendorUI::AddItem(gmVendorUI*,UIElement_ItemList*,unsigned int,int,int,int,int,int,int)</code>
    /// </summary>
    /// <param name="uiItemList">The UI list control to which the item will be inserted.</param>
    /// <param name="itemID">Identifier of the item to add.</param>
    /// <param name="position">Desired insertion position; adjusted if duplicates are removed.</param>
    /// <param name="removeDuplicates">If true, removes any existing instance before adding.</param>
    /// <param name="addContents">Recursively add contained items when true.</param>
    /// <param name="excludeIfUnacceptable">When set, the item is added only if the vendor profile accepts it or passes its own accept check; otherwise returns -1.</param>
    /// <param name="broadcast">Flag for broadcasting the addition (unused in this implementation).</param>
    /// <param name="quantityDisp">Quantity to display; unused here.</param>
    /// <returns>The index at which the item was inserted, or -1 if the operation failed.</returns>
    public int AddItem(ACBindings.Internal.UIElement_ItemList* uiItemList, uint itemID, int position, int removeDuplicates, int addContents, int excludeIfUnacceptable, int broadcast, int quantityDisp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.UIElement_ItemList*, uint, int, int, int, int, int, int, int>)0x004C20A0)(ref this, uiItemList, itemID, position, removeDuplicates, addContents, excludeIfUnacceptable, broadcast, quantityDisp);

    /// <summary>Initializes a vendor UI element with the specified layout and element descriptions, setting up internal state and clearing vendor data.
    /// <code>Offset: 0x004C3060
    /// void __thiscall gmVendorUI::gmVendorUI(gmVendorUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining display parameters for the UI panel.</param>
    /// <param name="full_desc">Element descriptor containing detailed configuration of the UI component.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004C3060)(ref this, layout, full_desc);

    /// <summary>Returns a UIElement pointer corresponding to the requested type when casting from gmVendorUI, yielding either its base UIElement or the object itself for specific type codes.
    /// <code>Offset: 0x004C3130
    /// UIElement* __thiscall gmVendorUI::DynamicCast(gmVendorUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier of the desired element type; 268435479 selects the UIElement base and 3 selects the full gmVendorUI as a UIElement.</param>
    /// <returns>Pointer to the requested UIElement if the type matches, otherwise null.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, ACBindings.Internal.UIElement*>)0x004C3130)(ref this, i_eType);

    /// <summary>Provides the unique UI element type identifier for the vendor interface.
    /// <code>Offset: 0x004C3150
    /// unsigned int __thiscall gmVendorUI::GetUIElementType(gmVendorUI*)</code>
    /// </summary>
    /// <returns>The constant representing this UI element's type (268435479).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint>)0x004C3150)(ref this);

    /// <summary>Destroys a gmVendorUI instance by releasing owned UI components, unregistering all event and object‑range handlers, flushing internal item lists, and freeing allocated resources.
    /// <code>Offset: 0x004C3160
    /// void __thiscall gmVendorUI::~gmVendorUI(gmVendorUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, void>)0x004C3160)(ref this);

    /// <summary>Resets the vendor UI's internal shop state, clearing sold items, item profiles, and releasing associated resources. When called with updating set to false, it performs a complete reset of all shop data.
    /// <code>Offset: 0x004C32C0
    /// void __thiscall gmVendorUI::ResetShopState(gmVendorUI*,bool)</code>
    /// </summary>
    /// <param name="updating">Determines whether to perform a full reset (false) or only update certain aspects (true).</param>
    public void ResetShopState(byte updating) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, byte, void>)0x004C32C0)(ref this, updating);

    /// <summary>Attempts to purchase one unit of the specified item from the current vendor, validating the player’s available currency and inventory capacity before completing the transaction.
    /// <code>Offset: 0x004C3410
    /// bool __thiscall gmVendorUI::BuySingleItem(gmVendorUI*,unsigned int)</code>
    /// </summary>
    /// <param name="ID">The unique identifier of the item requested for purchase.</param>
    /// <returns>True if the purchase was successful; otherwise false.</returns>
    public byte BuySingleItem(uint ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, byte>)0x004C3410)(ref this, ID);

    /// <summary>Attempts to sell one unit of the item identified by ID from the vendor interface, ensuring the item is eligible for sale before queuing a trade event.
    /// <code>Offset: 0x004C3730
    /// bool __thiscall gmVendorUI::SellSingleItem(gmVendorUI*,unsigned int)</code>
    /// </summary>
    /// <param name="ID">The unique identifier of the item to be sold.</param>
    /// <returns>True if the sale request was successfully queued; otherwise false and a notice informs the player of why the sale failed.</returns>
    public byte SellSingleItem(uint ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, byte>)0x004C3730)(ref this, ID);

    /// <summary>Clears the target UI list and copies items from the source inventory into it, optionally normalizing stack sizes and setting sell state for eligible items.
    /// <code>Offset: 0x004C38F0
    /// void __stdcall gmVendorUI::AdoptAsContents(UIElement_ItemList*,int,char)</code>
    /// </summary>
    /// <param name="a1">The UIItemList to populate; if null, item insertion is skipped but stack updates still occur.</param>
    /// <param name="a2">Pointer or handle to the source item collection from which items are adopted.</param>
    /// <param name="a3">Flag indicating whether to adjust stackable items' stack size and value before adding them to the list.</param>
    public static void AdoptAsContents(ACBindings.Internal.UIElement_ItemList* a1, int a2, sbyte a3) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.UIElement_ItemList*, int, sbyte, void>)0x004C38F0)(a1, a2, a3);

    /// <summary>Constructs an error message indicating that the required components are missing or insufficient for a vendor transaction, writing the formatted text into the supplied buffer.
    /// <code>Offset: 0x004C3A80
    /// LONG __stdcall gmVendorUI::AddMissingComp(char*,char**)</code>
    /// </summary>
    /// <param name="Source">Pointer to a char buffer that will receive the constructed message. The function overwrites this location with the resulting string.</param>
    /// <param name="a2">Pointer to a component name string (or list) that is appended to the message, prefixed appropriately by “There was not enough:” or a comma separator.</param>
    /// <returns>Returns a LONG value representing the reference count after cleaning up temporary strings; zero indicates all resources were released.</returns>
    public static int AddMissingComp(sbyte* Source, sbyte** a2) => ((delegate* unmanaged[Stdcall]<sbyte*, sbyte**, int>)0x004C3A80)(Source, a2);

    /// <summary>Registers the vendor UI element class with the UI framework, associating it with a unique identifier and a layout constructor.
    /// <code>Offset: 0x004C3BF0
    /// void __cdecl gmVendorUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004C3BF0)();

    /// <summary>Closes the vendor interface, cleaning up sub‑UIs and unregistering event handlers as needed.
    /// <code>Offset: 0x004C3C10
    /// void __thiscall gmVendorUI::CloseVendor(gmVendorUI*,bool)</code>
    /// </summary>
    /// <param name="updating">When true, skips closing sub‑UI panels and only resets state; otherwise fully closes all vendor UI components before resetting.</param>
    public void CloseVendor(byte updating) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, byte, void>)0x004C3C10)(ref this, updating);

    /// <summary>Handles cleanup after closing the vendor UI dialog by examining result properties, sending a close notice if required, decrementing reference counts on related objects, and clearing the current dialog context.
    /// <code>Offset: 0x004C3C70
    /// void __cdecl gmVendorUI::CloseVendorDialogCallback(const PropertyCollection*)</code>
    /// </summary>
    /// <param name="i_rcResults">A collection of properties returned from the dialog closure operation.</param>
    public static void CloseVendorDialogCallback(ACBindings.Internal.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void>)0x004C3C70)(i_rcResults);

    /// <summary>Handles visibility changes of the vendor UI by closing sub‑UI components and cleaning up when it becomes hidden. It unregisters event handlers, resets shop state, closes dialogs, and updates global systems accordingly.
    /// <code>Offset: 0x004C4410
    /// void __thiscall gmVendorUI::OnVisibilityChanged(gmVendorUI*,bool)</code>
    /// </summary>
    /// <param name="i_bVisible">True if the vendor UI is now visible; false otherwise.</param>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, byte, void>)0x004C4410)(ref this, i_bVisible);

    /// <summary>Handles mouse press events within the vendor interface, determining which item list was clicked and performing actions such as buying items or updating shopping lists.
    /// <code>Offset: 0x004C4CC0
    /// void __thiscall gmVendorUI::HandleMousePresses(gmVendorUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">The gmVendorUI instance handling the event.</param>
    /// <param name="i_rMsg">Information about the UI element message that triggered the event.</param>
    public void HandleMousePresses(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.UIElementMessageInfo*, void>)0x004C4CC0)(ref this, i_rMsg);

    /// <summary>Prepares an item for dragging from the vendor's item list by resetting its sell state, removing it from the internal profile list, updating the UI, and preventing split actions when appropriate.
    /// <code>Offset: 0x004C4F70
    /// void __thiscall gmVendorUI::RecvNotice_ItemListBeginDrag(gmVendorUI*,const UIElement*,int)</code>
    /// </summary>
    /// <param name="i_itemList">The UI element that contains the list of items where the drag was initiated.</param>
    /// <param name="i_slotNum">Index of the selected slot within that list.</param>
    public void RecvNotice_ItemListBeginDrag(ACBindings.Internal.UIElement* i_itemList, int i_slotNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.UIElement*, int, void>)0x004C4F70)(ref this, i_itemList, i_slotNum);

    /// <summary>Handles server move notices for items in the vendor UI, removing any item that is no longer owned by a player from the sell list and refreshing the UI accordingly.
    /// <code>Offset: 0x004C5090
    /// void __thiscall gmVendorUI::RecvNotice_ServerSaysMoveItem(gmVendorUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">Unique identifier of the moved item.</param>
    /// <param name="oldContainer">Identifier of the item's previous container.</param>
    /// <param name="oldWielder">Identifier of the entity who previously wielded the item.</param>
    /// <param name="oldLocation">Previous location index of the item.</param>
    /// <param name="newContainer">Identifier of the item's new container.</param>
    /// <param name="place">Target placement position within the new container.</param>
    /// <param name="newWielder">Identifier of the entity that now wields the item.</param>
    /// <param name="newLocation">New location index of the item.</param>
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004C5090)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>Handles a notification that an item's attributes have changed, updating the vendor's sell list when the item matches the currently split item and its attributes meet expected conditions.
    /// <code>Offset: 0x004C50E0
    /// void __thiscall gmVendorUI::RecvNotice_ItemAttributesChanged(gmVendorUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_target">The identifier of the item whose attributes were modified.</param>
    /// <param name="i_attrib">Bitmask indicating which attributes changed; flag 1 is examined to trigger a stack‑size update.</param>
    public void RecvNotice_ItemAttributesChanged(uint i_target, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, uint, void>)0x004C50E0)(ref this, i_target, i_attrib);

    /// <summary>Adjusts vendor UI when stack slider changes by refreshing item listings if the selected item is present.
    /// <code>Offset: 0x004C50F0
    /// void __thiscall gmVendorUI::RecvNotice_StackSliderChanged(gmVendorUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_splitSize">The new stack split size chosen by the user.</param>
    /// <param name="i_maxSplitSize">The maximum allowable split size for the item.</param>
    public void RecvNotice_StackSliderChanged(uint i_splitSize, uint i_maxSplitSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, uint, void>)0x004C50F0)(ref this, i_splitSize, i_maxSplitSize);

    /// <summary>Populates the vendor’s buy list with spell components matching the requested category, respecting the maximum spending limit supplied.
    /// <code>Offset: 0x004C5130
    /// void __thiscall gmVendorUI::FillComponentList(gmVendorUI*,SpellComponentCategory,int)</code>
    /// </summary>
    /// <param name="sp_cat">The desired spell component category to filter by; Undef_SpellComponentCategory matches all categories.</param>
    /// <param name="max_to_spend">Maximum total cost of items to add to the buy list; zero indicates no limit.</param>
    public void FillComponentList(ACBindings.Internal.SpellComponentCategory sp_cat, int max_to_spend) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.SpellComponentCategory, int, void>)0x004C5130)(ref this, sp_cat, max_to_spend);

    /// <summary>Recomputes the vendor’s total value from the current player descriptor and refreshes associated UI panels for items, buying, and selling.
    /// <code>Offset: 0x004C54D0
    /// void __thiscall gmVendorUI::UpdateTotalValue(gmVendorUI*)</code>
    /// </summary>
    public void UpdateTotalValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, void>)0x004C54D0)(ref this);

    /// <summary>Adds an item identified by its ID to the vendor's sell list and updates the UI accordingly.
    /// <code>Offset: 0x004C56B0
    /// void __thiscall gmVendorUI::RecvNotice_AddItemToSell(gmVendorUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_itemID">The identifier of the item to be added for sale.</param>
    public void RecvNotice_AddItemToSell(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, void>)0x004C56B0)(ref this, i_itemID);

    /// <summary>Populates the vendor UI’s component buy list for a given spell component category, limiting the number of items added to a specified maximum.
    /// <code>Offset: 0x004C56C0
    /// void __thiscall gmVendorUI::RecvNotice_FillComponentBuyList(gmVendorUI*,SpellComponentCategory,int)</code>
    /// </summary>
    /// <param name="i_sp_cat">The spell component category that determines which components appear in the buy list.</param>
    /// <param name="i_max_to_buy">The maximum quantity of each component type to include in the buy list.</param>
    public void RecvNotice_FillComponentBuyList(ACBindings.Internal.SpellComponentCategory i_sp_cat, int i_max_to_buy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.SpellComponentCategory, int, void>)0x004C56C0)(ref this, i_sp_cat, i_max_to_buy);

    /// <summary>Responds to quality or stat changes for items in a vendor interface, updating totals and adjusting selections as needed.
    /// <code>Offset: 0x004C56D0
    /// void __thiscall gmVendorUI::OnQualityChanged(gmVendorUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="cwobj">The object whose stats changed.</param>
    /// <param name="stype">The type of stat that changed.</param>
    /// <param name="senum">The new value associated with the stat change.</param>
    public void OnQualityChanged(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x004C56D0)(ref this, cwobj, stype, senum);

    /// <summary>Updates the vendor UI's total value when a relevant quality is removed, such as currency changes or specific stat types.
    /// <code>Offset: 0x004C5750
    /// void __thiscall gmVendorUI::OnQualityRemoved(gmVendorUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="cwobj">The object whose quality was removed.</param>
    /// <param name="stype">The statistical type affected by the change.</param>
    /// <param name="senum">Enum indicating the particular quality removed; used to determine whether a total value update is necessary.</param>
    public void OnQualityRemoved(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x004C5750)(ref this, cwobj, stype, senum);

    /// <summary>Opens the vendor interface for a specified vendor ID using supplied vendor data, initializing the vendor profile and item lists, and displaying the appropriate panel tab.
    /// <code>Offset: 0x004C5790
    /// int __thiscall gmVendorUI::OpenVendor(gmVendorUI*,_DWORD*,TResult,int,int)</code>
    /// </summary>
    /// <param name="responseObjID">Vendor identifier used to open the interface.</param>
    /// <param name="result">Result structure containing vendor profile information.</param>
    /// <param name="a4">Pointer to a list of item profiles for the shop.</param>
    /// <param name="a5">Index indicating which panel tab should be opened (e.g., 2 or 3).</param>
    /// <returns>The result code from opening the vendor UI components.</returns>
    public int OpenVendor(int* responseObjID, ACBindings.Internal.TResult result, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, int*, ACBindings.Internal.TResult, int, int, int>)0x004C5790)(ref this, responseObjID, result, a4, a5);

    /// <summary>Handles button click events for the vendor UI, performing actions such as buying or selling single items, adding items to purchase/sell lists, validating transactions, updating interface elements, and displaying error notices when necessary.
    /// <code>Offset: 0x004C5CC0
    /// void __thiscall gmVendorUI::HandleButtonClicks(gmVendorUI*,unsigned int)</code>
    /// </summary>
    /// <param name="this">The gmVendorUI instance handling the event.</param>
    /// <param name="elementID">Identifier of the clicked UI element, determining which vendor operation to perform.</param>
    public void HandleButtonClicks(uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, void>)0x004C5CC0)(ref this, elementID);

    /// <summary>Handles drop release events on the vendor UI by processing dragged items over the sell shop list and accepting valid sales.
    /// <code>Offset: 0x004C6270
    /// void __thiscall gmVendorUI::HandleDropRelease(gmVendorUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the message associated with the drag-and-drop operation, including source and target elements.</param>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.UIElementMessageInfo*, void>)0x004C6270)(ref this, i_rMsg);

    /// <summary>Handles a vendor opening notice by invoking OpenVendor on the gmVendorUI instance with supplied parameters.
    /// <code>Offset: 0x004C62E0
    /// int __thiscall gmVendorUI::RecvNotice_OpenVendor(char*,_DWORD*,TResult,int,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to data required for opening the vendor, such as vendor information or context.</param>
    /// <param name="a3">Result indicator or status code associated with the notice.</param>
    /// <param name="a4">Additional integer parameter used by OpenVendor (e.g., flags or identifiers).</param>
    /// <param name="a5">Further integer parameter for OpenVendor (e.g., user ID or session info).</param>
    /// <returns>The return value from gmVendorUI::OpenVendor, indicating success or failure.</returns>
    public int RecvNotice_OpenVendor(int* a2, ACBindings.Internal.TResult a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, int*, ACBindings.Internal.TResult, int, int, int>)0x004C62E0)(ref this, a2, a3, a4, a5);

    /// <summary>Processes vendor interface events by routing messages such as mouse presses, button clicks, and page changes to the appropriate handlers or updating item lists, then forwards the message to the base element handler.
    /// <code>Offset: 0x004C62F0
    /// UIElementMessageListenResult __thiscall gmVendorUI::ListenToElementMessage(gmVendorUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI event, including its ID, originating element, and parameters.</param>
    /// <returns>The result of the underlying UIElement's message handling indicating whether the event was consumed.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004C62F0)(ref this, i_rMsg);
}

