namespace ACBindings;

// AsyncIPipeByte
public unsafe struct AsyncIPipeByte
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // AsyncIPipeByte_vtbl
    public unsafe struct AsyncIPipeByte_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr Begin_Pull; // function pointer
        public System.IntPtr Finish_Pull; // function pointer
        public System.IntPtr Begin_Push; // function pointer
        public System.IntPtr Finish_Push; // function pointer

        // Methods
    }

    // Methods
}

