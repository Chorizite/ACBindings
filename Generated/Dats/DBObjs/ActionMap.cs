namespace ACBindings.Internal;

public unsafe struct ActionMap : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct ActionMap_vtbl
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
    public ACBindings.Internal.HashList__uint___HashList__uint___ActionMapValue m_hashInputMaps;
    public ACBindings.Internal.IDClass____tagDataID m_didStringTable;
    public ACBindings.Internal.HashTable__uint___InputMapConflictsValue m_hashConflictingMaps;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F7E50
    /// DBObj* __cdecl ActionMap::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7E50)();

    /// <summary>
    /// <code>Offset: 0x00685F30
    /// char __thiscall ActionMap::GetConflictingInputMaps(_DWORD*,unsigned int,_DWORD*)</code>
    /// </summary>
    public sbyte GetConflictingInputMaps(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, uint, int*, sbyte>)0x00685F30)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x006863A0
    /// unsigned int __thiscall ActionMap::GetToggleType(ActionMap*,unsigned int,unsigned int)</code>
    /// </summary>
    public uint GetToggleType(uint i_eAction, uint i_eMapID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, uint, uint, uint>)0x006863A0)(ref this, i_eAction, i_eMapID);

    /// <summary>
    /// <code>Offset: 0x00686470
    /// bool __thiscall ActionMap::IsActionAllowedInInputMap(ActionMap*,unsigned int,unsigned int)</code>
    /// </summary>
    public byte IsActionAllowedInInputMap(uint i_eAction, uint i_eMapID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, uint, uint, byte>)0x00686470)(ref this, i_eAction, i_eMapID);

    /// <summary>
    /// <code>Offset: 0x00686530
    /// bool __thiscall ActionMap::IsUserBindable(ActionMap*,unsigned int,unsigned int)</code>
    /// </summary>
    public byte IsUserBindable(uint i_eAction, uint i_eMapID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, uint, uint, byte>)0x00686530)(ref this, i_eAction, i_eMapID);

    /// <summary>
    /// <code>Offset: 0x00686610
    /// unsigned int __thiscall ActionMap::GetActionClass(ActionMap*,unsigned int,unsigned int)</code>
    /// </summary>
    public uint GetActionClass(uint i_eAction, uint i_eMapID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, uint, uint, uint>)0x00686610)(ref this, i_eAction, i_eMapID);

    /// <summary>
    /// <code>Offset: 0x006866E0
    /// char __thiscall ActionMap::GetDescripValues(_DWORD*,int,int,wchar_t*,wchar_t*)</code>
    /// </summary>
    public sbyte GetDescripValues(int a2, int a3, System.IntPtr a4, System.IntPtr a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, int, int, System.IntPtr, System.IntPtr, sbyte>)0x006866E0)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x00686BD0
    /// void __thiscall ActionMap::Destroy(ActionMap*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, void>)0x00686BD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00686C50
    /// unsigned int __thiscall ActionMap::GetDBOType(ActionMap*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, uint>)0x00686C50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00686C60
    /// void __thiscall ActionMap::~ActionMap(ActionMap*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, void>)0x00686C60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00686F60
    /// void __thiscall ActionMap::Serialize(ActionMap*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, ACBindings.Internal.Archive*, void>)0x00686F60)(ref this, io_archive);
}

