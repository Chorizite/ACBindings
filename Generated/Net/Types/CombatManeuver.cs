namespace ACBindings.Internal;


/// <summary>Represents a combat maneuver, storing style, attack height, type, minimum skill level and motion for packing into a 20‑byte serialized form used by the game's combat system.</summary>
public unsafe struct CombatManeuver
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CombatManeuver_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CombatManeuver*, void> CombatManeuver_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CombatManeuver*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CombatManeuver*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CombatManeuver*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>Initializes a new CombatManeuver instance, setting its style, attack height, attack type, minimum skill level, and motion to default values.
    /// <code>Offset: 0x005CB4B0
    /// void __thiscall CombatManeuver::CombatManeuver(CombatManeuver*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CombatManeuver, void>)0x005CB4B0)(ref this);

    /// <summary>Packs the CombatManeuver fields into a 20‑byte block at the supplied address when the buffer is large enough, advancing the address pointer past the written data.
    /// <code>Offset: 0x005CB720
    /// unsigned int __thiscall CombatManeuver::Pack(CombatManeuver*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer location where data will be written; updated to point after the packed fields if packing succeeds.</param>
    /// <param name="size">Number of bytes available in the buffer. Packing occurs only when this value is at least 20.</param>
    /// <returns>Number of bytes required for the packed representation (always 20).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CombatManeuver, void**, uint, uint>)0x005CB720)(ref this, addr, size);

    /// <summary>Unpacks combat maneuver data from a serialized buffer into this object.
    /// <code>Offset: 0x005CB780
    /// int __thiscall CombatManeuver::UnPack(CombatManeuver*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the buffer; advanced as each field is extracted.</param>
    /// <param name="size">Number of bytes remaining in the buffer that may be consumed.</param>
    /// <returns>Non‑zero if at least 20 bytes were available and the fields were successfully populated; otherwise zero.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CombatManeuver, void**, uint, int>)0x005CB780)(ref this, addr, size);
}

