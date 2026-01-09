namespace ACBindings;

// SecondaryAttribute
public unsafe struct SecondaryAttribute
{
    // Base Classes
    public ACBindings.Attribute BaseClass_Attribute; // ACBindings.Attribute

    // Child Types
    // SecondaryAttribute_vtbl
    public unsafe struct SecondaryAttribute_vtbl
    {
        // Members
        public System.IntPtr SecondaryAttribute_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr LevelFromExperience; // function pointer
        public System.IntPtr ExperienceToLevel; // function pointer

        // Methods
    }

    // Members
    public uint _current_level;

    // Generated Constructor
    public SecondaryAttribute(ACBindings.SecondaryAttribute* that) {
        _ConstructorInternal(that);
    }

    // Methods
    // void __thiscall SecondaryAttribute::SecondaryAttribute(SecondaryAttribute*,const SecondaryAttribute*)
    public void _ConstructorInternal(ACBindings.SecondaryAttribute* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SecondaryAttribute, ACBindings.SecondaryAttribute*, void>)0x00558460)(ref this, that);
    // unsigned int __thiscall SecondaryAttribute::LevelFromExperience(SecondaryAttribute*,unsigned int)
    public uint LevelFromExperience(uint xp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SecondaryAttribute, uint, uint>)0x005CBB70)(ref this, xp);
    // unsigned int __thiscall SecondaryAttribute::ExperienceToLevel(SecondaryAttribute*,unsigned int)
    public uint ExperienceToLevel(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SecondaryAttribute, uint, uint>)0x005CBB80)(ref this, level);
    // unsigned int __thiscall SecondaryAttribute::Pack(SecondaryAttribute*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SecondaryAttribute, void**, uint, uint>)0x005CBB90)(ref this, addr, size);
    // int __thiscall SecondaryAttribute::UnPack(SecondaryAttribute*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SecondaryAttribute, void**, uint, int>)0x005CBBC0)(ref this, addr, size);
}

