namespace ACBindings;

// MaterialLayer
public unsafe struct MaterialLayer : System.IDisposable
{
    // Members
    public uint m_Options;
    public uint m_TrueFlags;
    public uint m_FalseFlags;
    public ACBindings.RenderPassType m_RenderPass;
    public ACBindings.SmartArray__ShaderResourceType m_ShaderResources;
    public ACBindings.SmartArray__LayerStage_ptr m_Stages;
    public ACBindings.SmartArray__LayerModifier_ptr m_FFModifiers;
    public ACBindings.BlendMode m_SourceBlend;
    public ACBindings.BlendMode m_DestBlend;
    public ACBindings.BlendOpType m_BlendOp;
    public ACBindings.DepthTestMode m_DepthTest;
    public byte m_DepthWrite;
    public ACBindings.CullModeType m_CullMode;
    public byte m_AlphaTest;
    public ACBindings.Waveform m_AlphaTestRef;
    public ACBindings.RGBAColor m_cDiffuse;
    public ACBindings.RGBAColor m_cSpecular;
    public ACBindings.Waveform m_wSpecularPower;
    public ACBindings.RGBAColor m_cDye;

    // Generated Constructor
    public MaterialLayer() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall MaterialLayer::SetDiffuse(MaterialLayer*,const RGBAColor*)
    public void SetDiffuse(ACBindings.RGBAColor* cColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialLayer, ACBindings.RGBAColor*, void>)0x0043DC50)(ref this, cColor);
    // void __thiscall MaterialLayer::InsertStage(MaterialLayer*,const unsigned int,LayerStage*)
    public void InsertStage(uint Index, ACBindings.LayerStage* pStage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialLayer, uint, ACBindings.LayerStage*, void>)0x0043FFA0)(ref this, Index, pStage);
    // void __thiscall MaterialLayer::End(MaterialLayer*)
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialLayer, void>)0x0044A4F0)(ref this);
    // void __thiscall MaterialLayer::~MaterialLayer(MaterialLayer*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialLayer, void>)0x0044A8C0)(ref this);
    // void __thiscall MaterialLayer::Begin(MaterialLayer*)
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialLayer, void>)0x0044A930)(ref this);
    // void __thiscall MaterialLayer::MaterialLayer(MaterialLayer*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialLayer, void>)0x0044AA40)(ref this);
    // bool __thiscall MaterialLayer::CopyInto(MaterialLayer*,const bool,MaterialLayer*)
    public byte CopyInto(byte IsInstance, ACBindings.MaterialLayer* target) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialLayer, byte, ACBindings.MaterialLayer*, byte>)0x0044AA80)(ref this, IsInstance, target);
    // void __thiscall MaterialLayer::Serialize(MaterialLayer*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialLayer, ACBindings.Archive*, void>)0x0044AF60)(ref this, io_archive);
    // MaterialLayer* __thiscall MaterialLayer::Copy(MaterialLayer*,const bool)
    public ACBindings.MaterialLayer* Copy(byte IsInstance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialLayer, byte, ACBindings.MaterialLayer*>)0x0044B5F0)(ref this, IsInstance);
    // void __thiscall MaterialLayer::SetAlphaTestRef(MaterialLayer*,const Waveform*)
    public void SetAlphaTestRef(ACBindings.Waveform* w) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialLayer, ACBindings.Waveform*, void>)0x0044F970)(ref this, w);
    // void __thiscall MaterialLayer::SetSpecularPower(MaterialLayer*,const Waveform*)
    public void SetSpecularPower(ACBindings.Waveform* wWave) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialLayer, ACBindings.Waveform*, void>)0x0044F9C0)(ref this, wWave);
}

