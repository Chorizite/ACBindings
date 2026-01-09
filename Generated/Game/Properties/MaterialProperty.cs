namespace ACBindings;

// MaterialProperty
public unsafe struct MaterialProperty : System.IDisposable
{
    // Members
    public ACBindings.PStringBase__sbyte name;
    public uint nameID;
    public ACBindings.RMDataType dataType;
    public uint dataLength;
    public System.IntPtr data;
    public ACBindings.PStringBase__sbyte dataName;
    public byte m_IsShaderConstant;
    public ACBindings.SmartArray__MaterialField_ptr fields;
    public ACBindings.RenderTexture* m_pCachedTexture;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall MaterialProperty::ReleaseSubObjects(MaterialProperty*)
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialProperty, byte>)0x0044FA30)(ref this);
    // void __thiscall MaterialProperty::Begin(MaterialProperty*)
    public void Begin() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialProperty, void>)0x0044FA50)(ref this);
    // void __thiscall MaterialProperty::Apply(MaterialProperty*,RenderMaterial*,const MaterialProperty*)
    public void Apply(ACBindings.RenderMaterial* material, ACBindings.MaterialProperty* refProp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialProperty, ACBindings.RenderMaterial*, ACBindings.MaterialProperty*, void>)0x0044FAF0)(ref this, material, refProp);
    // bool __thiscall MaterialProperty::GetSubObjects(MaterialProperty*)
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialProperty, byte>)0x0044FD50)(ref this);
    // void __thiscall MaterialProperty::End(MaterialProperty*)
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialProperty, void>)0x0044FE00)(ref this);
    // void __thiscall MaterialProperty::GetSubDataIDs(MaterialProperty*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialProperty, ACBindings.QualifiedDataIDArray*, void>)0x0044FEE0)(ref this, id_array);
    // void __thiscall MaterialProperty::~MaterialProperty(MaterialProperty*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialProperty, void>)0x0044FF20)(ref this);
    // bool __thiscall MaterialProperty::CopyInto(MaterialProperty*,MaterialProperty*)
    public byte CopyInto(ACBindings.MaterialProperty* target) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialProperty, ACBindings.MaterialProperty*, byte>)0x0044FF90)(ref this, target);
    // void __thiscall MaterialProperty::Serialize(MaterialProperty*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialProperty, ACBindings.Archive*, void>)0x00450120)(ref this, io_archive);
    // MaterialProperty* __thiscall MaterialProperty::Copy(MaterialProperty*)
    public ACBindings.MaterialProperty* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MaterialProperty, ACBindings.MaterialProperty*>)0x00450380)(ref this);
}

