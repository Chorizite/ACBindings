namespace ACBindings;

// InterpolationManager
public unsafe struct InterpolationManager : System.IDisposable
{
    // Statics
    public static int* fUseAdjustedSpeed_ = (int*)0x00820428;

    // Members
    public ACBindings.LList__InterpolationNode position_queue;
    public ACBindings.CPhysicsObj* physics_obj;
    public int keep_heading;
    public uint frame_counter;
    public float original_distance;
    public float progress_quantum;
    public int node_fail_counter;
    public ACBindings.Position blipto_position;

    // Generated Constructor
    public InterpolationManager(ACBindings.CPhysicsObj* physics_obj) {
        _ConstructorInternal(physics_obj);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall InterpolationManager::InterpolationManager(InterpolationManager*,CPhysicsObj*)
    public void _ConstructorInternal(ACBindings.CPhysicsObj* physics_obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpolationManager, ACBindings.CPhysicsObj*, void>)0x005564F0)(ref this, physics_obj);
    // InterpolationManager* __cdecl InterpolationManager::Create(CPhysicsObj*)
    public static ACBindings.InterpolationManager* Create(ACBindings.CPhysicsObj* obj) => ((delegate* unmanaged[Cdecl]<ACBindings.CPhysicsObj*, ACBindings.InterpolationManager*>)0x00556550)(obj);
    // void __thiscall InterpolationManager::StopInterpolating(InterpolationManager*)
    public void StopInterpolating() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpolationManager, void>)0x00556570)(ref this);
    // void __thiscall InterpolationManager::NodeCompleted(InterpolationManager*,int)
    public void NodeCompleted(int success) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpolationManager, int, void>)0x005565C0)(ref this, success);
    // void __thiscall InterpolationManager::Destroy(InterpolationManager*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpolationManager, void>)0x00556710)(ref this);
    // void __thiscall InterpolationManager::InterpolateTo(InterpolationManager*,const Position*,int)
    public void InterpolateTo(ACBindings.Position* p, int keep_heading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpolationManager, ACBindings.Position*, int, void>)0x00556740)(ref this, p, keep_heading);
    // void __thiscall InterpolationManager::adjust_offset(InterpolationManager*,Frame*,long double)
    public void adjust_offset(ACBindings.Frame* offset, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpolationManager, ACBindings.Frame*, double, void>)0x00556950)(ref this, offset, quantum);
    // void __thiscall InterpolationManager::UseTime(InterpolationManager*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpolationManager, void>)0x00556B40)(ref this);
    // void __thiscall InterpolationManager::~InterpolationManager(InterpolationManager*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterpolationManager, void>)0x00556C90)(ref this);
}

