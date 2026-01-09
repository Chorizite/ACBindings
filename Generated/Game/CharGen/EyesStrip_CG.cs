namespace ACBindings;

// EyesStrip_CG
public unsafe struct EyesStrip_CG
{
    // Child Types
    // EyesStrip_CG_vtbl
    public unsafe struct EyesStrip_CG_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.IDClass___tagDataID iconImage;
    public ACBindings.IDClass___tagDataID iconImage_Bald;
    public ACBindings.ObjDesc objDesc;
    public ACBindings.ObjDesc objDesc_Bald;

    // Methods
    // void __thiscall EyesStrip_CG::Serialize(EyesStrip_CG*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EyesStrip_CG, ACBindings.Archive*, void>)0x005BEC00)(ref this, io_archive);
}

