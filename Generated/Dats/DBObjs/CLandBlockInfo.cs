namespace ACBindings.Internal;

public unsafe struct CLandBlockInfo
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct CLandBlockInfo_vtbl
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
    public uint num_objects;
    public System.IntPtr object_ids;
    public ACBindings.Internal.Frame* object_frames;
    public uint num_buildings;
    public ACBindings.Internal.BuildInfo** buildings;
    public System.IntPtr restriction_table;
    public System.IntPtr cell_ownership;
    public uint num_cells;
    public uint* cell_ids;
    public ACBindings.Internal.CEnvCell** cells;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F7A50
    /// DBObj* __cdecl CLandBlockInfo::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7A50)();

    /// <summary>
    /// <code>Offset: 0x005276A0
    /// unsigned int __thiscall CLandBlockInfo::GetDBOType(CLandBlockInfo*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockInfo, uint>)0x005276A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052F420
    /// int __thiscall CLandBlockInfo::PreFetchCells(CLandBlockInfo*)</code>
    /// </summary>
    public int PreFetchCells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockInfo, int>)0x0052F420)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052F620
    /// void __thiscall CLandBlockInfo::Destroy(CLandBlockInfo*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockInfo, void>)0x0052F620)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052F720
    /// unsigned int __thiscall CLandBlockInfo::pack_size(CLandBlockInfo*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockInfo, uint>)0x0052F720)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052F7C0
    /// unsigned int __thiscall CLandBlockInfo::Pack(CLandBlockInfo*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockInfo, void**, uint, uint>)0x0052F7C0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0052F900
    /// int __thiscall CLandBlockInfo::UnPack(CLandBlockInfo*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockInfo, void**, uint, int>)0x0052F900)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0052FBD0
    /// unsigned int __thiscall CLandBlockInfo::GetRestrictionIID(CLandBlockInfo*,const unsigned int)</code>
    /// </summary>
    public uint GetRestrictionIID(uint landcellid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockInfo, uint, uint>)0x0052FBD0)(ref this, landcellid);
}

