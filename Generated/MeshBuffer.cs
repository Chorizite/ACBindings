namespace ACBindings;

// MeshBuffer
public unsafe struct MeshBuffer
{
    // Members
    public ACBindings.ID3DXMesh* pMesh;
    public System.IntPtr pRenderMesh;
    public uint meshFVF;
    public float detailTilingFactorSet;
    public byte* isStippledOrAlphaedMask;
    public byte burnedInStaticLights;
    public byte m_bUseUVAnimation;
    public ACBindings.CVec2Duv m_vUVDelta;
    public uint m_RemoteSizeInBytes;

    // Methods
}

