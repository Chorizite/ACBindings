namespace ACBindings.Internal;

public unsafe struct CMotionInterp : System.IDisposable
{
    // Child Types
    public unsafe struct MotionNode
    {
        // Base Classes
        public ACBindings.Internal.LListData BaseClass_LListData; // ACBindings.Internal.LListData

        // Members
        public uint context_id;
        public uint motion;
        public uint jump_error_code;

        // Methods
    }

    // Members
    public int initted;
    public ACBindings.Internal.CWeenieObject* weenie_obj;
    public ACBindings.Internal.CPhysicsObj* physics_obj;
    public ACBindings.Internal.RawMotionState raw_state;
    public ACBindings.Internal.InterpretedMotionState interpreted_state;
    public float current_speed_factor;
    public int standing_longjump;
    public float jump_extent;
    public uint server_action_stamp;
    public float my_run_rate;
    public ACBindings.Internal.LList___CMotionInterp_MotionNode pending_motions;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005285E0
    /// unsigned int __thiscall CMotionInterp::motion_allows_jump(CMotionInterp*,unsigned int)</code>
    /// </summary>
    public uint motion_allows_jump(uint substate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint, uint>)0x005285E0)(ref this, substate);

    /// <summary>
    /// <code>Offset: 0x00528660
    /// unsigned int __thiscall CMotionInterp::jump_charge_is_allowed(CMotionInterp*)</code>
    /// </summary>
    public uint jump_charge_is_allowed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint>)0x00528660)(ref this);

    /// <summary>
    /// <code>Offset: 0x005286B0
    /// float __thiscall CMotionInterp::get_jump_v_z(CMotionInterp*)</code>
    /// </summary>
    public float get_jump_v_z() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, float>)0x005286B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00528720
    /// unsigned int __thiscall CMotionInterp::InqStyle(CMotionInterp*)</code>
    /// </summary>
    public uint InqStyle() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint>)0x00528720)(ref this);

    /// <summary>
    /// <code>Offset: 0x00528750
    /// void __thiscall CMotionInterp::Destroy(CMotionInterp*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, void>)0x00528750)(ref this);

    /// <summary>
    /// <code>Offset: 0x00528790
    /// void __thiscall CMotionInterp::add_to_queue(CMotionInterp*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void add_to_queue(uint context_id, uint motion, uint jump_error_code) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint, uint, uint, void>)0x00528790)(ref this, context_id, motion, jump_error_code);

    /// <summary>
    /// <code>Offset: 0x005287F0
    /// void __thiscall CMotionInterp::apply_run_to_command(CMotionInterp*,unsigned int*,float*)</code>
    /// </summary>
    public void apply_run_to_command(uint* motion, float* speed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint*, float*, void>)0x005287F0)(ref this, motion, speed);

    /// <summary>
    /// <code>Offset: 0x005288C0
    /// float __thiscall CMotionInterp::get_max_speed(CMotionInterp*)</code>
    /// </summary>
    public float get_max_speed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, float>)0x005288C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00528910
    /// float __thiscall CMotionInterp::get_adjusted_max_speed(CMotionInterp*)</code>
    /// </summary>
    public float get_adjusted_max_speed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, float>)0x00528910)(ref this);

    /// <summary>
    /// <code>Offset: 0x00528960
    /// void __thiscall CMotionInterp::get_state_velocity(CMotionInterp*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public void get_state_velocity(ACBindings.Internal.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00528960)(ref this, v);

    /// <summary>
    /// <code>Offset: 0x00528A50
    /// unsigned int __thiscall CMotionInterp::StopCompletely(CMotionInterp*)</code>
    /// </summary>
    public uint StopCompletely() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint>)0x00528A50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00528AD0
    /// void __thiscall CMotionInterp::MotionDone(CMotionInterp*,int)</code>
    /// </summary>
    public void MotionDone(int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, int, void>)0x00528AD0)(ref this, success);

    /// <summary>
    /// <code>Offset: 0x00528BB0
    /// int __thiscall CMotionInterp::is_standing_still(CMotionInterp*)</code>
    /// </summary>
    public int is_standing_still() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, int>)0x00528BB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00528BF0
    /// int __thiscall CMotionInterp::motions_pending(CMotionInterp*)</code>
    /// </summary>
    public int motions_pending() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, int>)0x00528BF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00528C00
    /// void __thiscall CMotionInterp::~CMotionInterp(CMotionInterp*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, void>)0x00528C00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00528C20
    /// void __thiscall CMotionInterp::adjust_motion(CMotionInterp*,unsigned int*,float*,HoldKey)</code>
    /// </summary>
    public void adjust_motion(uint* motion, float* speed, ACBindings.Internal.HoldKey key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint*, float*, ACBindings.Internal.HoldKey, void>)0x00528C20)(ref this, motion, speed, key);

    /// <summary>
    /// <code>Offset: 0x00528CD0
    /// void __thiscall CMotionInterp::get_leave_ground_velocity(CMotionInterp*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public void get_leave_ground_velocity(ACBindings.Internal.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00528CD0)(ref this, v);

    /// <summary>
    /// <code>Offset: 0x00528DD0
    /// unsigned int __thiscall CMotionInterp::charge_jump(CMotionInterp*)</code>
    /// </summary>
    public uint charge_jump() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint>)0x00528DD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00528E50
    /// int __thiscall CMotionInterp::contact_allows_move(CMotionInterp*,unsigned int)</code>
    /// </summary>
    public int contact_allows_move(uint motion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint, int>)0x00528E50)(ref this, motion);

    /// <summary>
    /// <code>Offset: 0x00528EC0
    /// unsigned int __thiscall CMotionInterp::jump_is_allowed(CMotionInterp*,float,int*)</code>
    /// </summary>
    public uint jump_is_allowed(float extent, int* stamina_cost) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, float, int*, uint>)0x00528EC0)(ref this, extent, stamina_cost);

    /// <summary>
    /// <code>Offset: 0x00528F70
    /// unsigned int __thiscall CMotionInterp::DoInterpretedMotion(CMotionInterp*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    public uint DoInterpretedMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint, ACBindings.Internal.MovementParameters*, uint>)0x00528F70)(ref this, motion, params_);

    /// <summary>
    /// <code>Offset: 0x00529080
    /// unsigned int __thiscall CMotionInterp::StopInterpretedMotion(CMotionInterp*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    public uint StopInterpretedMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint, ACBindings.Internal.MovementParameters*, uint>)0x00529080)(ref this, motion, params_);

    /// <summary>
    /// <code>Offset: 0x00529140
    /// unsigned int __thiscall CMotionInterp::StopMotion(CMotionInterp*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    public uint StopMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint, ACBindings.Internal.MovementParameters*, uint>)0x00529140)(ref this, motion, params_);

    /// <summary>
    /// <code>Offset: 0x00529210
    /// void __thiscall CMotionInterp::apply_interpreted_movement(CMotionInterp*,int,int)</code>
    /// </summary>
    public void apply_interpreted_movement(int cancel_moveto, int disallow_jump) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, int, int, void>)0x00529210)(ref this, cancel_moveto, disallow_jump);

    /// <summary>
    /// <code>Offset: 0x00529390
    /// unsigned int __thiscall CMotionInterp::jump(CMotionInterp*,float,int*)</code>
    /// </summary>
    public uint jump(float extent, int* stamina_adjustment) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, float, int*, uint>)0x00529390)(ref this, extent, stamina_adjustment);

    /// <summary>
    /// <code>Offset: 0x005293F0
    /// void __thiscall CMotionInterp::apply_raw_movement(CMotionInterp*,int,int)</code>
    /// </summary>
    public void apply_raw_movement(int cancel_moveto, int disallow_jump) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, int, int, void>)0x005293F0)(ref this, cancel_moveto, disallow_jump);

    /// <summary>
    /// <code>Offset: 0x00529480
    /// void __thiscall CMotionInterp::apply_current_movement(CMotionInterp*,int,int)</code>
    /// </summary>
    public void apply_current_movement(int cancel_moveto, int disallow_jump) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, int, int, void>)0x00529480)(ref this, cancel_moveto, disallow_jump);

    /// <summary>
    /// <code>Offset: 0x005294E0
    /// void __thiscall CMotionInterp::ReportExhaustion(CMotionInterp*)</code>
    /// </summary>
    public void ReportExhaustion() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, void>)0x005294E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00529530
    /// void __thiscall CMotionInterp::SetWeenieObject(CMotionInterp*,CWeenieObject*)</code>
    /// </summary>
    public void SetWeenieObject(ACBindings.Internal.CWeenieObject* weenie_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, ACBindings.Internal.CWeenieObject*, void>)0x00529530)(ref this, weenie_obj);

    /// <summary>
    /// <code>Offset: 0x00529580
    /// void __thiscall CMotionInterp::SetPhysicsObject(CMotionInterp*,CPhysicsObj*)</code>
    /// </summary>
    public void SetPhysicsObject(ACBindings.Internal.CPhysicsObj* physics_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, ACBindings.Internal.CPhysicsObj*, void>)0x00529580)(ref this, physics_obj);

    /// <summary>
    /// <code>Offset: 0x005295D0
    /// int __thiscall CMotionInterp::move_to_interpreted_state(CMotionInterp*,const InterpretedMotionState*)</code>
    /// </summary>
    public int move_to_interpreted_state(ACBindings.Internal.InterpretedMotionState* new_state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, ACBindings.Internal.InterpretedMotionState*, int>)0x005295D0)(ref this, new_state);

    /// <summary>
    /// <code>Offset: 0x005296D0
    /// void __thiscall CMotionInterp::HitGround(CMotionInterp*)</code>
    /// </summary>
    public void HitGround() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, void>)0x005296D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00529710
    /// void __thiscall CMotionInterp::LeaveGround(CMotionInterp*)</code>
    /// </summary>
    public void LeaveGround() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, void>)0x00529710)(ref this);

    /// <summary>
    /// <code>Offset: 0x00529780
    /// void __thiscall CMotionInterp::set_hold_run(CMotionInterp*,int,int)</code>
    /// </summary>
    public void set_hold_run(int val, int cancel_moveto) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, int, int, void>)0x00529780)(ref this, val, cancel_moveto);

    /// <summary>
    /// <code>Offset: 0x005297C0
    /// void __thiscall CMotionInterp::SetHoldKey(CMotionInterp*,HoldKey,int)</code>
    /// </summary>
    public void SetHoldKey(ACBindings.Internal.HoldKey key, int cancel_moveto) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, ACBindings.Internal.HoldKey, int, void>)0x005297C0)(ref this, key, cancel_moveto);

    /// <summary>
    /// <code>Offset: 0x00529810
    /// CMotionInterp* __cdecl CMotionInterp::Create(CPhysicsObj*,CWeenieObject*)</code>
    /// </summary>
    public static ACBindings.Internal.CMotionInterp* Create(ACBindings.Internal.CPhysicsObj* physics_obj, ACBindings.Internal.CWeenieObject* weenie_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.CMotionInterp*>)0x00529810)(physics_obj, weenie_obj);

    /// <summary>
    /// <code>Offset: 0x00529890
    /// void __thiscall CMotionInterp::enter_default_state(CMotionInterp*)</code>
    /// </summary>
    public void enter_default_state() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, void>)0x00529890)(ref this);

    /// <summary>
    /// <code>Offset: 0x00529930
    /// unsigned int __thiscall CMotionInterp::DoMotion(CMotionInterp*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    public uint DoMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint, ACBindings.Internal.MovementParameters*, uint>)0x00529930)(ref this, motion, params_);

    /// <summary>
    /// <code>Offset: 0x00529A90
    /// unsigned int __thiscall CMotionInterp::PerformMovement(CMotionInterp*,const MovementStruct*)</code>
    /// </summary>
    public uint PerformMovement(ACBindings.Internal.MovementStruct* mvs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, ACBindings.Internal.MovementStruct*, uint>)0x00529A90)(ref this, mvs);
}

