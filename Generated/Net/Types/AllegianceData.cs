namespace ACBindings;

// AllegianceData
public unsafe struct AllegianceData : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // AllegianceData_vtbl
    public unsafe struct AllegianceData_vtbl
    {
        // Members
        public System.IntPtr AllegianceData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _id;
    public ACBindings.AC1Legacy.PStringBase__sbyte _name;
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
    public AllegianceData(ACBindings.AllegianceData* rhs) {
        _ConstructorInternal(rhs);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // int __thiscall AllegianceData::GetTitle(int*,int*)
    public int GetTitle(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceData, int*, int>)0x005B7620)(ref this, a2);
    // int __thiscall AllegianceData::IsLoggedIn(AllegianceData*)
    public int IsLoggedIn() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceData, int>)0x005B7640)(ref this);
    // void __thiscall AllegianceData::SetMayPassupExperience(AllegianceData*,int)
    public void SetMayPassupExperience(int bMayPassupExperience) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceData, int, void>)0x005B7650)(ref this, bMayPassupExperience);
    // void __thiscall AllegianceData::AllegianceData(AllegianceData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceData, void>)0x005B7670)(ref this);
    // void __thiscall AllegianceData::~AllegianceData(AllegianceData*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceData, void>)0x005B76C0)(ref this);
    // unsigned int __thiscall AllegianceData::GetPackSize(AllegianceData*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceData, uint>)0x005B77E0)(ref this);
    // unsigned int __thiscall AllegianceData::Pack(AllegianceData*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceData, void**, uint, uint>)0x005B7800)(ref this, addr, size);
    // void __thiscall AllegianceData::AllegianceData(AllegianceData*,const AllegianceData*)
    public void _ConstructorInternal(ACBindings.AllegianceData* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceData, ACBindings.AllegianceData*, void>)0x005B78E0)(ref this, rhs);
    // int __thiscall AllegianceData::UnPack(AllegianceData*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceData, void**, uint, int>)0x005B7940)(ref this, addr, size);
    // int __thiscall AllegianceData::GetFullName(_DWORD*,int)
    public int GetFullName(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceData, int, int>)0x005B7A40)(ref this, a2);
}

