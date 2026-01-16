namespace ACBindings.Internal;


/// <summary>Encapsulates a PackObj instance within an aligned container, facilitating organized packing operations in the system.</summary>
public unsafe struct StreamPackObj
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct StreamPackObj_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StreamPackObj*, void> StreamPackObj_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StreamPackObj*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StreamPackObj*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StreamPackObj*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.StreamPackObj*, ACBindings.Internal.STREAMTYPE, void**, uint*, int> StreamPack; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Packs the StreamPackObj into a provided buffer; if no buffer is supplied, returns the required packed size.
    /// <code>Offset: 0x00541340
    /// unsigned int __thiscall StreamPackObj::Pack(StreamPackObj*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a buffer where packed data will be written. If null, the method only calculates and returns the total packed size.</param>
    /// <param name="size">On input, the size of the available buffer. On output, the remaining unused space after packing.</param>
    /// <returns>The number of bytes written into the buffer, or the total packed size when no buffer is provided.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StreamPackObj, void**, uint, uint>)0x00541340)(ref this, addr, size);

    /// <summary>Unpacks data via the base PackObj implementation and returns a status code.
    /// <code>Offset: 0x00541380
    /// int __thiscall StreamPackObj::UnPack(StreamPackObj*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a void* that will receive the address of the unpacked data.</param>
    /// <param name="size">Unsigned int specifying the maximum buffer size; may be updated with the actual amount of data unpacked by the base method.</param>
    /// <returns>Integer status code returned by the underlying PackObj unpack operation.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StreamPackObj, void**, uint, int>)0x00541380)(ref this, addr, size);
}

