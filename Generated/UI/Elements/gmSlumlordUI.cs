namespace ACBindings;

// gmSlumlordUI
public unsafe struct gmSlumlordUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Panel BaseClass_UIElement_Panel; // ACBindings.UIElement_Panel
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler
    public ACBindings.ObjectRangeHandler BaseClass_ObjectRangeHandler; // ACBindings.ObjectRangeHandler
    public ACBindings.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.ItemListDragHandler

    // Child Types
    // gmSlumlordUI_vtbl
    public unsafe struct gmSlumlordUI_vtbl
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
    public uint m_iidOwner;
    public ACBindings.HouseProfile* m_pHouseProfile;
    public ACBindings.HouseProfile* m_pBackupHouseProfile;
    public ACBindings.HouseOp m_eCurrentHouseOp;
    public ACBindings.UIElement_ItemList* m_pCurItemList;
    public ACBindings.UIElement_Text* m_pBuyRequirementsText;
    public ACBindings.UIElement_Text* m_pBuyHouseOwnerText;
    public ACBindings.UIElement_ItemList* m_pBuyItemList;
    public ACBindings.UIElement_Button* m_pBuyButton;
    public ACBindings.UIElement_Text* m_pRentRequirementsText;
    public ACBindings.UIElement_Text* m_pRentHouseOwnerText;
    public ACBindings.UIElement_ItemList* m_pRentItemList;
    public ACBindings.UIElement_Button* m_pRentButton;
    public uint m_uiHousePurchaseDialogContext;
    public uint m_uiRentPaymentByProxyDialogContext;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmSlumlordUI::OnVisibilityChanged(gmSlumlordUI*,bool)
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, byte, void>)0x004C8860)(ref this, i_bVisible);
    // void __thiscall gmSlumlordUI::OnObjectRangeExit(gmSlumlordUI*,unsigned int)
    public void OnObjectRangeExit(uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, uint, void>)0x004C88A0)(ref this, objectID);
    // bool __thiscall gmSlumlordUI::BackupHouseProfile(gmSlumlordUI*)
    public byte BackupHouseProfile() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, byte>)0x004C88D0)(ref this);
    // bool __thiscall gmSlumlordUI::AmIHouseOwner(gmSlumlordUI*)
    public byte AmIHouseOwner() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, byte>)0x004C8920)(ref this);
    // bool __thiscall gmSlumlordUI::IsPaymentAllowed(gmSlumlordUI*)
    public byte IsPaymentAllowed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, byte>)0x004C8950)(ref this);
    // UIElement* __thiscall gmSlumlordUI::DynamicCast(gmSlumlordUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, uint, ACBindings.UIElement*>)0x004C8AA0)(ref this, i_eType);
    // unsigned int __thiscall gmSlumlordUI::GetUIElementType(gmSlumlordUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, uint>)0x004C8AC0)(ref this);
    // void __thiscall gmSlumlordUI::~gmSlumlordUI(gmSlumlordUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, void>)0x004C8AD0)(ref this);
    // void __thiscall gmSlumlordUI::RecvNotice_FailedHouseTransaction(gmSlumlordUI*,unsigned int)
    public void RecvNotice_FailedHouseTransaction(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, uint, void>)0x004C8BB0)(ref this, i_eType);
    // void __thiscall gmSlumlordUI::UpdateButtons(gmSlumlordUI*)
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, void>)0x004C8BD0)(ref this);
    // void __thiscall gmSlumlordUI::CleanItemLists(gmSlumlordUI*)
    public void CleanItemLists() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, void>)0x004C8C70)(ref this);
    // bool __thiscall gmSlumlordUI::AddItem(gmSlumlordUI*,ACCWeenieObject*)
    public byte AddItem(ACBindings.ACCWeenieObject* i_pItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, ACBindings.ACCWeenieObject*, byte>)0x004C8CE0)(ref this, i_pItem);
    // void __thiscall gmSlumlordUI::RemoveItem(gmSlumlordUI*,ACCWeenieObject*)
    public void RemoveItem(ACBindings.ACCWeenieObject* i_pItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, ACBindings.ACCWeenieObject*, void>)0x004C8DA0)(ref this, i_pItem);
    // void __thiscall gmSlumlordUI::PostInit(gmSlumlordUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, void>)0x004C8EB0)(ref this);
    // void __cdecl gmSlumlordUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004C90C0)();
    // void __thiscall gmSlumlordUI::RecvNotice_ItemListBeginDrag(gmSlumlordUI*,const UIElement*,int)
    public void RecvNotice_ItemListBeginDrag(ACBindings.UIElement* i_itemList, int i_slotNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, ACBindings.UIElement*, int, void>)0x004C90E0)(ref this, i_itemList, i_slotNum);
    // void __thiscall gmSlumlordUI::RecvNotice_ServerSaysMoveItem(gmSlumlordUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004C9140)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);
    // void __thiscall gmSlumlordUI::RecvNotice_BeingDeleted(gmSlumlordUI*,CWeenieObject*)
    public void RecvNotice_BeingDeleted(ACBindings.CWeenieObject* i_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, ACBindings.CWeenieObject*, void>)0x004C9190)(ref this, i_obj);
    // bool __thiscall gmSlumlordUI::AddObject(gmSlumlordUI*,ACCWeenieObject*)
    public byte AddObject(ACBindings.ACCWeenieObject* i_pObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, ACBindings.ACCWeenieObject*, byte>)0x004C91A0)(ref this, i_pObject);
    // bool __thiscall gmSlumlordUI::DragItemAcceptable(gmSlumlordUI*,unsigned int,bool)
    public byte DragItemAcceptable(uint i_iidItem, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, uint, byte, byte>)0x004C91E0)(ref this, i_iidItem, silent);
    // bool __thiscall gmSlumlordUI::AddContainer(gmSlumlordUI*,ACCWeenieObject*)
    public byte AddContainer(ACBindings.ACCWeenieObject* i_pContainer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, ACBindings.ACCWeenieObject*, byte>)0x004C92D0)(ref this, i_pContainer);
    // bool __thiscall gmSlumlordUI::AcceptDragObject(gmSlumlordUI*,unsigned int)
    public byte AcceptDragObject(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, uint, byte>)0x004C93B0)(ref this, i_iidItem);
    // bool __thiscall gmSlumlordUI::MakePayment(gmSlumlordUI*)
    public byte MakePayment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, byte>)0x004C9530)(ref this);
    // void __thiscall gmSlumlordUI::HandleDropRelease(gmSlumlordUI*,const UIElementMessageInfo*)
    public void HandleDropRelease(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, ACBindings.UIElementMessageInfo*, void>)0x004C9670)(ref this, i_rMsg);
    // bool __thiscall gmSlumlordUI::RefreshHouse(gmSlumlordUI*)
    public byte RefreshHouse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, byte>)0x004C9710)(ref this);
    // bool __thiscall gmSlumlordUI::CloseBuyHouseConfirmationDialog(gmSlumlordUI*,bool)
    public byte CloseBuyHouseConfirmationDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, byte, byte>)0x004C9980)(ref this, i_bConfirm);
    // bool __thiscall gmSlumlordUI::CloseRentPaymentByProxyConfirmationDialog(gmSlumlordUI*,bool)
    public byte CloseRentPaymentByProxyConfirmationDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, byte, byte>)0x004C99E0)(ref this, i_bConfirm);
    // void __thiscall gmSlumlordUI::RecvNotice_CloseDialog(gmSlumlordUI*,unsigned int,const PropertyCollection*)
    public void RecvNotice_CloseDialog(uint context, ACBindings.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, uint, ACBindings.PropertyCollection*, void>)0x004C9A30)(ref this, context, data);
    // bool __thiscall gmSlumlordUI::UpdateHouse(gmSlumlordUI*,unsigned int,const HouseProfile*)
    public byte UpdateHouse(uint i_iidOwner, ACBindings.HouseProfile* houseProfile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, uint, ACBindings.HouseProfile*, byte>)0x004C9BC0)(ref this, i_iidOwner, houseProfile);
    // void __thiscall gmSlumlordUI::RecvNotice_UpdateHouseProfile(gmSlumlordUI*,unsigned int,const HouseProfile*)
    public void RecvNotice_UpdateHouseProfile(uint i_iidOwner, ACBindings.HouseProfile* i_prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, uint, ACBindings.HouseProfile*, void>)0x004C9C30)(ref this, i_iidOwner, i_prof);
    // bool __thiscall gmSlumlordUI::MakeBuyHouseConfirmationDialog(gmSlumlordUI*)
    public byte MakeBuyHouseConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, byte>)0x004C9CA0)(ref this);
    // bool __thiscall gmSlumlordUI::MakeRentPaymentByProxyConfirmationDialog(gmSlumlordUI*)
    public byte MakeRentPaymentByProxyConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, byte>)0x004C9EA0)(ref this);
    // UIElementMessageListenResult __thiscall gmSlumlordUI::ListenToElementMessage(gmSlumlordUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSlumlordUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004CA0A0)(ref this, i_rMsg);
}

