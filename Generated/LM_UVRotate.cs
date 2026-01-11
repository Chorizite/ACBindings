namespace ACBindings.Internal;

public unsafe struct LM_UVRotate
{
    // Base Classes
    public ACBindings.Internal.LayerModifier BaseClass_LayerModifier; // ACBindings.Internal.LayerModifier

    // Child Types
    public unsafe struct LM_UVRotate_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, ACBindings.Internal.LayerModType> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, uint> GetTCIndex; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, uint> GetSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, byte> DoesModifyVertex; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, ACBindings.Internal.LayerModifier*> Copy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, System.IntPtr, ACBindings.Internal.VertexFormatInfo*, void> Apply; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, ACBindings.Internal.Matrix4*, void> ApplyTextureTransform; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> LoadFromFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> SaveToFileNode; // function pointer

        // Methods
    }

    // Members
    public uint texCoordIndex;
    public ACBindings.Internal.Waveform rotate;

    // Generated Constructor
    public LM_UVRotate() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004508B0
    /// void __thiscall LM_UVRotate::LM_UVRotate(LM_UVRotate*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVRotate, void>)0x004508B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004508E0
    /// unsigned int __thiscall LM_UVRotate::GetSize(LM_UVRotate*)</code>
    /// </summary>
    public uint GetSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVRotate, uint>)0x004508E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004508F0
    /// void __thiscall LM_UVRotate::ApplyTextureTransform(LM_UVRotate*,Matrix4*)</code>
    /// </summary>
    public void ApplyTextureTransform(ACBindings.Internal.Matrix4* mTextureMatrix) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVRotate, ACBindings.Internal.Matrix4*, void>)0x004508F0)(ref this, mTextureMatrix);

    /// <summary>
    /// <code>Offset: 0x00450B50
    /// LayerModifier* __thiscall LM_UVRotate::Copy(LM_UVRotate*)</code>
    /// </summary>
    public ACBindings.Internal.LayerModifier* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVRotate, ACBindings.Internal.LayerModifier*>)0x00450B50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00450F70
    /// void __thiscall LM_UVRotate::Serialize(LM_UVRotate*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVRotate, ACBindings.Internal.Archive*, void>)0x00450F70)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x00450FF0
    /// bool __thiscall LM_UVRotate::SaveToFileNode(LM_UVRotate*,PFileNode*,const RenderMaterial*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public byte SaveToFileNode(ACBindings.Internal.PFileNode* baseNode, ACBindings.Internal.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVRotate, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte>)0x00450FF0)(ref this, baseNode, owner, layerIndex, modIndex);

    /// <summary>
    /// <code>Offset: 0x004516D0
    /// bool __thiscall LM_UVRotate::LoadFromFileNode(LM_UVRotate*,const PFileNode*,RenderMaterial*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public byte LoadFromFileNode(ACBindings.Internal.PFileNode* baseNode, ACBindings.Internal.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVRotate, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte>)0x004516D0)(ref this, baseNode, owner, layerIndex, modIndex);
}

