namespace ACBindings.Internal;


/// <summary>
/// Defines a material layer used in rendering, encapsulating options, flags, render pass, shader resources, stages, modifiers, blending settings, depth behavior, culling mode, alpha testing configuration, and color properties such as diffuse, specular, dye. Holds configuration for a single rendering pass, controlling how geometry is blended, culled, depth‑tested, and shaded through shaders.
/// </summary>
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

    /// <summary>Sets the diffuse color of the material layer.
    /// <code>Offset: 0x0043DC50
    /// void __thiscall MaterialLayer::SetDiffuse(MaterialLayer*,const RGBAColor*)</code>
    /// </summary>
    /// <param name="cColor">The RGBA color to apply as the diffuse component.</param>
    public void SetDiffuse(ACBindings.Internal.RGBAColor* cColor) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, ACBindings.Internal.RGBAColor*, void>)0x0043DC50)(ref this, cColor);

    /// <summary>Insert a LayerStage into the material layer’s ordered stages collection at the given index.
    /// <code>Offset: 0x0043FFA0
    /// void __thiscall MaterialLayer::InsertStage(MaterialLayer*,const unsigned int,LayerStage*)</code>
    /// </summary>
    /// <param name="Index">Zero‑based position within the stage list where the new stage should appear.</param>
    /// <param name="pStage">Pointer to the stage object to be inserted.</param>
    public void InsertStage(uint Index, ACBindings.Internal.LayerStage* pStage) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, uint, ACBindings.Internal.LayerStage*, void>)0x0043FFA0)(ref this, Index, pStage);

    /// <summary>Releases all subobjects of each stage, deletes Stage objects and modifier instances, clears their arrays, resets internal counts and flags, and frees allocated memory, effectively cleaning up a MaterialLayer's dynamic resources.
    /// <code>Offset: 0x0044A4F0
    /// void __thiscall MaterialLayer::End(MaterialLayer*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, void>)0x0044A4F0)(ref this);

    /// <summary>Releases all resources owned by a MaterialLayer instance, invoking its End routine and freeing allocated shader resources, stages, and modifiers.
    /// <code>Offset: 0x0044A8C0
    /// void __thiscall MaterialLayer::~MaterialLayer(MaterialLayer*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, void>)0x0044A8C0)(ref this);

    /// <summary>Initializes the material layer with default rendering parameters, resetting flags, blend modes, and shader resources.
    /// <code>Offset: 0x0044A930
    /// void __thiscall MaterialLayer::Begin(MaterialLayer*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, void>)0x0044A930)(ref this);

    /// <summary>Initializes a MaterialLayer instance by clearing shader resources, stages, and modifiers arrays, constructing default waveforms for alpha test and specular power, then performing additional setup via Begin.
    /// <code>Offset: 0x0044AA40
    /// void __thiscall MaterialLayer::MaterialLayer(MaterialLayer*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, void>)0x0044AA40)(ref this);

    /// <summary>Copies this material layer's configuration into the specified target, cloning shader resources and stages when IsInstance is false.
    /// <code>Offset: 0x0044AA80
    /// bool __thiscall MaterialLayer::CopyInto(MaterialLayer*,const bool,MaterialLayer*)</code>
    /// </summary>
    /// <param name="IsInstance">If false, deep copies shader resource buffers and strings; if true, performs a shallow copy of references.</param>
    /// <param name="target">The MaterialLayer instance to receive the copied data.</param>
    /// <returns>True on success (always).</returns>
    public byte CopyInto(byte IsInstance, ACBindings.Internal.MaterialLayer* target) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, byte, ACBindings.Internal.MaterialLayer*, byte>)0x0044AA80)(ref this, IsInstance, target);

    /// <summary>Serializes the material layer's configuration—including options, flags, render pass, shader resources, stages, modifiers, blend modes, depth and cull settings, alpha test, colors, and waveforms—to or from an archive depending on its read/write mode.
    /// <code>Offset: 0x0044AF60
    /// void __thiscall MaterialLayer::Serialize(MaterialLayer*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for reading or writing the material layer data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, ACBindings.Internal.Archive*, void>)0x0044AF60)(ref this, io_archive);

    /// <summary>Creates a duplicate of the current material layer, optionally performing an instance-aware copy.
    /// <code>Offset: 0x0044B5F0
    /// MaterialLayer* __thiscall MaterialLayer::Copy(MaterialLayer*,const bool)</code>
    /// </summary>
    /// <param name="IsInstance">If true, copies resources as instance-specific; otherwise performs a direct copy.</param>
    /// <returns>A pointer to the new MaterialLayer object on success, or null if memory allocation or copying fails.</returns>
    public ACBindings.Internal.MaterialLayer* Copy(byte IsInstance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, byte, ACBindings.Internal.MaterialLayer*>)0x0044B5F0)(ref this, IsInstance);

    /// <summary>Assigns a new alpha test reference waveform to this material layer by copying the supplied waveform.
    /// <code>Offset: 0x0044F970
    /// void __thiscall MaterialLayer::SetAlphaTestRef(MaterialLayer*,const Waveform*)</code>
    /// </summary>
    /// <param name="w">The waveform defining the desired alpha test reference.</param>
    public void SetAlphaTestRef(ACBindings.Internal.Waveform* w) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, ACBindings.Internal.Waveform*, void>)0x0044F970)(ref this, w);

    /// <summary>Sets the specular power waveform for this material layer.
    /// <code>Offset: 0x0044F9C0
    /// void __thiscall MaterialLayer::SetSpecularPower(MaterialLayer*,const Waveform*)</code>
    /// </summary>
    /// <param name="wWave">Specifies the waveform used to compute specular intensity variations.</param>
    public void SetSpecularPower(ACBindings.Internal.Waveform* wWave) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialLayer, ACBindings.Internal.Waveform*, void>)0x0044F9C0)(ref this, wWave);
}

