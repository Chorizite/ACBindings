namespace ACBindings.Internal;


/// <summary>Coordinates motion interpolation, target navigation, physics interaction, and state updates for a game entity.</summary>
public unsafe struct MovementManager
{
    // Members
    public ACBindings.Internal.CMotionInterp* motion_interpreter;
    public ACBindings.Internal.MoveToManager* moveto_manager;
    public ACBindings.Internal.CPhysicsObj* physics_obj;
    public ACBindings.Internal.CWeenieObject* weenie_obj;

    // Methods

    /// <summary>Creates a MoveToManager for this MovementManager if one does not already exist.
    /// <code>Offset: 0x00524C00
    /// void __thiscall MovementManager::MakeMoveToManager(MovementManager*)</code>
    /// </summary>
    public void MakeMoveToManager() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void>)0x00524C00)(ref this);

    /// <summary>Associates a CWeenieObject with the MovementManager, updating its internal reference and synchronizing dependent components such as the motion interpreter and move‑to manager.
    /// <code>Offset: 0x00524C20
    /// void __thiscall MovementManager::SetWeenieObject(MovementManager*,CWeenieObject*)</code>
    /// </summary>
    /// <param name="weenie_obj">The CWeenieObject to associate with this manager.</param>
    public void SetWeenieObject(ACBindings.Internal.CWeenieObject* weenie_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, ACBindings.Internal.CWeenieObject*, void>)0x00524C20)(ref this, weenie_obj);

    /// <summary>Creates a MovementManager instance linking the specified physics and weenie objects.
    /// <code>Offset: 0x00524C50
    /// MovementManager* __cdecl MovementManager::Create(CPhysicsObj*,CWeenieObject*)</code>
    /// </summary>
    /// <param name="physics_obj">Physics object to control movement for.</param>
    /// <param name="weenie_obj">Weenie object associated with the movement manager.</param>
    /// <returns>Pointer to a new MovementManager, or null if allocation fails.</returns>
    public static ACBindings.Internal.MovementManager* Create(ACBindings.Internal.CPhysicsObj* physics_obj, ACBindings.Internal.CWeenieObject* weenie_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.MovementManager*>)0x00524C50)(physics_obj, weenie_obj);

    /// <summary>Executes a movement request by activating the associated physics object and dispatching the command to either the motion interpreter or move‑to manager based on the movement type. Returns an unsigned status code, with 71 indicating an unsupported movement type.
    /// <code>Offset: 0x00524CD0
    /// unsigned int __thiscall MovementManager::PerformMovement(MovementManager*,const MovementStruct*)</code>
    /// </summary>
    /// <param name="movement_struct">The movement instruction detailing type and parameters for the action.</param>
    /// <returns>Unsigned integer status code: zero indicates success; non‑zero values represent errors (e.g., 71 for unknown movement type).</returns>
    public uint PerformMovement(ACBindings.Internal.MovementStruct* movement_struct) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, ACBindings.Internal.MovementStruct*, uint>)0x00524CD0)(ref this, movement_struct);

    /// <summary>Switches the movement manager's motion interpreter to the specified interpreted state, creating and initializing the interpreter if it does not already exist.
    /// <code>Offset: 0x00524D70
    /// void __thiscall MovementManager::move_to_interpreted_state(MovementManager*,const InterpretedMotionState*)</code>
    /// </summary>
    /// <param name="state">The target motion state containing style, commands, speeds, and actions.</param>
    public void move_to_interpreted_state(ACBindings.Internal.InterpretedMotionState* state) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, ACBindings.Internal.InterpretedMotionState*, void>)0x00524D70)(ref this, state);

    /// <summary>Cancels the active move‑to request through the associated MoveToManager, forwarding a specified error code.
    /// <code>Offset: 0x00524DB0
    /// void __thiscall MovementManager::CancelMoveTo(MovementManager*,unsigned int)</code>
    /// </summary>
    /// <param name="err">Code indicating why the move was cancelled.</param>
    public void CancelMoveTo(uint err) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, uint, void>)0x00524DB0)(ref this, err);

    /// <summary>Ensures a motion interpreter exists for the movement manager and activates its default state.
    /// <code>Offset: 0x00524DC0
    /// void __thiscall MovementManager::EnterDefaultState(MovementManager*)</code>
    /// </summary>
    public void EnterDefaultState() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void>)0x00524DC0)(ref this);

    /// <summary>Determines whether the movement manager has an active target and is currently moving toward it.
    /// <code>Offset: 0x00524E60
    /// int __thiscall MovementManager::IsMovingTo(MovementManager*)</code>
    /// </summary>
    /// <returns>Non‑zero when a move‑to operation is in progress; zero otherwise.</returns>
    public int IsMovingTo() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, int>)0x00524E60)(ref this);

    /// <summary>Determines whether the movement manager has any pending motions to process.
    /// <code>Offset: 0x00524E80
    /// int __thiscall MovementManager::motions_pending(MovementManager*)</code>
    /// </summary>
    /// <returns>Non‑zero if there are pending motions; zero otherwise.</returns>
    public int motions_pending() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, int>)0x00524E80)(ref this);

    /// <summary>Processes queued movement actions for the associated MoveToManager during a time update, handling turn‑to‑heading or move‑to‑position based on the physics object's transient state.
    /// <code>Offset: 0x00524EF0
    /// void __thiscall MovementManager::UseTime(MovementManager*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void>)0x00524EF0)(ref this);

    /// <summary>Handles landing logic for a movement object, updating its motion interpolator and progressing to the next navigation node when appropriate.
    /// <code>Offset: 0x00524F00
    /// void __thiscall MovementManager::HitGround(MovementManager*)</code>
    /// </summary>
    public void HitGround() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void>)0x00524F00)(ref this);

    /// <summary>Leaves the grounded state by invoking the motion interpreter’s leave logic and notifying the move‑to manager of a prior spell selection.
    /// <code>Offset: 0x00524F20
    /// void __thiscall MovementManager::LeaveGround(MovementManager*)</code>
    /// </summary>
    public void LeaveGround() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void>)0x00524F20)(ref this);

    /// <summary>Handles world entry by forwarding a previous spell selection notice to the motion interpreter, if present.
    /// <code>Offset: 0x00524F40
    /// void __thiscall MovementManager::HandleEnterWorld(MovementManager*)</code>
    /// </summary>
    public void HandleEnterWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void>)0x00524F40)(ref this);

    /// <summary>Cleans up the movement manager by removing all pending motions, unbinding any attached physics objects, clearing motion actions, and freeing the linked list nodes before the entity leaves the game world.
    /// <code>Offset: 0x00524F50
    /// void __thiscall MovementManager::HandleExitWorld(MovementManager*)</code>
    /// </summary>
    public void HandleExitWorld() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void>)0x00524F50)(ref this);

    /// <summary>Destroys the movement manager by cleaning up its motion interpreter and move‑to manager, invoking their destructors, deallocating memory, and setting internal pointers to null.
    /// <code>Offset: 0x00524FF0
    /// void __thiscall MovementManager::Destroy(MovementManager*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void>)0x00524FF0)(ref this);

    /// <summary>Unpacks movement data from the supplied buffer, interprets the motion command, and applies it to the associated physics object and move‑to manager.
    /// <code>Offset: 0x00525040
    /// int __thiscall MovementManager::unpack_movement(MovementManager*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a pointer referencing the start of the data buffer; advanced as bytes are consumed during unpacking.</param>
    /// <param name="size">Maximum number of bytes remaining in the buffer to read.</param>
    /// <returns>Non‑zero if the packet was successfully processed, zero otherwise.</returns>
    public int unpack_movement(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, void**, uint, int>)0x00525040)(ref this, addr, size);

    /// <summary>Forwards a target update to the associated MoveToManager if it exists.
    /// <code>Offset: 0x00525390
    /// void __thiscall MovementManager::HandleUpdateTarget(MovementManager*,TargetInfo)</code>
    /// </summary>
    /// <param name="target_info">Target information containing context ID, object ID, radius, quantum, positions, heading, velocity, status, and last update time for movement updates.</param>
    public void HandleUpdateTarget(ACBindings.Internal.TargetInfo target_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovementManager, ACBindings.Internal.TargetInfo, void>)0x00525390)(ref this, target_info);
}

