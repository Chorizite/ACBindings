namespace ACBindings;

// Sex_CG
public unsafe struct Sex_CG : System.IDisposable
{
    // Child Types
    // Sex_CG_vtbl
    public unsafe struct Sex_CG_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.PStringBase__sbyte name;
    public int scaling;
    public ACBindings.IDClass___tagDataID setup;
    public ACBindings.IDClass___tagDataID soundTable;
    public ACBindings.IDClass___tagDataID iconImage;
    public ACBindings.ObjDesc objDesc;
    public ACBindings.IDClass___tagDataID physicsTable;
    public ACBindings.IDClass___tagDataID motionTable;
    public ACBindings.IDClass___tagDataID combatTable;
    public ACBindings.IDClass___tagDataID basePalette;
    public ACBindings.IDClass___tagDataID skinPalSet;
    public ACBindings.SmartArray__IDClass___tagDataID mHairColorList;
    public ACBindings.SmartArray__HairStyle_CG mHairStyleList;
    public ACBindings.SmartArray__IDClass___tagDataID mEyeColorList;
    public ACBindings.SmartArray__EyesStrip_CG mEyeStripList;
    public ACBindings.SmartArray__FaceStrip_CG mNoseStripList;
    public ACBindings.SmartArray__FaceStrip_CG mMouthStripList;
    public ACBindings.SmartArray__Style_CG mHeadgearList;
    public ACBindings.SmartArray__Style_CG mShirtList;
    public ACBindings.SmartArray__Style_CG mPantsList;
    public ACBindings.SmartArray__Style_CG mFootwearList;
    public ACBindings.SmartArray__uint mClothingColorsList;

    // Generated Constructor
    public Sex_CG() {
        _ConstructorInternal();
    }
    public Sex_CG(ACBindings.Sex_CG* that) {
        _ConstructorInternal(that);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall Sex_CG::~Sex_CG(Sex_CG*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Sex_CG, void>)0x0047DAA0)(ref this);
    // void __thiscall Sex_CG::GetSubDataIDs(Sex_CG*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Sex_CG, ACBindings.QualifiedDataIDArray*, void>)0x005C0380)(ref this, id_array);
    // void __thiscall Sex_CG::Sex_CG(Sex_CG*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Sex_CG, void>)0x005C12A0)(ref this);
    // void __thiscall Sex_CG::Sex_CG(Sex_CG*,const Sex_CG*)
    public void _ConstructorInternal(ACBindings.Sex_CG* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Sex_CG, ACBindings.Sex_CG*, void>)0x005C2460)(ref this, that);
    // void __thiscall Sex_CG::Serialize(Sex_CG*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Sex_CG, ACBindings.Archive*, void>)0x005C25E0)(ref this, io_archive);
}

