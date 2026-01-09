namespace ACBindings;

// CmdStruct
public unsafe struct CmdStruct
{
    // Members
    public fixed byte args[256];
    public uint size;
    public uint curr;
    public uint command;

    // Methods
}

