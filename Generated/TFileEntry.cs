namespace ACBindings.Internal;

public unsafe struct TFileEntry
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct TFileEntry_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TFileEntry*, void> TFileEntry_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PStringBase__sbyte m_pPath;
    public ACBindings.Internal.PStringBase__sbyte m_pFileName;
    public ACBindings.Internal.IDClass____tagDataID m_did;
    public uint m_dbtype;
    public ACBindings.Internal.FileEntryType m_EntryType;
    public byte m_bAuthoritative;
    public int m_tFileWriteTime;

    // Methods

    /// <summary>
    /// <code>Offset: 0x006794B0
    /// LONG __thiscall TFileEntry::SetPath(_DWORD*,int*)</code>
    /// </summary>
    public int SetPath(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TFileEntry, int*, int>)0x006794B0)(ref this, a2);
}

