namespace ACBindings.Internal;

public unsafe struct COLLISIONINFO
{
    // Members
    public int last_known_contact_plane_valid;
    public ACBindings.Internal.Plane last_known_contact_plane;
    public int last_known_contact_plane_is_water;
    public int contact_plane_valid;
    public ACBindings.Internal.Plane contact_plane;
    public uint contact_plane_cell_id;
    public uint last_known_contact_plane_cell_id;
    public int contact_plane_is_water;
    public int sliding_normal_valid;
    public ACBindings.Internal.AC1Legacy.Vector3 sliding_normal;
    public int collision_normal_valid;
    public ACBindings.Internal.AC1Legacy.Vector3 collision_normal;
    public ACBindings.Internal.AC1Legacy.Vector3 adjust_offset;
    public uint num_collide_object;
    public ACBindings.Internal.DArray___CPhysicsObj_ptr collide_object;
    public ACBindings.Internal.CPhysicsObj* last_collided_object;
    public int collided_with_environment;
    public int frames_stationary_fall;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0050A830
    /// void __thiscall COLLISIONINFO::init(COLLISIONINFO*)</code>
    /// </summary>
    public void init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.COLLISIONINFO, void>)0x0050A830)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050A850
    /// void __thiscall COLLISIONINFO::set_contact_plane(COLLISIONINFO*,const Plane*,int)</code>
    /// </summary>
    public void set_contact_plane(ACBindings.Internal.Plane* plane, int is_water) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.COLLISIONINFO, ACBindings.Internal.Plane*, int, void>)0x0050A850)(ref this, plane, is_water);

    /// <summary>
    /// <code>Offset: 0x0050AAD0
    /// void __thiscall COLLISIONINFO::set_collision_normal(COLLISIONINFO*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void set_collision_normal(ACBindings.Internal.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.COLLISIONINFO, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x0050AAD0)(ref this, normal);

    /// <summary>
    /// <code>Offset: 0x0050AB30
    /// void __thiscall COLLISIONINFO::set_sliding_normal(COLLISIONINFO*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void set_sliding_normal(ACBindings.Internal.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.COLLISIONINFO, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x0050AB30)(ref this, normal);

    /// <summary>
    /// <code>Offset: 0x006B5D60
    /// void __thiscall COLLISIONINFO::add_object(COLLISIONINFO*,const CPhysicsObj*,TransitionState)</code>
    /// </summary>
    public void add_object(ACBindings.Internal.CPhysicsObj* object_, ACBindings.Internal.TransitionState ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.COLLISIONINFO, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.TransitionState, void>)0x006B5D60)(ref this, object_, ts);
}

