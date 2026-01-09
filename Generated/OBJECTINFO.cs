namespace ACBindings;

// OBJECTINFO
public unsafe struct OBJECTINFO
{
    // Members
    public ACBindings.CPhysicsObj* object_;
    public int state;
    public float scale;
    public float step_up_height;
    public float step_down_height;
    public int ethereal;
    public int step_down;
    public uint targetID;

    // Methods
    // int __thiscall OBJECTINFO::missile_ignore(OBJECTINFO*,const CPhysicsObj*)
    public int missile_ignore(ACBindings.CPhysicsObj* collideobject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.OBJECTINFO, ACBindings.CPhysicsObj*, int>)0x0050D980)(ref this, collideobject);
    // int __thiscall OBJECTINFO::is_valid_walkable(OBJECTINFO*,const AC1Legacy::Vector3*)
    public int is_valid_walkable(ACBindings.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.OBJECTINFO, ACBindings.AC1Legacy.Vector3*, int>)0x0050D9E0)(ref this, normal);
    // float __thiscall OBJECTINFO::get_walkable_z(OBJECTINFO*)
    public float get_walkable_z() => ((delegate* unmanaged[Thiscall]<ref ACBindings.OBJECTINFO, float>)0x0050D9F0)(ref this);
    // void __thiscall OBJECTINFO::init(OBJECTINFO*,CPhysicsObj*,int)
    public void init(ACBindings.CPhysicsObj* object_, int object_state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.OBJECTINFO, ACBindings.CPhysicsObj*, int, void>)0x0050DA00)(ref this, object_, object_state);
    // void __thiscall OBJECTINFO::kill_velocity(OBJECTINFO*)
    public void kill_velocity() => ((delegate* unmanaged[Thiscall]<ref ACBindings.OBJECTINFO, void>)0x0050DAB0)(ref this);
    // TransitionState __thiscall OBJECTINFO::validate_walkable(OBJECTINFO*,const CSphere*,const Plane*,const int,const float,SPHEREPATH*,COLLISIONINFO*,unsigned int)
    public ACBindings.TransitionState validate_walkable(ACBindings.CSphere* check_pos, ACBindings.Plane* contact_plane, int is_water, float water_depth, ACBindings.SPHEREPATH* path, ACBindings.COLLISIONINFO* collisions, uint land_cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.OBJECTINFO, ACBindings.CSphere*, ACBindings.Plane*, int, float, ACBindings.SPHEREPATH*, ACBindings.COLLISIONINFO*, uint, ACBindings.TransitionState>)0x0050DAE0)(ref this, check_pos, contact_plane, is_water, water_depth, path, collisions, land_cell_id);
}

// ObjectInfo
public unsafe struct ObjectInfo
{
    // Members
    public uint object_id;
    public uint hit_location;

    // Methods
}

