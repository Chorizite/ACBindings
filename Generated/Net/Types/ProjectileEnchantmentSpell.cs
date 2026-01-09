namespace ACBindings;

// ProjectileEnchantmentSpell
public unsafe struct ProjectileEnchantmentSpell
{
    // Base Classes
    public ACBindings.ProjectileSpell BaseClass_ProjectileSpell; // ACBindings.ProjectileSpell

    // Child Types
    // ProjectileEnchantmentSpell_vtbl
    public unsafe struct ProjectileEnchantmentSpell_vtbl
    {
        // Members
        public System.IntPtr ProjectileEnchantmentSpell_dtor_0; // function pointer
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
    // int __thiscall ProjectileEnchantmentSpell::UnPack(ProjectileEnchantmentSpell*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProjectileEnchantmentSpell, void**, uint, int>)0x00599D70)(ref this, addr, size);
    // void __thiscall ProjectileEnchantmentSpell::SetEqual(ProjectileEnchantmentSpell*,const Spell*,const Spell*)
    public void SetEqual(ACBindings.Spell* dst, ACBindings.Spell* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProjectileEnchantmentSpell, ACBindings.Spell*, ACBindings.Spell*, void>)0x00599DD0)(ref this, dst, src);
    // int __thiscall ProjectileEnchantmentSpell::BuildEnchantment(ProjectileEnchantmentSpell*,Enchantment*)
    public int BuildEnchantment(ACBindings.Enchantment* e) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ProjectileEnchantmentSpell, ACBindings.Enchantment*, int>)0x00599E30)(ref this, e);
}

