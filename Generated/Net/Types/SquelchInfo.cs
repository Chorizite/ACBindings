namespace ACBindings;

// SquelchInfo
public unsafe struct SquelchInfo : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // SquelchInfo_vtbl
    public unsafe struct SquelchInfo_vtbl
    {
        // Members
        public System.IntPtr SquelchInfo_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AC1Legacy.vlong _squelch_msgs;
    public int _is_zone_squelch;
    public ACBindings.AC1Legacy.PStringBase__sbyte _name;

    // Generated Constructor
    public SquelchInfo() {
        _ConstructorInternal();
    }
    public SquelchInfo(void** a2, uint i) {
        _ConstructorInternal(a2, i);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall SquelchInfo::InqName(_DWORD*,int*)
    public void InqName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SquelchInfo, int*, void>)0x0058A180)(ref this, a2);
    // int __thiscall SquelchInfo::IsEmpty(SquelchInfo*)
    public int IsEmpty() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SquelchInfo, int>)0x006B1AF0)(ref this);
    // int __thiscall SquelchInfo::IsSquelched(SquelchInfo*,unsigned int)
    public int IsSquelched(uint msg_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SquelchInfo, uint, int>)0x006B1B20)(ref this, msg_type);
    // void __thiscall SquelchInfo::Clear(SquelchInfo*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SquelchInfo, void>)0x006B1DA0)(ref this);
    // void __thiscall SquelchInfo::SquelchInfo(SquelchInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SquelchInfo, void>)0x006B1F00)(ref this);
    // SquelchInfo* __thiscall SquelchInfo::SquelchInfo(SquelchInfo*,void**,unsigned int)
    public ACBindings.SquelchInfo* _ConstructorInternal(void** a2, uint i) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SquelchInfo, void**, uint, ACBindings.SquelchInfo*>)0x006B1F40)(ref this, a2, i);
    // void __thiscall SquelchInfo::~SquelchInfo(SquelchInfo*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SquelchInfo, void>)0x006B1FE0)(ref this);
    // unsigned int __thiscall SquelchInfo::Pack(SquelchInfo*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SquelchInfo, void**, uint, uint>)0x006B2020)(ref this, addr, size);
    // int __thiscall SquelchInfo::UnPack(SquelchInfo*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SquelchInfo, void**, uint, int>)0x006B2090)(ref this, addr, size);
}

