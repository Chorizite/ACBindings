namespace ACBindings.Internal;

public unsafe struct CSpellBase : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CSpellBase_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CSpellBase*, void> CSpellBase_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CSpellBase*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CSpellBase*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CSpellBase*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _name;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte _desc;
    public uint _school;
    public ACBindings.Internal.IDClass____tagDataID _iconID;
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
    public ACBindings.Internal.SpellFormula _formula;
    public ACBindings.Internal.PScriptType _caster_effect;
    public ACBindings.Internal.PScriptType _target_effect;
    public ACBindings.Internal.PScriptType _fizzle_effect;
    public double _recovery_interval;
    public float _recovery_amount;
    public int _display_order;
    public uint _non_component_target_type;
    public ACBindings.Internal.MetaSpell _meta_spell;

    // Generated Constructor
    public CSpellBase() {
        _ConstructorInternal();
    }
    public CSpellBase(ACBindings.Internal.CSpellBase* from) {
        _ConstructorInternal(from);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0048B420
    /// void __thiscall CSpellBase::CSpellBase(CSpellBase*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, void>)0x0048B420)(ref this);

    /// <summary>
    /// <code>Offset: 0x0048B4D0
    /// void __thiscall CSpellBase::~CSpellBase(CSpellBase*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, void>)0x0048B4D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00597950
    /// unsigned int __thiscall CSpellBase::InqSkillForSpell(CSpellBase*)</code>
    /// </summary>
    public uint InqSkillForSpell() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, uint>)0x00597950)(ref this);

    /// <summary>
    /// <code>Offset: 0x005979A0
    /// long double __thiscall CSpellBase::InqDuration(CSpellBase*)</code>
    /// </summary>
    public double InqDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, double>)0x005979A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00597B00
    /// unsigned int __thiscall CSpellBase::packed_size(CSpellBase*)</code>
    /// </summary>
    public uint packed_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, uint>)0x00597B00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00597B70
    /// unsigned int __thiscall CSpellBase::Pack(CSpellBase*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, void**, uint, uint>)0x00597B70)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00597CD0
    /// void __thiscall CSpellBase::CSpellBase(CSpellBase*,const CSpellBase*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.CSpellBase* from) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, ACBindings.Internal.CSpellBase*, void>)0x00597CD0)(ref this, from);

    /// <summary>
    /// <code>Offset: 0x00597DB0
    /// int* __thiscall CSpellBase::InqDescription(_DWORD*,int*)</code>
    /// </summary>
    public int* InqDescription(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, int*, int*>)0x00597DB0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00597E20
    /// SpellFormula* __thiscall CSpellBase::InqSpellFormula(CSpellBase*,SpellFormula*)</code>
    /// </summary>
    public ACBindings.Internal.SpellFormula* InqSpellFormula(ACBindings.Internal.SpellFormula* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, ACBindings.Internal.SpellFormula*, ACBindings.Internal.SpellFormula*>)0x00597E20)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x00597F70
    /// void*** __thiscall CSpellBase::InqCustomizedSpellFormula(CSpellBase*,void***,int*)</code>
    /// </summary>
    public void*** InqCustomizedSpellFormula(void*** a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, void***, int*, void***>)0x00597F70)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00597FC0
    /// SpellFormula* __thiscall CSpellBase::InqScarabOnlyFormula(CSpellBase*,SpellFormula*)</code>
    /// </summary>
    public ACBindings.Internal.SpellFormula* InqScarabOnlyFormula(ACBindings.Internal.SpellFormula* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, ACBindings.Internal.SpellFormula*, ACBindings.Internal.SpellFormula*>)0x00597FC0)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x005981A0
    /// unsigned int __thiscall CSpellBase::InqTargetType(CSpellBase*)</code>
    /// </summary>
    public uint InqTargetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, uint>)0x005981A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005981D0
    /// unsigned int __thiscall CSpellBase::InqSpellLevelByRoughHeuristic(CSpellBase*)</code>
    /// </summary>
    public uint InqSpellLevelByRoughHeuristic() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, uint>)0x005981D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00598200
    /// int __thiscall CSpellBase::UnPack(CSpellBase*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, void**, uint, int>)0x00598200)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00598370
    /// _DWORD* __cdecl CSpellBase::SchoolEnumToName(_DWORD*,int)</code>
    /// </summary>
    public static int* SchoolEnumToName(int* a1, int a2) => ((delegate* unmanaged[Cdecl]<int*, int, int*>)0x00598370)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x00598410
    /// int __thiscall CSpellBase::IsUntargeted(CSpellBase*)</code>
    /// </summary>
    public int IsUntargeted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, int>)0x00598410)(ref this);
}

