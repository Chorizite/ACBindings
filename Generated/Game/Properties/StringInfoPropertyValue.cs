namespace ACBindings;

// StringInfoPropertyValue
public unsafe struct StringInfoPropertyValue
{
    // Base Classes
    public ACBindings.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.BasePropertyValue

    // Members
    public ACBindings.StringInfo m_value;

    // Methods
    // bool __thiscall StringInfoPropertyValue::InqStringInfo(StringInfoPropertyValue*,StringInfo*)
    public byte InqStringInfo(ACBindings.StringInfo* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfoPropertyValue, ACBindings.StringInfo*, byte>)0x00424FE0)(ref this, value);
    // bool __thiscall StringInfoPropertyValue::SetStringInfo(StringInfoPropertyValue*,const StringInfo*)
    public byte SetStringInfo(ACBindings.StringInfo* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfoPropertyValue, ACBindings.StringInfo*, byte>)0x00425000)(ref this, value);
    // bool __thiscall StringInfoPropertyValue::SetValue(StringInfoPropertyValue*,const BasePropertyValue*)
    public byte SetValue(ACBindings.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfoPropertyValue, ACBindings.BasePropertyValue*, byte>)0x00425020)(ref this, value);
    // BasePropertyValue* __thiscall StringInfoPropertyValue::Copy(StringInfoPropertyValue*)
    public ACBindings.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfoPropertyValue, ACBindings.BasePropertyValue*>)0x00425120)(ref this);
    // void __thiscall StringInfoPropertyValue::Serialize(StringInfoPropertyValue*,Archive*,const unsigned int)
    public void Serialize(ACBindings.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfoPropertyValue, ACBindings.Archive*, uint, void>)0x00425160)(ref this, io_archive, i_eName);
    // bool __thiscall StringInfoPropertyValue::HasValidData(StringInfoPropertyValue*)
    public byte HasValidData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfoPropertyValue, byte>)0x004261D0)(ref this);
    // bool __thiscall StringInfoPropertyValue::Compare(StringInfoPropertyValue*,const BasePropertyValue*)
    public byte Compare(ACBindings.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfoPropertyValue, ACBindings.BasePropertyValue*, byte>)0x004261F0)(ref this, p);
    // bool __thiscall StringInfoPropertyValue::FromFileNode(StringInfoPropertyValue*,const BasePropertyDesc*,const PFileNode*)
    public byte FromFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfoPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00427BB0)(ref this, desc, node);
    // bool __thiscall StringInfoPropertyValue::ToFileNode(StringInfoPropertyValue*,const BasePropertyDesc*,PFileNode*)
    public byte ToFileNode(ACBindings.BasePropertyDesc* desc, ACBindings.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfoPropertyValue, ACBindings.BasePropertyDesc*, ACBindings.PFileNode*, byte>)0x00427CF0)(ref this, desc, node);
    // char __thiscall StringInfoPropertyValue::GetValueAsString(int,int,char**,const char*)
    public sbyte GetValueAsString(int a2, sbyte** a3, sbyte* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.StringInfoPropertyValue, int, sbyte**, sbyte*, sbyte>)0x00427D40)(ref this, a2, a3, a4);
}

