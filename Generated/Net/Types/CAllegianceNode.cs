namespace ACBindings;

// CAllegianceNode
public unsafe struct CAllegianceNode
{
    // Base Classes
    public ACBindings.AllegianceNode BaseClass_AllegianceNode; // ACBindings.AllegianceNode

    // Child Types
    // CAllegianceNode_vtbl
    public unsafe struct CAllegianceNode_vtbl
    {
        // Members
        public System.IntPtr CAllegianceNode_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Methods
}

