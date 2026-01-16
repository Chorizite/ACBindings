namespace ACBindings.Internal;


/// <summary>Manages movement behavior for a game entity, storing current and target positions, movement parameters, and command state to direct navigation.</summary>
public unsafe struct MoveToManager : System.IDisposable
{
    // Child Types

    /// <summary>
    /// Represents a node within MoveToManager's linked list of movement commands, storing command type, orientation, and list linkage information.
    /// </summary>
    public unsafe struct MovementNode
    {
        // Base Classes
        public ACBindings.Internal.DLListData BaseClass_DLListData; // ACBindings.Internal.DLListData

        // Members
        public ACBindings.Internal.MovementTypes.Type type;
        public float heading;

        // Methods
    }

    // Members
    public ACBindings.Internal.MovementTypes.Type movement_type;
    public ACBindings.Internal.Position sought_position;
    public ACBindings.Internal.Position current_target_position;
    public ACBindings.Internal.Position starting_position;
    public ACBindings.Internal.MovementParameters movement_params;
    public float previous_heading;
    public float previous_distance;
    public double previous_distance_time;
    public float original_distance;
    public double original_distance_time;
    public uint fail_progress_count;
    public uint sought_object_id;
    public uint top_level_object_id;
    public float sought_object_radius;
    public float sought_object_height;
    public uint current_command;
    public uint aux_command;
    public int moving_away;
    public int initialized;
    public ACBindings.Internal.DLList___MoveToManager_MovementNode pending_actions;
    public ACBindings.Internal.CPhysicsObj* physics_obj;
    public ACBindings.Internal.CWeenieObject* weenie_obj;

