namespace ACBindings.Internal;


/// <summary>Encapsulates a texture rotation modifier that applies a dynamic Z‑axis rotation to a material's UV coordinates based on an animated waveform. Stores the target texture coordinate set and the rotation curve.</summary>
public unsafe struct LM_UVRotate
{
    // Base Classes
    public ACBindings.Internal.LayerModifier BaseClass_LayerModifier; // ACBindings.Internal.LayerModifier

    // Child Types
    public unsafe struct LM_UVRotate_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, ACBindings.Internal.LayerModType> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, uint> GetTCIndex; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, uint> GetSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, byte> DoesModifyVertex; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, ACBindings.Internal.LayerModifier*> Copy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, System.IntPtr, ACBindings.Internal.VertexFormatInfo*, void> Apply; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, ACBindings.Internal.Matrix4*, void> ApplyTextureTransform; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> LoadFromFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVRotate*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> SaveToFileNode; // function pointer

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

    /// <summary>Constructs an LM_UVRotate object, initializing the base class virtual table, setting up a default rotation waveform, and resetting the texture coordinate index to zero.
    /// <code>Offset: 0x004508B0
    /// void __thiscall LM_UVRotate::LM_UVRotate(LM_UVRotate*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVRotate, void>)0x004508B0)(ref this);

    /// <summary>Returns the size, in bytes, of an LM_UVRotate instance.
    /// <code>Offset: 0x004508E0
    /// unsigned int __thiscall LM_UVRotate::GetSize(LM_UVRotate*)</code>
    /// </summary>
    /// <returns>The byte size (52) of the structure.</returns>
    public uint GetSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVRotate, uint>)0x004508E0)(ref this);

    /// <summary>Applies a Z‑axis rotation to the supplied texture matrix, where the angle is derived from the instance’s rotate waveform evaluated at the current local time.
    /// <code>Offset: 0x004508F0
    /// void __thiscall LM_UVRotate::ApplyTextureTransform(LM_UVRotate*,Matrix4*)</code>
    /// </summary>
    /// <param name="mTextureMatrix">The texture matrix that will be modified in place.</param>
    public void ApplyTextureTransform(ACBindings.Internal.Matrix4* mTextureMatrix) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVRotate, ACBindings.Internal.Matrix4*, void>)0x004508F0)(ref this, mTextureMatrix);

    /// <summary>Creates and returns a duplicate of this LM_UVRotate instance as a LayerModifier pointer.
    /// <code>Offset: 0x00450B50
    /// LayerModifier* __thiscall LM_UVRotate::Copy(LM_UVRotate*)</code>
    /// </summary>
    /// <returns>A new LayerModifier representing a copy of the current object, or nullptr if allocation fails.</returns>
    public ACBindings.Internal.LayerModifier* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVRotate, ACBindings.Internal.LayerModifier*>)0x00450B50)(ref this);

    /// <summary>Serializes or deserializes the LM_UVRotate modifier to or from an Archive, storing its type identifier, texture coordinate index and rotation waveform based on the archive’s flags.
    /// <code>Offset: 0x00450F70
    /// void __thiscall LM_UVRotate::Serialize(LM_UVRotate*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive instance used for reading or writing the object's data. When bit 0 of m_flags is set, the method writes; otherwise it reads.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVRotate, ACBindings.Internal.Archive*, void>)0x00450F70)(ref this, io_archive);

    /// <summary>Saves the UV rotate modifier settings into a file node hierarchy under the supplied base node for the specified material layer and modifier indices.
    /// <code>Offset: 0x00450FF0
    /// bool __thiscall LM_UVRotate::SaveToFileNode(LM_UVRotate*,PFileNode*,const RenderMaterial*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="baseNode">Parent file node where the modifier data will be added.</param>
    /// <param name="owner">RenderMaterial that owns this modifier.</param>
    /// <param name="layerIndex">Index of the material layer containing the modifier.</param>
    /// <param name="modIndex">Index of the modifier within that layer.</param>
    /// <returns>True (always).</returns>
    public byte SaveToFileNode(ACBindings.Internal.PFileNode* baseNode, ACBindings.Internal.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVRotate, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte>)0x00450FF0)(ref this, baseNode, owner, layerIndex, modIndex);

    /// <summary>Loads UVRotate modifier data from a file node into an LM_UVRotate instance, parsing texCoordIndex and rotate waveform parameters.
    /// <code>Offset: 0x004516D0
    /// bool __thiscall LM_UVRotate::LoadFromFileNode(LM_UVRotate*,const PFileNode*,RenderMaterial*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="baseNode">The root file node that contains the UVRotate settings to be parsed.</param>
    /// <param name="owner">The RenderMaterial object that owns this modifier.</param>
    /// <param name="layerIndex">The index of the layer within the material to which this modifier applies.</param>
    /// <param name="modIndex">The index of the modifier within the specified layer.</param>
    /// <returns>True if all parameters were parsed successfully; otherwise, false.</returns>
    public byte LoadFromFileNode(ACBindings.Internal.PFileNode* baseNode, ACBindings.Internal.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVRotate, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte>)0x004516D0)(ref this, baseNode, owner, layerIndex, modIndex);
}

