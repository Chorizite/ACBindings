namespace ACBindings.Internal;


/// <summary>Represents a component's data within the system, storing its unique identifier and an associated numeric value for internal logic.</summary>
/// <remarks>The struct is 4-byte aligned to match legacy memory layout expectations.</remarks>
public unsafe struct ComponentObjectData
{
    // Members
    public uint objectID;
    public uint number;

    // Methods
}

