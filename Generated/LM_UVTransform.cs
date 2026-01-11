namespace ACBindings.Internal;

public unsafe struct LM_UVTransform
{
    // Base Classes
    public ACBindings.Internal.LayerModifier BaseClass_LayerModifier; // ACBindings.Internal.LayerModifier

    // Child Types
    public unsafe struct LM_UVTransform_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, ACBindings.Internal.LayerModType> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, uint> GetTCIndex; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, uint> GetSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, byte> DoesModifyVertex; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, ACBindings.Internal.LayerModifier*> Copy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, System.IntPtr, ACBindings.Internal.VertexFormatInfo*, void> Apply; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, ACBindings.Internal.Matrix4*, void> ApplyTextureTransform; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> LoadFromFileNode; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> SaveToFileNode; // function pointer

        // Methods
    }

    // Members
    public uint m_nStageIndex;
    public ACBindings.Internal.Matrix4 m_mTransform;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00450B10
    /// unsigned int __thiscall LM_UVTransform::GetSize(LM_UVTransform*)</code>
    /// </summary>
    public uint GetSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTransform, uint>)0x00450B10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00450B20
    /// void __thiscall LM_UVTransform::ApplyTextureTransform(LM_UVTransform*,Matrix4*)</code>
    /// </summary>
    public void ApplyTextureTransform(ACBindings.Internal.Matrix4* mTextureMatrix) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTransform, ACBindings.Internal.Matrix4*, void>)0x00450B20)(ref this, mTextureMatrix);

    /// <summary>
    /// <code>Offset: 0x00450BE0
    /// LayerModifier* __thiscall LM_UVTransform::Copy(LM_UVTransform*)</code>
    /// </summary>
    public ACBindings.Internal.LayerModifier* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTransform, ACBindings.Internal.LayerModifier*>)0x00450BE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00451410
    /// void __thiscall LM_UVTransform::Serialize(LM_UVTransform*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTransform, ACBindings.Internal.Archive*, void>)0x00451410)(ref this, io_archive);
}

