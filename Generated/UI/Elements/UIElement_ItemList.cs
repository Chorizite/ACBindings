namespace ACBindings.Internal;

public unsafe struct UIElement_ItemList : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_ListBox BaseClass_UIElement_ListBox; // ACBindings.Internal.UIElement_ListBox
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct UIElement_ItemList_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> StartUpActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> EndUpActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> StartDownActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> EndDownActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> StartLeftActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> EndLeftActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> StartRightActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, byte> EndRightActive; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIElement_ListBox*, void> UpdateLayout; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004E3130
    /// bool __thiscall UIElement_ItemList::IsAliasList(UIElement_ItemList*)</code>
    /// </summary>
    public byte IsAliasList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, byte>)0x004E3130)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E3160
    /// void __thiscall UIElement_ItemList::HandleTargetedUseLeftClick(UIElement_ItemList*,UIElement_UIItem*)</code>
    /// </summary>
    public void HandleTargetedUseLeftClick(ACBindings.Internal.UIElement_UIItem* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement_UIItem*, void>)0x004E3160)(ref this, item);

    /// <summary>
    /// <code>Offset: 0x004E31C0
    /// void __thiscall UIElement_ItemList::ItemList_SetChildList(UIElement_ItemList*,UIElement_ItemList*)</code>
    /// </summary>
    public void ItemList_SetChildList(ACBindings.Internal.UIElement_ItemList* childList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement_ItemList*, void>)0x004E31C0)(ref this, childList);

    /// <summary>
    /// <code>Offset: 0x004E31D0
    /// void __thiscall UIElement_ItemList::RecvNotice_BeginDrag(UIElement_ItemList*,unsigned int,unsigned int,bool)</code>
    /// </summary>
    public void RecvNotice_BeginDrag(uint i_itemID, uint i_spellID, byte i_bIsAlias) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, uint, byte, void>)0x004E31D0)(ref this, i_itemID, i_spellID, i_bIsAlias);

    /// <summary>
    /// <code>Offset: 0x004E3220
    /// void __thiscall UIElement_ItemList::RegisterItemListDragHandler(UIElement_ItemList*,ItemListDragHandler*)</code>
    /// </summary>
    public void RegisterItemListDragHandler(ACBindings.Internal.ItemListDragHandler* handler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.ItemListDragHandler*, void>)0x004E3220)(ref this, handler);

    /// <summary>
    /// <code>Offset: 0x004E3230
    /// void __thiscall UIElement_ItemList::UnregisterItemListDragHandler(UIElement_ItemList*)</code>
    /// </summary>
    public void UnregisterItemListDragHandler() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E3230)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E3240
    /// void __thiscall UIElement_ItemList::SetAsPendingItem(UIElement_ItemList*,UIElement_UIItem*)</code>
    /// </summary>
    public void SetAsPendingItem(ACBindings.Internal.UIElement_UIItem* pendingItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement_UIItem*, void>)0x004E3240)(ref this, pendingItem);

    /// <summary>
    /// <code>Offset: 0x004E3250
    /// void __thiscall UIElement_ItemList::DeletePendingItem(UIElement_ItemList*)</code>
    /// </summary>
    public void DeletePendingItem() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E3250)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E3280
    /// int __thiscall UIElement_ItemList::WhatDragScrollRegion(UIElement_ItemList*,int,int)</code>
    /// </summary>
    public int WhatDragScrollRegion(int xPos, int yPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, int, int, int>)0x004E3280)(ref this, xPos, yPos);

    /// <summary>
    /// <code>Offset: 0x004E3380
    /// void __cdecl UIElement_ItemList::InqDropIconInfo(const UIElement*,unsigned int*,unsigned int*,DropItemFlags*)</code>
    /// </summary>
    public static void InqDropIconInfo(ACBindings.Internal.UIElement* dropIcon, uint* itemID, uint* spellID, ACBindings.Internal.DropItemFlags* flags) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIElement*, uint*, uint*, ACBindings.Internal.DropItemFlags*, void>)0x004E3380)(dropIcon, itemID, spellID, flags);

    /// <summary>
    /// <code>Offset: 0x004E36E0
    /// bool __thiscall UIElement_ItemList::PrepareDragIcon(UIElement_ItemList*,UIElement_UIItem*)</code>
    /// </summary>
    public byte PrepareDragIcon(ACBindings.Internal.UIElement_UIItem* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement_UIItem*, byte>)0x004E36E0)(ref this, item);

    /// <summary>
    /// <code>Offset: 0x004E3B60
    /// int __thiscall UIElement_ItemList::ItemList_IsInList(UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    public int ItemList_IsInList(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, int>)0x004E3B60)(ref this, itemID);

    /// <summary>
    /// <code>Offset: 0x004E3BC0
    /// UIElement_UIItem* __thiscall UIElement_ItemList::ItemList_GetItem(UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_UIItem* ItemList_GetItem(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, ACBindings.Internal.UIElement_UIItem*>)0x004E3BC0)(ref this, i_iidItem);

    /// <summary>
    /// <code>Offset: 0x004E3C10
    /// int __thiscall UIElement_ItemList::GetNumUIItems(UIElement_ItemList*)</code>
    /// </summary>
    public int GetNumUIItems() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, int>)0x004E3C10)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E3C70
    /// void __thiscall UIElement_ItemList::ItemList_SetSelectedItem(UIElement_ItemList*,unsigned int,unsigned int)</code>
    /// </summary>
    public void ItemList_SetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, uint, void>)0x004E3C70)(ref this, oldSelectedID, selectedID);

    /// <summary>
    /// <code>Offset: 0x004E3D00
    /// void __thiscall UIElement_ItemList::UpdateOpenContainerIndicator(UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    public void UpdateOpenContainerIndicator(uint containerID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, void>)0x004E3D00)(ref this, containerID);

    /// <summary>
    /// <code>Offset: 0x004E3D60
    /// void __thiscall UIElement_ItemList::TrackDragScrolling(UIElement_ItemList*)</code>
    /// </summary>
    public void TrackDragScrolling() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E3D60)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E3E70
    /// bool __thiscall UIElement_ItemList::InqAvailableProperties(UIElement_ItemList*,AvailablePropertySet*)</code>
    /// </summary>
    public byte InqAvailableProperties(ACBindings.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.AvailablePropertySet*, byte>)0x004E3E70)(ref this, set);

    /// <summary>
    /// <code>Offset: 0x004E3EB0
    /// void __thiscall UIElement_ItemList::ListenToGlobalMessage(UIElement_ItemList*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, int, void>)0x004E3EB0)(ref this, messageID, data_int);

    /// <summary>
    /// <code>Offset: 0x004E3EE0
    /// void __thiscall UIElement_ItemList::HandleSingleSelection(UIElement_ItemList*,UIElement_UIItem*)</code>
    /// </summary>
    public void HandleSingleSelection(ACBindings.Internal.UIElement_UIItem* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement_UIItem*, void>)0x004E3EE0)(ref this, item);

    /// <summary>
    /// <code>Offset: 0x004E3F60
    /// void __thiscall UIElement_ItemList::ItemList_BeginDrag(UIElement_ItemList*,int,int)</code>
    /// </summary>
    public void ItemList_BeginDrag(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, int, int, void>)0x004E3F60)(ref this, x, y);

    /// <summary>
    /// <code>Offset: 0x004E4090
    /// void __thiscall UIElement_ItemList::ItemList_DragOver(UIElement_ItemList*,UIElement*,UIElement_UIItem*)</code>
    /// </summary>
    public void ItemList_DragOver(ACBindings.Internal.UIElement* dragElement, ACBindings.Internal.UIElement_UIItem* catchElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement*, ACBindings.Internal.UIElement_UIItem*, void>)0x004E4090)(ref this, dragElement, catchElement);

    /// <summary>
    /// <code>Offset: 0x004E41C0
    /// bool __thiscall UIElement_ItemList::InternalDeleteItem(UIElement_ItemList*,UIElement_UIItem*)</code>
    /// </summary>
    public byte InternalDeleteItem(ACBindings.Internal.UIElement_UIItem* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement_UIItem*, byte>)0x004E41C0)(ref this, item);

    /// <summary>
    /// <code>Offset: 0x004E41F0
    /// void __thiscall UIElement_ItemList::RecvNotice_SetSelectedItem(UIElement_ItemList*,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_SetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, uint, void>)0x004E41F0)(ref this, oldSelectedID, selectedID);

    /// <summary>
    /// <code>Offset: 0x004E4200
    /// UIElement_UIItem* __thiscall UIElement_ItemList::InternalCreateItem(UIElement_ItemList*)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_UIItem* InternalCreateItem() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement_UIItem*>)0x004E4200)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E42E0
    /// void __thiscall UIElement_ItemList::ItemList_SetParentList(UIElement_ItemList*,UIElement_ItemList*)</code>
    /// </summary>
    public void ItemList_SetParentList(ACBindings.Internal.UIElement_ItemList* newParent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElement_ItemList*, void>)0x004E42E0)(ref this, newParent);

    /// <summary>
    /// <code>Offset: 0x004E4340
    /// void __thiscall UIElement_ItemList::ItemList_AddEmptySlot(UIElement_ItemList*,int)</code>
    /// </summary>
    public void ItemList_AddEmptySlot(int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, int, void>)0x004E4340)(ref this, pos);

    /// <summary>
    /// <code>Offset: 0x004E4390
    /// void __thiscall UIElement_ItemList::UpdateEmptySlots(UIElement_ItemList*)</code>
    /// </summary>
    public void UpdateEmptySlots() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E4390)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E45A0
    /// void __thiscall UIElement_ItemList::UpdateFixedSlots(UIElement_ItemList*)</code>
    /// </summary>
    public void UpdateFixedSlots() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E45A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E4670
    /// void __thiscall UIElement_ItemList::ItemList_UpdateContainerListSize(UIElement_ItemList*)</code>
    /// </summary>
    public void ItemList_UpdateContainerListSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E4670)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E4730
    /// void __thiscall UIElement_ItemList::UIElement_ItemList(UIElement_ItemList*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004E4730)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004E4830
    /// UIElement* __thiscall UIElement_ItemList::DynamicCast(UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, ACBindings.Internal.UIElement*>)0x004E4830)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004E4860
    /// unsigned int __thiscall UIElement_ItemList::GetUIElementType(UIElement_ItemList*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint>)0x004E4860)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E4870
    /// void __thiscall UIElement_ItemList::~UIElement_ItemList(UIElement_ItemList*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E4870)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E4990
    /// void __thiscall UIElement_ItemList::OnVisibilityChanged(UIElement_ItemList*,bool)</code>
    /// </summary>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, byte, void>)0x004E4990)(ref this, i_bVisible);

    /// <summary>
    /// <code>Offset: 0x004E49C0
    /// void __thiscall UIElement_ItemList::ResizeTo(UIElement_ItemList*,const int,const int)</code>
    /// </summary>
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, int, int, void>)0x004E49C0)(ref this, width, height);

    /// <summary>
    /// <code>Offset: 0x004E49F0
    /// void __thiscall UIElement_ItemList::ItemList_Flush(UIElement_ItemList*)</code>
    /// </summary>
    public void ItemList_Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E49F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E4A90
    /// UIElement_UIItem* __thiscall UIElement_ItemList::ItemList_AddItem(UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_UIItem* ItemList_AddItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, ACBindings.Internal.UIElement_UIItem*>)0x004E4A90)(ref this, itemID);

    /// <summary>
    /// <code>Offset: 0x004E4BD0
    /// UIElement_UIItem* __thiscall UIElement_ItemList::ItemList_InsertItem(UIElement_ItemList*,unsigned int,int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_UIItem* ItemList_InsertItem(uint itemID, int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, int, ACBindings.Internal.UIElement_UIItem*>)0x004E4BD0)(ref this, itemID, pos);

    /// <summary>
    /// <code>Offset: 0x004E4C70
    /// void __thiscall UIElement_ItemList::ItemList_DeleteItem(UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    public void ItemList_DeleteItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, void>)0x004E4C70)(ref this, itemID);

    /// <summary>
    /// <code>Offset: 0x004E4D30
    /// UIElement_UIItem* __thiscall UIElement_ItemList::ItemList_AddSpellShortcut(UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_UIItem* ItemList_AddSpellShortcut(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, ACBindings.Internal.UIElement_UIItem*>)0x004E4D30)(ref this, spellID);

    /// <summary>
    /// <code>Offset: 0x004E4E40
    /// UIElement_UIItem* __thiscall UIElement_ItemList::ItemList_InsertSpellShortcut(UIElement_ItemList*,unsigned int,int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement_UIItem* ItemList_InsertSpellShortcut(uint spellID, int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, int, ACBindings.Internal.UIElement_UIItem*>)0x004E4E40)(ref this, spellID, pos);

    /// <summary>
    /// <code>Offset: 0x004E4EE0
    /// bool __thiscall UIElement_ItemList::AcceptDragObject(UIElement_ItemList*,unsigned int,bool)</code>
    /// </summary>
    public byte AcceptDragObject(uint i_itemID, byte i_isContainer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, byte, byte>)0x004E4EE0)(ref this, i_itemID, i_isContainer);

    /// <summary>
    /// <code>Offset: 0x004E5400
    /// void __cdecl UIElement_ItemList::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004E5400)();

    /// <summary>
    /// <code>Offset: 0x004E5420
    /// void __thiscall UIElement_ItemList::HandleDropRelease(UIElement_ItemList*,const UIElementMessageInfo*)</code>
    /// </summary>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElementMessageInfo*, void>)0x004E5420)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004E54C0
    /// void __thiscall UIElement_ItemList::InitItemList(UIElement_ItemList*)</code>
    /// </summary>
    public void InitItemList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E54C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E5660
    /// void __thiscall UIElement_ItemList::ItemList_SetParentContainer(UIElement_ItemList*,unsigned int,int,int)</code>
    /// </summary>
    public void ItemList_SetParentContainer(uint parentContainerID, int refresh, int draw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, int, int, void>)0x004E5660)(ref this, parentContainerID, refresh, draw);

    /// <summary>
    /// <code>Offset: 0x004E5770
    /// int __thiscall UIElement_ItemList::ItemList_OpenContainer(UIElement_ItemList*,unsigned int,int)</code>
    /// </summary>
    public int ItemList_OpenContainer(uint containerID, int checkIfInList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, int, int>)0x004E5770)(ref this, containerID, checkIfInList);

    /// <summary>
    /// <code>Offset: 0x004E57F0
    /// void __thiscall UIElement_ItemList::ItemList_OpenFirstContainer(UIElement_ItemList*)</code>
    /// </summary>
    public void ItemList_OpenFirstContainer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E57F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E5930
    /// void __thiscall UIElement_ItemList::PostInit(UIElement_ItemList*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, void>)0x004E5930)(ref this);

    /// <summary>
    /// <code>Offset: 0x004E59E0
    /// UIElementMessageListenResult __thiscall UIElement_ItemList::ListenToElementMessage(UIElement_ItemList*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004E59E0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004E5C20
    /// void __thiscall UIElement_ItemList::ItemAttributesChanged(UIElement_ItemList*,unsigned int,int)</code>
    /// </summary>
    public void ItemAttributesChanged(uint itemID, int flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, int, void>)0x004E5C20)(ref this, itemID, flags);

    /// <summary>
    /// <code>Offset: 0x004E5C90
    /// void __thiscall UIElement_ItemList::ServerSaysMoveItem(UIElement_ItemList*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    public void ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004E5C90)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>
    /// <code>Offset: 0x004E5D80
    /// void __thiscall UIElement_ItemList::RecvNotice_ServerSaysAttemptFailed(UIElement_ItemList*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ServerSaysAttemptFailed(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, void>)0x004E5D80)(ref this, i_itemID);

    /// <summary>
    /// <code>Offset: 0x004E5D90
    /// void __thiscall UIElement_ItemList::RecvNotice_ItemAttributesChanged(UIElement_ItemList*,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ItemAttributesChanged(uint i_target, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, uint, void>)0x004E5D90)(ref this, i_target, i_attrib);

    /// <summary>
    /// <code>Offset: 0x004E5DA0
    /// void __thiscall UIElement_ItemList::RecvNotice_ServerSaysMoveItem(UIElement_ItemList*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ServerSaysMoveItem(uint i_itemID, uint i_oldContainer, uint i_oldWielder, uint i_oldLocation, uint i_newContainer, int i_place, uint i_newWielder, uint i_newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIElement_ItemList, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004E5DA0)(ref this, i_itemID, i_oldContainer, i_oldWielder, i_oldLocation, i_newContainer, i_place, i_newWielder, i_newLocation);
}

