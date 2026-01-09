namespace ACBindings;

// Skill
public unsafe struct Skill
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // Skill_vtbl
    public unsafe struct Skill_vtbl
    {
        // Members
        public System.IntPtr Skill_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.SKILL_ADVANCEMENT_CLASS _sac;
    public uint _pp;
    public uint _init_level;
    public uint _level_from_pp;
    public int _resistance_of_last_check;
    public double _last_used_time;

    // Generated Constructor
    public Skill() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall Skill::Skill(Skill*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Skill, void>)0x0049B020)(ref this);
    // void __thiscall Skill::SetSkillAdvancementClass(Skill*,SKILL_ADVANCEMENT_CLASS)
    public void SetSkillAdvancementClass(ACBindings.SKILL_ADVANCEMENT_CLASS sac) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Skill, ACBindings.SKILL_ADVANCEMENT_CLASS, void>)0x005CB8B0)(ref this, sac);
    // int __thiscall Skill::AdjPP(Skill*,unsigned int*)
    public int AdjPP(uint* amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Skill, uint*, int>)0x005CB8D0)(ref this, amount);
    // int __thiscall Skill::SanityCheck(Skill*)
    public int SanityCheck() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Skill, int>)0x005CB930)(ref this);
    // unsigned int __thiscall Skill::Pack(Skill*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Skill, void**, uint, uint>)0x005CB990)(ref this, addr, size);
    // int __thiscall Skill::UnPack(Skill*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Skill, void**, uint, int>)0x005CBA30)(ref this, addr, size);
}

