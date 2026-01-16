namespace ACBindings.Internal;


/// <summary>Encapsulates a secondary attribute for game entities, extending the core Attribute functionality with an additional current level field and providing serialization support.</summary>
public unsafe struct SecondaryAttribute
{
    // Base Classes
    public ACBindings.Internal.Attribute BaseClass_Attribute; // ACBindings.Internal.Attribute

    // Child Types
    public unsafe struct SecondaryAttribute_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SecondaryAttribute*, void> SecondaryAttribute_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SecondaryAttribute*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SecondaryAttribute*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SecondaryAttribute*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SecondaryAttribute*, uint, uint> LevelFromExperience; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SecondaryAttribute*, uint, uint> ExperienceToLevel; // function pointer

        // Methods
    }

    // Members
    public uint _current_level;

    // Generated Constructor
    public SecondaryAttribute(ACBindings.Internal.SecondaryAttribute* that) {
        _ConstructorInternal(that);
    }

    // Methods

    /// <summary>Creates a new SecondaryAttribute by duplicating the state of an existing instance, including its base attributes and current level.
    /// <code>Offset: 0x00558460
    /// void __thiscall SecondaryAttribute::SecondaryAttribute(SecondaryAttribute*,const SecondaryAttribute*)</code>
    /// </summary>
    /// <param name="that">The attribute to copy from.</param>
    public void _ConstructorInternal(ACBindings.Internal.SecondaryAttribute* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SecondaryAttribute, ACBindings.Internal.SecondaryAttribute*, void>)0x00558460)(ref this, that);

    /// <summary>Calculates the level of a secondary attribute from experience points.
    /// <code>Offset: 0x005CBB70
    /// unsigned int __thiscall SecondaryAttribute::LevelFromExperience(SecondaryAttribute*,unsigned int)</code>
    /// </summary>
    /// <param name="xp">The amount of experience to convert into a level.</param>
    /// <returns>The resulting secondary attribute level.</returns>
    public uint LevelFromExperience(uint xp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SecondaryAttribute, uint, uint>)0x005CBB70)(ref this, xp);

    /// <summary>Computes the experience required to attain a given secondary attribute level.
    /// <code>Offset: 0x005CBB80
    /// unsigned int __thiscall SecondaryAttribute::ExperienceToLevel(SecondaryAttribute*,unsigned int)</code>
    /// </summary>
    /// <param name="level">The desired target level for the secondary attribute.</param>
    /// <returns>The amount of experience points needed to reach that level.</returns>
    public uint ExperienceToLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SecondaryAttribute, uint, uint>)0x005CBB80)(ref this, level);

    /// <summary>Serializes a SecondaryAttribute into a binary buffer when sufficient space is available, writing base data and the current level.
    /// <code>Offset: 0x005CBB90
    /// unsigned int __thiscall SecondaryAttribute::Pack(SecondaryAttribute*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">Pointer to the SecondaryAttribute instance being packed.</param>
    /// <param name="addr">Address of the destination buffer; on return points just past the written data if packing occurred.</param>
    /// <param name="size">Number of bytes available in the destination buffer.</param>
    /// <returns>The number of bytes required for packing (always 16), regardless of whether the operation actually performed a write.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SecondaryAttribute, void**, uint, uint>)0x005CBB90)(ref this, addr, size);

    /// <summary>Unpacks a SecondaryAttribute from binary data by extracting its base Attribute fields and current level, while validating sufficient buffer size.
    /// <code>Offset: 0x005CBBC0
    /// int __thiscall SecondaryAttribute::UnPack(SecondaryAttribute*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the input data buffer; advanced past the unpacked data on success.</param>
    /// <param name="size">Number of bytes available in the buffer at call time.</param>
    /// <returns>1 if unpacking succeeded; otherwise 0.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SecondaryAttribute, void**, uint, int>)0x005CBBC0)(ref this, addr, size);
}

