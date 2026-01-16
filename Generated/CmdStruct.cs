namespace ACBindings.Internal;


/// <summary>Encapsulates a command packet for the device, storing raw arguments, packet size, current read offset, and the command identifier.</summary>
public unsafe struct CmdStruct
{
    // Members
    public fixed byte args[256];
    public uint size;
    public uint curr;
    public uint command;

    // Methods
}

