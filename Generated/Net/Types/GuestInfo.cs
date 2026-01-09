namespace ACBindings;

// GuestInfo
public unsafe struct GuestInfo : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // GuestInfo_vtbl
    public unsafe struct GuestInfo_vtbl
    {
        // Members
        public System.IntPtr GuestInfo_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public int _item_storage_permission;
    public ACBindings.AC1Legacy.PStringBase__sbyte _char_name;

    // Generated Constructor
    public GuestInfo() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall GuestInfo::~GuestInfo(GuestInfo*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GuestInfo, void>)0x005B0220)(ref this);
    // void __thiscall GuestInfo::Clear(GuestInfo*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GuestInfo, void>)0x005B0370)(ref this);
    // unsigned int __thiscall GuestInfo::GetPackSize(GuestInfo*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GuestInfo, uint>)0x005B03C0)(ref this);
    // unsigned int __thiscall GuestInfo::Pack(GuestInfo*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GuestInfo, void**, uint, uint>)0x005B03E0)(ref this, addr, size);
    // void __thiscall GuestInfo::GuestInfo(GuestInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GuestInfo, void>)0x005B0420)(ref this);
    // int __thiscall GuestInfo::UnPack(GuestInfo*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GuestInfo, void**, uint, int>)0x005B0490)(ref this, addr, size);
    // int __thiscall GuestInfo::Dump(_DWORD*,int)
    public int Dump(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GuestInfo, int, int>)0x005B05D0)(ref this, a2);
}

