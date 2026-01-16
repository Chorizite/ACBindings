namespace ACBindings.Internal;


/// <summary>Encapsulates the header information for an order, containing a unique identifier and timestamp, along with a flag indicating whether the data originates from a Weenie object.</summary>
public unsafe struct WOrderHdr
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct WOrderHdr_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WOrderHdr*, void> WOrderHdr_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WOrderHdr*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WOrderHdr*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.WOrderHdr*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public int isFromWeenie_;
    public uint iid_;
    public uint stamp_;

    // Methods

    /// <summary>Serializes the order header into a binary buffer, writing a marker followed by the identifier and timestamp.
    /// <code>Offset: 0x006B1970
    /// unsigned int __thiscall WOrderHdr::Pack(WOrderHdr*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; updated to point after the packed data.</param>
    /// <param name="size">Size of available space in the buffer; must be at least 12 bytes for packing to succeed.</param>
    /// <returns>Number of bytes written (always 12).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WOrderHdr, void**, uint, uint>)0x006B1970)(ref this, addr, size);

    /// <summary>Unpacks a WOrderHdr from a serialized data stream.
    /// <code>Offset: 0x006B19B0
    /// int __thiscall WOrderHdr::UnPack(WOrderHdr*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the input buffer; upon return it points past the consumed bytes.</param>
    /// <param name="size">Length of the remaining buffer (unused by this implementation).</param>
    /// <returns>1 if the header was successfully parsed and contains a recognized type code; 0 otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WOrderHdr, void**, uint, int>)0x006B19B0)(ref this, addr, size);
}

