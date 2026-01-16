namespace ACBindings.Internal;


/// <summary>Stores persistent UI data such as selected avatar and character set information, handles notice reception, and registers with a global event system for UI updates.</summary>
public unsafe struct UIPersistantData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.NoticeHandler BaseClass_NoticeHandler; // ACBindings.Internal.NoticeHandler

    // Child Types
    public unsafe struct UIPersistantData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, byte> IsEngine; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, ACBindings.Internal.CharacterSet*, void> RecvNotice_CharacterSet; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, void> RecvNotice_PlayerObjDescChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, byte, uint, uint, void> RecvNotice_RuntimeDDDStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, uint, void> RecvNotice_ItemAttributesChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, void> RecvNotice_ServerSaysAttemptFailed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, uint, uint, uint, uint, int, uint, uint, void> RecvNotice_ServerSaysMoveItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, uint, void> RecvNotice_SetSelectedItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, ACBindings.Internal.charError, void> RecvNotice_CharacterError; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, void> RecvNotice_ServerDied; // function pointer
        public System.IntPtr RecvNotice_WorldName;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, ACBindings.Internal.CWeenieObject*, void> RecvNotice_BeingDeleted; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, void> RecvNotice_CreateObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, ACBindings.Internal.PropertyCollection*, void> RecvNotice_CloseDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, ACBindings.Internal.StringInfo*, ACBindings.Internal.StringInfo*, uint, void> RecvNotice_DisplayFinalStringInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, ACBindings.Internal.StringInfo*, void> RecvNotice_DisplayStringInfo; // function pointer
        public System.IntPtr RecvNotice_DisplayWeenieError;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, void> RecvNotice_OpenDialog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, void> RecvNotice_SmartBoxObjectFound; // function pointer
        public System.IntPtr RecvNotice_TextTag_DIDClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, uint, void> RecvNotice_TextTag_IIDClick; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, uint, uint, void> RecvNotice_TextTag_IIDEnumClick; // function pointer
        public System.IntPtr RecvNotice_TextTag_IIDStringClick;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPersistantData*, uint, uint, uint, uint, void> RecvNotice_UpdateGameView; // function pointer

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

    /// <summary>Receives a character set notice, stores it internally and marks the set as received, then signals UI flow to refresh.
    /// <code>Offset: 0x00479D00
    /// void __thiscall UIPersistantData::RecvNotice_CharacterSet(UIPersistantData*,const CharacterSet*)</code>
    /// </summary>
    /// <param name="charSet">The character set information sent in the notice.</param>
    public void RecvNotice_CharacterSet(ACBindings.Internal.CharacterSet* charSet) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPersistantData, ACBindings.Internal.CharacterSet*, void>)0x00479D00)(ref this, charSet);

    /// <summary>Initializes a UIPersistantData instance by setting up its base NoticeHandler interface, initializing character set and state flags, and registering the object with the global event handler for notice processing.
    /// <code>Offset: 0x00479E00
    /// void __thiscall UIPersistantData::UIPersistantData(UIPersistantData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPersistantData, void>)0x00479E00)(ref this);

    /// <summary>Destroys a UIPersistantData instance, unregistering its notice handlers and cleaning up contained resources such as the character set.
    /// <code>Offset: 0x00479E40
    /// void __thiscall UIPersistantData::~UIPersistantData(UIPersistantData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPersistantData, void>)0x00479E40)(ref this);
}

