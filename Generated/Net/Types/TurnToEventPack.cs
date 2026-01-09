namespace ACBindings;

// TurnToEventPack
public unsafe struct TurnToEventPack
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // TurnToEventPack_vtbl
    public unsafe struct TurnToEventPack_vtbl
    {
        // Members
        public System.IntPtr TurnToEventPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public float absolute_degrees;
    public int run;

    // Methods
}

