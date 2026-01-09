namespace ACBindings;

// gmIntroUI
public unsafe struct gmIntroUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIMainFramework BaseClass_UIMainFramework; // ACBindings.UIMainFramework
    public ACBindings.CInputHandler BaseClass_CInputHandler; // ACBindings.CInputHandler
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmIntroUI_vtbl
    public unsafe struct gmIntroUI_vtbl
    {
        // Members
        public System.IntPtr gmIntroUI_dtor_0; // function pointer
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
    public ACBindings.UIElement* m_introField;
    public ACBindings.List__uint m_listStates;

    // Generated Constructor
    public gmIntroUI() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmIntroUI::NextFrame(gmIntroUI*)
    public void NextFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmIntroUI, void>)0x004EE680)(ref this);
    // UIElementMessageListenResult __thiscall gmIntroUI::ListenToElementMessage(gmIntroUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmIntroUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004EE6E0)(ref this, i_rMsg);
    // void __thiscall gmIntroUI::CharacterHandler(gmIntroUI*,wchar_t)
    public void CharacterHandler(System.Char Char) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmIntroUI, System.Char, void>)0x004EE730)(ref this, Char);
    // bool __thiscall gmIntroUI::OnAction(gmIntroUI*,const InputEvent*)
    public byte OnAction(ACBindings.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmIntroUI, ACBindings.InputEvent*, byte>)0x004EE760)(ref this, i_evt);
    // void __thiscall gmIntroUI::gmIntroUI(gmIntroUI*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmIntroUI, void>)0x004EE790)(ref this);
    // void __thiscall gmIntroUI::~gmIntroUI(gmIntroUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmIntroUI, void>)0x004EE9D0)(ref this);
    // UIMainFramework* __cdecl gmIntroUI::Create()
    public static ACBindings.UIMainFramework* Create() => ((delegate* unmanaged[Cdecl]<ACBindings.UIMainFramework*>)0x004EEA60)();
    // void __cdecl gmIntroUI::Register(unsigned int)
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004EEAA0)(mode);
}

