namespace ACBindings;

// Template_CG
public unsafe struct Template_CG : System.IDisposable
{
    // Child Types
    // Template_CG_vtbl
    public unsafe struct Template_CG_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.PStringBase__sbyte name;
    public ACBindings.IDClass___tagDataID iconImage;
    public uint titleID;
    public int strength;
    public int endurance;
    public int coordination;
    public int quickness;
    public int focus;
    public int self;
    public ACBindings.SmartArray__int mNormalSkillsList;
    public ACBindings.SmartArray__int mPrimarySkillsList;

    // Generated Constructor
    public Template_CG() {
        _ConstructorInternal();
    }
    public Template_CG(ACBindings.Template_CG* that) {
        _ConstructorInternal(that);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall Template_CG::~Template_CG(Template_CG*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Template_CG, void>)0x0047D7D0)(ref this);
    // void __thiscall Template_CG::Template_CG(Template_CG*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Template_CG, void>)0x005BFA90)(ref this);
    // void __thiscall Template_CG::Serialize(Template_CG*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Template_CG, ACBindings.Archive*, void>)0x005C1430)(ref this, io_archive);
    // void __thiscall Template_CG::Template_CG(Template_CG*,const Template_CG*)
    public void _ConstructorInternal(ACBindings.Template_CG* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Template_CG, ACBindings.Template_CG*, void>)0x005C5CF0)(ref this, that);
}

