namespace ACBindings.Internal;


/// <summary>Represents hair styling data for characters, encapsulating an icon reference, baldness flag, optional alternate setup, and detailed object description.</summary>
public unsafe struct HairStyle_CG
{
    // Child Types

    /// <summary>Defines the virtual function table for HairStyle_CG, enabling serialization of hairstyle data.</summary>
    public unsafe struct HairStyle_CG_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.HairStyle_CG*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.IDClass____tagDataID iconImage;
    public byte bald;
    public ACBindings.Internal.IDClass____tagDataID alternateSetup;
    public ACBindings.Internal.ObjDesc objDesc;

    // Generated Constructor
    public HairStyle_CG(ACBindings.Internal.HairStyle_CG* that) {
        _ConstructorInternal(that);
    }
    public HairStyle_CG() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Creates a HairStyle_CG by copying the icon image, bald flag, alternate setup, and object description from another instance.
    /// <code>Offset: 0x004DF000
    /// void __thiscall HairStyle_CG::HairStyle_CG(HairStyle_CG*,const HairStyle_CG*)</code>
    /// </summary>
    /// <param name="that">The source HairStyle_CG whose data is duplicated into the new instance.</param>
    public void _ConstructorInternal(ACBindings.Internal.HairStyle_CG* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HairStyle_CG, ACBindings.Internal.HairStyle_CG*, void>)0x004DF000)(ref this, that);

    /// <summary>Initializes a HairStyle_CG instance, assigning its virtual table, defaulting icon and alternate setup IDs to invalid values, marking the style as not bald, and constructing an associated ObjDesc.
    /// <code>Offset: 0x005BEB20
    /// void __thiscall HairStyle_CG::HairStyle_CG(HairStyle_CG*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HairStyle_CG, void>)0x005BEB20)(ref this);

    /// <summary>Serializes HairStyle_CG data to or from an Archive, handling icon image ID, bald flag, alternate setup ID, and object description.
    /// <code>Offset: 0x005BEB50
    /// void __thiscall HairStyle_CG::Serialize(HairStyle_CG*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive instance used for reading or writing the object's state.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HairStyle_CG, ACBindings.Internal.Archive*, void>)0x005BEB50)(ref this, io_archive);
}

