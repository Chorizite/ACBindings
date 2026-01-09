namespace ACBindings;

// CSetup
public unsafe struct CSetup
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Child Types
    // CSetup_vtbl
    public unsafe struct CSetup_vtbl
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
    public uint num_parts;
    public ACBindings.IDClass___tagDataID* parts;
    public uint* parent_index;
    public ACBindings.AC1Legacy.Vector3* default_scale;
    public uint num_cylsphere;
    public ACBindings.CCylSphere* cylsphere;
    public uint num_sphere;
    public ACBindings.CSphere* sphere;
    public int has_physics_bsp;
    public int allow_free_heading;
    public float height;
    public float radius;
    public float step_down_height;
    public float step_up_height;
    public ACBindings.CSphere sorting_sphere;
    public ACBindings.CSphere selection_sphere;
    public uint num_lights;
    public ACBindings.LIGHTINFO* lights;
    public ACBindings.AC1Legacy.Vector3 anim_scale;
    public ACBindings.LongHash__LocationType* holding_locations;
    public ACBindings.LongHash__LocationType* connection_points;
    public ACBindings.LongHash__PlacementType placement_frames;
    public ACBindings.IDClass___tagDataID default_anim_id;
    public ACBindings.IDClass___tagDataID default_script_id;
    public ACBindings.IDClass___tagDataID default_mtable_id;
    public ACBindings.IDClass___tagDataID default_stable_id;
    public ACBindings.IDClass___tagDataID default_phstable_id;

    // Generated Constructor
    public CSetup() {
        _ConstructorInternal();
    }

    // Methods
    // DBObj* __cdecl CSetup::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7B50)();
    // bool __thiscall CSetup::GetSubDataIDs(CSetup*,QualifiedDataIDArray*)
    public byte GetSubDataIDs(ACBindings.QualifiedDataIDArray* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSetup, ACBindings.QualifiedDataIDArray*, byte>)0x005208B0)(ref this, a2);
    // CSetup* __thiscall CSetup::CSetup(CSetup*)
    public ACBindings.CSetup* _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSetup, ACBindings.CSetup*>)0x00520A00)(ref this);
    // CSetup* __cdecl CSetup::makeSimpleSetup(int)
    public static ACBindings.CSetup* makeSimpleSetup(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.CSetup*>)0x00520BB0)(a1);
    // CSetup* __cdecl CSetup::makeParticleSetup(unsigned int)
    public static ACBindings.CSetup* makeParticleSetup(uint a1) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.CSetup*>)0x00520D10)(a1);
    // int __thiscall CSetup::pack_size(CSetup*)
    public int pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSetup, int>)0x00520D40)(ref this);
    // unsigned int __thiscall CSetup::Pack(CSetup*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSetup, void**, uint, uint>)0x005210A0)(ref this, addr, size);
    // int __thiscall CSetup::UnPack(CSetup*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSetup, void**, uint, int>)0x00521770)(ref this, addr, size);
    // int __thiscall CSetup::GetHoldingLocation(CSetup*,unsigned int)
    public int GetHoldingLocation(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSetup, uint, int>)0x00521F10)(ref this, a2);
    // unsigned int __thiscall CSetup::Destroy(void**)
    public uint Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSetup, uint>)0x00521F60)(ref this);
}

