namespace ACBindings;

// CChatEvent
public unsafe struct CChatEvent
{
    // Base Classes
    public ACBindings.CCliDatEvent BaseClass_CCliDatEvent; // ACBindings.CCliDatEvent

    // Child Types
    // CChatEvent_vtbl
    public unsafe struct CChatEvent_vtbl
    {
        // Members
        public System.IntPtr CChatEvent_dtor_0; // function pointer

        // Methods
    }
    // CChatEvent::CDataFormat
    public unsafe struct CDataFormat
    {
        // Members
        public uint eventType;
        public uint cbChatData;

        // Methods
    }

    // Methods
    // NetBlob* __cdecl CChatEvent::CreateForSend(const unsigned __int8*,unsigned int)
    public static ACBindings.NetBlob* CreateForSend(byte* pChatData, uint DataLen) => ((delegate* unmanaged[Cdecl]<byte*, uint, ACBindings.NetBlob*>)0x00556F70)(pChatData, DataLen);
}

