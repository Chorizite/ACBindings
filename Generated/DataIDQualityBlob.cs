namespace ACBindings.Internal;


/// <summary>Captures the quality state of a data identifier along with its saved and current values, while holding a reference to the UI element displaying the current value.</summary>
public unsafe struct DataIDQualityBlob
{
    // Members
    public uint m_eQuality;
    public ACBindings.Internal.IDClass____tagDataID m_didSavedValue;
    public ACBindings.Internal.IDClass____tagDataID m_didCurValue;
    public ACBindings.Internal.UIElement_Text* m_pCurValueText;

    // Methods
}

