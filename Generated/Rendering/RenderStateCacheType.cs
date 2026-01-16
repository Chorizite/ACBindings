namespace ACBindings.Internal;


/// <summary>Cache of all Direct3D render states used to avoid repeated API calls, including blend settings, depth testing, texture sampler and stage configurations, and lighting parameters.</summary>
public unsafe struct RenderStateCacheType
{
    // Child Types

    /// <summary>
    ///   Defines the configuration for texture sampling, specifying address modes,
    ///   filter types, and mipmap LOD bias.
    /// </summary>
    public unsafe struct SamplerType
    {
        // Members
        public ACBindings.Internal.TexAddress AddressModeU;
        public ACBindings.Internal.TexAddress AddressModeV;
        public ACBindings.Internal.TexFilterMode MinFilterMode;
        public ACBindings.Internal.TexFilterMode MipFilterMode;
        public ACBindings.Internal.TexFilterMode MagFilterMode;
        public float MipmapLODBias;

        // Methods
    }

    /// <summary>Encapsulates the state of a fixed‑function render stage, including texture reference, alpha/color blending arguments, operations, and transformation flags.</summary>
    /// <remarks>Used by the rendering engine to cache and restore pipeline state efficiently.</remarks>
    public unsafe struct StageType
    {
        // Members
        public System.IntPtr pTexture;
        public uint FFAlphaArg1;
        public uint FFAlphaArg2;
        public ACBindings.Internal.TextureOp FFAlphaOp;
        public uint FFColorArg1;
        public uint FFColorArg2;
        public ACBindings.Internal.TextureOp FFColorOp;
        public uint FFTexCoordIndex;
        public uint FFTextureTransformFlags;

        // Methods
    }

    // Members
    public byte m_bForceStates;
    public byte AlphaBlendEnable;
    public byte AlphaTestEnable;
    public ACBindings.Internal.AlphaTestFunc AlphaTestFunction;
    public uint AlphaTestRef;
    public ACBindings.Internal.BlendOpType BlendOp;
    public uint ColorWriteEnable;
    public ACBindings.Internal.CullModeType CullMode;
    public float DepthBias;
    public byte DepthBufferEnable;
    public ACBindings.Internal.DepthTestMode DepthTestFunction;
    public byte DepthWriteEnable;
    public ACBindings.Internal.BlendMode DestBlend;
    public uint FFAmbientColor32;
    public ACBindings.Internal.ColorSource FFAmbientColorSource;
    public ACBindings.Internal.ColorSource FFDiffuseColorSource;
    public ACBindings.Internal.RGBAColor FFFogColor;
    public byte FFFogEnable;
    public byte FFFogSystemDisabled;
    public byte FFFogUserDisabled;
    public byte FFFogAlphaDisabled;
    public float FFFogFarDistance;
    public float FFFogNearDistance;
    public byte FFLighting;
    public fixed byte FFLightEnable[8];
    public ACBindings.Internal.ColorSource FFEmissiveColorSource;
    public ACBindings.Internal.ColorSource FFSpecularColorSource;
    public byte FFSpecularEnable;
    public uint FFTextureFactor32;
    public ACBindings.Internal.FillModeType FillMode;
    public byte MultiSampleAntialias;
    public System.IntPtr pVertexBuffer;
    public ACBindings.Internal.BlendMode SourceBlend;
    public fixed byte Samplers_Raw[384];
    public ACBindings.Internal.RenderStateCacheType.SamplerType* Samplers => (ACBindings.Internal.RenderStateCacheType.SamplerType*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref Samplers_Raw[0]);
    public fixed byte Stages_Raw[288];
    public ACBindings.Internal.RenderStateCacheType.StageType* Stages => (ACBindings.Internal.RenderStateCacheType.StageType*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref Stages_Raw[0]);

    // Generated Constructor
    public RenderStateCacheType() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a RenderStateCacheType instance with all rendering parameters set to safe defaults, including blend modes, sampler settings, texture stages, and lighting/fog configuration.
    /// <code>Offset: 0x0059CB40
    /// void __thiscall RenderStateCacheType::RenderStateCacheType(RenderStateCacheType*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RenderStateCacheType, void>)0x0059CB40)(ref this);
}

