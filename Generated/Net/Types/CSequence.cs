namespace ACBindings;

// CSequence
public unsafe struct CSequence : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CSequence_vtbl
    public unsafe struct CSequence_vtbl
    {
        // Members
        public System.IntPtr CSequence_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.DLList__AnimSequenceNode anim_list;
    public ACBindings.AnimSequenceNode* first_cyclic;
    public ACBindings.AC1Legacy.Vector3 velocity;
    public ACBindings.AC1Legacy.Vector3 omega;
    public ACBindings.CPhysicsObj* hook_obj;
    public double frame_number;
    public ACBindings.AnimSequenceNode* curr_anim;
    public ACBindings.AnimFrame* placement_frame;
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
    // void __thiscall CSequence::set_object(CSequence*,CPhysicsObj*)
    public void set_object(ACBindings.CPhysicsObj* phys_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, ACBindings.CPhysicsObj*, void>)0x00525420)(ref this, phys_obj);
    // void __thiscall CSequence::execute_hooks(CSequence*,const AnimFrame*,int)
    public void execute_hooks(ACBindings.AnimFrame* animframe, int dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, ACBindings.AnimFrame*, int, void>)0x00525430)(ref this, animframe, dir);
    // void __thiscall CSequence::set_velocity(CSequence*,const AC1Legacy::Vector3*)
    public void set_velocity(ACBindings.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, ACBindings.AC1Legacy.Vector3*, void>)0x00525480)(ref this, v);
    // void __thiscall CSequence::set_omega(CSequence*,const AC1Legacy::Vector3*)
    public void set_omega(ACBindings.AC1Legacy.Vector3* o) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, ACBindings.AC1Legacy.Vector3*, void>)0x005254A0)(ref this, o);
    // void __thiscall CSequence::combine_physics(CSequence*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*)
    public void combine_physics(ACBindings.AC1Legacy.Vector3* v, ACBindings.AC1Legacy.Vector3* o) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, void>)0x005254C0)(ref this, v, o);
    // void __thiscall CSequence::subtract_physics(CSequence*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*)
    public void subtract_physics(ACBindings.AC1Legacy.Vector3* v, ACBindings.AC1Legacy.Vector3* o) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, void>)0x00525500)(ref this, v, o);
    // void __thiscall CSequence::multiply_cyclic_animation_fr(CSequence*,float)
    public void multiply_cyclic_animation_fr(float multiplier) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, float, void>)0x00525540)(ref this, multiplier);
    // const AnimFrame* __thiscall CSequence::get_curr_animframe(CSequence*)
    public ACBindings.AnimFrame* get_curr_animframe() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, ACBindings.AnimFrame*>)0x00525570)(ref this);
    // void __thiscall CSequence::set_placement_frame(CSequence*,const AnimFrame*,unsigned int)
    public void set_placement_frame(ACBindings.AnimFrame* placement_frame, uint id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, ACBindings.AnimFrame*, uint, void>)0x005255B0)(ref this, placement_frame, id);
    // void __thiscall CSequence::CSequence(CSequence*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, void>)0x005255F0)(ref this);
    // void __thiscall CSequence::~CSequence(CSequence*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, void>)0x00525630)(ref this);
    // void __thiscall CSequence::apply_physics(CSequence*,Frame*,long double,long double)
    public void apply_physics(ACBindings.Frame* frame, double quantum, double sign) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, ACBindings.Frame*, double, double, void>)0x005256B0)(ref this, frame, quantum, sign);
    // void __thiscall CSequence::apricot(CSequence*)
    public void apricot() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, void>)0x00525740)(ref this);
    // int __thiscall CSequence::has_anims(CSequence*)
    public int has_anims() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, int>)0x005257D0)(ref this);
    // void __thiscall CSequence::remove_link_animations(CSequence*,unsigned int)
    public void remove_link_animations(uint n) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, uint, void>)0x005257E0)(ref this, n);
    // void __thiscall CSequence::remove_all_link_animations(CSequence*)
    public void remove_all_link_animations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, void>)0x005258A0)(ref this);
    // void __thiscall CSequence::clear_physics(CSequence*)
    public void clear_physics() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, void>)0x00525950)(ref this);
    // void __thiscall CSequence::clear_animations(CSequence*)
    public void clear_animations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, void>)0x005259C0)(ref this);
    // void __thiscall CSequence::remove_cyclic_anims(CSequence*)
    public void remove_cyclic_anims() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, void>)0x00525A40)(ref this);
    // unsigned int __thiscall CSequence::pack_size(CSequence*,unsigned int*,unsigned int*)
    public uint pack_size(uint* bitfield, uint* num_anims) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, uint*, uint*, uint>)0x00525B20)(ref this, bitfield, num_anims);
    // unsigned int __thiscall CSequence::Pack(CSequence*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, void**, uint, uint>)0x00525C20)(ref this, addr, size);
    // void __thiscall CSequence::advance_to_next_animation(CSequence*,long double,const AnimSequenceNode**,long double*,Frame*)
    public void advance_to_next_animation(double quantum, ACBindings.AnimSequenceNode** curr_anim, double* frame_number, ACBindings.Frame* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, double, ACBindings.AnimSequenceNode**, double*, ACBindings.Frame*, void>)0x00525EB0)(ref this, quantum, curr_anim, frame_number, retval);
    // void __thiscall CSequence::append_animation(CSequence*,const AnimData*)
    public void append_animation(ACBindings.AnimData* new_data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, ACBindings.AnimData*, void>)0x00526110)(ref this, new_data);
    // void __thiscall CSequence::clear(CSequence*)
    public void clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, void>)0x005261B0)(ref this);
    // void __thiscall CSequence::update_internal(CSequence*,long double,AnimSequenceNode**,long double*,Frame*)
    public void update_internal(double quantum, ACBindings.AnimSequenceNode** curr_anim, double* frame_number, ACBindings.Frame* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, double, ACBindings.AnimSequenceNode**, double*, ACBindings.Frame*, void>)0x005261D0)(ref this, quantum, curr_anim, frame_number, retval);
    // int __thiscall CSequence::UnPack(CSequence*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, void**, uint, int>)0x005265D0)(ref this, addr, size);
    // void __thiscall CSequence::update(CSequence*,long double,Frame*)
    public void update(double quantum, ACBindings.Frame* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSequence, double, ACBindings.Frame*, void>)0x00526780)(ref this, quantum, retval);
}

