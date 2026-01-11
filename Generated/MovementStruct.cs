namespace ACBindings.Internal;

public unsafe struct MovementStruct
{
    // Members
    public ACBindings.Internal.MovementTypes.Type type;
    public uint motion;
    public uint object_id;
    public uint top_level_id;
    public ACBindings.Internal.Position pos;
    public float radius;
    public float height;
    public ACBindings.Internal.MovementParameters* params_;

    // Methods
}

