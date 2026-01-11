namespace ACBindings.Internal;

public unsafe struct ArmorProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ArmorProfile_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArmorProfile*, void> ArmorProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArmorProfile*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArmorProfile*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArmorProfile*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x005D1DA0
    /// unsigned int __thiscall ArmorProfile::Pack(ArmorProfile*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArmorProfile, void**, uint, uint>)0x005D1DA0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D1E20
    /// int __thiscall ArmorProfile::UnPack(ArmorProfile*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArmorProfile, void**, uint, int>)0x005D1E20)(ref this, addr, size);
}

