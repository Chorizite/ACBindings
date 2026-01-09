namespace ACBindings;

// FileSource
public unsafe struct FileSource
{
    // Base Classes
    public ACBindings.DataSource BaseClass_DataSource; // ACBindings.DataSource

    // Child Types
    // FileSource_vtbl
    public unsafe struct FileSource_vtbl
    {
        // Members
        public System.IntPtr FileSource_dtor_0; // function pointer
        public System.IntPtr Close; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr hFile;
    public System.IntPtr hMemoryFile;
    public byte* pBuffer;

    // Methods
}

