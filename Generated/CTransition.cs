namespace ACBindings;

// CTransition
public unsafe struct CTransition
{
    // Statics
    public static int* transition_level = (int*)0x00842C64;

    // Members
    public ACBindings.OBJECTINFO object_info;
    public ACBindings.SPHEREPATH sphere_path;
    public ACBindings.COLLISIONINFO collision_info;
    public ACBindings.CELLARRAY cell_array;
    public ACBindings.CObjCell* new_cell_ptr;

    // Generated Constructor
    public CTransition() {
        _ConstructorInternal();
    }

    // Methods
    // void __cdecl CTransition::cleanupTransition(CTransition*)
    public static void cleanupTransition(ACBindings.CTransition* transit) => ((delegate* unmanaged[Cdecl]<ACBindings.CTransition*, void>)0x0050A890)(transit);
    // void __thiscall CTransition::init(CTransition*)
    public void init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, void>)0x0050A8A0)(ref this);
    // void __thiscall CTransition::init_sphere(CTransition*,const unsigned int,const CSphere*,const float)
    public void init_sphere(uint num_sphere, ACBindings.CSphere* sphere, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, uint, ACBindings.CSphere*, float, void>)0x0050A920)(ref this, num_sphere, sphere, scale);
    // void __thiscall CTransition::init_path(CTransition*,const CObjCell*,const Position*,const Position*)
    public void init_path(ACBindings.CObjCell* begin_cell, ACBindings.Position* begin_pos, ACBindings.Position* end_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, ACBindings.CObjCell*, ACBindings.Position*, ACBindings.Position*, void>)0x0050A930)(ref this, begin_cell, begin_pos, end_pos);
    // TransitionState __thiscall CTransition::insert_into_cell(CTransition*,const CObjCell*,int)
    public ACBindings.TransitionState insert_into_cell(ACBindings.CObjCell* cell, int num_insertion_attempts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, ACBindings.CObjCell*, int, ACBindings.TransitionState>)0x0050A940)(ref this, cell, num_insertion_attempts);
    // void __thiscall CTransition::build_cell_array(CTransition*,CObjCell**)
    public void build_cell_array(ACBindings.CObjCell** new_cell_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, ACBindings.CObjCell**, void>)0x0050A9B0)(ref this, new_cell_p);
    // void __thiscall CTransition::calc_num_steps(CTransition*,AC1Legacy::Vector3*,AC1Legacy::Vector3*,unsigned int*)
    public void calc_num_steps(ACBindings.AC1Legacy.Vector3* offset, ACBindings.AC1Legacy.Vector3* offset_per_step, uint* num_steps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, uint*, void>)0x0050AB80)(ref this, offset, offset_per_step, num_steps);
    // AC1Legacy::Vector3* __thiscall CTransition::adjust_offset(CTransition*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)
    public ACBindings.AC1Legacy.Vector3* adjust_offset(ACBindings.AC1Legacy.Vector3* result, ACBindings.AC1Legacy.Vector3* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*>)0x0050AE40)(ref this, result, offset);
    // TransitionState __thiscall CTransition::cliff_slide(CTransition*,const Plane*)
    public ACBindings.TransitionState cliff_slide(ACBindings.Plane* contact_plane) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, ACBindings.Plane*, ACBindings.TransitionState>)0x0050B1A0)(ref this, contact_plane);
    // void __thiscall CTransition::CTransition(CTransition*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, void>)0x0050B450)(ref this);
    // int __thiscall CTransition::check_collisions(CTransition*,const CPhysicsObj*)
    public int check_collisions(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, ACBindings.CPhysicsObj*, int>)0x0050B4D0)(ref this, object_);
    // TransitionState __thiscall CTransition::validate_transition(CTransition*,TransitionState,int*)
    public ACBindings.TransitionState validate_transition(ACBindings.TransitionState ts, int* redo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, ACBindings.TransitionState, int*, ACBindings.TransitionState>)0x0050B540)(ref this, ts, redo);
    // TransitionState __thiscall CTransition::validate_placement_transition(CTransition*,TransitionState,int*)
    public ACBindings.TransitionState validate_placement_transition(ACBindings.TransitionState ts, int* redo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, ACBindings.TransitionState, int*, ACBindings.TransitionState>)0x0050B890)(ref this, ts, redo);
    // TransitionState __thiscall CTransition::check_other_cells(CTransition*,const CObjCell*)
    public ACBindings.TransitionState check_other_cells(ACBindings.CObjCell* curr_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, ACBindings.CObjCell*, ACBindings.TransitionState>)0x0050B920)(ref this, curr_cell);
    // int __thiscall CTransition::check_walkable(CTransition*,float)
    public int check_walkable(float z_chk) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, float, int>)0x0050BAC0)(ref this, z_chk);
    // CTransition* __cdecl CTransition::makeTransition()
    public static ACBindings.CTransition* makeTransition() => ((delegate* unmanaged[Cdecl]<ACBindings.CTransition*>)0x0050BC20)();
    // TransitionState __thiscall CTransition::placement_insert(CTransition*)
    public ACBindings.TransitionState placement_insert() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, ACBindings.TransitionState>)0x0050BCA0)(ref this);
    // TransitionState __thiscall CTransition::validate_placement(CTransition*,TransitionState,int)
    public ACBindings.TransitionState validate_placement(ACBindings.TransitionState ts, int adjust) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, ACBindings.TransitionState, int, ACBindings.TransitionState>)0x0050BCE0)(ref this, ts, adjust);
    // int __thiscall CTransition::step_down(CTransition*,float,float)
    public int step_down(float step_down_ht, float z_val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, float, float, int>)0x0050BD70)(ref this, step_down_ht, z_val);
    // int __thiscall CTransition::edge_slide(CTransition*,TransitionState*,float,float)
    public int edge_slide(ACBindings.TransitionState* ts, float step_down_ht, float z_val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, ACBindings.TransitionState*, float, float, int>)0x0050BEA0)(ref this, ts, step_down_ht, z_val);
    // int __thiscall CTransition::step_up(CTransition*,AC1Legacy::Vector3*)
    public int step_up(ACBindings.AC1Legacy.Vector3* collision_normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, ACBindings.AC1Legacy.Vector3*, int>)0x0050C0E0)(ref this, collision_normal);
    // TransitionState __thiscall CTransition::transitional_insert(CTransition*,int)
    public ACBindings.TransitionState transitional_insert(int num_insertion_attempts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, int, ACBindings.TransitionState>)0x0050C1C0)(ref this, num_insertion_attempts);
    // int __thiscall CTransition::find_placement_pos(CTransition*)
    public int find_placement_pos() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, int>)0x0050C520)(ref this);
    // int __thiscall CTransition::find_transitional_position(CTransition*)
    public int find_transitional_position() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, int>)0x0050C8C0)(ref this);
    // int __thiscall CTransition::find_placement_position(CTransition*)
    public int find_placement_position() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, int>)0x0050CC40)(ref this);
    // int __thiscall CTransition::find_valid_position(CTransition*)
    public int find_valid_position() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, int>)0x0050CDE0)(ref this);
    // void __thiscall CTransition::init_contact_plane(CTransition*,unsigned int,const Plane*,int)
    public void init_contact_plane(uint cell_id, ACBindings.Plane* plane, int is_water) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, uint, ACBindings.Plane*, int, void>)0x0050F320)(ref this, cell_id, plane, is_water);
    // void __thiscall CTransition::init_last_known_contact_plane(CTransition*,unsigned int,const Plane*,int)
    public void init_last_known_contact_plane(uint cell_id, ACBindings.Plane* plane, int is_water) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, uint, ACBindings.Plane*, int, void>)0x0050F3B0)(ref this, cell_id, plane, is_water);
    // void __thiscall CTransition::init_sliding_normal(CTransition*,const AC1Legacy::Vector3*)
    public void init_sliding_normal(ACBindings.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CTransition, ACBindings.AC1Legacy.Vector3*, void>)0x005109F0)(ref this, normal);
}

