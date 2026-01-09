namespace ACBindings;

// InstanceIDPropertyValue
public unsafe struct InstanceIDPropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public uint m_value;

    // Methods
    // bool __thiscall InstanceIDPropertyValue::SetValue(InstanceIDPropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InstanceIDPropertyValue, ACBindings.BasePropertyValue*, byte>)0x004245C0)(ref this, value);
    // bool __thiscall InstanceIDPropertyValue::Compare(InstanceIDPropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InstanceIDPropertyValue, ACBindings.BasePropertyValue*, byte>)0x004245E0)(ref this, p);
    // BasePropertyValue* __thiscall InstanceIDPropertyValue::Copy(InstanceIDPropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InstanceIDPropertyValue, ACBindings.BasePropertyValue*>)0x00424620)(ref this);
    // bool __thiscall InstanceIDPropertyValue::ToFileNode(InstanceIDPropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InstanceIDPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00425CD0)(ref this, desc, node);
    // bool __thiscall InstanceIDPropertyValue::FromFileNode(InstanceIDPropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InstanceIDPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00426D70)(ref this, desc, node);
    // char __thiscall InstanceIDPropertyValue::GetValueAsString(_DWORD*,int,char**,int)
    public sbyte GetValueAsString(int a2, sbyte** a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InstanceIDPropertyValue, int, sbyte**, int, sbyte>)0x004276F0)(ref this, a2, a3, a4);
}

