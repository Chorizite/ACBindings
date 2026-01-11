namespace ACBindings.Internal;

public unsafe struct AllegianceData : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AllegianceData_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceData*, void> AllegianceData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceData*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceData*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _id;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;
    public uint _gender;
    public uint _hg;
    public uint _rank;
    public uint _level;
    public uint _bitfield;
    public uint _cp_tithed;
    public uint _cp_cached;
    public uint _loyalty;
    public uint _leadership;
    public int _time_online;
    public int _allegiance_age;

    // Generated Constructor
    public AllegianceData() {
        _ConstructorInternal();
    }
    public AllegianceData(ACBindings.Internal.AllegianceData* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005B7620
    /// int __thiscall AllegianceData::GetTitle(int*,int*)</code>
    /// </summary>
    public int GetTitle(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, int*, int>)0x005B7620)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005B7640
    /// int __thiscall AllegianceData::IsLoggedIn(AllegianceData*)</code>
    /// </summary>
    public int IsLoggedIn() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, int>)0x005B7640)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B7650
    /// void __thiscall AllegianceData::SetMayPassupExperience(AllegianceData*,int)</code>
    /// </summary>
    public void SetMayPassupExperience(int bMayPassupExperience) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, int, void>)0x005B7650)(ref this, bMayPassupExperience);

    /// <summary>
    /// <code>Offset: 0x005B7670
    /// void __thiscall AllegianceData::AllegianceData(AllegianceData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, void>)0x005B7670)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B76C0
    /// void __thiscall AllegianceData::~AllegianceData(AllegianceData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, void>)0x005B76C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B77E0
    /// unsigned int __thiscall AllegianceData::GetPackSize(AllegianceData*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, uint>)0x005B77E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B7800
    /// unsigned int __thiscall AllegianceData::Pack(AllegianceData*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, void**, uint, uint>)0x005B7800)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005B78E0
    /// void __thiscall AllegianceData::AllegianceData(AllegianceData*,const AllegianceData*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.AllegianceData* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, ACBindings.Internal.AllegianceData*, void>)0x005B78E0)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x005B7940
    /// int __thiscall AllegianceData::UnPack(AllegianceData*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, void**, uint, int>)0x005B7940)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005B7A40
    /// int __thiscall AllegianceData::GetFullName(_DWORD*,int)</code>
    /// </summary>
    public int GetFullName(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceData, int, int>)0x005B7A40)(ref this, a2);
}

