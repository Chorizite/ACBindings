namespace ACBindings;

// RenderSurfaceSourceData
public unsafe struct RenderSurfaceSourceData
{
    // Members
    public uint width;
    public uint height;
    public uint imageSize;
    public byte* sourceBits;
    public ACBindings.PixelFormatDesc pfDesc;

    // Methods
}

