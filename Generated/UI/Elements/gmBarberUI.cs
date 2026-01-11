namespace ACBindings.Internal;

public unsafe struct gmBarberUI
{
    // Base Classes
    public ACBindings.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindings.Internal.UIElement_Field
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmBarberUI_vtbl
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
    // gmBarberUI::EGender
    public enum EGender : byte
    {
        ECG_GENDER_INVALID = 0x0,
        ECG_GENDER_FEMALE = 0x1,
        ECG_GENDER_MALE = 0x2
    }
    // gmBarberUI::EParts
    public enum EParts : uint
    {
    }
    // gmBarberUI::ERotateDirection
    public enum ERotateDirection : uint
    {
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
        public ACBindings.Internal.gmBarberUI.EParts ePart;

        // Methods
    }

    // Members
    public ACBindings.Internal.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.Internal.UIElement_Button* m_pRotateClockButton;
    public ACBindings.Internal.UIElement_Button* m_pRotateCounterClockButton;
    public ACBindings.Internal.UIElement_Button* m_pHairSpin;
    public ACBindings.Internal.UIElement_Button* m_pEyesSpin;
    public ACBindings.Internal.UIElement_Button* m_pNoseSpin;
    public ACBindings.Internal.UIElement_Button* m_pMouthSpin;
    public ACBindings.Internal.UIElement_Button* m_pSkinSpin;
    public ACBindings.Internal.UIElement_Button* m_pApplyButton;
    public ACBindings.Internal.UIElement_Button* m_pCancelButton;
    public ACBindings.Internal.UIElement_Button* m_pOption1Checkbox;
    public ACBindings.Internal.UIElement_Button* m_pOption2Checkbox;
    public ACBindings.Internal.UIElement_Button* m_pOption3Checkbox;
    public ACBindings.Internal.UIElement_Scrollbar* m_pShadeScroll;
    public ACBindings.Internal.UIElement* m_pFaceChoices;
    public ACBindings.Internal.UIElement* m_pGradCircle;
    public ACBindings.Internal.Graphic* m_pGradGraphic;
    public ACBindings.Internal.Graphic* m_pGradPlug;
    public ACBindings.Internal.UIElement* m_pCurSelection;
    public ACBindings.Internal.UIElement_Viewport* m_pViewport;
    public ACBindings.Internal.gmCG3DView* m_p3DView;
    public int m_iCurColor;
    public int m_iPartIndex;
    public int m_iHoldheadgear;
    public byte m_bRotating;
    public float m_fCurHeading;
    public float m_fTargHeading;
    public double m_dAnimStartTime;
    public double m_dAnimDuration;
    public double m_dLastRotateTime;
    public double m_dRotationPerSec;
    public ACBindings.Internal.gmBarberUI.ERotateDirection m_eRotateDir;
    public fixed byte m_tChoices_Raw[216];
    public ACBindings.Internal.gmBarberUI.tagChoices* m_tChoices => (ACBindings.Internal.gmBarberUI.tagChoices*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_tChoices_Raw[0]);
    public ACBindings.Internal.gmBarberUI.EParts m_eCurPart;
    public fixed byte m_tColorWheel_Raw[252];
    public ACBindings.Internal.gmBarberUI.tagColorWheel* m_tColorWheel => (ACBindings.Internal.gmBarberUI.tagColorWheel*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_tColorWheel_Raw[0]);

