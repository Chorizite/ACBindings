namespace ACBindings.Internal;


/// <summary>
/// Maintains a collection of invalid or corrupted data identifiers for the game’s database, supporting serialization and packing operations via SerializeUsingPackDBObj.
/// </summary>
public unsafe struct BadData
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct BadData_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableHashTable___IDClass____tagDataID__int _bad;

    // Generated Constructor
    public BadData(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>Creates a new BadData instance by allocating memory and invoking its constructor.
    /// <code>Offset: 0x004F7C60
    /// DBObj* __cdecl BadData::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the allocated DBObj, or null if allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7C60)();

    /// <summary>Initializes a BadData object by constructing its DBObj base and setting up an internal hash table for tracking bad data IDs.
    /// <code>Offset: 0x004FE830
    /// int __thiscall BadData::BadData(int,void**)</code>
    /// </summary>
    /// <param name="a2">Pointer to auxiliary data passed to the DBObj constructor during initialization.</param>
    /// <returns>Pointer to the fully initialized BadData instance.</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BadData, void**, int>)0x004FE830)(ref this, a2);

    /// <summary>Packs the object’s data into a binary buffer when sufficient space is available.
    /// <code>Offset: 0x005CC530
    /// unsigned int __thiscall BadData::Pack(QuestDefDB*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer where packed data will be written.</param>
    /// <param name="size">Maximum number of bytes that may be written to *addr.</param>
    /// <returns>Number of bytes required to represent the object; if size is large enough, this value equals the number of bytes actually written.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BadData, void**, uint, uint>)0x005CC530)(ref this, addr, size);
}

