namespace ACBindings;

// MetaSpell
public unsafe struct MetaSpell : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // MetaSpell_vtbl
    public unsafe struct MetaSpell_vtbl
    {
        // Members
        public System.IntPtr MetaSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.SpellType _sp_type;
    public ACBindings.Spell* _spell;

    // Generated Constructor
    public MetaSpell() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall MetaSpell::MetaSpell(MetaSpell*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MetaSpell, void>)0x00599710)(ref this);
    // unsigned int __thiscall MetaSpell::Pack(MetaSpell*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MetaSpell, void**, uint, uint>)0x00599750)(ref this, addr, size);
    // int __thiscall MetaSpell::UnPack(MetaSpell*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MetaSpell, void**, uint, int>)0x005997B0)(ref this, addr, size);
    // void __thiscall MetaSpell::~MetaSpell(MetaSpell*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MetaSpell, void>)0x00599890)(ref this);
}

