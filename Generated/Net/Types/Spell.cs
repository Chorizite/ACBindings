namespace ACBindings.Internal;


/// <summary>Represents a game spell with a unique identifier, enabling serialization and deserialization via its PackObj base class while facilitating runtime creation of diverse spell variants.</summary>
public unsafe struct Spell
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Spell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, void> Spell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, ACBindings.Internal.Spell*, void> SetEqual; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, double> InqDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, double, int> SetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> IsEnchantmentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> IsBoostSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> IsProjectileSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> IsTransferSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> IsDispelSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> IsFellowshipSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, ACBindings.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> AffectsHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> AffectsStamina; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, int> AffectsMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Spell*, uint> pack_size; // function pointer

        // Methods
    }

    // Members
    public uint _spell_id;

    // Generated Constructor
    public Spell() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Creates and initializes a new Spell instance corresponding to the specified spell type.
    /// <code>Offset: 0x00599540
    /// Spell* __cdecl Spell::BuildSpell(const SpellType)</code>
    /// </summary>
    /// <param name="sp_type">The type of spell to construct.</param>
    /// <returns>A pointer to the newly created Spell, or nullptr when the requested type is unsupported or memory allocation fails.</returns>
    public static ACBindings.Internal.Spell* BuildSpell(ACBindings.Internal.SpellType sp_type) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SpellType, ACBindings.Internal.Spell*>)0x00599540)(sp_type);

    /// <summary>Initializes a new Spell instance, assigning its base class virtual table and setting the spell ID to zero.
    /// <code>Offset: 0x00599820
    /// void __thiscall Spell::Spell(Spell*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Spell, void>)0x00599820)(ref this);

    /// <summary>Obtains the duration of the spell in seconds. A negative value indicates that the spell has no lasting effect.
    /// <code>Offset: 0x00599830
    /// long double __thiscall Spell::InqDuration(Spell*)</code>
    /// </summary>
    /// <returns>The spell's duration as a long double; negative if instantaneous or indefinite.</returns>
    public double InqDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Spell, double>)0x00599830)(ref this);

    /// <summary>Serializes a Spell into a buffer, writing its identifier when enough space is available.
    /// <code>Offset: 0x00599840
    /// unsigned int __thiscall Spell::Pack(Spell*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the destination buffer; updated after serialization.</param>
    /// <param name="size">Number of bytes remaining in the buffer that can be written.</param>
    /// <returns>The number of bytes required to serialize this Spell, which may exceed the provided size.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Spell, void**, uint, uint>)0x00599840)(ref this, addr, size);

    /// <summary>Unpacks a spell identifier from the provided buffer while ensuring sufficient data is available according to the base class's unpack requirements.
    /// <code>Offset: 0x00599860
    /// int __thiscall Spell::UnPack(Spell*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the buffer; updated to point after the extracted 4‑byte spell ID.</param>
    /// <param name="size">Number of bytes remaining in the buffer from the current position.</param>
    /// <returns>Returns 1 if the spell ID was successfully extracted; otherwise, returns 0 when there are insufficient bytes.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Spell, void**, uint, int>)0x00599860)(ref this, addr, size);
}

