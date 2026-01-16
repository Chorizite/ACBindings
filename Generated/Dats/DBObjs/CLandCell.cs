namespace ACBindings.Internal;


/// <summary>Represents a land cell within the spatial partitioning system, containing sorted cell data, associated polygons, and visibility status.</summary>
public unsafe struct CLandCell : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CSortCell BaseClass_CSortCell; // ACBindings.Internal.CSortCell

    // Child Types
    public unsafe struct CLandCell_vtbl
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
    public ACBindings.Internal.CPolygon** polygons;
    public ACBindings.Internal.BoundingType in_view;

    // Generated Constructor
    public CLandCell() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a new land cell by constructing its base classes, setting up virtual tables, allocating space for polygons, and marking the cell as outside the current view.
    /// <code>Offset: 0x005339B0
    /// void __thiscall CLandCell::CLandCell(CLandCell*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, void>)0x005339B0)(ref this);

    /// <summary>Retrieves the current visibility status of this land cell.
    /// <code>Offset: 0x005339F0
    /// BoundingType __thiscall CLandCell::IsInView(CLandCell*)</code>
    /// </summary>
    /// <returns>The BoundingType value indicating whether the cell is within the camera's view region.</returns>
    public ACBindings.Internal.BoundingType IsInView() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.BoundingType>)0x005339F0)(ref this);

    /// <summary>Destroys a CLandCell instance, freeing its polygon list and invoking base class destructors to clean up resources.
    /// <code>Offset: 0x00533A00
    /// void __thiscall CLandCell::~CLandCell(CLandCell*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, void>)0x00533A00)(ref this);

    /// <summary>Determines which of the cell’s first two terrain polygons contains a given point.
    /// <code>Offset: 0x00533A30
    /// int __thiscall CLandCell::find_terrain_poly(CLandCell*,const AC1Legacy::Vector3*,const CPolygon**)</code>
    /// </summary>
    /// <param name="origin">The 3‑D point to test against the polygons.</param>
    /// <param name="walkable">Receives the polygon that encloses the point, if any.</param>
    /// <returns>Non‑zero when the point lies inside one of the polygons; otherwise zero.</returns>
    public int find_terrain_poly(ACBindings.Internal.AC1Legacy.Vector3* origin, ACBindings.Internal.CPolygon** walkable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CPolygon**, int>)0x00533A30)(ref this, origin, walkable);

    /// <summary>Determines if a point lies inside the land cell’s terrain polygons.
    /// <code>Offset: 0x00533A80
    /// int __thiscall CLandCell::point_in_cell(CLandCell*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="point">The world‑space position to test against the cell's geometry.</param>
    /// <returns>Non‑zero when the point is inside any of the cell's polygons; zero otherwise.</returns>
    public int point_in_cell(ACBindings.Internal.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00533A80)(ref this, point);

    /// <summary>Performs collision detection on a land cell by delegating to its base components and returning the resulting transition state.
    /// <code>Offset: 0x00533AA0
    /// TransitionState __thiscall CLandCell::find_collisions(CLandCell*,CTransition*)</code>
    /// </summary>
    /// <param name="transition">Information about the transition, including objects and sphere path used for collision checks.</param>
    /// <returns>The final TransitionState after performing all collision steps.</returns>
    public ACBindings.Internal.TransitionState find_collisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x00533AA0)(ref this, transition);

    /// <summary>Collects visible cells for the current land cell by querying its associated landscape.
    /// <code>Offset: 0x00533AD0
    /// void __thiscall CLandCell::grab_visible_cells(CLandCell*)</code>
    /// </summary>
    public void grab_visible_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, void>)0x00533AD0)(ref this);

    /// <summary>Releases visible cells related to this land cell by delegating to the landscape manager, freeing associated rendering or simulation resources.
    /// <code>Offset: 0x00533AE0
    /// void __thiscall CLandCell::release_cells(CLandCell*)</code>
    /// </summary>
    public void release_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, void>)0x00533AE0)(ref this);

    /// <summary>Retrieves the land cell identified by the supplied cell identifier from the landscape.
    /// <code>Offset: 0x00533AF0
    /// CLandCell* __cdecl CLandCell::Get(unsigned int)</code>
    /// </summary>
    /// <param name="cell_id">The unique numeric identifier of the desired land cell.</param>
    /// <returns>A pointer to the corresponding CLandCell instance, or nullptr if no such cell exists.</returns>
    public static ACBindings.Internal.CLandCell* Get(uint cell_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CLandCell*>)0x00533AF0)(cell_id);

    /// <summary>Performs a line‑of‑sight check on the cell, marking it as checked and returning a status flag.
    /// <code>Offset: 0x00533B20
    /// unsigned int __thiscall CLandCell::Trace(CLandCell*,LOSParameters*)</code>
    /// </summary>
    /// <param name="los">Line‑of‑sight parameters used for the trace.</param>
    /// <returns>Zero if m_bCheckedOutside was already set; otherwise two to indicate the trace succeeded.</returns>
    public uint Trace(ACBindings.Internal.LOSParameters* los) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.LOSParameters*, uint>)0x00533B20)(ref this, los);

    /// <summary>Determines the terrain type present at a specified world position within this land cell.
    /// <code>Offset: 0x00533B60
    /// SURFCHAR __thiscall CLandCell::find_terrain(CLandCell*,const Position*)</code>
    /// </summary>
    /// <param name="pos">World‑space position to query for terrain information.</param>
    /// <returns>An encoded surface character indicating the terrain type located at the given position.</returns>
    public ACBindings.Internal.SURFCHAR find_terrain(ACBindings.Internal.Position* pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.Position*, ACBindings.Internal.SURFCHAR>)0x00533B60)(ref this, pos);

    /// <summary>Adds a landcell at the given coordinates to the specified CELLARRAY if the coordinates are within valid bounds.
    /// <code>Offset: 0x00533C00
    /// void __cdecl CLandCell::add_outside_cell(CELLARRAY*,int,int)</code>
    /// </summary>
    /// <param name="cell_array">The array into which the cell will be added.</param>
    /// <param name="x">X coordinate of the target cell (must be between 0 and 2039 inclusive).</param>
    /// <param name="y">Y coordinate of the target cell (must be between 0 and 2039 inclusive).</param>
    public static void add_outside_cell(ACBindings.Internal.CELLARRAY* cell_array, int x, int y) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CELLARRAY*, int, int, void>)0x00533C00)(cell_array, x, y);

    /// <summary>Determines whether a moving object collides with this land cell’s environment by checking entry restrictions, terrain polygons, water conditions, and walkability.
    /// <code>Offset: 0x00533C60
    /// TransitionState __thiscall CLandCell::find_env_collisions(CLandCell*,CTransition*)</code>
    /// </summary>
    /// <param name="transition">The transition data for the object being evaluated, including position, state, and collision information.</param>
    /// <returns>A TransitionState value indicating the result of the environmental collision check.</returns>
    public ACBindings.Internal.TransitionState find_env_collisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x00533C60)(ref this, transition);

    /// <summary>Determines and sets a collision normal for a transition based on its position within the land cell’s square region.
    /// <code>Offset: 0x00533DB0
    /// int __thiscall CLandCell::handle_move_restriction(CLandCell*,CTransition*)</code>
    /// </summary>
    /// <param name="this">The CLandCell instance whose spatial bounds are used to compute the normal.</param>
    /// <param name="transition">The CTransition object whose collision_info.normal is updated according to the transition’s current position relative to the square limits.</param>
    /// <returns>Always returns 1 to indicate successful handling of the movement restriction.</returns>
    public int handle_move_restriction(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.CTransition*, int>)0x00533DB0)(ref this, transition);

    /// <summary>Computes the planar distance from the viewer to this land cell while storing the offset vector in diff_vec.
    /// <code>Offset: 0x00533E80
    /// float __thiscall CLandCell::GetViewerDistance(CLandCell*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="diff_vec">Receives the vector difference between the cell’s position and the viewer’s position; its z component is set to zero.</param>
    /// <returns>The Euclidean horizontal (X‑Y plane) distance between the viewer and the cell.</returns>
    public float GetViewerDistance(ACBindings.Internal.AC1Legacy.Vector3* diff_vec) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.AC1Legacy.Vector3*, float>)0x00533E80)(ref this, diff_vec);

    /// <summary>Determines the walkable surface type for a given polygon and position within a land cell.
    /// <code>Offset: 0x00533ED0
    /// SURFCHAR __thiscall CLandCell::walkable_surface_type(CLandCell*,const CPolygon*,const Position*)</code>
    /// </summary>
    /// <param name="walkable">The polygon to test for walkability; only the first two polygons in the cell are considered walkable.</param>
    /// <param name="pos">Position used to identify terrain type when the polygon is walkable.</param>
    /// <returns>Surface character code of the walkable terrain, or 0 if the polygon is not among the first two or is unwalkable.</returns>
    public ACBindings.Internal.SURFCHAR walkable_surface_type(ACBindings.Internal.CPolygon* walkable, ACBindings.Internal.Position* pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.CPolygon*, ACBindings.Internal.Position*, ACBindings.Internal.SURFCHAR>)0x00533ED0)(ref this, walkable, pos);

    /// <summary>Adds all land cells within the inclusive rectangle defined by min_x/min_y and max_x/max_y to the provided CELLARRAY, skipping cells outside the valid 0–2039 coordinate range.
    /// <code>Offset: 0x00533F10
    /// void __cdecl CLandCell::add_cell_block(int,int,int,int,CELLARRAY*)</code>
    /// </summary>
    /// <param name="min_x">The minimum x-coordinate of the block (inclusive).</param>
    /// <param name="min_y">The minimum y-coordinate of the block (inclusive).</param>
    /// <param name="max_x">The maximum x-coordinate of the block (inclusive).</param>
    /// <param name="max_y">The maximum y-coordinate of the block (inclusive).</param>
    /// <param name="cell_array">The CELLARRAY to which found cells will be added.</param>
    public static void add_cell_block(int min_x, int min_y, int max_x, int max_y, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Cdecl]<int, int, int, int, ACBindings.Internal.CELLARRAY*, void>)0x00533F10)(min_x, min_y, max_x, max_y, cell_array);

    /// <summary>Evaluates the supplied point against maximum and minimum cell boundaries, adding adjacent cells to the array when the point lies outside those limits.
    /// <code>Offset: 0x00533FA0
    /// void __cdecl CLandCell::check_add_cell_boundary(CELLARRAY*,const Vec2D*,int,int,float,float)</code>
    /// </summary>
    /// <param name="cell_array">Array of cells to update with any newly identified outside cells.</param>
    /// <param name="pt">Position being checked for boundary violation.</param>
    /// <param name="x">X coordinate of the current cell.</param>
    /// <param name="y">Y coordinate of the current cell.</param>
    /// <param name="incell_max">Maximum allowed coordinate value before considering a point outside.</param>
    /// <param name="incell_min">Minimum allowed coordinate value before considering a point outside.</param>
    public static void check_add_cell_boundary(ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.Vec2D* pt, int x, int y, float incell_max, float incell_min) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CELLARRAY*, ACBindings.Internal.Vec2D*, int, int, float, float, void>)0x00533FA0)(cell_array, pt, x, y, incell_max, incell_min);

    /// <summary>Determines which grid cells contain or surround all given physics parts that lie outside the current land area, and adds those cells to the supplied CELLARRAY.
    /// <code>Offset: 0x005340A0
    /// void __cdecl CLandCell::add_all_outside_cells(const unsigned int,CPhysicsPart**,CELLARRAY*)</code>
    /// </summary>
    /// <param name="num_parts">Total number of entries in the parts array.</param>
    /// <param name="parts">Array of pointers to CPhysicsPart objects; null entries are ignored during processing.</param>
    /// <param name="cell_array">Structure that collects cell identifiers via add_cell_block; its added_outside flag is set after execution.</param>
    public static void add_all_outside_cells(uint num_parts, ACBindings.Internal.CPhysicsPart** parts, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CPhysicsPart**, ACBindings.Internal.CELLARRAY*, void>)0x005340A0)(num_parts, parts, cell_array);

    /// <summary>Adds all cells that lie outside the terrain bounds for either a single position or multiple spheres into the provided CELLARRAY. If spheres are supplied, each sphere's center is adjusted to an outside cell and added; otherwise the current position's cell is added.
    /// <code>Offset: 0x00534370
    /// void __cdecl CLandCell::add_all_outside_cells(const Position*,const unsigned int,const CSphere*,CELLARRAY*)</code>
    /// </summary>
    /// <param name="p">Position of the object whose surrounding cells should be considered.</param>
    /// <param name="num_sphere">Number of spheres in the sphere array. If zero, the function processes only the position.</param>
    /// <param name="sphere">Array of CSphere defining regions to evaluate for outside cells.</param>
    /// <param name="cell_array">Container that receives the added outside cell identifiers.</param>
    public static void add_all_outside_cells(ACBindings.Internal.Position* p, uint num_sphere, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, void>)0x00534370)(p, num_sphere, sphere, cell_array);

    /// <summary>Collects land cells intersecting or adjacent to the specified spheres, adding them to the supplied cell array and updating the traversal path.
    /// <code>Offset: 0x00534540
    /// void __thiscall CLandCell::find_transit_cells(CLandCell*,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)</code>
    /// </summary>
    /// <param name="p">Starting position for transit detection.</param>
    /// <param name="num_sphere">Number of spheres defining the transit region.</param>
    /// <param name="sphere">Array of spheres representing the volume to test against land cells.</param>
    /// <param name="cell_array">Output collection that receives qualifying cell identifiers.</param>
    /// <param name="path">Structure updated with sphere path traversal information and collision data.</param>
    public void find_transit_cells(ACBindings.Internal.Position* p, uint num_sphere, ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CELLARRAY* cell_array, ACBindings.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, ACBindings.Internal.Position*, uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CELLARRAY*, ACBindings.Internal.SPHEREPATH*, void>)0x00534540)(ref this, p, num_sphere, sphere, cell_array, path);

    /// <summary>Collects all transit cells intersecting the specified physics parts, including any outside cells, and stores them in the provided array.
    /// <code>Offset: 0x00534580
    /// void __thiscall CLandCell::find_transit_cells(CLandCell*,const unsigned int,CPhysicsPart**,CELLARRAY*)</code>
    /// </summary>
    /// <param name="num_parts">Number of physics parts to evaluate.</param>
    /// <param name="parts">Array of pointers to CPhysicsPart instances.</param>
    /// <param name="cell_array">Output array where found transit cells will be stored.</param>
    public void find_transit_cells(uint num_parts, ACBindings.Internal.CPhysicsPart** parts, ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandCell, uint, ACBindings.Internal.CPhysicsPart**, ACBindings.Internal.CELLARRAY*, void>)0x00534580)(ref this, num_parts, parts, cell_array);
}

