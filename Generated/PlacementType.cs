namespace ACBindings.Internal;

public unsafe struct PlacementType
{
    // Base Classes
    public ACBindings.Internal.LongHashData BaseClass_LongHashData; // ACBindings.Internal.LongHashData

    // Child Types
    public unsafe struct PlacementType_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PlacementType*, void> PlacementType_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AnimFrame anim_frame;

    // Methods
}

