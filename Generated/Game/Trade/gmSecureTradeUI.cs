namespace ACBindings;

// gmSecureTradeUI
public unsafe struct gmSecureTradeUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler
    public ACBindings.ObjectRangeHandler BaseClass_ObjectRangeHandler; // ACBindings.ObjectRangeHandler
    public ACBindings.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.ItemListDragHandler

    // Child Types
    // gmSecureTradeUI_vtbl
    public unsafe struct gmSecureTradeUI_vtbl
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
    public ACBindings.UIElement_Button* m_pTradeButton;
    public ACBindings.UIElement_Text* m_pSelfPlayerName;
    public ACBindings.UIElement_Text* m_pSelfTotalItemsLabel;
    public ACBindings.UIElement_ItemList* m_pSelfItemsList;
    public ACBindings.UIElement* m_pOtherTradeStatusIndicator;
    public ACBindings.UIElement_Text* m_pOtherPlayerName;
    public ACBindings.UIElement_Text* m_pOtherTotalItemsLabel;
    public ACBindings.UIElement_ItemList* m_pOtherItemsList;
    public ACBindings.UIElement_Button* m_pClearAllItemsButton;
    public uint splitItemID;
    public ACBindings.IDClass___tagDataID splitItemClassID;
    public uint splitItemStackSize;

    // Generated Constructor
    public gmSecureTradeUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmSecureTradeUI::~gmSecureTradeUI(gmSecureTradeUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, void>)0x004CA240)(ref this);
    // UIElement* __thiscall gmSecureTradeUI::DynamicCast(gmSecureTradeUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, ACBindings.UIElement*>)0x004CA2C0)(ref this, i_eType);
    // unsigned int __thiscall gmSecureTradeUI::GetUIElementType(gmSecureTradeUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint>)0x004CA2E0)(ref this);
    // void __thiscall gmSecureTradeUI::UpdateTradeButtonState(gmSecureTradeUI*)
    public void UpdateTradeButtonState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, void>)0x004CA2F0)(ref this);
    // void __thiscall gmSecureTradeUI::gmSecureTradeUI(gmSecureTradeUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004CA3B0)(ref this, layout, full_desc);
    // void __thiscall gmSecureTradeUI::RecvNotice_ServerSaysAttemptFailed(gmSecureTradeUI*,unsigned int)
    public void RecvNotice_ServerSaysAttemptFailed(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, void>)0x004CA4B0)(ref this, i_iidItem);
    // void __thiscall gmSecureTradeUI::SetMyItemNumber(gmSecureTradeUI*)
    public void SetMyItemNumber() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, void>)0x004CA4C0)(ref this);
    // void __thiscall gmSecureTradeUI::SetOtherItemNumber(gmSecureTradeUI*)
    public void SetOtherItemNumber() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, void>)0x004CA560)(ref this);
    // void __thiscall gmSecureTradeUI::AcceptTheTrade(gmSecureTradeUI*)
    public void AcceptTheTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, void>)0x004CA600)(ref this);
    // void __thiscall gmSecureTradeUI::DeclineTheTrade(gmSecureTradeUI*)
    public void DeclineTheTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, void>)0x004CA680)(ref this);
    // void __thiscall gmSecureTradeUI::FlushTradeLists(gmSecureTradeUI*)
    public void FlushTradeLists() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, void>)0x004CA6B0)(ref this);
    // void __thiscall gmSecureTradeUI::RemoveItem(gmSecureTradeUI*,ACCWeenieObject*)
    public void RemoveItem(ACBindings.ACCWeenieObject* i_pItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, ACBindings.ACCWeenieObject*, void>)0x004CA7D0)(ref this, i_pItem);
    // void __cdecl gmSecureTradeUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004CA8B0)();
    // void __thiscall gmSecureTradeUI::RecvNotice_AcceptTrade(gmSecureTradeUI*,unsigned int)
    public void RecvNotice_AcceptTrade(uint i_iidSource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, void>)0x004CA8D0)(ref this, i_iidSource);
    // void __thiscall gmSecureTradeUI::RecvNotice_DeclineTrade(gmSecureTradeUI*,unsigned int)
    public void RecvNotice_DeclineTrade(uint i_iidSource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, void>)0x004CA960)(ref this, i_iidSource);
    // void __thiscall gmSecureTradeUI::SetTradePartner(gmSecureTradeUI*,unsigned int)
    public void SetTradePartner(uint i_iidPartner) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, void>)0x004CA9C0)(ref this, i_iidPartner);
    // bool __thiscall gmSecureTradeUI::AddMyItem(gmSecureTradeUI*,unsigned int,unsigned int)
    public byte AddMyItem(uint i_iidItem, uint i_uiPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, uint, byte>)0x004CAA70)(ref this, i_iidItem, i_uiPos);
    // bool __thiscall gmSecureTradeUI::AddPartnerItem(gmSecureTradeUI*,unsigned int,unsigned int)
    public byte AddPartnerItem(uint i_iidItem, uint i_uiPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, uint, byte>)0x004CAB20)(ref this, i_iidItem, i_uiPos);
    // bool __thiscall gmSecureTradeUI::RemoveAddedItem(gmSecureTradeUI*,unsigned int)
    public byte RemoveAddedItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, byte>)0x004CABB0)(ref this, itemID);
    // bool __thiscall gmSecureTradeUI::RemovePartnerItem(gmSecureTradeUI*,unsigned int)
    public byte RemovePartnerItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, byte>)0x004CAC50)(ref this, itemID);
    // void __thiscall gmSecureTradeUI::Reset(gmSecureTradeUI*)
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, void>)0x004CACF0)(ref this);
    // void __thiscall gmSecureTradeUI::PostInit(gmSecureTradeUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, void>)0x004CAD50)(ref this);
    // void __thiscall gmSecureTradeUI::OnVisibilityChanged(gmSecureTradeUI*,bool)
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, byte, void>)0x004CB060)(ref this, i_bVisible);
    // void __thiscall gmSecureTradeUI::RecvNotice_AddItemToTrade(gmSecureTradeUI*,unsigned int,unsigned int,unsigned int)
    public void RecvNotice_AddItemToTrade(uint i_iidItem, uint i_eTradeListID, uint i_uiPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, uint, uint, void>)0x004CB0F0)(ref this, i_iidItem, i_eTradeListID, i_uiPos);
    // void __thiscall gmSecureTradeUI::RecvNotice_ClearTradeAcceptance(gmSecureTradeUI*)
    public void RecvNotice_ClearTradeAcceptance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, void>)0x004CB130)(ref this);
    // void __thiscall gmSecureTradeUI::RecvNotice_CloseTrade(gmSecureTradeUI*,unsigned int)
    public void RecvNotice_CloseTrade(uint i_eError) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, void>)0x004CB140)(ref this, i_eError);
    // void __thiscall gmSecureTradeUI::RecvNotice_RegisterTrade(gmSecureTradeUI*,unsigned int,unsigned int,long double)
    public void RecvNotice_RegisterTrade(uint i_iidInitiator, uint i_iidPartner, double i_ttStamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, uint, double, void>)0x004CB1B0)(ref this, i_iidInitiator, i_iidPartner, i_ttStamp);
    // void __thiscall gmSecureTradeUI::RecvNotice_RemoveItemFromTrade(gmSecureTradeUI*,unsigned int,unsigned int)
    public void RecvNotice_RemoveItemFromTrade(uint i_iidItem, uint i_eTradeListID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, uint, void>)0x004CB220)(ref this, i_iidItem, i_eTradeListID);
    // void __thiscall gmSecureTradeUI::RecvNotice_ResetTrade(gmSecureTradeUI*,unsigned int)
    public void RecvNotice_ResetTrade(uint i_iidSource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, void>)0x004CB260)(ref this, i_iidSource);
    // void __thiscall gmSecureTradeUI::RecvNotice_TradeFailure(gmSecureTradeUI*,unsigned int,unsigned int)
    public void RecvNotice_TradeFailure(uint i_iidItem, uint i_eError) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, uint, void>)0x004CB270)(ref this, i_iidItem, i_eError);
    // bool __thiscall gmSecureTradeUI::DragItemAcceptable(gmSecureTradeUI*,unsigned int,bool)
    public byte DragItemAcceptable(uint i_iidItem, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, byte, byte>)0x004CB290)(ref this, i_iidItem, silent);
    // int __thiscall gmSecureTradeUI::AddItem(gmSecureTradeUI*,unsigned int,int,bool,bool,bool)
    public int AddItem(uint itemID, int position, byte removeDuplicates, byte addContents, byte excludeIfUnacceptable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, int, byte, byte, byte, int>)0x004CB370)(ref this, itemID, position, removeDuplicates, addContents, excludeIfUnacceptable);
    // bool __thiscall gmSecureTradeUI::AcceptDragObject(gmSecureTradeUI*,unsigned int)
    public byte AcceptDragObject(uint i_iidObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, byte>)0x004CB630)(ref this, i_iidObject);
    // void __thiscall gmSecureTradeUI::ServerSaysMoveItem(gmSecureTradeUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)
    public void ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004CB810)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);
    // void __thiscall gmSecureTradeUI::RecvNotice_ServerSaysMoveItem(gmSecureTradeUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)
    public void RecvNotice_ServerSaysMoveItem(uint i_itemID, uint i_oldContainer, uint i_oldWielder, uint i_oldLocation, uint i_newContainer, int i_place, uint i_newWielder, uint i_newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004CB920)(ref this, i_itemID, i_oldContainer, i_oldWielder, i_oldLocation, i_newContainer, i_place, i_newWielder, i_newLocation);
    // void __thiscall gmSecureTradeUI::RecvNotice_ItemAttributesChanged(gmSecureTradeUI*,unsigned int,unsigned int)
    public void RecvNotice_ItemAttributesChanged(uint i_iidObject, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, uint, void>)0x004CB930)(ref this, i_iidObject, i_attrib);
    // bool __thiscall gmSecureTradeUI::TradeAnItemForDummies(gmSecureTradeUI*,unsigned int)
    public byte TradeAnItemForDummies(uint i_iidItemToTrade) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, byte>)0x004CB940)(ref this, i_iidItemToTrade);
    // void __thiscall gmSecureTradeUI::HandleDropRelease(gmSecureTradeUI*,const UIElementMessageInfo*)
    public void HandleDropRelease(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, ACBindings.UIElementMessageInfo*, void>)0x004CBA00)(ref this, i_rMsg);
    // UIElementMessageListenResult __thiscall gmSecureTradeUI::ListenToElementMessage(gmSecureTradeUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004CBA70)(ref this, i_rMsg);
    // void __thiscall gmSecureTradeUI::RecvNotice_TradeAnItemForDummies(gmSecureTradeUI*,unsigned int)
    public void RecvNotice_TradeAnItemForDummies(uint i_iidObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmSecureTradeUI, uint, void>)0x004CBB20)(ref this, i_iidObject);
}

