namespace ACBindings;

// PhysicsScriptTable
public unsafe struct PhysicsScriptTable : System.IDisposable
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // PhysicsScriptTable_vtbl
    public unsafe struct PhysicsScriptTable_vtbl
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
    public ACBindings.HashTable__uint__PhysicsScriptTableData_ptr script_table;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // DBObj* __cdecl PhysicsScriptTable::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7ED0)();
    // unsigned int __thiscall PhysicsScriptTable::pack_size(PhysicsScriptTable*,int*)
    public uint pack_size(int* num_scripts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScriptTable, int*, uint>)0x00522780)(ref this, num_scripts);
    // unsigned int __thiscall PhysicsScriptTable::Pack(PhysicsScriptTable*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScriptTable, void**, uint, uint>)0x00522800)(ref this, addr, size);
    // void __thiscall PhysicsScriptTable::GetSubDataIDs(PhysicsScriptTable*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScriptTable, ACBindings.QualifiedDataIDArray*, void>)0x005228B0)(ref this, id_array);
    // unsigned int* __thiscall PhysicsScriptTable::GetScript(_DWORD*,unsigned int*,unsigned int,float)
    public uint* GetScript(uint* a2, uint a3, float a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScriptTable, uint*, uint, float, uint*>)0x00522990)(ref this, a2, a3, a4);
    // unsigned int __thiscall PhysicsScriptTable::GetDBOType(PhysicsScriptTable*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScriptTable, uint>)0x00522B30)(ref this);
    // void __thiscall PhysicsScriptTable::Destroy(PhysicsScriptTable*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScriptTable, void>)0x00522B50)(ref this);
    // int __thiscall PhysicsScriptTable::UnPack(PhysicsScriptTable*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScriptTable, void**, uint, int>)0x00522C30)(ref this, addr, size);
    // void __thiscall PhysicsScriptTable::~PhysicsScriptTable(PhysicsScriptTable*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PhysicsScriptTable, void>)0x00522D30)(ref this);
}

