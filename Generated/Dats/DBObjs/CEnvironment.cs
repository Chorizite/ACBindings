namespace ACBindings;

// CEnvironment
public unsafe struct CEnvironment
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // CEnvironment_vtbl
    public unsafe struct CEnvironment_vtbl
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
    public uint num_cells;
    public ACBindings.CCellStruct* cells;

    // Methods
    // DBObj* __cdecl CEnvironment::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7C00)();
    // CCellStruct* __thiscall CEnvironment::get_cellstruct(CEnvironment*,unsigned int)
    public ACBindings.CCellStruct* get_cellstruct(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvironment, uint, ACBindings.CCellStruct*>)0x00531930)(ref this, index);
    // unsigned int __thiscall CEnvironment::pack_size(CEnvironment*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvironment, uint>)0x00531940)(ref this);
    // unsigned int __thiscall CEnvironment::Pack(CEnvironment*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvironment, void**, uint, uint>)0x005319D0)(ref this, addr, size);
    // int __thiscall CEnvironment::UnPack(CEnvironment*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvironment, void**, uint, int>)0x00531A30)(ref this, addr, size);
    // void __thiscall CEnvironment::Destroy(CEnvironment*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnvironment, void>)0x00531AE0)(ref this);
}

