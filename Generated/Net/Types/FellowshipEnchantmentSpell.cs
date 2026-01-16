namespace ACBindings.Internal;


/// <summary>Encapsulates an EnchantmentSpell instance, serving as a distinct type within the system.</summary>
public unsafe struct FellowshipEnchantmentSpell
{
    // Base Classes
    public ACBindings.Internal.EnchantmentSpell BaseClass_EnchantmentSpell; // ACBindings.Internal.EnchantmentSpell

    // Child Types
    public unsafe struct FellowshipEnchantmentSpell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, void> FellowshipEnchantmentSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, double> InqDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, double, int> SetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> IsEnchantmentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> IsBoostSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> IsProjectileSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> IsTransferSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> IsDispelSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> IsFellowshipSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> AffectsHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> AffectsStamina; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, int> AffectsMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FellowshipEnchantmentSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods
}

