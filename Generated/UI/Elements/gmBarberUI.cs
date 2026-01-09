namespace ACBindings;

// gmBarberUI
public unsafe struct gmBarberUI
{
    // Base Classes
    public ACBindings.UIElement_Field BaseClass_UIElement_Field; // ACBindings.UIElement_Field
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmBarberUI_vtbl
    public unsafe struct gmBarberUI_vtbl
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
    // gmBarberUI::tagChoices
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
    // gmBarberUI::tagColorWheel
    public unsafe struct tagColorWheel
    {
        // Members
        public uint iRed;
        public uint iGreen;
        public uint iBlue;
        public ACBindings.UIElement* pColor;
        public ACBindings.UIElement* pPointer;
        public ACBindings.Graphic* pGraphic;
        public ACBindings.gmBarberUI.EParts ePart;

        // Methods
    }

    // Members
    public ACBindings.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.UIElement_Button* m_pRotateClockButton;
    public ACBindings.UIElement_Button* m_pRotateCounterClockButton;
    public ACBindings.UIElement_Button* m_pHairSpin;
    public ACBindings.UIElement_Button* m_pEyesSpin;
    public ACBindings.UIElement_Button* m_pNoseSpin;
    public ACBindings.UIElement_Button* m_pMouthSpin;
    public ACBindings.UIElement_Button* m_pSkinSpin;
    public ACBindings.UIElement_Button* m_pApplyButton;
    public ACBindings.UIElement_Button* m_pCancelButton;
    public ACBindings.UIElement_Button* m_pOption1Checkbox;
    public ACBindings.UIElement_Button* m_pOption2Checkbox;
    public ACBindings.UIElement_Button* m_pOption3Checkbox;
    public ACBindings.UIElement_Scrollbar* m_pShadeScroll;
    public ACBindings.UIElement* m_pFaceChoices;
    public ACBindings.UIElement* m_pGradCircle;
    public ACBindings.Graphic* m_pGradGraphic;
    public ACBindings.Graphic* m_pGradPlug;
    public ACBindings.UIElement* m_pCurSelection;
    public ACBindings.UIElement_Viewport* m_pViewport;
    public ACBindings.gmCG3DView* m_p3DView;
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
    public ACBindings.gmBarberUI.ERotateDirection m_eRotateDir;
    public fixed byte m_tChoices_Raw[216];
    public ACBindings.gmBarberUI.tagChoices* m_tChoices => (ACBindings.gmBarberUI.tagChoices*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_tChoices_Raw[0]);
    public ACBindings.gmBarberUI.EParts m_eCurPart;
    public fixed byte m_tColorWheel_Raw[252];
    public ACBindings.gmBarberUI.tagColorWheel* m_tColorWheel => (ACBindings.gmBarberUI.tagColorWheel*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_tColorWheel_Raw[0]);

    // Generated Constructor
    public gmBarberUI(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods
    // void __thiscall gmBarberUI::gmBarberUI(gmBarberUI*,const LayoutDesc*,const ElementDesc*)
    public void _ConstructorInternal(ACBindings.LayoutDesc* layout, ACBindings.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, ACBindings.LayoutDesc*, ACBindings.ElementDesc*, void>)0x004DEE40)(ref this, layout, full_desc);
    // UIElement* __thiscall gmBarberUI::DynamicCast(gmBarberUI*,unsigned int)
    public ACBindings.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, uint, ACBindings.UIElement*>)0x004DEF40)(ref this, i_eType);
    // unsigned int __thiscall gmBarberUI::GetUIElementType(gmBarberUI*)
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, uint>)0x004DEF60)(ref this);
    // void __thiscall gmBarberUI::PostInit(gmBarberUI*)
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, void>)0x004DEF70)(ref this);
    // void __thiscall gmBarberUI::RecvNotice_PlayerObjDescChanged(gmBarberUI*)
    public void RecvNotice_PlayerObjDescChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, void>)0x004DF040)(ref this);
    // void __thiscall gmBarberUI::SetShade(gmBarberUI*,long double)
    public void SetShade(double dShade) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, double, void>)0x004DF060)(ref this, dShade);
    // void __thiscall gmBarberUI::DoRotation(gmBarberUI*)
    public void DoRotation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, void>)0x004DF0E0)(ref this);
    // void __thiscall gmBarberUI::Rotate(gmBarberUI*,gmBarberUI::ERotateDirection)
    public void Rotate(ACBindings.gmBarberUI.ERotateDirection eDir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, ACBindings.gmBarberUI.ERotateDirection, void>)0x004DF1B0)(ref this, eDir);
    // void __cdecl gmBarberUI::Register()
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004DF290)();
    // void __thiscall gmBarberUI::ListenToGlobalMessage(gmBarberUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint messageID, int data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, uint, int, void>)0x004DF2B0)(ref this, messageID, data_int);
    // void __thiscall gmBarberUI::DoColorSpots(gmBarberUI*,int)
    public void DoColorSpots(int iPart) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, int, void>)0x004DF2D0)(ref this, iPart);
    // void __thiscall gmBarberUI::DoGradDisk(gmBarberUI*,bool)
    public void DoGradDisk(byte bUsePlug) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, byte, void>)0x004DF510)(ref this, bUsePlug);
    // void __thiscall gmBarberUI::SetColor(gmBarberUI*,int)
    public void SetColor(int iColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, int, void>)0x004DF7D0)(ref this, iColor);
    // void __thiscall gmBarberUI::SetupParts(gmBarberUI*)
    public void SetupParts() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, void>)0x004DF880)(ref this);
    // void __thiscall gmBarberUI::SetSelection(gmBarberUI*,gmBarberUI::EParts)
    public void SetSelection(ACBindings.gmBarberUI.EParts ePart) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, ACBindings.gmBarberUI.EParts, void>)0x004DFA80)(ref this, ePart);
    // UIElementMessageListenResult __thiscall gmBarberUI::ListenToElementMessage(gmBarberUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004DFEF0)(ref this, i_rMsg);
    // void __thiscall gmBarberUI::InitializePage(UIElement*,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int)
    public void InitializePage(int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, int a11, int a12, int a13, int a14, int a15, int a16, int a17) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, void>)0x004E0CD0)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17);
    // int __thiscall gmBarberUI::RecvNotice_StartBarberNotice(gmCG3DView**,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int,int)
    public int RecvNotice_StartBarberNotice(int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, int a11, int a12, int a13, int a14, int a15, int a16, int a17) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmBarberUI, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>)0x004E1B50)(ref this, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17);
}

