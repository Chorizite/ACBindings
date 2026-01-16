namespace ACBindings.Internal;


/// <summary>Defines a material property, encapsulating its identifier, data type, raw value, associated fields, and cached texture reference to support shader constants and rendering configurations.</summary>
public unsafe struct MaterialProperty : System.IDisposable
{
    // Members
    public ACBindings.Internal.PStringBase__sbyte name;
    public uint nameID;
    public ACBindings.Internal.RMDataType dataType;
    public uint dataLength;
    public System.IntPtr data;
    public ACBindings.Internal.PStringBase__sbyte dataName;
    public byte m_IsShaderConstant;
    public ACBindings.Internal.SmartArray___MaterialField_ptr fields;
    public ACBindings.Internal.RenderTexture* m_pCachedTexture;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases any cached rendering texture linked to this material property when running in runtime mode.
    /// <code>Offset: 0x0044FA30
    /// bool __thiscall MaterialProperty::ReleaseSubObjects(MaterialProperty*)</code>
    /// </summary>
    /// <returns>True upon completion of the release operation.</returns>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, byte>)0x0044FA30)(ref this);

    /// <summary>Resets a MaterialProperty instance to its default state, clearing all name strings, data references, and cached textures while setting identifiers and type information back to zero or invalid values.
    /// <code>Offset: 0x0044FA50
    /// void __thiscall MaterialProperty::Begin(MaterialProperty*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, void>)0x0044FA50)(ref this);

    /// <summary>Applies the data stored in this MaterialProperty to a specified RenderMaterial according to field definitions supplied by refProp, updating colors, textures, UV transforms, and rendering flags across layers and stages.
    /// <code>Offset: 0x0044FAF0
    /// void __thiscall MaterialProperty::Apply(MaterialProperty*,RenderMaterial*,const MaterialProperty*)</code>
    /// </summary>
    /// <param name="this">The MaterialProperty instance containing the values to be applied.</param>
    /// <param name="material">The RenderMaterial whose layers, stages, and settings will be updated.</param>
    /// <param name="refProp">Reference property defining which fields of the material should receive updates from this property.</param>
    public void Apply(ACBindings.Internal.RenderMaterial* material, ACBindings.Internal.MaterialProperty* refProp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, ACBindings.Internal.RenderMaterial*, ACBindings.Internal.MaterialProperty*, void>)0x0044FAF0)(ref this, material, refProp);

    /// <summary>Retrieves and caches a render texture referenced by this material property. The operation succeeds automatically unless executed during runtime on a texture property whose data identifier cannot be resolved to an existing RenderTexture.
    /// <code>Offset: 0x0044FD50
    /// bool __thiscall MaterialProperty::GetSubObjects(MaterialProperty*)</code>
    /// </summary>
    /// <returns>True if the texture is found or no lookup is required; otherwise false when the texture object cannot be retrieved.</returns>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, byte>)0x0044FD50)(ref this);

    /// <summary>Releases all resources owned by the material property, including its name buffer, data array, cached texture, and field list.
    /// <code>Offset: 0x0044FE00
    /// void __thiscall MaterialProperty::End(MaterialProperty*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, void>)0x0044FE00)(ref this);

    /// <summary>Collects sub-data identifiers from the material property and appends them to the supplied array when the property represents a texture.
    /// <code>Offset: 0x0044FEE0
    /// void __thiscall MaterialProperty::GetSubDataIDs(MaterialProperty*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that receives qualified data IDs of the property’s sub‑data, if any.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0044FEE0)(ref this, id_array);

    /// <summary>Destroys a MaterialProperty instance, releasing its internal data and cached resources.
    /// <code>Offset: 0x0044FF20
    /// void __thiscall MaterialProperty::~MaterialProperty(MaterialProperty*)</code>
    /// </summary>
    /// <param name="this">The MaterialProperty object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, void>)0x0044FF20)(ref this);

    /// <summary>Copies all material property information from the current instance into the specified target instance, performing a deep copy of data buffers and field structures while preserving texture reference counts.
    /// <code>Offset: 0x0044FF90
    /// bool __thiscall MaterialProperty::CopyInto(MaterialProperty*,MaterialProperty*)</code>
    /// </summary>
    /// <param name="target">The MaterialProperty object to receive the copied data.</param>
    /// <returns>True if the copy succeeded; false if an allocation fails or source data is invalid.</returns>
    public byte CopyInto(ACBindings.Internal.MaterialProperty* target) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, ACBindings.Internal.MaterialProperty*, byte>)0x0044FF90)(ref this, target);

    /// <summary>Serializes or deserializes a material property into the specified archive, handling its identifier, type, data payload and associated fields.
    /// <code>Offset: 0x00450120
    /// void __thiscall MaterialProperty::Serialize(MaterialProperty*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive instance used for reading from or writing to persistent storage. The operation performed depends on the archive's mode flags.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, ACBindings.Internal.Archive*, void>)0x00450120)(ref this, io_archive);

    /// <summary>Creates a duplicate of the current material property by allocating a fresh instance and copying all fields.
    /// <code>Offset: 0x00450380
    /// MaterialProperty* __thiscall MaterialProperty::Copy(MaterialProperty*)</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated copy, or null if allocation fails or the copy operation cannot complete.</returns>
    public ACBindings.Internal.MaterialProperty* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, ACBindings.Internal.MaterialProperty*>)0x00450380)(ref this);
}

