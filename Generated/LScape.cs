namespace ACBindings.Internal;


/// <summary>Handles terrain rendering, block management, lighting and detail surfaces for the active region, coordinating sky updates and view‑dependent visibility.</summary>
public unsafe struct LScape : System.IDisposable
{
    // Statics
    public static byte* m_fFogEnabled = (byte*)0x0081DBF8;
    public static byte* weather_enabled = (byte*)0x0081DBF9;
    public static ACBindings.Internal.RGBAUnion* sunlight_color = (ACBindings.Internal.RGBAUnion*)0x00842778;
    public static ACBindings.Internal.RGBAUnion* ambient_color = (ACBindings.Internal.RGBAUnion*)0x0084277C;
    public static float* ambient_level = (float*)0x00842780;
    public static ACBindings.Internal.RGBAUnion* m_override_fog_color = (ACBindings.Internal.RGBAUnion*)0x00842784;
    public static ACBindings.Internal.RGBAUnion* m_override_ambient_color = (ACBindings.Internal.RGBAUnion*)0x00842788;
    public static double* next_tick = (double*)0x00842798;
    public static double* next_light_tick = (double*)0x008427A0;
    public static byte* m_fAlwaysDaylight = (byte*)0x008427A8;
    public static byte* m_override_enabled = (byte*)0x008427A9;
    public static float* m_override_ambient_level = (float*)0x008427AC;
    public static float* m_override_fog_min = (float*)0x008427B0;
    public static float* m_override_fog_max = (float*)0x008427B4;
    public static float* m_override_transition = (float*)0x008427B8;
    public static ACBindings.Internal.AC1Legacy.Vector3* sunlight = (ACBindings.Internal.AC1Legacy.Vector3*)0x00842950;
    public static float* min_ambient = (float*)0x0084295C;

    // Members
    public int mid_radius;
    public int mid_width;
    public ACBindings.Internal.CLandBlock** land_blocks;
    public ACBindings.Internal.CLandBlock** block_draw_list;
    public uint loaded_cell_id;
    public uint viewer_cell_id;
    public int viewer_b_xoff;
    public int viewer_b_yoff;
    public ACBindings.Internal.GameSky* sky;
    public ACBindings.Internal.CSurface* landscape_detail_surface;
    public ACBindings.Internal.CSurface* environment_detail_surface;
    public ACBindings.Internal.CSurface* building_detail_surface;
    public ACBindings.Internal.CSurface* object_detail_surface;

    // Generated Constructor
    public LScape() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Calculates object lighting based on the current sunlight vector and ambient level.
    /// <code>Offset: 0x00455850
    /// float __cdecl LScape::calc_object_light()</code>
    /// </summary>
    /// <returns>The combined light intensity as a floating-point value.</returns>
    public static float calc_object_light() => ((delegate* unmanaged[Cdecl]<float>)0x00455850)();

