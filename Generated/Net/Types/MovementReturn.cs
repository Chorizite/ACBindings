namespace ACBindings.Internal;

public unsafe struct MovementReturn
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct MovementReturn_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MovementReturn*, void> MovementReturn_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MovementReturn*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MovementReturn*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MovementReturn*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.MovementParameters params_;
    public uint object_id;
    public uint error;
    public ACBindings.Internal.Position position;
    public float object_radius;
    public float object_height;

    // Methods
}

