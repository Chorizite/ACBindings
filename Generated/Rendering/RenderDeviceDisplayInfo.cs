namespace ACBindings.Internal;


/// <summary>Describes the rendering device’s display configuration, indicating support for stencil buffers, multisampling, texture render targets, and available pixel formats for render targets, depth buffers, textures, and surfaces.</summary>
public unsafe struct RenderDeviceDisplayInfo
{
    // Members
    public byte bStencilBuffer;
    public byte bTextureRenderTargets;
    public byte bMultiSampling;
    public byte bMultiSample_2_Samples;
    public byte bMultiSample_4_Samples;
    public ACBindings.Internal.PixelFormatID pfRenderTargets;
    public ACBindings.Internal.PixelFormatID pfDepthBuffers;
    public ACBindings.Internal.PixelFormatID pfRGBTextures;
    public ACBindings.Internal.PixelFormatID pfARGBTextures;
    public ACBindings.Internal.PixelFormatID pfAlphaTextures;
    public ACBindings.Internal.PixelFormatID pfRGBSurfaces;
    public ACBindings.Internal.PixelFormatID pfARGBSurfaces;
    public ACBindings.Internal.PixelFormatID pfAlphaSurfaces;
    public ACBindings.Internal.PixelFormatID pfLowRGBSurfaces;
    public ACBindings.Internal.PixelFormatID pfLowARGBSurfaces;
    public ACBindings.Internal.PixelFormatID pfLowAlphaSurfaces;

    // Methods
}

