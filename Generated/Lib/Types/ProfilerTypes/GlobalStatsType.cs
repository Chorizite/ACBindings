namespace ACBindings.Internal.ProfilerTypes;


/// <summary>Aggregates runtime statistics for memory allocation and resource usage across graphics, audio, UI, and scene components, providing a consolidated view of system performance.</summary>
/// <remarks>Fields represent amounts of video memory allocated for textures, buffers, surfaces, as well as CPU-side memory allocations for fonts, audio data, and other engine resources. The struct is used by the profiling subsystem to expose global metrics for diagnostics and optimization.</remarks>
public unsafe struct GlobalStatsType
{
    // Members
    public ACBindings.Internal._32F96AD321CDC6745C0A66C54DC7D599 AC1;
    public uint TextureVideoMemoryAllocated;
    public uint SurfaceVideoMemoryAllocated;
    public uint StaticVertexBufferVideoMemoryAllocated;
    public uint DynamicVertexBufferVideoMemoryAllocated;
    public uint StaticIndexBufferVideoMemoryAllocated;
    public uint DynamicIndexBufferVideoMemoryAllocated;
    public uint SurfaceMemoryAllocated;
    public uint UISurfaceMemoryAllocated;
    public uint MeshVertexMemoryAllocated;
    public uint MeshTriangleMemoryAllocated;
    public uint MeshTopologyMemoryAllocated;
    public uint FontMemoryAllocated;
    public uint AudioMemoryAllocated;
    public uint SoundSources;
    public uint MovieMemoryAllocated;
    public uint LandBlockMemoryAllocated;
    public uint Direct3DHardwareStalls;
    public uint CompositorResourceMemoryAllocated;
    public uint CompositorTextureMemoryAllocated;
    public uint AC1_ImgTexMemoryAllocated;
    public uint AC1_D3DXMeshMemoryAllocated;

    // Methods
}

