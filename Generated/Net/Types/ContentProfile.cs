namespace ACBindings.Internal;

public unsafe struct ContentProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ContentProfile_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ContentProfile*, void> ContentProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ContentProfile*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ContentProfile*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ContentProfile*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x005A9890
    /// unsigned int __thiscall ContentProfile::Pack(CloTextureEffect*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContentProfile, void**, uint, uint>)0x005A9890)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x006B0DA0
    /// void __thiscall ContentProfile::ContentProfile(ContentProfile*,unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(uint iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContentProfile, uint, void>)0x006B0DA0)(ref this, iid);

    /// <summary>
    /// <code>Offset: 0x006B0DC0
    /// void __thiscall ContentProfile::ContentProfile(ContentProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContentProfile, void>)0x006B0DC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B0DE0
    /// int __thiscall ContentProfile::UnPack(ContentProfile*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ContentProfile, void**, uint, int>)0x006B0DE0)(ref this, addr, size);
}

