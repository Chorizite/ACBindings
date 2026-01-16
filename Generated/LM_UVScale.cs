namespace ACBindings.Internal;


/// <summary>Represents a UV scale modifier applied to texture coordinates within a material, storing per‑layer index and waveform‑controlled U/V scaling factors.</summary>
public unsafe struct LM_UVScale
{
    // Base Classes
    public ACBindings.Internal.LayerModifier BaseClass_LayerModifier; // ACBindings.Internal.LayerModifier

    // Child Types
    public unsafe struct LM_UVScale_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, ACBindings.Internal.LayerModType> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, uint> GetTCIndex; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, uint> GetSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, byte> DoesModifyVertex; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, ACBindings.Internal.LayerModifier*> Copy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, System.IntPtr, ACBindings.Internal.VertexFormatInfo*, void> Apply; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, ACBindings.Internal.Matrix4*, void> ApplyTextureTransform; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> LoadFromFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVScale*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> SaveToFileNode; // function pointer

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

    /// <summary>Initializes a UV scale modifier with default waveform settings and zero texture coordinate index.
    /// <code>Offset: 0x00450950
    /// void __thiscall LM_UVScale::LM_UVScale(LM_UVScale*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVScale, void>)0x00450950)(ref this);

    /// <summary>Applies UV scale transformation to the supplied texture matrix using the object's waveform-defined U and V scaling factors.
    /// <code>Offset: 0x00450A40
    /// void __thiscall LM_UVScale::ApplyTextureTransform(LM_UVScale*,Matrix4*)</code>
    /// </summary>
    /// <param name="mTextureMatrix">The texture matrix to be scaled; modified in place.</param>
    public void ApplyTextureTransform(ACBindings.Internal.Matrix4* mTextureMatrix) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVScale, ACBindings.Internal.Matrix4*, void>)0x00450A40)(ref this, mTextureMatrix);

    /// <summary>Creates a duplicate of the current LM_UVScale instance as a LayerModifier object.
    /// <code>Offset: 0x00450BA0
    /// LayerModifier* __thiscall LM_UVScale::Copy(LM_UVScale*)</code>
    /// </summary>
    /// <returns>A new LayerModifier pointing to a freshly allocated LM_UVScale that copies all data from this instance, or nullptr if allocation fails.</returns>
    public ACBindings.Internal.LayerModifier* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVScale, ACBindings.Internal.LayerModifier*>)0x00450BA0)(ref this);

    /// <summary>Writes UV scaling information (texture coordinate index, U scale, and V scale) into the specified file node. If the owning material provides override values for these fields, those are written instead of the stored defaults.
    /// <code>Offset: 0x004511C0
    /// bool __thiscall LM_UVScale::SaveToFileNode(LM_UVScale*,PFileNode*,const RenderMaterial*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="baseNode">The file node that will receive child nodes containing the UV scale data.</param>
    /// <param name="owner">Material from which override values may be retrieved.</param>
    /// <param name="layerIndex">Layer index within the material to check for overrides.</param>
    /// <param name="modIndex">Modifier index within the layer.</param>
    /// <returns>True if the node was populated successfully; otherwise false.</returns>
    public byte SaveToFileNode(ACBindings.Internal.PFileNode* baseNode, ACBindings.Internal.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVScale, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte>)0x004511C0)(ref this, baseNode, owner, layerIndex, modIndex);

    /// <summary>Parses UV scale settings from a file node and populates the LM_UVScale instance, updating texCoordIndex and U/V waveform scales.
    /// <code>Offset: 0x00451870
    /// bool __thiscall LM_UVScale::LoadFromFileNode(LM_UVScale*,const PFileNode*,RenderMaterial*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="baseNode">Root node containing UVScale configuration keywords.</param>
    /// <param name="owner">Material to which the UV scale applies; used for validating field indices.</param>
    /// <param name="layerIndex">Layer index within the material that receives these settings.</param>
    /// <param name="modIndex">Modification index identifying the specific modifier instance.</param>
    /// <returns>True if parsing succeeds without encountering invalid keywords; otherwise, false.</returns>
    public byte LoadFromFileNode(ACBindings.Internal.PFileNode* baseNode, ACBindings.Internal.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVScale, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte>)0x00451870)(ref this, baseNode, owner, layerIndex, modIndex);
}

