namespace ACBindings.Internal;

public unsafe struct gmRadarUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindings.Internal.QualityChangeHandler

    // Child Types
    public unsafe struct gmRadarUI_vtbl
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmRadarUI*, void> UpdateFromPlayerModule; // function pointer

        // Methods
    }

    // Members
    public float m_fRadarRange;
    public ACBindings.Internal.SmartArray___RadarInfo m_aRadarInfos;
    public uint m_iidObjectUnderMouse;
    public float m_fPlayerHeading;
    public ACBindings.Internal.Vector2 m_vecCenterPoint;
    public int m_nRadarRadius;
    public float m_fNorthTokenMagnitude;
    public float m_fEastTokenMagnitude;
    public float m_fSouthTokenMagnitude;
    public float m_fWestTokenMagnitude;
    public ACBindings.Internal.UIElement* m_pNorthToken;
    public ACBindings.Internal.UIElement* m_pEastToken;
    public ACBindings.Internal.UIElement* m_pSouthToken;
    public ACBindings.Internal.UIElement* m_pWestToken;
    public ACBindings.Internal.UIElement* m_pCoordinateContainerField;
    public ACBindings.Internal.UIElement_Text* m_pCombinedCoordsText;
    public ACBindings.Internal.UIElement_Text* m_pXCoordText;
    public ACBindings.Internal.UIElement_Text* m_pYCoordText;
    public ACBindings.Internal.UIElement* m_pLockUIButton;
    public ACBindings.Internal.UIElement* m_pDragButton;
    public double m_ttNextUpdateTime;
    public double m_fCurXCoord;
    public double m_fCurYCoord;
    public uint m_eWindowID;

    // Generated Constructor
    public gmRadarUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004D8210
    /// UIElementMessageListenResult __thiscall gmRadarUI::ListenToElementMessage(gmRadarUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004D8210)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004D82E0
    /// void __thiscall gmRadarUI::UpdateLockedStatus(gmRadarUI*)</code>
    /// </summary>
    public void UpdateLockedStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, void>)0x004D82E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004D8350
    /// RGBAColor* __cdecl gmRadarUI::GetBlipColor(RGBAColor*,ACCWeenieObject*)</code>
    /// </summary>
    public static ACBindings.Internal.RGBAColor* GetBlipColor(ACBindings.Internal.RGBAColor* result, ACBindings.Internal.ACCWeenieObject* i_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RGBAColor*, ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.RGBAColor*>)0x004D8350)(result, i_obj);

    /// <summary>
    /// <code>Offset: 0x004D87C0
    /// RadarBlipShape __thiscall gmRadarUI::GetBlipShape(gmRadarUI*,ACCWeenieObject*)</code>
    /// </summary>
    public ACBindings.Internal.RadarBlipShape GetBlipShape(ACBindings.Internal.ACCWeenieObject* i_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.ACCWeenieObject*, ACBindings.Internal.RadarBlipShape>)0x004D87C0)(ref this, i_obj);

    /// <summary>
    /// <code>Offset: 0x004D8890
    /// void __thiscall gmRadarUI::DrawPoint(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    public void DrawPoint(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D8890)(ref this, i_pSurface, color, x, y);

    /// <summary>
    /// <code>Offset: 0x004D88D0
    /// void __thiscall gmRadarUI::DrawEdges(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    public void DrawEdges(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D88D0)(ref this, i_pSurface, color, x, y);

    /// <summary>
    /// <code>Offset: 0x004D8980
    /// void __thiscall gmRadarUI::DrawCorners(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    public void DrawCorners(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D8980)(ref this, i_pSurface, color, x, y);

    /// <summary>
    /// <code>Offset: 0x004D8A40
    /// void __thiscall gmRadarUI::DrawCross(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    public void DrawCross(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D8A40)(ref this, i_pSurface, color, x, y);

    /// <summary>
    /// <code>Offset: 0x004D8A90
    /// void __thiscall gmRadarUI::DrawX(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    public void DrawX(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D8A90)(ref this, i_pSurface, color, x, y);

    /// <summary>
    /// <code>Offset: 0x004D8AE0
    /// void __thiscall gmRadarUI::DrawTriangle(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    public void DrawTriangle(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D8AE0)(ref this, i_pSurface, color, x, y);

    /// <summary>
    /// <code>Offset: 0x004D8B90
    /// void __thiscall gmRadarUI::DrawInvertedTriangle(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    public void DrawInvertedTriangle(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D8B90)(ref this, i_pSurface, color, x, y);

    /// <summary>
    /// <code>Offset: 0x004D8C40
    /// void __thiscall gmRadarUI::DrawSelected(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    public void DrawSelected(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D8C40)(ref this, i_pSurface, color, x, y);

    /// <summary>
    /// <code>Offset: 0x004D8E00
    /// void __thiscall gmRadarUI::MoveTo(gmRadarUI*,const int,const int)</code>
    /// </summary>
    public void MoveTo(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, int, int, void>)0x004D8E00)(ref this, i_x, i_y);

    /// <summary>
    /// <code>Offset: 0x004D8FF0
    /// void __thiscall gmRadarUI::RemoveObject(gmRadarUI*,ACCWeenieObject*)</code>
    /// </summary>
    public void RemoveObject(ACBindings.Internal.ACCWeenieObject* i_pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.ACCWeenieObject*, void>)0x004D8FF0)(ref this, i_pObj);

    /// <summary>
    /// <code>Offset: 0x004D9070
    /// RGBAColor* __cdecl gmRadarUI::GetBlipColor(RGBAColor*,unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.RGBAColor* GetBlipColor(ACBindings.Internal.RGBAColor* result, uint i_iid) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.RGBAColor*, uint, ACBindings.Internal.RGBAColor*>)0x004D9070)(result, i_iid);

    /// <summary>
    /// <code>Offset: 0x004D9090
    /// void __thiscall gmRadarUI::DrawHollow(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    public void DrawHollow(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D9090)(ref this, i_pSurface, color, x, y);

    /// <summary>
    /// <code>Offset: 0x004D90D0
    /// void __thiscall gmRadarUI::DrawXBox(gmRadarUI*,UISurface*,const RGBAColor*,int,int)</code>
    /// </summary>
    public void DrawXBox(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RGBAColor* color, int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RGBAColor*, int, int, void>)0x004D90D0)(ref this, i_pSurface, color, x, y);

    /// <summary>
    /// <code>Offset: 0x004D91A0
    /// void __thiscall gmRadarUI::UpdateFromPlayerModule(gmRadarUI*)</code>
    /// </summary>
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, void>)0x004D91A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004D9400
    /// void __thiscall gmRadarUI::gmRadarUI(gmRadarUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004D9400)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004D9510
    /// UIElement* __thiscall gmRadarUI::DynamicCast(gmRadarUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, uint, ACBindings.Internal.UIElement*>)0x004D9510)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004D9540
    /// void __thiscall gmRadarUI::~gmRadarUI(gmRadarUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, void>)0x004D9540)(ref this);

    /// <summary>
    /// <code>Offset: 0x004D95D0
    /// UIElement* __cdecl gmRadarUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x004D95D0)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004D9600
    /// void __thiscall gmRadarUI::RecvNotice_BeingDeleted(gmRadarUI*,CWeenieObject*)</code>
    /// </summary>
    public void RecvNotice_BeingDeleted(ACBindings.Internal.CWeenieObject* i_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.CWeenieObject*, void>)0x004D9600)(ref this, i_obj);

    /// <summary>
    /// <code>Offset: 0x004D9610
    /// void __thiscall gmRadarUI::UpdateRadarLook(gmRadarUI*,ACCWeenieObject*)</code>
    /// </summary>
    public void UpdateRadarLook(ACBindings.Internal.ACCWeenieObject* i_pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.ACCWeenieObject*, void>)0x004D9610)(ref this, i_pObj);

    /// <summary>
    /// <code>Offset: 0x004D9690
    /// void __thiscall gmRadarUI::DrawBlip(gmRadarUI*,UISurface*,const RadarInfo*,float,int,int,bool)</code>
    /// </summary>
    public void DrawBlip(ACBindings.Internal.UISurface* i_pSurface, ACBindings.Internal.RadarInfo* info, float intensity, int x, int y, byte selected) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, ACBindings.Internal.RadarInfo*, float, int, int, byte, void>)0x004D9690)(ref this, i_pSurface, info, intensity, x, y, selected);

    /// <summary>
    /// <code>Offset: 0x004D97E0
    /// void __cdecl gmRadarUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004D97E0)();

    /// <summary>
    /// <code>Offset: 0x004D9800
    /// void __thiscall gmRadarUI::RecvNotice_ChangeRadarLook(gmRadarUI*,CWeenieObject*)</code>
    /// </summary>
    public void RecvNotice_ChangeRadarLook(ACBindings.Internal.CWeenieObject* i_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.CWeenieObject*, void>)0x004D9800)(ref this, i_obj);

    /// <summary>
    /// <code>Offset: 0x004D9810
    /// void __thiscall gmRadarUI::OnQualityChanged(gmRadarUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    public void OnQualityChanged(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x004D9810)(ref this, cwobj, stype, senum);

    /// <summary>
    /// <code>Offset: 0x004D98C0
    /// void __thiscall gmRadarUI::OnQualityRemoved(gmRadarUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    public void OnQualityRemoved(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, void>)0x004D98C0)(ref this, cwobj, stype, senum);

    /// <summary>
    /// <code>Offset: 0x004D98E0
    /// void __thiscall gmRadarUI::UpdateCoordinates(gmRadarUI*)</code>
    /// </summary>
    public void UpdateCoordinates() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, void>)0x004D98E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004D9CC0
    /// void __thiscall gmRadarUI::UpdateCompassTokens(gmRadarUI*)</code>
    /// </summary>
    public void UpdateCompassTokens() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, void>)0x004D9CC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004D9FE0
    /// void __thiscall gmRadarUI::DrawObjects(gmRadarUI*,UISurface*)</code>
    /// </summary>
    public void DrawObjects(ACBindings.Internal.UISurface* i_pSurface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.UISurface*, void>)0x004D9FE0)(ref this, i_pSurface);

    /// <summary>
    /// <code>Offset: 0x004DA380
    /// char __thiscall gmRadarUI::DrawChildren(gmRadarUI*,_DWORD*,Box2D*,int,UISurface*)</code>
    /// </summary>
    public sbyte DrawChildren(int* a2, ACBindings.Internal.Box2D* a3, int a4, ACBindings.Internal.UISurface* i_pSurface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, int*, ACBindings.Internal.Box2D*, int, ACBindings.Internal.UISurface*, sbyte>)0x004DA380)(ref this, a2, a3, a4, i_pSurface);

    /// <summary>
    /// <code>Offset: 0x004DA500
    /// void __thiscall gmRadarUI::UseTime(gmRadarUI*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, void>)0x004DA500)(ref this);

    /// <summary>
    /// <code>Offset: 0x004DA640
    /// void __thiscall gmRadarUI::ListenToGlobalMessage(gmRadarUI*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, uint, int, void>)0x004DA640)(ref this, i_messageID, i_data_int);

    /// <summary>
    /// <code>Offset: 0x004DA660
    /// void __thiscall gmRadarUI::AddObject(gmRadarUI*,ACCWeenieObject*)</code>
    /// </summary>
    public void AddObject(ACBindings.Internal.ACCWeenieObject* i_pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.ACCWeenieObject*, void>)0x004DA660)(ref this, i_pObj);

    /// <summary>
    /// <code>Offset: 0x004DA7C0
    /// void __thiscall gmRadarUI::RecvNotice_CreateObject(gmRadarUI*,unsigned int)</code>
    /// </summary>
    public void RecvNotice_CreateObject(uint i_iidObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, uint, void>)0x004DA7C0)(ref this, i_iidObject);

    /// <summary>
    /// <code>Offset: 0x004DA7F0
    /// void __thiscall gmRadarUI::Init(gmRadarUI*)</code>
    /// </summary>
    public void Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, void>)0x004DA7F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004DA990
    /// void __thiscall gmRadarUI::PostInit(gmRadarUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, void>)0x004DA990)(ref this);

    /// <summary>
    /// <code>Offset: 0x004DAFE0
    /// void __thiscall gmRadarUI::RecvNotice_PlayerDescReceived(gmRadarUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmRadarUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004DAFE0)(ref this, i_playerDesc, i_playerModule);
}

