namespace ACBindings;

// Fellow
public unsafe struct Fellow : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // Fellow_vtbl
    public unsafe struct Fellow_vtbl
    {
        // Members
        public System.IntPtr Fellow_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte _name;
    public uint _level;
    public uint _cp_cache;
    public uint _lum_cache;
    public int _share_loot;
    public uint _max_health;
    public uint _max_stamina;
    public uint _max_mana;
    public uint _current_health;
    public uint _current_stamina;
    public uint _current_mana;

    // Generated Constructor
    public Fellow() {
        _ConstructorInternal();
    }
    public Fellow(ACBindings.Fellow* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall Fellow::~Fellow(Fellow*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellow, void>)0x0048ED20)(ref this);
    // void __thiscall Fellow::Fellow(Fellow*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellow, void>)0x005BA9E0)(ref this);
    // void __thiscall Fellow::Fellow(Fellow*,const Fellow*)
    public void _ConstructorInternal(ACBindings.Fellow* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellow, ACBindings.Fellow*, void>)0x005BAA30)(ref this, rhs);
    // unsigned int __thiscall Fellow::GetPackSize(Fellow*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellow, uint>)0x005BAB30)(ref this);
    // unsigned int __thiscall Fellow::Pack(Fellow*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellow, void**, uint, uint>)0x005BAB50)(ref this, addr, size);
    // int __thiscall Fellow::UnPack(Fellow*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Fellow, void**, uint, int>)0x005BAC10)(ref this, addr, size);
}

