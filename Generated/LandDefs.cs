namespace ACBindings.Internal;


/// <summary>Encapsulates utilities for converting between land cell identifiers, block coordinates, and world‑space positions within a tiled terrain system; provides bounds validation and height table management.</summary>
public unsafe struct LandDefs
{
    // Statics
    public static float** Land_Height_Table = (float**)0x008EEA38;

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

    /// <summary>Determines if a point lies within the land's coordinate limits.
    /// <code>Offset: 0x0043D7F0
    /// int __cdecl LandDefs::in_bounds(int,int)</code>
    /// </summary>
    /// <param name="x">The X-coordinate to test.</param>
    /// <param name="y">The Y-coordinate to test.</param>
    /// <returns>Non-zero when both coordinates are between 0 and 2039 inclusive; zero otherwise.</returns>
    public static int in_bounds(int x, int y) => ((delegate* unmanaged[Cdecl]<int, int, int>)0x0043D7F0)(x, y);

    /// <summary>Converts an encoded block identifier to X and Y coordinates, storing them through the supplied pointers.
    /// <code>Offset: 0x0043D820
    /// int __cdecl LandDefs::blockid_to_lcoord(unsigned int,int*,int*)</code>
    /// </summary>
    /// <param name="block_id">The encoded block identifier from which coordinates are derived.</param>
    /// <param name="x">Pointer to receive the computed X coordinate.</param>
    /// <param name="y">Pointer to receive the computed Y coordinate.</param>
    /// <returns>1 when a valid coordinate pair is produced; 0 if the input id is zero or invalid.</returns>
    public static int blockid_to_lcoord(uint block_id, int* x, int* y) => ((delegate* unmanaged[Cdecl]<uint, int*, int*, int>)0x0043D820)(block_id, x, y);

