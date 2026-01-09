namespace ACBindings;

// SpellSetTierList
public unsafe struct SpellSetTierList
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // SpellSetTierList_vtbl
    public unsafe struct SpellSetTierList_vtbl
    {
        // Members
        public System.IntPtr SpellSetTierList_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_PieceCount;
    public ACBindings.PList__uint m_SpellList;

    // Generated Constructor
    public SpellSetTierList(ACBindings.SpellSetTierList* from) {
        _ConstructorInternal(from);
    }

    // Methods
    // unsigned int __thiscall SpellSetTierList::GetPackSize(SpellSetTierList*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellSetTierList, uint>)0x005BE1A0)(ref this);
    // unsigned int __thiscall SpellSetTierList::Pack(SpellSetTierList*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellSetTierList, void**, uint, uint>)0x005BE1C0)(ref this, addr, size);
    // int __thiscall SpellSetTierList::UnPack(SpellSetTierList*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellSetTierList, void**, uint, int>)0x005BE200)(ref this, addr, size);
    // void __thiscall SpellSetTierList::SpellSetTierList(SpellSetTierList*,const SpellSetTierList*)
    public void _ConstructorInternal(ACBindings.SpellSetTierList* from) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellSetTierList, ACBindings.SpellSetTierList*, void>)0x005BE2C0)(ref this, from);
}

