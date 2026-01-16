namespace ACBindings.Internal;


/// <summary>Tracks spherical bounds, positions, and collision data for navigation paths across multiple coordinate spaces, including local, global, and intermediate transformations.</summary>
public unsafe struct SPHEREPATH : System.IDisposable
{
    // Child Types
    // SPHEREPATH::InsertType
    public enum InsertType : uint
    {
        TRANSITION_INSERT = 0x0,
        PLACEMENT_INSERT = 0x1,
        INITIAL_PLACEMENT_INSERT = 0x2,
        FORCE_InsertType_32_BIT = 0x7FFFFFFF
    }

    // Members
    public uint num_sphere;
    public ACBindings.Internal.CSphere* local_sphere;
    public ACBindings.Internal.AC1Legacy.Vector3 local_low_point;
    public ACBindings.Internal.CSphere* global_sphere;
    public ACBindings.Internal.AC1Legacy.Vector3 global_low_point;
    public ACBindings.Internal.CSphere* localspace_sphere;
    public ACBindings.Internal.AC1Legacy.Vector3 localspace_low_point;
    public ACBindings.Internal.AC1Legacy.Vector3* localspace_curr_center;
    public ACBindings.Internal.AC1Legacy.Vector3* global_curr_center;
    public ACBindings.Internal.Position localspace_pos;
    public ACBindings.Internal.AC1Legacy.Vector3 localspace_z;
    public ACBindings.Internal.CObjCell* begin_cell;
    public ACBindings.Internal.Position* begin_pos;
    public ACBindings.Internal.Position* end_pos;
    public ACBindings.Internal.CObjCell* curr_cell;
    public ACBindings.Internal.Position curr_pos;
    public ACBindings.Internal.AC1Legacy.Vector3 global_offset;
    public int step_up;
    public ACBindings.Internal.AC1Legacy.Vector3 step_up_normal;
    public int collide;
    public ACBindings.Internal.CObjCell* check_cell;
    public ACBindings.Internal.Position check_pos;
    public ACBindings.Internal.SPHEREPATH.InsertType insert_type;
    public int step_down;
    public ACBindings.Internal.SPHEREPATH.InsertType backup;
    public ACBindings.Internal.CObjCell* backup_cell;
    public ACBindings.Internal.Position backup_check_pos;
    public int obstruction_ethereal;
    public int hits_interior_cell;
    public int bldg_check;
    public float walkable_allowance;
    public float walk_interp;
    public float step_down_amt;
    public ACBindings.Internal.CSphere walkable_check_pos;
    public ACBindings.Internal.CPolygon* walkable;
    public int check_walkable;
    public ACBindings.Internal.AC1Legacy.Vector3 walkable_up;
    public ACBindings.Internal.Position walkable_pos;
    public float walkable_scale;
    public int cell_array_valid;
    public int neg_step_up;
    public ACBindings.Internal.AC1Legacy.Vector3 neg_collision_normal;
    public int neg_poly_hit;
    public int placement_allows_sliding;

