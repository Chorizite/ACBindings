namespace ACBindings;

// UIPersistantData
public unsafe struct UIPersistantData : System.IDisposable
{
    // Base Classes
    public ACBindings.NoticeHandler BaseClass_NoticeHandler; // ACBindings.NoticeHandler

    // Child Types
    // UIPersistantData_vtbl
    public unsafe struct UIPersistantData_vtbl
    {
        // Members
        public System.IntPtr IsEngine; // function pointer
        public System.IntPtr RecvNotice_CharacterSet; // function pointer
        public System.IntPtr RecvNotice_PlayerObjDescChanged; // function pointer
        public System.IntPtr RecvNotice_RuntimeDDDStatus; // function pointer
        public System.IntPtr RecvNotice_ItemAttributesChanged; // function pointer
        public System.IntPtr RecvNotice_ServerSaysAttemptFailed; // function pointer
        public System.IntPtr RecvNotice_ServerSaysMoveItem; // function pointer
        public System.IntPtr RecvNotice_SetSelectedItem; // function pointer
        public System.IntPtr RecvNotice_CharacterError; // function pointer
        public System.IntPtr RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public System.IntPtr RecvNotice_BeingDeleted; // function pointer
        public System.IntPtr RecvNotice_CreateObject; // function pointer
        public System.IntPtr RecvNotice_CloseDialog; // function pointer
        public System.IntPtr RecvNotice_DisplayFinalStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public System.IntPtr RecvNotice_OpenDialog; // function pointer
        public System.IntPtr RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public System.IntPtr RecvNotice_TextTag_IIDClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public System.IntPtr RecvNotice_UpdateGameView; // function pointer

        // Methods
    }

    // Members
    public ACBindings.CharacterSet _charSet;
    public byte _receivedSet;
    public uint m_iidSelectedAvatar;

    // Generated Constructor
    public UIPersistantData() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall UIPersistantData::RecvNotice_CharacterSet(UIPersistantData*,const CharacterSet*)
    public void RecvNotice_CharacterSet(ACBindings.CharacterSet* charSet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPersistantData, ACBindings.CharacterSet*, void>)0x00479D00)(ref this, charSet);
    // void __thiscall UIPersistantData::UIPersistantData(UIPersistantData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPersistantData, void>)0x00479E00)(ref this);
    // void __thiscall UIPersistantData::~UIPersistantData(UIPersistantData*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPersistantData, void>)0x00479E40)(ref this);
}

