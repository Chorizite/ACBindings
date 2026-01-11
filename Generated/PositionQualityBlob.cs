namespace ACBindings.Internal;

public unsafe struct PositionQualityBlob
{
    // Members
    public uint m_eQuality;
    public ACBindings.Internal.Position m_posSavedValue;
    public ACBindings.Internal.Position m_posCurValue;
    public ACBindings.Internal.UIElement_Text* m_pCurValueText;

    // Methods
}

