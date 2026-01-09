namespace ACBindings;

// ContentProfile
public unsafe struct ContentProfile
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // ContentProfile_vtbl
    public unsafe struct ContentProfile_vtbl
    {
        // Members
        public System.IntPtr ContentProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint m_iid;
    public uint m_uContainerProperties;

    // Generated Constructor
    public ContentProfile(uint iid) {
        _ConstructorInternal(iid);
    }
    public ContentProfile() {
        _ConstructorInternal();
    }

    // Methods
    // unsigned int __thiscall ContentProfile::Pack(CloTextureEffect*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ContentProfile, void**, uint, uint>)0x005A9890)(ref this, addr, size);
    // void __thiscall ContentProfile::ContentProfile(ContentProfile*,unsigned int)
    public void _ConstructorInternal(uint iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ContentProfile, uint, void>)0x006B0DA0)(ref this, iid);
    // void __thiscall ContentProfile::ContentProfile(ContentProfile*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ContentProfile, void>)0x006B0DC0)(ref this);
    // int __thiscall ContentProfile::UnPack(ContentProfile*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ContentProfile, void**, uint, int>)0x006B0DE0)(ref this, addr, size);
}

