namespace ACBindings.Internal;


/// <summary>
/// Describes the layout and characteristics of a vertex buffer used by the graphics engine. Stores format identifiers, component counts, compatibility flags, and byte offsets for positions, weights, normals, texture coordinates, colors, and skinning data.
/// </summary>
public unsafe struct VertexFormatInfo
{
    // Members
    public uint format;
    public uint size;
    public byte bFVFCompatible;
    public uint formatFVF;
    public uint numWeights;
    public uint numTCPairs;
    public uint numMatrices;
    public uint offsetOrigin;
    public uint offsetWeight0;
    public uint offsetWeight1;
    public uint offsetWeight2;
    public uint offsetWeight3;
    public uint offsetWeight4;
    public uint offsetNormal;
    public uint offsetPointSize;
    public uint offsetDiffuse;
    public uint offsetSpecular;
    public fixed uint offsetTCPair[8];
    public uint offsetVectorS;
    public uint offsetVectorT;
    public uint offsetMatrices;
    public uint offsetMWeights;

    // Methods

    /// <summary>Calculates vertex field offsets and total stride based on format flags in the VertexFormatInfo instance, updating offset members, FVF compatibility flag, and size.
    /// <code>Offset: 0x005D97F0
    /// void __thiscall VertexFormatInfo::GenerateOffsets(VertexFormatInfo*)</code>
    /// </summary>
    public void GenerateOffsets() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VertexFormatInfo, void>)0x005D97F0)(ref this);
}

