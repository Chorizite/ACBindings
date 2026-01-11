namespace ACBindings.Internal;

public unsafe struct PhysicsScriptTable : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct PhysicsScriptTable_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.HashTable__uint___PhysicsScriptTableData_ptr script_table;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F7ED0
    /// DBObj* __cdecl PhysicsScriptTable::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7ED0)();

    /// <summary>
    /// <code>Offset: 0x00522780
    /// unsigned int __thiscall PhysicsScriptTable::pack_size(PhysicsScriptTable*,int*)</code>
    /// </summary>
    public uint pack_size(int* num_scripts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTable, int*, uint>)0x00522780)(ref this, num_scripts);

    /// <summary>
    /// <code>Offset: 0x00522800
    /// unsigned int __thiscall PhysicsScriptTable::Pack(PhysicsScriptTable*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTable, void**, uint, uint>)0x00522800)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005228B0
    /// void __thiscall PhysicsScriptTable::GetSubDataIDs(PhysicsScriptTable*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTable, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005228B0)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x00522990
    /// unsigned int* __thiscall PhysicsScriptTable::GetScript(_DWORD*,unsigned int*,unsigned int,float)</code>
    /// </summary>
    public uint* GetScript(uint* a2, uint a3, float a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTable, uint*, uint, float, uint*>)0x00522990)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x00522B30
    /// unsigned int __thiscall PhysicsScriptTable::GetDBOType(PhysicsScriptTable*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTable, uint>)0x00522B30)(ref this);

    /// <summary>
    /// <code>Offset: 0x00522B50
    /// void __thiscall PhysicsScriptTable::Destroy(PhysicsScriptTable*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTable, void>)0x00522B50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00522C30
    /// int __thiscall PhysicsScriptTable::UnPack(PhysicsScriptTable*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTable, void**, uint, int>)0x00522C30)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00522D30
    /// void __thiscall PhysicsScriptTable::~PhysicsScriptTable(PhysicsScriptTable*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTable, void>)0x00522D30)(ref this);
}

