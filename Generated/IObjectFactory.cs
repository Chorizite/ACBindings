namespace ACBindings.Internal;


/// <summary>Represents a COM‑compatible object factory interface, providing reference counting and query functionality through its base Interface implementation.</summary>
/// <remarks>The definition presently exposes only the IUnknown-compatible base; concrete factory operations are expected to be defined in derived interfaces elsewhere in the system.</remarks>
public unsafe struct IObjectFactory
{
    // Base Classes
    public ACBindings.Internal.Interface BaseClass_Interface; // ACBindings.Internal.Interface

    // Methods
}

