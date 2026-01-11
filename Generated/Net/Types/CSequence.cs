namespace ACBindings.Internal;

public unsafe struct CSequence : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CSequence_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CSequence*, void> CSequence_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CSequence*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CSequence*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CSequence*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.DLList___AnimSequenceNode anim_list;
    public ACBindings.Internal.AnimSequenceNode* first_cyclic;
    public ACBindings.Internal.AC1Legacy.Vector3 velocity;
    public ACBindings.Internal.AC1Legacy.Vector3 omega;
    public ACBindings.Internal.CPhysicsObj* hook_obj;
    public double frame_number;
    public ACBindings.Internal.AnimSequenceNode* curr_anim;
    public ACBindings.Internal.AnimFrame* placement_frame;
    public uint placement_frame_id;
    public int bIsTrivial;

    // Generated Constructor
    public CSequence() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00525420
    /// void __thiscall CSequence::set_object(CSequence*,CPhysicsObj*)</code>
    /// </summary>
    public void set_object(ACBindings.Internal.CPhysicsObj* phys_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.CPhysicsObj*, void>)0x00525420)(ref this, phys_obj);

    /// <summary>
    /// <code>Offset: 0x00525430
    /// void __thiscall CSequence::execute_hooks(CSequence*,const AnimFrame*,int)</code>
    /// </summary>
    public void execute_hooks(ACBindings.Internal.AnimFrame* animframe, int dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.AnimFrame*, int, void>)0x00525430)(ref this, animframe, dir);

    /// <summary>
    /// <code>Offset: 0x00525480
    /// void __thiscall CSequence::set_velocity(CSequence*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void set_velocity(ACBindings.Internal.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00525480)(ref this, v);

    /// <summary>
    /// <code>Offset: 0x005254A0
    /// void __thiscall CSequence::set_omega(CSequence*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void set_omega(ACBindings.Internal.AC1Legacy.Vector3* o) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x005254A0)(ref this, o);

    /// <summary>
    /// <code>Offset: 0x005254C0
    /// void __thiscall CSequence::combine_physics(CSequence*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void combine_physics(ACBindings.Internal.AC1Legacy.Vector3* v, ACBindings.Internal.AC1Legacy.Vector3* o) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x005254C0)(ref this, v, o);

    /// <summary>
    /// <code>Offset: 0x00525500
    /// void __thiscall CSequence::subtract_physics(CSequence*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void subtract_physics(ACBindings.Internal.AC1Legacy.Vector3* v, ACBindings.Internal.AC1Legacy.Vector3* o) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00525500)(ref this, v, o);

    /// <summary>
    /// <code>Offset: 0x00525540
    /// void __thiscall CSequence::multiply_cyclic_animation_fr(CSequence*,float)</code>
    /// </summary>
    public void multiply_cyclic_animation_fr(float multiplier) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, float, void>)0x00525540)(ref this, multiplier);

    /// <summary>
    /// <code>Offset: 0x00525570
    /// const AnimFrame* __thiscall CSequence::get_curr_animframe(CSequence*)</code>
    /// </summary>
    public ACBindings.Internal.AnimFrame* get_curr_animframe() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.AnimFrame*>)0x00525570)(ref this);

    /// <summary>
    /// <code>Offset: 0x005255B0
    /// void __thiscall CSequence::set_placement_frame(CSequence*,const AnimFrame*,unsigned int)</code>
    /// </summary>
    public void set_placement_frame(ACBindings.Internal.AnimFrame* placement_frame, uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.AnimFrame*, uint, void>)0x005255B0)(ref this, placement_frame, id);

    /// <summary>
    /// <code>Offset: 0x005255F0
    /// void __thiscall CSequence::CSequence(CSequence*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void>)0x005255F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00525630
    /// void __thiscall CSequence::~CSequence(CSequence*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void>)0x00525630)(ref this);

    /// <summary>
    /// <code>Offset: 0x005256B0
    /// void __thiscall CSequence::apply_physics(CSequence*,Frame*,long double,long double)</code>
    /// </summary>
    public void apply_physics(ACBindings.Internal.Frame* frame, double quantum, double sign) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.Frame*, double, double, void>)0x005256B0)(ref this, frame, quantum, sign);

    /// <summary>
    /// <code>Offset: 0x00525740
    /// void __thiscall CSequence::apricot(CSequence*)</code>
    /// </summary>
    public void apricot() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void>)0x00525740)(ref this);

    /// <summary>
    /// <code>Offset: 0x005257D0
    /// int __thiscall CSequence::has_anims(CSequence*)</code>
    /// </summary>
    public int has_anims() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, int>)0x005257D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005257E0
    /// void __thiscall CSequence::remove_link_animations(CSequence*,unsigned int)</code>
    /// </summary>
    public void remove_link_animations(uint n) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, uint, void>)0x005257E0)(ref this, n);

    /// <summary>
    /// <code>Offset: 0x005258A0
    /// void __thiscall CSequence::remove_all_link_animations(CSequence*)</code>
    /// </summary>
    public void remove_all_link_animations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void>)0x005258A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00525950
    /// void __thiscall CSequence::clear_physics(CSequence*)</code>
    /// </summary>
    public void clear_physics() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void>)0x00525950)(ref this);

    /// <summary>
    /// <code>Offset: 0x005259C0
    /// void __thiscall CSequence::clear_animations(CSequence*)</code>
    /// </summary>
    public void clear_animations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void>)0x005259C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00525A40
    /// void __thiscall CSequence::remove_cyclic_anims(CSequence*)</code>
    /// </summary>
    public void remove_cyclic_anims() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void>)0x00525A40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00525B20
    /// unsigned int __thiscall CSequence::pack_size(CSequence*,unsigned int*,unsigned int*)</code>
    /// </summary>
    public uint pack_size(uint* bitfield, uint* num_anims) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, uint*, uint*, uint>)0x00525B20)(ref this, bitfield, num_anims);

    /// <summary>
    /// <code>Offset: 0x00525C20
    /// unsigned int __thiscall CSequence::Pack(CSequence*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void**, uint, uint>)0x00525C20)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00525EB0
    /// void __thiscall CSequence::advance_to_next_animation(CSequence*,long double,const AnimSequenceNode**,long double*,Frame*)</code>
    /// </summary>
    public void advance_to_next_animation(double quantum, ACBindings.Internal.AnimSequenceNode** curr_anim, double* frame_number, ACBindings.Internal.Frame* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, double, ACBindings.Internal.AnimSequenceNode**, double*, ACBindings.Internal.Frame*, void>)0x00525EB0)(ref this, quantum, curr_anim, frame_number, retval);

    /// <summary>
    /// <code>Offset: 0x00526110
    /// void __thiscall CSequence::append_animation(CSequence*,const AnimData*)</code>
    /// </summary>
    public void append_animation(ACBindings.Internal.AnimData* new_data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, ACBindings.Internal.AnimData*, void>)0x00526110)(ref this, new_data);

    /// <summary>
    /// <code>Offset: 0x005261B0
    /// void __thiscall CSequence::clear(CSequence*)</code>
    /// </summary>
    public void clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void>)0x005261B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005261D0
    /// void __thiscall CSequence::update_internal(CSequence*,long double,AnimSequenceNode**,long double*,Frame*)</code>
    /// </summary>
    public void update_internal(double quantum, ACBindings.Internal.AnimSequenceNode** curr_anim, double* frame_number, ACBindings.Internal.Frame* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, double, ACBindings.Internal.AnimSequenceNode**, double*, ACBindings.Internal.Frame*, void>)0x005261D0)(ref this, quantum, curr_anim, frame_number, retval);

    /// <summary>
    /// <code>Offset: 0x005265D0
    /// int __thiscall CSequence::UnPack(CSequence*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, void**, uint, int>)0x005265D0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00526780
    /// void __thiscall CSequence::update(CSequence*,long double,Frame*)</code>
    /// </summary>
    public void update(double quantum, ACBindings.Internal.Frame* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSequence, double, ACBindings.Internal.Frame*, void>)0x00526780)(ref this, quantum, retval);
}

