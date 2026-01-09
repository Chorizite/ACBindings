namespace ACBindings;

// gmMapUI
public unsafe struct gmMapUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmMapUI_vtbl
    public unsafe struct gmMapUI_vtbl
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
    // gmMapUI::LocationRolloverInfo
    public unsafe struct LocationRolloverInfo
    {
        // Members
        public uint X;
        public uint Y;
        public uint Width;
        public uint Height;
        public System.IntPtr Name;

        // Methods
    }

    // Members
    public ACBindings.UIElement_Text* m_pDateTimeText;
    public ACBindings.UIElement_Text* m_pCoordinateText;
    public ACBindings.UIElement* m_pPlayerLocationIcon;
    public ACBindings.UIElement* m_pHouseLocationIcon;
    public ACBindings.UIElement* m_pMap;
    public ACBindings.Box2D m_boxMapMarkerArea;
    public double m_nextUpdate;
    public ACBindings.Position m_HousePosition;

    // Generated Constructor
    public gmMapUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmMapUI::RecvNotice_UpdateHouseData(gmMapUI*,const HouseData*)
    public void RecvNotice_UpdateHouseData(ACBindings.HouseData* i_houseData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMapUI, ACBindings.HouseData*, void>)0x004A1BA0)(ref this, i_houseData);
    // void __thiscall gmMapUI::RecvNotice_FailedHouseTransaction(gmMapUI*,unsigned int)
    public void RecvNotice_FailedHouseTransaction(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMapUI, uint, void>)0x004A1BD0)(ref this, i_eType);
    // bool __thiscall gmMapUI::PlaceMarkerOnMap(gmMapUI*,UIElement*,long double,long double)
    public byte PlaceMarkerOnMap(ACBindings.UIElement* i_pMarker, double i_x, double i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMapUI, ACBindings.UIElement*, double, double, byte>)0x004A1BE0)(ref this, i_pMarker, i_x, i_y);
    // void __thiscall gmMapUI::gmMapUI(gmMapUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMapUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004A1D20)(ref this, layout, full_desc);
    // UIElement* __thiscall gmMapUI::DynamicCast(gmMapUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMapUI, uint, ACBindings.UIElement*>)0x004A1DD0)(ref this, i_eType);
    // unsigned int __thiscall gmMapUI::GetUIElementType(gmMapUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMapUI, uint>)0x004A1DF0)(ref this);
    // void __thiscall gmMapUI::~gmMapUI(gmMapUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMapUI, void>)0x004A1E00)(ref this);
    // UIElement* __cdecl gmMapUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004A1E70)(layout, full_desc);
    // void __cdecl gmMapUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004A1EC0)();
    // void __thiscall gmMapUI::AddMapNote(gmMapUI*,UIElement*,unsigned int,const LayoutDesc*,const gmMapUI::LocationRolloverInfo*)
    public void AddMapNote(ACBindings.UIElement* pMap, uint idNote, ACBindings.LayoutDesc* pLayout, ACBindings.gmMapUI.LocationRolloverInfo* lri) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMapUI, ACBindings.UIElement*, uint, ACBindings.LayoutDesc*, ACBindings.gmMapUI.LocationRolloverInfo*, void>)0x004A1EE0)(ref this, pMap, idNote, pLayout, lri);
    // void __thiscall gmMapUI::PostInit(gmMapUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMapUI, void>)0x004A1FA0)(ref this);
    // bool __thiscall gmMapUI::Update(gmMapUI*)
    public byte Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMapUI, byte>)0x004A21E0)(ref this);
    // void __thiscall gmMapUI::ListenToGlobalMessage(gmMapUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMapUI, uint, int, void>)0x004A2650)(ref this, i_messageID, i_data_int);
    // UIElementMessageListenResult __thiscall gmMapUI::ListenToElementMessage(gmMapUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMapUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004A2680)(ref this, i_rMsg);
}

