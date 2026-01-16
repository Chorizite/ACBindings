namespace ACBindings.Internal;


/// <summary>LayerStage encapsulates texture sampling configuration and associated resources for a rendering pipeline stage. It stores sampler name, texture file path, identifiers, address modes, filter modes, and color/alpha operations used during rendering.</summary>
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

    /// <summary>Releases the texture associated with a LayerStage instance by stopping its usage and freeing the resource.
    /// <code>Offset: 0x00447F60
    /// bool __thiscall LayerStage::ReleaseSubObjects(LayerStage*)</code>
    /// </summary>
    /// <returns>True after successfully releasing the sub‑objects.</returns>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, byte>)0x00447F60)(ref this);

    /// <summary>Reinitializes the LayerStage instance by releasing current sampler and texture names, resetting identifiers and texture parameters to their default values.
    /// <code>Offset: 0x00447F70
    /// void __thiscall LayerStage::Begin(LayerStage*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, void>)0x00447F70)(ref this);

    /// <summary>Copies all member data from the current LayerStage instance to another, optionally handling string references based on IsInstance flag.
    /// <code>Offset: 0x00448040
    /// bool __thiscall LayerStage::CopyInto(LayerStage*,const bool,LayerStage*)</code>
    /// </summary>
    /// <param name="IsInstance">When false, copies sampler and texture filename strings; when true, preserves existing target values for these fields.</param>
    /// <param name="target">The LayerStage object that will receive the copied data.</param>
    /// <returns>True after copying.</returns>
    public byte CopyInto(byte IsInstance, ACBindings.Internal.LayerStage* target) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, byte, ACBindings.Internal.LayerStage*, byte>)0x00448040)(ref this, IsInstance, target);

    /// <summary>Sets the main texture pointer to a new RenderTexture, updates reference counts, and assigns a secondary texture identifier while validating it against available resources.
    /// <code>Offset: 0x00448140
    /// char __thiscall LayerStage::SetTexture(RenderTexture**,RenderTexture**,int)</code>
    /// </summary>
    /// <param name="a2">Address of the RenderTexture to be used as the primary texture for this layer stage.</param>
    /// <param name="a3">Integer ID of an optional secondary texture; passing INVALID_DID_36.baseclass_0.id clears the secondary texture reference.</param>
    /// <returns>1 if the textures were successfully assigned and any supplied identifier resolved, otherwise 0.</returns>
    public sbyte SetTexture(ACBindings.Internal.RenderTexture** a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, ACBindings.Internal.RenderTexture**, int, sbyte>)0x00448140)(ref this, a2, a3);

    /// <summary>Assigns a RenderTexture to the layer stage, updating internal references and releasing any previously bound texture.
    /// <code>Offset: 0x00448200
    /// bool __thiscall LayerStage::SetTexture(LayerStage*,RenderTexture*)</code>
    /// </summary>
    /// <param name="pNewTexture">The RenderTexture to associate with this stage; if null clears the current texture reference.</param>
    /// <returns>True indicating that the operation succeeded (always returns true).</returns>
    public byte SetTexture(ACBindings.Internal.RenderTexture* pNewTexture) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, ACBindings.Internal.RenderTexture*, byte>)0x00448200)(ref this, pNewTexture);

    /// <summary>Initializes a LayerStage instance by setting its sampler name and texture file name to empty strings, updating reference counts for the shared string buffer, and preparing the stage via Begin.
    /// <code>Offset: 0x00448350
    /// void __thiscall LayerStage::LayerStage(LayerStage*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, void>)0x00448350)(ref this);

    /// <summary>Destroys a LayerStage instance, releasing its associated texture and decrementing the reference counts for the sampler and texture filenames.
    /// <code>Offset: 0x00448390
    /// void __thiscall LayerStage::~LayerStage(LayerStage*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, void>)0x00448390)(ref this);

    /// <summary>
    /// Creates a duplicate of the current LayerStage object, allocating a new instance and initializing its string members to null buffers before copying all fields from the source. If the copy operation succeeds, returns a pointer to the newly created LayerStage; otherwise returns nullptr.
    /// 
    /// <code>Offset: 0x004483F0
    /// LayerStage* __thiscall LayerStage::Copy(LayerStage*,const bool)</code>
    /// </summary>
    /// <param name="IsInstance">Specifies whether the copy should treat certain resources as instance-specific (e.g., duplicate textures) or share them with the original.</param>
    /// <returns>Pointer to the newly created LayerStage on success; null if allocation fails or copying fails.</returns>
    public ACBindings.Internal.LayerStage* Copy(byte IsInstance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, byte, ACBindings.Internal.LayerStage*>)0x004483F0)(ref this, IsInstance);

    /// <summary>Ensures the layer stage has a valid texture by assigning it from its stored texture ID and file name, handling reference counting for the underlying RenderTexture object, and returning true if the texture is already present or successfully set.
    /// <code>Offset: 0x00448460
    /// bool __thiscall LayerStage::GetSubObjects(LayerStage*)</code>
    /// </summary>
    /// <returns>true when the texture is already valid or was successfully assigned; otherwise false.</returns>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, byte>)0x00448460)(ref this);

    /// <summary>
    /// Serializes the LayerStage's texture and filtering configuration, including IDs, addressing modes, filter settings, color/alpha operations, and projection usage, to or from an Archive object.
    /// 
    /// <code>Offset: 0x004484E0
    /// void __thiscall LayerStage::Serialize(LayerStage*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for reading or writing serialized data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LayerStage, ACBindings.Internal.Archive*, void>)0x004484E0)(ref this, io_archive);
}

