namespace ACBindings;

// LayerStage
public unsafe struct LayerStage : System.IDisposable
{
    // Members
    public ACBindings.PStringBase__sbyte m_SamplerName;
    public ACBindings.PStringBase__sbyte m_TextureFileName;
    public ACBindings.IDClass___tagDataID m_TextureDID;
    public ACBindings.RenderTexture* m_pTexture;
    public uint m_SpecialTexture;
    public ACBindings.TexAddress m_AddressModeU;
    public ACBindings.TexAddress m_AddressModeV;
    public ACBindings.TexFilterMode m_MinFilterMode;
    public ACBindings.TexFilterMode m_MagFilterMode;
    public ACBindings.TexFilterMode m_MipFilterMode;
    public ACBindings.TextureOp m_FFColorOp;
    public uint m_FFColorArg1;
    public uint m_FFColorArg2;
    public ACBindings.TextureOp m_FFAlphaOp;
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
    // bool __thiscall LayerStage::ReleaseSubObjects(LayerStage*)
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayerStage, byte>)0x00447F60)(ref this);
    // void __thiscall LayerStage::Begin(LayerStage*)
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayerStage, void>)0x00447F70)(ref this);
    // bool __thiscall LayerStage::CopyInto(LayerStage*,const bool,LayerStage*)
    public byte CopyInto(byte IsInstance, ACBindings.LayerStage* target) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayerStage, byte, ACBindings.LayerStage*, byte>)0x00448040)(ref this, IsInstance, target);
    // char __thiscall LayerStage::SetTexture(RenderTexture**,RenderTexture**,int)
    public sbyte SetTexture(ACBindings.RenderTexture** a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayerStage, ACBindings.RenderTexture**, int, sbyte>)0x00448140)(ref this, a2, a3);
    // bool __thiscall LayerStage::SetTexture(LayerStage*,RenderTexture*)
    public byte SetTexture(ACBindings.RenderTexture* pNewTexture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayerStage, ACBindings.RenderTexture*, byte>)0x00448200)(ref this, pNewTexture);
    // void __thiscall LayerStage::LayerStage(LayerStage*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayerStage, void>)0x00448350)(ref this);
    // void __thiscall LayerStage::~LayerStage(LayerStage*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayerStage, void>)0x00448390)(ref this);
    // LayerStage* __thiscall LayerStage::Copy(LayerStage*,const bool)
    public ACBindings.LayerStage* Copy(byte IsInstance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayerStage, byte, ACBindings.LayerStage*>)0x004483F0)(ref this, IsInstance);
    // bool __thiscall LayerStage::GetSubObjects(LayerStage*)
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayerStage, byte>)0x00448460)(ref this);
    // void __thiscall LayerStage::Serialize(LayerStage*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LayerStage, ACBindings.Archive*, void>)0x004484E0)(ref this, io_archive);
}

