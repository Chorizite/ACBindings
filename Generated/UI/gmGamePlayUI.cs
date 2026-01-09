namespace ACBindings;

// gmGamePlayUI
public unsafe struct gmGamePlayUI : System.IDisposable
{
    // Base Classes
    public ACBindings.GamePlayUI BaseClass_GamePlayUI; // ACBindings.GamePlayUI
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmGamePlayUI_vtbl
    public unsafe struct gmGamePlayUI_vtbl
    {
        // Members
        public System.IntPtr gmGamePlayUI_dtor_0; // function pointer
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

    // Members
    public ACBindings.UIElement* m_pGameplayUI;
    public ACBindings.UIElement* m_pSmartBoxUI;
    public ACBindings.UIElement* m_pSmartBoxRadar;
    public ACBindings.UIElement* m_pStackedVitals;
    public ACBindings.UIElement* m_pSideBySideVitals;
    public uint m_waitContext;
    public uint m_logoutContext;
    public uint m_gameplayConfirmationContext;
    public ACBindings.ConfirmationType m_gameplayConfirmationType;
    public uint m_gameplayConfirmationContextServer;
    public byte m_endingSession;
    public byte m_doEndSession;
    public byte m_shouldQuitOnLogout;
    public byte m_bLogoutConfirmed;
    public byte m_bCurrentlyTogglingUIVisibility;

