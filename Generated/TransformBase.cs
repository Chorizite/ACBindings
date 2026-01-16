namespace ACBindings.Internal;


/// <summary>Combines position offset, scale, and rotation for transforming objects in 3D space.</summary>
public unsafe struct TransformBase
{
    // Members
    public ACBindings.Internal.Vector3 offset;
    public float scale;
    public ACBindings.Internal.Quaternion qt;

    // Methods
}

