namespace ACBindings.Internal;

public unsafe struct gmCGAppearancePage
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmCGAppearancePage_vtbl
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
    // gmCGAppearancePage::EGender
    public enum EGender : uint
    {
    }
    // gmCGAppearancePage::EParts
    public enum EParts : byte
    {
        ECG_PARTS_INVALID = 0x0,
        ECG_PARTS_HAIR = 0x1,
        ECG_PARTS_EYES = 0x2,
        ECG_PARTS_NOSE = 0x3,
        ECG_PARTS_MOUTH = 0x4,
        ECG_PARTS_SKIN = 0x5,
        ECG_PARTS_HEADGEAR = 0x6,
        ECG_PARTS_SHIRT = 0x7,
        ECG_PARTS_TROUSERS = 0x8,
        ECG_PARTS_FOOTWEAR = 0x9
    }
    // gmCGAppearancePage::ERotateDirection
    public enum ERotateDirection : byte
    {
        ECG_ROTATE_INVALID = 0x0,
        ECG_ROTATE_CLOCKWISE = 0x1,
        ECG_ROTATE_COUNTERCLOCKWISE = 0x2
    }
    // gmCGAppearancePage::EType
    public enum EType : byte
    {
        ECG_CHOICE_INVALID = 0x0,
        ECG_CHOICE_FACE = 0x1,
        ECG_CHOICE_CLOTHES = 0x2
    }
    public unsafe struct tagChoices
    {
        // Members
        public int iNumChoices;
        public int iCurrentChoice;
        public int iNumColors;
        public int iCurrentColor;
        public double dShade;

        // Methods
    }
    public unsafe struct tagColorWheel
    {
        // Members
        public uint iRed;
        public uint iGreen;
        public uint iBlue;
        public ACBindings.Internal.UIElement* pColor;
        public ACBindings.Internal.UIElement* pPointer;
        public ACBindings.Internal.Graphic* pGraphic;
        public ACBindings.Internal.gmCGAppearancePage.EParts ePart;

        // Methods
    }

    // Members
    public ACBindings.Internal.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.Internal.gmCharGenMainUI* m_pMainFramework;
    public ACBindings.Internal.UIElement_Button* m_pFemaleButton;
    public ACBindings.Internal.UIElement_Button* m_pMaleButton;
    public ACBindings.Internal.UIElement_Button* m_pFaceButton;
    public ACBindings.Internal.UIElement_Button* m_pClothesButton;
    public ACBindings.Internal.UIElement_Button* m_pZoomInButton;
    public ACBindings.Internal.UIElement_Button* m_pZoomOutButton;
    public ACBindings.Internal.UIElement_Button* m_pRotateClockButton;
    public ACBindings.Internal.UIElement_Button* m_pRotateCounterClockButton;
    public ACBindings.Internal.UIElement_Button* m_pHairSpin;
    public ACBindings.Internal.UIElement_Button* m_pEyesSpin;
    public ACBindings.Internal.UIElement_Button* m_pNoseSpin;
    public ACBindings.Internal.UIElement_Button* m_pMouthSpin;
    public ACBindings.Internal.UIElement_Button* m_pSkinSpin;
    public ACBindings.Internal.UIElement_Button* m_pHeadgearSpin;
    public ACBindings.Internal.UIElement_Button* m_pShirtSpin;
    public ACBindings.Internal.UIElement_Button* m_pTrousersSpin;
    public ACBindings.Internal.UIElement_Button* m_pFootwearSpin;
    public ACBindings.Internal.UIElement_Scrollbar* m_pShadeScroll;
    public ACBindings.Internal.UIElement* m_pFaceChoices;
    public ACBindings.Internal.UIElement* m_pClothesChoices;
    public ACBindings.Internal.UIElement* m_pGradCircle;
    public ACBindings.Internal.Graphic* m_pGradGraphic;
    public ACBindings.Internal.Graphic* m_pGradPlug;
    public ACBindings.Internal.UIElement* m_pCurSelection;
    public ACBindings.Internal.UIElement_Viewport* m_pViewport;
    public ACBindings.Internal.gmCG3DView* m_p3DView;
    public int m_iCurColor;
    public int m_iPartIndex;
    public int m_iHoldheadgear;
    public byte m_bShouldZoomAnimate;
    public byte m_bRotating;
    public byte m_bZoomedIn;
    public ACBindings.Internal.AC1Legacy.Vector3 m_vectTargPosition;
    public ACBindings.Internal.AC1Legacy.Vector3 m_vectStartPosition;
    public ACBindings.Internal.AC1Legacy.Vector3 m_vectCurPosition;
    public ACBindings.Internal.AC1Legacy.Vector3 m_vectTargDirection;
    public ACBindings.Internal.AC1Legacy.Vector3 m_vectStartDirection;
    public ACBindings.Internal.AC1Legacy.Vector3 m_vectCurDirection;
    public float m_fCurHeading;
    public float m_fTargHeading;
    public double m_dAnimStartTime;
    public double m_dAnimDuration;
    public double m_dLastRotateTime;
    public double m_dRotationPerSec;
    public uint m_LastHeritageGroup;
    public ACBindings.Internal.gmCGAppearancePage.ERotateDirection m_eRotateDir;
    public ACBindings.Internal.gmCGAppearancePage.EType m_eCurType;
    public fixed byte m_tChoices_Raw[216];
    public ACBindings.Internal.gmCGAppearancePage.tagChoices* m_tChoices => (ACBindings.Internal.gmCGAppearancePage.tagChoices*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_tChoices_Raw[0]);
    public ACBindings.Internal.gmCGAppearancePage.EParts m_eCurPart;
    public fixed byte m_tColorWheel_Raw[252];
    public ACBindings.Internal.gmCGAppearancePage.tagColorWheel* m_tColorWheel => (ACBindings.Internal.gmCGAppearancePage.tagColorWheel*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_tColorWheel_Raw[0]);
    public ACBindings.Internal.gmCGAppearancePage.EGender m_eGender;

    // Generated Constructor
    public gmCGAppearancePage(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0047CB80
    /// void __thiscall gmCGAppearancePage::PostInit(gmCGAppearancePage*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, void>)0x0047CB80)(ref this);

    /// <summary>
    /// <code>Offset: 0x0047CBC0
    /// UIElement* __thiscall gmCGAppearancePage::DynamicCast(gmCGAppearancePage*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, uint, ACBindings.Internal.UIElement*>)0x0047CBC0)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x0047CBE0
    /// unsigned int __thiscall gmCGAppearancePage::GetUIElementType(gmCGAppearancePage*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, uint>)0x0047CBE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0047CBF0
    /// void __thiscall gmCGAppearancePage::RecvNotice_PlayerObjDescChanged(gmCGAppearancePage*)</code>
    /// </summary>
    public void RecvNotice_PlayerObjDescChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, void>)0x0047CBF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0047CC10
    /// void __thiscall gmCGAppearancePage::SetShade(gmCGAppearancePage*,long double)</code>
    /// </summary>
    public void SetShade(double dShade) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, double, void>)0x0047CC10)(ref this, dShade);

    /// <summary>
    /// <code>Offset: 0x0047CD10
    /// void __thiscall gmCGAppearancePage::DoZoomAnimation(gmCGAppearancePage*)</code>
    /// </summary>
    public void DoZoomAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, void>)0x0047CD10)(ref this);

    /// <summary>
    /// <code>Offset: 0x0047CE30
    /// void __thiscall gmCGAppearancePage::DoRotation(gmCGAppearancePage*)</code>
    /// </summary>
    public void DoRotation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, void>)0x0047CE30)(ref this);

    /// <summary>
    /// <code>Offset: 0x0047CF00
    /// void __thiscall gmCGAppearancePage::Rotate(gmCGAppearancePage*,gmCGAppearancePage::ERotateDirection)</code>
    /// </summary>
    public void Rotate(ACBindings.Internal.gmCGAppearancePage.ERotateDirection eDir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, ACBindings.Internal.gmCGAppearancePage.ERotateDirection, void>)0x0047CF00)(ref this, eDir);

    /// <summary>
    /// <code>Offset: 0x0047D070
    /// void __thiscall gmCGAppearancePage::gmCGAppearancePage(gmCGAppearancePage*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x0047D070)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x0047D250
    /// UIElement* __cdecl gmCGAppearancePage::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public static ACBindings.Internal.UIElement* Create(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, ACBindings.Internal.UIElement*>)0x0047D250)(layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x0047D280
    /// void __thiscall gmCGAppearancePage::ListenToGlobalMessage(gmCGAppearancePage*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, uint, int, void>)0x0047D280)(ref this, messageID, data_int);

    /// <summary>
    /// <code>Offset: 0x0047D2B0
    /// void __thiscall gmCGAppearancePage::ZoomIn(gmCGAppearancePage*)</code>
    /// </summary>
    public void ZoomIn() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, void>)0x0047D2B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0047D400
    /// void __thiscall gmCGAppearancePage::ZoomOut(gmCGAppearancePage*)</code>
    /// </summary>
    public void ZoomOut() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, void>)0x0047D400)(ref this);

    /// <summary>
    /// <code>Offset: 0x0047D840
    /// void __cdecl gmCGAppearancePage::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0047D840)();

    /// <summary>
    /// <code>Offset: 0x0047D860
    /// void __thiscall gmCGAppearancePage::SetChoice(gmCGAppearancePage*,gmCGAppearancePage::EType)</code>
    /// </summary>
    public void SetChoice(ACBindings.Internal.gmCGAppearancePage.EType eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, ACBindings.Internal.gmCGAppearancePage.EType, void>)0x0047D860)(ref this, eType);

    /// <summary>
    /// <code>Offset: 0x0047DC00
    /// void __thiscall gmCGAppearancePage::DoColorSpots(gmCGAppearancePage*,int)</code>
    /// </summary>
    public void DoColorSpots(int iPart) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, int, void>)0x0047DC00)(ref this, iPart);

    /// <summary>
    /// <code>Offset: 0x0047DE40
    /// void __thiscall gmCGAppearancePage::DoGradDisk(gmCGAppearancePage*,bool)</code>
    /// </summary>
    public void DoGradDisk(byte bUsePlug) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, byte, void>)0x0047DE40)(ref this, bUsePlug);

    /// <summary>
    /// <code>Offset: 0x0047E100
    /// void __thiscall gmCGAppearancePage::SetColor(gmCGAppearancePage*,int)</code>
    /// </summary>
    public void SetColor(int iColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, int, void>)0x0047E100)(ref this, iColor);

    /// <summary>
    /// <code>Offset: 0x0047E3D0
    /// void __thiscall gmCGAppearancePage::SetupParts(gmCGAppearancePage*)</code>
    /// </summary>
    public void SetupParts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, void>)0x0047E3D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0047E610
    /// void __thiscall gmCGAppearancePage::SetSelection(gmCGAppearancePage*,gmCGAppearancePage::EParts)</code>
    /// </summary>
    public void SetSelection(ACBindings.Internal.gmCGAppearancePage.EParts ePart) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, ACBindings.Internal.gmCGAppearancePage.EParts, void>)0x0047E610)(ref this, ePart);

    /// <summary>
    /// <code>Offset: 0x0047ECA0
    /// void __thiscall gmCGAppearancePage::Update(gmCGAppearancePage*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, void>)0x0047ECA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0047F2E0
    /// UIElementMessageListenResult __thiscall gmCGAppearancePage::ListenToElementMessage(gmCGAppearancePage*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x0047F2E0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x00480180
    /// void __thiscall gmCGAppearancePage::InitializePage(gmCGAppearancePage*,gmCharGenMainUI*)</code>
    /// </summary>
    public void InitializePage(ACBindings.Internal.gmCharGenMainUI* pMain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCGAppearancePage, ACBindings.Internal.gmCharGenMainUI*, void>)0x00480180)(ref this, pMain);
}

