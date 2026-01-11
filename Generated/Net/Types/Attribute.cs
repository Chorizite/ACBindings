namespace ACBindings.Internal;

public unsafe struct Attribute
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Attribute_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute*, void> Attribute_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute*, void**, uint, int> UnPack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute*, uint, uint> LevelFromExperience; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Attribute*, uint, uint> ExperienceToLevel; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x00558430
    /// void __thiscall Attribute::Attribute(Attribute*,const Attribute*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.Attribute* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute, ACBindings.Internal.Attribute*, void>)0x00558430)(ref this, that);

    /// <summary>
    /// <code>Offset: 0x005CBB00
    /// unsigned int __thiscall Attribute::LevelFromExperience(Attribute*,unsigned int)</code>
    /// </summary>
    public uint LevelFromExperience(uint xp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute, uint, uint>)0x005CBB00)(ref this, xp);

    /// <summary>
    /// <code>Offset: 0x005CBB10
    /// unsigned int __thiscall Attribute::ExperienceToLevel(Attribute*,unsigned int)</code>
    /// </summary>
    public uint ExperienceToLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute, uint, uint>)0x005CBB10)(ref this, level);

    /// <summary>
    /// <code>Offset: 0x005CBB20
    /// int __thiscall Attribute::UnPack(Attribute*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute, void**, uint, int>)0x005CBB20)(ref this, addr, size);
}

