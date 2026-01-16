namespace ACBindings.Internal;


/// <summary>Defines a spell in the game, storing metadata such as name, description, school, icon, mana cost, range, power, formula, effects, recovery behavior, and meta‑spell data for use by the engine.</summary>
public unsafe struct CSpellBase : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CSpellBase_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CSpellBase*, void> CSpellBase_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CSpellBase*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CSpellBase*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CSpellBase*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>Initializes a new CSpellBase instance with default spell properties and empty name/description strings.
    /// <code>Offset: 0x0048B420
    /// void __thiscall CSpellBase::CSpellBase(CSpellBase*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, void>)0x0048B420)(ref this);

    /// <summary>Destroys a CSpellBase instance, releasing its internal resources—including the name and description strings, meta‑spell data, and resetting base‑class virtual table pointers—to clean up before deallocation.
    /// <code>Offset: 0x0048B4D0
    /// void __thiscall CSpellBase::~CSpellBase(CSpellBase*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, void>)0x0048B4D0)(ref this);

    /// <summary>Returns the skill identifier required for casting a spell based on its magical school.
    /// <code>Offset: 0x00597950
    /// unsigned int __thiscall CSpellBase::InqSkillForSpell(CSpellBase*)</code>
    /// </summary>
    /// <returns>The skill ID corresponding to the spell's school (e.g., 34 for school 1, 33 for school 2, 32 for school 3, 31 for school 4, 43 for school 5), or zero when the school is unrecognized.</returns>
    public uint InqSkillForSpell() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, uint>)0x00597950)(ref this);

    /// <summary>Attempts to retrieve a numeric metric for a spell, returning –1.0 when meta‑spell data or the spell itself is unavailable. If present, it calls GetPackSize on the spell’s base class but does not store the result; consequently, the returned value is undefined.
    /// <code>Offset: 0x005979A0
    /// long double __thiscall CSpellBase::InqDuration(CSpellBase*)</code>
    /// </summary>
    /// <returns>-1.0 if meta‑spell information is invalid or missing; otherwise returns an indeterminate long double because no real value is assigned before returning.</returns>
    public double InqDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, double>)0x005979A0)(ref this);

    /// <summary>Calculates the size in bytes required to serialize a CSpellBase instance, including its name, description, formula, and meta spell data.
    /// <code>Offset: 0x00597B00
    /// unsigned int __thiscall CSpellBase::packed_size(CSpellBase*)</code>
    /// </summary>
    /// <returns>The packed byte count for the spell base plus an 80‑byte fixed overhead.</returns>
    public uint packed_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, uint>)0x00597B00)(ref this);

    /// <summary>Serializes the spell object's data into a binary buffer, advancing the write pointer and returning the total byte count required.
    /// <code>Offset: 0x00597B70
    /// unsigned int __thiscall CSpellBase::Pack(CSpellBase*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a pointer that will be moved past the written data upon completion.</param>
    /// <param name="size">Maximum number of bytes available for packing; if less than the required size, no data is written.</param>
    /// <returns>Byte count necessary to represent the spell object fully.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, void**, uint, uint>)0x00597B70)(ref this, addr, size);

    /// <summary>Create a new CSpellBase instance, initializing member objects and string buffers before copying data from an existing spell base.
    /// <code>Offset: 0x00597CD0
    /// void __thiscall CSpellBase::CSpellBase(CSpellBase*,const CSpellBase*)</code>
    /// </summary>
    /// <param name="from">The source CSpellBase whose properties are duplicated into the new object.</param>
    public void _ConstructorInternal(ACBindings.Internal.CSpellBase* from) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, ACBindings.Internal.CSpellBase*, void>)0x00597CD0)(ref this, from);

    /// <summary>Retrieves and decodes the spell’s description text, storing the resulting string reference in the supplied output parameter.
    /// <code>Offset: 0x00597DB0
    /// int* __thiscall CSpellBase::InqDescription(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer where the decoded description string’s address will be written.</param>
    /// <returns>The same pointer that was passed in, now pointing to a string reference containing the spell’s description.</returns>
    public int* InqDescription(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, int*, int*>)0x00597DB0)(ref this, a2);

    /// <summary>Copies the spell's encrypted component list into the supplied SpellFormula object, decrypting it using the spell's name and description hashes.
    /// <code>Offset: 0x00597E20
    /// SpellFormula* __thiscall CSpellBase::InqSpellFormula(CSpellBase*,SpellFormula*)</code>
    /// </summary>
    /// <param name="result">The SpellFormula instance to populate with decrypted components.</param>
    /// <returns>The same pointer passed in as result, now containing the decoded component data.</returns>
    public ACBindings.Internal.SpellFormula* InqSpellFormula(ACBindings.Internal.SpellFormula* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, ACBindings.Internal.SpellFormula*, ACBindings.Internal.SpellFormula*>)0x00597E20)(ref this, result);

    /// <summary>Retrieves and customizes the spell formula for this spell, randomizing its components based on the supplied seed, then stores the resulting formula in a provided buffer.
    /// <code>Offset: 0x00597F70
    /// void*** __thiscall CSpellBase::InqCustomizedSpellFormula(CSpellBase*,void***,int*)</code>
    /// </summary>
    /// <param name="a2">Output buffer that receives a pointer to the customized SpellFormula object followed by its component data. The first element is set to the SpellFormula vtable address, and subsequent elements contain the randomized component values.</param>
    /// <param name="a3">Seed or identifier used during the randomization of the spell formula components.</param>
    /// <returns>The same pointer passed in as a2, enabling method chaining or direct use of the populated buffer.</returns>
    public void*** InqCustomizedSpellFormula(void*** a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, void***, int*, void***>)0x00597F70)(ref this, a2, a3);

    /// <summary>Retrieves a spell’s formula, filters it to keep only components eligible for scarab usage, and adds additional scarab components based on the most powerful component type found. The processed formula is stored in the supplied result buffer.
    /// <code>Offset: 0x00597FC0
    /// SpellFormula* __thiscall CSpellBase::InqScarabOnlyFormula(CSpellBase*,SpellFormula*)</code>
    /// </summary>
    /// <param name="this">The spell instance whose formula is being queried.</param>
    /// <param name="result">Buffer to receive the filtered and augmented spell formula.</param>
    /// <returns>Pointer to the provided result containing the updated formula.</returns>
    public ACBindings.Internal.SpellFormula* InqScarabOnlyFormula(ACBindings.Internal.SpellFormula* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, ACBindings.Internal.SpellFormula*, ACBindings.Internal.SpellFormula*>)0x00597FC0)(ref this, result);

    /// <summary>Retrieves the targeting type for this spell, returning the target type identifier when the spell’s formula is complete; otherwise returns 0.
    /// <code>Offset: 0x005981A0
    /// unsigned int __thiscall CSpellBase::InqTargetType(CSpellBase*)</code>
    /// </summary>
    /// <returns>The target type identifier if the formula is valid and complete; otherwise zero.</returns>
    public uint InqTargetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, uint>)0x005981A0)(ref this);

    /// <summary>Provides a rough estimate of the spell’s level by examining its formula’s power component and applying heuristic adjustments.
    /// <code>Offset: 0x005981D0
    /// unsigned int __thiscall CSpellBase::InqSpellLevelByRoughHeuristic(CSpellBase*)</code>
    /// </summary>
    /// <returns>An unsigned integer representing the inferred spell level after heuristics; typically reduced for high‑power components.</returns>
    public uint InqSpellLevelByRoughHeuristic() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, uint>)0x005981D0)(ref this);

    /// <summary>Unpacks serialized spell data from the provided buffer into the current instance.
    /// <code>Offset: 0x00598200
    /// int __thiscall CSpellBase::UnPack(CSpellBase*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a buffer address that will be advanced as data is consumed during unpacking.</param>
    /// <param name="size">Number of bytes remaining in the buffer; if insufficient for any field, the operation fails and restores the original address.</param>
    /// <returns>1 on successful unpack; 0 if the buffer does not contain enough data to fill all fields.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, void**, uint, int>)0x00598200)(ref this, addr, size);

    /// <summary>Converts a spell school enumeration into its corresponding name and stores it in the supplied string buffer.
    /// <code>Offset: 0x00598370
    /// _DWORD* __cdecl CSpellBase::SchoolEnumToName(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to receive the resulting string pointer; the function writes the name into this location.</param>
    /// <param name="a2">Integer representing the spell school (e.g., 1=War Magic, 2=Life Magic, etc.).</param>
    /// <returns>Same pointer passed in as a1, now pointing to the name string.</returns>
    public static int* SchoolEnumToName(int* a1, int a2) => ((delegate* unmanaged[Cdecl]<int*, int, int*>)0x00598370)(a1, a2);

    /// <summary>Determines whether a spell has no target requirement by examining its targeting type in the formula.
    /// <code>Offset: 0x00598410
    /// int __thiscall CSpellBase::IsUntargeted(CSpellBase*)</code>
    /// </summary>
    /// <returns>Non‑zero if the spell is untargeted; zero otherwise.</returns>
    public int IsUntargeted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellBase, int>)0x00598410)(ref this);
}

