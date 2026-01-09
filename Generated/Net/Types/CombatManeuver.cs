namespace ACBindings;

// CombatManeuver
public unsafe struct CombatManeuver
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CombatManeuver_vtbl
    public unsafe struct CombatManeuver_vtbl
    {
        // Members
        public System.IntPtr CombatManeuver_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint style;
    public ACBindings.ATTACK_HEIGHT attack_height;
    public ACBindings.AttackType attack_type;
    public uint min_skill_level;
    public uint motion;

    // Generated Constructor
    public CombatManeuver() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall CombatManeuver::CombatManeuver(CombatManeuver*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CombatManeuver, void>)0x005CB4B0)(ref this);
    // unsigned int __thiscall CombatManeuver::Pack(CombatManeuver*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CombatManeuver, void**, uint, uint>)0x005CB720)(ref this, addr, size);
    // int __thiscall CombatManeuver::UnPack(CombatManeuver*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CombatManeuver, void**, uint, int>)0x005CB780)(ref this, addr, size);
}

