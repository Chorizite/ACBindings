namespace ACBindings.Internal;

public unsafe struct SpellSet
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SpellSet_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellSet*, void> SpellSet_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellSet*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellSet*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellSet*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PList___SpellSetTierList m_countTiers;

    // Generated Constructor
    public SpellSet() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00598F20
    /// void __thiscall SpellSet::SpellSet(SpellSet*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellSet, void>)0x00598F20)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BE240
    /// unsigned int __thiscall SpellSet::GetPackSize(SpellSet*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellSet, uint>)0x005BE240)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BE260
    /// unsigned int __thiscall SpellSet::Pack(SpellSet*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellSet, void**, uint, uint>)0x005BE260)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BE290
    /// int __thiscall SpellSet::UnPack(SpellSet*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellSet, void**, uint, int>)0x005BE290)(ref this, addr, size);
}

