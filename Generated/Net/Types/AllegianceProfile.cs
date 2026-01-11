namespace ACBindings.Internal;

public unsafe struct AllegianceProfile : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AllegianceProfile_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceProfile*, void> AllegianceProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceProfile*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceProfile*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AllegianceProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AllegianceHierarchy _allegiance;
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

    /// <summary>
    /// <code>Offset: 0x0055B160
    /// void __thiscall AllegianceProfile::~AllegianceProfile(AllegianceProfile*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, void>)0x0055B160)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B7B70
    /// unsigned int __thiscall AllegianceProfile::GetMonarch(AllegianceProfile*,AllegianceData*)</code>
    /// </summary>
    public uint GetMonarch(ACBindings.Internal.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, ACBindings.Internal.AllegianceData*, uint>)0x005B7B70)(ref this, retval);

    /// <summary>
    /// <code>Offset: 0x005B7BA0
    /// unsigned int __thiscall AllegianceProfile::GetPatron(AllegianceProfile*,unsigned int,AllegianceData*)</code>
    /// </summary>
    public uint GetPatron(uint id, ACBindings.Internal.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, uint, ACBindings.Internal.AllegianceData*, uint>)0x005B7BA0)(ref this, id, retval);

    /// <summary>
    /// <code>Offset: 0x005B7BB0
    /// unsigned int __thiscall AllegianceProfile::GetFirstVassal(AllegianceProfile*,unsigned int,AllegianceData*)</code>
    /// </summary>
    public uint GetFirstVassal(uint id, ACBindings.Internal.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, uint, ACBindings.Internal.AllegianceData*, uint>)0x005B7BB0)(ref this, id, retval);

    /// <summary>
    /// <code>Offset: 0x005B7BC0
    /// unsigned int __thiscall AllegianceProfile::GetNextVassal(AllegianceProfile*,unsigned int,AllegianceData*)</code>
    /// </summary>
    public uint GetNextVassal(uint vassal_id, ACBindings.Internal.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, uint, ACBindings.Internal.AllegianceData*, uint>)0x005B7BC0)(ref this, vassal_id, retval);

    /// <summary>
    /// <code>Offset: 0x005B7BD0
    /// int __thiscall AllegianceProfile::GetData(AllegianceProfile*,unsigned int,AllegianceData*)</code>
    /// </summary>
    public int GetData(uint id, ACBindings.Internal.AllegianceData* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, uint, ACBindings.Internal.AllegianceData*, int>)0x005B7BD0)(ref this, id, retval);

    /// <summary>
    /// <code>Offset: 0x005B7BE0
    /// unsigned int __thiscall AllegianceProfile::GetPackSize(AllegianceProfile*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, uint>)0x005B7BE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B7C00
    /// void __thiscall AllegianceProfile::AllegianceProfile(AllegianceProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, void>)0x005B7C00)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B7C30
    /// unsigned int __thiscall AllegianceProfile::Pack(AllegianceProfile*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, void**, uint, uint>)0x005B7C30)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005B7C80
    /// int __thiscall AllegianceProfile::UnPack(AllegianceProfile*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AllegianceProfile, void**, uint, int>)0x005B7C80)(ref this, addr, size);
}

