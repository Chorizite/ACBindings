namespace ACBindings;

// gmCGAppearancePage
public unsafe struct gmCGAppearancePage
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmCGAppearancePage_vtbl
    public unsafe struct gmCGAppearancePage_vtbl
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
    // gmCGAppearancePage::tagChoices
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
    // gmCGAppearancePage::tagColorWheel
    public unsafe struct tagColorWheel
    {
        // Members
        public uint iRed;
        public uint iGreen;
        public uint iBlue;
        public ACBindings.UIElement* pColor;
        public ACBindings.UIElement* pPointer;
        public ACBindings.Graphic* pGraphic;
        public ACBindings.gmCGAppearancePage.EParts ePart;

        // Methods
    }

    // Members
    public ACBindings.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.gmCharGenMainUI* m_pMainFramework;
    public ACBindings.UIElement_Button* m_pFemaleButton;
    public ACBindings.UIElement_Button* m_pMaleButton;
    public ACBindings.UIElement_Button* m_pFaceButton;
    public ACBindings.UIElement_Button* m_pClothesButton;
    public ACBindings.UIElement_Button* m_pZoomInButton;
    public ACBindings.UIElement_Button* m_pZoomOutButton;
    public ACBindings.UIElement_Button* m_pRotateClockButton;
    public ACBindings.UIElement_Button* m_pRotateCounterClockButton;
    public ACBindings.UIElement_Button* m_pHairSpin;
    public ACBindings.UIElement_Button* m_pEyesSpin;
    public ACBindings.UIElement_Button* m_pNoseSpin;
    public ACBindings.UIElement_Button* m_pMouthSpin;
    public ACBindings.UIElement_Button* m_pSkinSpin;
    public ACBindings.UIElement_Button* m_pHeadgearSpin;
    public ACBindings.UIElement_Button* m_pShirtSpin;
    public ACBindings.UIElement_Button* m_pTrousersSpin;
    public ACBindings.UIElement_Button* m_pFootwearSpin;
    public ACBindings.UIElement_Scrollbar* m_pShadeScroll;
    public ACBindings.UIElement* m_pFaceChoices;
    public ACBindings.UIElement* m_pClothesChoices;
    public ACBindings.UIElement* m_pGradCircle;
    public ACBindings.Graphic* m_pGradGraphic;
    public ACBindings.Graphic* m_pGradPlug;
    public ACBindings.UIElement* m_pCurSelection;
    public ACBindings.UIElement_Viewport* m_pViewport;
    public ACBindings.gmCG3DView* m_p3DView;
    public int m_iCurColor;
    public int m_iPartIndex;
    public int m_iHoldheadgear;
    public byte m_bShouldZoomAnimate;
    public byte m_bRotating;
    public byte m_bZoomedIn;
    public ACBindings.AC1Legacy.Vector3 m_vectTargPosition;
    public ACBindings.AC1Legacy.Vector3 m_vectStartPosition;
    public ACBindings.AC1Legacy.Vector3 m_vectCurPosition;
    public ACBindings.AC1Legacy.Vector3 m_vectTargDirection;
    public ACBindings.AC1Legacy.Vector3 m_vectStartDirection;
    public ACBindings.AC1Legacy.Vector3 m_vectCurDirection;
    public float m_fCurHeading;
    public float m_fTargHeading;
    public double m_dAnimStartTime;
    public double m_dAnimDuration;
    public double m_dLastRotateTime;
    public double m_dRotationPerSec;
    public uint m_LastHeritageGroup;
    public ACBindings.gmCGAppearancePage.ERotateDirection m_eRotateDir;
    public ACBindings.gmCGAppearancePage.EType m_eCurType;
    public fixed byte m_tChoices_Raw[216];
    public ACBindings.gmCGAppearancePage.tagChoices* m_tChoices => (ACBindings.gmCGAppearancePage.tagChoices*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_tChoices_Raw[0]);
    public ACBindings.gmCGAppearancePage.EParts m_eCurPart;
    public fixed byte m_tColorWheel_Raw[252];
    public ACBindings.gmCGAppearancePage.tagColorWheel* m_tColorWheel => (ACBindings.gmCGAppearancePage.tagColorWheel*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_tColorWheel_Raw[0]);
    public ACBindings.gmCGAppearancePage.EGender m_eGender;

    // Generated Constructor
    public gmCGAppearancePage(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods
    // void __thiscall gmCGAppearancePage::PostInit(gmCGAppearancePage*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, void>)0x0047CB80)(ref this);
    // UIElement* __thiscall gmCGAppearancePage::DynamicCast(gmCGAppearancePage*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, uint, ACBindings.UIElement*>)0x0047CBC0)(ref this, i_eType);
    // unsigned int __thiscall gmCGAppearancePage::GetUIElementType(gmCGAppearancePage*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, uint>)0x0047CBE0)(ref this);
    // void __thiscall gmCGAppearancePage::RecvNotice_PlayerObjDescChanged(gmCGAppearancePage*)
    public void RecvNotice_PlayerObjDescChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, void>)0x0047CBF0)(ref this);
    // void __thiscall gmCGAppearancePage::SetShade(gmCGAppearancePage*,long double)
    public void SetShade(double dShade) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, double, void>)0x0047CC10)(ref this, dShade);
    // void __thiscall gmCGAppearancePage::DoZoomAnimation(gmCGAppearancePage*)
    public void DoZoomAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, void>)0x0047CD10)(ref this);
    // void __thiscall gmCGAppearancePage::DoRotation(gmCGAppearancePage*)
    public void DoRotation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, void>)0x0047CE30)(ref this);
    // void __thiscall gmCGAppearancePage::Rotate(gmCGAppearancePage*,gmCGAppearancePage::ERotateDirection)
    public void Rotate(ACBindings.gmCGAppearancePage.ERotateDirection eDir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, ACBindings.gmCGAppearancePage.ERotateDirection, void>)0x0047CF00)(ref this, eDir);
    // void __thiscall gmCGAppearancePage::gmCGAppearancePage(gmCGAppearancePage*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x0047D070)(ref this, layout, full_desc);
    // UIElement* __cdecl gmCGAppearancePage::Create(const LayoutDesc*,const ElementDesc*)
    public static ACBindings.UIElement* Create(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindings.LayoutDesc*, ACBindings.ElementDesc*, ACBindings.UIElement*>)0x0047D250)(layout, full_desc);
    // void __thiscall gmCGAppearancePage::ListenToGlobalMessage(gmCGAppearancePage*,unsigned int,int)
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, uint, int, void>)0x0047D280)(ref this, messageID, data_int);
    // void __thiscall gmCGAppearancePage::ZoomIn(gmCGAppearancePage*)
    public void ZoomIn() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, void>)0x0047D2B0)(ref this);
    // void __thiscall gmCGAppearancePage::ZoomOut(gmCGAppearancePage*)
    public void ZoomOut() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, void>)0x0047D400)(ref this);
    // void __cdecl gmCGAppearancePage::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0047D840)();
    // void __thiscall gmCGAppearancePage::SetChoice(gmCGAppearancePage*,gmCGAppearancePage::EType)
    public void SetChoice(ACBindings.gmCGAppearancePage.EType eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, ACBindings.gmCGAppearancePage.EType, void>)0x0047D860)(ref this, eType);
    // void __thiscall gmCGAppearancePage::DoColorSpots(gmCGAppearancePage*,int)
    public void DoColorSpots(int iPart) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, int, void>)0x0047DC00)(ref this, iPart);
    // void __thiscall gmCGAppearancePage::DoGradDisk(gmCGAppearancePage*,bool)
    public void DoGradDisk(byte bUsePlug) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, byte, void>)0x0047DE40)(ref this, bUsePlug);
    // void __thiscall gmCGAppearancePage::SetColor(gmCGAppearancePage*,int)
    public void SetColor(int iColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, int, void>)0x0047E100)(ref this, iColor);
    // void __thiscall gmCGAppearancePage::SetupParts(gmCGAppearancePage*)
    public void SetupParts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, void>)0x0047E3D0)(ref this);
    // void __thiscall gmCGAppearancePage::SetSelection(gmCGAppearancePage*,gmCGAppearancePage::EParts)
    public void SetSelection(ACBindings.gmCGAppearancePage.EParts ePart) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, ACBindings.gmCGAppearancePage.EParts, void>)0x0047E610)(ref this, ePart);
    // void __thiscall gmCGAppearancePage::Update(gmCGAppearancePage*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, void>)0x0047ECA0)(ref this);
    // UIElementMessageListenResult __thiscall gmCGAppearancePage::ListenToElementMessage(gmCGAppearancePage*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x0047F2E0)(ref this, i_rMsg);
    // void __thiscall gmCGAppearancePage::InitializePage(gmCGAppearancePage*,gmCharGenMainUI*)
    public void InitializePage(ACBindings.gmCharGenMainUI* pMain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCGAppearancePage, ACBindings.gmCharGenMainUI*, void>)0x00480180)(ref this, pMain);
}

