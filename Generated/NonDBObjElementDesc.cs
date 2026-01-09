namespace ACBindings;

// NonDBObjElementDesc
public unsafe struct NonDBObjElementDesc
{
    // Base Classes
    public ACBindings.ElementDesc BaseClass_ElementDesc; // ACBindings.ElementDesc

    // Child Types
    // NonDBObjElementDesc_vtbl
    public unsafe struct NonDBObjElementDesc_vtbl
    {
        // Members
        public System.IntPtr NonDBObjElementDesc_dtor_0; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr ToFileNode; // function pointer
        public System.IntPtr FromFileNode; // function pointer
        public System.IntPtr PositionToFileNode; // function pointer
        public System.IntPtr HandleNode; // function pointer
        public System.IntPtr CheckFFN; // function pointer
        public System.IntPtr UpdateSizeAndPosition; // function pointer

        // Methods
    }

    // Methods
}

