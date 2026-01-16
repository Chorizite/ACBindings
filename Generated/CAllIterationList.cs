namespace ACBindings.Internal;


/// <summary>Aggregates iteration lists linked to data file identifiers, storing consecutive integer sets for efficient retrieval and management during processing.</summary>
public unsafe struct CAllIterationList
{
    // Child Types

    /// <summary>Defines the virtual function table for CAllIterationList, providing a pointer to its serialization routine.</summary>
    public unsafe struct CAllIterationList_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllIterationList*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    /// <summary>Links a 64‑bit data-file identifier to its corresponding iteration list, allowing efficient storage, retrieval, and serialization of iteration sets within the AllIterationList system.</summary>
    public unsafe struct PTaggedIterationList
    {
        // Child Types

        /// <summary>Provides the virtual function table for a tagged iteration list, enabling serialization of its contents to an archive.</summary>
        public unsafe struct PTaggedIterationList_vtbl
        {
            // Members
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllIterationList.PTaggedIterationList*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

            // Methods
        }

        // Members
        public System.IntPtr __vftable; // vtable pointer
        public ulong idDatFile;
        public ACBindings.Internal.CMostlyConsecutiveIntSet List;

        // Methods

        /// <summary>Serializes a tagged iteration list to or from an archive, writing the identifier and delegating list serialization while respecting alignment constraints.
        /// <code>Offset: 0x00678CD0
        /// void __thiscall CAllIterationList::PTaggedIterationList::Serialize(CAllIterationList::PTaggedIterationList*,Archive*)</code>
        /// </summary>
        /// <param name="io_archive">Archive used for reading or writing the data; when its flags indicate write mode (bit 0 set), the method writes the 64‑bit idDatFile followed by the List contents; otherwise it reads them from the archive.</param>
        public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAllIterationList.PTaggedIterationList, ACBindings.Internal.Archive*, void>)0x00678CD0)(ref this, io_archive);
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.SmartArray___CAllIterationList_PTaggedIterationList m_Lists;

    // Methods

    /// <summary>Adds a new CMostlyConsecutiveIntSet to the internal list and associates it with the specified idDatFile.
    /// <code>Offset: 0x00679100
    /// CMostlyConsecutiveIntSet* __thiscall CAllIterationList::AddIterationList(CAllIterationList*,unsigned __int64)</code>
    /// </summary>
    /// <param name="idDatFile">Identifier for the data file that will be linked to the new iteration list.</param>
    /// <returns>Pointer to the newly created CMostlyConsecutiveIntSet instance.</returns>
    public ACBindings.Internal.CMostlyConsecutiveIntSet* AddIterationList(ulong idDatFile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAllIterationList, ulong, ACBindings.Internal.CMostlyConsecutiveIntSet*>)0x00679100)(ref this, idDatFile);
}

