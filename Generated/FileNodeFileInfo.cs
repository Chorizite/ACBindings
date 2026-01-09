namespace ACBindings;

// FileNodeFileInfo
public unsafe struct FileNodeFileInfo
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // FileNodeFileInfo_vtbl
    public unsafe struct FileNodeFileInfo_vtbl
    {
        // Members
        public System.IntPtr FileNodeFileInfo_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.PStringBase__sbyte m_filename;
    public ushort m_errorCount;
    public ushort m_warningCount;
    public uint m_compatabilityVersion;

    // Methods
}