    // Generated Constructor
    public MoveToManager() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Executes a movement command on the MoveToManager’s associated physics object using supplied parameters, delegating to the motion interpreter.
    /// <code>Offset: 0x00529C20
    /// unsigned int __thiscall MoveToManager::_DoMotion(MoveToManager*,unsigned int,MovementParameters*)</code>
    /// </summary>
    /// <param name="motion">Identifier of the motion to perform.</param>
    /// <param name="params">Parameters controlling speed, heading, hold key, and other motion characteristics.</param>
    /// <returns>Status code returned by CMotionInterp::DoInterpretedMotion; 8 indicates no physics object attached, 11 indicates the physics object lacks a motion interpreter. Other values represent success or additional status codes defined by the motion interpreter.</returns>
    public uint _DoMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, uint, ACBindings.Internal.MovementParameters*, uint>)0x00529C20)(ref this, motion, params_);

    /// <summary>Stops a motion on the MoveToManager's physics object by adjusting parameters and delegating to its motion interpreter, returning a status code.
    /// <code>Offset: 0x00529C90
    /// unsigned int __thiscall MoveToManager::_StopMotion(MoveToManager*,unsigned int,MovementParameters*)</code>
    /// </summary>
    /// <param name="this">The MoveToManager instance whose motion is being stopped.</param>
    /// <param name="motion">Identifier of the motion to stop.</param>
    /// <param name="params">MovementParameters used for adjusting speed and hold key before stopping.</param>
    /// <returns>Status code indicating success or a specific failure (e.g., missing physics object, no interpreter, or result from StopInterpretedMotion).</returns>
    public uint _StopMotion(uint motion, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, uint, ACBindings.Internal.MovementParameters*, uint>)0x00529C90)(ref this, motion, params_);

    /// <summary>Evaluates whether the object has moved at least 0.25 units per second since the last check or since start, updating internal timestamps when a new interval begins.
    /// <code>Offset: 0x00529D00
    /// int __thiscall MoveToManager::CheckProgressMade(MoveToManager*,float)</code>
    /// </summary>
    /// <param name="curr_distance">The current distance from the object to its target location.</param>
    /// <returns>Non‑zero if sufficient progress was detected; otherwise zero.</returns>
    public int CheckProgressMade(float curr_distance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, float, int>)0x00529D00)(ref this, curr_distance);

    /// <summary>Computes the present separation between the associated physics object and its target position. If the object's physics data is unavailable, returns a sentinel value of positive infinity; otherwise, calculates either Euclidean distance or cylinder‑based distance based on movement parameters.
    /// <code>Offset: 0x00529DC0
    /// float __thiscall MoveToManager::GetCurrentDistance(MoveToManager*)</code>
    /// </summary>
    /// <returns>The current distance as a floating‑point value, or FLT_MAX when no physics object exists.</returns>
    public float GetCurrentDistance() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, float>)0x00529DC0)(ref this);

    /// <summary>Determines whether a move-to operation is currently active for this manager instance.
    /// <code>Offset: 0x00529E30
    /// int __thiscall MoveToManager::is_moving_to(MoveToManager*)</code>
    /// </summary>
    /// <returns>True if the current movement type differs from Invalid; otherwise false.</returns>
    public int is_moving_to() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, int>)0x00529E30)(ref this);

    /// <summary>Associates a CWeenieObject with this MoveToManager instance.
    /// <code>Offset: 0x00529E40
    /// void __thiscall MoveToManager::SetWeenieObject(MoveToManager*,CWeenieObject*)</code>
    /// </summary>
    /// <param name="wobj">The CWeenieObject to be managed.</param>
    public void SetWeenieObject(ACBindings.Internal.CWeenieObject* wobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, ACBindings.Internal.CWeenieObject*, void>)0x00529E40)(ref this, wobj);

    /// <summary>Associates a physics object with this move‑to manager.
    /// <code>Offset: 0x00529E50
    /// void __thiscall MoveToManager::SetPhysicsObject(MoveToManager*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="pobj">The physics object to link to the manager.</param>
    public void SetPhysicsObject(ACBindings.Internal.CPhysicsObj* pobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, ACBindings.Internal.CPhysicsObj*, void>)0x00529E50)(ref this, pobj);

    /// <summary>Initializes all internal fields of a MoveToManager object to their default states, clearing movement data, timestamps, and positional information.
    /// <code>Offset: 0x00529E60
    /// void __thiscall MoveToManager::InitializeLocalVariables(MoveToManager*)</code>
    /// </summary>
    public void InitializeLocalVariables() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x00529E60)(ref this);

    /// <summary>Removes the first pending movement action from the list and frees its memory.
    /// <code>Offset: 0x00529F90
    /// void __thiscall MoveToManager::RemovePendingActionsHead(MoveToManager*)</code>
    /// </summary>
    public void RemovePendingActionsHead() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x00529F90)(ref this);

    /// <summary>Initializes a MoveToManager instance, setting up default positions and clearing all movement-related state.
    /// <code>Offset: 0x00529FC0
    /// void __thiscall MoveToManager::MoveToManager(MoveToManager*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x00529FC0)(ref this);

    /// <summary>Creates a MoveToManager instance linked to the specified physics object and weenie object.
    /// <code>Offset: 0x0052A080
    /// MoveToManager* __cdecl MoveToManager::Create(CPhysicsObj*,CWeenieObject*)</code>
    /// </summary>
    /// <param name="physics_obj">Physics component for which movement is managed.</param>
    /// <param name="weenie_obj">Associated game entity.</param>
    /// <returns>A pointer to the initialized MoveToManager, or null if allocation fails.</returns>
    public static ACBindings.Internal.MoveToManager* Create(ACBindings.Internal.CPhysicsObj* physics_obj, ACBindings.Internal.CWeenieObject* weenie_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.MoveToManager*>)0x0052A080)(physics_obj, weenie_obj);

    /// <summary>Destroys a MoveToManager instance by clearing its pending actions list, freeing all allocated nodes, and resetting internal state.
    /// <code>Offset: 0x0052A0C0
    /// void __thiscall MoveToManager::Destroy(MoveToManager*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052A0C0)(ref this);

    /// <summary>Adds a turn-to-heading node to the manager’s pending actions list.
    /// <code>Offset: 0x0052A140
    /// void __thiscall MoveToManager::AddTurnToHeadingNode(MoveToManager*,float)</code>
    /// </summary>
    /// <param name="global_heading">The desired heading angle for the move action.</param>
    public void AddTurnToHeadingNode(float global_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, float, void>)0x0052A140)(ref this, global_heading);

    /// <summary>Adds a new movement node placeholder into the manager’s pending actions list by allocating and linking list data structures.
    /// <code>Offset: 0x0052A190
    /// void __thiscall MoveToManager::AddMoveToPositionNode(MoveToManager*)</code>
    /// </summary>
    public void AddMoveToPositionNode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052A190)(ref this);

    /// <summary>Stops any active or auxiliary movement on the associated physics object, clears its target when appropriate, and resets internal state for future move commands.
    /// <code>Offset: 0x0052A1D0
    /// void __thiscall MoveToManager::CleanUp(MoveToManager*)</code>
    /// </summary>
    public void CleanUp() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052A1D0)(ref this);

    /// <summary>Resets the move‑to manager state and completely stops any physics object associated with it.
    /// <code>Offset: 0x0052A260
    /// void __thiscall MoveToManager::CleanUpAndCallWeenie(MoveToManager*,unsigned int)</code>
    /// </summary>
    /// <param name="status">Status code passed to the cleanup routine; currently unused in this implementation.</param>
    public void CleanUpAndCallWeenie(uint status) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, uint, void>)0x0052A260)(ref this, status);

    /// <summary>Sets up the manager to move a physics‑enabled object toward a target by recording its start position, assigning the desired target ID and size, applying movement parameters, stopping any current motion, and either setting a new destination or cleaning up if the object is already targeted.
    /// <code>Offset: 0x0052A290
    /// void __thiscall MoveToManager::MoveToObject(MoveToManager*,unsigned int,unsigned int,float,float,const MovementParameters*)</code>
    /// </summary>
    /// <param name="object_id">Identifier of the object to approach.</param>
    /// <param name="top_level_id">Identifier for the top‑level context used when assigning or clearing the target.</param>
    /// <param name="object_radius">Radius of the sought object, influencing collision and proximity checks.</param>
    /// <param name="object_height">Height of the sought object.</param>
    /// <param name="params">Pointer to a MovementParameters structure that defines distance, speed, heading, fail conditions, and other movement characteristics.</param>
    public void MoveToObject(uint object_id, uint top_level_id, float object_radius, float object_height, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, uint, uint, float, float, ACBindings.Internal.MovementParameters*, void>)0x0052A290)(ref this, object_id, top_level_id, object_radius, object_height, params_);

    /// <summary>Starts a turning motion toward the specified object, configuring movement parameters and updating the physics object's heading.
    /// <code>Offset: 0x0052A3E0
    /// void __thiscall MoveToManager::TurnToObject(MoveToManager*,unsigned int,unsigned int,const MovementParameters*)</code>
    /// </summary>
    /// <param name="object_id">The identifier of the object to face during the turn.</param>
    /// <param name="top_level_id">The top‑level object ID used to determine whether to set a new target or reset the movement state.</param>
    /// <param name="params">MovementParameters containing desired heading, speed, distance thresholds, and other configuration values for the turn.</param>
    public void TurnToObject(uint object_id, uint top_level_id, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, uint, uint, ACBindings.Internal.MovementParameters*, void>)0x0052A3E0)(ref this, object_id, top_level_id, params_);

    /// <summary>Stops any ongoing movement, clears all queued movement actions, and halts the associated physics object if present.
    /// <code>Offset: 0x0052A540
    /// void __thiscall MoveToManager::CancelMoveTo(MoveToManager*,unsigned int)</code>
    /// </summary>
    public void CancelMoveTo(uint retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, uint, void>)0x0052A540)(ref this, retval);

    /// <summary>Destroys the MoveToManager instance, cleaning up internal data structures and restoring base class virtual tables to their defaults.
    /// <code>Offset: 0x0052A5E0
    /// void __thiscall MoveToManager::~MoveToManager(MoveToManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052A5E0)(ref this);

    /// <summary>Starts forward movement toward the current target by calculating distance and heading, selecting an appropriate motion command, and initiating the action if available. If no command is needed, processes queued actions; otherwise cancels movement when a physics object is missing.
    /// <code>Offset: 0x0052A610
    /// void __thiscall MoveToManager::BeginMoveForward(MoveToManager*)</code>
    /// </summary>
    public void BeginMoveForward() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052A610)(ref this);

    /// <summary>Starts a turn operation toward the heading indicated by the next pending action. Configures motion settings based on current movement parameters and initiates the appropriate turn command, or advances to the following queued action when already aligned within tolerance.
    /// <code>Offset: 0x0052A7A0
    /// void __thiscall MoveToManager::BeginTurnToHeading(MoveToManager*)</code>
    /// </summary>
    public void BeginTurnToHeading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052A7A0)(ref this);

    /// <summary>Processes the next pending movement action in the queue, initiating a turn or forward move according to the node type. If no actions remain, performs cleanup and either stops motion or attaches the object to a target based on movement parameters.
    /// <code>Offset: 0x0052A8C0
    /// void __thiscall MoveToManager::BeginNextNode(MoveToManager*)</code>
    /// </summary>
    public void BeginNextNode() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052A8C0)(ref this);

    /// <summary>
    /// Handles movement of a physics object toward its target position by computing the desired heading, issuing motion commands to align the object, monitoring progress, and canceling or transitioning actions when stalled or completed; additionally adjusts velocity quantum for top‑level objects.
    /// 
    /// <code>Offset: 0x0052A990
    /// void __thiscall MoveToManager::HandleMoveToPosition(MoveToManager*)</code>
    /// </summary>
    public void HandleMoveToPosition() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052A990)(ref this);

    /// <summary>Manages rotation toward a desired heading while processing movement commands, adjusting the physics object’s orientation and advancing queued actions when alignment is achieved.
    /// <code>Offset: 0x0052ACD0
    /// void __thiscall MoveToManager::HandleTurnToHeading(MoveToManager*)</code>
    /// </summary>
    public void HandleTurnToHeading() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, void>)0x0052ACD0)(ref this);

    /// <summary>Stops the object's current motion and initiates a new move toward the given position using the supplied movement parameters, queuing turn and move nodes as needed.
    /// <code>Offset: 0x0052AE50
    /// void __thiscall MoveToManager::MoveToPosition(MoveToManager*,const Position*,const MovementParameters*)</code>
    /// </summary>
    /// <param name="p">The target position for the object to move to.</param>
    /// <param name="params">Movement configuration controlling heading, speed, distance thresholds, and other behavior flags.</param>
    public void MoveToPosition(ACBindings.Internal.Position* p, ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, ACBindings.Internal.Position*, ACBindings.Internal.MovementParameters*, void>)0x0052AE50)(ref this, p, params_);

    /// <summary>Updates the move‑to state of an object, adding turn and move actions based on the current and target positions. It computes heading and distance from the object's physics component, schedules movement nodes if a physics object exists, and otherwise cancels the operation.
    /// <code>Offset: 0x0052B010
    /// void __thiscall MoveToManager::MoveToObject_Internal(MoveToManager*,const Position*,const Position*)</code>
    /// </summary>
    /// <param name="target_position">The destination position the object should ultimately reach.</param>
    /// <param name="interpolated_position">The current or intermediate position used to calculate heading and distance relative to the object's physics state.</param>
    public void MoveToObject_Internal(ACBindings.Internal.Position* target_position, ACBindings.Internal.Position* interpolated_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, ACBindings.Internal.Position*, ACBindings.Internal.Position*, void>)0x0052B010)(ref this, target_position, interpolated_position);

    /// <summary>Adjusts the manager’s heading to face the supplied target position, adding a movement node to the pending actions queue when the physics object is present; otherwise it cancels the current move.
    /// <code>Offset: 0x0052B160
    /// void __thiscall MoveToManager::TurnToObject_Internal(MoveToManager*,const Position*)</code>
    /// </summary>
    /// <param name="target_position">The world position toward which the manager should orient itself.</param>
    public void TurnToObject_Internal(ACBindings.Internal.Position* target_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, ACBindings.Internal.Position*, void>)0x0052B160)(ref this, target_position);

    /// <summary>Sets the movement manager to rotate toward a specified heading using supplied parameters, updating internal state and queuing the action.
    /// <code>Offset: 0x0052B240
    /// void __thiscall MoveToManager::TurnToHeading(MoveToManager*,const MovementParameters*)</code>
    /// </summary>
    /// <param name="params">Movement parameters specifying desired heading, speed, distance thresholds, and context for the turn operation.</param>
    public void TurnToHeading(ACBindings.Internal.MovementParameters* params_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, ACBindings.Internal.MovementParameters*, void>)0x0052B240)(ref this, params_);

    /// <summary>Validates the supplied target against the manager's physics object and updates internal state or cancels movement based on status and movement type.
    /// <code>Offset: 0x0052B3E0
    /// void __thiscall MoveToManager::HandleUpdateTarget(MoveToManager*,const TargetInfo*)</code>
    /// </summary>
    /// <param name="this">The MoveToManager instance whose target is being processed.</param>
    /// <param name="target_info">Information about the updated target, including its ID, position, status, and motion data.</param>
    public void HandleUpdateTarget(ACBindings.Internal.TargetInfo* target_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, ACBindings.Internal.TargetInfo*, void>)0x0052B3E0)(ref this, target_info);

    /// <summary>Executes a movement or turn command based on the supplied MovementStruct, resetting any current motion before initiating the new action.
    /// <code>Offset: 0x0052B510
    /// unsigned int __thiscall MoveToManager::PerformMovement(MoveToManager*,const MovementStruct*)</code>
    /// </summary>
    /// <param name="this">The MoveToManager instance whose physics object will be moved.</param>
    /// <param name="mvs">Structure specifying the type of movement and associated parameters (object id, position, heading, etc.).</param>
    /// <returns>Zero on success; non‑zero may indicate an error (currently always zero).</returns>
    public uint PerformMovement(ACBindings.Internal.MovementStruct* mvs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToManager, ACBindings.Internal.MovementStruct*, uint>)0x0052B510)(ref this, mvs);
}

