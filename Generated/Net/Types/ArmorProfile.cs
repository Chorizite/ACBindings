namespace ACBindings;

// ArmorProfile
public unsafe struct ArmorProfile
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // ArmorProfile_vtbl
    public unsafe struct ArmorProfile_vtbl
    {
        // Members
        public System.IntPtr ArmorProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

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
    // unsigned int __thiscall ArmorProfile::Pack(ArmorProfile*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArmorProfile, void**, uint, uint>)0x005D1DA0)(ref this, addr, size);
    // int __thiscall ArmorProfile::UnPack(ArmorProfile*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArmorProfile, void**, uint, int>)0x005D1E20)(ref this, addr, size);
}

