namespace ACBindings;

// ArrayPropertyValue
public unsafe struct ArrayPropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public ACBindings.SmartArray__BaseProperty m_value;

    // Methods
    // bool __thiscall ArrayPropertyValue::InqArrayNumElements(ArrayPropertyValue*,unsigned int*)
    public byte InqArrayNumElements(uint* num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArrayPropertyValue, uint*, byte>)0x004269A0)(ref this, num);
    // bool __thiscall ArrayPropertyValue::InqArrayElement(ArrayPropertyValue*,const unsigned int,BaseProperty*)
    public byte InqArrayElement(uint index, ACBindings.BaseProperty* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArrayPropertyValue, uint, ACBindings.BaseProperty*, byte>)0x00426B20)(ref this, index, value);
    // const BaseProperty* __thiscall ArrayPropertyValue::GetArrayElement(ArrayPropertyValue*,const unsigned int)
    public ACBindings.BaseProperty* GetArrayElement(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArrayPropertyValue, uint, ACBindings.BaseProperty*>)0x00426B50)(ref this, index);
    // bool __thiscall ArrayPropertyValue::SetValue(ArrayPropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArrayPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00427510)(ref this, value);
    // BasePropertyValue* __thiscall ArrayPropertyValue::Copy(ArrayPropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArrayPropertyValue, ACBindings.BasePropertyValue*>)0x00428260)(ref this);
    // void __thiscall ArrayPropertyValue::Serialize(ArrayPropertyValue*,Archive*,const unsigned int)
    public void Serialize(ACBindings.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArrayPropertyValue, ACBindings.Archive*, uint, void>)0x004282C0)(ref this, io_archive, i_eName);
    // bool __thiscall ArrayPropertyValue::SetArrayElement(ArrayPropertyValue*,const unsigned int,const BaseProperty*)
    public byte SetArrayElement(uint index, ACBindings.BaseProperty* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArrayPropertyValue, uint, ACBindings.BaseProperty*, byte>)0x00428420)(ref this, index, value);
    // void __thiscall ArrayPropertyValue::PushArrayElement(ArrayPropertyValue*,const BaseProperty*)
    public void PushArrayElement(ACBindings.BaseProperty* i_rcElement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArrayPropertyValue, ACBindings.BaseProperty*, void>)0x00428780)(ref this, i_rcElement);
    // bool __thiscall ArrayPropertyValue::ToFileNode(ArrayPropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArrayPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x0042B900)(ref this, desc, node);
    // bool __thiscall ArrayPropertyValue::Compare(ArrayPropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArrayPropertyValue, ACBindings.BasePropertyValue*, byte>)0x0042B9D0)(ref this, p);
    // bool __thiscall ArrayPropertyValue::SwapArrayElements(ArrayPropertyValue*,const unsigned int,const unsigned int)
    public byte SwapArrayElements(uint index1, uint index2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArrayPropertyValue, uint, uint, byte>)0x0042BA40)(ref this, index1, index2);
    // char __thiscall ArrayPropertyValue::GetValueAsString(_DWORD*,int,char**,char)
    public sbyte GetValueAsString(int a2, sbyte** a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArrayPropertyValue, int, sbyte**, sbyte, sbyte>)0x0042BA60)(ref this, a2, a3, a4);
    // bool __thiscall ArrayPropertyValue::FromFileNode(ArrayPropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArrayPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x0042BAA0)(ref this, desc, node);
}

