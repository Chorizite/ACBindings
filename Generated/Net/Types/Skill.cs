namespace ACBindings.Internal;

public unsafe struct Skill
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Skill_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Skill*, void> Skill_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Skill*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Skill*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Skill*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SKILL_ADVANCEMENT_CLASS _sac;
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

    /// <summary>
    /// <code>Offset: 0x0049B020
    /// void __thiscall Skill::Skill(Skill*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Skill, void>)0x0049B020)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CB8B0
    /// void __thiscall Skill::SetSkillAdvancementClass(Skill*,SKILL_ADVANCEMENT_CLASS)</code>
    /// </summary>
    public void SetSkillAdvancementClass(ACBindings.Internal.SKILL_ADVANCEMENT_CLASS sac) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Skill, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS, void>)0x005CB8B0)(ref this, sac);

    /// <summary>
    /// <code>Offset: 0x005CB8D0
    /// int __thiscall Skill::AdjPP(Skill*,unsigned int*)</code>
    /// </summary>
    public int AdjPP(uint* amount) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Skill, uint*, int>)0x005CB8D0)(ref this, amount);

    /// <summary>
    /// <code>Offset: 0x005CB930
    /// int __thiscall Skill::SanityCheck(Skill*)</code>
    /// </summary>
    public int SanityCheck() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Skill, int>)0x005CB930)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CB990
    /// unsigned int __thiscall Skill::Pack(Skill*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Skill, void**, uint, uint>)0x005CB990)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CBA30
    /// int __thiscall Skill::UnPack(Skill*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Skill, void**, uint, int>)0x005CBA30)(ref this, addr, size);
}

