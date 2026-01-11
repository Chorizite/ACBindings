namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0050A7B0
    /// void __thiscall SPHEREPATH::set_walkable_check_pos(SPHEREPATH*,const CSphere*)</code>
    /// </summary>
    public void set_walkable_check_pos(ACBindings.Internal.CSphere* sphere) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.CSphere*, void>)0x0050A7B0)(ref this, sphere);

    /// <summary>
    /// <code>Offset: 0x0050A7E0
    /// void __thiscall SPHEREPATH::add_offset_to_check_pos(SPHEREPATH*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void add_offset_to_check_pos(ACBindings.Internal.AC1Legacy.Vector3* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x0050A7E0)(ref this, offset);

    /// <summary>
    /// <code>Offset: 0x0050AAA0
    /// AC1Legacy::Vector3* __thiscall SPHEREPATH::get_curr_pos_check_pos_block_offset(SPHEREPATH*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* get_curr_pos_check_pos_block_offset(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x0050AAA0)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x0050B350
    /// void __thiscall SPHEREPATH::save_check_pos(SPHEREPATH*)</code>
    /// </summary>
    public void save_check_pos() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, void>)0x0050B350)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050B380
    /// void __thiscall SPHEREPATH::set_check_pos(SPHEREPATH*,const Position*,CObjCell*)</code>
    /// </summary>
    public void set_check_pos(ACBindings.Internal.Position* p, ACBindings.Internal.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.Position*, ACBindings.Internal.CObjCell*, void>)0x0050B380)(ref this, p, cell);

    /// <summary>
    /// <code>Offset: 0x0050B3C0
    /// const Position* __thiscall SPHEREPATH::get_walkable_pos(SPHEREPATH*,const Position*)</code>
    /// </summary>
    public ACBindings.Internal.Position* get_walkable_pos(ACBindings.Internal.Position* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.Position*, ACBindings.Internal.Position*>)0x0050B3C0)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x0050BBD0
    /// void __thiscall SPHEREPATH::restore_check_pos(SPHEREPATH*)</code>
    /// </summary>
    public void restore_check_pos() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, void>)0x0050BBD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050CE00
    /// void __thiscall SPHEREPATH::init(SPHEREPATH*)</code>
    /// </summary>
    public void init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, void>)0x0050CE00)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050CE80
    /// TransitionState __thiscall SPHEREPATH::step_up_slide(SPHEREPATH*,OBJECTINFO*,COLLISIONINFO*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState step_up_slide(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.COLLISIONINFO* collisions) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.TransitionState>)0x0050CE80)(ref this, object_, collisions);

    /// <summary>
    /// <code>Offset: 0x0050CEB0
    /// int __thiscall SPHEREPATH::check_walkables(SPHEREPATH*)</code>
    /// </summary>
    public int check_walkables() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, int>)0x0050CEB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050CF50
    /// void __thiscall SPHEREPATH::SPHEREPATH(SPHEREPATH*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, void>)0x0050CF50)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050D0C0
    /// void __thiscall SPHEREPATH::~SPHEREPATH(SPHEREPATH*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, void>)0x0050D0C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050D140
    /// void __thiscall SPHEREPATH::init_sphere(SPHEREPATH*,const unsigned int,const CSphere*,const float)</code>
    /// </summary>
    public void init_sphere(uint num_sphere, ACBindings.Internal.CSphere* sphere, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, uint, ACBindings.Internal.CSphere*, float, void>)0x0050D140)(ref this, num_sphere, sphere, scale);

    /// <summary>
    /// <code>Offset: 0x0050D210
    /// void __thiscall SPHEREPATH::cache_global_curr_center(SPHEREPATH*)</code>
    /// </summary>
    public void cache_global_curr_center() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, void>)0x0050D210)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050D2E0
    /// void __thiscall SPHEREPATH::cache_global_sphere(SPHEREPATH*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void cache_global_sphere(ACBindings.Internal.AC1Legacy.Vector3* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x0050D2E0)(ref this, offset);

    /// <summary>
    /// <code>Offset: 0x0050D4A0
    /// void __thiscall SPHEREPATH::cache_localspace_sphere(SPHEREPATH*,const Position*,const float)</code>
    /// </summary>
    public void cache_localspace_sphere(ACBindings.Internal.Position* p, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.Position*, float, void>)0x0050D4A0)(ref this, p, scale);

    /// <summary>
    /// <code>Offset: 0x0050D6D0
    /// void __thiscall SPHEREPATH::adjust_check_pos(SPHEREPATH*,unsigned int)</code>
    /// </summary>
    public void adjust_check_pos(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, uint, void>)0x0050D6D0)(ref this, cell_id);

    /// <summary>
    /// <code>Offset: 0x0050D750
    /// TransitionState __thiscall SPHEREPATH::precipice_slide(SPHEREPATH*,COLLISIONINFO*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState precipice_slide(ACBindings.Internal.COLLISIONINFO* collisions) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.TransitionState>)0x0050D750)(ref this, collisions);

    /// <summary>
    /// <code>Offset: 0x0050D8F0
    /// void __thiscall SPHEREPATH::init_path(SPHEREPATH*,const CObjCell*,const Position*,const Position*)</code>
    /// </summary>
    public void init_path(ACBindings.Internal.CObjCell* begin_cell, ACBindings.Internal.Position* begin_pos, ACBindings.Internal.Position* end_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.CObjCell*, ACBindings.Internal.Position*, ACBindings.Internal.Position*, void>)0x0050D8F0)(ref this, begin_cell, begin_pos, end_pos);

    /// <summary>
    /// <code>Offset: 0x00537610
    /// int __thiscall SPHEREPATH::is_walkable_allowable(SPHEREPATH*,float)</code>
    /// </summary>
    public int is_walkable_allowable(float zval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, float, int>)0x00537610)(ref this, zval);

    /// <summary>
    /// <code>Offset: 0x005377A0
    /// void __thiscall SPHEREPATH::add_offset_to_check_pos(SPHEREPATH*,const AC1Legacy::Vector3*,const float)</code>
    /// </summary>
    public void add_offset_to_check_pos(ACBindings.Internal.AC1Legacy.Vector3* offset, float radius) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.AC1Legacy.Vector3*, float, void>)0x005377A0)(ref this, offset, radius);

    /// <summary>
    /// <code>Offset: 0x005385E0
    /// void __thiscall SPHEREPATH::set_collide(SPHEREPATH*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void set_collide(ACBindings.Internal.AC1Legacy.Vector3* collision_normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x005385E0)(ref this, collision_normal);

    /// <summary>
    /// <code>Offset: 0x0053A640
    /// void __thiscall SPHEREPATH::set_neg_poly_hit(SPHEREPATH*,int,AC1Legacy::Vector3*)</code>
    /// </summary>
    public void set_neg_poly_hit(int step_up, ACBindings.Internal.AC1Legacy.Vector3* collision_normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, int, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x0053A640)(ref this, step_up, collision_normal);

    /// <summary>
    /// <code>Offset: 0x0053AD20
    /// void __thiscall SPHEREPATH::set_walkable(SPHEREPATH*,const CSphere*,const CPolygon*,const AC1Legacy::Vector3*,const Position*,float)</code>
    /// </summary>
    public void set_walkable(ACBindings.Internal.CSphere* sphere, ACBindings.Internal.CPolygon* poly, ACBindings.Internal.AC1Legacy.Vector3* zaxis, ACBindings.Internal.Position* local_pos, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SPHEREPATH, ACBindings.Internal.CSphere*, ACBindings.Internal.CPolygon*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Position*, float, void>)0x0053AD20)(ref this, sphere, poly, zaxis, local_pos, scale);
}

