namespace ACBindings;

// RenderStateCacheType
public unsafe struct RenderStateCacheType
{
    // Child Types
    // RenderStateCacheType::SamplerType
    public unsafe struct SamplerType
    {
        // Members
        public ACBindings.TexAddress AddressModeU;
        public ACBindings.TexAddress AddressModeV;
        public ACBindings.TexFilterMode MinFilterMode;
        public ACBindings.TexFilterMode MipFilterMode;
        public ACBindings.TexFilterMode MagFilterMode;
        public float MipmapLODBias;

        // Methods
    }
    // RenderStateCacheType::StageType
    public unsafe struct StageType
    {
        // Members
        public System.IntPtr pTexture;
        public uint FFAlphaArg1;
        public uint FFAlphaArg2;
        public ACBindings.TextureOp FFAlphaOp;
        public uint FFColorArg1;
        public uint FFColorArg2;
        public ACBindings.TextureOp FFColorOp;
        public uint FFTexCoordIndex;
        public uint FFTextureTransformFlags;

        // Methods
    }

    // Members
    public byte m_bForceStates;
    public byte AlphaBlendEnable;
    public byte AlphaTestEnable;
    public ACBindings.AlphaTestFunc AlphaTestFunction;
    public uint AlphaTestRef;
    public ACBindings.BlendOpType BlendOp;
    public uint ColorWriteEnable;
    public ACBindings.CullModeType CullMode;
    public float DepthBias;
    public byte DepthBufferEnable;
    public ACBindings.DepthTestMode DepthTestFunction;
    public byte DepthWriteEnable;
    public ACBindings.BlendMode DestBlend;
    public uint FFAmbientColor32;
    public ACBindings.ColorSource FFAmbientColorSource;
    public ACBindings.ColorSource FFDiffuseColorSource;
    public ACBindings.RGBAColor FFFogColor;
    public byte FFFogEnable;
    public byte FFFogSystemDisabled;
    public byte FFFogUserDisabled;
    public byte FFFogAlphaDisabled;
    public float FFFogFarDistance;
    public float FFFogNearDistance;
    public byte FFLighting;
    public fixed byte FFLightEnable[8];
    public ACBindings.ColorSource FFEmissiveColorSource;
    public ACBindings.ColorSource FFSpecularColorSource;
    public byte FFSpecularEnable;
    public uint FFTextureFactor32;
    public ACBindings.FillModeType FillMode;
    public byte MultiSampleAntialias;
    public System.IntPtr pVertexBuffer;
    public ACBindings.BlendMode SourceBlend;
    public fixed byte Samplers_Raw[384];
    public ACBindings.RenderStateCacheType.SamplerType* Samplers => (ACBindings.RenderStateCacheType.SamplerType*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref Samplers_Raw[0]);
    public fixed byte Stages_Raw[288];
    public ACBindings.RenderStateCacheType.StageType* Stages => (ACBindings.RenderStateCacheType.StageType*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref Stages_Raw[0]);

    // Generated Constructor
    public RenderStateCacheType() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall RenderStateCacheType::RenderStateCacheType(RenderStateCacheType*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RenderStateCacheType, void>)0x0059CB40)(ref this);
}

