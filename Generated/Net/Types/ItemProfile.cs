namespace ACBindings.Internal;

public unsafe struct ItemProfile : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ItemProfile_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ItemProfile*, void> ItemProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ItemProfile*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ItemProfile*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ItemProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public int amount;
    public uint iid;
    public ACBindings.Internal.PublicWeenieDesc* pwd;

    // Generated Constructor
    public ItemProfile() {
        _ConstructorInternal();
    }
    public ItemProfile(ACBindings.Internal.ItemProfile* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005D2750
    /// void __thiscall ItemProfile::Clear(ItemProfile*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemProfile, void>)0x005D2750)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D2810
    /// void __thiscall ItemProfile::ItemProfile(ItemProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemProfile, void>)0x005D2810)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D2830
    /// void __thiscall ItemProfile::~ItemProfile(ItemProfile*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemProfile, void>)0x005D2830)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D2860
    /// void __thiscall ItemProfile::ItemProfile(ItemProfile*,const ItemProfile*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.ItemProfile* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemProfile, ACBindings.Internal.ItemProfile*, void>)0x005D2860)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x005D2890
    /// unsigned int __thiscall ItemProfile::Pack(ItemProfile*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemProfile, void**, uint, uint>)0x005D2890)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005D2910
    /// int __thiscall ItemProfile::UnPack(ItemProfile*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ItemProfile, void**, uint, int>)0x005D2910)(ref this, addr, size);
}

