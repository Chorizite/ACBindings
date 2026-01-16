namespace ACBindings.Internal;


/// <summary>Tracks the quality state of an integer property, storing its original and current values along with a reference to a UI text element for display.</summary>
public unsafe struct IntegerQualityBlob
{
    // Members
    public uint m_eQuality;
    public int m_nSavedValue;
    public int m_nCurValue;
    public ACBindings.Internal.UIElement_Text* m_pCurValueText;

    // Methods
}

