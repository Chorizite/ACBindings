namespace ACBindings.Internal;

public unsafe struct MissingIteration : System.IDisposable
{
    // Child Types
    public unsafe struct MissingIteration_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MissingIteration*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ulong idDatFile;
    public int idIteration;
    public ACBindings.Internal.SmartArray___QualifiedDataID IDsToDownload;
    public ACBindings.Internal.SmartArray___QualifiedDataID IDsToPurge;

    // Generated Constructor
    public MissingIteration() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F8CF0
    /// void __thiscall MissingIteration::MissingIteration(MissingIteration*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MissingIteration, void>)0x004F8CF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F8D10
    /// void __thiscall MissingIteration::~MissingIteration(MissingIteration*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MissingIteration, void>)0x004F8D10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00672750
    /// void __thiscall MissingIteration::Serialize(MissingIteration*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MissingIteration, ACBindings.Internal.Archive*, void>)0x00672750)(ref this, io_archive);
}

