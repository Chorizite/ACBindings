namespace ACBindings.Internal;

public unsafe struct CAllIterationList
{
    // Child Types
    public unsafe struct CAllIterationList_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllIterationList*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }
    public unsafe struct PTaggedIterationList
    {
        // Child Types
        public unsafe struct PTaggedIterationList_vtbl
        {
            // Members
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAllIterationList.PTaggedIterationList*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

            // Methods
        }

        // Members
        public System.IntPtr __vftable; // vtable pointer
        public ulong idDatFile;
        public ACBindings.Internal.CMostlyConsecutiveIntSet List;

        // Methods

        /// <summary>
        /// <code>Offset: 0x00678CD0
        /// void __thiscall CAllIterationList::PTaggedIterationList::Serialize(CAllIterationList::PTaggedIterationList*,Archive*)</code>
        /// </summary>
        public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAllIterationList.PTaggedIterationList, ACBindings.Internal.Archive*, void>)0x00678CD0)(ref this, io_archive);
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.SmartArray___CAllIterationList_PTaggedIterationList m_Lists;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00679100
    /// CMostlyConsecutiveIntSet* __thiscall CAllIterationList::AddIterationList(CAllIterationList*,unsigned __int64)</code>
    /// </summary>
    public ACBindings.Internal.CMostlyConsecutiveIntSet* AddIterationList(ulong idDatFile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAllIterationList, ulong, ACBindings.Internal.CMostlyConsecutiveIntSet*>)0x00679100)(ref this, idDatFile);
}

