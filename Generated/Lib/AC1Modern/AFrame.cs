namespace ACBindings.Internal.AC1Modern;


/// <summary>Defines a coordinate frame consisting of an origin point and orientation quaternion, used for spatial transformations within the AC1Modern system.</summary>
public unsafe struct AFrame
{
    // Members
    public ACBindings.Internal.Vector3 m_vOrigin;
    public ACBindings.Internal.Quaternion m_qOrientation;

    // Methods
}

