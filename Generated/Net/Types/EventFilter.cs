namespace ACBindings.Internal;


/// <summary>Represents a list of event identifiers that can be serialized and deserialized through binary packing operations.</summary>
/// <remarks>Includes a PackObj member providing alignment and size calculations, and manages a dynamic array of event ID values.</remarks>
public unsafe struct EventFilter
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct EventFilter_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EventFilter*, void> EventFilter_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EventFilter*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EventFilter*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EventFilter*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint num_events;
    public uint* event_filter;

    // Methods

    /// <summary>Serializes the EventFilter's data into a contiguous byte buffer, writing the event count followed by each event identifier and advancing the supplied pointer.
    /// <code>Offset: 0x006B2C60
    /// unsigned int __thiscall EventFilter::Pack(EventFilter*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; on return points to the next free location after serialized data.</param>
    /// <param name="size">Size in bytes of the available buffer region. If insufficient, data is not written but required size is still returned.</param>
    /// <returns>Number of bytes needed to store the packed event filter (4 * num_events + 4).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EventFilter, void**, uint, uint>)0x006B2C60)(ref this, addr, size);

    /// <summary>Unpacks an event filter from a binary stream, resizing and filling its internal array with the encoded event identifiers.
    /// <code>Offset: 0x006B2CB0
    /// int __thiscall EventFilter::UnPack(EventFilter*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current read position in the input buffer; updated as bytes are consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer; must be sufficient for the data to be unpacked.</param>
    /// <returns>Non‑zero if the filter was successfully reconstructed; zero if the provided buffer is too small.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EventFilter, void**, uint, int>)0x006B2CB0)(ref this, addr, size);
}

