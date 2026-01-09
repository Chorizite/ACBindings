namespace ACBindings;

// VertexFormatInfo
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
    // void __thiscall VertexFormatInfo::GenerateOffsets(VertexFormatInfo*)
    public void GenerateOffsets() => ((delegate* unmanaged[Thiscall]<ref ACBindings.VertexFormatInfo, void>)0x005D97F0)(ref this);
}

