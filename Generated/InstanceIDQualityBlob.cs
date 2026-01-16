namespace ACBindings.Internal;


/// <summary>Tracks the quality status of an instance identifier, storing its saved and current values along with a reference to the UI text element that displays it.</summary>
public unsafe struct InstanceIDQualityBlob
{
    // Members
    public uint m_eQuality;
    public uint m_iidSavedValue;
    public uint m_iidCurValue;
    public ACBindings.Internal.UIElement_Text* m_pCurValueText;

    // Methods
}

