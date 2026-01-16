namespace ACBindings.Internal;


/// <summary>Represents the data required to render a mesh, including geometry, vertex format, and rendering flags. Holds pointers to the underlying D3D mesh and its runtime representation, along with tiling factors, stippled/alpha masks, baked lighting flag, UV animation settings, and size metadata.</summary>
public unsafe struct MeshBuffer
{
    // Members
    public ACBindings.Internal.ID3DXMesh* pMesh;
    public System.IntPtr pRenderMesh;
    public uint meshFVF;
    public float detailTilingFactorSet;
    public byte* isStippledOrAlphaedMask;
    public byte burnedInStaticLights;
    public byte m_bUseUVAnimation;
    public ACBindings.Internal.CVec2Duv m_vUVDelta;
    public uint m_RemoteSizeInBytes;

    // Methods
}

