namespace ACBindings.Internal;


/// <summary>Represents a collection of spell identifiers grouped by tier, storing the number of pieces available and the ordered list of spells for that tier. Facilitates serialization, deserialization, and copying of tiered spell data within the game's spell management system.</summary>
public unsafe struct SpellSetTierList
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SpellSetTierList_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellSetTierList*, void> SpellSetTierList_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellSetTierList*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellSetTierList*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellSetTierList*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_PieceCount;
    public ACBindings.Internal.PList__uint m_SpellList;

    // Generated Constructor
    public SpellSetTierList(ACBindings.Internal.SpellSetTierList* from) {
        _ConstructorInternal(from);
    }

    // Methods

    /// <summary>Retrieves the size, in bytes, of the pack containing the spell list.
    /// <code>Offset: 0x005BE1A0
    /// unsigned int __thiscall SpellSetTierList::GetPackSize(SpellSetTierList*)</code>
    /// </summary>
    /// <returns>The number of bytes required to store the packed spell list.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellSetTierList, uint>)0x005BE1A0)(ref this);

    /// <summary>Serializes SpellSetTierList into a buffer when enough space exists.
    /// <code>Offset: 0x005BE1C0
    /// unsigned int __thiscall SpellSetTierList::Pack(SpellSetTierList*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer where packed data will be written; advances past the written bytes.</param>
    /// <param name="size">Number of bytes available at *addr. If size is less than the required amount, nothing is written.</param>
    /// <returns>Size in bytes necessary to serialize the object (piece count plus spell list). This value does not depend on whether the buffer was large enough.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellSetTierList, void**, uint, uint>)0x005BE1C0)(ref this, addr, size);

    /// <summary>Deserializes a SpellSetTierList by reading the piece count and unpacking its spell list from binary data.
    /// <code>Offset: 0x005BE200
    /// int __thiscall SpellSetTierList::UnPack(SpellSetTierList*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position within the buffer; advanced past the fields that are unpacked.</param>
    /// <param name="size">Number of bytes remaining in the input buffer.</param>
    /// <returns>1 if enough data is available and unpacking succeeds; 0 when the buffer does not contain sufficient bytes.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellSetTierList, void**, uint, int>)0x005BE200)(ref this, addr, size);

    /// <summary>Initializes the current SpellSetTierList by duplicating the piece count and spell list of a source instance.
    /// <code>Offset: 0x005BE2C0
    /// void __thiscall SpellSetTierList::SpellSetTierList(SpellSetTierList*,const SpellSetTierList*)</code>
    /// </summary>
    /// <param name="from">The SpellSetTierList to copy data from.</param>
    public void _ConstructorInternal(ACBindings.Internal.SpellSetTierList* from) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellSetTierList, ACBindings.Internal.SpellSetTierList*, void>)0x005BE2C0)(ref this, from);
}

