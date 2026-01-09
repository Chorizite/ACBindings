namespace ACBindings;

// QuestDefDB
public unsafe struct QuestDefDB : System.IDisposable
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // QuestDefDB_vtbl
    public unsafe struct QuestDefDB_vtbl
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
    public ACBindings.PackableHashTable__AC1Legacy_CaseInsensitiveStringBase__AC1Legacy_PStringBase__sbyte__QuestDef _defs;

    // Generated Constructor
    public QuestDefDB(void** a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall QuestDefDB::GetDBOType(QuestDefDB*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuestDefDB, uint>)0x004C0680)(ref this);
    // void __thiscall QuestDefDB::~QuestDefDB(QuestDefDB*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuestDefDB, void>)0x0059A7F0)(ref this);
    // int __thiscall QuestDefDB::UnPack(QuestDefDB*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuestDefDB, void**, uint, int>)0x005D3880)(ref this, addr, size);
    // int __thiscall QuestDefDB::QuestDefDB(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QuestDefDB, void**, int>)0x005D38E0)(ref this, a2);
    // DBObj* __cdecl QuestDefDB::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x005D3950)();
}

