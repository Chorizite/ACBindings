namespace ACBindings.Internal;


/// <summary>Tracks a character’s skill state, including experience points, the derived level, advancement class, resistance to last check, and elapsed time since the last use.</summary>
public unsafe struct Skill
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Skill_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Skill*, void> Skill_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Skill*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Skill*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Skill*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SKILL_ADVANCEMENT_CLASS _sac;
    public uint _pp;
    public uint _init_level;
    public uint _level_from_pp;
    public int _resistance_of_last_check;
    public double _last_used_time;

    // Generated Constructor
    public Skill() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a new Skill instance by assigning the correct vtable and resetting all internal fields to their default values.
    /// <code>Offset: 0x0049B020
    /// void __thiscall Skill::Skill(Skill*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Skill, void>)0x0049B020)(ref this);

    /// <summary>Sets the skill advancement class for this skill and recalculates its level from the current experience points.
    /// <code>Offset: 0x005CB8B0
    /// void __thiscall Skill::SetSkillAdvancementClass(Skill*,SKILL_ADVANCEMENT_CLASS)</code>
    /// </summary>
    /// <param name="sac">The new skill advancement class to assign.</param>
    public void SetSkillAdvancementClass(ACBindings.Internal.SKILL_ADVANCEMENT_CLASS sac) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Skill, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS, void>)0x005CB8B0)(ref this, sac);

    /// <summary>Adjusts the Skill’s experience points by the given amount, recalculates the skill level, and indicates if the level was altered.
    /// <code>Offset: 0x005CB8D0
    /// int __thiscall Skill::AdjPP(Skill*,unsigned int*)</code>
    /// </summary>
    /// <param name="amount">The change in experience points to apply; after execution it may be modified to reflect the actual adjustment performed.</param>
    /// <returns>Non‑zero if the skill’s level changed as a result of the adjustment; zero otherwise.</returns>
    public int AdjPP(uint* amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Skill, uint*, int>)0x005CB8D0)(ref this, amount);

    /// <summary>Verifies that a Skill object's advancement class and experience-derived level are consistent. If the advancement class is invalid it resets to UNTRAINED_SKILL_ADVANCEMENT_CLASS, updates the derived level, and flags the change. The function also ensures the cached level matches the current experience; if not, it recalculates and records the new level.
    /// <code>Offset: 0x005CB930
    /// int __thiscall Skill::SanityCheck(Skill*)</code>
    /// </summary>
    /// <returns>1 if the Skill was already consistent; 0 if corrections were applied or the level had to be recomputed.</returns>
    public int SanityCheck() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Skill, int>)0x005CB930)(ref this);

    /// <summary>Packs the skill's state into a contiguous buffer, writing fixed-size fields such as level, advancement class, points, initial level, last check resistance, and elapsed time since last use. The function updates the supplied address pointer to follow the serialized data.
    /// <code>Offset: 0x005CB990
    /// unsigned int __thiscall Skill::Pack(Skill*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; after packing it points immediately after the written data.</param>
    /// <param name="size">Available size of the buffer in bytes; packing occurs only if at least 28 bytes are available.</param>
    /// <returns>Number of bytes written (28). The function returns this value regardless of whether packing actually occurred, allowing callers to validate sufficient space beforehand.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Skill, void**, uint, uint>)0x005CB990)(ref this, addr, size);

    /// <summary>Unpacks a Skill instance from a binary buffer, advancing the buffer pointer as fields are read.
    /// <code>Offset: 0x005CBA30
    /// int __thiscall Skill::UnPack(Skill*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current position in the input buffer; updated to point after the consumed data.</param>
    /// <param name="size">Number of bytes remaining in the buffer at the start of unpacking.</param>
    /// <returns>1 if unpack succeeded and all validations passed; 0 otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Skill, void**, uint, int>)0x005CBA30)(ref this, addr, size);
}

