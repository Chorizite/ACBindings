namespace ACBindings.Internal;

public unsafe struct gmSecureTradeUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.ObjectRangeHandler BaseClass_ObjectRangeHandler; // ACBindings.Internal.ObjectRangeHandler
    public ACBindings.Internal.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.Internal.ItemListDragHandler

    // Child Types
    public unsafe struct gmSecureTradeUI_vtbl
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

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement_Button* m_pTradeButton;
    public ACBindings.Internal.UIElement_Text* m_pSelfPlayerName;
    public ACBindings.Internal.UIElement_Text* m_pSelfTotalItemsLabel;
    public ACBindings.Internal.UIElement_ItemList* m_pSelfItemsList;
    public ACBindings.Internal.UIElement* m_pOtherTradeStatusIndicator;
    public ACBindings.Internal.UIElement_Text* m_pOtherPlayerName;
    public ACBindings.Internal.UIElement_Text* m_pOtherTotalItemsLabel;
    public ACBindings.Internal.UIElement_ItemList* m_pOtherItemsList;
    public ACBindings.Internal.UIElement_Button* m_pClearAllItemsButton;
    public uint splitItemID;
    public ACBindings.Internal.IDClass____tagDataID splitItemClassID;
    public uint splitItemStackSize;

    // Generated Constructor
    public gmSecureTradeUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004CA240
    /// void __thiscall gmSecureTradeUI::~gmSecureTradeUI(gmSecureTradeUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CA240)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CA2C0
    /// UIElement* __thiscall gmSecureTradeUI::DynamicCast(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, ACBindings.Internal.UIElement*>)0x004CA2C0)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004CA2E0
    /// unsigned int __thiscall gmSecureTradeUI::GetUIElementType(gmSecureTradeUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint>)0x004CA2E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CA2F0
    /// void __thiscall gmSecureTradeUI::UpdateTradeButtonState(gmSecureTradeUI*)</code>
    /// </summary>
    public void UpdateTradeButtonState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CA2F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CA3B0
    /// void __thiscall gmSecureTradeUI::gmSecureTradeUI(gmSecureTradeUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004CA3B0)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004CA4B0
    /// void __thiscall gmSecureTradeUI::RecvNotice_ServerSaysAttemptFailed(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ServerSaysAttemptFailed(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, void>)0x004CA4B0)(ref this, i_iidItem);

    /// <summary>
    /// <code>Offset: 0x004CA4C0
    /// void __thiscall gmSecureTradeUI::SetMyItemNumber(gmSecureTradeUI*)</code>
    /// </summary>
    public void SetMyItemNumber() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CA4C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CA560
    /// void __thiscall gmSecureTradeUI::SetOtherItemNumber(gmSecureTradeUI*)</code>
    /// </summary>
    public void SetOtherItemNumber() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CA560)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CA600
    /// void __thiscall gmSecureTradeUI::AcceptTheTrade(gmSecureTradeUI*)</code>
    /// </summary>
    public void AcceptTheTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CA600)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CA680
    /// void __thiscall gmSecureTradeUI::DeclineTheTrade(gmSecureTradeUI*)</code>
    /// </summary>
    public void DeclineTheTrade() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CA680)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CA6B0
    /// void __thiscall gmSecureTradeUI::FlushTradeLists(gmSecureTradeUI*)</code>
    /// </summary>
    public void FlushTradeLists() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CA6B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CA7D0
    /// void __thiscall gmSecureTradeUI::RemoveItem(gmSecureTradeUI*,ACCWeenieObject*)</code>
    /// </summary>
    public void RemoveItem(ACBindings.Internal.ACCWeenieObject* i_pItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, ACBindings.Internal.ACCWeenieObject*, void>)0x004CA7D0)(ref this, i_pItem);

    /// <summary>
    /// <code>Offset: 0x004CA8B0
    /// void __cdecl gmSecureTradeUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004CA8B0)();

    /// <summary>
    /// <code>Offset: 0x004CA8D0
    /// void __thiscall gmSecureTradeUI::RecvNotice_AcceptTrade(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_AcceptTrade(uint i_iidSource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, void>)0x004CA8D0)(ref this, i_iidSource);

    /// <summary>
    /// <code>Offset: 0x004CA960
    /// void __thiscall gmSecureTradeUI::RecvNotice_DeclineTrade(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_DeclineTrade(uint i_iidSource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, void>)0x004CA960)(ref this, i_iidSource);

    /// <summary>
    /// <code>Offset: 0x004CA9C0
    /// void __thiscall gmSecureTradeUI::SetTradePartner(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    public void SetTradePartner(uint i_iidPartner) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, void>)0x004CA9C0)(ref this, i_iidPartner);

    /// <summary>
    /// <code>Offset: 0x004CAA70
    /// bool __thiscall gmSecureTradeUI::AddMyItem(gmSecureTradeUI*,unsigned int,unsigned int)</code>
    /// </summary>
    public byte AddMyItem(uint i_iidItem, uint i_uiPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, byte>)0x004CAA70)(ref this, i_iidItem, i_uiPos);

    /// <summary>
    /// <code>Offset: 0x004CAB20
    /// bool __thiscall gmSecureTradeUI::AddPartnerItem(gmSecureTradeUI*,unsigned int,unsigned int)</code>
    /// </summary>
    public byte AddPartnerItem(uint i_iidItem, uint i_uiPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, byte>)0x004CAB20)(ref this, i_iidItem, i_uiPos);

    /// <summary>
    /// <code>Offset: 0x004CABB0
    /// bool __thiscall gmSecureTradeUI::RemoveAddedItem(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    public byte RemoveAddedItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, byte>)0x004CABB0)(ref this, itemID);

    /// <summary>
    /// <code>Offset: 0x004CAC50
    /// bool __thiscall gmSecureTradeUI::RemovePartnerItem(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    public byte RemovePartnerItem(uint itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, byte>)0x004CAC50)(ref this, itemID);

    /// <summary>
    /// <code>Offset: 0x004CACF0
    /// void __thiscall gmSecureTradeUI::Reset(gmSecureTradeUI*)</code>
    /// </summary>
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CACF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CAD50
    /// void __thiscall gmSecureTradeUI::PostInit(gmSecureTradeUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CAD50)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CB060
    /// void __thiscall gmSecureTradeUI::OnVisibilityChanged(gmSecureTradeUI*,bool)</code>
    /// </summary>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, byte, void>)0x004CB060)(ref this, i_bVisible);

    /// <summary>
    /// <code>Offset: 0x004CB0F0
    /// void __thiscall gmSecureTradeUI::RecvNotice_AddItemToTrade(gmSecureTradeUI*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_AddItemToTrade(uint i_iidItem, uint i_eTradeListID, uint i_uiPos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, uint, void>)0x004CB0F0)(ref this, i_iidItem, i_eTradeListID, i_uiPos);

    /// <summary>
    /// <code>Offset: 0x004CB130
    /// void __thiscall gmSecureTradeUI::RecvNotice_ClearTradeAcceptance(gmSecureTradeUI*)</code>
    /// </summary>
    public void RecvNotice_ClearTradeAcceptance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, void>)0x004CB130)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CB140
    /// void __thiscall gmSecureTradeUI::RecvNotice_CloseTrade(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_CloseTrade(uint i_eError) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, void>)0x004CB140)(ref this, i_eError);

    /// <summary>
    /// <code>Offset: 0x004CB1B0
    /// void __thiscall gmSecureTradeUI::RecvNotice_RegisterTrade(gmSecureTradeUI*,unsigned int,unsigned int,long double)</code>
    /// </summary>
    public void RecvNotice_RegisterTrade(uint i_iidInitiator, uint i_iidPartner, double i_ttStamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, double, void>)0x004CB1B0)(ref this, i_iidInitiator, i_iidPartner, i_ttStamp);

    /// <summary>
    /// <code>Offset: 0x004CB220
    /// void __thiscall gmSecureTradeUI::RecvNotice_RemoveItemFromTrade(gmSecureTradeUI*,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_RemoveItemFromTrade(uint i_iidItem, uint i_eTradeListID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, void>)0x004CB220)(ref this, i_iidItem, i_eTradeListID);

    /// <summary>
    /// <code>Offset: 0x004CB260
    /// void __thiscall gmSecureTradeUI::RecvNotice_ResetTrade(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ResetTrade(uint i_iidSource) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, void>)0x004CB260)(ref this, i_iidSource);

    /// <summary>
    /// <code>Offset: 0x004CB270
    /// void __thiscall gmSecureTradeUI::RecvNotice_TradeFailure(gmSecureTradeUI*,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_TradeFailure(uint i_iidItem, uint i_eError) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, void>)0x004CB270)(ref this, i_iidItem, i_eError);

    /// <summary>
    /// <code>Offset: 0x004CB290
    /// bool __thiscall gmSecureTradeUI::DragItemAcceptable(gmSecureTradeUI*,unsigned int,bool)</code>
    /// </summary>
    public byte DragItemAcceptable(uint i_iidItem, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, byte, byte>)0x004CB290)(ref this, i_iidItem, silent);

    /// <summary>
    /// <code>Offset: 0x004CB370
    /// int __thiscall gmSecureTradeUI::AddItem(gmSecureTradeUI*,unsigned int,int,bool,bool,bool)</code>
    /// </summary>
    public int AddItem(uint itemID, int position, byte removeDuplicates, byte addContents, byte excludeIfUnacceptable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, int, byte, byte, byte, int>)0x004CB370)(ref this, itemID, position, removeDuplicates, addContents, excludeIfUnacceptable);

    /// <summary>
    /// <code>Offset: 0x004CB630
    /// bool __thiscall gmSecureTradeUI::AcceptDragObject(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    public byte AcceptDragObject(uint i_iidObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, byte>)0x004CB630)(ref this, i_iidObject);

    /// <summary>
    /// <code>Offset: 0x004CB810
    /// void __thiscall gmSecureTradeUI::ServerSaysMoveItem(gmSecureTradeUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    public void ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004CB810)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>
    /// <code>Offset: 0x004CB920
    /// void __thiscall gmSecureTradeUI::RecvNotice_ServerSaysMoveItem(gmSecureTradeUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ServerSaysMoveItem(uint i_itemID, uint i_oldContainer, uint i_oldWielder, uint i_oldLocation, uint i_newContainer, int i_place, uint i_newWielder, uint i_newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004CB920)(ref this, i_itemID, i_oldContainer, i_oldWielder, i_oldLocation, i_newContainer, i_place, i_newWielder, i_newLocation);

    /// <summary>
    /// <code>Offset: 0x004CB930
    /// void __thiscall gmSecureTradeUI::RecvNotice_ItemAttributesChanged(gmSecureTradeUI*,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ItemAttributesChanged(uint i_iidObject, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, uint, void>)0x004CB930)(ref this, i_iidObject, i_attrib);

    /// <summary>
    /// <code>Offset: 0x004CB940
    /// bool __thiscall gmSecureTradeUI::TradeAnItemForDummies(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    public byte TradeAnItemForDummies(uint i_iidItemToTrade) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, byte>)0x004CB940)(ref this, i_iidItemToTrade);

    /// <summary>
    /// <code>Offset: 0x004CBA00
    /// void __thiscall gmSecureTradeUI::HandleDropRelease(gmSecureTradeUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, ACBindings.Internal.UIElementMessageInfo*, void>)0x004CBA00)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004CBA70
    /// UIElementMessageListenResult __thiscall gmSecureTradeUI::ListenToElementMessage(gmSecureTradeUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004CBA70)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004CBB20
    /// void __thiscall gmSecureTradeUI::RecvNotice_TradeAnItemForDummies(gmSecureTradeUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_TradeAnItemForDummies(uint i_iidObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSecureTradeUI, uint, void>)0x004CBB20)(ref this, i_iidObject);
}

