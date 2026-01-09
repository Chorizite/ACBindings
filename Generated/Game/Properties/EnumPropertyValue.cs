namespace ACBindings;

// EnumPropertyValue
public unsafe struct EnumPropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public uint m_value;

    // Methods
    // int __thiscall EnumPropertyValue::HasValidData(MetaSpell*)
    public int HasValidData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumPropertyValue, int>)0x00424150)(ref this);
    // bool __thiscall EnumPropertyValue::SetValue(EnumPropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00424160)(ref this, value);
    // bool __thiscall EnumPropertyValue::Compare(EnumPropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00424180)(ref this, p);
    // BasePropertyValue* __thiscall EnumPropertyValue::Copy(EnumPropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumPropertyValue, ACBindings.BasePropertyValue*>)0x00424220)(ref this);
    // void __thiscall EnumPropertyValue::Serialize(StringTokenPropertyValue*,Archive*,const unsigned int)
    public void Serialize(ACBindings.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumPropertyValue, ACBindings.Archive*, uint, void>)0x004266F0)(ref this, io_archive, i_eName);
    // bool __thiscall EnumPropertyValue::FromFileNode(EnumPropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x0042B600)(ref this, desc, node);
    // bool __thiscall EnumPropertyValue::ToFileNode(EnumPropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x0042B770)(ref this, desc, node);
    // char __thiscall EnumPropertyValue::GetValueAsString(int*,_DWORD*,char**,char)
    public sbyte GetValueAsString(int* a2, sbyte** a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.EnumPropertyValue, int*, sbyte**, sbyte, sbyte>)0x0042B860)(ref this, a2, a3, a4);
}

