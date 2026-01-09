namespace ACBindings;

// MovementReturn
public unsafe struct MovementReturn
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // MovementReturn_vtbl
    public unsafe struct MovementReturn_vtbl
    {
        // Members
        public System.IntPtr MovementReturn_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.MovementParameters params_;
    public uint object_id;
    public uint error;
    public ACBindings.Position position;
    public float object_radius;
    public float object_height;

    // Methods
}

