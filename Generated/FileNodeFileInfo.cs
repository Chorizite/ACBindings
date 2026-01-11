namespace ACBindings.Internal;

public unsafe struct FileNodeFileInfo
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct FileNodeFileInfo_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.FileNodeFileInfo*, void> FileNodeFileInfo_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PStringBase__sbyte m_filename;
    public ushort m_errorCount;
    public ushort m_warningCount;
    public uint m_compatabilityVersion;

    // Methods
}

