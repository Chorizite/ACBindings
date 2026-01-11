namespace ACBindings.Internal;

public unsafe struct Sex_CG : System.IDisposable
{
    // Child Types
    public unsafe struct Sex_CG_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Sex_CG*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.PStringBase__sbyte name;
    public int scaling;
    public ACBindings.Internal.IDClass____tagDataID setup;
    public ACBindings.Internal.IDClass____tagDataID soundTable;
    public ACBindings.Internal.IDClass____tagDataID iconImage;
    public ACBindings.Internal.ObjDesc objDesc;
    public ACBindings.Internal.IDClass____tagDataID physicsTable;
    public ACBindings.Internal.IDClass____tagDataID motionTable;
    public ACBindings.Internal.IDClass____tagDataID combatTable;
    public ACBindings.Internal.IDClass____tagDataID basePalette;
    public ACBindings.Internal.IDClass____tagDataID skinPalSet;
    public ACBindings.Internal.SmartArray___IDClass____tagDataID mHairColorList;
    public ACBindings.Internal.SmartArray___HairStyle_CG mHairStyleList;
    public ACBindings.Internal.SmartArray___IDClass____tagDataID mEyeColorList;
    public ACBindings.Internal.SmartArray___EyesStrip_CG mEyeStripList;
    public ACBindings.Internal.SmartArray___FaceStrip_CG mNoseStripList;
    public ACBindings.Internal.SmartArray___FaceStrip_CG mMouthStripList;
    public ACBindings.Internal.SmartArray___Style_CG mHeadgearList;
    public ACBindings.Internal.SmartArray___Style_CG mShirtList;
    public ACBindings.Internal.SmartArray___Style_CG mPantsList;
    public ACBindings.Internal.SmartArray___Style_CG mFootwearList;
    public ACBindings.Internal.SmartArray__uint mClothingColorsList;

    // Generated Constructor
    public Sex_CG() {
        _ConstructorInternal();
    }
    public Sex_CG(ACBindings.Internal.Sex_CG* that) {
        _ConstructorInternal(that);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0047DAA0
    /// void __thiscall Sex_CG::~Sex_CG(Sex_CG*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Sex_CG, void>)0x0047DAA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C0380
    /// void __thiscall Sex_CG::GetSubDataIDs(Sex_CG*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Sex_CG, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005C0380)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x005C12A0
    /// void __thiscall Sex_CG::Sex_CG(Sex_CG*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Sex_CG, void>)0x005C12A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C2460
    /// void __thiscall Sex_CG::Sex_CG(Sex_CG*,const Sex_CG*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.Sex_CG* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Sex_CG, ACBindings.Internal.Sex_CG*, void>)0x005C2460)(ref this, that);

    /// <summary>
    /// <code>Offset: 0x005C25E0
    /// void __thiscall Sex_CG::Serialize(Sex_CG*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Sex_CG, ACBindings.Internal.Archive*, void>)0x005C25E0)(ref this, io_archive);
}

