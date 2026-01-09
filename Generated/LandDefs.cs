namespace ACBindings;

// LandDefs
public unsafe struct LandDefs
{
    // Statics
    public static float* Land_Height_Table = (float*)0x008EEA38;

    // Child Types
    // LandDefs::Direction
    public enum Direction : uint
    {
        IN_VIEWER_BLOCK = 0x0,
        NORTH_OF_VIEWER = 0x1,
        SOUTH_OF_VIEWER = 0x2,
        EAST_OF_VIEWER = 0x3,
        WEST_OF_VIEWER = 0x4,
        NORTHWEST_OF_VIEWER = 0x5,
        SOUTHWEST_OF_VIEWER = 0x6,
        NORTHEAST_OF_VIEWER = 0x7,
        SOUTHEAST_OF_VIEWER = 0x8,
        UNKNOWN = 0x9,
        FORCE_Direction_32_BIT = 0x7FFFFFFF
    }
    // LandDefs::PalType
    public enum PalType : uint
    {
        SWTerrain = 0x0,
        SETerrain = 0x1,
        NETerrain = 0x2,
        NWTerrain = 0x3,
        Road = 0x4,
        FORCE_PalType_32_BIT = 0x7FFFFFFF
    }
    // LandDefs::Rotation
    public enum Rotation : uint
    {
        ROT_0 = 0x0,
        ROT_90 = 0x1,
        ROT_180 = 0x2,
        ROT_270 = 0x3,
        FORCE_Rotation_32_BIT = 0x7FFFFFFF
    }
    // LandDefs::TerrainType
    public enum TerrainType : uint
    {
        BarrenRock = 0x0,
        Grassland = 0x1,
        Ice = 0x2,
        LushGrass = 0x3,
        MarshSparseSwamp = 0x4,
        MudRichDirt = 0x5,
        ObsidianPlain = 0x6,
        PackedDirt = 0x7,
        PatchyDirt = 0x8,
        PatchyGrassland = 0x9,
        SandYellow = 0xA,
        SandGrey = 0xB,
        SandRockStrewn = 0xC,
        SedimentaryRock = 0xD,
        SemiBarrenRock = 0xE,
        Snow = 0xF,
        WaterRunning = 0x10,
        WaterStandingFresh = 0x11,
        WaterShallowSea = 0x12,
        WaterShallowStillSea = 0x13,
        WaterDeepSea = 0x14,
        Reserved21 = 0x15,
        Reserved22 = 0x16,
        Reserved23 = 0x17,
        Reserved24 = 0x18,
        Reserved25 = 0x19,
        Reserved26 = 0x1A,
        Reserved27 = 0x1B,
        Reserved28 = 0x1C,
        Reserved29 = 0x1D,
        Reserved30 = 0x1E,
        Reserved31 = 0x1F,
        RoadType = 0x20,
        FORCE_TerrainType_32_BIT = 0x7FFFFFFF
    }
    // LandDefs::WaterType
    public enum WaterType : uint
    {
        NOT_WATER = 0x0,
        PARTIALLY_WATER = 0x1,
        ENTIRELY_WATER = 0x2,
        FORCE_WaterType_32_BIT = 0x7FFFFFFF
    }

