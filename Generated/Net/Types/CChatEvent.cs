namespace ACBindings.Internal;

public unsafe struct CChatEvent
{
    // Base Classes
    public ACBindings.Internal.CCliDatEvent BaseClass_CCliDatEvent; // ACBindings.Internal.CCliDatEvent

    // Child Types
    public unsafe struct CChatEvent_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CChatEvent*, void> CChatEvent_dtor_0; // function pointer

        // Methods
    }
    public unsafe struct CDataFormat
    {
        // Members
        public uint eventType;
        public uint cbChatData;

        // Methods
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00556F70
    /// NetBlob* __cdecl CChatEvent::CreateForSend(const unsigned __int8*,unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.NetBlob* CreateForSend(byte* pChatData, uint DataLen) => ((delegate* unmanaged[Cdecl]<byte*, uint, ACBindings.Internal.NetBlob*>)0x00556F70)(pChatData, DataLen);
}

