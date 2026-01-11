namespace ACBindings.Internal;

public unsafe struct Style_CG
{
    // Child Types
    public unsafe struct Style_CG_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Style_CG*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x005BFA20
    /// void __thiscall Style_CG::Style_CG(Style_CG*,Style_CG*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.Style_CG* style) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Style_CG, ACBindings.Internal.Style_CG*, void>)0x005BFA20)(ref this, style);

    /// <summary>
    /// <code>Offset: 0x005C13C0
    /// void __thiscall Style_CG::Serialize(Style_CG*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Style_CG, ACBindings.Internal.Archive*, void>)0x005C13C0)(ref this, io_archive);
}

