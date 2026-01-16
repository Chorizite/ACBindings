namespace ACBindings.Internal;


/// <summary>Represents a projectile spell that carries an enchantment effect, extending the base projectile behavior with additional magical attributes.</summary>
/// <remarks>Inherits from ProjectileSpell and participates in the Spell system’s serialization and unpacking mechanisms. The struct is primarily used to apply enchantment data to projectiles during gameplay.</remarks>
public unsafe struct ProjectileEnchantmentSpell
{
    // Base Classes
    public ACBindings.Internal.ProjectileSpell BaseClass_ProjectileSpell; // ACBindings.Internal.ProjectileSpell

    // Child Types
    public unsafe struct ProjectileEnchantmentSpell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, void> ProjectileEnchantmentSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, double> InqDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, double, int> SetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> IsEnchantmentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> IsBoostSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> IsProjectileSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> IsTransferSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> IsDispelSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> IsFellowshipSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> AffectsHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> AffectsStamina; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> AffectsMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Deserializes a ProjectileEnchantmentSpell from the supplied buffer, ensuring sufficient data and updating the read position.
    /// <code>Offset: 0x00599D70
    /// int __thiscall ProjectileEnchantmentSpell::UnPack(ProjectileEnchantmentSpell*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read location; updated to reflect consumed bytes upon successful unpacking.</param>
    /// <param name="size">Number of bytes remaining in the buffer starting at *addr.</param>
    /// <returns>1 if unpack succeeds; 0 on failure or insufficient data.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProjectileEnchantmentSpell, void**, uint, int>)0x00599D70)(ref this, addr, size);

    /// <summary>Copies all relevant data from a source spell into a destination spell using the appropriate virtual method, making both spells equivalent in content.
    /// <code>Offset: 0x00599DD0
    /// void __thiscall ProjectileEnchantmentSpell::SetEqual(ProjectileEnchantmentSpell*,const Spell*,const Spell*)</code>
    /// </summary>
    /// <param name="this">The projectile enchantment spell instance on which the operation is performed.</param>
    /// <param name="dst">Destination spell that will receive the copied values.</param>
    /// <param name="src">Source spell whose data is copied to dst.</param>
    public void SetEqual(ACBindings.Internal.Spell* dst, ACBindings.Internal.Spell* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProjectileEnchantmentSpell, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void>)0x00599DD0)(ref this, dst, src);

    /// <summary>Assigns the enchantment ID from this spell's identifier and signals successful construction.
    /// <code>Offset: 0x00599E30
    /// int __thiscall ProjectileEnchantmentSpell::BuildEnchantment(ProjectileEnchantmentSpell*,Enchantment*)</code>
    /// </summary>
    /// <param name="e">The Enchantment to configure.</param>
    /// <returns>Integer status code: 1 indicates success.</returns>
    public int BuildEnchantment(ACBindings.Internal.Enchantment* e) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProjectileEnchantmentSpell, ACBindings.Internal.Enchantment*, int>)0x00599E30)(ref this, e);
}