    /// <summary>Computes horizontal and vertical block offsets between two cell identifiers and writes them to the supplied pointers.
    /// <code>Offset: 0x005054C0
    /// int __thiscall LScape::get_block_shift(LScape*,unsigned int,unsigned int,int*,int*)</code>
    /// </summary>
    /// <param name="cell_id1">The first cell identifier; must be non‑zero for a valid calculation.</param>
    /// <param name="cell_id2">The second cell identifier. If zero, the offset is calculated relative to an origin cell.</param>
    /// <param name="x_shift">Pointer to an integer that receives the horizontal block offset.</param>
    /// <param name="y_shift">Pointer to an integer that receives the vertical block offset.</param>
    /// <returns>1 if a shift was computed; otherwise 0 when cell_id1 is zero and no calculation occurs.</returns>
    public int get_block_shift(uint cell_id1, uint cell_id2, int* x_shift, int* y_shift) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, uint, uint, int*, int*, int>)0x005054C0)(ref this, cell_id1, cell_id2, x_shift, y_shift);

    /// <summary>
    /// Releases all custom landscape, environment, building, and object detail surfaces owned by the LScape instance and resets corresponding render settings.
    /// 
    /// <code>Offset: 0x00505540
    /// void __thiscall LScape::CleanupDetailSurfaces(LScape*)</code>
    /// </summary>
    public void CleanupDetailSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x00505540)(ref this);

    /// <summary>Releases all resources associated with an LScape instance, clearing land block data and deactivating the sky.
    /// <code>Offset: 0x005055C0
    /// void __thiscall LScape::release_all(LScape*)</code>
    /// </summary>
    /// <param name="this">The LScape object to be cleaned up.</param>
    public void release_all() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x005055C0)(ref this);

    /// <summary>Sets the middle radius of the landscape when no land blocks are loaded and the supplied radius is positive.
    /// <code>Offset: 0x00505660
    /// int __thiscall LScape::SetMidRadius(LScape*,int)</code>
    /// </summary>
    /// <param name="radius">The desired middle radius value.</param>
    /// <returns>1 if the radius was successfully applied; 0 if the radius is invalid or land blocks are already present.</returns>
    public int SetMidRadius(int radius) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, int, int>)0x00505660)(ref this, radius);

    /// <summary>Updates the sky object's position using the supplied Position data when a cell is loaded.
    /// <code>Offset: 0x00505690
    /// void __thiscall LScape::set_sky_position(LScape*,const Position*)</code>
    /// </summary>
    /// <param name="p">The target position for the sky, including cell ID and frame details.</param>
    public void set_sky_position(ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, ACBindings.Internal.Position*, void>)0x00505690)(ref this, p);

    /// <summary>Creates an ordered list of landscape blocks to render around the current viewer position. If the internal draw list has not yet been allocated, it allocates space for 4 × mid_width² block pointers and then fills the array with valid land block references while respecting map boundaries.
    /// <code>Offset: 0x005056B0
    /// void __thiscall LScape::get_block_order(LScape*)</code>
    /// </summary>
    /// <param name="this">The LScape instance whose blocks are being ordered.</param>
    public void get_block_order() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x005056B0)(ref this);

    /// <summary>Iterates over the landscape’s land blocks to initialize buildings and collect visible cells for each block. Then re‑initializes static and dynamic objects across the same grid.
    /// <code>Offset: 0x00505920
    /// void __thiscall LScape::grab_visible_cells(LScape*)</code>
    /// </summary>
    public void grab_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x00505920)(ref this);

    /// <summary>Releases all visible land blocks in the landscape by iterating over its cell grid and invoking each block’s release_visible_cells.
    /// <code>Offset: 0x005059B0
    /// void __thiscall LScape::release_visible_cells(LScape*)</code>
    /// </summary>
    public void release_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x005059B0)(ref this);

    /// <summary>Determines the size and orientation of a landscape block relative to the viewer based on its grid coordinates.
    /// <code>Offset: 0x005059F0
    /// void __thiscall LScape::get_block_orient(LScape*,int,int,int*,LandDefs::Direction*)</code>
    /// </summary>
    /// <param name="ix">X coordinate of the block within the LScape grid.</param>
    /// <param name="iy">Y coordinate of the block within the LScape grid.</param>
    /// <param name="size">Output parameter that receives the calculated block size (1, 2, 4, or 8).</param>
    /// <param name="dir">Output parameter that receives the block's direction relative to the viewer (e.g., NORTH_OF_VIEWER, EAST_OF_VIEWER, etc.).</param>
    public void get_block_orient(int ix, int iy, int* size, ACBindings.Internal.LandDefs.Direction* dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, int, int, int*, ACBindings.Internal.LandDefs.Direction*, void>)0x005059F0)(ref this, ix, iy, size, dir);

    /// <summary>Updates visibility status and static object counts for each cell in a land block by computing clip heights relative to the viewer. If the block is already marked entirely inside, all its cells are set to ENTIRELY_INSIDE; otherwise, individual cells are checked and updated accordingly.
    /// <code>Offset: 0x00505B00
    /// void __thiscall LScape::landcell_check(LScape*,CLandBlock*)</code>
    /// </summary>
    /// <param name="block">The land block whose cells are evaluated and updated.</param>
    public void landcell_check(ACBindings.Internal.CLandBlock* block) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, ACBindings.Internal.CLandBlock*, void>)0x00505B00)(ref this, block);

    /// <summary>Enables or disables constant daylight mode, forcing the environment to update immediately.
    /// <code>Offset: 0x00505D40
    /// void __cdecl LScape::SetDay(int)</code>
    /// </summary>
    /// <param name="on">Non‑zero value turns daylight always on; zero disables it.</param>
    public static void SetDay(int on) => ((delegate* unmanaged[Cdecl]<int, void>)0x00505D40)(on);

    /// <summary>Initializes an LScape instance by resetting land block pointers, setting default spatial parameters (mid_radius = 5, mid_width = 11), configuring ambient light and sunlight vectors, preparing land blocks via CLandBlock::init(), and allocating a GameSky object if memory allocation succeeds.
    /// <code>Offset: 0x00505DD0
    /// void __thiscall LScape::LScape(LScape*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x00505DD0)(ref this);

    /// <summary>Releases all land blocks, deallocates the block interval array, destroys the sky object if present, and cleans up detail surfaces.
    /// <code>Offset: 0x00505E70
    /// void __thiscall LScape::~LScape(LScape*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x00505E70)(ref this);

    /// <summary>Configures the scene’s ambient and sunlight parameters, updating global lighting state and recalculating block shading. If daylight is forced, overrides are fetched from the region descriptor; otherwise supplied vectors and colors are used. When a SmartBox instance exists, it receives an updated world ambient light value.
    /// <code>Offset: 0x00505F30
    /// void __thiscall LScape::set_landscape_lighting(LScape*,float,RGBAUnion,const AC1Legacy::Vector3*,RGBAUnion)</code>
    /// </summary>
    /// <param name="ambient_level">Ambient light intensity to apply across the scene.</param>
    /// <param name="ambient_color">Color of the ambient illumination.</param>
    /// <param name="sunlight">Direction vector for the sun’s light source.</param>
    /// <param name="sunlight_color">Color of sunlight to use when daylight is not forced.</param>
    public void set_landscape_lighting(float ambient_level, ACBindings.Internal.RGBAUnion ambient_color, ACBindings.Internal.AC1Legacy.Vector3* sunlight, ACBindings.Internal.RGBAUnion sunlight_color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, float, ACBindings.Internal.RGBAUnion, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.RGBAUnion, void>)0x00505F30)(ref this, ambient_level, ambient_color, sunlight, sunlight_color);

    /// <summary>Prefetches land block cells within a specified region, loading missing data into cache and counting newly fetched objects.
    /// <code>Offset: 0x005060C0
    /// int __fastcall LScape::PreFetchCells(int,int,unsigned int,_DWORD*)</code>
    /// </summary>
    /// <param name="a1">Pointer to an integer that supplies the base cell coordinate for calculating the prefetch area.</param>
    /// <param name="a2">Unused; retained for binary compatibility.</param>
    /// <param name="a3">Packed unsigned value encoding offset and size information of the region to be prefetched.</param>
    /// <param name="a4">Pointer to an integer that receives the number of cells actually prefetched during this call.</param>
    /// <returns>Non‑zero if all requested cells were already present in cache; zero otherwise.</returns>
    public static int PreFetchCells(int a1, int a2, uint a3, int* a4) => ((delegate* unmanaged[Fastcall]<int, int, uint, int*, int>)0x005060C0)(a1, a2, a3, a4);

    /// <summary>Iterates over the landscape's mid-width grid of land blocks; for each block whose size equals one, invokes its ambient sound addition routine using the supplied Position context.
    /// <code>Offset: 0x00506270
    /// void __thiscall LScape::add_ambient_sounds(LScape*,Position*)</code>
    /// </summary>
    /// <param name="a2">Position used as a reference point for adding ambient sounds to applicable land blocks.</param>
    public void add_ambient_sounds(ACBindings.Internal.Position* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, ACBindings.Internal.Position*, void>)0x00506270)(ref this, a2);

    /// <summary>Updates lighting, fog, and sky effects for the landscape based on the current game time and region data, applying any active overrides.
    /// <code>Offset: 0x005062E0
    /// void __thiscall LScape::UseTime(LScape*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x005062E0)(ref this);

    /// <summary>Computes the draw order for each land block relative to a specified cell, updating viewer offsets and optionally recomputing block ordering.
    /// <code>Offset: 0x005066D0
    /// void __thiscall LScape::calc_draw_order(LScape*,unsigned int,int)</code>
    /// </summary>
    /// <param name="cell_id">Identifier of the cell used to determine the viewer’s coordinates; if zero, the function exits without action.</param>
    /// <param name="calc_block_order">Flag indicating whether to recalculate the overall block order before processing individual blocks.</param>
    public void calc_draw_order(uint cell_id, int calc_block_order) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, uint, int, void>)0x005066D0)(ref this, cell_id, calc_block_order);

    /// <summary>Retrieves the database object corresponding to the supplied identifier, initializing or clearing its load flags based on that identifier.
    /// <code>Offset: 0x00506830
    /// DBObj* __stdcall LScape::get_all(unsigned int)</code>
    /// </summary>
    /// <param name="a1">Identifier used to locate the desired DBObj; zero indicates no load flag manipulation.</param>
    /// <returns>The matching DBObj if found; otherwise null.</returns>
    public static ACBindings.Internal.DBObj* get_all(uint a1) => ((delegate* unmanaged[Stdcall]<uint, ACBindings.Internal.DBObj*>)0x00506830)(a1);

    /// <summary>Retrieves the land block associated with the specified cell identifier after validating coordinates and ensuring it lies within the loaded region.
    /// <code>Offset: 0x005068A0
    /// CLandBlock* __thiscall LScape::get_landblock(LScape*,unsigned int)</code>
    /// </summary>
    /// <param name="cell_id">Identifier of the cell whose land block is requested.</param>
    /// <returns>A pointer to the corresponding CLandBlock, or null if the ID is out of bounds or no block exists.</returns>
    public ACBindings.Internal.CLandBlock* get_landblock(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, uint, ACBindings.Internal.CLandBlock*>)0x005068A0)(ref this, cell_id);

    /// <summary>Retrieves the CLandCell located at the given cell identifier within the landscape.
    /// <code>Offset: 0x00506970
    /// CLandCell* __thiscall LScape::get_landcell(LScape*,unsigned int)</code>
    /// </summary>
    /// <param name="cell_id">The unique identifier of the land cell to retrieve.</param>
    /// <returns>A pointer to the requested CLandCell, or nullptr if no such cell exists.</returns>
    public ACBindings.Internal.CLandCell* get_landcell(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, uint, ACBindings.Internal.CLandCell*>)0x00506970)(ref this, cell_id);

    /// <summary>Computes view intervals for landscape blocks in the current viewing area and performs visibility checks against the viewer’s perspective. Clears previous block state, allocates interval buffers as necessary, updates each land cell’s clip bounds based on portal geometry and viewer offsets, then records visible or intersecting cells and triggers additional processing.
    /// <code>Offset: 0x005069E0
    /// void __thiscall LScape::draw_check_blocks(LScape*)</code>
    /// </summary>
    public void draw_check_blocks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x005069E0)(ref this);

    /// <summary>Generates a detail surface for the specified terrain type by retrieving its associated texture and creating a custom CSurface object. Returns null when no matching texture is found or surface creation fails.
    /// <code>Offset: 0x00506C90
    /// CSurface* __thiscall LScape::GenerateDetailSurface(LScape*,unsigned int)</code>
    /// </summary>
    /// <param name="terrain_number">Identifier of the terrain whose detail surface is requested.</param>
    /// <returns>Pointer to the generated CSurface, or nullptr if generation failed.</returns>
    public ACBindings.Internal.CSurface* GenerateDetailSurface(uint terrain_number) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, uint, ACBindings.Internal.CSurface*>)0x00506C90)(ref this, terrain_number);

    /// <summary>Updates the viewport’s current cell and rebuilds drawing order when the viewed area changes; clears rendering data when no valid cell is specified.
    /// <code>Offset: 0x00506D30
    /// void __thiscall LScape::update_viewpoint(LScape*,unsigned int)</code>
    /// </summary>
    /// <param name="cell_id">Identifier of the cell to view, or 0 to reset the viewer state.</param>
    public void update_viewpoint(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, uint, void>)0x00506D30)(ref this, cell_id);

    /// <summary>Renders the landscape by drawing the sky and all visible land blocks, optionally applying weather effects if enabled.
    /// <code>Offset: 0x00506D90
    /// void __thiscall LScape::draw(LScape*)</code>
    /// </summary>
    public void draw() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x00506D90)(ref this);

    /// <summary>Updates the landscape block grid when the viewer moves or a forced refresh occurs, loading new CLandBlock objects and releasing unused ones, then recalculating orientation and lighting for each block.
    /// <code>Offset: 0x00506E00
    /// void __thiscall LScape::update_block(LScape*,unsigned int,int,int,int)</code>
    /// </summary>
    /// <param name="cell_id">Identifier of the current cell that determines which blocks to load.</param>
    /// <param name="x_shift">Horizontal shift (in block units) from the previous viewer position.</param>
    /// <param name="y_shift">Vertical shift (in block units) from the previous viewer position.</param>
    /// <param name="refresh">Non‑zero forces a complete rebuild of the block grid; otherwise only blocks affected by the shift are updated.</param>
    public void update_block(uint cell_id, int x_shift, int y_shift, int refresh) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, uint, int, int, int, void>)0x00506E00)(ref this, cell_id, x_shift, y_shift, refresh);

    /// <summary>Configures detail texturing for landscape, building, environment and object surfaces based on supplied flags. Updates tiling parameters from the current region and creates new surfaces as needed.
    /// <code>Offset: 0x005075A0
    /// bool __thiscall LScape::SetDetailTexturing(LScape*,int,int,int,int)</code>
    /// </summary>
    /// <param name="landscape">If non‑zero, generate or update the landscape detail surface.</param>
    /// <param name="building">If non‑zero, generate or update the building detail surface.</param>
    /// <param name="environment">If non‑zero, generate or update the environment detail surface.</param>
    /// <param name="object">If non‑zero, generate or update the object detail surface.</param>
    /// <returns>True if a current region was available and surfaces were configured; otherwise false.</returns>
    public byte SetDetailTexturing(int landscape, int building, int environment, int object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, int, int, int, int, byte>)0x005075A0)(ref this, landscape, building, environment, object_);

    /// <summary>Updates the region's detail texturing configuration to match the current rendering preferences, applying environment detail textures.
    /// <code>Offset: 0x00507710
    /// void __thiscall LScape::ChangeRegion(LScape*)</code>
    /// </summary>
    public void ChangeRegion() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, void>)0x00507710)(ref this);

    /// <summary>Updates the loaded landscape region for a new cell, loading required blocks and recalculating draw order or releasing all if the cell identifier is zero.
    /// <code>Offset: 0x00507730
    /// void __thiscall LScape::update_loadpoint(LScape*,unsigned int)</code>
    /// </summary>
    /// <param name="cell_id">Identifier of the target cell; zero triggers release of all loaded cells.</param>
    public void update_loadpoint(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LScape, uint, void>)0x00507730)(ref this, cell_id);
}

