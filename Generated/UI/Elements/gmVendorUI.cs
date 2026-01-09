namespace ACBindings;

// gmVendorUI
public unsafe struct gmVendorUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler
    public ACBindings.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.QualityChangeHandler
    public ACBindings.ObjectRangeHandler BaseClass_ObjectRangeHandler; // ACBindings.ObjectRangeHandler

    // Statics
    public static uint* m_curDialogContext = (uint*)0x00840534;

    // Child Types
    // gmVendorUI_vtbl
    public unsafe struct gmVendorUI_vtbl
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

        // Methods
    }

    // Members
    public ACBindings.UIElement_Panel* m_vendorPanel;
    public uint shopVendorID;
    public ACBindings.VendorProfile* shopVendorProfile;
    public System.IntPtr shopItemProfileList;
    public ACBindings.PackableList__ItemProfile m_buyList;
    public ACBindings.PackableList__ItemProfile m_sellList;
    public ACBindings.VendorItemsUI* m_itemsUI;
    public ACBindings.VendorBuyUI* m_buyUI;
    public ACBindings.VendorSellUI* m_sellUI;
    public int m_totalValue;
    public int m_last_sale;

    // Generated Constructor
    public gmVendorUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __stdcall gmVendorUI::SendShopEvent(int,int*,int,int)
    public static void SendShopEvent(int requestObjID, int* a2, int a3, int a4) => ((delegate* unmanaged[Stdcall]<int, int*, int, int, void>)0x004C0EA0)(requestObjID, a2, a3, a4);
    // void __thiscall gmVendorUI::RecvNotice_SetSelectedItem(gmVendorUI*,unsigned int,unsigned int)
    public void RecvNotice_SetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, uint, uint, void>)0x004C0F00)(ref this, oldSelectedID, selectedID);
    // void __thiscall gmVendorUI::RecvNotice_CloseVendor(gmVendorUI*,bool)
    public void RecvNotice_CloseVendor(byte i_bUpdating) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, byte, void>)0x004C0F40)(ref this, i_bUpdating);
    // void __thiscall gmVendorUI::OnObjectRangeExit(gmVendorUI*,unsigned int)
    public void OnObjectRangeExit(uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, uint, void>)0x004C0F70)(ref this, objectID);
    // void __thiscall gmVendorUI::VendorItemSetSellState(gmVendorUI*,unsigned int,int)
    public void VendorItemSetSellState(uint itemID, int state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, uint, int, void>)0x004C0FA0)(ref this, itemID, state);
    // void __thiscall gmVendorUI::DeleteItem(gmVendorUI*,UIElement_ItemList*,unsigned int,int)
    public void DeleteItem(ACBindings.UIElement_ItemList* uiItemList, uint itemID, int broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, ACBindings.UIElement_ItemList*, uint, int, void>)0x004C0FC0)(ref this, uiItemList, itemID, broadcast);
    // void __thiscall gmVendorUI::OpenTab(gmVendorUI*,unsigned int)
    public void OpenTab(uint tabID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, uint, void>)0x004C1010)(ref this, tabID);
    // void __thiscall gmVendorUI::UpdateDragOver(gmVendorUI*)
    public void UpdateDragOver() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, void>)0x004C1030)(ref this);
    // void __thiscall gmVendorUI::ListenToGlobalMessage(gmVendorUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, uint, int, void>)0x004C1100)(ref this, i_messageID, i_data_int);
    // void __thiscall gmVendorUI::PostInit(gmVendorUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, void>)0x004C1590)(ref this);
    // char __thiscall gmVendorUI::ShopHasItem(_DWORD*,int,_DWORD*,_DWORD*)
    public sbyte ShopHasItem(int a2, int* a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, int, int*, int*, sbyte>)0x004C1760)(ref this, a2, a3, a4);
    // void __stdcall gmVendorUI::FlushSellListSellState(int)
    public static void FlushSellListSellState(int a1) => ((delegate* unmanaged[Stdcall]<int, void>)0x004C17C0)(a1);
    // ACCWeenieObject* __stdcall gmVendorUI::InqListSlotCount(ACCWeenieObject*,_DWORD*,_DWORD*)
    public static ACBindings.ACCWeenieObject* InqListSlotCount(ACBindings.ACCWeenieObject* a1, int* a2, int* a3) => ((delegate* unmanaged[Stdcall]<ACBindings.ACCWeenieObject*, int*, int*, ACBindings.ACCWeenieObject*>)0x004C1800)(a1, a2, a3);
    // char __stdcall gmVendorUI::RemoveProfileFromList(_DWORD*,int,int)
    public static sbyte RemoveProfileFromList(int* a1, int a2, int a3) => ((delegate* unmanaged[Stdcall]<int*, int, int, sbyte>)0x004C1E50)(a1, a2, a3);
    // char __stdcall gmVendorUI::RecordContents(UIElement_ListBox*,_DWORD*,int,int)
    public static sbyte RecordContents(ACBindings.UIElement_ListBox* a1, int* a2, int a3, int a4) => ((delegate* unmanaged[Stdcall]<ACBindings.UIElement_ListBox*, int*, int, int, sbyte>)0x004C1F00)(a1, a2, a3, a4);
    // int __thiscall gmVendorUI::AddItem(gmVendorUI*,UIElement_ItemList*,unsigned int,int,int,int,int,int,int)
    public int AddItem(ACBindings.UIElement_ItemList* uiItemList, uint itemID, int position, int removeDuplicates, int addContents, int excludeIfUnacceptable, int broadcast, int quantityDisp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, ACBindings.UIElement_ItemList*, uint, int, int, int, int, int, int, int>)0x004C20A0)(ref this, uiItemList, itemID, position, removeDuplicates, addContents, excludeIfUnacceptable, broadcast, quantityDisp);
    // void __thiscall gmVendorUI::gmVendorUI(gmVendorUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004C3060)(ref this, layout, full_desc);
    // UIElement* __thiscall gmVendorUI::DynamicCast(gmVendorUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, uint, ACBindings.UIElement*>)0x004C3130)(ref this, i_eType);
    // unsigned int __thiscall gmVendorUI::GetUIElementType(gmVendorUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, uint>)0x004C3150)(ref this);
    // void __thiscall gmVendorUI::~gmVendorUI(gmVendorUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, void>)0x004C3160)(ref this);
    // void __thiscall gmVendorUI::ResetShopState(gmVendorUI*,bool)
    public void ResetShopState(byte updating) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, byte, void>)0x004C32C0)(ref this, updating);
    // bool __thiscall gmVendorUI::BuySingleItem(gmVendorUI*,unsigned int)
    public byte BuySingleItem(uint ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, uint, byte>)0x004C3410)(ref this, ID);
    // bool __thiscall gmVendorUI::SellSingleItem(gmVendorUI*,unsigned int)
    public byte SellSingleItem(uint ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, uint, byte>)0x004C3730)(ref this, ID);
    // void __stdcall gmVendorUI::AdoptAsContents(UIElement_ItemList*,int,char)
    public static void AdoptAsContents(ACBindings.UIElement_ItemList* a1, int a2, sbyte a3) => ((delegate* unmanaged[Stdcall]<ACBindings.UIElement_ItemList*, int, sbyte, void>)0x004C38F0)(a1, a2, a3);
    // LONG __stdcall gmVendorUI::AddMissingComp(char*,char**)
    public static int AddMissingComp(sbyte* Source, sbyte** a2) => ((delegate* unmanaged[Stdcall]<sbyte*, sbyte**, int>)0x004C3A80)(Source, a2);
    // void __cdecl gmVendorUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004C3BF0)();
    // void __thiscall gmVendorUI::CloseVendor(gmVendorUI*,bool)
    public void CloseVendor(byte updating) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, byte, void>)0x004C3C10)(ref this, updating);
    // void __cdecl gmVendorUI::CloseVendorDialogCallback(const PropertyCollection*)
    public static void CloseVendorDialogCallback(ACBindings.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.PropertyCollection*, void>)0x004C3C70)(i_rcResults);
    // void __thiscall gmVendorUI::OnVisibilityChanged(gmVendorUI*,bool)
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, byte, void>)0x004C4410)(ref this, i_bVisible);
    // void __thiscall gmVendorUI::HandleMousePresses(gmVendorUI*,const UIElementMessageInfo*)
    public void HandleMousePresses(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, ACBindings.UIElementMessageInfo*, void>)0x004C4CC0)(ref this, i_rMsg);
    // void __thiscall gmVendorUI::RecvNotice_ItemListBeginDrag(gmVendorUI*,const UIElement*,int)
    public void RecvNotice_ItemListBeginDrag(ACBindings.UIElement* i_itemList, int i_slotNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, ACBindings.UIElement*, int, void>)0x004C4F70)(ref this, i_itemList, i_slotNum);
    // void __thiscall gmVendorUI::RecvNotice_ServerSaysMoveItem(gmVendorUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004C5090)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);
    // void __thiscall gmVendorUI::RecvNotice_ItemAttributesChanged(gmVendorUI*,unsigned int,unsigned int)
    public void RecvNotice_ItemAttributesChanged(uint i_target, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, uint, uint, void>)0x004C50E0)(ref this, i_target, i_attrib);
    // void __thiscall gmVendorUI::RecvNotice_StackSliderChanged(gmVendorUI*,unsigned int,unsigned int)
    public void RecvNotice_StackSliderChanged(uint i_splitSize, uint i_maxSplitSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, uint, uint, void>)0x004C50F0)(ref this, i_splitSize, i_maxSplitSize);
    // void __thiscall gmVendorUI::FillComponentList(gmVendorUI*,SpellComponentCategory,int)
    public void FillComponentList(ACBindings.SpellComponentCategory sp_cat, int max_to_spend) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, ACBindings.SpellComponentCategory, int, void>)0x004C5130)(ref this, sp_cat, max_to_spend);
    // void __thiscall gmVendorUI::UpdateTotalValue(gmVendorUI*)
    public void UpdateTotalValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, void>)0x004C54D0)(ref this);
    // void __thiscall gmVendorUI::RecvNotice_AddItemToSell(gmVendorUI*,unsigned int)
    public void RecvNotice_AddItemToSell(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, uint, void>)0x004C56B0)(ref this, i_itemID);
    // void __thiscall gmVendorUI::RecvNotice_FillComponentBuyList(gmVendorUI*,SpellComponentCategory,int)
    public void RecvNotice_FillComponentBuyList(ACBindings.SpellComponentCategory i_sp_cat, int i_max_to_buy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, ACBindings.SpellComponentCategory, int, void>)0x004C56C0)(ref this, i_sp_cat, i_max_to_buy);
    // void __thiscall gmVendorUI::OnQualityChanged(gmVendorUI*,CWeenieObject*,StatType,unsigned int)
    public void OnQualityChanged(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, ACBindings.CWeenieObject*, ACBindings.StatType, uint, void>)0x004C56D0)(ref this, cwobj, stype, senum);
    // void __thiscall gmVendorUI::OnQualityRemoved(gmVendorUI*,CWeenieObject*,StatType,unsigned int)
    public void OnQualityRemoved(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, ACBindings.CWeenieObject*, ACBindings.StatType, uint, void>)0x004C5750)(ref this, cwobj, stype, senum);
    // int __thiscall gmVendorUI::OpenVendor(gmVendorUI*,_DWORD*,TResult,int,int)
    public int OpenVendor(int* responseObjID, ACBindings.TResult result, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, int*, ACBindings.TResult, int, int, int>)0x004C5790)(ref this, responseObjID, result, a4, a5);
    // void __thiscall gmVendorUI::HandleButtonClicks(gmVendorUI*,unsigned int)
    public void HandleButtonClicks(uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, uint, void>)0x004C5CC0)(ref this, elementID);
    // void __thiscall gmVendorUI::HandleDropRelease(gmVendorUI*,const UIElementMessageInfo*)
    public void HandleDropRelease(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, ACBindings.UIElementMessageInfo*, void>)0x004C6270)(ref this, i_rMsg);
    // int __thiscall gmVendorUI::RecvNotice_OpenVendor(char*,_DWORD*,TResult,int,int)
    public int RecvNotice_OpenVendor(int* a2, ACBindings.TResult a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, int*, ACBindings.TResult, int, int, int>)0x004C62E0)(ref this, a2, a3, a4, a5);
    // UIElementMessageListenResult __thiscall gmVendorUI::ListenToElementMessage(gmVendorUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmVendorUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004C62F0)(ref this, i_rMsg);
}

