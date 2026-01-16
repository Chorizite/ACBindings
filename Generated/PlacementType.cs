namespace ACBindings.Internal;


/// <summary>Represents an object placement descriptor, linking a base class hash to its current animation frame for positioning in the scene.</summary>
public unsafe struct PlacementType
{
    // Base Classes
    public ACBindings.Internal.LongHashData BaseClass_LongHashData; // ACBindings.Internal.LongHashData

    // Child Types
    public unsafe struct PlacementType_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.PlacementType*, void> PlacementType_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AnimFrame anim_frame;

    // Methods
}

