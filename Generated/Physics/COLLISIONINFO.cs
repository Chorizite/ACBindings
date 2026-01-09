namespace ACBindings;

// COLLISIONINFO
public unsafe struct COLLISIONINFO
{
    // Members
    public int last_known_contact_plane_valid;
    public ACBindings.Plane last_known_contact_plane;
    public int last_known_contact_plane_is_water;
    public int contact_plane_valid;
    public ACBindings.Plane contact_plane;
    public uint contact_plane_cell_id;
    public uint last_known_contact_plane_cell_id;
    public int contact_plane_is_water;
    public int sliding_normal_valid;
    public ACBindings.AC1Legacy.Vector3 sliding_normal;
    public int collision_normal_valid;
    public ACBindings.AC1Legacy.Vector3 collision_normal;
    public ACBindings.AC1Legacy.Vector3 adjust_offset;
    public uint num_collide_object;
    public ACBindings.DArray__CPhysicsObj_ptr collide_object;
    public ACBindings.CPhysicsObj* last_collided_object;
    public int collided_with_environment;
    public int frames_stationary_fall;

    // Methods
    // void __thiscall COLLISIONINFO::init(COLLISIONINFO*)
    public void init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.COLLISIONINFO, void>)0x0050A830)(ref this);
    // void __thiscall COLLISIONINFO::set_contact_plane(COLLISIONINFO*,const Plane*,int)
    public void set_contact_plane(ACBindings.Plane* plane, int is_water) => ((delegate* unmanaged[Thiscall]<ref ACBindings.COLLISIONINFO, ACBindings.Plane*, int, void>)0x0050A850)(ref this, plane, is_water);
    // void __thiscall COLLISIONINFO::set_collision_normal(COLLISIONINFO*,const AC1Legacy::Vector3*)
    public void set_collision_normal(ACBindings.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.COLLISIONINFO, ACBindings.AC1Legacy.Vector3*, void>)0x0050AAD0)(ref this, normal);
    // void __thiscall COLLISIONINFO::set_sliding_normal(COLLISIONINFO*,const AC1Legacy::Vector3*)
    public void set_sliding_normal(ACBindings.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.COLLISIONINFO, ACBindings.AC1Legacy.Vector3*, void>)0x0050AB30)(ref this, normal);
    // void __thiscall COLLISIONINFO::add_object(COLLISIONINFO*,const CPhysicsObj*,TransitionState)
    public void add_object(ACBindings.CPhysicsObj* object_, ACBindings.TransitionState ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.COLLISIONINFO, ACBindings.CPhysicsObj*, ACBindings.TransitionState, void>)0x006B5D60)(ref this, object_, ts);
}

