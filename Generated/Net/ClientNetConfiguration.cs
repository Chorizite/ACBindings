namespace ACBindings;

// ClientNetConfiguration
public unsafe struct ClientNetConfiguration
{
    // Base Classes
    public ACBindings.LoggingFunctions BaseClass_LoggingFunctions; // ACBindings.LoggingFunctions

    // Members
    public ACBindings.AC1Legacy.PStringBase__sbyte DesiredInterface;
    public uint dwPort;
    public int bAutoGenerateUniquePort;

    // Methods
}

