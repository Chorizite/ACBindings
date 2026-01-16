namespace ACBindings.Internal;


/// <summary>Defines layout information for a skinned vertex format, including offsets for matrix weights, transformation matrices, normals, number of matrices, and overall size.</summary>
/// <remarks>Used by the rendering pipeline to interpret vertex buffer data during skinning and shading operations.</remarks>
public unsafe struct BV_VertexFormatType
{
    // Members
    public uint OffsetMWeights;
    public uint OffsetMatrices;
    public uint OffsetNormal;
    public uint NumMatrices;
    public uint Size;

    // Methods
}

