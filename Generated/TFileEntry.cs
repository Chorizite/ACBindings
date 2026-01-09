namespace ACBindings;

// TFileEntry
public unsafe struct TFileEntry
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // TFileEntry_vtbl
    public unsafe struct TFileEntry_vtbl
    {
        // Members
        public System.IntPtr TFileEntry_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PStringBase__sbyte m_pPath;
    public ACBindings.PStringBase__sbyte m_pFileName;
    public ACBindings.IDClass___tagDataID m_did;
    public uint m_dbtype;
    public ACBindings.FileEntryType m_EntryType;
    public byte m_bAuthoritative;
    public int m_tFileWriteTime;

    // Methods
    // LONG __thiscall TFileEntry::SetPath(_DWORD*,int*)
    public int SetPath(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TFileEntry, int*, int>)0x006794B0)(ref this, a2);
}

