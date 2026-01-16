namespace ACBindings.Internal;


/// <summary>Manages attack state for a unit, tracking radius, the active attack, and queued pending attacks.</summary>
public unsafe struct AttackManager : System.IDisposable
{
    // Members
    public float attack_radius;
    public uint current_attack;
    public ACBindings.Internal.LongNIHash___AttackInfo pending_attacks;

    // Generated Constructor
    public AttackManager() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a new AttackManager with default settings, setting the attack radius to zero, clearing the current attack index, and allocating an empty hash table for pending attacks.
    /// <code>Offset: 0x0051ADD0
    /// void __thiscall AttackManager::AttackManager(AttackManager*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackManager, void>)0x0051ADD0)(ref this);

    /// <summary>Destroys an AttackManager instance by flushing its pending attack list and freeing allocated resources.
    /// <code>Offset: 0x0051AE10
    /// void __thiscall AttackManager::~AttackManager(AttackManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackManager, void>)0x0051AE10)(ref this);

    /// <summary>Creates a new AttackInfo object with an ID derived from the manager’s current_attack counter, stores it in the pending_attacks table, increments the counter, and returns the instance.
    /// <code>Offset: 0x0051AEA0
    /// AttackInfo* __thiscall AttackManager::NewAttack(AttackManager*,int)</code>
    /// </summary>
    /// <param name="part_index">Index identifying which part of the attacker is performing the attack.</param>
    /// <returns>A pointer to the newly created AttackInfo, or nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.AttackInfo* NewAttack(int part_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackManager, int, ACBindings.Internal.AttackInfo*>)0x0051AEA0)(ref this, part_index);

    /// <summary>Finalizes a completed attack by removing its entry from the manager's pending attacks and freeing associated resources.
    /// <code>Offset: 0x0051AF20
    /// void __thiscall AttackManager::AttackDone(AttackManager*,AttackInfo*)</code>
    /// </summary>
    /// <param name="attack_info">Information about the attack that has finished, including any objects involved.</param>
    public void AttackDone(ACBindings.Internal.AttackInfo* attack_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackManager, ACBindings.Internal.AttackInfo*, void>)0x0051AF20)(ref this, attack_info);
}

