namespace ACBindings;

// CContractTrackerTable
public unsafe struct CContractTrackerTable : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CContractTrackerTable_vtbl
    public unsafe struct CContractTrackerTable_vtbl
    {
        // Members
        public System.IntPtr CContractTrackerTable_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PackableHashTable__uint__CContractTracker _contractTrackerHash;

    // Generated Constructor
    public CContractTrackerTable() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CContractTrackerTable::~CContractTrackerTable(CContractTrackerTable*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CContractTrackerTable, void>)0x00560020)(ref this);
    // void __thiscall CContractTrackerTable::CContractTrackerTable(CContractTrackerTable*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CContractTrackerTable, void>)0x0059A250)(ref this);
}

