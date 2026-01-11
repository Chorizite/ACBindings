namespace ACBindings.Internal;

public unsafe struct HResultDebugData
{
    // Members
    public int hr;
    public fixed sbyte szName[128];
    public fixed sbyte szDescription[512];

    // Methods
}

