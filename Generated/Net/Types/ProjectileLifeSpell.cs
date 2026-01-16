namespace ACBindings.Internal;


/// <summary>Offers projectile spell functionality with support for packing its data into buffers, leveraging the underlying ProjectileSpell implementation.</summary>
public unsafe struct ProjectileLifeSpell
{
    // Base Classes
    public ACBindings.Internal.ProjectileSpell BaseClass_ProjectileSpell; // ACBindings.Internal.ProjectileSpell

    // Child Types
    public unsafe struct ProjectileLifeSpell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, void> ProjectileLifeSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, double> InqDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, double, int> SetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, int> IsEnchantmentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, int> IsBoostSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, int> IsProjectileSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, int> IsTransferSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, int> IsDispelSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, int> IsFellowshipSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, int> AffectsHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, int> AffectsStamina; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, int> AffectsMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileLifeSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Packs projectile life spell data into the supplied buffer if sufficient space is available, returning the byte count needed.
    /// <code>Offset: 0x00599DF0
    /// unsigned int __thiscall ProjectileLifeSpell::Pack(ProjectileEnchantmentSpell*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">The ProjectileEnchantmentSpell instance whose data will be packed.</param>
    /// <param name="addr">Pointer to the destination buffer where packed data should be written.</param>
    /// <param name="size">Size of the destination buffer in bytes.</param>
    /// <returns>Number of bytes required to pack the projectile life spell data.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProjectileLifeSpell, void**, uint, uint>)0x00599DF0)(ref this, addr, size);
}

