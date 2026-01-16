namespace ACBindings.Internal;


/// <summary>Tracks the quality state of a string property by storing its persisted value, the currently edited value, and linking to the UI element that displays or edits the text.</summary>
public unsafe struct StringQualityBlob
{
    // Members
    public uint m_eQuality;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_strSavedValue;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_strCurValue;
    public ACBindings.Internal.UIElement_Text* m_pCurValueText;

    // Methods
}

