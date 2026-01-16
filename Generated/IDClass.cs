namespace ACBindings.Internal;


/// <summary>Represents a cell identifier constrained to 16‑bit values between 16 and 65535, encapsulating an underlying IDClass structure for type safety and range enforcement.</summary>
public unsafe struct IDClass____tagCellID
{
    // Base Classes
    public uint BaseClass_uint; // uint

    // Methods
}


/// <summary>Represents a 32‑bit identifier handle associated with a specific tag version, providing unique identification for objects in the system.</summary>
public unsafe struct IDClass____tagVersionHandle
{
    // Base Classes
    public uint BaseClass_uint; // uint

    // Methods
}


/// <summary>Encapsulates a 32‑bit identifier for data tagged as _tagDataID, providing typed access and storing the value through an underlying _IDClass instance.</summary>
public unsafe struct IDClass____tagDataID
{
    // Base Classes
    public uint BaseClass_uint; // uint

    // Methods
}

