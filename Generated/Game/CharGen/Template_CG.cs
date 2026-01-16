namespace ACBindings.Internal;


/// <summary>Represents a character template containing identification, display information, core attributes, and skill sets. It serves as the blueprint for creating character instances with predefined stats and abilities.</summary>
public unsafe struct Template_CG : System.IDisposable
{
    // Child Types

    /// <summary>Provides the virtual function table for Template_CG, defining how instances are serialized into an Archive.</summary>
    public unsafe struct Template_CG_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Template_CG*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

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

    /// <summary>Destroys a Template_CG instance, freeing its dynamic skill lists and decrementing the reference count of its name buffer to trigger cleanup when no longer used.
    /// <code>Offset: 0x0047D7D0
    /// void __thiscall Template_CG::~Template_CG(Template_CG*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Template_CG, void>)0x0047D7D0)(ref this);

    /// <summary>Initializes a new Template_CG instance with default values for name, title ID, attribute statistics, icon image identifier, and empty skill lists, while correctly handling reference counting for the shared null string buffer.
    /// <code>Offset: 0x005BFA90
    /// void __thiscall Template_CG::Template_CG(Template_CG*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Template_CG, void>)0x005BFA90)(ref this);

    /// <summary>Serializes or deserializes Template_CG fields to an Archive based on operation mode.
    /// <code>Offset: 0x005C1430
    /// void __thiscall Template_CG::Serialize(Template_CG*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for reading or writing object data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Template_CG, ACBindings.Internal.Archive*, void>)0x005C1430)(ref this, io_archive);

    /// <summary>Creates a new Template_CG instance by copying all properties from an existing one, including the name reference count, icon image ID, title ID, stat values, and skill lists.
    /// <code>Offset: 0x005C5CF0
    /// void __thiscall Template_CG::Template_CG(Template_CG*,const Template_CG*)</code>
    /// </summary>
    /// <param name="that">The Template_CG object to copy data from.</param>
    public void _ConstructorInternal(ACBindings.Internal.Template_CG* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Template_CG, ACBindings.Internal.Template_CG*, void>)0x005C5CF0)(ref this, that);
}

