namespace ACBindings;

// SpellSet
public unsafe struct SpellSet
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // SpellSet_vtbl
    public unsafe struct SpellSet_vtbl
    {
        // Members
        public System.IntPtr SpellSet_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PList__SpellSetTierList m_countTiers;

    // Generated Constructor
    public SpellSet() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall SpellSet::SpellSet(SpellSet*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellSet, void>)0x00598F20)(ref this);
    // unsigned int __thiscall SpellSet::GetPackSize(SpellSet*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellSet, uint>)0x005BE240)(ref this);
    // unsigned int __thiscall SpellSet::Pack(SpellSet*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellSet, void**, uint, uint>)0x005BE260)(ref this, addr, size);
    // int __thiscall SpellSet::UnPack(SpellSet*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellSet, void**, uint, int>)0x005BE290)(ref this, addr, size);
}

