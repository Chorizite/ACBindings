namespace ACBindings.Internal;


/// <summary>
/// Manages the user interface presented after a disconnection, providing feedback through a root element and optional error message.
/// Handles relevant UI messages and coordinates transitions to other UI modes.
/// </summary>
public unsafe struct gmDisconnectedUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIMainFramework BaseClass_UIMainFramework; // ACBindings.Internal.UIMainFramework
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmDisconnectedUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, void> gmDisconnectedUI_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, byte, void> Show; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, byte> Shown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, byte, void> ForceHidden; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, void> Update; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement* m_disconnectedField;
    public ACBindings.Internal.UIElement_Text* m_errorText;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys the gmDisconnectedUI instance, unregistering UI messages, removing root elements, clearing error text, and invoking base class destructors.
    /// <code>Offset: 0x004EA600
    /// void __thiscall gmDisconnectedUI::~gmDisconnectedUI(gmDisconnectedUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDisconnectedUI, void>)0x004EA600)(ref this);

    /// <summary>
    /// Responds to UI element messages, queuing a specific UI mode when the disconnect field (ID 268436504) sends message type 1; otherwise forwards the message to the base framework.
    /// 
    /// <code>Offset: 0x004EA650
    /// UIElementMessageListenResult __thiscall gmDisconnectedUI::ListenToElementMessage(gmDisconnectedUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element message, including element ID and message type.</param>
    /// <returns>Result of processing the message as returned by UIFramework::ListenToElementMessage.</returns>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDisconnectedUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004EA650)(ref this, i_rMsg);

    /// <summary>Updates the text element that displays disconnection errors, if present, with information from the supplied StringInfo instance.
    /// <code>Offset: 0x004EA680
    /// void __thiscall gmDisconnectedUI::SetErrorMsg(gmDisconnectedUI*,const StringInfo*)</code>
    /// </summary>
    /// <param name="err">StringInfo containing the error message to display; it is forwarded directly to the underlying UIElement_Text::SetStringInfo call.</param>
    public void SetErrorMsg(ACBindings.Internal.StringInfo* err) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDisconnectedUI, ACBindings.Internal.StringInfo*, void>)0x004EA680)(ref this, err);

    /// <summary>Registers the gmDisconnectedUI framework with UIFlow, enabling it within the user interface system.
    /// <code>Offset: 0x004EA770
    /// void __cdecl gmDisconnectedUI::Register(unsigned int)</code>
    /// </summary>
    /// <param name="mode">The registration mode or flags passed to UIFlow::RegisterFrameworkClass during class registration.</param>
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004EA770)(mode);
}

