namespace ACBindings.Internal;


/// <summary>Represents a scrollable list of UI items used for inventory, containers, vendor sales, and spell shortcuts in the game’s user interface.</summary>
/// <remarks>This structure extends UIElement_ListBox to provide item‑specific logic such as drag‑and‑drop handling, single selection enforcement, open‑container tracking, and cached reusable UIItem instances. It maintains state about its parent container, child list, scrolling parameters, and various flags that control interaction behavior.</remarks>
public unsafe struct UIElement_ItemList : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_ListBox BaseClass_UIElement_ListBox; // ACBindings.Internal.UIElement_ListBox
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct UIElement_ItemList_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> StartUpActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> EndUpActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> StartDownActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> EndDownActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> StartLeftActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> EndLeftActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> StartRightActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> EndRightActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, void> UpdateLayout; // function pointer

        // Methods
    }

    // Members
    public uint parentContainerID;
    public uint openItemID;
    public uint removedItemID;
    public ACBindings.Internal.UIElement_ItemList* childList;
    public ACBindings.Internal.UIElement_ItemList* parentList;
    public byte containerList;
    public byte vendorItemList;
    public byte shortcutList;
    public byte salvageList;
    public ACBindings.Internal.UIElement_UIItem* m_pendingItem;
    public int m_cellW;
    public int m_cellH;
    public ACBindings.Internal.List___UIElement_UIItem_ptr m_listUIItemCache;
    public ACBindings.Internal.ItemListDragHandler* m_dragHandler;
    public byte m_singleSelection;
    public byte m_dragScrollItemScrolling;
    public byte m_dragScrollSpellScrolling;
    public byte m_dragScrollVertical;
    public byte m_dragScrollHorizontal;
    public int m_dragScrollMarginWidth;
    public int m_dragScrollMarginHeight;
    public byte m_inDragScrollRegion;
    public int m_dragScrollJumpDistance;
    public float m_dragScrollDelay;
    public double m_nextDragScrollTime;

    // Generated Constructor
    public UIElement_ItemList(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Determines if the item list is an alias type, such as a vendor, salvage, or shortcut list.
    /// <code>Offset: 0x004E3130
    /// bool __thiscall UIElement_ItemList::IsAliasList(UIElement_ItemList*)</code>
    /// </summary>
    /// <returns>True when the list represents a vendor, salvage, or shortcut collection; otherwise false.</returns>
    public byte IsAliasList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, byte>)0x004E3130)(ref this);

    /// <summary>Executes the current target mode for a UI item when left‑clicked, handling spells and items accordingly.
    /// <code>Offset: 0x004E3160
    /// void __thiscall UIElement_ItemList::HandleTargetedUseLeftClick(UIElement_ItemList*,UIElement_UIItem*)</code>
    /// </summary>
    /// <param name="item">The UI item that was clicked; may contain a spell or item ID.</param>
    public void HandleTargetedUseLeftClick(ACBindings.Internal.UIElement_UIItem* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement_UIItem*, void>)0x004E3160)(ref this, item);

    /// <summary>Assigns the specified item list as the child of this UIElement_ItemList.
    /// <code>Offset: 0x004E31C0
    /// void __thiscall UIElement_ItemList::ItemList_SetChildList(UIElement_ItemList*,UIElement_ItemList*)</code>
    /// </summary>
    /// <param name="childList">The item list that becomes the child of this list.</param>
    public void ItemList_SetChildList(ACBindings.Internal.UIElement_ItemList* childList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement_ItemList*, void>)0x004E31C0)(ref this, childList);

    /// <summary>Registers the list to receive global drag‑start notices when a drag operation begins on an item or spell, based on internal state and alias status.
    /// <code>Offset: 0x004E31D0
    /// void __thiscall UIElement_ItemList::RecvNotice_BeginDrag(UIElement_ItemList*,unsigned int,unsigned int,bool)</code>
    /// </summary>
    /// <param name="i_itemID">Identifier of the dragged item; zero indicates no item.</param>
    /// <param name="i_spellID">Identifier of the associated spell; zero if none.</param>
    /// <param name="i_bIsAlias">True if the drag source is an alias, preventing registration for item drags.</param>
    public void RecvNotice_BeginDrag(uint i_itemID, uint i_spellID, byte i_bIsAlias) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, uint, byte, void>)0x004E31D0)(ref this, i_itemID, i_spellID, i_bIsAlias);

    /// <summary>Assigns the specified drag handler to the item list, enabling drag functionality.
    /// <code>Offset: 0x004E3220
    /// void __thiscall UIElement_ItemList::RegisterItemListDragHandler(UIElement_ItemList*,ItemListDragHandler*)</code>
    /// </summary>
    /// <param name="handler">The ItemListDragHandler instance to use for drag operations.</param>
    public void RegisterItemListDragHandler(ACBindings.Internal.ItemListDragHandler* handler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.ItemListDragHandler*, void>)0x004E3220)(ref this, handler);

    /// <summary>Unregisters the drag handler associated with this item list.
    /// <code>Offset: 0x004E3230
    /// void __thiscall UIElement_ItemList::UnregisterItemListDragHandler(UIElement_ItemList*)</code>
    /// </summary>
    public void UnregisterItemListDragHandler() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E3230)(ref this);

    /// <summary>Sets the supplied UI item as the list’s pending item, replacing any previously stored pending item.
    /// <code>Offset: 0x004E3240
    /// void __thiscall UIElement_ItemList::SetAsPendingItem(UIElement_ItemList*,UIElement_UIItem*)</code>
    /// </summary>
    /// <param name="pendingItem">The UI element to designate as pending within this item list.</param>
    public void SetAsPendingItem(ACBindings.Internal.UIElement_UIItem* pendingItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement_UIItem*, void>)0x004E3240)(ref this, pendingItem);

    /// <summary>Deletes any pending item in the list, clearing its contents and resetting its state to the default value.
    /// <code>Offset: 0x004E3250
    /// void __thiscall UIElement_ItemList::DeletePendingItem(UIElement_ItemList*)</code>
    /// </summary>
    public void DeletePendingItem() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E3250)(ref this);

    /// <summary>Determines which edge of the item list should trigger a drag‑scroll based on screen coordinates.
    /// <code>Offset: 0x004E3280
    /// int __thiscall UIElement_ItemList::WhatDragScrollRegion(UIElement_ItemList*,int,int)</code>
    /// </summary>
    /// <param name="xPos">Screen X coordinate to test against the list's bounds.</param>
    /// <param name="yPos">Screen Y coordinate to test against the list's bounds.</param>
    /// <returns>Zero if the point is outside any scroll region; 1 for top vertical edge, 2 for bottom vertical edge, 3 for left horizontal edge, or 4 for right horizontal edge.</returns>
    public int WhatDragScrollRegion(int xPos, int yPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, int, int, int>)0x004E3280)(ref this, xPos, yPos);

    /// <summary>Queries a drop icon element to retrieve the associated item ID, spell ID and drop flags.
    /// <code>Offset: 0x004E3380
    /// void __cdecl UIElement_ItemList::InqDropIconInfo(const UIElement*,unsigned int*,unsigned int*,DropItemFlags*)</code>
    /// </summary>
    /// <param name="dropIcon">The UIElement representing the drop target; if null no information is retrieved.</param>
    /// <param name="itemID">Pointer to an unsigned int that will receive the item identifier (0 if none).</param>
    /// <param name="spellID">Pointer to an unsigned int that will receive the spell identifier (0 if none).</param>
    /// <param name="flags">Pointer to a DropItemFlags value that will be populated with flags describing the drop action, such as whether an item or spell is present.</param>
    public static void InqDropIconInfo(ACBindings.Internal.UIElement* dropIcon, uint* itemID, uint* spellID, ACBindings.Internal.DropItemFlags* flags) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIElement*, uint*, uint*, ACBindings.Internal.DropItemFlags*, void>)0x004E3380)(dropIcon, itemID, spellID, flags);

    /// <summary>
    /// Prepares the drag icon for a UI item by configuring its image and properties based on whether the item is an object or spell, and updates contextual flags such as container status, vendor, shortcut, and salvage states.
    /// 
    /// <code>Offset: 0x004E36E0
    /// bool __thiscall UIElement_ItemList::PrepareDragIcon(UIElement_ItemList*,UIElement_UIItem*)</code>
    /// </summary>
    /// <param name="this">The UIElement_ItemList instance that initiates the drag operation.</param>
    /// <param name="item">The UIElement_UIItem representing the item to be dragged.</param>
    /// <returns>True if a drag icon is successfully set up; false if no icon can be prepared or the item has neither an object ID nor a spell ID.</returns>
    public byte PrepareDragIcon(ACBindings.Internal.UIElement_UIItem* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement_UIItem*, byte>)0x004E36E0)(ref this, item);

    /// <summary>Checks whether an item with the given identifier exists in this list.
    /// <code>Offset: 0x004E3B60
    /// int __thiscall UIElement_ItemList::ItemList_IsInList(UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">The identifier of the item to locate.</param>
    /// <returns>Non-zero (true) if the item is present; zero (false) otherwise.</returns>
    public int ItemList_IsInList(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, int>)0x004E3B60)(ref this, itemID);

    /// <summary>Returns the UIElement_UIItem whose itemID matches the supplied identifier, or null if no match is found.
    /// <code>Offset: 0x004E3BC0
    /// UIElement_UIItem* __thiscall UIElement_ItemList::ItemList_GetItem(UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    /// <param name="this">The UIElement_ItemList instance containing the items.</param>
    /// <param name="i_iidItem">Identifier of the item to retrieve.</param>
    /// <returns>Pointer to the matching UIElement_UIItem; null when the list is empty or the ID does not exist.</returns>
    public ACBindings.Internal.UIElement_UIItem* ItemList_GetItem(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, ACBindings.Internal.UIElement_UIItem*>)0x004E3BC0)(ref this, i_iidItem);

    /// <summary>Counts UI items in the list that exist and are not marked with the inactive state code (268435484).
    /// <code>Offset: 0x004E3C10
    /// int __thiscall UIElement_ItemList::GetNumUIItems(UIElement_ItemList*)</code>
    /// </summary>
    /// <returns>The number of active UI items.</returns>
    public int GetNumUIItems() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, int>)0x004E3C10)(ref this);

    /// <summary>Updates the selection state of items in an item list by clearing the previously selected item and marking a new item as selected, if it exists.
    /// <code>Offset: 0x004E3C70
    /// void __thiscall UIElement_ItemList::ItemList_SetSelectedItem(UIElement_ItemList*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="oldSelectedID">The ID of the item that was previously selected and should be deselected.</param>
    /// <param name="selectedID">The ID of the item to select; zero indicates no selection.</param>
    public void ItemList_SetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, uint, void>)0x004E3C70)(ref this, oldSelectedID, selectedID);

    /// <summary>Updates the visual indicator for container items, setting them as open when their ID matches the specified containerID and marking all others closed.
    /// <code>Offset: 0x004E3D00
    /// void __thiscall UIElement_ItemList::UpdateOpenContainerIndicator(UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    /// <param name="containerID">Identifier of the container to mark as open; zero clears all indicators.</param>
    public void UpdateOpenContainerIndicator(uint containerID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, void>)0x004E3D00)(ref this, containerID);

    /// <summary>Tracks drag scrolling while an item is being dragged within the list, automatically scrolling when the dragged position approaches the list edges. It throttles scroll events using a delay timer and updates horizontal or vertical scrolling based on which edge region is reached.
    /// <code>Offset: 0x004E3D60
    /// void __thiscall UIElement_ItemList::TrackDragScrolling(UIElement_ItemList*)</code>
    /// </summary>
    public void TrackDragScrolling() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E3D60)(ref this);

    /// <summary>
    /// Collects available properties for the item list UI element into the supplied set, delegating first to the underlying list box and then augmenting with additional master‑level properties. The function returns true only if the base list box added at least one property; it returns false if no properties were added or if the set pointer is null.
    /// <code>Offset: 0x004E3E70
    /// bool __thiscall UIElement_ItemList::InqAvailableProperties(UIElement_ItemList*,AvailablePropertySet*)</code>
    /// </summary>
    /// <param name="set">The AvailablePropertySet instance that receives the collected properties; may be null, in which case the method returns false.</param>
    /// <returns>True if the base class contributed any properties; otherwise false.</returns>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.AvailablePropertySet*, byte>)0x004E3E70)(ref this, set);

    /// <summary>Handles global message 3 to start or stop drag‑scroll processing for the item list, unregistering when no longer needed.
    /// <code>Offset: 0x004E3EB0
    /// void __thiscall UIElement_ItemList::ListenToGlobalMessage(UIElement_ItemList*,unsigned int,int)</code>
    /// </summary>
    /// <param name="this">The UIElement_ItemList instance receiving the message.</param>
    /// <param name="messageID">Identifier of the received global message; only ID 3 is processed.</param>
    /// <param name="data_int">Additional data attached to the message (unused in this handler).</param>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, int, void>)0x004E3EB0)(ref this, messageID, data_int);

    /// <summary>Ensures that only one UIItem is selected in a list by deselecting all other items with the same itemID before marking the specified item as selectable and selected.
    /// <code>Offset: 0x004E3EE0
    /// void __thiscall UIElement_ItemList::HandleSingleSelection(UIElement_ItemList*,UIElement_UIItem*)</code>
    /// </summary>
    /// <param name="item">The UIItem to select.</param>
    public void HandleSingleSelection(ACBindings.Internal.UIElement_UIItem* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement_UIItem*, void>)0x004E3EE0)(ref this, item);

    /// <summary>Starts a drag‑and‑drop operation for the item located at the specified screen coordinates, if dragging is permitted.
    /// <code>Offset: 0x004E3F60
    /// void __thiscall UIElement_ItemList::ItemList_BeginDrag(UIElement_ItemList*,int,int)</code>
    /// </summary>
    /// <param name="x">The screen X coordinate where the drag begins.</param>
    /// <param name="y">The screen Y coordinate where the drag begins.</param>
    public void ItemList_BeginDrag(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, int, int, void>)0x004E3F60)(ref this, x, y);

    /// <summary>Handles the drag‑over event for an item list by evaluating whether the dragged element can be accepted on the target slot and setting the appropriate accept state.
    /// <code>Offset: 0x004E4090
    /// void __thiscall UIElement_ItemList::ItemList_DragOver(UIElement_ItemList*,UIElement*,UIElement_UIItem*)</code>
    /// </summary>
    /// <param name="dragElement">The UI element currently being dragged.</param>
    /// <param name="catchElement">The item slot over which the dragged element is hovering.</param>
    public void ItemList_DragOver(ACBindings.Internal.UIElement* dragElement, ACBindings.Internal.UIElement_UIItem* catchElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement_UIItem*, void>)0x004E4090)(ref this, dragElement, catchElement);

    /// <summary>Removes an item from the listbox, caches it for reuse, and reports success.
    /// <code>Offset: 0x004E41C0
    /// bool __thiscall UIElement_ItemList::InternalDeleteItem(UIElement_ItemList*,UIElement_UIItem*)</code>
    /// </summary>
    /// <param name="item">The UI item to remove from this ItemList.</param>
    /// <returns>True if the item was present and removed; otherwise false.</returns>
    public byte InternalDeleteItem(ACBindings.Internal.UIElement_UIItem* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement_UIItem*, byte>)0x004E41C0)(ref this, item);

    /// <summary>
    /// Handles a selection change notice by updating the item list’s selected item state.
    /// 
    /// <code>Offset: 0x004E41F0
    /// void __thiscall UIElement_ItemList::RecvNotice_SetSelectedItem(UIElement_ItemList*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="oldSelectedID">The ID of the previously selected item.</param>
    /// <param name="selectedID">The ID of the newly selected item.</param>
    public void RecvNotice_SetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, uint, void>)0x004E41F0)(ref this, oldSelectedID, selectedID);

    /// <summary>Creates or reuses an item for the list. If a cached item is available it is reset and returned; otherwise a new UI element is instantiated from layout data defined by the list’s attributes, initialized, and returned.
    /// <code>Offset: 0x004E4200
    /// UIElement_UIItem* __thiscall UIElement_ItemList::InternalCreateItem(UIElement_ItemList*)</code>
    /// </summary>
    /// <returns>A pointer to the prepared UIElement_UIItem, or nullptr if creation fails.</returns>
    public ACBindings.Internal.UIElement_UIItem* InternalCreateItem() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement_UIItem*>)0x004E4200)(ref this);

    /// <summary>Assigns the specified list as the parent of this item list. If the existing parent differs from the new one, any open item in the old parent is closed and its indicator updated.
    /// <code>Offset: 0x004E42E0
    /// void __thiscall UIElement_ItemList::ItemList_SetParentList(UIElement_ItemList*,UIElement_ItemList*)</code>
    /// </summary>
    /// <param name="newParent">The UIElement_ItemList to set as the new parent.</param>
    public void ItemList_SetParentList(ACBindings.Internal.UIElement_ItemList* newParent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement_ItemList*, void>)0x004E42E0)(ref this, newParent);

    /// <summary>Adds a new empty item slot to the list at the specified position, appending it if no explicit index is provided.
    /// <code>Offset: 0x004E4340
    /// void __thiscall UIElement_ItemList::ItemList_AddEmptySlot(UIElement_ItemList*,int)</code>
    /// </summary>
    /// <param name="pos">Zero‑based insertion index; use -1 to add the slot at the end of the list.</param>
    public void ItemList_AddEmptySlot(int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, int, void>)0x004E4340)(ref this, pos);

    /// <summary>Synchronizes the list’s placeholder items with its visible area. Calculates how many item slots fit horizontally based on the element’s width and individual cell width, then removes excess placeholder items or creates new ones to fill unused space. Optionally ensures an empty slot at the end when requested by a custom attribute.
    /// <code>Offset: 0x004E4390
    /// void __thiscall UIElement_ItemList::UpdateEmptySlots(UIElement_ItemList*)</code>
    /// </summary>
    public void UpdateEmptySlots() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E4390)(ref this);

    /// <summary>Adjusts the item list to a fixed slot count specified by attribute 0x10000015, creating new slots or removing excess ones and caching removed items.
    /// <code>Offset: 0x004E45A0
    /// void __thiscall UIElement_ItemList::UpdateFixedSlots(UIElement_ItemList*)</code>
    /// </summary>
    public void UpdateFixedSlots() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E45A0)(ref this);

    /// <summary>
    /// Updates the list size attribute of this UI element by querying its parent container’s capacity.  
    /// If a valid (non‑negative) capacity is found, applies it and refreshes the fixed slots; otherwise marks the list as unavailable (-1) and updates empty slots.
    /// 
    /// <code>Offset: 0x004E4670
    /// void __thiscall UIElement_ItemList::ItemList_UpdateContainerListSize(UIElement_ItemList*)</code>
    /// </summary>
    public void ItemList_UpdateContainerListSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E4670)(ref this);

    /// <summary>Initializes a new item list UI element with the specified layout and element description, setting up default properties such as cell size and drag handlers.
    /// <code>Offset: 0x004E4730
    /// void __thiscall UIElement_ItemList::UIElement_ItemList(UIElement_ItemList*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining the visual arrangement of the UI component.</param>
    /// <param name="full_desc">Full element descriptor containing state information and child elements for the item list.</param>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004E4730)(ref this, layout, full_desc);

    /// <summary>Attempts to cast this UIElement_ItemList instance to the specified element type, returning either a pointer to its base UIElement or to the ItemList itself when the requested type matches known identifiers.
    /// <code>Offset: 0x004E4830
    /// UIElement* __thiscall UIElement_ItemList::DynamicCast(UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The numeric identifier of the target element type (e.g., 5, 268435505 for generic UIElement, 10 for UIElement_ItemList).</param>
    /// <returns>Pointer to the appropriate UIElement if the cast is valid; otherwise a null pointer.</returns>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, ACBindings.Internal.UIElement*>)0x004E4830)(ref this, i_eType);

    /// <summary>Retrieves the unique type identifier for this UI element, indicating it is an item list.
    /// <code>Offset: 0x004E4860
    /// unsigned int __thiscall UIElement_ItemList::GetUIElementType(UIElement_ItemList*)</code>
    /// </summary>
    /// <returns>An unsigned integer constant (268435505) representing the UIElement_ItemList type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint>)0x004E4860)(ref this);

    /// <summary>Destroys an item list UI element by unregistering it from global message handling, deleting cached items, flushing the underlying list box, and cleaning up associated notice handler resources.
    /// <code>Offset: 0x004E4870
    /// void __thiscall UIElement_ItemList::~UIElement_ItemList(UIElement_ItemList*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E4870)(ref this);

    /// <summary>Handles a visibility change for an item list by delegating to its base class and updating empty slots when the list becomes visible.
    /// <code>Offset: 0x004E4990
    /// void __thiscall UIElement_ItemList::OnVisibilityChanged(UIElement_ItemList*,bool)</code>
    /// </summary>
    /// <param name="i_bVisible">Indicates whether the element has become visible (true) or hidden (false).</param>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, byte, void>)0x004E4990)(ref this, i_bVisible);

    /// <summary>Resizes the item list to the specified width and height, delegating size handling to its base list box logic. If the empty‑slot flag is set, refreshes placeholder slots after resizing.
    /// <code>Offset: 0x004E49C0
    /// void __thiscall UIElement_ItemList::ResizeTo(UIElement_ItemList*,const int,const int)</code>
    /// </summary>
    /// <param name="width">Desired width in pixels.</param>
    /// <param name="height">Desired height in pixels.</param>
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, int, int, void>)0x004E49C0)(ref this, width, height);

    /// <summary>Flushes the item list by clearing any pending item, resetting all items in the base list to their default state, closing any open container, and updating empty‑slot tracking.
    /// <code>Offset: 0x004E49F0
    /// void __thiscall UIElement_ItemList::ItemList_Flush(UIElement_ItemList*)</code>
    /// </summary>
    public void ItemList_Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E49F0)(ref this);

    /// <summary>Adds an item with the specified ID to this item list, creating a new slot when necessary and reusing an existing empty entry if available. The function initializes the UI element, sets its selectable state based on single‑selection rules, updates its visual appearance, refreshes empty slots, and returns the resulting UIElement_UIItem.
    /// <code>Offset: 0x004E4A90
    /// UIElement_UIItem* __thiscall UIElement_ItemList::ItemList_AddItem(UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">The identifier of the item to add.</param>
    /// <returns>The UIElement_UIItem representing the newly added item, or null if the operation fails.</returns>
    public ACBindings.Internal.UIElement_UIItem* ItemList_AddItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, ACBindings.Internal.UIElement_UIItem*>)0x004E4A90)(ref this, itemID);

    /// <summary>Inserts a new item with the specified identifier into this item list at the given position, replacing any placeholder slot if present.
    /// <code>Offset: 0x004E4BD0
    /// UIElement_UIItem* __thiscall UIElement_ItemList::ItemList_InsertItem(UIElement_ItemList*,unsigned int,int)</code>
    /// </summary>
    /// <param name="itemID">Identifier of the item to insert.</param>
    /// <param name="pos">Index within the list where the item should be placed.</param>
    /// <returns>Pointer to the newly created UIElement_UIItem instance; null if insertion is not allowed or fails.</returns>
    public ACBindings.Internal.UIElement_UIItem* ItemList_InsertItem(uint itemID, int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, int, ACBindings.Internal.UIElement_UIItem*>)0x004E4BD0)(ref this, itemID, pos);

    /// <summary>Removes the list entry whose ID matches itemID, optionally restoring selectable state for single‑selection lists and caching the removed UI element before updating empty slot indicators.
    /// <code>Offset: 0x004E4C70
    /// void __thiscall UIElement_ItemList::ItemList_DeleteItem(UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">The identifier of the item to remove from the list.</param>
    public void ItemList_DeleteItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, void>)0x004E4C70)(ref this, itemID);

    /// <summary>Adds a spell shortcut to the item list, reusing an existing empty slot or creating a new one if necessary. The created or updated UIItem is initialized with the specified spell ID and marked as a shortcut.
    /// <code>Offset: 0x004E4D30
    /// UIElement_UIItem* __thiscall UIElement_ItemList::ItemList_AddSpellShortcut(UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    /// <param name="spellID">Identifier of the spell to add as a shortcut.</param>
    /// <returns>Pointer to the UIItem representing the added shortcut, or null if the operation failed (e.g., no available slot).</returns>
    public ACBindings.Internal.UIElement_UIItem* ItemList_AddSpellShortcut(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, ACBindings.Internal.UIElement_UIItem*>)0x004E4D30)(ref this, spellID);

    /// <summary>Inserts a spell shortcut into the list at the specified position, relocating any existing shortcut and ensuring an empty slot is present.
    /// <code>Offset: 0x004E4E40
    /// UIElement_UIItem* __thiscall UIElement_ItemList::ItemList_InsertSpellShortcut(UIElement_ItemList*,unsigned int,int)</code>
    /// </summary>
    /// <param name="spellID">The ID of the spell for which to create a shortcut.</param>
    /// <param name="pos">The index within the list where the shortcut should be inserted.</param>
    /// <returns>Pointer to the newly created UIElement_UIItem representing the shortcut, or null if insertion fails.</returns>
    public ACBindings.Internal.UIElement_UIItem* ItemList_InsertSpellShortcut(uint spellID, int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, int, ACBindings.Internal.UIElement_UIItem*>)0x004E4E40)(ref this, spellID, pos);

    /// <summary>Accepts a dragged item or container into the list, performing validity checks, merging with existing stacks, ensuring proper placement within containers or the main inventory, and handling special cases such as self‑containment or full capacity.
    /// <code>Offset: 0x004E4EE0
    /// bool __thiscall UIElement_ItemList::AcceptDragObject(UIElement_ItemList*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="i_itemID">The unique identifier of the object being dropped.</param>
    /// <param name="i_isContainer">True if the dragged object is a container; false for ordinary items.</param>
    /// <returns>True when the drop is accepted and the item is queued for insertion; otherwise false.</returns>
    public byte AcceptDragObject(uint i_itemID, byte i_isContainer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, byte, byte>)0x004E4EE0)(ref this, i_itemID, i_isContainer);

    /// <summary>Registers the item list UI element class with the UI system, enabling creation of item lists from layout descriptors.
    /// <code>Offset: 0x004E5400
    /// void __cdecl UIElement_ItemList::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004E5400)();

    /// <summary>Handles release of a dragged item onto this UI element list, attempting to accept the drop and resetting the object's state if it is not accepted.
    /// <code>Offset: 0x004E5420
    /// void __thiscall UIElement_ItemList::HandleDropRelease(UIElement_ItemList*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the drop event, including source element and parameters.</param>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElementMessageInfo*, void>)0x004E5420)(ref this, i_rMsg);

    /// <summary>Initializes the item list by reading configuration attributes, creating items accordingly, setting cell dimensions, adding them to the base listbox, and flushing the internal item cache.
    /// <code>Offset: 0x004E54C0
    /// void __thiscall UIElement_ItemList::InitItemList(UIElement_ItemList*)</code>
    /// </summary>
    public void InitItemList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E54C0)(ref this);

    /// <summary>Sets the parent container of an item list, updates its internal state, repopulates the list from the new container’s items or sub‑containers, and notifies the UI if the parent changes.
    /// <code>Offset: 0x004E5660
    /// void __thiscall UIElement_ItemList::ItemList_SetParentContainer(UIElement_ItemList*,unsigned int,int,int)</code>
    /// </summary>
    /// <param name="parentContainerID">The ID of the container to become the new parent. A zero value clears the current parent.</param>
    /// <param name="refresh">Flag indicating whether the list should be refreshed after setting the parent. (Currently unused.)</param>
    /// <param name="draw">Flag indicating whether the UI should redraw the list after updating. (Currently unused.)</param>
    public void ItemList_SetParentContainer(uint parentContainerID, int refresh, int draw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, int, int, void>)0x004E5660)(ref this, parentContainerID, refresh, draw);

    /// <summary>Opens a child container within the item list, updating scrolling and visual indicators as needed.
    /// <code>Offset: 0x004E5770
    /// int __thiscall UIElement_ItemList::ItemList_OpenContainer(UIElement_ItemList*,unsigned int,int)</code>
    /// </summary>
    /// <param name="containerID">Identifier of the container to open; a value of 0 causes failure.</param>
    /// <param name="checkIfInList">When non‑zero, validates that the specified container exists in the current list before attempting to open it.</param>
    /// <returns>1 if the container was opened successfully; 0 if the identifier is zero or invalid according to checkIfInList.</returns>
    public int ItemList_OpenContainer(uint containerID, int checkIfInList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, int, int>)0x004E5770)(ref this, containerID, checkIfInList);

    /// <summary>Opens the first container item in the list when an action occurs on it, initializing any child list and updating the open‑container indicator; if no valid container is selected, clears the current parent container.
    /// <code>Offset: 0x004E57F0
    /// void __thiscall UIElement_ItemList::ItemList_OpenFirstContainer(UIElement_ItemList*)</code>
    /// </summary>
    public void ItemList_OpenFirstContainer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E57F0)(ref this);

    /// <summary>
    /// Performs post‑initialization of the item list UI element by initializing its base scrollable component, registering relevant notice handlers with the global event system for item updates and changes, and then calling InitItemList to set up internal data structures.
    /// 
    /// <code>Offset: 0x004E5930
    /// void __thiscall UIElement_ItemList::PostInit(UIElement_ItemList*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E5930)(ref this);

    /// <summary>Handles UI element messages for an item list control. Processes click actions (message 28) to select items, open containers, examine objects or spells, and handles drop release events. For all other messages delegates to the base ListBox handler.
    /// <code>Offset: 0x004E59E0
    /// UIElementMessageListenResult __thiscall UIElement_ItemList::ListenToElementMessage(UIElement_ItemList*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information describing the event, including idMessage, parameters, and target element.</param>
    /// <returns>Result indicating whether the message was handled by this item list.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004E59E0)(ref this, i_rMsg);

    /// <summary>Refreshes the UI list when an item's attributes change, updating any matching UIItem and resetting the parent container if the changed item is that container.
    /// <code>Offset: 0x004E5C20
    /// void __thiscall UIElement_ItemList::ItemAttributesChanged(UIElement_ItemList*,unsigned int,int)</code>
    /// </summary>
    /// <param name="itemID">The identifier of the item whose attributes have been modified.</param>
    /// <param name="flags">A bitmask describing the type of changes; bit 0 indicates a change requiring the parent container to be refreshed.</param>
    public void ItemAttributesChanged(uint itemID, int flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, int, void>)0x004E5C20)(ref this, itemID, flags);

    /// <summary>Updates the UI list when an item moves between containers, adjusting parent container references and opening the container if the moved item is selected.
    /// <code>Offset: 0x004E5C90
    /// void __thiscall UIElement_ItemList::ServerSaysMoveItem(UIElement_ItemList*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">Unique identifier of the moved item.</param>
    /// <param name="oldContainer">Identifier of the item's previous container.</param>
    /// <param name="oldWielder">Identifier of the item's previous wielder (unused).</param>
    /// <param name="oldLocation">Previous location type of the item (unused).</param>
    /// <param name="newContainer">Identifier of the item's destination container.</param>
    /// <param name="place">Desired placement index within the new container (currently unused).</param>
    /// <param name="newWielder">Identifier of the item's new wielder (unused).</param>
    /// <param name="newLocation">New location type of the item (unused).</param>
    public void ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004E5C90)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>
    /// Responds to a server notification that an action attempt on a specific item has failed.  
    /// The function verifies whether the current parent container ID matches the reported item; if not, it scans the list's child items to locate the matching element and reestablishes the parent‑container linkage accordingly.  
    /// No change occurs when no match is found or when the list contains no items.
    /// 
    /// <code>Offset: 0x004E5D80
    /// void __thiscall UIElement_ItemList::RecvNotice_ServerSaysAttemptFailed(UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    /// <param name="i_itemID">The identifier of the item whose action was reported as failed by the server.</param>
    public void RecvNotice_ServerSaysAttemptFailed(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, void>)0x004E5D80)(ref this, i_itemID);

    /// <summary>Notifies the UI element list that an item's attributes have changed, delegating to internal handling logic.
    /// <code>Offset: 0x004E5D90
    /// void __thiscall UIElement_ItemList::RecvNotice_ItemAttributesChanged(UIElement_ItemList*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_target">Identifier of the target item whose attributes changed.</param>
    /// <param name="i_attrib">Bitmask or type specifying which attribute(s) changed.</param>
    public void RecvNotice_ItemAttributesChanged(uint i_target, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, uint, void>)0x004E5D90)(ref this, i_target, i_attrib);

    /// <summary>Handles a server notification that an item has moved from one container/location to another and delegates processing to the underlying move handler.
    /// <code>Offset: 0x004E5DA0
    /// void __thiscall UIElement_ItemList::RecvNotice_ServerSaysMoveItem(UIElement_ItemList*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_itemID">Identifier of the item being moved.</param>
    /// <param name="i_oldContainer">Id of the original container holding the item.</param>
    /// <param name="i_oldWielder">Id of the entity that originally wielded the item.</param>
    /// <param name="i_oldLocation">Original location identifier where the item resided.</param>
    /// <param name="i_newContainer">Target container id for the moved item.</param>
    /// <param name="i_place">Position index within the new container where the item should be placed.</param>
    /// <param name="i_newWielder">Id of the entity that will wield the item after the move.</param>
    /// <param name="i_newLocation">Target location identifier for the item in its new state.</param>
    public void RecvNotice_ServerSaysMoveItem(uint i_itemID, uint i_oldContainer, uint i_oldWielder, uint i_oldLocation, uint i_newContainer, int i_place, uint i_newWielder, uint i_newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004E5DA0)(ref this, i_itemID, i_oldContainer, i_oldWielder, i_oldLocation, i_newContainer, i_place, i_newWielder, i_newLocation);
}

