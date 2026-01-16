namespace ACBindings.Internal;


/// <summary>Represents an armor component with a base value and resistance modifiers for slash, pierce, bludgeon, cold, fire, acid, electric, and nether damage. Facilitates packing and unpacking of these attributes into binary buffers.</summary>
public unsafe struct ArmorCache
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ArmorCache_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ArmorCache*, void> ArmorCache_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ArmorCache*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ArmorCache*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ArmorCache*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public int _base_armor;
    public int _armor_vs_slash;
    public int _armor_vs_pierce;
    public int _armor_vs_bludgeon;
    public int _armor_vs_cold;
    public int _armor_vs_fire;
    public int _armor_vs_acid;
    public int _armor_vs_electric;
    public int _armor_vs_nether;

    // Methods

    /// <summary>Serializes armor base and resistance values into a byte buffer.
    /// <code>Offset: 0x005D24B0
    /// unsigned int __thiscall ArmorCache::Pack(ArmorCache*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the buffer; updated after each value is written.</param>
    /// <param name="size">Remaining size of the buffer; serialization proceeds only if at least 36 bytes are available.</param>
    /// <returns>Number of bytes written (36).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArmorCache, void**, uint, uint>)0x005D24B0)(ref this, addr, size);

    /// <summary>Unpacks armor attributes from a binary buffer, advancing the pointer and populating the ArmorCache fields.
    /// <code>Offset: 0x005D2540
    /// int __thiscall ArmorCache::UnPack(ArmorCache*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current position in the input stream; will be updated to point after the last read integer.</param>
    /// <param name="size">Number of bytes available at the current address.</param>
    /// <returns>1 if the buffer contained enough data and all fields were successfully extracted; otherwise 0, with the pointer reset to its original location.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArmorCache, void**, uint, int>)0x005D2540)(ref this, addr, size);
}

