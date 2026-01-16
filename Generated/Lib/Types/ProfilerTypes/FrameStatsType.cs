namespace ACBindings.Internal.ProfilerTypes;


/// <summary>Collects per-frame rendering metrics such as geometry counts, texture uploads, memory usage, audio activity, and UI processing, enabling detailed performance analysis of a 32-bit Windows application.</summary>
public unsafe struct FrameStatsType
{
    // Members
    public uint TrianglesRendered;
    public uint VerticesRendered;
    public uint BatchesRendered;
    public uint UISurfacesRendered;
    public uint VerticesSkinned;
    public uint TexturesUploaded;
    public uint TextureMemoryUploaded;
    public uint VerticesUploaded;
    public uint VertexBufferMemoryUploaded;
    public uint RecycledDynamicVertices;
    public uint IndicesUploaded;
    public uint IndexBufferMemoryUploaded;
    public uint ParticlesRendered;
    public uint ParticleSystemsRendered;
    public uint MaterialLayersApplied;
    public uint D3DTextureChanges;
    public uint D3DStreamChanges;
    public uint TextureVideoMemoryUsed;
    public uint SurfaceVideoMemoryUsed;
    public uint VertexBufferVideoMemoryUsed;
    public uint IndexBufferVideoMemoryUsed;
    public uint ArtAssetMeshVideoMemoryUsed;
    public uint ArtAssetTextureVideoMemoryUsed;
    public uint SoundsPlaying;
    public uint SoundsQueued;
    public uint UIElementsProcessed;
    public ACBindings.Internal._EA7D754458462534F92FF185238D0A0C AC1;

    // Methods
}

