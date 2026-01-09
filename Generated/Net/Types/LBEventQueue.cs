namespace ACBindings;

// LBEventQueue
public unsafe struct LBEventQueue
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // LBEventQueue_vtbl
    public unsafe struct LBEventQueue_vtbl
    {
        // Members
        public System.IntPtr LBEventQueue_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint lbID;
    public System.IntPtr evQ;

    // Methods
}

