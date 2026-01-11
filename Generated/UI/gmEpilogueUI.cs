namespace ACBindings.Internal;

public unsafe struct gmEpilogueUI
{
    // Base Classes
    public ACBindings.Internal.gmUIMainFramework BaseClass_gmUIMainFramework; // ACBindings.Internal.gmUIMainFramework
    public ACBindings.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmEpilogueUI_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmEpilogueUI*, void> gmEpilogueUI_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmEpilogueUI*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmEpilogueUI*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmEpilogueUI*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmEpilogueUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmEpilogueUI*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmEpilogueUI*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmEpilogueUI*, byte, void> Show; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmEpilogueUI*, byte> Shown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmEpilogueUI*, byte, void> ForceHidden; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmEpilogueUI*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmEpilogueUI*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmEpilogueUI*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmEpilogueUI*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmEpilogueUI*, void> Update; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement* m_epilogueField;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004EA820
    /// UIMainFramework* __cdecl gmEpilogueUI::Create()</code>
    /// </summary>
    public static ACBindings.Internal.UIMainFramework* Create() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.UIMainFramework*>)0x004EA820)();

    /// <summary>
    /// <code>Offset: 0x004EA8A0
    /// void __cdecl gmEpilogueUI::Register(unsigned int)</code>
    /// </summary>
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004EA8A0)(mode);

    /// <summary>
    /// <code>Offset: 0x004EA8C0
    /// void __thiscall gmEpilogueUI::ListenToGlobalMessage(gmEpilogueUI*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEpilogueUI, uint, int, void>)0x004EA8C0)(ref this, i_messageID, i_data_int);

    /// <summary>
    /// <code>Offset: 0x004EA8D0
    /// UIElementMessageListenResult __thiscall gmEpilogueUI::ListenToElementMessage(gmEpilogueUI*,unsigned int,UIElement*,unsigned int,int)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(uint i_elementID, ACBindings.Internal.UIElement* i_element, uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmEpilogueUI, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult>)0x004EA8D0)(ref this, i_elementID, i_element, i_messageID, i_data_int);
}

