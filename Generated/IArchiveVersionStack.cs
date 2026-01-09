namespace ACBindings;

// IArchiveVersionStack
public unsafe struct IArchiveVersionStack
{
    // Base Classes
    public ACBindings.Interface BaseClass_Interface; // ACBindings.Interface

    // Child Types
    // IArchiveVersionStack_vtbl
    public unsafe struct IArchiveVersionStack_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr GetVersionByToken; // function pointer
        public System.IntPtr SetVersion; // function pointer
        public fixed byte gap20[4];
        public System.IntPtr PushVersionRow;
        public System.IntPtr PopVersionRow;
        public System.IntPtr GetRowByHandle;
        public System.IntPtr GetCurrentVersionHandle;
        public System.IntPtr Reset; // function pointer

        // Methods
    }

    // Methods
}

