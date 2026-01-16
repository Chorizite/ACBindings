namespace ACBindings.Internal;


/// <summary>Gameplay UI framework managing the core player interface, dialog confirmations, session state, and child element references.</summary>
public unsafe struct gmGamePlayUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.GamePlayUI BaseClass_GamePlayUI; // ACBindings.Internal.GamePlayUI
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmGamePlayUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, void> gmGamePlayUI_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, byte, void> Show; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, byte> Shown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, byte, void> ForceHidden; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmGamePlayUI*, void> Update; // function pointer

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

    /// <summary>Shows or hides the gameplay user interface according to the supplied flag, coordinating with the underlying UI framework and respecting special contexts such as waiting periods or session endings.
    /// <code>Offset: 0x004EA8F0
    /// void __thiscall gmGamePlayUI::Show(gmGamePlayUI*,bool)</code>
    /// </summary>
    /// <param name="shown">True to display the UI; false to hide it.</param>
    public void Show(byte shown) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, byte, void>)0x004EA8F0)(ref this, shown);

    /// <summary>Queues the gameplay UI mode in the underlying UI framework, ensuring that the interface reflects the current gameplay context.
    /// <code>Offset: 0x004EA960
    /// void __thiscall gmGamePlayUI::Update(gmGamePlayUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, void>)0x004EA960)(ref this);

    /// <summary>Processes gameplay UI element messages, handling panel visibility toggles and element cleanup before delegating to the base framework.
    /// <code>Offset: 0x004EA970
    /// UIElementMessageListenResult __thiscall gmGamePlayUI::ListenToElementMessage(gmGamePlayUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the message sent by a UI element.</param>
    /// <returns>The result of listening to the message as determined by UIFramework::ListenToElementMessage.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004EA970)(ref this, i_rMsg);

    /// <summary>Aborts an active gameplay confirmation dialog when the requested type and context match the current pending confirmation.
    /// <code>Offset: 0x004EAA00
    /// void __thiscall gmGamePlayUI::RecvNotice_AbortConfirmationRequest(gmGamePlayUI*,int,unsigned int)</code>
    /// </summary>
    /// <param name="confirmationType">The confirmation type identifier to validate against the stored dialog.</param>
    /// <param name="context">A unique context ID associated with the pending confirmation request.</param>
    public void RecvNotice_AbortConfirmationRequest(int confirmationType, uint context) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, int, uint, void>)0x004EAA00)(ref this, confirmationType, context);

    /// <summary>Responds to a player option change notification, updating the side‑by‑side vitals UI visibility based on whether the option is enabled.
    /// <code>Offset: 0x004EAA30
    /// void __thiscall gmGamePlayUI::RecvNotice_PlayerOptionChanged(gmGamePlayUI*,PlayerOption)</code>
    /// </summary>
    /// <param name="i_eOption">The player option that changed.</param>
    public void RecvNotice_PlayerOptionChanged(ACBindings.Internal.PlayerOption i_eOption) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, ACBindings.Internal.PlayerOption, void>)0x004EAA30)(ref this, i_eOption);

    /// <summary>Handles input action codes for the game play UI, updating logout state, delegating standard actions, or opening help.
    /// <code>Offset: 0x004EAA80
    /// void __thiscall gmGamePlayUI::HandleKeyPress(gmGamePlayUI*,int)</code>
    /// </summary>
    /// <param name="i_nInputAction">The input action code generated by the input system.</param>
    public void HandleKeyPress(int i_nInputAction) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, int, void>)0x004EAA80)(ref this, i_nInputAction);

    /// <summary>Closes the current gameplay confirmation dialog by sending a confirmation response event and resetting the dialog context.
    /// <code>Offset: 0x004EAB10
    /// bool __thiscall gmGamePlayUI::CloseGameplayConfirmationDialog(gmGamePlayUI*,bool)</code>
    /// </summary>
    /// <param name="confirm">Indicates whether the user accepted (true) or declined (false) the confirmation prompt.</param>
    /// <returns>True after clearing the dialog state.</returns>
    public byte CloseGameplayConfirmationDialog(byte confirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, byte, byte>)0x004EAB10)(ref this, confirm);

    /// <summary>Initializes child UI components for the gameplay interface by locating specific sub‑elements within the main gameplay UI and configuring them.
    /// <code>Offset: 0x004EAB50
    /// void __thiscall gmGamePlayUI::SetupChildren(gmGamePlayUI*)</code>
    /// </summary>
    public void SetupChildren() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, void>)0x004EAB50)(ref this);

    /// <summary>Initializes a gameplay user interface by setting screen resolution, registering global UI messages and event handlers, initializing internal state variables, constructing child elements, and making the UI visible.
    /// <code>Offset: 0x004EACA0
    /// void __thiscall gmGamePlayUI::gmGamePlayUI(gmGamePlayUI*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, void>)0x004EACA0)(ref this);

    /// <summary>Creates a new gmGamePlayUI instance and returns its UIMainFramework base pointer.
    /// <code>Offset: 0x004EAE20
    /// UIMainFramework* __cdecl gmGamePlayUI::Create()</code>
    /// </summary>
    /// <returns>A pointer to the initialized UIMainFramework; or null if memory allocation fails.</returns>
    public static ACBindings.Internal.UIMainFramework* Create() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIMainFramework*>)0x004EAE20)();

    /// <summary>Ends the current gameplay session, optionally logging out when requested and conditions allow.
    /// <code>Offset: 0x004EAE40
    /// bool __thiscall gmGamePlayUI::EndSession(gmGamePlayUI*,bool)</code>
    /// </summary>
    /// <param name="requested">True to request a logout/quit; false to simply finish the session without exiting.</param>
    /// <returns>True if the session was successfully ended or a quit/logoff was initiated; false if the session is already ending or logout was not confirmed.</returns>
    public byte EndSession(byte requested) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, byte, byte>)0x004EAE40)(ref this, requested);

    /// <summary>Destroys a gmGamePlayUI instance, terminating active gameplay sessions, unregistering global event listeners, closing UI dialogs, restoring display resolution if needed, and invoking base class destructors.
    /// <code>Offset: 0x004EAF30
    /// void __thiscall gmGamePlayUI::~gmGamePlayUI(gmGamePlayUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, void>)0x004EAF30)(ref this);

    /// <summary>Registers the gameplay UI framework class with the UI flow system for a specified mode identifier.
    /// <code>Offset: 0x004EB010
    /// void __cdecl gmGamePlayUI::Register(unsigned int)</code>
    /// </summary>
    /// <param name="i_modeID">The unique identifier representing the mode under which this UI is registered.</param>
    public static void Register(uint i_modeID) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004EB010)(i_modeID);

    /// <summary>Adjusts camera scale when a camera set exists and processes session termination, handling logout confirmation and preventing logoff while the character is mid‑air.
    /// <code>Offset: 0x004EB030
    /// void __thiscall gmGamePlayUI::UseTime(gmGamePlayUI*)</code>
    /// </summary>
    /// <param name="this">The gmGamePlayUI instance.</param>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, void>)0x004EB030)(ref this);

    /// <summary>
    /// Processes a close dialog notice for the gameplay UI, updating UI elements and associated resources based on the supplied context and property data.
    /// 
    /// <code>Offset: 0x004EB180
    /// void __thiscall gmGamePlayUI::RecvNotice_CloseDialog(gmGamePlayUI*,unsigned int,const PropertyCollection*)</code>
    /// </summary>
    /// <param name="context">Identifier indicating which dialog or UI component should be closed.</param>
    /// <param name="data">Collection of properties providing additional information such as flags, callbacks, or object references related to the close operation.</param>
    public void RecvNotice_CloseDialog(uint context, ACBindings.Internal.PropertyCollection* data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, uint, ACBindings.Internal.PropertyCollection*, void>)0x004EB180)(ref this, context, data);

    /// <summary>Builds a file-system path for a UI layout based on an identifier and the dimensions of an internal region, storing the result in the supplied buffer.
    /// <code>Offset: 0x004EB320
    /// int __thiscall gmGamePlayUI::CreateScreenLayoutPath(UIRegion**,const char*,char**)</code>
    /// </summary>
    /// <param name="a2">Layout identifier. The special value “#auto” triggers automatic generation using the object’s name and region size; a single‑character string selects the default file; otherwise the string is used as the filename base.</param>
    /// <param name="a3">Pointer to a char* that will receive the constructed path. If *a3 points to an existing allocated string, it is released before assigning the new value.</param>
    /// <returns>Zero if the layout identifier string was deallocated after use; non‑zero otherwise.</returns>
    public int CreateScreenLayoutPath(sbyte* a2, sbyte** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, sbyte*, sbyte**, int>)0x004EB320)(ref this, a2, a3);

    /// <summary>Parses the specified screen layout file and applies element positions and sizes to the current UI framework.
    /// <code>Offset: 0x004EB580
    /// int __thiscall gmGamePlayUI::LoadScreenLayout(int,const char*)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmGamePlayUI instance.</param>
    /// <param name="a2">Name of the layout file or identifier to load.</param>
    /// <returns>1 if the layout was successfully loaded; 0 otherwise.</returns>
    public int LoadScreenLayout(sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, sbyte*, int>)0x004EB580)(ref this, a2);

    /// <summary>Writes current screen layout information to the specified file path.
    /// <code>Offset: 0x004EB9E0
    /// LONG __thiscall gmGamePlayUI::SaveScreenLayout(int,const char*)</code>
    /// </summary>
    /// <param name="a2">The file path where the screen layout will be saved.</param>
    /// <returns>The updated reference count of the input string after it has been decremented; a value of zero indicates the string was released.</returns>
    public int SaveScreenLayout(sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, sbyte*, int>)0x004EB9E0)(ref this, a2);

    /// <summary>Responds to global messages by delegating actions such as key presses, time updates, or loading UI layouts when appropriate.
    /// <code>Offset: 0x004EC230
    /// void __thiscall gmGamePlayUI::ListenToGlobalMessage(gmGamePlayUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier indicating which global event to handle.</param>
    /// <param name="i_data_int">Additional integer data supplied with the message (used for key press handling).</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, uint, int, void>)0x004EC230)(ref this, i_messageID, i_data_int);

    /// <summary>Saves the current UI layout using data supplied by a notice message and returns the status of the operation.
    /// <code>Offset: 0x004EC290
    /// LONG __thiscall gmGamePlayUI::RecvNotice_SaveUI(void*,const char**)</code>
    /// </summary>
    /// <param name="a2">Array of strings; the first element contains the identifier or path for the layout to be saved.</param>
    /// <returns>The result code from gmGamePlayUI::SaveScreenLayout, indicating success or failure.</returns>
    public int RecvNotice_SaveUI(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, sbyte**, int>)0x004EC290)(ref this, a2);

    /// <summary>Loads the user interface layout specified by the supplied string and returns the result of the underlying LoadScreenLayout call.
    /// <code>Offset: 0x004EC2C0
    /// int __thiscall gmGamePlayUI::RecvNotice_LoadUI(void*,const char**)</code>
    /// </summary>
    /// <param name="a2">Reference to a null‑terminated string that identifies the UI layout to load.</param>
    /// <returns>An integer status code, typically zero when loading succeeds.</returns>
    public int RecvNotice_LoadUI(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, sbyte**, int>)0x004EC2C0)(ref this, a2);

    /// <summary>Handles a notice indicating that the player's description has been received and loads the appropriate UI layout file for the gameplay screen.
    /// <code>Offset: 0x004EC2F0
    /// void __thiscall gmGamePlayUI::RecvNotice_PlayerDescReceived(gmGamePlayUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player's quality data (unused in this handler).</param>
    /// <param name="i_playerModule">Additional player module information (unused in this handler).</param>
    public void RecvNotice_PlayerDescReceived(ACBindings.Internal.CACQualities* i_playerDesc, ACBindings.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, ACBindings.Internal.CACQualities*, ACBindings.Internal.CPlayerModule*, void>)0x004EC2F0)(ref this, i_playerDesc, i_playerModule);

    /// <summary>Create a logout confirmation dialog with the specified message if no logout dialog is currently active.
    /// <code>Offset: 0x004EC330
    /// bool __thiscall gmGamePlayUI::MakeLogoutConfirmationDialog(gmGamePlayUI*,const StringInfo*)</code>
    /// </summary>
    /// <param name="msg">Message text to display in the confirmation dialog, typically a localized string.</param>
    /// <returns>True if the dialog was successfully created; false if a logout dialog already exists or creation failed.</returns>
    public byte MakeLogoutConfirmationDialog(ACBindings.Internal.StringInfo* msg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, ACBindings.Internal.StringInfo*, byte>)0x004EC330)(ref this, msg);

    /// <summary>Creates and displays a gameplay confirmation dialog with the supplied message.
    /// <code>Offset: 0x004EC520
    /// bool __thiscall gmGamePlayUI::MakeGameplayConfirmationDialog(gmGamePlayUI*,const StringInfo*)</code>
    /// </summary>
    /// <param name="msg">Message content for the dialog, represented as a StringInfo structure.</param>
    /// <returns>True if the dialog was successfully created; false if a dialog already exists or creation failed.</returns>
    public byte MakeGameplayConfirmationDialog(ACBindings.Internal.StringInfo* msg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, ACBindings.Internal.StringInfo*, byte>)0x004EC520)(ref this, msg);

    /// <summary>Handles a request to display a gameplay confirmation dialog for altering a skill, building the message from the supplied text and appending “ Continue?”, updating internal context state, showing the dialog, and cleaning up temporary strings.
    /// <code>Offset: 0x004EC700
    /// LONG __thiscall gmGamePlayUI::RecvNotice_AlterSkill_ConfirmationRequest(_DWORD*,void*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a C‑style string that forms the base of the confirmation message.</param>
    /// <param name="a3">Integer value used as the confirmation context identifier within the UI system.</param>
    /// <returns>The reference count of the temporary wide‑string buffer after it has been released; zero indicates the buffer was freed.</returns>
    public int RecvNotice_AlterSkill_ConfirmationRequest(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, System.IntPtr, int, int>)0x004EC700)(ref this, a2, a3);

    /// <summary>Displays a confirmation dialog asking the player to confirm an attribute change. The supplied notice text is appended with “ Continue?” and stored in internal context before showing the dialog.
    /// <code>Offset: 0x004EC7E0
    /// LONG __thiscall gmGamePlayUI::RecvNotice_AlterAttribute_ConfirmationRequest(_DWORD*,void*,int)</code>
    /// </summary>
    /// <param name="a2">Base notice string that will be extended for the confirmation prompt.</param>
    /// <param name="a3">Identifier or context value associated with the attribute alteration to be confirmed.</param>
    /// <returns>Status code from the internal reference count decrement; zero indicates success, non‑zero signals remaining references.</returns>
    public int RecvNotice_AlterAttribute_ConfirmationRequest(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, System.IntPtr, int, int>)0x004EC7E0)(ref this, a2, a3);

    /// <summary>Displays an augmentation confirmation dialog with the supplied message, appending “ Continue?” and storing the context for later processing.
    /// <code>Offset: 0x004EC8C0
    /// LONG __thiscall gmGamePlayUI::RecvNotice_Augmentation_ConfirmationRequest(_DWORD*,void*,int)</code>
    /// </summary>
    /// <param name="a2">ANSI string containing the base prompt text shown in the confirmation dialog.</param>
    /// <param name="a3">Integer identifying the augmentation confirmation context to be handled after user responds.</param>
    /// <returns>Long value from internal reference‑count cleanup; callers may ignore it.</returns>
    public int RecvNotice_Augmentation_ConfirmationRequest(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, System.IntPtr, int, int>)0x004EC8C0)(ref this, a2, a3);

    /// <summary>Displays a Yes/No confirmation dialog for the gameplay UI using data from a notice object and updates internal context state.
    /// <code>Offset: 0x004EC9A0
    /// LONG __thiscall gmGamePlayUI::RecvNotice_YesNo_ConfirmationRequest(_DWORD*,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a notice structure that contains the confirmation text and a reference count used for memory management.</param>
    /// <param name="a3">Identifier indicating which confirmation request is being processed (used to set internal context fields).</param>
    /// <returns>Updated reference count after processing; zero indicates the notice object was released.</returns>
    public int RecvNotice_YesNo_ConfirmationRequest(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, int*, int, int>)0x004EC9A0)(ref this, a2, a3);

    /// <summary>Handles a crafting interaction confirmation by appending a continuation prompt to the supplied message and displaying a gameplay confirmation dialog while recording context information.
    /// <code>Offset: 0x004ECA50
    /// LONG __thiscall gmGamePlayUI::RecvNotice_CraftInteraction_ConfirmationRequest(_DWORD*,void*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the base message string to which the “Continue?” suffix is appended for the confirmation dialog.</param>
    /// <param name="a3">Integer identifier used as context for this confirmation request.</param>
    /// <returns>Long status code returned from reference count management; zero indicates successful handling, non‑zero may indicate pending cleanup or error.</returns>
    public int RecvNotice_CraftInteraction_ConfirmationRequest(System.IntPtr a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, System.IntPtr, int, int>)0x004ECA50)(ref this, a2, a3);

    /// <summary>Handles an end‑character‑session notice. When confirmed, displays a logout confirmation dialog; otherwise sets internal state flags to indicate the session is pending termination.
    /// <code>Offset: 0x004ECB30
    /// void __thiscall gmGamePlayUI::RecvNotice_EndCharacterSession(gmGamePlayUI*,int)</code>
    /// </summary>
    /// <param name="confirm">Non‑zero value triggers the confirmation dialog; zero skips it and updates internal flags only.</param>
    public void RecvNotice_EndCharacterSession(int confirm) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, int, void>)0x004ECB30)(ref this, confirm);

    /// <summary>Displays a logoff confirmation dialog when a logoff notice is received, prompting the user to confirm ending their session.
    /// <code>Offset: 0x004ECBA0
    /// void __thiscall gmGamePlayUI::RecvNotice_Logoff(gmGamePlayUI*)</code>
    /// </summary>
    public void RecvNotice_Logoff() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmGamePlayUI, void>)0x004ECBA0)(ref this);
}

