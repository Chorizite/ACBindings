namespace ACBindings.Internal;

public unsafe struct gmDisconnectedUI : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIMainFramework BaseClass_UIMainFramework; // ACBindings.Internal.UIMainFramework
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmDisconnectedUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, void> gmDisconnectedUI_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, byte, void> Show; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, byte> Shown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, byte, void> ForceHidden; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDisconnectedUI*, void> Update; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004EA600
    /// void __thiscall gmDisconnectedUI::~gmDisconnectedUI(gmDisconnectedUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDisconnectedUI, void>)0x004EA600)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EA650
    /// UIElementMessageListenResult __thiscall gmDisconnectedUI::ListenToElementMessage(gmDisconnectedUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDisconnectedUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004EA650)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004EA680
    /// void __thiscall gmDisconnectedUI::SetErrorMsg(gmDisconnectedUI*,const StringInfo*)</code>
    /// </summary>
    public void SetErrorMsg(ACBindings.Internal.StringInfo* err) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDisconnectedUI, ACBindings.Internal.StringInfo*, void>)0x004EA680)(ref this, err);

    /// <summary>
    /// <code>Offset: 0x004EA770
    /// void __cdecl gmDisconnectedUI::Register(unsigned int)</code>
    /// </summary>
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004EA770)(mode);
}

