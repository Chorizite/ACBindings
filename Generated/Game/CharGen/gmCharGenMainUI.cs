namespace ACBindings.Internal;


/// <summary>Coordinates the character‑generation wizard, managing pages, navigation buttons, progress state, and dialog contexts while interfacing with the player system.</summary>
public unsafe struct gmCharGenMainUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIMainFramework BaseClass_UIMainFramework; // ACBindings.Internal.UIMainFramework
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmCharGenMainUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharGenMainUI*, void> gmCharGenMainUI_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharGenMainUI*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharGenMainUI*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharGenMainUI*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharGenMainUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharGenMainUI*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharGenMainUI*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharGenMainUI*, byte, void> Show; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharGenMainUI*, byte> Shown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharGenMainUI*, byte, void> ForceHidden; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharGenMainUI*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharGenMainUI*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharGenMainUI*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharGenMainUI*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmCharGenMainUI*, void> Update; // function pointer

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
    public ACBindings.Internal.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.Internal.UIElement* m_rootField;
    public ACBindings.Internal.UIElement* m_ProgressBar;
    public ACBindings.Internal.UIElement* m_MainMenu;
    public ACBindings.Internal.UIElement* m_pMasterPage;
    public ACBindings.Internal.gmCGHeritagePage* m_pHeritagePage;
    public ACBindings.Internal.gmCGProfessionPage* m_pProfessionPage;
    public ACBindings.Internal.gmCGSkillsPage* m_pSkillsPage;
    public ACBindings.Internal.gmCGAppearancePage* m_pAppearancePage;
    public ACBindings.Internal.gmCGTownPage* m_pTownPage;
    public ACBindings.Internal.gmCGSummaryPage* m_pSummaryPage;
    public ACBindings.Internal.UIElement_Button* m_pHeritageButton;
    public ACBindings.Internal.UIElement_Button* m_pProfessionButton;
    public ACBindings.Internal.UIElement_Button* m_pSkillsButton;
    public ACBindings.Internal.UIElement_Button* m_pAppearanceButton;
    public ACBindings.Internal.UIElement_Button* m_pTownButton;
    public ACBindings.Internal.UIElement_Button* m_pSummaryButton;
    public ACBindings.Internal.UIElement_Button* m_pLeftButton;
    public ACBindings.Internal.UIElement_Button* m_pRightButton;
    public ACBindings.Internal.UIElement_Button* m_pFinishButton;
    public ACBindings.Internal.UIElement_Button* m_pHelpButton;
    public ACBindings.Internal.UIElement_Button* m_pExitButton;
    public ACBindings.Internal.UIElement_Button* m_pRandomButton;
    public ACBindings.Internal.gmCharGenMainUI.ECGProgress m_eProgressState;
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

    /// <summary>Updates the character generation wizard to the specified step, activating the corresponding page and adjusting button visibility while handling special heritage group cases.
    /// <code>Offset: 0x004E86A0
    /// void __thiscall gmCharGenMainUI::SetProgressState(gmCharGenMainUI*,gmCharGenMainUI::ECGProgress)</code>
    /// </summary>
    /// <param name="eState">The desired progress state from the ECGProgress enumeration.</param>
    public void SetProgressState(ACBindings.Internal.gmCharGenMainUI.ECGProgress eState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharGenMainUI, ACBindings.Internal.gmCharGenMainUI.ECGProgress, void>)0x004E86A0)(ref this, eState);

    /// <summary>Randomizes the selected character generation step based on the current progress state, updating relevant UI pages.
    /// <code>Offset: 0x004E8A00
    /// void __thiscall gmCharGenMainUI::DoRandom(gmCharGenMainUI*)</code>
    /// </summary>
    public void DoRandom() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharGenMainUI, void>)0x004E8A00)(ref this);

    /// <summary>Initializes the character‑generation user interface, creating the root layout, configuring navigation buttons, establishing page references, registering notice and global message handlers, randomizing a new character based on account status, and setting the initial progress state to the heritage step.
    /// <code>Offset: 0x004E8B40
    /// void __thiscall gmCharGenMainUI::gmCharGenMainUI(gmCharGenMainUI*)</code>
    /// </summary>
    /// <returns>None. The constructor performs all setup in place.</returns>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharGenMainUI, void>)0x004E8B40)(ref this);

    /// <summary>Destroys the character‑generation main UI, unregistering it from global messages, removing its root element, clearing internal context IDs, and destroying the associated notice handler and UI framework base classes.
    /// <code>Offset: 0x004E9010
    /// void __thiscall gmCharGenMainUI::~gmCharGenMainUI(gmCharGenMainUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharGenMainUI, void>)0x004E9010)(ref this);

    /// <summary>Creates an instance of the character‑generation main UI framework and returns a pointer to its base UIMainFramework.
    /// <code>Offset: 0x004E9070
    /// UIMainFramework* __cdecl gmCharGenMainUI::Create()</code>
    /// </summary>
    /// <returns>A valid UIMainFramework pointer on success; null if memory allocation fails.</returns>
    public static ACBindings.Internal.UIMainFramework* Create() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIMainFramework*>)0x004E9070)();

    /// <summary>Closes the randomize warning dialog and triggers character randomization when confirmed.
    /// <code>Offset: 0x004E9090
    /// bool __thiscall gmCharGenMainUI::CloseRandomizeWarningDialog(gmCharGenMainUI*,bool)</code>
    /// </summary>
    /// <param name="i_bConfirm">Indicates whether the user confirmed randomization.</param>
    /// <returns>True after closing the dialog (and possibly initiating a randomization).</returns>
    public byte CloseRandomizeWarningDialog(byte i_bConfirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharGenMainUI, byte, byte>)0x004E9090)(ref this, i_bConfirm);

    /// <summary>Registers the character generation main UI framework class for a specified mode with the UI flow system.
    /// <code>Offset: 0x004E90D0
    /// void __cdecl gmCharGenMainUI::Register(unsigned int)</code>
    /// </summary>
    /// <param name="mode">Identifier indicating the registration context or mode used by UIFlow.</param>
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004E90D0)(mode);

    /// <summary>Updates the character‑generation main user interface, handling any pending log‑on selections and advancing to the next UI stage.
    /// <code>Offset: 0x004E90F0
    /// void __thiscall gmCharGenMainUI::Update(gmCharGenMainUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharGenMainUI, void>)0x004E90F0)(ref this);

    /// <summary>Shows an exit confirmation dialog if no dialog is currently active. Creates and stores the dialog context, returning true on success, or false when a dialog already exists or creation fails.
    /// <code>Offset: 0x004E92E0
    /// bool __thiscall gmCharGenMainUI::DoExit(gmCharGenMainUI*)</code>
    /// </summary>
    /// <returns>True if the exit dialog was successfully displayed; otherwise false.</returns>
    public byte DoExit() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharGenMainUI, byte>)0x004E92E0)(ref this);

    /// <summary>Create and display a credit warning dialog during character generation, unless one is already active.
    /// <code>Offset: 0x004E9500
    /// bool __thiscall gmCharGenMainUI::MakeCreditWarningDialog(gmCharGenMainUI*)</code>
    /// </summary>
    /// <returns>True if the dialog was successfully created; false if it already exists or creation failed.</returns>
    public byte MakeCreditWarningDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharGenMainUI, byte>)0x004E9500)(ref this);

    /// <summary>Create a randomization warning dialog for character generation when none is currently shown. It configures required properties, invokes the dialog factory, records the new context ID, and cleans up on failure.
    /// <code>Offset: 0x004E9720
    /// bool __thiscall gmCharGenMainUI::MakeRandomizeWarningDialog(gmCharGenMainUI*)</code>
    /// </summary>
    /// <returns>True if the dialog was successfully created; otherwise false.</returns>
    public byte MakeRandomizeWarningDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharGenMainUI, byte>)0x004E9720)(ref this);

    /// <summary>Creates an error message dialog that displays the supplied StringInfo, ensuring only one error dialog is active at a time.
    /// <code>Offset: 0x004E9940
    /// bool __thiscall gmCharGenMainUI::MakeErrorMessageDialog(gmCharGenMainUI*,const StringInfo*)</code>
    /// </summary>
    /// <param name="siError">The string information to show in the error message dialog.</param>
    /// <returns>True if the dialog was created; false if an error dialog already exists.</returns>
    public byte MakeErrorMessageDialog(ACBindings.Internal.StringInfo* siError) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharGenMainUI, ACBindings.Internal.StringInfo*, byte>)0x004E9940)(ref this, siError);

    /// <summary>Creates and displays the “Terms of Duty” required warning dialog if it has not yet been shown.
    /// <code>Offset: 0x004E9AD0
    /// bool __thiscall gmCharGenMainUI::MakeToDWarningDialog(gmCharGenMainUI*)</code>
    /// </summary>
    /// <returns>True when the dialog is successfully created; false if the dialog was previously displayed.</returns>
    public byte MakeToDWarningDialog() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharGenMainUI, byte>)0x004E9AD0)(ref this);

    /// <summary>Responds to global messages with ID 1 by executing exit or opening help based on data payload.
    /// <code>Offset: 0x004E9C90
    /// void __thiscall gmCharGenMainUI::ListenToGlobalMessage(gmCharGenMainUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the received message.</param>
    /// <param name="i_data_int">Data associated with the message, used to distinguish specific actions.</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharGenMainUI, uint, int, void>)0x004E9C90)(ref this, i_messageID, i_data_int);

    /// <summary>Handles responses from the character verification process, closing any open dialogs and presenting error messages or success indicators as needed.
    /// <code>Offset: 0x004E9CC0
    /// void __thiscall gmCharGenMainUI::RecvNotice_CharGenVerificationResponse(gmCharGenMainUI*,CG_VERIFICATION_RESPONSE)</code>
    /// </summary>
    /// <param name="i_rsvp">The result of the character verification request (e.g., OK, name in use, banned).</param>
    public void RecvNotice_CharGenVerificationResponse(ACBindings.Internal.CG_VERIFICATION_RESPONSE i_rsvp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharGenMainUI, ACBindings.Internal.CG_VERIFICATION_RESPONSE, void>)0x004E9CC0)(ref this, i_rsvp);

    /// <summary>Completes the character‑generation process when the user attempts to finalize their character. Validates the entered name, checks remaining attribute credits when requested, and sends a char‑gen result packet to the server if all conditions are met.
    /// <code>Offset: 0x004E9E00
    /// bool __thiscall gmCharGenMainUI::DoFinish(gmCharGenMainUI*,bool)</code>
    /// </summary>
    /// <param name="bCreditCheck">Whether to verify that the player has enough remaining attribute credits before finalizing.</param>
    /// <returns>True if the character generation was successfully submitted; otherwise false.</returns>
    public byte DoFinish(byte bCreditCheck) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharGenMainUI, byte, byte>)0x004E9E00)(ref this, bCreditCheck);

    /// <summary>Handles button and UI element events within the character‑generation interface, advancing progress steps, executing finish or randomization actions, and triggering warnings when appropriate.
    /// <code>Offset: 0x004EA0E0
    /// UIElementMessageListenResult __thiscall gmCharGenMainUI::ListenToElementMessage(gmCharGenMainUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element event, including its identifier, message type, and any parameters needed to determine the action.</param>
    /// <returns>Result indicating whether this handler processed the message; if not handled, the base framework may continue processing it.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharGenMainUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004EA0E0)(ref this, i_rMsg);

    /// <summary>Handles a close‑dialog notice for the character‑generation UI, interpreting properties in the supplied PropertyCollection to determine which dialog or UI element should be dismissed and performing the appropriate transition such as hiding the dialog, completing character creation, or closing warning pop‑ups.
    /// <code>Offset: 0x004EA410
    /// void __thiscall gmCharGenMainUI::RecvNotice_CloseDialog(gmCharGenMainUI*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    /// <param name="context">Identifier of the dialog or UI element that is being closed.</param>
    /// <param name="data">Property collection containing flags and data used to control how the close operation should be carried out.</param>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCharGenMainUI, uint, ACBindings.Internal.PropertyCollection*, void>)0x004EA410)(ref this, context, data);
}

