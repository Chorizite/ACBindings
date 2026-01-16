namespace ACBindings.Internal;


/// <summary>Environment cell that encapsulates geometry, portals, lighting, and static objects for a specific region in the virtual world, enabling efficient rendering and physics calculations.</summary>
public unsafe struct CEnvCell
{
    // Base Classes
    public ACBindings.Internal.CObjCell BaseClass_CObjCell; // ACBindings.Internal.CObjCell

    // Statics
    public static int* master_incell_timestamp = (int*)0x0081ECC8;
    public static ACBindings.Internal.HashTable__uint___CEnvCell_ptr* visible_cell_table = (ACBindings.Internal.HashTable__uint___CEnvCell_ptr*)0x0081ED38;
    public static ACBindings.Internal.HashTable__uint___CEnvCell_ptr* cell_flush_table = (ACBindings.Internal.HashTable__uint___CEnvCell_ptr*)0x0081EDB0;

    // Child Types
    public unsafe struct CEnvCell_vtbl
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
        public fixed byte gap58[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CEnvCell*> GetAsEnvCell; // function pointer
        public fixed byte gap60[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CLandCell*> GetAsLandCell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.BoundingType> IsInView; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.AC1Legacy.Vector3*, float> GetViewerDistance; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, void> grab_visible_cells; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, void> release_cells; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, uint, ACBindings.Internal.CPhysicsObj*> get_object; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void> find_transit_cells; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.AC1Legacy.Vector3*, int> point_in_cell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState> find_collisions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState> find_env_collisions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CTransition*, int> handle_move_restriction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.CPolygon*, ACBindings.Internal.Position*, ACBindings.Internal.SURFCHAR> walkable_surface_type; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, ACBindings.Internal.LOSParameters*, uint> Trace; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CObjCell*, void> init_static_objects; // function pointer

        // Methods
    }

    // Members
    public uint num_surfaces;
    public ACBindings.Internal.CSurface** surfaces;
    public ACBindings.Internal.CCellStruct* structure;
    public ACBindings.Internal.CEnvironment* env;
    public uint num_portals;
    public ACBindings.Internal.CCellPortal* portals;
    public uint num_static_objects;
    public System.IntPtr static_object_ids;
    public ACBindings.Internal.Frame* static_object_frames;
    public ACBindings.Internal.CPhysicsObj** static_objects;
    public ACBindings.Internal.RGBColor* light_array;
    public int incell_timestamp;
    public ACBindings.Internal.MeshBuffer* ructed_mesh;
    public int use_built_mesh;
    public uint m_current_render_frame_num;
    public uint num_view;
    public ACBindings.Internal.DArray___portal_view_type_ptr portal_view;

    // Generated Constructor
    public CEnvCell() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Allocates memory for a new CEnvCell object, constructs it, and returns the resulting DBObj pointer.
    /// <code>Offset: 0x004F7AF0
    /// DBObj* __cdecl CEnvCell::Allocator()</code>
    /// </summary>
    /// <returns>A DBObj* pointing to the newly created CEnvCell instance, or nullptr if allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7AF0)();

    /// <summary>Checks whether the cell has already been rendered in the current frame.
    /// <code>Offset: 0x0052CCD0
    /// bool __thiscall CEnvCell::GetDrawnThisFrame(CEnvCell*)</code>
    /// </summary>
    /// <returns>True if the cell was drawn during this rendering frame; otherwise, false.</returns>
    public byte GetDrawnThisFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, byte>)0x0052CCD0)(ref this);

    /// <summary>Records the current rendering frame number for the environment cell, enabling tracking of cells drawn during the frame.
    /// <code>Offset: 0x0052CCF0
    /// void __thiscall CEnvCell::SetDrawnThisFrame(CEnvCell*)</code>
    /// </summary>
    public void SetDrawnThisFrame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void>)0x0052CCF0)(ref this);

    /// <summary>Executes collision detection for the environment cell based on a transition object, delegating to the underlying object cell after releasing any pending resources.
    /// <code>Offset: 0x0052CD10
    /// TransitionState __thiscall CEnvCell::find_collisions(CEnvCell*,CTransition*)</code>
    /// </summary>
    /// <param name="transition">The transition context containing objects and path information for which collisions are evaluated.</param>
    /// <returns>The TransitionState result of the collision check; OK_TS indicates success and triggers further object-level collision detection.</returns>
    public ACBindings.Internal.TransitionState find_collisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0052CD10)(ref this, transition);

    /// <summary>
    /// Checks entry restrictions for a transition and tests its sphere path against the cell’s BSP tree, updating obstruction flags and collision data based on the result.
    /// 
    /// <code>Offset: 0x0052CD40
    /// TransitionState __thiscall CEnvCell::find_env_collisions(CEnvCell*,CTransition*)</code>
    /// </summary>
    /// <param name="transition">Transition containing sphere path and object information to test against the environment.</param>
    /// <returns>State indicating whether the operation succeeded or if a collision occurred (OK_TS for success).</returns>
    public ACBindings.Internal.TransitionState find_env_collisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0052CD40)(ref this, transition);

    /// <summary>Handles movement restrictions for an object within this environment cell based on its collision profile, always reporting success.
    /// <code>Offset: 0x0052CDD0
    /// int __thiscall CEnvCell::handle_move_restriction(ACCWeenieObject*,const ObjCollisionProfile*)</code>
    /// </summary>
    /// <param name="prof">Collision profile containing velocity and other data relevant to movement.</param>
    /// <returns>Always returns 1, indicating successful handling of move restrictions.</returns>
    public int handle_move_restriction(ACBindings.Internal.ObjCollisionProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, ACBindings.Internal.ObjCollisionProfile*, int>)0x0052CDD0)(ref this, prof);

    /// <summary>Computes the byte count required to serialize an environment cell, accounting for its surfaces, portals, static objects, stabs, and restriction flag.
    /// <code>Offset: 0x0052CDE0
    /// unsigned int __thiscall CEnvCell::pack_size(CEnvCell*)</code>
    /// </summary>
    /// <returns>The total number of bytes necessary to pack this cell.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, uint>)0x0052CDE0)(ref this);

    /// <summary>Initializes an environmental cell by calling the base object constructor and resetting all member variables to their default empty state.
    /// <code>Offset: 0x0052CE50
    /// void __thiscall CEnvCell::CEnvCell(CEnvCell*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void>)0x0052CE50)(ref this);

    /// <summary>Checks whether a world-space point lies within this environmental cell by converting to local coordinates and querying the cell structure.
    /// <code>Offset: 0x0052CF10
    /// int __thiscall CEnvCell::point_in_cell(CEnvCell*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="point">The position to test, expressed in global coordinates.</param>
    /// <returns>Non‑zero if the point is inside the cell; zero otherwise.</returns>
    public int point_in_cell(ACBindings.Internal.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0052CF10)(ref this, point);

    /// <summary>Initializes the cell’s static physics objects from stored IDs on first call, allocating an array of object pointers and linking each to the cell. Subsequent calls recalculate cross‑cell relationships for any existing object that is not completely visible.
    /// <code>Offset: 0x0052CF60
    /// void __thiscall CEnvCell::init_static_objects(CEnvCell*)</code>
    /// </summary>
    public void init_static_objects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void>)0x0052CF60)(ref this);

    /// <summary>Configures this cell’s rendering by assigning a specified presentation view to its most recently added portal view.
    /// <code>Offset: 0x0052D040
    /// void __thiscall CEnvCell::setup_view(CEnvCell*,unsigned int)</code>
    /// </summary>
    /// <param name="pres_view">The presentation view identifier used for the last portal view.</param>
    public void setup_view(uint pres_view) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, uint, void>)0x0052D040)(ref this, pres_view);

    /// <summary>Preloads environmental cell resources, including associated static objects and linked data, while updating a count of pending fetches.
    /// <code>Offset: 0x0052D070
    /// int __thiscall CEnvCell::PreFetchCells(CEnvCell*,unsigned int*)</code>
    /// </summary>
    /// <param name="num_waiting_elements">Pointer to an unsigned integer that is incremented for each object or link that cannot be immediately retrieved from memory and must wait for asynchronous loading.</param>
    /// <returns>Non‑zero if all required data are available (or prefetch was successfully initiated); zero otherwise.</returns>
    public int PreFetchCells(uint* num_waiting_elements) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, uint*, int>)0x0052D070)(ref this, num_waiting_elements);

    /// <summary>Checks whether any of a given set of spheres intersect the cell's building geometry, marking an interior hit on the path and adding this cell to the result array.
    /// <code>Offset: 0x0052D1E0
    /// void __thiscall CEnvCell::check_building_transit(CEnvCell*,int,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)</code>
    /// </summary>
    /// <param name="portal_id">Index of the portal; processing occurs only when non‑negative.</param>
    /// <param name="p">Position reference for the traversal (currently unused but part of the interface).</param>
    /// <param name="num_sphere">Number of spheres in the sphere array to test.</param>
    /// <param name="sphere">Array of CSphere objects representing collision volumes.</param>
    /// <param name="cell_array">Collection that receives this cell when an intersection is found.</param>
    /// <param name="path">Path data structure updated with hits_interior_cell flag upon intersection; may be null.</param>
    public void check_building_transit(int portal_id, ACBindings.Internal.Position* p, uint num_sphere, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, int, ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void>)0x0052D1E0)(ref this, portal_id, p, num_sphere, sphere, cell_array, path);

    /// <summary>Determines which cells a set of physics parts can enter by crossing a specified portal from the current cell. Adds reachable cells to the provided CELLARRAY and initiates further transit checks on neighboring cells.
    /// <code>Offset: 0x0052D290
    /// void __thiscall CEnvCell::check_building_transit(CEnvCell*,int,const unsigned int,CPhysicsPart**,CELLARRAY*)</code>
    /// </summary>
    /// <param name="portal_id">Identifier of the portal that connects this cell to its neighbor for transit evaluation.</param>
    /// <param name="num_parts">Number of physics parts supplied in the array to test for crossing the portal.</param>
    /// <param name="parts">Array of pointers to CPhysicsPart objects representing moving entities whose positions are checked against the portal plane.</param>
    /// <param name="cell_array">Output collection that receives identifiers of cells reachable through transit from this cell.</param>
    public void check_building_transit(int portal_id, uint num_parts, ACBindings.Internal.CPhysicsPart** parts, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, int, uint, ACBindings.Internal.CPhysicsPart**, ACBindings.Internal.CELLARRAY*, void>)0x0052D290)(ref this, portal_id, num_parts, parts, cell_array);

    /// <summary>Collects cells reachable from this cell through its portals for a set of spheres, adding qualifying cells to the supplied CELLARRAY. If any sphere passes a portal test, adds surrounding outside cells via CLandCell::add_all_outside_cells.
    /// <code>Offset: 0x0052D430
    /// void __thiscall CEnvCell::find_transit_cells(CEnvCell*,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)</code>
    /// </summary>
    /// <param name="p">Starting position used when adding outside cells; may be null if no outside cells are added.</param>
    /// <param name="num_sphere">Number of spheres in the array to evaluate against portals and cells.</param>
    /// <param name="sphere">Array of CSphere structures defining traversal volumes for each sphere.</param>
    /// <param name="cell_array">Container that receives IDs/pointers of discovered cells.</param>
    /// <param name="path">Currently unused; reserved for future use or path data.</param>
    public void find_transit_cells(ACBindings.Internal.Position* p, uint num_sphere, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void>)0x0052D430)(ref this, p, num_sphere, sphere, cell_array, path);

    /// <summary>Finds transit cells reachable from this cell by traversing portals for a set of physics parts and adds them to the supplied cell array.
    /// <code>Offset: 0x0052D6F0
    /// void __thiscall CEnvCell::find_transit_cells(CEnvCell*,const unsigned int,CPhysicsPart**,CELLARRAY*)</code>
    /// </summary>
    /// <param name="num_parts">Number of physics parts to test for portal traversal.</param>
    /// <param name="parts">Array of pointers to CPhysicsPart objects representing entities that may cross portals.</param>
    /// <param name="cell_array">Container to receive identifiers and references to transit cells found during the search.</param>
    public void find_transit_cells(uint num_parts, ACBindings.Internal.CPhysicsPart** parts, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, uint, ACBindings.Internal.CPhysicsPart**, ACBindings.Internal.CELLARRAY*, void>)0x0052D6F0)(ref this, num_parts, parts, cell_array);

    /// <summary>Packs the state of a CEnvCell into a contiguous memory buffer for serialization, writing data sequentially and updating the buffer pointer.
    /// <code>Offset: 0x0052D910
    /// unsigned int __thiscall CEnvCell::Pack(CEnvCell*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location; updated to point after written data.</param>
    /// <param name="size">Number of bytes available in the destination buffer; packing occurs only if sufficient space exists.</param>
    /// <returns>Size in bytes required to serialize the CEnvCell instance.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void**, uint, uint>)0x0052D910)(ref this, addr, size);

    /// <summary>Calculates and populates the clip planes for this environment cell based on its portals, ensuring an internal list exists and expanding it as needed.
    /// <code>Offset: 0x0052DD50
    /// void __thiscall CEnvCell::calc_clip_planes(CEnvCell*)</code>
    /// </summary>
    public void calc_clip_planes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void>)0x0052DD50)(ref this);

    /// <summary>Loads the environment cell corresponding to the specified identifier, pre‑fetching required static resources into memory before use.
    /// <code>Offset: 0x0052DE40
    /// int __cdecl CEnvCell::PreFetchCells(int,unsigned int*)</code>
    /// </summary>
    /// <param name="a1">Identifier of the environment cell to load.</param>
    /// <param name="num_waiting_elements">Receives the number of elements still waiting for loading; set to zero when prefetch succeeds.</param>
    /// <returns>Non‑zero if the cell and its static resources were successfully queued or already in memory; otherwise, zero.</returns>
    public static int PreFetchCells(int a1, uint* num_waiting_elements) => ((delegate* unmanaged[Cdecl]<int, uint*, int>)0x0052DE40)(a1, num_waiting_elements);

    /// <summary>Collects the qualified data identifiers for every surface, the environment, and all static objects in this cell into the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x0052DEC0
    /// void __thiscall CEnvCell::GetSubDataIDs(CEnvCell*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that receives the gathered data IDs.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0052DEC0)(ref this, id_array);

    /// <summary>Adds dynamic light sources from all objects in the visible cells of this environment cell to the global lighting system by iterating through each visible cell and its object list.
    /// <code>Offset: 0x0052E070
    /// void __cdecl CEnvCell::add_dynamic_lights()</code>
    /// </summary>
    public static void add_dynamic_lights() => ((delegate* unmanaged[Cdecl]<void>)0x0052E070)();

    /// <summary>Deserializes a CEnvCell from a binary buffer, reconstructing its lights, shadows, portals, clip planes, stabs, objects, and internal data structures.
    /// <code>Offset: 0x0052E0D0
    /// int __thiscall CEnvCell::UnPack(CEnvCell*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the serialized data; advanced as fields are extracted.</param>
    /// <param name="size">Total size of the serialized block, used for bounds checking during unpacking.</param>
    /// <returns>1 when unpacking succeeds.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void**, uint, int>)0x0052E0D0)(ref this, addr, size);

    /// <summary>Recursively searches for an object identified by the given ID in this cell and any connected cells through portals, returning a non‑zero value when found.
    /// <code>Offset: 0x0052E500
    /// int __thiscall CEnvCell::recursively_get_object(_DWORD*,int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Identifier of the object to locate.</param>
    /// <param name="a3">Hash table tracking visited portal identifiers to prevent revisiting cells during recursion.</param>
    /// <returns>Non‑zero if the object was found in this or an adjacent cell; zero otherwise.</returns>
    public int recursively_get_object(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, int, int*, int>)0x0052E500)(ref this, a2, a3);

    /// <summary>Destroys and releases all resources of the cell, including surfaces, lighting, clip planes, constructed mesh, environment references, portal views, portals, stab list, static object IDs and frames, and static objects.
    /// <code>Offset: 0x0052E5F0
    /// void __thiscall CEnvCell::Destroy(CEnvCell*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void>)0x0052E5F0)(ref this);

    /// <summary>Retrieves a visible environment cell by its identifier from the internal visibility table.
    /// <code>Offset: 0x0052E870
    /// CEnvCell* __cdecl CEnvCell::GetVisible(unsigned int)</code>
    /// </summary>
    /// <param name="cell_id">The unique identifier of the desired cell.</param>
    /// <returns>A pointer to the corresponding CEnvCell, or null if no such cell is visible.</returns>
    public static ACBindings.Internal.CEnvCell* GetVisible(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CEnvCell*>)0x0052E870)(cell_id);

    /// <summary>Finds a child environment cell visible from the specified point. If the current cell satisfies the visibility test it is returned immediately; otherwise the function searches either adjacent cells listed in the visible cell table (when <paramref name="bSearchCells"/> is non‑zero) or through portal connections. The first matching cell found is returned, or null if none are visible.
    /// <code>Offset: 0x0052E8B0
    /// CEnvCell* __thiscall CEnvCell::find_visible_child_cell(CEnvCell*,const AC1Legacy::Vector3*,const int)</code>
    /// </summary>
    /// <param name="origin">The point used to determine whether a cell is visible.</param>
    /// <param name="bSearchCells">When true the search uses cells in the visible cell table; when false only adjacent portal cells are considered.</param>
    /// <returns>Pointer to a CEnvCell that is visible from <paramref name="origin"/>, or nullptr if no such cell exists.</returns>
    public ACBindings.Internal.CEnvCell* find_visible_child_cell(ACBindings.Internal.AC1Legacy.Vector3* origin, int bSearchCells) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, ACBindings.Internal.AC1Legacy.Vector3*, int, ACBindings.Internal.CEnvCell*>)0x0052E8B0)(ref this, origin, bSearchCells);

    /// <summary>Adds a cell identified by cell_id to the visible cells table, retrieving it from memory or loading it if absent. If the cell is already registered, returns the existing instance; otherwise loads and registers a new cell.
    /// <code>Offset: 0x0052EAA0
    /// CEnvCell* __cdecl CEnvCell::add_visible_cell(unsigned int)</code>
    /// </summary>
    /// <param name="cell_id">Identifier of the cell to make visible.</param>
    /// <returns>Pointer to the CEnvCell corresponding to cell_id, or nullptr if loading fails.</returns>
    public static ACBindings.Internal.CEnvCell* add_visible_cell(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CEnvCell*>)0x0052EAA0)(cell_id);

    /// <summary>Flushes all environment cells, releasing their contained objects and clearing temporary tables. Reinitializes the currently visible cells for subsequent use.
    /// <code>Offset: 0x0052EB50
    /// void __cdecl CEnvCell::flush_cells()</code>
    /// </summary>
    public static void flush_cells() => ((delegate* unmanaged[Cdecl]<void>)0x0052EB50)();

    /// <summary>Links each stab identifier in the list to its environment cell and assigns the specified land block as the cell’s active region.
    /// <code>Offset: 0x0052ECA0
    /// void __cdecl CEnvCell::grab_visible(unsigned int,unsigned int*,CLandBlock*)</code>
    /// </summary>
    /// <param name="num_stabs">The number of stabs to process.</param>
    /// <param name="stab_list">Array containing identifiers for cells that should be marked visible.</param>
    /// <param name="block">The land block that becomes associated with each selected cell.</param>
    public static void grab_visible(uint num_stabs, uint* stab_list, ACBindings.Internal.CLandBlock* block) => ((delegate* unmanaged[Cdecl]<uint, uint*, ACBindings.Internal.CLandBlock*, void>)0x0052ECA0)(num_stabs, stab_list, block);

    /// <summary>Releases visibility data for the specified stabs, clearing cached state in the visible cell table and moving their entries to the flush table for later processing.
    /// <code>Offset: 0x0052ECE0
    /// void __cdecl CEnvCell::release_visible(unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="num_stabs">Number of stab identifiers provided in stab_list.</param>
    /// <param name="stab_list">Array of stab IDs whose visibility information should be released.</param>
    public static void release_visible(uint num_stabs, uint* stab_list) => ((delegate* unmanaged[Cdecl]<uint, uint*, void>)0x0052ECE0)(num_stabs, stab_list);

    /// <summary>Adds the current cell and its stab cells to the visible cell list, then includes landscape cells when the cell has been seen from outside.
    /// <code>Offset: 0x0052EE80
    /// void __thiscall CEnvCell::grab_visible_cells(CEnvCell*)</code>
    /// </summary>
    public void grab_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void>)0x0052EE80)(ref this);

    /// <summary>Removes the environment cell from visibility structures, clears its portal links, and frees related resources.
    /// <code>Offset: 0x0052EEE0
    /// void __thiscall CEnvCell::release_cells(CEnvCell*)</code>
    /// </summary>
    public void release_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void>)0x0052EEE0)(ref this);

    /// <summary>Ensures sufficient capacity in the cell’s portal_view array and appends a new view entry, allocating and initializing the associated data structures if required.
    /// <code>Offset: 0x005A61A0
    /// void __thiscall CEnvCell::curr_view_push(CEnvCell*)</code>
    /// </summary>
    public void curr_view_push() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void>)0x005A61A0)(ref this);

    /// <summary>Returns zero as a placeholder for walkable surface type determination.
    /// <code>Offset: 0x006B4D00
    /// unsigned int __thiscall CEnvCell::walkable_surface_type(OldPublicWeenieDesc*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Optional address buffer, unused in the current implementation.</param>
    /// <param name="size">Size of data at addr, unused.</param>
    /// <returns>Zero, indicating no surface type has been computed.</returns>
    public uint walkable_surface_type(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnvCell, void**, uint, uint>)0x006B4D00)(ref this, addr, size);
}

