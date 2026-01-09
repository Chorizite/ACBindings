namespace ACBindings;

// CContractTable
public unsafe struct CContractTable
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // CContractTable_vtbl
    public unsafe struct CContractTable_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBObj_dtor_18; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr InitLoad; // function pointer
        public System.IntPtr GetSubObjects; // function pointer
        public System.IntPtr ReleaseSubObjects; // function pointer
        public System.IntPtr NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr Destroy; // function pointer
        public System.IntPtr FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public System.IntPtr GetDBOType; // function pointer
        public System.IntPtr Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public System.IntPtr ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PackableHashTable__uint__CContract _contractHash;

    // Generated Constructor
    public CContractTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods
    // const CContract* __thiscall CContractTable::GetContract(CContractTable*,const unsigned int)
    public ACBindings.CContract* GetContract(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CContractTable, uint, ACBindings.CContract*>)0x00497FA0)(ref this, key);
    // unsigned int __thiscall CContractTable::GetDBOType(CContractTable*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CContractTable, uint>)0x004D9530)(ref this);
    // DBObj* __cdecl CContractTable::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x0058B7D0)();
    // void __thiscall CContractTable::GetSubDataIDs(CContractTable*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CContractTable, ACBindings.QualifiedDataIDArray*, void>)0x0059ABD0)(ref this, id_array);
    // int __thiscall CContractTable::CContractTable(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CContractTable, void**, int>)0x0059AF30)(ref this, a2);
}

