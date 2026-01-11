namespace ACBindings.Internal;

public unsafe struct ArmorCache
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ArmorCache_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArmorCache*, void> ArmorCache_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArmorCache*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArmorCache*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArmorCache*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x005D24B0
    /// unsigned int __thiscall ArmorCache::Pack(ArmorCache*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArmorCache, void**, uint, uint>)0x005D24B0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D2540
    /// int __thiscall ArmorCache::UnPack(ArmorCache*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArmorCache, void**, uint, int>)0x005D2540)(ref this, addr, size);
}

