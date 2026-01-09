namespace ACBindings;

// FellowshipEnchantmentSpell
public unsafe struct FellowshipEnchantmentSpell
{
    // Base Classes
    public ACBindings.EnchantmentSpell BaseClass_EnchantmentSpell; // ACBindings.EnchantmentSpell

    // Child Types
    // FellowshipEnchantmentSpell_vtbl
    public unsafe struct FellowshipEnchantmentSpell_vtbl
    {
        // Members
        public System.IntPtr FellowshipEnchantmentSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr SetEqual; // function pointer
        public System.IntPtr InqDuration; // function pointer
        public System.IntPtr SetDuration; // function pointer
        public System.IntPtr IsEnchantmentSpell; // function pointer
        public System.IntPtr IsBoostSpell; // function pointer
        public System.IntPtr IsProjectileSpell; // function pointer
        public System.IntPtr IsTransferSpell; // function pointer
        public System.IntPtr IsDispelSpell; // function pointer
        public System.IntPtr IsFellowshipSpell; // function pointer
        public System.IntPtr BuildEnchantment; // function pointer
        public System.IntPtr AffectsHealth; // function pointer
        public System.IntPtr AffectsStamina; // function pointer
        public System.IntPtr AffectsMana; // function pointer
        public System.IntPtr pack_size; // function pointer

        // Methods
    }

    // Methods
}

