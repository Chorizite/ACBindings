namespace ACBindings;

// IDataFilter
public unsafe struct IDataFilter
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // IDataFilter_vtbl
    public unsafe struct IDataFilter_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DoEncode; // function pointer
        public System.IntPtr DoDecode; // function pointer
        public System.IntPtr SetEncodingLevel; // function pointer

        // Methods
    }

    // Methods
}

