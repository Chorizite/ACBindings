namespace ACBindings.Internal;

public unsafe struct SpellBookPage
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SpellBookPage_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellBookPage*, void> SpellBookPage_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellBookPage*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellBookPage*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellBookPage*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float _casting_likelihood;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005CD180
    /// unsigned int __thiscall SpellBookPage::Pack(SpellBookPage*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellBookPage, void**, uint, uint>)0x005CD180)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CD1B0
    /// int __thiscall SpellBookPage::UnPack(SpellBookPage*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellBookPage, void**, uint, int>)0x005CD1B0)(ref this, addr, size);
}

