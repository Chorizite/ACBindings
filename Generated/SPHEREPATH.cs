namespace ACBindings;

// SPHEREPATH
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
    public ACBindings.CSphere* local_sphere;
    public ACBindings.AC1Legacy.Vector3 local_low_point;
    public ACBindings.CSphere* global_sphere;
    public ACBindings.AC1Legacy.Vector3 global_low_point;
    public ACBindings.CSphere* localspace_sphere;
    public ACBindings.AC1Legacy.Vector3 localspace_low_point;
    public ACBindings.AC1Legacy.Vector3* localspace_curr_center;
    public ACBindings.AC1Legacy.Vector3* global_curr_center;
    public ACBindings.Position localspace_pos;
    public ACBindings.AC1Legacy.Vector3 localspace_z;
    public ACBindings.CObjCell* begin_cell;
    public ACBindings.Position* begin_pos;
    public ACBindings.Position* end_pos;
    public ACBindings.CObjCell* curr_cell;
    public ACBindings.Position curr_pos;
    public ACBindings.AC1Legacy.Vector3 global_offset;
    public int step_up;
    public ACBindings.AC1Legacy.Vector3 step_up_normal;
    public int collide;
    public ACBindings.CObjCell* check_cell;
    public ACBindings.Position check_pos;
    public ACBindings.SPHEREPATH.InsertType insert_type;
    public int step_down;
    public ACBindings.SPHEREPATH.InsertType backup;
    public ACBindings.CObjCell* backup_cell;
    public ACBindings.Position backup_check_pos;
    public int obstruction_ethereal;
    public int hits_interior_cell;
    public int bldg_check;
    public float walkable_allowance;
    public float walk_interp;
    public float step_down_amt;
    public ACBindings.CSphere walkable_check_pos;
    public ACBindings.CPolygon* walkable;
    public int check_walkable;
    public ACBindings.AC1Legacy.Vector3 walkable_up;
    public ACBindings.Position walkable_pos;
    public float walkable_scale;
    public int cell_array_valid;
    public int neg_step_up;
    public ACBindings.AC1Legacy.Vector3 neg_collision_normal;
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
    // void __thiscall SPHEREPATH::set_walkable_check_pos(SPHEREPATH*,const CSphere*)
    public void set_walkable_check_pos(ACBindings.CSphere* sphere) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, ACBindings.CSphere*, void>)0x0050A7B0)(ref this, sphere);
    // void __thiscall SPHEREPATH::add_offset_to_check_pos(SPHEREPATH*,const AC1Legacy::Vector3*)
    public void add_offset_to_check_pos(ACBindings.AC1Legacy.Vector3* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, ACBindings.AC1Legacy.Vector3*, void>)0x0050A7E0)(ref this, offset);
    // AC1Legacy::Vector3* __thiscall SPHEREPATH::get_curr_pos_check_pos_block_offset(SPHEREPATH*,AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* get_curr_pos_check_pos_block_offset(ACBindings.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x0050AAA0)(ref this, result);
    // void __thiscall SPHEREPATH::save_check_pos(SPHEREPATH*)
    public void save_check_pos() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, void>)0x0050B350)(ref this);
    // void __thiscall SPHEREPATH::set_check_pos(SPHEREPATH*,const Position*,CObjCell*)
    public void set_check_pos(ACBindings.Position* p, ACBindings.CObjCell* cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, ACBindings.Position*, ACBindings.CObjCell*, void>)0x0050B380)(ref this, p, cell);
    // const Position* __thiscall SPHEREPATH::get_walkable_pos(SPHEREPATH*,const Position*)
    public ACBindings.Position* get_walkable_pos(ACBindings.Position* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, ACBindings.Position*, ACBindings.Position*>)0x0050B3C0)(ref this, result);
    // void __thiscall SPHEREPATH::restore_check_pos(SPHEREPATH*)
    public void restore_check_pos() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, void>)0x0050BBD0)(ref this);
    // void __thiscall SPHEREPATH::init(SPHEREPATH*)
    public void init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, void>)0x0050CE00)(ref this);
    // TransitionState __thiscall SPHEREPATH::step_up_slide(SPHEREPATH*,OBJECTINFO*,COLLISIONINFO*)
    public ACBindings.TransitionState step_up_slide(ACBindings.OBJECTINFO* object_, ACBindings.COLLISIONINFO* collisions) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, ACBindings.OBJECTINFO*, ACBindings.COLLISIONINFO*, ACBindings.TransitionState>)0x0050CE80)(ref this, object_, collisions);
    // int __thiscall SPHEREPATH::check_walkables(SPHEREPATH*)
    public int check_walkables() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, int>)0x0050CEB0)(ref this);
    // void __thiscall SPHEREPATH::SPHEREPATH(SPHEREPATH*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, void>)0x0050CF50)(ref this);
    // void __thiscall SPHEREPATH::~SPHEREPATH(SPHEREPATH*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, void>)0x0050D0C0)(ref this);
    // void __thiscall SPHEREPATH::init_sphere(SPHEREPATH*,const unsigned int,const CSphere*,const float)
    public void init_sphere(uint num_sphere, ACBindings.CSphere* sphere, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, uint, ACBindings.CSphere*, float, void>)0x0050D140)(ref this, num_sphere, sphere, scale);
    // void __thiscall SPHEREPATH::cache_global_curr_center(SPHEREPATH*)
    public void cache_global_curr_center() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, void>)0x0050D210)(ref this);
    // void __thiscall SPHEREPATH::cache_global_sphere(SPHEREPATH*,const AC1Legacy::Vector3*)
    public void cache_global_sphere(ACBindings.AC1Legacy.Vector3* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, ACBindings.AC1Legacy.Vector3*, void>)0x0050D2E0)(ref this, offset);
    // void __thiscall SPHEREPATH::cache_localspace_sphere(SPHEREPATH*,const Position*,const float)
    public void cache_localspace_sphere(ACBindings.Position* p, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, ACBindings.Position*, float, void>)0x0050D4A0)(ref this, p, scale);
    // void __thiscall SPHEREPATH::adjust_check_pos(SPHEREPATH*,unsigned int)
    public void adjust_check_pos(uint cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, uint, void>)0x0050D6D0)(ref this, cell_id);
    // TransitionState __thiscall SPHEREPATH::precipice_slide(SPHEREPATH*,COLLISIONINFO*)
    public ACBindings.TransitionState precipice_slide(ACBindings.COLLISIONINFO* collisions) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, ACBindings.COLLISIONINFO*, ACBindings.TransitionState>)0x0050D750)(ref this, collisions);
    // void __thiscall SPHEREPATH::init_path(SPHEREPATH*,const CObjCell*,const Position*,const Position*)
    public void init_path(ACBindings.CObjCell* begin_cell, ACBindings.Position* begin_pos, ACBindings.Position* end_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, ACBindings.CObjCell*, ACBindings.Position*, ACBindings.Position*, void>)0x0050D8F0)(ref this, begin_cell, begin_pos, end_pos);
    // int __thiscall SPHEREPATH::is_walkable_allowable(SPHEREPATH*,float)
    public int is_walkable_allowable(float zval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, float, int>)0x00537610)(ref this, zval);
    // void __thiscall SPHEREPATH::add_offset_to_check_pos(SPHEREPATH*,const AC1Legacy::Vector3*,const float)
    public void add_offset_to_check_pos(ACBindings.AC1Legacy.Vector3* offset, float radius) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, ACBindings.AC1Legacy.Vector3*, float, void>)0x005377A0)(ref this, offset, radius);
    // void __thiscall SPHEREPATH::set_collide(SPHEREPATH*,const AC1Legacy::Vector3*)
    public void set_collide(ACBindings.AC1Legacy.Vector3* collision_normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, ACBindings.AC1Legacy.Vector3*, void>)0x005385E0)(ref this, collision_normal);
    // void __thiscall SPHEREPATH::set_neg_poly_hit(SPHEREPATH*,int,AC1Legacy::Vector3*)
    public void set_neg_poly_hit(int step_up, ACBindings.AC1Legacy.Vector3* collision_normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, int, ACBindings.AC1Legacy.Vector3*, void>)0x0053A640)(ref this, step_up, collision_normal);
    // void __thiscall SPHEREPATH::set_walkable(SPHEREPATH*,const CSphere*,const CPolygon*,const AC1Legacy::Vector3*,const Position*,float)
    public void set_walkable(ACBindings.CSphere* sphere, ACBindings.CPolygon* poly, ACBindings.AC1Legacy.Vector3* zaxis, ACBindings.Position* local_pos, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SPHEREPATH, ACBindings.CSphere*, ACBindings.CPolygon*, ACBindings.AC1Legacy.Vector3*, ACBindings.Position*, float, void>)0x0053AD20)(ref this, sphere, poly, zaxis, local_pos, scale);
}

