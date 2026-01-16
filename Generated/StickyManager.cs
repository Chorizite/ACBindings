namespace ACBindings.Internal;


/// <summary>Manages a sticky target in the physics simulation, storing its identifier, radius, position, associated physics object, initialization state, and timeout threshold.</summary>
public unsafe struct StickyManager : System.IDisposable
{
    // Members
    public uint target_id;
    public float target_radius;
    public ACBindings.Internal.Position target_position;
    public ACBindings.Internal.CPhysicsObj* physics_obj;
    public int initialized;
    public double sticky_timeout_time;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Adjusts the supplied frame’s origin and heading so that it points toward the StickyManager’s target while respecting physics constraints and time-step limits. The method computes the vector from the manager’s physics object to its target (another object or stored position), converts this offset to local coordinates, clamps its magnitude based on the maximum speed multiplied by the quantum, normalizes very small vectors, and finally updates the frame’s heading accordingly.
    /// <code>Offset: 0x00556050
    /// void __thiscall StickyManager::adjust_offset(StickyManager*,Frame*,long double)</code>
    /// </summary>
    /// <param name="offset">The Frame whose origin and heading are modified to align with the target.</param>
    /// <param name="quantum">A time-step value used to scale movement limits when clamping the offset magnitude.</param>
    public void adjust_offset(ACBindings.Internal.Frame* offset, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StickyManager, ACBindings.Internal.Frame*, double, void>)0x00556050)(ref this, offset, quantum);

    /// <summary>Clears the current physics target and resets all internal state of a StickyManager instance to its default configuration.
    /// <code>Offset: 0x00556270
    /// void __thiscall StickyManager::Destroy(StickyManager*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StickyManager, void>)0x00556270)(ref this);

    /// <summary>Assigns a physics object to the sticky manager, destroying any existing assignment before setting the new one.
    /// <code>Offset: 0x00556300
    /// void __thiscall StickyManager::SetPhysicsObject(StickyManager*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="new_physobj">The physics object to associate with this manager.</param>
    public void SetPhysicsObject(ACBindings.Internal.CPhysicsObj* new_physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StickyManager, ACBindings.Internal.CPhysicsObj*, void>)0x00556300)(ref this, new_physobj);

    /// <summary>Assigns a new sticky target to the physics object, clearing any existing target and setting a timeout before stickiness takes effect.
    /// <code>Offset: 0x00556330
    /// void __thiscall StickyManager::StickTo(StickyManager*,unsigned int,float,float)</code>
    /// </summary>
    /// <param name="target_id">Identifier of the object to which this manager will stick.</param>
    /// <param name="target_radius">Radius within which the physics object should initiate sticking behavior.</param>
    /// <param name="target_height">Height offset for potential future use; currently ignored by this function.</param>
    public void StickTo(uint target_id, float target_radius, float target_height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StickyManager, uint, float, float, void>)0x00556330)(ref this, target_id, target_radius, target_height);

    /// <summary>Updates the sticky manager’s target data when a matching TargetInfo is received, initializing or clearing state based on the target’s status.
    /// <code>Offset: 0x005563A0
    /// void __thiscall StickyManager::HandleUpdateTarget(StickyManager*,TargetInfo)</code>
    /// </summary>
    /// <param name="target_info">Information about the target to update, including its ID, position, and status.</param>
    public void HandleUpdateTarget(ACBindings.Internal.TargetInfo target_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StickyManager, ACBindings.Internal.TargetInfo, void>)0x005563A0)(ref this, target_info);

    /// <summary>Destroys a StickyManager instance by releasing resources and resetting its position object's virtual table.
    /// <code>Offset: 0x00556400
    /// void __thiscall StickyManager::~StickyManager(StickyManager*)</code>
    /// </summary>
    /// <param name="this">Pointer to the StickyManager object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StickyManager, void>)0x00556400)(ref this);

    /// <summary>Create a new StickyManager and associate it with the given physics object.
    /// <code>Offset: 0x00556420
    /// StickyManager* __cdecl StickyManager::Create(CPhysicsObj*)</code>
    /// </summary>
    /// <param name="physics_obj">The CPhysicsObj that will be linked to the new manager.</param>
    /// <returns>A pointer to the initialized StickyManager or nullptr if memory allocation fails.</returns>
    public static ACBindings.Internal.StickyManager* Create(ACBindings.Internal.CPhysicsObj* physics_obj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.StickyManager*>)0x00556420)(physics_obj);
}

