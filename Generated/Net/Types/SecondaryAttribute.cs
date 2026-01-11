namespace ACBindings.Internal;

public unsafe struct SecondaryAttribute
{
    // Base Classes
    public ACBindings.Internal.Attribute BaseClass_Attribute; // ACBindings.Internal.Attribute

    // Child Types
    public unsafe struct SecondaryAttribute_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SecondaryAttribute*, void> SecondaryAttribute_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SecondaryAttribute*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SecondaryAttribute*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SecondaryAttribute*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SecondaryAttribute*, uint, uint> LevelFromExperience; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SecondaryAttribute*, uint, uint> ExperienceToLevel; // function pointer

        // Methods
    }

    // Members
    public uint _current_level;

    // Generated Constructor
    public SecondaryAttribute(ACBindings.Internal.SecondaryAttribute* that) {
        _ConstructorInternal(that);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00558460
    /// void __thiscall SecondaryAttribute::SecondaryAttribute(SecondaryAttribute*,const SecondaryAttribute*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.SecondaryAttribute* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SecondaryAttribute, ACBindings.Internal.SecondaryAttribute*, void>)0x00558460)(ref this, that);

    /// <summary>
    /// <code>Offset: 0x005CBB70
    /// unsigned int __thiscall SecondaryAttribute::LevelFromExperience(SecondaryAttribute*,unsigned int)</code>
    /// </summary>
    public uint LevelFromExperience(uint xp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SecondaryAttribute, uint, uint>)0x005CBB70)(ref this, xp);

    /// <summary>
    /// <code>Offset: 0x005CBB80
    /// unsigned int __thiscall SecondaryAttribute::ExperienceToLevel(SecondaryAttribute*,unsigned int)</code>
    /// </summary>
    public uint ExperienceToLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SecondaryAttribute, uint, uint>)0x005CBB80)(ref this, level);

    /// <summary>
    /// <code>Offset: 0x005CBB90
    /// unsigned int __thiscall SecondaryAttribute::Pack(SecondaryAttribute*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SecondaryAttribute, void**, uint, uint>)0x005CBB90)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CBBC0
    /// int __thiscall SecondaryAttribute::UnPack(SecondaryAttribute*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SecondaryAttribute, void**, uint, int>)0x005CBBC0)(ref this, addr, size);
}

