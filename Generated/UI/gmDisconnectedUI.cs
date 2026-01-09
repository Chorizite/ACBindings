namespace ACBindings;

// gmDisconnectedUI
public unsafe struct gmDisconnectedUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIMainFramework BaseClass_UIMainFramework; // ACBindings.UIMainFramework
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmDisconnectedUI_vtbl
    public unsafe struct gmDisconnectedUI_vtbl
    {
        // Members
        public System.IntPtr gmDisconnectedUI_dtor_0; // function pointer
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
    public ACBindings.UIElement* m_disconnectedField;
    public ACBindings.UIElement_Text* m_errorText;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall gmDisconnectedUI::~gmDisconnectedUI(gmDisconnectedUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmDisconnectedUI, void>)0x004EA600)(ref this);
    // UIElementMessageListenResult __thiscall gmDisconnectedUI::ListenToElementMessage(gmDisconnectedUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmDisconnectedUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004EA650)(ref this, i_rMsg);
    // void __thiscall gmDisconnectedUI::SetErrorMsg(gmDisconnectedUI*,const StringInfo*)
    public void SetErrorMsg(ACBindings.StringInfo* err) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmDisconnectedUI, ACBindings.StringInfo*, void>)0x004EA680)(ref this, err);
    // void __cdecl gmDisconnectedUI::Register(unsigned int)
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004EA770)(mode);
}

