namespace ACBindings.Internal;


/// <summary>
/// Represents a skill definition used by the game engine, holding metadata such as name, description, icon, cost and level requirements along with formulaic bounds for scaling.
/// </summary>
public unsafe struct SkillBase : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SkillBase_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillBase*, void> SkillBase_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillBase*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillBase*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillBase*, void**, uint, int> UnPack; // function pointer

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

    /// <summary>Initializes a new SkillBase instance with default values, setting string buffers to empty, costs and bounds to zero, category and level to undefined, icon ID to an invalid identifier, and a default skill formula.
    /// <code>Offset: 0x004F1EF0
    /// void __thiscall SkillBase::SkillBase(SkillBase*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillBase, void>)0x004F1EF0)(ref this);

    /// <summary>Releases the name and description buffers owned by a SkillBase instance, decrementing their reference counts and freeing them when the count reaches zero; subsequently restores base class virtual table pointers to their default state.
    /// <code>Offset: 0x004F1F70
    /// void __thiscall SkillBase::~SkillBase(SkillBase*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillBase, void>)0x004F1F70)(ref this);

    /// <summary>Serializes a SkillBase instance into a contiguous memory buffer when the supplied space is sufficient; otherwise returns the byte count needed.
    /// <code>Offset: 0x005CC0A0
    /// unsigned int __thiscall SkillBase::Pack(SkillBase*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of the destination buffer; on success, advanced to point past the last written byte.</param>
    /// <param name="size">Maximum number of bytes available for serialization.</param>
    /// <returns>Byte count required to pack the SkillBase object (the amount actually written if size sufficed).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillBase, void**, uint, uint>)0x005CC0A0)(ref this, addr, size);

    /// <summary>Unpacks serialized skill data into the current SkillBase object.
    /// <code>Offset: 0x005CC1A0
    /// int __thiscall SkillBase::UnPack(SkillBase*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the buffer containing packed skill information.</param>
    /// <param name="size">Total size of the packed data available at addr.</param>
    /// <returns>1 on successful unpack; 0 if the provided data is incomplete or invalid.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillBase, void**, uint, int>)0x005CC1A0)(ref this, addr, size);

    /// <summary>Creates a new SkillBase instance by copying all data from an existing one.
    /// <code>Offset: 0x005CC9C0
    /// void __thiscall SkillBase::SkillBase(SkillBase*,const SkillBase*)</code>
    /// </summary>
    /// <param name="that">The source SkillBase whose fields are duplicated into the newly constructed object.</param>
    public void _ConstructorInternal(ACBindings.Internal.SkillBase* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillBase, ACBindings.Internal.SkillBase*, void>)0x005CC9C0)(ref this, that);
}

