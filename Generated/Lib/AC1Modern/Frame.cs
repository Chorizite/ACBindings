namespace ACBindings.Internal.AC1Modern;


/// <summary>Represents a spatial transformation frame in AC1Modern, combining base frame properties with a 3×3 matrix of floats that define orientation or linear transform.</summary>
public unsafe struct Frame
{
    // Base Classes
    public ACBindings.Internal.AC1Modern.AFrame BaseClass_AC1Modern_AFrame; // ACBindings.Internal.AC1Modern.AFrame

    // Members
    public fixed float fl2gv[9];

    // Methods
}

