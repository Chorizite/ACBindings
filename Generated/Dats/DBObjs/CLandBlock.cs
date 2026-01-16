namespace ACBindings.Internal;


/// <summary>Represents a block of land in the game's spatial partitioning system. Stores terrain elevation bounds, static objects, buildings, and view‑related data to support rendering and physics.</summary>
public unsafe struct CLandBlock
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj
    public ACBindings.Internal.CLandBlockStruct BaseClass_CLandBlockStruct; // ACBindings.Internal.CLandBlockStruct

    // Child Types
    public unsafe struct CLandBlock_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SqCoord block_coord;
    public ACBindings.Internal.Frame block_frame;
    public float max_zval;
    public float min_zval;
    public int dyn_objs_init_done;
    public int lbi_exists;
    public ACBindings.Internal.LandDefs.Direction dir;
    public ACBindings.Internal.SqCoord closest;
    public ACBindings.Internal.BoundingType in_view;
    public ACBindings.Internal.CLandBlockInfo* lbi;
    public uint num_static_objects;
    public ACBindings.Internal.DArray___CPhysicsObj_ptr static_objects;
    public uint num_buildings;
    public ACBindings.Internal.CBuildingObj** buildings;
    public uint stab_num;
    public uint* stablist;
    public ACBindings.Internal.CLandCell** draw_array;
    public uint draw_array_size;

    // Methods

    /// <summary>Allocates memory for a new CLandBlock object, initializes its base classes and member fields, and returns the instance as a DBObj pointer.
    /// <code>Offset: 0x004F7A70
    /// DBObj* __cdecl CLandBlock::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed CLandBlock (as a DBObj). Returns null if allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7A70)();

    /// <summary>Destroys all building objects associated with this land block, removing them from the world and freeing related memory. The method clears internal arrays of buildings and static building indices and resets counters to zero.
    /// <code>Offset: 0x0052FE80
    /// void __thiscall CLandBlock::destroy_buildings(CLandBlock*)</code>
    /// </summary>
    public void destroy_buildings() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x0052FE80)(ref this);

    /// <summary>
    /// Computes the block’s minimum and maximum vertical extents by scanning its height map and applying offsets from the global height table.
    /// 
    /// <code>Offset: 0x0052FF10
    /// void __thiscall CLandBlock::get_land_limits(CLandBlock*)</code>
    /// </summary>
    public void get_land_limits() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x0052FF10)(ref this);

    /// <summary>Serializes a land block into a binary buffer by writing its frame data followed by its packed structure.
    /// <code>Offset: 0x00530000
    /// unsigned int __thiscall CLandBlock::Pack(CLandBlock*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; will be advanced past the written bytes.</param>
    /// <param name="size">Maximum number of bytes available in the buffer. The function writes only if this is sufficient for the required size.</param>
    /// <returns>The total number of bytes that would have been written, including the 4‑byte frame value.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void**, uint, uint>)0x00530000)(ref this, addr, size);

    /// <summary>Restores a CLandBlock instance from serialized data supplied via a buffer pointer.
    /// <code>Offset: 0x00530050
    /// int __thiscall CLandBlock::UnPack(CLandBlock*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current read position within the source buffer; advanced as data is consumed.</param>
    /// <param name="size">The size of the serialized block to unpack.</param>
    /// <returns>Always returns 1 to indicate successful completion.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void**, uint, int>)0x00530050)(ref this, addr, size);

    /// <summary>Releases all objects within the block's cells when the block has nine side vertices, then marks dynamic objects as uninitialized.
    /// <code>Offset: 0x00530090
    /// void __thiscall CLandBlock::release_objs(CLandBlock*)</code>
    /// </summary>
    public void release_objs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x00530090)(ref this);

    /// <summary>Initializes dynamic objects in every cell of the block when the block has eight side cells and they have not been initialized before.
    /// <code>Offset: 0x005300F0
    /// void __thiscall CLandBlock::init_dyn_objs(CLandBlock*)</code>
    /// </summary>
    public void init_dyn_objs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x005300F0)(ref this);

    /// <summary>Initializes each land cell’s back‑reference to this block by iterating over all side cells and assigning the myLandBlock_ pointer.
    /// <code>Offset: 0x00530150
    /// void __thiscall CLandBlock::init_lcell_ptrs(CLandBlock*)</code>
    /// </summary>
    public void init_lcell_ptrs() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x00530150)(ref this);

    /// <summary>Collects and updates the set of land cells that are currently visible within this block, preparing them for rendering or further processing.
    /// <code>Offset: 0x005301A0
    /// void __thiscall CLandBlock::grab_visible_cells(CLandBlock*)</code>
    /// </summary>
    public void grab_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x005301A0)(ref this);

    /// <summary>Releases the land block's visible environment cell references, freeing associated resources.
    /// <code>Offset: 0x005301C0
    /// void __thiscall CLandBlock::release_visible_cells(CLandBlock*)</code>
    /// </summary>
    public void release_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x005301C0)(ref this);

    /// <summary>Calculates and orders the land cells within a block for rendering based on a reference coordinate and viewer direction, updating an internal array of cell pointers. The method reallocates the array if necessary and tracks the closest cell to avoid redundant work.
    /// <code>Offset: 0x005301E0
    /// int __thiscall CLandBlock::calc_sq_draw_order(CLandBlock*,LandDefs::Direction,const SqCoord*)</code>
    /// </summary>
    /// <param name="new_dir">The relative viewing direction (e.g., north, south, east, west) that determines how cells are ordered for drawing.</param>
    /// <param name="coord">A coordinate within the block used as a reference point for computing the ordering of cells.</param>
    /// <returns>Non‑zero if the draw order was recomputed; zero if the existing order remained unchanged.</returns>
    public int calc_sq_draw_order(ACBindings.Internal.LandDefs.Direction new_dir, ACBindings.Internal.SqCoord* coord) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, ACBindings.Internal.LandDefs.Direction, ACBindings.Internal.SqCoord*, int>)0x005301E0)(ref this, new_dir, coord);

    /// <summary>Adds a physics object to the block’s collection of static objects, resizing internal storage if necessary.
    /// <code>Offset: 0x00530650
    /// void __thiscall CLandBlock::add_static_object(CLandBlock*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The CPhysicsObj instance to be stored as a static object within the land block.</param>
    public void add_static_object(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, ACBindings.Internal.CPhysicsObj*, void>)0x00530650)(ref this, object_);

    /// <summary>Removes all static physics objects owned by this land block from the simulation world and performs their cleanup, resetting the static object count to zero.
    /// <code>Offset: 0x00530790
    /// void __thiscall CLandBlock::destroy_static_objects(CLandBlock*)</code>
    /// </summary>
    public void destroy_static_objects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x00530790)(ref this);

    /// <summary>Destroys all objects tied to a land block, frees allocated memory, and resets its internal state.
    /// <code>Offset: 0x005307E0
    /// void __thiscall CLandBlock::Destroy(CLandBlock*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x005307E0)(ref this);

    /// <summary>Resets the land block’s internal state by clearing UV mapping data, setting four float parameters to one, and zeroing three integer counters.
    /// <code>Offset: 0x00530850
    /// void __cdecl CLandBlock::init()</code>
    /// </summary>
    public static void init() => ((delegate* unmanaged[Cdecl]<void>)0x00530850)();

    /// <summary>Retrieves the terrain type index for a specified cell within a land block by evaluating the cell coordinates against the provided world position.
    /// <code>Offset: 0x005308B0
    /// unsigned int __thiscall CLandBlock::get_terrain(CLandBlock*,unsigned int,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="cell_id">Identifier of the target cell relative to the block.</param>
    /// <param name="vc">World-space position used to determine which sub-cell to sample.</param>
    /// <returns>Integer terrain type (0–31) extracted from the block’s terrain data array.</returns>
    public uint get_terrain(uint cell_id, ACBindings.Internal.AC1Legacy.Vector3* vc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, uint, ACBindings.Internal.AC1Legacy.Vector3*, uint>)0x005308B0)(ref this, cell_id, vc);

    /// <summary>Populates the supplied QualifiedDataIDArray with the land block's sub data identifier when the block contains an LBI.
    /// <code>Offset: 0x005309A0
    /// void __thiscall CLandBlock::GetSubDataIDs(CLandBlock*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array to receive the qualified data ID of the block’s LBI, if present.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005309A0)(ref this, id_array);

    /// <summary>Initializes the land block's information by loading a CLandBlockInfo object from the database when the block has an associated info record.
    /// <code>Offset: 0x005309E0
    /// bool __thiscall CLandBlock::InitLoad(CLandBlock*)</code>
    /// </summary>
    /// <returns>True if the block requires no info (lbi_exists is false) or the CLandBlockInfo was successfully retrieved; otherwise, false.</returns>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, byte>)0x005309E0)(ref this);

    /// <summary>Releases all resources for the land block, clearing static objects, visible environment cells, and invoking the base‑class cleanup routine.
    /// <code>Offset: 0x00530A30
    /// void __thiscall CLandBlock::release_all(CLandBlock*)</code>
    /// </summary>
    public void release_all() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x00530A30)(ref this);

    /// <summary>Retrieves a land cell from the block by its global ID, returning NULL when no matching cell exists.
    /// <code>Offset: 0x00530A60
    /// CLandCell* __thiscall CLandBlock::get_landcell(CLandBlock*,unsigned int)</code>
    /// </summary>
    /// <param name="cell_id">The global identifier of the desired land cell.</param>
    /// <returns>A pointer to the CLandCell associated with the specified ID, or nullptr if the ID does not correspond to a stored cell within this block.</returns>
    public ACBindings.Internal.CLandCell* get_landcell(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, uint, ACBindings.Internal.CLandCell*>)0x00530A60)(ref this, cell_id);

    /// <summary>Initializes building objects within a land block based on associated CLandBlockInfo data, creating instances, assigning frames, and registering them with the appropriate land cells and stab list.
    /// <code>Offset: 0x00530AC0
    /// void __thiscall CLandBlock::init_buildings(CLandBlock*)</code>
    /// </summary>
    public void init_buildings() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x00530AC0)(ref this);

    /// <summary>Updates the vertical positions of all static scene objects within the land block so that each object rests on the appropriate walkable terrain surface, adjusting their frames accordingly.
    /// <code>Offset: 0x00530C30
    /// void __thiscall CLandBlock::adjust_scene_obj_height(CLandBlock*)</code>
    /// </summary>
    public void adjust_scene_obj_height() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x00530C30)(ref this);

    /// <summary>Checks whether the supplied world coordinates fall on a road tile in this land block by inspecting terrain data and local offsets.
    /// <code>Offset: 0x00530D30
    /// int __thiscall CLandBlock::on_road(CLandBlock*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="obj_vector">World position to test; its x and y components are used to locate the corresponding terrain cell.</param>
    /// <returns>Non‑zero if the point is considered to be on a road, zero otherwise.</returns>
    public int on_road(ACBindings.Internal.AC1Legacy.Vector3* obj_vector) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00530D30)(ref this, obj_vector);

    /// <summary>Ensures the cell data for this land block is loaded by pre‑fetching required static objects and delegating to CLandBlockInfo. Returns a non‑zero value if all resources are available; otherwise returns zero.
    /// <code>Offset: 0x00530F80
    /// int __thiscall CLandBlock::PreFetchCells(CLandBlock*)</code>
    /// </summary>
    /// <returns>Non‑zero on success, zero on failure.</returns>
    public int PreFetchCells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, int>)0x00530F80)(ref this);

    /// <summary>Releases visibility references, destroys static objects and buildings, and resets internal state after the block’s size changes.
    /// <code>Offset: 0x00531000
    /// void __thiscall CLandBlock::notify_change_size(CLandBlock*)</code>
    /// </summary>
    public void notify_change_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x00531000)(ref this);

    /// <summary>Adds ambient sounds associated with each cell in this land block at the specified position.
    /// <code>Offset: 0x00531050
    /// unsigned int __thiscall CLandBlock::add_ambient_sounds(CLandBlock*,Position*)</code>
    /// </summary>
    /// <param name="a2">Position object to which ambient sound references are added based on the block's terrain data.</param>
    /// <returns>The number of cells processed, equal to side_cell_count.</returns>
    public uint add_ambient_sounds(ACBindings.Internal.Position* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, ACBindings.Internal.Position*, uint>)0x00531050)(ref this, a2);

    /// <summary>Populates the land block with static objects defined in the current region’s scene data, creating physics instances and placing them on suitable terrain cells while respecting slope constraints and avoiding road intersections.
    /// <code>Offset: 0x005311A0
    /// void __thiscall CLandBlock::get_land_scenes(CLandBlock*)</code>
    /// </summary>
    public void get_land_scenes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, void>)0x005311A0)(ref this);

    /// <summary>Initializes static objects within the land block by creating physics objects from block data or updating existing ones, placing them in appropriate cells and applying cell restrictions.
    /// <code>Offset: 0x00531780
    /// void __thiscall CLandBlock::init_static_objs(CLandBlock*,int)</code>
    /// </summary>
    public void init_static_objs(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlock, int, void>)0x00531780)(ref this, a2);
}

