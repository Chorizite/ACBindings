namespace ACBindings.Internal;


/// <summary>Encapsulates a collection of spell tiers, storing them in an ordered list and enabling efficient serialization via PackObj mechanisms.</summary>
public unsafe struct SpellSet
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SpellSet_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellSet*, void> SpellSet_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellSet*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellSet*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellSet*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PList___SpellSetTierList m_countTiers;

    // Generated Constructor
    public SpellSet() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a new SpellSet object by setting its virtual table and preparing an empty list of spell tiers.
    /// <code>Offset: 0x00598F20
    /// void __thiscall SpellSet::SpellSet(SpellSet*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellSet, void>)0x00598F20)(ref this);

    /// <summary>Returns the size of the spell set’s pack by delegating to its underlying PackObj implementation.
    /// <code>Offset: 0x005BE240
    /// unsigned int __thiscall SpellSet::GetPackSize(SpellSet*)</code>
    /// </summary>
    /// <returns>The computed pack size as an unsigned integer.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellSet, uint>)0x005BE240)(ref this);

    /// <summary>Packs the SpellSet into a supplied memory buffer when sufficient space is available.
    /// <code>Offset: 0x005BE260
    /// unsigned int __thiscall SpellSet::Pack(SpellSet*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer where packed data will be written.</param>
    /// <param name="size">Maximum number of bytes that may be written to the buffer.</param>
    /// <returns>The total size, in bytes, required to pack the SpellSet. If the provided size is less than this value, no data is written.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellSet, void**, uint, uint>)0x005BE260)(ref this, addr, size);

    /// <summary>Deserializes a SpellSet from the supplied buffer, filling its tier list when enough data is available.
    /// <code>Offset: 0x005BE290
    /// int __thiscall SpellSet::UnPack(SpellSet*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the packed data buffer.</param>
    /// <param name="size">Size of the buffer in bytes.</param>
    /// <returns>Non‑zero on success; zero if the provided size is insufficient for unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellSet, void**, uint, int>)0x005BE290)(ref this, addr, size);
}

