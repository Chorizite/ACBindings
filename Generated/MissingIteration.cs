namespace ACBindings.Internal;


/// <summary>Represents the state of missing data for a specific iteration within a data file, storing its identifier and iteration number.</summary>
/// <summary>Holds two lists of qualified data IDs that must be downloaded or purged to resolve missing elements during synchronization.</summary>
public unsafe struct MissingIteration : System.IDisposable
{
    // Child Types

    /// <summary>Provides the virtual function table for MissingIteration, enabling serialization of its instances to an Archive.</summary>
    public unsafe struct MissingIteration_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MissingIteration*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

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

    /// <summary>Initializes a MissingIteration instance by assigning its virtual table pointer and resetting the download and purge ID lists to empty.
    /// <code>Offset: 0x004F8CF0
    /// void __thiscall MissingIteration::MissingIteration(MissingIteration*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MissingIteration, void>)0x004F8CF0)(ref this);

    /// <summary>Releases resources held by the MissingIteration instance, freeing any dynamically allocated arrays of QualifiedDataID stored in IDsToPurge and IDsToDownload.
    /// <code>Offset: 0x004F8D10
    /// void __thiscall MissingIteration::~MissingIteration(MissingIteration*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MissingIteration, void>)0x004F8D10)(ref this);

    /// <summary>Serializes or deserializes a MissingIteration instance to or from an Archive, writing or reading the data file identifier, iteration number, and associated download and purge ID lists based on archive mode.
    /// <code>Offset: 0x00672750
    /// void __thiscall MissingIteration::Serialize(MissingIteration*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for (de)serialization. Its flags indicate whether the operation is a write (flag 1 set) or read.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MissingIteration, ACBindings.Internal.Archive*, void>)0x00672750)(ref this, io_archive);
}

