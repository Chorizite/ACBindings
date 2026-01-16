namespace ACBindings.Internal;


/// <summary>Represents client event data encapsulated within a NetBlob, enabling network transmission of event payloads.</summary>
/// <remarks>Initializes the embedded NetBlob from raw data and assigns CChatEvent virtual tables for reference counting, packing, and hashing operations.</remarks>
public unsafe struct CCliDatEvent
{
    // Base Classes
    public ACBindings.Internal.NetBlob BaseClass_NetBlob; // ACBindings.Internal.NetBlob

    // Child Types
    public unsafe struct CCliDatEvent_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CCliDatEvent*, void> CCliDatEvent_dtor_0; // function pointer

        // Methods
    }

    /// <summary>Represents the format of a command‑line data event, encapsulating an unsigned integer that identifies the event type.</summary>
    public unsafe struct CDataFormat
    {
        // Members
        public uint eventType;

        // Methods
    }

    // Generated Constructor
    public CCliDatEvent(byte* pData, int DataLen) {
        _ConstructorInternal(pData, DataLen);
    }

    // Methods

    /// <summary>Initializes a CCliDatEvent by creating an internal NetBlob from the supplied data and configuring its reference count, packing object, and hash structures to use CChatEvent vtables.
    /// <code>Offset: 0x005A82F0
    /// void __thiscall CCliDatEvent::CCliDatEvent(CCliDatEvent*,unsigned __int8*,int)</code>
    /// </summary>
    /// <param name="pData">Pointer to the raw data used to populate the event.</param>
    /// <param name="DataLen">Length of the data buffer in bytes.</param>
    public void _ConstructorInternal(byte* pData, int DataLen) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCliDatEvent, byte*, int, void>)0x005A82F0)(ref this, pData, DataLen);
}

