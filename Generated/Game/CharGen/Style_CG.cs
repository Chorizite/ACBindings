namespace ACBindings;

// Style_CG
public unsafe struct Style_CG
{
    // Child Types
    // Style_CG_vtbl
    public unsafe struct Style_CG_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.PStringBase__sbyte name;
    public ACBindings.IDClass___tagDataID clothingTable;
    public ACBindings.IDClass___tagDataID weenieDefault;

    // Generated Constructor
    public Style_CG(ACBindings.Style_CG* style) {
        _ConstructorInternal(style);
    }

    // Methods
    // void __thiscall Style_CG::Style_CG(Style_CG*,Style_CG*)
    public void _ConstructorInternal(ACBindings.Style_CG* style) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Style_CG, ACBindings.Style_CG*, void>)0x005BFA20)(ref this, style);
    // void __thiscall Style_CG::Serialize(Style_CG*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Style_CG, ACBindings.Archive*, void>)0x005C13C0)(ref this, io_archive);
}

