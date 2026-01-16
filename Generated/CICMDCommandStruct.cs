namespace ACBindings.Internal;


/// <summary>Stores an ICMD command enumeration value and its accompanying 32‑bit unsigned parameter, used to dispatch commands in the application’s command-processing logic.</summary>
public unsafe struct CICMDCommandStruct
{
    // Members
    public ACBindings.Internal.ICMDCommandEnum Cmd;
    public uint Param;

    // Methods
}

