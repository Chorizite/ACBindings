namespace ACBindings;

// EnumIDMap
public unsafe struct EnumIDMap : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Child Types
    // EnumIDMap_vtbl
    public unsafe struct EnumIDMap_vtbl
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
    // EnumIDMap::iterator
    public unsafe struct iterator
    {
        // Members
        public ACBindings.EnumIDMap* m_mapper;
        public ACBindings.HashIterator__uint__PStringBase__sbyte m_iter;

        // Methods
    }

    // Members
    public ACBindings.HashTable__uint__IDClass___tagDataID m_EnumToID;
    public ACBindings.HashTable__uint__IDClass___tagDataID m_EnumToIDInternal;
    public ACBindings.HashTable__uint__PStringBase__sbyte m_EnumToName;
    public ACBindings.HashTable__uint__PStringBase__sbyte m_EnumToNameInternal;

    // Generated Constructor
    public EnumIDMap() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // char __thiscall EnumIDMap::NameToEnum(_DWORD*,const char**,_DWORD*)
    public sbyte NameToEnum(sbyte** a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumIDMap, sbyte**, int*, sbyte>)0x004159D0)(ref this, a2, a3);
    // void __thiscall EnumIDMap::GetSubDataIDs(EnumIDMap*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* IDs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumIDMap, ACBindings.QualifiedDataIDArray*, void>)0x00415B00)(ref this, IDs);
    // int __thiscall EnumIDMap::EnumToDID(_DWORD*,unsigned int,_DWORD*)
    public int EnumToDID(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumIDMap, uint, int*, int>)0x00415C10)(ref this, a2, a3);
    // BOOL __thiscall EnumIDMap::GetName(_DWORD*,int,int*)
    public byte GetName(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumIDMap, int, int*, byte>)0x00415C90)(ref this, a2, a3);
    // void __thiscall EnumIDMap::Destroy(EnumIDMap*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumIDMap, void>)0x00416150)(ref this);
    // void __thiscall EnumIDMap::EnumIDMap(EnumIDMap*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumIDMap, void>)0x00416690)(ref this);
    // unsigned int __thiscall EnumIDMap::GetDBOType(EnumIDMap*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumIDMap, uint>)0x00416700)(ref this);
    // void __thiscall EnumIDMap::~EnumIDMap(EnumIDMap*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumIDMap, void>)0x00416710)(ref this);
    // DBObj* __cdecl EnumIDMap::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x00416850)();
    // void __thiscall EnumIDMap::Serialize(EnumIDMap*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumIDMap, ACBindings.Archive*, void>)0x00416890)(ref this, io_archive);
}

