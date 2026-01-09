namespace ACBindings;

// ConstraintManager
public unsafe struct ConstraintManager : System.IDisposable
{
    // Members
    public ACBindings.CPhysicsObj* physics_obj;
    public int is_constrained;
    public float constraint_pos_offset;
    public ACBindings.Position constraint_pos;
    public float constraint_distance_start;
    public float constraint_distance_max;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ConstraintManager::SetPhysicsObject(ConstraintManager*,CPhysicsObj*)
    public void SetPhysicsObject(ACBindings.CPhysicsObj* new_physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ConstraintManager, ACBindings.CPhysicsObj*, void>)0x00556CB0)(ref this, new_physobj);
    // void __thiscall ConstraintManager::~ConstraintManager(ConstraintManager*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ConstraintManager, void>)0x00556D10)(ref this);
    // ConstraintManager* __cdecl ConstraintManager::Create(CPhysicsObj*)
    public static ACBindings.ConstraintManager* Create(ACBindings.CPhysicsObj* physobj) => ((delegate* unmanaged[Cdecl]<ACBindings.CPhysicsObj*, ACBindings.ConstraintManager*>)0x00556D30)(physobj);
    // void __thiscall ConstraintManager::adjust_offset(ConstraintManager*,Frame*,long double)
    public void adjust_offset(ACBindings.Frame* offset, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ConstraintManager, ACBindings.Frame*, double, void>)0x00556DA0)(ref this, offset, quantum);
    // void __thiscall ConstraintManager::ConstrainTo(ConstraintManager*,const Position*,float,float)
    public void ConstrainTo(ACBindings.Position* p, float start_distance, float max_distance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ConstraintManager, ACBindings.Position*, float, float, void>)0x00556E60)(ref this, p, start_distance, max_distance);
}

