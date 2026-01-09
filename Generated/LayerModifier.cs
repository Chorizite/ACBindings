namespace ACBindings;

// LayerModifier
public unsafe struct LayerModifier
{
    // Child Types
    // LayerModifier_vtbl
    public unsafe struct LayerModifier_vtbl
    {
        // Members
        public System.IntPtr GetType; // function pointer
        public System.IntPtr GetTCIndex; // function pointer
        public System.IntPtr GetSize; // function pointer
        public System.IntPtr DoesModifyVertex; // function pointer
        public System.IntPtr Copy; // function pointer
        public System.IntPtr Apply; // function pointer
        public System.IntPtr ApplyTextureTransform; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr LoadFromFileNode; // function pointer
        public System.IntPtr SaveToFileNode; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

