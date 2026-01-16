namespace ACBindings.Internal;


/// <summary>Manages an object’s movement through a spatial grid by tracking collision data, sphere path, and associated cell information for transitions in the physics engine.</summary>
/// <remarks>Used by the transition system to handle placement, stepping, sliding, and validation of objects during simulation.</remarks>
public unsafe struct CTransition
{
    // Statics
    public static int* transition_level = (int*)0x00842C6C;

    // Members
    public ACBindings.Internal.OBJECTINFO object_info;
    public ACBindings.Internal.SPHEREPATH sphere_path;
    public ACBindings.Internal.COLLISIONINFO collision_info;
    public ACBindings.Internal.CELLARRAY cell_array;
    public ACBindings.Internal.CObjCell* new_cell_ptr;

    // Generated Constructor
    public CTransition() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Decrements the global transition counter when a transition finishes.
    /// <code>Offset: 0x0050A890
    /// void __cdecl CTransition::cleanupTransition(CTransition*)</code>
    /// </summary>
    /// <param name="transit">The transition instance being cleaned up.</param>
    public static void cleanupTransition(ACBindings.Internal.CTransition* transit) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CTransition*, void>)0x0050A890)(transit);

    /// <summary>Resets all fields of a CTransition instance to their default values, clearing state and collision information.
    /// <code>Offset: 0x0050A8A0
    /// void __thiscall CTransition::init(CTransition*)</code>
    /// </summary>
    public void init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, void>)0x0050A8A0)(ref this);

    /// <summary>Initializes the transition object's sphere path using the supplied spheres and scale.
    /// <code>Offset: 0x0050A920
    /// void __thiscall CTransition::init_sphere(CTransition*,const unsigned int,const CSphere*,const float)</code>
    /// </summary>
    /// <param name="num_sphere">Number of spheres to be used in the path definition.</param>
    /// <param name="sphere">Array of CSphere structures describing center positions and radii.</param>
    /// <param name="scale">Scaling factor applied to each sphere's radius during initialization.</param>
    public void init_sphere(uint num_sphere, ACBindings.Internal.CSphere* sphere, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, uint, ACBindings.Internal.CSphere*, float, void>)0x0050A920)(ref this, num_sphere, sphere, scale);

    /// <summary>Initializes the sphere path for a transition using specified start cell and positions.
    /// <code>Offset: 0x0050A930
    /// void __thiscall CTransition::init_path(CTransition*,const CObjCell*,const Position*,const Position*)</code>
    /// </summary>
    /// <param name="begin_cell">The cell from which the transition begins.</param>
    /// <param name="begin_pos">Position data marking the starting point of the transition within the begin cell.</param>
    /// <param name="end_pos">Target position defining where the transition ends.</param>
    public void init_path(ACBindings.Internal.CObjCell* begin_cell, ACBindings.Internal.Position* begin_pos, ACBindings.Internal.Position* end_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.CObjCell*, ACBindings.Internal.Position*, ACBindings.Internal.Position*, void>)0x0050A930)(ref this, begin_cell, begin_pos, end_pos);

    /// <summary>Attempts to insert the transition into a specified object cell, retrying on sliding collisions up to a given number of attempts.
    /// <code>Offset: 0x0050A940
    /// TransitionState __thiscall CTransition::insert_into_cell(CTransition*,const CObjCell*,int)</code>
    /// </summary>
    /// <param name="cell">The target object cell for the insertion; must not be null, otherwise the method returns a failure state.</param>
    /// <param name="num_insertion_attempts">Maximum number of retries after encountering a slide collision before giving up.</param>
    /// <returns>TransitionState indicating the outcome: OK_TS for success, COLLIDED_TS if a collision prevented entry, SLID_TS when the transition slid and may be retried, or another status if retries are exhausted or the cell is null.</returns>
    public ACBindings.Internal.TransitionState insert_into_cell(ACBindings.Internal.CObjCell* cell, int num_insertion_attempts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.CObjCell*, int, ACBindings.Internal.TransitionState>)0x0050A940)(ref this, cell, num_insertion_attempts);

    /// <summary>Builds the cell array for the transition, marking the path as valid and clearing interior hit count before locating relevant cells.
    /// <code>Offset: 0x0050A9B0
    /// void __thiscall CTransition::build_cell_array(CTransition*,CObjCell**)</code>
    /// </summary>
    /// <param name="new_cell_p">Pointer to a CObjCell instance used in cell list construction.</param>
    public void build_cell_array(ACBindings.Internal.CObjCell** new_cell_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.CObjCell**, void>)0x0050A9B0)(ref this, new_cell_p);

    /// <summary>
    /// Computes the displacement between a transition’s start and end positions, then determines per‑step displacement and total step count needed to traverse that distance along a spherical path.
    /// 
    /// <code>Offset: 0x0050AB80
    /// void __thiscall CTransition::calc_num_steps(CTransition*,AC1Legacy::Vector3*,AC1Legacy::Vector3*,unsigned int*)</code>
    /// </summary>
    /// <param name="offset">Output vector representing the difference from the beginning position to the ending position.</param>
    /// <param name="offset_per_step">Output vector giving the incremental movement for each step of the transition.</param>
    /// <param name="num_steps">Output count of how many steps are required to reach the target position following the path constraints.</param>
    public void calc_num_steps(ACBindings.Internal.AC1Legacy.Vector3* offset, ACBindings.Internal.AC1Legacy.Vector3* offset_per_step, uint* num_steps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, uint*, void>)0x0050AB80)(ref this, offset, offset_per_step, num_steps);

    /// <summary>Adjusts a given offset vector by applying collision normals, contact plane corrections, and terrain adjustments so that the resulting position respects environmental constraints.
    /// <code>Offset: 0x0050AE40
    /// AC1Legacy::Vector3* __thiscall CTransition::adjust_offset(CTransition*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="result">Pointer to the Vector3 that will receive the corrected offset.</param>
    /// <param name="offset">The original offset vector before any adjustment is applied.</param>
    /// <returns>Returns a pointer to the result vector containing the adjusted values.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* adjust_offset(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.AC1Legacy.Vector3* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x0050AE40)(ref this, result, offset);

    /// <summary>Computes the sliding direction when an object contacts a cliff, updates the sphere path offset accordingly, and sets the collision normal for subsequent physics processing.
    /// <code>Offset: 0x0050B1A0
    /// TransitionState __thiscall CTransition::cliff_slide(CTransition*,const Plane*)</code>
    /// </summary>
    /// <param name="contact_plane">The plane representing the current contact surface.</param>
    /// <returns>A TransitionState value: 1 if the computed slide vector is too small to act upon; otherwise 3 indicating a successful cliff-slide transition.</returns>
    public ACBindings.Internal.TransitionState cliff_slide(ACBindings.Internal.Plane* contact_plane) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.Plane*, ACBindings.Internal.TransitionState>)0x0050B1A0)(ref this, contact_plane);

    /// <summary>Initializes a new CTransition instance by resetting all member fields to default values and preparing internal structures for use in the transition system.
    /// <code>Offset: 0x0050B450
    /// void __thiscall CTransition::CTransition(CTransition*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, void>)0x0050B450)(ref this);

    /// <summary>Determines if the supplied physics object intersects any objects within the transition’s current cell using the transition’s sphere path.
    /// <code>Offset: 0x0050B4D0
    /// int __thiscall CTransition::check_collisions(CTransition*,const CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object to test for collisions.</param>
    /// <returns>Non‑zero when a collision occurs; zero otherwise.</returns>
    public int check_collisions(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.CPhysicsObj*, int>)0x0050B4D0)(ref this, object_);

    /// <summary>Validates a transition based on the object's current position, collision data, and surrounding cells, updating internal flags accordingly.
    /// <code>Offset: 0x0050B540
    /// TransitionState __thiscall CTransition::validate_transition(CTransition*,TransitionState,int*)</code>
    /// </summary>
    /// <param name="ts">The desired transition state to validate.</param>
    /// <param name="redo">Pointer to an int flag that is reset to 0; no additional validation pass is required.</param>
    /// <returns>The validated TransitionState, which may be adjusted from the requested value.</returns>
    public ACBindings.Internal.TransitionState validate_transition(ACBindings.Internal.TransitionState ts, int* redo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.TransitionState, int*, ACBindings.Internal.TransitionState>)0x0050B540)(ref this, ts, redo);

    /// <summary>Validates a transition for a sphere path, updating its current position or preparing collision data based on the supplied transition state.
    /// <code>Offset: 0x0050B890
    /// TransitionState __thiscall CTransition::validate_placement_transition(CTransition*,TransitionState,int*)</code>
    /// </summary>
    /// <param name="ts">The transition state to validate; may be OK, sliding, or an error code.</param>
    /// <param name="redo">Output flag set to zero; indicates whether the operation should be retried (always zero in this implementation).</param>
    /// <returns>The resulting TransitionState after validation, which may be unchanged, updated to OK, or remain an error code if no valid cell is found.</returns>
    public ACBindings.Internal.TransitionState validate_placement_transition(ACBindings.Internal.TransitionState ts, int* redo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.TransitionState, int*, ACBindings.Internal.TransitionState>)0x0050B890)(ref this, ts, redo);

    /// <summary>Determines the result of a transition by examining adjacent cells relative to the current cell and updating the internal sphere path state accordingly.
    /// <code>Offset: 0x0050B920
    /// TransitionState __thiscall CTransition::check_other_cells(CTransition*,const CObjCell*)</code>
    /// </summary>
    /// <param name="this">The transition object containing sphere path and collision data.</param>
    /// <param name="curr_cell">The cell currently being evaluated during the transition.</param>
    /// <returns>A TransitionState indicating whether a collision, adjustment, slide or other outcome occurred while checking neighboring cells.</returns>
    public ACBindings.Internal.TransitionState check_other_cells(ACBindings.Internal.CObjCell* curr_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.CObjCell*, ACBindings.Internal.TransitionState>)0x0050B920)(ref this, curr_cell);

    /// <summary>Determines whether the transition object can be walked on at its current position, applying a vertical offset before performing a collision check.
    /// <code>Offset: 0x0050BAC0
    /// int __thiscall CTransition::check_walkable(CTransition*,float)</code>
    /// </summary>
    /// <param name="z_chk">Vertical allowance added to the walkability test.</param>
    /// <returns>Non‑zero if the position is considered walkable; zero otherwise.</returns>
    public int check_walkable(float z_chk) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, float, int>)0x0050BAC0)(ref this, z_chk);

    /// <summary>Creates a new transition instance from an internal pool, initializing it for use. If the maximum number of transitions has already been allocated, returns nullptr.
    /// <code>Offset: 0x0050BC20
    /// CTransition* __cdecl CTransition::makeTransition()</code>
    /// </summary>
    /// <returns>A pointer to the newly created CTransition object, or nullptr if no more transitions are available.</returns>
    public static ACBindings.Internal.CTransition* makeTransition() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CTransition*>)0x0050BC20)();

    /// <summary>Attempts to place the transition into its designated cell, performing an initial insertion followed by validation against adjacent cells.
    /// <code>Offset: 0x0050BCA0
    /// TransitionState __thiscall CTransition::placement_insert(CTransition*)</code>
    /// </summary>
    /// <returns>The resulting TransitionState reflecting success (OK_TS) or the specific error state returned during insertion or subsequent checks.</returns>
    public ACBindings.Internal.TransitionState placement_insert() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.TransitionState>)0x0050BCA0)(ref this);

    /// <summary>Validates the transition placement, updating the current position when the state is OK and handling collisions by inserting a new placement if allowed.
    /// <code>Offset: 0x0050BCE0
    /// TransitionState __thiscall CTransition::validate_placement(CTransition*,TransitionState,int)</code>
    /// </summary>
    /// <param name="ts">The current transition state to validate.</param>
    /// <param name="adjust">Flag indicating whether collision adjustments are permitted; used for recursive validation after insertion.</param>
    /// <returns>The resulting TransitionState after processing.</returns>
    public ACBindings.Internal.TransitionState validate_placement(ACBindings.Internal.TransitionState ts, int adjust) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.TransitionState, int, ACBindings.Internal.TransitionState>)0x0050BCE0)(ref this, ts, adjust);

    /// <summary>Attempts a downward transition by lowering the object's sphere position and performing collision checks to determine if the move is valid.
    /// <code>Offset: 0x0050BD70
    /// int __thiscall CTransition::step_down(CTransition*,float,float)</code>
    /// </summary>
    /// <param name="step_down_ht">The vertical distance to lower the object's sphere during the step down operation.</param>
    /// <param name="z_val">A threshold for the Z component of the contact plane normal used in walkability validation.</param>
    /// <returns>Non‑zero if the transition succeeded; zero if it failed due to an invalid state, collision, or non‑walkable surface.</returns>
    public int step_down(float step_down_ht, float z_val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, float, float, int>)0x0050BD70)(ref this, step_down_ht, z_val);

    /// <summary>Executes edge sliding logic for a transition object, adjusting the sphere path and collision information based on walkability, contact planes, and step‑down height.
    /// <code>Offset: 0x0050BEA0
    /// int __thiscall CTransition::edge_slide(CTransition*,TransitionState*,float,float)</code>
    /// </summary>
    /// <param name="ts">Receives the resulting TransitionState after processing the slide.</param>
    /// <param name="step_down_ht">The vertical distance to step down if a step is required.</param>
    /// <param name="z_val">Z‑coordinate threshold used for cliff detection.</param>
    /// <returns>Zero when a cliff slide occurs; non‑zero otherwise, indicating that a collision or other transition state has been set.</returns>
    public int edge_slide(ACBindings.Internal.TransitionState* ts, float step_down_ht, float z_val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.TransitionState*, float, float, int>)0x0050BEA0)(ref this, ts, step_down_ht, z_val);

    /// <summary>Attempts to move the transition object upward along a surface normal, updating its sphere path and invoking step‑down logic.
    /// <code>Offset: 0x0050C0E0
    /// int __thiscall CTransition::step_up(CTransition*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="collision_normal">The collision normal that triggers the step‑up action.</param>
    /// <returns>Non‑zero if the step‑up succeeded; zero otherwise.</returns>
    public int step_up(ACBindings.Internal.AC1Legacy.Vector3* collision_normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0050C0E0)(ref this, collision_normal);

    /// <summary>Attempts to insert an object’s collision sphere into the spatial grid, performing collision checks and positional adjustments such as stepping down or sliding until a valid position is found or the maximum number of attempts is exhausted.
    /// <code>Offset: 0x0050C1C0
    /// TransitionState __thiscall CTransition::transitional_insert(CTransition*,int)</code>
    /// </summary>
    /// <param name="num_insertion_attempts">Maximum number of insertion trials before aborting; zero or negative values result in immediate failure.</param>
    /// <returns>TransitionState value indicating the outcome: OK_TS for successful placement, COLLIDED_TS if a collision prevents insertion, ADJUSTED_TS or SLID_TS when position is modified during the process, and INVALID_TS when insertion fails entirely.</returns>
    public ACBindings.Internal.TransitionState transitional_insert(int num_insertion_attempts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, int, ACBindings.Internal.TransitionState>)0x0050C1C0)(ref this, num_insertion_attempts);

    /// <summary>Attempts to locate a valid placement for the transition sphere by iteratively testing offset positions around its current location. Returns 1 when a suitable position is found, otherwise returns 0.
    /// <code>Offset: 0x0050C520
    /// int __thiscall CTransition::find_placement_pos(CTransition*)</code>
    /// </summary>
    /// <returns>Returns 1 if a valid placement was located; returns 0 if no placement could be determined or sliding is not allowed.</returns>
    public int find_placement_pos() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, int>)0x0050C520)(ref this);

    /// <summary>Determines a valid transitional position for an object moving along its sphere path by iterating through steps, adjusting offsets, and validating placement or collision constraints. Returns 1 if a suitable position is found; otherwise returns 0.
    /// <code>Offset: 0x0050C8C0
    /// int __thiscall CTransition::find_transitional_position(CTransition*)</code>
    /// </summary>
    /// <returns>Integer flag: 1 indicates success in finding a transitional position; 0 indicates failure.</returns>
    public int find_transitional_position() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, int>)0x0050C8C0)(ref this);

    /// <summary>Attempts to determine a valid placement position for the transition object, performing collision checks, step‑down adjustments, and final validation before confirming placement.
    /// <code>Offset: 0x0050CC40
    /// int __thiscall CTransition::find_placement_position(CTransition*)</code>
    /// </summary>
    /// <returns>Non‑zero if placement is valid; zero otherwise.</returns>
    public int find_placement_position() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, int>)0x0050CC40)(ref this);

    /// <summary>Determines a suitable transition position by delegating to either placement or transitional logic based on the sphere path's insert type.
    /// <code>Offset: 0x0050CDE0
    /// int __thiscall CTransition::find_valid_position(CTransition*)</code>
    /// </summary>
    /// <returns>An integer indicating the found position (or an error code if none is available).</returns>
    public int find_valid_position() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, int>)0x0050CDE0)(ref this);

    /// <summary>Initializes contact plane information for the transition, marking it as valid and storing the plane data along with its associated cell ID and water flag.
    /// <code>Offset: 0x0050F320
    /// void __thiscall CTransition::init_contact_plane(CTransition*,unsigned int,const Plane*,int)</code>
    /// </summary>
    /// <param name="cell_id">Identifier of the cell where the contact occurs.</param>
    /// <param name="plane">Pointer to a Plane structure defining the contact plane's normal and offset.</param>
    /// <param name="is_water">Flag indicating whether the contact plane represents a water surface (non‑zero for water).</param>
    public void init_contact_plane(uint cell_id, ACBindings.Internal.Plane* plane, int is_water) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, uint, ACBindings.Internal.Plane*, int, void>)0x0050F320)(ref this, cell_id, plane, is_water);

    /// <summary>Sets the transition’s collision information to reflect the most recent contact plane, marking it valid and storing the associated cell ID and water status.
    /// <code>Offset: 0x0050F3B0
    /// void __thiscall CTransition::init_last_known_contact_plane(CTransition*,unsigned int,const Plane*,int)</code>
    /// </summary>
    /// <param name="cell_id">Identifier of the cell where the contact occurred.</param>
    /// <param name="plane">Plane describing the surface that was contacted.</param>
    /// <param name="is_water">Non‑zero if the plane represents a water surface; zero otherwise.</param>
    public void init_last_known_contact_plane(uint cell_id, ACBindings.Internal.Plane* plane, int is_water) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, uint, ACBindings.Internal.Plane*, int, void>)0x0050F3B0)(ref this, cell_id, plane, is_water);

    /// <summary>Initializes the collision sliding normal from a given 2D direction, ensuring it is properly normalized or cleared when too small.
    /// <code>Offset: 0x005109F0
    /// void __thiscall CTransition::init_sliding_normal(CTransition*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="normal">The input vector representing the desired sliding direction; its z component is ignored.</param>
    public void init_sliding_normal(ACBindings.Internal.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x005109F0)(ref this, normal);
}

