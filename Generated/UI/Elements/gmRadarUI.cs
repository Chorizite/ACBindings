namespace ACBindings;

// gmRadarUI
public unsafe struct gmRadarUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler
    public ACBindings.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.QualityChangeHandler

    // Child Types
    // gmRadarUI_vtbl
    public unsafe struct gmRadarUI_vtbl
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
        public System.IntPtr UpdateFromPlayerModule; // function pointer

        // Methods
    }

    // Members
    public float m_fRadarRange;
    public ACBindings.SmartArray__RadarInfo m_aRadarInfos;
    public uint m_iidObjectUnderMouse;
    public float m_fPlayerHeading;
    public ACBindings.Vector2 m_vecCenterPoint;
    public int m_nRadarRadius;
    public float m_fNorthTokenMagnitude;
    public float m_fEastTokenMagnitude;
    public float m_fSouthTokenMagnitude;
    public float m_fWestTokenMagnitude;
    public ACBindings.UIElement* m_pNorthToken;
    public ACBindings.UIElement* m_pEastToken;
    public ACBindings.UIElement* m_pSouthToken;
    public ACBindings.UIElement* m_pWestToken;
    public ACBindings.UIElement* m_pCoordinateContainerField;
    public ACBindings.UIElement_Text* m_pCombinedCoordsText;
    public ACBindings.UIElement_Text* m_pXCoordText;
    public ACBindings.UIElement_Text* m_pYCoordText;
    public ACBindings.UIElement* m_pLockUIButton;
    public ACBindings.UIElement* m_pDragButton;
    public double m_ttNextUpdateTime;
    public double m_fCurXCoord;
    public double m_fCurYCoord;
    public uint m_eWindowID;

    // Generated Constructor
    public gmRadarUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // UIElementMessageListenResult __thiscall gmRadarUI::ListenToElementMessage(gmRadarUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004D8210)(ref this, i_rMsg);
    // void __thiscall gmRadarUI::UpdateLockedStatus(gmRadarUI*)
    public void UpdateLockedStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, void>)0x004D82E0)(ref this);
    // RGBAColor* __cdecl gmRadarUI::GetBlipColor(RGBAColor*,ACCWeenieObject*)
    public static ACBindings.RGBAColor* GetBlipColor(ACBindings.RGBAColor* result, ACBindings.ACCWeenieObject* i_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.RGBAColor*, ACBindings.ACCWeenieObject*, ACBindings.RGBAColor*>)0x004D8350)(result, i_obj);
    // RadarBlipShape __thiscall gmRadarUI::GetBlipShape(gmRadarUI*,ACCWeenieObject*)
    public ACBindings.RadarBlipShape GetBlipShape(ACBindings.ACCWeenieObject* i_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.ACCWeenieObject*, ACBindings.RadarBlipShape>)0x004D87C0)(ref this, i_obj);
    // void __thiscall gmRadarUI::DrawPoint(gmRadarUI*,UISurface*,const RGBAColor*,int,int)
    public void DrawPoint(ACBindings.UISurface* i_pSurface, ACBindings.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.UISurface*, ACBindings.RGBAColor*, int, int, void>)0x004D8890)(ref this, i_pSurface, color, x, y);
    // void __thiscall gmRadarUI::DrawEdges(gmRadarUI*,UISurface*,const RGBAColor*,int,int)
    public void DrawEdges(ACBindings.UISurface* i_pSurface, ACBindings.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.UISurface*, ACBindings.RGBAColor*, int, int, void>)0x004D88D0)(ref this, i_pSurface, color, x, y);
    // void __thiscall gmRadarUI::DrawCorners(gmRadarUI*,UISurface*,const RGBAColor*,int,int)
    public void DrawCorners(ACBindings.UISurface* i_pSurface, ACBindings.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.UISurface*, ACBindings.RGBAColor*, int, int, void>)0x004D8980)(ref this, i_pSurface, color, x, y);
    // void __thiscall gmRadarUI::DrawCross(gmRadarUI*,UISurface*,const RGBAColor*,int,int)
    public void DrawCross(ACBindings.UISurface* i_pSurface, ACBindings.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.UISurface*, ACBindings.RGBAColor*, int, int, void>)0x004D8A40)(ref this, i_pSurface, color, x, y);
    // void __thiscall gmRadarUI::DrawX(gmRadarUI*,UISurface*,const RGBAColor*,int,int)
    public void DrawX(ACBindings.UISurface* i_pSurface, ACBindings.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.UISurface*, ACBindings.RGBAColor*, int, int, void>)0x004D8A90)(ref this, i_pSurface, color, x, y);
    // void __thiscall gmRadarUI::DrawTriangle(gmRadarUI*,UISurface*,const RGBAColor*,int,int)
    public void DrawTriangle(ACBindings.UISurface* i_pSurface, ACBindings.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.UISurface*, ACBindings.RGBAColor*, int, int, void>)0x004D8AE0)(ref this, i_pSurface, color, x, y);
    // void __thiscall gmRadarUI::DrawInvertedTriangle(gmRadarUI*,UISurface*,const RGBAColor*,int,int)
    public void DrawInvertedTriangle(ACBindings.UISurface* i_pSurface, ACBindings.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.UISurface*, ACBindings.RGBAColor*, int, int, void>)0x004D8B90)(ref this, i_pSurface, color, x, y);
    // void __thiscall gmRadarUI::DrawSelected(gmRadarUI*,UISurface*,const RGBAColor*,int,int)
    public void DrawSelected(ACBindings.UISurface* i_pSurface, ACBindings.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.UISurface*, ACBindings.RGBAColor*, int, int, void>)0x004D8C40)(ref this, i_pSurface, color, x, y);
    // void __thiscall gmRadarUI::MoveTo(gmRadarUI*,const int,const int)
    public void MoveTo(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, int, int, void>)0x004D8E00)(ref this, i_x, i_y);
    // void __thiscall gmRadarUI::RemoveObject(gmRadarUI*,ACCWeenieObject*)
    public void RemoveObject(ACBindings.ACCWeenieObject* i_pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.ACCWeenieObject*, void>)0x004D8FF0)(ref this, i_pObj);
    // RGBAColor* __cdecl gmRadarUI::GetBlipColor(RGBAColor*,unsigned int)
    public static ACBindings.RGBAColor* GetBlipColor(ACBindings.RGBAColor* result, uint i_iid) => ((delegate* unmanaged[Cdecl]<ACBindings.RGBAColor*, uint, ACBindings.RGBAColor*>)0x004D9070)(result, i_iid);
    // void __thiscall gmRadarUI::DrawHollow(gmRadarUI*,UISurface*,const RGBAColor*,int,int)
    public void DrawHollow(ACBindings.UISurface* i_pSurface, ACBindings.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.UISurface*, ACBindings.RGBAColor*, int, int, void>)0x004D9090)(ref this, i_pSurface, color, x, y);
    // void __thiscall gmRadarUI::DrawXBox(gmRadarUI*,UISurface*,const RGBAColor*,int,int)
    public void DrawXBox(ACBindings.UISurface* i_pSurface, ACBindings.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.UISurface*, ACBindings.RGBAColor*, int, int, void>)0x004D90D0)(ref this, i_pSurface, color, x, y);
    // void __thiscall gmRadarUI::UpdateFromPlayerModule(gmRadarUI*)
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, void>)0x004D91A0)(ref this);
    // void __thiscall gmRadarUI::gmRadarUI(gmRadarUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004D9400)(ref this, layout, full_desc);
    // UIElement* __thiscall gmRadarUI::DynamicCast(gmRadarUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, uint, ACBindings.UIElement*>)0x004D9510)(ref this, i_eType);
    // void __thiscall gmRadarUI::~gmRadarUI(gmRadarUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, void>)0x004D9540)(ref this);
    // UIElement* __cdecl gmRadarUI::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x004D95D0)(layout, full_desc);
    // void __thiscall gmRadarUI::RecvNotice_BeingDeleted(gmRadarUI*,CWeenieObject*)
    public void RecvNotice_BeingDeleted(ACBindings.CWeenieObject* i_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.CWeenieObject*, void>)0x004D9600)(ref this, i_obj);
    // void __thiscall gmRadarUI::UpdateRadarLook(gmRadarUI*,ACCWeenieObject*)
    public void UpdateRadarLook(ACBindings.ACCWeenieObject* i_pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.ACCWeenieObject*, void>)0x004D9610)(ref this, i_pObj);
    // void __thiscall gmRadarUI::DrawBlip(gmRadarUI*,UISurface*,const RadarInfo*,float,int,int,bool)
    public void DrawBlip(ACBindings.UISurface* i_pSurface, ACBindings.RadarInfo* info, float intensity, int x, int y, byte selected) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.UISurface*, ACBindings.RadarInfo*, float, int, int, byte, void>)0x004D9690)(ref this, i_pSurface, info, intensity, x, y, selected);
    // void __cdecl gmRadarUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004D97E0)();
    // void __thiscall gmRadarUI::RecvNotice_ChangeRadarLook(gmRadarUI*,CWeenieObject*)
    public void RecvNotice_ChangeRadarLook(ACBindings.CWeenieObject* i_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.CWeenieObject*, void>)0x004D9800)(ref this, i_obj);
    // void __thiscall gmRadarUI::OnQualityChanged(gmRadarUI*,CWeenieObject*,StatType,unsigned int)
    public void OnQualityChanged(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.CWeenieObject*, ACBindings.StatType, uint, void>)0x004D9810)(ref this, cwobj, stype, senum);
    // void __thiscall gmRadarUI::OnQualityRemoved(gmRadarUI*,CWeenieObject*,StatType,unsigned int)
    public void OnQualityRemoved(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.CWeenieObject*, ACBindings.StatType, uint, void>)0x004D98C0)(ref this, cwobj, stype, senum);
    // void __thiscall gmRadarUI::UpdateCoordinates(gmRadarUI*)
    public void UpdateCoordinates() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, void>)0x004D98E0)(ref this);
    // void __thiscall gmRadarUI::UpdateCompassTokens(gmRadarUI*)
    public void UpdateCompassTokens() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, void>)0x004D9CC0)(ref this);
    // void __thiscall gmRadarUI::DrawObjects(gmRadarUI*,UISurface*)
    public void DrawObjects(ACBindings.UISurface* i_pSurface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.UISurface*, void>)0x004D9FE0)(ref this, i_pSurface);
    // char __thiscall gmRadarUI::DrawChildren(gmRadarUI*,_DWORD*,Box2D*,int,UISurface*)
    public sbyte DrawChildren(int* a2, ACBindings.Box2D* a3, int a4, ACBindings.UISurface* i_pSurface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, int*, ACBindings.Box2D*, int, ACBindings.UISurface*, sbyte>)0x004DA380)(ref this, a2, a3, a4, i_pSurface);
    // void __thiscall gmRadarUI::UseTime(gmRadarUI*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, void>)0x004DA500)(ref this);
    // void __thiscall gmRadarUI::ListenToGlobalMessage(gmRadarUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, uint, int, void>)0x004DA640)(ref this, i_messageID, i_data_int);
    // void __thiscall gmRadarUI::AddObject(gmRadarUI*,ACCWeenieObject*)
    public void AddObject(ACBindings.ACCWeenieObject* i_pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.ACCWeenieObject*, void>)0x004DA660)(ref this, i_pObj);
    // void __thiscall gmRadarUI::RecvNotice_CreateObject(gmRadarUI*,unsigned int)
    public void RecvNotice_CreateObject(uint i_iidObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, uint, void>)0x004DA7C0)(ref this, i_iidObject);
    // void __thiscall gmRadarUI::Init(gmRadarUI*)
    public void Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, void>)0x004DA7F0)(ref this);
    // void __thiscall gmRadarUI::PostInit(gmRadarUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, void>)0x004DA990)(ref this);
    // void __thiscall gmRadarUI::RecvNotice_PlayerDescReceived(gmRadarUI*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmRadarUI, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x004DAFE0)(ref this, i_playerDesc, i_playerModule);
}

