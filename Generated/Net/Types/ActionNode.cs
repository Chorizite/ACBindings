namespace ACBindings.Internal;


/// <summary>Represents a node in an action sequence, storing the action type, execution speed, timestamp, and autonomy flag used by the system to schedule behaviors.</summary>
public unsafe struct ActionNode
{
    // Base Classes
    public ACBindings.Internal.LListData BaseClass_LListData; // ACBindings.Internal.LListData

    // Members
    public uint action;
    public float speed;
    public uint stamp;
    public int autonomous;

    // Methods
}

