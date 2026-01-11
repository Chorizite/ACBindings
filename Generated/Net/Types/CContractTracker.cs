namespace ACBindings.Internal;

public unsafe struct CContractTracker
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CContractTracker_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CContractTracker*, void> CContractTracker_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CContractTracker*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CContractTracker*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CContractTracker*, void**, uint, int> UnPack; // function pointer

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
    public CContractTracker(ACBindings.Internal.CContractTracker* contract) {
        _ConstructorInternal(contract);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0059A100
    /// void __thiscall CContractTracker::CContractTracker(CContractTracker*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContractTracker, void>)0x0059A100)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059A130
    /// void __thiscall CContractTracker::CContractTracker(CContractTracker*,const CContractTracker*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.CContractTracker* contract) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContractTracker, ACBindings.Internal.CContractTracker*, void>)0x0059A130)(ref this, contract);

    /// <summary>
    /// <code>Offset: 0x0059A180
    /// unsigned int __thiscall CContractTracker::Pack(CContractTracker*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContractTracker, void**, uint, uint>)0x0059A180)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0059A1E0
    /// int __thiscall CContractTracker::UnPack(CContractTracker*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContractTracker, void**, uint, int>)0x0059A1E0)(ref this, addr, size);
}

