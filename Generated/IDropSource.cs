namespace ACBindings;

// IDropSource
public unsafe struct IDropSource
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // IDropSource_vtbl
    public unsafe struct IDropSource_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr QueryContinueDrag; // function pointer
        public System.IntPtr GiveFeedback; // function pointer

        // Methods
    }

    // Methods
}

