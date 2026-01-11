namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0050A890
    /// void __cdecl CTransition::cleanupTransition(CTransition*)</code>
    /// </summary>
    public static void cleanupTransition(ACBindings.Internal.CTransition* transit) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CTransition*, void>)0x0050A890)(transit);

    /// <summary>
    /// <code>Offset: 0x0050A8A0
    /// void __thiscall CTransition::init(CTransition*)</code>
    /// </summary>
    public void init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, void>)0x0050A8A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050A920
    /// void __thiscall CTransition::init_sphere(CTransition*,const unsigned int,const CSphere*,const float)</code>
    /// </summary>
    public void init_sphere(uint num_sphere, ACBindings.Internal.CSphere* sphere, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, uint, ACBindings.Internal.CSphere*, float, void>)0x0050A920)(ref this, num_sphere, sphere, scale);

    /// <summary>
    /// <code>Offset: 0x0050A930
    /// void __thiscall CTransition::init_path(CTransition*,const CObjCell*,const Position*,const Position*)</code>
    /// </summary>
    public void init_path(ACBindings.Internal.CObjCell* begin_cell, ACBindings.Internal.Position* begin_pos, ACBindings.Internal.Position* end_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.CObjCell*, ACBindings.Internal.Position*, ACBindings.Internal.Position*, void>)0x0050A930)(ref this, begin_cell, begin_pos, end_pos);

    /// <summary>
    /// <code>Offset: 0x0050A940
    /// TransitionState __thiscall CTransition::insert_into_cell(CTransition*,const CObjCell*,int)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState insert_into_cell(ACBindings.Internal.CObjCell* cell, int num_insertion_attempts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.CObjCell*, int, ACBindings.Internal.TransitionState>)0x0050A940)(ref this, cell, num_insertion_attempts);

    /// <summary>
    /// <code>Offset: 0x0050A9B0
    /// void __thiscall CTransition::build_cell_array(CTransition*,CObjCell**)</code>
    /// </summary>
    public void build_cell_array(ACBindings.Internal.CObjCell** new_cell_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.CObjCell**, void>)0x0050A9B0)(ref this, new_cell_p);

    /// <summary>
    /// <code>Offset: 0x0050AB80
    /// void __thiscall CTransition::calc_num_steps(CTransition*,AC1Legacy::Vector3*,AC1Legacy::Vector3*,unsigned int*)</code>
    /// </summary>
    public void calc_num_steps(ACBindings.Internal.AC1Legacy.Vector3* offset, ACBindings.Internal.AC1Legacy.Vector3* offset_per_step, uint* num_steps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, uint*, void>)0x0050AB80)(ref this, offset, offset_per_step, num_steps);

    /// <summary>
    /// <code>Offset: 0x0050AE40
    /// AC1Legacy::Vector3* __thiscall CTransition::adjust_offset(CTransition*,AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public ACBindings.Internal.AC1Legacy.Vector3* adjust_offset(ACBindings.Internal.AC1Legacy.Vector3* result, ACBindings.Internal.AC1Legacy.Vector3* offset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x0050AE40)(ref this, result, offset);

    /// <summary>
    /// <code>Offset: 0x0050B1A0
    /// TransitionState __thiscall CTransition::cliff_slide(CTransition*,const Plane*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState cliff_slide(ACBindings.Internal.Plane* contact_plane) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.Plane*, ACBindings.Internal.TransitionState>)0x0050B1A0)(ref this, contact_plane);

    /// <summary>
    /// <code>Offset: 0x0050B450
    /// void __thiscall CTransition::CTransition(CTransition*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, void>)0x0050B450)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050B4D0
    /// int __thiscall CTransition::check_collisions(CTransition*,const CPhysicsObj*)</code>
    /// </summary>
    public int check_collisions(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.CPhysicsObj*, int>)0x0050B4D0)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x0050B540
    /// TransitionState __thiscall CTransition::validate_transition(CTransition*,TransitionState,int*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState validate_transition(ACBindings.Internal.TransitionState ts, int* redo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.TransitionState, int*, ACBindings.Internal.TransitionState>)0x0050B540)(ref this, ts, redo);

    /// <summary>
    /// <code>Offset: 0x0050B890
    /// TransitionState __thiscall CTransition::validate_placement_transition(CTransition*,TransitionState,int*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState validate_placement_transition(ACBindings.Internal.TransitionState ts, int* redo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.TransitionState, int*, ACBindings.Internal.TransitionState>)0x0050B890)(ref this, ts, redo);

    /// <summary>
    /// <code>Offset: 0x0050B920
    /// TransitionState __thiscall CTransition::check_other_cells(CTransition*,const CObjCell*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState check_other_cells(ACBindings.Internal.CObjCell* curr_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.CObjCell*, ACBindings.Internal.TransitionState>)0x0050B920)(ref this, curr_cell);

    /// <summary>
    /// <code>Offset: 0x0050BAC0
    /// int __thiscall CTransition::check_walkable(CTransition*,float)</code>
    /// </summary>
    public int check_walkable(float z_chk) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, float, int>)0x0050BAC0)(ref this, z_chk);

    /// <summary>
    /// <code>Offset: 0x0050BC20
    /// CTransition* __cdecl CTransition::makeTransition()</code>
    /// </summary>
    public static ACBindings.Internal.CTransition* makeTransition() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CTransition*>)0x0050BC20)();

    /// <summary>
    /// <code>Offset: 0x0050BCA0
    /// TransitionState __thiscall CTransition::placement_insert(CTransition*)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState placement_insert() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.TransitionState>)0x0050BCA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050BCE0
    /// TransitionState __thiscall CTransition::validate_placement(CTransition*,TransitionState,int)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState validate_placement(ACBindings.Internal.TransitionState ts, int adjust) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.TransitionState, int, ACBindings.Internal.TransitionState>)0x0050BCE0)(ref this, ts, adjust);

    /// <summary>
    /// <code>Offset: 0x0050BD70
    /// int __thiscall CTransition::step_down(CTransition*,float,float)</code>
    /// </summary>
    public int step_down(float step_down_ht, float z_val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, float, float, int>)0x0050BD70)(ref this, step_down_ht, z_val);

    /// <summary>
    /// <code>Offset: 0x0050BEA0
    /// int __thiscall CTransition::edge_slide(CTransition*,TransitionState*,float,float)</code>
    /// </summary>
    public int edge_slide(ACBindings.Internal.TransitionState* ts, float step_down_ht, float z_val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.TransitionState*, float, float, int>)0x0050BEA0)(ref this, ts, step_down_ht, z_val);

    /// <summary>
    /// <code>Offset: 0x0050C0E0
    /// int __thiscall CTransition::step_up(CTransition*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public int step_up(ACBindings.Internal.AC1Legacy.Vector3* collision_normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0050C0E0)(ref this, collision_normal);

    /// <summary>
    /// <code>Offset: 0x0050C1C0
    /// TransitionState __thiscall CTransition::transitional_insert(CTransition*,int)</code>
    /// </summary>
    public ACBindings.Internal.TransitionState transitional_insert(int num_insertion_attempts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, int, ACBindings.Internal.TransitionState>)0x0050C1C0)(ref this, num_insertion_attempts);

    /// <summary>
    /// <code>Offset: 0x0050C520
    /// int __thiscall CTransition::find_placement_pos(CTransition*)</code>
    /// </summary>
    public int find_placement_pos() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, int>)0x0050C520)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050C8C0
    /// int __thiscall CTransition::find_transitional_position(CTransition*)</code>
    /// </summary>
    public int find_transitional_position() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, int>)0x0050C8C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050CC40
    /// int __thiscall CTransition::find_placement_position(CTransition*)</code>
    /// </summary>
    public int find_placement_position() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, int>)0x0050CC40)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050CDE0
    /// int __thiscall CTransition::find_valid_position(CTransition*)</code>
    /// </summary>
    public int find_valid_position() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, int>)0x0050CDE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0050F320
    /// void __thiscall CTransition::init_contact_plane(CTransition*,unsigned int,const Plane*,int)</code>
    /// </summary>
    public void init_contact_plane(uint cell_id, ACBindings.Internal.Plane* plane, int is_water) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, uint, ACBindings.Internal.Plane*, int, void>)0x0050F320)(ref this, cell_id, plane, is_water);

    /// <summary>
    /// <code>Offset: 0x0050F3B0
    /// void __thiscall CTransition::init_last_known_contact_plane(CTransition*,unsigned int,const Plane*,int)</code>
    /// </summary>
    public void init_last_known_contact_plane(uint cell_id, ACBindings.Internal.Plane* plane, int is_water) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, uint, ACBindings.Internal.Plane*, int, void>)0x0050F3B0)(ref this, cell_id, plane, is_water);

    /// <summary>
    /// <code>Offset: 0x005109F0
    /// void __thiscall CTransition::init_sliding_normal(CTransition*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void init_sliding_normal(ACBindings.Internal.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CTransition, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x005109F0)(ref this, normal);
}

