namespace ACBindings.Internal;


/// <summary>
/// Represents the outcome of a movement request, encapsulating the original parameters, the target object's identifier, its final position, dimensional attributes, and any error status that resulted from processing.
/// </summary>
/// <remarks>
/// Fields:
/// - <c>baseclass_0</c>: underlying packet handling object used for packing/unpacking data.
/// - <c>params</c>: movement configuration supplied to the operation.
/// - <c>object_id</c>: unique identifier of the moved entity.
/// - <c>error</c>: status code indicating success or failure of the move.
/// - <c>position</c>: final spatial coordinates after movement.
/// - <c>object_radius</c>, <c>object_height</c>: physical dimensions of the object for collision detection and rendering.
/// </remarks>
public unsafe struct MovementReturn
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct MovementReturn_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MovementReturn*, void> MovementReturn_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MovementReturn*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MovementReturn*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MovementReturn*, void**, uint, int> UnPack; // function pointer

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

