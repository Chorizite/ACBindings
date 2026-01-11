namespace ACBindings.Internal;

public unsafe struct MaterialLayer : System.IDisposable
{
    // Members
    public uint m_Options;
    public uint m_TrueFlags;
    public uint m_FalseFlags;
    public ACBindings.Internal.RenderPassType m_RenderPass;
    public ACBindings.Internal.SmartArray___ShaderResourceType m_ShaderResources;
    public ACBindings.Internal.SmartArray___LayerStage_ptr m_Stages;
    public ACBindings.Internal.SmartArray___LayerModifier_ptr m_FFModifiers;
    public ACBindings.Internal.BlendMode m_SourceBlend;
    public ACBindings.Internal.BlendMode m_DestBlend;
    public ACBindings.Internal.BlendOpType m_BlendOp;
    public ACBindings.Internal.DepthTestMode m_DepthTest;
    public byte m_DepthWrite;
    public ACBindings.Internal.CullModeType m_CullMode;
    public byte m_AlphaTest;
    public ACBindings.Internal.Waveform m_AlphaTestRef;
    public ACBindings.Internal.RGBAColor m_cDiffuse;
    public ACBindings.Internal.RGBAColor m_cSpecular;
    public ACBindings.Internal.Waveform m_wSpecularPower;
    public ACBindings.Internal.RGBAColor m_cDye;

    // Generated Constructor
    public MaterialLayer() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0043DC50
    /// void __thiscall MaterialLayer::SetDiffuse(MaterialLayer*,const RGBAColor*)</code>
    /// </summary>
    public void SetDiffuse(ACBindings.Internal.RGBAColor* cColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, ACBindings.Internal.RGBAColor*, void>)0x0043DC50)(ref this, cColor);

    /// <summary>
    /// <code>Offset: 0x0043FFA0
    /// void __thiscall MaterialLayer::InsertStage(MaterialLayer*,const unsigned int,LayerStage*)</code>
    /// </summary>
    public void InsertStage(uint Index, ACBindings.Internal.LayerStage* pStage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, uint, ACBindings.Internal.LayerStage*, void>)0x0043FFA0)(ref this, Index, pStage);

    /// <summary>
    /// <code>Offset: 0x0044A4F0
    /// void __thiscall MaterialLayer::End(MaterialLayer*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, void>)0x0044A4F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044A8C0
    /// void __thiscall MaterialLayer::~MaterialLayer(MaterialLayer*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, void>)0x0044A8C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044A930
    /// void __thiscall MaterialLayer::Begin(MaterialLayer*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, void>)0x0044A930)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044AA40
    /// void __thiscall MaterialLayer::MaterialLayer(MaterialLayer*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, void>)0x0044AA40)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044AA80
    /// bool __thiscall MaterialLayer::CopyInto(MaterialLayer*,const bool,MaterialLayer*)</code>
    /// </summary>
    public byte CopyInto(byte IsInstance, ACBindings.Internal.MaterialLayer* target) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, byte, ACBindings.Internal.MaterialLayer*, byte>)0x0044AA80)(ref this, IsInstance, target);

    /// <summary>
    /// <code>Offset: 0x0044AF60
    /// void __thiscall MaterialLayer::Serialize(MaterialLayer*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, ACBindings.Internal.Archive*, void>)0x0044AF60)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x0044B5F0
    /// MaterialLayer* __thiscall MaterialLayer::Copy(MaterialLayer*,const bool)</code>
    /// </summary>
    public ACBindings.Internal.MaterialLayer* Copy(byte IsInstance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, byte, ACBindings.Internal.MaterialLayer*>)0x0044B5F0)(ref this, IsInstance);

    /// <summary>
    /// <code>Offset: 0x0044F970
    /// void __thiscall MaterialLayer::SetAlphaTestRef(MaterialLayer*,const Waveform*)</code>
    /// </summary>
    public void SetAlphaTestRef(ACBindings.Internal.Waveform* w) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, ACBindings.Internal.Waveform*, void>)0x0044F970)(ref this, w);

    /// <summary>
    /// <code>Offset: 0x0044F9C0
    /// void __thiscall MaterialLayer::SetSpecularPower(MaterialLayer*,const Waveform*)</code>
    /// </summary>
    public void SetSpecularPower(ACBindings.Internal.Waveform* wWave) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, ACBindings.Internal.Waveform*, void>)0x0044F9C0)(ref this, wWave);
}

