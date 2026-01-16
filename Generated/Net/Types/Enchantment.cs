namespace ACBindings.Internal;


/// <summary>Encapsulates data for an in‑game enchantment, including its identifier, category, power level, timing information, degradation behavior, and the associated stat modifier applied to affected entities.</summary>
public unsafe struct Enchantment
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Enchantment_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Enchantment*, void> Enchantment_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Enchantment*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Enchantment*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Enchantment*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _id;
    public uint m_SpellSetID;
    public uint _spell_category;
    public int _power_level;
    public double _start_time;
    public double _duration;
    public uint _caster;
    public float _degrade_modifier;
    public float _degrade_limit;
    public double _last_time_degraded;
    public ACBindings.Internal.StatMod _smod;

    // Generated Constructor
    public Enchantment(ACBindings.Internal.Enchantment* that) {
        _ConstructorInternal(that);
    }
    public Enchantment() {
        _ConstructorInternal();
    }
    public Enchantment(uint spid) {
        _ConstructorInternal(spid);
    }

    // Methods

    /// <summary>Creates an Enchantment by copying all attributes from the specified source instance.
    /// <code>Offset: 0x004B8A00
    /// void __thiscall Enchantment::Enchantment(Enchantment*,const Enchantment*)</code>
    /// </summary>
    /// <param name="that">The enchantment whose data will be duplicated into the new object.</param>
    public void _ConstructorInternal(ACBindings.Internal.Enchantment* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, ACBindings.Internal.Enchantment*, void>)0x004B8A00)(ref this, that);

    /// <summary>Determines whether this enchantment defeats a rival based on power level and activation timing. When power levels differ, the higher level wins; if equal, the enchantment whose opponent started earlier is considered victorious.
    /// <code>Offset: 0x005CBC10
    /// int __thiscall Enchantment::Duel(Enchantment*,const Enchantment*)</code>
    /// </summary>
    /// <param name="challenger">The opposing enchantment to compare against.</param>
    /// <returns>Non‑zero if this enchantment would win in a duel; zero otherwise.</returns>
    public int Duel(ACBindings.Internal.Enchantment* challenger) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, ACBindings.Internal.Enchantment*, int>)0x005CBC10)(ref this, challenger);

    /// <summary>Applies an enchantment’s stat modifier to the supplied value. If the modifier is flagged as additive (bit 0x8000) its value is added; if flagged as multiplicative (bit 0x4000) it multiplies the current value by the modifier. Returns 1 when a modification occurs, or 0 when no operation is performed.
    /// <code>Offset: 0x005CBC40
    /// int __thiscall Enchantment::Enchant(Enchantment*,float*)</code>
    /// </summary>
    /// <param name="value">The floating‑point number to be modified in place.</param>
    /// <returns>Non‑zero if the modifier was applied; zero otherwise.</returns>
    public int Enchant(float* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, float*, int>)0x005CBC40)(ref this, value);

    /// <summary>Applies the enchantment's stat modifier to an EnchantedQualityDetails instance, adjusting either additive or multiplicative values based on the modifier type and sign.
    /// <code>Offset: 0x005CBC80
    /// int __thiscall Enchantment::Enchant(Enchantment*,EnchantedQualityDetails*)</code>
    /// </summary>
    /// <param name="value">The quality details object that will receive the applied modifications.</param>
    /// <returns>1 if a modification was applied; 0 otherwise.</returns>
    public int Enchant(ACBindings.Internal.EnchantedQualityDetails* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, ACBindings.Internal.EnchantedQualityDetails*, int>)0x005CBC80)(ref this, value);

    /// <summary>Returns the size, in bytes, necessary to serialize or copy this Enchantment object.
    /// <code>Offset: 0x005CBCF0
    /// unsigned int __thiscall Enchantment::GetPackSize(Enchantment*)</code>
    /// </summary>
    /// <returns>The total number of bytes required to represent the Enchantment instance when packed.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, uint>)0x005CBCF0)(ref this);

    /// <summary>Determines whether this enchantment’s stat modifier applies to attack skills for the specified key.
    /// <code>Offset: 0x005CBD10
    /// int __thiscall Enchantment::AffectsAttackSkills(Enchantment*,unsigned int)</code>
    /// </summary>
    /// <param name="key">Numeric representation of a skill; only specific values are treated as attack skills.</param>
    /// <returns>Non-zero if the enchantment affects an attack skill for that key, otherwise zero.</returns>
    public int AffectsAttackSkills(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, uint, int>)0x005CBD10)(ref this, key);

    /// <summary>Determines whether the enchantment applies to defense-related skills identified by a skill key.
    /// <code>Offset: 0x005CBD60
    /// int __thiscall Enchantment::AffectsDefenseSkills(Enchantment*,unsigned int)</code>
    /// </summary>
    /// <param name="key">Skill identifier used to test against supported defense keys.</param>
    /// <returns>Non‑zero if the enchantment's stat modifier targets a defense skill matching the key; otherwise zero.</returns>
    public int AffectsDefenseSkills(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, uint, int>)0x005CBD60)(ref this, key);

    /// <summary>Initializes a new Enchantment instance with default values, resetting all timing fields and establishing the base class virtual table pointers.
    /// <code>Offset: 0x005CBDD0
    /// void __thiscall Enchantment::Enchantment(Enchantment*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, void>)0x005CBDD0)(ref this);

    /// <summary>Initializes a new Enchantment instance using the supplied spell identifier, setting default timing and degradation values as well as clearing caster and power information.
    /// <code>Offset: 0x005CBE30
    /// void __thiscall Enchantment::Enchantment(Enchantment*,const unsigned int)</code>
    /// </summary>
    /// <param name="spid">The identifier of the spell to bind to this enchantment.</param>
    public void _ConstructorInternal(uint spid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, uint, void>)0x005CBE30)(ref this, spid);

    /// <summary>Serializes an Enchantment instance into a binary buffer for storage or transmission.
    /// <code>Offset: 0x005CBEA0
    /// unsigned int __thiscall Enchantment::Pack(Enchantment*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer address; updated to point after the packed data.</param>
    /// <param name="size">Number of bytes available at *addr to hold the serialized data.</param>
    /// <returns>The total number of bytes required to pack this Enchantment. If size is smaller than that value, nothing is written and the function simply returns the needed size.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, void**, uint, uint>)0x005CBEA0)(ref this, addr, size);

    /// <summary>Deserializes an Enchantment from a binary buffer, populating its fields and advancing the buffer pointer.
    /// <code>Offset: 0x005CBF70
    /// int __thiscall Enchantment::UnPack(Enchantment*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current position in the input buffer; will be updated as data is consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer; must be at least 0x30 for base fields.</param>
    /// <returns>Non‑zero on success, zero or error code from sub‑unpack if deserialization fails.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, void**, uint, int>)0x005CBF70)(ref this, addr, size);
}

