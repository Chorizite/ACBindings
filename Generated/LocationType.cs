namespace ACBindings.Internal;

public unsafe struct LocationType
{
    // Base Classes
    public ACBindings.Internal.LongHashData BaseClass_LongHashData; // ACBindings.Internal.LongHashData

    // Child Types
    public unsafe struct LocationType_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LocationType*, void> LocationType_dtor_0; // function pointer

        // Methods
    }

    // Members
    public uint part_id;
    public ACBindings.Internal.Frame frame;

    // Methods
}

