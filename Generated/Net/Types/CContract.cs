namespace ACBindings;

// CContract
public unsafe struct CContract : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CContract_vtbl
    public unsafe struct CContract_vtbl
    {
        // Members
        public System.IntPtr CContract_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _version;
    public uint _contract_id;
    public ACBindings.AC1Legacy.PStringBase__sbyte _contract_name;
    public ACBindings.AC1Legacy.PStringBase__sbyte _description;
    public ACBindings.AC1Legacy.PStringBase__sbyte _description_progress;
    public ACBindings.AC1Legacy.PStringBase__sbyte _name_npc_start;
    public ACBindings.AC1Legacy.PStringBase__sbyte _name_npc_end;
    public ACBindings.AC1Legacy.PStringBase__sbyte _questflag_stamped;
    public ACBindings.AC1Legacy.PStringBase__sbyte _questflag_started;
    public ACBindings.AC1Legacy.PStringBase__sbyte _questflag_finished;
    public ACBindings.AC1Legacy.PStringBase__sbyte _questflag_progress;
    public ACBindings.AC1Legacy.PStringBase__sbyte _questflag_timer;
    public ACBindings.AC1Legacy.PStringBase__sbyte _questflag_repeat_time;
    public ACBindings.Position _location_npc_start;
    public ACBindings.Position _location_npc_end;
    public ACBindings.Position _location_quest_area;

    // Generated Constructor
    public CContract() {
        _ConstructorInternal();
    }
    public CContract(ACBindings.CContract* contract) {
        _ConstructorInternal(contract);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CContract::~CContract(CContract*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CContract, void>)0x0059AA80)(ref this);
    // void __thiscall CContract::CContract(CContract*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CContract, void>)0x0059AFE0)(ref this);
    // void __thiscall CContract::CContract(CContract*,const CContract*)
    public void _ConstructorInternal(ACBindings.CContract* contract) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CContract, ACBindings.CContract*, void>)0x0059B140)(ref this, contract);
    // unsigned int __thiscall CContract::GetPackSize(CContract*,const unsigned int)
    public uint GetPackSize(uint version) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CContract, uint, uint>)0x0059B270)(ref this, version);
    // unsigned int __thiscall CContract::Pack(CContract*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CContract, void**, uint, uint>)0x0059B390)(ref this, addr, size);
    // int __thiscall CContract::UnPack(CContract*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CContract, void**, uint, int>)0x0059B470)(ref this, addr, size);
}

