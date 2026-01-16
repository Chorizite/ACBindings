namespace ACBindings.Internal;


/// <summary>Encapsulates a portal‑summoning spell, combining generic Spell attributes with an explicit lifetime value for the resulting portal.</summary>
public unsafe struct PortalSummonSpell
{
    // Base Classes
    public ACBindings.Internal.Spell BaseClass_Spell; // ACBindings.Internal.Spell

    // Child Types
    public unsafe struct PortalSummonSpell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, void> PortalSummonSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, double> InqDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, double, int> SetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> IsEnchantmentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> IsBoostSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> IsProjectileSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> IsTransferSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> IsDispelSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> IsFellowshipSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> AffectsHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> AffectsStamina; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> AffectsMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Members
    public double _portal_lifetime;

    // Methods

    /// <summary>Retrieves the duration associated with a portal by returning the workmanship from a SalvageResult.
    /// <code>Offset: 0x00599BA0
    /// long double __thiscall PortalSummonSpell::InqDuration(SalvageResult*)</code>
    /// </summary>
    /// <param name="salvageResult">The SalvageResult containing workmanship information.</param>
    /// <returns>The workmanship value, interpreted as the portal's lifetime in seconds.</returns>
    public double InqDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalSummonSpell, double>)0x00599BA0)(ref this);

    /// <summary>Computes the serialized size in bytes for a PortalSummonSpell instance by combining the base class size with its own data fields.
    /// <code>Offset: 0x00599EB0
    /// unsigned int __thiscall PortalSummonSpell::pack_size(PortalSummonSpell*)</code>
    /// </summary>
    /// <returns>The total number of bytes required to pack this object.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalSummonSpell, uint>)0x00599EB0)(ref this);

    /// <summary>Copies the spell attributes from one Spell object into another within a PortalSummonSpell, ensuring both pointers are valid before assignment.
    /// <code>Offset: 0x00599EF0
    /// void __thiscall PortalSummonSpell::SetEqual(PortalSummonSpell*,const Spell*,const Spell*)</code>
    /// </summary>
    /// <param name="dst">The destination Spell to receive the copied data.</param>
    /// <param name="src">The source Spell providing values to copy.</param>
    public void SetEqual(ACBindings.Internal.Spell* dst, ACBindings.Internal.Spell* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalSummonSpell, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void>)0x00599EF0)(ref this, dst, src);

    /// <summary>Packs a PortalSummonSpell instance into a buffer, serializing its base Spell data followed by the portal lifetime value. Returns the total byte count required for serialization.
    /// <code>Offset: 0x00599F20
    /// unsigned int __thiscall PortalSummonSpell::Pack(PortalSummonSpell*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the start of the destination buffer. If size is sufficient, it advances past the written data; otherwise it remains unchanged.</param>
    /// <param name="size">Maximum number of bytes available in the buffer at *addr.</param>
    /// <returns>Number of bytes required to serialize the PortalSummonSpell object. The value is returned even when the supplied buffer is too small and no data is written.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalSummonSpell, void**, uint, uint>)0x00599F20)(ref this, addr, size);
}

