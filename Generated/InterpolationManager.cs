namespace ACBindings.Internal;


/// <summary>
/// Manages interpolation of a physics object’s position over time through a queue of nodes, tracks progress and frame counts, maintains the object’s heading, and records failure attempts.
/// </summary>
public unsafe struct InterpolationManager : System.IDisposable
{
    // Statics
    public static int* fUseAdjustedSpeed_ = (int*)0x00820428;

    // Members
    public ACBindings.Internal.LList___InterpolationNode position_queue;
    public ACBindings.Internal.CPhysicsObj* physics_obj;
    public int keep_heading;
    public uint frame_counter;
    public float original_distance;
    public float progress_quantum;
    public int node_fail_counter;
    public ACBindings.Internal.Position blipto_position;

    // Generated Constructor
    public InterpolationManager(ACBindings.Internal.CPhysicsObj* physics_obj) {
        _ConstructorInternal(physics_obj);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes the InterpolationManager for a physics object, setting default values and establishing the starting position at the origin with an identity orientation.
    /// <code>Offset: 0x005564F0
    /// void __thiscall InterpolationManager::InterpolationManager(InterpolationManager*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="physics_obj">The physics object that will be controlled by this interpolation manager.</param>
    public void _ConstructorInternal(ACBindings.Internal.CPhysicsObj* physics_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationManager, ACBindings.Internal.CPhysicsObj*, void>)0x005564F0)(ref this, physics_obj);

    /// <summary>
    /// Creates a new InterpolationManager for the supplied physics object, initializing its state via the constructor.
    /// 
    /// <code>Offset: 0x00556550
    /// InterpolationManager* __cdecl InterpolationManager::Create(CPhysicsObj*)</code>
    /// </summary>
    /// <param name="obj">The CPhysicsObj instance to associate with the interpolation manager.</param>
    /// <returns>Pointer to the newly allocated InterpolationManager, or null if memory allocation fails.</returns>
    public static ACBindings.Internal.InterpolationManager* Create(ACBindings.Internal.CPhysicsObj* obj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.InterpolationManager*>)0x00556550)(obj);

    /// <summary>Halts interpolation processing by clearing the position queue and resetting internal state variables.
    /// <code>Offset: 0x00556570
    /// void __thiscall InterpolationManager::StopInterpolating(InterpolationManager*)</code>
    /// </summary>
    public void StopInterpolating() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationManager, void>)0x00556570)(ref this);

    /// <summary>Handles completion of an interpolation step by removing the finished node, updating internal state, and preparing for the next node or terminating interpolation.
    /// <code>Offset: 0x005565C0
    /// void __thiscall InterpolationManager::NodeCompleted(InterpolationManager*,int)</code>
    /// </summary>
    /// <param name="success">Indicates whether the completed node was reached successfully.</param>
    public void NodeCompleted(int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationManager, int, void>)0x005565C0)(ref this, success);

    /// <summary>Frees all interpolation nodes stored in position_queue, resetting head and tail pointers.
    /// <code>Offset: 0x00556710
    /// void __thiscall InterpolationManager::Destroy(InterpolationManager*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationManager, void>)0x00556710)(ref this);

    /// <summary>Enqueues a new interpolation target for the physics object, trimming the queue if necessary and handling immediate completion when already near the destination. The keepHeading flag determines whether to maintain the object's current heading or adopt the target's heading during interpolation.
    /// <code>Offset: 0x00556740
    /// void __thiscall InterpolationManager::InterpolateTo(InterpolationManager*,const Position*,int)</code>
    /// </summary>
    /// <param name="p">The desired target position for the physics object.</param>
    /// <param name="keep_heading">Non‑zero to preserve the object's current heading; zero causes the heading to match the target's heading when interpolating.</param>
    public void InterpolateTo(ACBindings.Internal.Position* p, int keep_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationManager, ACBindings.Internal.Position*, int, void>)0x00556740)(ref this, p, keep_heading);

    /// <summary>Computes the positional offset required to move a physics object toward its next queued interpolation point, adjusting for speed limits and elapsed time. The function updates internal progress counters, resets them when the object is sufficiently near the target, and writes the resulting frame into the supplied <paramref name="offset"/> parameter. If the distance to the target falls below thresholds, the node is marked complete or failed accordingly.
    /// <code>Offset: 0x00556950
    /// void __thiscall InterpolationManager::adjust_offset(InterpolationManager*,Frame*,long double)</code>
    /// </summary>
    /// <param name="offset">Frame into which the computed offset vector is written if a valid interpolation step occurs.</param>
    /// <param name="quantum">Elapsed time quantum used to scale the movement based on speed constraints.</param>
    public void adjust_offset(ACBindings.Internal.Frame* offset, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationManager, ACBindings.Internal.Frame*, double, void>)0x00556950)(ref this, offset, quantum);

    /// <summary>Updates a physics object by processing queued interpolation nodes, applying new positions and velocities, and terminating interpolation when complete or an error occurs.
    /// <code>Offset: 0x00556B40
    /// void __thiscall InterpolationManager::UseTime(InterpolationManager*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationManager, void>)0x00556B40)(ref this);

    /// <summary>Destroys an InterpolationManager instance by freeing its internal resources and resetting the vtable of its blipto_position member.
    /// <code>Offset: 0x00556C90
    /// void __thiscall InterpolationManager::~InterpolationManager(InterpolationManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationManager, void>)0x00556C90)(ref this);
}

