namespace ACBindings;

// AllegianceProfile
public unsafe struct AllegianceProfile : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // AllegianceProfile_vtbl
    public unsafe struct AllegianceProfile_vtbl
    {
        // Members
        public System.IntPtr AllegianceProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AllegianceHierarchy _allegiance;
    public uint _total_members;
    public uint _total_vassals;

    // Generated Constructor
    public AllegianceProfile() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall AllegianceProfile::~AllegianceProfile(AllegianceProfile*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceProfile, void>)0x0055B160)(ref this);
    // unsigned int __thiscall AllegianceProfile::GetMonarch(AllegianceProfile*,AllegianceData*)
    public uint GetMonarch(ACBindings.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceProfile, ACBindings.AllegianceData*, uint>)0x005B7B70)(ref this, retval);
    // unsigned int __thiscall AllegianceProfile::GetPatron(AllegianceProfile*,unsigned int,AllegianceData*)
    public uint GetPatron(uint id, ACBindings.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceProfile, uint, ACBindings.AllegianceData*, uint>)0x005B7BA0)(ref this, id, retval);
    // unsigned int __thiscall AllegianceProfile::GetFirstVassal(AllegianceProfile*,unsigned int,AllegianceData*)
    public uint GetFirstVassal(uint id, ACBindings.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceProfile, uint, ACBindings.AllegianceData*, uint>)0x005B7BB0)(ref this, id, retval);
    // unsigned int __thiscall AllegianceProfile::GetNextVassal(AllegianceProfile*,unsigned int,AllegianceData*)
    public uint GetNextVassal(uint vassal_id, ACBindings.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceProfile, uint, ACBindings.AllegianceData*, uint>)0x005B7BC0)(ref this, vassal_id, retval);
    // int __thiscall AllegianceProfile::GetData(AllegianceProfile*,unsigned int,AllegianceData*)
    public int GetData(uint id, ACBindings.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceProfile, uint, ACBindings.AllegianceData*, int>)0x005B7BD0)(ref this, id, retval);
    // unsigned int __thiscall AllegianceProfile::GetPackSize(AllegianceProfile*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceProfile, uint>)0x005B7BE0)(ref this);
    // void __thiscall AllegianceProfile::AllegianceProfile(AllegianceProfile*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceProfile, void>)0x005B7C00)(ref this);
    // unsigned int __thiscall AllegianceProfile::Pack(AllegianceProfile*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceProfile, void**, uint, uint>)0x005B7C30)(ref this, addr, size);
    // int __thiscall AllegianceProfile::UnPack(AllegianceProfile*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AllegianceProfile, void**, uint, int>)0x005B7C80)(ref this, addr, size);
}

