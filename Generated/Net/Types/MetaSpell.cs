namespace ACBindings.Internal;

public unsafe struct MetaSpell : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct MetaSpell_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MetaSpell*, void> MetaSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MetaSpell*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MetaSpell*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MetaSpell*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SpellType _sp_type;
    public ACBindings.Internal.Spell* _spell;

    // Generated Constructor
    public MetaSpell() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00599710
    /// void __thiscall MetaSpell::MetaSpell(MetaSpell*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MetaSpell, void>)0x00599710)(ref this);

    /// <summary>
    /// <code>Offset: 0x00599750
    /// unsigned int __thiscall MetaSpell::Pack(MetaSpell*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MetaSpell, void**, uint, uint>)0x00599750)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005997B0
    /// int __thiscall MetaSpell::UnPack(MetaSpell*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MetaSpell, void**, uint, int>)0x005997B0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00599890
    /// void __thiscall MetaSpell::~MetaSpell(MetaSpell*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MetaSpell, void>)0x00599890)(ref this);
}

