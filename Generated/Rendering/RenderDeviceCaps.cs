namespace ACBindings.Internal;


/// <summary>Describes the capabilities of a rendering device, including maximum texture dimensions, supported features such as hardware vertex processing and compression, and limits on resources like simultaneous textures and render targets.</summary>
public unsafe struct RenderDeviceCaps
{
    // Members
    public uint MaxTextureWidth;
    public uint MaxTextureHeight;
    public uint MaxSimultaneousTextures;
    public uint MaxTextureBlendStages;
    public uint MaxSimultaneousRenderTargets;
    public uint MaxActiveLights;
    public uint MaxUserClipPlanes;
    public byte bCanDoSinglePassDetailing;
    public byte bTexOpDotProduct3;
    public byte bTexOpBumpEnvMap;
    public byte bDestinationAlpha;
    public byte bSquareTexturesOnly;
    public byte b3DTextures;
    public byte bCubeTextures;
    public byte bColorWriteControl;
    public byte bHardwareVertexProcessing;
    public byte bOcclusionQueries;
    public byte bSimpleNonPowerOfTwoTextures;
    public byte bPointSprites;
    public byte bAutoGenMipMaps;
    public byte bDynamicTextures;
    public byte bSlopeScaleDepthBias;
    public byte bBlendOp;
    public byte bTwoSidedStencil;
    public byte bCompressedTextures;

    // Methods
}

