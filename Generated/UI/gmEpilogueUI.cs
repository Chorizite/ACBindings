namespace ACBindings;

// gmEpilogueUI
public unsafe struct gmEpilogueUI
{
    // Base Classes
    public ACBindings.gmUIMainFramework BaseClass_gmUIMainFramework; // ACBindings.gmUIMainFramework
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler

    // Child Types
    // gmEpilogueUI_vtbl
    public unsafe struct gmEpilogueUI_vtbl
    {
        // Members
        public System.IntPtr gmEpilogueUI_dtor_0; // function pointer
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
    public ACBindings.UIElement* m_epilogueField;

    // Methods
    // UIMainFramework* __cdecl gmEpilogueUI::Create()
    public static ACBindings.UIMainFramework* Create() => ((delegate* unmanaged[Cdecl]<ACBindings.UIMainFramework*>)0x004EA820)();
    // void __cdecl gmEpilogueUI::Register(unsigned int)
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004EA8A0)(mode);
    // void __thiscall gmEpilogueUI::ListenToGlobalMessage(gmEpilogueUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEpilogueUI, uint, int, void>)0x004EA8C0)(ref this, i_messageID, i_data_int);
    // UIElementMessageListenResult __thiscall gmEpilogueUI::ListenToElementMessage(gmEpilogueUI*,unsigned int,UIElement*,unsigned int,int)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(uint i_elementID, ACBindings.UIElement* i_element, uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmEpilogueUI, uint, ACBindings.UIElement*, uint, int, ACBindings.UIElementMessageListenResult>)0x004EA8D0)(ref this, i_elementID, i_element, i_messageID, i_data_int);
}

