namespace ACBindings;

// gmHouseUI
public unsafe struct gmHouseUI
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmHouseUI_vtbl
    public unsafe struct gmHouseUI_vtbl
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
    public ACBindings.HouseData* m_pHouseData;
    public ACBindings.UIElement_ListBox* m_pTextBox;

    // Methods
    // UIElement* __thiscall gmHouseUI::DynamicCast(gmHouseUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, uint, ACBindings.UIElement*>)0x004A28D0)(ref this, i_eType);
    // unsigned int __thiscall gmHouseUI::GetUIElementType(gmHouseUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, uint>)0x004A28F0)(ref this);
    // UIElement* __cdecl gmHouseUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004A2900)(layout, full_desc);
    // void __thiscall gmHouseUI::PostInit(gmHouseUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, void>)0x004A2A40)(ref this);
    // void __cdecl gmHouseUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004A2AC0)();
    // bool __thiscall gmHouseUI::GetHouseLocation(gmHouseUI*,int*,int*)
    public byte GetHouseLocation(int* io_px, int* io_py) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, int*, int*, byte>)0x004A2AE0)(ref this, io_px, io_py);
    // void __thiscall gmHouseUI::AddHousePanelText(_DWORD*,int*,int)
    public void AddHousePanelText(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, int*, int, void>)0x004A2B40)(ref this, a2, a3);
    // void __thiscall gmHouseUI::DisplayBuyPayment(gmHouseUI*)
    public void DisplayBuyPayment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, void>)0x004A2E60)(ref this);
    // void __thiscall gmHouseUI::DisplayRentPayment(gmHouseUI*)
    public void DisplayRentPayment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, void>)0x004A2F50)(ref this);
    // void __thiscall gmHouseUI::DisplayBuyTime(gmHouseUI*)
    public void DisplayBuyTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, void>)0x004A2FF0)(ref this);
    // void __thiscall gmHouseUI::DisplayRentTimes(gmHouseUI*)
    public void DisplayRentTimes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, void>)0x004A3090)(ref this);
    // void __thiscall gmHouseUI::DisplayLocation(gmHouseUI*)
    public void DisplayLocation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, void>)0x004A3210)(ref this);
    // void __thiscall gmHouseUI::DisplayWarningText(gmHouseUI*)
    public void DisplayWarningText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, void>)0x004A3350)(ref this);
    // void __thiscall gmHouseUI::DisplayPurchaseTimeText(gmHouseUI*)
    public void DisplayPurchaseTimeText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, void>)0x004A3440)(ref this);
    // void __thiscall gmHouseUI::DisplayHouseData(gmHouseUI*)
    public void DisplayHouseData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, void>)0x004A36B0)(ref this);
    // void __thiscall gmHouseUI::RecvNotice_UpdateHouseData(gmHouseUI*,const HouseData*)
    public void RecvNotice_UpdateHouseData(ACBindings.HouseData* i_houseData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, ACBindings.HouseData*, void>)0x004A3800)(ref this, i_houseData);
    // void __thiscall gmHouseUI::RecvNotice_FailedHouseTransaction(gmHouseUI*,unsigned int)
    public void RecvNotice_FailedHouseTransaction(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, uint, void>)0x004A3810)(ref this, i_eType);
    // void __thiscall gmHouseUI::RecvNotice_UpdateRentTime(gmHouseUI*,int)
    public void RecvNotice_UpdateRentTime(int i_rentTime) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, int, void>)0x004A3820)(ref this, i_rentTime);
    // void __thiscall gmHouseUI::RecvNotice_UpdateRentPayment(gmHouseUI*,const HousePaymentList*)
    public void RecvNotice_UpdateRentPayment(ACBindings.HousePaymentList* i_rent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmHouseUI, ACBindings.HousePaymentList*, void>)0x004A3850)(ref this, i_rent);
}

