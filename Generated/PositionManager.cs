namespace ACBindings.Internal;


/// <summary>Coordinates position-related subsystems for a physics object, delegating interpolation, stickiness, and constraint handling through dedicated manager components.</summary>
public unsafe struct PositionManager
{
    // Members
    public ACBindings.Internal.InterpolationManager* interpolation_manager;
    public ACBindings.Internal.StickyManager* sticky_manager;
    public ACBindings.Internal.ConstraintManager* raint_manager;
    public ACBindings.Internal.CPhysicsObj* physics_obj;

    // Methods

    /// <summary>Advances PositionManager's internal systems by applying the current time: updates its interpolation manager, processes constraint notifications, and clears any stuck physics objects whose timeout has elapsed.
    /// <code>Offset: 0x00555D80
    /// void __thiscall PositionManager::UseTime(PositionManager*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, void>)0x00555D80)(ref this);

    /// <summary>Adjusts the positional offset for the current position manager by delegating to its interpolation, sticky, and constraint managers if they exist.
    /// <code>Offset: 0x00555DB0
    /// void __thiscall PositionManager::adjust_offset(PositionManager*,Frame*,long double)</code>
    /// </summary>
    /// <param name="this">The PositionManager instance whose offset is being modified.</param>
    /// <param name="offset">A Frame structure containing quaternion rotation data, a 3x3 matrix, and an origin vector that represent the desired positional change.</param>
    /// <param name="quantum">A long double value specifying the magnitude or scaling factor for applying the offset to each manager.</param>
    public void adjust_offset(ACBindings.Internal.Frame* offset, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, ACBindings.Internal.Frame*, double, void>)0x00555DB0)(ref this, offset, quantum);

    /// <summary>Removes any current stick relationship by clearing the target ID, resetting initialization flags, and cancelling pending physics movements.
    /// <code>Offset: 0x00555E00
    /// void __thiscall PositionManager::UnStick(PositionManager*)</code>
    /// </summary>
    public void UnStick() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, void>)0x00555E00)(ref this);

    /// <summary>Interpolates the physics object toward a target position, creating an interpolation manager if necessary and preserving heading when requested.
    /// <code>Offset: 0x00555E10
    /// void __thiscall PositionManager::InterpolateTo(PositionManager*,const Position*,int)</code>
    /// </summary>
    /// <param name="p">Target position for the interpolation.</param>
    /// <param name="keep_heading">True to maintain current orientation during interpolation; false to allow rotation to match the new position.</param>
    public void InterpolateTo(ACBindings.Internal.Position* p, int keep_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, ACBindings.Internal.Position*, int, void>)0x00555E10)(ref this, p, keep_heading);

    /// <summary>Halts any active interpolation managed by the position manager.
    /// <code>Offset: 0x00555E40
    /// void __thiscall PositionManager::StopInterpolating(PositionManager*)</code>
    /// </summary>
    public void StopInterpolating() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, void>)0x00555E40)(ref this);

    /// <summary>Creates a sticky manager for the physics object if necessary and attaches it to the target identified by <paramref name="object_id"/>, maintaining separation within <paramref name="radius"/> and vertical offset up to <paramref name="height"/>.
    /// <code>Offset: 0x00555E50
    /// void __thiscall PositionManager::StickTo(PositionManager*,unsigned int,float,float)</code>
    /// </summary>
    /// <param name="object_id">Identifier of the target object to which the physics object will stick.</param>
    /// <param name="radius">Maximum distance allowed between the physics object and the target while sticking.</param>
    /// <param name="height">Vertical offset or tolerance applied during the sticking operation.</param>
    public void StickTo(uint object_id, float radius, float height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, uint, float, float, void>)0x00555E50)(ref this, object_id, radius, height);

    /// <summary>Disables constraints on the manager’s ConstraintManager if one is attached.
    /// <code>Offset: 0x00555ED0
    /// void __thiscall PositionManager::UnConstrain(PositionManager*)</code>
    /// </summary>
    public void UnConstrain() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, void>)0x00555ED0)(ref this);

    /// <summary>Create a PositionManager for the specified CPhysicsObj, initializing internal fields and linking back to the object.
    /// <code>Offset: 0x00555EF0
    /// PositionManager* __cdecl PositionManager::Create(CPhysicsObj*)</code>
    /// </summary>
    /// <param name="physics_obj">The physics object to manage positions for.</param>
    /// <returns>Pointer to the newly created PositionManager instance, or null if allocation fails.</returns>
    public static ACBindings.Internal.PositionManager* Create(ACBindings.Internal.CPhysicsObj* physics_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.PositionManager*>)0x00555EF0)(physics_obj);

    /// <summary>Detaches and deletes the interpolation, sticky, and constraint managers owned by this PositionManager instance, clearing all internal references.
    /// <code>Offset: 0x00555F60
    /// void __thiscall PositionManager::Destroy(PositionManager*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, void>)0x00555F60)(ref this);

    /// <summary>Forwards updated target information to the sticky manager component if one is attached.
    /// <code>Offset: 0x00555FF0
    /// void __thiscall PositionManager::HandleUpdateTarget(PositionManager*,TargetInfo)</code>
    /// </summary>
    /// <param name="target_info">Target data containing context ID, object ID, radius, quantum, positions, heading, velocity and status to be processed by the position system.</param>
    public void HandleUpdateTarget(ACBindings.Internal.TargetInfo target_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionManager, ACBindings.Internal.TargetInfo, void>)0x00555FF0)(ref this, target_info);
}

