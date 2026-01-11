namespace ACBindings.Internal;

public unsafe struct GfxObjDegradeInfo
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct GfxObjDegradeInfo_vtbl
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
    public uint num_degrades;
    public ACBindings.Internal.GfxObjInfo* degrades;

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F7DA0
    /// DBObj* __cdecl GfxObjDegradeInfo::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7DA0)();

    /// <summary>
    /// <code>Offset: 0x0051EDD0
    /// unsigned int __thiscall GfxObjDegradeInfo::GetDBOType(GfxObjDegradeInfo*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GfxObjDegradeInfo, uint>)0x0051EDD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051EE20
    /// void __thiscall GfxObjDegradeInfo::Destroy(GfxObjDegradeInfo*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GfxObjDegradeInfo, void>)0x0051EE20)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051EE50
    /// unsigned int __thiscall GfxObjDegradeInfo::Pack(GfxObjDegradeInfo*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GfxObjDegradeInfo, void**, uint, uint>)0x0051EE50)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0051EF10
    /// int __thiscall GfxObjDegradeInfo::UnPack(GfxObjDegradeInfo*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GfxObjDegradeInfo, void**, uint, int>)0x0051EF10)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0051EFC0
    /// void __thiscall GfxObjDegradeInfo::get_degrade(GfxObjDegradeInfo*,float,unsigned int*,int*)</code>
    /// </summary>
    public void get_degrade(float distance, uint* deg_index, int* deg_mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GfxObjDegradeInfo, float, uint*, int*, void>)0x0051EFC0)(ref this, distance, deg_index, deg_mode);

    /// <summary>
    /// <code>Offset: 0x0051F140
    /// void __thiscall GfxObjDegradeInfo::GetSubDataIDs(GfxObjDegradeInfo*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GfxObjDegradeInfo, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0051F140)(ref this, id_array);
}

