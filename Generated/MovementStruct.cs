namespace ACBindings;

// MovementStruct
public unsafe struct MovementStruct
{
    // Members
    public ACBindings.MovementTypes.Type type;
    public uint motion;
    public uint object_id;
    public uint top_level_id;
    public ACBindings.Position pos;
    public float radius;
    public float height;
    public ACBindings.MovementParameters* params_;

    // Methods
}

