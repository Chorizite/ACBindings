namespace ACBindings;

// TurnEventPack
public unsafe struct TurnEventPack
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // TurnEventPack_vtbl
    public unsafe struct TurnEventPack_vtbl
    {
        // Members
        public System.IntPtr TurnEventPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public float relative_degrees;

    // Methods
}

