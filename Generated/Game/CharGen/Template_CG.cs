namespace ACBindings.Internal;

public unsafe struct Template_CG : System.IDisposable
{
    // Child Types
    public unsafe struct Template_CG_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Template_CG*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.PStringBase__sbyte name;
    public ACBindings.Internal.IDClass____tagDataID iconImage;
    public uint titleID;
    public int strength;
    public int endurance;
    public int coordination;
    public int quickness;
    public int focus;
    public int self;
    public ACBindings.Internal.SmartArray__int mNormalSkillsList;
    public ACBindings.Internal.SmartArray__int mPrimarySkillsList;

    // Generated Constructor
    public Template_CG() {
        _ConstructorInternal();
    }
    public Template_CG(ACBindings.Internal.Template_CG* that) {
        _ConstructorInternal(that);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0047D7D0
    /// void __thiscall Template_CG::~Template_CG(Template_CG*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Template_CG, void>)0x0047D7D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BFA90
    /// void __thiscall Template_CG::Template_CG(Template_CG*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Template_CG, void>)0x005BFA90)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C1430
    /// void __thiscall Template_CG::Serialize(Template_CG*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Template_CG, ACBindings.Internal.Archive*, void>)0x005C1430)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x005C5CF0
    /// void __thiscall Template_CG::Template_CG(Template_CG*,const Template_CG*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.Template_CG* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Template_CG, ACBindings.Internal.Template_CG*, void>)0x005C5CF0)(ref this, that);
}

