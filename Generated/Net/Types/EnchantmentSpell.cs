namespace ACBindings.Internal;


/// <summary>Encapsulates data for an enchantment spell, storing its duration, degradation parameters, elemental modifiers, damage bonuses, and supporting binary serialization.</summary>
public unsafe struct EnchantmentSpell
{
    // Base Classes
    public ACBindings.Internal.Spell BaseClass_Spell; // ACBindings.Internal.Spell

    // Child Types
    public unsafe struct EnchantmentSpell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, void> EnchantmentSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, double> InqDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, double, int> SetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> IsEnchantmentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> IsBoostSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> IsProjectileSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> IsTransferSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> IsDispelSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> IsFellowshipSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> AffectsHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> AffectsStamina; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, int> AffectsMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.EnchantmentSpell*, uint> pack_size; // function pointer

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

    /// <summary>Initializes the provided Enchantment object with properties from this spell, including id composition, degradation settings, and duration.
    /// <code>Offset: 0x00599B10
    /// int __thiscall EnchantmentSpell::BuildEnchantment(EnchantmentSpell*,Enchantment*)</code>
    /// </summary>
    /// <param name="e">The Enchantment instance to populate.</param>
    /// <returns>An integer status code; currently always 1 to indicate success.</returns>
    public int BuildEnchantment(ACBindings.Internal.Enchantment* e) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnchantmentSpell, ACBindings.Internal.Enchantment*, int>)0x00599B10)(ref this, e);

    /// <summary>Computes the number of bytes required to serialize an EnchantmentSpell instance.
    /// <code>Offset: 0x00599B50
    /// unsigned int __thiscall EnchantmentSpell::pack_size(EnchantmentSpell*)</code>
    /// </summary>
    /// <returns>The total size in bytes needed for packing, including base class data and additional fields.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnchantmentSpell, uint>)0x00599B50)(ref this);

    /// <summary>Assigns a new duration to an enchantment spell and indicates success.
    /// <code>Offset: 0x00599BB0
    /// int __thiscall EnchantmentSpell::SetDuration(EnchantmentSpell*,const long double)</code>
    /// </summary>
    /// <param name="d">The desired duration value for the spell.</param>
    /// <returns>Always 1 to signal that the operation succeeded.</returns>
    public int SetDuration(double d) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnchantmentSpell, double, int>)0x00599BB0)(ref this, d);

    /// <summary>Serializes an EnchantmentSpell instance into a contiguous block of memory, writing its duration, degrade modifier and limit after packing the underlying Spell data.
    /// <code>Offset: 0x00599BF0
    /// unsigned int __thiscall EnchantmentSpell::Pack(EnchantmentSpell*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer location where serialized data will be written; updated to point past the last byte written.</param>
    /// <param name="size">Maximum number of bytes available at *addr for serialization. If this value is smaller than the required size, no data is written.</param>
    /// <returns>The total number of bytes needed to pack the object (including base class and EnchantmentSpell-specific fields).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnchantmentSpell, void**, uint, uint>)0x00599BF0)(ref this, addr, size);

    /// <summary>Deserializes an EnchantmentSpell from a binary buffer, initializing its properties and advancing the buffer pointer.
    /// <code>Offset: 0x00599C40
    /// int __thiscall EnchantmentSpell::UnPack(EnchantmentSpell*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the input buffer; will be updated to point after the data read on success.</param>
    /// <param name="size">Number of bytes available in the buffer for deserialization.</param>
    /// <returns>Non‑zero if unpacking succeeds, zero if there is insufficient data or an error occurs during base‑class unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnchantmentSpell, void**, uint, int>)0x00599C40)(ref this, addr, size);
}

