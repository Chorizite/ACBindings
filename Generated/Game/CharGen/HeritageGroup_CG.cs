namespace ACBindings.Internal;


/// <summary>Holds data for a heritage group, including name, identifiers, credit counts, start areas, skills, templates, and gender‑specific details.</summary>
public unsafe struct HeritageGroup_CG : System.IDisposable
{
    // Child Types

    /// <summary>Defines the virtual function table for HeritageGroup_CG, exposing a Serialize method that writes the object's state into an Archive.</summary>
    public unsafe struct HeritageGroup_CG_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HeritageGroup_CG*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.PStringBase__sbyte name;
    public ACBindings.Internal.IDClass____tagDataID iconImage;
    public ACBindings.Internal.IDClass____tagDataID setupID;
    public ACBindings.Internal.IDClass____tagDataID environmentSetupID;
    public int numAttributeCredits;
    public int numSkillCredits;
    public ACBindings.Internal.SmartArray__uint mPrimaryStartAreaList;
    public ACBindings.Internal.SmartArray__uint mSecondaryStartAreaList;
    public ACBindings.Internal.SmartArray___Skill_CG mSkillList;
    public ACBindings.Internal.SmartArray___Template_CG mTemplateList;
    public ACBindings.Internal.HashTable__uint___Sex_CG mGenderList;

    // Generated Constructor
    public HeritageGroup_CG() {
        _ConstructorInternal();
    }
    public HeritageGroup_CG(ACBindings.Internal.HeritageGroup_CG* that) {
        _ConstructorInternal(that);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a HeritageGroup_CG instance, freeing all allocated memory for its gender hash table, template list, skill list, primary and secondary start area lists, and the associated name string buffer.
    /// <code>Offset: 0x0047E300
    /// void __thiscall HeritageGroup_CG::~HeritageGroup_CG(HeritageGroup_CG*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HeritageGroup_CG, void>)0x0047E300)(ref this);

    /// <summary>Collects all relevant data identifiers from the heritage group into the supplied array, including icon, setup, environment, template icons, and gender-specific IDs.
    /// <code>Offset: 0x005C15B0
    /// void __thiscall HeritageGroup_CG::GetSubDataIDs(HeritageGroup_CG*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The destination QualifiedDataIDArray to which collected IDs are appended.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HeritageGroup_CG, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005C15B0)(ref this, id_array);

    /// <summary>Retrieves a copy of the Sex_CG entry for the specified gender from this HeritageGroup_CG and stores it in the supplied result object.
    /// <code>Offset: 0x005C2B30
    /// const Sex_CG* __thiscall HeritageGroup_CG::GetSX(HeritageGroup_CG*,const Sex_CG*,unsigned int)</code>
    /// </summary>
    /// <param name="result">The Sex_CG instance to populate with the retrieved data. The caller owns this object; it is overwritten by the function.</param>
    /// <param name="gender">Identifier of the desired gender within the group's internal map.</param>
    /// <returns>Pointer to the populated result, or a default‑constructed Sex_CG if no matching entry exists.</returns>
    public ACBindings.Internal.Sex_CG* GetSX(ACBindings.Internal.Sex_CG* result, uint gender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HeritageGroup_CG, ACBindings.Internal.Sex_CG*, uint, ACBindings.Internal.Sex_CG*>)0x005C2B30)(ref this, result, gender);

    /// <summary>Initializes a new HeritageGroup_CG instance by assigning its vtable, clearing the name string, setting icon, setup, and environment IDs to invalid values, resetting credit counters, emptying all smart arrays, and constructing an intrusive hash table with an initial size of 23.
    /// <code>Offset: 0x005C3060
    /// void __thiscall HeritageGroup_CG::HeritageGroup_CG(HeritageGroup_CG*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HeritageGroup_CG, void>)0x005C3060)(ref this);

    /// <summary>
    /// Serializes this heritage group's properties—including name, identifiers, credit counts, start areas, skills, templates, and gender data—to or from the provided Archive, handling both write and read modes according to the archive's flags.
    /// 
    /// <code>Offset: 0x005C30E0
    /// void __thiscall HeritageGroup_CG::Serialize(HeritageGroup_CG*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for reading or writing the object's state.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HeritageGroup_CG, ACBindings.Internal.Archive*, void>)0x005C30E0)(ref this, io_archive);

    /// <summary>Creates a new HeritageGroup instance by copying all data fields from an existing group.
    /// <code>Offset: 0x005C32C0
    /// void __thiscall HeritageGroup_CG::HeritageGroup_CG(HeritageGroup_CG*,const HeritageGroup_CG*)</code>
    /// </summary>
    /// <param name="that">The source heritage group whose contents are duplicated.</param>
    public void _ConstructorInternal(ACBindings.Internal.HeritageGroup_CG* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HeritageGroup_CG, ACBindings.Internal.HeritageGroup_CG*, void>)0x005C32C0)(ref this, that);
}

