namespace ACBindings.Internal;

public unsafe struct RenderSurfaceSourceData
{
    // Members
    public uint width;
    public uint height;
    public uint imageSize;
    public byte* sourceBits;
    public ACBindings.Internal.PixelFormatDesc pfDesc;

    // Methods
}

