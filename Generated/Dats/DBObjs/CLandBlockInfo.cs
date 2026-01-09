namespace ACBindings;

// CLandBlockInfo
public unsafe struct CLandBlockInfo
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // CLandBlockInfo_vtbl
    public unsafe struct CLandBlockInfo_vtbl
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
    public uint num_objects;
    public System.IntPtr object_ids;
    public ACBindings.Frame* object_frames;
    public uint num_buildings;
    public ACBindings.BuildInfo** buildings;
    public System.IntPtr restriction_table;
    public System.IntPtr cell_ownership;
    public uint num_cells;
    public uint* cell_ids;
    public ACBindings.CEnvCell** cells;

    // Methods
    // DBObj* __cdecl CLandBlockInfo::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7A50)();
    // unsigned int __thiscall CLandBlockInfo::GetDBOType(CLandBlockInfo*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockInfo, uint>)0x005276A0)(ref this);
    // int __thiscall CLandBlockInfo::PreFetchCells(CLandBlockInfo*)
    public int PreFetchCells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockInfo, int>)0x0052F420)(ref this);
    // void __thiscall CLandBlockInfo::Destroy(CLandBlockInfo*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockInfo, void>)0x0052F620)(ref this);
    // unsigned int __thiscall CLandBlockInfo::pack_size(CLandBlockInfo*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockInfo, uint>)0x0052F720)(ref this);
    // unsigned int __thiscall CLandBlockInfo::Pack(CLandBlockInfo*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockInfo, void**, uint, uint>)0x0052F7C0)(ref this, addr, size);
    // int __thiscall CLandBlockInfo::UnPack(CLandBlockInfo*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockInfo, void**, uint, int>)0x0052F900)(ref this, addr, size);
    // unsigned int __thiscall CLandBlockInfo::GetRestrictionIID(CLandBlockInfo*,const unsigned int)
    public uint GetRestrictionIID(uint landcellid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockInfo, uint, uint>)0x0052FBD0)(ref this, landcellid);
}

