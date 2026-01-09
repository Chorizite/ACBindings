namespace ACBindings;

// gmCharGenMainUI
public unsafe struct gmCharGenMainUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIMainFramework BaseClass_UIMainFramework; // ACBindings.UIMainFramework
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmCharGenMainUI_vtbl
    public unsafe struct gmCharGenMainUI_vtbl
    {
        // Members
        public System.IntPtr gmCharGenMainUI_dtor_0; // function pointer
        public System.IntPtr OnAction; // function pointer
        public System.IntPtr OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public System.IntPtr ListenToElementMessage; // function pointer
        public System.IntPtr ListenToGlobalMessage; // function pointer
        public System.IntPtr CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public System.IntPtr RemoveRootElement; // function pointer
        public System.IntPtr Show; // function pointer
        public System.IntPtr Shown; // function pointer
        public System.IntPtr ForceHidden; // function pointer
        public System.IntPtr AddChild; // function pointer
        public System.IntPtr RemoveChild; // function pointer
        public System.IntPtr FindChild; // function pointer
        public System.IntPtr SetErrorMsg; // function pointer
        public System.IntPtr Update; // function pointer

        // Methods
    }
    // gmCharGenMainUI::ECGProgress
    public enum ECGProgress : byte
    {
        ECG_INVALID = 0x0,
        ECG_HERTAGE = 0x1,
        ECG_PROFESSION = 0x2,
        ECG_SKILLS = 0x3,
        ECG_APPEARANCE = 0x4,
        ECG_TOWN = 0x5,
        ECG_SUMMARY = 0x6
    }

    // Members
    public ACBindings.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.UIElement* m_rootField;
    public ACBindings.UIElement* m_ProgressBar;
    public ACBindings.UIElement* m_MainMenu;
    public ACBindings.UIElement* m_pMasterPage;
    public ACBindings.gmCGHeritagePage* m_pHeritagePage;
    public ACBindings.gmCGProfessionPage* m_pProfessionPage;
    public ACBindings.gmCGSkillsPage* m_pSkillsPage;
    public ACBindings.gmCGAppearancePage* m_pAppearancePage;
    public ACBindings.gmCGTownPage* m_pTownPage;
    public ACBindings.gmCGSummaryPage* m_pSummaryPage;
    public ACBindings.UIElement_Button* m_pHeritageButton;
    public ACBindings.UIElement_Button* m_pProfessionButton;
    public ACBindings.UIElement_Button* m_pSkillsButton;
    public ACBindings.UIElement_Button* m_pAppearanceButton;
    public ACBindings.UIElement_Button* m_pTownButton;
    public ACBindings.UIElement_Button* m_pSummaryButton;
    public ACBindings.UIElement_Button* m_pLeftButton;
    public ACBindings.UIElement_Button* m_pRightButton;
    public ACBindings.UIElement_Button* m_pFinishButton;
    public ACBindings.UIElement_Button* m_pHelpButton;
    public ACBindings.UIElement_Button* m_pExitButton;
    public ACBindings.UIElement_Button* m_pRandomButton;
    public ACBindings.gmCharGenMainUI.ECGProgress m_eProgressState;
    public byte m_bAwaitingCharSetForLogin;
    public uint m_uiExitContext;
    public uint m_uiPleaseWaitContext;
    public uint m_uiErrorMessageContext;
    public uint m_uiCreditWarningContext;
    public uint m_uiRandomizeWarningContext;
    public uint m_uiToDRequiredMessage;

    // Generated Constructor
    public gmCharGenMainUI() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmCharGenMainUI::SetProgressState(gmCharGenMainUI*,gmCharGenMainUI::ECGProgress)
    public void SetProgressState(ACBindings.gmCharGenMainUI.ECGProgress eState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharGenMainUI, ACBindings.gmCharGenMainUI.ECGProgress, void>)0x004E86A0)(ref this, eState);
    // void __thiscall gmCharGenMainUI::DoRandom(gmCharGenMainUI*)
    public void DoRandom() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharGenMainUI, void>)0x004E8A00)(ref this);
    // void __thiscall gmCharGenMainUI::gmCharGenMainUI(gmCharGenMainUI*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharGenMainUI, void>)0x004E8B40)(ref this);
    // void __thiscall gmCharGenMainUI::~gmCharGenMainUI(gmCharGenMainUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharGenMainUI, void>)0x004E9010)(ref this);
    // UIMainFramework* __cdecl gmCharGenMainUI::Create()
    public static ACBindings.UIMainFramework* Create() => ((delegate* unmanaged[Cdecl]<ACBindings.UIMainFramework*>)0x004E9070)();
    // bool __thiscall gmCharGenMainUI::CloseRandomizeWarningDialog(gmCharGenMainUI*,bool)
    public byte CloseRandomizeWarningDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharGenMainUI, byte, byte>)0x004E9090)(ref this, i_bConfirm);
    // void __cdecl gmCharGenMainUI::Register(unsigned int)
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004E90D0)(mode);
    // void __thiscall gmCharGenMainUI::Update(gmCharGenMainUI*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharGenMainUI, void>)0x004E90F0)(ref this);
    // bool __thiscall gmCharGenMainUI::DoExit(gmCharGenMainUI*)
    public byte DoExit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharGenMainUI, byte>)0x004E92E0)(ref this);
    // bool __thiscall gmCharGenMainUI::MakeCreditWarningDialog(gmCharGenMainUI*)
    public byte MakeCreditWarningDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharGenMainUI, byte>)0x004E9500)(ref this);
    // bool __thiscall gmCharGenMainUI::MakeRandomizeWarningDialog(gmCharGenMainUI*)
    public byte MakeRandomizeWarningDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharGenMainUI, byte>)0x004E9720)(ref this);
    // bool __thiscall gmCharGenMainUI::MakeErrorMessageDialog(gmCharGenMainUI*,const StringInfo*)
    public byte MakeErrorMessageDialog(ACBindings.StringInfo* siError) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharGenMainUI, ACBindings.StringInfo*, byte>)0x004E9940)(ref this, siError);
    // bool __thiscall gmCharGenMainUI::MakeToDWarningDialog(gmCharGenMainUI*)
    public byte MakeToDWarningDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharGenMainUI, byte>)0x004E9AD0)(ref this);
    // void __thiscall gmCharGenMainUI::ListenToGlobalMessage(gmCharGenMainUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharGenMainUI, uint, int, void>)0x004E9C90)(ref this, i_messageID, i_data_int);
    // void __thiscall gmCharGenMainUI::RecvNotice_CharGenVerificationResponse(gmCharGenMainUI*,CG_VERIFICATION_RESPONSE)
    public void RecvNotice_CharGenVerificationResponse(ACBindings.CG_VERIFICATION_RESPONSE i_rsvp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharGenMainUI, ACBindings.CG_VERIFICATION_RESPONSE, void>)0x004E9CC0)(ref this, i_rsvp);
    // bool __thiscall gmCharGenMainUI::DoFinish(gmCharGenMainUI*,bool)
    public byte DoFinish(byte bCreditCheck) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharGenMainUI, byte, byte>)0x004E9E00)(ref this, bCreditCheck);
    // UIElementMessageListenResult __thiscall gmCharGenMainUI::ListenToElementMessage(gmCharGenMainUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharGenMainUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004EA0E0)(ref this, i_rMsg);
    // void __thiscall gmCharGenMainUI::RecvNotice_CloseDialog(gmCharGenMainUI*,unsigned int,const PropertyCollection*)
    public void RecvNotice_CloseDialog(uint context, ACBindings.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharGenMainUI, uint, ACBindings.PropertyCollection*, void>)0x004EA410)(ref this, context, data);
}

