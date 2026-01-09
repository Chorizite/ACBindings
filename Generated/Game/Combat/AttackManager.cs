namespace ACBindings;

// AttackManager
public unsafe struct AttackManager : System.IDisposable
{
    // Members
    public float attack_radius;
    public uint current_attack;
    public ACBindings.LongNIHash__AttackInfo pending_attacks;

    // Generated Constructor
    public AttackManager() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall AttackManager::AttackManager(AttackManager*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttackManager, void>)0x0051ADD0)(ref this);
    // void __thiscall AttackManager::~AttackManager(AttackManager*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttackManager, void>)0x0051AE10)(ref this);
    // AttackInfo* __thiscall AttackManager::NewAttack(AttackManager*,int)
    public ACBindings.AttackInfo* NewAttack(int part_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttackManager, int, ACBindings.AttackInfo*>)0x0051AEA0)(ref this, part_index);
    // void __thiscall AttackManager::AttackDone(AttackManager*,AttackInfo*)
    public void AttackDone(ACBindings.AttackInfo* attack_info) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttackManager, ACBindings.AttackInfo*, void>)0x0051AF20)(ref this, attack_info);
}

