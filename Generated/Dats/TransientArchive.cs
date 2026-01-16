namespace ACBindings.Internal;


/// <summary>Encapsulates an Archive instance for transient storage during serialization tasks, enabling temporary data handling without persistent side effects.</summary>
public unsafe struct TransientArchive
{
    // Base Classes
    public ACBindings.Internal.Archive BaseClass_Archive; // ACBindings.Internal.Archive

    // Child Types
    public unsafe struct TransientArchive_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TransientArchive*, ACBindings.Internal.ArchiveInitializer*, ACBindings.Internal.SmartBuffer*, void> InitForPacking; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TransientArchive*, ACBindings.Internal.ArchiveInitializer*, ACBindings.Internal.SmartBuffer*, void> InitForUnpacking; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TransientArchive*, byte, void> SetCheckpointing; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TransientArchive*, void> InitVersionStack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TransientArchive*, void> CreateVersionStack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TransientArchive*, ACBindings.Internal.SmartBuffer*, void> InitForPacking_14; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TransientArchive*, ACBindings.Internal.SmartBuffer*, void> InitForUnpacking_18; // function pointer

        // Methods
    }

    // Generated Constructor
    public TransientArchive(ACBindings.Internal.Archive.tagPacking formal) {
        _ConstructorInternal(formal);
    }
    public TransientArchive(ACBindings.Internal.Archive.tagUnpacking formal, System.IntPtr addr, uint size) {
        _ConstructorInternal(formal, addr, size);
    }

    // Methods

    /// <summary>Initializes a transient archive configured for packing operations by setting up base Archive fields and preparing its buffer.
    /// <code>Offset: 0x00401600
    /// void __thiscall TransientArchive::TransientArchive(TransientArchive*,Archive::tagPacking)</code>
    /// </summary>
    /// <param name="formal">Specifies that the archive should be initialized in packing mode.</param>
    public void _ConstructorInternal(ACBindings.Internal.Archive.tagPacking formal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TransientArchive, ACBindings.Internal.Archive.tagPacking, void>)0x00401600)(ref this, formal);

    /// <summary>Prepares the transient archive for packing by initializing its base Archive with the supplied buffer and setting the core version.
    /// <code>Offset: 0x00401670
    /// void __thiscall TransientArchive::InitForPacking(TransientArchive*,const SmartBuffer*)</code>
    /// </summary>
    /// <param name="i_buffer">The SmartBuffer that provides the data to be packed into the archive.</param>
    public void InitForPacking(ACBindings.Internal.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TransientArchive, ACBindings.Internal.SmartBuffer*, void>)0x00401670)(ref this, i_buffer);

    /// <summary>Prepares the TransientArchive to read serialized data from a SmartBuffer, configuring internal archive state and applying the current core version.
    /// <code>Offset: 0x00401690
    /// void __thiscall TransientArchive::InitForUnpacking(TransientArchive*,const SmartBuffer*)</code>
    /// </summary>
    /// <param name="i_buffer">Source buffer containing packed data.</param>
    public void InitForUnpacking(ACBindings.Internal.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TransientArchive, ACBindings.Internal.SmartBuffer*, void>)0x00401690)(ref this, i_buffer);

    /// <summary>Initializes a TransientArchive from raw data, copying the specified buffer into an internal SmartBuffer and configuring the base Archive for unpacking.
    /// <code>Offset: 0x004F7A90
    /// void __thiscall TransientArchive::TransientArchive(TransientArchive*,Archive::tagUnpacking,void*,unsigned int)</code>
    /// </summary>
    /// <param name="formal">Tag indicating that the archive is being constructed for unpacking; used internally to select the correct initialization path.</param>
    /// <param name="addr">Pointer to the source memory block containing serialized data.</param>
    /// <param name="size">Number of bytes in the source buffer.</param>
    public void _ConstructorInternal(ACBindings.Internal.Archive.tagUnpacking formal, System.IntPtr addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TransientArchive, ACBindings.Internal.Archive.tagUnpacking, System.IntPtr, uint, void>)0x004F7A90)(ref this, formal, addr, size);
}

