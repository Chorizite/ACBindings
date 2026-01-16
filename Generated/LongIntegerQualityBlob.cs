namespace ACBindings.Internal;


/// <summary>Tracks quality of a 64‑bit integer, storing its previous and current values while linking to the UI text element that displays the current value.</summary>
public unsafe struct LongIntegerQualityBlob
{
    // Members
    public uint m_eQuality;
    public long m_nSavedValue;
    public long m_nCurValue;
    public ACBindings.Internal.UIElement_Text* m_pCurValueText;

    // Methods
}

