namespace ACBindings;

// ArmorCache
public unsafe struct ArmorCache
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // ArmorCache_vtbl
    public unsafe struct ArmorCache_vtbl
    {
        // Members
        public System.IntPtr ArmorCache_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

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
    // unsigned int __thiscall ArmorCache::Pack(ArmorCache*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArmorCache, void**, uint, uint>)0x005D24B0)(ref this, addr, size);
    // int __thiscall ArmorCache::UnPack(ArmorCache*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArmorCache, void**, uint, int>)0x005D2540)(ref this, addr, size);
}

