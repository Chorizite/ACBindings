namespace ACBindings.Internal;

public unsafe struct FellowshipEnchantmentSpell
{
    // Base Classes
    public ACBindings.Internal.EnchantmentSpell BaseClass_EnchantmentSpell; // ACBindings.Internal.EnchantmentSpell

    // Child Types
    public unsafe struct FellowshipEnchantmentSpell_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, void> FellowshipEnchantmentSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, double> InqDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, double, int> SetDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> IsEnchantmentSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> IsBoostSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> IsProjectileSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> IsTransferSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> IsDispelSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> IsFellowshipSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> AffectsHealth; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> AffectsStamina; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> AffectsMana; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods
}

