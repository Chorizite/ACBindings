namespace ACBindings.Internal;

public unsafe struct HeritageGroup_CG : System.IDisposable
{
    // Child Types
    public unsafe struct HeritageGroup_CG_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HeritageGroup_CG*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x0047E300
    /// void __thiscall HeritageGroup_CG::~HeritageGroup_CG(HeritageGroup_CG*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HeritageGroup_CG, void>)0x0047E300)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C15B0
    /// void __thiscall HeritageGroup_CG::GetSubDataIDs(HeritageGroup_CG*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HeritageGroup_CG, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005C15B0)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x005C2B30
    /// const Sex_CG* __thiscall HeritageGroup_CG::GetSX(HeritageGroup_CG*,const Sex_CG*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.Sex_CG* GetSX(ACBindings.Internal.Sex_CG* result, uint gender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HeritageGroup_CG, ACBindings.Internal.Sex_CG*, uint, ACBindings.Internal.Sex_CG*>)0x005C2B30)(ref this, result, gender);

    /// <summary>
    /// <code>Offset: 0x005C3060
    /// void __thiscall HeritageGroup_CG::HeritageGroup_CG(HeritageGroup_CG*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HeritageGroup_CG, void>)0x005C3060)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C30E0
    /// void __thiscall HeritageGroup_CG::Serialize(HeritageGroup_CG*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HeritageGroup_CG, ACBindings.Internal.Archive*, void>)0x005C30E0)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x005C32C0
    /// void __thiscall HeritageGroup_CG::HeritageGroup_CG(HeritageGroup_CG*,const HeritageGroup_CG*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.HeritageGroup_CG* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HeritageGroup_CG, ACBindings.Internal.HeritageGroup_CG*, void>)0x005C32C0)(ref this, that);
}

