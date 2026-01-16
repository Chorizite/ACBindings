namespace ACBindings.Internal;


/// <summary>Provides an implementation of DataSource capable of reading from either a physical file or a memory‑mapped region, maintaining internal handles and buffer pointers.</summary>
public unsafe struct FileSource
{
    // Base Classes
    public ACBindings.Internal.DataSource BaseClass_DataSource; // ACBindings.Internal.DataSource

    // Child Types
    public unsafe struct FileSource_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FileSource*, void> FileSource_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FileSource*, void> Close; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr hFile;
    public System.IntPtr hMemoryFile;
    public byte* pBuffer;

    // Methods
}

