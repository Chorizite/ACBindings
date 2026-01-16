namespace ACBindings.Internal;


/// <summary>Provides an interface for accessing read‑only file identifiers through a virtual function table, enabling efficient lookup and management of IDs without altering the underlying data store.</summary>
public unsafe struct TReadOnlyFile2IDTable
{
    // Child Types
    public unsafe struct TReadOnlyFile2IDTable_vtbl
    {
        // Members
        public System.IntPtr GetDIDByFileName;
        public System.IntPtr GetFileNameByDID;
        public System.IntPtr GetFullPathByDID;
        public System.IntPtr GetFullPathByFileName;
        public System.IntPtr GetDBTypeString;
        public System.IntPtr GetHighestDID;
        public System.IntPtr GetDBTypes;
        public System.IntPtr GetDIDs;
        public System.IntPtr GetFilePaths;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

