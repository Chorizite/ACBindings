namespace ACBindings.Internal;

public unsafe struct CSetup
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct CSetup_vtbl
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
    public uint num_parts;
    public ACBindings.Internal.IDClass____tagDataID* parts;
    public uint* parent_index;
    public ACBindings.Internal.AC1Legacy.Vector3* default_scale;
    public uint num_cylsphere;
    public ACBindings.Internal.CCylSphere* cylsphere;
    public uint num_sphere;
    public ACBindings.Internal.CSphere* sphere;
    public int has_physics_bsp;
    public int allow_free_heading;
    public float height;
    public float radius;
    public float step_down_height;
    public float step_up_height;
    public ACBindings.Internal.CSphere sorting_sphere;
    public ACBindings.Internal.CSphere selection_sphere;
    public uint num_lights;
    public ACBindings.Internal.LIGHTINFO* lights;
    public ACBindings.Internal.AC1Legacy.Vector3 anim_scale;
    public ACBindings.Internal.LongHash___LocationType* holding_locations;
    public ACBindings.Internal.LongHash___LocationType* connection_points;
    public ACBindings.Internal.LongHash___PlacementType placement_frames;
    public ACBindings.Internal.IDClass____tagDataID default_anim_id;
    public ACBindings.Internal.IDClass____tagDataID default_script_id;
    public ACBindings.Internal.IDClass____tagDataID default_mtable_id;
    public ACBindings.Internal.IDClass____tagDataID default_stable_id;
    public ACBindings.Internal.IDClass____tagDataID default_phstable_id;

    // Generated Constructor
    public CSetup() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F7B50
    /// DBObj* __cdecl CSetup::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7B50)();

    /// <summary>
    /// <code>Offset: 0x005208B0
    /// bool __thiscall CSetup::GetSubDataIDs(CSetup*,QualifiedDataIDArray*)</code>
    /// </summary>
    public byte GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSetup, ACBindings.Internal.QualifiedDataIDArray*, byte>)0x005208B0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00520A00
    /// CSetup* __thiscall CSetup::CSetup(CSetup*)</code>
    /// </summary>
    public ACBindings.Internal.CSetup* _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSetup, ACBindings.Internal.CSetup*>)0x00520A00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00520BB0
    /// CSetup* __cdecl CSetup::makeSimpleSetup(int)</code>
    /// </summary>
    public static ACBindings.Internal.CSetup* makeSimpleSetup(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.CSetup*>)0x00520BB0)(a1);

    /// <summary>
    /// <code>Offset: 0x00520D10
    /// CSetup* __cdecl CSetup::makeParticleSetup(unsigned int)</code>
    /// </summary>
    public static ACBindings.Internal.CSetup* makeParticleSetup(uint a1) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CSetup*>)0x00520D10)(a1);

    /// <summary>
    /// <code>Offset: 0x00520D40
    /// int __thiscall CSetup::pack_size(CSetup*)</code>
    /// </summary>
    public int pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSetup, int>)0x00520D40)(ref this);

    /// <summary>
    /// <code>Offset: 0x005210A0
    /// unsigned int __thiscall CSetup::Pack(CSetup*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSetup, void**, uint, uint>)0x005210A0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00521770
    /// int __thiscall CSetup::UnPack(CSetup*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSetup, void**, uint, int>)0x00521770)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00521F10
    /// int __thiscall CSetup::GetHoldingLocation(CSetup*,unsigned int)</code>
    /// </summary>
    public int GetHoldingLocation(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSetup, uint, int>)0x00521F10)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00521F60
    /// unsigned int __thiscall CSetup::Destroy(void**)</code>
    /// </summary>
    public uint Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSetup, uint>)0x00521F60)(ref this);
}

