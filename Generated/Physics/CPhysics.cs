namespace ACBindings.Internal;


/// <summary>Coordinates physics simulation state, linking the object maintenance system, spatial context, and active player reference.</summary>
/// <field name="obj_maint">Central object maintenance system holding all physics objects.</field>
/// <field name="smartbox">Spatial container providing rendering callbacks for physics interactions.</field>
/// <field name="player">Active player physics object, if any.</field>
/// <field name="iter">Iterator over physics objects used during simulation updates.</field>
public unsafe struct CPhysics : System.IDisposable
{
    // Statics
    public static ACBindings.Internal.AC1Legacy.SmartArray___CPhysicsObj_ptr* static_animating_objects = (ACBindings.Internal.AC1Legacy.SmartArray___CPhysicsObj_ptr*)0x00842C50;
    public static ACBindings.Internal.AC1Legacy.SmartArray___GfxVelocityDesc_ptr* texture_velocity_gids = (ACBindings.Internal.AC1Legacy.SmartArray___GfxVelocityDesc_ptr*)0x00842C5C;

    // Members
    public ACBindings.Internal.CObjectMaint* obj_maint;
    public ACBindings.Internal.SmartBox* smartbox;
    public ACBindings.Internal.CPhysicsObj* player;
    public System.IntPtr iter;

    // Generated Constructor
    public CPhysics(ACBindings.Internal.CObjectMaint* obj_maint, ACBindings.Internal.SmartBox* smartbox) {
        _ConstructorInternal(obj_maint, smartbox);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Updates the specified physics object's movement state using the supplied data buffer, applying only newer timestamps and respecting autonomy rules.
    /// <code>Offset: 0x0050A160
    /// int __thiscall CPhysics::SetObjectMovement(CPhysics*,CPhysicsObj*,void*,unsigned int,unsigned __int16,unsigned __int16,int)</code>
    /// </summary>
    /// <param name="object">The physics object whose motion is being updated.</param>
    /// <param name="buff">Pointer to a packed movement data block.</param>
    /// <param name="size">Size of the packed movement data in bytes.</param>
    /// <param name="movement_timestamp">Timestamp indicating when the movement was generated.</param>
    /// <param name="server_control_timestamp">Server-side timestamp used for ordering autonomous movements.</param>
    /// <param name="autonomous">Flag specifying whether the movement is autonomous (non-client-controlled).</param>
    /// <returns>1 if a client-originated movement was applied; 0 otherwise.</returns>
    public int SetObjectMovement(ACBindings.Internal.CPhysicsObj* object_, System.IntPtr buff, uint size, ushort movement_timestamp, ushort server_control_timestamp, int autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysics, ACBindings.Internal.CPhysicsObj*, System.IntPtr, uint, ushort, ushort, int, int>)0x0050A160)(ref this, object_, buff, size, movement_timestamp, server_control_timestamp, autonomous);

    /// <summary>Removes a physics object from the static animating objects list by swapping it with the last entry and decreasing the total count.
    /// <code>Offset: 0x0050A230
    /// void __cdecl CPhysics::RemoveStaticAnimatingObject(CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The <c>CPhysicsObj</c> instance to be removed from the list.</param>
    public static void RemoveStaticAnimatingObject(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, void>)0x0050A230)(object_);

    /// <summary>Applies movement information to the specified physics object using data read from the supplied buffer.
    /// <code>Offset: 0x0050A260
    /// int __thiscall CPhysics::SetObjectMovement(CPhysics*,CPhysicsObj*,void*,unsigned int)</code>
    /// </summary>
    /// <param name="object">Physics object whose movement state will be updated.</param>
    /// <param name="buff">Pointer to a raw buffer containing serialized movement data, including a timestamp and additional parameters.</param>
    /// <param name="size">Number of bytes in the buffer.</param>
    /// <returns>Integer status code; non‑zero indicates success while zero or negative values represent failure.</returns>
    public int SetObjectMovement(ACBindings.Internal.CPhysicsObj* object_, System.IntPtr buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysics, ACBindings.Internal.CPhysicsObj*, System.IntPtr, uint, int>)0x0050A260)(ref this, object_, buff, size);

    /// <summary>Updates texture‑velocity offsets for all registered graphics objects using the supplied elapsed time, applying wrap‑around when a full cycle is reached.
    /// <code>Offset: 0x0050A2F0
    /// void __cdecl CPhysics::UpdateTexVelocity(float)</code>
    /// </summary>
    /// <param name="time_delta">Time elapsed since the last update; used to scale velocity offsets and advance accumulated values.</param>
    public static void UpdateTexVelocity(float time_delta) => ((delegate* unmanaged[Cdecl]<float, void>)0x0050A2F0)(time_delta);

    /// <summary>Releases resources held by the physics system, freeing allocated texture velocity GIDs and iterator data.
    /// <code>Offset: 0x0050A3E0
    /// void __thiscall CPhysics::~CPhysics(CPhysics*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysics, void>)0x0050A3E0)(ref this);

    /// <summary>Advances the physics simulation when at least MIN_QUANTUM_93 seconds have elapsed since the last update, updating all active physics objects, invoking player callbacks, animating static objects, and adjusting texture velocities. If no time has passed or a negative delta occurs, only the timestamp is refreshed.
    /// <code>Offset: 0x0050A420
    /// void __thiscall CPhysics::UseTime(CPhysics*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysics, void>)0x0050A420)(ref this);

    /// <summary>Initializes a physics engine instance by linking it to the object maintenance system and the SmartBox, resetting the player reference, creating an iterator over existing physics objects, and recording the current simulation time.
    /// <code>Offset: 0x0050A530
    /// void __thiscall CPhysics::CPhysics(CPhysics*,CObjectMaint*,SmartBox*)</code>
    /// </summary>
    /// <param name="obj_maint">Reference to the central object maintenance manager that holds all physics objects.</param>
    /// <param name="smartbox">SmartBox instance providing spatial context and rendering callbacks for the physics system.</param>
    public void _ConstructorInternal(ACBindings.Internal.CObjectMaint* obj_maint, ACBindings.Internal.SmartBox* smartbox) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPhysics, ACBindings.Internal.CObjectMaint*, ACBindings.Internal.SmartBox*, void>)0x0050A530)(ref this, obj_maint, smartbox);

    /// <summary>Adds a physics object to the static animating objects array, ensuring no duplicate entries by removing any existing instance before insertion and expanding storage as needed.
    /// <code>Offset: 0x0050A5C0
    /// void __cdecl CPhysics::AddStaticAnimatingObject(CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The CPhysicsObj to be added to the list of static animating objects.</param>
    public static void AddStaticAnimatingObject(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, void>)0x0050A5C0)(object_);

    /// <summary>Adds or updates a graphical velocity entry identified by the provided ID, setting its horizontal and vertical offsets. If both offsets are zero, removes any existing entry for that ID.
    /// <code>Offset: 0x0050A630
    /// void __cdecl CPhysics::AddGfxVelocity(int,float,float)</code>
    /// </summary>
    /// <param name="a1">Identifier of the texture or material to modify.</param>
    /// <param name="a2">Horizontal offset (u) component of the velocity.</param>
    /// <param name="a3">Vertical offset (v) component of the velocity.</param>
    public static void AddGfxVelocity(int a1, float a2, float a3) => ((delegate* unmanaged[Cdecl]<int, float, float, void>)0x0050A630)(a1, a2, a3);
}

