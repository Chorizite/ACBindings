namespace ACBindings.Internal;

public unsafe struct HairStyle_CG
{
    // Child Types
    public unsafe struct HairStyle_CG_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.HairStyle_CG*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004DF000
    /// void __thiscall HairStyle_CG::HairStyle_CG(HairStyle_CG*,const HairStyle_CG*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.HairStyle_CG* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HairStyle_CG, ACBindings.Internal.HairStyle_CG*, void>)0x004DF000)(ref this, that);

    /// <summary>
    /// <code>Offset: 0x005BEB20
    /// void __thiscall HairStyle_CG::HairStyle_CG(HairStyle_CG*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HairStyle_CG, void>)0x005BEB20)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BEB50
    /// void __thiscall HairStyle_CG::Serialize(HairStyle_CG*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.HairStyle_CG, ACBindings.Internal.Archive*, void>)0x005BEB50)(ref this, io_archive);
}

