namespace ACBindings;

// GfxObjDegradeInfo
public unsafe struct GfxObjDegradeInfo
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // GfxObjDegradeInfo_vtbl
    public unsafe struct GfxObjDegradeInfo_vtbl
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
    public uint num_degrades;
    public ACBindings.GfxObjInfo* degrades;

    // Methods
    // DBObj* __cdecl GfxObjDegradeInfo::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7DA0)();
    // unsigned int __thiscall GfxObjDegradeInfo::GetDBOType(GfxObjDegradeInfo*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GfxObjDegradeInfo, uint>)0x0051EDD0)(ref this);
    // void __thiscall GfxObjDegradeInfo::Destroy(GfxObjDegradeInfo*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GfxObjDegradeInfo, void>)0x0051EE20)(ref this);
    // unsigned int __thiscall GfxObjDegradeInfo::Pack(GfxObjDegradeInfo*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GfxObjDegradeInfo, void**, uint, uint>)0x0051EE50)(ref this, addr, size);
    // int __thiscall GfxObjDegradeInfo::UnPack(GfxObjDegradeInfo*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GfxObjDegradeInfo, void**, uint, int>)0x0051EF10)(ref this, addr, size);
    // void __thiscall GfxObjDegradeInfo::get_degrade(GfxObjDegradeInfo*,float,unsigned int*,int*)
    public void get_degrade(float distance, uint* deg_index, int* deg_mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GfxObjDegradeInfo, float, uint*, int*, void>)0x0051EFC0)(ref this, distance, deg_index, deg_mode);
    // void __thiscall GfxObjDegradeInfo::GetSubDataIDs(GfxObjDegradeInfo*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GfxObjDegradeInfo, ACBindings.QualifiedDataIDArray*, void>)0x0051F140)(ref this, id_array);
}

