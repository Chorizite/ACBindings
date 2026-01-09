namespace ACBindings;

// DispelSpell
public unsafe struct DispelSpell
{
    // Base Classes
    public ACBindings.Spell BaseClass_Spell; // ACBindings.Spell

    // Child Types
    // DispelSpell_vtbl
    public unsafe struct DispelSpell_vtbl
    {
        // Members
        public System.IntPtr DispelSpell_dtor_0; // function pointer
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
    // unsigned int __thiscall DispelSpell::Pack(DispelSpell*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DispelSpell, void**, uint, uint>)0x00599960)(ref this, addr, size);
    // int __thiscall DispelSpell::UnPack(DispelSpell*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DispelSpell, void**, uint, int>)0x00599990)(ref this, addr, size);
    // void __thiscall DispelSpell::SetEqual(DispelSpell*,const Spell*,const Spell*)
    public void SetEqual(ACBindings.Spell* dst, ACBindings.Spell* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DispelSpell, ACBindings.Spell*, ACBindings.Spell*, void>)0x005999E0)(ref this, dst, src);
}

