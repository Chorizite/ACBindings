namespace ACBindings;

// FaceStrip_CG
public unsafe struct FaceStrip_CG
{
    // Child Types
    // FaceStrip_CG_vtbl
    public unsafe struct FaceStrip_CG_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.IDClass___tagDataID iconImage;
    public ACBindings.ObjDesc objDesc;

    // Methods
    // void __thiscall FaceStrip_CG::Serialize(FaceStrip_CG*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.FaceStrip_CG, ACBindings.Archive*, void>)0x005BECA0)(ref this, io_archive);
}

