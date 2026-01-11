namespace ACBindings.Internal;

public unsafe struct ConstraintManager : System.IDisposable
{
    // Members
    public ACBindings.Internal.CPhysicsObj* physics_obj;
    public int is_constrained;
    public float constraint_pos_offset;
    public ACBindings.Internal.Position constraint_pos;
    public float constraint_distance_start;
    public float constraint_distance_max;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00556CB0
    /// void __thiscall ConstraintManager::SetPhysicsObject(ConstraintManager*,CPhysicsObj*)</code>
    /// </summary>
    public void SetPhysicsObject(ACBindings.Internal.CPhysicsObj* new_physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstraintManager, ACBindings.Internal.CPhysicsObj*, void>)0x00556CB0)(ref this, new_physobj);

    /// <summary>
    /// <code>Offset: 0x00556D10
    /// void __thiscall ConstraintManager::~ConstraintManager(ConstraintManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstraintManager, void>)0x00556D10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00556D30
    /// ConstraintManager* __cdecl ConstraintManager::Create(CPhysicsObj*)</code>
    /// </summary>
    public static ACBindings.Internal.ConstraintManager* Create(ACBindings.Internal.CPhysicsObj* physobj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.ConstraintManager*>)0x00556D30)(physobj);

    /// <summary>
    /// <code>Offset: 0x00556DA0
    /// void __thiscall ConstraintManager::adjust_offset(ConstraintManager*,Frame*,long double)</code>
    /// </summary>
    public void adjust_offset(ACBindings.Internal.Frame* offset, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstraintManager, ACBindings.Internal.Frame*, double, void>)0x00556DA0)(ref this, offset, quantum);

    /// <summary>
    /// <code>Offset: 0x00556E60
    /// void __thiscall ConstraintManager::ConstrainTo(ConstraintManager*,const Position*,float,float)</code>
    /// </summary>
    public void ConstrainTo(ACBindings.Internal.Position* p, float start_distance, float max_distance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstraintManager, ACBindings.Internal.Position*, float, float, void>)0x00556E60)(ref this, p, start_distance, max_distance);
}

