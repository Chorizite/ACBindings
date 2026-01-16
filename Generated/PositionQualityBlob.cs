namespace ACBindings.Internal;


/// <summary>Encapsulates positional data along with its quality metric, maintaining both stored and live coordinates for synchronization with the user interface.</summary>
public unsafe struct PositionQualityBlob
{
    // Members
    public uint m_eQuality;
    public ACBindings.Internal.Position m_posSavedValue;
    public ACBindings.Internal.Position m_posCurValue;
    public ACBindings.Internal.UIElement_Text* m_pCurValueText;

    // Methods
}

