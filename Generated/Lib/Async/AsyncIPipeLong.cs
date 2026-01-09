namespace ACBindings;

// AsyncIPipeLong
public unsafe struct AsyncIPipeLong
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // AsyncIPipeLong_vtbl
    public unsafe struct AsyncIPipeLong_vtbl
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

