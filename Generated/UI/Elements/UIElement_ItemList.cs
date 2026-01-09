namespace ACBindings;

// UIElement_ItemList
public unsafe struct UIElement_ItemList : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_ListBox BaseClass_UIElement_ListBox; // ACBindings.UIElement_ListBox
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // UIElement_ItemList_vtbl
    public unsafe struct UIElement_ItemList_vtbl
    {
        // Members
        public System.IntPtr UIListener_dtor_0; // function pointer
        public System.IntPtr OnAction; // function pointer
        public System.IntPtr OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public System.IntPtr ListenToElementMessage; // function pointer
        public System.IntPtr ListenToGlobalMessage; // function pointer
        public System.IntPtr SetVisible; // function pointer
        public System.IntPtr SetShouldBlockClicks; // function pointer
        public System.IntPtr SetShouldEraseBackground; // function pointer
        public System.IntPtr SetClampGameViewEdge; // function pointer
        public System.IntPtr CheckOverOverride; // function pointer
        public System.IntPtr MoveTo; // function pointer
        public System.IntPtr ResizeTo; // function pointer
        public System.IntPtr GetSurfaceBox; // function pointer
        public System.IntPtr CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public System.IntPtr SetParent; // function pointer
        public fixed byte gap48[4];
        public System.IntPtr MouseMove; // function pointer
        public System.IntPtr MouseOver; // function pointer
        public System.IntPtr MouseOverTop; // function pointer
        public System.IntPtr MouseHover; // function pointer
        public System.IntPtr MouseUnhover; // function pointer
        public System.IntPtr MouseDown; // function pointer
        public System.IntPtr MouseUp; // function pointer
        public System.IntPtr HasCursor; // function pointer
        public System.IntPtr AddChild; // function pointer
        public System.IntPtr RemoveChild; // function pointer
        public System.IntPtr DrawStart; // function pointer
        public System.IntPtr EraseBackground; // function pointer
        public System.IntPtr PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public System.IntPtr PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public System.IntPtr DrawDone; // function pointer
        public System.IntPtr MouseTap; // function pointer
        public System.IntPtr DynamicCast; // function pointer
        public System.IntPtr GetUIElementType; // function pointer
        public System.IntPtr SetState; // function pointer
        public System.IntPtr GetParent; // function pointer
        public System.IntPtr GetAncestorByID; // function pointer
        public System.IntPtr KeyUp; // function pointer
        public System.IntPtr KeyDown; // function pointer
        public System.IntPtr RegisterInputMaps; // function pointer
        public System.IntPtr UnregisterInputMaps; // function pointer
        public System.IntPtr OnChildAction; // function pointer
        public System.IntPtr Initialize; // function pointer
        public System.IntPtr PostInit; // function pointer
        public System.IntPtr InqAvailableProperties; // function pointer
        public System.IntPtr OnSetAttribute; // function pointer
        public System.IntPtr ContainsProperty; // function pointer
        public System.IntPtr InqProperty; // function pointer
        public System.IntPtr SetProperty; // function pointer
        public fixed byte gapD8[4];
        public System.IntPtr CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public System.IntPtr DragAndDropComplete; // function pointer
        public System.IntPtr DragItem; // function pointer
        public System.IntPtr GetDragAndDropCatcher; // function pointer
        public System.IntPtr MatchElement; // function pointer
        public System.IntPtr UpdateForChildSizeChange; // function pointer
        public System.IntPtr UpdateForParentVisibilityChange; // function pointer
        public System.IntPtr Activate; // function pointer
        public System.IntPtr Deactivate; // function pointer
        public System.IntPtr TakeFocus; // function pointer
        public System.IntPtr RelinquishFocus; // function pointer
        public System.IntPtr GetActivatable; // function pointer
        public System.IntPtr SetMouseVisible; // function pointer
        public System.IntPtr UpdateForScreenPositionChange; // function pointer
        public System.IntPtr SetUIObject; // function pointer
        public System.IntPtr MakeUIObject; // function pointer
        public System.IntPtr OnChildActivationChanged; // function pointer
        public System.IntPtr GetShouldBeMouseVisible; // function pointer
        public System.IntPtr ForwardElementMessage; // function pointer
        public System.IntPtr DefElementMessageHandler; // function pointer
        public System.IntPtr OnVisibilityChanged; // function pointer
        public System.IntPtr Initialized; // function pointer
        public System.IntPtr AdjustToScrollableXYChange; // function pointer
        public System.IntPtr InqScrollDelta; // function pointer
        public System.IntPtr StartUpActive; // function pointer
        public System.IntPtr EndUpActive; // function pointer
        public System.IntPtr StartDownActive; // function pointer
        public System.IntPtr EndDownActive; // function pointer
        public System.IntPtr StartLeftActive; // function pointer
        public System.IntPtr EndLeftActive; // function pointer
        public System.IntPtr StartRightActive; // function pointer
        public System.IntPtr EndRightActive; // function pointer
        public System.IntPtr UpdateLayout; // function pointer

        // Methods
    }

    // Members
    public uint parentContainerID;
    public uint openItemID;
    public uint removedItemID;
    public ACBindings.UIElement_ItemList* childList;
    public ACBindings.UIElement_ItemList* parentList;
    public byte containerList;
    public byte vendorItemList;
    public byte shortcutList;
    public byte salvageList;
    public ACBindings.UIElement_UIItem* m_pendingItem;
    public int m_cellW;
    public int m_cellH;
    public ACBindings.List__UIElement_UIItem_ptr m_listUIItemCache;
    public ACBindings.ItemListDragHandler* m_dragHandler;
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
    public UIElement_ItemList(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall UIElement_ItemList::IsAliasList(UIElement_ItemList*)
    public byte IsAliasList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, byte>)0x004E3130)(ref this);
    // void __thiscall UIElement_ItemList::HandleTargetedUseLeftClick(UIElement_ItemList*,UIElement_UIItem*)
    public void HandleTargetedUseLeftClick(ACBindings.UIElement_UIItem* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, ACBindings.UIElement_UIItem*, void>)0x004E3160)(ref this, item);
    // void __thiscall UIElement_ItemList::ItemList_SetChildList(UIElement_ItemList*,UIElement_ItemList*)
    public void ItemList_SetChildList(ACBindings.UIElement_ItemList* childList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, ACBindings.UIElement_ItemList*, void>)0x004E31C0)(ref this, childList);
    // void __thiscall UIElement_ItemList::RecvNotice_BeginDrag(UIElement_ItemList*,unsigned int,unsigned int,bool)
    public void RecvNotice_BeginDrag(uint i_itemID, uint i_spellID, byte i_bIsAlias) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, uint, byte, void>)0x004E31D0)(ref this, i_itemID, i_spellID, i_bIsAlias);
    // void __thiscall UIElement_ItemList::RegisterItemListDragHandler(UIElement_ItemList*,ItemListDragHandler*)
    public void RegisterItemListDragHandler(ACBindings.ItemListDragHandler* handler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, ACBindings.ItemListDragHandler*, void>)0x004E3220)(ref this, handler);
    // void __thiscall UIElement_ItemList::UnregisterItemListDragHandler(UIElement_ItemList*)
    public void UnregisterItemListDragHandler() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, void>)0x004E3230)(ref this);
    // void __thiscall UIElement_ItemList::SetAsPendingItem(UIElement_ItemList*,UIElement_UIItem*)
    public void SetAsPendingItem(ACBindings.UIElement_UIItem* pendingItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, ACBindings.UIElement_UIItem*, void>)0x004E3240)(ref this, pendingItem);
    // void __thiscall UIElement_ItemList::DeletePendingItem(UIElement_ItemList*)
    public void DeletePendingItem() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, void>)0x004E3250)(ref this);
    // int __thiscall UIElement_ItemList::WhatDragScrollRegion(UIElement_ItemList*,int,int)
    public int WhatDragScrollRegion(int xPos, int yPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, int, int, int>)0x004E3280)(ref this, xPos, yPos);
    // void __cdecl UIElement_ItemList::InqDropIconInfo(const UIElement*,unsigned int*,unsigned int*,DropItemFlags*)
    public static void InqDropIconInfo(ACBindings.UIElement* dropIcon, uint* itemID, uint* spellID, ACBindings.DropItemFlags* flags) => ((delegate* unmanaged[Cdecl]<ACBindings.UIElement*, uint*, uint*, ACBindings.DropItemFlags*, void>)0x004E3380)(dropIcon, itemID, spellID, flags);
    // bool __thiscall UIElement_ItemList::PrepareDragIcon(UIElement_ItemList*,UIElement_UIItem*)
    public byte PrepareDragIcon(ACBindings.UIElement_UIItem* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, ACBindings.UIElement_UIItem*, byte>)0x004E36E0)(ref this, item);
    // int __thiscall UIElement_ItemList::ItemList_IsInList(UIElement_ItemList*,unsigned int)
    public int ItemList_IsInList(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, int>)0x004E3B60)(ref this, itemID);
    // UIElement_UIItem* __thiscall UIElement_ItemList::ItemList_GetItem(UIElement_ItemList*,unsigned int)
    public ACBindings.UIElement_UIItem* ItemList_GetItem(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, ACBindings.UIElement_UIItem*>)0x004E3BC0)(ref this, i_iidItem);
    // int __thiscall UIElement_ItemList::GetNumUIItems(UIElement_ItemList*)
    public int GetNumUIItems() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, int>)0x004E3C10)(ref this);
    // void __thiscall UIElement_ItemList::ItemList_SetSelectedItem(UIElement_ItemList*,unsigned int,unsigned int)
    public void ItemList_SetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, uint, void>)0x004E3C70)(ref this, oldSelectedID, selectedID);
    // void __thiscall UIElement_ItemList::UpdateOpenContainerIndicator(UIElement_ItemList*,unsigned int)
    public void UpdateOpenContainerIndicator(uint containerID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, void>)0x004E3D00)(ref this, containerID);
    // void __thiscall UIElement_ItemList::TrackDragScrolling(UIElement_ItemList*)
    public void TrackDragScrolling() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, void>)0x004E3D60)(ref this);
    // bool __thiscall UIElement_ItemList::InqAvailableProperties(UIElement_ItemList*,AvailablePropertySet*)
    public byte InqAvailableProperties(ACBindings.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, ACBindings.AvailablePropertySet*, byte>)0x004E3E70)(ref this, set);
    // void __thiscall UIElement_ItemList::ListenToGlobalMessage(UIElement_ItemList*,unsigned int,int)
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, int, void>)0x004E3EB0)(ref this, messageID, data_int);
    // void __thiscall UIElement_ItemList::HandleSingleSelection(UIElement_ItemList*,UIElement_UIItem*)
    public void HandleSingleSelection(ACBindings.UIElement_UIItem* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, ACBindings.UIElement_UIItem*, void>)0x004E3EE0)(ref this, item);
    // void __thiscall UIElement_ItemList::ItemList_BeginDrag(UIElement_ItemList*,int,int)
    public void ItemList_BeginDrag(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, int, int, void>)0x004E3F60)(ref this, x, y);
    // void __thiscall UIElement_ItemList::ItemList_DragOver(UIElement_ItemList*,UIElement*,UIElement_UIItem*)
    public void ItemList_DragOver(ACBindings.UIElement* dragElement, ACBindings.UIElement_UIItem* catchElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, ACBindings.UIElement*, ACBindings.UIElement_UIItem*, void>)0x004E4090)(ref this, dragElement, catchElement);
    // bool __thiscall UIElement_ItemList::InternalDeleteItem(UIElement_ItemList*,UIElement_UIItem*)
    public byte InternalDeleteItem(ACBindings.UIElement_UIItem* item) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, ACBindings.UIElement_UIItem*, byte>)0x004E41C0)(ref this, item);
    // void __thiscall UIElement_ItemList::RecvNotice_SetSelectedItem(UIElement_ItemList*,unsigned int,unsigned int)
    public void RecvNotice_SetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, uint, void>)0x004E41F0)(ref this, oldSelectedID, selectedID);
    // UIElement_UIItem* __thiscall UIElement_ItemList::InternalCreateItem(UIElement_ItemList*)
    public ACBindings.UIElement_UIItem* InternalCreateItem() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, ACBindings.UIElement_UIItem*>)0x004E4200)(ref this);
    // void __thiscall UIElement_ItemList::ItemList_SetParentList(UIElement_ItemList*,UIElement_ItemList*)
    public void ItemList_SetParentList(ACBindings.UIElement_ItemList* newParent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, ACBindings.UIElement_ItemList*, void>)0x004E42E0)(ref this, newParent);
    // void __thiscall UIElement_ItemList::ItemList_AddEmptySlot(UIElement_ItemList*,int)
    public void ItemList_AddEmptySlot(int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, int, void>)0x004E4340)(ref this, pos);
    // void __thiscall UIElement_ItemList::UpdateEmptySlots(UIElement_ItemList*)
    public void UpdateEmptySlots() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, void>)0x004E4390)(ref this);
    // void __thiscall UIElement_ItemList::UpdateFixedSlots(UIElement_ItemList*)
    public void UpdateFixedSlots() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, void>)0x004E45A0)(ref this);
    // void __thiscall UIElement_ItemList::ItemList_UpdateContainerListSize(UIElement_ItemList*)
    public void ItemList_UpdateContainerListSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, void>)0x004E4670)(ref this);
    // void __thiscall UIElement_ItemList::UIElement_ItemList(UIElement_ItemList*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004E4730)(ref this, layout, full_desc);
    // UIElement* __thiscall UIElement_ItemList::DynamicCast(UIElement_ItemList*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, ACBindings.UIElement*>)0x004E4830)(ref this, i_eType);
    // unsigned int __thiscall UIElement_ItemList::GetUIElementType(UIElement_ItemList*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint>)0x004E4860)(ref this);
    // void __thiscall UIElement_ItemList::~UIElement_ItemList(UIElement_ItemList*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, void>)0x004E4870)(ref this);
    // void __thiscall UIElement_ItemList::OnVisibilityChanged(UIElement_ItemList*,bool)
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, byte, void>)0x004E4990)(ref this, i_bVisible);
    // void __thiscall UIElement_ItemList::ResizeTo(UIElement_ItemList*,const int,const int)
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, int, int, void>)0x004E49C0)(ref this, width, height);
    // void __thiscall UIElement_ItemList::ItemList_Flush(UIElement_ItemList*)
    public void ItemList_Flush() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, void>)0x004E49F0)(ref this);
    // UIElement_UIItem* __thiscall UIElement_ItemList::ItemList_AddItem(UIElement_ItemList*,unsigned int)
    public ACBindings.UIElement_UIItem* ItemList_AddItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, ACBindings.UIElement_UIItem*>)0x004E4A90)(ref this, itemID);
    // UIElement_UIItem* __thiscall UIElement_ItemList::ItemList_InsertItem(UIElement_ItemList*,unsigned int,int)
    public ACBindings.UIElement_UIItem* ItemList_InsertItem(uint itemID, int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, int, ACBindings.UIElement_UIItem*>)0x004E4BD0)(ref this, itemID, pos);
    // void __thiscall UIElement_ItemList::ItemList_DeleteItem(UIElement_ItemList*,unsigned int)
    public void ItemList_DeleteItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, void>)0x004E4C70)(ref this, itemID);
    // UIElement_UIItem* __thiscall UIElement_ItemList::ItemList_AddSpellShortcut(UIElement_ItemList*,unsigned int)
    public ACBindings.UIElement_UIItem* ItemList_AddSpellShortcut(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, ACBindings.UIElement_UIItem*>)0x004E4D30)(ref this, spellID);
    // UIElement_UIItem* __thiscall UIElement_ItemList::ItemList_InsertSpellShortcut(UIElement_ItemList*,unsigned int,int)
    public ACBindings.UIElement_UIItem* ItemList_InsertSpellShortcut(uint spellID, int pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, int, ACBindings.UIElement_UIItem*>)0x004E4E40)(ref this, spellID, pos);
    // bool __thiscall UIElement_ItemList::AcceptDragObject(UIElement_ItemList*,unsigned int,bool)
    public byte AcceptDragObject(uint i_itemID, byte i_isContainer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, byte, byte>)0x004E4EE0)(ref this, i_itemID, i_isContainer);
    // void __cdecl UIElement_ItemList::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004E5400)();
    // void __thiscall UIElement_ItemList::HandleDropRelease(UIElement_ItemList*,const UIElementMessageInfo*)
    public void HandleDropRelease(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, ACBindings.UIElementMessageInfo*, void>)0x004E5420)(ref this, i_rMsg);
    // void __thiscall UIElement_ItemList::InitItemList(UIElement_ItemList*)
    public void InitItemList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, void>)0x004E54C0)(ref this);
    // void __thiscall UIElement_ItemList::ItemList_SetParentContainer(UIElement_ItemList*,unsigned int,int,int)
    public void ItemList_SetParentContainer(uint parentContainerID, int refresh, int draw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, int, int, void>)0x004E5660)(ref this, parentContainerID, refresh, draw);
    // int __thiscall UIElement_ItemList::ItemList_OpenContainer(UIElement_ItemList*,unsigned int,int)
    public int ItemList_OpenContainer(uint containerID, int checkIfInList) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, int, int>)0x004E5770)(ref this, containerID, checkIfInList);
    // void __thiscall UIElement_ItemList::ItemList_OpenFirstContainer(UIElement_ItemList*)
    public void ItemList_OpenFirstContainer() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, void>)0x004E57F0)(ref this);
    // void __thiscall UIElement_ItemList::PostInit(UIElement_ItemList*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, void>)0x004E5930)(ref this);
    // UIElementMessageListenResult __thiscall UIElement_ItemList::ListenToElementMessage(UIElement_ItemList*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004E59E0)(ref this, i_rMsg);
    // void __thiscall UIElement_ItemList::ItemAttributesChanged(UIElement_ItemList*,unsigned int,int)
    public void ItemAttributesChanged(uint itemID, int flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, int, void>)0x004E5C20)(ref this, itemID, flags);
    // void __thiscall UIElement_ItemList::ServerSaysMoveItem(UIElement_ItemList*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)
    public void ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004E5C90)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);
    // void __thiscall UIElement_ItemList::RecvNotice_ServerSaysAttemptFailed(UIElement_ItemList*,unsigned int)
    public void RecvNotice_ServerSaysAttemptFailed(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, void>)0x004E5D80)(ref this, i_itemID);
    // void __thiscall UIElement_ItemList::RecvNotice_ItemAttributesChanged(UIElement_ItemList*,unsigned int,unsigned int)
    public void RecvNotice_ItemAttributesChanged(uint i_target, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, uint, void>)0x004E5D90)(ref this, i_target, i_attrib);
    // void __thiscall UIElement_ItemList::RecvNotice_ServerSaysMoveItem(UIElement_ItemList*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)
    public void RecvNotice_ServerSaysMoveItem(uint i_itemID, uint i_oldContainer, uint i_oldWielder, uint i_oldLocation, uint i_newContainer, int i_place, uint i_newWielder, uint i_newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIElement_ItemList, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004E5DA0)(ref this, i_itemID, i_oldContainer, i_oldWielder, i_oldLocation, i_newContainer, i_place, i_newWielder, i_newLocation);
}