    // Generated Constructor
    public gmGamePlayUI() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmGamePlayUI::Show(gmGamePlayUI*,bool)
    public void Show(byte shown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, byte, void>)0x004EA8F0)(ref this, shown);
    // void __thiscall gmGamePlayUI::Update(gmGamePlayUI*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, void>)0x004EA960)(ref this);
    // UIElementMessageListenResult __thiscall gmGamePlayUI::ListenToElementMessage(gmGamePlayUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004EA970)(ref this, i_rMsg);
    // void __thiscall gmGamePlayUI::RecvNotice_AbortConfirmationRequest(gmGamePlayUI*,int,unsigned int)
    public void RecvNotice_AbortConfirmationRequest(int confirmationType, uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, int, uint, void>)0x004EAA00)(ref this, confirmationType, context);
    // void __thiscall gmGamePlayUI::RecvNotice_PlayerOptionChanged(gmGamePlayUI*,PlayerOption)
    public void RecvNotice_PlayerOptionChanged(ACBindings.PlayerOption i_eOption) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, ACBindings.PlayerOption, void>)0x004EAA30)(ref this, i_eOption);
    // void __thiscall gmGamePlayUI::HandleKeyPress(gmGamePlayUI*,int)
    public void HandleKeyPress(int i_nInputAction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, int, void>)0x004EAA80)(ref this, i_nInputAction);
    // bool __thiscall gmGamePlayUI::CloseGameplayConfirmationDialog(gmGamePlayUI*,bool)
    public byte CloseGameplayConfirmationDialog(byte confirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, byte, byte>)0x004EAB10)(ref this, confirm);
    // void __thiscall gmGamePlayUI::SetupChildren(gmGamePlayUI*)
    public void SetupChildren() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, void>)0x004EAB50)(ref this);
    // void __thiscall gmGamePlayUI::gmGamePlayUI(gmGamePlayUI*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, void>)0x004EACA0)(ref this);
    // UIMainFramework* __cdecl gmGamePlayUI::Create()
    public static ACBindings.UIMainFramework* Create() => ((delegate* unmanaged[Cdecl]<ACBindings.UIMainFramework*>)0x004EAE20)();
    // bool __thiscall gmGamePlayUI::EndSession(gmGamePlayUI*,bool)
    public byte EndSession(byte requested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, byte, byte>)0x004EAE40)(ref this, requested);
    // void __thiscall gmGamePlayUI::~gmGamePlayUI(gmGamePlayUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, void>)0x004EAF30)(ref this);
    // void __cdecl gmGamePlayUI::Register(unsigned int)
    public static void Register(uint i_modeID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004EB010)(i_modeID);
    // void __thiscall gmGamePlayUI::UseTime(gmGamePlayUI*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, void>)0x004EB030)(ref this);
    // void __thiscall gmGamePlayUI::RecvNotice_CloseDialog(gmGamePlayUI*,unsigned int,const PropertyCollection*)
    public void RecvNotice_CloseDialog(uint context, ACBindings.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, uint, ACBindings.PropertyCollection*, void>)0x004EB180)(ref this, context, data);
    // int __thiscall gmGamePlayUI::CreateScreenLayoutPath(UIRegion**,const char*,char**)
    public int CreateScreenLayoutPath(sbyte* a2, sbyte** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, sbyte*, sbyte**, int>)0x004EB320)(ref this, a2, a3);
    // int __thiscall gmGamePlayUI::LoadScreenLayout(int,const char*)
    public int LoadScreenLayout(sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, sbyte*, int>)0x004EB580)(ref this, a2);
    // LONG __thiscall gmGamePlayUI::SaveScreenLayout(int,const char*)
    public int SaveScreenLayout(sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, sbyte*, int>)0x004EB9E0)(ref this, a2);
    // void __thiscall gmGamePlayUI::ListenToGlobalMessage(gmGamePlayUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, uint, int, void>)0x004EC230)(ref this, i_messageID, i_data_int);
    // LONG __thiscall gmGamePlayUI::RecvNotice_SaveUI(void*,const char**)
    public int RecvNotice_SaveUI(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, sbyte**, int>)0x004EC290)(ref this, a2);
    // int __thiscall gmGamePlayUI::RecvNotice_LoadUI(void*,const char**)
    public int RecvNotice_LoadUI(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, sbyte**, int>)0x004EC2C0)(ref this, a2);
    // void __thiscall gmGamePlayUI::RecvNotice_PlayerDescReceived(gmGamePlayUI*,const CACQualities*,const CPlayerModule*)
    public void RecvNotice_PlayerDescReceived(ACBindings.CACQualities* i_playerDesc, ACBindings.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, ACBindings.CACQualities*, ACBindings.CPlayerModule*, void>)0x004EC2F0)(ref this, i_playerDesc, i_playerModule);
    // bool __thiscall gmGamePlayUI::MakeLogoutConfirmationDialog(gmGamePlayUI*,const StringInfo*)
    public byte MakeLogoutConfirmationDialog(ACBindings.StringInfo* msg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, ACBindings.StringInfo*, byte>)0x004EC330)(ref this, msg);
    // bool __thiscall gmGamePlayUI::MakeGameplayConfirmationDialog(gmGamePlayUI*,const StringInfo*)
    public byte MakeGameplayConfirmationDialog(ACBindings.StringInfo* msg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, ACBindings.StringInfo*, byte>)0x004EC520)(ref this, msg);
    // LONG __thiscall gmGamePlayUI::RecvNotice_AlterSkill_ConfirmationRequest(_DWORD*,void*,int)
    public int RecvNotice_AlterSkill_ConfirmationRequest(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, System.IntPtr, int, int>)0x004EC700)(ref this, a2, a3);
    // LONG __thiscall gmGamePlayUI::RecvNotice_AlterAttribute_ConfirmationRequest(_DWORD*,void*,int)
    public int RecvNotice_AlterAttribute_ConfirmationRequest(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, System.IntPtr, int, int>)0x004EC7E0)(ref this, a2, a3);
    // LONG __thiscall gmGamePlayUI::RecvNotice_Augmentation_ConfirmationRequest(_DWORD*,void*,int)
    public int RecvNotice_Augmentation_ConfirmationRequest(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, System.IntPtr, int, int>)0x004EC8C0)(ref this, a2, a3);
    // LONG __thiscall gmGamePlayUI::RecvNotice_YesNo_ConfirmationRequest(_DWORD*,_DWORD*,int)
    public int RecvNotice_YesNo_ConfirmationRequest(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, int*, int, int>)0x004EC9A0)(ref this, a2, a3);
    // LONG __thiscall gmGamePlayUI::RecvNotice_CraftInteraction_ConfirmationRequest(_DWORD*,void*,int)
    public int RecvNotice_CraftInteraction_ConfirmationRequest(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, System.IntPtr, int, int>)0x004ECA50)(ref this, a2, a3);
    // void __thiscall gmGamePlayUI::RecvNotice_EndCharacterSession(gmGamePlayUI*,int)
    public void RecvNotice_EndCharacterSession(int confirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, int, void>)0x004ECB30)(ref this, confirm);
    // void __thiscall gmGamePlayUI::RecvNotice_Logoff(gmGamePlayUI*)
    public void RecvNotice_Logoff() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmGamePlayUI, void>)0x004ECBA0)(ref this);
}

