namespace ACBindings.Internal;

public unsafe struct Fellow : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Fellow_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Fellow*, void> Fellow_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Fellow*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Fellow*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Fellow*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;
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
    public Fellow(ACBindings.Internal.Fellow* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0048ED20
    /// void __thiscall Fellow::~Fellow(Fellow*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellow, void>)0x0048ED20)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BA9E0
    /// void __thiscall Fellow::Fellow(Fellow*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellow, void>)0x005BA9E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BAA30
    /// void __thiscall Fellow::Fellow(Fellow*,const Fellow*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.Fellow* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellow, ACBindings.Internal.Fellow*, void>)0x005BAA30)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x005BAB30
    /// unsigned int __thiscall Fellow::GetPackSize(Fellow*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellow, uint>)0x005BAB30)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BAB50
    /// unsigned int __thiscall Fellow::Pack(Fellow*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellow, void**, uint, uint>)0x005BAB50)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BAC10
    /// int __thiscall Fellow::UnPack(Fellow*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Fellow, void**, uint, int>)0x005BAC10)(ref this, addr, size);
}

