namespace ACBindings;

// MissingIteration
public unsafe struct MissingIteration : System.IDisposable
{
    // Child Types
    // MissingIteration_vtbl
    public unsafe struct MissingIteration_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ulong idDatFile;
    public int idIteration;
    public ACBindings.SmartArray__QualifiedDataID IDsToDownload;
    public ACBindings.SmartArray__QualifiedDataID IDsToPurge;

    // Generated Constructor
    public MissingIteration() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall MissingIteration::MissingIteration(MissingIteration*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MissingIteration, void>)0x004F8CF0)(ref this);
    // void __thiscall MissingIteration::~MissingIteration(MissingIteration*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MissingIteration, void>)0x004F8D10)(ref this);
    // void __thiscall MissingIteration::Serialize(MissingIteration*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MissingIteration, ACBindings.Archive*, void>)0x00672750)(ref this, io_archive);
}

