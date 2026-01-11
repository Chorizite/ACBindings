namespace ACBindings.Internal;

public unsafe struct BoostSpell
{
    // Base Classes
    public ACBindings.Internal.Spell BaseClass_Spell; // ACBindings.Internal.Spell

    // Child Types
    public unsafe struct BoostSpell_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, void> BoostSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, double> InqDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, double, int> SetDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, int> IsEnchantmentSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, int> IsBoostSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, int> IsProjectileSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, int> IsTransferSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, int> IsDispelSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, int> IsFellowshipSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, int> AffectsHealth; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, int> AffectsStamina; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, int> AffectsMana; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BoostSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00599FB0
    /// void __thiscall BoostSpell::SetEqual(BoostSpell*,const Spell*,const Spell*)</code>
    /// </summary>
    public void SetEqual(ACBindings.Internal.Spell* dst, ACBindings.Internal.Spell* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BoostSpell, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void>)0x00599FB0)(ref this, dst, src);
}

