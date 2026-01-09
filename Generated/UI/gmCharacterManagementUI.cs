namespace ACBindings;

// gmCharacterManagementUI
public unsafe struct gmCharacterManagementUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIMainFramework BaseClass_UIMainFramework; // ACBindings.UIMainFramework
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmCharacterManagementUI_vtbl
    public unsafe struct gmCharacterManagementUI_vtbl
    {
        // Members
        public System.IntPtr gmCharacterManagementUI_dtor_0; // function pointer
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
    public ACBindings.UIElement* m_rootField;
    public ACBindings.UIElement_ListBox* m_charListField;
    public ACBindings.UIElement* m_pCreateCharacterButton;
    public ACBindings.UIElement* m_pEnterGameButton;
    public ACBindings.UIElement* m_pDeleteCharacterButton;
    public ACBindings.UIElement* m_pRestoreCharacterButton;
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
    // void __thiscall gmCharacterManagementUI::RecvNotice_BeginEnterWorld(gmCharGenMainUI*)
    public void RecvNotice_BeginEnterWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, void>)0x004E8680)(ref this);
    // void __thiscall gmCharacterManagementUI::RecvNotice_CharGenVerificationResponse(gmCharacterManagementUI*,CG_VERIFICATION_RESPONSE)
    public void RecvNotice_CharGenVerificationResponse(ACBindings.CG_VERIFICATION_RESPONSE i_rsvp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, ACBindings.CG_VERIFICATION_RESPONSE, void>)0x004ECBF0)(ref this, i_rsvp);
    // void __thiscall gmCharacterManagementUI::ResetPreviouslySelectedCharacterSlot(gmCharacterManagementUI*)
    public void ResetPreviouslySelectedCharacterSlot() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, void>)0x004ECC80)(ref this);
    // void __thiscall gmCharacterManagementUI::~gmCharacterManagementUI(gmCharacterManagementUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, void>)0x004ECD10)(ref this);
    // void __thiscall gmCharacterManagementUI::UpdateWorldName(gmCharacterManagementUI*)
    public void UpdateWorldName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, void>)0x004ECDB0)(ref this);
    // void __thiscall gmCharacterManagementUI::SelectCharacter(gmCharacterManagementUI*,unsigned int)
    public void SelectCharacter(uint i_iidCharacter) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, uint, void>)0x004ECDF0)(ref this, i_iidCharacter);
    // void __thiscall gmCharacterManagementUI::UpdateButtons(gmCharacterManagementUI*)
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, void>)0x004ECED0)(ref this);
    // void __thiscall gmCharacterManagementUI::RecvNotice_WorldName(UIElement**,int)
    public void RecvNotice_WorldName(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, int, void>)0x004ECFF0)(ref this, a2);
    // void __thiscall gmCharacterManagementUI::RebuildCharacterList(gmCharacterManagementUI*)
    public void RebuildCharacterList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, void>)0x004ED030)(ref this);
    // void __thiscall gmCharacterManagementUI::gmCharacterManagementUI(gmCharacterManagementUI*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, void>)0x004ED580)(ref this);
    // void __thiscall gmCharacterManagementUI::Update(gmCharacterManagementUI*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, void>)0x004ED740)(ref this);
    // void __cdecl gmCharacterManagementUI::Register(unsigned int)
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004ED780)(mode);
    // bool __thiscall gmCharacterManagementUI::MakeErrorMessageDialog(gmCharacterManagementUI*,const StringInfo*)
    public byte MakeErrorMessageDialog(ACBindings.StringInfo* siError) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, ACBindings.StringInfo*, byte>)0x004ED7A0)(ref this, siError);
    // bool __thiscall gmCharacterManagementUI::MakeDeleteCharacterConfirmationDialog(gmCharacterManagementUI*)
    public byte MakeDeleteCharacterConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, byte>)0x004ED930)(ref this);
    // bool __thiscall gmCharacterManagementUI::MakePleaseWaitDialog(gmCharacterManagementUI*)
    public byte MakePleaseWaitDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, byte>)0x004EDB60)(ref this);
    // bool __thiscall gmCharacterManagementUI::MakeEnteringWorldDialog(gmCharacterManagementUI*)
    public byte MakeEnteringWorldDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, byte>)0x004EDD20)(ref this);
    // bool __thiscall gmCharacterManagementUI::MakeConfirmExitDialog(gmCharacterManagementUI*)
    public byte MakeConfirmExitDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, byte>)0x004EDEE0)(ref this);
    // bool __thiscall gmCharacterManagementUI::OnAction(gmCharacterManagementUI*,const InputEvent*)
    public byte OnAction(ACBindings.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, ACBindings.InputEvent*, byte>)0x004EE0A0)(ref this, i_evt);
    // void __thiscall gmCharacterManagementUI::EnterGame(gmCharacterManagementUI*)
    public void EnterGame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, void>)0x004EE0D0)(ref this);
    // void __thiscall gmCharacterManagementUI::CloseDeleteCharacterDialog(gmCharacterManagementUI*,const char**)
    public void CloseDeleteCharacterDialog(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, sbyte**, void>)0x004EE130)(ref this, a2);
    // UIElementMessageListenResult __thiscall gmCharacterManagementUI::ListenToElementMessage(gmCharacterManagementUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004EE230)(ref this, i_rMsg);
    // void __thiscall gmCharacterManagementUI::RecvNotice_CloseDialog(gmCharacterManagementUI*,unsigned int,const PropertyCollection*)
    public void RecvNotice_CloseDialog(uint context, ACBindings.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCharacterManagementUI, uint, ACBindings.PropertyCollection*, void>)0x004EE3F0)(ref this, context, data);
}

