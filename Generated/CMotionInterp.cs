namespace ACBindings.Internal;


/// <summary>Handles motion interpretation for in-game objects, converting raw movement inputs into smooth, physics‑aware states while tracking queued actions.</summary>
public unsafe struct CMotionInterp : System.IDisposable
{
    // Child Types

    /// <summary>Represents a node in the motion interpolation system, containing identifiers for context, motion clip, and error status.</summary>
    /// <remarks>Inherits linkage information from LListData to form a doubly linked list of motion nodes.</remarks>
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

    /// <summary>Evaluates the current motion substate to determine whether a jump can be performed; returns a non‑zero code when jumping is permitted.
    /// <code>Offset: 0x005285E0
    /// unsigned int __thiscall CMotionInterp::motion_allows_jump(CMotionInterp*,unsigned int)</code>
    /// </summary>
    /// <param name="substate">The identifier of the motion substate being evaluated.</param>
    /// <returns>Non‑zero (typically 72) if the substate allows a jump, otherwise zero.</returns>
    public uint motion_allows_jump(uint substate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint, uint>)0x005285E0)(ref this, substate);

    /// <summary>Determines whether a jump charge may be initiated for the associated motion interpreter by evaluating object state and current forward command.
    /// <code>Offset: 0x00528660
    /// unsigned int __thiscall CMotionInterp::jump_charge_is_allowed(CMotionInterp*)</code>
    /// </summary>
    /// <returns>Returns 72 if a jump charge is permissible; returns 73 if the object’s conditions prevent charging; returns 0 when the forward command disallows a charge.</returns>
    public uint jump_charge_is_allowed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint>)0x00528660)(ref this);

    /// <summary>Calculates the vertical jump velocity using the motion state's jump extent, clamping it to a sensible range and delegating final determination to the associated weenie object.
    /// <code>Offset: 0x005286B0
    /// float __thiscall CMotionInterp::get_jump_v_z(CMotionInterp*)</code>
    /// </summary>
    /// <returns>The resulting vertical velocity in units per second; zero if the jump is invalid or denied, otherwise the computed value (defaults to 10.0 when no weenie object exists).</returns>
    public float get_jump_v_z() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, float>)0x005286B0)(ref this);

    /// <summary>Retrieves the current motion style for the associated physics object.
    /// <code>Offset: 0x00528720
    /// unsigned int __thiscall CMotionInterp::InqStyle(CMotionInterp*)</code>
    /// </summary>
    /// <returns>The identifier of the active motion style as stored in the interpreted state.</returns>
    public uint InqStyle() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint>)0x00528720)(ref this);

    /// <summary>Destroys all pending motion nodes associated with this interpreter, freeing memory and resetting the list.
    /// <code>Offset: 0x00528750
    /// void __thiscall CMotionInterp::Destroy(CMotionInterp*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, void>)0x00528750)(ref this);

    /// <summary>Adds a new motion entry to the interpreter’s pending queue, storing the specified context ID, motion type, and jump error code.
    /// <code>Offset: 0x00528790
    /// void __thiscall CMotionInterp::add_to_queue(CMotionInterp*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="context_id">Identifier for the motion context or source.</param>
    /// <param name="motion">The motion command or state to be queued.</param>
    /// <param name="jump_error_code">Error code associated with a jump action, if any.</param>
    public void add_to_queue(uint context_id, uint motion, uint jump_error_code) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint, uint, uint, void>)0x00528790)(ref this, context_id, motion, jump_error_code);

    /// <summary>
    /// Adjusts the supplied motion identifier and speed according to the object's run rate or special movement rules, scaling speed for walking/running actions and clamping extreme values for certain motions.
    /// 
    /// <code>Offset: 0x005287F0
    /// void __thiscall CMotionInterp::apply_run_to_command(CMotionInterp*,unsigned int*,float*)</code>
    /// </summary>
    /// <param name="motion">Pointer to the current motion code; may be modified based on speed conditions.</param>
    /// <param name="speed">Pointer to the speed value that will be scaled or clamped by this function.</param>
    public void apply_run_to_command(uint* motion, float* speed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint*, float*, void>)0x005287F0)(ref this, motion, speed);

    /// <summary>Returns the maximum movement speed for this motion interpreter.
    /// <code>Offset: 0x005288C0
    /// float __thiscall CMotionInterp::get_max_speed(CMotionInterp*)</code>
    /// </summary>
    /// <returns>The maximum speed in units per second. If the associated weenie object supplies an overridden value via its virtual method, that value is multiplied by four; otherwise the stored run rate (my_run_rate) multiplied by four is used. When no weenie object exists, defaults to 4.0.</returns>
    public float get_max_speed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, float>)0x005288C0)(ref this);

    /// <summary>
    /// Computes the interpolator’s maximum movement speed by considering an object‑defined run rate or a forward command override, then scaling it by four.
    /// 
    /// <code>Offset: 0x00528910
    /// float __thiscall CMotionInterp::get_adjusted_max_speed(CMotionInterp*)</code>
    /// </summary>
    /// <returns>The adjusted maximum speed as a floating-point value.</returns>
    public float get_adjusted_max_speed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, float>)0x00528910)(ref this);

    /// <summary>Calculates the current movement velocity vector for the motion interpreter based on its interpreted state, including sidestep and forward commands, and clamps it to a maximum speed derived from the run rate.
    /// <code>Offset: 0x00528960
    /// void __thiscall CMotionInterp::get_state_velocity(CMotionInterp*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="v">The output Vector3 that receives the calculated velocity components (x, y, z).</param>
    public void get_state_velocity(ACBindings.Internal.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00528960)(ref this, v);

    /// <summary>Stops all motion of the entity immediately by canceling any move‑to requests, resetting raw and interpreted motion state to neutral, and invoking internal physics stop logic.
    /// <code>Offset: 0x00528A50
    /// unsigned int __thiscall CMotionInterp::StopCompletely(CMotionInterp*)</code>
    /// </summary>
    /// <returns>Zero on success; returns 8 if the object has no associated physics component.</returns>
    public uint StopCompletely() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint>)0x00528A50)(ref this);

    /// <summary>Finalizes a completed motion by unbinding any physics attachments, clearing associated actions, and removing the finished node from the pending motions list.
    /// <code>Offset: 0x00528AD0
    /// void __thiscall CMotionInterp::MotionDone(CMotionInterp*,int)</code>
    /// </summary>
    /// <param name="success">Indicates whether the motion was successful; this implementation currently ignores the value.</param>
    public void MotionDone(int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, int, void>)0x00528AD0)(ref this, success);

    /// <summary>Determines whether the associated object is currently stationary, based on its physics state and active movement commands.
    /// <code>Offset: 0x00528BB0
    /// int __thiscall CMotionInterp::is_standing_still(CMotionInterp*)</code>
    /// </summary>
    /// <returns>Non‑zero if the physics transient state indicates standing, the forward command matches the standing flag, and no sidestep or turn commands are active; otherwise zero.</returns>
    public int is_standing_still() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, int>)0x00528BB0)(ref this);

    /// <summary>Determines whether the motion interpreter has queued motions awaiting execution.
    /// <code>Offset: 0x00528BF0
    /// int __thiscall CMotionInterp::motions_pending(CMotionInterp*)</code>
    /// </summary>
    /// <returns>A non‑zero integer when at least one pending motion is present; otherwise returns zero.</returns>
    public int motions_pending() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, int>)0x00528BF0)(ref this);

    /// <summary>Releases resources owned by a CMotionInterp instance, destroying its interpreted and raw motion states.
    /// <code>Offset: 0x00528C00
    /// void __thiscall CMotionInterp::~CMotionInterp(CMotionInterp*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, void>)0x00528C00)(ref this);

    /// <summary>Adjusts the motion command and velocity for an entity, handling special motion codes and applying run modifiers based on a hold key.
    /// <code>Offset: 0x00528C20
    /// void __thiscall CMotionInterp::adjust_motion(CMotionInterp*,unsigned int*,float*,HoldKey)</code>
    /// </summary>
    /// <param name="motion">Pointer to the current motion code; may be updated to reflect direction changes or state transitions.</param>
    /// <param name="speed">Pointer to the speed factor; can be inverted or scaled by motion logic.</param>
    /// <param name="key">Hold key indicating special input (e.g., Run); if invalid, uses the entity's active hold key. If Run, a run scaling is applied to the command.</param>
    public void adjust_motion(uint* motion, float* speed, ACBindings.Internal.HoldKey key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint*, float*, ACBindings.Internal.HoldKey, void>)0x00528C20)(ref this, motion, speed, key);

    /// <summary>Computes the velocity a character will have when it leaves the ground, storing the result in the supplied Vector3.
    /// <code>Offset: 0x00528CD0
    /// void __thiscall CMotionInterp::get_leave_ground_velocity(CMotionInterp*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="v">The vector that receives the calculated leave‑ground velocity.</param>
    public void get_leave_ground_velocity(ACBindings.Internal.AC1Legacy.Vector3* v) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00528CD0)(ref this, v);

    /// <summary>Attempts to initiate a charge jump by evaluating the current motion and physics state, setting the standing_longjump flag when conditions are met.
    /// <code>Offset: 0x00528DD0
    /// unsigned int __thiscall CMotionInterp::charge_jump(CMotionInterp*)</code>
    /// </summary>
    /// <returns>The status code of the operation: 0 if the jump was successfully charged, 72 if the forward command forbids jumping, or 73 if the object cannot perform a jump due to internal constraints.</returns>
    public uint charge_jump() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint>)0x00528DD0)(ref this);

    /// <summary>Determines whether a given motion can proceed while the object is in contact by evaluating motion identifiers and physics state.
    /// <code>Offset: 0x00528E50
    /// int __thiscall CMotionInterp::contact_allows_move(CMotionInterp*,unsigned int)</code>
    /// </summary>
    /// <param name="motion">Identifier of the motion to test.</param>
    /// <returns>Non‑zero if movement is permitted, zero otherwise.</returns>
    public int contact_allows_move(uint motion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint, int>)0x00528E50)(ref this, motion);

    /// <summary>Determines whether a jump of the specified extent is permissible given the current motion state and stamina constraints.
    /// <code>Offset: 0x00528EC0
    /// unsigned int __thiscall CMotionInterp::jump_is_allowed(CMotionInterp*,float,int*)</code>
    /// </summary>
    /// <param name="extent">The desired jump distance or magnitude to evaluate.</param>
    /// <param name="stamina_cost">Receives the amount of stamina that would be consumed if the jump were allowed; may remain unchanged when the jump is disallowed.</param>
    /// <returns>Zero indicates success (jump allowed); a non‑zero error code signals why the jump cannot occur (e.g., 36 for missing physics or object, 71 for fully constrained). </returns>
    public uint jump_is_allowed(float extent, int* stamina_cost) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, float, int*, uint>)0x00528EC0)(ref this, extent, stamina_cost);

    /// <summary>Executes an interpreted motion on the object's physics component, handling special cases such as long jumps and link animations, queuing motions when immediate execution fails, and applying motion state changes based on movement parameters.
    /// <code>Offset: 0x00528F70
    /// unsigned int __thiscall CMotionInterp::DoInterpretedMotion(CMotionInterp*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    /// <p>
    ///   <param name="motion">The identifier of the motion to perform.</param>
    ///   <param name="params">A pointer to a MovementParameters structure that specifies details like distance, speed, context ID, and flags affecting motion behavior.</param>
    /// </p>
    /// <returns>An unsigned integer status code: 0 indicates success; other values (e.g., 8 for missing physics object or 36 when the move is disallowed) signal various failure conditions.</returns>
    public uint DoInterpretedMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint, ACBindings.Internal.MovementParameters*, uint>)0x00528F70)(ref this, motion, params_);

    /// <summary>Stops a specified interpreted motion on the associated physics object, taking into account contact restrictions and long‑jump standing conditions.
    /// <code>Offset: 0x00529080
    /// unsigned int __thiscall CMotionInterp::StopInterpretedMotion(CMotionInterp*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    /// <param name="motion">The identifier of the motion to stop.</param>
    /// <param name="params">Movement parameters that affect stopping behavior, including flags determining whether the motion should be removed from the interpreted state.</param>
    /// <returns>Zero if the motion stops successfully; otherwise a non‑zero error code (e.g., 8 when no physics object is present).</returns>
    public uint StopInterpretedMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint, ACBindings.Internal.MovementParameters*, uint>)0x00529080)(ref this, motion, params_);

    /// <summary>Stops a specified motion, optionally canceling the object's physics move‑to action and clearing a matching raw motion state based on flags in MovementParameters. Adjusts parameters before terminating interpreted motion.
    /// <code>Offset: 0x00529140
    /// unsigned int __thiscall CMotionInterp::StopMotion(CMotionInterp*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    /// <param name="motion">Identifier of the motion to stop.</param>
    /// <param name="params">MovementParameters that influence cancellation behavior; may contain flags controlling physics cancellation (0x80) and raw motion removal (0x2000).</param>
    /// <returns>Zero if the motion was successfully stopped; a non‑zero value (e.g., 8) indicates failure such as missing physics object.</returns>
    public uint StopMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint, ACBindings.Internal.MovementParameters*, uint>)0x00529140)(ref this, motion, params_);

    /// <summary>Applies movement commands derived from the object's interpreted state to its physics object, respecting cancellation of MoveTo actions and jump constraints.
    /// <code>Offset: 0x00529210
    /// void __thiscall CMotionInterp::apply_interpreted_movement(CMotionInterp*,int,int)</code>
    /// </summary>
    /// <param name="cancel_moveto">Flag indicating whether any pending MoveTo motion should be cancelled for this update.</param>
    /// <param name="disallow_jump">Flag that disables jumping during this movement update.</param>
    public void apply_interpreted_movement(int cancel_moveto, int disallow_jump) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, int, int, void>)0x00529210)(ref this, cancel_moveto, disallow_jump);

    /// <summary>Attempts to perform a jump for the motion interpreter, canceling any current movement and validating whether the jump is permitted based on the supplied extent and stamina adjustment.
    /// <code>Offset: 0x00529390
    /// unsigned int __thiscall CMotionInterp::jump(CMotionInterp*,float,int*)</code>
    /// </summary>
    /// <param name="extent">The desired distance or height of the jump.</param>
    /// <param name="stamina_adjustment">Pointer to an integer that may be modified to reflect stamina consumption for the jump.</param>
    /// <returns>Zero if a non‑allowed jump was queued, 8 if no physics object is available, otherwise the status code returned by CMotionInterp::jump_is_allowed indicating whether the jump succeeded or failed.</returns>
    public uint jump(float extent, int* stamina_adjustment) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, float, int*, uint>)0x00529390)(ref this, extent, stamina_adjustment);

    /// <summary>Converts raw motion inputs to an interpreted state, adjusting for hold keys and current style, then applies the resulting movement while respecting cancellation and jump restrictions.
    /// <code>Offset: 0x005293F0
    /// void __thiscall CMotionInterp::apply_raw_movement(CMotionInterp*,int,int)</code>
    /// </summary>
    /// <param name="cancel_moveto">If non‑zero, cancels any pending “move to” actions before applying new movement.</param>
    /// <param name="disallow_jump">When set, prevents jumping during this movement update.</param>
    public void apply_raw_movement(int cancel_moveto, int disallow_jump) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, int, int, void>)0x005293F0)(ref this, cancel_moveto, disallow_jump);

    /// <summary>Applies the object's current motion state to its physics component, selecting raw or interpreted movement based on autonomy and control conditions.
    /// <code>Offset: 0x00529480
    /// void __thiscall CMotionInterp::apply_current_movement(CMotionInterp*,int,int)</code>
    /// </summary>
    /// <param name="cancel_moveto">If non‑zero, cancels any pending move‑to actions before applying the new motion.</param>
    /// <param name="disallow_jump">If non‑zero, prevents jump motions from being applied during this update.</param>
    public void apply_current_movement(int cancel_moveto, int disallow_jump) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, int, int, void>)0x00529480)(ref this, cancel_moveto, disallow_jump);

    /// <summary>Applies either raw or interpreted movement to a physics-enabled object when the motion interpreter is initialized, choosing the method based on the object's validity and whether its movement is autonomous.
    /// <code>Offset: 0x005294E0
    /// void __thiscall CMotionInterp::ReportExhaustion(CMotionInterp*)</code>
    /// </summary>
    public void ReportExhaustion() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, void>)0x005294E0)(ref this);

    /// <summary>Associates a CWeenieObject with the motion interpreter and updates its movement handling if initialized.
    /// <code>Offset: 0x00529530
    /// void __thiscall CMotionInterp::SetWeenieObject(CMotionInterp*,CWeenieObject*)</code>
    /// </summary>
    /// <param name="weenie_obj">The weenie object to link.</param>
    public void SetWeenieObject(ACBindings.Internal.CWeenieObject* weenie_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, ACBindings.Internal.CWeenieObject*, void>)0x00529530)(ref this, weenie_obj);

    /// <summary>Associates a physics object with the motion interpreter and triggers an appropriate movement update when initialized.
    /// <code>Offset: 0x00529580
    /// void __thiscall CMotionInterp::SetPhysicsObject(CMotionInterp*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="physics_obj">The physics object to link, or null to detach the current one.</param>
    public void SetPhysicsObject(ACBindings.Internal.CPhysicsObj* physics_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, ACBindings.Internal.CPhysicsObj*, void>)0x00529580)(ref this, physics_obj);

    /// <summary>Updates the motion interpreter to reflect a new interpreted state, applying movement parameters and pending actions that fall within an allowable time window.
    /// <code>Offset: 0x005295D0
    /// int __thiscall CMotionInterp::move_to_interpreted_state(CMotionInterp*,const InterpretedMotionState*)</code>
    /// </summary>
    /// <param name="this">The CMotionInterp instance whose state is being updated.</param>
    /// <param name="new_state">A pointer to the target InterpretedMotionState containing desired motion properties and queued actions.</param>
    /// <returns>Non-zero if the physics object exists and the state was successfully applied; zero otherwise.</returns>
    public int move_to_interpreted_state(ACBindings.Internal.InterpretedMotionState* new_state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, ACBindings.Internal.InterpretedMotionState*, int>)0x005295D0)(ref this, new_state);

    /// <summary>Handles landing behavior by clearing link animations and resetting movement when the object hits ground.
    /// <code>Offset: 0x005296D0
    /// void __thiscall CMotionInterp::HitGround(CMotionInterp*)</code>
    /// </summary>
    public void HitGround() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, void>)0x005296D0)(ref this);

    /// <summary>Applies leave‑ground physics behavior by calculating a leave‑ground velocity, assigning it to the object's physics component, and resetting jump‑related state.
    /// <code>Offset: 0x00529710
    /// void __thiscall CMotionInterp::LeaveGround(CMotionInterp*)</code>
    /// </summary>
    public void LeaveGround() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, void>)0x00529710)(ref this);

    /// <summary>Sets or clears the run hold key status, updating motion state accordingly.
    /// <code>Offset: 0x00529780
    /// void __thiscall CMotionInterp::set_hold_run(CMotionInterp*,int,int)</code>
    /// </summary>
    /// <param name="val">Non‑zero to enable holding the run key; zero to disable it.</param>
    /// <param name="cancel_moveto">When non‑zero, cancels any pending move‑to operation while applying the new movement state.</param>
    public void set_hold_run(int val, int cancel_moveto) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, int, int, void>)0x00529780)(ref this, val, cancel_moveto);

    /// <summary>Changes the entity's current hold key, enabling or disabling run mode and optionally cancelling queued move‑to motions when switching keys.
    /// <code>Offset: 0x005297C0
    /// void __thiscall CMotionInterp::SetHoldKey(CMotionInterp*,HoldKey,int)</code>
    /// </summary>
    /// <param name="key">The desired hold state (e.g., Run or None).</param>
    /// <param name="cancel_moveto">If nonzero, any pending move-to action is cancelled when the hold key changes.</param>
    public void SetHoldKey(ACBindings.Internal.HoldKey key, int cancel_moveto) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, ACBindings.Internal.HoldKey, int, void>)0x005297C0)(ref this, key, cancel_moveto);

    /// <summary>Creates a new motion interpreter for the specified physics object and its associated weenie, initializing state and linking both objects.
    /// <code>Offset: 0x00529810
    /// CMotionInterp* __cdecl CMotionInterp::Create(CPhysicsObj*,CWeenieObject*)</code>
    /// </summary>
    /// <param name="physics_obj">Physics object to be controlled by the motion interpreter.</param>
    /// <param name="weenie_obj">Weenie object that owns or is represented by the motion interpreter.</param>
    /// <returns>Pointer to the initialized CMotionInterp instance; null if memory allocation fails.</returns>
    public static ACBindings.Internal.CMotionInterp* Create(ACBindings.Internal.CPhysicsObj* physics_obj, ACBindings.Internal.CWeenieObject* weenie_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.CMotionInterp*>)0x00529810)(physics_obj, weenie_obj);

    /// <summary>Initializes the motion interpreter to its default state by resetting raw and interpreted motion data, reinitializing physics tables, creating an initial pending motion list, marking the object as initialized, and updating ground status.
    /// <code>Offset: 0x00529890
    /// void __thiscall CMotionInterp::enter_default_state(CMotionInterp*)</code>
    /// </summary>
    public void enter_default_state() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, void>)0x00529890)(ref this);

    /// <summary>Executes a movement command on the linked physics object, applying motion parameters, handling hold key flags, adjusting speed, and updating both interpreted and raw motion states.
    /// <code>Offset: 0x00529930
    /// unsigned int __thiscall CMotionInterp::DoMotion(CMotionInterp*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    /// <param name="motion">Identifier of the motion to perform; may include special flag bits that trigger early returns or additional checks.</param>
    /// <param name="params">Pointer to a MovementParameters structure that supplies target distance, desired heading, speed, fail conditions, hold key information, and context data for the motion.</param>
    /// <returns>Unsigned integer status code: 8 if no physics object is available; specific values (63‑66, 69) indicate early termination due to current style or action limits; otherwise returns the result of DoInterpretedMotion, with fallback to raw motion when appropriate.</returns>
    public uint DoMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, uint, ACBindings.Internal.MovementParameters*, uint>)0x00529930)(ref this, motion, params_);

    /// <summary>Executes a movement instruction described by the supplied MovementStruct, dispatching to raw or interpreted motion handlers, stopping motions, or clearing all motions as requested.
    /// <code>Offset: 0x00529A90
    /// unsigned int __thiscall CMotionInterp::PerformMovement(CMotionInterp*,const MovementStruct*)</code>
    /// </summary>
    /// <param name="mvs">Movement instructions containing command type, motion identifier, and associated parameters.</param>
    /// <returns>An unsigned int status code returned by the underlying motion operation; zero usually indicates success, while non‑zero values (e.g., 71) signal errors or unsupported commands.</returns>
    public uint PerformMovement(ACBindings.Internal.MovementStruct* mvs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CMotionInterp, ACBindings.Internal.MovementStruct*, uint>)0x00529A90)(ref this, mvs);
}

