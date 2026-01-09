namespace ACBindings;

// CommandListElement
public unsafe struct CommandListElement
{
    // Members
    public ACBindings.CommandListElement* next;
    public ACBindings.CommandListElement* prev;
    public uint command;
    public float speed;
    public int hold_run;

    // Methods
}