    // Methods
    // int __cdecl LandDefs::in_bounds(int,int)
    public static int in_bounds(int x, int y) => ((delegate* unmanaged[Cdecl]<int, int, int>)0x0043D7F0)(x, y);
    // int __cdecl LandDefs::blockid_to_lcoord(unsigned int,int*,int*)
    public static int blockid_to_lcoord(uint block_id, int* x, int* y) => ((delegate* unmanaged[Cdecl]<uint, int*, int*, int>)0x0043D820)(block_id, x, y);
    // AC1Legacy::Vector3* __cdecl LandDefs::get_block_offset(AC1Legacy::Vector3*,unsigned int,unsigned int)
    public static ACBindings.AC1Legacy.Vector3* get_block_offset(ACBindings.AC1Legacy.Vector3* result, uint cell_from, uint cell_to) => ((delegate* unmanaged[Cdecl]<ACBindings.AC1Legacy.Vector3*, uint, uint, ACBindings.AC1Legacy.Vector3*>)0x0043E7D0)(result, cell_from, cell_to);
    // int __cdecl LandDefs::inbound_valid_cellid(unsigned int)
    public static int inbound_valid_cellid(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, int>)0x00497C80)(cell_id);
    // int __cdecl LandDefs::gid_to_lcoord(unsigned int,int*,int*)
    public static int gid_to_lcoord(uint cell_id, int* x, int* y) => ((delegate* unmanaged[Cdecl]<uint, int*, int*, int>)0x00497D70)(cell_id, x, y);
    // unsigned int __cdecl LandDefs::lcoord_to_gid(int,int)
    public static uint lcoord_to_gid(int x, int y) => ((delegate* unmanaged[Cdecl]<int, int, uint>)0x004A1CD0)(x, y);
    // unsigned int* __cdecl LandDefs::get_block_did(unsigned int*,int,int)
    public static uint* get_block_did(uint* a1, int a2, int a3) => ((delegate* unmanaged[Cdecl]<uint*, int, int, uint*>)0x00505D80)(a1, a2, a3);
    // int __cdecl LandDefs::within_block(const AC1Legacy::Vector3*,float)
    public static int within_block(ACBindings.AC1Legacy.Vector3* vc, float radius) => ((delegate* unmanaged[Cdecl]<ACBindings.AC1Legacy.Vector3*, float, int>)0x0050F2D0)(vc, radius);
    // void __cdecl LandDefs::get_vars(int*,int*,float*,int*,int*,float*,float*,float*)
    public static void get_vars(int* height, int* width, float* cell_size, int* cells_per_block, int* cell_sub_divide, float* max_obj_height, float* sky_height, float* road_width) => ((delegate* unmanaged[Cdecl]<int*, int*, float*, int*, int*, float*, float*, float*, void>)0x005AAA30)(height, width, cell_size, cells_per_block, cell_sub_divide, max_obj_height, sky_height, road_width);
    // int __cdecl LandDefs::set_height_table(float*)
    public static int set_height_table(float* height_table) => ((delegate* unmanaged[Cdecl]<float*, int>)0x005AAA90)(height_table);
    // float __cdecl LandDefs::heading(LandDefs::Direction)
    public static float heading(ACBindings.LandDefs.Direction dir) => ((delegate* unmanaged[Cdecl]<ACBindings.LandDefs.Direction, float>)0x005AAAE0)(dir);
    // LandDefs::Direction __cdecl LandDefs::get_dir(int,int)
    public static ACBindings.LandDefs.Direction get_dir(int ix, int iy) => ((delegate* unmanaged[Cdecl]<int, int, ACBindings.LandDefs.Direction>)0x005AAB50)(ix, iy);
    // int __cdecl LandDefs::get_outside_lcoord(unsigned int,const AC1Legacy::Vector3*,int*,int*)
    public static int get_outside_lcoord(uint cell_id, ACBindings.AC1Legacy.Vector3* loc, int* x, int* y) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.AC1Legacy.Vector3*, int*, int*, int>)0x005AABB0)(cell_id, loc, x, y);
    // int __cdecl LandDefs::adjust_to_outside(unsigned int*,AC1Legacy::Vector3*)
    public static int adjust_to_outside(uint* cell_id, ACBindings.AC1Legacy.Vector3* loc) => ((delegate* unmanaged[Cdecl]<uint*, ACBindings.AC1Legacy.Vector3*, int>)0x005AAC70)(cell_id, loc);
    // int* __cdecl LandDefs::CellidToCoordinateString(int*,unsigned int)
    public static int* CellidToCoordinateString(int* a1, uint cell_id) => ((delegate* unmanaged[Cdecl]<int*, uint, int*>)0x005AAD60)(a1, cell_id);
}

