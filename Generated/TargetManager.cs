namespace ACBindings.Internal;


/// <summary>Manages the state of a target entity within the simulation, linking its physics object to associated metadata and tracking update timing. Provides observer support via a voyeur table for external systems.</summary>
public unsafe struct TargetManager : System.IDisposable
{
    // Members
    public ACBindings.Internal.CPhysicsObj* physobj;
    public ACBindings.Internal.TargetInfo* target_info;
    public System.IntPtr voyeur_table;
    public double last_update_time;

    // Generated Constructor
    public TargetManager(ACBindings.Internal.CPhysicsObj* object_) {
        _ConstructorInternal(object_);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a TargetManager with the given CPhysicsObj, resetting target information, voyeur table, and last update time.
    /// <code>Offset: 0x0051AF50
    /// void __thiscall TargetManager::TargetManager(TargetManager*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object that will be managed by this instance.</param>
    public void _ConstructorInternal(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, ACBindings.Internal.CPhysicsObj*, void>)0x0051AF50)(ref this, object_);

    /// <summary>Assigns a new quantum value to the current target and updates its physics representation accordingly.
    /// <code>Offset: 0x0051B040
    /// void __thiscall TargetManager::SetTargetQuantum(TargetManager*,long double)</code>
    /// </summary>
    /// <param name="new_quantum">The desired quantum value for the target.</param>
    public void SetTargetQuantum(double new_quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, double, void>)0x0051B040)(ref this, new_quantum);

    /// <summary>Updates a voyeur’s last sent position using the supplied target location, builds a TargetInfo packet containing current physics data, and forwards it to the associated object if available.
    /// <code>Offset: 0x0051B090
    /// void __thiscall TargetManager::SendVoyeurUpdate(TargetManager*,TargettedVoyeurInfo*,const Position*,TargetStatus)</code>
    /// </summary>
    /// <param name="this">Reference to the manager handling target updates.</param>
    /// <param name="voyeur">Structure representing the voyeur being updated.</param>
    /// <param name="p">New position information for the target.</param>
    /// <param name="status">Current status of the target.</param>
    public void SendVoyeurUpdate(ACBindings.Internal.TargettedVoyeurInfo* voyeur, ACBindings.Internal.Position* p, ACBindings.Internal.TargetStatus status) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, ACBindings.Internal.TargettedVoyeurInfo*, ACBindings.Internal.Position*, ACBindings.Internal.TargetStatus, void>)0x0051B090)(ref this, voyeur, p, status);

    /// <summary>Computes the position of a target after advancing by the specified time quantum using its current velocity and writes the result into the supplied Position structure.
    /// <code>Offset: 0x0051B180
    /// void __thiscall TargetManager::GetInterpolatedPosition(TargetManager*,long double,Position*)</code>
    /// </summary>
    /// <param name="quantum">The amount of time over which to advance the target.</param>
    /// <param name="p">Output parameter receiving the interpolated Position, including cell ID and frame data.</param>
    public void GetInterpolatedPosition(double quantum, ACBindings.Internal.Position* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, double, ACBindings.Internal.Position*, void>)0x0051B180)(ref this, quantum, p);

    /// <summary>Checks whether a target’s current interpolated position differs from its last sent position by more than the specified radius and sends an update if necessary.
    /// <code>Offset: 0x0051B1F0
    /// void __thiscall TargetManager::CheckAndUpdateVoyeur(TargetManager*,TargettedVoyeurInfo*)</code>
    /// </summary>
    /// <param name="voyeur">The targetted voyeur information, including quantum time, last sent position, and radius threshold.</param>
    public void CheckAndUpdateVoyeur(ACBindings.Internal.TargettedVoyeurInfo* voyeur) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, ACBindings.Internal.TargettedVoyeurInfo*, void>)0x0051B1F0)(ref this, voyeur);

    /// <summary>Notifies every voyeur registered in the manager about a change in target status, broadcasting the target’s current position along with the event.
    /// <code>Offset: 0x0051B290
    /// void __thiscall TargetManager::NotifyVoyeurOfEvent(TargetManager*,TargetStatus)</code>
    /// </summary>
    /// <param name="event">The target status that triggered the notification.</param>
    public void NotifyVoyeurOfEvent(ACBindings.Internal.TargetStatus event_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, ACBindings.Internal.TargetStatus, void>)0x0051B290)(ref this, event_);

    /// <summary>Clears the current target data and removes any voyeur link between the manager’s physics object and the previously targeted object.
    /// <code>Offset: 0x0051B310
    /// void __thiscall TargetManager::ClearTarget(TargetManager*)</code>
    /// </summary>
    public void ClearTarget() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, void>)0x0051B310)(ref this);

    /// <summary>Adds or updates a voyeur entry for the specified object ID with the given detection radius and quantum interval. If the internal voyeur table does not exist, it initializes the hash table before inserting the new entry.
    /// <code>Offset: 0x0051B360
    /// void __thiscall TargetManager::AddVoyeur(TargetManager*,unsigned int,float,long double)</code>
    /// </summary>
    /// <param name="object_id">The identifier of the object for which a voyeur is added or updated.</param>
    /// <param name="radius">The detection radius within which the voyeur will be notified of changes.</param>
    /// <param name="quantum">The time interval between successive updates to the voyeur.</param>
    public void AddVoyeur(uint object_id, float radius, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, uint, float, double, void>)0x0051B360)(ref this, object_id, radius, quantum);

    /// <summary>Updates internal target data with a new TargetInfo, recalculating positions and heading, notifying the physics system, and clearing the target if it has exited the world.
    /// <code>Offset: 0x0051B460
    /// void __thiscall TargetManager::ReceiveUpdate(TargetManager*,const TargetInfo*)</code>
    /// </summary>
    /// <param name="target_update">Incoming target information; applied only when its object ID matches the stored one.</param>
    public void ReceiveUpdate(ACBindings.Internal.TargetInfo* target_update) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, ACBindings.Internal.TargetInfo*, void>)0x0051B460)(ref this, target_update);

    /// <summary>Updates target status and processes voyeur entries when at least half a second has elapsed since the last update.
    /// <code>Offset: 0x0051B5C0
    /// void __thiscall TargetManager::HandleTargetting(TargetManager*)</code>
    /// </summary>
    public void HandleTargetting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, void>)0x0051B5C0)(ref this);

    /// <summary>Destroys a TargetManager instance by releasing its target information and clearing the voyeur table resources.
    /// <code>Offset: 0x0051B700
    /// void __thiscall TargetManager::~TargetManager(TargetManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, void>)0x0051B700)(ref this);

    /// <summary>Sets or clears this manager's current target based on context ID and object ID, configuring radius and quantum parameters while managing associated physics voyeur relationships.
    /// <code>Offset: 0x0051B760
    /// void __thiscall TargetManager::SetTarget(TargetManager*,unsigned int,unsigned int,float,long double)</code>
    /// </summary>
    /// <param name="context_id">Identifier used to associate the target with a specific context (e.g., player or camera).</param>
    /// <param name="object_id">Physics object's identifier to be targeted; if zero, the target is cleared and marked as timed out.</param>
    /// <param name="radius">Search or influence radius applied when adding voyeur relationships.</param>
    /// <param name="quantum">Additional parameter passed to the physics system for the voyeur relationship.</param>
    public void SetTarget(uint context_id, uint object_id, float radius, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetManager, uint, uint, float, double, void>)0x0051B760)(ref this, context_id, object_id, radius, quantum);
}

