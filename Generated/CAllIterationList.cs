namespace ACBindings;

// CAllIterationList
public unsafe struct CAllIterationList
{
    // Child Types
    // CAllIterationList_vtbl
    public unsafe struct CAllIterationList_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }
    // CAllIterationList::PTaggedIterationList_vtbl
    public unsafe struct PTaggedIterationList_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }
    // CAllIterationList::PTaggedIterationList
    public unsafe struct PTaggedIterationList
    {
        // Members
        public System.IntPtr __vftable; // vtable pointer
        public ulong idDatFile;
        public ACBindings.CMostlyConsecutiveIntSet List;

        // Methods
        // void __thiscall CAllIterationList::PTaggedIterationList::Serialize(CAllIterationList::PTaggedIterationList*,Archive*)
        public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAllIterationList.PTaggedIterationList, ACBindings.Archive*, void>)0x00678CD0)(ref this, io_archive);
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.SmartArray__CAllIterationList_PTaggedIterationList m_Lists;

    // Methods
    // CMostlyConsecutiveIntSet* __thiscall CAllIterationList::AddIterationList(CAllIterationList*,unsigned __int64)
    public ACBindings.CMostlyConsecutiveIntSet* AddIterationList(ulong idDatFile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAllIterationList, ulong, ACBindings.CMostlyConsecutiveIntSet*>)0x00679100)(ref this, idDatFile);
}

