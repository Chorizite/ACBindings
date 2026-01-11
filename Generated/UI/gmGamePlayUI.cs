namespace ACBindings.Internal;

public unsafe struct gmGamePlayUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.GamePlayUI BaseClass_GamePlayUI; // ACBindings.Internal.GamePlayUI
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmGamePlayUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, void> gmGamePlayUI_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, byte, void> Show; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, byte> Shown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, byte, void> ForceHidden; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, void> Update; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement* m_pGameplayUI;
    public ACBindings.Internal.UIElement* m_pSmartBoxUI;
    public ACBindings.Internal.UIElement* m_pSmartBoxRadar;
    public ACBindings.Internal.UIElement* m_pStackedVitals;
    public ACBindings.Internal.UIElement* m_pSideBySideVitals;
    public uint m_waitContext;
    public uint m_logoutContext;
    public uint m_gameplayConfirmationContext;
    public ACBindings.Internal.ConfirmationType m_gameplayConfirmationType;
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

    /// <summary>
    /// <code>Offset: 0x004EA8F0
    /// void __thiscall gmGamePlayUI::Show(gmGamePlayUI*,bool)</code>
    /// </summary>
    public void Show(byte shown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, byte, void>)0x004EA8F0)(ref this, shown);

    /// <summary>
    /// <code>Offset: 0x004EA960
    /// void __thiscall gmGamePlayUI::Update(gmGamePlayUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, void>)0x004EA960)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EA970
    /// UIElementMessageListenResult __thiscall gmGamePlayUI::ListenToElementMessage(gmGamePlayUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004EA970)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004EAA00
    /// void __thiscall gmGamePlayUI::RecvNotice_AbortConfirmationRequest(gmGamePlayUI*,int,unsigned int)</code>
    /// </summary>
    public void RecvNotice_AbortConfirmationRequest(int confirmationType, uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, int, uint, void>)0x004EAA00)(ref this, confirmationType, context);

    /// <summary>
    /// <code>Offset: 0x004EAA30
    /// void __thiscall gmGamePlayUI::RecvNotice_PlayerOptionChanged(gmGamePlayUI*,PlayerOption)</code>
    /// </summary>
    public void RecvNotice_PlayerOptionChanged(ACBindings.Internal.PlayerOption i_eOption) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, ACBindings.Internal.PlayerOption, void>)0x004EAA30)(ref this, i_eOption);

    /// <summary>
    /// <code>Offset: 0x004EAA80
    /// void __thiscall gmGamePlayUI::HandleKeyPress(gmGamePlayUI*,int)</code>
    /// </summary>
    public void HandleKeyPress(int i_nInputAction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, int, void>)0x004EAA80)(ref this, i_nInputAction);

    /// <summary>
    /// <code>Offset: 0x004EAB10
    /// bool __thiscall gmGamePlayUI::CloseGameplayConfirmationDialog(gmGamePlayUI*,bool)</code>
    /// </summary>
    public byte CloseGameplayConfirmationDialog(byte confirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, byte, byte>)0x004EAB10)(ref this, confirm);

    /// <summary>
    /// <code>Offset: 0x004EAB50
    /// void __thiscall gmGamePlayUI::SetupChildren(gmGamePlayUI*)</code>
    /// </summary>
    public void SetupChildren() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, void>)0x004EAB50)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EACA0
    /// void __thiscall gmGamePlayUI::gmGamePlayUI(gmGamePlayUI*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, void>)0x004EACA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EAE20
    /// UIMainFramework* __cdecl gmGamePlayUI::Create()</code>
    /// </summary>
    public static ACBindings.Internal.UIMainFramework* Create() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIMainFramework*>)0x004EAE20)();

    /// <summary>
    /// <code>Offset: 0x004EAE40
    /// bool __thiscall gmGamePlayUI::EndSession(gmGamePlayUI*,bool)</code>
    /// </summary>
    public byte EndSession(byte requested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, byte, byte>)0x004EAE40)(ref this, requested);

    /// <summary>
    /// <code>Offset: 0x004EAF30
    /// void __thiscall gmGamePlayUI::~gmGamePlayUI(gmGamePlayUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, void>)0x004EAF30)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EB010
    /// void __cdecl gmGamePlayUI::Register(unsigned int)</code>
    /// </summary>
    public static void Register(uint i_modeID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004EB010)(i_modeID);

    /// <summary>
    /// <code>Offset: 0x004EB030
    /// void __thiscall gmGamePlayUI::UseTime(gmGamePlayUI*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, void>)0x004EB030)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EB180
    /// void __thiscall gmGamePlayUI::RecvNotice_CloseDialog(gmGamePlayUI*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, uint, ACBindings.Internal.PropertyCollection*, void>)0x004EB180)(ref this, context, data);

    /// <summary>
    /// <code>Offset: 0x004EB320
    /// int __thiscall gmGamePlayUI::CreateScreenLayoutPath(UIRegion**,const char*,char**)</code>
    /// </summary>
    public int CreateScreenLayoutPath(sbyte* a2, sbyte** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, sbyte*, sbyte**, int>)0x004EB320)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004EB580
    /// int __thiscall gmGamePlayUI::LoadScreenLayout(int,const char*)</code>
    /// </summary>
    public int LoadScreenLayout(sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, sbyte*, int>)0x004EB580)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004EB9E0
    /// LONG __thiscall gmGamePlayUI::SaveScreenLayout(int,const char*)</code>
    /// </summary>
    public int SaveScreenLayout(sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, sbyte*, int>)0x004EB9E0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004EC230
    /// void __thiscall gmGamePlayUI::ListenToGlobalMessage(gmGamePlayUI*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, uint, int, void>)0x004EC230)(ref this, i_messageID, i_data_int);

    /// <summary>
    /// <code>Offset: 0x004EC290
    /// LONG __thiscall gmGamePlayUI::RecvNotice_SaveUI(void*,const char**)</code>
    /// </summary>
    public int RecvNotice_SaveUI(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, sbyte**, int>)0x004EC290)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004EC2C0
    /// int __thiscall gmGamePlayUI::RecvNotice_LoadUI(void*,const char**)</code>
    /// </summary>
    public int RecvNotice_LoadUI(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, sbyte**, int>)0x004EC2C0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004EC2F0
    /// void __thiscall gmGamePlayUI::RecvNotice_PlayerDescReceived(gmGamePlayUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004EC2F0)(ref this, i_playerDesc, i_playerModule);

    /// <summary>
    /// <code>Offset: 0x004EC330
    /// bool __thiscall gmGamePlayUI::MakeLogoutConfirmationDialog(gmGamePlayUI*,const StringInfo*)</code>
    /// </summary>
    public byte MakeLogoutConfirmationDialog(ACBindings.Internal.StringInfo* msg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, ACBindings.Internal.StringInfo*, byte>)0x004EC330)(ref this, msg);

    /// <summary>
    /// <code>Offset: 0x004EC520
    /// bool __thiscall gmGamePlayUI::MakeGameplayConfirmationDialog(gmGamePlayUI*,const StringInfo*)</code>
    /// </summary>
    public byte MakeGameplayConfirmationDialog(ACBindings.Internal.StringInfo* msg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, ACBindings.Internal.StringInfo*, byte>)0x004EC520)(ref this, msg);

    /// <summary>
    /// <code>Offset: 0x004EC700
    /// LONG __thiscall gmGamePlayUI::RecvNotice_AlterSkill_ConfirmationRequest(_DWORD*,void*,int)</code>
    /// </summary>
    public int RecvNotice_AlterSkill_ConfirmationRequest(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, System.IntPtr, int, int>)0x004EC700)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004EC7E0
    /// LONG __thiscall gmGamePlayUI::RecvNotice_AlterAttribute_ConfirmationRequest(_DWORD*,void*,int)</code>
    /// </summary>
    public int RecvNotice_AlterAttribute_ConfirmationRequest(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, System.IntPtr, int, int>)0x004EC7E0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004EC8C0
    /// LONG __thiscall gmGamePlayUI::RecvNotice_Augmentation_ConfirmationRequest(_DWORD*,void*,int)</code>
    /// </summary>
    public int RecvNotice_Augmentation_ConfirmationRequest(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, System.IntPtr, int, int>)0x004EC8C0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004EC9A0
    /// LONG __thiscall gmGamePlayUI::RecvNotice_YesNo_ConfirmationRequest(_DWORD*,_DWORD*,int)</code>
    /// </summary>
    public int RecvNotice_YesNo_ConfirmationRequest(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, int*, int, int>)0x004EC9A0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004ECA50
    /// LONG __thiscall gmGamePlayUI::RecvNotice_CraftInteraction_ConfirmationRequest(_DWORD*,void*,int)</code>
    /// </summary>
    public int RecvNotice_CraftInteraction_ConfirmationRequest(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, System.IntPtr, int, int>)0x004ECA50)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004ECB30
    /// void __thiscall gmGamePlayUI::RecvNotice_EndCharacterSession(gmGamePlayUI*,int)</code>
    /// </summary>
    public void RecvNotice_EndCharacterSession(int confirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, int, void>)0x004ECB30)(ref this, confirm);

    /// <summary>
    /// <code>Offset: 0x004ECBA0
    /// void __thiscall gmGamePlayUI::RecvNotice_Logoff(gmGamePlayUI*)</code>
    /// </summary>
    public void RecvNotice_Logoff() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, void>)0x004ECBA0)(ref this);
}

