namespace ACBindings;

// SkillBase
public unsafe struct SkillBase : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // SkillBase_vtbl
    public unsafe struct SkillBase_vtbl
    {
        // Members
        public System.IntPtr SkillBase_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte _description;
    public ACBindings.AC1Legacy.PStringBase__sbyte _name;
    public ACBindings.IDClass___tagDataID _iconID;
    public uint _trained_cost;
    public uint _specialized_cost;
    public ACBindings.SKILL_CATEGORY _category;
    public int _chargen_use;
    public ACBindings.SKILL_ADVANCEMENT_CLASS _min_level;
    public ACBindings.SkillFormula _formula;
    public double _upper_bound;
    public double _lower_bound;
    public double _learn_mod;

    // Generated Constructor
    public SkillBase() {
        _ConstructorInternal();
    }
    public SkillBase(ACBindings.SkillBase* that) {
        _ConstructorInternal(that);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall SkillBase::SkillBase(SkillBase*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillBase, void>)0x004F1EF0)(ref this);
    // void __thiscall SkillBase::~SkillBase(SkillBase*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillBase, void>)0x004F1F70)(ref this);
    // unsigned int __thiscall SkillBase::Pack(SkillBase*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillBase, void**, uint, uint>)0x005CC0A0)(ref this, addr, size);
    // int __thiscall SkillBase::UnPack(SkillBase*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillBase, void**, uint, int>)0x005CC1A0)(ref this, addr, size);
    // void __thiscall SkillBase::SkillBase(SkillBase*,const SkillBase*)
    public void _ConstructorInternal(ACBindings.SkillBase* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillBase, ACBindings.SkillBase*, void>)0x005CC9C0)(ref this, that);
}

