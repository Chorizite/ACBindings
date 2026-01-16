namespace ACBindings.Internal;


/// <summary>Subpalette effect containing one or more range definitions and a palette identifier, used to apply selective palette modifications in rendering pipelines.</summary>
public unsafe struct CloSubpalEffect
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CloSubpalEffect_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CloSubpalEffect*, void> CloSubpalEffect_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CloSubpalEffect*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CloSubpalEffect*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CloSubpalEffect*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint numRanges;
    public uint* rangeStart;
    public uint* rangeLength;
    public ACBindings.Internal.IDClass____tagDataID palSet;

    // Generated Constructor
    public CloSubpalEffect() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a new CloSubpalEffect instance with default values.
    /// <code>Offset: 0x005A9590
    /// void __thiscall CloSubpalEffect::CloSubpalEffect(CloSubpalEffect*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloSubpalEffect, void>)0x005A9590)(ref this);

    /// <summary>Packs the CloSubpalEffect instance into a contiguous byte stream, writing the count of ranges followed by each range's start and length values, and then the palette set ID. If the supplied buffer is too small, no data is written but the required size is returned.
    /// <code>Offset: 0x005A9C20
    /// unsigned int __thiscall CloSubpalEffect::Pack(CloSubpalEffect*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a memory address; on entry it points to available space, and on exit it is advanced past the packed data.</param>
    /// <param name="size">Number of bytes remaining in the provided buffer.</param>
    /// <returns>Bytes needed to store the fully packed representation.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloSubpalEffect, void**, uint, uint>)0x005A9C20)(ref this, addr, size);

    /// <summary>Unpacks a CloSubpalEffect from a serialized byte buffer.
    /// <code>Offset: 0x005A9C90
    /// int __thiscall CloSubpalEffect::UnPack(CloSubpalEffect*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position; updated to point after the consumed data upon success.</param>
    /// <param name="size">Number of bytes remaining in the buffer starting at *addr.</param>
    /// <returns>Non-zero if unpacking succeeds within the bounds of size; otherwise zero and restores addr to its original value.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CloSubpalEffect, void**, uint, int>)0x005A9C90)(ref this, addr, size);
}

