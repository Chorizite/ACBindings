namespace ACBindings.Internal;


/// <summary>Holds metadata and references required by a dialog component, including its property collection, runtime instance, owning framework, and contextual identifier.</summary>
public unsafe struct DialogInfo
{
    // Members
    public ACBindings.Internal.PropertyCollection data;
    public ACBindings.Internal.Dialog* pointer;
    public ACBindings.Internal.UIFramework* parent;
    public uint context;

    // Methods
}

