namespace ACBindings.Internal;

public unsafe struct LM_UVTranslate
{
    // Base Classes
    public ACBindings.Internal.LayerModifier BaseClass_LayerModifier; // ACBindings.Internal.LayerModifier

    // Child Types
    public unsafe struct LM_UVTranslate_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, ACBindings.Internal.LayerModType> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, uint> GetTCIndex; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, uint> GetSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, byte> DoesModifyVertex; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, ACBindings.Internal.LayerModifier*> Copy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, System.IntPtr, ACBindings.Internal.VertexFormatInfo*, void> Apply; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, ACBindings.Internal.Matrix4*, void> ApplyTextureTransform; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> LoadFromFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> SaveToFileNode; // function pointer

        // Methods
    }

    // Members
    public uint texCoordIndex;
    public ACBindings.Internal.Waveform uTranslate;
    public ACBindings.Internal.Waveform vTranslate;

    // Generated Constructor
    public LM_UVTranslate() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0044F8D0
    /// void __thiscall LM_UVTranslate::SetUTranslate(LM_UVScale*,const Waveform*)</code>
    /// </summary>
    public void SetUTranslate(ACBindings.Internal.Waveform* uScale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, ACBindings.Internal.Waveform*, void>)0x0044F8D0)(ref this, uScale);

    /// <summary>
    /// <code>Offset: 0x0044F920
    /// void __thiscall LM_UVTranslate::SetVTranslate(LM_UVScale*,const Waveform*)</code>
    /// </summary>
    public void SetVTranslate(ACBindings.Internal.Waveform* vScale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, ACBindings.Internal.Waveform*, void>)0x0044F920)(ref this, vScale);

    /// <summary>
    /// <code>Offset: 0x004507E0
    /// void __thiscall LM_UVTranslate::LM_UVTranslate(LM_UVTranslate*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, void>)0x004507E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00450820
    /// unsigned int __thiscall LM_UVTranslate::GetSize(LM_UVScale*)</code>
    /// </summary>
    public uint GetSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, uint>)0x00450820)(ref this);

    /// <summary>
    /// <code>Offset: 0x00450830
    /// void __thiscall LM_UVTranslate::ApplyTextureTransform(LM_UVTranslate*,Matrix4*)</code>
    /// </summary>
    public void ApplyTextureTransform(ACBindings.Internal.Matrix4* mTextureMatrix) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, ACBindings.Internal.Matrix4*, void>)0x00450830)(ref this, mTextureMatrix);

    /// <summary>
    /// <code>Offset: 0x00450C50
    /// LayerModifier* __thiscall LM_UVTranslate::Copy(LM_UVTranslate*)</code>
    /// </summary>
    public ACBindings.Internal.LayerModifier* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, ACBindings.Internal.LayerModifier*>)0x00450C50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00450CB0
    /// void __thiscall LM_UVTranslate::Serialize(LM_UVScale*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, ACBindings.Internal.Archive*, void>)0x00450CB0)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x00450D20
    /// bool __thiscall LM_UVTranslate::SaveToFileNode(LM_UVTranslate*,PFileNode*,const RenderMaterial*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public byte SaveToFileNode(ACBindings.Internal.PFileNode* baseNode, ACBindings.Internal.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte>)0x00450D20)(ref this, baseNode, owner, layerIndex, modIndex);

    /// <summary>
    /// <code>Offset: 0x004514A0
    /// bool __thiscall LM_UVTranslate::LoadFromFileNode(LM_UVTranslate*,const PFileNode*,RenderMaterial*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public byte LoadFromFileNode(ACBindings.Internal.PFileNode* baseNode, ACBindings.Internal.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte>)0x004514A0)(ref this, baseNode, owner, layerIndex, modIndex);
}

