namespace ACBindings;

// ActionMap
public unsafe struct ActionMap : System.IDisposable
{
    // Base Classes
    public ACBindings.DBObj BaseClass_DBObj; // ACBindings.DBObj

    // Child Types
    // ActionMap_vtbl
    public unsafe struct ActionMap_vtbl
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
    public ACBindings.HashList__uint__HashList__uint__ActionMapValue m_hashInputMaps;
    public ACBindings.IDClass___tagDataID m_didStringTable;
    public ACBindings.HashTable__uint__InputMapConflictsValue m_hashConflictingMaps;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // DBObj* __cdecl ActionMap::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7E50)();
    // char __thiscall ActionMap::GetConflictingInputMaps(_DWORD*,unsigned int,_DWORD*)
    public sbyte GetConflictingInputMaps(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ActionMap, uint, int*, sbyte>)0x00685F30)(ref this, a2, a3);
    // unsigned int __thiscall ActionMap::GetToggleType(ActionMap*,unsigned int,unsigned int)
    public uint GetToggleType(uint i_eAction, uint i_eMapID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ActionMap, uint, uint, uint>)0x006863A0)(ref this, i_eAction, i_eMapID);
    // bool __thiscall ActionMap::IsActionAllowedInInputMap(ActionMap*,unsigned int,unsigned int)
    public byte IsActionAllowedInInputMap(uint i_eAction, uint i_eMapID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ActionMap, uint, uint, byte>)0x00686470)(ref this, i_eAction, i_eMapID);
    // bool __thiscall ActionMap::IsUserBindable(ActionMap*,unsigned int,unsigned int)
    public byte IsUserBindable(uint i_eAction, uint i_eMapID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ActionMap, uint, uint, byte>)0x00686530)(ref this, i_eAction, i_eMapID);
    // unsigned int __thiscall ActionMap::GetActionClass(ActionMap*,unsigned int,unsigned int)
    public uint GetActionClass(uint i_eAction, uint i_eMapID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ActionMap, uint, uint, uint>)0x00686610)(ref this, i_eAction, i_eMapID);
    // char __thiscall ActionMap::GetDescripValues(_DWORD*,int,int,wchar_t*,wchar_t*)
    public sbyte GetDescripValues(int a2, int a3, System.IntPtr a4, System.IntPtr a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ActionMap, int, int, System.IntPtr, System.IntPtr, sbyte>)0x006866E0)(ref this, a2, a3, a4, a5);
    // void __thiscall ActionMap::Destroy(ActionMap*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ActionMap, void>)0x00686BD0)(ref this);
    // unsigned int __thiscall ActionMap::GetDBOType(ActionMap*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ActionMap, uint>)0x00686C50)(ref this);
    // void __thiscall ActionMap::~ActionMap(ActionMap*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ActionMap, void>)0x00686C60)(ref this);
    // void __thiscall ActionMap::Serialize(ActionMap*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ActionMap, ACBindings.Archive*, void>)0x00686F60)(ref this, io_archive);
}

