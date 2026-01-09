namespace ACBindings;

// EnchantmentSpell
public unsafe struct EnchantmentSpell
{
    // Base Classes
    public ACBindings.Spell BaseClass_Spell; // ACBindings.Spell

    // Child Types
    // EnchantmentSpell_vtbl
    public unsafe struct EnchantmentSpell_vtbl
    {
        // Members
        public System.IntPtr EnchantmentSpell_dtor_0; // function pointer
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
    // int __thiscall EnchantmentSpell::BuildEnchantment(EnchantmentSpell*,Enchantment*)
    public int BuildEnchantment(ACBindings.Enchantment* e) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnchantmentSpell, ACBindings.Enchantment*, int>)0x00599B10)(ref this, e);
    // unsigned int __thiscall EnchantmentSpell::pack_size(EnchantmentSpell*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnchantmentSpell, uint>)0x00599B50)(ref this);
    // int __thiscall EnchantmentSpell::SetDuration(EnchantmentSpell*,const long double)
    public int SetDuration(double d) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnchantmentSpell, double, int>)0x00599BB0)(ref this, d);
    // unsigned int __thiscall EnchantmentSpell::Pack(EnchantmentSpell*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnchantmentSpell, void**, uint, uint>)0x00599BF0)(ref this, addr, size);
    // int __thiscall EnchantmentSpell::UnPack(EnchantmentSpell*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnchantmentSpell, void**, uint, int>)0x00599C40)(ref this, addr, size);
}

