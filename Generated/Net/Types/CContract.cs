namespace ACBindings.Internal;

public unsafe struct CContract : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CContract_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CContract*, void> CContract_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CContract*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CContract*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CContract*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _version;
    public uint _contract_id;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _contract_name;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _description;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _description_progress;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name_npc_start;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name_npc_end;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _questflag_stamped;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _questflag_started;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _questflag_finished;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _questflag_progress;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _questflag_timer;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _questflag_repeat_time;
    public ACBindings.Internal.Position _location_npc_start;
    public ACBindings.Internal.Position _location_npc_end;
    public ACBindings.Internal.Position _location_quest_area;

    // Generated Constructor
    public CContract() {
        _ConstructorInternal();
    }
    public CContract(ACBindings.Internal.CContract* contract) {
        _ConstructorInternal(contract);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0059AA80
    /// void __thiscall CContract::~CContract(CContract*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContract, void>)0x0059AA80)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059AFE0
    /// void __thiscall CContract::CContract(CContract*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContract, void>)0x0059AFE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059B140
    /// void __thiscall CContract::CContract(CContract*,const CContract*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.CContract* contract) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContract, ACBindings.Internal.CContract*, void>)0x0059B140)(ref this, contract);

    /// <summary>
    /// <code>Offset: 0x0059B270
    /// unsigned int __thiscall CContract::GetPackSize(CContract*,const unsigned int)</code>
    /// </summary>
    public uint GetPackSize(uint version) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContract, uint, uint>)0x0059B270)(ref this, version);

    /// <summary>
    /// <code>Offset: 0x0059B390
    /// unsigned int __thiscall CContract::Pack(CContract*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContract, void**, uint, uint>)0x0059B390)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0059B470
    /// int __thiscall CContract::UnPack(CContract*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContract, void**, uint, int>)0x0059B470)(ref this, addr, size);
}

