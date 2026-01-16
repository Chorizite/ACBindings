namespace ACBindings.Internal;


/// <summary>Represents a node in a singly linked list of motions, storing an identifier, a speed modifier, and a reference to the next node.</summary>
public unsafe struct MotionList
{
    // Members
    public uint motion;
    public float speed_mod;
    public ACBindings.Internal.MotionList* next;

    // Methods
}

