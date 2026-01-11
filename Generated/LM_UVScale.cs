namespace ACBindings.Internal;

public unsafe struct LM_UVScale
{
    // Base Classes
    public ACBindings.Internal.LayerModifier BaseClass_LayerModifier; // ACBindings.Internal.LayerModifier

    // Child Types
    public unsafe struct LM_UVScale_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, ACBindings.Internal.LayerModType> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, uint> GetTCIndex; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, uint> GetSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, byte> DoesModifyVertex; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, ACBindings.Internal.LayerModifier*> Copy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, System.IntPtr, ACBindings.Internal.VertexFormatInfo*, void> Apply; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, ACBindings.Internal.Matrix4*, void> ApplyTextureTransform; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> LoadFromFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> SaveToFileNode; // function pointer

        // Methods
    }

    // Members
    public uint texCoordIndex;
    public ACBindings.Internal.Waveform uScale;
    public ACBindings.Internal.Waveform vScale;

    // Generated Constructor
    public LM_UVScale() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00450950
    /// void __thiscall LM_UVScale::LM_UVScale(LM_UVScale*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVScale, void>)0x00450950)(ref this);

    /// <summary>
    /// <code>Offset: 0x00450A40
    /// void __thiscall LM_UVScale::ApplyTextureTransform(LM_UVScale*,Matrix4*)</code>
    /// </summary>
    public void ApplyTextureTransform(ACBindings.Internal.Matrix4* mTextureMatrix) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVScale, ACBindings.Internal.Matrix4*, void>)0x00450A40)(ref this, mTextureMatrix);

    /// <summary>
    /// <code>Offset: 0x00450BA0
    /// LayerModifier* __thiscall LM_UVScale::Copy(LM_UVScale*)</code>
    /// </summary>
    public ACBindings.Internal.LayerModifier* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVScale, ACBindings.Internal.LayerModifier*>)0x00450BA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004511C0
    /// bool __thiscall LM_UVScale::SaveToFileNode(LM_UVScale*,PFileNode*,const RenderMaterial*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public byte SaveToFileNode(ACBindings.Internal.PFileNode* baseNode, ACBindings.Internal.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVScale, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte>)0x004511C0)(ref this, baseNode, owner, layerIndex, modIndex);

    /// <summary>
    /// <code>Offset: 0x00451870
    /// bool __thiscall LM_UVScale::LoadFromFileNode(LM_UVScale*,const PFileNode*,RenderMaterial*,const unsigned int,const unsigned int)</code>
    /// </summary>
    public byte LoadFromFileNode(ACBindings.Internal.PFileNode* baseNode, ACBindings.Internal.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVScale, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte>)0x00451870)(ref this, baseNode, owner, layerIndex, modIndex);
}

