namespace ACBindings.Internal;

public unsafe struct SkillBase : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SkillBase_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillBase*, void> SkillBase_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillBase*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillBase*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillBase*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _description;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;
    public ACBindings.Internal.IDClass____tagDataID _iconID;
    public uint _trained_cost;
    public uint _specialized_cost;
    public ACBindings.Internal.SKILL_CATEGORY _category;
    public int _chargen_use;
    public ACBindings.Internal.SKILL_ADVANCEMENT_CLASS _min_level;
    public ACBindings.Internal.SkillFormula _formula;
    public double _upper_bound;
    public double _lower_bound;
    public double _learn_mod;

    // Generated Constructor
    public SkillBase() {
        _ConstructorInternal();
    }
    public SkillBase(ACBindings.Internal.SkillBase* that) {
        _ConstructorInternal(that);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F1EF0
    /// void __thiscall SkillBase::SkillBase(SkillBase*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillBase, void>)0x004F1EF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F1F70
    /// void __thiscall SkillBase::~SkillBase(SkillBase*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillBase, void>)0x004F1F70)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CC0A0
    /// unsigned int __thiscall SkillBase::Pack(SkillBase*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillBase, void**, uint, uint>)0x005CC0A0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CC1A0
    /// int __thiscall SkillBase::UnPack(SkillBase*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillBase, void**, uint, int>)0x005CC1A0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CC9C0
    /// void __thiscall SkillBase::SkillBase(SkillBase*,const SkillBase*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.SkillBase* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillBase, ACBindings.Internal.SkillBase*, void>)0x005CC9C0)(ref this, that);
}

