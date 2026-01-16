namespace ACBindings.Internal;


/// <summary>Holds client networking settings including logging callbacks, preferred interface, port assignment, and an option for automatic unique port generation.</summary>
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

