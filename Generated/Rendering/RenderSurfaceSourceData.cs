namespace ACBindings.Internal;


/// <summary>Stores surface source properties for rendering, including dimensions, image size, a pointer to raw pixel data, and the corresponding pixel format description.</summary>
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

