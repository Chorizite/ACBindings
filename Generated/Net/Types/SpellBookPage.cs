namespace ACBindings.Internal;


/// <summary>
/// Represents a single entry in a spellbook, holding the adjusted probability of casting success.
/// </summary>
public unsafe struct SpellBookPage
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SpellBookPage_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellBookPage*, void> SpellBookPage_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellBookPage*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellBookPage*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellBookPage*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float _casting_likelihood;

    // Methods

    /// <summary>Packs the adjusted casting likelihood into a buffer as a single float, adding 2.0 to the stored value.
    /// <code>Offset: 0x005CD180
    /// unsigned int __thiscall SpellBookPage::Pack(SpellBookPage*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; receives the packed float and is advanced by four bytes when written.</param>
    /// <param name="size">Number of bytes remaining in the buffer; packing occurs only if this is at least 4.</param>
    /// <returns>Always returns 4, indicating the byte count that would be used for the packed data.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellBookPage, void**, uint, uint>)0x005CD180)(ref this, addr, size);

    /// <summary>Unpacks a SpellBookPage from serialized data, setting the casting likelihood and advancing the read pointer.
    /// <code>Offset: 0x005CD1B0
    /// int __thiscall SpellBookPage::UnPack(SpellBookPage*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current position in the input buffer; advanced past consumed bytes.</param>
    /// <param name="size">Number of remaining bytes available for unpacking.</param>
    /// <returns>1 if unpack succeeds; 0 when insufficient data is provided.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellBookPage, void**, uint, int>)0x005CD1B0)(ref this, addr, size);
}

