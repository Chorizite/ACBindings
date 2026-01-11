namespace ACBindings.Internal;

public unsafe struct CRegionDesc
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Statics
    public static ACBindings.Internal.CRegionDesc* current_region = (ACBindings.Internal.CRegionDesc*)0x0084247C;

    // Child Types
    public unsafe struct CRegionDesc_vtbl
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
    public uint region_number;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte region_name;
    public uint version;
    public int minimize_pal;
    public uint parts_mask;
    public ACBindings.Internal.FileNameDesc* file_info;
    public ACBindings.Internal.SkyDesc* sky_info;
    public ACBindings.Internal.CSoundDesc* sound_info;
    public ACBindings.Internal.CSceneDesc* scene_info;
    public ACBindings.Internal.CTerrainDesc* terrain_info;
    public ACBindings.Internal.CEncounterDesc* encounter_info;
    public System.IntPtr water_info;
    public System.IntPtr fog_info;
    public System.IntPtr dist_fog_info;
    public System.IntPtr region_map_info;
    public ACBindings.Internal.RegionMisc* region_misc;

    // Generated Constructor
    public CRegionDesc(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F7DE0
    /// DBObj* __cdecl CRegionDesc::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7DE0)();

    /// <summary>
    /// <code>Offset: 0x004FF370
    /// bool __cdecl CRegionDesc::SetRegion(unsigned int)</code>
    /// </summary>
    public static byte SetRegion(uint region_num) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x004FF370)(region_num);

    /// <summary>
    /// <code>Offset: 0x004FF3B0
    /// void __cdecl CRegionDesc::RemoveCurrentRegion()</code>
    /// </summary>
    public static void RemoveCurrentRegion() => ((delegate* unmanaged[Cdecl]<void>)0x004FF3B0)();

    /// <summary>
    /// <code>Offset: 0x004FF3E0
    /// unsigned int __thiscall CRegionDesc::NumSceneType(CRegionDesc*,unsigned int)</code>
    /// </summary>
    public uint NumSceneType(uint terrain_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, uint, uint>)0x004FF3E0)(ref this, terrain_id);

    /// <summary>
    /// <code>Offset: 0x004FF3F0
    /// unsigned int __thiscall CRegionDesc::SceneCount(CRegionDesc*,unsigned int,unsigned int)</code>
    /// </summary>
    public uint SceneCount(uint terrain_id, uint scene_type_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, uint, uint, uint>)0x004FF3F0)(ref this, terrain_id, scene_type_id);

    /// <summary>
    /// <code>Offset: 0x004FF400
    /// int __thiscall CRegionDesc::IsPalShifted(CRegionDesc*)</code>
    /// </summary>
    public int IsPalShifted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, int>)0x004FF400)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FF420
    /// void __cdecl CRegionDesc::CalcDayGroup()</code>
    /// </summary>
    public static void CalcDayGroup() => ((delegate* unmanaged[Cdecl]<void>)0x004FF420)();

    /// <summary>
    /// <code>Offset: 0x004FF440
    /// int __cdecl CRegionDesc::GetLighting(float,float*,RGBAUnion*,AC1Legacy::Vector3*,RGBAUnion*)</code>
    /// </summary>
    public static int GetLighting(float time_of_day, float* ambient, ACBindings.Internal.RGBAUnion* amb_color, ACBindings.Internal.AC1Legacy.Vector3* directional, ACBindings.Internal.RGBAUnion* dir_color) => ((delegate* unmanaged[Cdecl]<float, float*, ACBindings.Internal.RGBAUnion*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.RGBAUnion*, int>)0x004FF440)(time_of_day, ambient, amb_color, directional, dir_color);

    /// <summary>
    /// <code>Offset: 0x004FF480
    /// int __cdecl CRegionDesc::GetWorldFog(float,float*,float*,RGBAUnion*)</code>
    /// </summary>
    public static int GetWorldFog(float time_of_day, float* min, float* max, ACBindings.Internal.RGBAUnion* color) => ((delegate* unmanaged[Cdecl]<float, float*, float*, ACBindings.Internal.RGBAUnion*, int>)0x004FF480)(time_of_day, min, max, color);

    /// <summary>
    /// <code>Offset: 0x004FF4B0
    /// int __cdecl CRegionDesc::GetSky(float,int)</code>
    /// </summary>
    public static int GetSky(float a1, int a2) => ((delegate* unmanaged[Cdecl]<float, int, int>)0x004FF4B0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x004FF530
    /// AmbientSTBDesc* __thiscall CRegionDesc::GetSTBDesc(CRegionDesc*,unsigned int,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.AmbientSTBDesc* GetSTBDesc(uint terrain_id, uint scene_type_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, uint, uint, ACBindings.Internal.AmbientSTBDesc*>)0x004FF530)(ref this, terrain_id, scene_type_id);

    /// <summary>
    /// <code>Offset: 0x004FF570
    /// IDClass&lt;_tagDataID,32,0&gt;* __thiscall CRegionDesc::GetScene(_DWORD**,IDClass&lt;_tagDataID,32,0&gt;*,int,int,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.IDClass____tagDataID* GetScene(ACBindings.Internal.IDClass____tagDataID* a2, int a3, int a4, uint a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, ACBindings.Internal.IDClass____tagDataID*, int, int, uint, ACBindings.Internal.IDClass____tagDataID*>)0x004FF570)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x004FF6E0
    /// int __thiscall CRegionDesc::CRegionDesc(int,void**)</code>
    /// </summary>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, void**, int>)0x004FF6E0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004FF770
    /// void __thiscall CRegionDesc::Destroy(CRegionDesc*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, void>)0x004FF770)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FF840
    /// void __thiscall CRegionDesc::GetSubDataIDs(CRegionDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x004FF840)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x004FF8D0
    /// unsigned int __thiscall CRegionDesc::pack_size(CRegionDesc*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, uint>)0x004FF8D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FF970
    /// unsigned int __thiscall CRegionDesc::Pack(CRegionDesc*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, void**, uint, uint>)0x004FF970)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x004FFEC0
    /// int __thiscall CRegionDesc::UnPack(CRegionDesc*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, void**, uint, int>)0x004FFEC0)(ref this, addr, size);
}

