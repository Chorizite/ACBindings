namespace ACBindings.Internal;


/// <summary>Encapsulates a texture stage’s UV transformation matrix and associated stage index, enabling copying, application to texture matrices, and serialization.</summary>
public unsafe struct LM_UVTransform
{
    // Base Classes
    public ACBindings.Internal.LayerModifier BaseClass_LayerModifier; // ACBindings.Internal.LayerModifier

    // Child Types
    public unsafe struct LM_UVTransform_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, ACBindings.Internal.LayerModType> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, uint> GetTCIndex; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, uint> GetSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, byte> DoesModifyVertex; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, ACBindings.Internal.LayerModifier*> Copy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, System.IntPtr, ACBindings.Internal.VertexFormatInfo*, void> Apply; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, ACBindings.Internal.Matrix4*, void> ApplyTextureTransform; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> LoadFromFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTransform*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> SaveToFileNode; // function pointer

        // Methods
    }

    // Members
    public uint m_nStageIndex;
    public ACBindings.Internal.Matrix4 m_mTransform;

    // Methods

    /// <summary>Returns the size, in bytes, of an LM_UVTransform object.
    /// <code>Offset: 0x00450B10
    /// unsigned int __thiscall LM_UVTransform::GetSize(LM_UVTransform*)</code>
    /// </summary>
    /// <returns>The number of bytes that comprise an LM_UVTransform instance.</returns>
    public uint GetSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTransform, uint>)0x00450B10)(ref this);

    /// <summary>Applies the UV transformation stored in this object to the supplied texture matrix.
    /// <code>Offset: 0x00450B20
    /// void __thiscall LM_UVTransform::ApplyTextureTransform(LM_UVTransform*,Matrix4*)</code>
    /// </summary>
    /// <param name="mTextureMatrix">The texture matrix to transform; after execution it contains the transformed matrix.</param>
    public void ApplyTextureTransform(ACBindings.Internal.Matrix4* mTextureMatrix) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTransform, ACBindings.Internal.Matrix4*, void>)0x00450B20)(ref this, mTextureMatrix);

    /// <summary>Creates an independent copy of this UV transform, allocating a new LayerModifier object that duplicates its transformation matrix and associated stage data.
    /// <code>Offset: 0x00450BE0
    /// LayerModifier* __thiscall LM_UVTransform::Copy(LM_UVTransform*)</code>
    /// </summary>
    /// <returns>A pointer to the newly created LayerModifier instance representing the copied transform; returns nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.LayerModifier* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTransform, ACBindings.Internal.LayerModifier*>)0x00450BE0)(ref this);

    /// <summary>Serializes this UV transform's type identifier, stage index, and 4×4 transformation matrix to or from an Archive based on read/write mode.
    /// <code>Offset: 0x00451410
    /// void __thiscall LM_UVTransform::Serialize(LM_UVTransform*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive instance used for reading or writing the object's data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTransform, ACBindings.Internal.Archive*, void>)0x00451410)(ref this, io_archive);
}

