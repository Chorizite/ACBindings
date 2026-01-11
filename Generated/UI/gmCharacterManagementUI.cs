namespace ACBindings.Internal;

public unsafe struct gmCharacterManagementUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIMainFramework BaseClass_UIMainFramework; // ACBindings.Internal.UIMainFramework
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmCharacterManagementUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, void> gmCharacterManagementUI_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, byte, void> Show; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, byte> Shown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, byte, void> ForceHidden; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, void> Update; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement* m_rootField;
    public ACBindings.Internal.UIElement_ListBox* m_charListField;
    public ACBindings.Internal.UIElement* m_pCreateCharacterButton;
    public ACBindings.Internal.UIElement* m_pEnterGameButton;
    public ACBindings.Internal.UIElement* m_pDeleteCharacterButton;
    public ACBindings.Internal.UIElement* m_pRestoreCharacterButton;
    public uint m_uiCharListSelectedItem;
    public uint m_iidSelectedCharacter;
    public uint m_errorMessageDialogContext;
    public uint m_confirmExitDialogContext;
    public uint m_deleteCharacterDialogContext;
    public uint m_pleaseWaitDialogContext;
    public uint m_enteringWorldDialogContext;

    // Generated Constructor
    public gmCharacterManagementUI() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004E8680
    /// void __thiscall gmCharacterManagementUI::RecvNotice_BeginEnterWorld(gmCharGenMainUI*)</code>
    /// </summary>
    public void RecvNotice_BeginEnterWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004E8680)(ref this);

    /// <summary>
    /// <code>Offset: 0x004ECBF0
    /// void __thiscall gmCharacterManagementUI::RecvNotice_CharGenVerificationResponse(gmCharacterManagementUI*,CG_VERIFICATION_RESPONSE)</code>
    /// </summary>
    public void RecvNotice_CharGenVerificationResponse(ACBindings.Internal.CG_VERIFICATION_RESPONSE i_rsvp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void>)0x004ECBF0)(ref this, i_rsvp);

    /// <summary>
    /// <code>Offset: 0x004ECC80
    /// void __thiscall gmCharacterManagementUI::ResetPreviouslySelectedCharacterSlot(gmCharacterManagementUI*)</code>
    /// </summary>
    public void ResetPreviouslySelectedCharacterSlot() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004ECC80)(ref this);

    /// <summary>
    /// <code>Offset: 0x004ECD10
    /// void __thiscall gmCharacterManagementUI::~gmCharacterManagementUI(gmCharacterManagementUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004ECD10)(ref this);

    /// <summary>
    /// <code>Offset: 0x004ECDB0
    /// void __thiscall gmCharacterManagementUI::UpdateWorldName(gmCharacterManagementUI*)</code>
    /// </summary>
    public void UpdateWorldName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004ECDB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004ECDF0
    /// void __thiscall gmCharacterManagementUI::SelectCharacter(gmCharacterManagementUI*,unsigned int)</code>
    /// </summary>
    public void SelectCharacter(uint i_iidCharacter) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, uint, void>)0x004ECDF0)(ref this, i_iidCharacter);

    /// <summary>
    /// <code>Offset: 0x004ECED0
    /// void __thiscall gmCharacterManagementUI::UpdateButtons(gmCharacterManagementUI*)</code>
    /// </summary>
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004ECED0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004ECFF0
    /// void __thiscall gmCharacterManagementUI::RecvNotice_WorldName(UIElement**,int)</code>
    /// </summary>
    public void RecvNotice_WorldName(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, int, void>)0x004ECFF0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004ED030
    /// void __thiscall gmCharacterManagementUI::RebuildCharacterList(gmCharacterManagementUI*)</code>
    /// </summary>
    public void RebuildCharacterList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004ED030)(ref this);

    /// <summary>
    /// <code>Offset: 0x004ED580
    /// void __thiscall gmCharacterManagementUI::gmCharacterManagementUI(gmCharacterManagementUI*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004ED580)(ref this);

    /// <summary>
    /// <code>Offset: 0x004ED740
    /// void __thiscall gmCharacterManagementUI::Update(gmCharacterManagementUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004ED740)(ref this);

    /// <summary>
    /// <code>Offset: 0x004ED780
    /// void __cdecl gmCharacterManagementUI::Register(unsigned int)</code>
    /// </summary>
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004ED780)(mode);

    /// <summary>
    /// <code>Offset: 0x004ED7A0
    /// bool __thiscall gmCharacterManagementUI::MakeErrorMessageDialog(gmCharacterManagementUI*,const StringInfo*)</code>
    /// </summary>
    public byte MakeErrorMessageDialog(ACBindings.Internal.StringInfo* siError) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, ACBindings.Internal.StringInfo*, byte>)0x004ED7A0)(ref this, siError);

    /// <summary>
    /// <code>Offset: 0x004ED930
    /// bool __thiscall gmCharacterManagementUI::MakeDeleteCharacterConfirmationDialog(gmCharacterManagementUI*)</code>
    /// </summary>
    public byte MakeDeleteCharacterConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, byte>)0x004ED930)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EDB60
    /// bool __thiscall gmCharacterManagementUI::MakePleaseWaitDialog(gmCharacterManagementUI*)</code>
    /// </summary>
    public byte MakePleaseWaitDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, byte>)0x004EDB60)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EDD20
    /// bool __thiscall gmCharacterManagementUI::MakeEnteringWorldDialog(gmCharacterManagementUI*)</code>
    /// </summary>
    public byte MakeEnteringWorldDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, byte>)0x004EDD20)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EDEE0
    /// bool __thiscall gmCharacterManagementUI::MakeConfirmExitDialog(gmCharacterManagementUI*)</code>
    /// </summary>
    public byte MakeConfirmExitDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, byte>)0x004EDEE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EE0A0
    /// bool __thiscall gmCharacterManagementUI::OnAction(gmCharacterManagementUI*,const InputEvent*)</code>
    /// </summary>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, ACBindings.Internal.InputEvent*, byte>)0x004EE0A0)(ref this, i_evt);

    /// <summary>
    /// <code>Offset: 0x004EE0D0
    /// void __thiscall gmCharacterManagementUI::EnterGame(gmCharacterManagementUI*)</code>
    /// </summary>
    public void EnterGame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004EE0D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EE130
    /// void __thiscall gmCharacterManagementUI::CloseDeleteCharacterDialog(gmCharacterManagementUI*,const char**)</code>
    /// </summary>
    public void CloseDeleteCharacterDialog(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, sbyte**, void>)0x004EE130)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004EE230
    /// UIElementMessageListenResult __thiscall gmCharacterManagementUI::ListenToElementMessage(gmCharacterManagementUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004EE230)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004EE3F0
    /// void __thiscall gmCharacterManagementUI::RecvNotice_CloseDialog(gmCharacterManagementUI*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, uint, ACBindings.Internal.PropertyCollection*, void>)0x004EE3F0)(ref this, context, data);
}

