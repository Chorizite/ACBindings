namespace ACBindings.Internal;


/// <summary>Encapsulates chat message data as a reference‑counted network event, enabling queuing, sending, and receiving over the client–server channel.</summary>
public unsafe struct CChatEvent
{
    // Base Classes
    public ACBindings.Internal.CCliDatEvent BaseClass_CCliDatEvent; // ACBindings.Internal.CCliDatEvent

    // Child Types
    public unsafe struct CChatEvent_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CChatEvent*, void> CChatEvent_dtor_0; // function pointer

        // Methods
    }

    /// <summary>Specifies the format of a chat event by providing an event type identifier and the size of its accompanying data.</summary>
    public unsafe struct CDataFormat
    {
        // Members
        public uint eventType;
        public uint cbChatData;

        // Methods
    }

    // Methods

    /// <summary>Creates a network blob encapsulating chat data for transmission, initializing the event with appropriate headers and queue settings.
    /// <code>Offset: 0x00556F70
    /// NetBlob* __cdecl CChatEvent::CreateForSend(const unsigned __int8*,unsigned int)</code>
    /// </summary>
    /// <param name="pChatData">Pointer to raw chat message bytes.</param>
    /// <param name="DataLen">Length of the chat data in bytes.</param>
    /// <returns>Pointer to the constructed NetBlob object on success; null if memory allocation fails.</returns>
    public static ACBindings.Internal.NetBlob* CreateForSend(byte* pChatData, uint DataLen) => ((delegate* unmanaged[Cdecl]<byte*, uint, ACBindings.Internal.NetBlob*>)0x00556F70)(pChatData, DataLen);
}

