namespace ACBindings.Internal;


/// <summary>Represents metadata for a user interface button within a panel, including the UI element pointer and the panel’s unique identifier.</summary>
public unsafe struct PanelButtonInfo
{
    // Members
    public ACBindings.Internal.UIElement* button;
    public uint panelID;

    // Methods
}

