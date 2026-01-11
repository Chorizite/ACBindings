namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0044FA30
    /// bool __thiscall MaterialProperty::ReleaseSubObjects(MaterialProperty*)</code>
    /// </summary>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, byte>)0x0044FA30)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044FA50
    /// void __thiscall MaterialProperty::Begin(MaterialProperty*)</code>
    /// </summary>
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, void>)0x0044FA50)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044FAF0
    /// void __thiscall MaterialProperty::Apply(MaterialProperty*,RenderMaterial*,const MaterialProperty*)</code>
    /// </summary>
    public void Apply(ACBindings.Internal.RenderMaterial* material, ACBindings.Internal.MaterialProperty* refProp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, ACBindings.Internal.RenderMaterial*, ACBindings.Internal.MaterialProperty*, void>)0x0044FAF0)(ref this, material, refProp);

    /// <summary>
    /// <code>Offset: 0x0044FD50
    /// bool __thiscall MaterialProperty::GetSubObjects(MaterialProperty*)</code>
    /// </summary>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, byte>)0x0044FD50)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044FE00
    /// void __thiscall MaterialProperty::End(MaterialProperty*)</code>
    /// </summary>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, void>)0x0044FE00)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044FEE0
    /// void __thiscall MaterialProperty::GetSubDataIDs(MaterialProperty*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0044FEE0)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x0044FF20
    /// void __thiscall MaterialProperty::~MaterialProperty(MaterialProperty*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, void>)0x0044FF20)(ref this);

    /// <summary>
    /// <code>Offset: 0x0044FF90
    /// bool __thiscall MaterialProperty::CopyInto(MaterialProperty*,MaterialProperty*)</code>
    /// </summary>
    public byte CopyInto(ACBindings.Internal.MaterialProperty* target) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, ACBindings.Internal.MaterialProperty*, byte>)0x0044FF90)(ref this, target);

    /// <summary>
    /// <code>Offset: 0x00450120
    /// void __thiscall MaterialProperty::Serialize(MaterialProperty*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, ACBindings.Internal.Archive*, void>)0x00450120)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x00450380
    /// MaterialProperty* __thiscall MaterialProperty::Copy(MaterialProperty*)</code>
    /// </summary>
    public ACBindings.Internal.MaterialProperty* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MaterialProperty, ACBindings.Internal.MaterialProperty*>)0x00450380)(ref this);
}

