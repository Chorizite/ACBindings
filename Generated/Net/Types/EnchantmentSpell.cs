namespace ACBindings.Internal;

public unsafe struct EnchantmentSpell
{
    // Base Classes
    public ACBindings.Internal.Spell BaseClass_Spell; // ACBindings.Internal.Spell

    // Child Types
    public unsafe struct EnchantmentSpell_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, void> EnchantmentSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, double> InqDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, double, int> SetDuration; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> IsEnchantmentSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> IsBoostSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> IsProjectileSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> IsTransferSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> IsDispelSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> IsFellowshipSpell; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> AffectsHealth; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> AffectsStamina; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> AffectsMana; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Members
    public double _duration;
    public float _degrade_modifier;
    public float _degrade_limit;
    public uint _etype;
    public uint _uImbuedEffect;
    public int _SlayerCreatureType;
    public float _SlayerDamageBonus;
    public double _critical_frequency;
    public double _critical_multiplier;
    public int _ignore_magic_resist;
    public double _resistanceModifier;
    public double _ElementalModifier;
    public int _weapon_is_loot;
    public int _damage_over_time;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00599B10
    /// int __thiscall EnchantmentSpell::BuildEnchantment(EnchantmentSpell*,Enchantment*)</code>
    /// </summary>
    public int BuildEnchantment(ACBindings.Internal.Enchantment* e) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnchantmentSpell, ACBindings.Internal.Enchantment*, int>)0x00599B10)(ref this, e);

    /// <summary>
    /// <code>Offset: 0x00599B50
    /// unsigned int __thiscall EnchantmentSpell::pack_size(EnchantmentSpell*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnchantmentSpell, uint>)0x00599B50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00599BB0
    /// int __thiscall EnchantmentSpell::SetDuration(EnchantmentSpell*,const long double)</code>
    /// </summary>
    public int SetDuration(double d) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnchantmentSpell, double, int>)0x00599BB0)(ref this, d);

    /// <summary>
    /// <code>Offset: 0x00599BF0
    /// unsigned int __thiscall EnchantmentSpell::Pack(EnchantmentSpell*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnchantmentSpell, void**, uint, uint>)0x00599BF0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00599C40
    /// int __thiscall EnchantmentSpell::UnPack(EnchantmentSpell*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnchantmentSpell, void**, uint, int>)0x00599C40)(ref this, addr, size);
}

