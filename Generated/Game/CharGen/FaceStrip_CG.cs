namespace ACBindings.Internal;

public unsafe struct FaceStrip_CG
{
    // Child Types
    public unsafe struct FaceStrip_CG_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FaceStrip_CG*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.IDClass____tagDataID iconImage;
    public ACBindings.Internal.ObjDesc objDesc;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005BECA0
    /// void __thiscall FaceStrip_CG::Serialize(FaceStrip_CG*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FaceStrip_CG, ACBindings.Internal.Archive*, void>)0x005BECA0)(ref this, io_archive);
}

