namespace ACBindings.Internal;


/// <summary>Introduces the introductory UI flow, managing root element creation, input handling, and state progression for the game’s opening sequence.</summary>
public unsafe struct gmIntroUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIMainFramework BaseClass_UIMainFramework; // ACBindings.Internal.UIMainFramework
    public ACBindings.Internal.CInputHandler BaseClass_CInputHandler; // ACBindings.Internal.CInputHandler
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmIntroUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, void> gmIntroUI_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, byte, void> Show; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, byte> Shown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, byte, void> ForceHidden; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, void> Update; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement* m_introField;
    public ACBindings.Internal.List__uint m_listStates;

    // Generated Constructor
    public gmIntroUI() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Advances the intro UI to its next state by dequeuing a pending frame from m_listStates and notifying the intro field; if no frames remain, queues a final UI mode transition.
    /// <code>Offset: 0x004EE680
    /// void __thiscall gmIntroUI::NextFrame(gmIntroUI*)</code>
    /// </summary>
    public void NextFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmIntroUI, void>)0x004EE680)(ref this);

    /// <summary>Handles special UI element messages for gmIntroUI, advancing to the next frame or queuing a UI mode before delegating to the framework's handler.
    /// <code>Offset: 0x004EE6E0
    /// UIElementMessageListenResult __thiscall gmIntroUI::ListenToElementMessage(gmIntroUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the received UI element message.</param>
    /// <returns>Result of processing the message by the underlying UI framework.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmIntroUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004EE6E0)(ref this, i_rMsg);

    /// <summary>Processes a character input in the intro interface, triggering an escape‑key transition when the Escape key (code 27) is detected and scheduling the next frame update.
    /// <code>Offset: 0x004EE730
    /// void __thiscall gmIntroUI::CharacterHandler(gmIntroUI*,wchar_t)</code>
    /// </summary>
    /// <param name="Char">Unicode code point of the pressed key.</param>
    public void CharacterHandler(System.Char Char) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmIntroUI, System.Char, void>)0x004EE730)(ref this, Char);

    /// <summary>Responds to start actions during the intro UI, queuing a specific UI mode when action 39 occurs or advancing to the next frame otherwise.
    /// <code>Offset: 0x004EE760
    /// bool __thiscall gmIntroUI::OnAction(gmIntroUI*,const InputEvent*)</code>
    /// </summary>
    /// <param name="this">The gmIntroUI instance handling the input event.</param>
    /// <param name="i_evt">The input event being processed.</param>
    /// <returns>True if the event was handled; false if it is not a start event.</returns>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmIntroUI, ACBindings.Internal.InputEvent*, byte>)0x004EE760)(ref this, i_evt);

    /// <summary>Initializes the introductory user interface by creating the root element, setting up input and notice handling, preparing a state list, and scheduling initial actions with the IDM system.
    /// <code>Offset: 0x004EE790
    /// void __thiscall gmIntroUI::gmIntroUI(gmIntroUI*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmIntroUI, void>)0x004EE790)(ref this);

    /// <summary>Destroys an instance of gmIntroUI, removing its root UI element, deregistering input handling, clearing internal state lists, and delegating to base class destructors.
    /// <code>Offset: 0x004EE9D0
    /// void __thiscall gmIntroUI::~gmIntroUI(gmIntroUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmIntroUI, void>)0x004EE9D0)(ref this);

    /// <summary>Creates a new introductory UI framework instance, allocating memory and initializing the object.
    /// <code>Offset: 0x004EEA60
    /// UIMainFramework* __cdecl gmIntroUI::Create()</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed UIMainFramework, or null if allocation fails.</returns>
    public static ACBindings.Internal.UIMainFramework* Create() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIMainFramework*>)0x004EEA60)();

    /// <summary>Registers the Intro UI framework with the UI flow system using the given mode.
    /// <code>Offset: 0x004EEAA0
    /// void __cdecl gmIntroUI::Register(unsigned int)</code>
    /// </summary>
    /// <param name="mode">Specifies the registration mode or type for this UI framework within UIFlow.</param>
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004EEAA0)(mode);
}

