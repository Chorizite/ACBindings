namespace ACBindings.Internal;

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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, void> gmIntroUI_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, byte, void> Show; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, byte> Shown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, byte, void> ForceHidden; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmIntroUI*, void> Update; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004EE680
    /// void __thiscall gmIntroUI::NextFrame(gmIntroUI*)</code>
    /// </summary>
    public void NextFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmIntroUI, void>)0x004EE680)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EE6E0
    /// UIElementMessageListenResult __thiscall gmIntroUI::ListenToElementMessage(gmIntroUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmIntroUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004EE6E0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004EE730
    /// void __thiscall gmIntroUI::CharacterHandler(gmIntroUI*,wchar_t)</code>
    /// </summary>
    public void CharacterHandler(System.Char Char) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmIntroUI, System.Char, void>)0x004EE730)(ref this, Char);

    /// <summary>
    /// <code>Offset: 0x004EE760
    /// bool __thiscall gmIntroUI::OnAction(gmIntroUI*,const InputEvent*)</code>
    /// </summary>
    public byte OnAction(ACBindings.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmIntroUI, ACBindings.Internal.InputEvent*, byte>)0x004EE760)(ref this, i_evt);

    /// <summary>
    /// <code>Offset: 0x004EE790
    /// void __thiscall gmIntroUI::gmIntroUI(gmIntroUI*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmIntroUI, void>)0x004EE790)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EE9D0
    /// void __thiscall gmIntroUI::~gmIntroUI(gmIntroUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmIntroUI, void>)0x004EE9D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EEA60
    /// UIMainFramework* __cdecl gmIntroUI::Create()</code>
    /// </summary>
    public static ACBindings.Internal.UIMainFramework* Create() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIMainFramework*>)0x004EEA60)();

    /// <summary>
    /// <code>Offset: 0x004EEAA0
    /// void __cdecl gmIntroUI::Register(unsigned int)</code>
    /// </summary>
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004EEAA0)(mode);
}

