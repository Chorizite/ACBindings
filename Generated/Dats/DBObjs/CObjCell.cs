namespace ACBindings.Internal;


/// <summary>Defines a spatial partition of the game world that aggregates physics objects, lighting information, shadow data, and land block references to optimize rendering and simulation.</summary>
public unsafe struct CObjCell : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj
    public ACBindings.Internal.CPartCell BaseClass_CPartCell; // ACBindings.Internal.CPartCell

    // Statics
    public static ACBindings.Internal.CObjectMaint** obj_maint = (ACBindings.Internal.CObjectMaint**)0x008456EC;
    public static ACBindings.Internal.LScape** landscape = (ACBindings.Internal.LScape**)0x008456F0;

    // Child Types
    public unsafe struct CObjCell_vtbl
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
    public ACBindings.Internal.LandDefs.WaterType water_type;
    public ACBindings.Internal.Position pos;
    public uint num_objects;
    public ACBindings.Internal.DArray___CPhysicsObj_ptr object_list;
    public uint num_lights;
    public ACBindings.Internal.DArray___LIGHTOBJ_ptr light_list;
    public uint num_shadow_objects;
    public ACBindings.Internal.DArray___CShadowObj_ptr shadow_object_list;
    public uint restriction_obj;
    public ACBindings.Internal.ClipPlaneList** clip_planes;
    public uint num_stabs;
    public uint* stab_list;
    public int seen_outside;
    public System.IntPtr voyeur_table;
    public ACBindings.Internal.CLandBlock* myLandBlock_;

    // Generated Constructor
    public CObjCell() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves a visible cell object corresponding to the specified identifier.
    /// <code>Offset: 0x0052B950
    /// CObjCell* __cdecl CObjCell::GetVisible(unsigned int)</code>
    /// </summary>
    /// <param name="cell_id">The numeric ID of the target cell.</param>
    /// <returns>A pointer to the visible CObjCell instance, or null when no such cell exists.</returns>
    public static ACBindings.Internal.CObjCell* GetVisible(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CObjCell*>)0x0052B950)(cell_id);

    /// <summary>Assigns the specified object maintainer to the current cell, enabling object management within this region.
    /// <code>Offset: 0x0052B980
    /// void __cdecl CObjCell::SetObjectMaintainer(CObjectMaint*)</code>
    /// </summary>
    /// <param name="obj_maint">The CObjectMaint instance responsible for maintaining objects in this cell.</param>
    public static void SetObjectMaintainer(ACBindings.Internal.CObjectMaint* obj_maint) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CObjectMaint*, void>)0x0052B980)(obj_maint);

    /// <summary>Obtains the water type of the land block linked to this cell, returning a default value when none is present.
    /// <code>Offset: 0x0052B9A0
    /// LandDefs::WaterType __thiscall CObjCell::get_block_water_type(CObjCell*)</code>
    /// </summary>
    /// <returns>The WaterType for the cell's land block or 0 if the block is absent.</returns>
    public ACBindings.Internal.LandDefs.WaterType get_block_water_type() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.LandDefs.WaterType>)0x0052B9A0)(ref this);

    /// <summary>Initializes a new CObjCell instance, configuring base class interfaces, setting the default position to the origin, marking water type as NOT_WATER, and clearing object, light, shadow, and other related lists.
    /// <code>Offset: 0x0052BB80
    /// void __thiscall CObjCell::CObjCell(CObjCell*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, void>)0x0052BB80)(ref this);

    /// <summary>Determines the sequence of cells intersected by one or more spheres originating from a given position and records them for further processing.
    /// <code>Offset: 0x0052BC80
    /// void __thiscall CObjCell::find_transit_cells(CObjCell*,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)</code>
    /// </summary>
    /// <param name="p">Starting position from which sphere(s) are evaluated.</param>
    /// <param name="num_sphere">Number of spheres to consider in the transit calculation.</param>
    /// <param name="sphere">Pointer to sphere data defining the shapes whose traversal is to be analyzed.</param>
    /// <param name="cell_array">Output container that receives the list of cells intersected during transit.</param>
    /// <param name="path">Structure used to record detailed path and collision information for each traversed sphere.</param>
    public void find_transit_cells(ACBindings.Internal.Position* p, uint num_sphere, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void>)0x0052BC80)(ref this, p, num_sphere, sphere, cell_array, path);

    /// <summary>Locates transit cells for given physics parts and stores them in the provided cell array. Currently unimplemented and triggers a debug abort.
    /// <code>Offset: 0x0052BC90
    /// void __thiscall CObjCell::find_transit_cells(CObjCell*,const unsigned int,CPhysicsPart**,CELLARRAY*)</code>
    /// </summary>
    /// <param name="num_parts">Number of physics part pointers supplied.</param>
    /// <param name="parts">Array of pointers to physics parts whose transit cells are to be found.</param>
    /// <param name="cell_array">Container that will receive information about discovered transit cells.</param>
    public void find_transit_cells(uint num_parts, ACBindings.Internal.CPhysicsPart** parts, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, uint, ACBindings.Internal.CPhysicsPart**, ACBindings.Internal.CELLARRAY*, void>)0x0052BC90)(ref this, num_parts, parts, cell_array);

    /// <summary>Destructs a CObjCell instance, releasing dynamic arrays for objects, lights, shadows, clip planes, invoking any voyeur table callbacks, and calling base class destructors to clean up inherited resources.
    /// <code>Offset: 0x0052BCD0
    /// void __thiscall CObjCell::~CObjCell(CObjCell*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, void>)0x0052BCD0)(ref this);

    /// <summary>Retrieves a CObjCell instance by its identifier, delegating to land cell lookup for small IDs and database retrieval for larger ones.
    /// <code>Offset: 0x0052BD90
    /// CObjCell* __cdecl CObjCell::Get(unsigned int)</code>
    /// </summary>
    /// <param name="cell_id">Numeric identifier of the desired cell; values below 256 refer to land cells, while larger values are resolved through the object database.</param>
    /// <returns>Pointer to the requested CObjCell or nullptr if cell_id is zero.</returns>
    public static ACBindings.Internal.CObjCell* Get(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CObjCell*>)0x0052BD90)(cell_id);

    /// <summary>Adds a light source to this cell's list, automatically enlarging the storage when capacity is exceeded.
    /// <code>Offset: 0x0052BDE0
    /// void __thiscall CObjCell::add_light(CObjCell*,const LIGHTOBJ*)</code>
    /// </summary>
    /// <param name="light">Pointer to the LIGHTOBJ instance to be added.</param>
    public void add_light(ACBindings.Internal.LIGHTOBJ* light) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.LIGHTOBJ*, void>)0x0052BDE0)(ref this, light);

    /// <summary>Removes the specified light object from this cell's internal list, updating the count and shifting the last element into the vacated slot. If the list shrinks sufficiently, storage is reduced to keep memory usage efficient.
    /// <code>Offset: 0x0052BE20
    /// void __thiscall CObjCell::remove_light(CObjCell*,const LIGHTOBJ*)</code>
    /// </summary>
    /// <param name="light">The LIGHTOBJ instance to remove from the cell; if not present, no changes are made.</param>
    public void remove_light(ACBindings.Internal.LIGHTOBJ* light) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.LIGHTOBJ*, void>)0x0052BE20)(ref this, light);

    /// <summary>Adds a CShadowObj to the cell’s list of shadow objects, ensuring sufficient capacity and recording the owning cell.
    /// <code>Offset: 0x0052BE90
    /// void __thiscall CObjCell::add_shadow_object(CObjCell*,CShadowObj*,unsigned int)</code>
    /// </summary>
    /// <param name="object">The shadow object to associate with the cell.</param>
    /// <param name="num_shadow_cells">The number of shadow cells that the object covers; currently unused in this routine but may be relevant for other calculations.</param>
    public void add_shadow_object(ACBindings.Internal.CShadowObj* object_, uint num_shadow_cells) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CShadowObj*, uint, void>)0x0052BE90)(ref this, object_, num_shadow_cells);

    /// <summary>Removes the specified shadow object from this cell’s internal list, clears its association with the cell, and reduces the list size when appropriate.
    /// <code>Offset: 0x0052BEE0
    /// void __thiscall CObjCell::remove_shadow_object(CObjCell*,CShadowObj*)</code>
    /// </summary>
    /// <param name="object">The CShadowObj instance to detach from the cell.</param>
    public void remove_shadow_object(ACBindings.Internal.CShadowObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CShadowObj*, void>)0x0052BEE0)(ref this, object_);

    /// <summary>Adds active static lights from this cell to the global renderer, registering each enabled light along with its position and properties for lighting calculations.
    /// <code>Offset: 0x0052BF60
    /// void __thiscall CObjCell::add_static_to_global_lights(CObjCell*)</code>
    /// </summary>
    public void add_static_to_global_lights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, void>)0x0052BF60)(ref this);

    /// <summary>Adds all dynamic (non-static) lights owned by this cell to the global renderer's light list.
    /// <code>Offset: 0x0052BFA0
    /// void __thiscall CObjCell::add_dynamic_to_global_lights(CObjCell*)</code>
    /// </summary>
    /// <param name="this">The CObjCell instance whose lights are processed.</param>
    public void add_dynamic_to_global_lights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, void>)0x0052BFA0)(ref this);

    /// <summary>Resets the supplied vector to zero and reports a viewer distance of zero.
    /// <code>Offset: 0x0052BFF0
    /// float __thiscall CObjCell::GetViewerDistance(CObjCell*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="diff_vec">The vector that receives the zeroed coordinates (0, 0, 0).</param>
    /// <returns>The computed viewer distance, always 0.</returns>
    public float GetViewerDistance(ACBindings.Internal.AC1Legacy.Vector3* diff_vec) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.AC1Legacy.Vector3*, float>)0x0052BFF0)(ref this, diff_vec);

    /// <summary>Initializes the object cell by registering it with the global object maintainer and updating cross‑cell relationships for invisible or inactive physics objects.
    /// <code>Offset: 0x0052C030
    /// void __thiscall CObjCell::init_objects(CObjCell*)</code>
    /// </summary>
    public void init_objects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, void>)0x0052C030)(ref this);

    /// <summary>Releases all shadow objects associated with the cell, removes their physics parts, and informs the global object maintainer to clean up the cell's remaining objects if present.
    /// <code>Offset: 0x0052C0A0
    /// void __thiscall CObjCell::release_objects(CObjCell*)</code>
    /// </summary>
    public void release_objects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, void>)0x0052C0A0)(ref this);

    /// <summary>Collects object cells intersecting a sphere or set of spheres and records whether an interior cell was encountered.
    /// <code>Offset: 0x0052C0F0
    /// void __cdecl CObjCell::find_cell_list(const Position*,const unsigned int,const CSphere*,CELLARRAY*,CObjCell**,SPHEREPATH*)</code>
    /// </summary>
    /// <param name="p">The starting position used to determine which cells to examine.</param>
    /// <param name="num_sphere">The number of spheres supplied for evaluation; zero indicates a single sphere.</param>
    /// <param name="sphere">Pointer to the sphere(s) that define the area of interest.</param>
    /// <param name="cell_array">Output container cleared at entry and then populated with cells that intersect the specified sphere(s).</param>
    /// <param name="curr_cell">If provided, receives the first cell that satisfies interior‑cell criteria; otherwise left unchanged.</param>
    /// <param name="path">Optional structure whose flags are updated to indicate whether an interior cell was hit during processing.</param>
    public static void find_cell_list(ACBindings.Internal.Position* p, uint num_sphere, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.CObjCell** curr_cell, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.CObjCell**, ACBindings.Internal.SPHEREPATH*, void>)0x0052C0F0)(p, num_sphere, sphere, cell_array, curr_cell, path);

    /// <summary>Determines whether an object entering this cell satisfies the cell’s entry restrictions and may be admitted.
    /// <code>Offset: 0x0052C2E0
    /// TransitionState __thiscall CObjCell::check_entry_restrictions(CObjCell*,CTransition*)</code>
    /// </summary>
    /// <param name="transition">Information about the moving object, including its physics representation, state flags, and target cell pointer.</param>
    /// <returns>1 if the transition is allowed; 2 if the object fails the restriction checks (and a base‑class query interface is invoked).</returns>
    public ACBindings.Internal.TransitionState check_entry_restrictions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0052C2E0)(ref this, transition);

    /// <summary>Detects collisions between a transitioning object and the cell's shadow objects, skipping checks when inserting during initial placement.
    /// <code>Offset: 0x0052C360
    /// TransitionState __thiscall CObjCell::find_obj_collisions(CObjCell*,CTransition*)</code>
    /// </summary>
    /// <param name="this">The cell containing potential collision targets.</param>
    /// <param name="transition">Describes the object to transition, including its physics info and insertion type.</param>
    /// <returns>A TransitionState value indicating whether any collisions were detected (OK_TS if none).</returns>
    public ACBindings.Internal.TransitionState find_obj_collisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0052C360)(ref this, transition);

    /// <summary>Checks whether any top‑level shadow object in the cell collides with the supplied physics object, ignoring objects that are children of other physics objects or identical to the supplied one.
    /// <code>Offset: 0x0052C3C0
    /// int __thiscall CObjCell::check_collisions(CObjCell*,const CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object to test against the cell’s top‑level shadow objects.</param>
    /// <returns>1 if a collision is detected; 0 otherwise.</returns>
    public int check_collisions(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CPhysicsObj*, int>)0x0052C3C0)(ref this, object_);

    /// <summary>Iterates over all shadow objects in the cell, testing each against a directional attack defined by attacker position, scale and cone, and records hits in the supplied AttackInfo structure. Objects that are the attacker or already flagged as processed are skipped.
    /// <code>Offset: 0x0052C420
    /// void __thiscall CObjCell::check_attack(CObjCell*,const unsigned int,const Position*,const float,const AttackCone*,AttackInfo*)</code>
    /// </summary>
    /// <param name="attacker_id">Identifier of the attacking object; used to exclude this object from being considered a target.</param>
    /// <param name="attacker_pos">Position of the attacking object, providing the origin for attack calculations.</param>
    /// <param name="attacker_scale">Scale factor applied to the attack’s dimensions when evaluating potential hits.</param>
    /// <param name="attack_cone">Cone geometry that defines the directional attack area (radius, height, left/right vectors).</param>
    /// <param name="attack_info">Output structure into which hit object IDs and related data are recorded.</param>
    public void check_attack(uint attacker_id, ACBindings.Internal.Position* attacker_pos, float attacker_scale, ACBindings.Internal.AttackCone* attack_cone, ACBindings.Internal.AttackInfo* attack_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, uint, ACBindings.Internal.Position*, float, ACBindings.Internal.AttackCone*, ACBindings.Internal.AttackInfo*, void>)0x0052C420)(ref this, attacker_id, attacker_pos, attacker_scale, attack_cone, attack_info);

    /// <summary>Returns the depth of water at the specified location within this cell.
    /// <code>Offset: 0x0052C4B0
    /// float __thiscall CObjCell::get_water_depth(CObjCell*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="point">The world-space position whose water depth is queried.</param>
    /// <returns>The water depth (in game units). Returns 0.0 if the cell is not a water cell, or a fixed value for certain water types; otherwise calculates depth from the associated land block or defaults to 0.1 when no land block exists.</returns>
    public float get_water_depth(ACBindings.Internal.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.AC1Legacy.Vector3*, float>)0x0052C4B0)(ref this, point);

    /// <summary>Retrieves a physics object by its unique identifier from this cell’s object list.
    /// <code>Offset: 0x0052C500
    /// CPhysicsObj* __thiscall CObjCell::get_object(CObjCell*,const unsigned int)</code>
    /// </summary>
    /// <param name="obj_iid">The unique ID of the desired physics object.</param>
    /// <returns>A pointer to the matching CPhysicsObj, or null if no object with that ID exists in the cell.</returns>
    public ACBindings.Internal.CPhysicsObj* get_object(uint obj_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, uint, ACBindings.Internal.CPhysicsObj*>)0x0052C500)(ref this, obj_iid);

    /// <summary>Adds static and dynamic lights from the current object cell into the global lighting system, ensuring they are considered for rendering.
    /// <code>Offset: 0x0052C560
    /// void __thiscall CObjCell::add_lights(CObjCell*)</code>
    /// </summary>
    public void add_lights() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, void>)0x0052C560)(ref this);

    /// <summary>Collects cells intersecting the spheres described in a SPHEREPATH into the supplied CELLARRAY and updates an optional cell pointer with the current checked cell during traversal.
    /// <code>Offset: 0x0052C570
    /// void __cdecl CObjCell::find_cell_list(CELLARRAY*,CObjCell**,SPHEREPATH*)</code>
    /// </summary>
    /// <param name="cell_array">The array that receives the list of cells found along the sphere path.</param>
    /// <param name="check_cell">Pointer to a CObjCell that will be set to the current checked cell; may remain unchanged if no cell is matched.</param>
    /// <param name="path">Path data containing sphere positions used for determining which cells intersect the movement volume.</param>
    public static void find_cell_list(ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.CObjCell** check_cell, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CELLARRAY*, ACBindings.Internal.CObjCell**, ACBindings.Internal.SPHEREPATH*, void>)0x0052C570)(cell_array, check_cell, path);

    /// <summary>Transforms a local sphere into global coordinates using a given position, then records cells intersecting that sphere in the supplied cell array and updates an optional sphere path.
    /// <code>Offset: 0x0052C5A0
    /// void __cdecl CObjCell::find_cell_list(const Position*,const CSphere*,CELLARRAY*,SPHEREPATH*)</code>
    /// </summary>
    /// <param name="p">Reference point defining the origin and orientation for converting the sphere from local to global space.</param>
    /// <param name="sphere">Sphere defined in local coordinates relative to the reference position.</param>
    /// <param name="cell_array">Output container that receives the list of cells intersected by the transformed sphere.</param>
    /// <param name="path">Optional structure updated with traversal and collision information for the sphere path.</param>
    public static void find_cell_list(ACBindings.Internal.Position* p, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void>)0x0052C5A0)(p, sphere, cell_array, path);

    /// <summary>Collects cells intersecting up to ten cylindrical volumes defined relative to a position, converting each volume into global space before performing the search.
    /// <code>Offset: 0x0052C600
    /// void __cdecl CObjCell::find_cell_list(const Position*,const unsigned int,const CCylSphere*,CELLARRAY*,SPHEREPATH*)</code>
    /// </summary>
    /// <param name="p">The reference Position used to transform local cylinder definitions to world coordinates.</param>
    /// <param name="num_cylsphere">Number of CCylSphere structures provided; values greater than ten are truncated to ten.</param>
    /// <param name="cylsphere">Array of CCylSphere objects describing the cylinders in local space.</param>
    /// <param name="cell_array">Output structure that receives the list of cells intersecting the transformed volumes.</param>
    /// <param name="path">Optional SPHEREPATH used during the search; may be null.</param>
    public static void find_cell_list(ACBindings.Internal.Position* p, uint num_cylsphere, ACBindings.Internal.CCylSphere* cylsphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, uint, ACBindings.Internal.CCylSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void>)0x0052C600)(p, num_cylsphere, cylsphere, cell_array, path);

    /// <summary>Adds or updates a voyeur entry identified by <paramref name="voyeur_id"/> in the cell's voyeur table, initializing it with the provided detection parameters. When newly added, all other objects currently present are notified that they have entered its detection range.
    /// <code>Offset: 0x0052C770
    /// int __thiscall CObjCell::add_voyeur(CObjCell*,unsigned int,const DetectionCylsphere*)</code>
    /// </summary>
    /// <param name="voyeur_id">Identifier of the object to be monitored as a voyeur.</param>
    /// <param name="detcyl">Detection cylinder defining how the voyeur detects other objects.</param>
    /// <returns>Non‑zero if the voyeur was added or updated successfully; zero when either argument is null or zero.</returns>
    public int add_voyeur(uint voyeur_id, ACBindings.Internal.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, uint, ACBindings.Internal.DetectionCylsphere*, int>)0x0052C770)(ref this, voyeur_id, detcyl);

    /// <summary>Removes a voyeur from the cell’s internal table and updates object detection status when the last reference is deleted.
    /// <code>Offset: 0x0052C8A0
    /// int __thiscall CObjCell::remove_voyeur(CObjCell*,unsigned int,const DetectionCylsphere*)</code>
    /// </summary>
    /// <param name="voyeur_id">Identifier of the voyeur to be removed.</param>
    /// <param name="detcyl">Detection cylinder data for the removal operation (unused in this implementation).</param>
    /// <returns>1 if the voyeur was successfully removed; 0 if no such voyeur or the table is missing.</returns>
    public int remove_voyeur(uint voyeur_id, ACBindings.Internal.DetectionCylsphere* detcyl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, uint, ACBindings.Internal.DetectionCylsphere*, int>)0x0052C8A0)(ref this, voyeur_id, detcyl);

    /// <summary>Notifies all objects registered in the cell’s voyeur table when a specified object triggers a detection event, propagating the event to relevant observers.
    /// <code>Offset: 0x0052C990
    /// void __thiscall CObjCell::update_all_voyeur(CObjCell*,CPhysicsObj*,DetectionType)</code>
    /// </summary>
    /// <param name="object">The physics object that generated the detection event.</param>
    /// <param name="type">The type of detection (e.g., EnteredDetection) indicating how the event should be handled.</param>
    public void update_all_voyeur(ACBindings.Internal.CPhysicsObj* object_, ACBindings.Internal.DetectionType type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.DetectionType, void>)0x0052C990)(ref this, object_, type);

    /// <summary>Hides a physics object within the current cell, updating all voyeur entries so that it no longer appears in relevant detection lists.
    /// <code>Offset: 0x0052CA40
    /// void __thiscall CObjCell::hide_object(CObjCell*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="obj">The physics object to hide from this cell.</param>
    public void hide_object(ACBindings.Internal.CPhysicsObj* obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CPhysicsObj*, void>)0x0052CA40)(ref this, obj);

    /// <summary>Notifies voyeur observers of this cell that a physics object is present when the object is not hidden and has no parent.
    /// <code>Offset: 0x0052CA50
    /// void __thiscall CObjCell::unhide_object(CObjCell*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="obj">The physics object to notify about.</param>
    public void unhide_object(ACBindings.Internal.CPhysicsObj* obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CPhysicsObj*, void>)0x0052CA50)(ref this, obj);

    /// <summary>Adds the specified physics object to this cell’s collection, expanding storage if necessary. If the object is a top‑level entity with an identifier and not flagged as special, the method informs relevant objects via the voyeur table that a new entrant has entered detection range.
    /// <code>Offset: 0x0052CB70
    /// void __thiscall CObjCell::add_object(CObjCell*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object to add to the cell.</param>
    public void add_object(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CPhysicsObj*, void>)0x0052CB70)(ref this, object_);

    /// <summary>Removes a physics object from the cell's list if present, updates voyeur references, and shrinks internal storage when sufficient unused space exists.
    /// <code>Offset: 0x0052CC50
    /// void __thiscall CObjCell::remove_object(CObjCell*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="this">The cell instance from which to remove the object.</param>
    /// <param name="object">The physics object to be removed.</param>
    public void remove_object(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CObjCell, ACBindings.Internal.CPhysicsObj*, void>)0x0052CC50)(ref this, object_);
}