    /// <summary>Computes the world‑space offset between two block indices, scaling by a unit size of 24 and writing the result into the supplied vector.
    /// <code>Offset: 0x0043E7D0
    /// AC1Legacy::Vector3* __cdecl LandDefs::get_block_offset(AC1Legacy::Vector3*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="result">Pointer to an AC1Legacy::Vector3 where the calculated offset will be stored.</param>
    /// <param name="cell_from">Source cell index.</param>
    /// <param name="cell_to">Destination cell index.</param>
    /// <returns>Returns the same pointer passed in as result, containing a zero vector if both cells share the same high word; otherwise holds the scaled difference between the two positions.</returns>
    public static ACBindings.Internal.AC1Legacy.Vector3* get_block_offset(ACBindings.Internal.AC1Legacy.Vector3* result, uint cell_from, uint cell_to) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.AC1Legacy.Vector3*, uint, uint, ACBindings.Internal.AC1Legacy.Vector3*>)0x0043E7D0)(result, cell_from, cell_to);

    /// <summary>Checks whether a cell identifier falls within allowed ranges and satisfies positional limits.
    /// <code>Offset: 0x00497C80
    /// int __cdecl LandDefs::inbound_valid_cellid(unsigned int)</code>
    /// </summary>
    /// <param name="cell_id">The identifier of the cell to validate.</param>
    /// <returns>Non‑zero if the cell id is valid; zero otherwise.</returns>
    public static int inbound_valid_cellid(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, int>)0x00497C80)(cell_id);

    /// <summary>Converts a global cell ID into local X and Y coordinates within the land definition.
    /// <code>Offset: 0x00497D70
    /// int __cdecl LandDefs::gid_to_lcoord(unsigned int,int*,int*)</code>
    /// </summary>
    /// <param name="cell_id">The identifier of the cell to convert.</param>
    /// <param name="x">Pointer receiving the calculated X coordinate.</param>
    /// <param name="y">Pointer receiving the calculated Y coordinate.</param>
    /// <returns>Non-zero if conversion succeeded; zero otherwise.</returns>
    public static int gid_to_lcoord(uint cell_id, int* x, int* y) => ((delegate* unmanaged[Cdecl]<uint, int*, int*, int>)0x00497D70)(cell_id, x, y);

    /// <summary>Converts tile coordinates (x, y) into a global ID used by the land definition system.
    /// <code>Offset: 0x004A1CD0
    /// unsigned int __cdecl LandDefs::lcoord_to_gid(int,int)</code>
    /// </summary>
    /// <param name="x">The X coordinate of the tile.</param>
    /// <param name="y">The Y coordinate of the tile.</param>
    /// <returns>The computed global ID, or 0 if the coordinates are outside the valid range [0, 2039].</returns>
    public static uint lcoord_to_gid(int x, int y) => ((delegate* unmanaged[Cdecl]<int, int, uint>)0x004A1CD0)(x, y);

    /// <summary>Computes a block identifier from two coordinate values, stores it in the supplied unsigned integer pointer, and returns that pointer; if either coordinate lies outside the valid range, zero is stored instead.
    /// <code>Offset: 0x00505D80
    /// unsigned int* __cdecl LandDefs::get_block_did(unsigned int*,int,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to an unsigned int where the computed block ID will be written.</param>
    /// <param name="a2">Horizontal coordinate value (e.g., X), must be between 0 and 2039 inclusive.</param>
    /// <param name="a3">Vertical coordinate value (e.g., Z or Y), must be between 0 and 2039 inclusive.</param>
    /// <returns>Pointer to the output parameter containing the block ID, which is zero when the coordinates are invalid.</returns>
    public static uint* get_block_did(uint* a1, int a2, int a3) => ((delegate* unmanaged[Cdecl]<uint*, int, int, uint*>)0x00505D80)(a1, a2, a3);

    /// <summary>Checks whether the point represented by the vector lies within the bounds of the land block, accounting for a margin defined by radius.
    /// <code>Offset: 0x0050F2D0
    /// int __cdecl LandDefs::within_block(const AC1Legacy::Vector3*,float)</code>
    /// </summary>
    /// <param name="vc">The position vector to test against the block boundaries.</param>
    /// <param name="radius">Margin distance from the block edges that must be maintained.</param>
    /// <returns>Non-zero if the point is inside the block; zero otherwise.</returns>
    public static int within_block(ACBindings.Internal.AC1Legacy.Vector3* vc, float radius) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.AC1Legacy.Vector3*, float, int>)0x0050F2D0)(vc, radius);

    /// <summary>
    /// Provides default land parameters including grid size, cell dimensions and environmental limits.
    /// 
    /// <code>Offset: 0x005AAA30
    /// void __cdecl LandDefs::get_vars(int*,int*,float*,int*,int*,float*,float*,float*)</code>
    /// </summary>
    /// <param name="height">The number of terrain cells along the vertical axis.</param>
    /// <param name="width">The number of terrain cells along the horizontal axis.</param>
    /// <param name="cell_size">Size of a single cell in world units.</param>
    /// <param name="cells_per_block">Number of cells that form one block for rendering or collision purposes.</param>
    /// <param name="cell_sub_divide">Subdivision factor applied to each cell when generating detailed geometry.</param>
    /// <param name="max_obj_height">Maximum height allowed for objects placed on the land.</param>
    /// <param name="sky_height">Height at which the sky or horizon is rendered relative to the ground plane.</param>
    /// <param name="road_width">Width of roads in world units.</param>
    public static void get_vars(int* height, int* width, float* cell_size, int* cells_per_block, int* cell_sub_divide, float* max_obj_height, float* sky_height, float* road_width) => ((delegate* unmanaged[Cdecl]<int*, int*, float*, int*, int*, float*, float*, float*, void>)0x005AAA30)(height, width, cell_size, cells_per_block, cell_sub_divide, max_obj_height, sky_height, road_width);

    /// <summary>Copies up to 256 height values from the supplied array into the internal land height table, validating each entry is between 0 and 800 inclusive.
    /// <code>Offset: 0x005AAA90
    /// int __cdecl LandDefs::set_height_table(float*)</code>
    /// </summary>
    /// <param name="height_table">Pointer to an array of float heights to be copied.</param>
    /// <returns>1 if all 256 entries were successfully processed; otherwise 0 when encountering invalid data or insufficient input length.</returns>
    public static int set_height_table(float* height_table) => ((delegate* unmanaged[Cdecl]<float*, int>)0x005AAA90)(height_table);

    /// <summary>Computes the heading angle (in radians) for a specified direction relative to the viewer. The function maps each enum value to its corresponding compass bearing using standard trigonometric angles.
    /// <code>Offset: 0x005AAAE0
    /// float __cdecl LandDefs::heading(LandDefs::Direction)</code>
    /// </summary>
    /// <param name="dir">The direction relative to the viewer (e.g., NORTHWEST_OF_VIEWER).</param>
    /// <returns>The heading in radians; returns 0 if an unrecognized direction is supplied.</returns>
    public static float heading(ACBindings.Internal.LandDefs.Direction dir) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.LandDefs.Direction, float>)0x005AAAE0)(dir);

    /// <summary>Determines the relative direction between two points by evaluating the signs of the x and y offsets.
    /// <code>Offset: 0x005AAB50
    /// LandDefs::Direction __cdecl LandDefs::get_dir(int,int)</code>
    /// </summary>
    /// <param name="ix">Horizontal offset from the reference point.</param>
    /// <param name="iy">Vertical offset from the reference point.</param>
    /// <returns>The enum value representing the calculated direction.</returns>
    public static ACBindings.Internal.LandDefs.Direction get_dir(int ix, int iy) => ((delegate* unmanaged[Cdecl]<int, int, ACBindings.Internal.LandDefs.Direction>)0x005AAB50)(ix, iy);

    /// <summary>Transforms a land block ID and local position into global grid coordinates, validating that the result lies within map bounds.
    /// <code>Offset: 0x005AABB0
    /// int __cdecl LandDefs::get_outside_lcoord(unsigned int,const AC1Legacy::Vector3*,int*,int*)</code>
    /// </summary>
    /// <param name="cell_id">Identifier of the land block to convert.</param>
    /// <param name="loc">Pointer to a 3D vector representing a point relative to the block.</param>
    /// <param name="x">Receives the computed global X coordinate.</param>
    /// <param name="y">Receives the computed global Y coordinate.</param>
    /// <returns>Non‑zero if the calculated coordinates are within [0, 2040); zero otherwise.</returns>
    public static int get_outside_lcoord(uint cell_id, ACBindings.Internal.AC1Legacy.Vector3* loc, int* x, int* y) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.AC1Legacy.Vector3*, int*, int*, int>)0x005AABB0)(cell_id, loc, x, y);

    /// <summary>Adjusts a position vector and its associated cell ID to an outside coordinate system, normalizing coordinates near zero and mapping them to new block‑aligned values.
    /// <code>Offset: 0x005AAC70
    /// int __cdecl LandDefs::adjust_to_outside(unsigned int*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="cell_id">Pointer to the cell identifier that will be updated based on the adjusted location; set to 0 if adjustment fails.</param>
    /// <param name="loc">Pointer to a Vector3 representing the position; coordinates are modified in place to align with block boundaries and remove negligible offsets.</param>
    /// <returns>Integer 1 for success, 0 if the provided cell ID is invalid or conversion cannot be performed.</returns>
    public static int adjust_to_outside(uint* cell_id, ACBindings.Internal.AC1Legacy.Vector3* loc) => ((delegate* unmanaged[Cdecl]<uint*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x005AAC70)(cell_id, loc);

    /// <summary>Converts a cell ID into a human‑readable coordinate string formatted as “{distance}N/S, {distance}E/W”.
    /// <code>Offset: 0x005AAD60
    /// int* __cdecl LandDefs::CellidToCoordinateString(int*,unsigned int)</code>
    /// </summary>
    /// <param name="a1">Pointer to an integer buffer that will receive the address of the newly created C‑style string.</param>
    /// <param name="cell_id">Identifier of the cell whose coordinates are to be converted.</param>
    /// <returns>Returns the same pointer passed in as a1, now pointing to the formatted coordinate string.</returns>
    public static int* CellidToCoordinateString(int* a1, uint cell_id) => ((delegate* unmanaged[Cdecl]<int*, uint, int*>)0x005AAD60)(a1, cell_id);
}

