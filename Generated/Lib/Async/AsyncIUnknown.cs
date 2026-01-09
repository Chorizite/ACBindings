namespace ACBindings;

// AsyncIUnknown
public unsafe struct AsyncIUnknown
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // AsyncIUnknown_vtbl
    public unsafe struct AsyncIUnknown_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr Begin_QueryInterface; // function pointer
        public System.IntPtr Finish_QueryInterface; // function pointer
        public System.IntPtr Begin_AddRef; // function pointer
        public System.IntPtr Finish_AddRef; // function pointer
        public System.IntPtr Begin_Release; // function pointer
        public System.IntPtr Finish_Release; // function pointer

        // Methods
    }

    // Methods
}

