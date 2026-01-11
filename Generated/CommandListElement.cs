namespace ACBindings.Internal;

public unsafe struct CommandListElement
{
    // Members
    public ACBindings.Internal.CommandListElement* next;
    public ACBindings.Internal.CommandListElement* prev;
    public uint command;
    public float speed;
    public int hold_run;

    // Methods
}

