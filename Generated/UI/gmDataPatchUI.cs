namespace ACBindings.Internal;


/// <summary>Handles the user interface during data patch operations, tracking connection progress, patch status, and coordinating UI transitions when patches complete.</summary>
public unsafe struct gmDataPatchUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIMainFramework BaseClass_UIMainFramework; // ACBindings.Internal.UIMainFramework
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler
    public ACBindings.Internal.CDDDStatusPlugin BaseClass_CDDDStatusPlugin; // ACBindings.Internal.CDDDStatusPlugin

    // Child Types
    public unsafe struct gmDataPatchUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, void> gmDataPatchUI_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, byte, void> Show; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, byte> Shown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, byte, void> ForceHidden; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, void> Update; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement* m_datapatchField;
    public ACBindings.Internal.UIElement_Text* m_connectText;
    public ACBindings.Internal.UIElement* m_connectMeter;
    public ACBindings.Internal.UIElement_Text* m_patchText;
    public ACBindings.Internal.UIElement* m_patchMeter;
    public float m_fConnectLevel;
    public float m_fPatchLevel;
    public uint m_expected;
    public uint m_recieved;
    public double m_timeNextDiskspaceCheck;

    // Generated Constructor
    public gmDataPatchUI() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Handles messages from UI elements, triggering a specific UI mode when the message id is 1 and the element id matches 268436508, then delegates to the base framework handler.
    /// <code>Offset: 0x004EEAC0
    /// UIElementMessageListenResult __thiscall gmDataPatchUI::ListenToElementMessage(gmDataPatchUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element message being processed.</param>
    /// <returns>The result of the base framework's message handling.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDataPatchUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004EEAC0)(ref this, i_rMsg);

    /// <summary>Updates the connection progress indicator and adjusts its visual representation based on the supplied level.
    /// <code>Offset: 0x004EEAF0
    /// void __thiscall gmDataPatchUI::SetConnectLevel(gmDataPatchUI*,float)</code>
    /// </summary>
    /// <param name="i_fConnectLevel">The desired connection percentage, ranging from 0.0 (no connection) to 1.0 (fully connected).</param>
    public void SetConnectLevel(float i_fConnectLevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDataPatchUI, float, void>)0x004EEAF0)(ref this, i_fConnectLevel);

    /// <summary>Updates the patch level stored by this UI component and refreshes its visual meter when the new value differs from the current level.
    /// <code>Offset: 0x004EEB70
    /// void __thiscall gmDataPatchUI::SetPatchLevel(gmDataPatchUI*,float)</code>
    /// </summary>
    /// <param name="i_fPatchLevel">The new patch level to set.</param>
    public void SetPatchLevel(float i_fPatchLevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDataPatchUI, float, void>)0x004EEB70)(ref this, i_fPatchLevel);

    /// <summary>Updates the data patch user interface by ensuring the connection progress level reaches full completion, periodically checking available disk space while patches are expected, and queuing a transition to the next UI mode when both connection and patch operations are complete.
    /// <code>Offset: 0x004EEBA0
    /// void __thiscall gmDataPatchUI::UseTime(gmDataPatchUI*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDataPatchUI, void>)0x004EEBA0)(ref this);

    /// <summary>Handles data patch events, updating UI text and patch progress indicators accordingly.
    /// <code>Offset: 0x004EEC80
    /// void __thiscall gmDataPatchUI::OnDDDEvent(gmDataPatchUI*,DDDEvent,unsigned int)</code>
    /// </summary>
    /// <param name="eventNum">The DDD event code indicating the current stage of data patching (e.g., interrogation, pending, begin, end, or downloaded).</param>
    /// <param name="nBytes">A numeric value associated with the event; its interpretation depends on the event type and is used to set progress levels or identifiers.</param>
    public void OnDDDEvent(ACBindings.Internal.DDDEvent eventNum, uint nBytes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDataPatchUI, ACBindings.Internal.DDDEvent, uint, void>)0x004EEC80)(ref this, eventNum, nBytes);

    /// <summary>Handles global messages and performs a time‑update routine when the incoming message has ID 3.
    /// <code>Offset: 0x004EEEA0
    /// void __thiscall gmDataPatchUI::ListenToGlobalMessage(gmDataPatchUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">Identifier of the received global message.</param>
    /// <param name="i_data_int">Optional integer data accompanying the message; ignored in this implementation.</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDataPatchUI, uint, int, void>)0x004EEEA0)(ref this, i_messageID, i_data_int);

    /// <summary>Destroys a gmDataPatchUI instance, unregistering UI components and listeners, removing the associated plugin prototype, and releasing all base class resources.
    /// <code>Offset: 0x004EEEB0
    /// void __thiscall gmDataPatchUI::~gmDataPatchUI(gmDataPatchUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDataPatchUI, void>)0x004EEEB0)(ref this);

    /// <summary>Creates the data patch UI framework, initializes its child elements, registers a global message listener, and resets connection and patch levels to zero.
    /// <code>Offset: 0x004EEF40
    /// void __thiscall gmDataPatchUI::gmDataPatchUI(gmDataPatchUI*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDataPatchUI, void>)0x004EEF40)(ref this);

    /// <summary>Registers the data patch user interface as a framework component within the UI system, using the specified registration mode.
    /// <code>Offset: 0x004EF0E0
    /// void __cdecl gmDataPatchUI::Register(unsigned int)</code>
    /// </summary>
    /// <param name="mode">The registration mode that determines how the framework is integrated into the UI flow.</param>
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004EF0E0)(mode);
}

