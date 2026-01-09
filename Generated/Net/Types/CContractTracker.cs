namespace ACBindings;

// CContractTracker
public unsafe struct CContractTracker
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CContractTracker_vtbl
    public unsafe struct CContractTracker_vtbl
    {
        // Members
        public System.IntPtr CContractTracker_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _version;
    public uint _contract_id;
    public uint _contract_stage;
    public double _time_when_done;
    public double _time_when_repeats;
    public double _time_of_server_update;

    // Generated Constructor
    public CContractTracker() {
        _ConstructorInternal();
    }
    public CContractTracker(ACBindings.CContractTracker* contract) {
        _ConstructorInternal(contract);
    }

    // Methods
    // void __thiscall CContractTracker::CContractTracker(CContractTracker*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CContractTracker, void>)0x0059A100)(ref this);
    // void __thiscall CContractTracker::CContractTracker(CContractTracker*,const CContractTracker*)
    public void _ConstructorInternal(ACBindings.CContractTracker* contract) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CContractTracker, ACBindings.CContractTracker*, void>)0x0059A130)(ref this, contract);
    // unsigned int __thiscall CContractTracker::Pack(CContractTracker*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CContractTracker, void**, uint, uint>)0x0059A180)(ref this, addr, size);
    // int __thiscall CContractTracker::UnPack(CContractTracker*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CContractTracker, void**, uint, int>)0x0059A1E0)(ref this, addr, size);
}

