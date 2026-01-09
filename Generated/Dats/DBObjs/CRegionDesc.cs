namespace ACBindings;

// CRegionDesc
public unsafe struct CRegionDesc
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Statics
    public static ACBindings.CRegionDesc* current_region = (ACBindings.CRegionDesc*)0x0084247C;

    // Child Types
    // CRegionDesc_vtbl
    public unsafe struct CRegionDesc_vtbl
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
    public uint region_number;
    public ACBindings.AC1Legacy.PStringBase__sbyte region_name;
    public uint version;
    public int minimize_pal;
    public uint parts_mask;
    public ACBindings.FileNameDesc* file_info;
    public ACBindings.SkyDesc* sky_info;
    public ACBindings.CSoundDesc* sound_info;
    public ACBindings.CSceneDesc* scene_info;
    public ACBindings.CTerrainDesc* terrain_info;
    public ACBindings.CEncounterDesc* encounter_info;
    public System.IntPtr water_info;
    public System.IntPtr fog_info;
    public System.IntPtr dist_fog_info;
    public System.IntPtr region_map_info;
    public ACBindings.RegionMisc* region_misc;

    // Generated Constructor
    public CRegionDesc(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods
    // DBObj* __cdecl CRegionDesc::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7DE0)();
    // bool __cdecl CRegionDesc::SetRegion(unsigned int)
    public static byte SetRegion(uint region_num) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x004FF370)(region_num);
    // void __cdecl CRegionDesc::RemoveCurrentRegion()
    public static void RemoveCurrentRegion() => ((delegate* unmanaged[Cdecl]<void>)0x004FF3B0)();
    // unsigned int __thiscall CRegionDesc::NumSceneType(CRegionDesc*,unsigned int)
    public uint NumSceneType(uint terrain_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CRegionDesc, uint, uint>)0x004FF3E0)(ref this, terrain_id);
    // unsigned int __thiscall CRegionDesc::SceneCount(CRegionDesc*,unsigned int,unsigned int)
    public uint SceneCount(uint terrain_id, uint scene_type_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CRegionDesc, uint, uint, uint>)0x004FF3F0)(ref this, terrain_id, scene_type_id);
    // int __thiscall CRegionDesc::IsPalShifted(CRegionDesc*)
    public int IsPalShifted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CRegionDesc, int>)0x004FF400)(ref this);
    // void __cdecl CRegionDesc::CalcDayGroup()
    public static void CalcDayGroup() => ((delegate* unmanaged[Cdecl]<void>)0x004FF420)();
    // int __cdecl CRegionDesc::GetLighting(float,float*,RGBAUnion*,AC1Legacy::Vector3*,RGBAUnion*)
    public static int GetLighting(float time_of_day, float* ambient, ACBindings.RGBAUnion* amb_color, ACBindings.AC1Legacy.Vector3* directional, ACBindings.RGBAUnion* dir_color) => ((delegate* unmanaged[Cdecl]<float, float*, ACBindings.RGBAUnion*, ACBindings.AC1Legacy.Vector3*, ACBindings.RGBAUnion*, int>)0x004FF440)(time_of_day, ambient, amb_color, directional, dir_color);
    // int __cdecl CRegionDesc::GetWorldFog(float,float*,float*,RGBAUnion*)
    public static int GetWorldFog(float time_of_day, float* min, float* max, ACBindings.RGBAUnion* color) => ((delegate* unmanaged[Cdecl]<float, float*, float*, ACBindings.RGBAUnion*, int>)0x004FF480)(time_of_day, min, max, color);
    // int __cdecl CRegionDesc::GetSky(float,int)
    public static int GetSky(float a1, int a2) => ((delegate* unmanaged[Cdecl]<float, int, int>)0x004FF4B0)(a1, a2);
    // AmbientSTBDesc* __thiscall CRegionDesc::GetSTBDesc(CRegionDesc*,unsigned int,unsigned int)
    public ACBindings.AmbientSTBDesc* GetSTBDesc(uint terrain_id, uint scene_type_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CRegionDesc, uint, uint, ACBindings.AmbientSTBDesc*>)0x004FF530)(ref this, terrain_id, scene_type_id);
    // IDClass<_tagDataID,32,0>* __thiscall CRegionDesc::GetScene(_DWORD**,IDClass<_tagDataID,32,0>*,int,int,unsigned int)
    public ACBindings.IDClass___tagDataID* GetScene(ACBindings.IDClass___tagDataID* a2, int a3, int a4, uint a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CRegionDesc, ACBindings.IDClass___tagDataID*, int, int, uint, ACBindings.IDClass___tagDataID*>)0x004FF570)(ref this, a2, a3, a4, a5);
    // int __thiscall CRegionDesc::CRegionDesc(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CRegionDesc, void**, int>)0x004FF6E0)(ref this, a2);
    // void __thiscall CRegionDesc::Destroy(CRegionDesc*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CRegionDesc, void>)0x004FF770)(ref this);
    // void __thiscall CRegionDesc::GetSubDataIDs(CRegionDesc*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CRegionDesc, ACBindings.QualifiedDataIDArray*, void>)0x004FF840)(ref this, id_array);
    // unsigned int __thiscall CRegionDesc::pack_size(CRegionDesc*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CRegionDesc, uint>)0x004FF8D0)(ref this);
    // unsigned int __thiscall CRegionDesc::Pack(CRegionDesc*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CRegionDesc, void**, uint, uint>)0x004FF970)(ref this, addr, size);
    // int __thiscall CRegionDesc::UnPack(CRegionDesc*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CRegionDesc, void**, uint, int>)0x004FFEC0)(ref this, addr, size);
}

