namespace ACBindings.Internal;

public unsafe struct ClientNetConfiguration
{
    // Base Classes
    public ACBindings.Internal.LoggingFunctions BaseClass_LoggingFunctions; // ACBindings.Internal.LoggingFunctions

    // Members
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte DesiredInterface;
    public uint dwPort;
    public int bAutoGenerateUniquePort;

    // Methods
}

