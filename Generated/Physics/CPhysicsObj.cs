namespace ACBindings.Internal;


/// <summary>Represents the physical state and behavior of an in‑game object, storing its position, velocity, forces, interactions with other objects, and environmental factors for use by the physics engine.</summary>
public unsafe struct CPhysicsObj : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.LongHashData BaseClass_LongHashData; // ACBindings.Internal.LongHashData

    // Statics
    public static ACBindings.Internal.CObjectMaint** obj_maint = (ACBindings.Internal.CObjectMaint**)0x00844D64;
    public static ACBindings.Internal.CPhysicsObj** player_object = (ACBindings.Internal.CPhysicsObj**)0x00844D68;

    // Child Types
    public unsafe struct CPhysicsObj_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CPhysicsObj*, void> CPhysicsObj_dtor_0; // function pointer

        // Methods
    }

    /// <summary>Records collision state for a physics object, storing the timestamp of the last touch and flag indicating ethereal status.</summary>
    /// <remarks>The touched_time field holds the time of the most recent collision event, while ethereal denotes whether the object should participate in physical interactions.</remarks>
    public unsafe struct CollisionRecord
    {
        // Members
        public double touched_time;
        public int ethereal;

        // Methods
    }

    // Members
    public System.IntPtr netblob_list;
    public ACBindings.Internal.CPartArray* part_array;
    public ACBindings.Internal.AC1Legacy.Vector3 player_vector;
    public float player_distance;
    public float CYpt;
    public ACBindings.Internal.CSoundTable* sound_table;
    public byte m_bExaminationObject;
    public ACBindings.Internal.ScriptManager* script_manager;
    public ACBindings.Internal.PhysicsScriptTable* physics_script_table;
    public ACBindings.Internal.PScriptType default_script;
    public float default_script_intensity;
    public ACBindings.Internal.CPhysicsObj* parent;
    public ACBindings.Internal.CHILDLIST* children;
    public ACBindings.Internal.Position m_position;
    public ACBindings.Internal.CObjCell* cell;
    public uint num_shadow_objects;
    public ACBindings.Internal.DArray___CShadowObj shadow_objects;
    public uint state;
    public uint transient_state;
    public float elasticity;
    public float translucency;
    public float translucencyOriginal;
    public float friction;
    public float massinv;
    public ACBindings.Internal.MovementManager* movement_manager;
    public ACBindings.Internal.PositionManager* position_manager;
    public int last_move_was_autonomous;
    public int jumped_this_frame;
    public double update_time;
    public ACBindings.Internal.AC1Legacy.Vector3 m_velocityVector;
    public ACBindings.Internal.AC1Legacy.Vector3 m_accelerationVector;
    public ACBindings.Internal.AC1Legacy.Vector3 m_omegaVector;
    public ACBindings.Internal.PhysicsObjHook* hooks;
    public ACBindings.Internal.AC1Legacy.SmartArray___CAnimHook_ptr anim_hooks;
    public float m_scale;
    public float attack_radius;
    public ACBindings.Internal.DetectionManager* detection_manager;
    public ACBindings.Internal.AttackManager* attack_manager;
    public ACBindings.Internal.TargetManager* target_manager;
    public ACBindings.Internal.ParticleManager* particle_manager;
    public ACBindings.Internal.CWeenieObject* weenie_obj;
    public ACBindings.Internal.Plane contact_plane;
    public uint contact_plane_cell_id;
    public ACBindings.Internal.AC1Legacy.Vector3 sliding_normal;
    public ACBindings.Internal.AC1Legacy.Vector3 cached_velocity;
    public System.IntPtr collision_table;
    public int colliding_with_environment;
    public fixed ushort update_times[9];

    // Generated Constructor
    public CPhysicsObj() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Determines whether the supplied 16‑bit timestamp represents a more recent time than another, accounting for wrap‑around.
    /// <code>Offset: 0x00451B10
    /// int __cdecl CPhysicsObj::is_newer(unsigned __int16,unsigned __int16)</code>
    /// </summary>
    /// <param name="timestamp">The current timestamp to compare against.</param>
    /// <param name="new_time">The candidate newer timestamp.</param>
    /// <returns>Nonzero if new_time is considered newer; zero otherwise.</returns>
    public static int is_newer(ushort timestamp, ushort new_time) => ((delegate* unmanaged[Cdecl]<ushort, ushort, int>)0x00451B10)(timestamp, new_time);

    /// <summary>Updates the object's timestamp for a given event type when the supplied value is newer, handling 16‑bit wrap‑around.
    /// <code>Offset: 0x00451B50
    /// int __thiscall CPhysicsObj::newer_event(CPhysicsObj*,PhysicsTimeStamp,unsigned __int16)</code>
    /// </summary>
    /// <param name="stamp">Index identifying which update time to compare.</param>
    /// <param name="new_time">The proposed new timestamp value.</param>
    /// <returns>1 if the stored timestamp was updated; 0 otherwise.</returns>
    public int newer_event(ACBindings.Internal.PhysicsTimeStamp stamp, ushort new_time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.PhysicsTimeStamp, ushort, int>)0x00451B50)(ref this, stamp, new_time);

    /// <summary>Returns a constant pointer to the object's position and orientation frame.
    /// <code>Offset: 0x00452950
    /// const Frame* __thiscall CPhysicsObj::get_frame(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>A pointer to the internal Frame structure representing the object's transform.</returns>
    public ACBindings.Internal.Frame* get_frame() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Frame*>)0x00452950)(ref this);

    /// <summary>Creates a new CPartArray configuration for this physics object using the supplied arguments, assigns it to the object's part_array member, and indicates whether creation succeeded.
    /// <code>Offset: 0x0050F400
    /// BOOL __thiscall CPhysicsObj::makeAnimObject(CPhysicsObj*,int,int)</code>
    /// </summary>
    /// <param name="a2">First argument used to configure the animation setup (e.g., type or identifier).</param>
    /// <param name="a3">Second argument used in configuring the animation setup.</param>
    /// <returns>True if a part array was successfully created; otherwise false.</returns>
    public byte makeAnimObject(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int, byte>)0x0050F400)(ref this, a2, a3);

    /// <summary>Retrieves the setup identifier from this object's part array if present, otherwise writes an invalid ID.
    /// <code>Offset: 0x0050F430
    /// unsigned int* __thiscall CPhysicsObj::GetSetupID(_DWORD*,unsigned int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an unsigned integer that will receive the retrieved or default ID.</param>
    /// <returns>The same pointer supplied via a2, now containing the obtained setup identifier.</returns>
    public uint* GetSetupID(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint*, uint*>)0x0050F430)(ref this, a2);

    /// <summary>Retrieves the data identifier for the physics object. If the object contains a part array, forwards the call; otherwise assigns a predefined invalid ID.
    /// <code>Offset: 0x0050F460
    /// unsigned int* __thiscall CPhysicsObj::GetDataID(_DWORD*,unsigned int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an unsigned integer that receives the data identifier.</param>
    /// <returns>A pointer to the updated identifier (the same as the supplied a2).</returns>
    public uint* GetDataID(uint* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint*, uint*>)0x0050F460)(ref this, a2);

    /// <summary>Retrieves the radius of the physics object’s collision shape.
    /// <code>Offset: 0x0050F490
    /// float __thiscall CPhysicsObj::GetRadius(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>The radius if a part array exists; otherwise zero.</returns>
    public float GetRadius() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x0050F490)(ref this);

    /// <summary>Returns the vertical extent of the object by querying its part array. If the object has no parts, returns 0.
    /// <code>Offset: 0x0050F4B0
    /// float __thiscall CPhysicsObj::GetHeight(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>The height (in world units) of the physics object, or zero if it contains no parts.</returns>
    public float GetHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x0050F4B0)(ref this);

    /// <summary>Calculates the step‑up height of the physics object based on its part array configuration.
    /// <code>Offset: 0x0050F4D0
    /// float __thiscall CPhysicsObj::GetStepUpHeight(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>The step‑up height in world units; returns 0 if no part array exists and defaults to 0.01 when setup data is missing.</returns>
    public float GetStepUpHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x0050F4D0)(ref this);

    /// <summary>Returns the vertical distance an object can step down safely, derived from its part configuration or a minimal default if none.
    /// <code>Offset: 0x0050F4F0
    /// float __thiscall CPhysicsObj::GetStepDownHeight(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>The calculated step‑down height as a floating‑point value in world units.</returns>
    public float GetStepDownHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x0050F4F0)(ref this);

    /// <summary>
    /// Computes the bounding sphere used for object selection by delegating to its part array, if present.
    /// 
    /// <code>Offset: 0x0050F510
    /// int __thiscall CPhysicsObj::GetSelectionSphere(CPhysicsObj*,CSphere*)</code>
    /// </summary>
    /// <param name="selection_sphere">
    /// Out parameter populated with the sphere's center and radius when a valid part array exists; otherwise left unchanged.
    /// </param>
    /// <returns>Non‑zero on success (part array provided), zero when no part array is available.</returns>
    public int GetSelectionSphere(ACBindings.Internal.CSphere* selection_sphere) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CSphere*, int>)0x0050F510)(ref this, selection_sphere);

    /// <summary>Prepares the physics object's parts for motion sequencing by initializing their motion tables when available.
    /// <code>Offset: 0x0050F530
    /// void __thiscall CPhysicsObj::InitializeMotionTables(CPhysicsObj*)</code>
    /// </summary>
    public void InitializeMotionTables() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x0050F530)(ref this);

    /// <summary>Delegates interpreted motion to the object's part array if available; otherwise returns an error code.
    /// <code>Offset: 0x0050F540
    /// unsigned int __thiscall CPhysicsObj::DoInterpretedMotion(CPhysicsObj*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    /// <param name="motion">Identifier of the motion to perform.</param>
    /// <param name="params">Movement parameters controlling speed, heading, and other motion attributes.</param>
    /// <returns>Status code indicating success or failure. Returns 71 when no part array is present.</returns>
    public uint DoInterpretedMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, ACBindings.Internal.MovementParameters*, uint>)0x0050F540)(ref this, motion, params_);

    /// <summary>Halts an interpreted motion on this physics object by delegating to its part array when present.
    /// <code>Offset: 0x0050F560
    /// unsigned int __thiscall CPhysicsObj::StopInterpretedMotion(CPhysicsObj*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    /// <param name="motion">Identifier of the motion to stop.</param>
    /// <param name="params">Movement parameters that influence how the motion is halted.</param>
    /// <returns>The status code returned by the part array's StopInterpretedMotion, or 71 if no part array exists.</returns>
    public uint StopInterpretedMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, ACBindings.Internal.MovementParameters*, uint>)0x0050F560)(ref this, motion, params_);

    /// <summary>Returns non‑zero if the object's MovementManager reports pending motions; zero otherwise.
    /// <code>Offset: 0x0050F580
    /// int __thiscall CPhysicsObj::motions_pending(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>An integer indicating whether any motions are pending (non‑zero means pending).</returns>
    public int motions_pending() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x0050F580)(ref this);

    /// <summary>Stops all physics simulation components of the object, halting movement and resetting motion-related state.
    /// <code>Offset: 0x0050F5A0
    /// void __thiscall CPhysicsObj::StopCompletely_Internal(CPhysicsObj*)</code>
    /// </summary>
    public void StopCompletely_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x0050F5A0)(ref this);

    /// <summary>Unstucks the object from any positional constraints by invoking UnStick on its PositionManager.
    /// <code>Offset: 0x0050F5B0
    /// void __thiscall CPhysicsObj::unstick_from_object(CPhysicsObj*)</code>
    /// </summary>
    public void unstick_from_object() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x0050F5B0)(ref this);

    /// <summary>Returns the identifier of the sticky object associated with this physics object's position manager, or zero when no sticky object exists.
    /// <code>Offset: 0x0050F5C0
    /// unsigned int __thiscall CPhysicsObj::get_sticky_object_id(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>The sticky object's ID, or 0 if none.</returns>
    public uint get_sticky_object_id() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint>)0x0050F5C0)(ref this);

    /// <summary>Determines whether the physics object has an active movement target by querying its MovementManager.
    /// <code>Offset: 0x0050F5E0
    /// int __thiscall CPhysicsObj::IsMovingTo(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>Non‑zero when the object is in motion toward a destination; zero otherwise.</returns>
    public int IsMovingTo() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x0050F5E0)(ref this);

    /// <summary>Indicates whether the object's most recent movement was performed autonomously.
    /// <code>Offset: 0x0050F600
    /// int __thiscall CPhysicsObj::movement_is_autonomous(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>A non‑zero integer if the last move was autonomous, otherwise zero.</returns>
    public int movement_is_autonomous() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x0050F600)(ref this);

    /// <summary>Terminates position interpolation for this physics object, delegating to its PositionManager if available.
    /// <code>Offset: 0x0050F610
    /// void __thiscall CPhysicsObj::StopInterpolating(CPhysicsObj*)</code>
    /// </summary>
    public void StopInterpolating() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x0050F610)(ref this);

    /// <summary>Determines whether the physics object's position manager has a non‑empty interpolation queue.
    /// <code>Offset: 0x0050F620
    /// int __thiscall CPhysicsObj::IsInterpolating(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>Non‑zero if an interpolation manager exists and its queue holds pending positions; otherwise zero.</returns>
    public int IsInterpolating() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x0050F620)(ref this);

    /// <summary>Provides the autonomy blip distance for a physics object, varying by whether it is the player and its cell location.
    /// <code>Offset: 0x0050F640
    /// float __thiscall CPhysicsObj::GetAutonomyBlipDistance(CPhysicsObj*)</code>
    /// </summary>
    /// <param name="this">The physics object requesting the blip distance.</param>
    /// <returns>The calculated blip distance as a float; 25.0 or 20.0 units for objects in cells with ID ≥ 256, otherwise 100.0 units.</returns>
    public float GetAutonomyBlipDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x0050F640)(ref this);

    /// <summary>Computes the starting constraint distance for a physics object based on its cell identifier, returning 5.0 when the object resides in a higher‑level cell (ID ≥ 256) and 10.0 otherwise.
    /// <code>Offset: 0x0050F690
    /// float __thiscall CPhysicsObj::GetStartConstraintDistance(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>The initial distance threshold used by constraint logic.</returns>
    public float GetStartConstraintDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x0050F690)(ref this);

    /// <summary>Retrieves the maximum distance a physics constraint may extend from this object, determined by its cell identifier.
    /// <code>Offset: 0x0050F6E0
    /// float __thiscall CPhysicsObj::GetMaxConstraintDistance(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>The maximum constraint distance: 20.0 units for objects in cells with an ID of 0x100 or higher; otherwise 50.0 units.</returns>
    public float GetMaxConstraintDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x0050F6E0)(ref this);

    /// <summary>Returns non‑zero when the physics object’s positional offset exceeds 90 % of its maximum allowed constraint distance, indicating it is no longer fully constrained; otherwise returns zero. If the object lacks a position or constraint manager, the function also returns zero.
    /// <code>Offset: 0x0050F730
    /// int __thiscall CPhysicsObj::IsFullyConstrained(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>Non‑zero if offset > 0.9 × max constraint distance; zero otherwise.</returns>
    public int IsFullyConstrained() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x0050F730)(ref this);

    /// <summary>Determines whether this physics object would be struck by an attack originating from a specified position, scale, and cone shape, taking into account the object's dimensions and current state.
    /// <code>Offset: 0x0050F750
    /// unsigned int __thiscall CPhysicsObj::check_attack(CPhysicsObj*,const Position*,const float,const AttackCone*,float)</code>
    /// </summary>
    /// <param name="attacker_pos">Position of the attacking entity.</param>
    /// <param name="attacker_scale">Scale factor applied to the attack cone’s height and radius.</param>
    /// <param name="attack_cone">Cone geometry defining the direction and spread of the attack.</param>
    /// <param name="attacker_attack_radius">Additional radius added to the attack cone for collision detection.</param>
    /// <returns>Non‑zero if the attack intersects the object; zero otherwise.</returns>
    public uint check_attack(ACBindings.Internal.Position* attacker_pos, float attacker_scale, ACBindings.Internal.AttackCone* attack_cone, float attacker_attack_radius) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, float, ACBindings.Internal.AttackCone*, float, uint>)0x0050F750)(ref this, attacker_pos, attacker_scale, attack_cone, attacker_attack_radius);

    /// <summary>Assigns or updates a target relationship for this physics object via its internal TargetManager, creating the manager if needed before delegating to SetTarget.
    /// <code>Offset: 0x0050F800
    /// void __thiscall CPhysicsObj::set_target(CPhysicsObj*,unsigned int,unsigned int,float,long double)</code>
    /// </summary>
    /// <param name="context_id">Identifier indicating the targeting context (e.g., AI, player).</param>
    /// <param name="object_id">Unique identifier of the target object.</param>
    /// <param name="radius">Radius within which the target is considered valid.</param>
    /// <param name="quantum">Precise time value used by TargetManager for scheduling or evaluation.</param>
    public void set_target(uint context_id, uint object_id, float radius, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, uint, float, double, void>)0x0050F800)(ref this, context_id, object_id, radius, quantum);

    /// <summary>Removes the current target from this physics object by delegating to its TargetManager.
    /// <code>Offset: 0x0050F860
    /// void __thiscall CPhysicsObj::clear_target(CPhysicsObj*)</code>
    /// </summary>
    public void clear_target() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x0050F860)(ref this);

    /// <summary>Updates the physics object's target manager with a new quantum value, affecting targeting behavior.
    /// <code>Offset: 0x0050F870
    /// void __thiscall CPhysicsObj::set_target_quantum(CPhysicsObj*,long double)</code>
    /// </summary>
    /// <param name="new_quantum">The quantum to set for the target manager.</param>
    public void set_target_quantum(double new_quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, double, void>)0x0050F870)(ref this, new_quantum);

    /// <summary>Retrieves the current target's quantum value when a target is active; otherwise returns zero.
    /// <code>Offset: 0x0050F890
    /// float __thiscall CPhysicsObj::get_target_quantum(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>The quantum associated with the current target, or 0.0 if no target is present.</returns>
    public float get_target_quantum() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x0050F890)(ref this);

    /// <summary>Delivers updated target data to the physics object's target manager when available.
    /// <code>Offset: 0x0050F8B0
    /// void __thiscall CPhysicsObj::receive_target_update(CPhysicsObj*,const TargetInfo*)</code>
    /// </summary>
    /// <param name="info">Information about the target update.</param>
    public void receive_target_update(ACBindings.Internal.TargetInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.TargetInfo*, void>)0x0050F8B0)(ref this, info);

    /// <summary>Registers another physics object as a voyeur target for this object, creating a TargetManager if necessary.
    /// <code>Offset: 0x0050F8D0
    /// void __thiscall CPhysicsObj::add_voyeur(CPhysicsObj*,unsigned int,float,float)</code>
    /// </summary>
    /// <param name="object_id">Identifier of the object to be observed.</param>
    /// <param name="radius">Distance within which the voyeur can detect events.</param>
    /// <param name="quantum">Time interval or update frequency for the voyeur's monitoring.</param>
    public void add_voyeur(uint object_id, float radius, float quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, float, float, void>)0x0050F8D0)(ref this, object_id, radius, quantum);

    /// <summary>Removes the voyeur identified by object_id from the target manager’s voyeur table, freeing its resources.
    /// <code>Offset: 0x0050F920
    /// int __thiscall CPhysicsObj::remove_voyeur(CPhysicsObj*,unsigned int)</code>
    /// </summary>
    /// <param name="object_id">The identifier of the voyeur to be removed.</param>
    /// <returns>Non‑zero if the removal succeeded; zero otherwise.</returns>
    public int remove_voyeur(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int>)0x0050F920)(ref this, object_id);

    /// <summary>Applies friction to the physics object’s velocity based on its current state, contact plane, and motion parameters.
    /// <code>Offset: 0x0050F940
    /// void __thiscall CPhysicsObj::calc_friction(CPhysicsObj*,float,float)</code>
    /// </summary>
    /// <param name="quantum">Exponent used when scaling velocity by (1 – friction) raised to this power.</param>
    /// <param name="velocity_mag2">Squared magnitude of the object's velocity before friction is applied.</param>
    public void calc_friction(float quantum, float velocity_mag2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, float, void>)0x0050F940)(ref this, quantum, velocity_mag2);

    /// <summary>
    /// Determines whether the physics object collides with another during a transition by testing its part geometry against the target object's collision path and updates the transition's collision info accordingly.
    /// 
    /// <code>Offset: 0x0050FB20
    /// TransitionState __thiscall CPhysicsObj::FindObjCollisions(CPhysicsObj*,CTransition*)</code>
    /// </summary>
    /// <param name="this">The physics object whose collisions are being evaluated.</param>
    /// <param name="transition">Transition data containing the target object, sphere path, and collision information to be updated.</param>
    /// <returns>A TransitionState indicating the result of the collision check (e.g., OK_TS for no collision or a specific collision state).</returns>
    public ACBindings.Internal.TransitionState FindObjCollisions(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0050FB20)(ref this, transition);

    /// <summary>Updates the object's internal viewer distance parameter and forwards the change to its associated parts.
    /// <code>Offset: 0x0050FE10
    /// void __thiscall CPhysicsObj::UpdateViewerDistance(CPhysicsObj*,float,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="CYpt">New viewer distance or Y‑coordinate value used by the physics object.</param>
    /// <param name="viewer_heading">Vector indicating the viewer’s heading direction for part updates.</param>
    public void UpdateViewerDistance(float CYpt, ACBindings.Internal.AC1Legacy.Vector3* viewer_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x0050FE10)(ref this, CYpt, viewer_heading);

    /// <summary>Create or retrieve the particle manager for this physics object and register a new particle emitter using the supplied parameters.
    /// <code>Offset: 0x0050FE30
    /// unsigned int __thiscall CPhysicsObj::create_particle_emitter(CPhysicsObj*,int,unsigned int,Frame*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Identifier or flag specifying the type of emitter to create.</param>
    /// <param name="a3">Additional property value (e.g., priority, color index) used during emitter creation.</param>
    /// <param name="a4">Frame containing position, orientation and scale for the emitter.</param>
    /// <param name="a5">Emitter-specific data such as lifetime or particle count.</param>
    /// <returns>Identifier of the newly created particle emitter.</returns>
    public uint create_particle_emitter(int a2, uint a3, ACBindings.Internal.Frame* a4, uint a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, uint, ACBindings.Internal.Frame*, uint, uint>)0x0050FE30)(ref this, a2, a3, a4, a5);

    /// <summary>Creates a blocking particle emitter for the physics object, initializing its particle manager if it does not yet exist.
    /// <code>Offset: 0x0050FE80
    /// unsigned int __thiscall CPhysicsObj::create_blocking_particle_emitter(CPhysicsObj*,int,unsigned int,Frame*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">An integer identifying the specific type or configuration of the emitter to create.</param>
    /// <param name="a3">Unsigned flags or options that modify the behavior of the created emitter.</param>
    /// <param name="a4">Pointer to a <c>Frame</c> structure providing orientation and origin data for the emitter’s placement.</param>
    /// <param name="a5">Additional unsigned parameter, typically used for counts or duration settings associated with the emitter.</param>
    /// <returns>The unique identifier assigned to the newly created blocking particle emitter; returns zero if creation fails.</returns>
    public uint create_blocking_particle_emitter(int a2, uint a3, ACBindings.Internal.Frame* a4, uint a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, uint, ACBindings.Internal.Frame*, uint, uint>)0x0050FE80)(ref this, a2, a3, a4, a5);

    /// <summary>Destroys a particle emitter identified by its ID from the physics object's particle manager, if it exists.
    /// <code>Offset: 0x0050FED0
    /// int __thiscall CPhysicsObj::destroy_particle_emitter(CPhysicsObj*,unsigned int)</code>
    /// </summary>
    /// <param name="emitter_id">The identifier of the emitter to remove.</param>
    /// <returns>1 if an emitter was removed; 0 if none existed or the particle manager is unavailable. </returns>
    public int destroy_particle_emitter(uint emitter_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int>)0x0050FED0)(ref this, emitter_id);

    /// <summary>Stops the particle emitter identified by the specified ID within this physics object's particle manager.
    /// <code>Offset: 0x0050FEF0
    /// int __thiscall CPhysicsObj::stop_particle_emitter(CPhysicsObj*,unsigned int)</code>
    /// </summary>
    /// <param name="emitter_id">The identifier of the emitter to stop.</param>
    /// <returns>Non‑zero (1) if the emitter was successfully stopped; zero otherwise.</returns>
    public int stop_particle_emitter(uint emitter_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int>)0x0050FEF0)(ref this, emitter_id);

    /// <summary>Triggers playback of the specified sound type at the given volume for this physics object when a valid sound table is present.
    /// <code>Offset: 0x0050FF30
    /// int __thiscall CPhysicsObj::play_sound(CPhysicsObj*,SoundType,float)</code>
    /// </summary>
    /// <param name="sound_type">The enumeration value identifying which sound to play.</param>
    /// <param name="volume">Desired playback volume, typically between 0.0 and 1.0.</param>
    /// <returns>Returns 1 if the sound was successfully played; otherwise returns 0.</returns>
    public int play_sound(ACBindings.Internal.SoundType sound_type, float volume) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.SoundType, float, int>)0x0050FF30)(ref this, sound_type, volume);

    /// <summary>Retrieves a physics object by its identifier through the global object maintenance system.
    /// <code>Offset: 0x0050FF60
    /// CPhysicsObj* __cdecl CPhysicsObj::GetObjectA(unsigned int)</code>
    /// </summary>
    /// <param name="object_id">The unique identifier of the desired object.</param>
    /// <returns>A pointer to the requested CPhysicsObj if found; otherwise, null when the maintenance system is unavailable or the id does not exist.</returns>
    public static ACBindings.Internal.CPhysicsObj* GetObjectA(uint object_id) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CPhysicsObj*>)0x0050FF60)(object_id);

    /// <summary>Assigns the specified CObjectMaint instance as the manager for this physics object.
    /// <code>Offset: 0x0050FF80
    /// void __cdecl CPhysicsObj::SetObjectMaintainer(CObjectMaint*)</code>
    /// </summary>
    /// <param name="obj_maint">The object maintainer that will oversee this physics object's lifecycle and updates.</param>
    public static void SetObjectMaintainer(ACBindings.Internal.CObjectMaint* obj_maint) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CObjectMaint*, void>)0x0050FF80)(obj_maint);

    /// <summary>Designates the specified physics object as the current player within the simulation.
    /// <code>Offset: 0x0050FF90
    /// void __cdecl CPhysicsObj::SetPlayer(CPhysicsObj*)</code>
    /// </summary>
    /// <param name="new_player_object">The physics object to set as the active player.</param>
    public static void SetPlayer(ACBindings.Internal.CPhysicsObj* new_player_object) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, void>)0x0050FF90)(new_player_object);

    /// <summary>Assigns the specified weenie object to this physics object and updates the associated movement manager, if any.
    /// <code>Offset: 0x0050FFA0
    /// void __thiscall CPhysicsObj::set_weenie_obj_ptr(CPhysicsObj*,CWeenieObject*)</code>
    /// </summary>
    /// <param name="wobj">The CWeenieObject instance to link with the physics object.</param>
    public void set_weenie_obj_ptr(ACBindings.Internal.CWeenieObject* wobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CWeenieObject*, void>)0x0050FFA0)(ref this, wobj);

    /// <summary>Assigns a new cell identifier to the physics object, updating its position record and propagating the change to any attached part array unless the object is in a transient state.
    /// <code>Offset: 0x0050FFC0
    /// void __thiscall CPhysicsObj::set_cell_id(CPhysicsObj*,unsigned int)</code>
    /// </summary>
    /// <param name="new_cell_id">The identifier of the cell to which the object should belong.</param>
    public void set_cell_id(uint new_cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, void>)0x0050FFC0)(ref this, new_cell_id);

    /// <summary>Removes all physics components of this object that are situated within the specified object cell.
    /// <code>Offset: 0x0050FFF0
    /// void __thiscall CPhysicsObj::remove_parts(CPhysicsObj*,CObjCell*)</code>
    /// </summary>
    /// <param name="obj_cell">The cell whose contained parts will be cleared from the object.</param>
    public void remove_parts(ACBindings.Internal.CObjCell* obj_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CObjCell*, void>)0x0050FFF0)(ref this, obj_cell);

    /// <summary>Determines whether the supplied surface normal qualifies as a walkable plane by comparing its z‑component to the global floor threshold.
    /// <code>Offset: 0x00510000
    /// int __thiscall CPhysicsObj::is_valid_walkable(CPhysicsObj*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="normal">Vector describing the orientation of the surface whose walkability is being evaluated.</param>
    /// <returns>Non‑zero if the normal’s z component meets or exceeds PhysicsGlobals::floor_z, indicating a valid walkable surface; zero otherwise.</returns>
    public int is_valid_walkable(ACBindings.Internal.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00510000)(ref this, normal);

    /// <summary>Determines whether the object's part array has a cached physics BSP and updates an internal state flag accordingly.
    /// <code>Offset: 0x00510040
    /// int __thiscall CPhysicsObj::CacheHasPhysicsBSP(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>Returns 1 when a cached physics BSP is present; otherwise returns 0.</returns>
    public int CacheHasPhysicsBSP() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00510040)(ref this);

    /// <summary>Determines whether to accept a contact based on the object's velocity relative to its contact plane.
    /// <code>Offset: 0x00510080
    /// int __thiscall CPhysicsObj::check_contact(CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="contact">The contact value to return when conditions are satisfied.</param>
    /// <returns>Zero if the object has an active transient state and is moving away from the plane beyond a small threshold; otherwise returns the supplied contact value.</returns>
    public int check_contact(int contact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int>)0x00510080)(ref this, contact);

    /// <summary>Builds a collision profile by populating an ObjCollisionProfile structure with identifiers, velocity and contact flags based on another physics object's state.
    /// <code>Offset: 0x005100D0
    /// int __thiscall CPhysicsObj::build_collision_profile(CPhysicsObj*,ObjCollisionProfile*,const CPhysicsObj*,const AC1Legacy::Vector3*,const int,const int,const int)</code>
    /// </summary>
    /// <param name="prof">Output parameter that receives the constructed collision profile.</param>
    /// <param name="obj">Physics object whose data is used to build the profile.</param>
    /// <param name="vel">Velocity vector applied to the collision profile.</param>
    /// <param name="amIInContact">Indicates whether this object is in contact with the target object.</param>
    /// <param name="objIsMissile">Specifies whether the other object functions as a missile.</param>
    /// <param name="objHasContact">Indicates whether the other object is already in contact.</param>
    /// <returns>Returns 1 if the profile was successfully built; otherwise, returns 0 when the associated WeenieObject is missing or its virtual function is unavailable.</returns>
    public int build_collision_profile(ACBindings.Internal.ObjCollisionProfile* prof, ACBindings.Internal.CPhysicsObj* obj, ACBindings.Internal.AC1Legacy.Vector3* vel, int amIInContact, int objIsMissile, int objHasContact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.ObjCollisionProfile*, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.AC1Legacy.Vector3*, int, int, int, int>)0x005100D0)(ref this, prof, obj, vel, amIInContact, objIsMissile, objHasContact);

    /// <summary>Synchronizes part array frames with the object's current position frame unless a specific state flag is set.
    /// <code>Offset: 0x00510140
    /// void __thiscall CPhysicsObj::UpdatePartsInternal(CPhysicsObj*)</code>
    /// </summary>
    public void UpdatePartsInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00510140)(ref this);

    /// <summary>Applies a placement frame to the object's parts and updates part frames when appropriate.
    /// <code>Offset: 0x00510160
    /// int __thiscall CPhysicsObj::SetPlacementFrameInternal(CPhysicsObj*,unsigned int)</code>
    /// </summary>
    /// <param name="frame_id">Identifier of the placement frame to set.</param>
    /// <returns>Zero if no part array exists; otherwise, status code returned by CPartArray::SetPlacementFrame.</returns>
    public int SetPlacementFrameInternal(uint frame_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int>)0x00510160)(ref this, frame_id);

    /// <summary>Assigns a new angular velocity vector to the physics object.
    /// <code>Offset: 0x005101A0
    /// void __thiscall CPhysicsObj::set_omega(CPhysicsObj*,const AC1Legacy::Vector3*,int)</code>
    /// </summary>
    /// <param name="new_omega">Pointer to the vector containing the desired angular velocity.</param>
    /// <param name="send_event">Flag indicating whether an event should be emitted after updating; currently unused.</param>
    public void set_omega(ACBindings.Internal.AC1Legacy.Vector3* new_omega, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.AC1Legacy.Vector3*, int, void>)0x005101A0)(ref this, new_omega, send_event);

    /// <summary>Sets or updates an animation on the physics object’s internal sequence, optionally clearing existing animations first.
    /// <code>Offset: 0x005101C0
    /// void __thiscall CPhysicsObj::set_sequence_animation(_DWORD*,unsigned int,int,int,float)</code>
    /// </summary>
    /// <param name="a2">The identifier of the animation to apply.</param>
    /// <param name="a3">When non‑zero, clears any current animations before adding the new one; otherwise, appends it to the existing sequence.</param>
    /// <param name="a4">The low frame index for the animation sequence.</param>
    /// <param name="a5">The playback framerate for the animation.</param>
    public void set_sequence_animation(uint a2, int a3, int a4, float a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int, int, float, void>)0x005101C0)(ref this, a2, a3, a4, a5);

    /// <summary>Clears any active sequence animations associated with this object's part array, if present.
    /// <code>Offset: 0x00510230
    /// void __thiscall CPhysicsObj::clear_sequence_anims(CPhysicsObj*)</code>
    /// </summary>
    public void clear_sequence_anims() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00510230)(ref this);

    /// <summary>Determines whether this physics object possesses any animation sequences by inspecting its part array.
    /// <code>Offset: 0x00510240
    /// int __thiscall CPhysicsObj::HasAnims(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>Non‑zero if an animation exists; zero if none or no part array is present.</returns>
    public int HasAnims() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00510240)(ref this);

    /// <summary>Retrieves the current frame number from the object's part array sequence, returning 0 when no part array exists.
    /// <code>Offset: 0x00510250
    /// unsigned int __thiscall CPhysicsObj::get_curr_frame_number(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>The current frame number as an unsigned integer.</returns>
    public uint get_curr_frame_number() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint>)0x00510250)(ref this);

    /// <summary>Calculates the spatial separation between this physics object and another, using simple positional distance or cylinder-based collision geometry based on the <paramref name="use_cyls"/> flag.
    /// <code>Offset: 0x00510270
    /// float __thiscall CPhysicsObj::get_distance_to_object(CPhysicsObj*,CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="object">The target physics object to measure against.</param>
    /// <param name="use_cyls">If zero, returns Euclidean distance; otherwise uses each object's height and radius from its part array for a more accurate cylinder-to-cylinder distance.</param>
    /// <returns>A floating‑point value representing the computed distance in world units.</returns>
    public float get_distance_to_object(ACBindings.Internal.CPhysicsObj* object_, int use_cyls) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, int, float>)0x00510270)(ref this, object_, use_cyls);

    /// <summary>Adds the specified physics object as a child of this object at the given holding location index if valid.
    /// <code>Offset: 0x00510340
    /// int __thiscall CPhysicsObj::add_child(CPhysicsObj*,CPhysicsObj*,unsigned int)</code>
    /// </summary>
    /// <param name="obj">The child object to attach.</param>
    /// <param name="where">Index of the desired holding location within this object's part array.</param>
    /// <returns>1 when the child is successfully attached; 0 if the operation fails due to invalid parameters (e.g., same object, missing part array, or invalid index).</returns>
    public int add_child(ACBindings.Internal.CPhysicsObj* obj, uint where) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, uint, int>)0x00510340)(ref this, obj, where);

    /// <summary>Adds another physics object as a child of this object, optionally attaching it to a specific component and applying an initial transform.
    /// <code>Offset: 0x005103C0
    /// int __thiscall CPhysicsObj::add_child(CPhysicsObj*,CPhysicsObj*,unsigned int,const Frame*)</code>
    /// </summary>
    /// <param name="obj">The physics object to attach as a child.</param>
    /// <param name="part_index">Index of the part on which to attach; -1 indicates no attachment.</param>
    /// <param name="frame">Transform applied to the child relative to this object when attached.</param>
    /// <returns>Non‑zero if the child was successfully added, zero otherwise (e.g., attempting to add the same object or an invalid part index).</returns>
    public int add_child(ACBindings.Internal.CPhysicsObj* obj, uint part_index, ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, uint, ACBindings.Internal.Frame*, int>)0x005103C0)(ref this, obj, part_index, frame);

    /// <summary>Adjusts this physics object's translucency, clamping it to its original minimum value before assigning. If a part array exists, forwards the update to each part.
    /// <code>Offset: 0x00510430
    /// void __thiscall CPhysicsObj::SetTranslucencyInternal(CPhysicsObj*,float)</code>
    /// </summary>
    /// <param name="translucency">Desired translucency level; values lower than the object's original will be ignored and set to that baseline instead.</param>
    public void SetTranslucencyInternal(float translucency) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, void>)0x00510430)(ref this, translucency);

    /// <summary>Sets the visibility of the object's parts based on the noDraw flag.
    /// <code>Offset: 0x00510470
    /// void __thiscall CPhysicsObj::SetNoDraw(CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="no_draw">Non‑zero to hide all parts, zero to show them.</param>
    public void SetNoDraw(int no_draw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, void>)0x00510470)(ref this, no_draw);

    /// <summary>Applies modifications from an object descriptor to the physics object's components and adjusts translucency accordingly.
    /// <code>Offset: 0x00510480
    /// int __thiscall CPhysicsObj::DoObjDescChangesFromDefault(CPhysicsObj*,const ObjDesc*)</code>
    /// </summary>
    /// <param name="objdesc">Descriptor containing visual and animation changes to apply.</param>
    /// <returns>An integer indicating the result of applying the changes, typically the number of parts modified or a non‑zero success flag.</returns>
    public int DoObjDescChangesFromDefault(ACBindings.Internal.ObjDesc* objdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.ObjDesc*, int>)0x00510480)(ref this, objdesc);

    /// <summary>Applies visual changes from an ObjDesc to the physics object's parts and ensures the object's translucency does not fall below its original value.
    /// <code>Offset: 0x00510500
    /// int __thiscall CPhysicsObj::DoObjDescChanges(CPhysicsObj*,const ObjDesc*)</code>
    /// </summary>
    /// <param name="objdesc">Descriptor containing palette, texture map, and animation part updates for the object.</param>
    /// <returns>The number of part changes applied by the underlying CPartArray, or zero if no part array exists.</returns>
    public int DoObjDescChanges(ACBindings.Internal.ObjDesc* objdesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.ObjDesc*, int>)0x00510500)(ref this, objdesc);

    /// <summary>Morphs this physics object's components to match those of an existing object, synchronizing translucency and examination state.
    /// <code>Offset: 0x00510580
    /// int __thiscall CPhysicsObj::MorphToExistingObject(CPhysicsObj*,const CPhysicsObj*)</code>
    /// </summary>
    /// <param name="pObj">The target physics object whose properties are copied into this instance.</param>
    /// <returns>Number of part array elements successfully morphed; zero if either part array is missing.</returns>
    public int MorphToExistingObject(ACBindings.Internal.CPhysicsObj* pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, int>)0x00510580)(ref this, pObj);

    /// <summary>Animates or immediately sets the object's translucency between a start and end value, using a timing hook when the change is significant.
    /// <code>Offset: 0x00510620
    /// void __thiscall CPhysicsObj::SetTranslucency2(CPhysicsObj*,float,float,long double)</code>
    /// </summary>
    /// <param name="start_translucency">Initial translucency for an animation; ignored if the change is applied instantly.</param>
    /// <param name="end_translucency">Target translucency. If smaller than the object's original translucency, it will be clamped to that original value when applied instantly.</param>
    /// <param name="delta">Elapsed time in seconds; large enough values trigger an animation hook, otherwise the change is applied immediately.</param>
    public void SetTranslucency2(float start_translucency, float end_translucency, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, float, double, void>)0x00510620)(ref this, start_translucency, end_translucency, delta);

    /// <summary>Applies horizontal and vertical texture scroll velocities to every graphical component of the object, updating UV offsets for all attached parts.
    /// <code>Offset: 0x005106F0
    /// void __thiscall CPhysicsObj::SetTextureVelocity(CPhysicsObj*,float,float)</code>
    /// </summary>
    /// <param name="du">Horizontal texture velocity applied to each part's graphics object.</param>
    /// <param name="dv">Vertical texture velocity applied to each part's graphics object.</param>
    public void SetTextureVelocity(float du, float dv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, float, void>)0x005106F0)(ref this, du, dv);

    /// <summary>
    /// Sets the texture velocity (du, dv) for a specified part of the physics object.
    /// If the part exists and has an associated graphics object, the velocity is applied to that object's graphical representation.
    /// 
    /// <code>Offset: 0x00510700
    /// void __thiscall CPhysicsObj::SetPartTextureVelocity(CPhysicsObj*,unsigned int,float,float)</code>
    /// </summary>
    /// <param name="part_index">Index of the part within the object's part array.</param>
    /// <param name="du">Horizontal component of the texture speed.</param>
    /// <param name="dv">Vertical component of the texture speed.</param>
    public void SetPartTextureVelocity(uint part_index, float du, float dv) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, float, float, void>)0x00510700)(ref this, part_index, du, dv);

    /// <summary>Sets the object's transient active flag, updating its last‑update timestamp when activating.
    /// <code>Offset: 0x00510710
    /// int __thiscall CPhysicsObj::set_active(CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="active">Non‑zero activates the object; zero deactivates it.</param>
    /// <returns>Returns 1 if the state change succeeded or was already valid; returns 0 if activation is requested but the object is already in an active mode indicated by its internal state flag.</returns>
    public int set_active(int active) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int>)0x00510710)(ref this, active);

    /// <summary>Sets the object's visibility flag and updates its parts accordingly.
    /// <code>Offset: 0x00510770
    /// int __thiscall CPhysicsObj::set_nodraw(CPhysicsObj*,int,int)</code>
    /// </summary>
    /// <param name="nodraw">If non‑zero, enables no‑draw mode; otherwise disables it.</param>
    /// <param name="send_event">Ignored by this implementation; reserved for future use or event notifications.</param>
    /// <returns>Always returns 1 indicating success.</returns>
    public int set_nodraw(int nodraw, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int, int>)0x00510770)(ref this, nodraw, send_event);

    /// <summary>Sets or clears the lighting flag for this physics object and initializes or destroys lights on its part array accordingly.
    /// <code>Offset: 0x005107C0
    /// void __thiscall CPhysicsObj::set_lights(CPhysicsObj*,int,int)</code>
    /// </summary>
    /// <param name="lights_on">Non‑zero to enable lights; zero to disable them.</param>
    /// <param name="send_event">Ignored by this method.</param>
    public void set_lights(int lights_on, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int, void>)0x005107C0)(ref this, lights_on, send_event);

    /// <summary>Sets the object's elasticity, clamping the value between zero and a maximum of 0.1.
    /// <code>Offset: 0x00510810
    /// int __thiscall CPhysicsObj::set_elasticity(CPhysicsObj*,float)</code>
    /// </summary>
    /// <param name="elasticity">The desired elasticity coefficient; values below zero are treated as zero, values above 0.1 are capped at 0.1.</param>
    /// <returns>An integer status code (always 1) indicating that the operation succeeded.</returns>
    public int set_elasticity(float elasticity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, int>)0x00510810)(ref this, elasticity);

    /// <summary>Notifies this physics object’s part array that its current animation sequence has finished, allowing the system to update state accordingly.
    /// <code>Offset: 0x00510870
    /// void __thiscall CPhysicsObj::Hook_AnimDone(CPhysicsObj*)</code>
    /// </summary>
    public void Hook_AnimDone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00510870)(ref this);

    /// <summary>Signals completion of a movement motion to the associated MovementManager, indicating success or failure.
    /// <code>Offset: 0x00510880
    /// void __thiscall CPhysicsObj::MotionDone(CPhysicsObj*,unsigned int,int)</code>
    /// </summary>
    /// <param name="motion">Identifier of the completed motion (unused in this implementation).</param>
    /// <param name="success">Non‑zero if the motion finished successfully; zero otherwise.</param>
    public void MotionDone(uint motion, int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int, void>)0x00510880)(ref this, motion, success);

    /// <summary>Retrieves the current raw motion state for the object, creating a motion interpreter on demand if one does not already exist.
    /// <code>Offset: 0x005108B0
    /// const RawMotionState* __thiscall CPhysicsObj::InqRawMotionState(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>A pointer to the object's RawMotionState, or null when no movement manager is present.</returns>
    public ACBindings.Internal.RawMotionState* InqRawMotionState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.RawMotionState*>)0x005108B0)(ref this);

    /// <summary>Provides access to the object's interpreted motion state, creating a motion interpreter if necessary.
    /// <code>Offset: 0x005108D0
    /// const InterpretedMotionState* __thiscall CPhysicsObj::InqInterpretedMotionState(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>A pointer to InterpretedMotionState, or nullptr when no movement manager is present.</returns>
    public ACBindings.Internal.InterpretedMotionState* InqInterpretedMotionState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.InterpretedMotionState*>)0x005108D0)(ref this);

    /// <summary>Ensures the object's part array processes enter‑world logic if present.
    /// <code>Offset: 0x005108F0
    /// void __thiscall CPhysicsObj::RemoveLinkAnimations(CPhysicsObj*)</code>
    /// </summary>
    public void RemoveLinkAnimations() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x005108F0)(ref this);

    /// <summary>Checks the object's parts for completed motions via its motion table manager, if available.
    /// <code>Offset: 0x00510900
    /// void __thiscall CPhysicsObj::CheckForCompletedMotions(CPhysicsObj*)</code>
    /// </summary>
    public void CheckForCompletedMotions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00510900)(ref this);

    /// <summary>Retrieves the aggregate axis-aligned bounding box of this physics object's components.
    /// <code>Offset: 0x00510910
    /// bool __thiscall CPhysicsObj::GetBoundingBox(CPhysicsObj*,BBox*)</code>
    /// </summary>
    /// <param name="o_bbox">Output parameter receiving the minimum and maximum coordinates of the combined parts.</param>
    /// <returns>True if the object contains a part array and the bounding box was successfully populated; otherwise false.</returns>
    public byte GetBoundingBox(ACBindings.Internal.BBox* o_bbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.BBox*, byte>)0x00510910)(ref this, o_bbox);

    /// <summary>Decides whether particle effects should be rendered for this physics object based on its examination status, distance from the camera and cell validity.
    /// <code>Offset: 0x00510930
    /// bool __thiscall CPhysicsObj::ShouldDrawParticles(CPhysicsObj*,float)</code>
    /// </summary>
    /// <param name="i_fDegradeDistance">Maximum distance at which particles remain visible; objects beyond this threshold disable their particles.</param>
    /// <returns>True if particles should be drawn; false otherwise.</returns>
    public byte ShouldDrawParticles(float i_fDegradeDistance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, byte>)0x00510930)(ref this, i_fDegradeDistance);

    /// <summary>Initializes the physics object with a unique identifier and configures its dynamic state. Updates internal flags, clears transient bits, and records the current time.
    /// <code>Offset: 0x00510A50
    /// int __thiscall CPhysicsObj::InitObjectBegin(CPhysicsObj*,unsigned int,int)</code>
    /// </summary>
    /// <param name="object_iid">The unique ID assigned to the object.</param>
    /// <param name="bDynamic">True if the object should be treated as dynamic; false for static.</param>
    /// <returns>1 indicating successful initialization.</returns>
    public int InitObjectBegin(uint object_iid, int bDynamic) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int, int>)0x00510A50)(ref this, object_iid, bDynamic);

    /// <summary>
    /// Finalizes a physics object's initialization by setting its part array’s placement frame to 0x65 and, unless the state flag 0x1000 is set, synchronizing the part array’s current frame with the object’s position frame.
    /// 
    /// <code>Offset: 0x00510AB0
    /// int __thiscall CPhysicsObj::InitObjectEnd(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>Always returns 1 to indicate successful completion.</returns>
    public int InitObjectEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00510AB0)(ref this);

    /// <summary>Executes a raw motion command on the physics object by delegating to its MovementManager and marking the move as autonomous.
    /// <code>Offset: 0x00510AF0
    /// unsigned int __thiscall CPhysicsObj::DoMotion(CPhysicsObj*,unsigned int,const MovementParameters*,int)</code>
    /// </summary>
    /// <param name="motion">Identifier of the motion to perform.</param>
    /// <param name="params">Movement parameters such as distance, speed, heading, and context information.</param>
    /// <param name="send_event">Flag indicating whether an event should be sent; not used in this implementation.</param>
    /// <returns>Result code from MovementManager::PerformMovement; returns 7 if the object lacks a MovementManager.</returns>
    public uint DoMotion(uint motion, ACBindings.Internal.MovementParameters* params_, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, ACBindings.Internal.MovementParameters*, int, uint>)0x00510AF0)(ref this, motion, params_, send_event);

    /// <summary>Halts the physics object's current motion by issuing a stop command through its MovementManager and marks the move as autonomous.
    /// <code>Offset: 0x00510BA0
    /// unsigned int __thiscall CPhysicsObj::StopMotion(CPhysicsObj*,unsigned int,const MovementParameters*,int)</code>
    /// </summary>
    /// <param name="motion">Identifier of the motion to be stopped.</param>
    /// <param name="params">Optional movement parameters influencing how the stop is performed.</param>
    /// <param name="send_event">Flag indicating whether an event should be dispatched (unused in this implementation).</param>
    /// <returns>Zero or a status code returned by MovementManager::PerformMovement; returns 7 if no MovementManager is present.</returns>
    public uint StopMotion(uint motion, ACBindings.Internal.MovementParameters* params_, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, ACBindings.Internal.MovementParameters*, int, uint>)0x00510BA0)(ref this, motion, params_, send_event);

    /// <summary>Stops the physics object's movement immediately by instructing its movement manager to perform a stop‑complete action.
    /// <code>Offset: 0x00510C50
    /// void __thiscall CPhysicsObj::StopCompletely(CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="send_event">Flag indicating whether to broadcast the stop event (currently unused).</param>
    public void StopCompletely(int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, void>)0x00510C50)(ref this, send_event);

    /// <summary>Cancels any pending move‑to operation for this physics object by delegating to its MovementManager with the cancel flag 0x36.
    /// <code>Offset: 0x00510CC0
    /// void __thiscall CPhysicsObj::cancel_moveto(CPhysicsObj*)</code>
    /// </summary>
    public void cancel_moveto() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00510CC0)(ref this);

    /// <summary>
    /// Creates or reuses a PositionManager for the physics object and updates its internal timing state when appropriate.
    /// 
    /// <code>Offset: 0x00510CE0
    /// void __thiscall CPhysicsObj::MakePositionManager(CPhysicsObj*)</code>
    /// </summary>
    public void MakePositionManager() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00510CE0)(ref this);

    /// <summary>Creates a movement manager for the physics object if one does not already exist, optionally enters its default motion state and records the current update time when first entering the non‑state‑1 condition.
    /// <code>Offset: 0x00510D40
    /// void __thiscall CPhysicsObj::MakeMovementManager(CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="init_motion">If non‑zero, causes the new movement manager to enter its default state immediately after creation.</param>
    public void MakeMovementManager(int init_motion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, void>)0x00510D40)(ref this, init_motion);

    /// <summary>Moves the physics object toward a target object using supplied movement parameters and initializes its movement manager if absent.
    /// <code>Offset: 0x00510DB0
    /// void __thiscall CPhysicsObj::MoveToObject_Internal(CPhysicsObj*,unsigned int,unsigned int,float,float,const MovementParameters*)</code>
    /// </summary>
    /// <param name="object_id">Identifier of the target object to approach.</param>
    /// <param name="top_level_id">Top‑level identifier for hierarchical movement contexts.</param>
    /// <param name="object_radius">Radius of the target object, used in collision or proximity checks.</param>
    /// <param name="object_height">Height of the target object, influencing vertical positioning during movement.</param>
    /// <param name="params">Pointer to a MovementParameters structure specifying desired distance, heading, speed and other constraints for the move.</param>
    public void MoveToObject_Internal(uint object_id, uint top_level_id, float object_radius, float object_height, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, uint, float, float, ACBindings.Internal.MovementParameters*, void>)0x00510DB0)(ref this, object_id, top_level_id, object_radius, object_height, params_);

    /// <summary>Configures the physics object's movement manager to rotate toward a specified target object using supplied movement parameters.
    /// <code>Offset: 0x00510EC0
    /// void __thiscall CPhysicsObj::TurnToObject_Internal(CPhysicsObj*,unsigned int,unsigned int,const MovementParameters*)</code>
    /// </summary>
    /// <param name="object_id">Identifier of the target object to face.</param>
    /// <param name="top_level_id">Identifier of the top‑level context for the turn operation.</param>
    /// <param name="params">MovementParameters defining desired heading, speed, and other constraints for the rotation.</param>
    public void TurnToObject_Internal(uint object_id, uint top_level_id, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, uint, ACBindings.Internal.MovementParameters*, void>)0x00510EC0)(ref this, object_id, top_level_id, params_);

    /// <summary>Interpolate the object's position manager toward a target position, optionally preserving its current heading.
    /// <code>Offset: 0x00510FC0
    /// void __thiscall CPhysicsObj::InterpolateTo(CPhysicsObj*,const Position*,int)</code>
    /// </summary>
    /// <param name="p">Target position to interpolate towards.</param>
    /// <param name="keep_heading">Flag indicating whether to maintain the object's orientation during interpolation.</param>
    public void InterpolateTo(ACBindings.Internal.Position* p, int keep_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, int, void>)0x00510FC0)(ref this, p, keep_heading);

    /// <summary>Constrains the physics object to remain within a specified distance range of a target position by delegating to its PositionManager and ConstraintManager.
    /// <code>Offset: 0x00510FF0
    /// void __thiscall CPhysicsObj::ConstrainTo(CPhysicsObj*,const Position*,float,float)</code>
    /// </summary>
    /// <param name="p">Target position for the constraint.</param>
    /// <param name="start_distance">Initial distance threshold at which the constraint starts affecting movement.</param>
    /// <param name="max_distance">Maximum allowed distance from the target before the constraint stops applying.</param>
    public void ConstrainTo(ACBindings.Internal.Position* p, float start_distance, float max_distance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, float, float, void>)0x00510FF0)(ref this, p, start_distance, max_distance);

    /// <summary>Reports the results of a physics-based attack to the object's associated WeenieObject and its AttackManager, forwarding hit information for each affected target.
    /// <code>Offset: 0x00511010
    /// void __thiscall CPhysicsObj::report_attacks(CPhysicsObj*,AttackInfo*)</code>
    /// </summary>
    /// <param name="attack_info">Information about the attack, including the list of objects that were hit and related details.</param>
    public void report_attacks(ACBindings.Internal.AttackInfo* attack_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.AttackInfo*, void>)0x00511010)(ref this, attack_info);

    /// <summary>Forwards a detection update to the object's DetectionManager and records that the object has been processed this frame.
    /// <code>Offset: 0x005110A0
    /// void __thiscall CPhysicsObj::receive_detection_update(CPhysicsObj*,const DetectionInfo*)</code>
    /// </summary>
    /// <param name="info">Detection information describing the event.</param>
    public void receive_detection_update(ACBindings.Internal.DetectionInfo* info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.DetectionInfo*, void>)0x005110A0)(ref this, info);

    /// <summary>Updates the object's physics state over a time step of length <c>quantum</c>, applying velocity, acceleration, friction and speed clamping, then writes the resulting displacement and rotation into <c>offset_frame</c>. The update also integrates angular motion via the omega vector.
    /// <code>Offset: 0x005111D0
    /// void __thiscall CPhysicsObj::UpdatePhysicsInternal(CPhysicsObj*,float,Frame*)</code>
    /// </summary>
    /// <param name="quantum">Elapsed time (in seconds) for this physics update step.</param>
    /// <param name="offset_frame">Frame structure that receives the computed positional offset and rotational change applied during this update.</param>
    public void UpdatePhysicsInternal(float quantum, ACBindings.Internal.Frame* offset_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, ACBindings.Internal.Frame*, void>)0x005111D0)(ref this, quantum, offset_frame);

    /// <summary>Computes the physics object's acceleration vector based on its transient and state flags. If both transient bits 0x1 and 0x2 are set while the object is not activated, sets the acceleration to zero and clears the angular velocity. Otherwise, when gravity is enabled (state bit 0x400), applies a downward acceleration equal to the global gravity constant; if gravity is disabled, leaves the acceleration at zero.
    /// <code>Offset: 0x00511420
    /// void __thiscall CPhysicsObj::calc_acceleration(CPhysicsObj*)</code>
    /// </summary>
    public void calc_acceleration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00511420)(ref this);

    /// <summary>Detects whether any of the object's shadow objects collide with its environment by checking each shadow object's associated cell.
    /// <code>Offset: 0x00511510
    /// int __thiscall CPhysicsObj::ethereal_check_for_collisions(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>An integer that is non‑zero when a collision occurs, otherwise zero.</returns>
    public int ethereal_check_for_collisions() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00511510)(ref this);

    /// <summary>Ends a collision between this physics object and another specified by <paramref name="object_id"/>, invoking any related script callbacks as needed.
    /// <code>Offset: 0x00511560
    /// int __thiscall CPhysicsObj::report_object_collision_end(CPhysicsObj*,const unsigned int)</code>
    /// </summary>
    /// <param name="object_id">The identifier of the other physics object whose collision end is being reported.</param>
    /// <returns>1 if the other object was found in the global maintenance list; 0 otherwise. The return value indicates whether a counterpart physics object was located, regardless of whether any script callbacks were executed.</returns>
    public int report_object_collision_end(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int>)0x00511560)(ref this, object_id);

    /// <summary>Computes the object's distance from the viewer and updates its part array accordingly, using a different threshold when the object is flagged as a particle.
    /// <code>Offset: 0x00511600
    /// void __thiscall CPhysicsObj::UpdateViewerDistance(CPhysicsObj*)</code>
    /// </summary>
    public void UpdateViewerDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00511600)(ref this);

    /// <summary>Computes and updates the viewer distance for this physics object, then recursively applies the same update to every descendant in its hierarchy.
    /// <code>Offset: 0x00511720
    /// void __thiscall CPhysicsObj::UpdateViewerDistanceRecursive(CPhysicsObj*)</code>
    /// </summary>
    public void UpdateViewerDistanceRecursive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00511720)(ref this);

    /// <summary>Renders the object’s parts and then recursively draws all child physics objects.
    /// <code>Offset: 0x00511760
    /// void __thiscall CPhysicsObj::DrawRecursive(CPhysicsObj*)</code>
    /// </summary>
    public void DrawRecursive() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00511760)(ref this);

    /// <summary>Adds a script identified by the given ID to the object's ScriptManager, creating one if necessary.
    /// <code>Offset: 0x005117A0
    /// int __thiscall CPhysicsObj::play_script_internal(CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="physobj">The physics object to which the script will be attached.</param>
    /// <param name="a2">Identifier of the script to play.</param>
    /// <returns>Non‑zero value returned by ScriptManager::AddScript on success; otherwise zero when no script manager could be created or a2 is zero.</returns>
    public int play_script_internal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int>)0x005117A0)(ref this, a2);

    /// <summary>Starts a physics script on the object when it is located in a cell, delegating to the internal implementation.
    /// <code>Offset: 0x00511800
    /// int __thiscall CPhysicsObj::play_script(CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="physobj">The physics object to run the script on.</param>
    /// <param name="a2">Identifier of the script to execute.</param>
    /// <returns>Result code from play_script_internal if the object has an active cell; otherwise 1.</returns>
    public int play_script(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int>)0x00511800)(ref this, a2);

    /// <summary>Destroys the ParticleManager associated with this physics object, releasing its resources and setting the pointer to null.
    /// <code>Offset: 0x00511820
    /// void __thiscall CPhysicsObj::destroy_particle_manager(CPhysicsObj*)</code>
    /// </summary>
    public void destroy_particle_manager() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00511820)(ref this);

    /// <summary>Retrieves the landscape coordinates for the object's current cell, storing them via the supplied integer pointers.
    /// <code>Offset: 0x00511850
    /// int __thiscall CPhysicsObj::get_landscape_coord(CPhysicsObj*,int*,int*)</code>
    /// </summary>
    /// <param name="x">Pointer to an int where the X coordinate will be written.</param>
    /// <param name="y">Pointer to an int where the Y coordinate will be written.</param>
    /// <returns>An integer status code from LandDefs::gid_to_lcoord indicating success or failure of the conversion.</returns>
    public int get_landscape_coord(int* x, int* y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int*, int*, int>)0x00511850)(ref this, x, y);

    /// <summary>
    /// Assigns a new cell identifier to this physics object and propagates the change through its child hierarchy. Updates the object's position data and, unless a specific transient state flag is set, updates the associated part array. Recursively applies the same update to all descendant objects.
    /// 
    /// <code>Offset: 0x00511870
    /// void __thiscall CPhysicsObj::set_cell_id_recursive(CPhysicsObj*,unsigned int)</code>
    /// </summary>
    /// <param name="new_cell_id">The cell ID to assign to the object and all of its descendants.</param>
    public void set_cell_id_recursive(uint new_cell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, void>)0x00511870)(ref this, new_cell_id);

    /// <summary>Adds a physics part to each shadow object cell associated with this physics object, updating the part’s cell identifier accordingly.
    /// <code>Offset: 0x005118D0
    /// void __thiscall CPhysicsObj::AddPartToShadowCells(CPhysicsObj*,CPhysicsPart*)</code>
    /// </summary>
    /// <param name="part">The physics part to add to the shadow cells.</param>
    public void AddPartToShadowCells(ACBindings.Internal.CPhysicsPart* part) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsPart*, void>)0x005118D0)(ref this, part);

    /// <summary>Removes a physics part from all shadow cells belonging to this object, updating the part’s cell identifier if the primary cell exists.
    /// <code>Offset: 0x00511940
    /// void __thiscall CPhysicsObj::RemovePartFromShadowCells(CPhysicsObj*,CPhysicsPart*)</code>
    /// </summary>
    /// <param name="part">The physics part to detach from shadow cells.</param>
    public void RemovePartFromShadowCells(ACBindings.Internal.CPhysicsPart* part) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsPart*, void>)0x00511940)(ref this, part);

    /// <summary>Adds the physics object to a spatial cell, updating its position and any associated parts or lights; recursively applies the same to all child objects.
    /// <code>Offset: 0x005119A0
    /// void __thiscall CPhysicsObj::enter_cell(CPhysicsObj*,CObjCell*)</code>
    /// </summary>
    /// <param name="new_cell">The target cell into which the physics object and its children should be placed.</param>
    public void enter_cell(ACBindings.Internal.CObjCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CObjCell*, void>)0x005119A0)(ref this, new_cell);

    /// <summary>
    /// Removes this physics object from its current cell and propagates removal to all child objects.
    /// If the object has associated part lights, those lights are also removed from the cell.
    /// After cleanup, the object's cell reference is cleared.
    /// 
    /// <code>Offset: 0x00511A20
    /// void __thiscall CPhysicsObj::leave_cell(CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="is_changing_cell">True if the object will immediately enter another cell; otherwise false.</param>
    public void leave_cell(int is_changing_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, void>)0x00511A20)(ref this, is_changing_cell);

    /// <summary>Populates the supplied CELLARRAY with all cells intersecting or adjacent to this object’s bounding box, starting from the object’s current cell and expanding via part‑array intersection calculations.
    /// <code>Offset: 0x00511A90
    /// void __thiscall CPhysicsObj::find_bbox_cell_list(CPhysicsObj*,CELLARRAY*)</code>
    /// </summary>
    /// <param name="cell_array">The array to receive the list of relevant cells; its contents are overwritten each call.</param>
    public void find_bbox_cell_list(ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CELLARRAY*, void>)0x00511A90)(ref this, cell_array);

    /// <summary>Determines whether the physics object lies within the current land block, taking into account its shape and transform.
    /// <code>Offset: 0x00511B00
    /// int __thiscall CPhysicsObj::obj_within_block(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>Non-zero if the object is inside the block; zero otherwise.</returns>
    public int obj_within_block() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00511B00)(ref this);

    /// <summary>Removes all shadow objects linked to this physics object from their respective cells and clears the object's shadow list. Recursively applies the same removal to any child physics objects.
    /// <code>Offset: 0x00511D00
    /// void __thiscall CPhysicsObj::remove_shadows_from_cells(CPhysicsObj*)</code>
    /// </summary>
    public void remove_shadows_from_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00511D00)(ref this);

    /// <summary>Checks whether the physics object is fully visible by ensuring it has an associated cell and all its shadow objects reference cells, requiring at least one shadow object.
    /// <code>Offset: 0x00511D90
    /// int __thiscall CPhysicsObj::is_completely_visible(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>Non‑zero if both conditions are met; otherwise zero.</returns>
    public int is_completely_visible() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00511D90)(ref this);

    /// <summary>Updates the object's walkability flag, notifying its movement manager when entering or leaving a grounded state and recalculates acceleration.
    /// <code>Offset: 0x00511DE0
    /// void __thiscall CPhysicsObj::set_on_walkable(CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="is_on_walkable">Non‑zero to enable walking on ground; zero disables walkability.</param>
    public void set_on_walkable(int is_on_walkable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, void>)0x00511DE0)(ref this, is_on_walkable);

    /// <summary>Assigns the specified placement frame to the physics object, updating its part array and internal position as needed.
    /// <code>Offset: 0x00511E50
    /// int __thiscall CPhysicsObj::SetPlacementFrame(CPhysicsObj*,unsigned int,int)</code>
    /// </summary>
    /// <param name="frame_id">Identifier for the new placement frame.</param>
    /// <param name="send_event">Flag indicating whether an event should be sent when the frame changes (currently unused).</param>
    /// <returns>Zero if no parts are present or the operation fails; otherwise, a non‑zero value returned by the part array's SetPlacementFrame method.</returns>
    public int SetPlacementFrame(uint frame_id, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int, int>)0x00511E50)(ref this, frame_id, send_event);

    /// <summary>Retrieves the object's cached velocity vector.
    /// <code>Offset: 0x00511E90
    /// AC1Legacy::Vector3* __thiscall CPhysicsObj::get_velocity(CPhysicsObj*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="result">Pointer to a Vector3 that receives the current velocity.</param>
    /// <returns>The same pointer supplied in result, now populated with the velocity.</returns>
    public ACBindings.Internal.AC1Legacy.Vector3* get_velocity(ACBindings.Internal.AC1Legacy.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*>)0x00511E90)(ref this, result);

    /// <summary>Updates a physics object's velocity vector; if changed, normalizes and scales it, then marks the object as having moved and refreshes its update state.
    /// <code>Offset: 0x00511EC0
    /// void __thiscall CPhysicsObj::set_velocity(CPhysicsObj*,const AC1Legacy::Vector3*,int)</code>
    /// </summary>
    /// <param name="new_velocity">The new velocity to assign to the object.</param>
    /// <param name="send_event">Indicates whether a change event should be triggered (not used in this implementation).</param>
    public void set_velocity(ACBindings.Internal.AC1Legacy.Vector3* new_velocity, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.AC1Legacy.Vector3*, int, void>)0x00511EC0)(ref this, new_velocity, send_event);

    /// <summary>Sets the object's velocity by transforming a local‑space vector into world coordinates and applying it.
    /// <code>Offset: 0x00511FA0
    /// void __thiscall CPhysicsObj::set_local_velocity(CPhysicsObj*,const AC1Legacy::Vector3*,int)</code>
    /// </summary>
    /// <param name="new_velocity">Velocity expressed in the object's local coordinate space.</param>
    /// <param name="send_event">If non‑zero, triggers an event to notify the physics system of the change.</param>
    public void set_local_velocity(ACBindings.Internal.AC1Legacy.Vector3* new_velocity, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.AC1Legacy.Vector3*, int, void>)0x00511FA0)(ref this, new_velocity, send_event);

    /// <summary>Retrieves the current heading angle of the object from its position frame.
    /// <code>Offset: 0x00512010
    /// float __thiscall CPhysicsObj::get_heading(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>The heading angle, expressed in radians.</returns>
    public float get_heading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float>)0x00512010)(ref this);

    /// <summary>Processes active physics and animation hooks, executing each hook and removing those that indicate completion. Completed PhysicsObjHook instances are detached from the linked list, deallocated, and the array of animation hooks is cleared after execution.
    /// <code>Offset: 0x00512020
    /// void __thiscall CPhysicsObj::process_hooks(CPhysicsObj*)</code>
    /// </summary>
    public void process_hooks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00512020)(ref this);

    /// <summary>Adjusts the object's translucency, optionally applying the change over a specified duration if the duration exceeds 0.0002 seconds; otherwise sets the value immediately while ensuring it does not fall below the original translucency.
    /// <code>Offset: 0x005120C0
    /// void __thiscall CPhysicsObj::SetTranslucency(CPhysicsObj*,float,long double)</code>
    /// </summary>
    /// <param name="translucency">Target translucency level to apply to the object.</param>
    /// <param name="delta">Duration of the transition in seconds; transitions shorter than 0.0002 seconds are applied instantly.</param>
    public void SetTranslucency(float translucency, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, double, void>)0x005120C0)(ref this, translucency, delta);

    /// <summary>Applies a new translucency level to this physics object and all its descendants, clamping each child’s value to its own original setting. Updates the part array accordingly.
    /// <code>Offset: 0x00512190
    /// void __thiscall CPhysicsObj::SetTranslucencyHierarchical(CPhysicsObj*,float)</code>
    /// </summary>
    /// <param name="translucency">Desired translucency value; if lower than an object’s stored original, that object retains its original translucency.</param>
    public void SetTranslucencyHierarchical(float translucency) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, void>)0x00512190)(ref this, translucency);

    /// <summary>Transitions a physics object's specified part from one translucency level to another over a given time period, automatically creating an update hook if the transition exceeds 0.0002 seconds; otherwise applies the change instantly.
    /// <code>Offset: 0x00512200
    /// void __thiscall CPhysicsObj::SetPartTranslucency(CPhysicsObj*,unsigned int,float,float,long double)</code>
    /// </summary>
    /// <param name="part_index">Index of the part whose translucency should be altered.</param>
    /// <param name="start_trans">Initial translucency value for the transition.</param>
    /// <param name="end_trans">Target translucency value to reach at the end of the transition.</param>
    /// <param name="delta">Duration of the transition in seconds; if less than 0.0002, the change is applied immediately.</param>
    public void SetPartTranslucency(uint part_index, float start_trans, float end_trans, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, float, float, double, void>)0x00512200)(ref this, part_index, start_trans, end_trans, delta);

    /// <summary>Adjusts the brightness of a specified physics component over time. If the transition rate exceeds a small threshold, registers a dynamic hook that interpolates between the current and target values; otherwise applies the final value immediately.
    /// <code>Offset: 0x005122B0
    /// void __thiscall CPhysicsObj::SetPartLuminosity(CPhysicsObj*,unsigned int,float,float,long double)</code>
    /// </summary>
    /// <param name="part">Index of the part whose luminosity is to be changed.</param>
    /// <param name="start">Initial brightness level used when creating an interpolation hook.</param>
    /// <param name="end">Target brightness level applied at completion or directly if no hook is needed.</param>
    /// <param name="delta">Time duration over which the change should occur. Values below 0.0002 trigger instant update.</param>
    public void SetPartLuminosity(uint part, float start, float end, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, float, float, double, void>)0x005122B0)(ref this, part, start, end, delta);

    /// <summary>Adjusts the object's luminance, scheduling a gradual change when the duration exceeds a small threshold or applying an immediate value otherwise.
    /// <code>Offset: 0x00512360
    /// void __thiscall CPhysicsObj::SetLuminosity(CPhysicsObj*,float,float,long double)</code>
    /// </summary>
    /// <param name="start">The initial luminosity intensity from which to begin transitioning.</param>
    /// <param name="end">The target luminosity intensity that the object should reach after the transition.</param>
    /// <param name="delta">The time span, in seconds, over which the change should occur; values below 0.0002 trigger an instant update.</param>
    public void SetLuminosity(float start, float end, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, float, double, void>)0x00512360)(ref this, start, end, delta);

    /// <summary>Sets the diffusion for a specific part of the object, optionally scheduling an interpolation when the transition period exceeds a minimal duration.
    /// <code>Offset: 0x00512400
    /// void __thiscall CPhysicsObj::SetPartDiffusion(CPhysicsObj*,unsigned int,float,float,long double)</code>
    /// </summary>
    /// <param name="part">Index of the part within the object's part array whose diffusion will be set.</param>
    /// <param name="start">Initial diffusion value to begin from when an interpolated change is requested.</param>
    /// <param name="end">Target diffusion value to reach after the transition period.</param>
    /// <param name="delta">Duration in seconds over which the diffusion should change; if below a small threshold, the change occurs immediately.</param>
    public void SetPartDiffusion(uint part, float start, float end, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, float, float, double, void>)0x00512400)(ref this, part, start, end, delta);

    /// <summary>Configures the object's diffusion behavior by scheduling a gradual velocity change or applying an instant update based on the supplied time span.
    /// <code>Offset: 0x005124B0
    /// void __thiscall CPhysicsObj::SetDiffusion(CPhysicsObj*,float,float,long double)</code>
    /// </summary>
    /// <param name="start">Initial diffusion coefficient to begin from.</param>
    /// <param name="end">Target diffusion coefficient after transition.</param>
    /// <param name="delta">Duration over which the transition should occur; if below the threshold, the change is applied immediately.</param>
    public void SetDiffusion(float start, float end, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, float, double, void>)0x005124B0)(ref this, start, end, delta);

    /// <summary>Applies the specified luminosity and diffuse values to every physics part of the object.
    /// <code>Offset: 0x00512550
    /// void __thiscall CPhysicsObj::SetLighting(CPhysicsObj*,float,float)</code>
    /// </summary>
    /// <param name="luminosity">The overall brightness level to apply.</param>
    /// <param name="diffuse">The diffuse light intensity for each part.</param>
    public void SetLighting(float luminosity, float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, float, void>)0x00512550)(ref this, luminosity, diffuse);

    /// <summary>Configures luminosity and diffuse parameters for a specific physics part.
    /// <code>Offset: 0x00512560
    /// int __thiscall CPhysicsObj::SetPartLighting(CPhysicsObj*,unsigned int,float,float)</code>
    /// </summary>
    /// <param name="part_index">Index of the target part within the object's part array.</param>
    /// <param name="luminosity">Desired brightness level to apply to the part.</param>
    /// <param name="diffuse">Diffuse color intensity to apply to the part.</param>
    /// <returns>1 when the part array exists, is set up, and the index is valid; 0 otherwise.</returns>
    public int SetPartLighting(uint part_index, float luminosity, float diffuse) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, float, float, int>)0x00512560)(ref this, part_index, luminosity, diffuse);

    /// <summary>Restores lighting on every active physics part of this object by invoking each part’s RestoreLighting method.
    /// <code>Offset: 0x00512580
    /// void __thiscall CPhysicsObj::RestoreLighting(CPhysicsObj*)</code>
    /// </summary>
    public void RestoreLighting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00512580)(ref this);

    /// <summary>Executes an internal physics script when a threshold is met and the object resides within a cell.
    /// <code>Offset: 0x00512590
    /// void __thiscall CPhysicsObj::CallPESInternal(CPhysicsObj*,int,float)</code>
    /// </summary>
    /// <param name="a2">Identifier for the physics script to execute.</param>
    /// <param name="a3">Value compared against 1.0 to decide whether execution should occur.</param>
    public void CallPESInternal(int a2, float a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, float, void>)0x00512590)(ref this, a2, a3);

    /// <summary>Creates an FPHook for this physics object when the supplied time exceeds a minimal threshold; otherwise, executes the object's internal script with the provided user data.
    /// <code>Offset: 0x005125C0
    /// void __thiscall CPhysicsObj::CallPES(CPhysicsObj*,void*,double)</code>
    /// </summary>
    /// <param name="user_data">Pointer to user-defined data passed to the hook or script.</param>
    /// <param name="a3">Time value used to determine whether to generate a random velocity hook or trigger the script.</param>
    public void CallPES(System.IntPtr user_data, double a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, System.IntPtr, double, void>)0x005125C0)(ref this, user_data, a3);

    /// <summary>Sets the object's scaling factor and propagates the change to its parts if present.
    /// <code>Offset: 0x00512680
    /// void __thiscall CPhysicsObj::SetScaleStatic(CPhysicsObj*,float)</code>
    /// </summary>
    /// <param name="new_scale">The desired uniform scale for the object and its components.</param>
    public void SetScaleStatic(float new_scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, void>)0x00512680)(ref this, new_scale);

    /// <summary>Updates the object's ethereal status. When enabling, clears temporary state flags; when disabling, verifies that no parent exists, the object is in a cell, and no collisions would occur before clearing the flag, otherwise restores it and marks a transient state.
    /// <code>Offset: 0x00512710
    /// int __thiscall CPhysicsObj::set_ethereal(CPhysicsObj*,int,int)</code>
    /// </summary>
    /// <param name="ethereal">Nonzero to set the object as ethereal, zero to attempt removal of the ethereal property.</param>
    /// <param name="send_event">If nonzero, an event is dispatched to notify listeners of the change (currently unused in this implementation).</param>
    /// <returns>1 when the ethereal flag was applied or successfully removed; 0 if removal failed due to collision constraints and the flag remains set.</returns>
    public int set_ethereal(int ethereal, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int, int>)0x00512710)(ref this, ethereal, send_event);

    /// <summary>Determines and encodes various physical states of the object into a flag mask, initializing transition data such as contact planes or sliding normals when appropriate.
    /// <code>Offset: 0x00512790
    /// unsigned int __thiscall CPhysicsObj::get_object_info(CPhysicsObj*,CTransition*,int)</code>
    /// </summary>
    /// <param name="transit">Transition structure that receives contact plane or sliding normal data when the object is not in an administrative move.</param>
    /// <param name="admin_move">Flag indicating whether movement is forced by an administrator; if non‑zero, contact checks and related initializations are skipped.</param>
    /// <returns>Bitmask describing the object's physical state (e.g., presence of contact plane, sliding normal, free heading, etc.).</returns>
    public uint get_object_info(ACBindings.Internal.CTransition* transit, int admin_move) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CTransition*, int, uint>)0x00512790)(ref this, transit, admin_move);

    /// <summary>Adjusts a Position’s cell membership and world coordinates when moving across cell boundaries, updating the position object and returning whether a new cell was assigned.
    /// <code>Offset: 0x00512850
    /// int __cdecl CPhysicsObj::AdjustPosition(Position*,const AC1Legacy::Vector3*,CObjCell**,int,int)</code>
    /// </summary>
    /// <param name="p">The Position to adjust.</param>
    /// <param name="low_pt">Reference vector used for local‑to‑global coordinate conversion during adjustment.</param>
    /// <param name="new_cell">Output pointer to the CObjCell that now contains the adjusted position, if any.</param>
    /// <param name="bDontCreateCells">Flag indicating whether new cells should be created when required (unused in current logic).</param>
    /// <param name="bSearchCells">Flag controlling whether visible child cells are searched during adjustment.</param>
    /// <returns>Non‑zero if the position was successfully adjusted and a new cell assigned; zero otherwise.</returns>
    public static int AdjustPosition(ACBindings.Internal.Position* p, ACBindings.Internal.AC1Legacy.Vector3* low_pt, ACBindings.Internal.CObjCell** new_cell, int bDontCreateCells, int bSearchCells) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Position*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CObjCell**, int, int, int>)0x00512850)(p, low_pt, new_cell, bDontCreateCells, bSearchCells);

    /// <summary>Determines whether a physics object can occupy the specified location within a cell, optionally updating the target position when movement is feasible.
    /// <code>Offset: 0x00512960
    /// int __thiscall CPhysicsObj::CheckPositionInternal(CPhysicsObj*,CObjCell*,Position*,CTransition*,const SetPositionStruct*)</code>
    /// </summary>
    /// <param name="new_cell">Target cell for potential placement.</param>
    /// <param name="new_pos">Position to test; may be modified to a valid location if found.</param>
    /// <param name="transit">Transition helper used to evaluate paths and collisions during the check.</param>
    /// <param name="sps">Set of positioning flags and parameters, including whether sliding is allowed.</param>
    /// <returns>1 if a suitable position is available (and new_pos updated when appropriate), otherwise 0.</returns>
    public int CheckPositionInternal(ACBindings.Internal.CObjCell* new_cell, ACBindings.Internal.Position* new_pos, ACBindings.Internal.CTransition* transit, ACBindings.Internal.SetPositionStruct* sps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CObjCell*, ACBindings.Internal.Position*, ACBindings.Internal.CTransition*, ACBindings.Internal.SetPositionStruct*, int>)0x00512960)(ref this, new_cell, new_pos, transit, sps);

    /// <summary>Prepares the physics object for removal from visibility by clearing shadow references, detaching it from its current cell, and scheduling itself and all child objects for destruction.
    /// <code>Offset: 0x00512A10
    /// int __thiscall CPhysicsObj::prepare_to_leave_visibility(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>Always 1, indicating successful preparation.</returns>
    public int prepare_to_leave_visibility() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00512A10)(ref this);

    /// <summary>Prepares a physics object for insertion into the simulation world by resetting its update timestamp, removing it and any child objects from pending destruction lists, clearing lost‑cell status, and setting internal flags to mark the object as active.
    /// <code>Offset: 0x00512A70
    /// void __thiscall CPhysicsObj::prepare_to_enter_world(CPhysicsObj*)</code>
    /// </summary>
    public void prepare_to_enter_world() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00512A70)(ref this);

    /// <summary>Initializes the movement manager if missing, updates timing flags when required, and forwards the movement data blob to the MovementManager for unpacking.
    /// <code>Offset: 0x00512B10
    /// void __thiscall CPhysicsObj::unpack_movement(CPhysicsObj*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the serialized movement data buffer.</param>
    /// <param name="size">Size in bytes of the movement data block.</param>
    public void unpack_movement(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void**, uint, void>)0x00512B10)(ref this, addr, size);

    /// <summary>Retrieves the motion interpreter associated with this physics object, creating the movement manager and default states when necessary.
    /// <code>Offset: 0x00512B90
    /// CMotionInterp* __thiscall CPhysicsObj::get_minterp(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>A pointer to the CMotionInterp instance used for interpreting motion states of the object.</returns>
    public ACBindings.Internal.CMotionInterp* get_minterp() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CMotionInterp*>)0x00512B90)(ref this);

    /// <summary>Accesses the PositionManager associated with this physics object, creating it if necessary.
    /// <code>Offset: 0x00512C00
    /// PositionManager* __thiscall CPhysicsObj::get_position_manager(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>A pointer to the PositionManager instance managing this object's position.</returns>
    public ACBindings.Internal.PositionManager* get_position_manager() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.PositionManager*>)0x00512C00)(ref this);

    /// <summary>Computes the physics velocity expressed in the object’s local coordinate system and writes it to the supplied vector.
    /// <code>Offset: 0x00512C10
    /// void __thiscall CPhysicsObj::get_local_physics_velocity(CPhysicsObj*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="retval">The vector that will receive the local velocity components.</param>
    public void get_local_physics_velocity(ACBindings.Internal.AC1Legacy.Vector3* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x00512C10)(ref this, retval);

    /// <summary>Initializes a physics object with default values, sets up its position frame, allocates storage for shadow objects, and prepares movement, detection, attack, and particle managers for use.
    /// <code>Offset: 0x00512EF0
    /// void __thiscall CPhysicsObj::CPhysicsObj(CPhysicsObj*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00512EF0)(ref this);

    /// <summary>Creates a new physics object initialized with the supplied identifier and dynamic flag.
    /// <code>Offset: 0x00513100
    /// CPhysicsObj* __cdecl CPhysicsObj::makeNullObject(unsigned int,int)</code>
    /// </summary>
    /// <param name="object_iid">The unique ID assigned to the newly created physics object.</param>
    /// <param name="bDynamic">A flag indicating whether the object should be treated as dynamic (non‑static) when initialized.</param>
    /// <returns>A pointer to the constructed CPhysicsObj instance if initialization succeeds; otherwise, null.</returns>
    public static ACBindings.Internal.CPhysicsObj* makeNullObject(uint object_iid, int bDynamic) => ((delegate* unmanaged[Cdecl]<uint, int, ACBindings.Internal.CPhysicsObj*>)0x00513100)(object_iid, bDynamic);

    /// <summary>Creates a new physics object configured as a particle system with the given number of parts and optional sorting sphere.
    /// <code>Offset: 0x00513140
    /// CPhysicsObj* __cdecl CPhysicsObj::makeParticleObject(unsigned int,const CSphere*)</code>
    /// </summary>
    /// <param name="num_parts">The desired number of particles to include in the system.</param>
    /// <param name="sorting_sphere">Optional sphere used to influence particle ordering; may be nullptr.</param>
    /// <returns>Pointer to the newly constructed CPhysicsObj, or null if allocation or initialization fails.</returns>
    public static ACBindings.Internal.CPhysicsObj* makeParticleObject(uint num_parts, ACBindings.Internal.CSphere* sorting_sphere) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CSphere*, ACBindings.Internal.CPhysicsObj*>)0x00513140)(num_parts, sorting_sphere);

    /// <summary>Initializes the physics object's part array based on its type, creating a mesh or animation object as required.
    /// <code>Offset: 0x005131B0
    /// int __thiscall CPhysicsObj::InitPartArrayObject(CPhysicsObj*,int,int)</code>
    /// </summary>
    /// <param name="a2">Identifier for the object definition to load.</param>
    /// <param name="a3">Optional secondary identifier used when creating animated or setup parts.</param>
    /// <returns>Returns 1 if initialization succeeds; otherwise returns 0.</returns>
    public int InitPartArrayObject(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int, int>)0x005131B0)(ref this, a2, a3);

    /// <summary>Assigns a motion table identifier to the object's part array, updating its movement manager accordingly.
    /// <code>Offset: 0x00513280
    /// int __thiscall CPhysicsObj::SetMotionTableID(CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="a2">The motion table ID to apply; if invalid, no new movement manager is created.</param>
    /// <returns>Non‑zero on success; zero if the part array is absent or setting fails.</returns>
    public int SetMotionTableID(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int>)0x00513280)(ref this, a2);

    /// <summary>Binds this physics object to a target object by creating or updating its PositionManager so it remains attached to that object’s base ID, using the target’s dimensions when available.
    /// <code>Offset: 0x005132E0
    /// void __thiscall CPhysicsObj::stick_to_object(CPhysicsObj*,unsigned int)</code>
    /// </summary>
    /// <param name="object_id">Identifier of the object to which this object should attach.</param>
    public void stick_to_object(uint object_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, void>)0x005132E0)(ref this, object_id);

    /// <summary>Moves this physics object toward a specified target object using the supplied movement parameters. If the object lacks an active movement manager, one is created and initialized to its default state before executing the move.
    /// <code>Offset: 0x00513360
    /// void __thiscall CPhysicsObj::MoveToObject(CPhysicsObj*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    /// <param name="object_id">The identifier of the target physics object to approach.</param>
    /// <param name="params">A pointer to a const MovementParameters structure that defines distance thresholds, heading, speed, and other movement constraints.</param>
    public void MoveToObject(uint object_id, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, ACBindings.Internal.MovementParameters*, void>)0x00513360)(ref this, object_id, params_);

    /// <summary>Aligns this physics object to face a specified target object using optional movement parameters.
    /// <code>Offset: 0x00513440
    /// void __thiscall CPhysicsObj::TurnToObject(CPhysicsObj*,unsigned int,const MovementParameters*)</code>
    /// </summary>
    /// <param name="object_id">Identifier of the target object to orient toward.</param>
    /// <param name="params">Optional movement settings controlling heading, distance tolerance, speed, and other turn behavior.</param>
    public void TurnToObject(uint object_id, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, ACBindings.Internal.MovementParameters*, void>)0x00513440)(ref this, object_id, params_);

    /// <summary>Rotates the object toward a heading defined by the supplied MovementParameters. If the object lacks an active movement manager, one is created and initialized before performing the turn.
    /// <code>Offset: 0x00513480
    /// void __thiscall CPhysicsObj::TurnToHeading(CPhysicsObj*,const MovementParameters*)</code>
    /// </summary>
    /// <param name="params">Movement parameters describing the target heading, speed, and related motion data for this rotation.</param>
    public void TurnToHeading(ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.MovementParameters*, void>)0x00513480)(ref this, params_);

    /// <summary>Executes an attack from this physics object using the supplied attack cone, querying nearby cells for targets and reporting successful hits.
    /// <code>Offset: 0x00513570
    /// void __thiscall CPhysicsObj::attack(CPhysicsObj*,const AttackCone*)</code>
    /// </summary>
    /// <param name="attack_cone">Defines part index, angular boundaries, radius, and height of the attack volume.</param>
    public void attack(ACBindings.Internal.AttackCone* attack_cone) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.AttackCone*, void>)0x00513570)(ref this, attack_cone);

    /// <summary>Updates the physics object's movement and position managers with new target data when no context ID is specified.
    /// <code>Offset: 0x005136C0
    /// void __thiscall CPhysicsObj::HandleUpdateTarget(CPhysicsObj*,TargetInfo)</code>
    /// </summary>
    /// <param name="target_info">Target information to propagate; if its context_id is zero, updates are forwarded to the movement and position managers.</param>
    public void HandleUpdateTarget(ACBindings.Internal.TargetInfo target_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.TargetInfo, void>)0x005136C0)(ref this, target_info);

    /// <summary>Updates the physics object's position by applying part updates, scaling offsets, adjusting through the PositionManager, and merging with its current frame before advancing internal physics simulation and executing hooks.
    /// <code>Offset: 0x00513730
    /// void __thiscall CPhysicsObj::UpdatePositionInternal(CPhysicsObj*,float,Frame*)</code>
    /// </summary>
    /// <param name="quantum">Time delta for this update cycle.</param>
    /// <param name="o_newFrame">Output frame containing the updated global transform.</param>
    public void UpdatePositionInternal(float quantum, ACBindings.Internal.Frame* o_newFrame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, ACBindings.Internal.Frame*, void>)0x00513730)(ref this, quantum, o_newFrame);

    /// <summary>
    /// Updates a child physics object's spatial transform relative to its parent by combining either the parent's base frame or a specified part's frame with the provided child frame; then refreshes any particle and script managers attached to the child.
    /// 
    /// <code>Offset: 0x00513850
    /// void __thiscall CPhysicsObj::UpdateChild(CPhysicsObj*,CPhysicsObj*,unsigned int,const Frame*)</code>
    /// </summary>
    /// <param name="child_obj">The child physics object whose frame is being updated.</param>
    /// <param name="part_index">Index of the parent part used for combining frames; if out of range, the parent's base frame is used.</param>
    /// <param name="child_frame">Frame defining the child's local transform to apply after combination.</param>
    public void UpdateChild(ACBindings.Internal.CPhysicsObj* child_obj, uint part_index, ACBindings.Internal.Frame* child_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, uint, ACBindings.Internal.Frame*, void>)0x00513850)(ref this, child_obj, part_index, child_frame);

    /// <summary>Computes the movement transition for a physics object between two positions, initializing sphere data, collision info, and validating the resulting position.
    /// <code>Offset: 0x005138C0
    /// const CTransition* __thiscall CPhysicsObj::transition(CPhysicsObj*,const Position*,const Position*,int)</code>
    /// </summary>
    /// <param name="old_pos">The object's previous position.</param>
    /// <param name="new_pos">The intended new position after movement.</param>
    /// <param name="admin_move">Flag indicating whether the move was forced by an administrator.</param>
    /// <returns>Pointer to a populated CTransition structure if a valid transition exists; otherwise, null.</returns>
    public ACBindings.Internal.CTransition* transition(ACBindings.Internal.Position* old_pos, ACBindings.Internal.Position* new_pos, int admin_move) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, ACBindings.Internal.Position*, int, ACBindings.Internal.CTransition*>)0x005138C0)(ref this, old_pos, new_pos, admin_move);

    /// <summary>Determines whether this physics object collides with the specified object by performing a transition‑based collision check.
    /// <code>Offset: 0x005139D0
    /// int __thiscall CPhysicsObj::check_collision(CPhysicsObj*,const CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The other physics object to test against.</param>
    /// <returns>An integer flag: non-zero if a collision is detected; zero otherwise.</returns>
    public int check_collision(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, int>)0x005139D0)(ref this, object_);

    /// <summary>Handles a new collision between the physics object and its surrounding environment, updates internal state flags, and informs the associated WeenieObject when appropriate.
    /// <code>Offset: 0x00513AC0
    /// int __thiscall CPhysicsObj::report_environment_collision(CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="prev_has_contact">Indicates whether the object was already in contact with the environment before this call; used to set the collision profile’s previous contact flag.</param>
    /// <returns>1 if a new collision event was processed and notified; otherwise 0.</returns>
    public int report_environment_collision(int prev_has_contact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int>)0x00513AC0)(ref this, prev_has_contact);

    /// <summary>Reports a collision between this object and another, notifying their associated game objects when appropriate.
    /// <code>Offset: 0x00513B60
    /// int __thiscall CPhysicsObj::report_object_collision(CPhysicsObj*,const CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="object">The other physics object involved in the collision.</param>
    /// <param name="prev_has_contact">Flag indicating whether contact was already occurring prior to this call.</param>
    /// <returns>1 if a collision event was handled; 0 otherwise.</returns>
    public int report_object_collision(ACBindings.Internal.CPhysicsObj* object_, int prev_has_contact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, int, int>)0x00513B60)(ref this, object_, prev_has_contact);

    /// <summary>Plays a physics script of the specified type on this object, applying an optional modification factor.
    /// <code>Offset: 0x00513D60
    /// int __thiscall CPhysicsObj::play_script(CPhysicsObj*,PScriptType,float)</code>
    /// </summary>
    /// <param name="script_type">Identifier for the desired physics script.</param>
    /// <param name="mod">Intensity or modifier value influencing script execution.</param>
    /// <returns>Zero if no script table exists; one if the object lacks a cell; otherwise the result from play_script_internal.</returns>
    public int play_script(ACBindings.Internal.PScriptType script_type, float mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.PScriptType, float, int>)0x00513D60)(ref this, script_type, mod);

    /// <summary>Runs the object's default physics script by resolving it through the physics script table and invoking its internal execution.
    /// <code>Offset: 0x00513DB0
    /// int __thiscall CPhysicsObj::play_default_script(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>Non‑zero when the object has no cell or when the script executes successfully; zero if there is no physics script table or if execution fails.</returns>
    public int play_default_script() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00513DB0)(ref this);

    /// <summary>Searches this object's children for a component with the given part number and triggers that child's default physics script if available.
    /// <code>Offset: 0x00513E00
    /// int __thiscall CPhysicsObj::play_default_script(CPhysicsObj*,unsigned int)</code>
    /// </summary>
    /// <param name="part_index">The part number to locate among the object's child parts.</param>
    /// <returns>1 when a matching child is found but has no cell; otherwise returns the value from play_script_internal when the script is executed. Returns 0 if no matching child exists or the child lacks a physics script table.</returns>
    public int play_default_script(uint part_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int>)0x00513E00)(ref this, part_index);

    /// <summary>Moves the physics object into a specified cell or detaches it when null, updating internal references and part array cell IDs accordingly.
    /// <code>Offset: 0x00513E90
    /// void __thiscall CPhysicsObj::change_cell(CPhysicsObj*,CObjCell*)</code>
    /// </summary>
    /// <param name="new_cell">Target cell for the object; if nullptr, the object is removed from its current cell and all related identifiers reset.</param>
    public void change_cell(ACBindings.Internal.CObjCell* new_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CObjCell*, void>)0x00513E90)(ref this, new_cell);

    /// <summary>Detaches the physics object from its current cell, clearing its position reference and resetting part cell IDs when appropriate. If a target cell is provided, removes any shadow objects and parts associated with this object from that cell.
    /// <code>Offset: 0x00513EF0
    /// void __thiscall CPhysicsObj::RemoveObjectFromSingleCell(CPhysicsObj*,CObjCell*)</code>
    /// </summary>
    /// <param name="obj_cell">The cell from which to remove the object's shadow objects and parts; if null, only the object's own cell association is cleared.</param>
    public void RemoveObjectFromSingleCell(ACBindings.Internal.CObjCell* obj_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CObjCell*, void>)0x00513EF0)(ref this, obj_cell);

    /// <summary>Detaches a physics object from its parent by removing it from the parent's child list, clearing parent-related flags, resetting timing information, and recomputing acceleration, also ensuring ground state is updated when appropriate.
    /// <code>Offset: 0x00513F70
    /// void __thiscall CPhysicsObj::unset_parent(CPhysicsObj*)</code>
    /// </summary>
    public void unset_parent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00513F70)(ref this);

    /// <summary>Detaches all child objects from the current physics object, resetting parent references and updating their physical state accordingly.
    /// <code>Offset: 0x00513FE0
    /// void __thiscall CPhysicsObj::unparent_children(CPhysicsObj*)</code>
    /// </summary>
    public void unparent_children() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00513FE0)(ref this);

    /// <summary>Dispatches a physics object hook operation based on the specified type, applying the given value to scale, translucency, part properties, or triggering internal scripts.
    /// <code>Offset: 0x005140C0
    /// void __thiscall CPhysicsObj::process_fp_hook(CPhysicsObj*,int,float,void*)</code>
    /// </summary>
    /// <param name="type">Identifier of the hook operation to perform (0 = set scale, 1 = set translucency, 2‑6 = modify part attributes, 7 = invoke a physics script).</param>
    /// <param name="curr_value">The floating-point value to apply for the selected operation.</param>
    /// <param name="user_data">Additional data used by certain operations; typically an index or script identifier.</param>
    public void process_fp_hook(int type, float curr_value, System.IntPtr user_data) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, float, System.IntPtr, void>)0x005140C0)(ref this, type, curr_value, user_data);

    /// <summary>Adjusts the object's scaling factor. If the supplied time delta exceeds a small threshold, creates an interpolation hook that gradually changes scale; otherwise applies the new value immediately and propagates it to contained parts.
    /// <code>Offset: 0x005141A0
    /// void __thiscall CPhysicsObj::SetScale(CPhysicsObj*,float,long double)</code>
    /// </summary>
    /// <param name="new_scale">The desired scaling factor to apply to the object.</param>
    /// <param name="delta">Time duration over which the scaling change should animate when above a minimal threshold.</param>
    public void SetScale(float new_scale, double delta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, double, void>)0x005141A0)(ref this, new_scale, delta);

    /// <summary>Adds a NetBlob to this physics object's network queue, creating the queue if it does not exist.
    /// <code>Offset: 0x00514270
    /// void __thiscall CPhysicsObj::queue_netblob(CPhysicsObj*,NetBlob*)</code>
    /// </summary>
    /// <param name="blob">The NetBlob to enqueue; its reference count is increased.</param>
    public void queue_netblob(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.NetBlob*, void>)0x00514270)(ref this, blob);

    /// <summary>Initializes the object's part array for a null configuration using the specified setup ID, configuring placement and frame data as needed.
    /// <code>Offset: 0x00514410
    /// int __thiscall CPhysicsObj::InitNullObject(CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="a2">The identifier used to set up the part array.</param>
    /// <returns>1 if initialization succeeds; otherwise returns an error code.</returns>
    public int InitNullObject(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int>)0x00514410)(ref this, a2);

    /// <summary>Creates a new physics object using the supplied parameters, initializes its internal structures, and returns the resulting instance or null on failure.
    /// <code>Offset: 0x00514470
    /// CPhysicsObj* __cdecl CPhysicsObj::makeObject(int,unsigned int,int)</code>
    /// </summary>
    /// <param name="a1">Used for part‑array initialization (e.g., number of parts).</param>
    /// <param name="object_iid">Identifier specifying the type of physics object to instantiate.</param>
    /// <param name="bDynamic">Flag indicating whether the object is dynamic (non‑static) or not.</param>
    /// <returns>Pointer to the newly created CPhysicsObj instance, or null if allocation or initialization fails.</returns>
    public static ACBindings.Internal.CPhysicsObj* makeObject(int a1, uint object_iid, int bDynamic) => ((delegate* unmanaged[Cdecl]<int, uint, int, ACBindings.Internal.CPhysicsObj*>)0x00514470)(a1, object_iid, bDynamic);

    /// <summary>Initializes the physics object with defaults from the supplied setup structure, configuring scripts, motion tables, sound and physics tables, and updating relevant state flags.
    /// <code>Offset: 0x005144D0
    /// void __thiscall CPhysicsObj::InitDefaults(CPhysicsObj*,const CSetup*)</code>
    /// </summary>
    /// <param name="this">The physics object instance to initialize.</param>
    /// <param name="a2">Setup data providing default configuration parameters such as script IDs, table references, and state modifiers.</param>
    public void InitDefaults(ACBindings.Internal.CSetup* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CSetup*, void>)0x005144D0)(ref this, a2);

    /// <summary>Destroys the physics object, freeing associated managers, scripts, collision tables, and resetting internal state to indicate deactivation.
    /// <code>Offset: 0x005145D0
    /// void __thiscall CPhysicsObj::Destroy(CPhysicsObj*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x005145D0)(ref this);

    /// <summary>Destroys a CPhysicsObj instance, cleaning up resources such as shadow objects, animation hooks, and resetting base class references.
    /// <code>Offset: 0x00514830
    /// void __thiscall CPhysicsObj::~CPhysicsObj(CPhysicsObj*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00514830)(ref this);

    /// <summary>Updates the physics state of all child objects linked to this object when a part array exists, iterating over each child and invoking UpdateChild with corresponding data.
    /// <code>Offset: 0x005148A0
    /// void __thiscall CPhysicsObj::UpdateChildrenInternal(CPhysicsObj*)</code>
    /// </summary>
    public void UpdateChildrenInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x005148A0)(ref this);

    /// <summary>Advances the simulation of a static physics object based on elapsed time while it resides in a cell. The method applies part and child updates when the time delta falls within an acceptable quantum, runs associated scripts and particle systems, and processes animation hooks before resetting its update timestamp.
    /// <code>Offset: 0x005148F0
    /// void __thiscall CPhysicsObj::animate_static_object(CPhysicsObj*)</code>
    /// </summary>
    public void animate_static_object() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x005148F0)(ref this);

    /// <summary>Tracks a collision between this physics object and another, reporting the event if it has not been processed already. Handles environment collisions separately.
    /// <code>Offset: 0x00514A10
    /// int __thiscall CPhysicsObj::track_object_collision(CPhysicsObj*,const CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="object">The other physics object to check for contact with.</param>
    /// <param name="prev_has_contact">Indicates whether this object was previously in contact; used to avoid duplicate reports.</param>
    /// <returns>Non‑zero if a collision report is issued, zero if the collision has already been recorded or no new collision occurred.</returns>
    public int track_object_collision(ACBindings.Internal.CPhysicsObj* object_, int prev_has_contact) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, int, int>)0x00514A10)(ref this, object_, prev_has_contact);

    /// <summary>Reports that this physics object has begun colliding with other objects by traversing its collision table, retrieving associated objects from the maintenance system, and invoking collision callbacks for each detected contact.
    /// <code>Offset: 0x00514AD0
    /// void __thiscall CPhysicsObj::report_collision_start(CPhysicsObj*)</code>
    /// </summary>
    public void report_collision_start() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00514AD0)(ref this);

    /// <summary>Sets the physics object's transform to the specified frame after validating its orientation. If the frame is invalid except for heading, zeroes the quaternion while preserving rotation matrix and origin. Propagates the updated frame to attached parts (if any) and updates child objects.
    /// <code>Offset: 0x00514B90
    /// void __thiscall CPhysicsObj::set_frame(CPhysicsObj*,const Frame*)</code>
    /// </summary>
    /// <param name="i_frame">The desired position and orientation frame.</param>
    public void set_frame(ACBindings.Internal.Frame* i_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Frame*, void>)0x00514B90)(ref this, i_frame);

    /// <summary>Sets the object's initial transformation frame, updating associated parts and child objects as needed.
    /// <code>Offset: 0x00514C20
    /// void __thiscall CPhysicsObj::set_initial_frame(CPhysicsObj*,const Frame*)</code>
    /// </summary>
    /// <param name="frame">The frame defining position, orientation, scale, and related matrices to apply to the object.</param>
    public void set_initial_frame(ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Frame*, void>)0x00514C20)(ref this, frame);

    /// <summary>Sets the object's heading by rotating its frame to the specified angle.
    /// <code>Offset: 0x00514C60
    /// void __thiscall CPhysicsObj::set_heading(CPhysicsObj*,float,int)</code>
    /// </summary>
    /// <param name="degrees">The desired heading in degrees.</param>
    /// <param name="send_event">Flag indicating whether an event should be sent when the heading changes (currently unused).</param>
    public void set_heading(float degrees, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, int, void>)0x00514C60)(ref this, degrees, send_event);

    /// <summary>Stores the supplied Position into the physics object, updating its cell identifier, frame, and part array while handling out‑of‑bounds adjustments.
    /// <code>Offset: 0x00514CA0
    /// void __thiscall CPhysicsObj::store_position(CPhysicsObj*,const Position*)</code>
    /// </summary>
    /// <param name="p">The Position containing the new cell ID and frame to apply.</param>
    public void store_position(ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, void>)0x00514CA0)(ref this, p);

    /// <summary>Prepares the physics object for exiting visible area, stores its current position, relocates it to a lost cell, and clears its visibility transient flag.
    /// <code>Offset: 0x00514D20
    /// void __thiscall CPhysicsObj::leave_visibility(CPhysicsObj*)</code>
    /// </summary>
    public void leave_visibility() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00514D20)(ref this);

    /// <summary>Creates a new physics object based on the supplied template.
    /// <code>Offset: 0x00514FB0
    /// CPhysicsObj* __cdecl CPhysicsObj::makeObject(const CPhysicsObj*)</code>
    /// </summary>
    /// <param name="pTemplate">The template physics object used to initialize the new instance.</param>
    /// <returns>Pointer to the newly created physics object, or nullptr if creation fails.</returns>
    public static ACBindings.Internal.CPhysicsObj* makeObject(ACBindings.Internal.CPhysicsObj* pTemplate) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.CPhysicsObj*>)0x00514FB0)(pTemplate);

    /// <summary>Updates the object’s position and associated systems based on elapsed time, applying physics integration only when sufficient time has passed and refreshing particles and scripts as needed.
    /// <code>Offset: 0x00515020
    /// void __thiscall CPhysicsObj::update_position(CPhysicsObj*)</code>
    /// </summary>
    public void update_position() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00515020)(ref this);

    /// <summary>Ends expired or forcibly requested collisions, removes them from the internal collision table, and notifies each affected object via report_object_collision_end.
    /// <code>Offset: 0x00515120
    /// void __thiscall CPhysicsObj::report_collision_end(CPhysicsObj*,const int)</code>
    /// </summary>
    /// <param name="force_end">Non‑zero forces all current collisions to end immediately regardless of their timers.</param>
    public void report_collision_end(int force_end) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, void>)0x00515120)(ref this, force_end);

    /// <summary>Processes all collisions for a physics object, handling interactions with other objects and the environment, updating velocity and transient state accordingly.
    /// <code>Offset: 0x00515280
    /// int __thiscall CPhysicsObj::handle_all_collisions(CPhysicsObj*,const COLLISIONINFO*,int,int)</code>
    /// </summary>
    /// <param name="collisions">Collision information containing interacting objects, normals, and frame data.</param>
    /// <param name="prev_has_contact">Flag indicating whether the object had contact before this call.</param>
    /// <param name="prev_on_walkable">Flag indicating whether the object was on a walkable surface before this call.</param>
    /// <returns>Non‑zero if any collision (object or environment) was handled; zero otherwise.</returns>
    public int handle_all_collisions(ACBindings.Internal.COLLISIONINFO* collisions, int prev_has_contact, int prev_on_walkable) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.COLLISIONINFO*, int, int, int>)0x00515280)(ref this, collisions, prev_has_contact, prev_on_walkable);

    /// <summary>Adds the physics object to a specified cell, removing it from any previous cell and updating shadow and part array associations accordingly.
    /// <code>Offset: 0x005154E0
    /// void __thiscall CPhysicsObj::AddObjectToSingleCell(CPhysicsObj*,CObjCell*)</code>
    /// </summary>
    /// <param name="obj_cell">The target cell for the object; if null, the object is detached from its current cell.</param>
    public void AddObjectToSingleCell(ACBindings.Internal.CObjCell* obj_cell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CObjCell*, void>)0x005154E0)(ref this, obj_cell);

    /// <summary>Creates a shadow entry for the physics object within its current cell, registering the object's particle effects so they are processed or rendered by the cell system.
    /// <code>Offset: 0x00515570
    /// void __thiscall CPhysicsObj::add_particle_shadow_to_cell(CPhysicsObj*)</code>
    /// </summary>
    public void add_particle_shadow_to_cell() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00515570)(ref this);

    /// <summary>Adds shadow representations for this physics object into each cell specified in the given cell array, creating or resizing an internal shadow buffer as needed and registering those shadows with both the cells themselves and their part arrays. If the object has a special state flag set, it delegates to a particle‑shadow routine instead of the standard process. After handling its own shadows, the method recursively applies the same logic to all child physics objects.
    /// <code>Offset: 0x005155E0
    /// void __thiscall CPhysicsObj::add_shadows_to_cells(CPhysicsObj*,const CELLARRAY*)</code>
    /// </summary>
    /// <param name="cell_array">The array of cell information that defines where this object's shadows should be placed and tracked.</param>
    public void add_shadows_to_cells(ACBindings.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CELLARRAY*, void>)0x005155E0)(ref this, cell_array);

    /// <summary>Adds an animation hook to the physics object, automatically expanding the internal collection if required.
    /// <code>Offset: 0x00515720
    /// void __thiscall CPhysicsObj::add_anim_hook(CPhysicsObj*,CAnimHook*)</code>
    /// </summary>
    /// <param name="hook">The animation hook instance to attach.</param>
    public void add_anim_hook(ACBindings.Internal.CAnimHook* hook) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CAnimHook*, void>)0x00515720)(ref this, hook);

    /// <summary>Sets an object's visibility and related physics state, running hide/show scripts, updating child objects, collision flags, and cell registration as needed.
    /// <code>Offset: 0x00515760
    /// void __thiscall CPhysicsObj::set_hidden(CPhysicsObj*,int,int)</code>
    /// </summary>
    /// <param name="hidden">Non‑zero to mark the object hidden; zero restores it to visible.</param>
    /// <param name="send_event">Unused in this implementation; retained for API compatibility.</param>
    public void set_hidden(int hidden, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int, void>)0x00515760)(ref this, hidden, send_event);

    /// <summary>Updates the physics object's state flags, adjusting lighting, visibility, and hidden status as required by the new state bitmask.
    /// <code>Offset: 0x005158D0
    /// int __thiscall CPhysicsObj::set_state(CPhysicsObj*,unsigned int,int)</code>
    /// </summary>
    /// <param name="new_state">Bitfield describing the desired state of the object (e.g., light enable/disable, no‑draw, hidden).</param>
    /// <param name="send_event">Indicates whether a state‑change event should be sent; currently unused in this implementation.</param>
    /// <returns>Always returns 1 to signal successful completion.</returns>
    public int set_state(uint new_state, int send_event) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, uint, int, int>)0x005158D0)(ref this, new_state, send_event);

    /// <summary>Removes the physics object from the world, cleaning up parts, movement, position, target, and detection managers, then signals that collision handling has ended.
    /// <code>Offset: 0x00515960
    /// void __thiscall CPhysicsObj::exit_world(CPhysicsObj*)</code>
    /// </summary>
    public void exit_world() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00515960)(ref this);

    /// <summary>
    /// Performs necessary state cleanup when an object is teleported: cancels pending movement, removes position constraints, stops interpolation, clears current targets, notifies voyeurs of the teleport event, and ends collision reporting.
    /// 
    /// <code>Offset: 0x005159D0
    /// void __thiscall CPhysicsObj::teleport_hook(CPhysicsObj*,int)</code>
    /// </summary>
    /// <param name="hide">Optional flag indicating whether to hide the object during teleport; currently unused by this implementation.</param>
    public void teleport_hook(int hide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, void>)0x005159D0)(ref this, hide);

    /// <summary>Applies the provided PhysicsDesc to this object, configuring motion tables, scripts, physical attributes, and optionally setting movement data.
    /// <code>Offset: 0x00515A40
    /// int __thiscall CPhysicsObj::set_description(CPhysicsObj*,const PhysicsDesc*,int)</code>
    /// </summary>
    /// <param name="desc">The physics description containing parameters such as state, scale, friction, elasticity, translucency, velocity, and script information.</param>
    /// <param name="set_movement">When non‑zero, the function unpacks movement data from the descriptor; otherwise only placement and attribute values are applied.</param>
    /// <returns>Non‑zero (typically 1) if the description was successfully applied; otherwise returns the error code from SetMotionTableID.</returns>
    public int set_description(ACBindings.Internal.PhysicsDesc* desc, int set_movement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.PhysicsDesc*, int, int>)0x00515A40)(ref this, desc, set_movement);

    /// <summary>Determines which world cells intersect the physics object and updates its shadow participation by removing outdated references and inserting current ones, using cylindrical parts when available or falling back to the bounding‑box for static objects.
    /// <code>Offset: 0x00515C60
    /// void __thiscall CPhysicsObj::calc_cross_cells_static(CPhysicsObj*)</code>
    /// </summary>
    public void calc_cross_cells_static() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00515C60)(ref this);

    /// <summary>Determines which world cells intersect the object based on its position and geometry, updates its cell list, and refreshes associated shadow objects accordingly.
    /// <code>Offset: 0x00515D30
    /// void __thiscall CPhysicsObj::calc_cross_cells(CPhysicsObj*)</code>
    /// </summary>
    public void calc_cross_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00515D30)(ref this);

    /// <summary>Updates the physics object's position and state according to a transition, synchronizing cell membership, part array identifiers, transient flags, contact plane data, acceleration, collision handling, and shadow updates.
    /// <code>Offset: 0x00515E30
    /// int __thiscall CPhysicsObj::SetPositionInternal(CPhysicsObj*,const CTransition*)</code>
    /// </summary>
    /// <param name="transit">The transition containing new position, cell, collision, and path information.</param>
    /// <returns>Always returns 1 to indicate successful completion.</returns>
    public int SetPositionInternal(ACBindings.Internal.CTransition* transit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CTransition*, int>)0x00515E30)(ref this, transit);

    /// <summary>Detaches the object from the physics world by clearing collision state, removing it from maintenance structures, detaching from cells and part arrays, recalculating acceleration, and resetting movement flags.
    /// <code>Offset: 0x005160A0
    /// void __thiscall CPhysicsObj::leave_world(CPhysicsObj*)</code>
    /// </summary>
    public void leave_world() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x005160A0)(ref this);

    /// <summary>Assigns the object to a new cell based on a specified position, updating its frame and recalculating cross‑cell relationships.
    /// <code>Offset: 0x00516160
    /// SetPositionError __thiscall CPhysicsObj::ForceIntoCell(CPhysicsObj*,CObjCell*,const Position*)</code>
    /// </summary>
    /// <param name="pNewCell">The target cell into which the physics object should be moved.</param>
    /// <param name="pos">Position data containing the frame information to apply to the object.</param>
    /// <returns>Zero on success; non‑zero error code (e.g., 3) if the specified cell is null.</returns>
    public ACBindings.Internal.SetPositionError ForceIntoCell(ACBindings.Internal.CObjCell* pNewCell, ACBindings.Internal.Position* pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CObjCell*, ACBindings.Internal.Position*, ACBindings.Internal.SetPositionError>)0x00516160)(ref this, pNewCell, pos);

    /// <summary>Advances the physics object’s state by a given time quantum, updating position, velocity, transitions, and interacting with movement, detection, targeting, particle, and script systems. Handles special cases such as ethereal state, sphere part array movement, and frame orientation adjustments.
    /// <code>Offset: 0x005161B0
    /// void __thiscall CPhysicsObj::UpdateObjectInternal(CPhysicsObj*,float)</code>
    /// </summary>
    /// <param name="quantum">The elapsed time to apply when stepping the physics simulation.</param>
    public void UpdateObjectInternal(float quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, float, void>)0x005161B0)(ref this, quantum);

    /// <summary>Moves the physics object into a specified cell using a new transform frame, updating its internal state, child objects, and static cross‑cell relationships.
    /// <code>Offset: 0x005164E0
    /// void __thiscall CPhysicsObj::add_obj_to_cell(CPhysicsObj*,CObjCell*,const Frame*)</code>
    /// </summary>
    /// <param name="new_cell">The destination cell for the object.</param>
    /// <param name="new_frame">A frame containing position and orientation data to apply to the object within the new cell.</param>
    public void add_obj_to_cell(ACBindings.Internal.CObjCell* new_cell, ACBindings.Internal.Frame* new_frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CObjCell*, ACBindings.Internal.Frame*, void>)0x005164E0)(ref this, new_cell, new_frame);

    /// <summary>Recalculates the set of world cells that a physics object occupies or shadows, updating its cross‑cell data and propagating the operation to any child objects.
    /// <code>Offset: 0x00516530
    /// void __thiscall CPhysicsObj::recalc_cross_cells(CPhysicsObj*)</code>
    /// </summary>
    public void recalc_cross_cells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00516530)(ref this);

    /// <summary>Sets the current physics object as a child of another object, attaching it at the specified index and updating hierarchy, world cell association, and rendering state accordingly.
    /// <code>Offset: 0x00516590
    /// int __thiscall CPhysicsObj::set_parent(CPhysicsObj*,CPhysicsObj*,unsigned int)</code>
    /// </summary>
    /// <param name="obj">The parent physics object that will receive this instance as a child.</param>
    /// <param name="where">Index within the parent's children list where this object should be inserted.</param>
    /// <returns>Non‑zero if the attachment succeeds; zero if the parent is null or adding the child fails.</returns>
    public int set_parent(ACBindings.Internal.CPhysicsObj* obj, uint where) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, uint, int>)0x00516590)(ref this, obj, where);

    /// <summary>Attaches the current physics object as a child of another object at the specified part index using the provided frame, updating parent relationships and spatial state.
    /// <code>Offset: 0x00516650
    /// int __thiscall CPhysicsObj::set_parent(CPhysicsObj*,CPhysicsObj*,unsigned int,const Frame*)</code>
    /// </summary>
    /// <param name="obj">The new parent physics object.</param>
    /// <param name="part_index">Index of the part on the parent to which this object will attach.</param>
    /// <param name="frame">Transformation frame defining this object's pose relative to the parent.</param>
    /// <returns>Nonzero if attachment succeeds; zero otherwise (e.g., null parent or failure to add child).</returns>
    public int set_parent(ACBindings.Internal.CPhysicsObj* obj, uint part_index, ACBindings.Internal.Frame* frame) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.CPhysicsObj*, uint, ACBindings.Internal.Frame*, int>)0x00516650)(ref this, obj, part_index, frame);

    /// <summary>
    /// Updates the physics object's internal position, performing cell transition checks, collision handling, and optional forced placement. Returns an error code indicating success or the type of failure encountered.
    /// 
    /// <code>Offset: 0x005166D0
    /// SetPositionError __thiscall CPhysicsObj::SetPositionInternal(CPhysicsObj*,Position*,const SetPositionStruct*,CTransition*)</code>
    /// </summary>
    /// <param name="p">Target position data to be applied to the object.</param>
    /// <param name="sps">Structure containing flags, line information, rotation radii, and retry limits for positioning.</param>
    /// <param name="transit">Transition context used during positioning; may be updated or cleared by the method.</param>
    /// <returns>Zero on success; non‑zero error codes indicate specific failure conditions such as forced cell entry failures, collision resolution failures, missing current cell, or unresolved transition data.</returns>
    public ACBindings.Internal.SetPositionError SetPositionInternal(ACBindings.Internal.Position* p, ACBindings.Internal.SetPositionStruct* sps, ACBindings.Internal.CTransition* transit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, ACBindings.Internal.SetPositionStruct*, ACBindings.Internal.CTransition*, ACBindings.Internal.SetPositionError>)0x005166D0)(ref this, p, sps, transit);

    /// <summary>Updates the physics object’s simulation state each frame, performing time‑stepping with fixed quanta, activating or deactivating based on proximity to the player, and handling parent/child relationships. Large elapsed times are broken into quantum increments to maintain numerical stability.
    /// <code>Offset: 0x00516810
    /// void __thiscall CPhysicsObj::update_object(CPhysicsObj*)</code>
    /// </summary>
    public void update_object() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, void>)0x00516810)(ref this);

    /// <summary>
    /// Attempts to set the object's position by applying random offsets within the specified X and Y radii,
    /// repeating up to the maximum number of tries defined in the SetPositionStruct until successful or all attempts fail.
    /// 
    /// <code>Offset: 0x00516A00
    /// SetPositionError __thiscall CPhysicsObj::SetScatterPositionInternal(CPhysicsObj*,const SetPositionStruct*,CTransition*)</code>
    /// </summary>
    /// <param name="sps">Structure containing the desired base position, offset radii, and maximum retry count.</param>
    /// <param name="transit">Transition data used during the internal position set operation.</param>
    /// <returns>OK_SPE if the position was successfully updated; otherwise a failure error code such as GENERAL_FAILURE_SPE.</returns>
    public ACBindings.Internal.SetPositionError SetScatterPositionInternal(ACBindings.Internal.SetPositionStruct* sps, ACBindings.Internal.CTransition* transit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.SetPositionStruct*, ACBindings.Internal.CTransition*, ACBindings.Internal.SetPositionError>)0x00516A00)(ref this, sps, transit);

    /// <summary>Sets the physics object's position using data from SetPositionStruct and optional transition context, applying scatter handling when relevant flag bits are set.
    /// <code>Offset: 0x00516B40
    /// SetPositionError __thiscall CPhysicsObj::SetPositionInternal(CPhysicsObj*,const SetPositionStruct*,CTransition*)</code>
    /// </summary>
    /// <param name="this">The CPhysicsObj instance whose position is being updated.</param>
    /// <param name="sps">Structure containing target position, orientation, and flags that control scattering behavior.</param>
    /// <param name="transit">Transition information used for moving between cells or handling sphere paths.</param>
    /// <returns>SetPositionError indicating the success or failure of the operation.</returns>
    public ACBindings.Internal.SetPositionError SetPositionInternal(ACBindings.Internal.SetPositionStruct* sps, ACBindings.Internal.CTransition* transit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.SetPositionStruct*, ACBindings.Internal.CTransition*, ACBindings.Internal.SetPositionError>)0x00516B40)(ref this, sps, transit);

    /// <summary>Sets the object's position according to the supplied SetPositionStruct, creating a transition that incorporates any collision spheres before delegating to internal logic.
    /// <code>Offset: 0x00516BC0
    /// SetPositionError __thiscall CPhysicsObj::SetPosition(CPhysicsObj*,SetPositionStruct*)</code>
    /// </summary>
    /// <param name="sps">Structure containing target position, movement flags, and optional ray/rotation data.</param>
    /// <returns>SetPositionError code from the underlying SetPositionInternal call.</returns>
    public ACBindings.Internal.SetPositionError SetPosition(ACBindings.Internal.SetPositionStruct* sps) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.SetPositionStruct*, ACBindings.Internal.SetPositionError>)0x00516BC0)(ref this, sps);

    /// <summary>Enters the physics simulation world by initializing position data, updating timestamps, and notifying associated components such as part arrays and movement managers.
    /// <code>Offset: 0x00516C70
    /// int __thiscall CPhysicsObj::enter_world(CPhysicsObj*,const int)</code>
    /// </summary>
    /// <param name="slide">If non‑zero, forces a sliding state; otherwise uses normal entry behavior.</param>
    /// <returns>Non‑zero on success; returns zero if the object already has a parent or if setting its position fails.</returns>
    public int enter_world(int slide) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int, int>)0x00516C70)(ref this, slide);

    /// <summary>Re-enters the physics object into the world by preparing it and setting its position with visibility flags.
    /// <code>Offset: 0x00516D50
    /// int __thiscall CPhysicsObj::reenter_visibility(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>Zero if the re‑entering succeeds, otherwise a non‑zero value (usually one).</returns>
    public int reenter_visibility() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00516D50)(ref this);

    /// <summary>Sets the object's position using the supplied Position data, optionally allowing sliding behavior.
    /// <code>Offset: 0x00516DB0
    /// SetPositionError __thiscall CPhysicsObj::SetPositionSimple(CPhysicsObj*,const Position*,int)</code>
    /// </summary>
    /// <param name="p">The Position structure containing target coordinates and orientation for this object.</param>
    /// <param name="sliding">Non‑zero enables sliding; zero disables it.</param>
    /// <returns>A SetPositionError value indicating whether the position update succeeded or failed.</returns>
    public ACBindings.Internal.SetPositionError SetPositionSimple(ACBindings.Internal.Position* p, int sliding) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, int, ACBindings.Internal.SetPositionError>)0x00516DB0)(ref this, p, sliding);

    /// <summary>Places the physics object into the world at the specified position.
    /// <code>Offset: 0x00516E10
    /// int __thiscall CPhysicsObj::enter_world(CPhysicsObj*,const Position*)</code>
    /// </summary>
    /// <param name="p">The desired position for the object within its cell.</param>
    /// <returns>An integer status code indicating whether the operation succeeded.</returns>
    public int enter_world(ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, int>)0x00516E10)(ref this, p);

    /// <summary>Attempts to reposition the physics object toward a target position; if the provided timestamp is newer than the object's last update or the object has no cell, performs an instantaneous teleport instead.
    /// <code>Offset: 0x00516E30
    /// int __thiscall CPhysicsObj::MoveOrTeleport(CPhysicsObj*,Position*,unsigned __int16,int,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="this">The physics object being moved or teleported.</param>
    /// <param name="p">Target position for movement or teleportation.</param>
    /// <param name="teleport_timestamp">Timestamp used to determine whether the operation should be treated as a teleport event.</param>
    /// <param name="contact">Non‑zero indicates movement is allowed when not teleporting; zero causes an early exit.</param>
    /// <param name="velocity">Velocity vector supplied for potential future use (currently unused).</param>
    /// <returns>1 if the object was moved or teleported successfully, 0 otherwise.</returns>
    public int MoveOrTeleport(ACBindings.Internal.Position* p, ushort teleport_timestamp, int contact, ACBindings.Internal.AC1Legacy.Vector3* velocity) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, ACBindings.Internal.Position*, ushort, int, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00516E30)(ref this, p, teleport_timestamp, contact, velocity);

    /// <summary>Determines whether the physics object is currently touching the ground.
    /// <code>Offset: 0x00528730
    /// int __thiscall CPhysicsObj::on_ground(CPhysicsObj*)</code>
    /// </summary>
    /// <returns>Non‑zero if both the first and second transient state bits are set, indicating ground contact; zero otherwise.</returns>
    public int on_ground() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysicsObj, int>)0x00528730)(ref this);
}

