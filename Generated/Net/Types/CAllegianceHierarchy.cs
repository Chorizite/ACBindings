namespace ACBindings;

// CAllegianceHierarchy
public unsafe struct CAllegianceHierarchy
{
    // Base Classes
    public ACBindings.AllegianceHierarchy BaseClass_AllegianceHierarchy; // ACBindings.AllegianceHierarchy

    // Child Types
    // CAllegianceHierarchy_vtbl
    public unsafe struct CAllegianceHierarchy_vtbl
    {
        // Members
        public System.IntPtr CAllegianceHierarchy_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer
        public System.IntPtr GetMinPackSize; // function pointer

        // Methods
    }

    // Methods
}

