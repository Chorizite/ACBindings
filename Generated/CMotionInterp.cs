namespace ACBindings;

// CMotionInterp
public unsafe struct CMotionInterp : System.IDisposable
{
    // Child Types
    // CMotionInterp::MotionNode
    public unsafe struct MotionNode
    {
        // Base Classes
        public ACBindings.LListData BaseClass_LListData; // ACBindings.LListData

        // Members
        public uint context_id;
        public uint motion;
        public uint jump_error_code;

        // Methods
    }

    // Members
    public int initted;
    public ACBindings.CWeenieObject* weenie_obj;
    public ACBindings.CPhysicsObj* physics_obj;
    public ACBindings.RawMotionState raw_state;
    public ACBindings.InterpretedMotionState interpreted_state;
    public float current_speed_factor;
    public int standing_longjump;
    public float jump_extent;
    public uint server_action_stamp;
    public float my_run_rate;
    public ACBindings.LList__CMotionInterp_MotionNode pending_motions;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall CMotionInterp::motion_allows_jump(CMotionInterp*,unsigned int)
    public uint motion_allows_jump(uint substate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, uint, uint>)0x005285E0)(ref this, substate);
    // unsigned int __thiscall CMotionInterp::jump_charge_is_allowed(CMotionInterp*)
    public uint jump_charge_is_allowed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, uint>)0x00528660)(ref this);
    // float __thiscall CMotionInterp::get_jump_v_z(CMotionInterp*)
    public float get_jump_v_z() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, float>)0x005286B0)(ref this);
    // unsigned int __thiscall CMotionInterp::InqStyle(CMotionInterp*)
    public uint InqStyle() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, uint>)0x00528720)(ref this);
    // void __thiscall CMotionInterp::Destroy(CMotionInterp*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, void>)0x00528750)(ref this);
    // void __thiscall CMotionInterp::add_to_queue(CMotionInterp*,unsigned int,unsigned int,unsigned int)
    public void add_to_queue(uint context_id, uint motion, uint jump_error_code) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, uint, uint, uint, void>)0x00528790)(ref this, context_id, motion, jump_error_code);
    // void __thiscall CMotionInterp::apply_run_to_command(CMotionInterp*,unsigned int*,float*)
    public void apply_run_to_command(uint* motion, float* speed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, uint*, float*, void>)0x005287F0)(ref this, motion, speed);
    // float __thiscall CMotionInterp::get_max_speed(CMotionInterp*)
    public float get_max_speed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, float>)0x005288C0)(ref this);
    // float __thiscall CMotionInterp::get_adjusted_max_speed(CMotionInterp*)
    public float get_adjusted_max_speed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, float>)0x00528910)(ref this);
    // void __thiscall CMotionInterp::get_state_velocity(CMotionInterp*,AC1Legacy::Vector3*)
    public void get_state_velocity(ACBindings.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, ACBindings.AC1Legacy.Vector3*, void>)0x00528960)(ref this, v);
    // unsigned int __thiscall CMotionInterp::StopCompletely(CMotionInterp*)
    public uint StopCompletely() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, uint>)0x00528A50)(ref this);
    // void __thiscall CMotionInterp::MotionDone(CMotionInterp*,int)
    public void MotionDone(int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, int, void>)0x00528AD0)(ref this, success);
    // int __thiscall CMotionInterp::is_standing_still(CMotionInterp*)
    public int is_standing_still() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, int>)0x00528BB0)(ref this);
    // int __thiscall CMotionInterp::motions_pending(CMotionInterp*)
    public int motions_pending() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, int>)0x00528BF0)(ref this);
    // void __thiscall CMotionInterp::~CMotionInterp(CMotionInterp*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, void>)0x00528C00)(ref this);
    // void __thiscall CMotionInterp::adjust_motion(CMotionInterp*,unsigned int*,float*,HoldKey)
    public void adjust_motion(uint* motion, float* speed, ACBindings.HoldKey key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, uint*, float*, ACBindings.HoldKey, void>)0x00528C20)(ref this, motion, speed, key);
    // void __thiscall CMotionInterp::get_leave_ground_velocity(CMotionInterp*,AC1Legacy::Vector3*)
    public void get_leave_ground_velocity(ACBindings.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, ACBindings.AC1Legacy.Vector3*, void>)0x00528CD0)(ref this, v);
    // unsigned int __thiscall CMotionInterp::charge_jump(CMotionInterp*)
    public uint charge_jump() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, uint>)0x00528DD0)(ref this);
    // int __thiscall CMotionInterp::contact_allows_move(CMotionInterp*,unsigned int)
    public int contact_allows_move(uint motion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, uint, int>)0x00528E50)(ref this, motion);
    // unsigned int __thiscall CMotionInterp::jump_is_allowed(CMotionInterp*,float,int*)
    public uint jump_is_allowed(float extent, int* stamina_cost) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, float, int*, uint>)0x00528EC0)(ref this, extent, stamina_cost);
    // unsigned int __thiscall CMotionInterp::DoInterpretedMotion(CMotionInterp*,unsigned int,const MovementParameters*)
    public uint DoInterpretedMotion(uint motion, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, uint, ACBindings.MovementParameters*, uint>)0x00528F70)(ref this, motion, params_);
    // unsigned int __thiscall CMotionInterp::StopInterpretedMotion(CMotionInterp*,unsigned int,const MovementParameters*)
    public uint StopInterpretedMotion(uint motion, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, uint, ACBindings.MovementParameters*, uint>)0x00529080)(ref this, motion, params_);
    // unsigned int __thiscall CMotionInterp::StopMotion(CMotionInterp*,unsigned int,const MovementParameters*)
    public uint StopMotion(uint motion, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, uint, ACBindings.MovementParameters*, uint>)0x00529140)(ref this, motion, params_);
    // void __thiscall CMotionInterp::apply_interpreted_movement(CMotionInterp*,int,int)
    public void apply_interpreted_movement(int cancel_moveto, int disallow_jump) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, int, int, void>)0x00529210)(ref this, cancel_moveto, disallow_jump);
    // unsigned int __thiscall CMotionInterp::jump(CMotionInterp*,float,int*)
    public uint jump(float extent, int* stamina_adjustment) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, float, int*, uint>)0x00529390)(ref this, extent, stamina_adjustment);
    // void __thiscall CMotionInterp::apply_raw_movement(CMotionInterp*,int,int)
    public void apply_raw_movement(int cancel_moveto, int disallow_jump) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, int, int, void>)0x005293F0)(ref this, cancel_moveto, disallow_jump);
    // void __thiscall CMotionInterp::apply_current_movement(CMotionInterp*,int,int)
    public void apply_current_movement(int cancel_moveto, int disallow_jump) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, int, int, void>)0x00529480)(ref this, cancel_moveto, disallow_jump);
    // void __thiscall CMotionInterp::ReportExhaustion(CMotionInterp*)
    public void ReportExhaustion() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, void>)0x005294E0)(ref this);
    // void __thiscall CMotionInterp::SetWeenieObject(CMotionInterp*,CWeenieObject*)
    public void SetWeenieObject(ACBindings.CWeenieObject* weenie_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, ACBindings.CWeenieObject*, void>)0x00529530)(ref this, weenie_obj);
    // void __thiscall CMotionInterp::SetPhysicsObject(CMotionInterp*,CPhysicsObj*)
    public void SetPhysicsObject(ACBindings.CPhysicsObj* physics_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, ACBindings.CPhysicsObj*, void>)0x00529580)(ref this, physics_obj);
    // int __thiscall CMotionInterp::move_to_interpreted_state(CMotionInterp*,const InterpretedMotionState*)
    public int move_to_interpreted_state(ACBindings.InterpretedMotionState* new_state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, ACBindings.InterpretedMotionState*, int>)0x005295D0)(ref this, new_state);
    // void __thiscall CMotionInterp::HitGround(CMotionInterp*)
    public void HitGround() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, void>)0x005296D0)(ref this);
    // void __thiscall CMotionInterp::LeaveGround(CMotionInterp*)
    public void LeaveGround() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, void>)0x00529710)(ref this);
    // void __thiscall CMotionInterp::set_hold_run(CMotionInterp*,int,int)
    public void set_hold_run(int val, int cancel_moveto) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, int, int, void>)0x00529780)(ref this, val, cancel_moveto);
    // void __thiscall CMotionInterp::SetHoldKey(CMotionInterp*,HoldKey,int)
    public void SetHoldKey(ACBindings.HoldKey key, int cancel_moveto) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, ACBindings.HoldKey, int, void>)0x005297C0)(ref this, key, cancel_moveto);
    // CMotionInterp* __cdecl CMotionInterp::Create(CPhysicsObj*,CWeenieObject*)
    public static ACBindings.CMotionInterp* Create(ACBindings.CPhysicsObj* physics_obj, ACBindings.CWeenieObject* weenie_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.CPhysicsObj*, ACBindings.CWeenieObject*, ACBindings.CMotionInterp*>)0x00529810)(physics_obj, weenie_obj);
    // void __thiscall CMotionInterp::enter_default_state(CMotionInterp*)
    public void enter_default_state() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, void>)0x00529890)(ref this);
    // unsigned int __thiscall CMotionInterp::DoMotion(CMotionInterp*,unsigned int,const MovementParameters*)
    public uint DoMotion(uint motion, ACBindings.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, uint, ACBindings.MovementParameters*, uint>)0x00529930)(ref this, motion, params_);
    // unsigned int __thiscall CMotionInterp::PerformMovement(CMotionInterp*,const MovementStruct*)
    public uint PerformMovement(ACBindings.MovementStruct* mvs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CMotionInterp, ACBindings.MovementStruct*, uint>)0x00529A90)(ref this, mvs);
}