    // Generated Constructor
    public gmBarberUI(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004DEE40
    /// void __thiscall gmBarberUI::gmBarberUI(gmBarberUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.LayoutDesc* layout, ACBindings.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, ACBindings.Internal.LayoutDesc*, ACBindings.Internal.ElementDesc*, void>)0x004DEE40)(ref this, layout, full_desc);

    /// <summary>
    /// <code>Offset: 0x004DEF40
    /// UIElement* __thiscall gmBarberUI::DynamicCast(gmBarberUI*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, uint, ACBindings.Internal.UIElement*>)0x004DEF40)(ref this, i_eType);

    /// <summary>
    /// <code>Offset: 0x004DEF60
    /// unsigned int __thiscall gmBarberUI::GetUIElementType(gmBarberUI*)</code>
    /// </summary>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, uint>)0x004DEF60)(ref this);

    /// <summary>
    /// <code>Offset: 0x004DEF70
    /// void __thiscall gmBarberUI::PostInit(gmBarberUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, void>)0x004DEF70)(ref this);

    /// <summary>
    /// <code>Offset: 0x004DF040
    /// void __thiscall gmBarberUI::RecvNotice_PlayerObjDescChanged(gmBarberUI*)</code>
    /// </summary>
    public void RecvNotice_PlayerObjDescChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, void>)0x004DF040)(ref this);

    /// <summary>
    /// <code>Offset: 0x004DF060
    /// void __thiscall gmBarberUI::SetShade(gmBarberUI*,long double)</code>
    /// </summary>
    public void SetShade(double dShade) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, double, void>)0x004DF060)(ref this, dShade);

    /// <summary>
    /// <code>Offset: 0x004DF0E0
    /// void __thiscall gmBarberUI::DoRotation(gmBarberUI*)</code>
    /// </summary>
    public void DoRotation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, void>)0x004DF0E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004DF1B0
    /// void __thiscall gmBarberUI::Rotate(gmBarberUI*,gmBarberUI::ERotateDirection)</code>
    /// </summary>
    public void Rotate(ACBindings.Internal.gmBarberUI.ERotateDirection eDir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, ACBindings.Internal.gmBarberUI.ERotateDirection, void>)0x004DF1B0)(ref this, eDir);

    /// <summary>
    /// <code>Offset: 0x004DF290
    /// void __cdecl gmBarberUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004DF290)();

    /// <summary>
    /// <code>Offset: 0x004DF2B0
    /// void __thiscall gmBarberUI::ListenToGlobalMessage(gmBarberUI*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, uint, int, void>)0x004DF2B0)(ref this, messageID, data_int);

    /// <summary>
    /// <code>Offset: 0x004DF2D0
    /// void __thiscall gmBarberUI::DoColorSpots(gmBarberUI*,int)</code>
    /// </summary>
    public void DoColorSpots(int iPart) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, int, void>)0x004DF2D0)(ref this, iPart);

    /// <summary>
    /// <code>Offset: 0x004DF510
    /// void __thiscall gmBarberUI::DoGradDisk(gmBarberUI*,bool)</code>
    /// </summary>
    public void DoGradDisk(byte bUsePlug) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, byte, void>)0x004DF510)(ref this, bUsePlug);

    /// <summary>
    /// <code>Offset: 0x004DF7D0
    /// void __thiscall gmBarberUI::SetColor(gmBarberUI*,int)</code>
    /// </summary>
    public void SetColor(int iColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, int, void>)0x004DF7D0)(ref this, iColor);

    /// <summary>
    /// <code>Offset: 0x004DF880
    /// void __thiscall gmBarberUI::SetupParts(gmBarberUI*)</code>
    /// </summary>
    public void SetupParts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, void>)0x004DF880)(ref this);

    /// <summary>
    /// <code>Offset: 0x004DFA80
    /// void __thiscall gmBarberUI::SetSelection(gmBarberUI*,gmBarberUI::EParts)</code>
    /// </summary>
    public void SetSelection(ACBindings.Internal.gmBarberUI.EParts ePart) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, ACBindings.Internal.gmBarberUI.EParts, void>)0x004DFA80)(ref this, ePart);

    /// <summary>
    /// <code>Offset: 0x004DFEF0
    /// UIElementMessageListenResult __thiscall gmBarberUI::ListenToElementMessage(gmBarberUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004DFEF0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004E0CD0
    /// void __thiscall gmBarberUI::InitializePage(UIElement*,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int)</code>
    /// </summary>
    public void InitializePage(int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, int a11, int a12, int a13, int a14, int a15, int a16, int a17) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, void>)0x004E0CD0)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17);

    /// <summary>
    /// <code>Offset: 0x004E1B50
    /// int __thiscall gmBarberUI::RecvNotice_StartBarberNotice(gmCG3DView**,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int)</code>
    /// </summary>
    public int RecvNotice_StartBarberNotice(int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, int a11, int a12, int a13, int a14, int a15, int a16, int a17) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmBarberUI, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>)0x004E1B50)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17);
}

