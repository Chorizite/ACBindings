namespace ACBindings.Internal;

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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, void> gmDataPatchUI_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, uint, uint, ACBindings.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, ACBindings.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, byte, void> Show; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, byte> Shown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, byte, void> ForceHidden; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, ACBindings.Internal.UIChildFramework*, void> AddChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, ACBindings.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, ACBindings.Internal.UIChildFramework*, int> FindChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, ACBindings.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.gmDataPatchUI*, void> Update; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004EEAC0
    /// UIElementMessageListenResult __thiscall gmDataPatchUI::ListenToElementMessage(gmDataPatchUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    public ACBindings.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindings.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDataPatchUI, ACBindings.Internal.UIElementMessageInfo*, ACBindings.Internal.UIElementMessageListenResult>)0x004EEAC0)(ref this, i_rMsg);

    /// <summary>
    /// <code>Offset: 0x004EEAF0
    /// void __thiscall gmDataPatchUI::SetConnectLevel(gmDataPatchUI*,float)</code>
    /// </summary>
    public void SetConnectLevel(float i_fConnectLevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDataPatchUI, float, void>)0x004EEAF0)(ref this, i_fConnectLevel);

    /// <summary>
    /// <code>Offset: 0x004EEB70
    /// void __thiscall gmDataPatchUI::SetPatchLevel(gmDataPatchUI*,float)</code>
    /// </summary>
    public void SetPatchLevel(float i_fPatchLevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDataPatchUI, float, void>)0x004EEB70)(ref this, i_fPatchLevel);

    /// <summary>
    /// <code>Offset: 0x004EEBA0
    /// void __thiscall gmDataPatchUI::UseTime(gmDataPatchUI*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDataPatchUI, void>)0x004EEBA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EEC80
    /// void __thiscall gmDataPatchUI::OnDDDEvent(gmDataPatchUI*,DDDEvent,unsigned int)</code>
    /// </summary>
    public void OnDDDEvent(ACBindings.Internal.DDDEvent eventNum, uint nBytes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDataPatchUI, ACBindings.Internal.DDDEvent, uint, void>)0x004EEC80)(ref this, eventNum, nBytes);

    /// <summary>
    /// <code>Offset: 0x004EEEA0
    /// void __thiscall gmDataPatchUI::ListenToGlobalMessage(gmDataPatchUI*,unsigned int,int)</code>
    /// </summary>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDataPatchUI, uint, int, void>)0x004EEEA0)(ref this, i_messageID, i_data_int);

    /// <summary>
    /// <code>Offset: 0x004EEEB0
    /// void __thiscall gmDataPatchUI::~gmDataPatchUI(gmDataPatchUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDataPatchUI, void>)0x004EEEB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EEF40
    /// void __thiscall gmDataPatchUI::gmDataPatchUI(gmDataPatchUI*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmDataPatchUI, void>)0x004EEF40)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EF0E0
    /// void __cdecl gmDataPatchUI::Register(unsigned int)</code>
    /// </summary>
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004EF0E0)(mode);
}

