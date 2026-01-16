namespace ACBindings.Internal;


/// <summary>Encapsulates the result of searching for an HRESULT debug data entry, holding whether it was found, the HRESULT code, and a pointer to its associated debug information.</summary>
public unsafe struct GetHResultDebugData_functor
{
    // Members
    public byte m_bFound;
    public int m_hr;
    public ACBindings.Internal.HResultDebugData* m_rData;

    // Methods
}

