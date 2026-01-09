namespace ACBindings;

// ID3DXBuffer
public unsafe struct ID3DXBuffer
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // ID3DXBuffer_vtbl
    public unsafe struct ID3DXBuffer_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr GetBufferPointer; // function pointer
        public System.IntPtr GetBufferSize; // function pointer

        // Methods
    }

    // Methods
}

