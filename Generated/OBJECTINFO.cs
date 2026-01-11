namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0050D980
    /// int __thiscall OBJECTINFO::missile_ignore(OBJECTINFO*,const CPhysicsObj*)</code>
    /// </summary>
    public int missile_ignore(ACBindings.Internal.CPhysicsObj* collideobject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OBJECTINFO, ACBindings.Internal.CPhysicsObj*, int>)0x0050D980)(ref this, collideobject);

    /// <summary>
    /// <code>Offset: 0x0050D9E0
    /// int __thiscall OBJECTINFO::is_valid_walkable(OBJECTINFO*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int is_valid_walkable(ACBindings.Internal.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OBJECTINFO, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0050D9E0)(ref this, normal);

    /// <summary>
    /// <code>Offset: 0x0050D9F0
    /// float __thiscall OBJECTINFO::get_walkable_z(OBJECTINFO*)</code>
    /// </summary>
    public float get_walkable_z() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OBJECTINFO, float>)0x0050D9F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050DA00
    /// void __thiscall OBJECTINFO::init(OBJECTINFO*,CPhysicsObj*,int)</code>
    /// </summary>
    public void init(ACBindings.Internal.CPhysicsObj* object_, int object_state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OBJECTINFO, ACBindings.Internal.CPhysicsObj*, int, void>)0x0050DA00)(ref this, object_, object_state);

    /// <summary>
    /// <code>Offset: 0x0050DAB0
    /// void __thiscall OBJECTINFO::kill_velocity(OBJECTINFO*)</code>
    /// </summary>
    public void kill_velocity() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OBJECTINFO, void>)0x0050DAB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050DAE0
    /// TransitionState __thiscall OBJECTINFO::validate_walkable(OBJECTINFO*,const CSphere*,const Plane*,const int,const float,SPHEREPATH*,COLLISIONINFO*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState validate_walkable(ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.Plane* contact_plane, int is_water, float water_depth, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, uint land_cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.OBJECTINFO, ACBindings.Internal.CSphere*, ACBindings.Internal.Plane*, int, float, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, uint, ACBindings.Internal.TransitionState>)0x0050DAE0)(ref this, check_pos, contact_plane, is_water, water_depth, path, collisions, land_cell_id);
}

public unsafe struct ObjectInfo
{
    // Members
    public uint object_id;
    public uint hit_location;

    // Methods
}

