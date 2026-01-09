namespace ACBindings;

// HairStyle_CG
public unsafe struct HairStyle_CG
{
    // Child Types
    // HairStyle_CG_vtbl
    public unsafe struct HairStyle_CG_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.IDClass___tagDataID iconImage;
    public byte bald;
    public ACBindings.IDClass___tagDataID alternateSetup;
    public ACBindings.ObjDesc objDesc;

    // Generated Constructor
    public HairStyle_CG(ACBindings.HairStyle_CG* that) {
        _ConstructorInternal(that);
    }
    public HairStyle_CG() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall HairStyle_CG::HairStyle_CG(HairStyle_CG*,const HairStyle_CG*)
    public void _ConstructorInternal(ACBindings.HairStyle_CG* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HairStyle_CG, ACBindings.HairStyle_CG*, void>)0x004DF000)(ref this, that);
    // void __thiscall HairStyle_CG::HairStyle_CG(HairStyle_CG*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.HairStyle_CG, void>)0x005BEB20)(ref this);
    // void __thiscall HairStyle_CG::Serialize(HairStyle_CG*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.HairStyle_CG, ACBindings.Archive*, void>)0x005BEB50)(ref this, io_archive);
}

