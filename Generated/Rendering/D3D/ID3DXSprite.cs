namespace ACBindings;

// ID3DXSprite
public unsafe struct ID3DXSprite
{
    // Base Classes
    public ACBindings.IUnknown BaseClass_IUnknown; // ACBindings.IUnknown

    // Child Types
    // ID3DXSprite_vtbl
    public unsafe struct ID3DXSprite_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr GetDevice; // function pointer
        public System.IntPtr GetTransform; // function pointer
        public System.IntPtr SetTransform; // function pointer
        public System.IntPtr SetWorldViewRH; // function pointer
        public System.IntPtr SetWorldViewLH; // function pointer
        public System.IntPtr Begin; // function pointer
        public System.IntPtr Draw; // function pointer
        public System.IntPtr Flush; // function pointer
        public System.IntPtr End; // function pointer
        public System.IntPtr OnLostDevice; // function pointer
        public System.IntPtr OnResetDevice; // function pointer

        // Methods
    }

    // Methods
}

