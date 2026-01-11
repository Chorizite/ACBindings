namespace ACBindings.Internal;

public unsafe struct ProjectileEnchantmentSpell
{
    // Base Classes
    public ACBindings.Internal.ProjectileSpell BaseClass_ProjectileSpell; // ACBindings.Internal.ProjectileSpell

    // Child Types
    public unsafe struct ProjectileEnchantmentSpell_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, void> ProjectileEnchantmentSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, double> InqDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, double, int> SetDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> IsEnchantmentSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> IsBoostSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> IsProjectileSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> IsTransferSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> IsDispelSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> IsFellowshipSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> AffectsHealth; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> AffectsStamina; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, int> AffectsMana; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ProjectileEnchantmentSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00599D70
    /// int __thiscall ProjectileEnchantmentSpell::UnPack(ProjectileEnchantmentSpell*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProjectileEnchantmentSpell, void**, uint, int>)0x00599D70)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00599DD0
    /// void __thiscall ProjectileEnchantmentSpell::SetEqual(ProjectileEnchantmentSpell*,const Spell*,const Spell*)</code>
    /// </summary>
    public void SetEqual(ACBindings.Internal.Spell* dst, ACBindings.Internal.Spell* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProjectileEnchantmentSpell, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void>)0x00599DD0)(ref this, dst, src);

    /// <summary>
    /// <code>Offset: 0x00599E30
    /// int __thiscall ProjectileEnchantmentSpell::BuildEnchantment(ProjectileEnchantmentSpell*,Enchantment*)</code>
    /// </summary>
    public int BuildEnchantment(ACBindings.Internal.Enchantment* e) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ProjectileEnchantmentSpell, ACBindings.Internal.Enchantment*, int>)0x00599E30)(ref this, e);
}

