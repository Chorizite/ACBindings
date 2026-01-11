namespace ACBindings.Internal;

public unsafe struct LayerStage : System.IDisposable
{
    // Members
    public ACBindings.Internal.PStringBase__sbyte m_SamplerName;
    public ACBindings.Internal.PStringBase__sbyte m_TextureFileName;
    public ACBindings.Internal.IDClass____tagDataID m_TextureDID;
    public ACBindings.Internal.RenderTexture* m_pTexture;
    public uint m_SpecialTexture;
    public ACBindings.Internal.TexAddress m_AddressModeU;
    public ACBindings.Internal.TexAddress m_AddressModeV;
    public ACBindings.Internal.TexFilterMode m_MinFilterMode;
    public ACBindings.Internal.TexFilterMode m_MagFilterMode;
    public ACBindings.Internal.TexFilterMode m_MipFilterMode;
    public ACBindings.Internal.TextureOp m_FFColorOp;
    public uint m_FFColorArg1;
    public uint m_FFColorArg2;
    public ACBindings.Internal.TextureOp m_FFAlphaOp;
    public uint m_FFAlphaArg1;
    public uint m_FFAlphaArg2;
    public uint m_FFTexCoordIndex;
    public byte m_FFUseProjection;

    // Generated Constructor
    public LayerStage() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00447F60
    /// bool __thiscall LayerStage::ReleaseSubObjects(LayerStage*)</code>
    /// </summary>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, byte>)0x00447F60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00447F70
    /// void __thiscall LayerStage::Begin(LayerStage*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, void>)0x00447F70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00448040
    /// bool __thiscall LayerStage::CopyInto(LayerStage*,const bool,LayerStage*)</code>
    /// </summary>
    public byte CopyInto(byte IsInstance, ACBindings.Internal.LayerStage* target) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, byte, ACBindings.Internal.LayerStage*, byte>)0x00448040)(ref this, IsInstance, target);

    /// <summary>
    /// <code>Offset: 0x00448140
    /// char __thiscall LayerStage::SetTexture(RenderTexture**,RenderTexture**,int)</code>
    /// </summary>
    public sbyte SetTexture(ACBindings.Internal.RenderTexture** a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, ACBindings.Internal.RenderTexture**, int, sbyte>)0x00448140)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00448200
    /// bool __thiscall LayerStage::SetTexture(LayerStage*,RenderTexture*)</code>
    /// </summary>
    public byte SetTexture(ACBindings.Internal.RenderTexture* pNewTexture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, ACBindings.Internal.RenderTexture*, byte>)0x00448200)(ref this, pNewTexture);

    /// <summary>
    /// <code>Offset: 0x00448350
    /// void __thiscall LayerStage::LayerStage(LayerStage*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, void>)0x00448350)(ref this);

    /// <summary>
    /// <code>Offset: 0x00448390
    /// void __thiscall LayerStage::~LayerStage(LayerStage*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, void>)0x00448390)(ref this);

    /// <summary>
    /// <code>Offset: 0x004483F0
    /// LayerStage* __thiscall LayerStage::Copy(LayerStage*,const bool)</code>
    /// </summary>
    public ACBindings.Internal.LayerStage* Copy(byte IsInstance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, byte, ACBindings.Internal.LayerStage*>)0x004483F0)(ref this, IsInstance);

    /// <summary>
    /// <code>Offset: 0x00448460
    /// bool __thiscall LayerStage::GetSubObjects(LayerStage*)</code>
    /// </summary>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, byte>)0x00448460)(ref this);

    /// <summary>
    /// <code>Offset: 0x004484E0
    /// void __thiscall LayerStage::Serialize(LayerStage*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, ACBindings.Internal.Archive*, void>)0x004484E0)(ref this, io_archive);
}

