namespace ACBindings.Internal;

public unsafe struct CombatManeuver
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CombatManeuver_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CombatManeuver*, void> CombatManeuver_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CombatManeuver*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CombatManeuver*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CombatManeuver*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint style;
    public ACBindings.Internal.ATTACK_HEIGHT attack_height;
    public ACBindings.Internal.AttackType attack_type;
    public uint min_skill_level;
    public uint motion;

    // Generated Constructor
    public CombatManeuver() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005CB4B0
    /// void __thiscall CombatManeuver::CombatManeuver(CombatManeuver*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CombatManeuver, void>)0x005CB4B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CB720
    /// unsigned int __thiscall CombatManeuver::Pack(CombatManeuver*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CombatManeuver, void**, uint, uint>)0x005CB720)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CB780
    /// int __thiscall CombatManeuver::UnPack(CombatManeuver*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CombatManeuver, void**, uint, int>)0x005CB780)(ref this, addr, size);
}

