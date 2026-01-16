namespace ACBindings.Internal;


/// <summary>Represents a quality flag, storing an identifier along with the saved and current boolean values used for tracking state changes.</summary>
public unsafe struct BoolQualityBlob
{
    // Members
    public uint m_eQuality;
    public byte m_bSavedValue;
    public byte m_bCurValue;

    // Methods
}

