namespace ACBindings.Internal;


/// <summary>Provides human‑readable information for HRESULT codes, including symbolic name and textual description, facilitating debugging and logging.</summary>
public unsafe struct HResultDebugData
{
    // Members
    public int hr;
    public fixed sbyte szName[128];
    public fixed sbyte szDescription[512];

    // Methods
}

