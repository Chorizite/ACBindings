namespace ACBindings;

// BaseProperty
public unsafe struct BaseProperty : System.IDisposable
{
    // Members
    public ACBindings.BasePropertyDesc* m_pcPropertyDesc;
    public ACBindings.BasePropertyValue* m_pcPropertyValue;

    // Generated Constructor
    public BaseProperty() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall BaseProperty::BaseProperty(BaseProperty*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, void>)0x004175F0)(ref this);
    // void __thiscall BaseProperty::~BaseProperty(BaseProperty*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, void>)0x004234D0)(ref this);
    // bool __thiscall BaseProperty::InqEnum(BaseProperty*,unsigned int*)
    public byte InqEnum(uint* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, uint*, byte>)0x00429940)(ref this, value);
    // bool __thiscall BaseProperty::IsClientOnlyData(BaseProperty*)
    public byte IsClientOnlyData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, byte>)0x00429960)(ref this);
    // bool __thiscall BaseProperty::IsServerOnlyData(BaseProperty*)
    public byte IsServerOnlyData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, byte>)0x00429980)(ref this);
    // bool __thiscall BaseProperty::IsToolOnly(BaseProperty*)
    public byte IsToolOnly() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, byte>)0x004299A0)(ref this);
    // bool __thiscall BaseProperty::Compare(BaseProperty*,const BaseProperty*)
    public byte Compare(ACBindings.BaseProperty* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, ACBindings.BaseProperty*, byte>)0x004299B0)(ref this, p);
    // unsigned int __thiscall BaseProperty::GetPropertyName(BaseProperty*)
    public uint GetPropertyName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, uint>)0x00429A00)(ref this);
    // unsigned int __thiscall BaseProperty::GetGroupName(BaseProperty*)
    public uint GetGroupName() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, uint>)0x00429A10)(ref this);
    // char __thiscall BaseProperty::InqPropertyName(void*,volatile LONG**)
    public sbyte InqPropertyName(int** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, int**, sbyte>)0x00429A20)(ref this, a2);
    // void __thiscall BaseProperty::CheckCopyOnWrite(BaseProperty*)
    public void CheckCopyOnWrite() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, void>)0x00429B10)(ref this);
    // bool __thiscall BaseProperty::SetFloat(BaseProperty*,const float)
    public byte SetFloat(float value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, float, byte>)0x00429B80)(ref this, value);
    // bool __thiscall BaseProperty::SetEnum(BaseProperty*,const unsigned int)
    public byte SetEnum(uint value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, uint, byte>)0x00429BC0)(ref this, value);
    // bool __thiscall BaseProperty::SetStringInfo(BaseProperty*,const StringInfo*)
    public byte SetStringInfo(ACBindings.StringInfo* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, ACBindings.StringInfo*, byte>)0x00429C00)(ref this, value);
    // void __thiscall BaseProperty::GetSubDataIDs(BaseProperty*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, ACBindings.QualifiedDataIDArray*, void>)0x00429CE0)(ref this, id_array);
    // bool __thiscall BaseProperty::ToFileNode(BaseProperty*,PFileNode*)
    public byte ToFileNode(ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, ACBindings.PFileNode*, byte>)0x00429EA0)(ref this, node);
    // bool __thiscall BaseProperty::ValueFromFileNode(BaseProperty*,const PFileNode*)
    public byte ValueFromFileNode(ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, ACBindings.PFileNode*, byte>)0x00429F40)(ref this, node);
    // bool __thiscall BaseProperty::InitToDefaultValue(BaseProperty*)
    public byte InitToDefaultValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, byte>)0x0042A1C0)(ref this);
    // bool __thiscall BaseProperty::SetPropertyDesc(BaseProperty*,BasePropertyDesc*)
    public byte SetPropertyDesc(ACBindings.BasePropertyDesc* i_pcDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, ACBindings.BasePropertyDesc*, byte>)0x0042A280)(ref this, i_pcDesc);
    // bool __thiscall BaseProperty::SetPropertyName(BaseProperty*,const unsigned int)
    public byte SetPropertyName(uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, uint, byte>)0x0042A2D0)(ref this, i_eName);
    // void __thiscall BaseProperty::Serialize(BaseProperty*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, ACBindings.Archive*, void>)0x0042A330)(ref this, io_archive);
    // bool __thiscall BaseProperty::FromFileNode(BaseProperty*,const PFileNode*)
    public byte FromFileNode(ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BaseProperty, ACBindings.PFileNode*, byte>)0x0042A420)(ref this, node);
}

