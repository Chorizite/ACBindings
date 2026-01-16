namespace ACBindings.Internal;


/// <summary>
/// Manages the character management screen in the game client, coordinating the UI elements that display available characters, handle selection, creation, deletion, and entry into gameplay. Tracks dialog states for confirmations, waiting indicators, and world name updates.
/// </summary>
public unsafe struct gmCharacterManagementUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIMainFramework BaseClass_UIMainFramework; // ACBindings.Internal.UIMainFramework
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmCharacterManagementUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, void> gmCharacterManagementUI_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, byte, void> Show; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, byte> Shown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, byte, void> ForceHidden; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharacterManagementUI*, void> Update; // function pointer

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

    /// <summary>Queues the UI framework into enter‑world mode when a begin‑enter‑world notice is received, preparing the character management interface for gameplay transition.
    /// <code>Offset: 0x004E8680
    /// void __thiscall gmCharacterManagementUI::RecvNotice_BeginEnterWorld(gmCharGenMainUI*)</code>
    /// </summary>
    /// <param name="this">The gmCharGenMainUI instance that triggers the transition.</param>
    public void RecvNotice_BeginEnterWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004E8680)(ref this);

    /// <summary>Handles responses from character generation verification by closing any active dialog and displaying an appropriate error message for name‑in‑use, corrupt data, or database‑down conditions.
    /// <code>Offset: 0x004ECBF0
    /// void __thiscall gmCharacterManagementUI::RecvNotice_CharGenVerificationResponse(gmCharacterManagementUI*,CG_VERIFICATION_RESPONSE)</code>
    /// </summary>
    /// <param name="i_rsvp">The result code returned from the server during character generation verification.</param>
    public void RecvNotice_CharGenVerificationResponse(ACBindings.Internal.CG_VERIFICATION_RESPONSE i_rsvp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void>)0x004ECBF0)(ref this, i_rsvp);

    /// <summary>Clears the previously selected character slot by resetting internal selection indices, clearing persistent data references, and updating the character generation state.
    /// <code>Offset: 0x004ECC80
    /// void __thiscall gmCharacterManagementUI::ResetPreviouslySelectedCharacterSlot(gmCharacterManagementUI*)</code>
    /// </summary>
    public void ResetPreviouslySelectedCharacterSlot() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004ECC80)(ref this);

    /// <summary>Destructs the character management UI, removing its root element from the framework, closing any active dialog contexts, resetting their identifiers, restoring base class virtual function tables, and invoking destructors for the notice handler and main framework components.
    /// <code>Offset: 0x004ECD10
    /// void __thiscall gmCharacterManagementUI::~gmCharacterManagementUI(gmCharacterManagementUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004ECD10)(ref this);

    /// <summary>Updates the UI element with ID 0x1000039B to show the current world name retrieved from the client instance.
    /// <code>Offset: 0x004ECDB0
    /// void __thiscall gmCharacterManagementUI::UpdateWorldName(gmCharacterManagementUI*)</code>
    /// </summary>
    public void UpdateWorldName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004ECDB0)(ref this);

    /// <summary>Selects a character by its unique ID, updating UI selection state, persistent avatar data, and character generation slot while resetting any previously selected character.
    /// <code>Offset: 0x004ECDF0
    /// void __thiscall gmCharacterManagementUI::SelectCharacter(gmCharacterManagementUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidCharacter">The identifier of the character to select.</param>
    public void SelectCharacter(uint i_iidCharacter) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, uint, void>)0x004ECDF0)(ref this, i_iidCharacter);

    /// <summary>Updates the state of character management UI buttons based on current selection and character set status: enables or disables Enter Game, Delete/Restore, and Create Character buttons according to whether a valid character is selected, if it is greyed out, or if the maximum number of characters has been reached.
    /// <code>Offset: 0x004ECED0
    /// void __thiscall gmCharacterManagementUI::UpdateButtons(gmCharacterManagementUI*)</code>
    /// </summary>
    public void UpdateButtons() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004ECED0)(ref this);

    /// <summary>Updates the world name display in the character management UI when a notice is received.
    /// <code>Offset: 0x004ECFF0
    /// void __thiscall gmCharacterManagementUI::RecvNotice_WorldName(UIElement**,int)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmCharacterManagementUI instance handling the UI update.</param>
    /// <param name="a2">Identifier of the incoming notice (currently unused by this implementation).</param>
    public void RecvNotice_WorldName(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, int, void>)0x004ECFF0)(ref this, a2);

    /// <summary>Rebuilds the character list user interface by refreshing the displayed characters from the game's persistent data. Clears existing items, repopulates the list with current character names and IDs, sorts them alphabetically, selects an appropriate entry, and updates the state of related action buttons.
    /// <code>Offset: 0x004ED030
    /// void __thiscall gmCharacterManagementUI::RebuildCharacterList(gmCharacterManagementUI*)</code>
    /// </summary>
    public void RebuildCharacterList() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004ED030)(ref this);

    /// <summary>Initializes the character management user interface by creating the root element, locating child controls such as the character list and action buttons, and registering global notice handlers. Updates world information, restores any persisted selected character, rebuilds the character list, and schedules a delayed UI refresh if applicable.
    /// <code>Offset: 0x004ED580
    /// void __thiscall gmCharacterManagementUI::gmCharacterManagementUI(gmCharacterManagementUI*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004ED580)(ref this);

    /// <summary>Updates the character management UI when new persistent data has been received, refreshing the world name and character list and closing any waiting dialog.
    /// <code>Offset: 0x004ED740
    /// void __thiscall gmCharacterManagementUI::Update(gmCharacterManagementUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004ED740)(ref this);

    /// <summary>Registers the character management UI framework class with the UI flow system using the specified mode.
    /// <code>Offset: 0x004ED780
    /// void __cdecl gmCharacterManagementUI::Register(unsigned int)</code>
    /// </summary>
    /// <param name="mode">Specifies the registration mode or context for the UI framework class.</param>
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004ED780)(mode);

    /// <summary>Creates an error message dialog displaying the supplied error text if no such dialog is currently active.
    /// <code>Offset: 0x004ED7A0
    /// bool __thiscall gmCharacterManagementUI::MakeErrorMessageDialog(gmCharacterManagementUI*,const StringInfo*)</code>
    /// </summary>
    /// <param name="siError">StringInfo containing the error message to show.</param>
    /// <returns>True when a new dialog was created; false if one already exists.</returns>
    public byte MakeErrorMessageDialog(ACBindings.Internal.StringInfo* siError) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, ACBindings.Internal.StringInfo*, byte>)0x004ED7A0)(ref this, siError);

    /// <summary>Creates a confirmation dialog for deleting the selected character, if none is currently shown.
    /// <code>Offset: 0x004ED930
    /// bool __thiscall gmCharacterManagementUI::MakeDeleteCharacterConfirmationDialog(gmCharacterManagementUI*)</code>
    /// </summary>
    /// <returns>True when the dialog is successfully created; otherwise false if a delete confirmation dialog already exists.</returns>
    public byte MakeDeleteCharacterConfirmationDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, byte>)0x004ED930)(ref this);

    /// <summary>Create a “Please Wait” dialog for character management if one does not already exist.
    /// <code>Offset: 0x004EDB60
    /// bool __thiscall gmCharacterManagementUI::MakePleaseWaitDialog(gmCharacterManagementUI*)</code>
    /// </summary>
    /// <returns>True when the dialog is created successfully; false if a dialog is already active and no new dialog is made.</returns>
    public byte MakePleaseWaitDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, byte>)0x004EDB60)(ref this);

    /// <summary>Creates an entering‑world dialog within the character management UI, initializing its properties and storing a context handle.
    /// <code>Offset: 0x004EDD20
    /// bool __thiscall gmCharacterManagementUI::MakeEnteringWorldDialog(gmCharacterManagementUI*)</code>
    /// </summary>
    /// <returns>True when the dialog is created successfully; false if a dialog context already exists.</returns>
    public byte MakeEnteringWorldDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, byte>)0x004EDD20)(ref this);

    /// <summary>Creates a confirm‑exit dialog for the character management UI when none exists, setting up dialog properties and storing its context.
    /// <code>Offset: 0x004EDEE0
    /// bool __thiscall gmCharacterManagementUI::MakeConfirmExitDialog(gmCharacterManagementUI*)</code>
    /// </summary>
    /// <returns>True if the dialog was successfully created; false if a dialog already existed.</returns>
    public byte MakeConfirmExitDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, byte>)0x004EDEE0)(ref this);

    /// <summary>Handles an input event; if the event’s action ID is 39, displays a confirmation dialog to exit the character management interface.
    /// <code>Offset: 0x004EE0A0
    /// bool __thiscall gmCharacterManagementUI::OnAction(gmCharacterManagementUI*,const InputEvent*)</code>
    /// </summary>
    /// <param name="i_evt">The input event to process.</param>
    /// <returns>True if the event was handled (action 39); otherwise false.</returns>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, ACBindings.Internal.InputEvent*, byte>)0x004EE0A0)(ref this, i_evt);

    /// <summary>Starts the login process for the chosen character, displaying an entering‑world dialog and calling the player system’s LogOnCharacter routine when the character is available and a player system exists.
    /// <code>Offset: 0x004EE0D0
    /// void __thiscall gmCharacterManagementUI::EnterGame(gmCharacterManagementUI*)</code>
    /// </summary>
    public void EnterGame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, void>)0x004EE0D0)(ref this);

    /// <summary>Closes the delete‑character confirmation dialog and, if the supplied response matches the expected confirmation string, deletes the currently selected character after displaying a waiting indicator.
    /// <code>Offset: 0x004EE130
    /// void __thiscall gmCharacterManagementUI::CloseDeleteCharacterDialog(gmCharacterManagementUI*,const char**)</code>
    /// </summary>
    /// <param name="a2">Pointer to the user’s response text from the delete‑character dialog.</param>
    public void CloseDeleteCharacterDialog(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, sbyte**, void>)0x004EE130)(ref this, a2);

    /// <summary>Processes UI element messages for the character management interface, executing actions such as selecting a character, restoring or deleting it, entering the game, and displaying confirmation dialogs based on the element and message identifiers.
    /// <code>Offset: 0x004EE230
    /// UIElementMessageListenResult __thiscall gmCharacterManagementUI::ListenToElementMessage(gmCharacterManagementUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">Reference to the gmCharacterManagementUI instance handling the message.</param>
    /// <param name="i_rMsg">Pointer to UIElementMessageInfo containing information about the originating UI element, message type, parameters, and coordinates.</param>
    /// <returns>Indicates whether the message was handled or forwarded to the base framework.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004EE230)(ref this, i_rMsg);

    /// <summary>Closes an open character‑management dialog identified by <paramref name="context"/>, updating UI state according to information supplied in the property collection.
    /// <code>Offset: 0x004EE3F0
    /// void __thiscall gmCharacterManagementUI::RecvNotice_CloseDialog(gmCharacterManagementUI*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    /// <param name="context">Identifier of the dialog or action that should be closed.</param>
    /// <param name="data">Property collection containing additional details such as flags and strings used during the close operation.</param>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharacterManagementUI, uint, ACBindings.Internal.PropertyCollection*, void>)0x004EE3F0)(ref this, context, data);
}

