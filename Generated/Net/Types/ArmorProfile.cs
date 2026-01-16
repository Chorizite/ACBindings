namespace ACBindings.Internal;


/// <summary>Encapsulates damage‑resistance multipliers for armor against various attack types, including slash, pierce, bludgeon, cold, fire, acid, electric, and nether effects.</summary>
public unsafe struct ArmorProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ArmorProfile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ArmorProfile*, void> ArmorProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ArmorProfile*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ArmorProfile*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ArmorProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float mod_vs_slash;
    public float mod_vs_pierce;
    public float mod_vs_bludgeon;
    public float mod_vs_cold;
    public float mod_vs_fire;
    public float mod_vs_acid;
    public float mod_vs_electric;
    public float mod_vs_nether;

    // Methods

    /// <summary>Packs the armor's damage‑modifier values into a contiguous buffer when at least 32 bytes are available.
    /// <code>Offset: 0x005D1DA0
    /// unsigned int __thiscall ArmorProfile::Pack(ArmorProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; advanced past the packed data on success.</param>
    /// <param name="size">Number of bytes remaining in the destination buffer; packing occurs only if this is ≥ 32.</param>
    /// <returns>Always 32, representing the size required for a full pack. If size &lt; 32 no data is written and addr remains unchanged.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArmorProfile, void**, uint, uint>)0x005D1DA0)(ref this, addr, size);

    /// <summary>Deserializes armor resistance modifiers from a byte buffer into an ArmorProfile instance.
    /// <code>Offset: 0x005D1E20
    /// int __thiscall ArmorProfile::UnPack(ArmorProfile*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the input buffer; advanced past the read data.</param>
    /// <param name="size">Size of the remaining data available for unpacking; must be at least 32 bytes.</param>
    /// <returns>1 if enough data was available and unpack succeeded; otherwise 0.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArmorProfile, void**, uint, int>)0x005D1E20)(ref this, addr, size);
}

