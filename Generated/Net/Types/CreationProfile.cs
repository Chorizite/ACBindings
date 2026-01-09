namespace ACBindings;

// CreationProfile
public unsafe struct CreationProfile
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CreationProfile_vtbl
    public unsafe struct CreationProfile_vtbl
    {
        // Members
        public System.IntPtr CreationProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IDClass___tagDataID wcid;
    public int try_to_bond;
    public uint palette;
    public ACBindings._8CE6913025E23AEA9D70623073A7213E ___u4;
    public ACBindings._C35DDEE700DD6A38E6EDE7A3277AAE91 ___u5;
    public ACBindings._84ACB31EA67D08504ED00D0F279E10D9 ___u6;

    // Generated Constructor
    public CreationProfile() {
        _ConstructorInternal();
    }
    public CreationProfile(ACBindings.CreationProfile* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods
    // void __thiscall CreationProfile::CreationProfile(CreationProfile*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreationProfile, void>)0x005CD250)(ref this);
    // void __thiscall CreationProfile::CreationProfile(CreationProfile*,const CreationProfile*)
    public void _ConstructorInternal(ACBindings.CreationProfile* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreationProfile, ACBindings.CreationProfile*, void>)0x005CD280)(ref this, rhs);
    // unsigned int __thiscall CreationProfile::Pack(CreationProfile*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreationProfile, void**, uint, uint>)0x005CD2C0)(ref this, addr, size);
    // int __thiscall CreationProfile::UnPack(CreationProfile*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CreationProfile, void**, uint, int>)0x005CD320)(ref this, addr, size);
}

