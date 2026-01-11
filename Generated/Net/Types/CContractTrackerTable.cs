namespace ACBindings.Internal;

public unsafe struct CContractTrackerTable : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CContractTrackerTable_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CContractTrackerTable*, void> CContractTrackerTable_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CContractTrackerTable*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CContractTrackerTable*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CContractTrackerTable*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableHashTable__uint___CContractTracker _contractTrackerHash;

    // Generated Constructor
    public CContractTrackerTable() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00560020
    /// void __thiscall CContractTrackerTable::~CContractTrackerTable(CContractTrackerTable*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContractTrackerTable, void>)0x00560020)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059A250
    /// void __thiscall CContractTrackerTable::CContractTrackerTable(CContractTrackerTable*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContractTrackerTable, void>)0x0059A250)(ref this);
}

