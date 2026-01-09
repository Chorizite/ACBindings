namespace ACBindings;

// HeritageGroup_CG
public unsafe struct HeritageGroup_CG : System.IDisposable
{
    // Child Types
    // HeritageGroup_CG_vtbl
    public unsafe struct HeritageGroup_CG_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.PStringBase__sbyte name;
    public ACBindings.IDClass___tagDataID iconImage;
    public ACBindings.IDClass___tagDataID setupID;
    public ACBindings.IDClass___tagDataID environmentSetupID;
    public int numAttributeCredits;
    public int numSkillCredits;
    public ACBindings.SmartArray__uint mPrimaryStartAreaList;
    public ACBindings.SmartArray__uint mSecondaryStartAreaList;
    public ACBindings.SmartArray__Skill_CG mSkillList;
    public ACBindings.SmartArray__Template_CG mTemplateList;
    public ACBindings.HashTable__uint__Sex_CG mGenderList;

    // Generated Constructor
    public HeritageGroup_CG() {
        _ConstructorInternal();
    }
    public HeritageGroup_CG(ACBindings.HeritageGroup_CG* that) {
        _ConstructorInternal(that);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall HeritageGroup_CG::~HeritageGroup_CG(HeritageGroup_CG*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HeritageGroup_CG, void>)0x0047E300)(ref this);
    // void __thiscall HeritageGroup_CG::GetSubDataIDs(HeritageGroup_CG*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HeritageGroup_CG, ACBindings.QualifiedDataIDArray*, void>)0x005C15B0)(ref this, id_array);
    // const Sex_CG* __thiscall HeritageGroup_CG::GetSX(HeritageGroup_CG*,const Sex_CG*,unsigned int)
    public ACBindings.Sex_CG* GetSX(ACBindings.Sex_CG* result, uint gender) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HeritageGroup_CG, ACBindings.Sex_CG*, uint, ACBindings.Sex_CG*>)0x005C2B30)(ref this, result, gender);
    // void __thiscall HeritageGroup_CG::HeritageGroup_CG(HeritageGroup_CG*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HeritageGroup_CG, void>)0x005C3060)(ref this);
    // void __thiscall HeritageGroup_CG::Serialize(HeritageGroup_CG*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HeritageGroup_CG, ACBindings.Archive*, void>)0x005C30E0)(ref this, io_archive);
    // void __thiscall HeritageGroup_CG::HeritageGroup_CG(HeritageGroup_CG*,const HeritageGroup_CG*)
    public void _ConstructorInternal(ACBindings.HeritageGroup_CG* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HeritageGroup_CG, ACBindings.HeritageGroup_CG*, void>)0x005C32C0)(ref this, that);
}

