namespace ACBindings.Internal;


/// <summary>Encapsulates a spell object together with its type identifier for serialization and deserialization, delegating packing and unpacking responsibilities to the contained Spell instance.</summary>
public unsafe struct MetaSpell : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct MetaSpell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MetaSpell*, void> MetaSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MetaSpell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MetaSpell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MetaSpell*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SpellType _sp_type;
    public ACBindings.Internal.Spell* _spell;

    // Generated Constructor
    public MetaSpell() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a MetaSpell instance with default values and sets up its virtual table pointer.
    /// <code>Offset: 0x00599710
    /// void __thiscall MetaSpell::MetaSpell(MetaSpell*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MetaSpell, void>)0x00599710)(ref this);

    /// <summary>Serializes the MetaSpell into a binary buffer, writing the spell type followed by any encapsulated Spell data.
    /// <code>Offset: 0x00599750
    /// unsigned int __thiscall MetaSpell::Pack(MetaSpell*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the destination pointer; on success it points after the written data.</param>
    /// <param name="size">Maximum number of bytes that may be written to the buffer.</param>
    /// <returns>The total number of bytes required to represent this MetaSpell (including 4‑byte spell type and packed Spell data). If size is insufficient, no data is written but the needed length is still returned.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MetaSpell, void**, uint, uint>)0x00599750)(ref this, addr, size);

    /// <summary>Unpacks serialized data into this MetaSpell instance, reading a spell type from the buffer, constructing an appropriate Spell object, delegating further unpacking to that Spell, and cleaning up any previously held Spell.
    /// <code>Offset: 0x005997B0
    /// int __thiscall MetaSpell::UnPack(MetaSpell*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the input buffer; advanced as bytes are consumed during unpacking.</param>
    /// <param name="size">Number of bytes remaining in the input buffer to process.</param>
    /// <returns>Zero on failure or insufficient data, otherwise returns the result of the constructed Spell’s unpack operation.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MetaSpell, void**, uint, int>)0x005997B0)(ref this, addr, size);

    /// <summary>Destroys the MetaSpell object, releasing its associated Spell instance if one exists, resets the spell type to Undef_SpellType, and restores the base class virtual table pointer to PackObj's default.
    /// <code>Offset: 0x00599890
    /// void __thiscall MetaSpell::~MetaSpell(MetaSpell*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MetaSpell, void>)0x00599890)(ref this);
}

