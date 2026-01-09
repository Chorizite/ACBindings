namespace ACBindings;

// ISequentialStream
public unsafe struct ISequentialStream
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // ISequentialStream_vtbl
    public unsafe struct ISequentialStream_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr Read; // function pointer
        public System.IntPtr Write; // function pointer

        // Methods
    }

    // Methods
}

