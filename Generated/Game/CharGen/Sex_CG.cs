namespace ACBindings.Internal;


/// <summary>Represents a character model configuration, encapsulating base appearance data, animation resources, and customizable hair, eye, facial, and clothing options for a specific gender.</summary>
public unsafe struct Sex_CG : System.IDisposable
{
    // Child Types

    /// <summary>Defines the virtual function table for Sex_CG objects, exposing a Serialize method that writes or reads object state to or from an Archive.</summary>
    public unsafe struct Sex_CG_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Sex_CG*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

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

    /// <summary>Releases resources held by a Sex_CG object, including deleting dynamically allocated arrays, invoking subobject destructors, resetting the virtual function table, and freeing the name string buffer when its reference count reaches zero.
    /// <code>Offset: 0x0047DAA0
    /// void __thiscall Sex_CG::~Sex_CG(Sex_CG*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Sex_CG, void>)0x0047DAA0)(ref this);

    /// <summary>Collects all qualified data identifiers belonging to a Sex_CG instance into the supplied QualifiedDataIDArray, including base properties and every subcomponent such as hair styles, eye strips, facial features, clothing items, and color sets.
    /// <code>Offset: 0x005C0380
    /// void __thiscall Sex_CG::GetSubDataIDs(Sex_CG*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that receives the collected IDs.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Sex_CG, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005C0380)(ref this, id_array);

    /// <summary>Initializes a new Sex_CG instance with default settings, including an empty name string, zero scaling, invalid identifiers for all data tables, and cleared collections of hair, eye, face, clothing items, and colors.
    /// <code>Offset: 0x005C12A0
    /// void __thiscall Sex_CG::Sex_CG(Sex_CG*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Sex_CG, void>)0x005C12A0)(ref this);

    /// <summary>Copies all properties from another Sex_CG instance into this object, duplicating nested structures and adjusting shared string reference counts appropriately.
    /// <code>Offset: 0x005C2460
    /// void __thiscall Sex_CG::Sex_CG(Sex_CG*,const Sex_CG*)</code>
    /// </summary>
    /// <param name="that">The source Sex_CG whose state is replicated by this constructor.</param>
    public void _ConstructorInternal(ACBindings.Internal.Sex_CG* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Sex_CG, ACBindings.Internal.Sex_CG*, void>)0x005C2460)(ref this, that);

    /// <summary>Serializes all member data of a Sex_CG object into or from an Archive, handling both reading and writing based on archive flags.
    /// <code>Offset: 0x005C25E0
    /// void __thiscall Sex_CG::Serialize(Sex_CG*,Archive*)</code>
    /// </summary>
    /// <param name="this">The Sex_CG instance whose fields are being serialized.</param>
    /// <param name="io_archive">Archive used for input or output; serialization behavior depends on its mode flag.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Sex_CG, ACBindings.Internal.Archive*, void>)0x005C25E0)(ref this, io_archive);
}

