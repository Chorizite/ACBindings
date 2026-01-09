namespace ACBindings;

// CSpellBase
public unsafe struct CSpellBase : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CSpellBase_vtbl
    public unsafe struct CSpellBase_vtbl
    {
        // Members
        public System.IntPtr CSpellBase_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte _name;
    public ACBindings.AC1Legacy.PStringBase__sbyte _desc;
    public uint _school;
    public ACBindings.IDClass___tagDataID _iconID;
    public uint _category;
    public uint _bitfield;
    public int _base_mana;
    public int _mana_mod;
    public float _base_range_constant;
    public float _base_range_mod;
    public int _power;
    public float _spell_economy_mod;
    public uint _formula_version;
    public float _component_loss;
    public ACBindings.SpellFormula _formula;
    public ACBindings.PScriptType _caster_effect;
    public ACBindings.PScriptType _target_effect;
    public ACBindings.PScriptType _fizzle_effect;
    public double _recovery_interval;
    public float _recovery_amount;
    public int _display_order;
    public uint _non_component_target_type;
    public ACBindings.MetaSpell _meta_spell;

    // Generated Constructor
    public CSpellBase() {
        _ConstructorInternal();
    }
    public CSpellBase(ACBindings.CSpellBase* from) {
        _ConstructorInternal(from);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CSpellBase::CSpellBase(CSpellBase*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBase, void>)0x0048B420)(ref this);
    // void __thiscall CSpellBase::~CSpellBase(CSpellBase*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBase, void>)0x0048B4D0)(ref this);
    // unsigned int __thiscall CSpellBase::InqSkillForSpell(CSpellBase*)
    public uint InqSkillForSpell() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBase, uint>)0x00597950)(ref this);
    // long double __thiscall CSpellBase::InqDuration(CSpellBase*)
    public double InqDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBase, double>)0x005979A0)(ref this);
    // unsigned int __thiscall CSpellBase::packed_size(CSpellBase*)
    public uint packed_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBase, uint>)0x00597B00)(ref this);
    // unsigned int __thiscall CSpellBase::Pack(CSpellBase*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBase, void**, uint, uint>)0x00597B70)(ref this, addr, size);
    // void __thiscall CSpellBase::CSpellBase(CSpellBase*,const CSpellBase*)
    public void _ConstructorInternal(ACBindings.CSpellBase* from) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBase, ACBindings.CSpellBase*, void>)0x00597CD0)(ref this, from);
    // int* __thiscall CSpellBase::InqDescription(_DWORD*,int*)
    public int* InqDescription(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBase, int*, int*>)0x00597DB0)(ref this, a2);
    // SpellFormula* __thiscall CSpellBase::InqSpellFormula(CSpellBase*,SpellFormula*)
    public ACBindings.SpellFormula* InqSpellFormula(ACBindings.SpellFormula* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBase, ACBindings.SpellFormula*, ACBindings.SpellFormula*>)0x00597E20)(ref this, result);
    // void*** __thiscall CSpellBase::InqCustomizedSpellFormula(CSpellBase*,void***,int*)
    public void*** InqCustomizedSpellFormula(void*** a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBase, void***, int*, void***>)0x00597F70)(ref this, a2, a3);
    // SpellFormula* __thiscall CSpellBase::InqScarabOnlyFormula(CSpellBase*,SpellFormula*)
    public ACBindings.SpellFormula* InqScarabOnlyFormula(ACBindings.SpellFormula* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBase, ACBindings.SpellFormula*, ACBindings.SpellFormula*>)0x00597FC0)(ref this, result);
    // unsigned int __thiscall CSpellBase::InqTargetType(CSpellBase*)
    public uint InqTargetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBase, uint>)0x005981A0)(ref this);
    // unsigned int __thiscall CSpellBase::InqSpellLevelByRoughHeuristic(CSpellBase*)
    public uint InqSpellLevelByRoughHeuristic() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBase, uint>)0x005981D0)(ref this);
    // int __thiscall CSpellBase::UnPack(CSpellBase*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBase, void**, uint, int>)0x00598200)(ref this, addr, size);
    // _DWORD* __cdecl CSpellBase::SchoolEnumToName(_DWORD*,int)
    public static int* SchoolEnumToName(int* a1, int a2) => ((delegate* unmanaged[Cdecl]<int*, int, int*>)0x00598370)(a1, a2);
    // int __thiscall CSpellBase::IsUntargeted(CSpellBase*)
    public int IsUntargeted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSpellBase, int>)0x00598410)(ref this);
}

