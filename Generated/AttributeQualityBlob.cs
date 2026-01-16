namespace ACBindings.Internal;


/// <summary>Encapsulates an attribute's quality state and its current value, providing tracking for saved versus active values and a UI text element to display the current value.</summary>
public unsafe struct AttributeQualityBlob
{
    // Members
    public uint m_eQuality;
    public int m_nSavedValue;
    public int m_nCurValue;
    public ACBindings.Internal.UIElement_Text* m_pCurValueText;

    // Methods
}

