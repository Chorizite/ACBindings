namespace ACBindings.Internal;

public unsafe struct PortalSummonSpell
{
    // Base Classes
    public ACBindings.Internal.Spell BaseClass_Spell; // ACBindings.Internal.Spell

    // Child Types
    public unsafe struct PortalSummonSpell_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, void> PortalSummonSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, double> InqDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, double, int> SetDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> IsEnchantmentSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> IsBoostSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> IsProjectileSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> IsTransferSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> IsDispelSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> IsFellowshipSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> AffectsHealth; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> AffectsStamina; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, int> AffectsMana; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PortalSummonSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Members
    public double _portal_lifetime;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00599BA0
    /// long double __thiscall PortalSummonSpell::InqDuration(SalvageResult*)</code>
    /// </summary>
    public double InqDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalSummonSpell, double>)0x00599BA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00599EB0
    /// unsigned int __thiscall PortalSummonSpell::pack_size(PortalSummonSpell*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalSummonSpell, uint>)0x00599EB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00599EF0
    /// void __thiscall PortalSummonSpell::SetEqual(PortalSummonSpell*,const Spell*,const Spell*)</code>
    /// </summary>
    public void SetEqual(ACBindings.Internal.Spell* dst, ACBindings.Internal.Spell* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalSummonSpell, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void>)0x00599EF0)(ref this, dst, src);

    /// <summary>
    /// <code>Offset: 0x00599F20
    /// unsigned int __thiscall PortalSummonSpell::Pack(PortalSummonSpell*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PortalSummonSpell, void**, uint, uint>)0x00599F20)(ref this, addr, size);
}

