namespace ACBindings.Internal;


/// <summary>Represents a floating-point quality metric, storing its current and saved values along with a UI element for displaying the current value.</summary>
public unsafe struct FloatQualityBlob
{
    // Members
    public uint m_eQuality;
    public double m_fSavedValue;
    public double m_fCurValue;
    public ACBindings.Internal.UIElement_Text* m_pCurValueText;

    // Methods
}

