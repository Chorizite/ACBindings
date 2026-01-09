namespace ACBindings;

// gmDataPatchUI
public unsafe struct gmDataPatchUI : System.IDisposable
{
    // Base Classes
    public ACBindings.UIMainFramework BaseClass_UIMainFramework; // ACBindings.UIMainFramework
    public ACBindings.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindings.gmNoticeHandler
    public ACBindings.CDDDStatusPlugin BaseClass_CDDDStatusPlugin; // ACBindings.CDDDStatusPlugin

    // Child Types
    // gmDataPatchUI_vtbl
    public unsafe struct gmDataPatchUI_vtbl
    {
        // Members
        public System.IntPtr gmDataPatchUI_dtor_0; // function pointer
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
    public ACBindings.UIElement* m_datapatchField;
    public ACBindings.UIElement_Text* m_connectText;
    public ACBindings.UIElement* m_connectMeter;
    public ACBindings.UIElement_Text* m_patchText;
    public ACBindings.UIElement* m_patchMeter;
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
    // UIElementMessageListenResult __thiscall gmDataPatchUI::ListenToElementMessage(gmDataPatchUI*,const UIElementMessageInfo*)
    public ACBindings.UIElementMessageListenResult ListenToElementMessage(ACBindings.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmDataPatchUI, ACBindings.UIElementMessageInfo*, ACBindings.UIElementMessageListenResult>)0x004EEAC0)(ref this, i_rMsg);
    // void __thiscall gmDataPatchUI::SetConnectLevel(gmDataPatchUI*,float)
    public void SetConnectLevel(float i_fConnectLevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmDataPatchUI, float, void>)0x004EEAF0)(ref this, i_fConnectLevel);
    // void __thiscall gmDataPatchUI::SetPatchLevel(gmDataPatchUI*,float)
    public void SetPatchLevel(float i_fPatchLevel) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmDataPatchUI, float, void>)0x004EEB70)(ref this, i_fPatchLevel);
    // void __thiscall gmDataPatchUI::UseTime(gmDataPatchUI*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmDataPatchUI, void>)0x004EEBA0)(ref this);
    // void __thiscall gmDataPatchUI::OnDDDEvent(gmDataPatchUI*,DDDEvent,unsigned int)
    public void OnDDDEvent(ACBindings.DDDEvent eventNum, uint nBytes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmDataPatchUI, ACBindings.DDDEvent, uint, void>)0x004EEC80)(ref this, eventNum, nBytes);
    // void __thiscall gmDataPatchUI::ListenToGlobalMessage(gmDataPatchUI*,unsigned int,int)
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmDataPatchUI, uint, int, void>)0x004EEEA0)(ref this, i_messageID, i_data_int);
    // void __thiscall gmDataPatchUI::~gmDataPatchUI(gmDataPatchUI*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmDataPatchUI, void>)0x004EEEB0)(ref this);
    // void __thiscall gmDataPatchUI::gmDataPatchUI(gmDataPatchUI*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmDataPatchUI, void>)0x004EEF40)(ref this);
    // void __cdecl gmDataPatchUI::Register(unsigned int)
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004EF0E0)(mode);
}

