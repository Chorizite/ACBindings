namespace ACBindings.Internal;


/// <summary>Manages constraints applied to a physics object, tracking whether it is constrained and storing positional offsets as well as distance limits for the constraint.</summary>
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

    /// <summary>Assigns a new physics object to the manager, clearing any previous reference and resetting constraint state.
    /// <code>Offset: 0x00556CB0
    /// void __thiscall ConstraintManager::SetPhysicsObject(ConstraintManager*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="new_physobj">The physics object to associate with this manager.</param>
    public void SetPhysicsObject(ACBindings.Internal.CPhysicsObj* new_physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstraintManager, ACBindings.Internal.CPhysicsObj*, void>)0x00556CB0)(ref this, new_physobj);

    /// <summary>Resets constraint flags and positions, clears physics references, and prepares the object for destruction.
    /// <code>Offset: 0x00556D10
    /// void __thiscall ConstraintManager::~ConstraintManager(ConstraintManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstraintManager, void>)0x00556D10)(ref this);

    /// <summary>Creates a new constraint manager for the specified physics object and initializes all fields to default values.
    /// <code>Offset: 0x00556D30
    /// ConstraintManager* __cdecl ConstraintManager::Create(CPhysicsObj*)</code>
    /// </summary>
    /// <param name="physobj">The CPhysicsObj instance to be managed by the new constraint manager.</param>
    /// <returns>A pointer to the initialized ConstraintManager, or nullptr if memory allocation fails.</returns>
    public static ACBindings.Internal.ConstraintManager* Create(ACBindings.Internal.CPhysicsObj* physobj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.ConstraintManager*>)0x00556D30)(physobj);

    /// <summary>Adjusts the internal constraint offset using a supplied Frame offset vector, scaling it between configured start and max distances or zeroing it when exceeding the maximum; then updates the accumulated offset magnitude.
    /// <code>Offset: 0x00556DA0
    /// void __thiscall ConstraintManager::adjust_offset(ConstraintManager*,Frame*,long double)</code>
    /// </summary>
    /// <param name="offset">Frame containing an origin vector that represents the desired offset adjustment.</param>
    public void adjust_offset(ACBindings.Internal.Frame* offset, double quantum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstraintManager, ACBindings.Internal.Frame*, double, void>)0x00556DA0)(ref this, offset, quantum);

    /// <summary>Activates a positional constraint on the linked physics object, storing the target cell ID and frame data from <paramref name="p"/>.
    /// <code>Offset: 0x00556E60
    /// void __thiscall ConstraintManager::ConstrainTo(ConstraintManager*,const Position*,float,float)</code>
    /// </summary>
    /// <param name="p">The position to which the physics object should be constrained.</param>
    /// <param name="start_distance">The initial distance at which the constraint is applied.</param>
    /// <param name="max_distance">The maximum allowable distance for the constrained movement.</param>
    public void ConstrainTo(ACBindings.Internal.Position* p, float start_distance, float max_distance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstraintManager, ACBindings.Internal.Position*, float, float, void>)0x00556E60)(ref this, p, start_distance, max_distance);
}

