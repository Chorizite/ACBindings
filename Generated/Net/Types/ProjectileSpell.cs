namespace ACBindings.Internal;


/// <summary>Represents a spell that manifests as a projectile, extending the base Spell functionality with projectile‑specific behavior.</summary>
public unsafe struct ProjectileSpell
{
    // Base Classes
    public ACBindings.Internal.Spell BaseClass_Spell; // ACBindings.Internal.Spell

    // Child Types
    public unsafe struct ProjectileSpell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, void> ProjectileSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, double> InqDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, double, int> SetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, int> IsEnchantmentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, int> IsBoostSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, int> IsProjectileSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, int> IsTransferSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, int> IsDispelSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, int> IsFellowshipSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, int> AffectsHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, int> AffectsStamina; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, int> AffectsMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Identifies a projectile spell, always returning 1 to signal that the spell is classified as a projectile.
    /// <code>Offset: 0x005275F0
    /// unsigned int __thiscall ProjectileSpell::IsProjectileSpell(CPlayerModule*)</code>
    /// </summary>
    /// <param name="this">Pointer to the player module context associated with the spell instance.</param>
    /// <returns>Always 1, indicating the spell is considered a projectile spell.</returns>
    public uint IsProjectileSpell() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProjectileSpell, uint>)0x005275F0)(ref this);
}

