namespace ACBindings.Internal;


/// <summary>Encapsulates information about an observed entity, providing its unique identifier, relevance metric (quantum), interaction radius, and the last transmitted position.</summary>
public unsafe struct TargettedVoyeurInfo
{
    // Members
    public uint object_id;
    public double quantum;
    public float radius;
    public ACBindings.Internal.Position last_sent_position;

    // Methods
}

