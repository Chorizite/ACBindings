namespace ACBindings.Internal;

public unsafe struct SpellSetTierList
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SpellSetTierList_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellSetTierList*, void> SpellSetTierList_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellSetTierList*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellSetTierList*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellSetTierList*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_PieceCount;
    public ACBindings.Internal.PList__uint m_SpellList;

    // Generated Constructor
    public SpellSetTierList(ACBindings.Internal.SpellSetTierList* from) {
        _ConstructorInternal(from);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005BE1A0
    /// unsigned int __thiscall SpellSetTierList::GetPackSize(SpellSetTierList*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellSetTierList, uint>)0x005BE1A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BE1C0
    /// unsigned int __thiscall SpellSetTierList::Pack(SpellSetTierList*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellSetTierList, void**, uint, uint>)0x005BE1C0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BE200
    /// int __thiscall SpellSetTierList::UnPack(SpellSetTierList*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellSetTierList, void**, uint, int>)0x005BE200)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BE2C0
    /// void __thiscall SpellSetTierList::SpellSetTierList(SpellSetTierList*,const SpellSetTierList*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.SpellSetTierList* from) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellSetTierList, ACBindings.Internal.SpellSetTierList*, void>)0x005BE2C0)(ref this, from);
}

