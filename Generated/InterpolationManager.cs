namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x005564F0
    /// void __thiscall InterpolationManager::InterpolationManager(InterpolationManager*,CPhysicsObj*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.CPhysicsObj* physics_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationManager, ACBindings.Internal.CPhysicsObj*, void>)0x005564F0)(ref this, physics_obj);

    /// <summary>
    /// <code>Offset: 0x00556550
    /// InterpolationManager* __cdecl InterpolationManager::Create(CPhysicsObj*)</code>
    /// </summary>
    public static ACBindings.Internal.InterpolationManager* Create(ACBindings.Internal.CPhysicsObj* obj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.InterpolationManager*>)0x00556550)(obj);

    /// <summary>
    /// <code>Offset: 0x00556570
    /// void __thiscall InterpolationManager::StopInterpolating(InterpolationManager*)</code>
    /// </summary>
    public void StopInterpolating() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationManager, void>)0x00556570)(ref this);

    /// <summary>
    /// <code>Offset: 0x005565C0
    /// void __thiscall InterpolationManager::NodeCompleted(InterpolationManager*,int)</code>
    /// </summary>
    public void NodeCompleted(int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationManager, int, void>)0x005565C0)(ref this, success);

    /// <summary>
    /// <code>Offset: 0x00556710
    /// void __thiscall InterpolationManager::Destroy(InterpolationManager*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationManager, void>)0x00556710)(ref this);

    /// <summary>
    /// <code>Offset: 0x00556740
    /// void __thiscall InterpolationManager::InterpolateTo(InterpolationManager*,const Position*,int)</code>
    /// </summary>
    public void InterpolateTo(ACBindings.Internal.Position* p, int keep_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationManager, ACBindings.Internal.Position*, int, void>)0x00556740)(ref this, p, keep_heading);

    /// <summary>
    /// <code>Offset: 0x00556950
    /// void __thiscall InterpolationManager::adjust_offset(InterpolationManager*,Frame*,long double)</code>
    /// </summary>
    public void adjust_offset(ACBindings.Internal.Frame* offset, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationManager, ACBindings.Internal.Frame*, double, void>)0x00556950)(ref this, offset, quantum);

    /// <summary>
    /// <code>Offset: 0x00556B40
    /// void __thiscall InterpolationManager::UseTime(InterpolationManager*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationManager, void>)0x00556B40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00556C90
    /// void __thiscall InterpolationManager::~InterpolationManager(InterpolationManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterpolationManager, void>)0x00556C90)(ref this);
}

