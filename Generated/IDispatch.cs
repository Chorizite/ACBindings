namespace ACBindings;

// IDispatch
public unsafe struct IDispatch
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // IDispatch_vtbl
    public unsafe struct IDispatch_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr GetTypeInfoCount; // function pointer
        public System.IntPtr GetTypeInfo; // function pointer
        public System.IntPtr GetIDsOfNames; // function pointer
        public System.IntPtr Invoke; // function pointer

        // Methods
    }

    // Methods
}

