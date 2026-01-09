namespace ACBindings;

// VisualDesc
public unsafe struct VisualDesc
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // VisualDesc_vtbl
    public unsafe struct VisualDesc_vtbl
    {
        // Members
        public System.IntPtr VisualDesc_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr pack_size; // function pointer

        // Methods
    }

    // Methods
}

