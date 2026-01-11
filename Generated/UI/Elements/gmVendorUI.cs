namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x004C0EA0
    /// void __stdcall gmVendorUI::SendShopEvent(int,int*,int,int)</code>
    /// </summary>
    public static void SendShopEvent(int requestObjID, int* a2, int a3, int a4) => ((delegate* unmanaged[Stdcall]<int, int*, int, int, void>)0x004C0EA0)(requestObjID, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x004C0F00
    /// void __thiscall gmVendorUI::RecvNotice_SetSelectedItem(gmVendorUI*,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_SetSelectedItem(uint oldSelectedID, uint selectedID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, uint, void>)0x004C0F00)(ref this, oldSelectedID, selectedID);

    /// <summary>
    /// <code>Offset: 0x004C0F40
    /// void __thiscall gmVendorUI::RecvNotice_CloseVendor(gmVendorUI*,bool)</code>
    /// </summary>
    public void RecvNotice_CloseVendor(byte i_bUpdating) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, byte, void>)0x004C0F40)(ref this, i_bUpdating);

    /// <summary>
    /// <code>Offset: 0x004C0F70
    /// void __thiscall gmVendorUI::OnObjectRangeExit(gmVendorUI*,unsigned int)</code>
    /// </summary>
    public void OnObjectRangeExit(uint objectID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, void>)0x004C0F70)(ref this, objectID);

    /// <summary>
    /// <code>Offset: 0x004C0FA0
    /// void __thiscall gmVendorUI::VendorItemSetSellState(gmVendorUI*,unsigned int,int)</code>
    /// </summary>
    public void VendorItemSetSellState(uint itemID, int state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, int, void>)0x004C0FA0)(ref this, itemID, state);

    /// <summary>
    /// <code>Offset: 0x004C0FC0
    /// void __thiscall gmVendorUI::DeleteItem(gmVendorUI*,UIElement_ItemList*,unsigned int,int)</code>
    /// </summary>
    public void DeleteItem(ACBindings.Internal.UIElement_ItemList* uiItemList, uint itemID, int broadcast) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.UIElement_ItemList*, uint, int, void>)0x004C0FC0)(ref this, uiItemList, itemID, broadcast);

    /// <summary>
    /// <code>Offset: 0x004C1010
    /// void __thiscall gmVendorUI::OpenTab(gmVendorUI*,unsigned int)</code>
    /// </summary>
    public void OpenTab(uint tabID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, void>)0x004C1010)(ref this, tabID);

    /// <summary>
    /// <code>Offset: 0x004C1030
    /// void __thiscall gmVendorUI::UpdateDragOver(gmVendorUI*)</code>
    /// </summary>
    public void UpdateDragOver() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, void>)0x004C1030)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C1100
    /// void __thiscall gmVendorUI::ListenToGlobalMessage(gmVendorUI*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, int, void>)0x004C1100)(ref this, i_messageID, i_data_int);

    /// <summary>
    /// <code>Offset: 0x004C1590
    /// void __thiscall gmVendorUI::PostInit(gmVendorUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, void>)0x004C1590)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C1760
    /// char __thiscall gmVendorUI::ShopHasItem(_DWORD*,int,_DWORD*,_DWORD*)</code>
    /// </summary>
    public sbyte ShopHasItem(int a2, int* a3, int* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, int, int*, int*, sbyte>)0x004C1760)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x004C17C0
    /// void __stdcall gmVendorUI::FlushSellListSellState(int)</code>
    /// </summary>
    public static void FlushSellListSellState(int a1) => ((delegate* unmanaged[Stdcall]<int, void>)0x004C17C0)(a1);

    /// <summary>
    /// <code>Offset: 0x004C1800
    /// ACCWeenieObject* __stdcall gmVendorUI::InqListSlotCount(ACCWeenieObject*,_DWORD*,_DWORD*)</code>
    /// </summary>
    public static ACBindings.Internal.ACCWeenieObject* InqListSlotCount(ACBindings.Internal.ACCWeenieObject* a1, int* a2, int* a3) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.ACCWeenieObject*, int*, int*, ACBindings.Internal.ACCWeenieObject*>)0x004C1800)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004C1E50
    /// char __stdcall gmVendorUI::RemoveProfileFromList(_DWORD*,int,int)</code>
    /// </summary>
    public static sbyte RemoveProfileFromList(int* a1, int a2, int a3) => ((delegate* unmanaged[Stdcall]<int*, int, int, sbyte>)0x004C1E50)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004C1F00
    /// char __stdcall gmVendorUI::RecordContents(UIElement_ListBox*,_DWORD*,int,int)</code>
    /// </summary>
    public static sbyte RecordContents(ACBindings.Internal.UIElement_ListBox* a1, int* a2, int a3, int a4) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.UIElement_ListBox*, int*, int, int, sbyte>)0x004C1F00)(a1, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x004C20A0
    /// int __thiscall gmVendorUI::AddItem(gmVendorUI*,UIElement_ItemList*,unsigned int,int,int,int,int,int,int)</code>
    /// </summary>
    public int AddItem(ACBindings.Internal.UIElement_ItemList* uiItemList, uint itemID, int position, int removeDuplicates, int addContents, int excludeIfUnacceptable, int broadcast, int quantityDisp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.UIElement_ItemList*, uint, int, int, int, int, int, int, int>)0x004C20A0)(ref this, uiItemList, itemID, position, removeDuplicates, addContents, excludeIfUnacceptable, broadcast, quantityDisp);

    /// <summary>
    /// <code>Offset: 0x004C3060
    /// void __thiscall gmVendorUI::gmVendorUI(gmVendorUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004C3060)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004C3130
    /// UIElement* __thiscall gmVendorUI::DynamicCast(gmVendorUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, ACBindings.Internal.UIElement*>)0x004C3130)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004C3150
    /// unsigned int __thiscall gmVendorUI::GetUIElementType(gmVendorUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint>)0x004C3150)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C3160
    /// void __thiscall gmVendorUI::~gmVendorUI(gmVendorUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, void>)0x004C3160)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C32C0
    /// void __thiscall gmVendorUI::ResetShopState(gmVendorUI*,bool)</code>
    /// </summary>
    public void ResetShopState(byte updating) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, byte, void>)0x004C32C0)(ref this, updating);

    /// <summary>
    /// <code>Offset: 0x004C3410
    /// bool __thiscall gmVendorUI::BuySingleItem(gmVendorUI*,unsigned int)</code>
    /// </summary>
    public byte BuySingleItem(uint ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, byte>)0x004C3410)(ref this, ID);

    /// <summary>
    /// <code>Offset: 0x004C3730
    /// bool __thiscall gmVendorUI::SellSingleItem(gmVendorUI*,unsigned int)</code>
    /// </summary>
    public byte SellSingleItem(uint ID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, byte>)0x004C3730)(ref this, ID);

    /// <summary>
    /// <code>Offset: 0x004C38F0
    /// void __stdcall gmVendorUI::AdoptAsContents(UIElement_ItemList*,int,char)</code>
    /// </summary>
    public static void AdoptAsContents(ACBindings.Internal.UIElement_ItemList* a1, int a2, sbyte a3) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.UIElement_ItemList*, int, sbyte, void>)0x004C38F0)(a1, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004C3A80
    /// LONG __stdcall gmVendorUI::AddMissingComp(char*,char**)</code>
    /// </summary>
    public static int AddMissingComp(sbyte* Source, sbyte** a2) => ((delegate* unmanaged[Stdcall]<sbyte*, sbyte**, int>)0x004C3A80)(Source, a2);

    /// <summary>
    /// <code>Offset: 0x004C3BF0
    /// void __cdecl gmVendorUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004C3BF0)();

    /// <summary>
    /// <code>Offset: 0x004C3C10
    /// void __thiscall gmVendorUI::CloseVendor(gmVendorUI*,bool)</code>
    /// </summary>
    public void CloseVendor(byte updating) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, byte, void>)0x004C3C10)(ref this, updating);

    /// <summary>
    /// <code>Offset: 0x004C3C70
    /// void __cdecl gmVendorUI::CloseVendorDialogCallback(const PropertyCollection*)</code>
    /// </summary>
    public static void CloseVendorDialogCallback(ACBindings.Internal.PropertyCollection* i_rcResults) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PropertyCollection*, void>)0x004C3C70)(i_rcResults);

    /// <summary>
    /// <code>Offset: 0x004C4410
    /// void __thiscall gmVendorUI::OnVisibilityChanged(gmVendorUI*,bool)</code>
    /// </summary>
    public void OnVisibilityChanged(byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, byte, void>)0x004C4410)(ref this, i_bVisible);

    /// <summary>
    /// <code>Offset: 0x004C4CC0
    /// void __thiscall gmVendorUI::HandleMousePresses(gmVendorUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public void HandleMousePresses(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.UIElementMessageInfo*, void>)0x004C4CC0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004C4F70
    /// void __thiscall gmVendorUI::RecvNotice_ItemListBeginDrag(gmVendorUI*,const UIElement*,int)</code>
    /// </summary>
    public void RecvNotice_ItemListBeginDrag(ACBindings.Internal.UIElement* i_itemList, int i_slotNum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.UIElement*, int, void>)0x004C4F70)(ref this, i_itemList, i_slotNum);

    /// <summary>
    /// <code>Offset: 0x004C5090
    /// void __thiscall gmVendorUI::RecvNotice_ServerSaysMoveItem(gmVendorUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004C5090)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>
    /// <code>Offset: 0x004C50E0
    /// void __thiscall gmVendorUI::RecvNotice_ItemAttributesChanged(gmVendorUI*,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_ItemAttributesChanged(uint i_target, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, uint, void>)0x004C50E0)(ref this, i_target, i_attrib);

    /// <summary>
    /// <code>Offset: 0x004C50F0
    /// void __thiscall gmVendorUI::RecvNotice_StackSliderChanged(gmVendorUI*,unsigned int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_StackSliderChanged(uint i_splitSize, uint i_maxSplitSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, uint, void>)0x004C50F0)(ref this, i_splitSize, i_maxSplitSize);

    /// <summary>
    /// <code>Offset: 0x004C5130
    /// void __thiscall gmVendorUI::FillComponentList(gmVendorUI*,SpellComponentCategory,int)</code>
    /// </summary>
    public void FillComponentList(ACBindings.Internal.SpellComponentCategory sp_cat, int max_to_spend) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.SpellComponentCategory, int, void>)0x004C5130)(ref this, sp_cat, max_to_spend);

    /// <summary>
    /// <code>Offset: 0x004C54D0
    /// void __thiscall gmVendorUI::UpdateTotalValue(gmVendorUI*)</code>
    /// </summary>
    public void UpdateTotalValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, void>)0x004C54D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004C56B0
    /// void __thiscall gmVendorUI::RecvNotice_AddItemToSell(gmVendorUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_AddItemToSell(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, void>)0x004C56B0)(ref this, i_itemID);

    /// <summary>
    /// <code>Offset: 0x004C56C0
    /// void __thiscall gmVendorUI::RecvNotice_FillComponentBuyList(gmVendorUI*,SpellComponentCategory,int)</code>
    /// </summary>
    public void RecvNotice_FillComponentBuyList(ACBindings.Internal.SpellComponentCategory i_sp_cat, int i_max_to_buy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.SpellComponentCategory, int, void>)0x004C56C0)(ref this, i_sp_cat, i_max_to_buy);

    /// <summary>
    /// <code>Offset: 0x004C56D0
    /// void __thiscall gmVendorUI::OnQualityChanged(gmVendorUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    public void OnQualityChanged(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x004C56D0)(ref this, cwobj, stype, senum);

    /// <summary>
    /// <code>Offset: 0x004C5750
    /// void __thiscall gmVendorUI::OnQualityRemoved(gmVendorUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    public void OnQualityRemoved(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x004C5750)(ref this, cwobj, stype, senum);

    /// <summary>
    /// <code>Offset: 0x004C5790
    /// int __thiscall gmVendorUI::OpenVendor(gmVendorUI*,_DWORD*,TResult,int,int)</code>
    /// </summary>
    public int OpenVendor(int* responseObjID, ACBindings.Internal.TResult result, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, int*, ACBindings.Internal.TResult, int, int, int>)0x004C5790)(ref this, responseObjID, result, a4, a5);

    /// <summary>
    /// <code>Offset: 0x004C5CC0
    /// void __thiscall gmVendorUI::HandleButtonClicks(gmVendorUI*,unsigned int)</code>
    /// </summary>
    public void HandleButtonClicks(uint elementID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, uint, void>)0x004C5CC0)(ref this, elementID);

    /// <summary>
    /// <code>Offset: 0x004C6270
    /// void __thiscall gmVendorUI::HandleDropRelease(gmVendorUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public void HandleDropRelease(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.UIElementMessageInfo*, void>)0x004C6270)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004C62E0
    /// int __thiscall gmVendorUI::RecvNotice_OpenVendor(char*,_DWORD*,TResult,int,int)</code>
    /// </summary>
    public int RecvNotice_OpenVendor(int* a2, ACBindings.Internal.TResult a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, int*, ACBindings.Internal.TResult, int, int, int>)0x004C62E0)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x004C62F0
    /// UIElementMessageListenResult __thiscall gmVendorUI::ListenToElementMessage(gmVendorUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmVendorUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004C62F0)(ref this, i_rMsg);
}

