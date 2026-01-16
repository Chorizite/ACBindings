namespace ACBindings.Internal;


/// <summary>UV translation modifier applied to a material layer, storing the target texture coordinate set and per‑axis waveforms that drive time‑dependent U and V offsets.</summary>
public unsafe struct LM_UVTranslate
{
    // Base Classes
    public ACBindings.Internal.LayerModifier BaseClass_LayerModifier; // ACBindings.Internal.LayerModifier

    // Child Types
    public unsafe struct LM_UVTranslate_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, ACBindings.Internal.LayerModType> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, uint> GetTCIndex; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, uint> GetSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, byte> DoesModifyVertex; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, ACBindings.Internal.LayerModifier*> Copy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, System.IntPtr, ACBindings.Internal.VertexFormatInfo*, void> Apply; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, ACBindings.Internal.Matrix4*, void> ApplyTextureTransform; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> LoadFromFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.LM_UVTranslate*, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte> SaveToFileNode; // function pointer

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

    /// <summary>Copies the supplied waveform into the UV modifier's U‑translation parameters.
    /// <code>Offset: 0x0044F8D0
    /// void __thiscall LM_UVTranslate::SetUTranslate(LM_UVScale*,const Waveform*)</code>
    /// </summary>
    /// <param name="uScale">Waveform defining the U‑coordinate translation behavior.</param>
    public void SetUTranslate(ACBindings.Internal.Waveform* uScale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, ACBindings.Internal.Waveform*, void>)0x0044F8D0)(ref this, uScale);

    /// <summary>Assigns a new waveform to the V‑scale component of an LM_UVScale instance, overriding any existing definition.
    /// <code>Offset: 0x0044F920
    /// void __thiscall LM_UVTranslate::SetVTranslate(LM_UVScale*,const Waveform*)</code>
    /// </summary>
    /// <param name="vScale">The waveform that specifies how the V coordinate should be scaled over time.</param>
    public void SetVTranslate(ACBindings.Internal.Waveform* vScale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, ACBindings.Internal.Waveform*, void>)0x0044F920)(ref this, vScale);

    /// <summary>Initializes an LM_UVTranslate instance by assigning its base class virtual table, resetting the texture coordinate index to zero, and constructing default U and V translation waveforms.
    /// <code>Offset: 0x004507E0
    /// void __thiscall LM_UVTranslate::LM_UVTranslate(LM_UVTranslate*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, void>)0x004507E0)(ref this);

    /// <summary>Returns the fixed byte size of an LM_UVTranslate instance.
    /// <code>Offset: 0x00450820
    /// unsigned int __thiscall LM_UVTranslate::GetSize(LM_UVScale*)</code>
    /// </summary>
    /// <returns>The value 96, indicating the object's size in bytes.</returns>
    public uint GetSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, uint>)0x00450820)(ref this);

    /// <summary>Applies a time‑dependent translation to the supplied texture matrix based on the object's u and v waveform values.
    /// <code>Offset: 0x00450830
    /// void __thiscall LM_UVTranslate::ApplyTextureTransform(LM_UVTranslate*,Matrix4*)</code>
    /// </summary>
    /// <param name="mTextureMatrix">The texture transformation matrix that will be modified in place to include the calculated translation.</param>
    public void ApplyTextureTransform(ACBindings.Internal.Matrix4* mTextureMatrix) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, ACBindings.Internal.Matrix4*, void>)0x00450830)(ref this, mTextureMatrix);

    /// <summary>Copies the current UV translate modifier, allocating a new instance that replicates its settings and returns it as a LayerModifier pointer.
    /// <code>Offset: 0x00450C50
    /// LayerModifier* __thiscall LM_UVTranslate::Copy(LM_UVTranslate*)</code>
    /// </summary>
    /// <returns>A pointer to the newly created modifier; null if memory allocation fails.</returns>
    public ACBindings.Internal.LayerModifier* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, ACBindings.Internal.LayerModifier*>)0x00450C50)(ref this);

    /// <summary>Serializes or deserializes the object's type identifier, texture coordinate index, and its uScale and vScale waveforms to or from an Archive.
    /// <code>Offset: 0x00450CB0
    /// void __thiscall LM_UVTranslate::Serialize(LM_UVScale*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for reading or writing. Data is written when archive flags indicate write mode; otherwise it reads data into the object.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, ACBindings.Internal.Archive*, void>)0x00450CB0)(ref this, io_archive);

    /// <summary>Saves the UV translation settings of this object into a hierarchical file node structure under <paramref name="baseNode"/>, using information from the owner material for optional output fields. Writes child nodes for texture coordinate index, translation data (uTranslate and vTranslate), and conditionally outputs existing values or waveform data based on RenderMaterial's CheckOutputField.
    /// <code>Offset: 0x00450D20
    /// bool __thiscall LM_UVTranslate::SaveToFileNode(LM_UVTranslate*,PFileNode*,const RenderMaterial*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="baseNode">The root file node to which UV translation data will be appended.</param>
    /// <param name="owner">Material that may provide pre-existing output fields for the translation.</param>
    /// <param name="layerIndex">Layer index within the material for which the data applies.</param>
    /// <param name="modIndex">Modifier index used when querying the material's output fields.</param>
    /// <returns>True on successful serialization of UV translation data into the file node hierarchy.</returns>
    public byte SaveToFileNode(ACBindings.Internal.PFileNode* baseNode, ACBindings.Internal.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte>)0x00450D20)(ref this, baseNode, owner, layerIndex, modIndex);

    /// <summary>Parses a file node describing UV translation modifiers and applies them to this instance, updating the texture coordinate index and waveform translations for the specified layer and modifier.
    /// <code>Offset: 0x004514A0
    /// bool __thiscall LM_UVTranslate::LoadFromFileNode(LM_UVTranslate*,const PFileNode*,RenderMaterial*,const unsigned int,const unsigned int)</code>
    /// </summary>
    /// <param name="baseNode">Root file node containing UVTranslate child elements.</param>
    /// <param name="owner">RenderMaterial owning the material layers affected by the translation.</param>
    /// <param name="layerIndex">Zero‑based index of the target material layer.</param>
    /// <param name="modIndex">Zero‑based modifier index within that layer.</param>
    /// <returns>True if parsing and application succeeded; otherwise false, with errors reported for invalid keywords.</returns>
    public byte LoadFromFileNode(ACBindings.Internal.PFileNode* baseNode, ACBindings.Internal.RenderMaterial* owner, uint layerIndex, uint modIndex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LM_UVTranslate, ACBindings.Internal.PFileNode*, ACBindings.Internal.RenderMaterial*, uint, uint, byte>)0x004514A0)(ref this, baseNode, owner, layerIndex, modIndex);
}

