namespace ACBindings.Internal;


/// <summary>Represents a character’s attribute state, storing the level derived from character points, the initial level at allocation, and the CP that has been spent; inherits PackObj to enable packing and unpacking of its data.</summary>
public unsafe struct Attribute
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Attribute_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute*, void> Attribute_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute*, uint, uint> LevelFromExperience; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute*, uint, uint> ExperienceToLevel; // function pointer

        // Methods
    }

    // Members
    public uint _level_from_cp;
    public uint _init_level;
    public uint _cp_spent;

    // Generated Constructor
    public Attribute(ACBindings.Internal.Attribute* that) {
        _ConstructorInternal(that);
    }

    // Methods

    /// <summary>Copies all member values from another Attribute instance, initializing the virtual table pointer and data fields.
    /// <code>Offset: 0x00558430
    /// void __thiscall Attribute::Attribute(Attribute*,const Attribute*)</code>
    /// </summary>
    /// <param name="that">The Attribute instance whose contents are copied into the new object.</param>
    public void _ConstructorInternal(ACBindings.Internal.Attribute* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute, ACBindings.Internal.Attribute*, void>)0x00558430)(ref this, that);

    /// <summary>Determines the attribute level from a raw experience point value using the game's experience system.
    /// <code>Offset: 0x005CBB00
    /// unsigned int __thiscall Attribute::LevelFromExperience(Attribute*,unsigned int)</code>
    /// </summary>
    /// <param name="xp">The total experience points used for level calculation.</param>
    /// <returns>The resulting level as an unsigned integer.</returns>
    public uint LevelFromExperience(uint xp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute, uint, uint>)0x005CBB00)(ref this, xp);

    /// <summary>Converts a raw experience value into the corresponding attribute level using the game’s experience system.
    /// <code>Offset: 0x005CBB10
    /// unsigned int __thiscall Attribute::ExperienceToLevel(Attribute*,unsigned int)</code>
    /// </summary>
    /// <param name="level">Experience points to translate into an attribute level.</param>
    /// <returns>The calculated attribute level.</returns>
    public uint ExperienceToLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute, uint, uint>)0x005CBB10)(ref this, level);

    /// <summary>Unpacks attribute data from a byte stream into this object’s fields, updating the supplied buffer pointer.
    /// <code>Offset: 0x005CBB20
    /// int __thiscall Attribute::UnPack(Attribute*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read location in the buffer; updated to point after unpacked data.</param>
    /// <param name="size">Number of bytes remaining in the buffer; must be at least 12 for successful unpacking.</param>
    /// <returns>Non‑zero if unpacking succeeded, zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute, void**, uint, int>)0x005CBB20)(ref this, addr, size);
}

