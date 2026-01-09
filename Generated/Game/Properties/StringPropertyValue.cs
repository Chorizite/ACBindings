namespace ACBindings;

// StringPropertyValue
public unsafe struct StringPropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public ACBindings.PStringBase__sbyte m_value;

    // Methods
    // bool __thiscall StringPropertyValue::SetValue(StringPropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringPropertyValue, ACBindings.BasePropertyValue*, byte>)0x004262E0)(ref this, value);
    // bool __thiscall StringPropertyValue::HasValidData(StringPropertyValue*)
    public byte HasValidData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringPropertyValue, byte>)0x00426300)(ref this);
    // BasePropertyValue* __thiscall StringPropertyValue::Copy(StringPropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringPropertyValue, ACBindings.BasePropertyValue*>)0x00426320)(ref this);
    // bool __thiscall StringPropertyValue::FromFileNode(StringPropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00426360)(ref this, desc, node);
    // char __thiscall StringPropertyValue::InqString(LONG*,LONG*)
    public sbyte InqString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringPropertyValue, int*, sbyte>)0x00426390)(ref this, a2);
    // char __thiscall StringPropertyValue::SetString(LONG*,LONG*)
    public sbyte SetString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringPropertyValue, int*, sbyte>)0x004263B0)(ref this, a2);
    // char __thiscall StringPropertyValue::GetValueAsString(LONG*,int,LONG*,int)
    public sbyte GetValueAsString(int a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringPropertyValue, int, int*, int, sbyte>)0x004263D0)(ref this, a2, a3, a4);
    // bool __thiscall StringPropertyValue::Compare(StringPropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringPropertyValue, ACBindings.BasePropertyValue*, byte>)0x004263F0)(ref this, p);
    // bool __thiscall StringPropertyValue::ToFileNode(StringPropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00426F50)(ref this, desc, node);
    // void __thiscall StringPropertyValue::Serialize(StringPropertyValue*,Archive*,const unsigned int)
    public void Serialize(ACBindings.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringPropertyValue, ACBindings.Archive*, uint, void>)0x00427F40)(ref this, io_archive, i_eName);
}

