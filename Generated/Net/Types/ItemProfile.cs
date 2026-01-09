namespace ACBindings;

// ItemProfile
public unsafe struct ItemProfile : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // ItemProfile_vtbl
    public unsafe struct ItemProfile_vtbl
    {
        // Members
        public System.IntPtr ItemProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public int amount;
    public uint iid;
    public ACBindings.PublicWeenieDesc* pwd;

    // Generated Constructor
    public ItemProfile() {
        _ConstructorInternal();
    }
    public ItemProfile(ACBindings.ItemProfile* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ItemProfile::Clear(ItemProfile*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemProfile, void>)0x005D2750)(ref this);
    // void __thiscall ItemProfile::ItemProfile(ItemProfile*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemProfile, void>)0x005D2810)(ref this);
    // void __thiscall ItemProfile::~ItemProfile(ItemProfile*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemProfile, void>)0x005D2830)(ref this);
    // void __thiscall ItemProfile::ItemProfile(ItemProfile*,const ItemProfile*)
    public void _ConstructorInternal(ACBindings.ItemProfile* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemProfile, ACBindings.ItemProfile*, void>)0x005D2860)(ref this, rhs);
    // unsigned int __thiscall ItemProfile::Pack(ItemProfile*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemProfile, void**, uint, uint>)0x005D2890)(ref this, addr, size);
    // int __thiscall ItemProfile::UnPack(ItemProfile*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ItemProfile, void**, uint, int>)0x005D2910)(ref this, addr, size);
}

