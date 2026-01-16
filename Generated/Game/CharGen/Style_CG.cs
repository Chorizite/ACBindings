namespace ACBindings.Internal;


/// <summary>Encapsulates style information for CG objects, holding a name string and two identifier classes for the clothing table and default weenie; supports serialization and reference‑counted string management.</summary>
public unsafe struct Style_CG
{
    // Child Types

    /// <summary>Represents the virtual function table for Style_CG objects, defining how they serialize into an Archive.</summary>
    public unsafe struct Style_CG_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Style_CG*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.PStringBase__sbyte name;
    public ACBindings.Internal.IDClass____tagDataID clothingTable;
    public ACBindings.Internal.IDClass____tagDataID weenieDefault;

    // Generated Constructor
    public Style_CG(ACBindings.Internal.Style_CG* style) {
        _ConstructorInternal(style);
    }

    // Methods

    /// <summary>Initializes a new Style_CG by copying name, clothingTable and weenieDefault identifiers from another Style_CG instance, handling reference counting of the underlying string buffer.
    /// <code>Offset: 0x005BFA20
    /// void __thiscall Style_CG::Style_CG(Style_CG*,Style_CG*)</code>
    /// </summary>
    /// <param name="style">The source Style_CG whose data will be copied into this object.</param>
    public void _ConstructorInternal(ACBindings.Internal.Style_CG* style) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Style_CG, ACBindings.Internal.Style_CG*, void>)0x005BFA20)(ref this, style);

    /// <summary>Serializes or deserializes the Style_CG object's data—including its name and two IDClass identifiers—to or from an Archive based on the archive's mode flag.
    /// <code>Offset: 0x005C13C0
    /// void __thiscall Style_CG::Serialize(Style_CG*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used to read or write the object's state.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Style_CG, ACBindings.Internal.Archive*, void>)0x005C13C0)(ref this, io_archive);
}

