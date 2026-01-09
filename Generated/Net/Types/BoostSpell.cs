namespace ACBindings;

// BoostSpell
public unsafe struct BoostSpell
{
    // Base Classes
    public ACBindings.Spell BaseClass_Spell; // ACBindings.Spell

    // Child Types
    // BoostSpell_vtbl
    public unsafe struct BoostSpell_vtbl
    {
        // Members
        public System.IntPtr BoostSpell_dtor_0; // function pointer
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
    // void __thiscall BoostSpell::SetEqual(BoostSpell*,const Spell*,const Spell*)
    public void SetEqual(ACBindings.Spell* dst, ACBindings.Spell* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BoostSpell, ACBindings.Spell*, ACBindings.Spell*, void>)0x00599FB0)(ref this, dst, src);
}

