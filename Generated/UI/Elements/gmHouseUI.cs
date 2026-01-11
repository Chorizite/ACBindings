namespace ACBindings.Internal;

public unsafe struct gmHouseUI
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmHouseUI_vtbl
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
    public ACBindings.Internal.HouseData* m_pHouseData;
    public ACBindings.Internal.UIElement_ListBox* m_pTextBox;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004A28D0
    /// UIElement* __thiscall gmHouseUI::DynamicCast(gmHouseUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, uint, ACBindings.Internal.UIElement*>)0x004A28D0)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004A28F0
    /// unsigned int __thiscall gmHouseUI::GetUIElementType(gmHouseUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, uint>)0x004A28F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A2900
    /// UIElement* __cdecl gmHouseUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004A2900)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004A2A40
    /// void __thiscall gmHouseUI::PostInit(gmHouseUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A2A40)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A2AC0
    /// void __cdecl gmHouseUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004A2AC0)();

    /// <summary>
    /// <code>Offset: 0x004A2AE0
    /// bool __thiscall gmHouseUI::GetHouseLocation(gmHouseUI*,int*,int*)</code>
    /// </summary>
    public byte GetHouseLocation(int* io_px, int* io_py) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, int*, int*, byte>)0x004A2AE0)(ref this, io_px, io_py);

    /// <summary>
    /// <code>Offset: 0x004A2B40
    /// void __thiscall gmHouseUI::AddHousePanelText(_DWORD*,int*,int)</code>
    /// </summary>
    public void AddHousePanelText(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, int*, int, void>)0x004A2B40)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004A2E60
    /// void __thiscall gmHouseUI::DisplayBuyPayment(gmHouseUI*)</code>
    /// </summary>
    public void DisplayBuyPayment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A2E60)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A2F50
    /// void __thiscall gmHouseUI::DisplayRentPayment(gmHouseUI*)</code>
    /// </summary>
    public void DisplayRentPayment() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A2F50)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A2FF0
    /// void __thiscall gmHouseUI::DisplayBuyTime(gmHouseUI*)</code>
    /// </summary>
    public void DisplayBuyTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A2FF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A3090
    /// void __thiscall gmHouseUI::DisplayRentTimes(gmHouseUI*)</code>
    /// </summary>
    public void DisplayRentTimes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A3090)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A3210
    /// void __thiscall gmHouseUI::DisplayLocation(gmHouseUI*)</code>
    /// </summary>
    public void DisplayLocation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A3210)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A3350
    /// void __thiscall gmHouseUI::DisplayWarningText(gmHouseUI*)</code>
    /// </summary>
    public void DisplayWarningText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A3350)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A3440
    /// void __thiscall gmHouseUI::DisplayPurchaseTimeText(gmHouseUI*)</code>
    /// </summary>
    public void DisplayPurchaseTimeText() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A3440)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A36B0
    /// void __thiscall gmHouseUI::DisplayHouseData(gmHouseUI*)</code>
    /// </summary>
    public void DisplayHouseData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, void>)0x004A36B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004A3800
    /// void __thiscall gmHouseUI::RecvNotice_UpdateHouseData(gmHouseUI*,const HouseData*)</code>
    /// </summary>
    public void RecvNotice_UpdateHouseData(ACBindings.Internal.HouseData* i_houseData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, ACBindings.Internal.HouseData*, void>)0x004A3800)(ref this, i_houseData);

    /// <summary>
    /// <code>Offset: 0x004A3810
    /// void __thiscall gmHouseUI::RecvNotice_FailedHouseTransaction(gmHouseUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_FailedHouseTransaction(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, uint, void>)0x004A3810)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004A3820
    /// void __thiscall gmHouseUI::RecvNotice_UpdateRentTime(gmHouseUI*,int)</code>
    /// </summary>
    public void RecvNotice_UpdateRentTime(int i_rentTime) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, int, void>)0x004A3820)(ref this, i_rentTime);

    /// <summary>
    /// <code>Offset: 0x004A3850
    /// void __thiscall gmHouseUI::RecvNotice_UpdateRentPayment(gmHouseUI*,const HousePaymentList*)</code>
    /// </summary>
    public void RecvNotice_UpdateRentPayment(ACBindings.Internal.HousePaymentList* i_rent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmHouseUI, ACBindings.Internal.HousePaymentList*, void>)0x004A3850)(ref this, i_rent);
}

