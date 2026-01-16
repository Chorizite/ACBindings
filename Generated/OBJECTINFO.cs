namespace ACBindings.Internal;


/// <summary>Stores runtime physics and movement attributes for an in‑world object, including its reference to a CPhysicsObj, scaling, step dimensions, state flags, and target relation information used by collision and navigation routines.</summary>
public unsafe struct OBJECTINFO
{
    // Members
    public ACBindings.Internal.CPhysicsObj* object_;
    public int state;
    public float scale;
    public float step_up_height;
    public float step_down_height;
    public int ethereal;
    public int step_down;
    public uint targetID;

    // Methods

    /// <summary>Determines whether a missile should disregard collisions with the specified physics object based on state flags and target relationships.
    /// <code>Offset: 0x0050D980
    /// int __thiscall OBJECTINFO::missile_ignore(OBJECTINFO*,const CPhysicsObj*)</code>
    /// </summary>
    /// <param name="collideobject">The physics object potentially colliding with the missile.</param>
    /// <returns>Non-zero if the missile must ignore the collision; zero otherwise.</returns>
    public int missile_ignore(ACBindings.Internal.CPhysicsObj* collideobject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OBJECTINFO, ACBindings.Internal.CPhysicsObj*, int>)0x0050D980)(ref this, collideobject);

    /// <summary>Checks whether the object's surface defined by the given normal vector is walkable.
    /// <code>Offset: 0x0050D9E0
    /// int __thiscall OBJECTINFO::is_valid_walkable(OBJECTINFO*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="normal">The surface normal to test for walkability.</param>
    /// <returns>Non‑zero if the surface is walkable; zero otherwise.</returns>
    public int is_valid_walkable(ACBindings.Internal.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OBJECTINFO, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0050D9E0)(ref this, normal);

    /// <summary>Retrieves the Z‑coordinate of the walkable surface for the object.
    /// <code>Offset: 0x0050D9F0
    /// float __thiscall OBJECTINFO::get_walkable_z(OBJECTINFO*)</code>
    /// </summary>
    /// <returns>The current floor level in world coordinates.</returns>
    public float get_walkable_z() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OBJECTINFO, float>)0x0050D9F0)(ref this);

    /// <summary>
    /// Initializes this OBJECTINFO instance from the given CPhysicsObj and state, copying attributes such as scale and step heights while setting internal flags that reflect the physics object’s properties.
    /// 
    /// <code>Offset: 0x0050DA00
    /// void __thiscall OBJECTINFO::init(OBJECTINFO*,CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="object">The CPhysicsObj to associate with this OBJECTINFO.</param>
    /// <param name="object_state">An integer representing the initial state for this OBJECTINFO; may be combined with additional flags derived from the physics object's characteristics.</param>
    public void init(ACBindings.Internal.CPhysicsObj* object_, int object_state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OBJECTINFO, ACBindings.Internal.CPhysicsObj*, int, void>)0x0050DA00)(ref this, object_, object_state);

    /// <summary>Halts motion of the physics object by resetting its velocity to zero.
    /// <code>Offset: 0x0050DAB0
    /// void __thiscall OBJECTINFO::kill_velocity(OBJECTINFO*)</code>
    /// </summary>
    public void kill_velocity() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OBJECTINFO, void>)0x0050DAB0)(ref this);

    /// <summary>Validates whether an object's sphere can walk on a plane, updating collision information and path adjustments based on surface type, water depth, stepping parameters, and the object's current state.
    /// <code>Offset: 0x0050DAE0
    /// TransitionState __thiscall OBJECTINFO::validate_walkable(OBJECTINFO*,const CSphere*,const Plane*,const int,const float,SPHEREPATH*,COLLISIONINFO*,unsigned int)</code>
    /// </summary>
    /// <param name="check_pos">Sphere position and radius used for the walkability check.</param>
    /// <param name="contact_plane">Plane against which the sphere is evaluated.</param>
    /// <param name="is_water">Indicates whether the plane represents a water surface.</param>
    /// <param name="water_depth">Depth of water to consider when evaluating a water surface.</param>
    /// <param name="path">Path structure used for recording offsets, stepping information, and walkable checks.</param>
    /// <param name="collisions">Collision info structure updated with normals and plane data.</param>
    /// <param name="land_cell_id">Identifier of the cell where the collision occurs.</param>
    /// <returns>TransitionState representing the outcome of the validation (e.g., OK, ADJUSTED, or other states).</returns>
    public ACBindings.Internal.TransitionState validate_walkable(ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.Plane* contact_plane, int is_water, float water_depth, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, uint land_cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OBJECTINFO, ACBindings.Internal.CSphere*, ACBindings.Internal.Plane*, int, float, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, uint, ACBindings.Internal.TransitionState>)0x0050DAE0)(ref this, check_pos, contact_plane, is_water, water_depth, path, collisions, land_cell_id);
}


/// <summary>Captures an object's identifier and the specific point of impact within its geometry.</summary>
public unsafe struct ObjectInfo
{
    // Members
    public uint object_id;
    public uint hit_location;

    // Methods
}

