namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0051ADD0
    /// void __thiscall AttackManager::AttackManager(AttackManager*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackManager, void>)0x0051ADD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051AE10
    /// void __thiscall AttackManager::~AttackManager(AttackManager*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackManager, void>)0x0051AE10)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051AEA0
    /// AttackInfo* __thiscall AttackManager::NewAttack(AttackManager*,int)</code>
    /// </summary>
    public ACBindings.Internal.AttackInfo* NewAttack(int part_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackManager, int, ACBindings.Internal.AttackInfo*>)0x0051AEA0)(ref this, part_index);

    /// <summary>
    /// <code>Offset: 0x0051AF20
    /// void __thiscall AttackManager::AttackDone(AttackManager*,AttackInfo*)</code>
    /// </summary>
    public void AttackDone(ACBindings.Internal.AttackInfo* attack_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackManager, ACBindings.Internal.AttackInfo*, void>)0x0051AF20)(ref this, attack_info);
}

