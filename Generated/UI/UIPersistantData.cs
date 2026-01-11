namespace ACBindings.Internal;

public unsafe struct UIPersistantData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.NoticeHandler BaseClass_NoticeHandler; // ACBindings.Internal.NoticeHandler

    // Child Types
    public unsafe struct UIPersistantData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, byte> IsEngine; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, void> RecvNotice_CreateObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, void> RecvNotice_OpenDialog; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.CharacterSet _charSet;
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

    /// <summary>
    /// <code>Offset: 0x00479D00
    /// void __thiscall UIPersistantData::RecvNotice_CharacterSet(UIPersistantData*,const CharacterSet*)</code>
    /// </summary>
    public void RecvNotice_CharacterSet(ACBindings.Internal.CharacterSet* charSet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPersistantData, ACBindings.Internal.CharacterSet*, void>)0x00479D00)(ref this, charSet);

    /// <summary>
    /// <code>Offset: 0x00479E00
    /// void __thiscall UIPersistantData::UIPersistantData(UIPersistantData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPersistantData, void>)0x00479E00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00479E40
    /// void __thiscall UIPersistantData::~UIPersistantData(UIPersistantData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPersistantData, void>)0x00479E40)(ref this);
}