    // Generated Constructor
    public SPHEREPATH() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Updates the walkable check position with the provided sphere.
    /// <code>Offset: 0x0050A7B0
    /// void __thiscall SPHEREPATH::set_walkable_check_pos(SPHEREPATH*,const CSphere*)</code>
    /// </summary>
    /// <param name="sphere">Sphere defining the new walkable check location.</param>
    public void set_walkable_check_pos(ACBindings.Internal.CSphere* sphere) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.CSphere*, void>)0x0050A7B0)(ref this, sphere);

    /// <summary>Adds a positional offset to the path’s current check position, clears cached cell data, and updates the global sphere accordingly.
    /// <code>Offset: 0x0050A7E0
    /// void __thiscall SPHEREPATH::add_offset_to_check_pos(SPHEREPATH*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="offset">The offset vector applied to the check position.</param>
    public void add_offset_to_check_pos(ACBindings.Internal.AC1Legacy.Vector3* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x0050A7E0)(ref this, offset);

    /// <summary>Computes block offset between current position and check position, storing it in the supplied vector.
    /// <code>Offset: 0x0050AAA0
    /// AC1Legacy::Vector3* __thiscall SPHEREPATH::get_curr_pos_check_pos_block_offset(SPHEREPATH*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="result">Vector to receive computed offset.</param>
    /// <returns>Pointer to the vector containing the calculated offset.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* get_curr_pos_check_pos_block_offset(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x0050AAA0)(ref this, result);

    /// <summary>Stores the current collision check cell and position into backup fields for later restoration.
    /// <code>Offset: 0x0050B350
    /// void __thiscall SPHEREPATH::save_check_pos(SPHEREPATH*)</code>
    /// </summary>
    public void save_check_pos() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, void>)0x0050B350)(ref this);

    /// <summary>Sets the internal check position to a specified Position and associates it with a given CObjCell, resetting cached data for subsequent path calculations.
    /// <code>Offset: 0x0050B380
    /// void __thiscall SPHEREPATH::set_check_pos(SPHEREPATH*,const Position*,CObjCell*)</code>
    /// </summary>
    /// <param name="p">Position to use as the new check point.</param>
    /// <param name="cell">CObjCell representing the spatial context for the check.</param>
    public void set_check_pos(ACBindings.Internal.Position* p, ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.Position*, ACBindings.Internal.CObjCell*, void>)0x0050B380)(ref this, p, cell);

    /// <summary>Retrieves the current walkable position from a sphere path and stores it in the supplied Position object.
    /// <code>Offset: 0x0050B3C0
    /// const Position* __thiscall SPHEREPATH::get_walkable_pos(SPHEREPATH*,const Position*)</code>
    /// </summary>
    /// <param name="result">Destination Position to receive the walkable position.</param>
    /// <returns>Pointer to the Position containing the walkable position.</returns>
    public ACBindings.Internal.Position* get_walkable_pos(ACBindings.Internal.Position* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.Position*, ACBindings.Internal.Position*>)0x0050B3C0)(ref this, result);

    /// <summary>Restores the check position and cell from backup values, clears the validity flag, and updates the global sphere cache accordingly.
    /// <code>Offset: 0x0050BBD0
    /// void __thiscall SPHEREPATH::restore_check_pos(SPHEREPATH*)</code>
    /// </summary>
    public void restore_check_pos() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, void>)0x0050BBD0)(ref this);

    /// <summary>Resets all fields of a SPHEREPATH object, preparing it for use with default settings such as TRANSITION_INSERT insertion type and enabling sliding placement.
    /// <code>Offset: 0x0050CE00
    /// void __thiscall SPHEREPATH::init(SPHEREPATH*)</code>
    /// </summary>
    public void init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, void>)0x0050CE00)(ref this);

    /// <summary>Slides the object's collision sphere from its current global position, resetting any existing contact plane data and the step‑up flag before delegating to CSphere::slide_sphere.
    /// <code>Offset: 0x0050CE80
    /// TransitionState __thiscall SPHEREPATH::step_up_slide(SPHEREPATH*,OBJECTINFO*,COLLISIONINFO*)</code>
    /// </summary>
    /// <param name="object">Object information; unused in this routine.</param>
    /// <param name="collisions">Collision data that will be updated with slide results, including normals and validity flags.</param>
    /// <returns>TransitionState returned by CSphere::slide_sphere indicating the outcome of the sliding operation.</returns>
    public ACBindings.Internal.TransitionState step_up_slide(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.COLLISIONINFO* collisions) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.TransitionState>)0x0050CE80)(ref this, object_, collisions);

    /// <summary>Checks whether the current sphere position lies on a walkable polygon by querying the associated CPolygon with an adjusted collision sphere. Returns non‑zero when walkable, or 1 if no polygon is defined.
    /// <code>Offset: 0x0050CEB0
    /// int __thiscall SPHEREPATH::check_walkables(SPHEREPATH*)</code>
    /// </summary>
    /// <returns>An integer indicating walkability: zero for not walkable, non‑zero otherwise.</returns>
    public int check_walkables() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, int>)0x0050CEB0)(ref this);

    /// <summary>Initializes a SPHEREPATH instance by setting all position vectors to zero with an identity rotation, allocating internal sphere buffers and center vectors, then performing further setup via init().
    /// <code>Offset: 0x0050CF50
    /// void __thiscall SPHEREPATH::SPHEREPATH(SPHEREPATH*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, void>)0x0050CF50)(ref this);

    /// <summary>Destroys a SPHEREPATH instance by freeing any dynamically allocated sphere arrays and center vectors, then restoring the base‑class virtual table pointers to their default PackObj values.
    /// <code>Offset: 0x0050D0C0
    /// void __thiscall SPHEREPATH::~SPHEREPATH(SPHEREPATH*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, void>)0x0050D0C0)(ref this);

    /// <summary>Initializes a sphere path with up to two spheres, scaling their coordinates and computing the local low point based on the first sphere.
    /// <code>Offset: 0x0050D140
    /// void __thiscall SPHEREPATH::init_sphere(SPHEREPATH*,const unsigned int,const CSphere*,const float)</code>
    /// </summary>
    /// <summary>Updates internal members such as num_sphere, the local_sphere array, and local_low_point accordingly.
    /// <code>Offset: 0x0050D140
    /// void __thiscall SPHEREPATH::init_sphere(SPHEREPATH*,const unsigned int,const CSphere*,const float)</code>
    /// </summary>
    /// <param name="num_sphere">Maximum number of spheres to initialize (clamped to 2).</param>
    /// <param name="sphere">Pointer to an array of CSphere structures containing sphere data.</param>
    /// <param name="scale">Factor applied to sphere coordinates when copying into the local representation.</param>
    public void init_sphere(uint num_sphere, ACBindings.Internal.CSphere* sphere, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, uint, ACBindings.Internal.CSphere*, float, void>)0x0050D140)(ref this, num_sphere, sphere, scale);

    /// <summary>Transforms each local sphere center into world space using the current transform and stores the results in the global_curr_center array.
    /// <code>Offset: 0x0050D210
    /// void __thiscall SPHEREPATH::cache_global_curr_center(SPHEREPATH*)</code>
    /// </summary>
    public void cache_global_curr_center() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, void>)0x0050D210)(ref this);

    /// <summary>Updates the global sphere representations by applying an optional positional offset or transforming local spheres into world coordinates.
    /// <code>Offset: 0x0050D2E0
    /// void __thiscall SPHEREPATH::cache_global_sphere(SPHEREPATH*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="offset">Optional displacement added to existing global sphere centers and low point. If null, recomputes each global sphere from its corresponding local sphere using the current transform and updates the global low point accordingly.</param>
    public void cache_global_sphere(ACBindings.Internal.AC1Legacy.Vector3* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x0050D2E0)(ref this, offset);

    /// <summary>Precomputes sphere data in local space relative to a given position, applying the provided scale factor.
    /// <code>Offset: 0x0050D4A0
    /// void __thiscall SPHEREPATH::cache_localspace_sphere(SPHEREPATH*,const Position*,const float)</code>
    /// </summary>
    /// <param name="p">Position used as reference point and orientation for the transformation.</param>
    /// <param name="scale">Scale factor; radii are multiplied by its reciprocal during caching.</param>
    public void cache_localspace_sphere(ACBindings.Internal.Position* p, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.Position*, float, void>)0x0050D4A0)(ref this, p, scale);

    /// <summary>Adjusts the SPHEREPATH's internal check position to correspond with a given cell ID, applying terrain block offset for small IDs and updating cached global sphere data.
    /// <code>Offset: 0x0050D6D0
    /// void __thiscall SPHEREPATH::adjust_check_pos(SPHEREPATH*,unsigned int)</code>
    /// </summary>
    /// <param name="cell_id">The identifier of the cell to set as the new check position.</param>
    public void adjust_check_pos(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, uint, void>)0x0050D6D0)(ref this, cell_id);

    /// <summary>Slides the sphere path along a precipice by transforming the collision normal relative to the current walkable surface and invoking a sphere sliding routine.
    /// <code>Offset: 0x0050D750
    /// TransitionState __thiscall SPHEREPATH::precipice_slide(SPHEREPATH*,COLLISIONINFO*)</code>
    /// </summary>
    /// <param name="collisions">Collision information used during the sliding operation.</param>
    /// <returns>The resulting transition state, typically returned from CSphere::slide_sphere or 2 when no slide is performed.</returns>
    public ACBindings.Internal.TransitionState precipice_slide(ACBindings.Internal.COLLISIONINFO* collisions) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.TransitionState>)0x0050D750)(ref this, collisions);

    /// <summary>Initializes a sphere-based path by assigning start and end cells/positions, setting the current position, caching global center data, and determining the insertion type based on whether a starting position is supplied.
    /// <code>Offset: 0x0050D8F0
    /// void __thiscall SPHEREPATH::init_path(SPHEREPATH*,const CObjCell*,const Position*,const Position*)</code>
    /// </summary>
    /// <param name="begin_cell">The cell that contains the starting point of the path.</param>
    /// <param name="begin_pos">Optional pointer to the initial position within begin_cell; if null, the end position is used instead.</param>
    /// <param name="end_pos">Pointer to the terminal position for the path.</param>
    public void init_path(ACBindings.Internal.CObjCell* begin_cell, ACBindings.Internal.Position* begin_pos, ACBindings.Internal.Position* end_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.CObjCell*, ACBindings.Internal.Position*, ACBindings.Internal.Position*, void>)0x0050D8F0)(ref this, begin_cell, begin_pos, end_pos);

    /// <summary>Determines if a given vertical offset is larger than the stored walkable allowance threshold.
    /// <code>Offset: 0x00537610
    /// int __thiscall SPHEREPATH::is_walkable_allowable(SPHEREPATH*,float)</code>
    /// </summary>
    /// <param name="zval">The vertical offset to test against the allowance.</param>
    /// <returns>Non‑zero when the offset exceeds the allowance, zero otherwise.</returns>
    public int is_walkable_allowable(float zval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, float, int>)0x00537610)(ref this, zval);

    /// <summary>Adds an offset vector to the current check position and updates the global sphere cache accordingly, marking the cell array as invalid.
    /// <code>Offset: 0x005377A0
    /// void __thiscall SPHEREPATH::add_offset_to_check_pos(SPHEREPATH*,const AC1Legacy::Vector3*,const float)</code>
    /// </summary>
    /// <param name="offset">The vector whose components are added to the existing check position.</param>
    public void add_offset_to_check_pos(ACBindings.Internal.AC1Legacy.Vector3* offset, float radius) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.AC1Legacy.Vector3*, float, void>)0x005377A0)(ref this, offset, radius);

    /// <summary>Records a collision event on the sphere path, storing the collision normal and preserving current cell and position data.
    /// <code>Offset: 0x005385E0
    /// void __thiscall SPHEREPATH::set_collide(SPHEREPATH*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="collision_normal">The normal vector describing the collision surface direction.</param>
    public void set_collide(ACBindings.Internal.AC1Legacy.Vector3* collision_normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x005385E0)(ref this, collision_normal);

    /// <summary>Records a negative polygon hit by storing the supplied step‑up value and the inverted collision normal for later use.
    /// <code>Offset: 0x0053A640
    /// void __thiscall SPHEREPATH::set_neg_poly_hit(SPHEREPATH*,int,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="step_up">The amount of negative step up applied when moving against a polygon during reverse traversal.</param>
    /// <param name="collision_normal">Pointer to the vector representing the collision normal; its negated form is stored internally.</param>
    public void set_neg_poly_hit(int step_up, ACBindings.Internal.AC1Legacy.Vector3* collision_normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, int, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x0053A640)(ref this, step_up, collision_normal);

    /// <summary>Configures the walkability detection parameters for a SPHEREPATH instance, including sphere geometry, surface polygon, orientation axis, local position reference, and scaling factor.
    /// <code>Offset: 0x0053AD20
    /// void __thiscall SPHEREPATH::set_walkable(SPHEREPATH*,const CSphere*,const CPolygon*,const AC1Legacy::Vector3*,const Position*,float)</code>
    /// </summary>
    /// <param name="sphere">Sphere used to compute the walkable check position.</param>
    /// <param name="poly">Polygon representing the surface to be considered walkable.</param>
    /// <param name="zaxis">Vector defining the up direction relative to the sphere.</param>
    /// <param name="local_pos">Position providing cell ID and frame for local placement of the walkable area.</param>
    /// <param name="scale">Scaling factor applied to the walkable check distance and radius.</param>
    public void set_walkable(ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CPolygon* poly, ACBindings.Internal.AC1Legacy.Vector3* zaxis, ACBindings.Internal.Position* local_pos, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.CSphere*, ACBindings.Internal.CPolygon*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Position*, float, void>)0x0053AD20)(ref this, sphere, poly, zaxis, local_pos, scale);
}

