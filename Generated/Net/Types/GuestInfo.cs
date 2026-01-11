namespace ACBindings.Internal;

public unsafe struct GuestInfo : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct GuestInfo_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GuestInfo*, void> GuestInfo_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GuestInfo*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GuestInfo*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GuestInfo*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public int _item_storage_permission;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _char_name;

    // Generated Constructor
    public GuestInfo() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005B0220
    /// void __thiscall GuestInfo::~GuestInfo(GuestInfo*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GuestInfo, void>)0x005B0220)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B0370
    /// void __thiscall GuestInfo::Clear(GuestInfo*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GuestInfo, void>)0x005B0370)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B03C0
    /// unsigned int __thiscall GuestInfo::GetPackSize(GuestInfo*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GuestInfo, uint>)0x005B03C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B03E0
    /// unsigned int __thiscall GuestInfo::Pack(GuestInfo*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GuestInfo, void**, uint, uint>)0x005B03E0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005B0420
    /// void __thiscall GuestInfo::GuestInfo(GuestInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GuestInfo, void>)0x005B0420)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B0490
    /// int __thiscall GuestInfo::UnPack(GuestInfo*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GuestInfo, void**, uint, int>)0x005B0490)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005B05D0
    /// int __thiscall GuestInfo::Dump(_DWORD*,int)</code>
    /// </summary>
    public int Dump(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GuestInfo, int, int>)0x005B05D0)(ref this, a2);
}

