namespace ACBindings.Internal;


/// <summary>Header information for an order packet, storing shared attributes via PackObj and a unique timestamp.</summary>
public unsafe struct OrderHdr
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct OrderHdr_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OrderHdr*, void> OrderHdr_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OrderHdr*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OrderHdr*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OrderHdr*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint stamp_;

    // Methods

    /// <summary>Packs the order header into a binary format at the given buffer address and returns the number of bytes written.
    /// <code>Offset: 0x006B4010
    /// unsigned int __thiscall OrderHdr::Pack(OrderHdr*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to a pointer that points to the destination buffer; updated to point after the written data.</param>
    /// <param name="size">Size in bytes of the destination buffer; must be at least 8 for successful packing.</param>
    /// <returns>The number of bytes written (always 8).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OrderHdr, void**, uint, uint>)0x006B4010)(ref this, addr, size);

    /// <summary>Unpacks an OrderHdr instance from a binary buffer, validating a magic marker and extracting the stamp_ field.
    /// <code>Offset: 0x006B4040
    /// int __thiscall OrderHdr::UnPack(OrderHdr*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the buffer; updated to point after the read data.</param>
    /// <param name="size">Number of bytes remaining in the buffer at the time of the call.</param>
    /// <returns>Returns 1 if a valid header was found and stamp_ extracted; otherwise returns 0, leaving addr unchanged.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OrderHdr, void**, uint, int>)0x006B4040)(ref this, addr, size);
}

