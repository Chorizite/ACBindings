namespace ACBindings.Internal;

public unsafe struct SquelchInfo : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SquelchInfo_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SquelchInfo*, void> SquelchInfo_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SquelchInfo*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SquelchInfo*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SquelchInfo*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.vlong _squelch_msgs;
    public int _is_zone_squelch;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;

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

    /// <summary>
    /// <code>Offset: 0x0058A180
    /// void __thiscall SquelchInfo::InqName(_DWORD*,int*)</code>
    /// </summary>
    public void InqName(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, int*, void>)0x0058A180)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x006B1AF0
    /// int __thiscall SquelchInfo::IsEmpty(SquelchInfo*)</code>
    /// </summary>
    public int IsEmpty() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, int>)0x006B1AF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B1B20
    /// int __thiscall SquelchInfo::IsSquelched(SquelchInfo*,unsigned int)</code>
    /// </summary>
    public int IsSquelched(uint msg_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, uint, int>)0x006B1B20)(ref this, msg_type);

    /// <summary>
    /// <code>Offset: 0x006B1DA0
    /// void __thiscall SquelchInfo::Clear(SquelchInfo*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, void>)0x006B1DA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B1F00
    /// void __thiscall SquelchInfo::SquelchInfo(SquelchInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, void>)0x006B1F00)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B1F40
    /// SquelchInfo* __thiscall SquelchInfo::SquelchInfo(SquelchInfo*,void**,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.SquelchInfo* _ConstructorInternal(void** a2, uint i) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, void**, uint, ACBindings.Internal.SquelchInfo*>)0x006B1F40)(ref this, a2, i);

    /// <summary>
    /// <code>Offset: 0x006B1FE0
    /// void __thiscall SquelchInfo::~SquelchInfo(SquelchInfo*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, void>)0x006B1FE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006B2020
    /// unsigned int __thiscall SquelchInfo::Pack(SquelchInfo*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, void**, uint, uint>)0x006B2020)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x006B2090
    /// int __thiscall SquelchInfo::UnPack(SquelchInfo*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SquelchInfo, void**, uint, int>)0x006B2090)(ref this, addr, size);
}

