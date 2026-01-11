namespace ACBindings.Internal;

public unsafe struct CreationProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CreationProfile_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreationProfile*, void> CreationProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreationProfile*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreationProfile*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CreationProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID wcid;
    public int try_to_bond;
    public uint palette;
    public ACBindings.Internal._8CE6913025E23AEA9D70623073A7213E ___u4;
    public ACBindings.Internal._C35DDEE700DD6A38E6EDE7A3277AAE91 ___u5;
    public ACBindings.Internal._84ACB31EA67D08504ED00D0F279E10D9 ___u6;

    // Generated Constructor
    public CreationProfile() {
        _ConstructorInternal();
    }
    public CreationProfile(ACBindings.Internal.CreationProfile* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005CD250
    /// void __thiscall CreationProfile::CreationProfile(CreationProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreationProfile, void>)0x005CD250)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CD280
    /// void __thiscall CreationProfile::CreationProfile(CreationProfile*,const CreationProfile*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.CreationProfile* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreationProfile, ACBindings.Internal.CreationProfile*, void>)0x005CD280)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x005CD2C0
    /// unsigned int __thiscall CreationProfile::Pack(CreationProfile*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreationProfile, void**, uint, uint>)0x005CD2C0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CD320
    /// int __thiscall CreationProfile::UnPack(CreationProfile*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CreationProfile, void**, uint, int>)0x005CD320)(ref this, addr, size);
}

