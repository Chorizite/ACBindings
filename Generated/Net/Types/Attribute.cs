namespace ACBindings;

// Attribute
public unsafe struct Attribute
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // Attribute_vtbl
    public unsafe struct Attribute_vtbl
    {
        // Members
        public System.IntPtr Attribute_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr LevelFromExperience; // function pointer
        public System.IntPtr ExperienceToLevel; // function pointer

        // Methods
    }

    // Members
    public uint _level_from_cp;
    public uint _init_level;
    public uint _cp_spent;

    // Generated Constructor
    public Attribute(ACBindings.Attribute* that) {
        _ConstructorInternal(that);
    }

    // Methods
    // void __thiscall Attribute::Attribute(Attribute*,const Attribute*)
    public void _ConstructorInternal(ACBindings.Attribute* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Attribute, ACBindings.Attribute*, void>)0x00558430)(ref this, that);
    // unsigned int __thiscall Attribute::LevelFromExperience(Attribute*,unsigned int)
    public uint LevelFromExperience(uint xp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Attribute, uint, uint>)0x005CBB00)(ref this, xp);
    // unsigned int __thiscall Attribute::ExperienceToLevel(Attribute*,unsigned int)
    public uint ExperienceToLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Attribute, uint, uint>)0x005CBB10)(ref this, level);
    // int __thiscall Attribute::UnPack(Attribute*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Attribute, void**, uint, int>)0x005CBB20)(ref this, addr, size);
}

