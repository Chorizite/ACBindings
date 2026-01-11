namespace ACBindings.Internal;

public unsafe struct gmSlumlordUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Panel BaseClass_UIElement_Panel; // ACBindings.Internal.UIElement_Panel
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.ObjectRangeHandler BaseClass_ObjectRangeHandler; // ACBindings.Internal.ObjectRangeHandler
    public ACBindings.Internal.ItemListDragHandler BaseClass_ItemListDragHandler; // ACBindings.Internal.ItemListDragHandler

    // Child Types
    public unsafe struct gmSlumlordUI_vtbl
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
    public uint m_iidOwner;
    public ACBindings.Internal.HouseProfile* m_pHouseProfile;
    public ACBindings.Internal.HouseProfile* m_pBackupHouseProfile;
    public ACBindings.Internal.HouseOp m_eCurrentHouseOp;
    public ACBindings.Internal.UIElement_ItemList* m_pCurItemList;
    public ACBindings.Internal.UIElement_Text* m_pBuyRequirementsText;
    public ACBindings.Internal.UIElement_Text* m_pBuyHouseOwnerText;
    public ACBindings.Internal.UIElement_ItemList* m_pBuyItemList;
    public ACBindings.Internal.UIElement_Button* m_pBuyButton;
    public ACBindings.Internal.UIElement_Text* m_pRentRequirementsText;
    public ACBindings.Internal.UIElement_Text* m_pRentHouseOwnerText;
    public ACBindings.Internal.UIElement_ItemList* m_pRentItemList;
    public ACBindings.Internal.UIElement_Button* m_pRentButton;
    public uint m_uiHousePurchaseDialogContext;
    public uint m_uiRentPaymentByProxyDialogContext;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004C8860
    /// void __thiscall gmSlumlordUI::OnVisibilityChanged(gmSlumlordUI*,bool)</code>
    /// </summary>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte, void>)0x004C8860)(ref this, i_bVisible);

    /// <summary>
    /// <code>Offset: 0x004C88A0
    /// void __thiscall gmSlumlordUI::OnObjectRangeExit(gmSlumlordUI*,unsigned int)</code>
    /// </summary>
    public void OnObjectRangeExit(uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, void>)0x004C88A0)(ref this, objectID);

    /// <summary>
    /// <code>Offset: 0x004C88D0
    /// bool __thiscall gmSlumlordUI::BackupHouseProfile(gmSlumlordUI*)</code>
    /// </summary>
    public byte BackupHouseProfile() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte>)0x004C88D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C8920
    /// bool __thiscall gmSlumlordUI::AmIHouseOwner(gmSlumlordUI*)</code>
    /// </summary>
    public byte AmIHouseOwner() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte>)0x004C8920)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C8950
    /// bool __thiscall gmSlumlordUI::IsPaymentAllowed(gmSlumlordUI*)</code>
    /// </summary>
    public byte IsPaymentAllowed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte>)0x004C8950)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C8AA0
    /// UIElement* __thiscall gmSlumlordUI::DynamicCast(gmSlumlordUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, ACBindings.Internal.UIElement*>)0x004C8AA0)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004C8AC0
    /// unsigned int __thiscall gmSlumlordUI::GetUIElementType(gmSlumlordUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint>)0x004C8AC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C8AD0
    /// void __thiscall gmSlumlordUI::~gmSlumlordUI(gmSlumlordUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, void>)0x004C8AD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C8BB0
    /// void __thiscall gmSlumlordUI::RecvNotice_FailedHouseTransaction(gmSlumlordUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_FailedHouseTransaction(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, void>)0x004C8BB0)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004C8BD0
    /// void __thiscall gmSlumlordUI::UpdateButtons(gmSlumlordUI*)</code>
    /// </summary>
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, void>)0x004C8BD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C8C70
    /// void __thiscall gmSlumlordUI::CleanItemLists(gmSlumlordUI*)</code>
    /// </summary>
    public void CleanItemLists() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, void>)0x004C8C70)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C8CE0
    /// bool __thiscall gmSlumlordUI::AddItem(gmSlumlordUI*,ACCWeenieObject*)</code>
    /// </summary>
    public byte AddItem(ACBindings.Internal.ACCWeenieObject* i_pItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, ACBindings.Internal.ACCWeenieObject*, byte>)0x004C8CE0)(ref this, i_pItem);

    /// <summary>
    /// <code>Offset: 0x004C8DA0
    /// void __thiscall gmSlumlordUI::RemoveItem(gmSlumlordUI*,ACCWeenieObject*)</code>
    /// </summary>
    public void RemoveItem(ACBindings.Internal.ACCWeenieObject* i_pItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, ACBindings.Internal.ACCWeenieObject*, void>)0x004C8DA0)(ref this, i_pItem);

    /// <summary>
    /// <code>Offset: 0x004C8EB0
    /// void __thiscall gmSlumlordUI::PostInit(gmSlumlordUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, void>)0x004C8EB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C90C0
    /// void __cdecl gmSlumlordUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004C90C0)();

    /// <summary>
    /// <code>Offset: 0x004C90E0
    /// void __thiscall gmSlumlordUI::RecvNotice_ItemListBeginDrag(gmSlumlordUI*,const UIElement*,int)</code>
    /// </summary>
    public void RecvNotice_ItemListBeginDrag(ACBindings.Internal.UIElement* i_itemList, int i_slotNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, ACBindings.Internal.UIElement*, int, void>)0x004C90E0)(ref this, i_itemList, i_slotNum);

    /// <summary>
    /// <code>Offset: 0x004C9140
    /// void __thiscall gmSlumlordUI::RecvNotice_ServerSaysMoveItem(gmSlumlordUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004C9140)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>
    /// <code>Offset: 0x004C9190
    /// void __thiscall gmSlumlordUI::RecvNotice_BeingDeleted(gmSlumlordUI*,CWeenieObject*)</code>
    /// </summary>
    public void RecvNotice_BeingDeleted(ACBindings.Internal.CWeenieObject* i_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, ACBindings.Internal.CWeenieObject*, void>)0x004C9190)(ref this, i_obj);

    /// <summary>
    /// <code>Offset: 0x004C91A0
    /// bool __thiscall gmSlumlordUI::AddObject(gmSlumlordUI*,ACCWeenieObject*)</code>
    /// </summary>
    public byte AddObject(ACBindings.Internal.ACCWeenieObject* i_pObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, ACBindings.Internal.ACCWeenieObject*, byte>)0x004C91A0)(ref this, i_pObject);

    /// <summary>
    /// <code>Offset: 0x004C91E0
    /// bool __thiscall gmSlumlordUI::DragItemAcceptable(gmSlumlordUI*,unsigned int,bool)</code>
    /// </summary>
    public byte DragItemAcceptable(uint i_iidItem, byte silent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, byte, byte>)0x004C91E0)(ref this, i_iidItem, silent);

    /// <summary>
    /// <code>Offset: 0x004C92D0
    /// bool __thiscall gmSlumlordUI::AddContainer(gmSlumlordUI*,ACCWeenieObject*)</code>
    /// </summary>
    public byte AddContainer(ACBindings.Internal.ACCWeenieObject* i_pContainer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, ACBindings.Internal.ACCWeenieObject*, byte>)0x004C92D0)(ref this, i_pContainer);

    /// <summary>
    /// <code>Offset: 0x004C93B0
    /// bool __thiscall gmSlumlordUI::AcceptDragObject(gmSlumlordUI*,unsigned int)</code>
    /// </summary>
    public byte AcceptDragObject(uint i_iidItem) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, byte>)0x004C93B0)(ref this, i_iidItem);

    /// <summary>
    /// <code>Offset: 0x004C9530
    /// bool __thiscall gmSlumlordUI::MakePayment(gmSlumlordUI*)</code>
    /// </summary>
    public byte MakePayment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte>)0x004C9530)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C9670
    /// void __thiscall gmSlumlordUI::HandleDropRelease(gmSlumlordUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, ACBindings.Internal.UIElementMessageInfo*, void>)0x004C9670)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004C9710
    /// bool __thiscall gmSlumlordUI::RefreshHouse(gmSlumlordUI*)</code>
    /// </summary>
    public byte RefreshHouse() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte>)0x004C9710)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C9980
    /// bool __thiscall gmSlumlordUI::CloseBuyHouseConfirmationDialog(gmSlumlordUI*,bool)</code>
    /// </summary>
    public byte CloseBuyHouseConfirmationDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte, byte>)0x004C9980)(ref this, i_bConfirm);

    /// <summary>
    /// <code>Offset: 0x004C99E0
    /// bool __thiscall gmSlumlordUI::CloseRentPaymentByProxyConfirmationDialog(gmSlumlordUI*,bool)</code>
    /// </summary>
    public byte CloseRentPaymentByProxyConfirmationDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte, byte>)0x004C99E0)(ref this, i_bConfirm);

    /// <summary>
    /// <code>Offset: 0x004C9A30
    /// void __thiscall gmSlumlordUI::RecvNotice_CloseDialog(gmSlumlordUI*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, ACBindings.Internal.PropertyCollection*, void>)0x004C9A30)(ref this, context, data);

    /// <summary>
    /// <code>Offset: 0x004C9BC0
    /// bool __thiscall gmSlumlordUI::UpdateHouse(gmSlumlordUI*,unsigned int,const HouseProfile*)</code>
    /// </summary>
    public byte UpdateHouse(uint i_iidOwner, ACBindings.Internal.HouseProfile* houseProfile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, ACBindings.Internal.HouseProfile*, byte>)0x004C9BC0)(ref this, i_iidOwner, houseProfile);

    /// <summary>
    /// <code>Offset: 0x004C9C30
    /// void __thiscall gmSlumlordUI::RecvNotice_UpdateHouseProfile(gmSlumlordUI*,unsigned int,const HouseProfile*)</code>
    /// </summary>
    public void RecvNotice_UpdateHouseProfile(uint i_iidOwner, ACBindings.Internal.HouseProfile* i_prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, uint, ACBindings.Internal.HouseProfile*, void>)0x004C9C30)(ref this, i_iidOwner, i_prof);

    /// <summary>
    /// <code>Offset: 0x004C9CA0
    /// bool __thiscall gmSlumlordUI::MakeBuyHouseConfirmationDialog(gmSlumlordUI*)</code>
    /// </summary>
    public byte MakeBuyHouseConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte>)0x004C9CA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C9EA0
    /// bool __thiscall gmSlumlordUI::MakeRentPaymentByProxyConfirmationDialog(gmSlumlordUI*)</code>
    /// </summary>
    public byte MakeRentPaymentByProxyConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, byte>)0x004C9EA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004CA0A0
    /// UIElementMessageListenResult __thiscall gmSlumlordUI::ListenToElementMessage(gmSlumlordUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmSlumlordUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004CA0A0)(ref this, i_rMsg);
}

