namespace ACBindings;

// PortalSummonSpell
public unsafe struct PortalSummonSpell
{
    // Base Classes
    public ACBindings.Spell BaseClass_Spell; // ACBindings.Spell

    // Child Types
    // PortalSummonSpell_vtbl
    public unsafe struct PortalSummonSpell_vtbl
    {
        // Members
        public System.IntPtr PortalSummonSpell_dtor_0; // function pointer
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

    // Members
    public double _portal_lifetime;

    // Methods
    // long double __thiscall PortalSummonSpell::InqDuration(SalvageResult*)
    public double InqDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PortalSummonSpell, double>)0x00599BA0)(ref this);
    // unsigned int __thiscall PortalSummonSpell::pack_size(PortalSummonSpell*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PortalSummonSpell, uint>)0x00599EB0)(ref this);
    // void __thiscall PortalSummonSpell::SetEqual(PortalSummonSpell*,const Spell*,const Spell*)
    public void SetEqual(ACBindings.Spell* dst, ACBindings.Spell* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PortalSummonSpell, ACBindings.Spell*, ACBindings.Spell*, void>)0x00599EF0)(ref this, dst, src);
    // unsigned int __thiscall PortalSummonSpell::Pack(PortalSummonSpell*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PortalSummonSpell, void**, uint, uint>)0x00599F20)(ref this, addr, size);
}

