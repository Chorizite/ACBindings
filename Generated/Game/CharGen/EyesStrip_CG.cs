namespace ACBindings.Internal;

public unsafe struct EyesStrip_CG
{
    // Child Types
    public unsafe struct EyesStrip_CG_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.EyesStrip_CG*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.IDClass____tagDataID iconImage;
    public ACBindings.Internal.IDClass____tagDataID iconImage_Bald;
    public ACBindings.Internal.ObjDesc objDesc;
    public ACBindings.Internal.ObjDesc objDesc_Bald;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005BEC00
    /// void __thiscall EyesStrip_CG::Serialize(EyesStrip_CG*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EyesStrip_CG, ACBindings.Internal.Archive*, void>)0x005BEC00)(ref this, io_archive);
}

