namespace ACBindings.Internal;


/// <summary>Defines a display mode by specifying resolution, pixel format, and refresh rate for rendering output.</summary>
public unsafe struct RenderDisplayModeType
{
    // Members
    public uint nWidth;
    public uint nHeight;
    public ACBindings.Internal.PixelFormatID Format;
    public uint nRefreshRate;

    // Methods
}

