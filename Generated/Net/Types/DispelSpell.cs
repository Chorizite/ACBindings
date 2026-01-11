namespace ACBindings.Internal;

public unsafe struct DispelSpell
{
    // Base Classes
    public ACBindings.Internal.Spell BaseClass_Spell; // ACBindings.Internal.Spell

    // Child Types
    public unsafe struct DispelSpell_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, void> DispelSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, double> InqDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, double, int> SetDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> IsEnchantmentSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> IsBoostSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> IsProjectileSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> IsTransferSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> IsDispelSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> IsFellowshipSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> AffectsHealth; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> AffectsStamina; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, int> AffectsMana; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DispelSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00599960
    /// unsigned int __thiscall DispelSpell::Pack(DispelSpell*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DispelSpell, void**, uint, uint>)0x00599960)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00599990
    /// int __thiscall DispelSpell::UnPack(DispelSpell*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DispelSpell, void**, uint, int>)0x00599990)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005999E0
    /// void __thiscall DispelSpell::SetEqual(DispelSpell*,const Spell*,const Spell*)</code>
    /// </summary>
    public void SetEqual(ACBindings.Internal.Spell* dst, ACBindings.Internal.Spell* src) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DispelSpell, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void>)0x005999E0)(ref this, dst, src);
}

